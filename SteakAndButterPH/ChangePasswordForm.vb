Imports MySql.Data.MySqlClient
Public Class ChangePasswordForm

    'DISPLAYED S = 406, 174     L = 16,71

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            OpenConnection()
            Dim Login As New MySqlCommand("SELECT * FROM `employee_tb` WHERE `employee_ID` = @accessid AND `pass` = @password", Connection)
            Login.Parameters.Add("@accessid", MySqlDbType.VarChar).Value = AccessIDInput.Text
            Login.Parameters.Add("@password", MySqlDbType.VarChar).Value = CurrentPasswordInput.Text
            Dim adapter As New MySqlDataAdapter(Login)
            Dim CPTable As New DataTable()
            CPTable.Clear()
            adapter.Fill(CPTable)
            Connection.Close()

            If CPTable.Rows.Count = 0 Then
                MessageBox.Show("Username or Password are incorrect")
            Else
                AcctCnfrmPnl1.Location = New Point(16, 253)
                AcctCnfrmPnl1.Size = New Size(20, 20)
                AcctCnfrmPnl1.Visible = False
                AcctCnfrmPnl2.Location = New Point(16, 71)
                AcctCnfrmPnl2.Size = New Size(406, 174)
                AcctCnfrmPnl2.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Username or Password are incorrect")
        End Try
    End Sub

    Private Sub CancelPBtn_Click(sender As Object, e As EventArgs) Handles CancelPBtn.Click
        AcctCnfrmPnl2.Location = New Point(36, 253)
        AcctCnfrmPnl2.Size = New Size(20, 20)
        AcctCnfrmPnl2.Visible = False
        AcctCnfrmPnl1.Location = New Point(16, 71)
        AcctCnfrmPnl1.Size = New Size(406, 174)
        AcctCnfrmPnl1.Visible = True
        AccessIDInput.Text = ""
        CurrentPasswordInput.Text = ""
    End Sub

    Private Sub UpdatePBtn_Click(sender As Object, e As EventArgs) Handles UpdatePBtn.Click
        If (NewPasswordInput.TextLength < 7 And ConfirmPasswordInput.TextLength < 7) Then
            MsgBox("The Password you have chosen is weak.")
        ElseIf (ConfirmPasswordInput.Text <> NewPasswordInput.Text) Then
            MsgBox("Password doesn't match")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "UPDATE employee_tb  SET pass = '" & ConfirmPasswordInput.Text & "' WHERE employee_ID = '" & AccessIDInput.Text & "'"
                MsgBox("Password Succesfully Changed")
                Command.ExecuteNonQuery()
                Connection.Close()

                AccessIDInput.Clear()
                CurrentPasswordInput.Clear()
                NewPasswordInput.Clear()
                ConfirmPasswordInput.Clear()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class