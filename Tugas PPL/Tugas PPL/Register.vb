Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Register
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()

            Dim query As String = "INSERT INTO user (nama, password, tgl_lahir, jenis_kelamin, keterangan) VALUES (@Value2, @Value3, @Value4, @Value5, 'user')"
            Dim command As New MySqlCommand(query, connection)
            Dim selectedValue As String = ""

            ' Mengatur nilai parameter
            command.Parameters.AddWithValue("@Value2", namaInput.Text)
            command.Parameters.AddWithValue("@Value3", passwordInput.Text)
            command.Parameters.AddWithValue("@Value4", tanggalInput.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@Value5", kelaminInput.Text)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Berhasil membuat user, silahkan login")
                Console.WriteLine("Berhasil input:")
            Else
                MsgBox("silahkan buat ulang")
                Console.WriteLine("Terjadi kesalahan")
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then ' 1062 adalah kode error untuk "Duplicate entry"
                MessageBox.Show("Nama sudah digunakan silahkan coba yang lain")
            End If
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat menjalankan perintah INSERT:")

            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)

        Finally
            ' Pastikan selalu menutup koneksi database setelah digunakan
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub ComboBox1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kelaminInput.GotFocus
        kelaminInput.DroppedDown = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class