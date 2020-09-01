Public Class Form1
    Dim uts, uas, tugas As Integer
    Dim hasil As Double
    Dim nama, matkul, grade As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            matkul = RadioButton1.Text
        End If
        If RadioButton2.Checked Then
            matkul = RadioButton2.Text
        End If
        nama = TextBox1.Text
        If CheckBox1.Checked Then
            uts = Val(TextBox2.Text)
        Else
            TextBox2.Text = 0
            uts = 0
        End If
        If CheckBox2.Checked Then
            uas = Val(TextBox3.Text)
        Else
            TextBox3.Text = 0
            uas = 0
        End If
        If CheckBox3.Checked Then
            tugas = Val(TextBox4.Text)
        Else
            TextBox4.Text = 0
            tugas = 0
        End If

        hasil = (uts + uas + tugas) / 3
        If (hasil < 30) Then
            grade = "E"
        End If
        If (hasil >= 30) And (hasil < 50) Then
            grade = "D"
        End If
        If (hasil >= 50) And (hasil < 65) Then
            grade = "C"
        End If
        If (hasil >= 65) And (hasil < 80) Then
            grade = "B"
        End If
        If (hasil >= 80) And (hasil <= 100) Then
            grade = "A"
        End If
        TextBox5.Text =
        "Matkul  = " & matkul & vbNewLine &
        " Nama  = " & nama & vbNewLine &
        " UTS    = " & uts & vbNewLine &
        " UAS    = " & uas & vbNewLine &
        "TUGAS = " & tugas & vbNewLine &
        "Rata2  = " & FormatNumber(hasil, 2) & vbNewLine &
        "Grade  = " & grade
    End Sub
End Class
