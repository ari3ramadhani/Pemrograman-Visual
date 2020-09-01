Public Class Data

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Hasil.Label1.Text = "Nama : " & TextBox1.Text & vbNewLine &
                            "Nim : " & TextBox2.Text & vbNewLine &
                            "Jurusan : " & TextBox3.Text & vbNewLine &
                            "Matkul : " & TextBox4.Text & vbNewLine
        Hasil.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class