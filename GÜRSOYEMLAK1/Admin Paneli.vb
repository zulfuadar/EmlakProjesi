Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class Admin_Paneli
    Dim bag As New OleDbConnection
    Private Sub Admin_Paneli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bag.ConnectionString = "Provider=Microsoft.ace.OleDb.12.0;Data Source=gursoyemlak.accdb"
    End Sub

    Public Function ask()
        Dim sKy As String = "lkirwf897+22#bbtrm8814z5qq=498j5"  '32 chr shared ascii string (32 * 8 = 256 bit)
        Dim sIV As String = "741952hheeyy66#cs!9hjv887mxx7@8y"  '32 chr shared ascii string (32 * 8 = 256 bit)

        Dim sTextVal As String = "Here is my data to encrypt!!!"

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        bag.Open()
        Dim da As New OleDbDataAdapter("Select * From Admin", bag)
        da.Fill(dt)
        For Each datarow In dt.Rows
            Dim str As String = DecryptRJ256(sKy, sIV, datarow.item(1))
            Dim str2 As Integer = DecryptRJ256(sKy, sIV, datarow.item(1)).IndexOf(TextBox2.Text)
            If TextBox1.Text = datarow.item(0) And 0 = DecryptRJ256(sKy, sIV, datarow.item(1)).IndexOf(TextBox2.Text) Then
                bag.Close()
                Return True
            End If
        Next
        bag.Close()
        Return False
    End Function
    Public Function ask1()
        Dim sKy As String = "lkirwf897+22#bbtrm8814z5qq=498j5"  '32 chr shared ascii string (32 * 8 = 256 bit)
        Dim sIV As String = "741952hheeyy66#cs!9hjv887mxx7@8y"  '32 chr shared ascii string (32 * 8 = 256 bit)

        Dim sTextVal As String = "Here is my data to encrypt!!!"


        Dim dt1 As New DataTable
        Dim ds1 As New DataSet


        ds1.Tables.Add(dt1)
        bag.Open()
        Dim da As New OleDbDataAdapter("Select * From kullanici", bag)
        da.Fill(dt1)
        For Each datarow In dt1.Rows

            Dim str As Integer = DecryptRJ256(sKy, sIV, datarow.item(1)).IndexOf(TextBox2.Text)
            If TextBox1.Text = datarow.item(0) And 0 = DecryptRJ256(sKy, sIV, datarow.item(1)).IndexOf(TextBox2.Text) Then
                bag.Close()
                Return True
            End If
        Next
        bag.Close()
        Return False
    End Function

    Public Function DecryptRJ256(ByVal prm_key As String, ByVal prm_iv As String, ByVal prm_text_to_decrypt As String)

        Dim sEncryptedString As String = prm_text_to_decrypt

        Dim myRijndael As New RijndaelManaged
        myRijndael.Padding = PaddingMode.Zeros
        myRijndael.Mode = CipherMode.CBC
        myRijndael.KeySize = 256
        myRijndael.BlockSize = 256

        Dim key() As Byte
        Dim IV() As Byte

        key = System.Text.Encoding.ASCII.GetBytes(prm_key)
        IV = System.Text.Encoding.ASCII.GetBytes(prm_iv)

        Dim decryptor As ICryptoTransform = myRijndael.CreateDecryptor(key, IV)

        Dim sEncrypted As Byte() = Convert.FromBase64String(sEncryptedString)

        Dim fromEncrypt() As Byte = New Byte(sEncrypted.Length) {}

        Dim msDecrypt As New MemoryStream(sEncrypted)
        Dim csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)

        csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length)

        Return (System.Text.Encoding.ASCII.GetString(fromEncrypt))

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ask() = True Then
            Form1.Show()
        ElseIf ask1() = True Then
            Form1.Show()

            Form2.yeniKayıtBtn.Visible = 0
            Form2.guncelleBtn.Visible = 0
            Form2.Button1.Visible = 0
            Form3.guncellebtn.Visible = 0
            Form3.arsivbtn.Visible = 0
            Form1.ykebtn.Visible = 0

        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then

            MsgBox("Lütfen Kullanıcı Adı ve Şifre Giriniz.")


        ElseIf ask() = False Then
            MsgBox("Lütfen Kullanıcı Adı ve Şifre Giriniz.")


        End If




    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*****"

        End If
    End Sub
End Class