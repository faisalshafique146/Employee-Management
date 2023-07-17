Imports System.Data.SqlClient
Public Class Details
    Dim con As New SqlConnection("Data Source=DESKTOP-BEG2PBO\SQLEXPRESS;Initial Catalog=EmployeeMSDB;Integrated Security=True")
    Private Sub FetchEmpData()
        If EItxt.Text = "" Then
            MsgBox("Enter Employee ID")
        Else
            con.Open()
            Dim query = "select * from EmpTbl where ID =" & EItxt.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                ENlbl.Text = dr(1).ToString()
                EAlbl.Text = dr(2).ToString()
                ESlbl.Text = dr(3).ToString()
                EDOBlbl.Text = dr(4).ToString()
                EPlbl.Text = dr(5).ToString()
                EElbl.Text = dr(6).ToString()
                EGlbl.Text = dr(7).ToString()
                ENlbl.Visible = True
                EAlbl.Visible = True
                ESlbl.Visible = True
                EDOBlbl.Visible = True
                EPlbl.Visible = True
                EElbl.Visible = True
                EGlbl.Visible = True
            Next
            con.Close()
        End If
    End Sub
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles FDbtn.Click
        FetchEmpData()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***Employee Summary***", New Font("Arial", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("Name:   " + ENlbl.Text + vbTab + "Address:   " + EAlbl.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 205)
        e.Graphics.DrawString("Scale:   " + ESlbl.Text + vbTab + "Education:   " + EElbl.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 260)
        e.Graphics.DrawString("Phone:   " + EPlbl.Text + vbTab + "Gender:   " + EGlbl.Text, New Font("Century Gothic", 22), Brushes.Black, 140, 320)
        e.Graphics.DrawString("DOB:   " + EDOBlbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.Black, 140, 385)
        e.Graphics.DrawString("=======Hi-Soft Technology=======", New Font("Century Gothic", 15), Brushes.DarkGreen, 250, 550)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class