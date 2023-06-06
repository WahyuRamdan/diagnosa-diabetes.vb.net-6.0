<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        jeniskelaminInput = New ComboBox()
        Label7 = New Label()
        tanggallahirInput = New DateTimePicker()
        Button2 = New Button()
        Button1 = New Button()
        hasildiagnosaInput = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        passwordInput = New TextBox()
        Label3 = New Label()
        namaInput = New TextBox()
        Label2 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        tanggaldiagnosaInput = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        DataGridView1.Location = New Point(12, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(721, 502)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 37)
        Label1.TabIndex = 1
        Label1.Text = "List Users"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(jeniskelaminInput)
        GroupBox1.Controls.Add(tanggaldiagnosaInput)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(tanggallahirInput)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(hasildiagnosaInput)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(passwordInput)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(namaInput)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Location = New Point(759, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(340, 551)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Detail"' 
        ' jeniskelaminInput
        ' 
        jeniskelaminInput.FormattingEnabled = True
        jeniskelaminInput.Items.AddRange(New Object() {"Wanita", "Pria"})
        jeniskelaminInput.Location = New Point(16, 208)
        jeniskelaminInput.Name = "jeniskelaminInput"
        jeniskelaminInput.Size = New Size(307, 28)
        jeniskelaminInput.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(16, 358)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 20)
        Label7.TabIndex = 13
        Label7.Text = "Tanggal Diagnosa"' 
        ' tanggallahirInput
        ' 
        tanggallahirInput.Location = New Point(16, 274)
        tanggallahirInput.Name = "tanggallahirInput"
        tanggallahirInput.Size = New Size(250, 27)
        tanggallahirInput.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(193, 486)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 43)
        Button2.TabIndex = 11
        Button2.Text = "Buat Baru"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(41, 486)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 43)
        Button1.TabIndex = 10
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' hasildiagnosaInput
        ' 
        hasildiagnosaInput.Location = New Point(16, 444)
        hasildiagnosaInput.Name = "hasildiagnosaInput"
        hasildiagnosaInput.Size = New Size(307, 27)
        hasildiagnosaInput.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(16, 421)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 20)
        Label6.TabIndex = 8
        Label6.Text = "Hasil Diagnosa"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(16, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 6
        Label5.Text = "Tanggal Lahir"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(16, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 4
        Label4.Text = "Jenis Kelamin"' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(16, 133)
        passwordInput.Name = "passwordInput"
        passwordInput.Size = New Size(307, 27)
        passwordInput.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(16, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"' 
        ' namaInput
        ' 
        namaInput.Location = New Point(16, 61)
        namaInput.Name = "namaInput"
        namaInput.Size = New Size(307, 27)
        namaInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama"' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(619, 46)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 43)
        Button3.TabIndex = 15
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(508, 46)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 43)
        Button4.TabIndex = 14
        Button4.Text = "Edit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' tanggaldiagnosaInput
        ' 
        tanggaldiagnosaInput.Location = New Point(16, 381)
        tanggaldiagnosaInput.Name = "tanggaldiagnosaInput"
        tanggaldiagnosaInput.Size = New Size(250, 27)
        tanggaldiagnosaInput.TabIndex = 14
        tanggaldiagnosaInput.Value = New DateTime(2012, 1, 1, 0, 0, 0, 0)
        ' 
        ' Users
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(1111, 648)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Users"
        Text = "Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents hasildiagnosaInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents namaInput As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents jeniskelaminInput As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tanggallahirInput As DateTimePicker
    Friend WithEvents tanggaldiagnosaInput As DateTimePicker
End Class
