Imports System.IO
Imports System.IO.Packaging
Imports System.Xml
Imports Android_Theme_Studio.constants
Imports Android_Theme_Studio.InnerSetting
Imports Android_Theme_Studio.Application_procedures
Imports System.Threading

Public Enum ProjectPlatforms
    Cyanogenmod10_1
    Cyanogenmod10
    Cyanogenmod9
    Cyanogenmod7
    AOKP
    AOKP_ICS
    AOKP_JP
    Miui_GB
    MiUi_V4
    MiUi_JB
    IconPack
End Enum
Public Class constants
    Public Shared ThemeName, Platform, ThemeVersion, ThemeAuthor, Preview, Resolution _
        , WAllpaper, Ringtone, Alarm, Notification, Xml, values _
         , Drawable, Drawable_LDPI, Drawable_MDPI, Drawable_HDPI, Drawable_xHDPI _
          , Drawable_NoDPI, Dcolors, Mipmap_hDPI, Mipmap_xhDPI As String

    Public Shared CurrentProject, CurrentProject_dir As String
End Class
Public Class NewProject
    Public Shared PRj_Destination As String
    Private Shared PRJFile As String = Nothing
    Shared Sub extractRawFiles(ByVal platform As String, ByVal projPath As String)
        Dim Zip As String = Nothing

        Select Case platform
            Case "CyanogenMod 10"
                Zip = RawFiles_Path + "\CM10_RAW_.7z"
            Case "CyanogenMod 9"
                Zip = RawFiles_Path + "\CM9_AOKP_RAW_.7z"
            Case "AOKP_ICS"
                Zip = RawFiles_Path + "\CM9_AOKP_RAW_.7z"
        End Select

        Zip = Zip + " -y"
        Dim Arg As String = "x -o"

        Clipboard.SetText((Arg + projPath + " " + Zip))
        Process.Start(SzDir, Arg + projPath + " " + Zip)
    End Sub ''Done
    Shared Sub CreateProject(ByVal Destination As String, ByVal ProjName As String)
        PRj_Destination = Destination + "\" + ProjName
        IO.Directory.CreateDirectory(PRj_Destination)

        IO.File.WriteAllText(PRj_Destination + "\" + ProjName + ".DTSTheme", My.Resources.Theme_Project)
        PRJFile = PRj_Destination + "\" + ProjName + ".DTSTheme"
        extractRawFiles(Platform, PRj_Destination)

        FillData()
    End Sub ''Done
    Public Shared Sub FillData()
        Dim xmldoc As New XmlDataDocument()

        Dim XmlNode As XmlNodeList

        xmldoc.Load(PRJFile)

        XmlNode = xmldoc.GetElementsByTagName("Properties")
        XmlNode(0).Attributes(0).Value = Platform
        XmlNode(0).Attributes(1).Value = Resolution
        XmlNode(0).ChildNodes(0).InnerXml = ThemeName
        XmlNode(0).ChildNodes(1).InnerXml = ThemeVersion
        XmlNode(0).ChildNodes(2).InnerXml = ThemeAuthor
        XmlNode(0).ChildNodes(3).InnerXml = Platform

        xmldoc.Save(PRJFile)


    End Sub ''Done    
End Class ''Done

Public Class loadProject

    '//Finish Load INto APP
  
    Public Shared Sub load(ByVal project As String, ByVal destination As String)


        CurrentProject = project
        CurrentProject_dir = destination
        loadConsts()
        loadIntoAPP()

    End Sub
    Public Shared Sub loadConsts()
        Dim xmldoc As New XmlDataDocument()

        Dim XmlNode As XmlNodeList

        xmldoc.Load(CurrentProject)

        XmlNode = xmldoc.GetElementsByTagName("Properties")
        Platform = XmlNode(0).Attributes(0).Value
        Resolution = XmlNode(0).Attributes(1).Value
        ThemeName = XmlNode(0).ChildNodes(0).InnerXml
        ThemeVersion = XmlNode(0).ChildNodes(1).InnerXml
        ThemeAuthor = XmlNode(0).ChildNodes(2).InnerXml
        Platform = XmlNode(0).ChildNodes(3).InnerXml


        XmlNode = xmldoc.GetElementsByTagName("Customizing")
        Preview = XmlNode(0).ChildNodes(0).InnerXml
        WAllpaper = XmlNode(0).ChildNodes(1).InnerXml
        Ringtone = XmlNode(0).ChildNodes(2).InnerXml
        Alarm = XmlNode(0).ChildNodes(3).InnerXml
        Notification = XmlNode(0).ChildNodes(4).InnerXml


        Xml = CurrentProject_dir + "\res\xml"
        values = CurrentProject_dir + "\res\values"
        Drawable = CurrentProject_dir + "\res\Drawable"
        Drawable_LDPI = CurrentProject_dir + "\res\Drawable-LDPI"
        Drawable_MDPI = CurrentProject_dir + "\res\Drawable-MDPI"
        Drawable_HDPI = CurrentProject_dir + "\res\Drawable-HDPI"
        Drawable_xHDPI = CurrentProject_dir + "\res\Drawable-xHDPI"
        Drawable_NoDPI = CurrentProject_dir + "\res\Drawable-NoDPI"
        Dcolors = CurrentProject_dir + "\res\color"
        Mipmap_hDPI = CurrentProject_dir + "\res\Mipmap-hDPI"
        Mipmap_xhDPI = CurrentProject_dir + "\res\Mipmap-xhDPI"
    End Sub
    Public Shared Sub loadIntoAPP()
        IsLoadingProject = True
        Main_Form.Text = ThemeName + " - " + Main_Form.Text
        
        Main_Form.CB_FWA.Items.AddRange(filter_apps(Drawable_HDPI, "*.png"))
        Main_Form.CB_FWA.SelectedIndex = 0


        Main_Form.CB_XMLDirs.Items.AddRange(CheckForExtension(CurrentProject_dir & "\res", "*.xml"))
        Main_Form.CB_XMLDirs.SelectedIndex = 0


        Main_Form.CB_xmlFiles.Items.AddRange(LoadDirectoryFiles(Main_Form.CB_XMLDirs.SelectedItem, "*.xml"))
        Main_Form.CB_xmlFiles.SelectedIndex = 0

        Dim arr As New ArrayList
        For x As Integer = 0 To Main_Form.CB_XMLDirs.Items.Count - 1
            arr.Add(Main_Form.CB_XMLDirs.Items(x))
        Next
        Main_Form.CB_XMLDirs.Items.Clear()

        For i As Integer = 0 To arr.Count - 1
            Dim x As String() = arr(i).ToString.Split("\")
            Dim y As Integer = x.Length - 1
            Main_Form.CB_XMLDirs.Items.Add(x(y))
        Next
        Main_Form.CB_XMLDirs.SelectedIndex = 0

        loadXmlIems(CurrentProject_dir & "\res\" & Main_Form.CB_XMLDirs.SelectedItem & "\" & Main_Form.CB_xmlFiles.SelectedItem, Main_Form.LV_XMLITEMS)

        Pubulate_LV(Org_Framwork_LW, Drawable_HDPI)
        CloneListview(Org_Framwork_LW, Main_Form.Framework_LV)
        Filter_LV(Main_Form.Framework_LV, Main_Form.CB_FWA.SelectedItem.ToString)
        Pubulate_LV(Main_Form.APPIcons_LV, Mipmap_hDPI)
       
        GC.Collect()
    End Sub
End Class
Public Class SaveProject

End Class
Public Class UnloadProject
    Public Shared Sub Unload()

        'clear all controls data
        'reset main form name
        ThemeName = Nothing
        Platform = Nothing
        ThemeVersion = Nothing
        ThemeAuthor = Nothing
        Preview = Nothing
        Resolution = Nothing
        WAllpaper = Nothing
        Ringtone = Nothing
        Alarm = Nothing
        Notification = Nothing
        Xml = Nothing
        values = Nothing
        Drawable = Nothing
        Drawable_LDPI = Nothing
        Drawable_MDPI = Nothing
        Drawable_HDPI = Nothing
        Drawable_xHDPI = Nothing
        Drawable_NoDPI = Nothing
        Dcolors = Nothing
        Mipmap_hDPI = Nothing
        Mipmap_xhDPI = Nothing
        CurrentProject = Nothing
        CurrentProject_dir = Nothing
        Main_Form.Text = "Droid Theme Studio"
        Main_Form.CB_FWA.Items.Clear()
        Main_Form.CB_FWA.Text = Nothing
        Main_Form.Framework_LV.Items.Clear()
        Main_Form.APPIcons_LV.Items.Clear()
        Main_Form.LBL_RNGNAME = Nothing
        Main_Form.LBL_RNGNAME = Nothing
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Main_Form Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        GC.Collect()
    End Sub
End Class