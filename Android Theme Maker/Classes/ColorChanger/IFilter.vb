' Class implementing image filter interface and base filter class.
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

Public Interface IFilter

    Function ExecuteFilter( _
             ByVal inputImage As System.Drawing.Image) As System.Drawing.Image

End Interface

Public MustInherit Class BasicFilter
    Implements IFilter

    ''' <summary>
    ''' Background color. Default is a transparent background.
    ''' </summary>
    Private _bgColor As Color = Color.FromArgb(0, 0, 0, 0)
    ''' <summary>
    ''' Interpolation mode. Default is highest quality.
    ''' </summary>
    Private _interpolation As InterpolationMode = _
             InterpolationMode.HighQualityBicubic

    ''' <summary>
    ''' Get or set background color.
    ''' </summary>
    Public Property BackgroundColor() As Color
        Get
            Return _bgColor
        End Get
        Set(ByVal value As Color)
            _bgColor = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set resize interpolation mode.
    ''' </summary>
    Public Property Interpolation() As InterpolationMode
        Get
            Return _interpolation
        End Get
        Set(ByVal value As InterpolationMode)
            _interpolation = value
        End Set
    End Property

    ''' <summary>
    ''' Execute filter function and return new filtered image.
    ''' </summary>
    ''' <param name="img">Image to be filtered.</param>
    ''' <returns>New filtered image.</returns>
    Public MustOverride Function ExecuteFilter( _
             ByVal img As System.Drawing.Image) _
             As System.Drawing.Image Implements IFilter.ExecuteFilter

End Class