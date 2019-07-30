<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsales
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
        Me.btnprod = New System.Windows.Forms.Button
        Me.btnsales = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.txtaqty = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.btndel = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.txtsold = New System.Windows.Forms.TextBox
        Me.dgvsales = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.cmbcat = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbsubtype = New System.Windows.Forms.ComboBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnprint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnprod)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnsales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtaqty)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtdesc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btndel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnreset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsold)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvsales)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnadd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txttotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btncancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtprice)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtpdate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtqty)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbcat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbsubtype)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 546)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.TabIndex = 0
        '
        'btnprod
        '
        Me.btnprod.Location = New System.Drawing.Point(11, 23)
        Me.btnprod.Name = "btnprod"
        Me.btnprod.Size = New System.Drawing.Size(137, 50)
        Me.btnprod.TabIndex = 26
        Me.btnprod.Text = "Production"
        Me.btnprod.UseVisualStyleBackColor = True
        '
        'btnsales
        '
        Me.btnsales.Location = New System.Drawing.Point(11, 85)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Size = New System.Drawing.Size(137, 50)
        Me.btnsales.TabIndex = 27
        Me.btnsales.Text = "Sales"
        Me.btnsales.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(11, 483)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(137, 50)
        Me.btnprint.TabIndex = 35
        Me.btnprint.Text = "Print Report"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'txtaqty
        '
        Me.txtaqty.Location = New System.Drawing.Point(166, 135)
        Me.txtaqty.Name = "txtaqty"
        Me.txtaqty.Size = New System.Drawing.Size(121, 20)
        Me.txtaqty.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Available Quantity"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(166, 288)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(174, 93)
        Me.txtdesc.TabIndex = 15
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(427, 403)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 23)
        Me.btndel.TabIndex = 32
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Description"
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(517, 403)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "Clear"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtsold
        '
        Me.txtsold.Location = New System.Drawing.Point(166, 255)
        Me.txtsold.Name = "txtsold"
        Me.txtsold.Size = New System.Drawing.Size(121, 20)
        Me.txtsold.TabIndex = 13
        '
        'dgvsales
        '
        Me.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvsales.Location = New System.Drawing.Point(346, 39)
        Me.dgvsales.Name = "dgvsales"
        Me.dgvsales.Size = New System.Drawing.Size(340, 343)
        Me.dgvsales.TabIndex = 31
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Subtype"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sold To"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(346, 403)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 30
        Me.btnadd.Text = "Add Sales"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(166, 224)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 20)
        Me.txttotal.TabIndex = 11
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(611, 403)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 34
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "total Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(166, 194)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(121, 20)
        Me.txtprice.TabIndex = 9
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(166, 39)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpdate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price/Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(166, 164)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(121, 20)
        Me.txtqty.TabIndex = 7
        '
        'cmbcat
        '
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Robusta", "Arabica"})
        Me.cmbcat.Location = New System.Drawing.Point(166, 68)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(121, 21)
        Me.cmbcat.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subtype"
        '
        'cmbsubtype
        '
        Me.cmbsubtype.FormattingEnabled = True
        Me.cmbsubtype.Items.AddRange(New Object() {"Fresh", "Dry", "Curing"})
        Me.cmbsubtype.Location = New System.Drawing.Point(166, 101)
        Me.cmbsubtype.Name = "cmbsubtype"
        Me.cmbsubtype.Size = New System.Drawing.Size(121, 21)
        Me.cmbsubtype.TabIndex = 5
        '
        'frmsales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmsales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsales"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtaqty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsold As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbsubtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents dgvsales As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnprod As System.Windows.Forms.Button
    Friend WithEvents btnsales As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
