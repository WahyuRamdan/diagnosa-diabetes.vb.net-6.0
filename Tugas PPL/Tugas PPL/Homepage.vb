Imports System.Diagnostics.Eventing
Imports System.Linq
Imports MySql.Data.MySqlClient
Imports System.Text
Imports MySql

Public Class Homepage
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)
    Public Shared Property username As String

    Private Function tampildata()
        connection.Open()
        Dim query As String = "SELECT * FROM user where nama = @user"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@user", username)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read()
            namaLengkap.Text = reader.GetString("nama")
            tanggalLahir.Text = reader.GetDateTime("tgl_lahir").ToString("dd-MM-yyyy")
            jenisKelamin.Text = reader.GetString("jenis_kelamin")

        End While

        reader.Close()

        Dim query2 As String = "SELECT * FROM gejala"
        Dim command2 As New MySqlCommand(query2, connection)
        Dim reader2 As MySqlDataReader = command2.ExecuteReader()
        CheckedListBox1.Items.Clear()
        While reader2.Read()
            CheckedListBox1.Items.Add(reader2.GetString(reader2.GetOrdinal("gejala")))
        End While

        reader2.Close()
        'Tampil data checkboxlist
        connection.Close()
    End Function

    Public Sub Homepage_Load(sender As Object, e As EventArgs)
        tampildata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Informasi.Show()
    End Sub



    ' Definisikan class untuk menyimpan data
    Public Class Aturan
        Public Property id As Integer
        Public Property id_gejala As String
        Public Property pertanyaan As String
        Public Property fakta As String
        Public Property rute As String
        Public Property status As String
        Public Property id_penyakit As String
    End Class

    ' Buat fungsi untuk mengambil data dari tabel basis_aturan dan memasukkannya ke dalam dictionary
    Public Function GetData() As Dictionary(Of String, String())
        Dim dataDictionary As New Dictionary(Of String, String())

        ' Query SQL untuk mengambil data dari tabel basis_aturan
        Dim sqlQuery As String = "SELECT rute, pertanyaan FROM basis_aturan"

        ' Koneksi ke database dan eksekusi query
        ' Misalkan menggunakan koneksi ke MySQL menggunakan MySQLConnector
        connection.Open()

        Using command As New MySqlCommand(sqlQuery, connection)
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ' Baca data dari setiap baris dan masukkan ke dalam dictionary
                    Dim rute As String = reader("rute").ToString()
                    Dim pertanyaan As String = reader("pertanyaan").ToString()

                    ' Periksa apakah kunci (rute) sudah ada di dalam dictionary
                    ' Jika sudah ada, tambahkan pertanyaan ke array yang ada di dalam dictionary
                    ' Jika belum ada, buat array baru dengan satu elemen pertanyaan dan tambahkan ke dictionary
                    If dataDictionary.ContainsKey(rute) Then
                        Dim existingPertanyaan As String() = dataDictionary(rute)
                        Array.Resize(existingPertanyaan, existingPertanyaan.Length + 1)
                        existingPertanyaan(existingPertanyaan.Length - 1) = pertanyaan
                        dataDictionary(rute) = existingPertanyaan
                    Else
                        dataDictionary.Add(rute, {pertanyaan})
                    End If
                End While
            End Using
        End Using

        connection.Close()

        ' Kembalikan dictionary yang berisi data unik
        Return dataDictionary
    End Function

    Private Sub btnIya_Click(sender As Object, e As EventArgs) Handles btnIya.Click
        Dim isBanyakKencing As Boolean = CheckedListBox1.CheckedItems.Contains("Apakah kencing di malam hari lebih dari 5 kali?")
        Dim isSeringHausLapar As Boolean = CheckedListBox1.CheckedItems.Contains("Sering haus atau lapar")
        Dim isBeratBadanTurun As Boolean = CheckedListBox1.CheckedItems.Contains("Berat badan turun drastis")
        Dim isSeringPusing As Boolean = CheckedListBox1.CheckedItems.Contains("Sering pusing")
        Dim isLukaSulitSembuh As Boolean = CheckedListBox1.CheckedItems.Contains("Luka sulit/lama sembuh")
        Dim isPengelihatanKabur As Boolean = CheckedListBox1.CheckedItems.Contains("Pengelihatan kabur")
        Dim isKeputihan As Boolean = CheckedListBox1.CheckedItems.Contains("Keputihan")
        Dim isKesemutan As Boolean = CheckedListBox1.CheckedItems.Contains("Sering kesemutan pada tangan dan kaki")
        Dim isSeringCepatLelah As Boolean = CheckedListBox1.CheckedItems.Contains("Sering cepat lelah saat beraktifitas")
        Dim isInfeksiSaluranKemih As Boolean = CheckedListBox1.CheckedItems.Contains("Infeksi salurah kemih")
        Dim isSeringGatalAlergi As Boolean = CheckedListBox1.CheckedItems.Contains("Sering gatal-gatal atau alergi pada kulit")
        Dim isSeringMual As Boolean = CheckedListBox1.CheckedItems.Contains("Sering mual-mual")
        Dim isSeringMuntah As Boolean = CheckedListBox1.CheckedItems.Contains("Sering muntah")
        Dim isSeringNyeriPerut As Boolean = CheckedListBox1.CheckedItems.Contains("Sering nyeri perut")
        Dim isHipertensi As Boolean = CheckedListBox1.CheckedItems.Contains("Hipertensi (tekanan darah tinggi lebih dari 120/80 mmHg)")
        Dim isObesitas As Boolean = CheckedListBox1.CheckedItems.Contains("Obesitas (kegemukan)")
        Dim isKatarak As Boolean = CheckedListBox1.CheckedItems.Contains("Katarak")
        Dim isBekerjaDenganKeringat As Boolean = CheckedListBox1.CheckedItems.Contains("Berkeringat dengan keringat lengket")
        Dim isSeringDiare As Boolean = CheckedListBox1.CheckedItems.Contains("Sering diare")
        Dim isSeringSesakNafas As Boolean = CheckedListBox1.CheckedItems.Contains("Sering sesak nafas")
        Dim isSeringNyeriUluHati As Boolean = CheckedListBox1.CheckedItems.Contains("Sering nyeri di ulu hati")

        Dim pertanyaanDipilih As New List(Of String)()
        For Each item In CheckedListBox1.CheckedItems
            pertanyaanDipilih.Add(item)
        Next



        Dim data As Dictionary(Of String, String()) = GetData()
        ' Cetak hasil
        For Each kvp As KeyValuePair(Of String, String()) In data
            Console.WriteLine("Rute: " & kvp.Key)
            Console.WriteLine("Pertanyaan:")
            For Each pertanyaan As String In kvp.Value
                Console.WriteLine("- " & pertanyaan)
            Next
            Console.WriteLine()
        Next

        Dim hasil As String

        For Each kvp As KeyValuePair(Of String, String()) In data

            If kvp.Value.SequenceEqual(pertanyaanDipilih) Then
                Console.WriteLine(kvp.Key)
                hasil = kvp.Key
                Console.WriteLine(kvp.Value.SequenceEqual(pertanyaanDipilih).ToString())
            End If

        Next



        ' Logika pengecekan kondisi
        ' R1

        'If isBanyakKencing And isSeringHausLapar And isBeratBadanTurun And isLukaSulitSembuh And isSeringCepatLelah And isHipertensi And isBekerjaDenganKeringat And Not (isSeringPusing Or isPengelihatanKabur Or isKeputihan Or isKesemutan Or isInfeksiSaluranKemih Or isSeringGatalAlergi Or isSeringMual Or isSeringMuntah Or isSeringNyeriPerut Or isObesitas Or isKatarak Or isSeringDiare Or isSeringSesakNafas Or isSeringNyeriUluHati) Then
        '    MessageBox.Show("Anda mungkin menderita Diabetes Mellitus Type I.")
        '    hasil = "Diabetes Mellitus Type 1"
        '    ' R2
        'ElseIf isBanyakKencing And isSeringHausLapar And isBeratBadanTurun And isLukaSulitSembuh And isSeringCepatLelah And isObesitas And Not (isSeringPusing Or isPengelihatanKabur Or isKeputihan Or isKesemutan Or isInfeksiSaluranKemih Or isSeringGatalAlergi Or isSeringMual Or isSeringMuntah Or isSeringNyeriPerut Or isHipertensi Or isKatarak Or isBekerjaDenganKeringat Or isSeringDiare Or isSeringSesakNafas Or isSeringNyeriUluHati) Then
        '    MessageBox.Show("Anda mungkin menderita Diabetes Mellitus Type 2.")
        '    hasil = "Diabetes Mellitus Type 2"
        '    ' R3
        'ElseIf isBanyakKencing And isSeringHausLapar And isSeringPusing And isPengelihatanKabur And isSeringMual And isObesitas And isKatarak And isSeringNyeriUluHati And Not (isBeratBadanTurun Or isLukaSulitSembuh Or isSeringCepatLelah Or isKeputihan Or isKesemutan Or isInfeksiSaluranKemih Or isSeringGatalAlergi Or isSeringMuntah Or isSeringNyeriPerut Or isHipertensi Or isBekerjaDenganKeringat Or isSeringDiare Or isSeringSesakNafas) Then
        '    MessageBox.Show("Anda mungkin menderita Neuropati Diabetes.")
        '    hasil = "Neuropati Diabetes"
        '    ' R4
        'ElseIf isBanyakKencing And isPengelihatanKabur And isKesemutan And isSeringGatalAlergi And isHipertensi And isBekerjaDenganKeringat And Not (isSeringHausLapar Or isBeratBadanTurun Or isSeringPusing Or isKeputihan Or isSeringCepatLelah Or isInfeksiSaluranKemih Or isSeringMual Or isSeringMuntah Or isSeringNyeriPerut Or isObesitas Or isKatarak Or isSeringDiare Or isSeringSesakNafas Or isSeringNyeriUluHati) Then
        '    MessageBox.Show("Anda mungkin menderita Retinopati Diabetes.")
        '    hasil = "Retinopati Diabetes"
        '    ' R5
        'ElseIf isBanyakKencing And isSeringHausLapar And isLukaSulitSembuh And isInfeksiSaluranKemih And isSeringNyeriPerut And isHipertensi And isObesitas And isSeringDiare And Not (isBeratBadanTurun Or isSeringPusing Or isSeringGatalAlergi Or isPengelihatanKabur Or isKeputihan Or isKesemutan Or isSeringCepatLelah Or isSeringMual Or isSeringMuntah Or isKatarak Or isBekerjaDenganKeringat Or isSeringSesakNafas Or isSeringNyeriUluHati) Then
        '    MessageBox.Show("Anda mungkin menderita Nefropati Diabetes.")
        '    hasil = "Nefropati Diabetes"
        '    ' R6
        'ElseIf isSeringPusing And isKeputihan And isSeringMuntah And isSeringNyeriPerut And isHipertensi And isObesitas And isSeringDiare And Not (isBanyakKencing Or isSeringHausLapar Or isBeratBadanTurun Or isLukaSulitSembuh Or isPengelihatanKabur Or isKesemutan Or isSeringCepatLelah Or isInfeksiSaluranKemih Or isSeringGatalAlergi Or isSeringMual Or isKatarak Or isBekerjaDenganKeringat Or isSeringSesakNafas Or isSeringNyeriUluHati) Then
        '    MessageBox.Show("Anda mungkin menderita Ketoasidosis Diabetes.")
        '    hasil = "Ketoasidosis Diabetes"
        '    ' R7
        'ElseIf isPengelihatanKabur And isSeringMual And isSeringMuntah And isSeringNyeriPerut And isObesitas And isBekerjaDenganKeringat And isSeringNyeriUluHati And Not (isBanyakKencing Or isSeringHausLapar Or isBeratBadanTurun Or isSeringPusing Or isLukaSulitSembuh Or isKeputihan Or isKesemutan Or isSeringCepatLelah Or isInfeksiSaluranKemih Or isSeringGatalAlergi Or isHipertensi Or isKatarak Or isSeringDiare Or isSeringSesakNafas) Then
        '    MessageBox.Show("Anda mungkin menderita Gestasional Diabetes.")
        '    hasil = "Gestasional Diabetes"
        'Else
        '    MessageBox.Show("Tidak ada kondisi yang sesuai dengan gejala yang dipilih.")
        '    hasil = "Tidak memiliki diabetes"
        'End If

        Dim now As DateTime = DateTime.Now()
        Console.WriteLine(now.ToString("yyyy-MM-dd"))
        Try
            connection.Open()
            Dim command2 As New MySqlCommand("SELECT * FROM `basis_aturan` WHERE rute = @rute", connection)
            command2.Parameters.AddWithValue("@rute", hasil)
            Dim adaHasil As MySqlDataReader = command2.ExecuteReader()
            Dim penyakitHasil As String
            While adaHasil.Read()
                penyakitHasil = adaHasil("id_penyakit")
            End While
            adaHasil.Close()
            Dim query As String = "UPDATE `user` Set `hasil_diagnosa` = @hasil, `tgl_diagnosa` = @tgl_diagnosa WHERE `user`.`nama` = @user"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user", namaLengkap.Text)
            command.Parameters.AddWithValue("@tgl_diagnosa", now.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@hasil", penyakitHasil)
            ' Menjalankan perintah INSERT
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                tampildata()
            Else
                tampildata()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
            Dim hasilForm As New Hasil()
            hasilForm.username = namaLengkap.Text
            hasilForm.Hasil_Load(Nothing, EventArgs.Empty)
            hasilForm.Show()
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hasil As New Hasil()
        Hasil.username = namaLengkap.Text
        hasil.Hasil_Load(Nothing, EventArgs.Empty)
        hasil.Show()
    End Sub


End Class