Public Class frmmanure

    Public year As Integer
    Public i As Integer
    Private Sub btnmclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmclear.Click
        clear()
        
       
    End Sub
    Sub clear()
        txtincharge.Text = ""

        txtmpay.Clear()

        txtqtyp.Clear()
        txtnowrkers.Clear()
        txtsno.Clear()
        dgvmtools.Rows.Clear()
        dgvmtype.Rows.Clear()
        dgvpest.Rows.Clear()
        dtpmfrom.Value = Today
        dtpmto.Value = Today
    End Sub
    Private Sub btnirrigation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnirrigation.Click
        btnirrigation.Enabled = False
        btnmanure.Enabled = True
        btnclean.Enabled = True
        frmmaintain.MdiParent = frmmaster
        frmmaintain.Show()
        Me.Close()
    End Sub

    Private Sub btnmanure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanure.Click
        btnirrigation.Enabled = True
        btnmanure.Enabled = False
        btnclean.Enabled = True
        pnlmanure.Visible = True

    End Sub

    Private Sub btnclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclean.Click
        btnirrigation.Enabled = True
        btnmanure.Enabled = True
        btnclean.Enabled = False
        frmcleaning.MdiParent = frmmaster
        frmcleaning.Show()
        Me.Close()
    End Sub

    Private Sub frmmanure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        workers()
        load_year()
        load_manuredetails()
    End Sub
    Sub load_manuredetails()
        dgvmdata.Rows.Clear()
        i = 0
        sql = "select set_no,frmdate,incharge from tbl_mannure where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvmdata.Rows.Add()
            dgvmdata.Item(0, i).Value = rs(0).Value
            dgvmdata.Item(1, i).Value = rs(1).Value
            dgvmdata.Item(2, i).Value = rs(2).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub workers()
        sql = "select l_name from tbl_workerInfo"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            txtincharge.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            year = rs(0).Value
        End If
    End Sub
    Private Sub btnmsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmsave.Click
        If txtincharge.Text = "" Or txtmpay.Text = "" Or txtnowrkers.Text = "" Or txtqtyp.Text = "" Or txtsno.Text = "" Then
            MsgBox("Please Enter all the details", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_mannure where set_no='" & txtsno.Text & "' and year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Set No Already Exist", MsgBoxStyle.Information)
            Else
                sql = "insert into tbl_mannure(year,set_no,incharge,frmdate,todate,pay_worker,total_worker,mannure_plant)values('" & year & "','" & txtsno.Text & "','" & txtincharge.Text & "',convert(date,'" & dtpmfrom.Value & "',103),convert(date,'" & dtpmto.Value & "',103),'" & txtmpay.Text & "','" & txtnowrkers.Text & "','" & txtqtyp.Text & "')"
                conn.Execute(sql)
                i = 0
                For i = 0 To dgvmtype.Rows.Count - 2
                    sql = "insert into tbl_manuretype(year,set_no,type,quantity,price)values('" & year & "','" & txtsno.Text & "','" & dgvmtype.Item(0, i).Value & "','" & dgvmtype.Item(1, i).Value & "','" & dgvmtype.Item(2, i).Value & "')"
                    conn.Execute(sql)
                Next
                i = 0
                For i = 0 To dgvpest.Rows.Count - 2
                    sql = "insert into tbl_pesticide(year,set_no,ptype,quantity,price)values('" & year & "','" & txtsno.Text & "','" & dgvpest.Item(0, i).Value & "','" & dgvpest.Item(1, i).Value & "','" & dgvpest.Item(2, i).Value & "')"
                    conn.Execute(sql)
                Next
                i = 0
                For i = 0 To dgvmtools.Rows.Count - 2
                    sql = "insert into tbl_mtools(year,set_no,toolname,qty)values('" & year & "','" & txtsno.Text & "','" & dgvmtools.Item(0, i).Value & "','" & dgvmtools.Item(1, i).Value & "')"
                    conn.Execute(sql)
                Next
                MsgBox("Record Added Successfully", MsgBoxStyle.Information)
                load_manuredetails()
            End If
        End If
    End Sub

    Private Sub dgvmdata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvmdata.DoubleClick
        sql = "select * from tbl_mannure where set_no='" & dgvmdata.CurrentRow.Cells(0).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtsno.Text = rs(1).Value
            txtincharge.Text = rs(2).Value
            dtpmfrom.Value = rs(3).Value
            dtpmto.Value = rs(4).Value
            txtmpay.Text = rs(5).Value
            txtnowrkers.Text = rs(6).Value
            txtqtyp.Text = rs(7).Value
        End If
        dgvmtype.Rows.Clear()
        i = 0
        sql = "select * from tbl_manuretype where year='" & year & "' and set_no='" & dgvmdata.CurrentRow.Cells(0).Value & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvmtype.Rows.Add()
            dgvmtype.Item(0, i).Value = rs(2).Value
            dgvmtype.Item(1, i).Value = rs(3).Value
            dgvmtype.Item(2, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop
        i = 0
        dgvpest.Rows.Clear()
        sql = "select * from tbl_pesticide where year='" & year & "' and set_no='" & txtsno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvpest.Rows.Add()
            dgvpest.Item(0, i).Value = rs(2).Value
            dgvpest.Item(1, i).Value = rs(3).Value
            dgvpest.Item(2, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop
        i = 0
        dgvmtools.Rows.Clear()
        sql = "select * from tbl_mtools where year='" & year & "' and set_no='" & txtsno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvmtools.Rows.Add()
            dgvmtools.Item(0, i).Value = rs(2).Value
            dgvmtools.Item(1, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub btnmdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmdelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete the Record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_mannure where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_manuretype where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_pesticide where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_mtools where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        MsgBox("Record deleted Successfully", MsgBoxStyle.Information)
        load_manuredetails()
        clear()
    End Sub

    Private Sub btnmupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmupdate.Click
        sql = "update tbl_mannure set incharge='" & txtincharge.Text & "',frmdate=convert(date,'" & dtpmfrom.Value & "',103),todate=convert(date,'" & dtpmto.Value & "',103),pay_worker='" & txtmpay.Text & "',total_worker='" & txtnowrkers.Text & "',mannure_plant='" & txtqtyp.Text & "' where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_manuretype where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        i = 0
        For i = 0 To dgvmtype.Rows.Count - 2
            sql = "insert into tbl_manuretype(year,set_no,type,quantity,price)values('" & year & "','" & txtsno.Text & "','" & dgvmtype.Item(0, i).Value & "','" & dgvmtype.Item(1, i).Value & "','" & dgvmtype.Item(2, i).Value & "')"
            conn.Execute(sql)
        Next
        sql = "delete from tbl_pesticide where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        i = 0
        For i = 0 To dgvpest.Rows.Count - 2
            sql = "insert into tbl_pesticide(year,set_no,ptype,quantity,price)values('" & year & "','" & txtsno.Text & "','" & dgvpest.Item(0, i).Value & "','" & dgvpest.Item(1, i).Value & "','" & dgvpest.Item(2, i).Value & "')"
            conn.Execute(sql)
        Next
        sql = "delete from tbl_mtools where set_no='" & txtsno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        i = 0
        For i = 0 To dgvmtools.Rows.Count - 2
            sql = "insert into tbl_mtools(year,set_no,toolname,qty)values('" & year & "','" & txtsno.Text & "','" & dgvmtools.Item(0, i).Value & "','" & dgvmtools.Item(1, i).Value & "')"
            conn.Execute(sql)
        Next
        MsgBox("Record Updated Successfully", MsgBoxStyle.Information)
        load_manuredetails()
    End Sub

    Private Sub btnmcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmcancel.Click
        Me.Close()
    End Sub

    Private Sub btnmadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmadd.Click
        clear()
        sql = "select max(set_no)+1 from tbl_mannure where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = True Then
                txtsno.Text = "1"
            Else
                txtsno.Text = rs(0).Value
            End If
        End If
    End Sub

    Private Sub btnmprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmprint.Click
        sql = "select * from TBL_settings"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            server = rs(0).Value
            database = rs(1).Value
            user = rs(2).Value
            password = rs(3).Value
        End If
        Dim rpt As New manure
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmmanurereport.Text = "MANURE"
        'frmmanurereport.CrystalReportViewer1.ReportSource = rpt
        'frmmanurereport.CrystalReportViewer1.Refresh()
        'frmmanurereport.ShowDialog()
    End Sub
End Class