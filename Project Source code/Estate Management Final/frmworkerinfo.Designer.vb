<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmworkerinfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnworkinvest = New System.Windows.Forms.Button
        Me.btnwrkassign = New System.Windows.Forms.Button
        Me.btnworkinfo = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgvworkers = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.photo = New System.Windows.Forms.Label
        Me.txtdocument = New System.Windows.Forms.TextBox
        Me.cmbcategory = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnupload = New System.Windows.Forms.Button
        Me.wrkerpic = New System.Windows.Forms.PictureBox
        Me.dtpdoj = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtbeneficials = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtbal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdbfemale = New System.Windows.Forms.RadioButton
        Me.rdbmale = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnupdate = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvworkers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wrkerpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnprint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnworkinvest)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnwrkassign)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnworkinfo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 546)
        Me.SplitContainer1.SplitterDistance = 161
        Me.SplitContainer1.TabIndex = 0
        '
        'btnworkinvest
        '
        Me.btnworkinvest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkinvest.Location = New System.Drawing.Point(11, 133)
        Me.btnworkinvest.Name = "btnworkinvest"
        Me.btnworkinvest.Size = New System.Drawing.Size(137, 50)
        Me.btnworkinvest.TabIndex = 7
        Me.btnworkinvest.Text = "Work Investments"
        Me.btnworkinvest.UseVisualStyleBackColor = True
        '
        'btnwrkassign
        '
        Me.btnwrkassign.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwrkassign.Location = New System.Drawing.Point(11, 77)
        Me.btnwrkassign.Name = "btnwrkassign"
        Me.btnwrkassign.Size = New System.Drawing.Size(137, 50)
        Me.btnwrkassign.TabIndex = 6
        Me.btnwrkassign.Text = "Work Assignments"
        Me.btnwrkassign.UseVisualStyleBackColor = True
        '
        'btnworkinfo
        '
        Me.btnworkinfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkinfo.Location = New System.Drawing.Point(11, 21)
        Me.btnworkinfo.Name = "btnworkinfo"
        Me.btnworkinfo.Size = New System.Drawing.Size(137, 50)
        Me.btnworkinfo.TabIndex = 5
        Me.btnworkinfo.Text = "Workers Information"
        Me.btnworkinfo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtcontact)
        Me.Panel2.Controls.Add(Me.txtlname)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.dgvworkers)
        Me.Panel2.Controls.Add(Me.photo)
        Me.Panel2.Controls.Add(Me.txtdocument)
        Me.Panel2.Controls.Add(Me.cmbcategory)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnupload)
        Me.Panel2.Controls.Add(Me.wrkerpic)
        Me.Panel2.Controls.Add(Me.dtpdoj)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtbeneficials)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtbal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.rdbfemale)
        Me.Panel2.Controls.Add(Me.rdbmale)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtage)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 558)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btndel)
        Me.Panel1.Location = New System.Drawing.Point(435, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 143)
        Me.Panel1.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(147, 51)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(111, 35)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "add new"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(11, 473)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(137, 50)
        Me.btnprint.TabIndex = 5
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(147, 97)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(111, 35)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(3, 98)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(111, 34)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(3, 51)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(111, 35)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(3, 3)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(111, 35)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Contact"
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(70, 151)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(138, 22)
        Me.txtcontact.TabIndex = 27
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(70, 35)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(151, 22)
        Me.txtlname.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Last Name"
        '
        'dgvworkers
        '
        Me.dgvworkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvworkers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvworkers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvworkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvworkers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvworkers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvworkers.Location = New System.Drawing.Point(435, 11)
        Me.dgvworkers.Name = "dgvworkers"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvworkers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvworkers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvworkers.Size = New System.Drawing.Size(281, 313)
        Me.dgvworkers.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "SL.NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "AGE"
        Me.Column3.Name = "Column3"
        '
        'photo
        '
        Me.photo.AutoSize = True
        Me.photo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photo.Location = New System.Drawing.Point(271, 12)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(39, 15)
        Me.photo.TabIndex = 23
        Me.photo.Text = "Photo"
        '
        'txtdocument
        '
        Me.txtdocument.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocument.Location = New System.Drawing.Point(314, 182)
        Me.txtdocument.Multiline = True
        Me.txtdocument.Name = "txtdocument"
        Me.txtdocument.Size = New System.Drawing.Size(115, 107)
        Me.txtdocument.TabIndex = 22
        '
        'cmbcategory
        '
        Me.cmbcategory.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Permanent", "Temporary"})
        Me.cmbcategory.Location = New System.Drawing.Point(70, 174)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(138, 23)
        Me.cmbcategory.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Documental Proof"
        '
        'btnupload
        '
        Me.btnupload.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupload.Location = New System.Drawing.Point(310, 130)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(115, 23)
        Me.btnupload.TabIndex = 17
        Me.btnupload.Text = "Upload"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'wrkerpic
        '
        Me.wrkerpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wrkerpic.Location = New System.Drawing.Point(310, 11)
        Me.wrkerpic.Name = "wrkerpic"
        Me.wrkerpic.Size = New System.Drawing.Size(115, 115)
        Me.wrkerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wrkerpic.TabIndex = 16
        Me.wrkerpic.TabStop = False
        '
        'dtpdoj
        '
        Me.dtpdoj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdoj.Location = New System.Drawing.Point(314, 156)
        Me.dtpdoj.Name = "dtpdoj"
        Me.dtpdoj.Size = New System.Drawing.Size(86, 20)
        Me.dtpdoj.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(221, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date Of Joining"
        '
        'txtbeneficials
        '
        Me.txtbeneficials.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeneficials.Location = New System.Drawing.Point(70, 224)
        Me.txtbeneficials.Multiline = True
        Me.txtbeneficials.Name = "txtbeneficials"
        Me.txtbeneficials.Size = New System.Drawing.Size(138, 65)
        Me.txtbeneficials.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Beneficials"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 188)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Work Analysis"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'txtbal
        '
        Me.txtbal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbal.Location = New System.Drawing.Point(70, 200)
        Me.txtbal.Name = "txtbal"
        Me.txtbal.Size = New System.Drawing.Size(138, 22)
        Me.txtbal.TabIndex = 10
        Me.txtbal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Balance"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(70, 89)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(138, 59)
        Me.txtaddress.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Address"
        '
        'rdbfemale
        '
        Me.rdbfemale.AutoSize = True
        Me.rdbfemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbfemale.Location = New System.Drawing.Point(124, 62)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(62, 19)
        Me.rdbfemale.TabIndex = 6
        Me.rdbfemale.TabStop = True
        Me.rdbfemale.Text = "Female"
        Me.rdbfemale.UseVisualStyleBackColor = True
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbmale.Location = New System.Drawing.Point(70, 62)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(52, 19)
        Me.rdbmale.TabIndex = 5
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(219, 63)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(28, 22)
        Me.txtage.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(70, 11)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(151, 22)
        Me.txtname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(147, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(111, 35)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'frmworkerinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmworkerinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmworkerinfo"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvworkers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wrkerpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvworkers As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents photo As System.Windows.Forms.Label
    Friend WithEvents txtdocument As System.Windows.Forms.TextBox
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents wrkerpic As System.Windows.Forms.PictureBox
    Friend WithEvents dtpdoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbeneficials As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnworkinvest As System.Windows.Forms.Button
    Friend WithEvents btnwrkassign As System.Windows.Forms.Button
    Friend WithEvents btnworkinfo As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
