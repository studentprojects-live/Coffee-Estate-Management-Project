Public Class frmstorage
    Public i As Integer
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtpinfo.Clear()
        cmbincharge.Text = ""
        cmbstype.Text = ""
        dgvistore.Rows.Clear()
        dgvostore.Rows.Clear()
    End Sub

    Private Sub cmbstype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstype.SelectedIndexChanged
        If cmbstype.Text = "INSTORE" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        ElseIf cmbstype.Text = "OUTSTORE" Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub frmstorage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbstype.Text = "INSTORE" Then
            i = 0
            For i = 0 To dgvistore.Rows.Count - 1
                sql = "insert into tbl_instore(year,Incharge,date,coffee_type,Quantity)values('" & year & "','" & cmbincharge.Text & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvistore.Item(0, i).Value & "','" & dgvistore.Item(1, i).Value & "')"
            Next
            conn.Execute(sql)
            MsgBox("record update successfull", MsgBoxStyle.Information)

        ElseIf cmbstype.Text = "OUTSTORE" Then
            For i = 0 To dgvostore.Rows.Count - 1
                sql = "insert into tbl_outstore(year,name,date,coffee_type,Quantity,personal_info)values('" & year & "','" & txtname.Text & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvostore.Item(0, i).Value & "','" & dgvistore.Item(1, i).Value & "','" & txtpinfo.Text & "')"

                conn.Execute(sql)
            Next
            MsgBox("record update successfull", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If cmbstype.Text = "INSTORE" Then
            i = 0
            For i = 0 To dgvistore.Rows.Count - 1
                sql = "update into tbl_instore(year,date,Quantity)values('" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvistore.Item(1, i).Value & "')"
            Next
            conn.Execute(sql)
            MsgBox("record update successfull", MsgBoxStyle.Information)

        ElseIf cmbstype.Text = "OUTSTORE" Then
            For i = 0 To dgvostore.Rows.Count - 1
                sql = "insert into tbl_outstore(year,date,Quantity)values('" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvistore.Item(1, i).Value & "')"

                conn.Execute(sql)
            Next
            MsgBox("record update successfull", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
       If MsgBoxResult.No = MsgBox("do you want to delete the record ?", MsgBoxStyle.YesNo) Then Exit Sub
        If cmbstype.Text = "INSTORE" Then
            sql = "delete from tbl_instore where date=convert(date,'" & dtpdate.Value & "',103)and incharge= '" & cmbincharge.Text & "'"
            conn.Execute(sql)
            MsgBox(" details deleted successfully", MsgBoxStyle.Information)
        ElseIf cmbstype.Text = "OUTSTORE" Then
            sql = "delete from tbl_outstore where date=convert(date,'" & dtpdate.Value & "',103)and incharge= '" & cmbincharge.Text & "'"
            conn.Execute(sql)
            MsgBox(" details deleted successfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub
End Class