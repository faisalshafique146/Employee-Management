Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(3)
        If ProgressBar.Value = 100 Then
            Me.Hide()
            Dim Log = New Form1
            Log.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
