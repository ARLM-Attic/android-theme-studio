Imports System.Xml
Imports Android_Theme_Studio.Declaration
Public Class InnerSetting
    Public Shared Sub loadSettings()
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        xmldoc.Load(Sttings_Dir)
        XmlNode = xmldoc.GetElementsByTagName("General")
        CloseWBAfterOpen = XmlNode(0).ChildNodes(0).InnerText
        RecentListItemsNo = XmlNode(0).ChildNodes(1).InnerText
        XmlNode = xmldoc.GetElementsByTagName("Projects")
        SaveLocation = XmlNode(0).ChildNodes(0).InnerXml
        Username = XmlNode(0).ChildNodes(1).InnerXml
        PackageName = XmlNode(0).ChildNodes(2).InnerXml
        Copyright = XmlNode(0).ChildNodes(3).InnerXml
        XmlNode = xmldoc.GetElementsByTagName("Compile")
        ApktoolDir = XmlNode(0).ChildNodes(0).InnerXml
        SzDir = XmlNode(0).ChildNodes(1).InnerXml
    End Sub

    Public Shared Sub Load_recentProjectsList(ByVal number As Integer)
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        xmldoc.Load(Recent_projects_list)
        XmlNode = xmldoc.GetElementsByTagName("RecentProjects")

        For i As Integer = XmlNode.Count - 1 To number Step -1
            Main_Form.Recent_TV.Nodes.Add(XmlNode(i).Attributes(0).Value)
        Next

    End Sub
    Public Shared Sub open_recentProject()
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        xmldoc.Load(Recent_projects_list)
        XmlNode = xmldoc.GetElementsByTagName("RecentProjects")

        For i As Integer = 0 To XmlNode.Count - 1
            If XmlNode(i).Attributes(0).Value = Main_Form.Recent_TV.SelectedNode.Text Then
                loadProject.load(Main_Form.Recent_TV.SelectedNode.Text, XmlNode(i).InnerXml)
            End If
        Next

    End Sub

End Class
