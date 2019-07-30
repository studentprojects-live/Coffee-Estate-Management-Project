Public Class frmtools

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtaptool.Text = "" Or txtnotools.Text = "" Or txttname.Text = "" Or txttotalamt.Text = "" Then
            MsgBox("Please Enter Required Details", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "select * from tbl_etools where tool_name ='" & txttname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("invalid tool name", MsgBoxStyle.Information)
        Else
            sql = "insert into tbl_etools(year,tool_name,no_tools,amt_tools,date,total_amt)values('" & year & "','" & txtaptool.Text & "','" & txtnotools.Text & "','" & txttname.Text & "',convert(date,'" & dtptooldate.Value & "',103),'" & txttotalamt.Text & "')"
            conn.Execute(sql)
            MsgBox("Record Added Successfully")
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("do you want to delete the record ?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_etools where tool_Name='" & txttname.Text & "' and date= convert(date,'" & dtptooldate.Value & "',103"
        conn.Execute(sql)
        MsgBox("updated details deleted successfully", MsgBoxStyle.Information)
        Reset()
       
        'Dim frm As New frmworkers
        'frm.Show()
        'frm.Close()
        'frm = New frmworkers
        'frm.MdiParent = frmmaster
        'frm.Show()
        'Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        reset()
    End Sub
    Sub reset()
        txtaptool.Clear()
        txtnotools.Clear()
        txttname.Clear()
        txttotalamt.Clear()
        dgvtransport.Rows.Clear()
        dtptooldate.Value = Today
    End Sub

    Private Sub frmtools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_etools set no_tools='" & txtnotools.Text & "',total_amt='" & txttotalamt.Text & "',date=convert(date,'" & dtptooldate.Value & "',103),amt_tool='" & txtaptool.Text & "' where year='" & year & "' and tool_name='" & txttname.Text & "'"
        conn.Execute(sql)
        MsgBox("Record updated Successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

    End Sub
End Class