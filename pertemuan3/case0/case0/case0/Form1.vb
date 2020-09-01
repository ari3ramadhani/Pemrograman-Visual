Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case CheckBox1.Checked
            Case True
                Label1.Text = " anda sudah bayar"
            Case False
                Label1.Text = " anda belum bayar"
        End Select
    End Sub
End Class
