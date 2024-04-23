<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployeeForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ContactNumInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AddressInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FirstNameInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.StockInIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LastNameInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.EmailInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PrivilegePick = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.EPassInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.EUserInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.AddBtn.Location = New System.Drawing.Point(351, 417)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(71, 35)
        Me.AddBtn.TabIndex = 47
        Me.AddBtn.Text = "ADD"
        '
        'ContactNumInput
        '
        Me.ContactNumInput.BackColor = System.Drawing.Color.Transparent
        Me.ContactNumInput.BorderRadius = 2
        Me.ContactNumInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactNumInput.DefaultText = ""
        Me.ContactNumInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ContactNumInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ContactNumInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactNumInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactNumInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ContactNumInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumInput.ForeColor = System.Drawing.Color.Black
        Me.ContactNumInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ContactNumInput.Location = New System.Drawing.Point(242, 269)
        Me.ContactNumInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNumInput.MaxLength = 11
        Me.ContactNumInput.Name = "ContactNumInput"
        Me.ContactNumInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactNumInput.PlaceholderText = ""
        Me.ContactNumInput.SelectedText = ""
        Me.ContactNumInput.Size = New System.Drawing.Size(180, 36)
        Me.ContactNumInput.TabIndex = 46
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(242, 234)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(162, 28)
        Me.Guna2HtmlLabel5.TabIndex = 45
        Me.Guna2HtmlLabel5.Text = "Contact Number"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(242, 156)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(139, 28)
        Me.Guna2HtmlLabel4.TabIndex = 43
        Me.Guna2HtmlLabel4.Text = "Email Address"
        '
        'AddressInput
        '
        Me.AddressInput.BackColor = System.Drawing.Color.Transparent
        Me.AddressInput.BorderRadius = 2
        Me.AddressInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressInput.DefaultText = ""
        Me.AddressInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.AddressInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressInput.ForeColor = System.Drawing.Color.Black
        Me.AddressInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.AddressInput.Location = New System.Drawing.Point(24, 191)
        Me.AddressInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddressInput.Name = "AddressInput"
        Me.AddressInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressInput.PlaceholderText = ""
        Me.AddressInput.SelectedText = ""
        Me.AddressInput.Size = New System.Drawing.Size(180, 36)
        Me.AddressInput.TabIndex = 42
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(24, 156)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(80, 28)
        Me.Guna2HtmlLabel3.TabIndex = 41
        Me.Guna2HtmlLabel3.Text = "Address"
        '
        'FirstNameInput
        '
        Me.FirstNameInput.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameInput.BorderRadius = 2
        Me.FirstNameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameInput.DefaultText = ""
        Me.FirstNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FirstNameInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameInput.ForeColor = System.Drawing.Color.Black
        Me.FirstNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.FirstNameInput.Location = New System.Drawing.Point(24, 113)
        Me.FirstNameInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstNameInput.Name = "FirstNameInput"
        Me.FirstNameInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameInput.PlaceholderText = ""
        Me.FirstNameInput.SelectedText = ""
        Me.FirstNameInput.Size = New System.Drawing.Size(180, 36)
        Me.FirstNameInput.TabIndex = 40
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 78)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(108, 28)
        Me.Guna2HtmlLabel1.TabIndex = 39
        Me.Guna2HtmlLabel1.Text = "First Name"
        '
        'StockInIcon
        '
        Me.StockInIcon.BackColor = System.Drawing.Color.Transparent
        Me.StockInIcon.FillColor = System.Drawing.Color.Transparent
        Me.StockInIcon.Image = Global.SteakAndButterPH.My.Resources.Resources.teamwork
        Me.StockInIcon.ImageRotate = 0!
        Me.StockInIcon.Location = New System.Drawing.Point(24, 24)
        Me.StockInIcon.Name = "StockInIcon"
        Me.StockInIcon.Size = New System.Drawing.Size(39, 38)
        Me.StockInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StockInIcon.TabIndex = 38
        Me.StockInIcon.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(69, 23)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(239, 41)
        Me.Guna2HtmlLabel2.TabIndex = 37
        Me.Guna2HtmlLabel2.Text = "ADD EMPLOYEE"
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
        Me.ExitBtn.TabIndex = 36
        '
        'LastNameInput
        '
        Me.LastNameInput.BackColor = System.Drawing.Color.Transparent
        Me.LastNameInput.BorderRadius = 2
        Me.LastNameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameInput.DefaultText = ""
        Me.LastNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.LastNameInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameInput.ForeColor = System.Drawing.Color.Black
        Me.LastNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.LastNameInput.Location = New System.Drawing.Point(242, 113)
        Me.LastNameInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastNameInput.Name = "LastNameInput"
        Me.LastNameInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameInput.PlaceholderText = ""
        Me.LastNameInput.SelectedText = ""
        Me.LastNameInput.Size = New System.Drawing.Size(180, 36)
        Me.LastNameInput.TabIndex = 50
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(242, 78)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(104, 28)
        Me.Guna2HtmlLabel6.TabIndex = 49
        Me.Guna2HtmlLabel6.Text = "Last Name"
        '
        'EmailInput
        '
        Me.EmailInput.BackColor = System.Drawing.Color.Transparent
        Me.EmailInput.BorderRadius = 2
        Me.EmailInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailInput.DefaultText = ""
        Me.EmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EmailInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailInput.ForeColor = System.Drawing.Color.Black
        Me.EmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.EmailInput.Location = New System.Drawing.Point(242, 191)
        Me.EmailInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailInput.Name = "EmailInput"
        Me.EmailInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailInput.PlaceholderText = ""
        Me.EmailInput.SelectedText = ""
        Me.EmailInput.Size = New System.Drawing.Size(180, 36)
        Me.EmailInput.TabIndex = 51
        '
        'PrivilegePick
        '
        Me.PrivilegePick.BackColor = System.Drawing.Color.Transparent
        Me.PrivilegePick.BorderRadius = 2
        Me.PrivilegePick.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PrivilegePick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrivilegePick.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrivilegePick.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrivilegePick.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PrivilegePick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PrivilegePick.ItemHeight = 30
        Me.PrivilegePick.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.PrivilegePick.Location = New System.Drawing.Point(24, 269)
        Me.PrivilegePick.Name = "PrivilegePick"
        Me.PrivilegePick.Size = New System.Drawing.Size(180, 36)
        Me.PrivilegePick.TabIndex = 52
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(24, 235)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(87, 28)
        Me.Guna2HtmlLabel7.TabIndex = 53
        Me.Guna2HtmlLabel7.Text = "Privilege"
        '
        'EPassInput
        '
        Me.EPassInput.BackColor = System.Drawing.Color.Transparent
        Me.EPassInput.BorderRadius = 2
        Me.EPassInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EPassInput.DefaultText = ""
        Me.EPassInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EPassInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EPassInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EPassInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EPassInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EPassInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EPassInput.ForeColor = System.Drawing.Color.Black
        Me.EPassInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.EPassInput.Location = New System.Drawing.Point(242, 351)
        Me.EPassInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EPassInput.MaxLength = 11
        Me.EPassInput.Name = "EPassInput"
        Me.EPassInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EPassInput.PlaceholderText = ""
        Me.EPassInput.SelectedText = ""
        Me.EPassInput.Size = New System.Drawing.Size(180, 36)
        Me.EPassInput.TabIndex = 57
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(242, 316)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(93, 28)
        Me.Guna2HtmlLabel8.TabIndex = 56
        Me.Guna2HtmlLabel8.Text = "Password"
        '
        'EUserInput
        '
        Me.EUserInput.BackColor = System.Drawing.Color.Transparent
        Me.EUserInput.BorderRadius = 2
        Me.EUserInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EUserInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EUserInput.DefaultText = ""
        Me.EUserInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EUserInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EUserInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EUserInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EUserInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EUserInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EUserInput.ForeColor = System.Drawing.Color.Black
        Me.EUserInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.EUserInput.Location = New System.Drawing.Point(24, 351)
        Me.EUserInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EUserInput.Name = "EUserInput"
        Me.EUserInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EUserInput.PlaceholderText = ""
        Me.EUserInput.SelectedText = ""
        Me.EUserInput.Size = New System.Drawing.Size(180, 36)
        Me.EUserInput.TabIndex = 55
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(24, 316)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(46, 28)
        Me.Guna2HtmlLabel9.TabIndex = 54
        Me.Guna2HtmlLabel9.Text = "User"
        '
        'AddEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SteakAndButterPH.My.Resources.Resources.SISOBG1
        Me.ClientSize = New System.Drawing.Size(450, 475)
        Me.Controls.Add(Me.EPassInput)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.EUserInput)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.PrivilegePick)
        Me.Controls.Add(Me.EmailInput)
        Me.Controls.Add(Me.LastNameInput)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ContactNumInput)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.AddressInput)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.FirstNameInput)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.StockInIcon)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmployeeForm"
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ContactNumInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AddressInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FirstNameInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents StockInIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EmailInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastNameInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PrivilegePick As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents EPassInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents EUserInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
