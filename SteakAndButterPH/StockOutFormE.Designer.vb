﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockOutFormE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockOutFormE))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.StockInIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.QuantityInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.WithdrawBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.StockOutInput = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'StockInIcon
        '
        Me.StockInIcon.BackColor = System.Drawing.Color.Transparent
        Me.StockInIcon.FillColor = System.Drawing.Color.Transparent
        Me.StockInIcon.Image = Global.SteakAndButterPH.My.Resources.Resources.upload
        Me.StockInIcon.ImageRotate = 0!
        Me.StockInIcon.Location = New System.Drawing.Point(24, 24)
        Me.StockInIcon.Name = "StockInIcon"
        Me.StockInIcon.Size = New System.Drawing.Size(39, 38)
        Me.StockInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StockInIcon.TabIndex = 7
        Me.StockInIcon.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(69, 20)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(211, 48)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "STOCK OUT"
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
        Me.ExitBtn.TabIndex = 5
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 93)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(141, 28)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "Product Name"
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
        Me.QuantityInput.Location = New System.Drawing.Point(305, 128)
        Me.QuantityInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuantityInput.Name = "QuantityInput"
        Me.QuantityInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityInput.PlaceholderText = ""
        Me.QuantityInput.SelectedText = ""
        Me.QuantityInput.Size = New System.Drawing.Size(110, 36)
        Me.QuantityInput.TabIndex = 14
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(305, 93)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(87, 28)
        Me.Guna2HtmlLabel5.TabIndex = 13
        Me.Guna2HtmlLabel5.Text = "Quantity"
        '
        'WithdrawBtn
        '
        Me.WithdrawBtn.Animated = True
        Me.WithdrawBtn.BackColor = System.Drawing.Color.Transparent
        Me.WithdrawBtn.BorderColor = System.Drawing.Color.Transparent
        Me.WithdrawBtn.BorderRadius = 2
        Me.WithdrawBtn.BorderThickness = 1
        Me.WithdrawBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.WithdrawBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.WithdrawBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.WithdrawBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.WithdrawBtn.FillColor = System.Drawing.Color.White
        Me.WithdrawBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithdrawBtn.ForeColor = System.Drawing.Color.Black
        Me.WithdrawBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.WithdrawBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.WithdrawBtn.Location = New System.Drawing.Point(286, 185)
        Me.WithdrawBtn.Name = "WithdrawBtn"
        Me.WithdrawBtn.Size = New System.Drawing.Size(129, 35)
        Me.WithdrawBtn.TabIndex = 21
        Me.WithdrawBtn.Text = "WITHDRAW"
        '
        'StockOutInput
        '
        Me.StockOutInput.BackColor = System.Drawing.Color.Transparent
        Me.StockOutInput.BorderRadius = 2
        Me.StockOutInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StockOutInput.DefaultText = ""
        Me.StockOutInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StockOutInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StockOutInput.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.StockOutInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.StockOutInput.Enabled = False
        Me.StockOutInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.StockOutInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StockOutInput.ForeColor = System.Drawing.Color.Black
        Me.StockOutInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.StockOutInput.Location = New System.Drawing.Point(24, 128)
        Me.StockOutInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockOutInput.Name = "StockOutInput"
        Me.StockOutInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StockOutInput.PlaceholderText = ""
        Me.StockOutInput.SelectedText = ""
        Me.StockOutInput.Size = New System.Drawing.Size(237, 36)
        Me.StockOutInput.TabIndex = 33
        '
        'StockOutFormE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SteakAndButterPH.My.Resources.Resources.SISOBG1
        Me.ClientSize = New System.Drawing.Size(450, 243)
        Me.Controls.Add(Me.StockOutInput)
        Me.Controls.Add(Me.WithdrawBtn)
        Me.Controls.Add(Me.QuantityInput)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.StockInIcon)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StockOutFormE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockOutFormE"
        CType(Me.StockInIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents StockInIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents QuantityInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents WithdrawBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StockOutInput As Guna.UI2.WinForms.Guna2TextBox
End Class
