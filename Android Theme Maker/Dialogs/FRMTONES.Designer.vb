<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMTONES
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton3 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.Txt_alrm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_notifi = New System.Windows.Forms.TextBox()
        Me.Txt_RING = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OPN_FILE_dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 36)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(440, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "APPLY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.VButton2)
        Me.Panel2.Controls.Add(Me.VButton3)
        Me.Panel2.Controls.Add(Me.VButton1)
        Me.Panel2.Controls.Add(Me.Txt_alrm)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TXT_notifi)
        Me.Panel2.Controls.Add(Me.Txt_RING)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 126)
        Me.Panel2.TabIndex = 3
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Location = New System.Drawing.Point(420, 50)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.RoundedCornersRadius = 0
        Me.VButton2.Size = New System.Drawing.Size(66, 20)
        Me.VButton2.TabIndex = 7
        Me.VButton2.Text = "B&rowse.."
        Me.VButton2.UseVisualStyleBackColor = True
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'VButton3
        '
        Me.VButton3.AllowAnimations = True
        Me.VButton3.BackColor = System.Drawing.Color.Transparent
        Me.VButton3.Location = New System.Drawing.Point(420, 91)
        Me.VButton3.Name = "VButton3"
        Me.VButton3.RoundedCornersMask = CType(15, Byte)
        Me.VButton3.RoundedCornersRadius = 0
        Me.VButton3.Size = New System.Drawing.Size(66, 20)
        Me.VButton3.TabIndex = 7
        Me.VButton3.Text = "B&rowse.."
        Me.VButton3.UseVisualStyleBackColor = True
        Me.VButton3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Location = New System.Drawing.Point(420, 14)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.RoundedCornersRadius = 0
        Me.VButton1.Size = New System.Drawing.Size(66, 20)
        Me.VButton1.TabIndex = 12
        Me.VButton1.Text = "B&rowse.."
        Me.VButton1.UseVisualStyleBackColor = True
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'Txt_alrm
        '
        Me.Txt_alrm.Location = New System.Drawing.Point(100, 53)
        Me.Txt_alrm.Name = "Txt_alrm"
        Me.Txt_alrm.Size = New System.Drawing.Size(314, 20)
        Me.Txt_alrm.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Alarm"
        '
        'TXT_notifi
        '
        Me.TXT_notifi.Location = New System.Drawing.Point(100, 92)
        Me.TXT_notifi.Name = "TXT_notifi"
        Me.TXT_notifi.Size = New System.Drawing.Size(314, 20)
        Me.TXT_notifi.TabIndex = 4
        '
        'Txt_RING
        '
        Me.Txt_RING.Location = New System.Drawing.Point(100, 14)
        Me.Txt_RING.Name = "Txt_RING"
        Me.Txt_RING.Size = New System.Drawing.Size(314, 20)
        Me.Txt_RING.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(3, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Notification"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ringtone"
        '
        'OPN_FILE_dlg
        '
        Me.OPN_FILE_dlg.Filter = "MP3 Files|*.mp3"
        '
        'FRMTONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMTONES"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting Tones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Txt_alrm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_RING As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_notifi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton3 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents OPN_FILE_dlg As System.Windows.Forms.OpenFileDialog
End Class
