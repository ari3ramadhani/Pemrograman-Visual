Public Class Form1
    Dim pensil As Integer = 4000
    Dim buku As Integer = 5000
    Dim penghapus As Integer = 3000

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jumlah As Integer
        Dim diskon As Integer
        Dim harga As Integer

        ' Jumlah harga barang sebelum diskon
        jumlah = (Val(TextBox1.Text) * pensil) +
            (Val(TextBox2.Text) * buku) +
            (Val(TextBox3.Text) * penghapus)
        Label7.Text = jumlah

        'Tentukan diskon
        If jumlah >= 25000 And jumlah <= 50000 Then
            diskon = jumlah * 0.05
        ElseIf jumlah > 50000 Then
            diskon = jumlah * 0.1
        Else
            diskon = 0
        End If
        lb_diskon.Text = diskon
        'Harga setelah diskon
        harga = jumlah - diskon
        lb_total.Text = harga
    End Sub
End Class
