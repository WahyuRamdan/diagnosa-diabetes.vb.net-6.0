Public Class Informasi
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim url As String = "https://hellosehat.com/diabetes/tipe-diabetes/" ' Ganti dengan URL yang diinginkan

        Shell("cmd /c start " & url, AppWinStyle.NormalFocus)
    End Sub
End Class