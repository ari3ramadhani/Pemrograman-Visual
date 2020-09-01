Public Class Form1
    Dim lpn, lp, cpn, cp, total As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            If CheckBox1.Checked Then
                lpn = 10000
            Else
                lpn = 0
            End If
            If CheckBox2.Checked Then
                lp = 8000
            Else
                lp = 0
            End If
        Else
            lpn = 0
            lp = 0
        End If
        If RadioButton2.Checked Then
            If CheckBox3.Checked Then
                cpn = 20000
            Else
                cpn = 0
            End If
            If CheckBox4.Checked Then
                cp = 15000
            Else
                cp = 0
            End If
        Else
            cpn = 0
            cp = 0
        End If
        total = lpn + lp + cpn + cp
        Label2.Text = total
    End Sub
End Class
