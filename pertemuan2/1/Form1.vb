Public Class Form1
    Dim angka1, angka2, hasil As Integer
    Dim hasil2 As Double
    Dim nama As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        angka1 = TextBox1.Text
        angka2 = TextBox2.Text
        hasil = angka1 + angka2
        nama = TextBox3.Text

        Label5.Text = nama
        Label3.Text = hasil
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        angka1 = TextBox1.Text
        angka2 = TextBox2.Text
        hasil = angka1 + angka2
        nama = TextBox3.Text

        Label5.Text = nama
        Label3.Text = hasil
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        angka1 = TextBox1.Text
        angka2 = TextBox2.Text
        hasil = angka1 - angka2
        nama = TextBox3.Text
        Label5.Text = nama

        Label3.Text = hasil
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        angka1 = TextBox1.Text
        angka2 = TextBox2.Text
        hasil = angka1 * angka2
        nama = TextBox3.Text

        Label5.Text = nama
        Label3.Text = hasil
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        angka1 = TextBox1.Text
        angka2 = TextBox2.Text
        nama = TextBox3.Text
        hasil2 = angka1 / angka2

        Label5.Text = nama
        Label3.Text = hasil2
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
