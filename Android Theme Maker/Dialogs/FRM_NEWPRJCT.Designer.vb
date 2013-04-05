<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NEWPRJCT
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_res = New WindowsFormsAero.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_plat = New WindowsFormsAero.ComboBox()
        Me.Txt_Dir = New System.Windows.Forms.ComboBox()
        Me.Btn_Brws = New System.Windows.Forms.Button()
        Me.Txt_auth = New System.Windows.Forms.TextBox()
        Me.Txt_ver = New System.Windows.Forms.TextBox()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 50)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(431, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Txt_res)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Txt_plat)
        Me.Panel2.Controls.Add(Me.Txt_Dir)
        Me.Panel2.Controls.Add(Me.Btn_Brws)
        Me.Panel2.Controls.Add(Me.Txt_auth)
        Me.Panel2.Controls.Add(Me.Txt_ver)
        Me.Panel2.Controls.Add(Me.Txt_Name)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 234)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(3, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Resolution"
        '
        'Txt_res
        '
        Me.Txt_res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_res.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Txt_res.FormattingEnabled = True
        Me.Txt_res.Items.AddRange(New Object() {"Xhdpi", "Lhdpi", "Mhdpi"})
        Me.Txt_res.Location = New System.Drawing.Point(129, 209)
        Me.Txt_res.Name = "Txt_res"
        Me.Txt_res.Size = New System.Drawing.Size(282, 21)
        Me.Txt_res.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(3, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Platform"
        '
        'Txt_plat
        '
        Me.Txt_plat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_plat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Txt_plat.FormattingEnabled = True
        Me.Txt_plat.Items.AddRange(New Object() {"CyanogenMod 9"})
        Me.Txt_plat.Location = New System.Drawing.Point(129, 167)
        Me.Txt_plat.Name = "Txt_plat"
        Me.Txt_plat.Size = New System.Drawing.Size(282, 21)
        Me.Txt_plat.TabIndex = 5
        '
        'Txt_Dir
        '
        Me.Txt_Dir.FormattingEnabled = True
        Me.Txt_Dir.Location = New System.Drawing.Point(129, 125)
        Me.Txt_Dir.Name = "Txt_Dir"
        Me.Txt_Dir.Size = New System.Drawing.Size(282, 21)
        Me.Txt_Dir.TabIndex = 4
        '
        'Btn_Brws
        '
        Me.Btn_Brws.Location = New System.Drawing.Point(417, 125)
        Me.Btn_Brws.Name = "Btn_Brws"
        Me.Btn_Brws.Size = New System.Drawing.Size(75, 21)
        Me.Btn_Brws.TabIndex = 3
        Me.Btn_Brws.Text = "Browse..."
        Me.Btn_Brws.UseVisualStyleBackColor = True
        '
        'Txt_auth
        '
        Me.Txt_auth.Location = New System.Drawing.Point(129, 84)
        Me.Txt_auth.Name = "Txt_auth"
        Me.Txt_auth.Size = New System.Drawing.Size(363, 20)
        Me.Txt_auth.TabIndex = 2
        '
        'Txt_ver
        '
        Me.Txt_ver.Location = New System.Drawing.Point(129, 43)
        Me.Txt_ver.Name = "Txt_ver"
        Me.Txt_ver.Size = New System.Drawing.Size(363, 20)
        Me.Txt_ver.TabIndex = 1
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(129, 2)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(363, 20)
        Me.Txt_Name.TabIndex = 0
        Me.Txt_Name.Text = "AndroidTheme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(3, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(3, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Theme Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Theme Name"
        '
        'FRM_NEWPRJCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 302)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(433, 247)
        Me.Name = "FRM_NEWPRJCT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Project"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Dir As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Brws As System.Windows.Forms.Button
    Friend WithEvents Txt_auth As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ver As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_plat As WindowsFormsAero.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_res As WindowsFormsAero.ComboBox
End Class
