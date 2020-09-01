Imports MySql.Data.MySqlClient
Public Class login
    Dim koneksi As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim start As String
    Dim username, password, id, level As String

    Sub konek()
        start = "server=localhost;user id=root;password=; database=mahasiswa"
        koneksi = New MySqlConnection(start)
        koneksi.Open()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        username = TextBox1.Text
        password = TextBox2.Text
        Call konek()

        Dim command As New MySqlCommand("select *from login where username '" & username &
                                        "' And password = '" & password & "'", koneksi)
        Dim read As MySqlDataReader
        read = command.ExecuteReader()
        read.Read()
        If read.HasRows Then
            id = read.Item("id")
            level = read.Item("level")
            If level = "admin" Then
                pinjma.Show()
                Me.Hide()
            ElseIf level = "user" Then
                pinjma.Show()
                Me.Hide()
            End If
            clear()

        End If
    End Sub

End Class