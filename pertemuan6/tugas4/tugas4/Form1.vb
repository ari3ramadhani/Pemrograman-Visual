Public Class Form1
    Dim nama, sy, py, dokter, sakit, rawat, suster As String
    Dim bayar, bsuster, bcowo, hanap, halan As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Spesialis"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Panas")
                ComboBox2.Items.Add("Batuk")
            Case "Mata"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Katarak")
                ComboBox2.Items.Add("Rabun")
            Case "Kandungan"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Hamil")
                ComboBox2.Items.Add("Ngegugurin")
        End Select
        dokter = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Panas"
            Case "Batuk"
            Case "Katarak"
            Case "Rabun"
            Case "Hamil"
            Case "Ngegugurin"
        End Select
        sakit = ComboBox2.Text
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If ComboBox2.Text = "Panas" Then
            hanap = 100000
        ElseIf ComboBox2.Text = "Batuk" Then
            hanap = 80000
        ElseIf ComboBox2.Text = "Katarak" Then
            hanap = 700000
        ElseIf ComboBox2.Text = "Rabun" Then
            hanap = 800000
        ElseIf ComboBox2.Text = "Hamil" Then
            hanap = 900000
        ElseIf ComboBox2.Text = "Ngegugurin" Then
            hanap = 700000
        End If
        bayar = hanap
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If ComboBox2.Text = "Panas" Then
            halan = 50000
        ElseIf ComboBox2.Text = "Batuk" Then
            halan = 40000
        ElseIf ComboBox2.Text = "Katarak" Then
            halan = 500000
        ElseIf ComboBox2.Text = "Rabun" Then
            halan = 600000
        ElseIf ComboBox2.Text = "Hamil" Then
            halan = 700000
        ElseIf ComboBox2.Text = "Ngegugurin" Then
            halan = 500000
        End If
        bayar = halan
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        nama = TextBox1.Text
        If RadioButton1.Checked Then
            rawat = "Inap"
        ElseIf RadioButton2.Checked Then
            rawat = "Jalan"
        End If
        If CheckBox1.Checked Then
            sy = "Ya"
            bsuster = 100000
        Else
            sy = "Tidak"
            bsuster = 0
        End If
        If CheckBox2.Checked Then
            py = "Ya"
            bcowo = 200000
        Else
            py = "Tidak"
            bcowo = 0
        End If
        TextBox2.Text = "Nama            :" & nama & vbNewLine &
                        "Dokter          :" & dokter & vbNewLine &
                        "Sakit                :" & sakit & vbNewLine &
                        "Rawat              :" & rawat & vbNewLine &
                        "Suster               :" & sy & " biayanya :" & bsuster & vbNewLine &
                        "Perawat cowok:" & py & " biayanya :" & bcowo & vbNewLine &
                        "Biaya rawat        :" & rawat & " " & bayar & vbNewLine &
                        "Biaya total         :" & Val(bayar + bsuster + bcowo)
    End Sub

End Class
