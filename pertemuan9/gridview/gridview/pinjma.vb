Imports MySql.Data.MySqlClient
Public Class pinjma
    Dim koneksi As MySqlConnection
    Dim adapter As MySqlDataAdapter 'nampilin data di data gridview
    Dim cari, start As String
    Sub konek()
        start = "server=localhost;user id=root;password=; database=mahasiswa"
        koneksi = New MySqlConnection(start)
        koneksi.Open()
    End Sub
    Sub data()
        Dim adapter As New MySqlDataAdapter("select id,lama_pinjam,tanggal_pinjam from pinjam order by id asc", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim com As New MySqlCommand("insert into pinjam(id,lama_pinjam,tanggal_pinjam) values (NULL,'" &
                                        TextBox1.Text &
                                        "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')", koneksi)
        com.ExecuteNonQuery()
        MsgBox("Data berhasil diinput")
        data()
    End Sub

    Private Sub pinjma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
        data()
    End Sub

    Private Sub LineShape1_Click(sender As System.Object, e As System.EventArgs) Handles LineShape1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim comand As New MySqlCommand("select * from pinjam where id= '", koneksi)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox2.Text = row.Cells(1).Value.ToString
            DateTimePicker2.Text = row.Cells(2).Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call konek()
        Dim time As Integer
        Dim time1 As DateTime = DateTimePicker2.Value
        Dim time2 As DateTime = Today()
        Dim rentang As TimeSpan = time2.Subtract(time1)
        Dim telat As Integer = rentang.TotalDays
        If telat > TextBox2.Text Then
            time = telat - TextBox2.Text
        Else
            time = 0
        End If
        Label8.Text = telat - TextBox2.Text
        Label6.Text = time * 1000


    End Sub

End Class