Imports System.Xml
Imports WindowsFormsAero.TaskDialog
Imports Android_Theme_Studio.XML_Builder
Imports Android_Theme_Studio.XML_Builder.XML_procedures
Imports System.IO

Public Class Application_procedures

    Structure ErrorString
        Dim appname As String
    End Structure
    Shared errlog() As ErrorString

    Public Shared Function filter_apps(ByVal Directory As String, ByVal extension As String) As Array
        On Error Resume Next

        Dim folder As New IO.DirectoryInfo(Directory)

        Dim dir As IO.FileInfo() = folder.GetFiles(extension, IO.SearchOption.TopDirectoryOnly)


        Dim arrstr() As String
        ReDim arrstr(0 To dir.Count - 1)



        For i As Integer = 0 To dir.Count - 1
            arrstr(i) = dir(i).ToString
            arrstr(i) = arrstr(i).Substring(0, arrstr(i).IndexOf("_"))
        Next

        Dim list As New ListBox
        For Each item As String In arrstr
            list.Items.Add(item)
        Next


        Dim x, j As Integer
        Dim arr As New ArrayList
        Dim itemfound As Boolean
        For x = 0 To list.Items.Count - 1
            itemfound = False
            For j = 0 To x - 1
                If list.Items.Item(x) = list.Items.Item(j) Then
                    itemfound = True
                    Exit For
                End If
            Next j

            If Not itemfound Then
                arr.Add(list.Items.Item(x))
            End If
        Next x

        Return arr.ToArray

    End Function ''FINISHED''
    Public Shared Function LoadDirectoryFiles(ByVal directory As String, ByVal Extension As String) As Array
        Dim folder As New IO.DirectoryInfo(directory)

        Dim dir As IO.FileInfo() = folder.GetFiles(Extension, IO.SearchOption.TopDirectoryOnly)

        Dim arrstr() As String
        ReDim arrstr(0 To dir.Count - 1)


        For i As Integer = 0 To dir.Count - 1
            arrstr(i) = dir(i).ToString  
        Next

        Dim list As New ListBox
        For Each item As String In arrstr
            list.Items.Add(item)
        Next


        Dim x, j As Integer
        Dim arr As New ArrayList
        Dim itemfound As Boolean
        For x = 0 To list.Items.Count - 1
            itemfound = False
            For j = 0 To x - 1
                If list.Items.Item(x) = list.Items.Item(j) Then
                    itemfound = True
                    Exit For
                End If
            Next j

            If Not itemfound Then
                arr.Add(list.Items.Item(x))
            End If
        Next x

        Return arr.ToArray

    End Function
    Shared renamearray As New ArrayList
    Public Shared Sub Multple_rename(ByVal folder As String, ByVal array As ArrayList)
        On Error GoTo err
1:
        Dim NewName As String = Nothing
        For i As Integer = 0 To array.Count
            FRMDB.filter(array.Item(i).ToString)
            If FRMDB.lst_apps.Items.Count > 0 Then
                NewName = FRMDB.lst_apps.Items(0).SubItems(1).Text
                My.Computer.FileSystem.RenameFile(folder + "\" + array.Item(i).ToString, NewName)
            ElseIf FRMDB.lst_apps.Items.Count = 0 Then
                Dim x As Integer = errlog.Length
                errlog(x + 1).appname = array.Item(i).ToString
            End If
        Next
        Dim ErrString As String = Nothing
        For x As Integer = 0 To errlog.Length
            ErrString += "The Application: " + errlog(x).appname.ToString + " Does NOT exist in the Database" + vbNewLine
        Next
        TaskDialog.Show("error", "ERROR LOG", ErrString, TaskDialogButton.Retry, TaskDialogIcon.Warning)
        array.Clear()
err:
        If TaskDialog.Show("Can't Resume", "ERROR", "Error Number = " & Err.Number & vbNewLine & "Error Description: " + Err.Description, WindowsFormsAero.TaskDialog.TaskDialogButton.Retry + WindowsFormsAero.TaskDialog.TaskDialogButton.Close, TaskDialogIcon.Stop) = Result.Retry Then
            GoTo 1
        Else
            End
        End If
    End Sub ''FINISHED
    Public Shared Sub Rename_Icon(ByVal folder As String, ByVal OldName As String)
        Dim NewName As String = Nothing

        FRMDB.filter(OldName)
        If FRMDB.lst_apps.Items.Count > 0 Then
            NewName = FRMDB.lst_apps.Items(0).SubItems(1).Text
            My.Computer.FileSystem.RenameFile(folder + "\" + OldName, NewName)
        ElseIf FRMDB.lst_apps.Items.Count = 0 Then
            If TaskDialog.Show("The Application: " + OldName + " Does NOT exist in the Database" + vbNewLine + "Would you like to add it?", "ERROR", "", TaskDialogButton.Yes) = Result.Yes Then
                FRM_newapp.TxtName.Text = OldName
                FRM_newapp.ShowDialog()
            End If
        End If

    End Sub ''FINISHED''
    Public Shared Sub Add_application(ByVal Name As String, ByVal Packname As String)
        Dim xmldoc As New XmlDataDocument()

        Dim XmlNode As XmlNodeList
        xmldoc.Load(Database)

        XmlNode = xmldoc.GetElementsByTagName("Applications_database")
        Dim node As XmlNode
        Dim attr As XmlNode
        node = xmldoc.CreateNode(XmlNodeType.Element, "App", Nothing)
        attr = xmldoc.CreateNode(XmlNodeType.Attribute, "Name", Nothing)
        node.InnerText = Packname
        attr.InnerText = Name
        node.Attributes.Append(attr)
        xmldoc.DocumentElement.AppendChild(node)
        xmldoc.Save(Database)
    End Sub ''FINISHED''
    Public Shared Function addDir_Files(ByVal Directory As String) As Array
        Dim dir As New IO.DirectoryInfo(Directory)
        Dim diar1 As IO.FileInfo() = dir.GetFiles()
        Dim dra As IO.FileInfo

        Dim array As New ArrayList

        For Each dra In diar1
            array.Add(dra.ToString)
        Next
        Return array.ToArray
        array.Clear()
    End Function ''FINISHED
    Public Shared Sub Pubulate_LV(ByVal ListView As ListView, ByVal Directory As String)
        Dim ThisRow As Array = Nothing
        Dim list As New ImageList
        On Error Resume Next
        Dim k As Integer
        Dim array As Array = addDir_Files(Directory)
        For k = 0 To array.Length - 1
            ListView.Items.Add(array(k).ToString, k)
            list.Images.Add(Bitmap.FromFile(Directory + "\" + array(k).ToString))
        Next
        ListView.LargeImageList = list
        array = Nothing
        GC.Collect()
    End Sub ''FINISHED
    Public Shared Sub Filter_LV(ByVal ListView As ListView, ByVal value As String)
        For Each item As ListViewItem In ListView.Items
            Dim x As String() = item.Text.Split("_")
            If Not x(0) = value Then
                item.Remove()
            End If
        Next
    End Sub ''FINISHED 
    Public Shared Sub CloneListview(ByVal listview As ListView, ByVal Clonedlistview As ListView)
        Dim imagelist As New ImageList
        For i As Integer = 0 To listview.LargeImageList.Images.Count - 1
            imagelist.Images.Add(listview.LargeImageList.Images(i))
        Next

        For Each lvi As ListViewItem In listview.Items
            Dim newLvi As ListViewItem = lvi.Clone()
            For Each lvsi As ListViewItem.ListViewSubItem In lvi.SubItems

                newLvi.SubItems.Add(New ListViewItem.ListViewSubItem(newLvi, lvsi.Text, lvsi.ForeColor, lvsi.BackColor, lvsi.Font))
             
            Next
            Clonedlistview.Items.Add(newLvi)
            Clonedlistview.LargeImageList = imagelist
        Next
    End Sub ''FINISHED
    Public Shared Function ReFilter_LV(ByVal listview As ListView, ByVal value As String) As ListView
        Dim lV As New ListView
        CloneListview(Org_Framwork_LW, lV)
        Filter_LV(lV, value)
        GC.Collect()
        Return lV
    End Function ''FINISHED
    Public Shared Sub add_recentproject(ByVal ProjectName As String, ByVal projectdir As String)
        Dim arr1, arr2 As New ArrayList
        arr1(0) = "Name"
        arr2(0) = ProjectName
        ADD_XML_node(Recent_projects_list, "RecentProjects", "Project", projectdir, arr1, arr2)
    End Sub ''FINISHED
    Public Shared Sub add_FavColor(ByVal Color As Color)
        Dim arr1, arr2 As New ArrayList
        ADD_XML_node(Recent_projects_list, "RecentColors", "Color", Color.ToArgb, arr1, arr2)
    End Sub ''FINISHED
    Public Shared Function copyToTemp(ByVal File As String)
        On Error GoTo a
        If IO.File.Exists(Path.GetTempPath() & "\" & Path.GetFileName(File)) = True Then
            IO.File.Delete(Path.GetTempPath() & "\" & Path.GetFileName(File))
            IO.File.Copy(File, Path.GetTempPath() & "\" & Path.GetFileName(File))
        Else
            IO.File.Copy(File, Path.GetTempPath() & "\" & Path.GetFileName(File))
        End If

        Return Path.GetTempPath() & Path.GetFileName(File).ToString
a:
        MsgBox(Err.Description)
    End Function ''FINISHED
    Public Shared Function CheckForExtension(ByVal Directory As String, ByVal extension As String) As Array
        Dim folder As New IO.DirectoryInfo(Directory)
        Dim ArrRetrieved As New ArrayList
        Dim dir As New ArrayList

        For Each dr As IO.DirectoryInfo In folder.GetDirectories
            dir.Add(dr.FullName)
        Next

        For item As Integer = 0 To dir.Count - 1
            If filter_apps(dir(item).ToString, extension).Length > 0 Then
                ArrRetrieved.Add(dir(item))  
            End If
        Next
    
        Return ArrRetrieved.ToArray
    End Function ''FINISHED
    Public Shared Sub loadXmlIems(ByVal File As String, ByVal listView As ListView)
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        Dim tagname As String = Nothing
        listView.Items.Clear()

        Dim xmlreader As New XmlTextReader(File)
        xmlreader.WhitespaceHandling = WhitespaceHandling.None
        xmlreader.Read()


        'Load the Loop
        While Not xmlreader.EOF
            'Go to the name tag
            xmlreader.Read()

            If xmlreader.IsStartElement() Then
                tagname = xmlreader.LocalName
                xmlreader.Close()
                Exit While
            End If

        End While
        xmldoc.Load(File)

        XmlNode = xmldoc.GetElementsByTagName(tagname)

        For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1
            listView.Items.Add(XmlNode(0).ChildNodes(i).Name).SubItems.Add(XmlNode(0).ChildNodes(i).InnerXml)
        Next

    End Sub ''FINISHED
    Public Shared Sub LoadXMLItem_attributes(ByVal File As String, ByVal Value As String, ByVal listView As ListView)
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        Dim tagname As String = Nothing
        listView.Items.Clear()

        Dim xmlreader As New XmlTextReader(File)
        xmlreader.WhitespaceHandling = WhitespaceHandling.None
        xmlreader.Read()


        'Load the Loop
        While Not xmlreader.EOF
            'Go to the name tag
            xmlreader.Read()

            If xmlreader.IsStartElement() Then
                tagname = xmlreader.LocalName
                xmlreader.Close()
                Exit While
            End If

        End While
        xmldoc.Load(File)

        XmlNode = xmldoc.GetElementsByTagName(tagname)

        For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1
            If XmlNode(0).ChildNodes(i).InnerXml = Value Then
                For x As Integer = 0 To XmlNode(0).ChildNodes(i).Attributes.Count - 1
                    listView.Items.Add(XmlNode(0).ChildNodes(i).Attributes(x).Name).SubItems.Add(XmlNode(0).ChildNodes(i).Attributes(x).Value)

                Next
            End If
        Next

    End Sub ''FINISHED
    Public Shared Function GetXmlTagName(ByVal Directory As String) As String
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        Dim tagname As String = Nothing

        Dim xmlreader As New XmlTextReader(Directory)
        xmlreader.WhitespaceHandling = WhitespaceHandling.None
        xmlreader.Read()

        'Load the Loop
        While Not xmlreader.EOF
            'Go to the name tag
            xmlreader.Read()

            If xmlreader.IsStartElement() Then
                tagname = xmlreader.LocalName
                xmlreader.Close()
                Exit While
            End If

        End While
        Return tagname
    End Function


#Region "ADD APK FILE To project"
    Public Shared Function CheckAPKname(ByVal NAME As String) As String
        Dim available As String = Nothing
        Return available
    End Function
    Public Shared Sub ADD_APKtoProject()

    End Sub
#End Region
    Public Enum File_ImpTypes
        Mp3
        Text
        Img
        PreviewImg
        Wallpaper
    End Enum
    Public Shared Sub Import_File(ByVal File As String, ByVal type As File_ImpTypes)
        Select Case type
            Case File_ImpTypes.Mp3

            Case File_ImpTypes.Img

            Case File_ImpTypes.Text

        End Select

    End Sub
End Class