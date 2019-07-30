Public Class frmassain
    Public gender, wname As String
    Public i As Integer = 0
    Public j As Integer = 0
    Public outamount
    Private Sub frmassain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_year()
        Panel3.Visible = True

        btnadd.Enabled = True

        lstall.Items.Clear()
        lstworkers.Items.Clear()
        workers()
        'lstall.DrawMode = DrawMode.OwnerDrawVariable
        'AddHandler lstall.DrawItem, AddressOf drawit
        workers1()
        j = 0
        dgvwrkassign.Rows.Clear()
        sql = "select worker_description,wfrom,wstatus from tbl_wrkassign  where year='" & year & "' group by worker_description,wfrom,wstatus"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvwrkassign.Rows.Add()
            dgvwrkassign.Item(1, j).Value = rs(0).Value
            dgvwrkassign.Item(2, j).Value = rs(1).Value
            dgvwrkassign.Item(3, j).Value = rs(2).Value
            j = j + 1
            dgvwrkassign.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
        'Dim left As Integer = 15
        'Dim top As Integer = 15
        'sql = "select distinct(worker_description) from tbl_wrkassign"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'While rs.EOF = False
        '    Dim btnwrk As New Button
        '    btnwrk.Name = "btnw" & i
        '    btnwrk.Text = rs(0).Value
        '    btnwrk.BackColor = Color.Yellow
        '    btnwrk.Top = top
        '    btnwrk.Left = left
        '    btnwrk.Width = 75
        '    btnwrk.Height = 50
        '    Me.Panel3.Controls.Add(btnwrk)
        '    If left > SplitContainer1.Width - 200 Then
        '        top = top + 100
        '        left = 15
        '        btnwrk.Top = top
        '        btnwrk.Left = left
        '    End If
        '    left = left + 100
        '    AddHandler btnwrk.Click, AddressOf Me.ClickButtonwrk
        '    i = i + 1
        '    rs.MoveNext()
        'End While
    End Sub
    Sub workers1()
        sql = "select l_name from tbl_workerInfo  where l_name not in(select distinct(wname) from tbl_wrkassign where wstatus='Pending' or wstatus='stopped' and year='" & year & "')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstall.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub workers()
        sql = "select distinct(wname) from tbl_wrkassign where wstatus='Pending' or wstatus='stopped' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            wname = rs(0).Value & "*"
            lstall.Items.Add(wname)
            j = j + 1
            rs.MoveNext()
        End While

    End Sub
    Sub drawit(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        e.DrawBackground()
        e.DrawFocusRectangle()
        If e.Index < j Then
            e.Graphics.DrawString(lstall.Items(e.Index), New Font("Microsoft sans serif", 10), Brushes.Red, e.Bounds.X, e.Bounds.Y)
        Else
            e.Graphics.DrawString(lstall.Items(e.Index), New Font("Microsoft sans serif", 10), Brushes.Black, e.Bounds.X, e.Bounds.Y)

        End If
    End Sub
    Private Sub ClickButtonwrk(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = CType(sender, Button)
    End Sub

    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        lstworkers.Items.Add(lstall.SelectedItem.ToString)
        cmbmanage.Items.Add(lstall.SelectedItem.ToString)
        lstall.Items.Remove(lstall.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        lstall.Items.Add(lstworkers.SelectedItem.ToString)
        cmbmanage.Items.Remove(lstworkers.SelectedItem.ToString)
        lstworkers.Items.Remove(lstworkers.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
    End Sub

    Private Sub btnwdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwdelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete the Record", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
        sql = "delete from tbl_wrkassign where worker_description='" & txtdes.Text & "' and wfrom=convert(char,'" & dtpfrom.Value & "',103) and wto=convert(char,'" & dtpto.Value & "',103) and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_tools where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_outsource where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
        conn.Execute(sql)
        MsgBox("Record deleted successfully", MsgBoxStyle.Information)
        clear()
        load_workassign()
    End Sub
    Sub clear()
        txtdes.Clear()
        txtnum.Clear()
        txtpay.Clear()
        cmbmanage.Text = ""
        cmbstatus.Text = ""
        lstworkers.Items.Clear()
        lstall.Items.Clear()
        dtpfrom.Value = Today
        dtpto.Value = Today
        dgvtools.Rows.Clear()
        dgvout.Rows.Clear()
        j = 0
        workers()
        workers1()

    End Sub

    Private Sub btnwclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwclear.Click
        txtdes.Clear()
        txtnum.Clear()
        txtpay.Clear()
        cmbmanage.Text = ""
        cmbstatus.Text = ""
        lstworkers.Items.Clear()
        lstall.Items.Clear()
        dtpfrom.Value = Today
        dtpto.Value = Today
        dgvtools.Rows.Clear()
        dgvout.Rows.Clear()
        j = 0
        workers()
        workers1()

    End Sub

    Private Sub btnsavewrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavewrk.Click
        If txtdes.Text = "" Or txtnum.Text = "" Or txtpay.Text = "" Then
            MsgBox(" enter appropriate values", MsgBoxStyle.Information)
        ElseIf lstworkers.Items.Count = 0 Then
            MsgBox("please select the workers", MsgBoxStyle.Information)
        Else
            sql = "delete from tbl_wrkassign where worker_description='" & txtdes.Text & "' and wfrom=convert(char,'" & dtpfrom.Value & "',103) and wto=convert(char,'" & dtpto.Value & "',103) and year='" & year & "'"
            conn.Execute(sql)
            For i = 0 To lstworkers.Items.Count - 1
                sql = "insert into tbl_wrkassign(worker_description,wfrom,wto,wname,no_workers,wstatus,manager,pay,year)values('" & txtdes.Text & "',convert(char,'" & dtpfrom.Value & "',103),convert(char,'" & dtpto.Value & "',103),'" & lstworkers.Items(i).ToString & "', '" & txtnum.Text & "','" & cmbstatus.Text & "','" & cmbmanage.Text & "','" & txtpay.Text & "','" & year & "')"
                conn.Execute(sql)
            Next
            sql = "delete from tbl_tools where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "' and year='" & year & "'"
            conn.Execute(sql)
            i = 0
            For i = 0 To dgvtools.Rows.Count - 2
                sql = " insert into tbl_tools(work_des,manager,tool_name,tool_count,year) values ('" & txtdes.Text & "', '" & cmbmanage.Text & "','" & dgvtools.Item(0, i).Value & "','" & dgvtools.Item(1, i).Value & "','" & year & "')"
                conn.Execute(sql)
            Next
            sql = "delete from tbl_outsource where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "' and year='" & year & "'"
            conn.Execute(sql)
            i = 0
            For i = 0 To dgvout.Rows.Count - 2
                sql = " insert into tbl_outsource(work_des,manager,Outsource,Amount,year) values ('" & txtdes.Text & "', '" & cmbmanage.Text & "','" & dgvout.Item(0, i).Value & "','" & dgvout.Item(1, i).Value & "','" & year & "')"
                conn.Execute(sql)
            Next
            MsgBox(" data saved successfully", MsgBoxStyle.Information)
            clear()
            load_workassign()
        End If
    End Sub

    Private Sub dgvwrkassign_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvwrkassign.DoubleClick
        sql = "select worker_description,wfrom,wto,no_workers,wstatus,manager,pay from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtdes.Text = rs(0).Value
            dtpfrom.Value = rs(1).Value
            dtpto.Value = rs(2).Value
            txtnum.Text = rs(3).Value
            cmbstatus.Text = rs(4).Value
            cmbmanage.Text = rs(5).Value
            txtpay.Text = rs(6).Value
        End If
        lstworkers.Items.Clear()
        sql = "select wname from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstworkers.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        lstall.Items.Clear()
        sql = "select l_name from tbl_workerInfo  where l_name not in(select wname from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "' and year='" & year & "')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstall.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        j = 0
        dgvout.Rows.Clear()
        sql = "select Outsource,Amount from tbl_outsource where work_des='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvout.Rows.Add()
            dgvout.Item(0, j).Value = rs(0).Value
            dgvout.Item(1, j).Value = rs(1).Value
            j = j + 1
            rs.MoveNext()
        Loop
        j = 0
        dgvtools.Rows.Clear()
        sql = "select tool_name,tool_count from tbl_tools where work_des='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and manager='" & cmbmanage.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvtools.Rows.Add()
            dgvtools.Item(0, j).Value = rs(0).Value
            dgvtools.Item(1, j).Value = rs(1).Value
            j = j + 1
            rs.MoveNext()
        Loop
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
        Panel3.Visible = True
        btnwrkassign.Enabled = False
        btnworkinfo.Enabled = True
        btnworkinvest.Enabled = True
    End Sub

    Private Sub btnworkinvest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinvest.Click
        btnworkinfo.Enabled = True
        btnwrkassign.Enabled = True
        btnworkinvest.Enabled = False
        frminvest.MdiParent = frmmaster
        frminvest.Show()
        Me.Close()
    End Sub
    Sub load_workassign()
        j = 0
        dgvwrkassign.Rows.Clear()
        sql = "select worker_description,wfrom,wstatus from tbl_wrkassign  where year='" & year & "' group by worker_description,wfrom,wstatus"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvwrkassign.Rows.Add()
            dgvwrkassign.Item(1, j).Value = rs(0).Value
            dgvwrkassign.Item(2, j).Value = rs(1).Value
            dgvwrkassign.Item(3, j).Value = rs(2).Value
            j = j + 1
            dgvwrkassign.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
    End Sub
    Private Sub btnwcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwcancel.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        sql = "select * from TBL_settings"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            Server = rs(0).Value
            Database = rs(1).Value
            User = rs(2).Value
            Password = rs(3).Value
        End If
        Dim rpt As New Wrkassignment
        rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
        rpt.DataSourceConnections.Item(0).SetLogon(User, Password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmwrkassignreport.Text = "WORK ASSIGNMENTS"
        'frmwrkassignreport.CrystalReportViewer1.ReportSource = rpt
        'frmwrkassignreport.CrystalReportViewer1.Refresh()
        'frmwrkassignreport.ShowDialog()
    End Sub

    Private Sub btnaddn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub
End Class