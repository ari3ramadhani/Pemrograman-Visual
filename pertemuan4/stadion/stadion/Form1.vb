Public Class Form1
    Dim harga, total As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Old Traffod"
                Select Case ComboBox2.Text
                    Case "VVIP"
                        harga = 500000
                    Case "VIP"
                        harga = 300000
                    Case "Ekonomi"
                        harga = 100000
                End Select
            Case "Camp Nou"
                Select Case ComboBox2.Text
                    Case "VVIP"
                        harga = 300000
                    Case "VIP"
                        harga = 200000
                    Case "Ekonomi"
                        harga = 100000
                End Select
            Case "GBK"
                Select Case ComboBox2.Text
                    Case "VVIP"
                        harga = 200000
                    Case "VIP"
                        harga = 100000
                    Case "Ekonomi"
                        harga = 50000
                End Select
            Case Else
                MsgBox("Anda Belum Memilih")
        End Select
        TextBox1.Text = "Nama stadion : " & ComboBox1.Text & vbNewLine &
            "Nama stadion : " & ComboBox2.Text & vbNewLine &
            "Dengan harga : " & harga

    End Sub
End Class
