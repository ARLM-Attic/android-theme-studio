' Class implementing resizing of image.
' 
' Copyright (c) 2007 Miran Uhan
' 
' This program is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the
'    Free Software Foundation, Inc.
'    51 Franklin Street, Fifth Floor
'    Boston, MA 02110-1301 USA
'
' Sources:
' - http://www.codeproject.com/cs/library/yael_image_filters.asp
'
' For questions you can contact author at
'    miran.uhan@gmail.com
' Sugestions and bug reports are also welcome.
' 

Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class ResizeFilter
    Inherits BasicFilter

    ''' <summary>
    ''' Width of new image.
    ''' </summary>
    Private _width As Integer = 0
    ''' <summary>
    ''' Height of new image.
    ''' </summary>
    Private _height As Integer = 0

    ''' <summary>
    ''' Get or set output image width.
    ''' </summary>
    Public Property Width() As Integer
        Get
            Return _width
        End Get
        Set(ByVal value As Integer)
            _width = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set output image height.
    ''' </summary>
    Public Property Height() As Integer
        Get
            Return _height
        End Get
        Set(ByVal value As Integer)
            _height = value
        End Set
    End Property

    ''' <summary>
    ''' Execute resize of given image.
    ''' </summary>
    ''' <param name="img">Image to be resized.</param>
    ''' <returns>Resized image.</returns>
    Public Overrides Function ExecuteFilter(ByVal img As System.Drawing.Image) As System.Drawing.Image
        If ((img.Width <= 0) Or (img.Height <= 0) Or _
                 (_width <= 0) Or (_height <= 0)) Then
            Return img
        End If
        Dim result As Bitmap = New Bitmap(_width, _height)
        Dim g As Graphics = Graphics.FromImage(result)
        g.InterpolationMode = Interpolation
        g.DrawImage(img, 0, 0, _width, _height)
        Return result
    End Function

End Class
