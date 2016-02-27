Imports System.Data
Imports System.Data.OleDb
Public Class KullanıcıEkle
    Public bag As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=gursoyemlak.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader = Nothing
    Public dataTable As New DataTable







    Public Sub conClose()
        bag.Close()
        cmd.Dispose()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If Me.kullaniciaditxt.Text = "" And sifretxt.Text = "" Then
            MsgBox("Lütfen Öncelikle Kaydetme Parametreleri Giriniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        Else
            Select Case MsgBox("Kullanıcı Kaydetme İşlemi Yapılacaktır Emin Misiniz?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes
                    MessageBox.Show("Kullanıcı Oluşturulmuştur.")
                Case MsgBoxResult.No
                    Return

            End Select

            bag.Open()
            cmd.Connection = bag
            cmd.CommandText = (("INSERT INTO Kullanıcı VALUES ('" + kullaniciaditxt.Text & "','") + sifretxt.Text & "','") + ComboBox1.Text & "')"
            cmd.ExecuteNonQuery()
            conClose()

        End If
    End Sub

    Private Sub KullanıcıEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class