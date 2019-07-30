Public Class frmmaintain
    Public i As Integer = 0
   Private Sub btnmclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmclear.Click
        txtfamtl.Clear()
        txtfquantity.Clear()
        txtftamt.Clear()
        txtinchar.Clear()
        txtincharge.Text = ""
        txtmpay.Clear()
        txtpno.Clear()
        txtqtyp.Clear()
        txtsetno.Clear()
        txtsno.Clear()
        cmbftype.Text = ""
        cmbpsize.Text = ""
        cmbptype.Text = ""
        dgvdata.Rows.Clear()
        'dgvmdata.Rows.Clear()
        dgvmtools.Rows.Clear()
        dgvmtype.Rows.Clear()
        dgvrdata.Rows.Clear()
        dgvsdata.Rows.Clear()
        dtpmfrom.Value = Today
        dtpmto.Value = Today
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Sub clear()
        txtfamtl.Clear()
        txtfquantity.Clear()
        txtftamt.Clear()
        txtinchar.Clear()
        txtincharge.Text = ""
        txtmpay.Clear()
        txtpno.Clear()
        txtqtyp.Clear()
        txtsetno.Clear()
        txtsno.Clear()
        cmbftype.Text = ""
        cmbpsize.Text = ""
        cmbptype.Text = ""
        cmbshift.Text = ""
        txtrnshift.Clear()
        dgvsdata.Rows.Clear()
        dtpfrom.Value = Today
        dtpto.Value = Today
    End Sub

    Private Sub frmmaintain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        workers()
        load_year()
        load_Irrigation()
        load_rain()
    End Sub
    Sub load_rain()
        dgvrdata.Rows.Clear()
        i = 0
        sql = "select * from tbl_rain where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvrdata.Rows.Add()
            dgvrdata.Item(0, i).Value = rs(0).Value
            dgvrdata.Item(1, i).Value = rs(1).Value
            dgvrdata.Item(2, i).Value = rs(2).Value
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

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "select max(set_no)+1 from tbl_irrigation where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = True Then
                txtsetno.Text = "1"
            Else
                txtsetno.Text = rs(0).Value
            End If
        End If
        txtfamtl.Clear()
        txtfquantity.Clear()
        txtftamt.Clear()
        txtinchar.Clear()
        txtincharge.Text = ""
        txtmpay.Clear()
        txtpno.Clear()
        txtqtyp.Clear()

        txtsno.Clear()
        cmbftype.Text = ""
        cmbpsize.Text = ""
        cmbptype.Text = ""
        cmbshift.Text = ""
        txtrnshift.Clear()
        'dgvdata.Rows.Clear()
        'dgvmdata.Rows.Clear()

        dgvsdata.Rows.Clear()
        dtpfrom.Value = Today
        dtpto.Value = Today
    End Sub

    Private Sub btnirrigation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnirrigation.Click
        pnlirrigate.Visible = True
        btnirrigation.Enabled = False
        btnmanure.Enabled = True
        btnclean.Enabled = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtsetno.Text = "" Or txtincharge.Text = "" Or cmbftype.Text = "" Or txtfquantity.Text = "" Or txtfamtl.Text = "" Or txtftamt.Text = "" Or cmbptype.Text = "" Or cmbpsize.Text = "" Or txtpno.Text = "" Or cmbshift.Text = "" Or txtrnshift.Text = "" Then
            MsgBox("Please Enter Required Details", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "select * from tbl_irrigation where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("SetNo Already Exist", MsgBoxStyle.Information)
        Else
            sql = "insert into tbl_irrigation(set_no,Incharge,Fromdate,Todate,FuelType,Quantity,Amount,TotalAmt,PipeType,Pipesize,No_Pipes,ShiftType,No_Shifts,year)values('" & txtsetno.Text & "','" & txtincharge.Text & "',convert(date,'" & dtpfrom.Value & "',103),convert(date,'" & dtpto.Value & "',103),'" & cmbftype.Text & "','" & txtfquantity.Text & "','" & txtfamtl.Text & "','" & txtftamt.Text & "','" & cmbptype.Text & "','" & cmbpsize.Text & "','" & txtpno.Text & "','" & cmbshift.Text & "','" & txtrnshift.Text & "','" & year & "')"
            conn.Execute(sql)
            For i = 0 To dgvsdata.Rows.Count - 2
                sql = "insert into tbl_sprinkler(set_No,stype,No_sprinklers,year)values('" & txtsetno.Text & "','" & dgvsdata.Item(0, i).Value & "','" & dgvsdata.Item(1, i).Value & "','" & year & "')"
                conn.Execute(sql)
            Next
            sql = "delete from tbl_rain where year='" & year & "'"
            conn.Execute(sql)
            For i = 0 To dgvrdata.Rows.Count - 2
                sql = "insert into tbl_rain(rdate,rinch,rcents,year)values(convert(char,'" & dgvrdata.Item(0, i).Value & "',103),'" & dgvrdata.Item(1, i).Value & "','" & dgvrdata.Item(2, i).Value & "','" & year & "')"
                conn.Execute(sql)
            Next
            MsgBox("Record Added Successfully")
            load_Irrigation()
            load_rain()
        End If
    End Sub

 
    Private Sub btnmanure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanure.Click
        btnirrigation.Enabled = True
        btnmanure.Enabled = False
        btnclean.Enabled = True
        frmmanure.MdiParent = frmmaster
        frmmanure.Show()
        Me.Close()
    End Sub

    Private Sub btnclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclean.Click
        btnirrigation.Enabled = True
        btnmanure.Enabled = True
        btnclean.Enabled = False
        frmcleaning.MdiParent = frmmaster
        frmcleaning.Show()
        Me.Close()
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtfamtl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfamtl.TextChanged
        txtftamt.Text = Val(txtfquantity.Text) * Val(txtfamtl.Text)
    End Sub
    Sub load_Irrigation()
        dgvdata.Rows.Clear()
        i = 0
        sql = "select set_no,Fromdate,Incharge from tbl_irrigation where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvdata.Rows.Add()
            dgvdata.Item(0, i).Value = rs(0).Value
            dgvdata.Item(1, i).Value = rs(1).Value
            dgvdata.Item(2, i).Value = rs(2).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub dgvdata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvdata.DoubleClick
        sql = "select * from tbl_irrigation where set_no='" & dgvdata.CurrentRow.Cells(0).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtsetno.Text = rs(0).Value
            txtincharge.Text = rs(1).Value
            dtpfrom.Value = rs(2).Value
            dtpto.Value = rs(3).Value
            cmbftype.Text = rs(4).Value
            txtfquantity.Text = rs(5).Value
            txtfamtl.Text = rs(6).Value
            txtftamt.Text = rs(7).Value
            cmbptype.Text = rs(8).Value
            cmbpsize.Text = rs(9).Value
            txtpno.Text = rs(10).Value
            cmbshift.Text = rs(11).Value
            txtrnshift.Text = rs(12).Value
        End If
        dgvsdata.Rows.Clear()
        i = 0
        sql = "select * from tbl_sprinkler where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvsdata.Rows.Add()
            dgvsdata.Item(0, i).Value = rs(1).Value
            dgvsdata.Item(1, i).Value = rs(2).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you really want to delete the Record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_irrigation where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_sprinkler where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        MsgBox("Record Deleted Successfully", MsgBoxStyle.Information)
        clear()
        load_Irrigation()
        load_rain()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_irrigation set Incharge='" & txtincharge.Text & "',Fromdate=convert(date,'" & dtpfrom.Value & "',103),Todate=convert(date,'" & dtpto.Value & "',103),FuelType='" & cmbftype.Text & "',Quantity='" & txtfquantity.Text & "',Amount='" & txtfamtl.Text & "',TotalAmt='" & txtftamt.Text & "',PipeType='" & cmbptype.Text & "',pipesize='" & cmbpsize.Text & "',No_Pipes='" & txtpno.Text & "',ShiftType='" & cmbshift.Text & "',No_Shifts='" & txtrnshift.Text & "' where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_sprinkler where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        For i = 0 To dgvsdata.Rows.Count - 2
            sql = "insert into tbl_sprinkler(set_No,stype,No_sprinklers,year)values('" & txtsetno.Text & "','" & dgvsdata.Item(0, i).Value & "','" & dgvsdata.Item(1, i).Value & "','" & year & "')"
            conn.Execute(sql)
        Next
        MsgBox("Record Updated Successfully", MsgBoxStyle.Information)
        clear()
        load_Irrigation()
        load_rain()
    End Sub

    Private Sub txtfquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfquantity.TextChanged
        If txtfamtl.Text <> "" Then
            txtftamt.Text = Val(txtfquantity.Text) * Val(txtfamtl.Text)
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        sql = "select * from TBL_settings"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            server = rs(0).Value
            database = rs(1).Value
            user = rs(2).Value
            password = rs(3).Value
        End If
        Dim rpt As New irrigation
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmirreport.Text = "IRRIGATION"
        'frmirreport.CrystalReportViewer1.ReportSource = rpt
        'frmirreport.CrystalReportViewer1.Refresh()
        'frmirreport.ShowDialog()
    End Sub
End Class