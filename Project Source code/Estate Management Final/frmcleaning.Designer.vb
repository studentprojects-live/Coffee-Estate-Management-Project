<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcleaning
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnclean = New System.Windows.Forms.Button
        Me.btnmanure = New System.Windows.Forms.Button
        Me.btnirrigation = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnmadd = New System.Windows.Forms.Button
        Me.dgvclean = New System.Windows.Forms.DataGridView
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnmprint = New System.Windows.Forms.Button
        Me.btnmdelete = New System.Windows.Forms.Button
        Me.btnmclear = New System.Windows.Forms.Button
        Me.btnmcancel = New System.Windows.Forms.Button
        Me.btnmupdate = New System.Windows.Forms.Button
        Me.btnmsave = New System.Windows.Forms.Button
        Me.txtnoworkers = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvgeneral = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvtools = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvctrees = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtpkg = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtpp = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtnp = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbincharge = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcleaning = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtsetno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btndelete = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvclean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvgeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvctrees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnclean)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmanure)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnirrigation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 546)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 0
        '
        'btnclean
        '
        Me.btnclean.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclean.Location = New System.Drawing.Point(11, 128)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(137, 50)
        Me.btnclean.TabIndex = 8
        Me.btnclean.Text = "Cleaning"
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'btnmanure
        '
        Me.btnmanure.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanure.Location = New System.Drawing.Point(12, 70)
        Me.btnmanure.Name = "btnmanure"
        Me.btnmanure.Size = New System.Drawing.Size(137, 50)
        Me.btnmanure.TabIndex = 7
        Me.btnmanure.Text = "Mannure"
        Me.btnmanure.UseVisualStyleBackColor = True
        '
        'btnirrigation
        '
        Me.btnirrigation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnirrigation.Location = New System.Drawing.Point(12, 12)
        Me.btnirrigation.Name = "btnirrigation"
        Me.btnirrigation.Size = New System.Drawing.Size(137, 50)
        Me.btnirrigation.TabIndex = 6
        Me.btnirrigation.Text = "Irrigation"
        Me.btnirrigation.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmadd)
        Me.Panel1.Controls.Add(Me.dgvclean)
        Me.Panel1.Controls.Add(Me.btnmprint)
        Me.Panel1.Controls.Add(Me.btnmdelete)
        Me.Panel1.Controls.Add(Me.btnmclear)
        Me.Panel1.Controls.Add(Me.btnmcancel)
        Me.Panel1.Controls.Add(Me.btnmupdate)
        Me.Panel1.Controls.Add(Me.btnmsave)
        Me.Panel1.Controls.Add(Me.txtnoworkers)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.dgvtools)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dtpto)
        Me.Panel1.Controls.Add(Me.dtpfrom)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbincharge)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbcleaning)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtsetno)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 546)
        Me.Panel1.TabIndex = 7
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(12, 463)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(137, 50)
        Me.btnprint.TabIndex = 9
        Me.btnprint.Text = "Print Report"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnmadd
        '
        Me.btnmadd.Location = New System.Drawing.Point(433, 463)
        Me.btnmadd.Name = "btnmadd"
        Me.btnmadd.Size = New System.Drawing.Size(105, 37)
        Me.btnmadd.TabIndex = 64
        Me.btnmadd.Text = "add new"
        Me.btnmadd.UseVisualStyleBackColor = True
        '
        'dgvclean
        '
        Me.dgvclean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclean.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvclean.Location = New System.Drawing.Point(301, 28)
        Me.dgvclean.Name = "dgvclean"
        Me.dgvclean.Size = New System.Drawing.Size(375, 205)
        Me.dgvclean.TabIndex = 63
        '
        'Column6
        '
        Me.Column6.HeaderText = "SetNo"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Incharge"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "CleaningType"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Startdate"
        Me.Column9.Name = "Column9"
        '
        'btnmprint
        '
        Me.btnmprint.Location = New System.Drawing.Point(317, 544)
        Me.btnmprint.Name = "btnmprint"
        Me.btnmprint.Size = New System.Drawing.Size(127, 26)
        Me.btnmprint.TabIndex = 62
        Me.btnmprint.Text = "print"
        Me.btnmprint.UseVisualStyleBackColor = True
        '
        'btnmdelete
        '
        Me.btnmdelete.Location = New System.Drawing.Point(450, 543)
        Me.btnmdelete.Name = "btnmdelete"
        Me.btnmdelete.Size = New System.Drawing.Size(128, 29)
        Me.btnmdelete.TabIndex = 61
        Me.btnmdelete.Text = "delete"
        Me.btnmdelete.UseVisualStyleBackColor = True
        '
        'btnmclear
        '
        Me.btnmclear.Location = New System.Drawing.Point(299, 421)
        Me.btnmclear.Name = "btnmclear"
        Me.btnmclear.Size = New System.Drawing.Size(128, 37)
        Me.btnmclear.TabIndex = 60
        Me.btnmclear.Text = "clear"
        Me.btnmclear.UseVisualStyleBackColor = True
        '
        'btnmcancel
        '
        Me.btnmcancel.Location = New System.Drawing.Point(549, 463)
        Me.btnmcancel.Name = "btnmcancel"
        Me.btnmcancel.Size = New System.Drawing.Size(128, 37)
        Me.btnmcancel.TabIndex = 59
        Me.btnmcancel.Text = "cancel"
        Me.btnmcancel.UseVisualStyleBackColor = True
        '
        'btnmupdate
        '
        Me.btnmupdate.Location = New System.Drawing.Point(548, 420)
        Me.btnmupdate.Name = "btnmupdate"
        Me.btnmupdate.Size = New System.Drawing.Size(128, 37)
        Me.btnmupdate.TabIndex = 58
        Me.btnmupdate.Text = "update"
        Me.btnmupdate.UseVisualStyleBackColor = True
        '
        'btnmsave
        '
        Me.btnmsave.Location = New System.Drawing.Point(299, 463)
        Me.btnmsave.Name = "btnmsave"
        Me.btnmsave.Size = New System.Drawing.Size(128, 37)
        Me.btnmsave.TabIndex = 57
        Me.btnmsave.Text = "save"
        Me.btnmsave.UseVisualStyleBackColor = True
        '
        'txtnoworkers
        '
        Me.txtnoworkers.Location = New System.Drawing.Point(111, 114)
        Me.txtnoworkers.Name = "txtnoworkers"
        Me.txtnoworkers.Size = New System.Drawing.Size(122, 20)
        Me.txtnoworkers.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "no of workers"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvgeneral)
        Me.GroupBox3.Location = New System.Drawing.Point(301, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 143)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "general cleaning"
        '
        'dgvgeneral
        '
        Me.dgvgeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvgeneral.Location = New System.Drawing.Point(6, 37)
        Me.dgvgeneral.Name = "dgvgeneral"
        Me.dgvgeneral.Size = New System.Drawing.Size(363, 90)
        Me.dgvgeneral.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "cleaning type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "pay/day"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'dgvtools
        '
        Me.dgvtools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvtools.Location = New System.Drawing.Point(8, 371)
        Me.dgvtools.Name = "dgvtools"
        Me.dgvtools.Size = New System.Drawing.Size(281, 131)
        Me.dgvtools.TabIndex = 12
        '
        'Column4
        '
        Me.Column4.HeaderText = "tool type"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "no of tools"
        Me.Column5.Name = "Column5"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "fuel"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "fuel amt"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvctrees)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 165)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "cleaningtrees"
        Me.GroupBox1.Visible = False
        '
        'dgvctrees
        '
        Me.dgvctrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvctrees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvctrees.Location = New System.Drawing.Point(6, 19)
        Me.dgvctrees.Name = "dgvctrees"
        Me.dgvctrees.Size = New System.Drawing.Size(274, 148)
        Me.dgvctrees.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "type of tree"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "count of trees"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "amount"
        Me.Column3.Name = "Column3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtpkg)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtpp)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtnp)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 164)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "coffee cleaning"
        Me.GroupBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "total amount"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(130, 182)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 8
        '
        'txtpkg
        '
        Me.txtpkg.Location = New System.Drawing.Point(130, 144)
        Me.txtpkg.Name = "txtpkg"
        Me.txtpkg.Size = New System.Drawing.Size(100, 20)
        Me.txtpkg.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "pay/kg"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(130, 104)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "qty of coffee cleaned"
        '
        'txtpp
        '
        Me.txtpp.Location = New System.Drawing.Point(96, 68)
        Me.txtpp.Name = "txtpp"
        Me.txtpp.Size = New System.Drawing.Size(100, 20)
        Me.txtpp.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "pay/plant"
        '
        'txtnp
        '
        Me.txtnp.Location = New System.Drawing.Point(96, 34)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.Size = New System.Drawing.Size(100, 20)
        Me.txtnp.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "no of plants"
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(208, 157)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(87, 20)
        Me.dtpto.TabIndex = 10
        '
        'dtpfrom
        '
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(112, 157)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtpfrom.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "from"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "date"
        '
        'cmbincharge
        '
        Me.cmbincharge.FormattingEnabled = True
        Me.cmbincharge.Location = New System.Drawing.Point(110, 59)
        Me.cmbincharge.Name = "cmbincharge"
        Me.cmbincharge.Size = New System.Drawing.Size(121, 21)
        Me.cmbincharge.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "incharge"
        '
        'cmbcleaning
        '
        Me.cmbcleaning.FormattingEnabled = True
        Me.cmbcleaning.Items.AddRange(New Object() {"Trees", "Coffee"})
        Me.cmbcleaning.Location = New System.Drawing.Point(111, 86)
        Me.cmbcleaning.Name = "cmbcleaning"
        Me.cmbcleaning.Size = New System.Drawing.Size(121, 21)
        Me.cmbcleaning.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "cleaning type"
        '
        'txtsetno
        '
        Me.txtsetno.Location = New System.Drawing.Point(110, 32)
        Me.txtsetno.Name = "txtsetno"
        Me.txtsetno.Size = New System.Drawing.Size(55, 20)
        Me.txtsetno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "setno"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(433, 421)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(104, 36)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmcleaning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmcleaning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcleaning"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvclean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvgeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvctrees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnclean As System.Windows.Forms.Button
    Friend WithEvents btnmanure As System.Windows.Forms.Button
    Friend WithEvents btnirrigation As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvgeneral As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtpkg As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvtools As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvctrees As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbincharge As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcleaning As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsetno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnoworkers As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnmprint As System.Windows.Forms.Button
    Friend WithEvents btnmdelete As System.Windows.Forms.Button
    Friend WithEvents btnmclear As System.Windows.Forms.Button
    Friend WithEvents btnmcancel As System.Windows.Forms.Button
    Friend WithEvents btnmupdate As System.Windows.Forms.Button
    Friend WithEvents btnmsave As System.Windows.Forms.Button
    Friend WithEvents dgvclean As System.Windows.Forms.DataGridView
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnmadd As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
