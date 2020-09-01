Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jari2 As Integer = TextBox1.Text
        Dim tinggi As Integer = TextBox2.Text

        Dim luasLingkaran As Double = Math.PI * jari2 ^ 2
        Dim volumeTabung As Double = luasLingkaran * tinggi

        Label4.Text = Math.Round(luasLingkaran, 2, MidpointRounding.AwayFromZero)
        Label6.Text = Math.Round(volumeTabung, 2, MidpointRounding.AwayFromZero)
    End Sub


End Class
