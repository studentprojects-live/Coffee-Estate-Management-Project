<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnadmin = New System.Windows.Forms.Button
        Me.btnguest = New System.Windows.Forms.Button
        Me.btnlogin = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.userpic = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.userpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 104)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(84, 66)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(123, 20)
        Me.txtpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(84, 19)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(123, 20)
        Me.txtusername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'btnadmin
        '
        Me.btnadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmin.Location = New System.Drawing.Point(6, 116)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(75, 23)
        Me.btnadmin.TabIndex = 0
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'btnguest
        '
        Me.btnguest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguest.Location = New System.Drawing.Point(87, 116)
        Me.btnguest.Name = "btnguest"
        Me.btnguest.Size = New System.Drawing.Size(77, 23)
        Me.btnguest.TabIndex = 1
        Me.btnguest.Text = "Guest"
        Me.btnguest.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(176, 116)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(77, 23)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(257, 116)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Exit"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'userpic
        '
        Me.userpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userpic.Location = New System.Drawing.Point(231, 7)
        Me.userpic.Name = "userpic"
        Me.userpic.Size = New System.Drawing.Size(101, 104)
        Me.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userpic.TabIndex = 4
        Me.userpic.TabStop = False
        Me.userpic.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.userpic)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnadmin)
        Me.Panel2.Controls.Add(Me.btnlogin)
        Me.Panel2.Controls.Add(Me.btnguest)
        Me.Panel2.Location = New System.Drawing.Point(283, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 146)
        Me.Panel2.TabIndex = 5
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.userpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents btnguest As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents userpic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
