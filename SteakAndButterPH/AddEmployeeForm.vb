Public Class AddEmployeeForm

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        If FirstNameInput.Text = "" Or LastNameInput.Text = "" Or AddressInput.Text = "" Or EmailInput.Text = "" Or ContactNumInput.Text = "" Or PrivilegePick.SelectedIndex = -1 Then
            MsgBox("Fill All Fields")
        ElseIf EmailInput.Text.Length < 20 Then
            MsgBox("Invalid Email")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "INSERT INTO employee_tb (`Employee_ID`,`FirstName`,`LastName`,`Address`,`EmailAddress`,`ContactNum`,`Privilege`,`user`,`pass`)
                                     VALUES ('','" & FirstNameInput.Text & "','" & LastNameInput.Text & "','" & AddressInput.Text & "','" & EmailInput.Text & "'," & ContactNumInput.Text & ",'" & PrivilegePick.SelectedItem & "', '" & EUserInput.Text & "', '" & EPassInput.Text & "')"
                MsgBox("Employee Successfully Added")
                Command.ExecuteNonQuery()

                Command.CommandText = "SELECT employee_ID AS 'Access ID', firstname AS 'First Name', lastname AS 'Last Name', address AS 'Address', emailAddress AS 'Email Address', contactNum AS 'Contact Number', privilege AS 'Privilege' FROM employee_tb"
                Adapter.SelectCommand = Command
                ETable.Clear()
                Adapter.Fill(ETable)
                AdminForm.EmployeesDGV.DataSource = ETable
                Connection.Close()

                FirstNameInput.Clear()
                LastNameInput.Clear()
                AddressInput.Clear()
                EmailInput.Clear()
                ContactNumInput.Clear()
                PrivilegePick.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub LastNameInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameInput.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstNameInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameInput.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class