Option Explicit On
Imports System.Xml
Imports WindowsFormsAero.TaskDialog

Public Class FRMDB
    Public Sub loadDB()
        On Error GoTo err

        Dim xmldoc As New XmlDataDocument()

        Dim XmlNode As XmlNodeList

        xmldoc.Load(Database)

        XmlNode = xmldoc.GetElementsByTagName("Applications_database")

        Dim i As Integer

        For i = 0 To XmlNode(0).ChildNodes.Count - 1
            lst_apps.Items.Add(XmlNode(0).ChildNodes(i).Attributes(0).Value).SubItems.Add((XmlNode(0).ChildNodes(i).InnerXml))
        Next
err:
        If Err.Number = 0 Or 20 Then
            Resume Next
        Else
            If TaskDialog.Show("Can't Resume", "ERROR", "Error Number = " & Err.Number & vbNewLine & "Error Description: " + Err.Description, WindowsFormsAero.TaskDialog.TaskDialogButton.Retry + WindowsFormsAero.TaskDialog.TaskDialogButton.Close, TaskDialogIcon.Stop) = Result.Retry Then
                loadDB()
            Else
                End
            End If
        End If
       
    End Sub
    Private Sub FRMDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadDB()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FRM_newapp.ShowDialog()
        loadDB()
    End Sub

    Public Sub filter(ByVal value As String)
        If Op_APP.Checked = True Then
            For Each item As ListViewItem In lst_apps.Items
                If Not item.Text = value Then
                    item.Remove()
                End If
            Next
        ElseIf OP_PACK.Checked = True Then
            For Each item As ListViewItem In lst_apps.Items
                If Not item.SubItems(1).Text = value Then
                    item.Remove()
                End If
            Next
        End If

    End Sub

    Private Sub SearchTextBox1_SearchCancelled(sender As Object, e As EventArgs) Handles SearchTextBox1.SearchCancelled
        lst_apps.Items.Clear()
        loadDB()
    End Sub

    Private Sub SearchTextBox1_SearchStarted(sender As Object, e As EventArgs) Handles SearchTextBox1.SearchStarted
        If SearchTextBox1.Text <> Nothing Then
            filter(SearchTextBox1.Text)
        ElseIf SearchTextBox1.Text = Nothing Then
            lst_apps.Items.Clear()
            loadDB()
        End If
    End Sub

    Private Sub Brn_reload_Click(sender As Object, e As EventArgs) Handles Brn_reload.Click
        lst_apps.Items.Clear()
        loadDB()
    End Sub
End Class