Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.Utils.Drawing.Helpers

Namespace WindowsFormsApplication3
	Public Interface IHelpOwner
		Sub DoBaseWndProc(ByRef msg As Message)
		Sub DoHelpRequested()
		ReadOnly Property Control() As Control
	End Interface
	Public Class HelpHelper
		Private owner As IHelpOwner
		Private helpRequested As Boolean = False
		Public Sub New(ByVal owner As IHelpOwner)
            Me.owner = owner
		End Sub
		Public Function DoWndProc(ByRef message As Message) As Boolean
            If message.Msg = MSG.WM_NCLBUTTONDOWN Then
                Dim pt As New Point(message.LParam.ToInt32())
                'Console.WriteLine(string.Format("{0}, {1}", msg.WParam, pt.ToString()));
                If message.WParam.ToInt32() = DevExpress.Utils.Drawing.Helpers.NativeMethods.HT.HTHELP Then
                    Me.helpRequested = False
                    owner.DoBaseWndProc(message)
                    Return True
                End If
            End If
            If message.Msg = &H210 AndAlso message.WParam.ToInt32() = MSG.WM_LBUTTONDOWN Then
                If message.Msg = &H210 AndAlso message.WParam.ToInt32() = MSG.WM_LBUTTONDOWN Then
                    If (Not helpRequested) Then
                        owner.Control.BeginInvoke(New MethodInvoker(AddressOf CheckShowHelp))
                    End If
                End If
            End If
            Return False
        End Function
		Private Sub CheckShowHelp()
			If (Not helpRequested) Then
				Me.helpRequested = True
				owner.DoHelpRequested()
			End If
		End Sub
		Public Sub SetHelpRequested()
			Me.helpRequested = True
		End Sub
	End Class
End Namespace
