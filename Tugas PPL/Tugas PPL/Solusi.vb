Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Solusi
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Private Function tampildata()
        Try
            connection.Open()
            ' Table ruangan
            Dim query1 As String = "SELECT * FROM daftar_solusi"
            Dim command1 As New MySqlCommand(query1, connection)
            Dim adapter1 As New MySqlDataAdapter(command1)
            Dim dataTable1 As New DataTable()
            adapter1.Fill(dataTable1)
            DataGridView1.DataSource = dataTable1
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 400
            DataGridView1.ForeColor = Color.Black
            connection.Close()
            Console.WriteLine("Query berhasil dieksekusi.")




        Catch ex As Exception
            ' Tangkap dan tangani kesalahan yang mungkin terjadi
            Console.WriteLine("Terjadi kesalahan saat menjalankan query:")
            Console.WriteLine(ex.Message)

            ' Jika diperlukan, lakukan tindakan yang sesuai untuk penanganan kesalahan
        Finally
            ' Pastikan selalu menutup koneksi database setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        Try
            ' Table Request
            connection.Open()
            Dim query3 As String = "SELECT * FROM daftar_penyakit"
            Dim command3 As New MySqlCommand(query3, connection)
            Dim adapter3 As New MySqlDataAdapter(command3)
            Dim dataTable3 As New DataTable()
            ' Menambahkan data dari DataTable ke dalam ComboBox
            dataTable3.Load(command3.ExecuteReader())
            ComboBox1.DataSource = dataTable3
            ComboBox1.DisplayMember = "nama_penyakit"
            connection.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Function
    Dim idHapus As String
    Dim indexGridView1 As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            idHapus = selectedRow.Cells("id_solusi").Value.ToString()
            indexGridView1 = selectedRow.Index
            Console.WriteLine(selectedRow.Index)
        End If
    End Sub

    Private Sub Solusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(indexGridView1)
            solusiInput.Text = selectedRow.Cells("solusi").Value.ToString()
            ComboBox1.Text = selectedRow.Cells("id_penyakit").Value.ToString()
        Catch ex As Exception
            Console.WriteLine("ada yang salah")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM daftar_solusi WHERE `daftar_solusi`.`id_solusi` = @value1"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", idHapus)
            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Data berhasil dihapus.")
            Else
                MsgBox("Gagal dihapus data")
            End If

        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat menjalankan perintah DELETE:")
            Console.WriteLine(ex.Message)
        Finally
            ' Pastikan selalu menutup koneksi database setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            tampildata()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE `daftar_solusi` Set  solusi = @solusi, id_penyakit = @idPenyakit WHERE `daftar_solusi`.`id_solusi` = @idHapus;"
            Dim command As New MySqlCommand(query, connection)
            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@idHapus", idHapus)
            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@solusi", solusiInput.Text())
            command.Parameters.AddWithValue("@idPenyakit", ComboBox1.Text())

            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Data berhasil diubah.")
            Else
                MsgBox("Gagal dibuah data ")
            End If

        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat menjalankan perintah INSERT:")
            Console.WriteLine(ex.Message)

        Finally
            ' Pastikan selalu menutup koneksi database setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            tampildata()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO daftar_solusi (solusi, id_penyakit) values (@solusi, @idPenyakit)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@solusi", solusiInput.Text())
            command.Parameters.AddWithValue("@idPenyakit", ComboBox1.Text())
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Data berhasil berhasil ditambahkan.")
            Else
                MsgBox("Gagal dihapus data")
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' 1062 adalah kode error untuk "Duplicate entry"
                MessageBox.Show("Nama sudah digunakan silahkan coba yang lain")
            End If
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat menjalankan perintah DELETE:")
            Console.WriteLine(ex.Message)
        Finally
            ' Pastikan selalu menutup koneksi database setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            tampildata()
        End Try
    End Sub
End Class