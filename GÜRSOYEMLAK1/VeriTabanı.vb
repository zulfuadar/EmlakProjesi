Imports System.Data
Imports System.Data.OleDb
Public Class VeriTabanı
    'Bağlantı ayarları'
    Public bag As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=" & Environment.CurrentDirectory & "\gursoyemlak.accdb")
    Public cmd As OleDbCommand = New OleDbCommand
    Public cmd1 As OleDbCommand = New OleDbCommand

    Public dataTable As New DataTable


    Public Sub conClose()
        bag.Close()
        cmd.Dispose()
    End Sub


    Public Sub Insert(ByVal tabloIsmi As String, ByVal kolonlar() As String)


        Dim kolonSayısı As Integer = kolonlar.Length

        Dim soruIsaretleri As String = "?"
        For i = 1 To (kolonlar.Length - 1)
            soruIsaretleri = soruIsaretleri + ","
            soruIsaretleri = soruIsaretleri + "?"
        Next


        cmd = New OleDbCommand("INSERT INTO " & tabloIsmi & " VALUES(" & soruIsaretleri & ")", bag)


        For i = 0 To (kolonSayısı - 1)
            cmd.Parameters.AddWithValue("@?", kolonlar(i))
        Next
        cmd.ExecuteNonQuery()
    End Sub

    Public Function ReturnAllColumnsForDosyano(ByVal dosyaNoklasorNo As String) As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM MulkBilgileri,EvSahibiBilgileri, KiraciBilgileri, YonetimBilgileri  WHERE KiraciBilgileri.kiraci_tckimlik = (Select kiraci_tckimlik FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "') AND EvSahibiBilgileri.evsahibi_tckimlik = (SELECT evsahibi_tckimlik FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "') AND YonetimBilgileri.yonetim_tckimlik = (SELECT yonetim_tckimlik  FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "') AND MulkBilgileri.dosyano_klasorno = '" & dosyaNoklasorNo & "'", bag)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Return reader
    End Function
    Public Function ReturnAllColumnsForKiraci(ByVal KiraciTc As String) As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM MulkBilgileri,EvSahibiBilgileri, KiraciBilgileri, YonetimBilgileri  WHERE KiraciBilgileri.kiraci_tckimlik = (Select kiraci_tckimlik FROM MulkBilgileri WHERE kiraci_tckimlik = '" & KiraciTc & "') AND EvSahibiBilgileri.evsahibi_tckimlik = (SELECT evsahibi_tckimlik FROM MulkBilgileri WHERE kiraci_tckimlik = '" & KiraciTc & "') AND YonetimBilgileri.yonetim_tckimlik = (SELECT yonetim_tckimlik  FROM MulkBilgileri WHERE kiraci_tckimlik = '" & KiraciTc & "') AND MulkBilgileri.kiraci_tckimlik = '" & KiraciTc & "'", bag)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Return reader
    End Function
    Public Function ReturnAllColumnsForEvSahibi(ByVal EvSahibiTc As String) As OleDbDataReader
        cmd = New OleDbCommand("SELECT * FROM MulkBilgileri,EvSahibiBilgileri, KiraciBilgileri, YonetimBilgileri  WHERE KiraciBilgileri.kiraci_tckimlik = (Select kiraci_tckimlik FROM MulkBilgileri WHERE evsahibi_tckimlik= '" & EvSahibiTc & "') AND EvSahibiBilgileri.evsahibi_tckimlik = (SELECT evsahibi_tckimlik FROM MulkBilgileri WHERE evsahibi_tckimlik= '" & EvSahibiTc & "') AND YonetimBilgileri.yonetim_tckimlik = (SELECT yonetim_tckimlik  FROM MulkBilgileri WHERE evsahibi_tckimlik= '" & EvSahibiTc & "') AND MulkBilgileri.evsahibi_tckimlik= '" & EvSahibiTc & "'", bag)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Return reader
    End Function

    
End Class
