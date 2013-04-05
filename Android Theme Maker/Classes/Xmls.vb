Imports System.Xml
Imports System.IO
Imports Android_Theme_Studio.constants
Imports Android_Theme_Studio.Application_procedures
Imports Android_Theme_Studio.XML_Builder.XML_procedures
Namespace XML_Builder
    
    Public Class XML_procedures
        Enum EditType
            Name
            Value
        End Enum
        Public Shared Sub ADD_XML_node(ByVal XMLFile As String, ByVal TagName As String, ByVal node_Name As String, _
                               ByVal Node_Value As String, ByVal Arguments_arr As ArrayList, ByVal ArgumentsVals As ArrayList)

            Dim xmldoc As New XmlDataDocument()

            Dim XmlNode As XmlNodeList

            xmldoc.Load(XMLFile)
            Dim item As Integer
            XmlNode = xmldoc.GetElementsByTagName(TagName)

            Dim node As XmlNode
            Dim attr As XmlAttribute
            If Arguments_arr.Count > 0 And ArgumentsVals.Count > 0 Then
                node = xmldoc.CreateNode(XmlNodeType.Element, node_Name, Nothing)
                node.InnerText = Node_Value

                For item = 0 To Arguments_arr.Count - 1

                    attr = xmldoc.CreateAttribute(XmlNodeType.Attribute, Arguments_arr.Item(item).ToString, Nothing)


                    attr.InnerText = ArgumentsVals.Item(item).ToString

                    node.Attributes.Append(attr)

                    xmldoc.DocumentElement.AppendChild(node)

                    xmldoc.Save(XMLFile)
                Next

            ElseIf Arguments_arr.Count = 0 Then
                node = xmldoc.CreateNode(XmlNodeType.Element, node_Name, Nothing)
                node.InnerText = Node_Value
                xmldoc.DocumentElement.AppendChild(node)
                xmldoc.Save(XMLFile)
            End If
        End Sub ''FINISHED''
        Public Shared Sub DEL_XML_node(ByVal XMLFile As String, ByVal TagName As String, _
                              ByVal Node_Value As String, ByVal ArgumentsVal As String)
            Dim xmldoc As New XmlDataDocument()
            Dim XmlNode As XmlNodeList
            xmldoc.Load(XMLFile)
            XmlNode = xmldoc.GetElementsByTagName(TagName)
            For i As Integer = 0 To xmldoc.ChildNodes.Count - 1
                If XmlNode(0).ChildNodes(i).Attributes(0).Value = ArgumentsVal Or XmlNode(0).ChildNodes(i).InnerXml = Node_Value Then
                    XmlNode(0).ChildNodes(0).RemoveAll()
                End If
            Next
            xmldoc.Save(XMLFile)

        End Sub ''FINISHED''
        Public Shared Sub Edit_node_Value(ByVal XMLFile As String, ByVal TagName As String, ByVal editType As EditType, ByVal oldValue As String, ByVal NewValue As String)
            Dim xmldoc As New XmlDataDocument()
            Dim XmlNode As XmlNodeList
            xmldoc.Load(XMLFile)
            XmlNode = xmldoc.GetElementsByTagName(TagName)

            Select Case editType
                Case XML_procedures.EditType.Value

                    For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1
                        If XmlNode(0).ChildNodes(i).InnerXml = oldValue Then
                            XmlNode(0).ChildNodes(i).InnerXml = NewValue
                            Exit Select
                        End If
                    Next
                Case XML_procedures.EditType.Name

                    For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1
                        For x As Integer = 0 To XmlNode(0).ChildNodes(i).Attributes.Count - 1
                            If XmlNode(0).ChildNodes(i).Attributes(x).Value = oldValue Then
                                XmlNode(0).ChildNodes(i).InnerXml = NewValue
                                Exit Select
                            End If
                        Next
                    Next
            End Select


            xmldoc.Save(XMLFile)
        End Sub ''FINISHED''
        Public Shared Sub Edit_Node_attr(ByVal XmlFile As String, ByVal TagName As String, ByVal EditType As EditType, ByVal attribute As String, ByVal NewValue As String)
            Dim xmldoc As New XmlDataDocument()
            Dim XmlNode As XmlNodeList
            xmldoc.Load(XmlFile)
            XmlNode = xmldoc.GetElementsByTagName(TagName)

            Select Case EditType
                Case XML_procedures.EditType.Name
                    For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1

                        For x As Integer = 0 To XmlNode(0).ChildNodes(i).Attributes.Count - 1
                            If XmlNode(0).ChildNodes(i).Attributes(x).Value = attribute Then
                                XmlNode(0).ChildNodes(i).Attributes(x).Value = NewValue
                                Exit For
                            End If
                        Next
                 

                    Next
                Case XML_procedures.EditType.Value
                    For i As Integer = 0 To XmlNode(0).ChildNodes.Count - 1

                        For x As Integer = 0 To XmlNode(0).ChildNodes(i).Attributes.Count - 1
                            If XmlNode(0).ChildNodes(i).Attributes(x).Value = attribute Then
                                XmlNode(0).ChildNodes(i).Attributes(x).Value = NewValue
                                Exit For
                            End If
                        Next
                   
                    Next
            End Select

            xmldoc.Save(XmlFile)
        End Sub
        Public Shared Sub Create_APPXML(ByVal destination As String)
            Dim writer As New XmlTextWriter(destination, System.Text.Encoding.UTF8)
            writer.WriteStartDocument()
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("resource-redirections>")
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        End Sub
    End Class

Public Module Declarations
        Enum SDKno
            CyanogenMod101
            CyanogenMod10 = 14
            CyanogenMod9 = 15
            CyanogenMod7 = 9
            AOKP_JB = 14
            AOKP_ICS = 15
            IconPackage = 8
        End Enum
        Enum AndroidVersionCode
            CM9 = 1
            CM7 = 3
            CM10 = 12
        End Enum
        Enum Tones
            Ringtone
            Alarm
            Notification
        End Enum
        Enum ImageType
            Wallpaper
            Preview
        End Enum
        Public PackageName As String
#Region "Consts"
        Public manifistXML As String = CurrentProject_dir + "AndroidManifest.xml"
        Public StylesXML As String = values + "styles.xml"
        Public StringsXML As String = values + "strings.xml"
#End Region

    End Module
    Public Class AndroidManifest
        Public Shared Sub Buildmanifest(ByVal File As String, ByVal SDK As SDKno)
            Dim writer As New XmlTextWriter(File, System.Text.Encoding.UTF8)
            writer.Formatting = Formatting.Indented
            writer.WriteStartDocument()
            writer.Indentation = 2
            writer.WriteStartElement("manifest")
            writer.WriteAttributeString("android:hasCode", "false")
            writer.WriteAttributeString("android:versionCode", "")
            writer.WriteAttributeString("android:versionName", "")
            writer.WriteAttributeString("android:installLocation", "internalOnly")
            writer.WriteAttributeString("package", PackageName)
            writer.WriteAttributeString("xmlns:android", "http://schemas.android.com/apk/res/android")
            writer.WriteAttributeString("xmlns:pluto", "http://www.w3.org/2001/pluto.html")
            writer.WriteStartElement("uses-sdk")
            writer.WriteAttributeString("android:minSdkVersion", SDK)
            writer.WriteAttributeString("android:targetSdkVersion", SDK)
            writer.WriteEndElement()

            writer.WriteStartElement("application")
            writer.WriteAttributeString("android:label", "@string/theme_name")
            writer.WriteAttributeString("android:icon", "@drawable/icon")
            writer.WriteStartElement("activity")
            writer.WriteAttributeString("android:label", "@string/theme_name")
            writer.WriteAttributeString("android:name", "com.tmobile.theme.Foo")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("theme")
            writer.WriteAttributeString("pluto:themeId", "")
            writer.WriteAttributeString("pluto:styleId", "")
            writer.WriteAttributeString("pluto:name", "")
            writer.WriteAttributeString("pluto:preview", "")
            writer.WriteAttributeString("pluto:author", "")
            writer.WriteAttributeString("pluto:copyright", "")
            writer.WriteAttributeString("pluto:wallpaperImage", "")
            writer.WriteAttributeString("pluto:styleName", "")
            writer.WriteAttributeString("pluto:ringtoneName", "")
            writer.WriteAttributeString("pluto:ringtoneFileName", "false")
            writer.WriteAttributeString("pluto:notificationRingtoneName", "false")
            writer.WriteAttributeString("pluto:notificationRingtoneFileName", "false")
            writer.WriteStartElement("activity")
            writer.WriteAttributeString("meta-data", "com.tmobile.theme.redirections")
            writer.WriteAttributeString("android:resource", "@xml/redirections")
            writer.WriteEndElement()

            writer.WriteEndDocument()
            writer.Close()
        End Sub
    End Class
#Region "procedures"

    Class PropertiesProcedures
        ''need modifications
        Public Shared Sub SetProperty_Name(ByVal ThemeName As String)
            XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", PackageName)
            XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "pluto:themeId", ThemeName)
            XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "pluto:styleId", ThemeName)

            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "app_name", PackageName)
            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "theme_name", ThemeName)
            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "style_appearance_name", ThemeName)
            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "author", ThemeAuthor)
            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "copyright", ThemeName)

            XML_procedures.Edit_Node_attr(StylesXML, "resources", XML_procedures.EditType.Value, "THEME_NAME_GOES_HERE", ThemeName)

        End Sub
        Public Shared Sub SetProperty_Author(ByVal Author As String)
            XML_procedures.Edit_node_Value(StringsXML, "manifest", XML_procedures.EditType.Name, "author", Author)
        End Sub
        Public Shared Sub SetProperty_Version(ByVal Version As String)
            XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "android:versionName", Version)
        End Sub
        Public Shared Sub SetProperty_Copyright(ByVal Copyright As String)
            XML_procedures.Edit_node_Value(StringsXML, "resources", XML_procedures.EditType.Name, "copyright", Copyright)
        End Sub
        Public Shared Sub SetProperty_AppearanceName(ByVal ThemeName As String)
            XML_procedures.Edit_node_Value(StringsXML, "manifest", XML_procedures.EditType.Name, "style_appearance_name", ThemeName)
        End Sub
        Public Shared Sub SetProperty_Tones(ByVal ToneOption As Tones, ByVal File As String)
            Select Case ToneOption
                Case Tones.Alarm
                    XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", File)
                Case Tones.Notification
                    XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", File)
                Case Tones.Ringtone
                    XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", File)
            End Select

        End Sub
        Public Shared Sub SetProperty_Images(ByVal ImageOption As ImageType, ByVal File As String)
            Select Case ImageOption
                Case ImageType.Preview
                    XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", File)
                Case ImageType.Wallpaper
                    XML_procedures.Edit_Node_attr(manifistXML, "manifest", XML_procedures.EditType.Name, "package", File)
            End Select

        End Sub
    End Class
    Class otherprocedures
        Public Shared Sub Add_ApplicationIcon(ByVal Name As String)
            If CheckAPKname(Name).ToString IsNot Nothing Then
                Dim arratr, arrvls As New ArrayList
                arratr.Add("android:name")
                arratr.Add("android:resource")
                arrvls.Add(Name)
                arrvls.Add(CheckAPKname(Name).ToString)
                ADD_XML_node(values & "\redirections.xml", "theme-redirections", "package-redirections", "", arratr, arrvls)
                Create_APPXML(values & CheckAPKname(Name).ToString & ".xml")
                arratr.Clear()
                arrvls.Clear()
                arratr.Add("name")
                arrvls.Add(CheckAPKname(Name).ToString)
                ADD_XML_node(values & "\redirections.xml", "theme-item", "package-redirections", "", arratr, arrvls)
            Else
                MsgBox("The selected file does NOT exist in the database")
            End If
        End Sub
        Public Shared Sub Remove_ApplicationIcon(ByVal Name As String)
            IO.File.Delete(values & Path.GetFileNameWithoutExtension(Name) & ".xml")
            IO.File.Delete(Name)
            DEL_XML_node(values & "\redirections.xml", "theme-item", "", Name)
        End Sub
    End Class
#End Region
End Namespace
