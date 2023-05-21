<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfoForm
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
        Me.ButtonBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxEaddress = New System.Windows.Forms.TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxEcontact = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.TextBoxErelation = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxEname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxBranch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxYear = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCollege = New System.Windows.Forms.TextBox()
        Me.TextBoxProgram = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBirth = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxSex = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextMname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel1.Controls.Add(Me.ButtonBack)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1607, 75)
        Me.Guna2Panel1.TabIndex = 0
        '
        'ButtonBack
        '
        Me.ButtonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonBack.FillColor = System.Drawing.Color.Maroon
        Me.ButtonBack.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(1479, 11)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(115, 29)
        Me.ButtonBack.TabIndex = 1
        Me.ButtonBack.Text = "BACK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT INFORMATION"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 45
        Me.Guna2PictureBox1.Image = Global.Self_Enrollment_System.My.Resources.Resources.infoiconsmall
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(157, 151)
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackgroundImage = Global.Self_Enrollment_System.My.Resources.Resources.studentinfobg
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Controls.Add(Me.MainPanel)
        Me.Guna2Panel2.Location = New System.Drawing.Point(1, 72)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1604, 810)
        Me.Guna2Panel2.TabIndex = 2
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainPanel.Controls.Add(Me.GroupBox3)
        Me.MainPanel.Controls.Add(Me.GroupBox2)
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPanel.ForeColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(160, 129)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1292, 625)
        Me.MainPanel.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ButtonEdit)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TextBoxEaddress)
        Me.GroupBox3.Controls.Add(Me.Guna2Separator1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBoxAddress)
        Me.GroupBox3.Controls.Add(Me.TextBoxEcontact)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBoxPhone)
        Me.GroupBox3.Controls.Add(Me.TextBoxErelation)
        Me.GroupBox3.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox3.Controls.Add(Me.TextBoxEname)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ButtonConfirm)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(666, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 571)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Details"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonEdit.FillColor = System.Drawing.Color.Maroon
        Me.ButtonEdit.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(411, 500)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(128, 45)
        Me.ButtonEdit.TabIndex = 21
        Me.ButtonEdit.Text = "Edit"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(244, 33)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Emergency Contact"
        '
        'TextBoxEaddress
        '
        Me.TextBoxEaddress.Enabled = False
        Me.TextBoxEaddress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEaddress.Location = New System.Drawing.Point(241, 414)
        Me.TextBoxEaddress.Multiline = True
        Me.TextBoxEaddress.Name = "TextBoxEaddress"
        Me.TextBoxEaddress.Size = New System.Drawing.Size(298, 75)
        Me.TextBoxEaddress.TabIndex = 19
        Me.TextBoxEaddress.Text = "asdasdas asdasdas asdas asdas a dasda"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.White
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(6, 211)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(575, 24)
        Me.Guna2Separator1.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 414)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 29)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Address"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Enabled = False
        Me.TextBoxAddress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(241, 127)
        Me.TextBoxAddress.Multiline = True
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(298, 75)
        Me.TextBoxAddress.TabIndex = 11
        '
        'TextBoxEcontact
        '
        Me.TextBoxEcontact.Enabled = False
        Me.TextBoxEcontact.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEcontact.Location = New System.Drawing.Point(241, 372)
        Me.TextBoxEcontact.MaxLength = 11
        Me.TextBoxEcontact.Name = "TextBoxEcontact"
        Me.TextBoxEcontact.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxEcontact.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 29)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Phone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 29)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 29)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Relationship"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 29)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Contact number"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Enabled = False
        Me.TextBoxPhone.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhone.Location = New System.Drawing.Point(241, 44)
        Me.TextBoxPhone.MaxLength = 11
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxPhone.TabIndex = 7
        '
        'TextBoxErelation
        '
        Me.TextBoxErelation.Enabled = False
        Me.TextBoxErelation.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxErelation.Location = New System.Drawing.Point(241, 330)
        Me.TextBoxErelation.Name = "TextBoxErelation"
        Me.TextBoxErelation.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxErelation.TabIndex = 15
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Enabled = False
        Me.TextBoxEmail.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(241, 90)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(298, 27)
        Me.TextBoxEmail.TabIndex = 9
        '
        'TextBoxEname
        '
        Me.TextBoxEname.Enabled = False
        Me.TextBoxEname.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEname.Location = New System.Drawing.Point(241, 288)
        Me.TextBoxEname.Name = "TextBoxEname"
        Me.TextBoxEname.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxEname.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 29)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Email"
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonConfirm.FillColor = System.Drawing.Color.Maroon
        Me.ButtonConfirm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirm.ForeColor = System.Drawing.Color.White
        Me.ButtonConfirm.Location = New System.Drawing.Point(411, 500)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(128, 45)
        Me.ButtonConfirm.TabIndex = 22
        Me.ButtonConfirm.Text = "Confirm"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBoxID)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBoxBranch)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxYear)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxCollege)
        Me.GroupBox2.Controls.Add(Me.TextBoxProgram)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(34, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 279)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Course Information"
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(241, 50)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxID.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(34, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 29)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Id Number"
        '
        'TextBoxBranch
        '
        Me.TextBoxBranch.Enabled = False
        Me.TextBoxBranch.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBranch.Location = New System.Drawing.Point(241, 218)
        Me.TextBoxBranch.Name = "TextBoxBranch"
        Me.TextBoxBranch.ReadOnly = True
        Me.TextBoxBranch.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxBranch.TabIndex = 13
        Me.TextBoxBranch.Text = "Main"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Branch"
        '
        'TextBoxYear
        '
        Me.TextBoxYear.Enabled = False
        Me.TextBoxYear.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxYear.Location = New System.Drawing.Point(241, 176)
        Me.TextBoxYear.Name = "TextBoxYear"
        Me.TextBoxYear.ReadOnly = True
        Me.TextBoxYear.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxYear.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "College"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Year Level"
        '
        'TextBoxCollege
        '
        Me.TextBoxCollege.Enabled = False
        Me.TextBoxCollege.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCollege.Location = New System.Drawing.Point(241, 92)
        Me.TextBoxCollege.Name = "TextBoxCollege"
        Me.TextBoxCollege.ReadOnly = True
        Me.TextBoxCollege.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxCollege.TabIndex = 7
        '
        'TextBoxProgram
        '
        Me.TextBoxProgram.Enabled = False
        Me.TextBoxProgram.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProgram.Location = New System.Drawing.Point(241, 134)
        Me.TextBoxProgram.Name = "TextBoxProgram"
        Me.TextBoxProgram.ReadOnly = True
        Me.TextBoxProgram.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxProgram.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Program"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBoxBirth)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBoxSex)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBoxLname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextMname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxFname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(34, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'TextBoxBirth
        '
        Me.TextBoxBirth.Enabled = False
        Me.TextBoxBirth.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBirth.Location = New System.Drawing.Point(241, 211)
        Me.TextBoxBirth.Name = "TextBoxBirth"
        Me.TextBoxBirth.ReadOnly = True
        Me.TextBoxBirth.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxBirth.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(34, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 29)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Birth Date"
        '
        'TextBoxSex
        '
        Me.TextBoxSex.Enabled = False
        Me.TextBoxSex.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSex.Location = New System.Drawing.Point(241, 169)
        Me.TextBoxSex.Name = "TextBoxSex"
        Me.TextBoxSex.ReadOnly = True
        Me.TextBoxSex.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxSex.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 29)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Sex"
        '
        'TextBoxLname
        '
        Me.TextBoxLname.Enabled = False
        Me.TextBoxLname.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLname.Location = New System.Drawing.Point(241, 127)
        Me.TextBoxLname.Name = "TextBoxLname"
        Me.TextBoxLname.ReadOnly = True
        Me.TextBoxLname.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxLname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name "
        '
        'TextMname
        '
        Me.TextMname.Enabled = False
        Me.TextMname.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMname.Location = New System.Drawing.Point(241, 85)
        Me.TextMname.Name = "TextMname"
        Me.TextMname.ReadOnly = True
        Me.TextMname.Size = New System.Drawing.Size(298, 36)
        Me.TextMname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name "
        '
        'TextBoxFname
        '
        Me.TextBoxFname.Enabled = False
        Me.TextBoxFname.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFname.Location = New System.Drawing.Point(241, 43)
        Me.TextBoxFname.Name = "TextBoxFname"
        Me.TextBoxFname.ReadOnly = True
        Me.TextBoxFname.Size = New System.Drawing.Size(298, 36)
        Me.TextBoxFname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'StudentInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 881)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StudentInfoForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextMname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxFname As TextBox
    Friend WithEvents TextBoxEcontact As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxErelation As TextBox
    Friend WithEvents TextBoxEname As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxBranch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxYear As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCollege As TextBox
    Friend WithEvents TextBoxProgram As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxEaddress As TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxSex As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxBirth As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ButtonEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
