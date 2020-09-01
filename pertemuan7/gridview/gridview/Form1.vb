Imports MySql.Data.MySqlClient
Public Class Form1
    Dim koneksi As MySqlConnection
    Dim adapter As MySqlDataAdapter 'nampilin data di data gridview
    Dim cari, start As String
    Sub konek()
        start = "server=localhost;user id=root;password=; database=mahasiswa"
        koneksi = New MySqlConnection(start)
        koneksi.Open()
    End Sub
    Sub table()
        adapter = New MySqlDataAdapter("select * from mhs", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        table()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim com As New MySqlCommand("insert into mhs(id,nim,nama,fakultas,jurusan,status,tanggal_masuk) values (NULL,'" &
                                        TextBox2.Text & "', '" & TextBox3.Text & "', '" &
                                        TextBox4.Text & "', '" & TextBox5.Text & "', '" &
                                        TextBox6.Text & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')", koneksi)
        com.ExecuteNonQuery()
        MsgBox("Data berhasil diinput")
        table()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        cari = TextBox1.Text
        Dim adapter As New MySqlDataAdapter("select * from mhs where nama like '%" & cari &
                                            "%' or nim like'%" & cari &
                                            "%'", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged, TextBox6.TextChanged

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click, Label5.Click, Label6.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        antara.show()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox2.Text = row.Cells(1).Value.ToString
            TextBox3.Text = row.Cells(2).Value.ToString
            TextBox4.Text = row.Cells(3).Value.ToString
            TextBox5.Text = row.Cells(4).Value.ToString
            TextBox6.Text = row.Cells(4).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand
        konek()
        Try
            cmd = koneksi.CreateCommand()
            cmd.CommandText = "update mhs set nim=@nim , nama=@nama , fakulas=@fakultas , jurusan=@jurusan , status=@status where nim=@nim"
            cmd.Parameters.AddWithValue("@nim", TextBox2.Text)
            cmd.Parameters.AddWithValue("@nama", TextBox3.Text)
            cmd.Parameters.AddWithValue("@fakultas", TextBox4.Text)
            cmd.Parameters.AddWithValue("@jurusan", TextBox5.Text)
            cmd.Parameters.AddWithValue("@status", TextBox6.Text)
            cmd.ExecuteNonQuery()
            table()

            MessageBox.Show("Ubah Data Barang Berhasil")
        Catch ex As Exception

        End Try
    End Sub
End Class