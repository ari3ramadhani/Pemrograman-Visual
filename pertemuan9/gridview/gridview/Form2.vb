Imports MySql.Data.MySqlClient
Public Class Form2
    Dim koneksi As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim start As String
    Dim timee As String
    Dim harga As String

    Sub konek()
        start = "server=localhost;user id=root;password=; database=mahasiswa"
        koneksi = New MySqlConnection(start)
        koneksi.Open()
    End Sub
    Sub trans()
        timee = Format(Now, "yyyyMMdd-hhmmss")

    End Sub
    Sub table1()
        Dim adapter = New MySqlDataAdapter("select * from mhs", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Sub table2()
        Dim adapter1 = New MySqlDataAdapter("select * from barang", koneksi)
        Dim table1 As New DataTable
        adapter1.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub
    Sub table3()
        Dim adapter2 = New MySqlDataAdapter("select * from transaksi", koneksi)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        DataGridView1.DataSource = table2
    End Sub
    Sub combo1()
        Dim muncul As New MySqlDataAdapter("select nim, nama from mhs group by nama", koneksi)
        Dim datase As New DataSet
        datase.Clear()
        muncul.Fill(datase, "transaksi")
        ComboBox1.DataSource = datase.Tables("transaksi")
        Me.ComboBox1.DisplayMember = "nama"
        Me.ComboBox1.ValueMember = "nim"
        TextBox3.Text = ComboBox1.ValueMember
    End Sub
    Sub combo2()
        Dim muncul1 As New MySqlDataAdapter("select id_barang,nama_barang from barang group by nama_barang", koneksi)
        Dim datase1 As New DataSet
        datase1.Clear()
        muncul1.Fill(datase1, "barang")
        ComboBox2.DataSource = datase1.Tables("barang")
        Me.ComboBox2.DisplayMember = "nama_barang"
        Me.ComboBox2.ValueMember = "id_barang"
        TextBox4.Text = ComboBox2.ValueMember
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
        trans()
        TextBox1.Text = timee
        combo1()
        combo2()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call konek()
        table1()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call konek()
        table3()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Call konek()
        table2()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Lengkapi data")
        Else
            Dim comm As New MySqlCommand("select harga from barang where id_barang = '" & ComboBox2.SelectedValue & "'", koneksi)
            Dim readd As MySqlDataReader
            readd = comm.ExecuteReader()
            If readd.Read Then
                harga = readd(0)
            End If
            koneksi.Close()
            Call konek()
            'Dim co As New MySqlCommand("Insert into transaksi(id,id_transaksi,id_barang,nim,jml_barang,tgl_transaksi) values (NULL,'" &
            '                           TextBox1.Text & "', '" & ComboBox2.SelectedValue & "','" & ComboBox1.SelectedValue &
            '                            TextBox2.Text & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')", koneksi)
            'co.ExecuteNonQuery()

            Dim co As New MySqlCommand("Insert into transaksi(id,nim,id_transaksi,id_barang,jml_barang,tgl_transaksi) values (NULL,'" &
                                      TextBox1.Text & "', '" & ComboBox1.SelectedValue & "','" & ComboBox2.SelectedValue & "','" &
                                      TextBox2.Text & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')", koneksi)
            co.ExecuteNonQuery()
            MsgBox("sukses")
        End If
    End Sub
End Class