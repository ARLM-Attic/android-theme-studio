
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms

Namespace GradientPanel
	Public Partial Class GradientPanel
		Inherits System.Windows.Forms.Panel

		' member variables
        Private mStartColor As System.Drawing.Color
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Private mEndColor As System.Drawing.Color
        Private mAngel As Integer
        Private _BorderColor As Color
        Public Sub New()
            InitializeComponent()
            PaintGradient()
            Me.SetStyle(ControlStyles.UserPaint, True)

        End Sub

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            ' TODO: Add custom paint code here

            ' Calling the base class OnPaint
            MyBase.OnPaint(pe)
            pe.Graphics.DrawRectangle(New Pen(New SolidBrush(_BorderColor), 2), pe.ClipRectangle)
        End Sub


        Public Property PageStartColor() As System.Drawing.Color
            Get
                Return mStartColor
            End Get
            Set(value As System.Drawing.Color)
                mStartColor = Value
                PaintGradient()
            End Set
        End Property


        Public Property PageEndColor() As System.Drawing.Color
            Get
                Return mEndColor
            End Get
            Set(value As System.Drawing.Color)
                mEndColor = Value
                PaintGradient()
            End Set
        End Property
        Public Property Angel() As Integer
            Get
                Return mAngel
            End Get
            Set(value As Integer)
                mAngel = value
                PaintGradient()
            End Set
        End Property

        Public Property BorderColor() As Color
            Get
                Return _BorderColor
            End Get
            Set(value As Color)
                _BorderColor = value

            End Set
        End Property

    

        Private Sub PaintGradient()
            Dim gradBrush As System.Drawing.Drawing2D.LinearGradientBrush
            gradBrush = New System.Drawing.Drawing2D.LinearGradientBrush(New Rectangle(0, 0, Me.Width, Me.Height), PageStartColor, PageEndColor, mAngel)

            Dim bmp As New Bitmap(Me.Width, Me.Height)

            Dim g As Graphics = Graphics.FromImage(bmp)
            g.FillRectangle(gradBrush, New Rectangle(0, 0, Me.Width, Me.Height))
            Me.BackgroundImage = bmp
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End Sub

        Private Sub InitializeComponent()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(200, 100)
            Me.Panel1.TabIndex = 0
            Me.ResumeLayout(False)

        End Sub


    End Class
End Namespace
