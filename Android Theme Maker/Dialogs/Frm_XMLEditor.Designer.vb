﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_XMLEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_APPLY = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_CANcEL = New VIBlend.WinForms.Controls.vButton()
        Me.TextEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_APPLY
        '
        Me.BTN_APPLY.AllowAnimations = True
        Me.BTN_APPLY.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APPLY.Location = New System.Drawing.Point(361, 141)
        Me.BTN_APPLY.Name = "BTN_APPLY"
        Me.BTN_APPLY.RoundedCornersMask = CType(15, Byte)
        Me.BTN_APPLY.Size = New System.Drawing.Size(86, 25)
        Me.BTN_APPLY.TabIndex = 0
        Me.BTN_APPLY.Text = "Apply"
        Me.BTN_APPLY.UseVisualStyleBackColor = False
        Me.BTN_APPLY.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'BTN_CANcEL
        '
        Me.BTN_CANcEL.AllowAnimations = True
        Me.BTN_CANcEL.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CANcEL.Location = New System.Drawing.Point(453, 141)
        Me.BTN_CANcEL.Name = "BTN_CANcEL"
        Me.BTN_CANcEL.RoundedCornersMask = CType(15, Byte)
        Me.BTN_CANcEL.Size = New System.Drawing.Size(86, 25)
        Me.BTN_CANcEL.TabIndex = 1
        Me.BTN_CANcEL.Text = "Cancel"
        Me.BTN_CANcEL.UseVisualStyleBackColor = False
        Me.BTN_CANcEL.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'TextEdit
        '
        Me.TextEdit.Location = New System.Drawing.Point(44, 12)
        Me.TextEdit.MaxLength = 9999999
        Me.TextEdit.Multiline = True
        Me.TextEdit.Name = "TextEdit"
        Me.TextEdit.Size = New System.Drawing.Size(470, 123)
        Me.TextEdit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Text:"
        '
        'Frm_XMLEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 169)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEdit)
        Me.Controls.Add(Me.BTN_CANcEL)
        Me.Controls.Add(Me.BTN_APPLY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_XMLEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_APPLY As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_CANcEL As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TextEdit As System.Windows.Forms.TextBox
End Class
