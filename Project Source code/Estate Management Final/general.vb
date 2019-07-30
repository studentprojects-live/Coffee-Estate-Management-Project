Module general
    Public conn As New ADODB.Connection
    Public usertype, sql, server, database, user, password As String
    Public rs As New ADODB.Recordset
    Public i, year As Integer
    Public Function OpenDB()
        Try
            If conn.State = 1 Then conn.Close()
            conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;user id=sa;password=mangalore123;Initial Catalog=Estate;Data Source=PC")
            Return (0)
        Catch ex As Exception
            MsgBox("Database is not connected ..... Please Check Your Network Connection", MsgBoxStyle.Critical, "Error")
            End
        End Try
    End Function
    Public Function load_year()
        sql = "select year from tbl_year where status='Active'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            Year = rs(0).Value
        End If
        Return year
    End Function
End Module
