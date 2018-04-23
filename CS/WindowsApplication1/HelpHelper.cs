using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils.Drawing.Helpers;

namespace WindowsFormsApplication3 {
    public interface IHelpOwner {
        void DoBaseWndProc(ref Message msg);
        void DoHelpRequested();
        Control Control { get; }
    }
    public class HelpHelper {
        IHelpOwner owner;
        bool helpRequested = false;
        public HelpHelper(IHelpOwner owner) {
            this.owner = owner;
        }
        public bool DoWndProc(ref Message msg) {
            if (msg.Msg == MSG.WM_NCLBUTTONDOWN) {
                Point pt = new Point(msg.LParam.ToInt32());
                //Console.WriteLine(string.Format("{0}, {1}", msg.WParam, pt.ToString()));
                if (msg.WParam.ToInt32() == DevExpress.Utils.Drawing.Helpers.NativeMethods.HT.HTHELP) {
                    this.helpRequested = false;
                    owner.DoBaseWndProc(ref msg);
                    return true;
                }
            }
            if (msg.Msg == 0x210/*wm_parentnotify*/ && msg.WParam.ToInt32() == MSG.WM_LBUTTONDOWN) {
                if (!helpRequested) {
                    owner.Control.BeginInvoke(new MethodInvoker(CheckShowHelp));
                }
            }
            return false;
        }
        void CheckShowHelp() {
            if (!helpRequested) {
                this.helpRequested = true;
                owner.DoHelpRequested();
            }
        }
        public void SetHelpRequested() { this.helpRequested = true; }
    }
}
