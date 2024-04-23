Imports ClosedXML.Excel
Imports System.Data.OleDb

Public Class EmployeeFormA

    'DISPLAYED
    'LOC  = 209, 45
    'SIZE = 979, 652

    'HIDDEN DASHBOARD
    'LOC  = 225, 725
    'SIZE = 25,25

    Dim StorageSum As Integer = 0
    Dim StorageCount As Integer = 0
    Dim StorageAverage As Integer = 0

    Private Sub Transact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
        OpenConnection()
        Try
            Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
            Adapter.SelectCommand = Command
            PTable.Clear()
            Adapter.Fill(PTable)
            ProductsDGV.DataSource = PTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        For i As Integer = 0 To ProductsDGV.RowCount - 1
            StorageSum += ProductsDGV.Rows(i).Cells(2).Value
        Next
        If StorageSum = 0 Then
            MessageBox.Show("No Records Found")
        End If
        StorageCount = ProductsDGV.Rows.Count
        StorageAverage = (StorageSum / StorageCount) * 0.1
        StorageCapText.Text = StorageAverage.ToString
        StorageCapMetric.Value = StorageAverage

    End Sub

    Sub LoadDashboard()
        OpenConnection()
        Try
            Command.Connection = Connection

            Command.CommandText = "SELECT product_name AS 'Product Name', prod_quantity AS 'Quantity' FROM product_tbl ORDER BY prod_quantity ASC LIMIT 5"
            Adapter.SelectCommand = Command
            CSTable.Clear()
            Adapter.Fill(CSTable)
            CriticalDGV.DataSource = CSTable

            Command.CommandText = "SELECT product_name AS 'Product Name', Expiration_Date AS 'Expiration Date' FROM product_tbl ORDER BY Expiration_Date ASC LIMIT 5"
            Adapter.SelectCommand = Command
            NETable.Clear()
            Adapter.Fill(NETable)
            ExpirationDGV.DataSource = NETable

            Command.CommandText = "SELECT product_name AS 'Product Name', prod_quantity AS 'Quantity' FROM product_tbl ORDER BY prod_quantity DESC LIMIT 5"
            Adapter.SelectCommand = Command
            SLTable.Clear()
            Adapter.Fill(SLTable)
            StockDGV.DataSource = SLTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim LogOut As Integer
        LogOut = MsgBox("Would you like to log out?", vbYesNo)
        If LogOut = vbYes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        LoadDashboard()

        DashboardBtn.FillColor = Color.FromArgb(170, 140, 100, 100)

        ProductsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        SuppliersBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        TransactionsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)

        DashboardPnl.Size = New Size(979, 652)
        DashboardPnl.Location = New Point(209, 45)
        DashboardPnl.Visible = True

        ProductsPanel.Size = New Size(25, 25)
        ProductsPanel.Location = New Point(255, 725)
        ProductsPanel.Visible = False
        SuppliersPanel.Size = New Size(25, 25)
        SuppliersPanel.Location = New Point(285, 725)
        SuppliersPanel.Visible = False
        TransactionsPanel.Size = New Size(25, 25)
        TransactionsPanel.Location = New Point(285, 725)
        TransactionsPanel.Visible = False
        EmployeesPanel.Size = New Size(25, 25)
        EmployeesPanel.Location = New Point(315, 725)
        EmployeesPanel.Visible = False

        OpenConnection()
        Try
            Command.Connection = Connection

            Command.CommandText = "SELECT product_name AS 'Product Name', prod_quantity AS 'Quantity' FROM product_tbl ORDER BY prod_quantity ASC LIMIT 5"
            Adapter.SelectCommand = Command
            CSTable.Clear()
            Adapter.Fill(CSTable)
            CriticalDGV.DataSource = CSTable

            Command.CommandText = "SELECT product_name AS 'Product Name', Expiration_Date AS 'Expiration Date' FROM product_tbl ORDER BY Expiration_Date ASC LIMIT 5"
            Adapter.SelectCommand = Command
            NETable.Clear()
            Adapter.Fill(NETable)
            ExpirationDGV.DataSource = NETable

            Command.CommandText = "SELECT product_name AS 'Product Name', prod_quantity AS 'Quantity' FROM product_tbl ORDER BY prod_quantity DESC LIMIT 5"
            Adapter.SelectCommand = Command
            SLTable.Clear()
            Adapter.Fill(SLTable)
            StockDGV.DataSource = SLTable
            Connection.Close()

            StorageSum = 0
            For i As Integer = 0 To ProductsDGV.RowCount - 1
                StorageSum += ProductsDGV.Rows(i).Cells(2).Value
            Next
            If StorageSum = 0 Then
                MessageBox.Show("No Records Found. Metrics Cannot Be Displayed")
            End If
            StorageCount = ProductsDGV.Rows.Count
            StorageAverage = (StorageSum / StorageCount) * 0.1
            StorageCapText.Text = StorageAverage.ToString
            StorageCapMetric.Value = StorageAverage
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        ProductsBtn.FillColor = Color.FromArgb(170, 140, 100, 100)

        DashboardBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        SuppliersBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        TransactionsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)

        ProductsPanel.Size = New Size(979, 652)
        ProductsPanel.Location = New Point(209, 45)
        ProductsPanel.Visible = True

        DashboardPnl.Size = New Size(25, 25)
        DashboardPnl.Location = New Point(225, 725)
        DashboardPnl.Visible = False
        SuppliersPanel.Size = New Size(25, 25)
        SuppliersPanel.Location = New Point(285, 725)
        SuppliersPanel.Visible = False
        TransactionsPanel.Size = New Size(25, 25)
        TransactionsPanel.Location = New Point(285, 725)
        TransactionsPanel.Visible = False
        EmployeesPanel.Size = New Size(25, 25)
        EmployeesPanel.Location = New Point(315, 725)
        EmployeesPanel.Visible = False

        OpenConnection()
        Try
            Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
            Adapter.SelectCommand = Command
            PTable.Clear()
            Adapter.Fill(PTable)
            ProductsDGV.DataSource = PTable
            Connection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub SuppliersBtn_Click(sender As Object, e As EventArgs) Handles SuppliersBtn.Click
        SuppliersBtn.FillColor = Color.FromArgb(170, 140, 100, 100)

        DashboardBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        ProductsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        TransactionsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)

        SuppliersPanel.Size = New Size(979, 652)
        SuppliersPanel.Location = New Point(209, 45)
        SuppliersPanel.Visible = True

        DashboardPnl.Size = New Size(25, 25)
        DashboardPnl.Location = New Point(225, 725)
        DashboardPnl.Visible = False
        ProductsPanel.Size = New Size(25, 25)
        ProductsPanel.Location = New Point(255, 725)
        ProductsPanel.Visible = False
        TransactionsPanel.Size = New Size(25, 25)
        TransactionsPanel.Location = New Point(285, 725)
        TransactionsPanel.Visible = False
        EmployeesPanel.Size = New Size(25, 25)
        EmployeesPanel.Location = New Point(315, 725)
        EmployeesPanel.Visible = False

        OpenConnection()
        Try
            Command.CommandText = "SELECT supplier_ID AS 'Supplier ID', company_name AS 'Company Name', address AS 'Address', email AS 'Email Address', contactNum AS 'Contact Number' FROM supplier_tbl"
            Adapter.SelectCommand = Command
            STable.Clear()
            Adapter.Fill(STable)
            SuppliersDGV.DataSource = STable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TransactionsBtn_Click(sender As Object, e As EventArgs) Handles TransactionsBtn.Click
        TransactionsBtn.FillColor = Color.FromArgb(170, 140, 100, 100)

        DashboardBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        ProductsBtn.FillColor = Color.FromArgb(220, 50, 50, 50)
        SuppliersBtn.FillColor = Color.FromArgb(220, 50, 50, 50)

        TransactionsPanel.Size = New Size(979, 652)
        TransactionsPanel.Location = New Point(209, 45)
        TransactionsPanel.Visible = True

        DashboardPnl.Size = New Size(25, 25)
        DashboardPnl.Location = New Point(225, 725)
        DashboardPnl.Visible = False
        ProductsPanel.Size = New Size(25, 25)
        ProductsPanel.Location = New Point(255, 725)
        ProductsPanel.Visible = False
        SuppliersPanel.Size = New Size(25, 25)
        SuppliersPanel.Location = New Point(285, 725)
        SuppliersPanel.Visible = False
        EmployeesPanel.Size = New Size(25, 25)
        EmployeesPanel.Location = New Point(315, 725)
        EmployeesPanel.Visible = False


        OpenConnection()
        Try
            Command.CommandText = "SELECT deposit_date AS 'Deposit Date', supplier_ID AS 'Supplier ID', product_name AS 'Product Name', product_quantity AS 'Quantity', supplier_contact AS 'Contact Number' FROM deposit_tbl"
            Adapter.SelectCommand = Command
            DTable.Clear()
            Adapter.Fill(DTable)
            StockInDGV.DataSource = DTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        AddProductFormE.Show()
    End Sub

    Private Sub StockInBtn_Click(sender As Object, e As EventArgs) Handles StockInBtn.Click
        StockInFormE.StockInInput.Text = ProductsDGV.Item("Product Name", ProductsDGV.CurrentRow.Index).Value
        StockInFormE.Show()
    End Sub

    Private Sub StockOutBtn_Click(sender As Object, e As EventArgs) Handles StockOutBtn.Click
        StockOutFormE.StockOutInput.Text = ProductsDGV.Item("Product Name", ProductsDGV.CurrentRow.Index).Value
        StockOutFormE.Show()
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Dim currentSelectedRow As Integer
        Dim delConfirm As String
        currentSelectedRow = ProductsDGV.CurrentRow.Selected
        delConfirm = MsgBox("Delete the record of " + ProductsDGV.Item("Product Name", ProductsDGV.CurrentRow.Index).Value, vbYesNo)
        If (delConfirm = vbYes) Then
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "DELETE FROM product_tbl WHERE product_name LIKE '%" & ProductsDGV.Item("Product Name", ProductsDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("DELETED!!")

                Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl"
                Adapter.SelectCommand = Command

                PTable.Clear()
                Adapter.Fill(PTable)
                ProductsDGV.DataSource = PTable
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditProductFormE.Show()
        EditProductFormE.ProductNameInput.Text = ProductsDGV.Item("Product Name", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.QuantityInput.Text = ProductsDGV.Item("Quantity", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.PriceInput.Text = ProductsDGV.Item("Price", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.SupplierIDInput.Text = ProductsDGV.Item("Supplier ID", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.BestBeforeDate.Text = ProductsDGV.Item("Best Before", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.ExpirationDate.Text = ProductsDGV.Item("Expiration Date", ProductsDGV.CurrentRow.Index).Value
        EditProductFormE.CriticalLvlInput.Text = ProductsDGV.Item("Critical Level", ProductsDGV.CurrentRow.Index).Value
    End Sub

    Private Sub PSearchBar_TextChanged(sender As Object, e As EventArgs) Handles PSearchBar.TextChanged
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "SELECT product_ID AS 'Product ID', product_name AS 'Product Name', prod_quantity AS 'Quantity', price AS 'Price', supplier_ID AS 'Supplier ID', Best_Before AS 'Best Before', Expiration_Date AS 'Expiration Date', Critical_Level AS 'Critical Level' FROM product_tbl WHERE product_name LIKE '%" & PSearchBar.Text & "%'"
            Adapter.SelectCommand = Command
            PTable.Clear()
            Adapter.Fill(PTable)
            SuppliersDGV.DataSource = PTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SAddBtn_Click(sender As Object, e As EventArgs)
        AddSupplierForm.Show()
    End Sub

    Private Sub SEditBtn_Click(sender As Object, e As EventArgs)
        EditSupplierForm.Show()
        EditSupplierForm.CompanyNameInput.Text = SuppliersDGV.Item("company_name", SuppliersDGV.CurrentRow.Index).Value
        EditSupplierForm.AddressInput.Text = SuppliersDGV.Item("address", SuppliersDGV.CurrentRow.Index).Value
        EditSupplierForm.EmailInput.Text = SuppliersDGV.Item("email", SuppliersDGV.CurrentRow.Index).Value
        EditSupplierForm.ContactNumInput.Text = SuppliersDGV.Item("contactNum", SuppliersDGV.CurrentRow.Index).Value
    End Sub

    Private Sub SSearchBar_TextChanged(sender As Object, e As EventArgs) Handles SSearchBar.TextChanged
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "SELECT supplier_ID AS 'Supplier ID', company_name AS 'Company Name', address AS 'Address', email AS 'Email Address', contactNum AS 'Contact Number' FROM supplier_tbl WHERE company_name LIKE '%" & SSearchBar.Text & "%'"
            Adapter.SelectCommand = Command
            STable.Clear()
            Adapter.Fill(STable)
            SuppliersDGV.DataSource = STable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SRemoveBtn_Click(sender As Object, e As EventArgs)
        Dim delConfirm As String
        delConfirm = MsgBox("Delete the selected row?", vbYesNo)
        If (delConfirm = vbYes) Then

            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "DELETE FROM supplier_tbl WHERE company_name LIKE '%" & SuppliersDGV.Item("Company Name", SuppliersDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("DELETED!!")

                STable.Clear()
                Adapter.Fill(STable)
                SuppliersDGV.DataSource = STable
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub SODeleteBtn_Click(sender As Object, e As EventArgs)
        Dim delConfirm As String
        delConfirm = MsgBox("Delete the selected row?", vbYesNo)
        If (delConfirm = vbYes) Then
            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "DELETE FROM withdraw_tbl WHERE company_name LIKE '%" & StockOutDGV.Item("Company Name", StockOutDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("DELETED!!")

                WTable.Clear()
                Adapter.Fill(WTable)
                StockOutDGV.DataSource = WTable
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SOExcelBtn_Click(sender As Object, e As EventArgs) Handles SOExcelBtn.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()
                        workbook.Worksheets.Add(WTable, "Stock Out Table")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MsgBox("Data successfully exported.")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End Using
    End Sub

    Private Sub SOSearch_TextChanged(sender As Object, e As EventArgs)
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "SELECT withdraw_date AS 'Withdraw Date', supplier_ID AS 'Supplier ID', company_name AS 'Company Name', product_name AS 'Product Name', product_quantity AS 'Quantity', supplier_contact AS 'Contact Number' FROM withdraw_tbl WHERE company_name LIKE '%" & SOSearch.Text & "%'"
            Adapter.SelectCommand = Command
            WTable.Clear()
            Adapter.Fill(WTable)
            StockOutDGV.DataSource = WTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SIDeleteBtn_Click(sender As Object, e As EventArgs)
        Dim delConfirm As String
        delConfirm = MsgBox("Delete the selected row?", vbYesNo)
        If (delConfirm = vbYes) Then

            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "DELETE FROM deposit_tbl WHERE supplier_ID LIKE '%" & StockInDGV.Item("Company Name", StockInDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("DELETED!!")

                DTable.Clear()
                Adapter.Fill(DTable)
                StockInDGV.DataSource = DTable
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub SIExcelBtn_Click(sender As Object, e As EventArgs) Handles SIExcelBtn.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()
                        workbook.Worksheets.Add(DTable, "Stock In Table")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MsgBox("Data successfully exported.")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End Using
    End Sub

    Private Sub SISearch_TextChanged(sender As Object, e As EventArgs) Handles SISearch.TextChanged
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "SELECT deposit_date AS 'Deposit Date', supplier_ID AS 'Supplier ID', company_name AS 'Company Name', product_name AS 'Product Name', product_quantity AS 'Quantity', supplier_contact AS 'Contact Number' FROM deposit_tbl WHERE company_name LIKE '%" & SISearch.Text & "%'"
            Adapter.SelectCommand = Command
            DTable.Clear()
            Adapter.Fill(DTable)
            StockInDGV.DataSource = DTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub StockInTabBtn_Click(sender As Object, e As EventArgs) Handles StockInTabBtn.Click
        StockInPanel.Size = New Size(956, 505)
        StockInPanel.Location = New Point(12, 135)
        StockInPanel.Visible = True
        StockInTabBtn.FillColor = Color.White
        StockInTabBtn.ForeColor = Color.Black

        StockOutPanel.Size = New Size(30, 30)
        StockOutPanel.Location = New Point(885, 53)
        StockOutPanel.Visible = False
        StockOutTabBtn.FillColor = Color.Transparent
        StockOutTabBtn.ForeColor = Color.White

        OpenConnection()
        Try
            Command.CommandText = "SELECT deposit_date AS 'Deposit Date', supplier_ID AS 'Supplier ID', company_name AS 'Company Name', product_name AS 'Product Name', product_quantity AS 'Quantity', supplier_contact AS 'Contact Number' FROM deposit_tbl"
            Adapter.SelectCommand = Command
            DTable.Clear()
            Adapter.Fill(DTable)
            StockInDGV.DataSource = DTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub StockOutTabBtn_Click(sender As Object, e As EventArgs) Handles StockOutTabBtn.Click
        StockOutPanel.Size = New Size(956, 505)
        StockOutPanel.Location = New Point(12, 135)
        StockOutPanel.Visible = True
        StockOutTabBtn.FillColor = Color.White
        StockOutTabBtn.ForeColor = Color.Black

        StockInPanel.Size = New Size(30, 30)
        StockInPanel.Location = New Point(835, 53)
        StockInPanel.Visible = False
        StockInTabBtn.FillColor = Color.Transparent
        StockInTabBtn.ForeColor = Color.White

        OpenConnection()
        Try
            Command.CommandText = "SELECT withdraw_date AS 'Withdraw Date', supplier_ID AS 'Supplier ID', company_name AS 'Company Name', product_name AS 'Product Name', product_quantity AS 'Quantity', supplier_contact AS 'Contact Number' FROM withdraw_tbl"
            Adapter.SelectCommand = Command
            WTable.Clear()
            Adapter.Fill(WTable)
            StockOutDGV.DataSource = WTable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EDeleteBtn_Click(sender As Object, e As EventArgs) Handles EDeleteBtn.Click
        Dim delConfirm As String
        delConfirm = MsgBox("Remove " + EmployeesDGV.Item("Last Name", EmployeesDGV.CurrentRow.Index).Value, vbYesNo)
        If (delConfirm = vbYes) Then

            OpenConnection()
            Try
                Command.Connection = Connection
                Command.CommandText = "DELETE FROM employee_tb WHERE LastName LIKE '%" & EmployeesDGV.Item("Last Name", EmployeesDGV.CurrentRow.Index).Value & "%' "
                Command.ExecuteNonQuery()
                MsgBox("DELETED!!")

                ETable.Clear()
                Adapter.Fill(ETable)
                EmployeesDGV.DataSource = ETable
                Connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ESearchBar_TextChanged(sender As Object, e As EventArgs) Handles ESearchBar.TextChanged
        OpenConnection()
        Try
            Command.Connection = Connection
            Command.CommandText = "SELECT employee_ID AS 'Employee ID', firstname AS 'First Name', lastname AS 'Last Name', address AS 'Address', emailAddress AS 'Email Address', contactNum AS 'Contact Number', privilege AS 'Privilege' FROM employee_tb WHERE FirstName LIKE '%" & ESearchBar.Text & "%'"
            Adapter.SelectCommand = Command
            ETable.Clear()
            Adapter.Fill(ETable)
            EmployeesDGV.DataSource = ETable
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EAddBtn_Click(sender As Object, e As EventArgs) Handles EAddBtn.Click
        AddEmployeeForm.Show()
    End Sub

    Private Sub EEditBtn_Click(sender As Object, e As EventArgs) Handles EEditBtn.Click
        EditEmployeeForm.Show()
        EditEmployeeForm.FirstNameInput.Text = EmployeesDGV.Item("FirstName", EmployeesDGV.CurrentRow.Index).Value
        EditEmployeeForm.LastNameInput.Text = EmployeesDGV.Item("LastName", EmployeesDGV.CurrentRow.Index).Value
        EditEmployeeForm.AddressInput.Text = EmployeesDGV.Item("Address", EmployeesDGV.CurrentRow.Index).Value
        EditEmployeeForm.EmailInput.Text = EmployeesDGV.Item("EmailAddress", EmployeesDGV.CurrentRow.Index).Value
        EditEmployeeForm.ContactNumInput.Text = EmployeesDGV.Item("ContactNum", EmployeesDGV.CurrentRow.Index).Value
        EditEmployeeForm.PrivilegePick.Text = EmployeesDGV.Item("privilege", EmployeesDGV.CurrentRow.Index).Value
    End Sub

    Private Sub ChangePasswordBtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordBtn.Click
        ChangePasswordForm.Show()
    End Sub

    Private Sub PrintBtn1_Click(sender As Object, e As EventArgs) Handles PrintBtn1.Click
        PSD1.Document = PD1
        PSD1.Document.DefaultPageSettings.Color = False
        PSD1.ShowDialog()
        PPD1.ShowDialog()
        PD1.Print()
    End Sub

    Private Sub PD1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD1.PrintPage
        Dim bm As New Bitmap(Me.StockInDGV.Width, Me.StockInDGV.Height)
        StockInDGV.DrawToBitmap(bm, New Rectangle(0, 30, Me.StockInDGV.Width, Me.StockInDGV.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintBtn2_Click(sender As Object, e As EventArgs) Handles PrintBtn2.Click
        PSD2.Document = PD2
        PSD2.Document.DefaultPageSettings.Color = False
        PSD2.ShowDialog()
        PPD2.ShowDialog()
        PD2.Print()
    End Sub

    Private Sub PD2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Dim bm As New Bitmap(Me.StockInDGV.Width, Me.StockInDGV.Height)
        StockInDGV.DrawToBitmap(bm, New Rectangle(0, 30, Me.StockInDGV.Width, Me.StockInDGV.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

End Class