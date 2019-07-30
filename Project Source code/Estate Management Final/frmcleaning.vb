Public Class frmcleaning
    Public year As Integer
    Public i As Integer
    Private Sub btnclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclean.Click
        Panel1.Visible = True
        btnclean.Enabled = False
        btnirrigation.Enabled = True
        btnmanure.Enabled = True
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
        frmmanure.MdiParent = frmmaster
        frmmanure.Show()
        Me.Close()
    End Sub

    Private Sub btnmclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmclear.Click
        clear()
    End Sub
    Sub clear()
        txtnoworkers.Clear()
        txtnp.Clear()
        txtpkg.Clear()
        txtpp.Clear()
        txtqty.Clear()
        txtsetno.Clear()
        txttotal.Clear()
        dgvctrees.Rows.Clear()
        dgvgeneral.Rows.Clear()
        dgvtools.Rows.Clear()
        cmbincharge.Text = ""
        cmbcleaning.Text = ""
    End Sub
    Sub load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            Year = rs(0).Value
        End If
    End Sub
    Private Sub btnmsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmsave.Click
        If txtnoworkers.Text = "" Or txtsetno.Text = "" Or cmbcleaning.Text = "" Or cmbincharge.Text = "" Then
            MsgBox("Please Enter all the Information", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_cleaning where set_no='" & txtsetno.Text & "' and year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("SetNo Already Exist", MsgBoxStyle.Information)
            Else
                sql = "insert into tbl_cleaning(year,set_no,incharge,type,frmdate,todate,noworkers)values('" & year & "','" & txtsetno.Text & "','" & cmbincharge.Text & "','" & cmbcleaning.Text & "',convert(date,'" & dtpfrom.Value & "',103),convert(date,'" & dtpto.Value & "',103),'" & txtnoworkers.Text & "')"
                conn.Execute(sql)

                If cmbcleaning.Text = "Trees" Then
                    i = 0
                    For i = 0 To dgvctrees.Rows.Count - 2
                        sql = "insert into tbl_trees(year,set_no,type,count,amount)values('" & year & "','" & txtsetno.Text & "','" & dgvctrees.Item(0, i).Value & "','" & dgvctrees.Item(1, i).Value & "','" & dgvctrees.Item(2, i).Value & "')"
                        conn.Execute(sql)
                    Next
                ElseIf cmbcleaning.Text = "Coffee" Then
                    sql = "insert into tbl_coffeeclean(year,set_no,noplants,pay_plant,qty,pay_kg,total_amount)values('" & year & "','" & txtsetno.Text & "','" & txtnp.Text & "','" & txtpp.Text & "','" & txtqty.Text & "','" & txtpkg.Text & "','" & txttotal.Text & "')"
                    conn.Execute(sql)
                End If
                i = 0
                For i = 0 To dgvtools.Rows.Count - 2
                    sql = "insert into tbl_ctools(year,set_no,tooltype,toolno,fuel,fuelamt)values('" & year & "','" & txtsetno.Text & "','" & dgvtools.Item(0, i).Value & "','" & dgvtools.Item(1, i).Value & "','" & dgvtools.Item(2, i).Value & "','" & dgvtools.Item(3, i).Value & "')"
                    conn.Execute(sql)
                Next
                i = 0
                For i = 0 To dgvgeneral.Rows.Count - 2
                    sql = "insert into tbl_generalclean(year,set_no,cleantype,date,pay_day)values('" & year & "','" & txtsetno.Text & "','" & dgvgeneral.Item(0, i).Value & "',convert(date,'" & dgvgeneral.Item(1, i).Value & "',103),'" & dgvgeneral.Item(2, i).Value & "')"
                    conn.Execute(sql)
                Next
                MsgBox("Record Added Successfully", MsgBoxStyle.Information)
                load_cleaning()
            End If
        End If
    End Sub

    Private Sub frmcleaning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
        load_cleaning()
        workers()
    End Sub
    Sub workers()
        sql = "select l_name from tbl_workerInfo"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            cmbincharge.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Private Sub cmbcleaning_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcleaning.SelectedIndexChanged
        If cmbcleaning.Text = "Trees" Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        ElseIf cmbcleaning.Text = "Coffee" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub btnmupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmupdate.Click
        If txtnoworkers.Text = "" Or txtsetno.Text = "" Or cmbcleaning.Text = "" Or cmbincharge.Text = "" Then
            MsgBox("Please Enter all the Information", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_cleaning where set_no='" & txtsetno.Text & "' and year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "update tbl_cleaning set incharge='" & cmbincharge.Text & "',type='" & cmbcleaning.Text & "',frmdate=convert(date,'" & dtpfrom.Value & "',103),todate=convert(date,'" & dtpto.Value & "',103),noworkers='" & txtnoworkers.Text & "' where year='" & year & "' and set_no='" & txtsetno.Text & "'"
                conn.Execute(sql)
               
                If cmbcleaning.Text = "Trees" Then
                    sql = "delete from tbl_trees where year='" & year & "' and set_no='" & txtsetno.Text & "'"
                    conn.Execute(sql)
                    i = 0
                    For i = 0 To dgvctrees.Rows.Count - 2
                        sql = "insert into tbl_trees(year,set_no,type,count,amount)values('" & year & "','" & txtsetno.Text & "','" & dgvctrees.Item(0, i).Value & "','" & dgvctrees.Item(1, i).Value & "','" & dgvctrees.Item(2, i).Value & "')"
                        conn.Execute(sql)
                    Next
                ElseIf cmbcleaning.Text = "Coffee" Then
                    sql = "update tbl_coffeeclean set noplants='" & txtnp.Text & "',pay_plant='" & txtpp.Text & "',qty='" & txtqty.Text & "',pay_kg='" & txtpkg.Text & "',total_amount='" & txttotal.Text & "' where year='" & year & "' and set_no='" & txtsetno.Text & "'"
                    conn.Execute(sql)
                End If
                sql = "delete from tbl_ctools where year='" & year & "' and set_no='" & txtsetno.Text & "'"
                conn.Execute(sql)
                i = 0
                For i = 0 To dgvtools.Rows.Count - 2
                    sql = "insert into tbl_ctools(year,set_no,tooltype,toolno,fuel,fuelamt)values('" & year & "','" & txtsetno.Text & "','" & dgvtools.Item(0, i).Value & "','" & dgvtools.Item(1, i).Value & "','" & dgvtools.Item(2, i).Value & "','" & dgvtools.Item(3, i).Value & "')"
                    conn.Execute(sql)
                Next
                sql = "delete from tbl_generalclean where year='" & year & "' and set_no='" & txtsetno.Text & "'"
                conn.Execute(sql)
                i = 0
                For i = 0 To dgvgeneral.Rows.Count - 2
                    sql = "insert into tbl_generalclean(year,set_no,cleantype,date,pay_day)values('" & year & "','" & txtsetno.Text & "','" & dgvgeneral.Item(0, i).Value & "',convert(date,'" & dgvgeneral.Item(1, i).Value & "',103),'" & dgvgeneral.Item(2, i).Value & "')"
                    conn.Execute(sql)
                Next
                MsgBox("Record Added Successfully", MsgBoxStyle.Information)
                load_cleaning()
            End If
        End If
    End Sub

    Private Sub btnmdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmdelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete the Record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_cleaning where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_trees where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_ctools where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_generalclean where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_coffeeclean where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        conn.Execute(sql)
        MsgBox("Record deleted Successfully", MsgBoxStyle.Information)
        load_cleaning()
        clear()
    End Sub
    Sub load_cleaning()
        dgvclean.Rows.Clear()
        i = 0
        sql = "select set_no,incharge,type,frmdate from tbl_cleaning where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvclean.Rows.Add()
            dgvclean.Item(0, i).Value = rs(0).Value
            dgvclean.Item(1, i).Value = rs(1).Value
            dgvclean.Item(2, i).Value = rs(2).Value
            dgvclean.Item(3, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub dgvclean_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvclean.DoubleClick
        sql = "select * from tbl_cleaning where set_no='" & dgvclean.CurrentRow.Cells(0).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtsetno.Text = rs(1).Value
            cmbincharge.Text = rs(2).Value
            cmbcleaning.Text = rs(3).Value
            dtpfrom.Value = rs(4).Value
            dtpto.Value = rs(5).Value
            txtnoworkers.Text = rs(6).Value
        End If
        If cmbcleaning.Text = "Coffee" Then
            GroupBox2.Visible = True
            GroupBox1.Visible = False
            sql = "select * from tbl_coffeeclean where year='" & year & "' and set_no='" & txtsetno.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtnp.Text = rs(2).Value
                txtpp.Text = rs(3).Value
                txtqty.Text = rs(4).Value
                txtpkg.Text = rs(5).Value
                txttotal.Text = rs(6).Value
            End If
        ElseIf cmbcleaning.Text = "Trees" Then
            GroupBox2.Visible = False
            GroupBox1.Visible = True
            dgvctrees.Rows.Clear()
            i = 0
            sql = "select * from tbl_trees where year='" & year & "' and set_no='" & txtsetno.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Do While Not rs.EOF
                dgvctrees.Rows.Add()
                dgvctrees.Item(0, i).Value = rs(2).Value
                dgvctrees.Item(1, i).Value = rs(3).Value
                dgvctrees.Item(2, i).Value = rs(4).Value
                rs.MoveNext()
                i = i + 1
            Loop
        End If
        i = 0
        dgvgeneral.Rows.Clear()
        sql = "select * from tbl_generalclean where year='" & year & "' and set_no='" & txtsetno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvgeneral.Rows.Add()
            dgvgeneral.Item(0, i).Value = rs(2).Value
            dgvgeneral.Item(1, i).Value = rs(3).Value
            dgvgeneral.Item(2, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop
        i = 0
        dgvtools.Rows.Clear()
        sql = "select * from tbl_ctools where set_no='" & txtsetno.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvtools.Rows.Add()
            dgvtools.Item(0, i).Value = rs(2).Value
            dgvtools.Item(1, i).Value = rs(3).Value
            dgvtools.Item(2, i).Value = rs(4).Value
            dgvtools.Item(3, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub btnmcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmcancel.Click
        Me.Close()
    End Sub

    Private Sub btnmadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmadd.Click
        clear()
        sql = "select max(set_no)+1 from tbl_cleaning where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = True Then
                txtsetno.Text = "1"
            Else
                txtsetno.Text = rs(0).Value
            End If
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
        Dim rpt As New cleaning
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmcleaningreport.Text = "CLEANING"
        'frmcleaningreport.CrystalReportViewer1.ReportSource = rpt
        'frmcleaningreport.CrystalReportViewer1.Refresh()
        'frmcleaningreport.ShowDialog()
    End Sub
End Class