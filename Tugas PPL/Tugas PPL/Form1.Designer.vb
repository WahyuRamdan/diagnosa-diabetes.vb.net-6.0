<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        namaInput = New TextBox()
        passwordInput = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        judul = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(186, 140)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 201)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(90, 269)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 41)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.CausesValidation = False
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(71, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama"' 
        ' namaInput
        ' 
        namaInput.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        namaInput.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        namaInput.Location = New Point(71, 387)
        namaInput.Name = "namaInput"
        namaInput.Size = New Size(414, 27)
        namaInput.TabIndex = 3
        ' 
        ' passwordInput
        ' 
        passwordInput.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        passwordInput.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        passwordInput.Location = New Point(71, 456)
        passwordInput.Name = "passwordInput"
        passwordInput.PasswordChar = "*"c
        passwordInput.Size = New Size(414, 27)
        passwordInput.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.CausesValidation = False
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(71, 433)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 4
        Label3.Text = "Password"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(115, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 37)
        Label4.TabIndex = 6
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(71, 512)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 35)
        Button1.TabIndex = 7
        Button1.Text = "Kirim"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button2.Location = New Point(186, 512)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 35)
        Button2.TabIndex = 8
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Location = New Point(121, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 37)
        Label5.TabIndex = 9
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' judul
        ' 
        judul.AutoSize = True
        judul.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        judul.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        judul.Location = New Point(90, 66)
        judul.Name = "judul"
        judul.Size = New Size(402, 28)
        judul.TabIndex = 11
        judul.Text = "Sistem Pakar Diagnosa penyakit diabetes"
        judul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(559, 589)
        Controls.Add(judul)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(passwordInput)
        Controls.Add(Label3)
        Controls.Add(namaInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namaInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents judul As Label
End Class
