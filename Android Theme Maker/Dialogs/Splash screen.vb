Imports System.Threading
Public Class Splash_screen
 
    Sub load_Arguments()
        On Error GoTo a
        Dim adjective As String = IO.Path.GetFullPath(My.Application.CommandLineArgs(0)) 
        Main_Form.dest = adjective
        Main_Form.Threadstart()
        loadSettings()
        GC.Collect()
a:
        If Not Err.Number = 0 Then
            MsgBox(Err.Number & vbNewLine & Err.Description)
            Resume Next
        End If
    End Sub
    Sub LoadPRJ()

    End Sub
    Private Sub Splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   
        If (My.Application.CommandLineArgs.Count > 0) Then
            load_Arguments()
            Timer2.Enabled = True
        ElseIf My.Application.CommandLineArgs.Count = 0 Or My.Application.CommandLineArgs.Count < 0 Then

            Timer2.Enabled = True
        End If
    End Sub

    Sub loadSettings()
        InnerSetting.loadSettings()
        InnerSetting.Load_recentProjectsList(RecentListItemsNo)
        GC.Collect()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Main_Form.Show()
        Me.Close()
    End Sub
End Class