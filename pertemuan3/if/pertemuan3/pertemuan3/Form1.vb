Public Class Form1
    Dim nilai As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nilai = TextBox1.Text

        If (nilai < 30) Then
            TextBox2.Text = "grade nilai anda E"
        End If
        If (nilai >= 30) And (nilai < 50) Then
            TextBox2.Text = "grade nilai anda D"
        End If
        If (nilai >= 50) And (nilai < 65) Then
            TextBox2.Text = "grade nilai anda C"
        End If
        If (nilai >= 65) And (nilai < 80) Then
            TextBox2.Text = "grade nilai anda B"
        End If
        If (nilai >= 80) And (nilai <= 100) Then
            TextBox2.Text = "grade nilai anda A"
        End If

    End Sub
End Class
