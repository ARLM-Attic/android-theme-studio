Imports Android_Theme_Studio.Application_procedures
Public Class FRM_newapp
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtName.Text <> "" And txtPackname.Text <> "" Then
            Add_application(TxtName.Text, txtPackname.Text)
            Me.Close()
        ElseIf TxtName.Text <> "" Or txtPackname.Text <> "" Then
            MsgBox("Sorry, You can not leave neither application name nor package name fields empty!")
        End If

    End Sub
    Sub retrive()

    End Sub
    Sub save()

    End Sub
    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPackname.Focus()
        End If
    End Sub
 
    Private Sub txtPackname_KeyPress(sender As Object, e As KeyEventArgs) Handles txtPackname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub FRM_newapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrive()
    End Sub
End Class