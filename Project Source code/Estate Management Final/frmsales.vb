Public Class frmsales
    Public year, i As Integer
    Public A_QTY
    Public search As Boolean = False

   
    Sub clear()
        txtaqty.Clear()
        txtdesc.Clear()
        txtprice.Clear()
        txtqty.Clear()
        txtsold.Clear()
        txttotal.Clear()
        cmbcat.Text = ""
        cmbsubtype.Text = ""
    End Sub

    

   

    Private Sub frmsales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_year()
        load_sales()
    End Sub
    Sub load_sales()
        dgvsales.Rows.Clear()
        i = 0
        'sql = "select * from tbl_LogDetails where LogDate>convert(date,'" & d & "',103)"
        sql = "select  date,Subtype,Quantity_sold from tbl_sales where year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvsales.Rows.Add()
            dgvsales.Item(0, i).Value = rs(0).Value
            dgvsales.Item(1, i).Value = rs(1).Value
            dgvsales.Item(2, i).Value = rs(2).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub
    Sub load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            year = rs(0).Value
        End If
    End Sub

    

  

    

  
   
   
  

    Private Sub btnprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprod.Click
        btnprod.Enabled = False
        btnsales.Enabled = True
        frmproduction.MdiParent = frmmaster
        frmproduction.Show()
        Me.Close()
    End Sub

    Private Sub btnsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsales.Click
        btnsales.Enabled = False
        btnprod.Enabled = True
        'Panel1.Visible = True
    End Sub

   
   
    Private Sub cmbsubtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubtype.SelectedIndexChanged
        sql = "select * from tbl_stock where category='" & cmbcat.Text & "' and subtype='" & cmbsubtype.Text & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then

            txtaqty.Text = rs(2).Value
            A_QTY = rs(2).Value

        End If
    End Sub

 
   
    
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtaqty.Text = "" Or txtdesc.Text = "" Or txtprice.Text = "" Or txtqty.Text = "" Or txtsold.Text = "" Or txttotal.Text = "" Or cmbcat.Text = "" Or cmbsubtype.Text = "" Then
            MsgBox("Enter all the details", MsgBoxStyle.Information)
        Else
            sql = "insert into tbl_sales(date,Category,subtype,Quantity_sold,Price,Total_Amount,Sold_To,Description,Available_Qty,year)values(convert(date,'" & dtpdate.Value & "',103),'" & cmbcat.Text & "','" & cmbsubtype.Text & "','" & txtqty.Text & "','" & txtprice.Text & "','" & txttotal.Text & "','" & txtsold.Text & "','" & txtdesc.Text & "','" & txtaqty.Text & "','" & year & "')"
            conn.Execute(sql)
            sql = "update tbl_stock set Available_Qty='" & txtaqty.Text & "' where category='" & cmbcat.Text & "' and Subtype='" & cmbsubtype.Text & "'"
            conn.Execute(sql)
            MsgBox("Sales Added Successfully", MsgBoxStyle.Information)
            load_sales()
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If MsgBoxResult.No = MsgBox("Do you really want to delete the Record?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_sales where date=convert(char,'" & dgvsales.CurrentRow.Cells(0).Value & "',103) and Subtype='" & dgvsales.CurrentRow.Cells(1).Value & "' and Quantity_sold='" & dgvsales.CurrentRow.Cells(2).Value & "' and year='" & year & "'"
        conn.Execute(sql)
        MsgBox("Record deleted Successfully", MsgBoxStyle.Information)
        clear()
        load_sales()
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        txttotal.Text = Val(txtprice.Text) * Val(txtqty.Text)
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If search = False Then


            If Val(txtqty.Text) > Val(A_QTY) Then
                MsgBox("Stock Not Available", MsgBoxStyle.Information)
                txtqty.Clear()
            Else
                txtaqty.Text = Val(A_QTY) - Val(txtqty.Text)
            End If
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub dgvsales_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvsales.DoubleClick
        sql = "select * from tbl_sales where date=convert(char,'" & dgvsales.CurrentRow.Cells(0).Value & "',103) and Subtype='" & dgvsales.CurrentRow.Cells(1).Value & "' and Quantity_sold='" & dgvsales.CurrentRow.Cells(2).Value & "' and year='" & year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            search = True
            dtpdate.Value = rs(0).Value
            cmbcat.Text = rs(1).Value

            txtqty.Text = rs(3).Value
            txtprice.Text = rs(4).Value
            txttotal.Text = rs(5).Value
            txtsold.Text = rs(6).Value
            txtdesc.Text = rs(7).Value
            txtaqty.Text = rs(8).Value
            cmbsubtype.Text = rs(2).Value
            search = False
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
        Dim rpt As New sales
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmsalesreport.Text = "sales"
        'frmsalesreport.CrystalReportViewer1.ReportSource = rpt
        'frmsalesreport.CrystalReportViewer1.Refresh()
        'frmsalesreport.ShowDialog()
    End Sub
End Class