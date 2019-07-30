Public Class frmlogindetails
    Dim d As Date
    Public i, month As Integer
    Private Sub frmlogindetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d = Date.Today
        d = d.AddDays(-7)
        Log_Details()
    End Sub
    Sub Log_Details()
        i = 0
        'sql = "select * from tbl_LogDetails where LogDate>convert(date,'" & d & "',103)"
        sql = "select top(10)* from tbl_LogDetails order by logdate desc"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvlog.Rows.Add()
            dgvlog.Item(1, i).Value = rs(1).Value
            dgvlog.Item(2, i).Value = rs(2).Value
            dgvlog.Item(3, i).Value = rs(3).Value
            dgvlog.Item(4, i).Value = rs(4).Value
            i = i + 1
            dgvlog.Item(0, i - 1).Value = i
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click
        dgvlog.Rows.Clear()
        i = 0
        sql = "select * from tbl_LogDetails where month(LogDate)='" & month & "' and year(LogDate)='" & cmbyear.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvlog.Rows.Add()
            dgvlog.Item(1, i).Value = rs(1).Value
            dgvlog.Item(2, i).Value = rs(2).Value
            dgvlog.Item(3, i).Value = rs(3).Value
            dgvlog.Item(4, i).Value = rs(4).Value
            i = i + 1
            dgvlog.Item(0, i - 1).Value = i
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbmonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmonth.SelectedIndexChanged
        If cmbmonth.Text = "JANUARY" Then
            month = "1"
        ElseIf cmbmonth.Text = "FEBRUARY" Then
            month = "2"
        ElseIf cmbmonth.Text = "MARCH" Then
            month = "3"
        ElseIf cmbmonth.Text = "APRIL" Then
            month = "4"
        ElseIf cmbmonth.Text = "MAY" Then
            month = "5"
        ElseIf cmbmonth.Text = "JUNE" Then
            month = "6"
        ElseIf cmbmonth.Text = "JULY" Then
            month = "7"
        ElseIf cmbmonth.Text = "AUGUST" Then
            month = "8"
        ElseIf cmbmonth.Text = "SEPTEMBER" Then
            month = "9"
        ElseIf cmbmonth.Text = "OCTOBER" Then
            month = "10"
        ElseIf cmbmonth.Text = "NOVEMBER" Then
            month = "11"
        ElseIf cmbmonth.Text = "DECEMBER" Then
            month = "12"
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
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
        Dim rpt As New logindetails
        rpt.DataSourceConnections.Item(0).SetConnection(server, database, user, password)
        rpt.DataSourceConnections.Item(0).SetLogon(user, password)
        'rpt.RecordSelectionFormula = " {command.receiptNo}='" & lblno.Text & "'"
        rpt.SetParameterValue("wyear", year)
        'frmlogindetailsreport.Text = "LOGIN DETAILS"
        'frmlogindetailsreport.CrystalReportViewer1.ReportSource = rpt
        'frmlogindetailsreport.CrystalReportViewer1.Refresh()
        'frmlogindetailsreport.ShowDialog()
    End Sub
End Class