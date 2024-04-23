Public Class StockInFormE

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) 
        StockInInput.Text = ""
        QuantityInput.Clear()
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click

        If (StockInInput.Text = "" Or QuantityInput.Text = "") Then
            MsgBox("Fill All Fields")
        ElseIf (AdminForm.StorageSum + QuantityInput.Text) > 10000 Then
            MsgBox("Not Enough Space In The Warehouse.")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "UPDATE product_tbl SET prod_quantity = prod_quantity + '" & QuantityInput.Text & "' WHERE product_ID LIKE '%" & EmployeeFormA.ProductsDGV.Item("Product ID", EmployeeFormA.ProductsDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("Quantity Added")

                Command.Connection = Connection
                Command.CommandText = "INSERT INTO deposit_tbl(deposit_ID, deposit_date, supplier_ID, company_name, product_name, product_quantity, supplier_contact) VALUES ('', '" & Date.Now & "','" & EmployeeFormA.ProductsDGV.Item("Supplier ID", EmployeeFormA.ProductsDGV.CurrentRow.Index).Value & "','" & EmployeeFormA.SuppliersDGV.Item("Company Name", EmployeeFormA.SuppliersDGV.CurrentRow.Index).Value & "','" & EmployeeFormA.ProductsDGV.Item("Product Name", EmployeeFormA.ProductsDGV.CurrentRow.Index).Value & "','" & QuantityInput.Text & "','" & EmployeeFormA.SuppliersDGV.Item("Contact Number", EmployeeFormA.SuppliersDGV.CurrentRow.Index).Value & "')"
                Command.ExecuteNonQuery()
                Adapter.SelectCommand = Command

                Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
                Command.ExecuteNonQuery()
                Adapter.SelectCommand = Command
                PTable.Clear()
                Adapter.Fill(PTable)
                EmployeeFormA.ProductsDGV.DataSource = PTable

                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub QuantityInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class