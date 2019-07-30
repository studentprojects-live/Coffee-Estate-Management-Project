Public Class frmlogin

    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        userpic.Visible = True
        Panel1.Visible = True
        Label2.Visible = True
        txtpassword.Visible = True
        usertype = "Admin"
        sql = "select user_pic from tbl_login where UserType='" & usertype & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            userpic.ImageLocation = rs(0).Value
        End If
    End Sub

    Private Sub btnguest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguest.Click
        Panel1.Visible = True
        Label2.Visible = False
        txtpassword.Visible = False
        usertype = "Guest"
        userpic.ImageLocation = ""
        userpic.Visible = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
    End Sub
    Sub clear()
        txtpassword.Clear()
        txtusername.Clear()
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If usertype = "Admin" Then
            sql = "select * from tbl_login where UserType='" & usertype & "' and Username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("login Succcessfull", MsgBoxStyle.Information, "Success")
                sql = "insert into tbl_LogDetails(UserType,Username,LogDate,Login,year)values('" & usertype & "','" & txtusername.Text & "',convert(date,'" & Now.Date & "',103),'" & Now.TimeOfDay.ToString & "','" & year & "')"
                conn.Execute(sql)
                frmmaster.Show()
                Me.Hide()
            Else
                MsgBox("Invalid User", MsgBoxStyle.Exclamation, "Failure")
                clear()
            End If
        ElseIf usertype = "Guest" Then
            sql = "insert into tbl_LogDetails(UserType,Username,LogDate,Login,year)values('" & usertype & "','" & txtusername.Text & "',convert(date,'" & Now.Date & "',103),'" & Now.TimeOfDay.ToString & "','" & year & "')"
            conn.Execute(sql)
            frmmaster.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userpic.Click

    End Sub
End Class
