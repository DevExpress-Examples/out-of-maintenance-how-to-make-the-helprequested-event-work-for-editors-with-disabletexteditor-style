Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(12, 31)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(260, 20)
			Me.comboBoxEdit1.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(69, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "ComboBoxEdit"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 57)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(99, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "ImageComboBoxEdit"
			' 
			' imageComboBoxEdit1
			' 
			Me.imageComboBoxEdit1.Location = New System.Drawing.Point(11, 76)
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit1.Size = New System.Drawing.Size(261, 20)
			Me.imageComboBoxEdit1.TabIndex = 3
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(105, 229)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(11, 121)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(261, 20)
			Me.textEdit1.TabIndex = 5
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(11, 102)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(40, 13)
			Me.labelControl3.TabIndex = 6
			Me.labelControl3.Text = "TextEdit"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(12, 166)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(260, 20)
			Me.dateEdit1.TabIndex = 7
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(11, 147)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(41, 13)
			Me.labelControl4.TabIndex = 8
			Me.labelControl4.Text = "DateEdit"
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(13, 193)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "checkEdit1"
			Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
			Me.checkEdit1.TabIndex = 9
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.dateEdit1)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.imageComboBoxEdit1)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.HelpButton = True
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
'			Me.HelpRequested += New System.Windows.Forms.HelpEventHandler(Me.Form1_HelpRequested);
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

