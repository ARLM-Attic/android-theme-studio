Imports System.Drawing.Imaging

Public Class Image_Editor
    Public r As Integer = 0
    Public g As Integer = 0
    Public b As Integer = 0

    Private _imgOriginal As Image
    Private _imgFiltered As Image
    Private _imgResized As Image
    Private _filterHSL As HSLFilter = New HSLFilter
    Private _mouseDown As Boolean = False

    Private Shared ImageFile As String
    Public Shared Property MYImage As String
        Get
            Return ImageFile
        End Get
        Set(ByVal Img As String)
            ImageFile = Img
        End Set
    End Property
    Public Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim j As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()
        j = 0
        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If
            j += 1
        End While
        Return Nothing
    End Function
    Sub ChangeColor()
        r = TXTR.Value
        g = TXTG.Value
        b = TXTB.Value

        CLR.BackColor = Color.FromArgb(r, g, b)
    End Sub
    Public Function translate(ByVal img As Image, ByVal red As Single, _
                       ByVal green As Single, ByVal blue As Single, _
                       Optional ByVal alpha As Single = 0) As Boolean

        Dim image_attr As New ImageAttributes
        Dim cm As ColorMatrix
        Dim rect As Rectangle = Rectangle.Round(IMGORGNL.Image.GetBounds(GraphicsUnit.Pixel))
        Dim wid As Integer = IMGORGNL.Image.Width
        Dim hgt As Integer = IMGORGNL.Image.Height
        Dim bm As Bitmap
        Dim gr As Graphics

        Dim sr, sg, sb, sa As Single

        ' noramlize the color components to 1
        sr = red / 255
        sg = green / 255
        sb = blue / 255
        sa = alpha / 255


        bm = New Bitmap(wid, hgt)
        gr = Graphics.FromImage(bm)
        cm = New ColorMatrix(New Single()() { _
            New Single() {0.299, 0.299, 0.299, 0, 0}, _
            New Single() {0.587, 0.587, 0.587, 0, 0}, _
            New Single() {0.114, 0.114, 0.114, 0, 0}, _
            New Single() {0, 0, 0, 1, 0}, _
            New Single() {sr, sg, sb, sa, 1}})
        image_attr.SetColorMatrix(cm)
        gr.DrawImage(IMGORGNL.Image, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_attr)
        IMGEDITED.Image = bm


        Return True
    End Function
    Private Sub BTNPIC_Click(sender As System.Object, e As System.EventArgs)
        RecentColors.ShowDialog()
        CLR.BackColor = Drawing.ColorTranslator.FromHtml(RecentColors.SelectedColor.ToString)
        TxtR.Value = CLR.BackColor.R
        TxtG.Value = CLR.BackColor.G
        TxtB.Value = CLR.BackColor.B
    End Sub
    Private Sub BTNAPLY_Click(sender As System.Object, e As System.EventArgs)
        translate(IMGORGNL.Image, r, g, b)
    End Sub
    Private Sub TxtG_ValueChanged(sender As System.Object, e As System.EventArgs)
        ChangeColor()
        BTNAPLY.PerformClick()
    End Sub
    Private Sub TxtR_ValueChanged(sender As System.Object, e As System.EventArgs)
        ChangeColor()
        BTNAPLY.PerformClick()
    End Sub
    Private Sub TxtB_ValueChanged(sender As System.Object, e As System.EventArgs)
        ChangeColor()
        BTNAPLY.PerformClick()
    End Sub
    Private Sub FilterImageHSL()
        IMGHSLE.BackgroundImage = Nothing
        IMGHSLE.BackgroundImage = _filterHSL.ExecuteFilter(_imgResized)
    End Sub

    Private Sub sliderH_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = True
    End Sub
    Private Sub sliderH_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = False
        If (CDbl(SliderH.Value) <> _filterHSL.Hue) Then
            _filterHSL.Hue = CDbl(SliderH.Value)
            FilterImageHSL()
        End If
    End Sub
    Private Sub sliderH_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        textH.Text = SliderH.Value
    End Sub
    Private Sub sliderS_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = True
    End Sub
    Private Sub sliderS_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = False
        If (CDbl(SliderS.Value) <> _filterHSL.Saturation) Then
            _filterHSL.Saturation = CDbl(SliderS.Value)
            FilterImageHSL()
        End If
    End Sub
    Private Sub sliderS_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sliderS.Scroll
        textS.Text = sliderS.Value
    End Sub
    Private Sub sliderL_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = True
    End Sub
    Private Sub sliderL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _mouseDown = False
        If (CDbl(SliderL.Value) <> _filterHSL.Lightness) Then
            _filterHSL.Lightness = CDbl(SliderL.Value)
            FilterImageHSL()
        End If
    End Sub
    Public imageDir As String
    Public Sub loadImage()
        imageDir = Application_procedures.copyToTemp(IO.Path.GetFullPath(ImageFile))
        IMGORGNL.Image = Image.FromFile(imageDir)
        _imgOriginal = Image.FromFile(imageDir)
        imageDir = IO.Path.GetFullPath(ImageFile)
        'Dim scale As Double = 1
        'If (_imgOriginal.Width > 280) Or (_imgOriginal.Height > 210) Then
        '    scale = System.Math.Min(280 / _imgOriginal.Width, 210 / _imgOriginal.Height)
        'End If
        Dim imgFilter As ResizeFilter = New ResizeFilter
        'imgFilter.Width = CInt(scale * _imgOriginal.Width)
        'imgFilter.Height = CInt(scale * _imgOriginal.Height)
        BTNAPLY.PerformClick()
        _imgResized = imgFilter.ExecuteFilter(_imgOriginal)
        IMGORGNL.BackgroundImage = _imgResized
        IMGHSLE.BackgroundImage = _imgResized

    End Sub
    Private Sub VRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles VRadioButton2.CheckedChanged
        If VRadioButton2.Checked = True Then
            GradientPanel2.BringToFront()
        End If
    End Sub
    Private Sub VRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles VRadioButton1.CheckedChanged
        If VRadioButton1.Checked = True Then
            GradientPanel1.BringToFront()
        End If
    End Sub
    Private Sub BTN_Save_Click(sender As Object, e As EventArgs)
        IMGEDITED.Image.Save(IO.Path.GetFullPath(ImageFile), ImageFormat.Png)
    End Sub

    Private Sub BTN_HSLSAve_Click(sender As Object, e As EventArgs)
        IMGHSLE.BackgroundImage.Save(IO.Path.GetFullPath(ImageFile), ImageFormat.Png)
    End Sub
    Private Sub sliderL_Scroll(sender As Object, e As ScrollEventArgs)
        textL.Text = SliderL.Value
    End Sub

    Private Sub Image_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class