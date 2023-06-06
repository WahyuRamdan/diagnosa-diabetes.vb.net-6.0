Imports MySql.Data.MySqlClient

Public Class Aturan
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Private Function tampildata()
        Try
            connection.Open()
            ' Table ruangan
            Dim query1 As String = "SELECT * FROM basis_aturan"
            Dim command1 As New MySqlCommand(query1, connection)
            Dim adapter1 As New MySqlDataAdapter(command1)
            Dim dataTable1 As New DataTable()
            adapter1.Fill(dataTable1)
            DataGridView1.DataSource = dataTable1
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 50
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
            ' Table daftar penyakit
            connection.Open()
            Dim query3 As String = "SELECT * FROM daftar_penyakit"
            Dim command3 As New MySqlCommand(query3, connection)
            Dim adapter3 As New MySqlDataAdapter(command3)
            Dim dataTable3 As New DataTable()
            ' Menambahkan data dari DataTable ke dalam ComboBox
            dataTable3.Load(command3.ExecuteReader())
            ComboBox2.DataSource = dataTable3
            ComboBox2.DisplayMember = "nama_penyakit"
            connection.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        Try
            ' Table gejala
            connection.Open()
            Dim query4 As String = "SELECT * FROM gejala"
            Dim command4 As New MySqlCommand(query4, connection)
            Dim adapter4 As New MySqlDataAdapter(command4)
            Dim dataTable4 As New DataTable()
            ' Menambahkan data dari DataTable ke dalam ComboBox
            dataTable4.Load(command4.ExecuteReader())
            ComboBox3.DataSource = dataTable4
            ComboBox3.DisplayMember = "gejala"

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
            idHapus = selectedRow.Cells("id_gejala").Value.ToString()
            indexGridView1 = selectedRow.Index
            Console.WriteLine(selectedRow.Index)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM basis_aturan WHERE `basis_aturan`.`id_gejala` = @value1"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(indexGridView1)
            ComboBox3.Text = selectedRow.Cells("id_gejala").Value.ToString()
            pertanyaanInput.Text = selectedRow.Cells("pertanyaan").Value.ToString()
            ComboBox1.Text = selectedRow.Cells("fakta").Value.ToString()
            ruteInput.Text = selectedRow.Cells("rute").Value.ToString()
            statusInput.Text = selectedRow.Cells("status").Value.ToString()
            ComboBox2.Text = selectedRow.Cells("id_penyakit").Value.ToString()
        Catch ex As Exception
            Console.WriteLine("ada yang salah")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Aturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE `basis_aturan` Set id_gejala = @idGejala, pertanyaan = @pertanyaan, fakta = @fakta, rute = @rute, status = @status, id_penyakit = @id_penyakit WHERE `basis_aturan`.`id_gejala` = @idHapus;"
            Dim command As New MySqlCommand(query, connection)
            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@idHapus", idHapus)
            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@idGejala", ComboBox3.Text())
            command.Parameters.AddWithValue("@pertanyaan", pertanyaanInput.Text())
            command.Parameters.AddWithValue("@fakta", ComboBox1.Text())
            command.Parameters.AddWithValue("@rute", ruteInput.Text())
            command.Parameters.AddWithValue("@status", statusInput.Text())
            command.Parameters.AddWithValue("@id_penyakit", ComboBox2.Text())

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
            Dim query As String = "INSERT INTO basis_aturan (id_gejala, pertanyaan, fakta, rute, status, id_penyakit) values (@idGejala, @pertanyaan, @fakta, @rute, @status, @id_penyakit)"
            Dim command As New MySqlCommand(query, connection)
            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@idGejala", ComboBox3.Text())
            command.Parameters.AddWithValue("@pertanyaan", pertanyaanInput.Text())
            command.Parameters.AddWithValue("@fakta", ComboBox1.Text())
            command.Parameters.AddWithValue("@rute", ruteInput.Text())
            command.Parameters.AddWithValue("@status", statusInput.Text())
            command.Parameters.AddWithValue("@id_penyakit", ComboBox2.Text())

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