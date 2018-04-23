using System.Windows.Forms;
using DevExpress.XtraEditors;
using System;

namespace WindowsFormsApplication3
{
    public partial class Form1 : XtraForm, IHelpOwner
    {
        HelpHelper helper;
        public Form1()
        {
            this.helper = new HelpHelper(this);
            InitializeComponent();
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Text += "1";
            this.helper.SetHelpRequested();
            Control control = this.GetChildAtPoint(this.PointToClient(hlpevent.MousePos));
            XtraMessageBox.Show(String.Format("Help requested for {0}", control.Name));
        }
        protected override void WndProc(ref Message msg) {
            if (helper.DoWndProc(ref msg)) return;
            base.WndProc(ref msg);
        }
        #region IHelpOwner Members
        void IHelpOwner.DoBaseWndProc(ref Message msg) {
            base.WndProc(ref msg);
        }
        void IHelpOwner.DoHelpRequested() {
            OnHelpRequested(new HelpEventArgs(MousePosition));
        }
        Control IHelpOwner.Control { get { return this; } }

        #endregion
    }
}
