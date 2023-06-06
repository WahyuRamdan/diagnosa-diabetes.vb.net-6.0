Imports MySql.Data.MySqlClient

Public Class Hasil
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Public Shared Property username As String
    Private Function tampildata()
        connection.Open()
        Dim query As String = "SELECT * FROM user where nama = @user"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@user", username)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        Dim namaPenyakit As String
        While reader.Read()
            penyakit.Text = reader.GetString("hasil_diagnosa")
            tanggal.Text = reader.GetDateTime("tgl_diagnosa").ToString("dd-MM-yyyy")
            namaPenyakit = reader.GetString("hasil_diagnosa")
        End While

        reader.Close()

        Dim query2 As String = "SELECT * FROM daftar_solusi where id_penyakit = @nama_penyakit"
        Dim command2 As New MySqlCommand(query2, connection)
        command2.Parameters.AddWithValue("@nama_penyakit", namaPenyakit)
        Dim reader2 As MySqlDataReader = command2.ExecuteReader()
        While reader2.Read()
            solusi.Text = reader2.GetString("solusi")
        End While
        Me.Height = solusi.Height

        reader2.Close()
        'Tampil data checkboxlist
        connection.Close()
    End Function

    Public Sub Hasil_Load(sender As Object, e As EventArgs)
        tampildata()
    End Sub
End Class