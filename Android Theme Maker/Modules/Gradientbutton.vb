
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms

Namespace GradientButton
    Partial Public Class GradientButton
        Inherits System.Windows.Forms.Button

        ' member variables
        Private mStartColor As System.Drawing.Color
        Private mEndColor As System.Drawing.Color
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Private mAngel As Integer
        Public Sub New()
            InitializeComponent()
            PaintGradient()
        End Sub

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            ' TODO: Add custom paint code here

            ' Calling the base class OnPaint
            MyBase.OnPaint(pe)
        End Sub


        Public Property PageStartColor() As System.Drawing.Color
            Get
                Return mStartColor
            End Get
            Set(value As System.Drawing.Color)
                mStartColor = value
                PaintGradient()
            End Set
        End Property


        Public Property PageEndColor() As System.Drawing.Color
            Get
                Return mEndColor
            End Get
            Set(value As System.Drawing.Color)
                mEndColor = value
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
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(0, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.FlatAppearance.BorderSize = 0.2
            Me.Button1.UseVisualStyleBackColor = True
            Me.ResumeLayout(False)

        End Sub


    End Class
End Namespace