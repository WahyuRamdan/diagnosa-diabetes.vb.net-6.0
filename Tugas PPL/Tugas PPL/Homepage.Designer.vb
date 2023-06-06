<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnIya = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        jenisKelamin = New Label()
        Label9 = New Label()
        tanggalLahir = New Label()
        Label7 = New Label()
        namaLengkap = New Label()
        Label5 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 60)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Location = New Point(299, 13)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 32)
        Button3.TabIndex = 2
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(139, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 32)
        Button2.TabIndex = 1
        Button2.Text = "Informasi Diabetes"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 32)
        Button1.TabIndex = 0
        Button1.Text = "Diagnosa"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnIya
        ' 
        btnIya.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        btnIya.FlatStyle = FlatStyle.Flat
        btnIya.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnIya.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnIya.Location = New Point(170, 645)
        btnIya.Name = "btnIya"
        btnIya.Size = New Size(115, 30)
        btnIya.TabIndex = 4
        btnIya.Text = "Check"
        btnIya.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 335)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 20)
        Label1.TabIndex = 6
        Label1.Text = "Pilih Gejala yang dirasakan :"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(jenisKelamin)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(tanggalLahir)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(namaLengkap)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Location = New Point(12, 92)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(430, 208)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informasi User"' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(12, 156)
        Button4.Name = "Button4"
        Button4.Size = New Size(199, 32)
        Button4.TabIndex = 3
        Button4.Text = "Riwayat Diagnosa"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' jenisKelamin
        ' 
        jenisKelamin.AutoSize = True
        jenisKelamin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        jenisKelamin.Location = New Point(158, 115)
        jenisKelamin.Name = "jenisKelamin"
        jenisKelamin.Size = New Size(53, 20)
        jenisKelamin.TabIndex = 16
        jenisKelamin.Text = "Wahyu"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(12, 115)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 20)
        Label9.TabIndex = 15
        Label9.Text = "Jenis Kelamin :"' 
        ' tanggalLahir
        ' 
        tanggalLahir.AutoSize = True
        tanggalLahir.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tanggalLahir.Location = New Point(158, 77)
        tanggalLahir.Name = "tanggalLahir"
        tanggalLahir.Size = New Size(53, 20)
        tanggalLahir.TabIndex = 14
        tanggalLahir.Text = "Wahyu"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(12, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 20)
        Label7.TabIndex = 13
        Label7.Text = "Tanggal lahir :"' 
        ' namaLengkap
        ' 
        namaLengkap.AutoSize = True
        namaLengkap.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        namaLengkap.Location = New Point(158, 40)
        namaLengkap.Name = "namaLengkap"
        namaLengkap.Size = New Size(53, 20)
        namaLengkap.TabIndex = 12
        namaLengkap.Text = "Wahyu"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(12, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 11
        Label5.Text = "Nama Lengkap :"' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(30, 358)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(396, 268)
        CheckedListBox1.TabIndex = 9
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(472, 687)
        Controls.Add(CheckedListBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(btnIya)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Homepage"
        Text = "Diagnosa"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnIya As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents jenisKelamin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tanggalLahir As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents namaLengkap As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button4 As Button
End Class
