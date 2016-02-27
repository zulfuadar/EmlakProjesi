Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles yeniKayıtBtn.Click
        If Me.dosyaNo.Text = "" Then
            MsgBox("Lütfen Öncelikle Kaydetme Parametreleri Giriniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        Else
            Select Case MsgBox("Kaydetme İşlemi Yapılacaktır Emin Misiniz?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes

                    'Bu class sonradan tanımlandı. Projeye bakarak görebilirsiniz. 
                    'İşlevi 07.02.2015 tarihi itibariyle sadece insert yapmak.
                    'ileride tüm veritabanı işlemlerini bu class üzerinden yazacağız
                    'Aşağıda "VeriTabanı" isimli classdan "veriTabanı" isimli nesneyi türettik.
                    'veriTabanı.bag.Open() metoduyla veritabanını aktif ettik
                    Dim veriTabanı As New VeriTabanı
                    veriTabanı.bag.Open()

                    'Evsahibi bilgilerini ve Kiraci bilgilerini birer DİZİ! oluşturarak kullanıcıdan almış olduk
                    'Görüldüğü üzere 2 diziyede boyut vermedik. Bunun sebebi içlerine yazdığımız değer kadar boyutları olmaları
                    'Örneğin kolonlarEvSahibiBilgileri dizisinin boyutu 11 olur. 
                    Dim kolonlarEvSahibiBilgileri() As String = {esTcKimlik.Text, esAdı.Text, esSoyadı.Text, esTelefon.Text, esAdres.Text, esVekili.Text, esVekilTelno.Text, hesapAdSoyad.Text, hesapHesapNO.Text, hesapIbanNO.Text, hesapBanka.Text}
                    Dim kolonlarKiraciBilgileri() As String = {kTcKimlik.Text, kAd.Text, kSoyad.Text, kTelefon.Text, kAdres.Text, notlarElektirik.Text, notlarSu.Text, notlarDogalGaz.Text, notlarYakıt.Text, notlarKira.Text, notlarBoya.Text, notlarTesisat.Text, notlarCtv.Text, notlarDigerHasarlar.Text, notlarToplam.Text, notlarNotlar.Text}
                    Dim kolonlarYonetici() As String = {yonetimTC.Text, yonetimAd.Text, yonetimSoyad.Text, yonetimTelefon.Text, yonetimKaloriferci.Text, yonetimKaloriferciTel.Text, yonetimYakıt.Text, yonetimOnarım.Text, yonetimDiger.Text}
                    Dim kolonlarMulkBilgileri() As String = {yonetimTC.Text, esTcKimlik.Text, kTcKimlik.Text, dosyaNo.Text + klasorNO.Text, aMahalle.Text, aSokak.Text, aApart.Text, aApartmanNo.Text, aDaireNo.Text, aAdresKodu.Text, aBinaKodu.Text, aFaturaNo.Text, eskikiraAdı.Text, eskikiracıSoyad.Text, eskikiracıTcKimlikNo.Text, eskikiracıTelefonNo.Text, eskikiracıAdres.Text, suEabone.Text, suYabone.Text, suSicil.Text, suGosterge.Text, suKimAdınaKayıtlı.Text, elektirkKarne.Text, elektrikSıra.Text, elektrikAbone.Text, elektrikGosterge.Text, elektrikKimAdınaKayıtlı.Text, gazBinaNo.Text, gazSayacNo.Text, gazAbone.Text, gazGosterge.Text, gazKimAdınaKayıtlı.Text, depremsigortaAdSoyad.Text, depremsigortasıBaslangicTarihi.Text, depremsigortasıDaskPoliceNO.Text, depremsigortasiBitisTarihi.Text, depremsigortasıKimYatıracak.Text}
                    Dim kolonlarYonetimMuhasebe() As String = {yonetimTC.Text, dosyaNo.Text + klasorNO.Text, "", "", "", "", "", ""}
                    Dim kolonlarEvSahibiMuhasebe() As String = {esTcKimlik.Text, dosyaNo.Text + klasorNO.Text, "", "", "", "", "", ""}
                    Dim kolonlarKiraciMuhasebe() As String = {kTcKimlik.Text, dosyaNo.Text + klasorNO.Text, kAd.Text, kSoyad.Text, "", "", "", "", "", ""}

                    'VeriTabanı classından türettiğimiz veriTabanı nesnesinin Insert metodunu çağırdık'
                    'Bu metod 2 parametre alıyor
                    '1. parametre hangi tabloya insert işlemi yapacaksak o tablonun ismi.
                    '2. parametre ise o tabloya değerler. Bu değerler aşağıdaki kolonlarEvSahibiBilgileri örneğinde olduğu gibi String dizi tipinde olmalıdır.
                    veriTabanı.Insert("EvSahibiBilgileri", kolonlarEvSahibiBilgileri)
                    veriTabanı.Insert("KiraciBilgileri", kolonlarKiraciBilgileri)
                    veriTabanı.Insert("YonetimBilgileri", kolonlarYonetici)
                    veriTabanı.Insert("MulkBilgileri", kolonlarMulkBilgileri)
                    veriTabanı.Insert("YonetimMuhasebe", kolonlarYonetimMuhasebe)
                    veriTabanı.Insert("EvSahibiMuhasebe", kolonlarEvSahibiMuhasebe)
                    veriTabanı.Insert("KiraciMuhasebe", kolonlarKiraciMuhasebe)
                    'VeriTabanı classından türettiğimiz veriTabanı nesnesinin conClose metodunu çağırdık'
                    veriTabanı.conClose()

                    MsgBox("Kayıt işlemi gerçekleştirildi !")
                Case MsgBoxResult.No
                    Return
            End Select
        End If

    End Sub

    Private Sub araBtn_Click(sender As Object, e As EventArgs) Handles araBtn.Click

        'If Me.dosyaNo.Text = "" And klasorNO.Text = "" Then
        '    MsgBox("Lütfen Öncelikle Arama Parametreleri Giriniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        'Else


        '    Dim dosyaNoklasorNo As String = dosyaNo.Text
        '    Dim sql = "SELECT * FROM EvSahibiBilgileri, KiraciBilgileri, YonetimBilgileri  WHERE KiraciBilgileri.kiraci_tckimlik = (Select kiraci_tckimlik FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "') AND EvSahibiBilgileri.evsahibi_tckimlik = (SELECT evsahibi_tckimlik FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "') AND YonetimBilgileri.yonetim_tckimlik = (SELECT yonetim_tckimlik  FROM MulkBilgileri WHERE dosyano_klasorno = '" & dosyaNoklasorNo & "')"
        '    bag.Open()
        '    cmd = New OleDbCommand(sql, bag)
        '    Dim reader As OleDbDataReader = cmd.ExecuteReader()

        '    While reader.Read
        '        dosyaNo.Text = reader.GetInt32(0)
        '        esAdı.Text = reader.GetString(1)
        '        esSoyadı.Text = reader.GetString(2)
        '        esTcKimlik.Text = reader.GetString(3)
        '        esTelefon.Text = reader.GetString(4)
        '        esAdres.Text = reader.GetString(5)
        '        esVekili.Text = reader.GetString(6)
        '        esVekilTelno.Text = reader.GetString(7)
        '        kAd.Text = reader.GetString(8)
        '        kSoyad.Text = reader.GetString(9)
        '        kTcKimlik.Text = reader.GetString(10)
        '        kTelefon.Text = reader.GetString(11)
        '        kAdres.Text = reader.GetString(12)
        '        aMahalle.Text = reader.GetString(13)
        '        aSokak.Text = reader.GetString(14)
        '        aApart.Text = reader.GetString(15)
        '        aApartmanNo.Text = reader.GetString(16)
        '        aDaireNo.Text = reader.GetString(17)
        '        aAdresKodu.Text = reader.GetString(18)
        '        aBinaKodu.Text = reader.GetString(19)
        '        aFaturaNo.Text = reader.GetString(20)
        '        suEabone.Text = reader.GetString(21)
        '        suYabone.Text = reader.GetString(22)
        '        suSicil.Text = reader.GetString(23)
        '        suGosterge.Text = reader.GetString(24)
        '        suKimAdınaKayıtlı.Text = reader.GetString(25)
        '        elektirkKarne.Text = reader.GetString(26)
        '        elektrikSıra.Text = reader.GetString(27)
        '        elektrikAbone.Text = reader.GetString(28)
        '        elektrikGosterge.Text = reader.GetString(29)
        '        elektrikKimAdınaKayıtlı.Text = reader.GetString(30)
        '        gazBinaNo.Text = reader.GetString(31)
        '        gazSayacNo.Text = reader.GetString(32)
        '        gazAbone.Text = reader.GetString(33)
        '        gazGosterge.Text = reader.GetString(34)
        '        gazKimAdınaKayıtlı.Text = reader.GetString(35)
        '        yonetimAd.Text = reader.GetString(36)
        '        yonetimSoyad.Text = reader.GetString(37)
        '        yonetimTelefon.Text = reader.GetString(38)
        '        yonetimKaloriferci.Text = reader.GetString(39)
        '        yonetimKaloriferciTel.Text = reader.GetString(40)
        '        yonetimYakıt.Text = reader.GetString(41)
        '        yonetimOnarım.Text = reader.GetString(42)
        '        yonetimDiger.Text = reader.GetString(43)
        '        eskikiraAdı.Text = reader.GetString(44)
        '        eskikiracıSoyad.Text = reader.GetString(45)
        '        eskikiracıTcKimlikNo.Text = reader.GetString(46)
        '        eskikiracıTelefonNo.Text = reader.GetString(47)
        '        eskikiracıAdres.Text = reader.GetString(48)
        '        hesapAdSoyad.Text = reader.GetString(49)
        '        hesapHesapNO.Text = reader.GetString(50)
        '        hesapIbanNO.Text = reader.GetString(51)
        '        hesapBanka.Text = reader.GetString(52)
        '        depremsigortaAdSoyad.Text = reader.GetString(53)
        '        depremsigortasıBaslangicTarihi.Text = reader.GetString(54)
        '        depremsigortasıDaskPoliceNO.Text = reader.GetString(55)
        '        depremsigortasiBitisTarihi.Text = reader.GetString(56)
        '        depremsigortasıKimYatıracak.Text = reader.GetString(57)
        '        notlarElektirik.Text = reader.GetString(58)
        '        notlarSu.Text = reader.GetString(59)
        '        notlarDogalGaz.Text = reader.GetString(60)
        '        notlarYakıt.Text = reader.GetString(61)
        '        notlarKira.Text = reader.GetString(62)
        '        notlarBoya.Text = reader.GetString(63)
        '        notlarTesisat.Text = reader.GetString(64)
        '        notlarCtv.Text = reader.GetString(65)
        '        notlarDigerHasarlar.Text = reader.GetString(66)
        '        notlarToplam.Text = reader.GetString(67)
        '        notlarNotlar.Text = reader.GetString(68)
        '        klasorNO.Text = reader.GetString(69)

        '    End While
        '    reader.Close()
        '    conClose()
        'End If
    End Sub
    Public Sub Temizle()
        dosyaNo.Clear()
        esAdı.Clear()
        esSoyadı.Clear()
        esTcKimlik.Clear()
        esTelefon.Clear()
        esAdres.Clear()
        esVekili.Clear()
        esVekilTelno.Clear()
        kAd.Clear()
        kSoyad.Clear()
        kTcKimlik.Clear()
        kTelefon.Clear()
        kAdres.Clear()
        aMahalle.Clear()
        aSokak.Clear()
        aApart.Clear()
        aApartmanNo.Clear()
        aDaireNo.Clear()
        aAdresKodu.Clear()
        aBinaKodu.Clear()
        aFaturaNo.Clear()
        suEabone.Clear()
        suYabone.Clear()
        suSicil.Clear()
        suGosterge.Clear()
        suKimAdınaKayıtlı.Clear()
        elektirkKarne.Clear()
        elektrikSıra.Clear()
        elektrikAbone.Clear()
        elektrikGosterge.Clear()
        elektrikKimAdınaKayıtlı.Clear()
        gazBinaNo.Clear()
        gazSayacNo.Clear()
        gazAbone.Clear()
        gazGosterge.Clear()
        gazKimAdınaKayıtlı.Clear()
        yonetimAd.Clear()
        yonetimSoyad.Clear()
        yonetimTelefon.Clear()
        yonetimKaloriferci.Clear()
        yonetimKaloriferciTel.Clear()
        yonetimYakıt.Clear()
        yonetimOnarım.Clear()
        yonetimDiger.Clear()
        eskikiraAdı.Clear()
        eskikiracıSoyad.Clear()
        eskikiracıTcKimlikNo.Clear()
        eskikiracıTelefonNo.Clear()
        eskikiracıAdres.Clear()
        hesapAdSoyad.Clear()
        hesapHesapNO.Clear()
        hesapIbanNO.Clear()
        hesapBanka.Clear()
        depremsigortaAdSoyad.Clear()
        depremsigortasıBaslangicTarihi.Clear()
        depremsigortasıDaskPoliceNO.Clear()
        depremsigortasiBitisTarihi.Clear()
        depremsigortasıKimYatıracak.Clear()
        notlarElektirik.Clear()
        notlarSu.Clear()
        notlarDogalGaz.Clear()
        notlarYakıt.Clear()
        notlarKira.Clear()
        notlarBoya.Clear()
        notlarTesisat.Clear()
        notlarCtv.Clear()
        notlarDigerHasarlar.Clear()
        notlarToplam.Clear()
        notlarNotlar.Clear()
        klasorNO.Clear()
    End Sub
    Private Sub temizleBtn_Click(sender As Object, e As EventArgs) Handles temizleBtn.Click
        Temizle()

    End Sub


    Private Sub guncelleBtn_Click(sender As Object, e As EventArgs) Handles guncelleBtn.Click


        'Dim tuser As String
        'Dim muser As String
        'Dim sql As String
        'If dosyaNo.Text <> String.Empty And klasorNO.Text <> String.Empty Then
        '    tuser = dosyaNo.Text
        '    muser = klasorNO.Text
        '    sql = "UPDATE tablo SET evad ='" & esAdı.Text & "' , evsoyad ='" & esSoyadı.Text & "' , evtc ='" & esTcKimlik.Text & "', evtelefon='" & esTelefon.Text & "', evadres='" & esAdres.Text & "' , vekil='" & esVekili.Text & "' , vekiltel='" & esVekilTelno.Text & "' , kiraciad='" & kAd.Text & "' , kiracisoyad='" & kSoyad.Text & "', kiracitc='" & kTcKimlik.Text & "' , kiracitel='" & kTelefon.Text & "' , kiraciadres='" & kAdres.Text & "' , mahalle='" & aMahalle.Text & "' , sokak='" & aSokak.Text & "' , apartman='" & aApart.Text & "' , apartmanno='" & aApartmanNo.Text & "' , daireno='" & aDaireNo.Text & "' , adreskodu='" & aAdresKodu.Text & "' , binakodu='" & aBinaKodu.Text & "' , faturano='" & aFaturaNo.Text & "' , sueabone='" & suEabone.Text & "' , suyabone='" & suYabone.Text & "' , susicil='" & suSicil.Text & "' , sugosterge='" & suGosterge.Text & "' , sukayit='" & suKimAdınaKayıtlı.Text & "' , elektrikkarne='" & elektirkKarne.Text & "' , elektriksira='" & elektrikSıra.Text & "' , elektrikabone='" & elektrikAbone.Text & "' , elektrikgosterge='" & elektrikGosterge.Text & "' , elektrikkayit='" & elektrikKimAdınaKayıtlı.Text & "' , gazbinano='" & gazBinaNo.Text & "' , gazsayacno='" & gazSayacNo.Text & "' , gazabone='" & gazAbone.Text & "' , gazgosterge='" & gazGosterge.Text & "' , gazkayit='" & gazKimAdınaKayıtlı.Text & "' , yonetimad='" & yonetimAd.Text & "' , yonetimsoyad='" & yonetimSoyad.Text & "' , yonetimtel='" & yonetimTelefon.Text & "' , kaloriferci='" & yonetimKaloriferci.Text & "' , kalorifercitel='" & yonetimKaloriferciTel.Text & "' , yakit='" & yonetimYakıt.Text & "' , onarım='" & yonetimOnarım.Text & "' , diger='" & yonetimDiger.Text & "' , eskikiraciad='" & eskikiraAdı.Text & "' , eskikiracisoyad='" & eskikiracıSoyad.Text & "' , eskikiracitc='" & eskikiracıTcKimlikNo.Text & "' , eskikiracitel='" & eskikiracıTelefonNo.Text & "' , eskikiraciadres='" & eskikiracıAdres.Text & "' , hesapadsoyad='" & hesapAdSoyad.Text & "' , hesapno='" & hesapHesapNO.Text & "' , ibanno='" & hesapIbanNO.Text & "' , banka='" & hesapBanka.Text & "' , depremadsoyad='" & depremsigortaAdSoyad.Text & "' , başlangictarihi='" & depremsigortasıBaslangicTarihi.Text & "' , daskpoliceno='" & depremsigortasıDaskPoliceNO.Text & "' , bitistarihi='" & depremsigortasiBitisTarihi.Text & "' , kimyatiracak='" & depremsigortasıKimYatıracak.Text & "' , notelektrik='" & notlarElektirik.Text & "' , notsu='" & notlarSu.Text & "' , notdogalgaz='" & notlarDogalGaz.Text & "' , notyakit='" & notlarYakıt.Text & "' , notkira='" & notlarKira.Text & "' , notboya='" & notlarBoya.Text & "' , nottesisat='" & notlarTesisat.Text & "'  , notctv='" & notlarCtv.Text & "' , notdiger='" & notlarDigerHasarlar.Text & "' , nottoplam='" & notlarToplam.Text & "' , notlar='" & notlarNotlar.Text & "' WHERE dosyano='" & tuser & "' And klasorno='" & muser & "'"

        '    bag.Open()
        '    cmd = New OleDbCommand(sql, bag)
        '    cmd.ExecuteNonQuery()

        '    MessageBox.Show("Güncelleme tamamlandı.")
        'Else
        '    MessageBox.Show("Lütfen güncellemek isteğiniz dosyanın dosya numarasını giriniz")
        'End If
        'bag.Close()

    End Sub

    Private Sub silBtn_Click_1(sender As Object, e As EventArgs) Handles silBtn.Click
        '    If Me.dosyaNo.Text = "" And klasorNO.Text = "" Then
        '        MsgBox("Lütfen Öncelikle Kayıt Seçiniz.", MsgBoxStyle.Exclamation, "DİKKAT")
        '    Else
        '        Select Case MsgBox("Silme İşlemi Yapılacaktır Emin Misiniz?", MsgBoxStyle.YesNo, "caption")
        '            Case MsgBoxResult.Yes
        '                MessageBox.Show("Listeden Seçmiş Olduğunuz Veriler Silinmiştir.")
        '            Case MsgBoxResult.No
        '                Return
        '        End Select

        '        Dim sql As New String("DELETE FROM tablo WHERE dosyano='{0}' And klasorno = '{1}' ")
        '        sql = String.Format(sql, dosyaNo.Text, klasorNO.Text)
        '        Dim baglanti As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=gursoyemlak.accdb")
        '        Dim komutnesnesi As New OleDb.OleDbCommand(sql, baglanti)
        '        Dim sonuc As Integer
        '        baglanti.Open()
        '        sonuc = komutnesnesi.ExecuteNonQuery()

        '        baglanti.Close()
        '        Temizle()
        '    End If
    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub


End Class