<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penyakit
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
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        npInput = New TextBox()
        Label5 = New Label()
        keteranganInput = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        Button1 = New Button()
        namaInput = New TextBox()
        Label2 = New Label()
        Button4 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(533, 41)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 43)
        Button3.TabIndex = 18
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(npInput)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(keteranganInput)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(namaInput)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Location = New Point(654, 88)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(340, 374)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Penyakit Detail"' 
        ' npInput
        ' 
        npInput.Location = New Point(16, 261)
        npInput.Name = "npInput"
        npInput.Size = New Size(307, 27)
        npInput.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(16, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 22
        Label5.Text = "Nppenyakit"' 
        ' keteranganInput
        ' 
        keteranganInput.Location = New Point(16, 121)
        keteranganInput.Multiline = True
        keteranganInput.Name = "keteranganInput"
        keteranganInput.Size = New Size(307, 102)
        keteranganInput.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(16, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 20
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(183, 308)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 43)
        Button2.TabIndex = 11
        Button2.Text = "Buat Baru"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(16, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 2
        Label3.Text = "Keterangan"' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(58, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 43)
        Button1.TabIndex = 10
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' namaInput
        ' 
        namaInput.Location = New Point(16, 59)
        namaInput.Name = "namaInput"
        namaInput.Size = New Size(307, 27)
        namaInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama Penyakit"' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(88), CByte(177), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(422, 41)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 43)
        Button4.TabIndex = 17
        Button4.Text = "Edit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 37)
        Label1.TabIndex = 15
        Label1.Text = "List Penyakit"' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(636, 368)
        DataGridView1.TabIndex = 14
        ' 
        ' Penyakit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(1005, 474)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Penyakit"
        Text = "Penyakit"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Private WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents namaInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents npInput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents keteranganInput As TextBox
End Class
