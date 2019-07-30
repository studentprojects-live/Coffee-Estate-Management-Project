Public Class frmmaster

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        sql = "UPDATE tbl_LogDetails set Logout='" & Now.TimeOfDay.ToString & "' where usertype='" & usertype & "' and LogDate=convert(date,'" & Now.Date & "',103)"
        conn.Execute(sql)
        Me.Close()
    End Sub

    'Private Sub frmmaster_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    MsgBox("Please Logout", MsgBoxStyle.Information)
    '    Exit Sub
    'End Sub

    Private Sub frmmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
    End Sub

    Private Sub WORKERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORKERSToolStripMenuItem.Click
        frmworkerinfo.MdiParent = Me
        frmworkerinfo.Show()
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        frmpass.MdiParent = Me
        frmpass.Show()
    End Sub

    Private Sub LOGINDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINDETAILSToolStripMenuItem.Click
        frmlogindetails.MdiParent = Me
        frmlogindetails.Show()
    End Sub

    Private Sub TREATMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TREATMENTSToolStripMenuItem.Click
        frmmaintain.MdiParent = Me
        frmmaintain.Show()
    End Sub

    

    Private Sub RECORDCONFIGURATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECORDCONFIGURATIONToolStripMenuItem.Click
        FRMYEAR.MdiParent = Me
        FRMYEAR.Show()
    End Sub

    

    Private Sub PRODUCTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTIONToolStripMenuItem.Click
        frmproduction.MdiParent = Me
        frmproduction.Show()
    End Sub

    Private Sub PAYROLLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYROLLToolStripMenuItem.Click
        frmpayroll.MdiParent = Me
        frmpayroll.Show()
    End Sub

   
End Class