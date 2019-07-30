Public Class frmworkers
    Public gender, wname As String
    Public i As Integer = 0
    Public j As Integer = 0
    Public outamount
    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        With Me.OpenFileDialog1
            .Filter = "All Files|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                wrkerpic.ImageLocation = .FileName
            End If
        End With
    End Sub

    Private Sub btnworkinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinfo.Click
        Panel2.Visible = True
        Panel3.Visible = False
        'Panel1.Visible = False
        btnadd.Enabled = True
        btnsave.Enabled = True
        j = 0
        sql = "select L_Name,Age from tbl_workerInfo"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvworkers.Rows.Add()
            dgvworkers.Item(1, j).Value = rs(0).Value
            dgvworkers.Item(2, j).Value = rs(1).Value
            j = j + 1
            dgvworkers.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
        'Dim left As Integer = 15
        'Dim top As Integer = 15
        'sql = "select L_Name from tbl_workerInfo"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'While rs.EOF = False
        '    Dim btnwrker As New Button
        '    btnwrker.Name = "btnw" & i
        '    btnwrker.Text = rs(0).Value
        '    btnwrker.BackColor = Color.Yellow
        '    btnwrker.Top = top
        '    btnwrker.Left = left
        '    btnwrker.Width = 75
        '    btnwrker.Height = 50
        '    Me.SplitContainer1.Panel2.Controls.Add(btnwrker)
        '    If left > SplitContainer1.Width - 200 Then
        '        top = top + 100
        '        left = 15
        '        btnwrker.Top = top
        '        btnwrker.Left = left
        '    End If
        '    left = left + 100
        '    AddHandler btnwrker.Click, AddressOf Me.ClickButton
        '    i = i + 1
        '    rs.MoveNext()
        'End While
    End Sub
    'Private Sub ClickButton(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim btn As Button = CType(sender, Button)
    '    Panel2.Visible = True
    '    Panel1.Visible = True
    '    sql = "select * from tbl_workerInfo where L_Name='" & btn.Text & "'"
    '    If rs.State = 1 Then rs.Close()
    '    rs.Open(sql, conn)
    '    If rs.EOF = False Then
    '        txtname.Text = rs(0).Value
    '        txtage.Text = rs(1).Value
    '        If rs(2).Value = rdbmale.Text Then
    '            rdbmale.Checked = True
    '        ElseIf rs(2).Value = rdbfemale.Text Then
    '            rdbfemale.Checked = True
    '        End If
    '        txtaddress.Text = rs(3).Value
    '        txtbal.Text = rs(4).Value
    '        txtbeneficials.Text = rs(5).Value
    '        dtpdoj.Value = rs(6).Value
    '        wrkerpic.ImageLocation = rs(7).Value
    '        cmbcategory.Text = rs(8).Value
    '        txtdocument.Text = rs(9).Value
    '    End If
    'End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Visible = True
        Panel1.Visible = True
        Panel3.Visible = False
        wrkinvstpanel.Visible = False
        btnsave.Enabled = True
        btnadd.Enabled = False
        reset()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtaddress.Text = "" Or txtage.Text = "" Or txtbal.Text = "" Or txtdocument.Text = "" Or txtname.Text = "" Or wrkerpic.ImageLocation = "" Or cmbcategory.Text = "" Then
            MsgBox("please enter the appropriate values", MsgBoxStyle.Information)
        Else
            If rdbmale.Checked = True Then
                gender = rdbmale.Text
            ElseIf rdbfemale.Checked = True Then
                gender = rdbfemale.Text
            End If
            sql = "select * from tbl_workerInfo where L_Name='" & txtname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                sql = "insert into tbl_workerInfo(L_Name,Age,Sex,Address,Balance,Beneficials,DOJ,Photo,Category,Documents,last_name,contact)values('" & txtname.Text & "','" & txtage.Text & "','" & gender & "', '" & txtaddress.Text & "','" & txtbal.Text & "', '" & txtbeneficials.Text & "',convert(date,'" & dtpdoj.Value & "',103),'" & wrkerpic.ImageLocation & "','" & cmbcategory.Text & "','" & txtdocument.Text & "','" & txtlname.Text & "','" & txtcontact.Text & "')"
                conn.Execute(sql)
                MsgBox("worker information added successfully", MsgBoxStyle.Information)
                reset()
                Panel1.Visible = False
                Panel2.Visible = False
                btnadd.Enabled = True
                btnsave.Enabled = False
            Else
                If MsgBoxResult.No = MsgBox("Do you want to Update the Record?", MsgBoxStyle.YesNo) Then Exit Sub
                sql = "update tbl_workerInfo set L_Name='" & txtname.Text & "',age='" & txtage.Text & "', sex='" & gender & "', address='" & txtaddress.Text & "', balance= '" & txtbal.Text & "',beneficials='" & txtbeneficials.Text & "',doj=convert(date,'" & dtpdoj.Value & "',103),photo='" & wrkerpic.ImageLocation & "', category='" & cmbcategory.Text & "',documents='" & txtdocument.Text & "' where L_Name='" & txtname.Text & "'"
                conn.Execute(sql)
                MsgBox("worker information updated successfully", MsgBoxStyle.Information)
                reset()
                j = 0
                dgvworkers.Rows.Clear()
                sql = "select L_Name,Age from tbl_workerInfo"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                Do While Not rs.EOF
                    dgvworkers.Rows.Add()
                    dgvworkers.Item(1, j).Value = rs(0).Value
                    dgvworkers.Item(2, j).Value = rs(1).Value
                    j = j + 1
                    dgvworkers.Item(0, j - 1).Value = j
                    rs.MoveNext()
                Loop
            End If
        End If
    End Sub
    Sub reset()
        txtaddress.Clear()
        txtage.Clear()
        txtbal.Clear()
        txtbeneficials.Clear()
        txtdocument.Clear()
        txtname.Clear()
        txtlname.Clear()
        txtcontact.Clear()
        wrkerpic.ImageLocation = ""
        cmbcategory.Text = ""
        rdbmale.Checked = False
        rdbfemale.Checked = False
    End Sub
    
  
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If MsgBoxResult.No = MsgBox("do you want to delete the record ?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_workerInfo where L_Name='" & txtname.Text & "'"
        conn.Execute(sql)
        MsgBox("worker details deleted successfully", MsgBoxStyle.Information)
        reset()
        j = 0
        dgvworkers.Rows.Clear()
        sql = "select L_Name,Age from tbl_workerInfo"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvworkers.Rows.Add()
            dgvworkers.Item(1, j).Value = rs(0).Value
            dgvworkers.Item(2, j).Value = rs(1).Value
            j = j + 1
            dgvworkers.Item(0, j - 1).Value = j
            rs.MoveNext()
        Loop
        'Dim frm As New frmworkers
        'frm.Show()
        'frm.Close()
        'frm = New frmworkers
        'frm.MdiParent = frmmaster
        'frm.Show()
        'Me.Close()
    End Sub

    Private Sub btnwrkassign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwrkassign.Click
        Panel2.Visible = True
        Panel3.Visible = True
        wrkinvstpanel.Visible = False
        btnadd.Enabled = True
        btnsave.Enabled = True
        lstall.Items.Clear()
        lstworkers.Items.Clear()
        workers()
        'lstall.DrawMode = DrawMode.OwnerDrawVariable
        'AddHandler lstall.DrawItem, AddressOf drawit
        workers1()
        j = 0
        dgvwrkassign.Rows.Clear()
        sql = "select worker_description,wfrom,wstatus from tbl_wrkassign group by worker_description,wfrom,wstatus"
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
        sql = "select l_name from tbl_workerInfo  where l_name not in(select wname from tbl_wrkassign where wstatus='Pending' or wstatus='stopped')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstall.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub
    Sub workers()
        sql = "select wname from tbl_wrkassign where wstatus='Pending' or wstatus='stopped'"
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

    Private Sub btnaddwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Visible = True
        Panel3.Visible = True
        wrkinvstpanel.Visible = False
        btnadd.Enabled = True
        btnsave.Enabled = True
        lstall.Items.Clear()
        lstworkers.Items.Clear()
        workers()

        workers1()
        j = 0
        dgvwrkassign.Rows.Clear()
        sql = "select worker_description,wfrom,wstatus from tbl_wrkassign group by worker_description,wfrom,wstatus"
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

    Private Sub dgvworkers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvworkers.DoubleClick
        sql = "select L_Name,Age,Sex,Address,Balance,Beneficials,DOJ,Photo,Category,Documents,last_name,contact from tbl_workerInfo where L_Name='" & dgvworkers.CurrentRow.Cells(1).Value & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtname.Text = rs(0).Value
            txtage.Text = rs(1).Value
            If rs(2).Value = rdbmale.Text Then
                rdbmale.Checked = True
            ElseIf rs(2).Value = rdbfemale.Text Then
                rdbfemale.Checked = True
            End If
            txtaddress.Text = rs(3).Value
            txtbal.Text = rs(4).Value
            txtbeneficials.Text = rs(5).Value
            dtpdoj.Value = rs(6).Value
            wrkerpic.ImageLocation = rs(7).Value
            cmbcategory.Text = rs(8).Value
            txtdocument.Text = rs(9).Value
            txtlname.Text = rs(10).Value
          txtcontact.Text = rs(11).Value
        End If
    End Sub

    Private Sub frmworkers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

 
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        reset()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Panel2.Visible = False
    End Sub

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        lstworkers.Items.Add(lstall.SelectedItem.ToString)
        cmbmanage.Items.Add(lstall.SelectedItem.ToString)
        lstall.Items.Remove(lstall.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
        'lstall.Items.Clear()
        'j = 0
        'workers()
        'workers1()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        lstall.Items.Add(lstworkers.SelectedItem.ToString)
        cmbmanage.Items.Remove(lstworkers.SelectedItem.ToString)
        lstworkers.Items.Remove(lstworkers.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
    End Sub

   
    Private Sub btnsavewrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavewrk.Click
        If txtdes.Text = "" Or txtnum.Text = "" Or txtpay.Text = "" Then
            MsgBox(" enter appropriate values", MsgBoxStyle.Information)
        ElseIf lstworkers.Items.Count = 0 Then
            MsgBox("please select the workers", MsgBoxStyle.Information)
        Else
            sql = "delete from tbl_wrkassign where worker_description='" & txtdes.Text & "' and wfrom=convert(date,'" & dtpfrom.Value & "',103) and wto=convert(date,'" & dtpto.Value & "',103)"
            conn.Execute(sql)
            For i = 0 To lstworkers.Items.Count - 1
                sql = "insert into tbl_wrkassign(worker_description,wfrom,wto,wname,no_workers,wstatus,manager,pay)values('" & txtdes.Text & "',convert(date,'" & dtpfrom.Value & "',103),convert(date,'" & dtpto.Value & "',103),'" & lstworkers.Items(i).ToString & "', '" & txtnum.Text & "','" & cmbstatus.Text & "','" & cmbmanage.Text & "','" & txtpay.Text & "')"
                conn.Execute(sql)
            Next
            sql = "delete from tbl_tools where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
            conn.Execute(sql)
            i = 0
            For i = 0 To dgvtools.Rows.Count - 2
                sql = " insert into tbl_tools(work_des,manager,tool_name,tool_count) values ('" & txtdes.Text & "', '" & cmbmanage.Text & "','" & dgvtools.Item(0, i).Value & "','" & dgvtools.Item(1, i).Value & "')"
                conn.Execute(sql)
            Next
            sql = "delete from tbl_outsource where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
            conn.Execute(sql)
            i = 0
            For i = 0 To dgvout.Rows.Count - 2
                sql = " insert into tbl_outsource(work_des,manager,Outsource,Amount) values ('" & txtdes.Text & "', '" & cmbmanage.Text & "','" & dgvout.Item(0, i).Value & "','" & dgvout.Item(1, i).Value & "')"
                conn.Execute(sql)
            Next
            MsgBox(" data saved successfully", MsgBoxStyle.Information)
            clear()
        End If
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

   
    Private Sub dgvwrkassign_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvwrkassign.DoubleClick
        sql = "select worker_description,wfrom,wto,no_workers,wstatus,manager,pay from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "'"
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
        sql = "select wname from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstworkers.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        lstall.Items.Clear()
        sql = "select l_name from tbl_workerInfo  where l_name not in(select wname from tbl_wrkassign where worker_description='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and wfrom='" & dgvwrkassign.CurrentRow.Cells(2).Value & "' and wstatus='" & dgvwrkassign.CurrentRow.Cells(3).Value & "')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            lstall.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        j = 0
        sql = "select Outsource,Amount from tbl_outsource where work_des='" & dgvwrkassign.CurrentRow.Cells(1).Value & "'"
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
        sql = "select tool_name,tool_count from tbl_tools where work_des='" & dgvwrkassign.CurrentRow.Cells(1).Value & "' and manager='" & cmbmanage.Text & "'"
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

    
    Private Sub btnwdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwdelete.Click
        If MsgBoxResult.No = MsgBox("Do you want to delete the Record", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
        sql = "delete from tbl_wrkassign where worker_description='" & txtdes.Text & "' and wfrom=convert(date,'" & dtpfrom.Value & "',103) and wto=convert(date,'" & dtpto.Value & "',103)"
        conn.Execute(sql)
        sql = "delete from tbl_tools where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
        conn.Execute(sql)
        sql = "delete from tbl_outsource where work_des='" & txtdes.Text & "' and manager='" & cmbmanage.Text & "'"
        conn.Execute(sql)
        MsgBox("Record deleted successfully", MsgBoxStyle.Information)
        clear()
    End Sub

  
    Private Sub btnwcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwcancel.Click
        Panel3.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub btnworkinvest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinvest.Click
        Panel3.Visible = True
        Panel2.Visible = True
        btnadd.Enabled = True
        wrkinvstpanel.Visible = True
        sql = "select distinct(worker_description) from tbl_wrkassign"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        While rs.EOF = False
            cmbwrkdes.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        j = 0
        dgvwrkassign.Rows.Clear()
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

    Private Sub cmbwrkdes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbwrkdes.SelectedIndexChanged
        sql = "select datediff(day,wfrom,wto),no_workers,pay,manager from tbl_wrkassign where worker_description='" & cmbwrkdes.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtwd.Text = rs(0).Value
            txtnw.Text = rs(1).Value
            txtpd.Text = rs(2).Value
            txtmanage.Text = rs(3).Value
        End If
        j = 0
        sql = "select Outsource,Amount from tbl_outsource where work_des='" & cmbwrkdes.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvoutsourse.Rows.Add()
            dgvoutsourse.Item(0, j).Value = rs(0).Value
            dgvoutsourse.Item(1, j).Value = rs(1).Value
            j = j + 1
            rs.MoveNext()
        Loop
        sql = "select sum(Amount) from tbl_outsource where work_des='" & cmbwrkdes.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            outamount = rs(0).Value
        End If
        txttinvest.Text = Val(txtnw.Text) * Val(txtwd.Text) * Val(txtpd.Text) + Val(outamount)
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

    Private Sub btnwincancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwincancel.Click
        wrkinvstpanel.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub btnwinsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwinsave.Click
        If cmbwrkdes.Text = "" Or txtnw.Text = "" Or txtwd.Text = "" Or txtpd.Text = "" Or txtmanage.Text = "" Or txttinvest.Text = "" Then
            MsgBox("Please enter the Values", MsgBoxStyle.Information)
        Else
            sql = "insert into tbl_wrkinvest(wrk_des,no_wrkers,no_days,pay_day,manager,Total_invest)values('" & cmbwrkdes.Text & "','" & txtnw.Text & "','" & txtwd.Text & "','" & txtpd.Text & "','" & txtmanage.Text & "','" & txttinvest.Text & "')"
            conn.Execute(sql)
            MsgBox("Record Added Successfully", MsgBoxStyle.Information)
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
        End If
    End Sub

  
    Private Sub btnwindelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwindelete.Click
        sql = "delete from tbl_wrkinvest where wrk_des='" & cmbwrkdes.Text & "'"
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

  
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub btnaddn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddn.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub
End Class
