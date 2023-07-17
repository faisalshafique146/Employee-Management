Imports System.Data.SqlClient
Public Class Employee
    Dim con As New SqlConnection("Data Source=DESKTOP-BEG2PBO\SQLEXPRESS;Initial Catalog=EmployeeMSDB;Integrated Security=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        con.Open()
        Dim query As String
        query = "Insert into EmpTbl values('" & ENtxt.Text & "','" & EAtxt.Text & "','" & EStxt.SelectedItem.ToString() & "','" & CDate(EDOB.Text) & "','" & EPtxt.Text & "','" & EEtxt.SelectedItem.ToString() & "','" & EGtxt.SelectedItem.ToString() & "')"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Employee Added")
        con.Close()
        Populate()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        con.Open()
        Dim sql = "select * from EmpTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim build As SqlCommandBuilder
        build = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EDGpnl.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Dim key = 0
    Private Sub clear()
        ENtxt.Clear()
        EStxt.Text = ""
        EGtxt.Text = ""
        EAtxt.Text = ""
        key = 0
        EEtxt.Text = ""
        EPtxt.Text = ""
    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If key = 0 Then
            MsgBox("Select The Row To Be Delete")
        Else
            Try
                con.Open()
                Dim query As String
                query = "Delete from EmpTbl where Id = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted")
                con.Close()
                Populate()
                clear()
            Catch it As Exception
                MsgBox(it.Message)
            End Try
        End If
    End Sub

    Private Sub EDGpnl_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EDGpnl.CellMouseClick
        Dim row As DataGridViewRow = EDGpnl.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        ENtxt.Text = row.Cells(1).Value.ToString()
        EAtxt.Text = row.Cells(2).Value.ToString()
        EStxt.Text = row.Cells(3).Value.ToString()
        EDOB.Value = row.Cells(4).Value.ToString()
        EPtxt.Text = row.Cells(5).Value.ToString()
        EEtxt.Text = row.Cells(6).Value.ToString()
        EGtxt.Text = row.Cells(7).Value.ToString()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        If ENtxt.Text = "" Or EPtxt.Text = "" Or EAtxt.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query As String
            query = "Update EmpTbl set Name='" & ENtxt.Text & "', Address='" & EAtxt.Text & "', Scale='" & EStxt.SelectedItem.ToString() & "', Dob='" & CDate(EDOB.Text) & "', Phone='" & EPtxt.Text & "', Edu='" & EEtxt.SelectedItem.ToString() & "', Gender='" & EGtxt.SelectedItem.ToString() & "' where ID=" & key & ""
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated")
            con.Close()
            Populate()
            clear()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Hide()
        Dim sh = New Form1
        sh.Show()
    End Sub

End Class