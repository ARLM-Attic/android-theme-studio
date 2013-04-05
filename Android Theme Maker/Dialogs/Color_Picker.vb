Public Class Color_Picker
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer

    Private Sub Color_Picker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main_Form.ColorPickerToolStripMenuItem.Checked = False
    End Sub
    Private Sub Color_Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub
    Public Shared Property RetrivedColor As New retcolor()
    Public Class retcolor
        Private ARGB_Color As Color
        Private HTML_Color As String
        Property ARGB() As Color
            Get
                Return ARGB_Color
            End Get
            Set(ByVal Value As Color)
                ARGB_Color = Value
            End Set
        End Property

        Property HTML() As String
            Get
                Return HTML_Color
            End Get
            Set(ByVal value As String)
                HTML_Color = value
            End Set
        End Property
    End Class

    Private Shared pix As Drawing.Color
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), _
                           New Drawing.Point(0, 0), BMP.Size)
        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)
        CPpanel.BackColor = Pixel
        Redtxt.Text = Pixel.R
        Greentxt.Text = Pixel.G
        Bluetxt.Text = Pixel.B

        HTMLCLR.Text = ColorTranslator.ToHtml(Color.FromArgb(Pixel.ToArgb))
        pix = Pixel
        RetrivedColor.ARGB = Color.FromArgb(Pixel.ToArgb)
        RetrivedColor.HTML = ColorTranslator.ToHtml(Color.FromArgb(Pixel.ToArgb))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (GetAsyncKeyState(117)) Then
            Timer1.Start()
        End If
        If (GetAsyncKeyState(118)) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        RetrivedColor.ARGB = Color.FromArgb(pix.ToArgb)
        RetrivedColor.HTML = ColorTranslator.ToHtml(Color.FromArgb(pix.ToArgb))
        Me.Close()
    End Sub
End Class