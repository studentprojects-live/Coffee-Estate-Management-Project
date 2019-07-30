Public Class frmworkerinfo
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
    Sub load_workers()
        dgvworkers.Rows.Clear()
        i = 0
        j = 1
        sql = "select L_Name,Age from tbl_workerInfo"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvworkers.Rows.Add()
            dgvworkers.Item(0, i).Value = j
            dgvworkers.Item(1, i).Value = rs(0).Value
            dgvworkers.Item(2, i).Value = rs(1).Value
            j = j + 1
            i = i + 1
            rs.MoveNext()
        Loop
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
                load_workers()
                'Panel1.Visible = False
                'Panel2.Visible = False
                btnadd.Enabled = True
                btnsave.Enabled = False
            Else
                If MsgBoxResult.No = MsgBox("Do you want to Update the Record?", MsgBoxStyle.YesNo) Then Exit Sub
                sql = "update tbl_workerInfo set L_Name='" & txtname.Text & "',age='" & txtage.Text & "', sex='" & gender & "', address='" & txtaddress.Text & "', balance= '" & txtbal.Text & "',beneficials='" & txtbeneficials.Text & "',doj=convert(date,'" & dtpdoj.Value & "',103),photo='" & wrkerpic.ImageLocation & "', category='" & cmbcategory.Text & "',documents='" & txtdocument.Text & "' where L_Name='" & txtname.Text & "'"
                conn.Execute(sql)
                MsgBox("worker information updated successfully", MsgBoxStyle.Information)
                Reset()
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
                load_workers()
            End If
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If MsgBoxResult.No = MsgBox("do you want to delete the record ?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_workerInfo where L_Name='" & txtname.Text & "'"
        conn.Execute(sql)
        MsgBox("worker details deleted successfully", MsgBoxStyle.Information)
        Reset()
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

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        reset()
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

    Private Sub frmworkerinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        load_workers()
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

    Private Sub btnworkinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnworkinfo.Click
        btnworkinfo.Enabled = False
        btnwrkassign.Enabled = True
        btnworkinvest.Enabled = True
        Panel2.Visible = True
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
        frminvest.MdiParent = frmmaster
        frminvest.Show()
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        sql = "select * from TBL_settings"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            Server = rs(0).Value
            Database = rs(1).Value
            User = rs(2).Value
            Password = rs(3).Value
        End If
        Dim rpt As New workerInformation
        rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
        rpt.DataSourceConnections.Item(0).SetLogon(User, Password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        'rpt.SetParameterValue("words", words)
        'frmwrkerrep.Text = "WORKER INFORMATION"
        'frmwrkerrep.CrystalReportViewer1.ReportSource = rpt
        'frmwrkerrep.CrystalReportViewer1.Refresh()
        'frmwrkerrep.ShowDialog()
    End Sub
End Class