Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub

    Private Sub AdmVerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordInput.UseSystemPasswordChar = True
    End Sub

    Private Sub PassReveal_CheckedChanged(sender As Object, e As EventArgs) Handles PassReveal.CheckedChanged
        If PasswordInput.UseSystemPasswordChar = False Then
            PasswordInput.UseSystemPasswordChar = True
        ElseIf PasswordInput.UseSystemPasswordChar = True Then
            PasswordInput.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        AdminIDInput.Clear()
        PasswordInput.Clear()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            OpenConnection()
            Dim Login As New MySqlCommand("SELECT * FROM `employee_tb` WHERE `user` = @username AND `pass` = @password", Connection)
            Login.Parameters.Add("@username", MySqlDbType.VarChar).Value = AdminIDInput.Text
            Login.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordInput.Text
            Dim adapter As New MySqlDataAdapter(Login)
            ELTable.Clear()
            adapter.Fill(ELTable)
            Connection.Close()

            If AdminIDInput.Text = "" And PasswordInput.Text = "" Then
                MessageBox.Show("Fill All Fields")
            ElseIf ELTable.Rows(0)("Privilege") = "Admin" Then
                Me.Hide()
                AdminForm.AccountNameLbl.Text = AdminIDInput.Text
                AdminForm.Show()
                AdminIDInput.Clear()
                PasswordInput.Clear()
            ElseIf ELTable.Rows(0)("Privilege") = "Employee" Then
                Me.Hide()
                EmployeeFormA.AccountNameLbl.Text = AdminIDInput.Text
                EmployeeFormA.Show()
                AdminIDInput.Clear()
                PasswordInput.Clear()
            Else
                MessageBox.Show("Username or Password are incorrect")
                'AdminIDInput.Clear()
                'PasswordInput.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Username or Password are incorrect")
        End Try

    End Sub
End Class