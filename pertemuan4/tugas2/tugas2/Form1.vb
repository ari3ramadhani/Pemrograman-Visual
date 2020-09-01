Public Class Form1
    Dim nama, maaf As String
    Dim total, baju, celana, bajuj, celanaj As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        nama = TextBox1.Text
        If ListBox1.Text = "Kemeja" Then
            If ComboBox1.Text = "S" Then
                baju = 100000
            ElseIf ComboBox1.Text = "M" Then
                baju = 150000
            ElseIf ComboBox1.Text = "L" Then
                baju = 200000
            End If
        ElseIf ListBox1.Text = "Polo" Then
            If ComboBox1.Text = "S" Then
                baju = 50000
            ElseIf ComboBox1.Text = "M" Then
                baju = 75000
            ElseIf ComboBox1.Text = "L" Then
                baju = 85000
            End If
        ElseIf ListBox1.Text = "Kaos" Then
            If ComboBox1.Text = "S" Then
                baju = 30000
            ElseIf ComboBox1.Text = "M" Then
                baju = 40000
            ElseIf ComboBox1.Text = "L" Then
                baju = 50000
            End If
        Else
            baju = 0
        End If
        If Val(TextBox2.Text) < 4 Then
            bajuj = Val(TextBox2.Text)
        Else
            TextBox2.Text = 0
        End If

        If ListBox2.Text = "Jeans" Then
            If ComboBox2.Text = "S" Then
                celana = 200000
            ElseIf ComboBox2.Text = "M" Then
                celana = 250000
            ElseIf ComboBox2.Text = "L" Then
                celana = 300000
            End If
        ElseIf ListBox2.Text = "Joger" Then
            If ComboBox2.Text = "S" Then
                celana = 120000
            ElseIf ComboBox2.Text = "M" Then
                celana = 130000
            ElseIf ComboBox2.Text = "L" Then
                celana = 140000
            End If
        ElseIf ListBox2.Text = "Boxer" Then
            If ComboBox2.Text = "S" Then
                celana = 12000
            ElseIf ComboBox2.Text = "M" Then
                celana = 13000
            ElseIf ComboBox2.Text = "L" Then
                celana = 15000
            End If
        Else
            celana = 0
        End If
        celanaj = Val(TextBox3.Text)



        TextBox4.Text = "Selamat datang di toko kami" & vbNewLine &
            "Nama           : " & nama & vbNewLine &
             "Beli baju     : " & ListBox1.Text & vbNewLine &
             "Ukuran baju   : " & ComboBox1.Text & vbNewLine &
             "Jumlah baju   : " & TextBox2.Text & vbNewLine &
             "Harga baju    : " & baju * bajuj & vbNewLine &
             "Beli celana   : " & ListBox2.Text & vbNewLine &
             "Ukuran celana : " & ComboBox2.Text & vbNewLine &
             "Jumlah celana : " & TextBox3.Text & vbNewLine &
             "Harga celana  : " & celana * celanaj & vbNewLine &
             "Total         : " & (baju * bajuj) + (celana * celanaj) & vbNewLine

    End Sub
End Class
