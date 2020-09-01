Public Class Form1
    Dim makanan, minuman, total, harga, harga1 As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If ListBox1.Text = "burger" Then
            makanan = 20000
        ElseIf ListBox1.Text = "pizza" Then
            makanan = 50000
        ElseIf ListBox1.Text = "sushi" Then
            makanan = 10000
        Else
            makanan = 0
        End If

        If ComboBox1.Text = "Makan disini" Then
            harga = makanan + 3000
        ElseIf ComboBox1.Text = "Bawa pulang" Then
            harga = makanan
        End If

        TextBox1.Text = "Selamat datang di restorsn kami" & vbNewLine &
                "Anda memesan makanan :" & ListBox1.Text & vbNewLine &
                "pesanan anda di : " & ComboBox1.Text & vbNewLine &
                "harga : " & harga


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ListBox2.Text = "teh sisri" Then
            minuman = 5000
        ElseIf ListBox2.Text = "jus" Then
            minuman = 10000
        ElseIf ListBox2.Text = "aqua gelas" Then
            minuman = 5000
        Else : minuman = 0
        End If
        If ComboBox2.Text = "Makan disini" Then
            harga1 = minuman + 3000
        ElseIf ComboBox2.Text = "Bawa pulang" Then
            harga1 = minuman
        End If
        TextBox2.Text = "Selamat datang di restorsn kami" & vbNewLine &
                "Anda memesan minuman :" & ListBox2.Text & vbNewLine &
                "pesanan anda di : " & ComboBox2.Text & vbNewLine &
                "harga : " & harga1

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        total = harga + harga1
        Label1.Text = "Total harga yang harus dibayar: " & total
    End Sub
End Class
