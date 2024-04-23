Public Class StockOutForm

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) 
        StockOutInput.Text = ""
        QuantityInput.Clear()
    End Sub

    Private Sub WithdrawBtn_Click(sender As Object, e As EventArgs) Handles WithdrawBtn.Click

        If (StockOutInput.Text = "" Or QuantityInput.Text = "") Then
            MsgBox("Fill All Fields")
        ElseIf (AdminForm.ProductsDGV.Item("Quantity", AdminForm.ProductsDGV.CurrentRow.Index).Value - QuantityInput.Text) < 0 Then
            MsgBox("Product does not have enough supply")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "UPDATE product_tbl SET prod_quantity = prod_quantity - '" & QuantityInput.Text & "' WHERE product_ID LIKE '%" & AdminForm.ProductsDGV.Item("Product ID", AdminForm.ProductsDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("Quantity Deducted")


                Command.Connection = Connection
                Command.CommandText = "INSERT INTO withdraw_tbl(withdraw_date, supplier_ID, company_name, product_name, product_quantity, supplier_contact) VALUES ('" & Date.Now & "','" & AdminForm.ProductsDGV.Item("Supplier ID", AdminForm.ProductsDGV.CurrentRow.Index).Value & "','" & AdminForm.SuppliersDGV.Item("Company Name", AdminForm.SuppliersDGV.CurrentRow.Index).Value & "','" & AdminForm.ProductsDGV.Item("Product Name", AdminForm.ProductsDGV.CurrentRow.Index).Value & "','" & QuantityInput.Text & "','" & AdminForm.SuppliersDGV.Item("Contact Number", AdminForm.SuppliersDGV.CurrentRow.Index).Value & "')"
                Command.ExecuteNonQuery()
                Adapter.SelectCommand = Command

                Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
                Adapter.SelectCommand = Command
                PTable.Clear()
                Adapter.Fill(PTable)
                AdminForm.ProductsDGV.DataSource = PTable

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