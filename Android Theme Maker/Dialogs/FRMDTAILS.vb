Imports Android_Theme_Studio.XML_Builder.PropertiesProcedures

Public Class FRMDTAILS

    Friend Sub retrive()
        TXT_Auth.Text = constants.ThemeAuthor
        TXT_NAM.Text = constants.ThemeName
        TXT_Ver.Text = constants.ThemeVersion
    End Sub
    Friend Sub save()
        SetProperty_Author(TXT_Auth.Text)
        SetProperty_Name(TXT_NAM.Text)
        SetProperty_Version(TXT_Ver.Text)
    End Sub
    Private Sub FRMDTAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrive()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        save()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class