Public NotInheritable Class About
   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Text)
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_ver.Text = My.Application.Info.Version.ToString
    End Sub
End Class
