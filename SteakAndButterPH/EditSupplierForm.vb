Public Class EditSupplierForm
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "UPDATE supplier_tbl  SET company_name = '" & CompanyNameInput.Text & "', address = '" & AddressInput.Text & "',
                                           email = '" & EmailInput.Text & "', ContactNum = '" & ContactNumInput.Text & "' WHERE supplier_ID = '" & AdminForm.SuppliersDGV.Item("Supplier ID", AdminForm.SuppliersDGV.CurrentRow.Index).Value & "'"
            MsgBox("Information Updated")
            Command.ExecuteNonQuery()

            Command.CommandText = "SELECT supplier_ID AS 'Supplier ID', company_name AS 'Company Name', address AS 'Address', email AS 'Email Address', contactNum AS 'Contact Number' FROM supplier_tbl"
            Adapter.SelectCommand = Command
            STable.Clear()
            Adapter.Fill(STable)
            AdminForm.SuppliersDGV.DataSource = STable
            Connection.Close()

            CompanyNameInput.Clear()
            AddressInput.Clear()
            EmailInput.Clear()
            ContactNumInput.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

End Class