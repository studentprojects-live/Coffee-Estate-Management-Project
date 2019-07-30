Public Class FRMYEAR

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnset.Click
        sql = "select * from tbl_year where year='" & cmbyear.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            sql = "update tbl_year set status='Active' where year='" & cmbyear.Text & "'"
            conn.Execute(sql)
            MsgBox("Current year records are activated", MsgBoxStyle.Information)
            cmbyear.Text = ""
            load_year()
        Else
            If cmbyear.Text <> Now.Year Then
                MsgBox("No Records Available", MsgBoxStyle.Information)
                Exit Sub
            End If
            sql = "insert into tbl_year(year,status)values('" & cmbyear.Text & "','Active')"
            conn.Execute(sql)
            MsgBox("Current year records are activated", MsgBoxStyle.Information)
            cmbyear.Text = ""
            load_year()
        End If
         End Sub

    Private Sub FRMYEAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
    End Sub
    Sub load_year()
        cmbyear.Items.Clear()
        sql = "select * from tbl_year"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            cmbyear.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub btndefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefault.Click
        sql = "select * from tbl_year where year='" & Now.Year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            sql = "update tbl_year set status='Active' where year='" & Now.Year & "'"
            conn.Execute(sql)
            MsgBox("Current year records are activated", MsgBoxStyle.Information)
            cmbyear.Text = ""
            load_year()
        Else
            sql = "insert into tbl_year(year,status)values('" & Now.Year & "','Active')"
            conn.Execute(sql)
            MsgBox("Current year records are activated", MsgBoxStyle.Information)
            cmbyear.Text = ""
            load_year()
        End If
    End Sub
End Class