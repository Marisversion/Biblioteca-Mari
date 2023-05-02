Imports MySql.Data.MySqlClient
Public Class Libro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cstring As String
        cstring = "server=localhost;user=root;database=biblioteca;port=3306;password=CVO-2023;"
        Dim conn As New MySqlConnection(cstring)
        Try
            conn.Open()
            Dim squery As String
            squery = "SELECT *FROM libro"
            Dim da As New MysqlDataAdapter(squery, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class