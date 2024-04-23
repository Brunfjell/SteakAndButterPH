<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.StockInIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AcctCnfrmPnl1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CurrentPasswordInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AccessIDInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AcctCnfrmPnl2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CancelPBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NewPasswordInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ConfirmPasswordInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UpdatePBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcctCnfrmPnl1.SuspendLayout()
        Me.AcctCnfrmPnl2.SuspendLayout()
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
        Me.AddBtn.Location = New System.Drawing.Point(294, 136)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(109, 35)
        Me.AddBtn.TabIndex = 49
        Me.AddBtn.Text = "PROCEED"
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
        Me.ExitBtn.Location = New System.Drawing.Point(382, 0)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(52, 24)
        Me.ExitBtn.TabIndex = 48
        '
        'StockInIcon
        '
        Me.StockInIcon.BackColor = System.Drawing.Color.Transparent
        Me.StockInIcon.FillColor = System.Drawing.Color.Transparent
        Me.StockInIcon.Image = Global.SteakAndButterPH.My.Resources.Resources.key
        Me.StockInIcon.ImageRotate = 0!
        Me.StockInIcon.Location = New System.Drawing.Point(16, 13)
        Me.StockInIcon.Name = "StockInIcon"
        Me.StockInIcon.Size = New System.Drawing.Size(39, 38)
        Me.StockInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StockInIcon.TabIndex = 51
        Me.StockInIcon.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(61, 18)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(260, 33)
        Me.Guna2HtmlLabel2.TabIndex = 50
        Me.Guna2HtmlLabel2.Text = "CHANGE PASSWORD"
        '
        'AcctCnfrmPnl1
        '
        Me.AcctCnfrmPnl1.BackColor = System.Drawing.Color.Transparent
        Me.AcctCnfrmPnl1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.AcctCnfrmPnl1.Controls.Add(Me.CurrentPasswordInput)
        Me.AcctCnfrmPnl1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.AcctCnfrmPnl1.Controls.Add(Me.AccessIDInput)
        Me.AcctCnfrmPnl1.Controls.Add(Me.AddBtn)
        Me.AcctCnfrmPnl1.Location = New System.Drawing.Point(16, 71)
        Me.AcctCnfrmPnl1.Name = "AcctCnfrmPnl1"
        Me.AcctCnfrmPnl1.Size = New System.Drawing.Size(406, 174)
        Me.AcctCnfrmPnl1.TabIndex = 52
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(176, 24)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(183, 24)
        Me.Guna2HtmlLabel3.TabIndex = 55
        Me.Guna2HtmlLabel3.Text = "CURRENT PASSWORD"
        '
        'CurrentPasswordInput
        '
        Me.CurrentPasswordInput.BorderRadius = 2
        Me.CurrentPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CurrentPasswordInput.DefaultText = ""
        Me.CurrentPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CurrentPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CurrentPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CurrentPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CurrentPasswordInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordInput.ForeColor = System.Drawing.Color.Black
        Me.CurrentPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.CurrentPasswordInput.Location = New System.Drawing.Point(176, 55)
        Me.CurrentPasswordInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrentPasswordInput.Name = "CurrentPasswordInput"
        Me.CurrentPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CurrentPasswordInput.PlaceholderText = ""
        Me.CurrentPasswordInput.SelectedText = ""
        Me.CurrentPasswordInput.Size = New System.Drawing.Size(205, 46)
        Me.CurrentPasswordInput.TabIndex = 54
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(22, 24)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(89, 24)
        Me.Guna2HtmlLabel1.TabIndex = 53
        Me.Guna2HtmlLabel1.Text = "ACCESS ID"
        '
        'AccessIDInput
        '
        Me.AccessIDInput.BorderRadius = 2
        Me.AccessIDInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccessIDInput.DefaultText = ""
        Me.AccessIDInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AccessIDInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AccessIDInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccessIDInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccessIDInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccessIDInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessIDInput.ForeColor = System.Drawing.Color.Black
        Me.AccessIDInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.AccessIDInput.Location = New System.Drawing.Point(22, 55)
        Me.AccessIDInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccessIDInput.Name = "AccessIDInput"
        Me.AccessIDInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccessIDInput.PlaceholderText = ""
        Me.AccessIDInput.SelectedText = ""
        Me.AccessIDInput.Size = New System.Drawing.Size(129, 46)
        Me.AccessIDInput.TabIndex = 50
        '
        'AcctCnfrmPnl2
        '
        Me.AcctCnfrmPnl2.BackColor = System.Drawing.Color.Transparent
        Me.AcctCnfrmPnl2.Controls.Add(Me.CancelPBtn)
        Me.AcctCnfrmPnl2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.AcctCnfrmPnl2.Controls.Add(Me.NewPasswordInput)
        Me.AcctCnfrmPnl2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.AcctCnfrmPnl2.Controls.Add(Me.ConfirmPasswordInput)
        Me.AcctCnfrmPnl2.Controls.Add(Me.UpdatePBtn)
        Me.AcctCnfrmPnl2.Location = New System.Drawing.Point(42, 253)
        Me.AcctCnfrmPnl2.Name = "AcctCnfrmPnl2"
        Me.AcctCnfrmPnl2.Size = New System.Drawing.Size(20, 20)
        Me.AcctCnfrmPnl2.TabIndex = 56
        Me.AcctCnfrmPnl2.Visible = False
        '
        'CancelPBtn
        '
        Me.CancelPBtn.Animated = True
        Me.CancelPBtn.BackColor = System.Drawing.Color.Transparent
        Me.CancelPBtn.BorderColor = System.Drawing.Color.Transparent
        Me.CancelPBtn.BorderRadius = 2
        Me.CancelPBtn.BorderThickness = 1
        Me.CancelPBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CancelPBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CancelPBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CancelPBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CancelPBtn.FillColor = System.Drawing.Color.Transparent
        Me.CancelPBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPBtn.ForeColor = System.Drawing.Color.White
        Me.CancelPBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.CancelPBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.CancelPBtn.Location = New System.Drawing.Point(307, 143)
        Me.CancelPBtn.Name = "CancelPBtn"
        Me.CancelPBtn.Size = New System.Drawing.Size(83, 27)
        Me.CancelPBtn.TabIndex = 58
        Me.CancelPBtn.Text = "CANCEL"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(12, 3)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(145, 24)
        Me.Guna2HtmlLabel5.TabIndex = 57
        Me.Guna2HtmlLabel5.Text = "NEW PASSWORD"
        '
        'NewPasswordInput
        '
        Me.NewPasswordInput.BorderRadius = 2
        Me.NewPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewPasswordInput.DefaultText = ""
        Me.NewPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NewPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NewPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewPasswordInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordInput.ForeColor = System.Drawing.Color.Black
        Me.NewPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.NewPasswordInput.Location = New System.Drawing.Point(12, 32)
        Me.NewPasswordInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NewPasswordInput.MaxLength = 11
        Me.NewPasswordInput.Name = "NewPasswordInput"
        Me.NewPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewPasswordInput.PlaceholderText = ""
        Me.NewPasswordInput.SelectedText = ""
        Me.NewPasswordInput.Size = New System.Drawing.Size(212, 46)
        Me.NewPasswordInput.TabIndex = 56
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 93)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(212, 24)
        Me.Guna2HtmlLabel4.TabIndex = 55
        Me.Guna2HtmlLabel4.Text = "REPEAT NEW PASSWORD"
        '
        'ConfirmPasswordInput
        '
        Me.ConfirmPasswordInput.BorderRadius = 2
        Me.ConfirmPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPasswordInput.DefaultText = ""
        Me.ConfirmPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordInput.ForeColor = System.Drawing.Color.Black
        Me.ConfirmPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ConfirmPasswordInput.Location = New System.Drawing.Point(12, 124)
        Me.ConfirmPasswordInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ConfirmPasswordInput.MaxLength = 11
        Me.ConfirmPasswordInput.Name = "ConfirmPasswordInput"
        Me.ConfirmPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmPasswordInput.PlaceholderText = ""
        Me.ConfirmPasswordInput.SelectedText = ""
        Me.ConfirmPasswordInput.Size = New System.Drawing.Size(212, 46)
        Me.ConfirmPasswordInput.TabIndex = 54
        '
        'UpdatePBtn
        '
        Me.UpdatePBtn.Animated = True
        Me.UpdatePBtn.BackColor = System.Drawing.Color.Transparent
        Me.UpdatePBtn.BorderColor = System.Drawing.Color.Transparent
        Me.UpdatePBtn.BorderRadius = 2
        Me.UpdatePBtn.BorderThickness = 1
        Me.UpdatePBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdatePBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdatePBtn.FillColor = System.Drawing.Color.White
        Me.UpdatePBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatePBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdatePBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.UpdatePBtn.Location = New System.Drawing.Point(294, 101)
        Me.UpdatePBtn.Name = "UpdatePBtn"
        Me.UpdatePBtn.Size = New System.Drawing.Size(109, 35)
        Me.UpdatePBtn.TabIndex = 49
        Me.UpdatePBtn.Text = "UPDATE"
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SteakAndButterPH.My.Resources.Resources.SISOBG1
        Me.ClientSize = New System.Drawing.Size(434, 274)
        Me.Controls.Add(Me.AcctCnfrmPnl2)
        Me.Controls.Add(Me.AcctCnfrmPnl1)
        Me.Controls.Add(Me.StockInIcon)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePasswordForm"
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcctCnfrmPnl1.ResumeLayout(False)
        Me.AcctCnfrmPnl1.PerformLayout()
        Me.AcctCnfrmPnl2.ResumeLayout(False)
        Me.AcctCnfrmPnl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StockInIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AcctCnfrmPnl1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AccessIDInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CurrentPasswordInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AcctCnfrmPnl2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ConfirmPasswordInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UpdatePBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NewPasswordInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CancelPBtn As Guna.UI2.WinForms.Guna2Button
End Class
