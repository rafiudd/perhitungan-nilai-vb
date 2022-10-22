Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Handle jika user tidak menginput form
        If input_presensi.Text.Length = 0 Then
            input_presensi.Text = 0
        End If

        If input_responsi.Text.Length = 0 Then
            input_responsi.Text = 0
        End If

        If input_tugas.Text.Length = 0 Then
            input_tugas.Text = 0
        End If

        If input_uas.Text.Length = 0 Then
            input_uas.Text = 0
        End If
        'Handle jika user tidak menginput form

        'Variable untuk menyimpan nilai huruf(A,B,C,D,E)
        Dim nilai_huruf

        'Jumlah semua hasil input
        hasil_akhir.Text = Convert.ToInt64(input_presensi.Text) + Convert.ToInt64(input_responsi.Text) + Convert.ToInt64(input_tugas.Text) + Convert.ToInt64(input_uas.Text)
        hasil_akhir.Text = Convert.ToInt64(hasil_akhir.Text)

        If hasil_akhir.Text > 86 Then
            nilai_huruf = " A"
        ElseIf hasil_akhir.Text < 86 And hasil_akhir.Text > 76 Then
            nilai_huruf = " B"
        ElseIf hasil_akhir.Text < 76 And hasil_akhir.Text > 66 Then
            nilai_huruf = " C"
        ElseIf hasil_akhir.Text < 66 And hasil_akhir.Text > 56 Then
            nilai_huruf = " D"
        Else
            nilai_huruf = " E"
        End If

        'Tambahkan nilai huruf ke hasil akhir
        hasil_akhir.Text += nilai_huruf
    End Sub

    Private Sub input_presensi_TextChanged(sender As Object, e As EventArgs) Handles input_presensi.TextChanged
        'Handle jika user menginput presensi lebih dari 20
        If input_presensi.TextLength > 0 Then
            If Convert.ToInt64(input_presensi.Text) > 20 Then
                input_presensi.Text = "20"
            End If
        End If
    End Sub

    Private Sub input_responsi_TextChanged(sender As Object, e As EventArgs) Handles input_responsi.TextChanged
        'Handle jika user menginput responsi lebih dari 10
        If input_responsi.TextLength > 0 Then
            If Convert.ToInt64(input_responsi.Text) > 10 Then
                input_responsi.Text = "10"
            End If
        End If
    End Sub

    Private Sub input_tugas_TextChanged(sender As Object, e As EventArgs) Handles input_tugas.TextChanged
        'Handle jika user menginput tugas lebih dari 25
        If input_tugas.TextLength > 0 Then
            If Convert.ToInt64(input_tugas.Text) > 25 Then
                input_tugas.Text = "25"
            End If
        End If
    End Sub

    Private Sub input_uas_TextChanged(sender As Object, e As EventArgs) Handles input_uas.TextChanged
        'Handle jika user menginput uas lebih dari 45
        If input_uas.TextLength > 0 Then
            If Convert.ToInt64(input_uas.Text) > 45 Then
                input_uas.Text = "45"
            End If
        End If
    End Sub
End Class
