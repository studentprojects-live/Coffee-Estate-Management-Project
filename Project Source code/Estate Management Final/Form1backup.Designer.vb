<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1backup
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
        Me.txtcreate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnccreate = New System.Windows.Forms.Button
        Me.btnccancel = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtrestore = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnrbrowse = New System.Windows.Forms.Button
        Me.btnrcreate = New System.Windows.Forms.Button
        Me.btnrcancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtcreate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnccreate)
        Me.Panel1.Controls.Add(Me.btnccancel)
        Me.Panel1.Location = New System.Drawing.Point(238, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 121)
        Me.Panel1.TabIndex = 0
        '
        'txtcreate
        '
        Me.txtcreate.Location = New System.Drawing.Point(27, 50)
        Me.txtcreate.Name = "txtcreate"
        Me.txtcreate.Size = New System.Drawing.Size(268, 20)
        Me.txtcreate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "select desired folder to create backup"
        '
        'btnccreate
        '
        Me.btnccreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnccreate.Location = New System.Drawing.Point(84, 86)
        Me.btnccreate.Name = "btnccreate"
        Me.btnccreate.Size = New System.Drawing.Size(75, 23)
        Me.btnccreate.TabIndex = 1
        Me.btnccreate.Text = "create"
        Me.btnccreate.UseVisualStyleBackColor = True
        '
        'btnccancel
        '
        Me.btnccancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnccancel.Location = New System.Drawing.Point(165, 86)
        Me.btnccancel.Name = "btnccancel"
        Me.btnccancel.Size = New System.Drawing.Size(75, 23)
        Me.btnccancel.TabIndex = 0
        Me.btnccancel.Text = "cancel"
        Me.btnccancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtrestore)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnrbrowse)
        Me.Panel2.Controls.Add(Me.btnrcreate)
        Me.Panel2.Controls.Add(Me.btnrcancel)
        Me.Panel2.Location = New System.Drawing.Point(238, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 121)
        Me.Panel2.TabIndex = 1
        '
        'txtrestore
        '
        Me.txtrestore.Location = New System.Drawing.Point(27, 50)
        Me.txtrestore.Name = "txtrestore"
        Me.txtrestore.Size = New System.Drawing.Size(268, 20)
        Me.txtrestore.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "select desired backup to restore data"
        '
        'btnrbrowse
        '
        Me.btnrbrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrbrowse.Location = New System.Drawing.Point(27, 86)
        Me.btnrbrowse.Name = "btnrbrowse"
        Me.btnrbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnrbrowse.TabIndex = 2
        Me.btnrbrowse.Text = "browse"
        Me.btnrbrowse.UseVisualStyleBackColor = True
        '
        'btnrcreate
        '
        Me.btnrcreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrcreate.Location = New System.Drawing.Point(125, 86)
        Me.btnrcreate.Name = "btnrcreate"
        Me.btnrcreate.Size = New System.Drawing.Size(75, 23)
        Me.btnrcreate.TabIndex = 1
        Me.btnrcreate.Text = "create"
        Me.btnrcreate.UseVisualStyleBackColor = True
        '
        'btnrcancel
        '
        Me.btnrcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrcancel.Location = New System.Drawing.Point(220, 86)
        Me.btnrcancel.Name = "btnrcancel"
        Me.btnrcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnrcancel.TabIndex = 0
        Me.btnrcancel.Text = "cancel"
        Me.btnrcancel.UseVisualStyleBackColor = True
        '
        'Form1backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1backup"
        Me.Text = "Form1backup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtcreate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnccreate As System.Windows.Forms.Button
    Friend WithEvents btnccancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtrestore As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnrbrowse As System.Windows.Forms.Button
    Friend WithEvents btnrcreate As System.Windows.Forms.Button
    Friend WithEvents btnrcancel As System.Windows.Forms.Button
End Class
