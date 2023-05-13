<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBoxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxIdNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Guna2Panel1.Controls.Add(Me.ButtonLogin)
        Me.Guna2Panel1.Controls.Add(Me.TextBoxPassword)
        Me.Guna2Panel1.Controls.Add(Me.TextBoxIdNumber)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(1142, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(462, 881)
        Me.Guna2Panel1.TabIndex = 0
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLogin.Animated = True
        Me.ButtonLogin.AutoRoundedCorners = True
        Me.ButtonLogin.BorderRadius = 23
        Me.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(101, 593)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(261, 48)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.Text = "LOGIN"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPassword.AutoRoundedCorners = True
        Me.TextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxPassword.BorderRadius = 23
        Me.TextBoxPassword.BorderThickness = 2
        Me.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPassword.DefaultText = ""
        Me.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.Red
        Me.TextBoxPassword.Location = New System.Drawing.Point(101, 464)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxPassword.PlaceholderText = "Password"
        Me.TextBoxPassword.SelectedText = ""
        Me.TextBoxPassword.Size = New System.Drawing.Size(261, 48)
        Me.TextBoxPassword.TabIndex = 2
        '
        'TextBoxIdNumber
        '
        Me.TextBoxIdNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIdNumber.AutoRoundedCorners = True
        Me.TextBoxIdNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxIdNumber.BorderRadius = 23
        Me.TextBoxIdNumber.BorderThickness = 2
        Me.TextBoxIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxIdNumber.DefaultText = ""
        Me.TextBoxIdNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxIdNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxIdNumber.HoverState.BorderColor = System.Drawing.Color.Red
        Me.TextBoxIdNumber.Location = New System.Drawing.Point(101, 384)
        Me.TextBoxIdNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxIdNumber.Name = "TextBoxIdNumber"
        Me.TextBoxIdNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxIdNumber.PlaceholderText = "ID Nubmer"
        Me.TextBoxIdNumber.SelectedText = ""
        Me.TextBoxIdNumber.Size = New System.Drawing.Size(261, 48)
        Me.TextBoxIdNumber.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackgroundImage = Global.Self_Enrollment_System.My.Resources.Resources.umlogo
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 76)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(462, 258)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackgroundImage = Global.Self_Enrollment_System.My.Resources.Resources.bglogin
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1142, 881)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2MessageDialog1
        '
        Me.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.Guna2MessageDialog1.Caption = Nothing
        Me.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Guna2MessageDialog1.Parent = Nothing
        Me.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.Guna2MessageDialog1.Text = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(1105, 111)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNIVERSITY OF MINDANAO"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 881)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TextBoxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxIdNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Label1 As Label
End Class
