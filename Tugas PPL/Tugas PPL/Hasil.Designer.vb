<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hasil
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
        penyakit = New Label()
        Label4 = New Label()
        tanggal = New Label()
        Label2 = New Label()
        Label1 = New Label()
        solusi = New Label()
        Label6 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(penyakit)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(tanggal)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(521, 193)
        Panel1.TabIndex = 0
        ' 
        ' penyakit
        ' 
        penyakit.AutoSize = True
        penyakit.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        penyakit.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        penyakit.Location = New Point(243, 142)
        penyakit.Name = "penyakit"
        penyakit.Size = New Size(131, 23)
        penyakit.TabIndex = 4
        penyakit.Text = "Pada Tanggal :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(21, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 23)
        Label4.TabIndex = 3
        Label4.Text = "Kemungkinan diderita :"' 
        ' tanggal
        ' 
        tanggal.AutoSize = True
        tanggal.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        tanggal.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        tanggal.Location = New Point(243, 86)
        tanggal.Name = "tanggal"
        tanggal.Size = New Size(131, 23)
        tanggal.TabIndex = 2
        tanggal.Text = "Pada Tanggal :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(21, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 23)
        Label2.TabIndex = 1
        Label2.Text = "Pada Tanggal :"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(176, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 28)
        Label1.TabIndex = 0
        Label1.Text = "Hasil Diagnosa"' 
        ' solusi
        ' 
        solusi.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        solusi.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        solusi.Location = New Point(33, 249)
        solusi.Name = "solusi"
        solusi.Size = New Size(500, 624)
        solusi.TabIndex = 6
        solusi.Text = "Pada Tanggal :"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label6.Location = New Point(33, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 23)
        Label6.TabIndex = 5
        Label6.Text = "Solusi yang disarankan :"' 
        ' Hasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(53), CByte(55), CByte(58))
        ClientSize = New Size(545, 291)
        Controls.Add(solusi)
        Controls.Add(Panel1)
        Controls.Add(Label6)
        Name = "Hasil"
        Text = "Hasil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents solusi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents penyakit As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
