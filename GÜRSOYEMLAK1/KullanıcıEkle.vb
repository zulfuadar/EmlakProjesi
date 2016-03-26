Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class KullanıcıEkle
    Public bag As New OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data Source=gursoyemlak.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim sql2, sql3 As String

    Dim reader As OleDbDataReader = Nothing
    Public dataTable As New DataTable



    Public Sub conClose()
        bag.Close()
        cmd.Dispose()

    End Sub

    Public Function EncryptRJ256(ByVal prm_key As String, ByVal prm_iv As String, ByVal prm_text_to_encrypt As String)

        Dim sToEncrypt As String = prm_text_to_encrypt

        Dim myRijndael As New RijndaelManaged
        myRijndael.Padding = PaddingMode.Zeros
        myRijndael.Mode = CipherMode.CBC
        myRijndael.KeySize = 256
        myRijndael.BlockSize = 256

        Dim encrypted() As Byte
        Dim toEncrypt() As Byte
        Dim key() As Byte
        Dim IV() As Byte

        key = System.Text.Encoding.ASCII.GetBytes(prm_key)
        IV = System.Text.Encoding.ASCII.GetBytes(prm_iv)

        Dim encryptor As ICryptoTransform = myRijndael.CreateEncryptor(key, IV)

        Dim msEncrypt As New MemoryStream()
        Dim csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)

        toEncrypt = System.Text.Encoding.ASCII.GetBytes(sToEncrypt)

        csEncrypt.Write(toEncrypt, 0, toEncrypt.Length)
        csEncrypt.FlushFinalBlock()

        encrypted = msEncrypt.ToArray()

        Return (Convert.ToBase64String(encrypted))

    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim sKy As String = "lkirwf897+22#bbtrm8814z5qq=498j5"  '32 chr shared ascii string (32 * 8 = 256 bit)
        Dim sIV As String = "741952hheeyy66#cs!9hjv887mxx7@8y"  '32 chr shared ascii string (32 * 8 = 256 bit)

        Dim sTextVal As String = "Here is my data to encrypt!!!"

        Dim text As String = sifretxt.Text
        Dim eText As String

        eText = EncryptRJ256(sKy, sIV, text)



        sql2 = "select * from Admin,kullanici"



        Dim cmd As New OleDbCommand(sql2, bag)

        Dim dr As OleDbDataReader


        bag.Open()

        dr = cmd.ExecuteReader


        Do While dr.Read

            If dr("adminkullaniciadi") = kullaniciaditxt.Text Or dr("kullaniciadi") = kullaniciaditxt.Text Then
                kullaniciaditxt.Text = ""
                MessageBox.Show("Bu Admin İsmi Sistemde Admin Olarak Kayıtlıdır.")


                Me.Close()
                Form1.ykebtn.PerformClick()



                bag.Close()
                Return


            End If
        Loop

        bag.Close()

        If Not sifretxt.Text = TextBox1.Text Then
            sifretxt.BackColor = Color.Red
            TextBox1.BackColor = Color.Red
            MsgBox("Girmiş Olduğunuz Şifreler Aynı Değil")
            sifretxt.BackColor = Color.White
            TextBox1.BackColor = Color.White


            Return



        End If


        If Me.kullaniciaditxt.Text = "" And sifretxt.Text = "" Then


            MsgBox("Lütfen Öncelikle Kaydetme Parametreleri Giriniz.", MsgBoxStyle.Exclamation, "DİKKAT")
            Return

        Else
            Select Case MsgBox("Kullanıcı Kaydetme İşlemi Yapılacaktır Emin Misiniz?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes
                    MessageBox.Show("Kullanıcı Oluşturulmuştur.")
                Case MsgBoxResult.No
                    Return

            End Select
        End If

        If ComboBox1.Text = "Admin" Then

            bag.Open()
            cmd.Connection = bag





            cmd.CommandText = (("INSERT INTO Admin VALUES ('" + kullaniciaditxt.Text & "','") + eText & "','") + ComboBox1.Text & "')"
            cmd.ExecuteNonQuery()
            conClose()
            MsgBox("Girdiğiniz Bilgiler Admin Olarak Tanımlanmıştır.")
        Else
            bag.Open()
            cmd.Connection = bag
            cmd.CommandText = (("INSERT INTO kullanici VALUES ('" + kullaniciaditxt.Text & "','") + eText & "','") + ComboBox1.Text & "')"
            cmd.ExecuteNonQuery()
            conClose()
            MsgBox("Girdiğiniz Bilgiler Üye Olarak Tanımlanmıştır.")


        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class