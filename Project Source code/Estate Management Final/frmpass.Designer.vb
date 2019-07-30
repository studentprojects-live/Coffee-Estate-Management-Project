<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpass
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
        Me.txtolduser = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtconfirm = New System.Windows.Forms.TextBox
        Me.txtnew = New System.Windows.Forms.TextBox
        Me.txtold = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnchange = New System.Windows.Forms.Button
        Me.adminpic = New System.Windows.Forms.PictureBox
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.adminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtolduser)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtconfirm)
        Me.Panel1.Controls.Add(Me.txtnew)
        Me.Panel1.Controls.Add(Me.txtold)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 142)
        Me.Panel1.TabIndex = 0
        '
        'txtolduser
        '
        Me.txtolduser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtolduser.Location = New System.Drawing.Point(109, 7)
        Me.txtolduser.Name = "txtolduser"
        Me.txtolduser.Size = New System.Drawing.Size(160, 22)
        Me.txtolduser.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Old Username"
        '
        'txtconfirm
        '
        Me.txtconfirm.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirm.Location = New System.Drawing.Point(109, 106)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirm.Size = New System.Drawing.Size(160, 22)
        Me.txtconfirm.TabIndex = 9
        '
        'txtnew
        '
        Me.txtnew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnew.Location = New System.Drawing.Point(109, 81)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnew.Size = New System.Drawing.Size(160, 22)
        Me.txtnew.TabIndex = 8
        '
        'txtold
        '
        Me.txtold.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtold.Location = New System.Drawing.Point(109, 31)
        Me.txtold.Name = "txtold"
        Me.txtold.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtold.Size = New System.Drawing.Size(160, 22)
        Me.txtold.TabIndex = 7
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(109, 56)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(160, 22)
        Me.txtuser.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Old Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(204, 148)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 28)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(5, 148)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(90, 28)
        Me.btnreset.TabIndex = 1
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnchange
        '
        Me.btnchange.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.Location = New System.Drawing.Point(105, 148)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(90, 28)
        Me.btnchange.TabIndex = 0
        Me.btnchange.Text = "change"
        Me.btnchange.UseVisualStyleBackColor = True
        '
        'adminpic
        '
        Me.adminpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminpic.Location = New System.Drawing.Point(297, 3)
        Me.adminpic.Name = "adminpic"
        Me.adminpic.Size = New System.Drawing.Size(123, 142)
        Me.adminpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.adminpic.TabIndex = 1
        Me.adminpic.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.Location = New System.Drawing.Point(297, 148)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(123, 28)
        Me.btnbrowse.TabIndex = 2
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnbrowse)
        Me.Panel2.Controls.Add(Me.btnchange)
        Me.Panel2.Controls.Add(Me.adminpic)
        Me.Panel2.Controls.Add(Me.btnreset)
        Me.Panel2.Location = New System.Drawing.Point(211, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 179)
        Me.Panel2.TabIndex = 11
        '
        'frmpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.adminpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtnew As System.Windows.Forms.TextBox
    Friend WithEvents txtold As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents adminpic As System.Windows.Forms.PictureBox
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtolduser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
