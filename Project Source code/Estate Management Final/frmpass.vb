Public Class frmpass

  

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtconfirm.Clear()
        txtnew.Clear()
        txtold.Clear()
        txtuser.Clear()
        txtolduser.Clear()
        adminpic.ImageLocation = ""
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click

        If txtconfirm.Text = "" Or txtnew.Text = "" Or txtold.Text = "" Or txtuser.Text = "" Or txtolduser.Text = "" Then
            MsgBox("please enter all the values", MsgBoxStyle.Information)
        Else
            sql = " select * from tbl_login where username ='" & txtolduser.Text & "' and password= '" & txtold.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                If txtconfirm.Text = txtnew.Text Then
                    sql = " update tbl_login set username='" & txtuser.Text & "',password='" & txtnew.Text & "',user_pic='" & adminpic.ImageLocation & "' where username ='" & txtolduser.Text & "' and password= '" & txtold.Text & "'"
                    conn.Execute(sql)
                    MsgBox("password changed successfully", MsgBoxStyle.Information)
                Else
                    MsgBox("new password mismatch,please check", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox(" invalid entry", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub txtolduser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtolduser.TextChanged
        txtuser.Text = txtolduser.Text
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        With Me.OpenFileDialog1
            .Filter = "All Files|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                adminpic.ImageLocation = .FileName
            End If
        End With
        sql = " update tbl_login set user_pic='" & adminpic.ImageLocation & "'"
        conn.Execute(sql)
        MsgBox(" image uploaded successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub frmpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " select user_pic from tbl_login"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            adminpic.ImageLocation = rs(0).Value
        End If

    End Sub
End Class