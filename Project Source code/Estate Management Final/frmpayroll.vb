Public Class frmpayroll
    Public year, i, total, wtotal, camt As Integer
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        dgvdetails.Rows.Clear()
        txtcredit.Clear()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtcredit.Text = "" Or txtinvest.Text = "" Or txtprofit.Text = "" Or txtsales.Text = "" Or txtwpay.Text = "" Then
            MsgBox("Please Enter all the Information", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_payroll where pdate=convert(date,'" & dtpdate.Value & "',103) and year='" & year & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "update tbl_payroll set worker_payroll='" & txtwpay.Text & "',investment='" & txtinvest.Text & "',sales='" & txtsales.Text & "',credits='" & txtcredit.Text & "',total_profit='" & txtprofit.Text & "' where pdate=convert(date,'" & dtpdate.Value & "',103) and year='" & year & "'"
                conn.Execute(sql)
                sql = "delete from tbl_credits where c_date=convert(date,'" & dtpdate.Value & "',103)"
                conn.Execute(sql)
                i = 0
                If dgvdetails.Rows.Count > 1 Then
                    For i = 0 To dgvdetails.Rows.Count - 1
                        sql = "insert into tbl_credits(year,c_date,c_name,amount)values('" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvdetails.Item(0, i).Value & "','" & dgvdetails.Item(1, i).Value & "')"
                        conn.Execute(sql)
                    Next
                End If
                MsgBox("Payroll Updates Successfully", MsgBoxStyle.Information)
            Else
                sql = "insert into tbl_payroll(year,pdate,worker_payroll,investment,sales,credits,total_profit)values('" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & txtwpay.Text & "','" & txtinvest.Text & "','" & txtsales.Text & "','" & txtcredit.Text & "','" & txtprofit.Text & "')"
                conn.Execute(sql)
                i = 0
                If dgvdetails.Rows.Count > 1 Then
                    For i = 0 To dgvdetails.Rows.Count - 1
                        sql = "insert into tbl_credits(year,c_date,c_name,amount)values('" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & dgvdetails.Item(0, i).Value & "','" & dgvdetails.Item(1, i).Value & "')"
                        conn.Execute(sql)
                        i = i + 1
                    Next
                End If

                MsgBox("Payroll Added Successfully", MsgBoxStyle.Information)
            End If
            load_payroll()
            End If
    End Sub
    Sub load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            year = rs(0).Value
        End If
    End Sub
    Sub load_payroll()
        dgvpayroll.Rows.Clear()
        i = 0
        sql = "select pdate,total_profit from tbl_payroll where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvpayroll.Rows.Add()
            dgvpayroll.Item(0, i).Value = rs(0).Value
            dgvpayroll.Item(1, i).Value = rs(1).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Private Sub frmpayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
        load_payroll()

        loadwrkpayroll()
        loadinvestments()
        loadsales()
    End Sub
    Sub loadwrkpayroll()
        wtotal = 0
        sql = "select sum(pay) from tbl_wrkassign where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            wtotal = wtotal + Val(rs(0).Value)
        End If
        sql = "select sum(total_amount) from tbl_coffeeclean where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                wtotal = wtotal + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(pay_worker*total_worker) from tbl_mannure where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            wtotal = wtotal + Val(rs(0).Value)
        End If
        txtwpay.Text = wtotal
    End Sub
    Sub loadinvestments()
        total = 0
      sql = "select sum(fuelamt) from tbl_ctools where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(total_amt) from tbl_etools where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(TotalAmt) from tbl_irrigation where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(quantity*price) from tbl_manuretype where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(amount) from tbl_outsource where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(quantity*price) from tbl_pesticide where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        sql = "select sum(total_amt) from tbl_transportation where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then
                total = total + Val(rs(0).Value)
            End If

        End If
        txtinvest.Text = total
    End Sub
    Sub loadsales()
        sql = "select sum(Total_Amount) from tbl_sales where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtsales.Text = rs(0).Value
        End If
    End Sub
    Private Sub dgvpayroll_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvpayroll.DoubleClick
        sql = "select * from tbl_payroll where pdate=convert(char,'" & dgvpayroll.CurrentRow.Cells(0).Value & "',103)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            dtpdate.Value = rs(1).Value
            txtwpay.Text = rs(2).Value
            txtinvest.Text = rs(3).Value
            txtsales.Text = rs(4).Value
            txtcredit.Text = rs(5).Value
            txtprofit.Text = rs(6).Value
        End If
        i = 0
        dgvdetails.Rows.Clear()
        sql = "select c_name,amount from tbl_credits where c_date=convert(char,'" & dgvpayroll.CurrentRow.Cells(0).Value & "',103)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvdetails.Rows.Clear()
            dgvdetails.Item(0, i).Value = rs(0).Value
            dgvdetails.Item(1, i).Value = rs(1).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you really want to delete the Record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_payroll where pdate=convert(date,'" & dtpdate.Value & "',103)"
        conn.Execute(sql)
        sql = "delete from tbl_credits where c_date=convert(date,'" & dtpdate.Value & "',103)"
        conn.Execute(sql)
        MsgBox("Record deleted succesfully", MsgBoxStyle.Information)
        load_payroll()
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        camt = 0
        If dgvdetails.Rows.Count > 1 Then
            For i = 0 To dgvdetails.Rows.Count - 1
                camt = camt + Val(dgvdetails.Item(1, i).Value)

            Next
        Else
            camt = 0
        End If
     
        txtprofit.Text = Val(txtsales.Text) - Val(txtwpay.Text) - Val(txtinvest.Text) - Val(txtcredit.Text) - Val(camt)
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
        Dim rpt As New payroll
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmpayrollreport.Text = "PAYROLL"
        'frmpayrollreport.CrystalReportViewer1.ReportSource = rpt
        'frmpayrollreport.CrystalReportViewer1.Refresh()
        'frmpayrollreport.ShowDialog()
    End Sub
End Class