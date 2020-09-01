Public Class Form1
    Dim hd, ha, td, ta, total, dewasa, anak As Integer
    Dim pp As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Garuda Indonesia"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Aceh")
                ComboBox2.Items.Add("Riau")
                ComboBox2.Items.Add("Medan")
                ComboBox2.Items.Add("Lampung")
            Case "Lion Air"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Balikpapan")
                ComboBox2.Items.Add("Samarinda")
                ComboBox2.Items.Add("Banjarmasin")
                ComboBox2.Items.Add("Tenggarong")
            Case "Sriwijaya Air"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Lombok")
                ComboBox2.Items.Add("Donggala")
                ComboBox2.Items.Add("Sigi")
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Aceh"
                hd = 3050000
                ha = 3010000
            Case "Riau"
                hd = 2050000
                ha = 2010000
            Case "Medan"
                hd = 10500000
                ha = 10100000
            Case "Lampung"
                hd = 550000
                ha = 110000

            Case "Balikpapan"
                hd = 3020000
                ha = 3010000
            Case "Samarinda"
                hd = 2020000
                ha = 2010000
            Case "Banjarmasin"
                hd = 1020000
                ha = 1010000
            Case "Tenggarong"
                hd = 1050000
                ha = 1010000

            Case "Lombok"
                hd = 3030000
                ha = 3010000
            Case "Donggala"
                hd = 2030000
                ha = 2010000
            Case "Sigi"
                hd = 2000000
                ha = 1000000
        End Select
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        td = Val(TextBox1.Text) * hd
        ta = Val(TextBox2.Text) * ha
        If CheckBox1.Checked Then
            td = td * 2
            ta = ta * 2
            hd = hd * 2
            ha = ha * 2
            pp = "Pulang Pergi"
        Else
            td = td * 1
            ta = ta * 1
            hd = hd * 1
            ha = ha * 1
            pp = "Pergi"
        End If
        TextBox3.Text = "Harga 1 tiket dewasa " & pp & hd & vbNewLine &
                        "Harga 1 tiket anak   " & pp & ha & vbNewLine &
                        "Jumlah harga tiket dewasa  " & td & vbNewLine &
                        "Jumlah harga tiket anak    " & ta & vbNewLine &
                        "Total harga tiket anda     " & td + ta & vbNewLine &
                        "Tiket anda                  " & pp
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
