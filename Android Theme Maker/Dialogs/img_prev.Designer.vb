<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class img_prev
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
        Me.BTN_size = New VIBlend.WinForms.Controls.vButton()
        Me.IMG = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_res = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.ZoomIn = New VIBlend.WinForms.Controls.vButton()
        Me.ZoomOut = New VIBlend.WinForms.Controls.vButton()
        CType(Me.IMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_size
        '
        Me.BTN_size.AllowAnimations = True
        Me.BTN_size.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_size.BackColor = System.Drawing.Color.Transparent
        Me.BTN_size.Location = New System.Drawing.Point(291, 126)
        Me.BTN_size.Name = "BTN_size"
        Me.BTN_size.RoundedCornersMask = CType(15, Byte)
        Me.BTN_size.Size = New System.Drawing.Size(83, 21)
        Me.BTN_size.TabIndex = 3
        Me.BTN_size.Text = "Full Size"
        Me.BTN_size.UseVisualStyleBackColor = False
        Me.BTN_size.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'IMG
        '
        Me.IMG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG.Location = New System.Drawing.Point(237, 3)
        Me.IMG.Name = "IMG"
        Me.IMG.Size = New System.Drawing.Size(137, 117)
        Me.IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IMG.TabIndex = 4
        Me.IMG.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resolution:"
        '
        'Lbl_res
        '
        Me.Lbl_res.AutoSize = True
        Me.Lbl_res.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_res.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Lbl_res.Location = New System.Drawing.Point(27, 95)
        Me.Lbl_res.Name = "Lbl_res"
        Me.Lbl_res.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_res.TabIndex = 9
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(251, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(270, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Lbl_name
        '
        Me.Lbl_name.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Lbl_name.Location = New System.Drawing.Point(27, 23)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(204, 55)
        Me.Lbl_name.TabIndex = 6
        '
        'ZoomIn
        '
        Me.ZoomIn.AllowAnimations = True
        Me.ZoomIn.BackColor = System.Drawing.Color.Transparent
        Me.ZoomIn.Image = Global.Android_Theme_Studio.My.Resources.Resources.zoom_in
        Me.ZoomIn.ImageAbsolutePosition = New System.Drawing.Point(5, 0)
        Me.ZoomIn.Location = New System.Drawing.Point(0, 124)
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.RoundedCornersMask = CType(15, Byte)
        Me.ZoomIn.Size = New System.Drawing.Size(40, 24)
        Me.ZoomIn.TabIndex = 12
        Me.ZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ZoomIn.UseAbsoluteImagePositioning = True
        Me.ZoomIn.UseVisualStyleBackColor = False
        Me.ZoomIn.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'ZoomOut
        '
        Me.ZoomOut.AllowAnimations = True
        Me.ZoomOut.BackColor = System.Drawing.Color.Transparent
        Me.ZoomOut.Image = Global.Android_Theme_Studio.My.Resources.Resources.zoom_out
        Me.ZoomOut.ImageAbsolutePosition = New System.Drawing.Point(5, 0)
        Me.ZoomOut.Location = New System.Drawing.Point(41, 124)
        Me.ZoomOut.Name = "ZoomOut"
        Me.ZoomOut.RoundedCornersMask = CType(15, Byte)
        Me.ZoomOut.Size = New System.Drawing.Size(40, 24)
        Me.ZoomOut.TabIndex = 0
        Me.ZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ZoomOut.UseAbsoluteImagePositioning = True
        Me.ZoomOut.UseVisualStyleBackColor = False
        Me.ZoomOut.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'img_prev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 150)
        Me.Controls.Add(Me.ZoomOut)
        Me.Controls.Add(Me.ZoomIn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_res)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IMG)
        Me.Controls.Add(Me.BTN_size)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "img_prev"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Image Preview"
        CType(Me.IMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_size As VIBlend.WinForms.Controls.vButton
    Friend WithEvents IMG As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_res As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents ZoomIn As VIBlend.WinForms.Controls.vButton
    Friend WithEvents ZoomOut As VIBlend.WinForms.Controls.vButton
End Class
