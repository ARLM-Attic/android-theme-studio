Imports System.Xml

Public Class Settings
    Private Sub VTreeView1_AfterSelect(sender As Object, e As VIBlend.WinForms.Controls.vTreeViewEventArgs)
        Select Case VTreeView1.SelectedNode.Text
            Case "General"
                General_Panle.BringToFront()
            Case "Projects"
                Projects_Panel.BringToFront()
            Case "Compile"
                Compile_Panle.BringToFront()
        End Select
    End Sub
    Private Sub BTN_FixFileAss_Click(sender As Object, e As EventArgs) Handles BTN_FixFileAss.Click
        Process.Start(Application.StartupPath + "\File_Association.exe")
    End Sub
    Sub loadSettings()
        TXT_7ZDir.Text = SzDir
        TXT_APKTDir.Text = ApktoolDir
        TXT_CP.Text = Copyright
        txt_RcntNum.Text = RecentListItemsNo
        TXT_UN.Text = Username
        txt_Prjctloc.Text = SaveLocation
        Txt_DFLTPCKJNM.Text = PackageName
        CHK_CWBOnLoad.Checked = CloseWBAfterOpen
    End Sub
    Sub Save()
        Dim xmldoc As New XmlDataDocument()

        Dim XmlNode As XmlNodeList

        xmldoc.Load(Sttings_Dir)

        XmlNode = xmldoc.GetElementsByTagName("General")
        XmlNode(0).ChildNodes(0).InnerXml = CHK_CWBOnLoad.Checked
        XmlNode(0).ChildNodes(1).InnerXml = txt_RcntNum.Text
        XmlNode = xmldoc.GetElementsByTagName("Projects")
        XmlNode(0).ChildNodes(0).InnerXml = txt_Prjctloc.Text
        XmlNode(0).ChildNodes(1).InnerXml = TXT_UN.Text
        XmlNode(0).ChildNodes(2).InnerXml = Txt_DFLTPCKJNM.Text
        XmlNode(0).ChildNodes(3).InnerXml = TXT_CP.Text
        XmlNode = xmldoc.GetElementsByTagName("Compile")
        XmlNode(0).ChildNodes(0).InnerXml = TXT_APKTDir.Text
        XmlNode(0).ChildNodes(1).InnerXml = TXT_7ZDir.Text

        xmldoc.Save(Sttings_Dir)

    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  loadSettings()
    End Sub

    Private Sub BTN_Apply_Click(sender As Object, e As EventArgs) Handles BTN_Apply.Click
        Save()
    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Save()
        Me.Close()
    End Sub
End Class