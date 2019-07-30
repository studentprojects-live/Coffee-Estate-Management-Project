Public Class frmproduction
    Public year As Integer
  
    Sub clear()
        txtcarry.Clear()
        txtcharge.Clear()
        txtcname.Clear()
        txtcuring.Clear()
        txtdesc.Clear()
        dtpdate.Value = Today
        txtdry.Clear()

        txtfresh.Clear()
        txttotal.Clear()
    End Sub
 

    Private Sub frmproduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
        load_production()
    End Sub
    Sub load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            year = rs(0).Value
        End If
    End Sub

    Private Sub txtcuring_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txttotal.Text = Val(txtfresh.Text) + Val(txtdry.Text) + Val(txtcuring.Text) + Val(txtcarry.Text)
    End Sub
    Sub load_production()
        dgvpro.Rows.Clear()
        i = 0
        sql = "select PDATE,category,Qfresh,Qdry,Qcuring from tbl_production where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvpro.Rows.Add()
            dgvpro.Item(0, i).Value = rs(0).Value
            dgvpro.Item(1, i).Value = rs(1).Value
            dgvpro.Item(2, i).Value = rs(2).Value
            dgvpro.Item(3, i).Value = rs(3).Value
            dgvpro.Item(4, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

   
    
    Private Sub btnprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprod.Click
        Panel2.Visible = True
        btnprod.Enabled = False
        btnsales.Enabled = True
    End Sub

    Private Sub btnsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsales.Click
        btnsales.Enabled = True
        btnprod.Enabled = False
        frmsales.MdiParent = frmmaster
        frmsales.Show()
        Me.Close()
    End Sub

   

    Private Sub txtfresh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfresh.TextChanged
        If txtdry.Text <> "" And txtcuring.Text <> "" Then
            txttotal.Text = Val(txtfresh.Text) + Val(txtdry.Text) + Val(txtcuring.Text)
        End If
    End Sub

    Private Sub txtdry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdry.TextChanged
        If txtfresh.Text <> "" And txtcuring.Text <> "" Then
            txttotal.Text = Val(txtfresh.Text) + Val(txtdry.Text) + Val(txtcuring.Text)
        End If
    End Sub

    Private Sub txtcuring_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcuring.TextChanged
        If txtdry.Text <> "" And txtfresh.Text <> "" Then
            txttotal.Text = Val(txtfresh.Text) + Val(txtdry.Text) + Val(txtcuring.Text)
        End If
    End Sub

   
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtcarry.Text = "" Or txtcharge.Text = "" Or txtcname.Text = "" Or txtcuring.Text = "" Or txtdesc.Text = "" Or txtdry.Text = "" Or txtfresh.Text = "" Or txttotal.Text = "" Then
            MsgBox("Please Enter all the details", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_production where year='" & year & "' and category='" & cmbcat.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                sql = "insert into tbl_production(category,Qfresh,Qdry,Qcuring,Carryover,Cdesc,CCharge,year,pdate,cname)values('" & cmbcat.Text & "','" & txtfresh.Text & "','" & txtdry.Text & "','" & txtcuring.Text & "','" & txtcarry.Text & "','" & txtdesc.Text & "','" & txtcharge.Text & "','" & year & "',convert(date,'" & dtpdate.Value & "',103),'" & txtcname.Text & "')"
                conn.Execute(sql)
                sql = "insert into tbl_Stock(category,Subtype,Available_Qty,year)values('" & cmbcat.Text & "','Fresh','" & txtfresh.Text & "','" & year & "')"
                conn.Execute(sql)
                sql = "insert into tbl_Stock(category,Subtype,Available_Qty,year)values('" & cmbcat.Text & "','Dry','" & txtdry.Text & "','" & year & "')"
                conn.Execute(sql)
                sql = "insert into tbl_Stock(category,Subtype,Available_Qty,year)values('" & cmbcat.Text & "','Curing','" & txtcuring.Text & "','" & year & "')"
                conn.Execute(sql)
                MsgBox("Production Added Successfully", MsgBoxStyle.Information)

            Else
                sql = "update tbl_production set Qfresh='" & txtfresh.Text & "',Qdry='" & txtdry.Text & "',Qcuring='" & txtcuring.Text & "',Carryover='" & txtcarry.Text & "',Cdesc='" & txtdesc.Text & "',CCharge='" & txtcharge.Text & "',pdate=convert(date,'" & dtpdate.Value & "',103),CName='" & txtcname.Text & "' where category='" & cmbcat.Text & "' and year='" & year & "'"
                conn.Execute(sql)
                sql = "update tbl_stock set Available_Qty='" & txtfresh.Text & "' where Subtype='Fresh' and Category='" & cmbcat.Text & "' and year='" & year & "'"
                conn.Execute(sql)
                sql = "update tbl_stock set Available_Qty='" & txtdry.Text & "' where Subtype='Dry' and Category='" & cmbcat.Text & "' and year='" & year & "'"
                conn.Execute(sql)
                sql = "update tbl_stock set Available_Qty='" & txtcuring.Text & "' where Subtype='Curing' and Category='" & cmbcat.Text & "' and year='" & year & "'"
                conn.Execute(sql)
                MsgBox("Production Updated Successfully", MsgBoxStyle.Information)
            End If
            load_production()
        End If
    End Sub

   
   
    Private Sub cmbcat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcat.SelectedIndexChanged
        clear()
        sql = "select * from tbl_production where category='" & cmbcat.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtfresh.Text = rs(1).Value
            txtdry.Text = rs(2).Value
            txtcuring.Text = rs(3).Value
            txtcarry.Text = rs(4).Value
            txtdesc.Text = rs(5).Value
            txtcharge.Text = rs(6).Value
            dtpdate.Value = rs(8).Value
            txtcname.Text = rs(9).Value
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("Do you really want to delete the record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_production where category='" & cmbcat.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        sql = "delete from tbl_stock where category='" & cmbcat.Text & "' and year='" & year & "'"
        conn.Execute(sql)
        MsgBox("Record deleted Successfully", MsgBoxStyle.Information)
        load_production()
    End Sub

    Private Sub dgvpro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvpro.DoubleClick
        sql = "select * from tbl_production where category='" & dgvpro.CurrentRow.Cells(1).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then

            txtfresh.Text = rs(1).Value
            txtdry.Text = rs(2).Value
            txtcuring.Text = rs(3).Value
            txtcarry.Text = rs(4).Value
            txtdesc.Text = rs(5).Value
            txtcharge.Text = rs(6).Value
            dtpdate.Value = rs(8).Value
            txtcname.Text = rs(9).Value
            cmbcat.Text = rs(0).Value
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
        Dim rpt As New production
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmproductionreport.Text = "PRODUCTION"
        'frmproductionreport.CrystalReportViewer1.ReportSource = rpt
        'frmproductionreport.CrystalReportViewer1.Refresh()
        'frmproductionreport.ShowDialog()
    End Sub
End Class