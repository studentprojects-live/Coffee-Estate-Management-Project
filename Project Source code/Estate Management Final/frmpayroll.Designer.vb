<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayroll
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.txtwpay = New System.Windows.Forms.TextBox
        Me.txtinvest = New System.Windows.Forms.TextBox
        Me.txtsales = New System.Windows.Forms.TextBox
        Me.txtprofit = New System.Windows.Forms.TextBox
        Me.txtcredit = New System.Windows.Forms.TextBox
        Me.dgvdetails = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.dgvpayroll = New System.Windows.Forms.DataGridView
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvpayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "worker payroll"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "investment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "other credentials"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "total profit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "sales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "details"
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(121, 55)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(100, 20)
        Me.dtpdate.TabIndex = 7
        '
        'txtwpay
        '
        Me.txtwpay.Enabled = False
        Me.txtwpay.Location = New System.Drawing.Point(121, 84)
        Me.txtwpay.Name = "txtwpay"
        Me.txtwpay.Size = New System.Drawing.Size(100, 20)
        Me.txtwpay.TabIndex = 8
        '
        'txtinvest
        '
        Me.txtinvest.Enabled = False
        Me.txtinvest.Location = New System.Drawing.Point(121, 120)
        Me.txtinvest.Name = "txtinvest"
        Me.txtinvest.Size = New System.Drawing.Size(100, 20)
        Me.txtinvest.TabIndex = 9
        '
        'txtsales
        '
        Me.txtsales.Enabled = False
        Me.txtsales.Location = New System.Drawing.Point(121, 171)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.Size = New System.Drawing.Size(100, 20)
        Me.txtsales.TabIndex = 10
        '
        'txtprofit
        '
        Me.txtprofit.Enabled = False
        Me.txtprofit.Location = New System.Drawing.Point(138, 415)
        Me.txtprofit.Name = "txtprofit"
        Me.txtprofit.Size = New System.Drawing.Size(100, 20)
        Me.txtprofit.TabIndex = 11
        '
        'txtcredit
        '
        Me.txtcredit.Location = New System.Drawing.Point(138, 368)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(100, 20)
        Me.txtcredit.TabIndex = 12
        Me.txtcredit.Text = "0"
        '
        'dgvdetails
        '
        Me.dgvdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvdetails.Location = New System.Drawing.Point(121, 206)
        Me.dgvdetails.Name = "dgvdetails"
        Me.dgvdetails.Size = New System.Drawing.Size(240, 126)
        Me.dgvdetails.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "credentials"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "amount"
        Me.Column2.Name = "Column2"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(738, 397)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(102, 35)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(600, 397)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(102, 35)
        Me.btnprint.TabIndex = 15
        Me.btnprint.Text = "print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(738, 356)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(102, 35)
        Me.btnreset.TabIndex = 16
        Me.btnreset.Text = "reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(600, 356)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(102, 35)
        Me.btnadd.TabIndex = 17
        Me.btnadd.Text = "add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dgvpayroll
        '
        Me.dgvpayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4})
        Me.dgvpayroll.Location = New System.Drawing.Point(597, 33)
        Me.dgvpayroll.Name = "dgvpayroll"
        Me.dgvpayroll.Size = New System.Drawing.Size(243, 299)
        Me.dgvpayroll.TabIndex = 18
        '
        'Column3
        '
        Me.Column3.HeaderText = "date of update"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "profit as on"
        Me.Column4.Name = "Column4"
        '
        'frmpayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.dgvpayroll)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.dgvdetails)
        Me.Controls.Add(Me.txtcredit)
        Me.Controls.Add(Me.txtprofit)
        Me.Controls.Add(Me.txtsales)
        Me.Controls.Add(Me.txtinvest)
        Me.Controls.Add(Me.txtwpay)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmpayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpayroll"
        CType(Me.dgvdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvpayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtwpay As System.Windows.Forms.TextBox
    Friend WithEvents txtinvest As System.Windows.Forms.TextBox
    Friend WithEvents txtsales As System.Windows.Forms.TextBox
    Friend WithEvents txtprofit As System.Windows.Forms.TextBox
    Friend WithEvents txtcredit As System.Windows.Forms.TextBox
    Friend WithEvents dgvdetails As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents dgvpayroll As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
