Public Class Form1backup

    Private Sub btnccancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnccancel.Click
        Me.Close()

    End Sub

    Private Sub btnrcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrcancel.Click
        Me.Close()
    End Sub

    Private Sub btnccreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnccreate.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        ' Then use the following code to create the Dialog window
        ' Change the .SelectedPath property to the default location
        With FolderBrowserDialog1
            ' Desktop is the root folder in the dialog.
            .RootFolder = Environment.SpecialFolder.Desktop
            ' Select the C:\Windows directory on entry.
            .SelectedPath = "d:\"
            ' Prompt the user with a custom message.
            .Description = "Select the source directory"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Display the selected folder if the user clicked on the OK button.
                'MessageBox.Show(.SelectedPath)
                Dim bk = .SelectedPath & "\Estate.bak"
                Try

                   
                    sql = "BACKUP DATABASE Estate TO DISK ='" & bk & "'"
                    conn.Execute(sql)


                    MsgBox("DataBase Restored Successfully", MsgBoxStyle.Information, "I-Search")


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub Form1backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
    End Sub

  
End Class