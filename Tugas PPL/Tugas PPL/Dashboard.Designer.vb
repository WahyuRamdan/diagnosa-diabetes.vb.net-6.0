<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Button7 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        totalUsers = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        totalGejala = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        totalPenyakit = New Label()
        Label5 = New Label()
        Panel5 = New Panel()
        totalSolusi = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(203), CByte(207), CByte(211))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(266, 649)
        Panel1.TabIndex = 0
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Gainsboro
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(11, 439)
        Button7.Name = "Button7"
        Button7.Size = New Size(245, 50)
        Button7.TabIndex = 8
        Button7.Text = "Data Aturan"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gainsboro
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(11, 371)
        Button4.Name = "Button4"
        Button4.Size = New Size(245, 50)
        Button4.TabIndex = 7
        Button4.Text = "Data Solusi"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.White
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(11, 565)
        Button6.Name = "Button6"
        Button6.Size = New Size(245, 50)
        Button6.TabIndex = 6
        Button6.Text = "Logout"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gainsboro
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(11, 304)
        Button5.Name = "Button5"
        Button5.Size = New Size(245, 50)
        Button5.TabIndex = 5
        Button5.Text = "Data Penyakit"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gainsboro
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(11, 237)
        Button3.Name = "Button3"
        Button3.Size = New Size(245, 50)
        Button3.TabIndex = 3
        Button3.Text = "Data Gejala"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gainsboro
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(11, 172)
        Button2.Name = "Button2"
        Button2.Size = New Size(245, 50)
        Button2.TabIndex = 2
        Button2.Text = "Data Users"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gainsboro
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(11, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 50)
        Button1.TabIndex = 1
        Button1.Text = "Dashboard Admin"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 32)
        Label1.TabIndex = 0
        Label1.Text = "SPK Penyakit Umum"' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(61), CByte(161), CByte(177))
        Panel2.Controls.Add(totalUsers)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(309, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(289, 119)
        Panel2.TabIndex = 1
        ' 
        ' totalUsers
        ' 
        totalUsers.AutoSize = True
        totalUsers.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        totalUsers.Location = New Point(33, 23)
        totalUsers.Name = "totalUsers"
        totalUsers.Size = New Size(28, 32)
        totalUsers.TabIndex = 4
        totalUsers.Text = "0"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 32)
        Label2.TabIndex = 0
        Label2.Text = "Total Users"' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(75), CByte(167), CByte(96))
        Panel3.Controls.Add(totalGejala)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(643, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(289, 119)
        Panel3.TabIndex = 2
        ' 
        ' totalGejala
        ' 
        totalGejala.AutoSize = True
        totalGejala.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        totalGejala.Location = New Point(44, 23)
        totalGejala.Name = "totalGejala"
        totalGejala.Size = New Size(28, 32)
        totalGejala.TabIndex = 5
        totalGejala.Text = "0"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(30, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 32)
        Label3.TabIndex = 1
        Label3.Text = "Total Gejala"' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(152), CByte(164))
        Panel4.Controls.Add(totalPenyakit)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(643, 203)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(289, 119)
        Panel4.TabIndex = 4
        ' 
        ' totalPenyakit
        ' 
        totalPenyakit.AutoSize = True
        totalPenyakit.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        totalPenyakit.Location = New Point(44, 22)
        totalPenyakit.Name = "totalPenyakit"
        totalPenyakit.Size = New Size(28, 32)
        totalPenyakit.TabIndex = 6
        totalPenyakit.Text = "0"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(30, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 32)
        Label5.TabIndex = 3
        Label5.Text = "Total Penyakit"' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(136), CByte(91), CByte(0))
        Panel5.Controls.Add(totalSolusi)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(309, 203)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(289, 119)
        Panel5.TabIndex = 3
        ' 
        ' totalSolusi
        ' 
        totalSolusi.AutoSize = True
        totalSolusi.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        totalSolusi.Location = New Point(33, 22)
        totalSolusi.Name = "totalSolusi"
        totalSolusi.Size = New Size(28, 32)
        totalSolusi.TabIndex = 3
        totalSolusi.Text = "0"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(21, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 32)
        Label4.TabIndex = 2
        Label4.Text = "Total Solusi"' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(978, 629)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents totalUsers As Label
    Friend WithEvents totalGejala As Label
    Friend WithEvents totalPenyakit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalSolusi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
End Class
