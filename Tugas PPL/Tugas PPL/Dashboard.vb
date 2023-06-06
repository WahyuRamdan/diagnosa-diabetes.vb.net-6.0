
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Private Function tampildata()
        Try
            connection.Open()
            Dim query As String = "SELECT COUNT(*) AS totalUser FROM user"
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()
            totalUsers.Text = reader.GetString(0)
            reader.Close()

            Dim query1 As String = "SELECT COUNT(*) AS totalUser FROM gejala"
            Dim command1 As New MySqlCommand(query1, connection)
            Dim reader1 As MySqlDataReader = command1.ExecuteReader()
            reader1.Read()
            totalGejala.Text = reader1.GetString(0)
            reader1.Close()

            Dim query2 As String = "SELECT COUNT(*) AS totalUser FROM daftar_penyakit"
            Dim command2 As New MySqlCommand(query2, connection)
            Dim reader2 As MySqlDataReader = command2.ExecuteReader()
            reader2.Read()
            totalPenyakit.Text = reader2.GetString(0)
            reader2.Close()

            Dim query3 As String = "SELECT COUNT(*) AS totalUser FROM daftar_solusi"
            Dim command3 As New MySqlCommand(query3, connection)
            Dim reader3 As MySqlDataReader = command3.ExecuteReader()
            reader3.Read()
            totalSolusi.Text = reader3.GetString(0)
            reader3.Close()

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        connection.Close()
    End Function
    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Users.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Gejala.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Penyakit.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Solusi.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Aturan.Show()
    End Sub
End Class