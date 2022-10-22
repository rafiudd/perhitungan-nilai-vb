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
        Me.Presensi = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.input_presensi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input_responsi = New System.Windows.Forms.TextBox()
        Me.input_tugas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input_uas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hasil_akhir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Presensi
        '
        Me.Presensi.AutoSize = True
        Me.Presensi.Location = New System.Drawing.Point(30, 35)
        Me.Presensi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Presensi.Name = "Presensi"
        Me.Presensi.Size = New System.Drawing.Size(62, 20)
        Me.Presensi.TabIndex = 0
        Me.Presensi.Text = "Presensi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 338)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cek Hasil Akhir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'input_presensi
        '
        Me.input_presensi.Location = New System.Drawing.Point(35, 60)
        Me.input_presensi.Margin = New System.Windows.Forms.Padding(2)
        Me.input_presensi.Name = "input_presensi"
        Me.input_presensi.PlaceholderText = "Masukan Nilai Presensi"
        Me.input_presensi.Size = New System.Drawing.Size(196, 27)
        Me.input_presensi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Responsi"
        '
        'input_responsi
        '
        Me.input_responsi.Location = New System.Drawing.Point(32, 125)
        Me.input_responsi.Margin = New System.Windows.Forms.Padding(2)
        Me.input_responsi.Name = "input_responsi"
        Me.input_responsi.PlaceholderText = "Masukan Nilai Responsi"
        Me.input_responsi.Size = New System.Drawing.Size(196, 27)
        Me.input_responsi.TabIndex = 5
        '
        'input_tugas
        '
        Me.input_tugas.Location = New System.Drawing.Point(32, 193)
        Me.input_tugas.Margin = New System.Windows.Forms.Padding(2)
        Me.input_tugas.Name = "input_tugas"
        Me.input_tugas.PlaceholderText = "Masukan Nilai Tugas"
        Me.input_tugas.Size = New System.Drawing.Size(196, 27)
        Me.input_tugas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nilai Tugas"
        '
        'input_uas
        '
        Me.input_uas.Location = New System.Drawing.Point(33, 259)
        Me.input_uas.Margin = New System.Windows.Forms.Padding(2)
        Me.input_uas.Name = "input_uas"
        Me.input_uas.PlaceholderText = "Masukan Nilai UAS"
        Me.input_uas.Size = New System.Drawing.Size(196, 27)
        Me.input_uas.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nilai UAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hasil Akhir Nilai Mahasiswa"
        '
        'hasil_akhir
        '
        Me.hasil_akhir.AutoSize = True
        Me.hasil_akhir.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.hasil_akhir.Location = New System.Drawing.Point(299, 269)
        Me.hasil_akhir.Name = "hasil_akhir"
        Me.hasil_akhir.Size = New System.Drawing.Size(0, 37)
        Me.hasil_akhir.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 180)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ketentuan Nilai " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "> 86      =  A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "76 - 85  =  B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "66 - 75  =  C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "55 - 65  =  D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "< " &
    "56      =  E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 411)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 40)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Rayhan Rafiud Darojat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STI202102221"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 469)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hasil_akhir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.input_uas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.input_tugas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.input_responsi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input_presensi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Presensi)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Presensi As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents input_presensi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents input_responsi As TextBox
    Friend WithEvents input_tugas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents input_uas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hasil_akhir As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
