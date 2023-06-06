<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gejala
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
        GroupBox1 = New GroupBox()
        namaInput = New TextBox()
        labelgejala = New Label()
        Button2 = New Button()
        Button1 = New Button()
        idInput = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(namaInput)
        GroupBox1.Controls.Add(labelgejala)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(idInput)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Location = New Point(501, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(340, 248)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gejala Detail"' 
        ' namaInput
        ' 
        namaInput.Location = New Point(17, 122)
        namaInput.Name = "namaInput"
        namaInput.Size = New Size(307, 27)
        namaInput.TabIndex = 13
        ' 
        ' labelgejala
        ' 
        labelgejala.AutoSize = True
        labelgejala.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        labelgejala.Location = New Point(17, 99)
        labelgejala.Name = "labelgejala"
        labelgejala.Size = New Size(95, 20)
        labelgejala.TabIndex = 12
        labelgejala.Text = "Nama Gejala"' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(180, 183)
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
        Button1.Location = New Point(28, 183)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 43)
        Button1.TabIndex = 10
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' idInput
        ' 
        idInput.Location = New Point(16, 59)
        idInput.Name = "idInput"
        idInput.Size = New Size(307, 27)
        idInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 0
        Label2.Text = "Id Input"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 37)
        Label1.TabIndex = 4
        Label1.Text = "List Gejala"' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(483, 302)
        DataGridView1.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(685, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 43)
        Button3.TabIndex = 13
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(554, 22)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 43)
        Button4.TabIndex = 12
        Button4.Text = "Edit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Gejala
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(862, 393)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Gejala"
        Text = "Gejala"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents idInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents namaInput As TextBox
    Friend WithEvents labelgejala As Label
End Class
