Public Class Frm_XMLEditor
    Public Shared Property Edited As Boolean
    Private Shared _EditedText As String
    Public Shared Property EditedText As String
        Get
            Return _EditedText
        End Get
        Set(value As String)
            _EditedText = value

        End Set
    End Property

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles BTN_CANcEL.Click
        Me.Close()
    End Sub

    Private Sub Frm_XMLEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit.Text = EditedText
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles BTN_APPLY.Click
        EditedText = TextEdit.Text
        Me.Close()
    End Sub
End Class