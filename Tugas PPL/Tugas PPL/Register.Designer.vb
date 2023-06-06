<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label1 = New Label()
        Label2 = New Label()
        namaInput = New TextBox()
        passwordInput = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        tanggalInput = New DateTimePicker()
        kelaminInput = New ComboBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(166, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 37)
        Label1.TabIndex = 0
        Label1.Text = "Register Akun"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama"' 
        ' namaInput
        ' 
        namaInput.Location = New Point(62, 112)
        namaInput.Name = "namaInput"
        namaInput.Size = New Size(408, 27)
        namaInput.TabIndex = 2
        ' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(62, 174)
        passwordInput.Name = "passwordInput"
        passwordInput.Size = New Size(408, 27)
        passwordInput.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 5
        Label4.Text = "Password"' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(116, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 41)
        Button1.TabIndex = 7
        Button1.Text = "Buat Akun"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button2.Location = New Point(291, 392)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 41)
        Button2.TabIndex = 8
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(62, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 9
        Label5.Text = "Tanggal Lahir"' 
        ' tanggalInput
        ' 
        tanggalInput.Format = DateTimePickerFormat.Short
        tanggalInput.Location = New Point(62, 246)
        tanggalInput.Name = "tanggalInput"
        tanggalInput.Size = New Size(408, 27)
        tanggalInput.TabIndex = 11
        ' 
        ' kelaminInput
        ' 
        kelaminInput.FormattingEnabled = True
        kelaminInput.Items.AddRange(New Object() {"Wanita", "Pria"})
        kelaminInput.Location = New Point(62, 320)
        kelaminInput.Name = "kelaminInput"
        kelaminInput.Size = New Size(408, 28)
        kelaminInput.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(62, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 13
        Label6.Text = "Jenis Kelamin"' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(525, 466)
        Controls.Add(Label6)
        Controls.Add(kelaminInput)
        Controls.Add(tanggalInput)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(passwordInput)
        Controls.Add(Label4)
        Controls.Add(namaInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Register"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namaInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tanggalInput As DateTimePicker
    Friend WithEvents kelaminInput As ComboBox
    Friend WithEvents Label6 As Label
End Class
