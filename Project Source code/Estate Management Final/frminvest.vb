Public Class frminvest
    Public gender, wname As String
    Public i As Integer = 0
    Public j As Integer = 0
    Public outamount As Integer = 0

    Private Sub frminvest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_year()
        btnadd.Enabled = True
        wrkinvstpanel.Visible = True
        sql = "select distinct(worker_description) from tbl_wrkassign where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            cmbwrkdes.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        j = 0

        sql = "select wrk_des,Total_invest from tbl_wrkinvest where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvinvest.Rows.Add()
            dgvinvest.Item(1, j).Value = rs(0).Value
            dgvinvest.Item(2, j).Value = rs(1).Value
            j = j + 1
            dgvinvest.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btnwinsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwinsave.Click
        If cmbwrkdes.Text = "" Or txtnw.Text = "" Or txtwd.Text = "" Or txtpd.Text = "" Or txtmanage.Text = "" Or txttinvest.Text = "" Then
            MsgBox("Please enter the Values", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_wrkinvest where wrk_des='" & cmbwrkdes.Text & "' and year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                sql = "insert into tbl_wrkinvest(wrk_des,no_wrkers,no_days,pay_day,manager,Total_invest,year)values('" & cmbwrkdes.Text & "','" & txtnw.Text & "','" & txtwd.Text & "','" & txtpd.Text & "','" & txtmanage.Text & "','" & txttinvest.Text & "','" & year & "')"
                conn.Execute(sql)
                MsgBox("Record Added Successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Record Already Added", MsgBoxStyle.Information)
            End If
           j = 0
            dgvinvest.Rows.Clear()
            sql = "select wrk_des,Total_invest from tbl_wrkinvest where year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Do While Not rs.EOF
                dgvinvest.Rows.Add()
                dgvinvest.Item(1, j).Value = rs(0).Value
                dgvinvest.Item(2, j).Value = rs(1).Value

                j = j + 1
                dgvinvest.Item(0, j - 1).Value = j
                rs.MoveNext()
            Loop
        End If
    End Sub

    Private Sub btnwindelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwindelete.Click
        sql = "delete from tbl_wrkinvest where wrk_des='" & cmbwrkdes.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        MsgBox("Record deleted successfully", MsgBoxStyle.Information)
        j = 0
        dgvinvest.Rows.Clear()
        sql = "select wrk_des,Total_invest from tbl_wrkinvest"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvinvest.Rows.Add()
            dgvinvest.Item(1, j).Value = rs(0).Value
            dgvinvest.Item(2, j).Value = rs(1).Value
            j = j + 1
            dgvinvest.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btnwinclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwinclear.Click
        cmbwrkdes.Text = ""
        txtnw.Clear()
        txtwd.Clear()
        txtpd.Clear()
        txtmanage.Clear()
        txttinvest.Clear()
        dgvoutsourse.Rows.Clear()
    End Sub

    Private Sub btnworkinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinfo.Click
        btnworkinfo.Enabled = False
        btnwrkassign.Enabled = True
        btnworkinvest.Enabled = True
        frmworkerinfo.MdiParent = frmmaster
        frmworkerinfo.Show()
        Me.Close()
    End Sub

    Private Sub btnwrkassign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwrkassign.Click
        btnworkinfo.Enabled = True
        btnwrkassign.Enabled = False
        btnworkinvest.Enabled = True
        frmassain.MdiParent = frmmaster
        frmassain.Show()
        Me.Close()
    End Sub

    Private Sub btnworkinvest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinvest.Click
        btnworkinfo.Enabled = True
        btnwrkassign.Enabled = True
        btnworkinvest.Enabled = False
        wrkinvstpanel.Visible = True
    End Sub

    Private Sub btnwincancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwincancel.Click
        Me.Close()
    End Sub

    Private Sub cmbwrkdes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbwrkdes.SelectedIndexChanged
        outamount = 0
        sql = "select * from tbl_wrkassign where worker_description='" & cmbwrkdes.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtnw.Text = rs(4).Value
            txtwd.Text = DateDiff(DateInterval.Day, rs(1).Value, rs(2).Value)
            If txtwd.Text = "0" Then
                txtwd.Text = "1"
            End If
            txtpd.Text = rs(7).Value
            txtmanage.Text = rs(6).Value

        End If
        i = 0
        dgvoutsourse.Rows.Clear()
        sql = "select * from tbl_outsource where work_des='" & cmbwrkdes.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvoutsourse.Rows.Add()
            dgvoutsourse.Item(0, i).Value = rs(2).Value
            dgvoutsourse.Item(1, i).Value = rs(3).Value
            outamount = outamount + Val(dgvoutsourse.Item(1, i).Value)
            rs.MoveNext()
            i = i + 1
        Loop

        txttinvest.Text = (Val(txtnw.Text) * Val(txtwd.Text) * Val(txtpd.Text)) + Val(outamount)
    End Sub

    Private Sub dgvinvest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvinvest.DoubleClick
        sql = "select * from tbl_wrkinvest where wrk_des='" & dgvinvest.CurrentRow.Cells(1).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then

            txtnw.Text = rs(1).Value
            txtwd.Text = rs(2).Value
            txtpd.Text = rs(3).Value
            txtmanage.Text = rs(4).Value
            txttinvest.Text = rs(5).Value
            cmbwrkdes.Text = rs(0).Value
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        sql = "select * from TBL_settings"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            server = rs(0).Value
            database = rs(1).Value
            user = rs(2).Value
            password = rs(3).Value
        End If
        Dim rpt As New workinvestments
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmwrkinvstreport.Text = "WORK INVESTMENTS"
        'frmwrkinvstreport.CrystalReportViewer1.ReportSource = rpt
        'frmwrkinvstreport.CrystalReportViewer1.Refresh()
        'frmwrkinvstreport.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub
End Class