Public Class Form1
    Dim nomor As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        nomor = TextBox1.Text
        For angka = 1 To nomor
            If angka >= 5 And angka <= 8 Then
                Continue For
            End If
            MsgBox(angka.ToString & "")
            If angka = 9 Then
                Exit For
            End If
        Next
        MsgBox("selesai")
    End Sub
End Class
