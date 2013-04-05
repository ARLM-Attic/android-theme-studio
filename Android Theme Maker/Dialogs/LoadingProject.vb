Public Class LoadingProject
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Long) As IntPtr

    Private Declare Function GetSystemMenu Lib "user32" (ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr

    Private Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As IntPtr) As Integer

    Private Declare Function DrawMenuBar Lib "user32" (ByVal hwnd As IntPtr) As Boolean

    Private Const MF_BYPOSITION = &H400
    Private Const MF_REMOVE = &H1000
    Private Const MF_DISABLED = &H2

    Public Sub DisableCloseButton(ByVal hwnd As IntPtr)

        Dim hMenu As IntPtr
        Dim menuItemCount As Integer

        hMenu = GetSystemMenu(hwnd, False)
        menuItemCount = GetMenuItemCount(hMenu)

        Call RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED Or MF_BYPOSITION)
        Call RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED Or MF_BYPOSITION)
        Call DrawMenuBar(hwnd)

    End Sub

    Private Sub LoadingProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsLoadingProject = False Then
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = "Loading..." Then
            Label1.Text = "Loading"
        Else
            Dim x As String = "."
            Label1.Text += x
        End If
       
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Close()
    End Sub
End Class