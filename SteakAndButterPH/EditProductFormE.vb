Public Class EditProductFormE
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "UPDATE product_tbl  SET product_name = '" & ProductNameInput.Text & "', prod_quantity = '" & QuantityInput.Text & "',
                                           price = '" & PriceInput.Text & "', supplier_ID = '" & SupplierIDInput.Text & "', Best_Before = " & Format(BestBeforeDate.Value, "yyyy-MM-dd") & "
                                           , Expiration_Date = " & Format(ExpirationDate.Value, "yyyy-MM-dd") & " , Critical_Level = '" & CriticalLvlInput.Text & "'WHERE product_ID = '" & EmployeeFormA.ProductsDGV.Item("Product ID", EmployeeFormA.ProductsDGV.CurrentRow.Index).Value & "'"
            MsgBox("Information Updated")
            Command.ExecuteNonQuery()

            Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
            Adapter.SelectCommand = Command
            PTable.Clear()
            Adapter.Fill(PTable)
            EmployeeFormA.ProductsDGV.DataSource = PTable
            Connection.Close()

            ProductNameInput.Clear()
            QuantityInput.Clear()
            PriceInput.Clear()
            SupplierIDInput.Clear()
            BestBeforeDate.Value = Date.Now
            ExpirationDate.Value = Date.Now
            CriticalLvlInput.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub SupplierIDInput_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub QuantityInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PriceInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CriticalLvlInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CriticalLvlInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ProductNameInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductNameInput.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class