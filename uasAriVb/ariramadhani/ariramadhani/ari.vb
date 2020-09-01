Imports MySql.Data.MySqlClient
Public Class ari
    Dim koneksi As MySqlConnection
    Dim mc As New MySqlCommand
    Dim ma As New MySqlDataAdapter
    Dim mt As New DataTable
    Dim str, cari As String
    Dim cb1, cb2, rb1, rb2 As String
    Dim pulau, jumlah, total, t1, t2 As Integer

    Sub konek()
        str = "Server=localhost;user id=root;password=; database=pesanan"
        koneksi = New MySqlConnection(str)
        koneksi.Open()
    End Sub
    Sub kirim()
        Dim dap As New MySqlDataAdapter("select*from kirim order by id desc", koneksi)
        Dim ble As New DataTable
        dap.Fill(ble)
        DataGridView1.DataSource = ble
    End Sub

    Private Sub ari_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call konek()
        kirim()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            rb1 = "Sumatera"
            If CheckBox1.Checked And CheckBox2.Checked Then
                cb1 = "Kilat & P. Belah"
                jumlah = Val(pulau * TextBox1.Text)
                t1 = Val(jumlah + 5000)
                t2 = Val((t1 * 10) / 100)
                total = t1 + t2
            ElseIf CheckBox1.Checked Then
                cb1 = "Kilat"
                If TextBox1.Text <= 5 Then
                    pulau = 20000
                ElseIf TextBox1.Text > 5 Then
                    pulau = 1500
                End If
                jumlah = Val(pulau * TextBox1.Text)
                total = Val((jumlah * 10) / 100)
                total = total + jumlah
            ElseIf CheckBox2.Checked Then
                cb1 = "Cairan/P.Belah"
                If TextBox1.Text <= 5 Then
                    pulau = 20000
                ElseIf TextBox1.Text > 5 Then
                    pulau = 1500
                End If
                jumlah = Val(pulau * TextBox1.Text)
                total = Val(jumlah + 5000)

            Else
                cb1 = "Tidak"
                If TextBox1.Text <= 5 Then
                    pulau = 20000
                    total = Val(pulau * TextBox1.Text)
                ElseIf TextBox1.Text > 5 Then
                    pulau = 1500
                    total = Val(pulau * TextBox1.Text)
                End If

            End If


        ElseIf RadioButton2.Checked Then
            rb1 = "Jawa"
            If CheckBox1.Checked And CheckBox2.Checked Then
                cb1 = "Kilat & P. Belah"
                jumlah = Val(pulau * TextBox1.Text)
                t1 = Val(jumlah + 5000)
                t2 = Val((t1 * 10) / 100)
                total = t1 + t2
            ElseIf CheckBox1.Checked Then
                cb1 = "Kilat"
                If TextBox1.Text <= 5 Then
                    pulau = 15000
                ElseIf TextBox1.Text > 5 Then
                    pulau = 1000
                End If
                jumlah = Val(pulau * TextBox1.Text)
                total = Val((jumlah * 10) / 100)
                total = total + jumlah

            ElseIf CheckBox2.Checked Then
                cb1 = "Cairan/P.Belah"
                If TextBox1.Text <= 5 Then
                    pulau = 15000
                ElseIf TextBox1.Text > 5 Then
                    pulau = 1000
                End If
                jumlah = Val(pulau * TextBox1.Text)
                total = Val(jumlah + 5000)
            ElseIf CheckBox1.Checked And CheckBox2.Checked Then
                total = total + total
            Else
                cb1 = "Tidak"
                If TextBox1.Text <= 5 Then
                    pulau = 15000
                    total = Val(pulau * TextBox1.Text)

                ElseIf TextBox1.Text > 5 Then
                    pulau = 1000
                    total = Val(pulau * TextBox1.Text)
                End If
            End If
        End If
        TextBox2.Text = total
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call konek()
        mc = New MySqlCommand("Insert into kirim(id,jenis,pulau,berat,total)values(NULL,'" &
                             cb1 & "','" &
                             rb1 & "','" &
                             TextBox1.Text & "','" &
                             total & "')", koneksi)
        mc.ExecuteNonQuery()
        kirim()
    End Sub
    
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        cari = TextBox3.Text
        Dim adapter As New MySqlDataAdapter("select * from kirim where total  <= '" & TextBox3.Text &
                                            "' ", koneksi)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class
