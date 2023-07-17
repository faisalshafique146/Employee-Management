Public Class Form1

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles button1.Click
        UIDtxt.Text = ""
        PSWDtxt.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If UIDtxt.Text = "" Or PSWDtxt.Text = "" Then
            MsgBox("Enter User Id and Password")
        ElseIf UIDtxt.Text = "User" And PSWDtxt.Text = "Password" Then
            Dim admin = New AdminPanel
            admin.Show()
            Me.Hide()
        Else
            MsgBox("Wrong User Id or Password")
        End If
    End Sub

    Private Sub PSWDtxt_OnValueChanged(sender As Object, e As EventArgs) Handles PSWDtxt.OnValueChanged
        PSWDtxt.isPassword = True
    End Sub
End Class