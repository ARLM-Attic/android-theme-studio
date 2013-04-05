Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.WindowsAPICodePack.Shell.PropertySystem
Imports MS.WindowsAPICodePack.Internal
Imports Android_Theme_Studio.InnerSetting
Imports Android_Theme_Studio.NewProject
Imports Android_Theme_Studio.constants
Imports Android_Theme_Studio.PublicModule
Public Class FRM_NEWPRJCT

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ThemeName = Txt_Name.Text
        ThemeAuthor = Txt_auth.Text
        ThemeVersion = Txt_ver.Text
        Platform = Txt_plat.Text
        Resolution = Txt_res.Text
        CreateProject(Txt_Dir.Text, Txt_Name.Text)
        loadProject.load(Txt_Dir.Text + "\" + Txt_Name.Text + "\" + Txt_Name.Text + ".DTSTheme", Txt_Dir.Text + "\" + Txt_Name.Text + "\")
        Me.Close()
    End Sub

    Private Sub Btn_Brws_Click(sender As Object, e As EventArgs) Handles Btn_Brws.Click
        If OPnFldrDLG.ShowDialog() = CommonFileDialogResult.Ok Then
            Txt_Dir.Text = OPnFldrDLG.FileName
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub FRM_NEWPRJCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class