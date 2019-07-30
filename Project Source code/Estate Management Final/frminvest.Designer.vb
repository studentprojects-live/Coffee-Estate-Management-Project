<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminvest
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnworkinvest = New System.Windows.Forms.Button
        Me.btnwrkassign = New System.Windows.Forms.Button
        Me.btnworkinfo = New System.Windows.Forms.Button
        Me.wrkinvstpanel = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnwinsave = New System.Windows.Forms.Button
        Me.btnwincancel = New System.Windows.Forms.Button
        Me.btnwinclear = New System.Windows.Forms.Button
        Me.btnwindelete = New System.Windows.Forms.Button
        Me.cmbwrkdes = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtmanage = New System.Windows.Forms.TextBox
        Me.txttinvest = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dgvoutsourse = New System.Windows.Forms.DataGridView
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtpd = New System.Windows.Forms.TextBox
        Me.txtwd = New System.Windows.Forms.TextBox
        Me.txtnw = New System.Windows.Forms.TextBox
        Me.dgvinvest = New System.Windows.Forms.DataGridView
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnupdate = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.wrkinvstpanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvoutsourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinvest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.wrkinvstpanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 546)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 0
        '
        'btnworkinvest
        '
        Me.btnworkinvest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkinvest.Location = New System.Drawing.Point(12, 135)
        Me.btnworkinvest.Name = "btnworkinvest"
        Me.btnworkinvest.Size = New System.Drawing.Size(137, 50)
        Me.btnworkinvest.TabIndex = 12
        Me.btnworkinvest.Text = "Work Investments"
        Me.btnworkinvest.UseVisualStyleBackColor = True
        '
        'btnwrkassign
        '
        Me.btnwrkassign.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwrkassign.Location = New System.Drawing.Point(12, 73)
        Me.btnwrkassign.Name = "btnwrkassign"
        Me.btnwrkassign.Size = New System.Drawing.Size(137, 50)
        Me.btnwrkassign.TabIndex = 11
        Me.btnwrkassign.Text = "Work Assignments"
        Me.btnwrkassign.UseVisualStyleBackColor = True
        '
        'btnworkinfo
        '
        Me.btnworkinfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkinfo.Location = New System.Drawing.Point(12, 14)
        Me.btnworkinfo.Name = "btnworkinfo"
        Me.btnworkinfo.Size = New System.Drawing.Size(137, 50)
        Me.btnworkinfo.TabIndex = 10
        Me.btnworkinfo.Text = "Workers Information"
        Me.btnworkinfo.UseVisualStyleBackColor = True
        '
        'wrkinvstpanel
        '
        Me.wrkinvstpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wrkinvstpanel.Controls.Add(Me.Panel5)
        Me.wrkinvstpanel.Controls.Add(Me.cmbwrkdes)
        Me.wrkinvstpanel.Controls.Add(Me.Label27)
        Me.wrkinvstpanel.Controls.Add(Me.txtmanage)
        Me.wrkinvstpanel.Controls.Add(Me.txttinvest)
        Me.wrkinvstpanel.Controls.Add(Me.Label26)
        Me.wrkinvstpanel.Controls.Add(Me.Label25)
        Me.wrkinvstpanel.Controls.Add(Me.dgvoutsourse)
        Me.wrkinvstpanel.Controls.Add(Me.Label24)
        Me.wrkinvstpanel.Controls.Add(Me.Label23)
        Me.wrkinvstpanel.Controls.Add(Me.Label22)
        Me.wrkinvstpanel.Controls.Add(Me.Label21)
        Me.wrkinvstpanel.Controls.Add(Me.txtpd)
        Me.wrkinvstpanel.Controls.Add(Me.txtwd)
        Me.wrkinvstpanel.Controls.Add(Me.txtnw)
        Me.wrkinvstpanel.Controls.Add(Me.dgvinvest)
        Me.wrkinvstpanel.Location = New System.Drawing.Point(3, 0)
        Me.wrkinvstpanel.Name = "wrkinvstpanel"
        Me.wrkinvstpanel.Size = New System.Drawing.Size(729, 541)
        Me.wrkinvstpanel.TabIndex = 33
        Me.wrkinvstpanel.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnupdate)
        Me.Panel5.Controls.Add(Me.btnadd)
        Me.Panel5.Controls.Add(Me.btnwinsave)
        Me.Panel5.Controls.Add(Me.btnwincancel)
        Me.Panel5.Controls.Add(Me.btnwinclear)
        Me.Panel5.Controls.Add(Me.btnwindelete)
        Me.Panel5.Location = New System.Drawing.Point(355, 430)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 75)
        Me.Panel5.TabIndex = 33
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(238, 41)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(89, 24)
        Me.btnadd.TabIndex = 30
        Me.btnadd.Text = "add new"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(12, 483)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(137, 50)
        Me.btnprint.TabIndex = 5
        Me.btnprint.Text = "Print Report"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnwinsave
        '
        Me.btnwinsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwinsave.Location = New System.Drawing.Point(5, 4)
        Me.btnwinsave.Name = "btnwinsave"
        Me.btnwinsave.Size = New System.Drawing.Size(90, 23)
        Me.btnwinsave.TabIndex = 26
        Me.btnwinsave.Text = "save"
        Me.btnwinsave.UseVisualStyleBackColor = True
        '
        'btnwincancel
        '
        Me.btnwincancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwincancel.Location = New System.Drawing.Point(5, 41)
        Me.btnwincancel.Name = "btnwincancel"
        Me.btnwincancel.Size = New System.Drawing.Size(90, 24)
        Me.btnwincancel.TabIndex = 28
        Me.btnwincancel.Text = "cancel"
        Me.btnwincancel.UseVisualStyleBackColor = True
        '
        'btnwinclear
        '
        Me.btnwinclear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwinclear.Location = New System.Drawing.Point(120, 41)
        Me.btnwinclear.Name = "btnwinclear"
        Me.btnwinclear.Size = New System.Drawing.Size(90, 24)
        Me.btnwinclear.TabIndex = 29
        Me.btnwinclear.Text = "clear"
        Me.btnwinclear.UseVisualStyleBackColor = True
        '
        'btnwindelete
        '
        Me.btnwindelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwindelete.Location = New System.Drawing.Point(120, 5)
        Me.btnwindelete.Name = "btnwindelete"
        Me.btnwindelete.Size = New System.Drawing.Size(90, 23)
        Me.btnwindelete.TabIndex = 1
        Me.btnwindelete.Text = "Delete"
        Me.btnwindelete.UseVisualStyleBackColor = True
        '
        'cmbwrkdes
        '
        Me.cmbwrkdes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbwrkdes.FormattingEnabled = True
        Me.cmbwrkdes.Location = New System.Drawing.Point(109, 11)
        Me.cmbwrkdes.Name = "cmbwrkdes"
        Me.cmbwrkdes.Size = New System.Drawing.Size(150, 23)
        Me.cmbwrkdes.TabIndex = 15
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 457)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 15)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "Managed by"
        '
        'txtmanage
        '
        Me.txtmanage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmanage.Location = New System.Drawing.Point(109, 452)
        Me.txtmanage.Name = "txtmanage"
        Me.txtmanage.Size = New System.Drawing.Size(150, 22)
        Me.txtmanage.TabIndex = 13
        '
        'txttinvest
        '
        Me.txttinvest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinvest.ForeColor = System.Drawing.Color.Navy
        Me.txttinvest.Location = New System.Drawing.Point(109, 480)
        Me.txttinvest.Name = "txttinvest"
        Me.txttinvest.Size = New System.Drawing.Size(150, 22)
        Me.txttinvest.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(5, 485)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 15)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Total  Investment"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 143)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 15)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Outside source"
        '
        'dgvoutsourse
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvoutsourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvoutsourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoutsourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvoutsourse.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvoutsourse.Location = New System.Drawing.Point(109, 135)
        Me.dgvoutsourse.Name = "dgvoutsourse"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvoutsourse.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvoutsourse.Size = New System.Drawing.Size(240, 289)
        Me.dgvoutsourse.TabIndex = 9
        '
        'Column8
        '
        Me.Column8.HeaderText = "Outsource"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 15)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Pay/day"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 79)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 15)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "No of work days"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 15)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "No of workers"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 15)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Work description"
        '
        'txtpd
        '
        Me.txtpd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd.Location = New System.Drawing.Point(109, 105)
        Me.txtpd.Name = "txtpd"
        Me.txtpd.Size = New System.Drawing.Size(150, 22)
        Me.txtpd.TabIndex = 4
        '
        'txtwd
        '
        Me.txtwd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwd.Location = New System.Drawing.Point(109, 76)
        Me.txtwd.Name = "txtwd"
        Me.txtwd.Size = New System.Drawing.Size(150, 22)
        Me.txtwd.TabIndex = 3
        '
        'txtnw
        '
        Me.txtnw.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnw.Location = New System.Drawing.Point(109, 43)
        Me.txtnw.Name = "txtnw"
        Me.txtnw.Size = New System.Drawing.Size(150, 22)
        Me.txtnw.TabIndex = 2
        '
        'dgvinvest
        '
        Me.dgvinvest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinvest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvinvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinvest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column10, Me.Column11})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinvest.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvinvest.Location = New System.Drawing.Point(355, 12)
        Me.dgvinvest.Name = "dgvinvest"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinvest.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvinvest.Size = New System.Drawing.Size(336, 412)
        Me.dgvinvest.TabIndex = 0
        '
        'Column12
        '
        Me.Column12.FillWeight = 48.73096!
        Me.Column12.HeaderText = "Sl No"
        Me.Column12.Name = "Column12"
        '
        'Column10
        '
        Me.Column10.FillWeight = 126.8333!
        Me.Column10.HeaderText = "Work Description"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.FillWeight = 64.43575!
        Me.Column11.HeaderText = "Investment"
        Me.Column11.Name = "Column11"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(238, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(89, 23)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'frminvest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frminvest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frminvest"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.wrkinvstpanel.ResumeLayout(False)
        Me.wrkinvstpanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvoutsourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinvest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnworkinvest As System.Windows.Forms.Button
    Friend WithEvents btnwrkassign As System.Windows.Forms.Button
    Friend WithEvents btnworkinfo As System.Windows.Forms.Button
    Friend WithEvents wrkinvstpanel As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnwinsave As System.Windows.Forms.Button
    Friend WithEvents btnwincancel As System.Windows.Forms.Button
    Friend WithEvents btnwinclear As System.Windows.Forms.Button
    Friend WithEvents btnwindelete As System.Windows.Forms.Button
    Friend WithEvents cmbwrkdes As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtmanage As System.Windows.Forms.TextBox
    Friend WithEvents txttinvest As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dgvoutsourse As System.Windows.Forms.DataGridView
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtpd As System.Windows.Forms.TextBox
    Friend WithEvents txtwd As System.Windows.Forms.TextBox
    Friend WithEvents txtnw As System.Windows.Forms.TextBox
    Friend WithEvents dgvinvest As System.Windows.Forms.DataGridView
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
