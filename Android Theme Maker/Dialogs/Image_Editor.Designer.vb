<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image_Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Image_Editor))
        Me.IMGORGNL = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VRadioButton1 = New VIBlend.WinForms.Controls.vRadioButton()
        Me.VRadioButton2 = New VIBlend.WinForms.Controls.vRadioButton()
        Me.GradientPanel1 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.TxtB = New System.Windows.Forms.NumericUpDown()
        Me.TxtG = New System.Windows.Forms.NumericUpDown()
        Me.TxtR = New System.Windows.Forms.NumericUpDown()
        Me.BTN_Save = New VIBlend.WinForms.Controls.vButton()
        Me.BTNAPLY = New VIBlend.WinForms.Controls.vButton()
        Me.BTNPIC = New VIBlend.WinForms.Controls.vButton()
        Me.IMGEDITED = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CLR = New System.Windows.Forms.PictureBox()
        Me.GradientPanel2 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.BTN_HSLSAve = New VIBlend.WinForms.Controls.vButton()
        Me.IMGHSLE = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SliderH = New XComponent.SliderBar.MACTrackBar()
        Me.SliderL = New XComponent.SliderBar.MACTrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SliderS = New XComponent.SliderBar.MACTrackBar()
        Me.textL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textS = New System.Windows.Forms.TextBox()
        Me.textH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.IMGORGNL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.TxtB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMGEDITED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel2.SuspendLayout()
        CType(Me.IMGHSLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMGORGNL
        '
        Me.IMGORGNL.BackColor = System.Drawing.Color.Transparent
        Me.IMGORGNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IMGORGNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMGORGNL.Location = New System.Drawing.Point(12, 36)
        Me.IMGORGNL.Name = "IMGORGNL"
        Me.IMGORGNL.Size = New System.Drawing.Size(128, 128)
        Me.IMGORGNL.TabIndex = 31
        Me.IMGORGNL.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Original"
        '
        'VRadioButton1
        '
        Me.VRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.VRadioButton1.Checked = True
        Me.VRadioButton1.Flat = True
        Me.VRadioButton1.Image = Nothing
        Me.VRadioButton1.Location = New System.Drawing.Point(9, 1)
        Me.VRadioButton1.Name = "VRadioButton1"
        Me.VRadioButton1.Size = New System.Drawing.Size(131, 16)
        Me.VRadioButton1.TabIndex = 0
        Me.VRadioButton1.TabStop = True
        Me.VRadioButton1.Text = "Edit using RGB values"
        Me.VRadioButton1.UseVisualStyleBackColor = False
        Me.VRadioButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'VRadioButton2
        '
        Me.VRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.VRadioButton2.Flat = True
        Me.VRadioButton2.Image = Nothing
        Me.VRadioButton2.Location = New System.Drawing.Point(146, 1)
        Me.VRadioButton2.Name = "VRadioButton2"
        Me.VRadioButton2.Size = New System.Drawing.Size(131, 16)
        Me.VRadioButton2.TabIndex = 1
        Me.VRadioButton2.Text = "Edit using HUE values"
        Me.VRadioButton2.UseVisualStyleBackColor = False
        Me.VRadioButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Angel = 0
        Me.GradientPanel1.BackgroundImage = CType(resources.GetObject("GradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanel1.Controls.Add(Me.TxtB)
        Me.GradientPanel1.Controls.Add(Me.TxtG)
        Me.GradientPanel1.Controls.Add(Me.TxtR)
        Me.GradientPanel1.Controls.Add(Me.BTN_Save)
        Me.GradientPanel1.Controls.Add(Me.BTNAPLY)
        Me.GradientPanel1.Controls.Add(Me.BTNPIC)
        Me.GradientPanel1.Controls.Add(Me.IMGEDITED)
        Me.GradientPanel1.Controls.Add(Me.Label1)
        Me.GradientPanel1.Controls.Add(Me.Label2)
        Me.GradientPanel1.Controls.Add(Me.Label3)
        Me.GradientPanel1.Controls.Add(Me.CLR)
        Me.GradientPanel1.Location = New System.Drawing.Point(167, 27)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.PageEndColor = System.Drawing.Color.Empty
        Me.GradientPanel1.PageStartColor = System.Drawing.Color.Empty
        Me.GradientPanel1.Size = New System.Drawing.Size(321, 274)
        Me.GradientPanel1.TabIndex = 59
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(109, 58)
        Me.TxtB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(117, 20)
        Me.TxtB.TabIndex = 69
        Me.TxtB.TabStop = False
        Me.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtG
        '
        Me.TxtG.Location = New System.Drawing.Point(109, 33)
        Me.TxtG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.TxtG.Name = "TxtG"
        Me.TxtG.Size = New System.Drawing.Size(117, 20)
        Me.TxtG.TabIndex = 68
        Me.TxtG.TabStop = False
        Me.TxtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtR
        '
        Me.TxtR.Location = New System.Drawing.Point(109, 9)
        Me.TxtR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.TxtR.Name = "TxtR"
        Me.TxtR.Size = New System.Drawing.Size(117, 20)
        Me.TxtR.TabIndex = 67
        Me.TxtR.TabStop = False
        Me.TxtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_Save
        '
        Me.BTN_Save.AllowAnimations = True
        Me.BTN_Save.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Save.Location = New System.Drawing.Point(79, 85)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.RoundedCornersMask = CType(15, Byte)
        Me.BTN_Save.RoundedCornersRadius = 0
        Me.BTN_Save.Size = New System.Drawing.Size(75, 22)
        Me.BTN_Save.TabIndex = 63
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        Me.BTN_Save.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'BTNAPLY
        '
        Me.BTNAPLY.AllowAnimations = True
        Me.BTNAPLY.BackColor = System.Drawing.Color.Transparent
        Me.BTNAPLY.Location = New System.Drawing.Point(244, 85)
        Me.BTNAPLY.Name = "BTNAPLY"
        Me.BTNAPLY.RoundedCornersMask = CType(15, Byte)
        Me.BTNAPLY.RoundedCornersRadius = 0
        Me.BTNAPLY.Size = New System.Drawing.Size(75, 22)
        Me.BTNAPLY.TabIndex = 64
        Me.BTNAPLY.Text = "Apply"
        Me.BTNAPLY.UseVisualStyleBackColor = True
        Me.BTNAPLY.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'BTNPIC
        '
        Me.BTNPIC.AllowAnimations = True
        Me.BTNPIC.BackColor = System.Drawing.Color.Transparent
        Me.BTNPIC.Location = New System.Drawing.Point(163, 85)
        Me.BTNPIC.Name = "BTNPIC"
        Me.BTNPIC.RoundedCornersMask = CType(15, Byte)
        Me.BTNPIC.RoundedCornersRadius = 0
        Me.BTNPIC.Size = New System.Drawing.Size(75, 22)
        Me.BTNPIC.TabIndex = 66
        Me.BTNPIC.Text = "Pick"
        Me.BTNPIC.UseVisualStyleBackColor = True
        Me.BTNPIC.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'IMGEDITED
        '
        Me.IMGEDITED.BackColor = System.Drawing.Color.Transparent
        Me.IMGEDITED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IMGEDITED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMGEDITED.Location = New System.Drawing.Point(3, 115)
        Me.IMGEDITED.Name = "IMGEDITED"
        Me.IMGEDITED.Size = New System.Drawing.Size(128, 128)
        Me.IMGEDITED.TabIndex = 65
        Me.IMGEDITED.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "RED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(2, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "GREEN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(2, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "BLUE"
        '
        'CLR
        '
        Me.CLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CLR.Location = New System.Drawing.Point(251, 10)
        Me.CLR.Name = "CLR"
        Me.CLR.Size = New System.Drawing.Size(64, 64)
        Me.CLR.TabIndex = 62
        Me.CLR.TabStop = False
        '
        'GradientPanel2
        '
        Me.GradientPanel2.Angel = 0
        Me.GradientPanel2.BackgroundImage = CType(resources.GetObject("GradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanel2.Controls.Add(Me.Panel1)
        Me.GradientPanel2.Controls.Add(Me.IMGHSLE)
        Me.GradientPanel2.Controls.Add(Me.BTN_HSLSAve)
        Me.GradientPanel2.Location = New System.Drawing.Point(167, 27)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.PageEndColor = System.Drawing.Color.Empty
        Me.GradientPanel2.PageStartColor = System.Drawing.Color.Empty
        Me.GradientPanel2.Size = New System.Drawing.Size(321, 274)
        Me.GradientPanel2.TabIndex = 60
        '
        'BTN_HSLSAve
        '
        Me.BTN_HSLSAve.AllowAnimations = True
        Me.BTN_HSLSAve.BackColor = System.Drawing.Color.Transparent
        Me.BTN_HSLSAve.Location = New System.Drawing.Point(238, 113)
        Me.BTN_HSLSAve.Name = "BTN_HSLSAve"
        Me.BTN_HSLSAve.RoundedCornersMask = CType(15, Byte)
        Me.BTN_HSLSAve.RoundedCornersRadius = 0
        Me.BTN_HSLSAve.Size = New System.Drawing.Size(75, 22)
        Me.BTN_HSLSAve.TabIndex = 48
        Me.BTN_HSLSAve.Text = "Save"
        Me.BTN_HSLSAve.UseVisualStyleBackColor = True
        Me.BTN_HSLSAve.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'IMGHSLE
        '
        Me.IMGHSLE.BackColor = System.Drawing.Color.Transparent
        Me.IMGHSLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IMGHSLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMGHSLE.Location = New System.Drawing.Point(3, 113)
        Me.IMGHSLE.Name = "IMGHSLE"
        Me.IMGHSLE.Size = New System.Drawing.Size(128, 128)
        Me.IMGHSLE.TabIndex = 47
        Me.IMGHSLE.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SliderH)
        Me.Panel1.Controls.Add(Me.SliderL)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SliderS)
        Me.Panel1.Controls.Add(Me.textL)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.textS)
        Me.Panel1.Controls.Add(Me.textH)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 102)
        Me.Panel1.TabIndex = 46
        '
        'SliderH
        '
        Me.SliderH.BackColor = System.Drawing.Color.Transparent
        Me.SliderH.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SliderH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SliderH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.SliderH.IndentHeight = 6
        Me.SliderH.Location = New System.Drawing.Point(73, -1)
        Me.SliderH.Maximum = 100
        Me.SliderH.Minimum = -100
        Me.SliderH.Name = "SliderH"
        Me.SliderH.Size = New System.Drawing.Size(169, 28)
        Me.SliderH.TabIndex = 48
        Me.SliderH.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderH.TickColor = System.Drawing.Color.Black
        Me.SliderH.TickHeight = 4
        Me.SliderH.TickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderH.TrackerColor = System.Drawing.Color.Silver
        Me.SliderH.TrackerSize = New System.Drawing.Size(16, 16)
        Me.SliderH.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SliderH.TrackLineHeight = 3
        Me.SliderH.Value = 0
        '
        'SliderL
        '
        Me.SliderL.BackColor = System.Drawing.Color.Transparent
        Me.SliderL.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SliderL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SliderL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.SliderL.IndentHeight = 6
        Me.SliderL.Location = New System.Drawing.Point(73, 65)
        Me.SliderL.Maximum = 100
        Me.SliderL.Minimum = -100
        Me.SliderL.Name = "SliderL"
        Me.SliderL.Size = New System.Drawing.Size(169, 28)
        Me.SliderL.TabIndex = 47
        Me.SliderL.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderL.TickColor = System.Drawing.Color.Black
        Me.SliderL.TickHeight = 4
        Me.SliderL.TickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderL.TrackerColor = System.Drawing.Color.Silver
        Me.SliderL.TrackerSize = New System.Drawing.Size(16, 16)
        Me.SliderL.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SliderL.TrackLineHeight = 3
        Me.SliderL.Value = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(3, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Luminance"
        '
        'SliderS
        '
        Me.SliderS.BackColor = System.Drawing.Color.Transparent
        Me.SliderS.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SliderS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SliderS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.SliderS.IndentHeight = 6
        Me.SliderS.Location = New System.Drawing.Point(73, 32)
        Me.SliderS.Maximum = 100
        Me.SliderS.Minimum = -100
        Me.SliderS.Name = "SliderS"
        Me.SliderS.Size = New System.Drawing.Size(169, 28)
        Me.SliderS.TabIndex = 46
        Me.SliderS.TextTickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderS.TickColor = System.Drawing.Color.Black
        Me.SliderS.TickHeight = 4
        Me.SliderS.TickStyle = System.Windows.Forms.TickStyle.None
        Me.SliderS.TrackerColor = System.Drawing.Color.Silver
        Me.SliderS.TrackerSize = New System.Drawing.Size(16, 16)
        Me.SliderS.TrackLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SliderS.TrackLineHeight = 3
        Me.SliderS.Value = 0
        '
        'textL
        '
        Me.textL.Enabled = False
        Me.textL.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textL.Location = New System.Drawing.Point(259, 65)
        Me.textL.Name = "textL"
        Me.textL.Size = New System.Drawing.Size(38, 23)
        Me.textL.TabIndex = 23
        Me.textL.Text = "0"
        Me.textL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(3, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Saturation"
        '
        'textS
        '
        Me.textS.Enabled = False
        Me.textS.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textS.Location = New System.Drawing.Point(259, 32)
        Me.textS.Name = "textS"
        Me.textS.Size = New System.Drawing.Size(38, 23)
        Me.textS.TabIndex = 22
        Me.textS.Text = "0"
        Me.textS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textH
        '
        Me.textH.Enabled = False
        Me.textH.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textH.Location = New System.Drawing.Point(259, 4)
        Me.textH.Name = "textH"
        Me.textH.Size = New System.Drawing.Size(38, 23)
        Me.textH.TabIndex = 21
        Me.textH.Text = "0"
        Me.textH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Hue"
        '
        'Image_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(490, 304)
        Me.Controls.Add(Me.VRadioButton2)
        Me.Controls.Add(Me.VRadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IMGORGNL)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.GradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Image_Editor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.IMGORGNL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.TxtB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMGEDITED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel2.ResumeLayout(False)
        CType(Me.IMGHSLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IMGORGNL As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents VRadioButton1 As VIBlend.WinForms.Controls.vRadioButton
    Friend WithEvents VRadioButton2 As VIBlend.WinForms.Controls.vRadioButton
    Friend WithEvents GradientPanel1 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents TxtB As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtG As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtR As System.Windows.Forms.NumericUpDown
    Friend WithEvents BTN_Save As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTNAPLY As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTNPIC As VIBlend.WinForms.Controls.vButton
    Friend WithEvents IMGEDITED As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CLR As System.Windows.Forms.PictureBox
    Friend WithEvents GradientPanel2 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SliderH As XComponent.SliderBar.MACTrackBar
    Friend WithEvents SliderL As XComponent.SliderBar.MACTrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SliderS As XComponent.SliderBar.MACTrackBar
    Friend WithEvents textL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textS As System.Windows.Forms.TextBox
    Friend WithEvents textH As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IMGHSLE As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_HSLSAve As VIBlend.WinForms.Controls.vButton
End Class
