<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.BTN_Cancel = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_OK = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_Apply = New VIBlend.WinForms.Controls.vButton()
        Me.VTreeView1 = New VIBlend.WinForms.Controls.vTreeView()
        Me.VTreeNode1 = New VIBlend.WinForms.Controls.vTreeNode()
        Me.VTreeNode2 = New VIBlend.WinForms.Controls.vTreeNode()
        Me.VTreeNode3 = New VIBlend.WinForms.Controls.vTreeNode()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Projects_Panel = New System.Windows.Forms.Panel()
        Me.TXT_CP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_DFLTPCKJNM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_BRWS = New VIBlend.WinForms.Controls.vButton()
        Me.TXT_UN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Prjctloc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Compile_Panle = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_7ZDir = New System.Windows.Forms.TextBox()
        Me.BTN_BRWS2 = New VIBlend.WinForms.Controls.vButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_APKTDir = New System.Windows.Forms.TextBox()
        Me.BTN_BRWS1 = New VIBlend.WinForms.Controls.vButton()
        Me.General_Panle = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_RcntNum = New System.Windows.Forms.TextBox()
        Me.BTN_FixFileAss = New VIBlend.WinForms.Controls.vButton()
        Me.CHK_CWBOnLoad = New VIBlend.WinForms.Controls.vCheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Projects_Panel.SuspendLayout()
        Me.Compile_Panle.SuspendLayout()
        Me.General_Panle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_Cancel)
        Me.Panel1.Controls.Add(Me.BTN_OK)
        Me.Panel1.Controls.Add(Me.BTN_Apply)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 39)
        Me.Panel1.TabIndex = 4
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.AllowAnimations = True
        Me.BTN_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Cancel.Location = New System.Drawing.Point(358, 8)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.RoundedCornersMask = CType(15, Byte)
        Me.BTN_Cancel.Size = New System.Drawing.Size(100, 26)
        Me.BTN_Cancel.TabIndex = 7
        Me.BTN_Cancel.Text = "Cancel"
        Me.BTN_Cancel.UseVisualStyleBackColor = False
        Me.BTN_Cancel.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.RETROBLUE
        '
        'BTN_OK
        '
        Me.BTN_OK.AllowAnimations = True
        Me.BTN_OK.BackColor = System.Drawing.Color.Transparent
        Me.BTN_OK.Location = New System.Drawing.Point(252, 8)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.RoundedCornersMask = CType(15, Byte)
        Me.BTN_OK.Size = New System.Drawing.Size(100, 26)
        Me.BTN_OK.TabIndex = 7
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = False
        Me.BTN_OK.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.RETROBLUE
        '
        'BTN_Apply
        '
        Me.BTN_Apply.AllowAnimations = True
        Me.BTN_Apply.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Apply.Location = New System.Drawing.Point(464, 8)
        Me.BTN_Apply.Name = "BTN_Apply"
        Me.BTN_Apply.RoundedCornersMask = CType(15, Byte)
        Me.BTN_Apply.Size = New System.Drawing.Size(100, 26)
        Me.BTN_Apply.TabIndex = 6
        Me.BTN_Apply.Text = "Apply"
        Me.BTN_Apply.UseVisualStyleBackColor = False
        Me.BTN_Apply.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.RETROBLUE
        '
        'VTreeView1
        '
        Me.VTreeView1.AccessibleName = "TreeView"
        Me.VTreeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.List
        Me.VTreeView1.CheckBoxes = True
        Me.VTreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.VTreeView1.EnableIndicatorsAnimation = True
        Me.VTreeView1.EnableToggleAnimation = False
        Me.VTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.VTreeView1.Name = "VTreeView1"
        Me.VTreeView1.Nodes.Add(Me.VTreeNode1)
        Me.VTreeView1.Nodes.Add(Me.VTreeNode2)
        Me.VTreeView1.Nodes.Add(Me.VTreeNode3)
        Me.VTreeView1.ScrollPosition = New System.Drawing.Point(0, -1)
        Me.VTreeView1.SelectedNode = Me.VTreeNode1
        Me.VTreeView1.Size = New System.Drawing.Size(116, 427)
        Me.VTreeView1.TabIndex = 1
        Me.VTreeView1.Text = "VTreeView1"
        Me.VTreeView1.TreeIndent = -15
        Me.VTreeView1.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        Me.VTreeView1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'VTreeNode1
        '
        Me.VTreeNode1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode1.HighlightForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode1.RoundedCornersMask = CType(15, Byte)
        Me.VTreeNode1.Selected = True
        Me.VTreeNode1.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode1.Text = "General"
        Me.VTreeNode1.TooltipText = "General"
        '
        'VTreeNode2
        '
        Me.VTreeNode2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode2.HighlightForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode2.RoundedCornersMask = CType(15, Byte)
        Me.VTreeNode2.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode2.Text = "Projects"
        Me.VTreeNode2.TooltipText = "Projects"
        '
        'VTreeNode3
        '
        Me.VTreeNode3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode3.HighlightForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode3.RoundedCornersMask = CType(15, Byte)
        Me.VTreeNode3.SelectedForeColor = System.Drawing.SystemColors.ControlText
        Me.VTreeNode3.Text = "Compile"
        Me.VTreeNode3.TooltipText = "Compile"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.General_Panle)
        Me.Panel2.Controls.Add(Me.Projects_Panel)
        Me.Panel2.Controls.Add(Me.Compile_Panle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(116, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 427)
        Me.Panel2.TabIndex = 5
        '
        'Projects_Panel
        '
        Me.Projects_Panel.Controls.Add(Me.TXT_CP)
        Me.Projects_Panel.Controls.Add(Me.Label7)
        Me.Projects_Panel.Controls.Add(Me.Label6)
        Me.Projects_Panel.Controls.Add(Me.Txt_DFLTPCKJNM)
        Me.Projects_Panel.Controls.Add(Me.Label2)
        Me.Projects_Panel.Controls.Add(Me.BTN_BRWS)
        Me.Projects_Panel.Controls.Add(Me.TXT_UN)
        Me.Projects_Panel.Controls.Add(Me.Label3)
        Me.Projects_Panel.Controls.Add(Me.txt_Prjctloc)
        Me.Projects_Panel.Controls.Add(Me.Label1)
        Me.Projects_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Projects_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Projects_Panel.Name = "Projects_Panel"
        Me.Projects_Panel.Size = New System.Drawing.Size(451, 427)
        Me.Projects_Panel.TabIndex = 12
        '
        'TXT_CP
        '
        Me.TXT_CP.Location = New System.Drawing.Point(31, 153)
        Me.TXT_CP.Multiline = True
        Me.TXT_CP.Name = "TXT_CP"
        Me.TXT_CP.Size = New System.Drawing.Size(216, 64)
        Me.TXT_CP.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Default CopyrightText"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(253, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "+ Theme Name"
        '
        'Txt_DFLTPCKJNM
        '
        Me.Txt_DFLTPCKJNM.Location = New System.Drawing.Point(31, 113)
        Me.Txt_DFLTPCKJNM.Name = "Txt_DFLTPCKJNM"
        Me.Txt_DFLTPCKJNM.Size = New System.Drawing.Size(216, 20)
        Me.Txt_DFLTPCKJNM.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Default PackageName"
        '
        'BTN_BRWS
        '
        Me.BTN_BRWS.AllowAnimations = True
        Me.BTN_BRWS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BRWS.Location = New System.Drawing.Point(350, 28)
        Me.BTN_BRWS.Name = "BTN_BRWS"
        Me.BTN_BRWS.RoundedCornersMask = CType(15, Byte)
        Me.BTN_BRWS.RoundedCornersRadius = 0
        Me.BTN_BRWS.Size = New System.Drawing.Size(66, 20)
        Me.BTN_BRWS.TabIndex = 6
        Me.BTN_BRWS.Text = "B&rowse.."
        Me.BTN_BRWS.UseVisualStyleBackColor = True
        Me.BTN_BRWS.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'TXT_UN
        '
        Me.TXT_UN.Location = New System.Drawing.Point(31, 73)
        Me.TXT_UN.Name = "TXT_UN"
        Me.TXT_UN.Size = New System.Drawing.Size(143, 20)
        Me.TXT_UN.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'txt_Prjctloc
        '
        Me.txt_Prjctloc.Location = New System.Drawing.Point(31, 28)
        Me.txt_Prjctloc.Name = "txt_Prjctloc"
        Me.txt_Prjctloc.Size = New System.Drawing.Size(313, 20)
        Me.txt_Prjctloc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Projects Location"
        '
        'Compile_Panle
        '
        Me.Compile_Panle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Compile_Panle.Controls.Add(Me.Label5)
        Me.Compile_Panle.Controls.Add(Me.TXT_7ZDir)
        Me.Compile_Panle.Controls.Add(Me.BTN_BRWS2)
        Me.Compile_Panle.Controls.Add(Me.Label4)
        Me.Compile_Panle.Controls.Add(Me.TXT_APKTDir)
        Me.Compile_Panle.Controls.Add(Me.BTN_BRWS1)
        Me.Compile_Panle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Compile_Panle.Location = New System.Drawing.Point(0, 0)
        Me.Compile_Panle.Name = "Compile_Panle"
        Me.Compile_Panle.Size = New System.Drawing.Size(451, 427)
        Me.Compile_Panle.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "7z Directory"
        '
        'TXT_7ZDir
        '
        Me.TXT_7ZDir.Location = New System.Drawing.Point(34, 71)
        Me.TXT_7ZDir.Name = "TXT_7ZDir"
        Me.TXT_7ZDir.Size = New System.Drawing.Size(310, 20)
        Me.TXT_7ZDir.TabIndex = 5
        '
        'BTN_BRWS2
        '
        Me.BTN_BRWS2.AllowAnimations = True
        Me.BTN_BRWS2.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BRWS2.Location = New System.Drawing.Point(350, 71)
        Me.BTN_BRWS2.Name = "BTN_BRWS2"
        Me.BTN_BRWS2.RoundedCornersMask = CType(15, Byte)
        Me.BTN_BRWS2.RoundedCornersRadius = 0
        Me.BTN_BRWS2.Size = New System.Drawing.Size(66, 20)
        Me.BTN_BRWS2.TabIndex = 6
        Me.BTN_BRWS2.Text = "B&rowse.."
        Me.BTN_BRWS2.UseVisualStyleBackColor = True
        Me.BTN_BRWS2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ApkTool Directory"
        '
        'TXT_APKTDir
        '
        Me.TXT_APKTDir.Location = New System.Drawing.Point(34, 28)
        Me.TXT_APKTDir.Name = "TXT_APKTDir"
        Me.TXT_APKTDir.Size = New System.Drawing.Size(310, 20)
        Me.TXT_APKTDir.TabIndex = 0
        '
        'BTN_BRWS1
        '
        Me.BTN_BRWS1.AllowAnimations = True
        Me.BTN_BRWS1.BackColor = System.Drawing.Color.Transparent
        Me.BTN_BRWS1.Location = New System.Drawing.Point(350, 28)
        Me.BTN_BRWS1.Name = "BTN_BRWS1"
        Me.BTN_BRWS1.RoundedCornersMask = CType(15, Byte)
        Me.BTN_BRWS1.RoundedCornersRadius = 0
        Me.BTN_BRWS1.Size = New System.Drawing.Size(66, 20)
        Me.BTN_BRWS1.TabIndex = 3
        Me.BTN_BRWS1.Text = "B&rowse.."
        Me.BTN_BRWS1.UseVisualStyleBackColor = True
        Me.BTN_BRWS1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'General_Panle
        '
        Me.General_Panle.Controls.Add(Me.Label8)
        Me.General_Panle.Controls.Add(Me.txt_RcntNum)
        Me.General_Panle.Controls.Add(Me.BTN_FixFileAss)
        Me.General_Panle.Controls.Add(Me.CHK_CWBOnLoad)
        Me.General_Panle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.General_Panle.Location = New System.Drawing.Point(0, 0)
        Me.General_Panle.Name = "General_Panle"
        Me.General_Panle.Size = New System.Drawing.Size(451, 427)
        Me.General_Panle.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(53, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Items shown in recently opened list"
        '
        'txt_RcntNum
        '
        Me.txt_RcntNum.Location = New System.Drawing.Point(11, 33)
        Me.txt_RcntNum.Name = "txt_RcntNum"
        Me.txt_RcntNum.Size = New System.Drawing.Size(36, 20)
        Me.txt_RcntNum.TabIndex = 9
        '
        'BTN_FixFileAss
        '
        Me.BTN_FixFileAss.AllowAnimations = True
        Me.BTN_FixFileAss.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FixFileAss.Location = New System.Drawing.Point(320, 401)
        Me.BTN_FixFileAss.Name = "BTN_FixFileAss"
        Me.BTN_FixFileAss.RoundedCornersMask = CType(15, Byte)
        Me.BTN_FixFileAss.RoundedCornersRadius = 0
        Me.BTN_FixFileAss.Size = New System.Drawing.Size(128, 20)
        Me.BTN_FixFileAss.TabIndex = 8
        Me.BTN_FixFileAss.Text = "Fix File association"
        Me.BTN_FixFileAss.UseVisualStyleBackColor = True
        Me.BTN_FixFileAss.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.EXPRESSIONDARK
        '
        'CHK_CWBOnLoad
        '
        Me.CHK_CWBOnLoad.BackColor = System.Drawing.Color.Transparent
        Me.CHK_CWBOnLoad.ForeColor = System.Drawing.Color.White
        Me.CHK_CWBOnLoad.Location = New System.Drawing.Point(11, 3)
        Me.CHK_CWBOnLoad.Name = "CHK_CWBOnLoad"
        Me.CHK_CWBOnLoad.Size = New System.Drawing.Size(269, 24)
        Me.CHK_CWBOnLoad.TabIndex = 4
        Me.CHK_CWBOnLoad.Text = "Close Welcome page after opening a project"
        Me.CHK_CWBOnLoad.UseThemeFont = True
        Me.CHK_CWBOnLoad.UseThemeTextColor = False
        Me.CHK_CWBOnLoad.UseVisualStyleBackColor = True
        Me.CHK_CWBOnLoad.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.VTreeView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Projects_Panel.ResumeLayout(False)
        Me.Projects_Panel.PerformLayout()
        Me.Compile_Panle.ResumeLayout(False)
        Me.Compile_Panle.PerformLayout()
        Me.General_Panle.ResumeLayout(False)
        Me.General_Panle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VTreeView1 As VIBlend.WinForms.Controls.vTreeView
    Friend WithEvents VTreeNode1 As VIBlend.WinForms.Controls.vTreeNode
    Friend WithEvents VTreeNode2 As VIBlend.WinForms.Controls.vTreeNode
    Friend WithEvents VTreeNode3 As VIBlend.WinForms.Controls.vTreeNode
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Compile_Panle As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_7ZDir As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BRWS2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_APKTDir As System.Windows.Forms.TextBox
    Friend WithEvents BTN_BRWS1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents General_Panle As System.Windows.Forms.Panel
    Friend WithEvents CHK_CWBOnLoad As VIBlend.WinForms.Controls.vCheckBox
    Friend WithEvents Projects_Panel As System.Windows.Forms.Panel
    Friend WithEvents BTN_BRWS As VIBlend.WinForms.Controls.vButton
    Friend WithEvents TXT_UN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Prjctloc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_FixFileAss As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_Cancel As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_OK As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_Apply As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_DFLTPCKJNM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_CP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_RcntNum As System.Windows.Forms.TextBox
End Class
