Public Class Admin_Paneli
    Dim adkullanici As String = "Gursoy"
    Dim adsifre As String = "GursoyKursat2211"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        adminsorgu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = adkullanici And TextBox2.Text = adsifre Then

        End If
        Form1.Show()

    End Sub


End Class