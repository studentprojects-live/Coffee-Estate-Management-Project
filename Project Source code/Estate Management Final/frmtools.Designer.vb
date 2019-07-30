<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtools
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnotools = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtaptool = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtptooldate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvtransport = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvtools = New System.Windows.Forms.DataGridView
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvtransport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "tool name"
        '
        'txttname
        '
        Me.txttname.Location = New System.Drawing.Point(116, 32)
        Me.txttname.Name = "txttname"
        Me.txttname.Size = New System.Drawing.Size(100, 20)
        Me.txttname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "no of tools"
        '
        'txtnotools
        '
        Me.txtnotools.Location = New System.Drawing.Point(116, 78)
        Me.txtnotools.Name = "txtnotools"
        Me.txtnotools.Size = New System.Drawing.Size(100, 20)
        Me.txtnotools.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "amt/tool"
        '
        'txtaptool
        '
        Me.txtaptool.Location = New System.Drawing.Point(116, 115)
        Me.txtaptool.Name = "txtaptool"
        Me.txtaptool.Size = New System.Drawing.Size(100, 20)
        Me.txtaptool.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "total amt"
        '
        'txttotalamt
        '
        Me.txttotalamt.Location = New System.Drawing.Point(116, 156)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(100, 20)
        Me.txttotalamt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "date"
        '
        'dtptooldate
        '
        Me.dtptooldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptooldate.Location = New System.Drawing.Point(116, 199)
        Me.dtptooldate.Name = "dtptooldate"
        Me.dtptooldate.Size = New System.Drawing.Size(114, 20)
        Me.dtptooldate.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvtransport)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 213)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transportation Details"
        '
        'dgvtransport
        '
        Me.dgvtransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtransport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvtransport.Location = New System.Drawing.Point(6, 19)
        Me.dgvtransport.Name = "dgvtransport"
        Me.dgvtransport.Size = New System.Drawing.Size(342, 188)
        Me.dgvtransport.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Transportation Type"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Total Amount"
        Me.Column3.Name = "Column3"
        '
        'dgvtools
        '
        Me.dgvtools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column4, Me.Column5})
        Me.dgvtools.Location = New System.Drawing.Point(448, 32)
        Me.dgvtools.Name = "dgvtools"
        Me.dgvtools.Size = New System.Drawing.Size(344, 412)
        Me.dgvtools.TabIndex = 1
        '
        'Column6
        '
        Me.Column6.HeaderText = "sl.no"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.HeaderText = "date"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "tool name"
        Me.Column5.Name = "Column5"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(448, 451)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(89, 64)
        Me.btnadd.TabIndex = 57
        Me.btnadd.Text = "add new"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(711, 451)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(78, 29)
        Me.btnprint.TabIndex = 56
        Me.btnprint.Text = "print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(627, 486)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 29)
        Me.btndelete.TabIndex = 55
        Me.btndelete.Text = "delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(627, 451)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(78, 29)
        Me.btnclear.TabIndex = 54
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(711, 486)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 29)
        Me.btncancel.TabIndex = 53
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(543, 485)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(78, 29)
        Me.btnupdate.TabIndex = 52
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(543, 450)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 29)
        Me.btnsave.TabIndex = 51
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmtools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dgvtools)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtptooldate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttotalamt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaptool)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnotools)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmtools"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvtransport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnotools As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaptool As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtptooldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvtransport As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtools As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
