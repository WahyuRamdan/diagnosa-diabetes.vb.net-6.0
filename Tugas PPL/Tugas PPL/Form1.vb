Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "server=localhost;user=root;password=;database=ppl"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection.Open()
        Dim query As String = "SELECT * FROM user"
        Dim command As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        Dim ketemu As Boolean = False


        While reader.Read()
            Dim username As String = reader.GetString("nama")
            Dim password As String = reader.GetString("password")
            Dim status As String = reader.GetString("keterangan")

            Console.WriteLine($"Value from column1: {username}, Value from column2: {password}")
            If namaInput.Text = username And passwordInput.Text = password Then
                If status = "admin" Then
                    ketemu = True

                    ' Memanggil metode Load secara manual
                    Dim dashboard As New Dashboard()
                    dashboard.Dashboard_Load(Nothing, EventArgs.Empty)
                    dashboard.Show()
                    Me.Hide()
                ElseIf status = "user" Then
                    Dim homepage As New Homepage()
                    Homepage.username = username
                    homepage.Homepage_Load(Nothing, EventArgs.Empty)
                    ketemu = True
                    homepage.Show()
                    Me.Hide()
                End If
                Exit While
            End If
        End While

        If Not ketemu Then
            MsgBox("User tidak ditemukan", 0, "Error")
        End If

        reader.Close()
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register.Show()
    End Sub
End Class
