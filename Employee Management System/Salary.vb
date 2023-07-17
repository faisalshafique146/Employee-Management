Imports System.Data.SqlClient
Public Class Salary
    Dim con As New SqlConnection("Data Source=DESKTOP-BEG2PBO\SQLEXPRESS;Initial Catalog=EmployeeMSDB;Integrated Security=True")
    Private Sub FetchEmpData()
        If EItxts.Text = "" Then
            MsgBox("Enter Employee ID")
        Else
            con.Open()
            Dim query = "select * from EmpTbl where ID =" & EItxts.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                ENlbls.Text = dr(1).ToString()
                ESlbls.Text = dr(3).ToString()
                ENlbls.Visible = True
                ESlbls.Visible = True
            Next
            con.Close()
        End If
    End Sub
    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        FetchEmpData()
    End Sub
    Dim Dpay
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If ESlbls.Text = "" Then
            MsgBox("Enter Employee ID")
        ElseIf EDOWtxt.Text = "" Or Convert.ToInt32(EDOWtxt.Text) > 31 Then
            MsgBox("Days Invalid")
        Else
            If ESlbls.Text = "18" Then
                Dpay = 3000
            ElseIf ESlbls.Text = "17" Then
                Dpay = 2500
            ElseIf ESlbls.Text = "16" Then
                Dpay = 2000
            ElseIf ESlbls.Text = "15" Then
                Dpay = 15000
            End If
            Dim total = Dpay * Convert.ToInt32(EDOWtxt.Text)
            ESSrtxt.Text = "ID:   " + EItxts.Text + vbCrLf + "Name:   " + ENlbls.Text + vbCrLf + "Scale:   " + ESlbls.Text + vbCrLf + "Work Days:   " + EDOWtxt.Text + vbCrLf + "Daily Salary Rs:   " + Convert.ToString(Dpay) + vbCrLf + "Total Amount Rs:   " + Convert.ToString(total)

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Centurey Gothic", 25), Brushes.DarkGreen, 200, 40)
        e.Graphics.DrawString("***PAYSLIP***", New Font("Arial", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(ESSrtxt.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("=======Thanks For Your Services=======", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub
End Class