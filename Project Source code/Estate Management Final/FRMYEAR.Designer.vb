<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMYEAR
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
        Me.cmbyear = New System.Windows.Forms.ComboBox
        Me.btnset = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btndefault = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year"
        '
        'cmbyear
        '
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Location = New System.Drawing.Point(102, 26)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(165, 21)
        Me.cmbyear.TabIndex = 1
        '
        'btnset
        '
        Me.btnset.Location = New System.Drawing.Point(6, 69)
        Me.btnset.Name = "btnset"
        Me.btnset.Size = New System.Drawing.Size(75, 23)
        Me.btnset.TabIndex = 2
        Me.btnset.Text = "Set"
        Me.btnset.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(192, 69)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndefault
        '
        Me.btndefault.Location = New System.Drawing.Point(102, 69)
        Me.btndefault.Name = "btndefault"
        Me.btndefault.Size = New System.Drawing.Size(75, 23)
        Me.btndefault.TabIndex = 4
        Me.btndefault.Text = "Default"
        Me.btndefault.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btndefault)
        Me.Panel1.Controls.Add(Me.cmbyear)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnset)
        Me.Panel1.Location = New System.Drawing.Point(266, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 112)
        Me.Panel1.TabIndex = 5
        '
        'FRMYEAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRMYEAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMYEAR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents btnset As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btndefault As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
