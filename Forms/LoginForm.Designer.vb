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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBoxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBoxIdNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.PanelBackGround = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.RadioButton5 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.RadioButton4 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.RadioButton3 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.RadioButton2 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.RadioButton1 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBackGround.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gold
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
        Me.ButtonLogin.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLogin.BorderColor = System.Drawing.Color.Gold
        Me.ButtonLogin.BorderRadius = 23
        Me.ButtonLogin.BorderThickness = 2
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
        Me.TextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxPassword.BorderRadius = 10
        Me.TextBoxPassword.BorderThickness = 2
        Me.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPassword.DefaultText = ""
        Me.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.Red
        Me.TextBoxPassword.Location = New System.Drawing.Point(101, 464)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.TextBoxIdNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxIdNumber.BorderRadius = 10
        Me.TextBoxIdNumber.BorderThickness = 2
        Me.TextBoxIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxIdNumber.DefaultText = ""
        Me.TextBoxIdNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxIdNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxIdNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxIdNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxIdNumber.HoverState.BorderColor = System.Drawing.Color.Red
        Me.TextBoxIdNumber.Location = New System.Drawing.Point(101, 384)
        Me.TextBoxIdNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxIdNumber.MaxLength = 6
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8000
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'PanelBackGround
        '
        Me.PanelBackGround.BackgroundImage = Global.Self_Enrollment_System.My.Resources.Resources.login_bg1
        Me.PanelBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBackGround.Controls.Add(Me.Guna2GroupBox1)
        Me.PanelBackGround.Controls.Add(Me.Label1)
        Me.PanelBackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackGround.Location = New System.Drawing.Point(0, 0)
        Me.PanelBackGround.Name = "PanelBackGround"
        Me.PanelBackGround.Size = New System.Drawing.Size(1142, 881)
        Me.PanelBackGround.TabIndex = 1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.RadioButton5)
        Me.Guna2GroupBox1.Controls.Add(Me.RadioButton4)
        Me.Guna2GroupBox1.Controls.Add(Me.RadioButton3)
        Me.Guna2GroupBox1.Controls.Add(Me.RadioButton2)
        Me.Guna2GroupBox1.Controls.Add(Me.RadioButton1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(450, 778)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(249, 66)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Guna2GroupBox1"
        '
        'RadioButton5
        '
        Me.RadioButton5.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.RadioButton5.CheckedState.BorderThickness = 0
        Me.RadioButton5.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.RadioButton5.CheckedState.InnerColor = System.Drawing.Color.Gold
        Me.RadioButton5.Location = New System.Drawing.Point(181, 23)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(20, 20)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Guna2CustomRadioButton5"
        Me.RadioButton5.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.RadioButton5.UncheckedState.BorderThickness = 0
        Me.RadioButton5.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RadioButton5.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'RadioButton4
        '
        Me.RadioButton4.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.RadioButton4.CheckedState.BorderThickness = 0
        Me.RadioButton4.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.RadioButton4.CheckedState.InnerColor = System.Drawing.Color.Gold
        Me.RadioButton4.Location = New System.Drawing.Point(147, 23)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(20, 20)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Guna2CustomRadioButton4"
        Me.RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.RadioButton4.UncheckedState.BorderThickness = 0
        Me.RadioButton4.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'RadioButton3
        '
        Me.RadioButton3.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.RadioButton3.CheckedState.BorderThickness = 0
        Me.RadioButton3.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.RadioButton3.CheckedState.InnerColor = System.Drawing.Color.Gold
        Me.RadioButton3.Location = New System.Drawing.Point(113, 23)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(20, 20)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Guna2CustomRadioButton3"
        Me.RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.RadioButton3.UncheckedState.BorderThickness = 0
        Me.RadioButton3.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'RadioButton2
        '
        Me.RadioButton2.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.RadioButton2.CheckedState.BorderThickness = 0
        Me.RadioButton2.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.RadioButton2.CheckedState.InnerColor = System.Drawing.Color.Gold
        Me.RadioButton2.Location = New System.Drawing.Point(79, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(20, 20)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Guna2CustomRadioButton2"
        Me.RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.RadioButton2.UncheckedState.BorderThickness = 0
        Me.RadioButton2.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.RadioButton1.CheckedState.BorderThickness = 0
        Me.RadioButton1.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.RadioButton1.CheckedState.InnerColor = System.Drawing.Color.Gold
        Me.RadioButton1.Location = New System.Drawing.Point(45, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(20, 20)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Guna2CustomRadioButton1"
        Me.RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.RadioButton1.UncheckedState.BorderThickness = 0
        Me.RadioButton1.UncheckedState.FillColor = System.Drawing.Color.White
        Me.RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.White
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
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBackGround)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBackGround.ResumeLayout(False)
        Me.PanelBackGround.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelBackGround As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TextBoxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBoxIdNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents RadioButton1 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents RadioButton5 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents RadioButton4 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents RadioButton3 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents RadioButton2 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label1 As Label
End Class
