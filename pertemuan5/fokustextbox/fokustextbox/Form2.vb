Public Class Form2
    Dim harga, jumlah As Integer

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.Text
            Case "Laptop"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("acer")
                ComboBox2.Items.Add("thosiba")
                ComboBox2.Items.Add("asus")
            Case "Handphone"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("nokia")
                ComboBox2.Items.Add("samsung")
                ComboBox2.Items.Add("blackberry")
                ComboBox2.Items.Add("xiaomi")
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "acer"
                harga = 4500000
            Case "thosiba"
                harga = 5000000
            Case "asus"
                harga = 4000000
            Case "mac"
                harga = 7000000


            Case "nokia"
                harga = 2500000
            Case "samsung"
                harga = 4000000
            Case "blackberry"
                harga = 1000000
            Case "xiaomi"
                harga = 2000000
        End Select
        TextBox1.Text = harga
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        jumlah = Val(TextBox2.Text)
        TextBox3.Text = harga * jumlah
    End Sub
End Class