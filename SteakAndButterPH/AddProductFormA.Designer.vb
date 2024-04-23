<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProductFormA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductFormA))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.StockInIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ProductNameInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PriceInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.QuantityInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CriticalLvlInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BestBeforeDate = New System.Windows.Forms.DateTimePicker()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplierIDInput = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 200
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Animated = True
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitBtn.FillColor = System.Drawing.Color.Transparent
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ExitBtn.Image = Global.SteakAndButterPH.My.Resources.Resources.reject
        Me.ExitBtn.Location = New System.Drawing.Point(398, 0)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(52, 24)
        Me.ExitBtn.TabIndex = 2
        '
        'StockInIcon
        '
        Me.StockInIcon.BackColor = System.Drawing.Color.Transparent
        Me.StockInIcon.FillColor = System.Drawing.Color.Transparent
        Me.StockInIcon.Image = Global.SteakAndButterPH.My.Resources.Resources.plus_sign
        Me.StockInIcon.ImageRotate = 0!
        Me.StockInIcon.Location = New System.Drawing.Point(24, 24)
        Me.StockInIcon.Name = "StockInIcon"
        Me.StockInIcon.Size = New System.Drawing.Size(39, 38)
        Me.StockInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StockInIcon.TabIndex = 4
        Me.StockInIcon.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(69, 20)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(272, 48)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "ADD PRODUCT"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 93)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(141, 28)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Product Name"
        '
        'ProductNameInput
        '
        Me.ProductNameInput.BackColor = System.Drawing.Color.Transparent
        Me.ProductNameInput.BorderRadius = 2
        Me.ProductNameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameInput.DefaultText = ""
        Me.ProductNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ProductNameInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameInput.ForeColor = System.Drawing.Color.Black
        Me.ProductNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ProductNameInput.Location = New System.Drawing.Point(24, 128)
        Me.ProductNameInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductNameInput.Name = "ProductNameInput"
        Me.ProductNameInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductNameInput.PlaceholderText = ""
        Me.ProductNameInput.SelectedText = ""
        Me.ProductNameInput.Size = New System.Drawing.Size(220, 30)
        Me.ProductNameInput.TabIndex = 6
        '
        'PriceInput
        '
        Me.PriceInput.BackColor = System.Drawing.Color.Transparent
        Me.PriceInput.BorderRadius = 2
        Me.PriceInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceInput.DefaultText = ""
        Me.PriceInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PriceInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceInput.ForeColor = System.Drawing.Color.Black
        Me.PriceInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.PriceInput.IconLeft = Global.SteakAndButterPH.My.Resources.Resources.philippines_peso_currency_symbol
        Me.PriceInput.IconLeftSize = New System.Drawing.Size(15, 15)
        Me.PriceInput.Location = New System.Drawing.Point(276, 128)
        Me.PriceInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PriceInput.Name = "PriceInput"
        Me.PriceInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceInput.PlaceholderText = ""
        Me.PriceInput.SelectedText = ""
        Me.PriceInput.Size = New System.Drawing.Size(141, 30)
        Me.PriceInput.TabIndex = 8
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(276, 93)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(50, 28)
        Me.Guna2HtmlLabel3.TabIndex = 7
        Me.Guna2HtmlLabel3.Text = "Price"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(24, 185)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(110, 28)
        Me.Guna2HtmlLabel4.TabIndex = 9
        Me.Guna2HtmlLabel4.Text = "Supplier ID"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(157, 185)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(87, 28)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "Quantity"
        '
        'QuantityInput
        '
        Me.QuantityInput.BackColor = System.Drawing.Color.Transparent
        Me.QuantityInput.BorderRadius = 2
        Me.QuantityInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityInput.DefaultText = ""
        Me.QuantityInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.QuantityInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityInput.ForeColor = System.Drawing.Color.Black
        Me.QuantityInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.QuantityInput.Location = New System.Drawing.Point(157, 220)
        Me.QuantityInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuantityInput.Name = "QuantityInput"
        Me.QuantityInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityInput.PlaceholderText = ""
        Me.QuantityInput.SelectedText = ""
        Me.QuantityInput.Size = New System.Drawing.Size(110, 36)
        Me.QuantityInput.TabIndex = 12
        '
        'CriticalLvlInput
        '
        Me.CriticalLvlInput.BackColor = System.Drawing.Color.Transparent
        Me.CriticalLvlInput.BorderRadius = 2
        Me.CriticalLvlInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CriticalLvlInput.DefaultText = ""
        Me.CriticalLvlInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CriticalLvlInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CriticalLvlInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CriticalLvlInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CriticalLvlInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.CriticalLvlInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriticalLvlInput.ForeColor = System.Drawing.Color.Black
        Me.CriticalLvlInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.CriticalLvlInput.Location = New System.Drawing.Point(291, 220)
        Me.CriticalLvlInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CriticalLvlInput.Name = "CriticalLvlInput"
        Me.CriticalLvlInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CriticalLvlInput.PlaceholderText = ""
        Me.CriticalLvlInput.SelectedText = ""
        Me.CriticalLvlInput.Size = New System.Drawing.Size(126, 36)
        Me.CriticalLvlInput.TabIndex = 14
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(291, 185)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(126, 28)
        Me.Guna2HtmlLabel6.TabIndex = 13
        Me.Guna2HtmlLabel6.Text = "Critical Level"
        '
        'BestBeforeDate
        '
        Me.BestBeforeDate.CalendarForeColor = System.Drawing.Color.White
        Me.BestBeforeDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BestBeforeDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BestBeforeDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.BestBeforeDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BestBeforeDate.CustomFormat = "yyyy-MM-dd"
        Me.BestBeforeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BestBeforeDate.Location = New System.Drawing.Point(24, 309)
        Me.BestBeforeDate.Name = "BestBeforeDate"
        Me.BestBeforeDate.Size = New System.Drawing.Size(184, 28)
        Me.BestBeforeDate.TabIndex = 15
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(24, 275)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(113, 28)
        Me.Guna2HtmlLabel7.TabIndex = 16
        Me.Guna2HtmlLabel7.Text = "Best Before"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(233, 275)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(152, 28)
        Me.Guna2HtmlLabel8.TabIndex = 18
        Me.Guna2HtmlLabel8.Text = "Expiration Date"
        '
        'ExpirationDate
        '
        Me.ExpirationDate.CalendarForeColor = System.Drawing.Color.White
        Me.ExpirationDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpirationDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ExpirationDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.ExpirationDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ExpirationDate.CustomFormat = "yyyy-MM-dd"
        Me.ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpirationDate.Location = New System.Drawing.Point(233, 309)
        Me.ExpirationDate.Name = "ExpirationDate"
        Me.ExpirationDate.Size = New System.Drawing.Size(184, 28)
        Me.ExpirationDate.TabIndex = 17
        '
        'AddBtn
        '
        Me.AddBtn.Animated = True
        Me.AddBtn.BackColor = System.Drawing.Color.Transparent
        Me.AddBtn.BorderColor = System.Drawing.Color.Transparent
        Me.AddBtn.BorderRadius = 2
        Me.AddBtn.BorderThickness = 1
        Me.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddBtn.FillColor = System.Drawing.Color.White
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.Black
        Me.AddBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.AddBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(346, 367)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(71, 35)
        Me.AddBtn.TabIndex = 19
        Me.AddBtn.Text = "ADD"
        '
        'SupplierIDInput
        '
        Me.SupplierIDInput.BackColor = System.Drawing.Color.Transparent
        Me.SupplierIDInput.BorderRadius = 2
        Me.SupplierIDInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupplierIDInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierIDInput.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SupplierIDInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SupplierIDInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierIDInput.ForeColor = System.Drawing.Color.Black
        Me.SupplierIDInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SupplierIDInput.ItemHeight = 30
        Me.SupplierIDInput.Location = New System.Drawing.Point(24, 220)
        Me.SupplierIDInput.Name = "SupplierIDInput"
        Me.SupplierIDInput.Size = New System.Drawing.Size(113, 36)
        Me.SupplierIDInput.TabIndex = 21
        '
        'AddProductFormA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SteakAndButterPH.My.Resources.Resources.SISOBG1
        Me.ClientSize = New System.Drawing.Size(450, 435)
        Me.Controls.Add(Me.SupplierIDInput)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.ExpirationDate)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.BestBeforeDate)
        Me.Controls.Add(Me.CriticalLvlInput)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.QuantityInput)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.PriceInput)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.ProductNameInput)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.StockInIcon)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ExitBtn)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AddProductFormA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockInForm"
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StockInIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PriceInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ProductNameInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BestBeforeDate As DateTimePicker
    Friend WithEvents CriticalLvlInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents QuantityInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExpirationDate As DateTimePicker
    Friend WithEvents SupplierIDInput As Guna.UI2.WinForms.Guna2ComboBox
End Class
