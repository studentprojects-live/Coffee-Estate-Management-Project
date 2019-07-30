<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmworkassign
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.txtpay = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbmanage = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvtools = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtsource = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnremove = New System.Windows.Forms.Button
        Me.lstall = New System.Windows.Forms.ListBox
        Me.lstworkers = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Till = New System.Windows.Forms.Label
        Me.from = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.tperiod = New System.Windows.Forms.Label
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.workdescription = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtpay)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbmanage)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dgvtools)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtsource)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbstatus)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtnum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnremove)
        Me.Panel1.Controls.Add(Me.lstall)
        Me.Panel1.Controls.Add(Me.lstworkers)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Till)
        Me.Panel1.Controls.Add(Me.from)
        Me.Panel1.Controls.Add(Me.dtpto)
        Me.Panel1.Controls.Add(Me.dtpfrom)
        Me.Panel1.Controls.Add(Me.tperiod)
        Me.Panel1.Controls.Add(Me.txtdes)
        Me.Panel1.Controls.Add(Me.workdescription)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 546)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Location = New System.Drawing.Point(413, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 73)
        Me.Panel2.TabIndex = 30
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(66, 42)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(54, 26)
        Me.btnclear.TabIndex = 29
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(7, 42)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(53, 26)
        Me.btncancel.TabIndex = 28
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(7, 7)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(53, 29)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(66, 7)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(54, 29)
        Me.btnupdate.TabIndex = 27
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtpay
        '
        Me.txtpay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpay.Location = New System.Drawing.Point(413, 165)
        Me.txtpay.Name = "txtpay"
        Me.txtpay.Size = New System.Drawing.Size(135, 22)
        Me.txtpay.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(360, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Pay/day"
        '
        'cmbmanage
        '
        Me.cmbmanage.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmanage.FormattingEnabled = True
        Me.cmbmanage.Location = New System.Drawing.Point(413, 137)
        Me.cmbmanage.Name = "cmbmanage"
        Me.cmbmanage.Size = New System.Drawing.Size(135, 23)
        Me.cmbmanage.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(336, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Managed by"
        '
        'dgvtools
        '
        Me.dgvtools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvtools.Location = New System.Drawing.Point(109, 223)
        Me.dgvtools.Name = "dgvtools"
        Me.dgvtools.Size = New System.Drawing.Size(219, 116)
        Me.dgvtools.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tool name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tool count"
        Me.Column2.Name = "Column2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tools"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "source"
        '
        'txtsource
        '
        Me.txtsource.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsource.Location = New System.Drawing.Point(395, 6)
        Me.txtsource.Multiline = True
        Me.txtsource.Name = "txtsource"
        Me.txtsource.Size = New System.Drawing.Size(153, 59)
        Me.txtsource.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Outside"
        '
        'cmbstatus
        '
        Me.cmbstatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Pending", "completed", "under progress", "stopped"})
        Me.cmbstatus.Location = New System.Drawing.Point(413, 108)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(135, 23)
        Me.cmbstatus.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Work status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "workers"
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(413, 75)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(135, 22)
        Me.txtnum.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Number of"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(201, 108)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(29, 32)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "<<"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(201, 185)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(29, 32)
        Me.btnremove.TabIndex = 10
        Me.btnremove.Text = ">>"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'lstall
        '
        Me.lstall.FormattingEnabled = True
        Me.lstall.ItemHeight = 15
        Me.lstall.Location = New System.Drawing.Point(236, 108)
        Me.lstall.Name = "lstall"
        Me.lstall.Size = New System.Drawing.Size(92, 109)
        Me.lstall.TabIndex = 9
        '
        'lstworkers
        '
        Me.lstworkers.FormattingEnabled = True
        Me.lstworkers.ItemHeight = 15
        Me.lstworkers.Location = New System.Drawing.Point(109, 108)
        Me.lstworkers.Name = "lstworkers"
        Me.lstworkers.Size = New System.Drawing.Size(86, 109)
        Me.lstworkers.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select workers"
        '
        'Till
        '
        Me.Till.AutoSize = True
        Me.Till.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Till.Location = New System.Drawing.Point(233, 68)
        Me.Till.Name = "Till"
        Me.Till.Size = New System.Drawing.Size(21, 15)
        Me.Till.TabIndex = 6
        Me.Till.Text = "To"
        '
        'from
        '
        Me.from.AutoSize = True
        Me.from.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from.Location = New System.Drawing.Point(106, 68)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(34, 15)
        Me.from.TabIndex = 5
        Me.from.Text = "From"
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(235, 83)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(102, 22)
        Me.dtpto.TabIndex = 4
        '
        'dtpfrom
        '
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(108, 84)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(102, 22)
        Me.dtpfrom.TabIndex = 3
        '
        'tperiod
        '
        Me.tperiod.AutoSize = True
        Me.tperiod.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tperiod.Location = New System.Drawing.Point(33, 88)
        Me.tperiod.Name = "tperiod"
        Me.tperiod.Size = New System.Drawing.Size(70, 15)
        Me.tperiod.TabIndex = 2
        Me.tperiod.Text = "Time period"
        '
        'txtdes
        '
        Me.txtdes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.Location = New System.Drawing.Point(109, 6)
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(229, 59)
        Me.txtdes.TabIndex = 1
        '
        'workdescription
        '
        Me.workdescription.AutoSize = True
        Me.workdescription.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workdescription.Location = New System.Drawing.Point(8, 13)
        Me.workdescription.Name = "workdescription"
        Me.workdescription.Size = New System.Drawing.Size(99, 15)
        Me.workdescription.TabIndex = 0
        Me.workdescription.Text = "Work description"
        '
        'frmworkassign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmworkassign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "work assignment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Till As System.Windows.Forms.Label
    Friend WithEvents from As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents tperiod As System.Windows.Forms.Label
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents workdescription As System.Windows.Forms.Label
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents lstall As System.Windows.Forms.ListBox
    Friend WithEvents lstworkers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsource As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvtools As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbmanage As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpay As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
