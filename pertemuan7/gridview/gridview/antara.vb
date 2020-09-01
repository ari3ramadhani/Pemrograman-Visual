Imports MySql.Data.MySqlClient
Public Class antara
    Dim koneksi As MySqlConnection
    Dim rd As MySqlDataReader
    Dim str, idp, cari As String
    Dim cmd As MySqlCommand
    Dim stok As Integer

    Sub konek()
        str = "Server=localhost; user id=root; password=; database=mahasiswa"
        koneksi = New MySqlConnection(Str)
        koneksi.Open()
    End Sub
    Sub showdata()
        Dim adapter As New MySqlDataAdapter("select * from mhs ",koneksi)
        Dim tb As New DataTable
        adapter.Fill(tb)
        DataGridView1.DataSource = tb
        koneksi.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub data()

        Dim adapter As New MySqlDataAdapter("select id,nim,nama,fakultas,jurusan,status,tanggal_masuk from mhs order by id desc", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adapter As New MySqlDataAdapter("select * from mhs where tanggal_masuk BETWEEN '" &
                                             DateTimePicker1.Text &
                                             "' And '" & DateTimePicker2.Text & "'", koneksi)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridView1.DataSource = tabel
    End Sub

    Private Sub antara_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
        data()
        showdata()
    End Sub
End Class