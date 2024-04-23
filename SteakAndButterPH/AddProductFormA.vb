Public Class AddProductFormA

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        If (ProductNameInput.Text = "" Or QuantityInput.Text = "" Or PriceInput.Text = "" Or SupplierIDInput.Text = "" Or CriticalLvlInput.Text = "") Then
            MsgBox("Fill All Fields")
        Else
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "INSERT INTO product_tbl (`product_ID`,`product_name`,`prod_quantity`,`price`,`supplier_ID`,`Best_Before`,`Expiration_Date`,`Critical_Level`)
                                     VALUES ('','" & ProductNameInput.Text & "','" & QuantityInput.Text & "','" & PriceInput.Text & "','" & SupplierIDInput.Text & "','" & Format(BestBeforeDate.Value, "yyyy-MM-dd") & "','" & Format(ExpirationDate.Value, "yyyy-MM-dd") & "','" & CriticalLvlInput.Text & "')"
                MsgBox("Product Successfully Added")
                Command.ExecuteNonQuery()

                Command.Connection = Connection
                Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
                Adapter.SelectCommand = Command
                PTable.Clear()
                Adapter.Fill(PTable)
                AdminForm.ProductsDGV.DataSource = PTable

                Command.Connection = Connection
                Command.CommandText = "INSERT INTO deposit_tbl(deposit_ID, deposit_date, supplier_ID, company_name, product_name, product_quantity, supplier_contact) VALUES ('', '" & Date.Now & "','" & AdminForm.ProductsDGV.Item("Supplier ID", AdminForm.ProductsDGV.CurrentRow.Index).Value & "','" & AdminForm.SuppliersDGV.Item("Company Name", AdminForm.SuppliersDGV.CurrentRow.Index).Value & "','" & AdminForm.ProductsDGV.Item("Product Name", AdminForm.ProductsDGV.CurrentRow.Index).Value & "','" & QuantityInput.Text & "','" & AdminForm.SuppliersDGV.Item("Contact Number", AdminForm.SuppliersDGV.CurrentRow.Index).Value & "')"
                Command.ExecuteNonQuery()
                Adapter.SelectCommand = Command

                Connection.Close()

                ProductNameInput.Clear()
                QuantityInput.Clear()
                PriceInput.Clear()
                SupplierIDInput.SelectedIndex = -1
                PriceInput.Clear()
                BestBeforeDate.Value = Date.Now
                ExpirationDate.Value = Date.Now
                CriticalLvlInput.Clear()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        End If

    End Sub

    Private Sub ProductNameInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductNameInput.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
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

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        SupplierIDInput.DataSource = STable
        SupplierIDInput.DisplayMember = "Supplier ID"
        Connection.Close()
    End Sub

End Class