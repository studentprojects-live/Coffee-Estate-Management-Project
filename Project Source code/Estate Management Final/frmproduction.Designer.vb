<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproduction
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.dgvpro = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnupdate = New System.Windows.Forms.Button
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcarry = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.txtfresh = New System.Windows.Forms.TextBox
        Me.txtdry = New System.Windows.Forms.TextBox
        Me.txtcuring = New System.Windows.Forms.TextBox
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.txtcharge = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbcat = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvpro, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnprod)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnprint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnsales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 546)
        Me.SplitContainer1.SplitterDistance = 155
        Me.SplitContainer1.TabIndex = 0
        '
        'btnprod
        '
        Me.btnprod.Location = New System.Drawing.Point(11, 23)
        Me.btnprod.Name = "btnprod"
        Me.btnprod.Size = New System.Drawing.Size(137, 50)
        Me.btnprod.TabIndex = 24
        Me.btnprod.Text = "Production"
        Me.btnprod.UseVisualStyleBackColor = True
        '
        'btnsales
        '
        Me.btnsales.Location = New System.Drawing.Point(10, 77)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Size = New System.Drawing.Size(137, 50)
        Me.btnsales.TabIndex = 25
        Me.btnsales.Text = "Sales"
        Me.btnsales.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.dtpdate)
        Me.Panel2.Controls.Add(Me.dgvpro)
        Me.Panel2.Controls.Add(Me.btnupdate)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtcarry)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtcname)
        Me.Panel2.Controls.Add(Me.txtfresh)
        Me.Panel2.Controls.Add(Me.txtdry)
        Me.Panel2.Controls.Add(Me.txtcuring)
        Me.Panel2.Controls.Add(Me.txtdesc)
        Me.Panel2.Controls.Add(Me.txtcharge)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.cmbcat)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Location = New System.Drawing.Point(-6, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 546)
        Me.Panel2.TabIndex = 10
        Me.Panel2.Visible = False
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(600, 405)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(130, 30)
        Me.btndelete.TabIndex = 26
        Me.btndelete.Text = "delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(10, 483)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(137, 50)
        Me.btnprint.TabIndex = 25
        Me.btnprint.Text = "Print Report"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(154, 47)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpdate.TabIndex = 24
        '
        'dgvpro
        '
        Me.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvpro.Location = New System.Drawing.Point(329, 14)
        Me.dgvpro.Name = "dgvpro"
        Me.dgvpro.Size = New System.Drawing.Size(401, 372)
        Me.dgvpro.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fresh"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dry"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Curing"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(329, 405)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(130, 30)
        Me.btnupdate.TabIndex = 22
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(154, 367)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 20)
        Me.txttotal.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Total Quantity"
        '
        'txtcarry
        '
        Me.txtcarry.Location = New System.Drawing.Point(154, 334)
        Me.txtcarry.Name = "txtcarry"
        Me.txtcarry.Size = New System.Drawing.Size(121, 20)
        Me.txtcarry.TabIndex = 19
        Me.txtcarry.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Carry Over"
        '
        'txtcname
        '
        Me.txtcname.Location = New System.Drawing.Point(154, 175)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(121, 20)
        Me.txtcname.TabIndex = 17
        '
        'txtfresh
        '
        Me.txtfresh.Location = New System.Drawing.Point(154, 77)
        Me.txtfresh.Name = "txtfresh"
        Me.txtfresh.Size = New System.Drawing.Size(121, 20)
        Me.txtfresh.TabIndex = 14
        '
        'txtdry
        '
        Me.txtdry.Location = New System.Drawing.Point(154, 109)
        Me.txtdry.Name = "txtdry"
        Me.txtdry.Size = New System.Drawing.Size(121, 20)
        Me.txtdry.TabIndex = 13
        '
        'txtcuring
        '
        Me.txtcuring.Location = New System.Drawing.Point(154, 142)
        Me.txtcuring.Name = "txtcuring"
        Me.txtcuring.Size = New System.Drawing.Size(121, 20)
        Me.txtcuring.TabIndex = 12
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(154, 211)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(121, 76)
        Me.txtdesc.TabIndex = 11
        '
        'txtcharge
        '
        Me.txtcharge.Location = New System.Drawing.Point(154, 301)
        Me.txtcharge.Name = "txtcharge"
        Me.txtcharge.Size = New System.Drawing.Size(121, 20)
        Me.txtcharge.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 306)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 16)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Curing Charge"
        '
        'cmbcat
        '
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Robusta", "Arabica"})
        Me.cmbcat.Location = New System.Drawing.Point(154, 17)
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(121, 21)
        Me.cmbcat.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Curing Description"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 145)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(129, 16)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Quantity at Curing"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 16)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Quantity at Dry"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 16)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Quantity at Fresh"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Category"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(464, 405)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(130, 30)
        Me.btncancel.TabIndex = 27
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmproduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmproduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmproduction"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvpro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvpro As System.Windows.Forms.DataGridView
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcarry As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtfresh As System.Windows.Forms.TextBox
    Friend WithEvents txtdry As System.Windows.Forms.TextBox
    Friend WithEvents txtcuring As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnprod As System.Windows.Forms.Button
    Friend WithEvents btnsales As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
