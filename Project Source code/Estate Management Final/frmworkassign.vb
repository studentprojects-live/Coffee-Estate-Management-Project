Public Class frmworkassign
    Public i As Integer = 0
    Public j As Integer = 0
    Public coloring As Boolean = False
    Public wname

    Private Sub frmworkassign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        workers()
        'lstall.DrawMode = DrawMode.OwnerDrawVariable
        'AddHandler lstall.DrawItem, AddressOf drawit
        workers1()
    End Sub
    Sub workers1()
        coloring = False
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
    
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lstworkers.Items.Add(lstall.SelectedItem.ToString)
        cmbmanage.Items.Add(lstall.SelectedItem.ToString)
        lstall.Items.Remove(lstall.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
        lstall.Items.Clear()
        j = 0
        workers()
        workers1()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        lstall.Items.Add(lstworkers.SelectedItem.ToString)
        cmbmanage.Items.Remove(lstworkers.SelectedItem.ToString)
        lstworkers.Items.Remove(lstworkers.SelectedItem.ToString)
        txtnum.Text = lstworkers.Items.Count
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtdes.Text = "" Or txtnum.Text = "" Or txtpay.Text = "" Or txtsource.Text = "" Then
            MsgBox(" enter appropriate values", MsgBoxStyle.Information)
        ElseIf lstworkers.Items.Count = 0 Then
            MsgBox("please select the workers", MsgBoxStyle.Information)
        Else
            For i = 0 To lstworkers.Items.Count - 1
                sql = "insert into tbl_wrkassign(worker_description,wfrom,wto,wname,outsource,no_workers,wstatus,manager,pay)values('" & txtdes.Text & "',convert(date,'" & dtpfrom.Value & "',103),convert(date,'" & dtpto.Value & "',103),'" & lstworkers.Items(i).ToString & "','" & txtsource.Text & "', '" & txtnum.Text & "','" & cmbstatus.Text & "','" & cmbmanage.Text & "','" & txtpay.Text & "')"
                conn.Execute(sql)
            Next
            i = 0
            For i = 0 To dgvtools.Rows.Count - 2
                sql = " insert into tbl_tools(work_des,manager,tool_name,tool_count) values ('" & txtdes.Text & "', '" & cmbmanage.Text & "','" & dgvtools.Item(0, i).Value & "','" & dgvtools.Item(1, i).Value & "')"
                conn.Execute(sql)
            Next
            MsgBox(" data saved successfully", MsgBoxStyle.Information)
            clear()
        End If

    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

        frmworkers.Show()
    End Sub
    Sub clear()
        txtdes.Clear()
        txtnum.Clear()
        txtpay.Clear()
        txtsource.Clear()
        cmbmanage.Text = ""
        cmbstatus.Text = ""
        lstworkers.Items.Clear()
        lstall.Items.Clear()
        dtpfrom.Value = Today
        dtpto.Value = Today
        dgvtools.Rows.Clear()
        j = 0
        workers()
        workers1()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub

   
   

    
End Class