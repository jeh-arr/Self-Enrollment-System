<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentGradesForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv1st1st = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSubjectlist = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1st1st, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubjectlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel1.Controls.Add(Me.ButtonBack)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, 0)
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
        Me.ButtonBack.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(1479, 11)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(115, 30)
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
        Me.Label1.Size = New System.Drawing.Size(361, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT GRADES"
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
        Me.Guna2PictureBox1.Image = Global.Self_Enrollment_System.My.Resources.Resources.gradeiconsmall
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
        Me.Guna2Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackgroundImage = Global.Self_Enrollment_System.My.Resources.Resources.gradebg
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Controls.Add(Me.MainPanel)
        Me.Guna2Panel2.Location = New System.Drawing.Point(1, 75)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1604, 807)
        Me.Guna2Panel2.TabIndex = 2
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPanel.ForeColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(160, 127)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1278, 605)
        Me.MainPanel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvSubjectlist)
        Me.GroupBox1.Controls.Add(Me.dgv1st1st)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(34, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 350)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FIRST YEAR:"
        '
        'dgv1st1st
        '
        Me.dgv1st1st.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv1st1st.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1st1st.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1st1st.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1st1st.ColumnHeadersHeight = 25
        Me.dgv1st1st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv1st1st.ColumnHeadersVisible = False
        Me.dgv1st1st.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1st1st.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv1st1st.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1st1st.Location = New System.Drawing.Point(29, 98)
        Me.dgv1st1st.Name = "dgv1st1st"
        Me.dgv1st1st.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1st1st.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv1st1st.RowHeadersVisible = False
        Me.dgv1st1st.RowTemplate.Height = 23
        Me.dgv1st1st.Size = New System.Drawing.Size(1067, 101)
        Me.dgv1st1st.TabIndex = 2
        Me.dgv1st1st.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv1st1st.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv1st1st.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv1st1st.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv1st1st.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv1st1st.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv1st1st.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1st1st.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1st1st.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv1st1st.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1st1st.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv1st1st.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv1st1st.ThemeStyle.HeaderStyle.Height = 25
        Me.dgv1st1st.ThemeStyle.ReadOnly = False
        Me.dgv1st1st.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv1st1st.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv1st1st.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1st1st.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgv1st1st.ThemeStyle.RowsStyle.Height = 23
        Me.dgv1st1st.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1st1st.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Grade"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Title"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Unit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FIRST SEMESTER: (26.0)"
        '
        'dgvSubjectlist
        '
        Me.dgvSubjectlist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSubjectlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubjectlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubjectlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubjectlist.ColumnHeadersHeight = 25
        Me.dgvSubjectlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubjectlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn12})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubjectlist.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubjectlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubjectlist.Location = New System.Drawing.Point(29, 98)
        Me.dgvSubjectlist.MultiSelect = False
        Me.dgvSubjectlist.Name = "dgvSubjectlist"
        Me.dgvSubjectlist.ReadOnly = True
        Me.dgvSubjectlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubjectlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSubjectlist.RowHeadersVisible = False
        Me.dgvSubjectlist.RowTemplate.Height = 23
        Me.dgvSubjectlist.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvSubjectlist.Size = New System.Drawing.Size(1004, 206)
        Me.dgvSubjectlist.TabIndex = 14
        Me.dgvSubjectlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubjectlist.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubjectlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvSubjectlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubjectlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSubjectlist.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubjectlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubjectlist.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvSubjectlist.ThemeStyle.ReadOnly = True
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.Height = 23
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubjectlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "GRADE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 93
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 82
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn13.HeaderText = "UNIT"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 76
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'StudentGradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 881)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentGradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StudentInfoForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1st1st, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubjectlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ButtonBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv1st1st As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents dgvSubjectlist As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
