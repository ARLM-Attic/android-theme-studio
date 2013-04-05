<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecentColors
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
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurColor = New System.Windows.Forms.PictureBox()
        Me.Btn_Colorpicker = New System.Windows.Forms.Button()
        CType(Me.CurColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Location = New System.Drawing.Point(86, 318)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(68, 28)
        Me.VButton1.TabIndex = 0
        Me.VButton1.Text = "Choose"
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Android_Theme_Studio.My.Resources.Resources.Palette_Colours
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(3, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(253, 349)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 275
        Me.LineShape2.X2 = -1
        Me.LineShape2.Y1 = 313
        Me.LineShape2.Y2 = 313
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 158
        Me.LineShape1.X2 = 0
        Me.LineShape1.Y1 = 52
        Me.LineShape1.Y2 = 52
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(3, 55)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(248, 255)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current Color"
        '
        'CurColor
        '
        Me.CurColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurColor.Location = New System.Drawing.Point(141, 3)
        Me.CurColor.Name = "CurColor"
        Me.CurColor.Size = New System.Drawing.Size(107, 31)
        Me.CurColor.TabIndex = 4
        Me.CurColor.TabStop = False
        '
        'Btn_Colorpicker
        '
        Me.Btn_Colorpicker.BackgroundImage = Global.Android_Theme_Studio.My.Resources.Resources.half_full
        Me.Btn_Colorpicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Colorpicker.Location = New System.Drawing.Point(49, 24)
        Me.Btn_Colorpicker.Name = "Btn_Colorpicker"
        Me.Btn_Colorpicker.Size = New System.Drawing.Size(40, 25)
        Me.Btn_Colorpicker.TabIndex = 5
        Me.Btn_Colorpicker.UseVisualStyleBackColor = True
        '
        'RecentColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(253, 349)
        Me.Controls.Add(Me.Btn_Colorpicker)
        Me.Controls.Add(Me.CurColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VButton1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecentColors"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Recent Colors"
        CType(Me.CurColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurColor As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Colorpicker As System.Windows.Forms.Button
End Class
