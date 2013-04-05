Public Class img_prev
    Public Shared Property MYIMG As New pic()
    Public Class pic
        Private ImageFile As Bitmap
        Private ImgName As String
        Private ImgResolution As String
        Property Image() As Image
            Get
                Return ImageFile
            End Get
            Set(ByVal Img As Image)
                ImageFile = Img
                ImgResolution = Img.Width.ToString + "," + Img.Height.ToString
            End Set
        End Property

        Property Name() As String
            Get
                Return ImgName
            End Get
            Set(ByVal value As String)
                ImgName = value
            End Set
        End Property
        ReadOnly Property Resolution() As String
            Get
                Return ImgResolution
            End Get
        End Property
    End Class
    Private Sub BTN_size_Click(sender As Object, e As EventArgs) Handles BTN_size.Click
        Dim ORGFRMsize As New Point(189, 393)
        Dim ORGIMGsize As New Point(117, 137)

        If BTN_size.Text = "Full Size" Then
            BTN_size.Text = "Normal Size"
            IMG.SizeMode = PictureBoxSizeMode.AutoSize
            Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.AutoSize = True

        ElseIf BTN_size.Text = "Normal Size" Then
            BTN_size.Text = "Full Size"
            IMG.SizeMode = PictureBoxSizeMode.CenterImage
            Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.AutoSize = False
            
            Me.Width = ORGFRMsize.Y
            Me.Height = ORGFRMsize.X
            IMG.Width = ORGIMGsize.Y
            IMG.Height = ORGIMGsize.X
        End If
    End Sub

    Private Sub img_prev_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main_Form.ToolStripMenuItem22.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IMG.Image = MYIMG.Image
        Lbl_name.Text = MYIMG.Name
        Lbl_res.Text = MYIMG.Resolution
        Timer1.Enabled = False
    End Sub

    Private Sub img_prev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IMG.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.BackColor = Drawing.Color.FromArgb(64, 64, 64)
        IMG.BackColor = Drawing.Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.BackColor = Drawing.Color.White
        IMG.BackColor = Color.White
    End Sub
 
    Public Function ZoomImage(ByVal Image As Image, ByVal ZoomFactor As Double) As Image
        Return New Bitmap(Image, Int(Image.Width * ZoomFactor), Int(Image.Height * ZoomFactor))
    End Function
    Private Sub ZoomIn_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        On Error Resume Next

        IMG.Image = ZoomImage(IMG.Image, 1.5)
    End Sub

    Private Sub ZoomOut_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        On Error Resume Next
        IMG.Image = ZoomImage(IMG.Image, 0.5)
    End Sub
End Class