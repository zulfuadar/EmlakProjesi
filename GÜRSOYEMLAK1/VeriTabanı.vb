Imports System.Data
Imports System.Data.OleDb
Public Class VeriTabanı
    'Bağlantı ayarları'
    Public bag As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=" & Environment.CurrentDirectory & "\gursoyemlak.accdb")
    Public cmd As OleDbCommand = New OleDbCommand
    Public cmd1 As OleDbCommand = New OleDbCommand
    Public dataTable As New DataTable



    'bağlantı kapatma ayarları'
    Public Sub conClose()
        bag.Close()
        cmd.Dispose()
    End Sub

    '"Insert" isimli bu metod 1 adet tablo ismi ve 1 adet String dizi(içerisinde kolon bilgileri olmalı) paremetrelerini alır
    'ByVal değeri fonksiyonlara parametre belirtmek için kullandığımız syntax(sintax)'dır'
    Public Sub Insert(ByVal tabloIsmi As String, ByVal kolonlar() As String)

        '"Insert" isimli metodun çağrıldığı yerden(kaydet butonu altında veriTabanı.Insert("EvSahibiBilgileri", kolonlarEvSahibiBilgileri) diyerek çağırmıştık) gönderilen string dizinin(içerisinde kullanıcıdan alınan kolon değerleri olan) uzunluğunu bir değişkene atadık
        Dim kolonSayısı As Integer = kolonlar.Length
        'gelen dizinin uzunluğu kadar soru işareti ürettik
        'bunun sebebi insert sorgusu oluştururken kaç kolona değer yazacağımızı belirtmemizdir
        Dim soruIsaretleri As String = "?"
        For i = 1 To (kolonlar.Length - 1)
            soruIsaretleri = soruIsaretleri + ","
            soruIsaretleri = soruIsaretleri + "?"
        Next

        'Gelen tablo ismi ve kaç kolona değer gireceğimizi sorguya yazdık'
        cmd = New OleDbCommand("INSERT INTO " & tabloIsmi & " VALUES(" & soruIsaretleri & ")", bag)

        'Bu sorguya TABLODAKİ KOLON SIRASIYLA değerlerin yazılması gerekiyor
        'Bu değerleri ise artık bilindiği üzere kolonlar dizisinden elde ediyoruz
        For i = 0 To (kolonSayısı - 1)
            cmd.Parameters.AddWithValue("@?", kolonlar(i))
        Next

        'sorguyu çalıştırıyoruz 
        cmd.ExecuteNonQuery()
    End Sub




End Class
