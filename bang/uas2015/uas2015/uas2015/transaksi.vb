Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class transaksi
    Dim koneksi As MySqlConnection
    Dim mc As New MySqlCommand
    Dim ma As New MySqlDataAdapter
    Dim mt As New DataTable
    Dim str As String
    Dim nama, member, perawatan, serum, moisturiser, mask, member1 As String
    Dim total, harga1, harga2, harga3, total1, total2, diskon, diskon1, bayar, kembali As Integer
    Sub konek()
        str = "Server=localhost;user id=root;password=; database=perawatan"
        koneksi = New MySqlConnection(str)
        koneksi.Open()
    End Sub
    Sub clear()
        Dim ct1 As Control
        For Each ct1 In Me.Controls
            If TypeOf ct1 Is TextBox Then
                ct1.Text = ""
            End If
        Next
    End Sub
    Sub clear1()
        Dim ct1 As Control
        For Each ct1 In Me.Controls
            If TypeOf ct1 Is ComboBox Then
                ct1.Text = ""
            End If
        Next
    End Sub
    Sub rawat()
        Dim dap As New MySqlDataAdapter("select*from transaksi", koneksi)
        Dim ble As New DataTable
        dap.Fill(ble)
        DataGridView1.DataSource = ble
    End Sub
    Private Sub transaksi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
        rawat()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call konek()
        nama = TextBox1.Text
        If RadioButton1.Checked Then
            perawatan = "Jerawat"
            If CheckBox1.Checked Then
                harga1 = 120000
                serum = "Ya"
            Else
                harga1 = 0
                serum = "Tidak"
            End If
            If CheckBox2.Checked Then
                harga2 = 90000
                moisturiser = "Ya"
            Else
                harga2 = 0
                moisturiser = "Tidak"
            End If
            If CheckBox3.Checked Then
                harga3 = 65000
                mask = "Ya"
            Else
                harga3 = 0
                mask = "Tidak"
            End If

        ElseIf RadioButton2.Checked Then
            perawatan = "Anti Aging"
            If CheckBox1.Checked Then
                harga1 = 150000
                serum = "Ya"
            Else
                harga1 = 0
                serum = "Tidak"
            End If
            If CheckBox2.Checked Then
                harga2 = 100000
                moisturiser = "Ya"
            Else
                harga2 = 0
                moisturiser = "Tidak"
            End If
            If CheckBox3.Checked Then
                harga3 = 80000
                mask = "Ya"
            Else
                harga3 = 0
                mask = "Tidak"
            End If
        Else
            MsgBox("Silahkan Pilih Perawatan")
        End If

        total1 = harga1 + harga2 + harga3

        If ComboBox1.Text = "Ya" Then
            diskon = total * 0.1
            member1 = "Ya"
        ElseIf ComboBox1.Text = "Tidak" Then
            diskon = total * 0
            member1 = "Tidak"
        Else
            diskon = 0
            member1 = "Tidak"
        End If
        total2 = total1 - diskon

        If total2 > 150000 Then
            diskon1 = total2 * 0.05
        ElseIf total2 < 150000 Then
            diskon1 = total2 * 0
        Else
            diskon1 = 0
        End If
        total = Val(total2 - diskon1)
        Label6.Text = total
        mc = New MySqlCommand("Insert into transaksi(id,nama,member,perawatan,serum,moisturiser,mask)values(NULL,'" &
                              nama & "','" &
                              member1 & "','" &
                              perawatan & "','" &
                              serum & "','" &
                              moisturiser & "','" &
                              mask & "')", koneksi)
        mc.ExecuteNonQuery()
        Dim dap1 As New MySqlDataAdapter("select * from transaksi where perawatan = '" & perawatan & "'", koneksi)
        Dim ble1 As New DataTable
        dap1.Fill(ble1)
        DataGridView1.DataSource = ble1
        rawat()
        clear()
        clear1()





    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Val(TextBox2.Text < Label6.Text) Then
            MsgBox("maaf duit kurang")
        Else
            bayar = TextBox2.Text
            kembali = bayar - total
            Label8.Text = kembali
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub
End Class
