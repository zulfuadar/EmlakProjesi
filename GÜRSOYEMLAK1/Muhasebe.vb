Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Public bag As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=gursoyemlak.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim cmd2 As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader = Nothing
    Dim reader2 As OleDbDataReader
    Dim adtr As New OleDbDataAdapter
    Public dataTable As New DataTable
    Dim dtst As New DataSet

    Public Sub conClose()
        bag.Close()
        cmd.Dispose()

    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click

        If kiraciTc.Text = "" Then
            MsgBox("Lütfen Öncelikle Arama Parametreleri Giriniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        Else


            Dim muser As String

            Dim sql As String

            If kiraciTc.Text <> String.Empty Then

                muser = kiraciTc.Text
                sql = "SELECT * FROM tablo WHERE kiracitc='" & muser & "'"

            End If


            bag.Open()
            cmd = New OleDbCommand(sql, bag)

            reader = cmd.ExecuteReader()

            reader.Read()

            kiraciAd.Text = reader.GetString(8)
            kiraciSoyad.Text = reader.GetString(9)
            kiraciTc.Text = reader.GetString(10)

            conClose()

            bag.Open()


            adtr = New OleDbDataAdapter("select * From Muhasebe", bag)
            adtr.Fill(dtst, "Muhasebe")
            DataGridView1.DataSource = dtst
            DataGridView1.DataMember = "Muhasebe"
            adtr = New OleDbDataAdapter("select * From Muhasebe", bag)
            adtr.Fill(dtst, "Muhasebe")
            DataGridView2.DataSource = dtst
            DataGridView2.DataMember = "Muhasebe"
            adtr = New OleDbDataAdapter("select * From Muhasebe", bag)
            adtr.Fill(dtst, "Muhasebe")
            DataGridView3.DataSource = dtst
            DataGridView3.DataMember = "Muhasebe"
            conClose()
            arabtn.Enabled = False

        End If
    End Sub

    Private Sub arsivbtn_Click(sender As Object, e As EventArgs) Handles arsivbtn.Click
        Dim sql As String
        Dim sql2 As String

        sql = "INSERT INTO  MuhasebeArsiv (kiracitc,kiracimuhasebetarih,kiracidanalinan,kiracidepozito,kiracikomisyon,kiracidanaidat,kiracitoplam,evsahibitarih,evsahibineödenen,evsahibikesinti,evsahibikesintituru,evsahibidekontno,evsahibitoplam,yonetimtarih,yonetimodenen,yonetimbanka,yonetimbankano,yonetimodemeyapankisi,yonetimtoplam) SELECT * FROM Muhasebe"
        sql2 = "DELETE FROM Muhasebe "
        bag.Open()
        cmd = New OleDbCommand(sql, bag)
        cmd.ExecuteNonQuery()
        conClose()
        bag.Open()
        cmd = New OleDbCommand(sql2, bag)
        cmd.ExecuteNonQuery()
        conClose()

        MsgBox("Veriler Arşive Taşınmıştır.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
