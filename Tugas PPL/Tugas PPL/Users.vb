
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Users
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Private Function tampildata()
        Try
            connection.Open()
            ' Table ruangan
            Dim query1 As String = "SELECT id, nama, password, jenis_kelamin, tgl_lahir, tgl_diagnosa, hasil_diagnosa FROM user"
            Dim command1 As New MySqlCommand(query1, connection)
            Dim adapter1 As New MySqlDataAdapter(command1)
            Dim dataTable1 As New DataTable()
            adapter1.Fill(dataTable1)
            DataGridView1.DataSource = dataTable1
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 30
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
    End Function
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        tanggaldiagnosaInput.Format = DateTimePickerFormat.Custom
        tanggaldiagnosaInput.CustomFormat = "yyyy-MM-dd"
        tanggallahirInput.Format = DateTimePickerFormat.Custom
        tanggallahirInput.CustomFormat = "yyyy-MM-dd"

    End Sub

    Dim idHapus As String
    Dim indexGridView1 As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            idHapus = selectedRow.Cells("id").Value.ToString()
            indexGridView1 = selectedRow.Index
            Console.WriteLine(selectedRow.Index)
        End If
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles jeniskelaminInput.Click
        jeniskelaminInput.DroppedDown = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(indexGridView1)
            Dim tanggal_lahir As DateTime = Convert.ToDateTime(selectedRow.Cells("tgl_lahir").Value)
            Dim tanggal_diagnosa As DateTime = Convert.ToDateTime(selectedRow.Cells("tgl_diagnosa").Value)
            namaInput.Text = selectedRow.Cells("nama").Value.ToString()
            passwordInput.Text = selectedRow.Cells("password").Value.ToString()
            hasildiagnosaInput.Text = selectedRow.Cells("hasil_diagnosa").Value.ToString()
            jeniskelaminInput.Text = selectedRow.Cells("jenis_kelamin").Value.ToString()
            tanggallahirInput.Text = tanggal_lahir.ToString("yyyy-MM-dd")
            tanggaldiagnosaInput.Text = tanggal_diagnosa.ToString("yyyy-MM-dd")
            Console.WriteLine()

        Catch ex As Exception
            Console.WriteLine("ada yang salah")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM user WHERE `user`.`id` = @value1"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Value1", idHapus)
            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Data berhasil dihapus dari dalam tabel.")
            Else
                MsgBox("Gagal dihapus data ke dalam tabel.")
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
            Dim query As String = "UPDATE `user` Set nama = @nama, password = @password, jenis_kelamin = @jenisKelamin, tgl_lahir = @tgl_lahir, tgl_diagnosa = @tgl_diagnosa, hasil_diagnosa = @hasil  WHERE `user`.`id` = @idHapus;"
            Dim command As New MySqlCommand(query, connection)

            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@idHapus", idHapus)
            Dim selectedValue As String = ""

            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@nama", namaInput.Text())
            command.Parameters.AddWithValue("@password", passwordInput.Text())
            command.Parameters.AddWithValue("@jenisKelamin", jeniskelaminInput.Text())
            command.Parameters.AddWithValue("@tgl_lahir", tanggallahirInput.Value)
            command.Parameters.AddWithValue("@tgl_diagnosa", tanggaldiagnosaInput.Value)
            command.Parameters.AddWithValue("@hasil", hasildiagnosaInput.Text)

            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                Console.WriteLine("Data berhasil ditambahkan ke dalam tabel.")
            Else
                Console.WriteLine("Gagal menambahkan data ke dalam tabel.")
            End If

        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat menjalankan perintah INSERT:")
            Console.WriteLine(ex.Source)

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
            Dim query As String = "INSERT INTO user (nama, password, jenis_kelamin, tgl_lahir, tgl_diagnosa, hasil_diagnosa, keterangan) VALUES (@nama, @password, @jenisKelamin, @tgl_lahir, @tgl_diagnosa, @hasil, 'user')"
            Dim command As New MySqlCommand(query, connection)

            ' Mengatur nilai parameter
            Dim selectedValue As String = ""
            command.Parameters.AddWithValue("@nama", namaInput.Text())
            command.Parameters.AddWithValue("@password", passwordInput.Text())
            command.Parameters.AddWithValue("@jenisKelamin", jeniskelaminInput.Text())
            command.Parameters.AddWithValue("@tgl_lahir", tanggallahirInput.Value)
            command.Parameters.AddWithValue("@tgl_diagnosa", tanggaldiagnosaInput.Value)
            command.Parameters.AddWithValue("@hasil", hasildiagnosaInput.Text)

            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Data berhasil ditambahkan ke dalam tabel.")
            Else
                MsgBox("Gagal menambahkan data ke dalam tabel.")
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' 1062 adalah kode error untuk "Duplicate entry"
                MessageBox.Show("Nama sudah digunakan silahkan coba yang lain")
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

End Class