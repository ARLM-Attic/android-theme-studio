
Public Class FRMTONES
    Dim SoundDir As String
    Public Shared Sub retrive()

    End Sub
    Public Shared Sub AddFiles()


    End Sub
    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        If OPN_FILE_dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Txt_RING.Text = OPN_FILE_dlg.FileName
        End If
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        If OPN_FILE_dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Txt_alrm.Text = OPN_FILE_dlg.FileName
        End If
    End Sub

    Private Sub VButton3_Click(sender As Object, e As EventArgs) Handles VButton3.Click
        If OPN_FILE_dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            TXT_notifi.Text = OPN_FILE_dlg.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub FRMTONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class