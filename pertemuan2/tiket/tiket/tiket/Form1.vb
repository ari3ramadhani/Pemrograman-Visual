Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, hargama, hargase, hargami As Integer

        If ComboBox1.Text = "Ekonomi" Then
            harga = 30000
            Label1.Text = harga
            If CheckBox1.Checked Then
                hargama = 10000
                Label1.Text = harga
            End If
            If CheckBox2.Checked Then
                hargase = 5000
                Label1.Text = harga
            End If
            If CheckBox3.Checked Then
                hargami = 4000
                Label1.Text = harga
            End If
        ElseIf ComboBox1.Text = "Bisnis" Then
            harga = 50000
            Label1.Text = harga
            If CheckBox1.Checked Then
                hargama = 25000
                Label1.Text = harga
            End If
            If CheckBox2.Checked Then
                hargase = 15000
                Label1.Text = harga
            End If
            If CheckBox3.Checked Then
                hargami = 10000
                Label1.Text = harga
            End If
        Else 
            Label1.Text = "salah"
        End If
        Label1.Text = harga + hargama + hargase + hargami
    End Sub
End Class
