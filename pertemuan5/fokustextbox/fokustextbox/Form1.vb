Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then
                MsgBox("Kolom 1 ini harus diisi")
                TextBox1.Focus()
            Else
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox2.Text = "" Then
                MsgBox("Kolom 2 harus diisi")
                TextBox2.Focus()
            Else
                TextBox3.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox3.Text = "" Then
                MsgBox("Kolom 3 harus diisi")
                TextBox3.Focus()
            Else
                TextBox4.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox4.Text = "" Then
                MsgBox("Kolom 4 harus diisi")
                TextBox4.Focus()
            Else
                Label5.Text = "Nama :" & TextBox1.Text & vbNewLine &
                            "Nim :" & TextBox2.Text & vbNewLine &
                            "Jurusan :" & TextBox3.Text & vbNewLine &
                            "Matkul :" & TextBox4.Text & vbNewLine


            End If
        End If
    End Sub


    Private Sub DataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataToolStripMenuItem.Click
        Data.Show()
        Me.Hide()
    End Sub
End Class
