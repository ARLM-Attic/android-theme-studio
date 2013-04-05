Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Android_Theme_Studio.InnerSetting
Imports WindowsFormsAero.TaskDialog
Imports System.Threading
Imports Android_Theme_Studio.constants
Imports Android_Theme_Studio.Application_procedures
Imports Android_Theme_Studio.loadProject
Imports Android_Theme_Studio.XML_Builder.XML_procedures
Imports Android_Theme_Studio.XML_Builder.otherprocedures

Public Class Main_Form
    Public Shared dest As String
#Region "SHOW/HIDE"
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
        Settings.Owner = Me
    End Sub
    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        About.Show()
        About.Owner = Me
    End Sub
    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        FRM_NEWPRJCT.ShowDialog()
        FRM_NEWPRJCT.Owner = Me
    End Sub
    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        End
    End Sub
    Private Sub ViewApplicationsDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewApplicationsDatabaseToolStripMenuItem.Click
        FRMDB.Show()
        FRMDB.Owner = Me
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        FRMTONES.ShowDialog()
    End Sub
    Private Sub EditProjectInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProjectInfoToolStripMenuItem.Click
        FRMDTAILS.ShowDialog()
    End Sub
    Private Sub ColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorPickerToolStripMenuItem.Click
        If Color_Picker.Visible = False Then
            Color_Picker.Visible = True
        ElseIf Color_Picker.Visible = True Then
            Color_Picker.Dispose()
        End If

    End Sub
    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        If img_prev.Visible = False Then
            img_prev.Visible = True
        ElseIf img_prev.Visible = True Then
            img_prev.Dispose()
        End If
    End Sub
    Private Sub AddTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTextFileToolStripMenuItem.Click
        OpnFileDlg.ShowDialog()
        Application_procedures.Import_File(OpnFileDlg.FileName, Application_procedures.File_ImpTypes.Text)
    End Sub
    Private Sub AddImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddImageToolStripMenuItem.Click
        OpnFileDlg.ShowDialog()
        Application_procedures.Import_File(OpnFileDlg.FileName, Application_procedures.File_ImpTypes.Img)
    End Sub
    Private Sub SetPreviewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPreviewImageToolStripMenuItem.Click
        OpnFileDlg.ShowDialog()
        Application_procedures.Import_File(OpnFileDlg.FileName, Application_procedures.File_ImpTypes.PreviewImg)
    End Sub
    Private Sub SetThemeBackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetThemeBackgroundToolStripMenuItem.Click
        OpnFileDlg.ShowDialog()
        Application_procedures.Import_File(OpnFileDlg.FileName, Application_procedures.File_ImpTypes.Wallpaper)
    End Sub
#End Region
    Dim WorkerThread As Thread
    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Main_Form_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        move_img_prev()
    End Sub
    Private Sub Main_Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        move_img_prev()
    End Sub
    Sub move_img_prev()
        Dim x, y As Integer
        x = Me.Location.X + Me.Size.Width - img_prev.Width - 26
        y = Me.Location.Y + 108
        img_prev.Location = New Point(x, y)
    End Sub
    Private Sub Main_Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        move_img_prev()
    End Sub
    Private Sub CloseProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseProjectToolStripMenuItem.Click
        UnloadProject.Unload()
    End Sub
    Private Sub ThreadTask()
        Me.Invoke(New MethodInvoker(AddressOf InvokeMainForm))
    End Sub
    Private Sub InvokeMainForm()
        
        loadProject.load(dest, System.IO.Path.GetDirectoryName(dest))
        GC.Collect()
        IsProjectLoading = False
        WorkerThread.Abort()
    End Sub
    Sub Threadstart()
        WorkerThread = New Thread(AddressOf ThreadTask)
        WorkerThread.IsBackground = True
        WorkerThread.Priority = ThreadPriority.Highest
        WorkerThread.Start()
    End Sub
 
    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        If OpnPrjDlg.ShowDialog = DialogResult.OK Then
            dest = OpnPrjDlg.FileName
            IsProjectLoading = True
            LoadingProject.ShowDialog()
            Threadstart()
        End If
    End Sub
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Splash_screen.Show()
        BTN_Assign.DropDownMenu = Me.AssignStrip
        Me.Hide()

        img_prev.Show()
        img_prev.Owner = Me
        Me.move_img_prev()
    End Sub
    Private Sub CB_FWA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FWA.SelectedIndexChanged
        If IsLoadingProject = False Then
            Framework_LV.Clear() 
            CloneListview(ReFilter_LV(Org_Framwork_LW, CB_FWA.SelectedItem.ToString), Framework_LV)
        Else
            Exit Sub
        End If 
    End Sub
    Private Sub BTN_FW_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_FW_EDIT.Click

        Image_Editor.MYImage = Drawable_HDPI & "\" & Framework_LV.SelectedItems(0).Text.ToString
        Image_Editor.loadImage()
        Image_Editor.Show()
    End Sub
    Private Sub Framework_LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Framework_LV.SelectedIndexChanged
        On Error Resume Next
        img_prev.MYIMG.Image = Image.FromFile(Drawable_HDPI & "\" & Framework_LV.SelectedItems(0).Text.ToString)
        img_prev.MYIMG.Name = Framework_LV.Items(Framework_LV.FocusedItem.Index).SubItems(0).Text()
        img_prev.Timer1.Enabled = True
    End Sub
    Private Sub BTN_FW_Replace_Click(sender As Object, e As EventArgs) Handles BTN_FW_Replace.Click
        Dim opnfileDLG As New OpenFileDialog With {.Filter = "Image File (*.PNG)|*.Png" _
                                                  , .Multiselect = False}
        If opnfileDLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(opnfileDLG.FileName, Drawable_HDPI & "\" & Framework_LV.SelectedItems(0).Text.ToString)
        End If
    End Sub
    Private Sub VButton5_Click(sender As Object, e As EventArgs) Handles BTN_APP_ADD.Click
        Dim opnfileDLG As New OpenFileDialog With {.Filter = "Image File (*.PNG)|*.Png" _
                                           , .Multiselect = False}
        If opnfileDLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(opnfileDLG.FileName, Mipmap_hDPI & "\" & IO.Path.GetFileName(opnfileDLG.FileName))
            Add_ApplicationIcon(IO.Path.GetFileName(opnfileDLG.FileName))
        End If
    End Sub

    Private Sub BTN_APP_Replace_Click(sender As Object, e As EventArgs) Handles BTN_APP_Replace.Click
        Dim opnfileDLG As New OpenFileDialog With {.Filter = "Image File (*.PNG)|*.Png" _
                                          , .Multiselect = False}
        If opnfileDLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(opnfileDLG.FileName, Drawable_HDPI & "\" & APPIcons_LV.SelectedItems(0).Text.ToString)
        End If
    End Sub

    Private Sub BTN_APP_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_APP_EDIT.Click
        Image_Editor.MYImage = Drawable_HDPI & "\" & APPIcons_LV.SelectedItems(0).Text.ToString
        Image_Editor.loadImage()
        Image_Editor.Show()
    End Sub

    Private Sub BTN_APP_RMV_Click(sender As Object, e As EventArgs) Handles BTN_APP_RMV.Click
        Remove_ApplicationIcon(APPIcons_LV.SelectedItems(0).Text.ToString)
        APPIcons_LV.SelectedItems(0).Remove()
    End Sub

    Private Sub APPIcons_LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles APPIcons_LV.SelectedIndexChanged
        On Error Resume Next
        img_prev.MYIMG.Image = Image.FromFile(Mipmap_hDPI & "\" & APPIcons_LV.SelectedItems(0).Text.ToString)
        img_prev.MYIMG.Name = APPIcons_LV.Items(APPIcons_LV.FocusedItem.Index).SubItems(0).Text()
        img_prev.Timer1.Enabled = True
    End Sub

    Private Sub CB_XMLDirs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_XMLDirs.SelectedIndexChanged
        If Not IsLoadingProject = True Then
            CB_xmlFiles.Items.Clear()
            CB_xmlFiles.Items.AddRange(LoadDirectoryFiles(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem, "*.xml"))
            CB_xmlFiles.SelectedIndex = 0
            GC.Collect()
        End If
    End Sub

    Private Sub CB_xmlFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_xmlFiles.SelectedIndexChanged
        If Not IsLoadingProject = True Then
            loadXmlIems(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, LV_XMLITEMS)
        End If

    End Sub

    Private Sub LV_XMLITEMS_ItemActivate(sender As Object, e As EventArgs) Handles LV_XMLITEMS.ItemActivate
        LoadXMLItem_attributes(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, LV_XMLITEMS.SelectedItems(0).SubItems(1).Text, LV_XMLattrs)
    End Sub

    Private Sub BTN_xml_editItemValue_Click(sender As Object, e As EventArgs) Handles BTN_xml_editItemValue.Click
        Frm_XMLEditor.EditedText = LV_XMLITEMS.SelectedItems(0).SubItems(1).Text
        Frm_XMLEditor.ShowDialog()
        Edit_node_Value(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, GetXmlTagName(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem), _
                         EditType.Value, LV_XMLITEMS.SelectedItems(0).SubItems(1).Text, Frm_XMLEditor.EditedText)
    End Sub

    Private Sub BTN_xml_editAttrValue_Click(sender As Object, e As EventArgs) Handles BTN_xml_editAttrValue.Click
        Frm_XMLEditor.EditedText = LV_XMLattrs.SelectedItems(0).SubItems(1).Text
        Frm_XMLEditor.ShowDialog()
        Edit_Node_attr(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, GetXmlTagName(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem), _
                       EditType.Value, LV_XMLattrs.SelectedItems(0).SubItems(1).Text, Frm_XMLEditor.EditedText)
    End Sub

    Private Sub Btn_xml_delItem_Click(sender As Object, e As EventArgs) Handles Btn_xml_delItem.Click

        DEL_XML_node(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, GetXmlTagName(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem), _
                       LV_XMLITEMS.SelectedItems(0).SubItems(1).Text, "")
    End Sub

    Private Sub Assigntoimage_Click(sender As Object, e As EventArgs) Handles Assigntoimage.Click

    End Sub

    Private Sub assigntocolor_Click(sender As Object, e As EventArgs) Handles assigntocolor.Click
        RecentColors.ShowDialog()
        If Not RecentColors.SelectedColor = Nothing Then
            Edit_node_Value(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem, GetXmlTagName(CurrentProject_dir & "\res\" & CB_XMLDirs.SelectedItem & "\" & CB_xmlFiles.SelectedItem), _
                             EditType.Value, LV_XMLITEMS.SelectedItems(0).SubItems(1).Text, Drawing.ColorTranslator.ToHtml(RecentColors.SelectedColor))
        Else
            Exit Sub
        End If
    End Sub
End Class