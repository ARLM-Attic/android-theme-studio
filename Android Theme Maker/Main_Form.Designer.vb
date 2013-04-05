<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Tabs = New VIBlend.WinForms.Controls.vTabControl()
        Me.Welcome = New VIBlend.WinForms.Controls.vTabPage()
        Me.Framework_Applications = New VIBlend.WinForms.Controls.vTabPage()
        Me.Framework_LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.IMG_PRV = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CB_FWA = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.AppIcons = New VIBlend.WinForms.Controls.vTabPage()
        Me.APPIcons_LV = New System.Windows.Forms.ListView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.xml = New VIBlend.WinForms.Controls.vTabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LV_XMLattrs = New System.Windows.Forms.ListView()
        Me.AttributeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AttributeValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_XMLITEMS = New System.Windows.Forms.ListView()
        Me.NodeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB_xmlFiles = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_XMLDirs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Extra = New VIBlend.WinForms.Controls.vTabPage()
        Me.Tabs2 = New VIBlend.WinForms.Controls.vTabControl()
        Me.Tones = New VIBlend.WinForms.Controls.vTabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_RNGNAME = New System.Windows.Forms.Label()
        Me.LBL_RNGDUR = New System.Windows.Forms.Label()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.Images = New VIBlend.WinForms.Controls.vTabPage()
        Me.Texts = New VIBlend.WinForms.Controls.vTabPage()
        Me.Other = New VIBlend.WinForms.Controls.vTabPage()
        Me.F_Menu = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorPickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrjctMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetThemeBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPreviewImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditProjectInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTargetPlatformToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewApplicationsDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.APKBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpnPrjDlg = New System.Windows.Forms.OpenFileDialog()
        Me.OpnFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.AssignStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Assigntoimage = New System.Windows.Forms.ToolStripMenuItem()
        Me.assigntocolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradientPanel3 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.Recent_TV = New VIBlend.WinForms.Controls.vTreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GradientPanel1 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.BTN_FW_EDIT = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_FW_Replace = New VIBlend.WinForms.Controls.vButton()
        Me.GradientPanel2 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.BTN_APP_ADD = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_APP_EDIT = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_APP_RMV = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_APP_Replace = New VIBlend.WinForms.Controls.vButton()
        Me.GradientPanel4 = New Android_Theme_Studio.GradientPanel.GradientPanel()
        Me.BTN_Assign = New VIBlend.WinForms.Controls.vSplitButton()
        Me.BTN_xml_editItemValue = New VIBlend.WinForms.Controls.vButton()
        Me.BTN_xml_editAttrValue = New VIBlend.WinForms.Controls.vButton()
        Me.Btn_xml_delItem = New VIBlend.WinForms.Controls.vButton()
        Me.Tabs.SuspendLayout()
        Me.Welcome.SuspendLayout()
        Me.Framework_Applications.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.IMG_PRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppIcons.SuspendLayout()
        Me.xml.SuspendLayout()
        Me.Extra.SuspendLayout()
        Me.Tabs2.SuspendLayout()
        Me.Tones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.F_Menu.SuspendLayout()
        Me.AssignStrip.SuspendLayout()
        Me.GradientPanel3.SuspendLayout()
        Me.GradientPanel1.SuspendLayout()
        Me.GradientPanel2.SuspendLayout()
        Me.GradientPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.AllowAnimations = True
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tabs.Controls.Add(Me.Welcome)
        Me.Tabs.Controls.Add(Me.Framework_Applications)
        Me.Tabs.Controls.Add(Me.AppIcons)
        Me.Tabs.Controls.Add(Me.xml)
        Me.Tabs.Controls.Add(Me.Extra)
        Me.Tabs.CornerRadius = 5
        Me.Tabs.EnableCloseButtons = True
        Me.Tabs.Location = New System.Drawing.Point(12, 26)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.Padding = New System.Windows.Forms.Padding(0, 45, 0, 0)
        Me.Tabs.Size = New System.Drawing.Size(1029, 569)
        Me.Tabs.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Top
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabPages.Add(Me.Welcome)
        Me.Tabs.TabPages.Add(Me.Framework_Applications)
        Me.Tabs.TabPages.Add(Me.AppIcons)
        Me.Tabs.TabPages.Add(Me.xml)
        Me.Tabs.TabPages.Add(Me.Extra)
        Me.Tabs.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Tabs.TabsInitialOffset = 35
        Me.Tabs.TabsShape = VIBlend.WinForms.Controls.TabsShape.RoundedCorners
        Me.Tabs.UseTabsAreaBackColor = True
        Me.Tabs.UseTabsAreaBorderColor = True
        Me.Tabs.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Welcome
        '
        Me.Welcome.BackColor = System.Drawing.Color.Transparent
        Me.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Welcome.ContentBackColor = System.Drawing.Color.GhostWhite
        Me.Welcome.ContentBorderColor = System.Drawing.Color.Transparent
        Me.Welcome.Controls.Add(Me.GradientPanel3)
        Me.Welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Welcome.ForeColor = System.Drawing.Color.White
        Me.Welcome.HeaderHeight = 35
        Me.Welcome.HighlightTextColor = System.Drawing.Color.White
        Me.Welcome.Location = New System.Drawing.Point(0, 45)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Padding = New System.Windows.Forms.Padding(0)
        Me.Welcome.Size = New System.Drawing.Size(1029, 524)
        Me.Welcome.TabIndex = 12
        Me.Welcome.Text = "Welcome Page"
        Me.Welcome.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Welcome.TextColor = System.Drawing.Color.WhiteSmoke
        Me.Welcome.TooltipText = "Welcome Page"
        Me.Welcome.UseThemeTextColor = False
        Me.Welcome.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Welcome.Visible = False
        '
        'Framework_Applications
        '
        Me.Framework_Applications.Controls.Add(Me.GradientPanel1)
        Me.Framework_Applications.Controls.Add(Me.Framework_LV)
        Me.Framework_Applications.Controls.Add(Me.Label5)
        Me.Framework_Applications.Controls.Add(Me.Panel7)
        Me.Framework_Applications.Controls.Add(Me.Label30)
        Me.Framework_Applications.Controls.Add(Me.CB_FWA)
        Me.Framework_Applications.Controls.Add(Me.Label31)
        Me.Framework_Applications.Controls.Add(Me.ShapeContainer2)
        Me.Framework_Applications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Framework_Applications.HeaderHeight = 35
        Me.Framework_Applications.Location = New System.Drawing.Point(0, 45)
        Me.Framework_Applications.Name = "Framework_Applications"
        Me.Framework_Applications.Padding = New System.Windows.Forms.Padding(0)
        Me.Framework_Applications.Size = New System.Drawing.Size(1029, 524)
        Me.Framework_Applications.TabIndex = 9
        Me.Framework_Applications.Text = "Framework Applications"
        Me.Framework_Applications.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Framework_Applications.TextColor = System.Drawing.Color.WhiteSmoke
        Me.Framework_Applications.TooltipText = "TabPage"
        Me.Framework_Applications.UseThemeTextColor = False
        Me.Framework_Applications.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Framework_Applications.Visible = False
        '
        'Framework_LV
        '
        Me.Framework_LV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Framework_LV.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Framework_LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.Framework_LV.Location = New System.Drawing.Point(7, 99)
        Me.Framework_LV.MultiSelect = False
        Me.Framework_LV.Name = "Framework_LV"
        Me.Framework_LV.Size = New System.Drawing.Size(516, 418)
        Me.Framework_LV.TabIndex = 31
        Me.Framework_LV.TileSize = New System.Drawing.Size(64, 64)
        Me.Framework_LV.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Layout icons :"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.IMG_PRV)
        Me.Panel7.Location = New System.Drawing.Point(533, 66)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(270, 451)
        Me.Panel7.TabIndex = 28
        '
        'IMG_PRV
        '
        Me.IMG_PRV.Location = New System.Drawing.Point(0, 0)
        Me.IMG_PRV.Name = "IMG_PRV"
        Me.IMG_PRV.Size = New System.Drawing.Size(270, 451)
        Me.IMG_PRV.TabIndex = 0
        Me.IMG_PRV.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(530, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 15)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "Preview :"
        '
        'CB_FWA
        '
        Me.CB_FWA.FormattingEnabled = True
        Me.CB_FWA.Location = New System.Drawing.Point(76, 56)
        Me.CB_FWA.Name = "CB_FWA"
        Me.CB_FWA.Size = New System.Drawing.Size(187, 21)
        Me.CB_FWA.TabIndex = 26
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 58)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 15)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Layout :"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(4, 4)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1021, 516)
        Me.ShapeContainer2.TabIndex = 36
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -2
        Me.LineShape2.X2 = 335
        Me.LineShape2.Y1 = 46
        Me.LineShape2.Y2 = 46
        '
        'AppIcons
        '
        Me.AppIcons.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.AppIcons.Controls.Add(Me.GradientPanel2)
        Me.AppIcons.Controls.Add(Me.APPIcons_LV)
        Me.AppIcons.Controls.Add(Me.Label10)
        Me.AppIcons.Controls.Add(Me.ShapeContainer1)
        Me.AppIcons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppIcons.HeaderHeight = 35
        Me.AppIcons.Location = New System.Drawing.Point(0, 45)
        Me.AppIcons.Name = "AppIcons"
        Me.AppIcons.Padding = New System.Windows.Forms.Padding(0)
        Me.AppIcons.Size = New System.Drawing.Size(1029, 524)
        Me.AppIcons.TabIndex = 5
        Me.AppIcons.Text = "Applications' Icons"
        Me.AppIcons.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.AppIcons.TextColor = System.Drawing.Color.WhiteSmoke
        Me.AppIcons.TooltipText = "Applications' Icons"
        Me.AppIcons.UseThemeTextColor = False
        Me.AppIcons.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.AppIcons.Visible = False
        '
        'APPIcons_LV
        '
        Me.APPIcons_LV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.APPIcons_LV.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.APPIcons_LV.Location = New System.Drawing.Point(7, 77)
        Me.APPIcons_LV.Name = "APPIcons_LV"
        Me.APPIcons_LV.Size = New System.Drawing.Size(516, 440)
        Me.APPIcons_LV.TabIndex = 32
        Me.APPIcons_LV.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "In Theme icons :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(4, 4)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1021, 516)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 335
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'xml
        '
        Me.xml.Controls.Add(Me.Label6)
        Me.xml.Controls.Add(Me.Label4)
        Me.xml.Controls.Add(Me.LV_XMLattrs)
        Me.xml.Controls.Add(Me.LV_XMLITEMS)
        Me.xml.Controls.Add(Me.CB_xmlFiles)
        Me.xml.Controls.Add(Me.Label3)
        Me.xml.Controls.Add(Me.CB_XMLDirs)
        Me.xml.Controls.Add(Me.Label2)
        Me.xml.Controls.Add(Me.ShapeContainer4)
        Me.xml.Controls.Add(Me.GradientPanel4)
        Me.xml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xml.HeaderHeight = 35
        Me.xml.Location = New System.Drawing.Point(0, 45)
        Me.xml.Name = "xml"
        Me.xml.Padding = New System.Windows.Forms.Padding(0)
        Me.xml.Size = New System.Drawing.Size(1029, 524)
        Me.xml.TabIndex = 8
        Me.xml.Text = "XMLs"
        Me.xml.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.xml.TextColor = System.Drawing.Color.WhiteSmoke
        Me.xml.TooltipText = "TabPage"
        Me.xml.UseThemeTextColor = False
        Me.xml.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.xml.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Items :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Attributes :"
        '
        'LV_XMLattrs
        '
        Me.LV_XMLattrs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AttributeName, Me.AttributeValue})
        Me.LV_XMLattrs.FullRowSelect = True
        Me.LV_XMLattrs.Location = New System.Drawing.Point(416, 89)
        Me.LV_XMLattrs.Name = "LV_XMLattrs"
        Me.LV_XMLattrs.Size = New System.Drawing.Size(452, 283)
        Me.LV_XMLattrs.TabIndex = 41
        Me.LV_XMLattrs.UseCompatibleStateImageBehavior = False
        Me.LV_XMLattrs.View = System.Windows.Forms.View.Details
        '
        'AttributeName
        '
        Me.AttributeName.Text = "Name"
        Me.AttributeName.Width = 99
        '
        'AttributeValue
        '
        Me.AttributeValue.Text = "Value"
        Me.AttributeValue.Width = 145
        '
        'LV_XMLITEMS
        '
        Me.LV_XMLITEMS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NodeName, Me.Value})
        Me.LV_XMLITEMS.FullRowSelect = True
        Me.LV_XMLITEMS.Location = New System.Drawing.Point(74, 89)
        Me.LV_XMLITEMS.Name = "LV_XMLITEMS"
        Me.LV_XMLITEMS.Size = New System.Drawing.Size(248, 428)
        Me.LV_XMLITEMS.TabIndex = 40
        Me.LV_XMLITEMS.UseCompatibleStateImageBehavior = False
        Me.LV_XMLITEMS.View = System.Windows.Forms.View.Details
        '
        'NodeName
        '
        Me.NodeName.Text = "Name"
        Me.NodeName.Width = 83
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 145
        '
        'CB_xmlFiles
        '
        Me.CB_xmlFiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_xmlFiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_xmlFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_xmlFiles.FormattingEnabled = True
        Me.CB_xmlFiles.Location = New System.Drawing.Point(289, 62)
        Me.CB_xmlFiles.Name = "CB_xmlFiles"
        Me.CB_xmlFiles.Size = New System.Drawing.Size(419, 21)
        Me.CB_xmlFiles.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Xml File:"
        '
        'CB_XMLDirs
        '
        Me.CB_XMLDirs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_XMLDirs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_XMLDirs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_XMLDirs.FormattingEnabled = True
        Me.CB_XMLDirs.Location = New System.Drawing.Point(74, 62)
        Me.CB_XMLDirs.Name = "CB_XMLDirs"
        Me.CB_XMLDirs.Size = New System.Drawing.Size(142, 21)
        Me.CB_XMLDirs.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Directory:"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(4, 37)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer4.Size = New System.Drawing.Size(1021, 483)
        Me.ShapeContainer4.TabIndex = 44
        Me.ShapeContainer4.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 336
        Me.LineShape4.Y1 = 13
        Me.LineShape4.Y2 = 13
        '
        'Extra
        '
        Me.Extra.Controls.Add(Me.Tabs2)
        Me.Extra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Extra.Enabled = False
        Me.Extra.HeaderHeight = 35
        Me.Extra.Location = New System.Drawing.Point(0, 45)
        Me.Extra.Name = "Extra"
        Me.Extra.Padding = New System.Windows.Forms.Padding(0)
        Me.Extra.Size = New System.Drawing.Size(1029, 524)
        Me.Extra.TabIndex = 11
        Me.Extra.Text = "Extra"
        Me.Extra.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Extra.TextColor = System.Drawing.Color.WhiteSmoke
        Me.Extra.TooltipText = "Extra"
        Me.Extra.UseThemeTextColor = False
        Me.Extra.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Extra.Visible = False
        '
        'Tabs2
        '
        Me.Tabs2.AllowAnimations = True
        Me.Tabs2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Tabs2.Controls.Add(Me.Tones)
        Me.Tabs2.Controls.Add(Me.Images)
        Me.Tabs2.Controls.Add(Me.Texts)
        Me.Tabs2.Controls.Add(Me.Other)
        Me.Tabs2.CornerRadius = 1
        Me.Tabs2.ForeColor = System.Drawing.Color.Black
        Me.Tabs2.Location = New System.Drawing.Point(0, 0)
        Me.Tabs2.Name = "Tabs2"
        Me.Tabs2.Padding = New System.Windows.Forms.Padding(85, 0, 0, 0)
        Me.Tabs2.Size = New System.Drawing.Size(1030, 525)
        Me.Tabs2.TabAlignment = VIBlend.WinForms.Controls.vTabPageAlignment.Left
        Me.Tabs2.TabIndex = 1
        Me.Tabs2.TabPages.Add(Me.Tones)
        Me.Tabs2.TabPages.Add(Me.Images)
        Me.Tabs2.TabPages.Add(Me.Texts)
        Me.Tabs2.TabPages.Add(Me.Other)
        Me.Tabs2.TabsAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Tabs2.TabsInitialOffset = 0
        Me.Tabs2.TextOrientation = VIBlend.WinForms.Controls.vTabPageTextOrientation.Vertical
        Me.Tabs2.TitleHeight = 85
        Me.Tabs2.UseTabsAreaBackColor = True
        Me.Tabs2.UseTabsAreaBorderColor = True
        Me.Tabs2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        '
        'Tones
        '
        Me.Tones.Controls.Add(Me.GroupBox1)
        Me.Tones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tones.HeaderHeight = 85
        Me.Tones.ImageIndex = 0
        Me.Tones.Location = New System.Drawing.Point(85, 0)
        Me.Tones.Name = "Tones"
        Me.Tones.Padding = New System.Windows.Forms.Padding(0)
        Me.Tones.Size = New System.Drawing.Size(945, 525)
        Me.Tones.TabIndex = 3
        Me.Tones.Text = "Tones"
        Me.Tones.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Tones.TextColor = System.Drawing.Color.White
        Me.Tones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tones.TooltipText = "TabPage"
        Me.Tones.UseThemeTextColor = False
        Me.Tones.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Tones.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LBL_RNGNAME)
        Me.GroupBox1.Controls.Add(Me.LBL_RNGDUR)
        Me.GroupBox1.Controls.Add(Me.VButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(666, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tones Preview"
        '
        'LBL_RNGNAME
        '
        Me.LBL_RNGNAME.AutoSize = True
        Me.LBL_RNGNAME.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RNGNAME.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBL_RNGNAME.Location = New System.Drawing.Point(3, 36)
        Me.LBL_RNGNAME.Name = "LBL_RNGNAME"
        Me.LBL_RNGNAME.Size = New System.Drawing.Size(51, 19)
        Me.LBL_RNGNAME.TabIndex = 11
        Me.LBL_RNGNAME.Text = "Title :"
        '
        'LBL_RNGDUR
        '
        Me.LBL_RNGDUR.AutoSize = True
        Me.LBL_RNGDUR.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RNGDUR.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBL_RNGDUR.Location = New System.Drawing.Point(3, 58)
        Me.LBL_RNGDUR.Name = "LBL_RNGDUR"
        Me.LBL_RNGDUR.Size = New System.Drawing.Size(84, 19)
        Me.LBL_RNGDUR.TabIndex = 10
        Me.LBL_RNGDUR.Text = "Duration :"
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Location = New System.Drawing.Point(167, 58)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.Size = New System.Drawing.Size(100, 30)
        Me.VButton2.TabIndex = 9
        Me.VButton2.Text = "Play"
        Me.VButton2.UseVisualStyleBackColor = False
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROGREEN
        '
        'Images
        '
        Me.Images.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Images.HeaderHeight = 85
        Me.Images.ImageIndex = 1
        Me.Images.Location = New System.Drawing.Point(85, 0)
        Me.Images.Name = "Images"
        Me.Images.Padding = New System.Windows.Forms.Padding(0)
        Me.Images.Size = New System.Drawing.Size(945, 525)
        Me.Images.TabIndex = 4
        Me.Images.Text = "Images"
        Me.Images.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Images.TextColor = System.Drawing.Color.White
        Me.Images.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Images.TooltipText = "TabPage"
        Me.Images.UseThemeTextColor = False
        Me.Images.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Images.Visible = False
        '
        'Texts
        '
        Me.Texts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Texts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Texts.HeaderHeight = 85
        Me.Texts.ImageIndex = 2
        Me.Texts.Location = New System.Drawing.Point(85, 0)
        Me.Texts.Name = "Texts"
        Me.Texts.Padding = New System.Windows.Forms.Padding(0)
        Me.Texts.Size = New System.Drawing.Size(945, 525)
        Me.Texts.TabIndex = 5
        Me.Texts.Text = "Texts"
        Me.Texts.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Texts.TextColor = System.Drawing.Color.White
        Me.Texts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Texts.TooltipText = "TabPage"
        Me.Texts.UseThemeTextColor = False
        Me.Texts.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Texts.Visible = False
        '
        'Other
        '
        Me.Other.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Other.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Other.HeaderHeight = 85
        Me.Other.ImageIndex = 3
        Me.Other.Location = New System.Drawing.Point(85, 0)
        Me.Other.Name = "Other"
        Me.Other.Padding = New System.Windows.Forms.Padding(0)
        Me.Other.Size = New System.Drawing.Size(945, 525)
        Me.Other.TabIndex = 6
        Me.Other.Text = "Other"
        Me.Other.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.Other.TextColor = System.Drawing.Color.White
        Me.Other.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Other.TooltipText = "TabPage"
        Me.Other.UseThemeTextColor = False
        Me.Other.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE
        Me.Other.Visible = False
        '
        'F_Menu
        '
        Me.F_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.F_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.PrjctMenu, Me.OptionMenu, Me.HelpMenu})
        Me.F_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.F_Menu.Location = New System.Drawing.Point(0, 0)
        Me.F_Menu.Name = "F_Menu"
        Me.F_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.F_Menu.Size = New System.Drawing.Size(1053, 23)
        Me.F_Menu.TabIndex = 1
        Me.F_Menu.Text = "Menu"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ConvertThemeToolStripMenuItem, Me.ToolStripMenuItem7, Me.ToolStripMenuItem11, Me.ToolStripMenuItem10, Me.CloseProjectToolStripMenuItem, Me.ToolStripMenuItem12, Me.ToolStripMenuItem14})
        Me.FileMenu.ForeColor = System.Drawing.Color.Silver
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(40, 19)
        Me.FileMenu.Text = "&FILE"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem9.Text = "New Project"
        '
        'ConvertThemeToolStripMenuItem
        '
        Me.ConvertThemeToolStripMenuItem.Enabled = False
        Me.ConvertThemeToolStripMenuItem.Name = "ConvertThemeToolStripMenuItem"
        Me.ConvertThemeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ConvertThemeToolStripMenuItem.Text = "Convert Theme"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(153, 6)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = CType(resources.GetObject("ToolStripMenuItem11.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem11.Text = "Open Project"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(153, 6)
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.Image = CType(resources.GetObject("CloseProjectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CloseProjectToolStripMenuItem.Text = "Close Project"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(153, 6)
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem14.Text = "Exit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem20, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem21, Me.SelectAllToolStripMenuItem})
        Me.EditMenu.Enabled = False
        Me.EditMenu.ForeColor = System.Drawing.Color.Black
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(43, 19)
        Me.EditMenu.Text = "&EDIT"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(119, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(119, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ColorPickerToolStripMenuItem})
        Me.ViewMenu.ForeColor = System.Drawing.Color.Silver
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(46, 19)
        Me.ViewMenu.Text = "&VIEW"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Checked = True
        Me.ToolStripMenuItem22.CheckOnClick = True
        Me.ToolStripMenuItem22.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem22.Text = "Image Preview"
        '
        'ColorPickerToolStripMenuItem
        '
        Me.ColorPickerToolStripMenuItem.CheckOnClick = True
        Me.ColorPickerToolStripMenuItem.Image = Global.Android_Theme_Studio.My.Resources.Resources.Palette_Colours
        Me.ColorPickerToolStripMenuItem.Name = "ColorPickerToolStripMenuItem"
        Me.ColorPickerToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ColorPickerToolStripMenuItem.Text = "Color Picker"
        '
        'PrjctMenu
        '
        Me.PrjctMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetThemeBackgroundToolStripMenuItem, Me.ToolStripMenuItem8, Me.SetPreviewImageToolStripMenuItem, Me.ToolStripMenuItem13, Me.AddImageToolStripMenuItem, Me.AddTextFileToolStripMenuItem, Me.ToolStripMenuItem15, Me.EditProjectInfoToolStripMenuItem, Me.ChangeTargetPlatformToolStripMenuItem, Me.ToolStripMenuItem19, Me.ImportIconsToolStripMenuItem})
        Me.PrjctMenu.ForeColor = System.Drawing.Color.Silver
        Me.PrjctMenu.Name = "PrjctMenu"
        Me.PrjctMenu.Size = New System.Drawing.Size(67, 19)
        Me.PrjctMenu.Text = "&PROJECT"
        '
        'SetThemeBackgroundToolStripMenuItem
        '
        Me.SetThemeBackgroundToolStripMenuItem.Image = Global.Android_Theme_Studio.My.Resources.Resources.Images
        Me.SetThemeBackgroundToolStripMenuItem.Name = "SetThemeBackgroundToolStripMenuItem"
        Me.SetThemeBackgroundToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SetThemeBackgroundToolStripMenuItem.Text = "Set Theme Wallpaper"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = Global.Android_Theme_Studio.My.Resources.Resources.music_2
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem8.Text = "Set Tones"
        '
        'SetPreviewImageToolStripMenuItem
        '
        Me.SetPreviewImageToolStripMenuItem.Image = CType(resources.GetObject("SetPreviewImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetPreviewImageToolStripMenuItem.Name = "SetPreviewImageToolStripMenuItem"
        Me.SetPreviewImageToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SetPreviewImageToolStripMenuItem.Text = "Set Preview Image"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(198, 6)
        '
        'AddImageToolStripMenuItem
        '
        Me.AddImageToolStripMenuItem.Enabled = False
        Me.AddImageToolStripMenuItem.Name = "AddImageToolStripMenuItem"
        Me.AddImageToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AddImageToolStripMenuItem.Text = "Add Image"
        '
        'AddTextFileToolStripMenuItem
        '
        Me.AddTextFileToolStripMenuItem.Enabled = False
        Me.AddTextFileToolStripMenuItem.Name = "AddTextFileToolStripMenuItem"
        Me.AddTextFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AddTextFileToolStripMenuItem.Text = "Add Text File"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(198, 6)
        '
        'EditProjectInfoToolStripMenuItem
        '
        Me.EditProjectInfoToolStripMenuItem.Image = Global.Android_Theme_Studio.My.Resources.Resources.Information_circle
        Me.EditProjectInfoToolStripMenuItem.Name = "EditProjectInfoToolStripMenuItem"
        Me.EditProjectInfoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EditProjectInfoToolStripMenuItem.Text = "Edit Project Info"
        '
        'ChangeTargetPlatformToolStripMenuItem
        '
        Me.ChangeTargetPlatformToolStripMenuItem.Enabled = False
        Me.ChangeTargetPlatformToolStripMenuItem.Name = "ChangeTargetPlatformToolStripMenuItem"
        Me.ChangeTargetPlatformToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ChangeTargetPlatformToolStripMenuItem.Text = "Change Target Platform"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(198, 6)
        '
        'ImportIconsToolStripMenuItem
        '
        Me.ImportIconsToolStripMenuItem.Enabled = False
        Me.ImportIconsToolStripMenuItem.Name = "ImportIconsToolStripMenuItem"
        Me.ImportIconsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ImportIconsToolStripMenuItem.Text = "Import Icons"
        '
        'OptionMenu
        '
        Me.OptionMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem17, Me.ViewApplicationsDatabaseToolStripMenuItem, Me.ToolStripMenuItem18, Me.APKBrowserToolStripMenuItem})
        Me.OptionMenu.ForeColor = System.Drawing.Color.Silver
        Me.OptionMenu.Name = "OptionMenu"
        Me.OptionMenu.Size = New System.Drawing.Size(69, 19)
        Me.OptionMenu.Text = "&OPTIONS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Android_Theme_Studio.My.Resources.Resources.gear
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(216, 6)
        '
        'ViewApplicationsDatabaseToolStripMenuItem
        '
        Me.ViewApplicationsDatabaseToolStripMenuItem.Image = CType(resources.GetObject("ViewApplicationsDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewApplicationsDatabaseToolStripMenuItem.Name = "ViewApplicationsDatabaseToolStripMenuItem"
        Me.ViewApplicationsDatabaseToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ViewApplicationsDatabaseToolStripMenuItem.Text = "View applications' database"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(216, 6)
        '
        'APKBrowserToolStripMenuItem
        '
        Me.APKBrowserToolStripMenuItem.Enabled = False
        Me.APKBrowserToolStripMenuItem.Name = "APKBrowserToolStripMenuItem"
        Me.APKBrowserToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.APKBrowserToolStripMenuItem.Text = "APK browser"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem16})
        Me.HelpMenu.ForeColor = System.Drawing.Color.Silver
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(47, 19)
        Me.HelpMenu.Text = "&HELP"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem16.Text = "About"
        '
        'OpnPrjDlg
        '
        Me.OpnPrjDlg.AddExtension = False
        Me.OpnPrjDlg.Filter = "Theme Project File (*.DTSTheme)|*.DTSTHeme"
        Me.OpnPrjDlg.Title = "Open Project"
        '
        'AssignStrip
        '
        Me.AssignStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Assigntoimage, Me.assigntocolor})
        Me.AssignStrip.Name = "AssignStrip"
        Me.AssignStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AssignStrip.ShowImageMargin = False
        Me.AssignStrip.ShowItemToolTips = False
        Me.AssignStrip.Size = New System.Drawing.Size(135, 70)
        '
        'Assigntoimage
        '
        Me.Assigntoimage.Enabled = False
        Me.Assigntoimage.Name = "Assigntoimage"
        Me.Assigntoimage.Size = New System.Drawing.Size(134, 22)
        Me.Assigntoimage.Text = "Assign to image"
        '
        'assigntocolor
        '
        Me.assigntocolor.Name = "assigntocolor"
        Me.assigntocolor.Size = New System.Drawing.Size(134, 22)
        Me.assigntocolor.Text = "Assign to color"
        '
        'GradientPanel3
        '
        Me.GradientPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradientPanel3.Angel = 90
        Me.GradientPanel3.BackgroundImage = CType(resources.GetObject("GradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel3.BorderColor = System.Drawing.Color.Empty
        Me.GradientPanel3.Controls.Add(Me.Recent_TV)
        Me.GradientPanel3.Controls.Add(Me.Label1)
        Me.GradientPanel3.Controls.Add(Me.ShapeContainer3)
        Me.GradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel3.Name = "GradientPanel3"
        Me.GradientPanel3.PageEndColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GradientPanel3.PageStartColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GradientPanel3.Size = New System.Drawing.Size(1028, 524)
        Me.GradientPanel3.TabIndex = 1
        '
        'Recent_TV
        '
        Me.Recent_TV.AccessibleName = "TreeView"
        Me.Recent_TV.AccessibleRole = System.Windows.Forms.AccessibleRole.List
        Me.Recent_TV.BorderColor = System.Drawing.Color.Transparent
        Me.Recent_TV.Location = New System.Drawing.Point(11, 55)
        Me.Recent_TV.Name = "Recent_TV"
        Me.Recent_TV.ScrollPosition = New System.Drawing.Point(0, 0)
        Me.Recent_TV.SelectedNode = Nothing
        Me.Recent_TV.Size = New System.Drawing.Size(184, 462)
        Me.Recent_TV.TabIndex = 2
        Me.Recent_TV.Text = "VTreeView1"
        Me.Recent_TV.UseThemeBackColor = False
        Me.Recent_TV.UseThemeBorderColor = False
        Me.Recent_TV.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLACK
        Me.Recent_TV.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICEBLACK
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recent"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1028, 524)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 11
        Me.LineShape3.X2 = 186
        Me.LineShape3.Y1 = 50
        Me.LineShape3.Y2 = 50
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Angel = 90
        Me.GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GradientPanel1.BackgroundImage = CType(resources.GetObject("GradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel1.BorderColor = System.Drawing.Color.Empty
        Me.GradientPanel1.Controls.Add(Me.BTN_FW_EDIT)
        Me.GradientPanel1.Controls.Add(Me.BTN_FW_Replace)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel1.Location = New System.Drawing.Point(4, 4)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.PageEndColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GradientPanel1.PageStartColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.GradientPanel1.Size = New System.Drawing.Size(1021, 31)
        Me.GradientPanel1.TabIndex = 35
        '
        'BTN_FW_EDIT
        '
        Me.BTN_FW_EDIT.AllowAnimations = True
        Me.BTN_FW_EDIT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FW_EDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_FW_EDIT.Image = CType(resources.GetObject("BTN_FW_EDIT.Image"), System.Drawing.Image)
        Me.BTN_FW_EDIT.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_FW_EDIT.Location = New System.Drawing.Point(3, 3)
        Me.BTN_FW_EDIT.Name = "BTN_FW_EDIT"
        Me.BTN_FW_EDIT.RoundedCornersMask = CType(15, Byte)
        Me.BTN_FW_EDIT.ShowFocusRectangle = False
        Me.BTN_FW_EDIT.Size = New System.Drawing.Size(44, 24)
        Me.BTN_FW_EDIT.TabIndex = 2
        Me.BTN_FW_EDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_FW_EDIT.UseAbsoluteImagePositioning = True
        Me.BTN_FW_EDIT.UseVisualStyleBackColor = False
        Me.BTN_FW_EDIT.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_FW_Replace
        '
        Me.BTN_FW_Replace.AllowAnimations = True
        Me.BTN_FW_Replace.BackColor = System.Drawing.Color.Transparent
        Me.BTN_FW_Replace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_FW_Replace.Image = CType(resources.GetObject("BTN_FW_Replace.Image"), System.Drawing.Image)
        Me.BTN_FW_Replace.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_FW_Replace.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_FW_Replace.Location = New System.Drawing.Point(53, 3)
        Me.BTN_FW_Replace.Name = "BTN_FW_Replace"
        Me.BTN_FW_Replace.RoundedCornersMask = CType(15, Byte)
        Me.BTN_FW_Replace.ShowFocusRectangle = False
        Me.BTN_FW_Replace.Size = New System.Drawing.Size(44, 24)
        Me.BTN_FW_Replace.TabIndex = 0
        Me.BTN_FW_Replace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_FW_Replace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_FW_Replace.UseAbsoluteImagePositioning = True
        Me.BTN_FW_Replace.UseVisualStyleBackColor = False
        Me.BTN_FW_Replace.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'GradientPanel2
        '
        Me.GradientPanel2.Angel = 90
        Me.GradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GradientPanel2.BackgroundImage = CType(resources.GetObject("GradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel2.BorderColor = System.Drawing.Color.Empty
        Me.GradientPanel2.Controls.Add(Me.BTN_APP_ADD)
        Me.GradientPanel2.Controls.Add(Me.BTN_APP_EDIT)
        Me.GradientPanel2.Controls.Add(Me.BTN_APP_RMV)
        Me.GradientPanel2.Controls.Add(Me.BTN_APP_Replace)
        Me.GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel2.Location = New System.Drawing.Point(4, 4)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.PageEndColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GradientPanel2.PageStartColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.GradientPanel2.Size = New System.Drawing.Size(1021, 33)
        Me.GradientPanel2.TabIndex = 34
        '
        'BTN_APP_ADD
        '
        Me.BTN_APP_ADD.AllowAnimations = True
        Me.BTN_APP_ADD.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APP_ADD.Image = Global.Android_Theme_Studio.My.Resources.Resources.add
        Me.BTN_APP_ADD.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_APP_ADD.Location = New System.Drawing.Point(3, 3)
        Me.BTN_APP_ADD.Name = "BTN_APP_ADD"
        Me.BTN_APP_ADD.RoundedCornersMask = CType(15, Byte)
        Me.BTN_APP_ADD.ShowFocusRectangle = False
        Me.BTN_APP_ADD.Size = New System.Drawing.Size(44, 24)
        Me.BTN_APP_ADD.TabIndex = 6
        Me.BTN_APP_ADD.TextAbsolutePosition = New System.Drawing.Point(0, 0)
        Me.BTN_APP_ADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_APP_ADD.UseAbsoluteImagePositioning = True
        Me.BTN_APP_ADD.UseVisualStyleBackColor = False
        Me.BTN_APP_ADD.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_APP_EDIT
        '
        Me.BTN_APP_EDIT.AllowAnimations = True
        Me.BTN_APP_EDIT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APP_EDIT.Image = Global.Android_Theme_Studio.My.Resources.Resources.edit
        Me.BTN_APP_EDIT.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_APP_EDIT.Location = New System.Drawing.Point(53, 3)
        Me.BTN_APP_EDIT.Name = "BTN_APP_EDIT"
        Me.BTN_APP_EDIT.RoundedCornersMask = CType(15, Byte)
        Me.BTN_APP_EDIT.ShowFocusRectangle = False
        Me.BTN_APP_EDIT.Size = New System.Drawing.Size(44, 24)
        Me.BTN_APP_EDIT.TabIndex = 5
        Me.BTN_APP_EDIT.TextAbsolutePosition = New System.Drawing.Point(0, 0)
        Me.BTN_APP_EDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_APP_EDIT.UseAbsoluteImagePositioning = True
        Me.BTN_APP_EDIT.UseVisualStyleBackColor = False
        Me.BTN_APP_EDIT.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_APP_RMV
        '
        Me.BTN_APP_RMV.AllowAnimations = True
        Me.BTN_APP_RMV.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APP_RMV.Image = Global.Android_Theme_Studio.My.Resources.Resources.delete
        Me.BTN_APP_RMV.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_APP_RMV.Location = New System.Drawing.Point(153, 3)
        Me.BTN_APP_RMV.Name = "BTN_APP_RMV"
        Me.BTN_APP_RMV.RoundedCornersMask = CType(15, Byte)
        Me.BTN_APP_RMV.ShowFocusRectangle = False
        Me.BTN_APP_RMV.Size = New System.Drawing.Size(44, 24)
        Me.BTN_APP_RMV.TabIndex = 4
        Me.BTN_APP_RMV.TextAbsolutePosition = New System.Drawing.Point(0, 0)
        Me.BTN_APP_RMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_APP_RMV.UseAbsoluteImagePositioning = True
        Me.BTN_APP_RMV.UseVisualStyleBackColor = False
        Me.BTN_APP_RMV.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_APP_Replace
        '
        Me.BTN_APP_Replace.AllowAnimations = True
        Me.BTN_APP_Replace.BackColor = System.Drawing.Color.Transparent
        Me.BTN_APP_Replace.Image = CType(resources.GetObject("BTN_APP_Replace.Image"), System.Drawing.Image)
        Me.BTN_APP_Replace.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_APP_Replace.Location = New System.Drawing.Point(103, 3)
        Me.BTN_APP_Replace.Name = "BTN_APP_Replace"
        Me.BTN_APP_Replace.RoundedCornersMask = CType(15, Byte)
        Me.BTN_APP_Replace.ShowFocusRectangle = False
        Me.BTN_APP_Replace.Size = New System.Drawing.Size(44, 24)
        Me.BTN_APP_Replace.TabIndex = 3
        Me.BTN_APP_Replace.TextAbsolutePosition = New System.Drawing.Point(0, 0)
        Me.BTN_APP_Replace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_APP_Replace.UseAbsoluteImagePositioning = True
        Me.BTN_APP_Replace.UseVisualStyleBackColor = False
        Me.BTN_APP_Replace.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'GradientPanel4
        '
        Me.GradientPanel4.Angel = 90
        Me.GradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GradientPanel4.BackgroundImage = CType(resources.GetObject("GradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel4.BorderColor = System.Drawing.Color.Empty
        Me.GradientPanel4.Controls.Add(Me.BTN_Assign)
        Me.GradientPanel4.Controls.Add(Me.BTN_xml_editItemValue)
        Me.GradientPanel4.Controls.Add(Me.BTN_xml_editAttrValue)
        Me.GradientPanel4.Controls.Add(Me.Btn_xml_delItem)
        Me.GradientPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanel4.Location = New System.Drawing.Point(4, 4)
        Me.GradientPanel4.Name = "GradientPanel4"
        Me.GradientPanel4.PageEndColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GradientPanel4.PageStartColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.GradientPanel4.Size = New System.Drawing.Size(1021, 33)
        Me.GradientPanel4.TabIndex = 35
        '
        'BTN_Assign
        '
        Me.BTN_Assign.AllowAnimations = True
        Me.BTN_Assign.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Assign.Image = Global.Android_Theme_Studio.My.Resources.Resources.tag
        Me.BTN_Assign.ImageAbsolutePosition = New System.Drawing.Point(16, 5)
        Me.BTN_Assign.Location = New System.Drawing.Point(153, 3)
        Me.BTN_Assign.Name = "BTN_Assign"
        Me.BTN_Assign.RoundedCornersMask = CType(15, Byte)
        Me.BTN_Assign.ShowFocusRectangle = False
        Me.BTN_Assign.Size = New System.Drawing.Size(61, 24)
        Me.BTN_Assign.StyleKey = "SplitButton"
        Me.BTN_Assign.TabIndex = 6
        Me.BTN_Assign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_Assign.UseVisualStyleBackColor = False
        Me.BTN_Assign.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_xml_editItemValue
        '
        Me.BTN_xml_editItemValue.AllowAnimations = True
        Me.BTN_xml_editItemValue.BackColor = System.Drawing.Color.Transparent
        Me.BTN_xml_editItemValue.Image = Global.Android_Theme_Studio.My.Resources.Resources.edit
        Me.BTN_xml_editItemValue.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_xml_editItemValue.Location = New System.Drawing.Point(3, 3)
        Me.BTN_xml_editItemValue.Name = "BTN_xml_editItemValue"
        Me.BTN_xml_editItemValue.RoundedCornersMask = CType(15, Byte)
        Me.BTN_xml_editItemValue.ShowFocusRectangle = False
        Me.BTN_xml_editItemValue.Size = New System.Drawing.Size(44, 24)
        Me.BTN_xml_editItemValue.TabIndex = 5
        Me.BTN_xml_editItemValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_xml_editItemValue.UseAbsoluteImagePositioning = True
        Me.BTN_xml_editItemValue.UseVisualStyleBackColor = False
        Me.BTN_xml_editItemValue.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'BTN_xml_editAttrValue
        '
        Me.BTN_xml_editAttrValue.AllowAnimations = True
        Me.BTN_xml_editAttrValue.BackColor = System.Drawing.Color.Transparent
        Me.BTN_xml_editAttrValue.Image = CType(resources.GetObject("BTN_xml_editAttrValue.Image"), System.Drawing.Image)
        Me.BTN_xml_editAttrValue.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.BTN_xml_editAttrValue.Location = New System.Drawing.Point(53, 3)
        Me.BTN_xml_editAttrValue.Name = "BTN_xml_editAttrValue"
        Me.BTN_xml_editAttrValue.RoundedCornersMask = CType(15, Byte)
        Me.BTN_xml_editAttrValue.ShowFocusRectangle = False
        Me.BTN_xml_editAttrValue.Size = New System.Drawing.Size(44, 24)
        Me.BTN_xml_editAttrValue.TabIndex = 4
        Me.BTN_xml_editAttrValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTN_xml_editAttrValue.UseAbsoluteImagePositioning = True
        Me.BTN_xml_editAttrValue.UseVisualStyleBackColor = False
        Me.BTN_xml_editAttrValue.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'Btn_xml_delItem
        '
        Me.Btn_xml_delItem.AllowAnimations = True
        Me.Btn_xml_delItem.BackColor = System.Drawing.Color.Transparent
        Me.Btn_xml_delItem.Image = Global.Android_Theme_Studio.My.Resources.Resources.delete1
        Me.Btn_xml_delItem.ImageAbsolutePosition = New System.Drawing.Point(12, 4)
        Me.Btn_xml_delItem.Location = New System.Drawing.Point(103, 3)
        Me.Btn_xml_delItem.Name = "Btn_xml_delItem"
        Me.Btn_xml_delItem.RoundedCornersMask = CType(15, Byte)
        Me.Btn_xml_delItem.ShowFocusRectangle = False
        Me.Btn_xml_delItem.Size = New System.Drawing.Size(44, 24)
        Me.Btn_xml_delItem.TabIndex = 3
        Me.Btn_xml_delItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_xml_delItem.UseAbsoluteImagePositioning = True
        Me.Btn_xml_delItem.UseVisualStyleBackColor = False
        Me.Btn_xml_delItem.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.STEEL
        '
        'Main_Form
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1053, 607)
        Me.Controls.Add(Me.F_Menu)
        Me.Controls.Add(Me.Tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1069, 646)
        Me.Name = "Main_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Droid Theme Studio"
        Me.Tabs.ResumeLayout(False)
        Me.Welcome.ResumeLayout(False)
        Me.Framework_Applications.ResumeLayout(False)
        Me.Framework_Applications.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.IMG_PRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppIcons.ResumeLayout(False)
        Me.AppIcons.PerformLayout()
        Me.xml.ResumeLayout(False)
        Me.xml.PerformLayout()
        Me.Extra.ResumeLayout(False)
        Me.Tabs2.ResumeLayout(False)
        Me.Tones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.F_Menu.ResumeLayout(False)
        Me.F_Menu.PerformLayout()
        Me.AssignStrip.ResumeLayout(False)
        Me.GradientPanel3.ResumeLayout(False)
        Me.GradientPanel3.PerformLayout()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel2.ResumeLayout(False)
        Me.GradientPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetHomescreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetTonesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tabs As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents AppIcons As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents F_Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrjctMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetThemeBackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetPreviewImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditProjectInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeTargetPlatformToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xml As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewApplicationsDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Framework_Applications As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents APKBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Framework_LV As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents CB_FWA As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Extra As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents APPIcons_LV As System.Windows.Forms.ListView
    Friend WithEvents OpnFileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Welcome As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents ColorPickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tabs2 As VIBlend.WinForms.Controls.vTabControl
    Friend WithEvents Tones As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Images As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Texts As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents Other As VIBlend.WinForms.Controls.vTabPage
    Friend WithEvents IMG_PRV As System.Windows.Forms.PictureBox
    Friend WithEvents GradientPanel2 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents BTN_FW_Replace As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_FW_EDIT As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_APP_EDIT As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_APP_Replace As VIBlend.WinForms.Controls.vButton
    Friend WithEvents GradientPanel3 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents GradientPanel1 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Recent_TV As VIBlend.WinForms.Controls.vTreeView
    Public WithEvents OpnPrjDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GradientPanel4 As Android_Theme_Studio.GradientPanel.GradientPanel
    Friend WithEvents BTN_Assign As VIBlend.WinForms.Controls.vSplitButton
    Friend WithEvents BTN_xml_editItemValue As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_xml_editAttrValue As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Btn_xml_delItem As VIBlend.WinForms.Controls.vButton
    Friend WithEvents CB_XMLDirs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LV_XMLattrs As System.Windows.Forms.ListView
    Friend WithEvents AttributeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents AttributeValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV_XMLITEMS As System.Windows.Forms.ListView
    Friend WithEvents NodeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents CB_xmlFiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_APP_RMV As VIBlend.WinForms.Controls.vButton
    Friend WithEvents BTN_APP_ADD As VIBlend.WinForms.Controls.vButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_RNGNAME As System.Windows.Forms.Label
    Friend WithEvents LBL_RNGDUR As System.Windows.Forms.Label
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents AssignStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Assigntoimage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents assigntocolor As System.Windows.Forms.ToolStripMenuItem



End Class
