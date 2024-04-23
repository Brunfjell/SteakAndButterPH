Public Class AddSupplierForm
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        If CompanyNameInput.Text = "" Or AddressInput.Text = "" Or EmailAddress.Text = "" Or ContactNumInput.Text = "" Then
            MsgBox("Fill All Fields")
        ElseIf EmailAddress.Text.Length < 20 Then
            MsgBox("Invalid Email")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "INSERT INTO supplier_tbl (`supplier_ID`,`company_name`,`address`,`email`,`contactNum`)
                                     VALUES ('','" & CompanyNameInput.Text & "','" & AddressInput.Text & "','" & EmailAddress.Text & "','" & ContactNumInput.Text & "')"
                MsgBox("Supplier Successfully Added")
                Command.ExecuteNonQuery()

                Command.CommandText = "SELECT supplier_ID AS 'Supplier ID', company_name AS 'Company Name', address AS 'Address', email AS 'Email Address', contactNum AS 'Contact Number' FROM supplier_tbl"
                Adapter.SelectCommand = Command
                STable.Clear()
                Adapter.Fill(STable)
                AdminForm.SuppliersDGV.DataSource = STable
                Connection.Close()

                CompanyNameInput.Clear()
                AddressInput.Clear()
                EmailAddress.Clear()
                ContactNumInput.Clear()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub ContactNumInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNumInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class