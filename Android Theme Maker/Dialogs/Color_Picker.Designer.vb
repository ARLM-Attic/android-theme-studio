<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Color_Picker
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CPpanel = New System.Windows.Forms.Panel()
        Me.Redtxt = New VIBlend.WinForms.Controls.vTextBox()
        Me.Greentxt = New VIBlend.WinForms.Controls.vTextBox()
        Me.Bluetxt = New VIBlend.WinForms.Controls.vTextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.HTMLCLR = New VIBlend.WinForms.Controls.vTextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'CPpanel
        '
        Me.CPpanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.CPpanel.Location = New System.Drawing.Point(117, 0)
        Me.CPpanel.Name = "CPpanel"
        Me.CPpanel.Size = New System.Drawing.Size(162, 136)
        Me.CPpanel.TabIndex = 0
        '
        'Redtxt
        '
        Me.Redtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Redtxt.BoundsOffset = New System.Drawing.Size(1, 1)
        Me.Redtxt.ControlBorderColor = System.Drawing.Color.Red
        Me.Redtxt.DefaultText = "Empty..."
        Me.Redtxt.Enabled = False
        Me.Redtxt.ForeColor = System.Drawing.Color.Red
        Me.Redtxt.Location = New System.Drawing.Point(12, 3)
        Me.Redtxt.MaxLength = 32767
        Me.Redtxt.Name = "Redtxt"
        Me.Redtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Redtxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Redtxt.SelectionLength = 0
        Me.Redtxt.SelectionStart = 0
        Me.Redtxt.Size = New System.Drawing.Size(99, 17)
        Me.Redtxt.TabIndex = 0
        Me.Redtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Redtxt.UseThemeBorderColor = False
        Me.Redtxt.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Greentxt
        '
        Me.Greentxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Greentxt.BoundsOffset = New System.Drawing.Size(1, 1)
        Me.Greentxt.ControlBorderColor = System.Drawing.Color.Lime
        Me.Greentxt.DefaultText = "Empty..."
        Me.Greentxt.Enabled = False
        Me.Greentxt.ForeColor = System.Drawing.Color.Lime
        Me.Greentxt.Location = New System.Drawing.Point(12, 30)
        Me.Greentxt.MaxLength = 32767
        Me.Greentxt.Name = "Greentxt"
        Me.Greentxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Greentxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Greentxt.SelectionLength = 0
        Me.Greentxt.SelectionStart = 0
        Me.Greentxt.Size = New System.Drawing.Size(99, 17)
        Me.Greentxt.TabIndex = 1
        Me.Greentxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Greentxt.UseThemeBorderColor = False
        Me.Greentxt.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Bluetxt
        '
        Me.Bluetxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Bluetxt.BoundsOffset = New System.Drawing.Size(1, 1)
        Me.Bluetxt.ControlBorderColor = System.Drawing.Color.DodgerBlue
        Me.Bluetxt.DefaultText = "Empty..."
        Me.Bluetxt.Enabled = False
        Me.Bluetxt.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Bluetxt.Location = New System.Drawing.Point(12, 57)
        Me.Bluetxt.MaxLength = 32767
        Me.Bluetxt.Name = "Bluetxt"
        Me.Bluetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Bluetxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Bluetxt.SelectionLength = 0
        Me.Bluetxt.SelectionStart = 0
        Me.Bluetxt.Size = New System.Drawing.Size(99, 17)
        Me.Bluetxt.TabIndex = 1
        Me.Bluetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Bluetxt.UseThemeBorderColor = False
        Me.Bluetxt.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Location = New System.Drawing.Point(11, 106)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(100, 25)
        Me.VButton1.TabIndex = 2
        Me.VButton1.Text = "Select"
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'HTMLCLR
        '
        Me.HTMLCLR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HTMLCLR.BoundsOffset = New System.Drawing.Size(1, 1)
        Me.HTMLCLR.ControlBorderColor = System.Drawing.Color.White
        Me.HTMLCLR.DefaultText = "Empty..."
        Me.HTMLCLR.Enabled = False
        Me.HTMLCLR.ForeColor = System.Drawing.Color.DodgerBlue
        Me.HTMLCLR.Location = New System.Drawing.Point(12, 83)
        Me.HTMLCLR.MaxLength = 32767
        Me.HTMLCLR.Name = "HTMLCLR"
        Me.HTMLCLR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HTMLCLR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HTMLCLR.SelectionLength = 0
        Me.HTMLCLR.SelectionStart = 0
        Me.HTMLCLR.Size = New System.Drawing.Size(99, 17)
        Me.HTMLCLR.TabIndex = 3
        Me.HTMLCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HTMLCLR.UseThemeBorderColor = False
        Me.HTMLCLR.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Color_Picker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 136)
        Me.Controls.Add(Me.HTMLCLR)
        Me.Controls.Add(Me.VButton1)
        Me.Controls.Add(Me.Redtxt)
        Me.Controls.Add(Me.Greentxt)
        Me.Controls.Add(Me.Bluetxt)
        Me.Controls.Add(Me.CPpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Color_Picker"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Color Picker - Press F7 to pick"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CPpanel As System.Windows.Forms.Panel
    Friend WithEvents Redtxt As VIBlend.WinForms.Controls.vTextBox
    Friend WithEvents Greentxt As VIBlend.WinForms.Controls.vTextBox
    Friend WithEvents Bluetxt As VIBlend.WinForms.Controls.vTextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents HTMLCLR As VIBlend.WinForms.Controls.vTextBox
End Class
