Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System

Namespace WindowsFormsApplication3
	Partial Public Class Form1
		Inherits XtraForm
		Implements IHelpOwner
		Private helpHelper As HelpHelper
		Public Sub New()
			Me.helpHelper = New HelpHelper(Me)
			InitializeComponent()
		End Sub

		Private Sub Form1_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
			Text &= "1"
			Me.helpHelper.SetHelpRequested()
			Dim control As Control = Me.GetChildAtPoint(Me.PointToClient(hlpevent.MousePos))
			XtraMessageBox.Show(String.Format("Help requested for {0}", control.Name))
		End Sub
		Protected Overrides Sub WndProc(ByRef msg As Message)
			If helpHelper.DoWndProc(msg) Then
				Return
			End If
			MyBase.WndProc(msg)
		End Sub
		#Region "IHelpOwner Members"
		Private Sub DoBaseWndProc(ByRef msg As Message) Implements IHelpOwner.DoBaseWndProc
			MyBase.WndProc(msg)
		End Sub
		Private Sub DoHelpRequested() Implements IHelpOwner.DoHelpRequested
			OnHelpRequested(New HelpEventArgs(MousePosition))
		End Sub
		Private ReadOnly Property IHelpOwner_Control() As Control Implements IHelpOwner.Control
			Get
				Return Me
			End Get
		End Property

		#End Region
	End Class
End Namespace
