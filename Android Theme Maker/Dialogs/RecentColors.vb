Imports System.Xml
Imports Android_Theme_Studio.Application_procedures
Public Class RecentColors
    Private Shared SColor As Color

    Public Shared Property SelectedColor As Color
        Get
            Return SColor
        End Get
        Set(value As Color)
            SColor = value
        End Set
    End Property


    Private Sub RecentColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xmldoc As New XmlDataDocument()
        Dim XmlNode As XmlNodeList
        xmldoc.Load(RecentColors_Dir)
        XmlNode = xmldoc.GetElementsByTagName("RecentColors")
        For i As Integer = 0 To XmlNode.Count - 1
            ListView1.Items.Add(XmlNode.Item(i).InnerXml)
            ListView1.Items(i).BackColor = Drawing.Color.FromArgb(XmlNode.Item(i).InnerXml)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        SelectedColor = ListView1.SelectedItems.Item(0).BackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialg As New ColorPickerControls.Dialogs.ColorPickerFullWithAlphaDialog
        dialg.ShowDialog()

        Dim clr As Color = System.Drawing.Color.FromArgb(dialg.SelectedColor.A, dialg.SelectedColor.R, dialg.SelectedColor.G, dialg.SelectedColor.B)

        SelectedColor = clr
        add_FavColor(clr)
        CurColor.BackColor = clr
    End Sub

    
    Private Sub Btn_Colorpicker_Click(sender As Object, e As EventArgs) Handles Btn_Colorpicker.Click

        Color_Picker.ShowDialog()

        Dim clr As Color = System.Drawing.Color.FromArgb(Color_Picker.RetrivedColor.ARGB.ToArgb)

        SelectedColor = clr
        add_FavColor(clr)
        CurColor.BackColor = clr
    End Sub
End Class