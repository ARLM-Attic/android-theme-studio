Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.WindowsAPICodePack.Shell.PropertySystem
Imports MS.WindowsAPICodePack.Internal
Imports Android_Theme_Studio
Imports Android_Theme_Studio.InnerSetting
Imports Android_Theme_Studio.NewProject
Imports Android_Theme_Studio.constants
Imports System.Xml
Imports VIBlend.Utilities
Imports ColorPicker
Imports ColorPickerControls

Public Module PublicModule
    Public IsLoadingProject As Boolean
    Public IsProjectLoading As Boolean
    Public Org_Framwork_LW As New ListView

    Public OPnFldrDLG As New CommonOpenFileDialog With {.IsFolderPicker = True _
                                                       , .DefaultDirectory = SaveLocation _
                                                       , .Title = Main_Form.Text _
                                                       , .ShowPlacesList = True _
                                                       , .EnsureFileExists = True}
    Public AdvColorDialog As New ColorPickerControls.Dialogs.ColorPickerFullWithAlphaDialog
End Module
Public Module theming
    Public Sub loadThmes()


    End Sub
End Module

Public Module Declaration
#Region "locations"
    Public Sttings_Dir As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Android Theme Studio\Settings.DTSSettings"
    Public Recent_projects_list As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Android Theme Studio\RecentProjects.DTSSettings"
    Public RecentColors_Dir As String = My.Application.Info.DirectoryPath.ToString + "\RecentColors.DTSSettings"
    Public Database As String = My.Application.Info.DirectoryPath.ToString + "\applicationsDB.DTSSettings"
    Public RawFiles_Path As String = My.Application.Info.DirectoryPath + "\RawFiles"
#End Region
#Region "SETTINGS" 
    Public CloseWBAfterOpen As String
    Public RecentListItemsNo As Integer
    Public SaveLocation As String
    Public Username As String
    Public PackageName As String
    Public Copyright As String
    Public ApktoolDir As String
    Public SzDir As String
#End Region
End Module