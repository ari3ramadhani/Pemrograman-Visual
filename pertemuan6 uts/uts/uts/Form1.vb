Public Class Form1
    Dim nama, golongan As String
    Dim id, jam, upah, lembur As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "A"
                upah = 10000
            Case "B"
                upah = 15000
            Case "C"
                upah = 20000
            Case "D"
                upah = 25000
        End Select
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        nama = TextBox1.Text
        id = Val(TextBox2.Text)
        golongan = ComboBox1.Text
        jam = Val(TextBox3.Text)
        If jam > 48 Then
            lembur = Val(TextBox3.Text) - 48
            lembur = lembur * 10000
            upah = upah * 48
        Else
            upah = upah * Val(TextBox3.Text)
            lembur = 0
        End If
        TextBox4.Text = "Nama =" & nama & vbNewLine &
                    "Id     =" & id & vbNewLine &
                    "Golongan= " & golongan & vbNewLine &
                    "Jam    =" & jam & vbNewLine &
                    "Upah   =" & upah + lembur & vbNewLine


    End Sub

End Class
