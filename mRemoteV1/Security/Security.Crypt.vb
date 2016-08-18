Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports dRemote.App.Runtime

Namespace Security
    Public Class Crypt
        Public Shared Function Encrypt(ByVal StrToEncrypt As String, ByVal StrSecret As String, Optional Encryption As String = "Default") As String
            Select Case Encryption
                Case "MD5"
                    Return Encrypt_MD5(StrToEncrypt, StrSecret)
                Case Else
                    Return EncryptStringToBytes_Aes(StrToEncrypt, StrSecret)
            End Select
        End Function
        Public Shared Function Encrypt_MD5(ByVal StrToEncrypt As String, ByVal StrSecret As String) As String
            If StrToEncrypt = "" Or StrSecret = "" Then
                Return StrToEncrypt
            End If

            Try
                Dim rd As New RijndaelManaged

                Dim md5 As New MD5CryptoServiceProvider
                Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(StrSecret))

                md5.Clear()
                rd.Key = key
                rd.GenerateIV()

                Dim iv() As Byte = rd.IV
                Dim ms As New MemoryStream

                ms.Write(iv, 0, iv.Length)

                Dim cs As New CryptoStream(ms, rd.CreateEncryptor, CryptoStreamMode.Write)
                Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(StrToEncrypt)

                cs.Write(data, 0, data.Length)
                cs.FlushFinalBlock()

                Dim encdata() As Byte = ms.ToArray()
                cs.Close()
                rd.Clear()

                Return Convert.ToBase64String(encdata)
            Catch ex As Exception
                MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, String.Format(My.Language.strErrorEncryptionFailed, ex.Message))
            End Try

            Return StrToEncrypt
        End Function

        Public Shared Function Decrypt(ByVal ciphertextBase64 As String, ByVal password As String) As String
            If String.IsNullOrEmpty(ciphertextBase64) Or String.IsNullOrEmpty(password) Then
                Return ciphertextBase64
            End If

            Try
                Dim plaintext As String

                Using rijndaelManaged As New RijndaelManaged
                    Using md5 As New MD5CryptoServiceProvider
                        Dim key() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes(password))
                        rijndaelManaged.Key = key
                    End Using

                    Dim ciphertext() As Byte = Convert.FromBase64String(ciphertextBase64)

                    Using memoryStream As New MemoryStream(ciphertext)
                        Const ivLength As Integer = 16
                        Dim iv(ivLength - 1) As Byte
                        memoryStream.Read(iv, 0, ivLength)
                        rijndaelManaged.IV = iv

                        Using cryptoStream As New CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor, CryptoStreamMode.Read)
                            Using streamReader As New StreamReader(cryptoStream, System.Text.Encoding.UTF8, True)
                                plaintext = streamReader.ReadToEnd()
                            End Using
                            rijndaelManaged.Clear()
                        End Using ' cryptoStream
                    End Using ' memoryStream
                End Using ' rijndaelManaged

                Return plaintext
            Catch ex As Exception
                ' Ignore CryptographicException "Padding is invalid and cannot be removed." when password is incorrect.
                If Not TypeOf ex Is CryptographicException Then
                    MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, String.Format(My.Language.strErrorDecryptionFailed, ex.Message))
                End If
            End Try

            Return ciphertextBase64
        End Function
        'End Class
        'Class EAS

        'Public Shared Sub Main()
        '    Try

        '        Dim original As String = "Here is some data to encrypt!"
        '        Dim masterkey As String = "12345678"
        '        Dim b As Byte() = System.Text.Encoding.Unicode.GetBytes(masterkey)
        '        ' Create a new instance of the Aes
        '        ' class.  This generates a new key and initialization 
        '        ' vector (IV).
        '        Using myAes As Aes = Aes.Create()
        '            myAes.Key = b
        '            myAes.IV = b
        '            ' Encrypt the string to an array of bytes.
        '            Dim encrypted As Byte() = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV)

        '            ' Decrypt the bytes to a string.
        '            Dim roundtrip As String = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV)

        '            'Display the original data and the decrypted data.
        '            Console.WriteLine("Original:   {0}", original)
        '            Console.WriteLine("encrypted: {0}", System.Text.Encoding.Unicode.GetString(encrypted).ToString)
        '            Console.WriteLine("Round Trip: {0}", roundtrip)
        '        End Using
        '    Catch e As Exception
        '        Console.WriteLine("Error: {0}", e.Message)
        '    End Try

        'End Sub 'Main

        Shared Function EncryptStringToBytes_Aes(ByVal plainText As String, ByVal masterkey As String) As String
            While masterkey.Length < 16
                masterkey &= " "
            End While
            Dim Key() As Byte = System.Text.Encoding.Unicode.GetBytes(Left(masterkey, 16))
            Dim IV() As Byte = System.Text.Encoding.Unicode.GetBytes(Left(masterkey, 8))

            ' Check arguments.
            If plainText Is Nothing OrElse plainText.Length <= 0 Then
                'Throw New ArgumentNullException("plainText")
                Return ""
            End If
            If Key Is Nothing OrElse Key.Length <= 0 Then
                'Throw New ArgumentNullException("Key")
                Return ""
            End If
            If IV Is Nothing OrElse IV.Length <= 0 Then
                'Throw New ArgumentNullException("IV")
                Return ""
            End If
            Dim encrypted() As Byte
            ' Create an Aes object
            ' with the specified key and IV.
            Using aesAlg As Aes = Aes.Create()

                aesAlg.Key = Key
                aesAlg.IV = IV

                ' Create a decrytor to perform the stream transform.
                Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
                ' Create the streams used for encryption.
                Using msEncrypt As New MemoryStream()
                    Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                        Using swEncrypt As New StreamWriter(csEncrypt)

                            'Write all data to the stream.
                            swEncrypt.Write(plainText)
                        End Using
                        encrypted = msEncrypt.ToArray()
                    End Using
                End Using
            End Using

            ' Return the encrypted bytes from the memory stream.
            Return Convert.ToBase64String(encrypted)

        End Function 'EncryptStringToBytes_Aes

        Shared Function DecryptStringFromBytes_Aes(ByVal encrypted As String, ByVal masterkey As String) As String
            Dim plaintext As String = Nothing
            Try
                While masterkey.Length < 16
                    masterkey &= " "
                End While
                Dim cipherText As Byte() = Convert.FromBase64String(encrypted)
                Dim Key() As Byte = System.Text.Encoding.Unicode.GetBytes(Left(masterkey, 16))
                Dim IV() As Byte = System.Text.Encoding.Unicode.GetBytes(Left(masterkey, 8))
                ' Check arguments.
                If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
                    'Throw New ArgumentNullException("cipherText")
                    Return ""
                End If
                If Key Is Nothing OrElse Key.Length <= 0 Then
                    'Throw New ArgumentNullException("Key")
                    Return ""
                End If
                If IV Is Nothing OrElse IV.Length <= 0 Then
                    'Throw New ArgumentNullException("IV")
                    Return ""
                End If
                ' Declare the string used to hold
                ' the decrypted text.

                ' Create an Aes object
                ' with the specified key and IV.
                Using aesAlg As Aes = Aes.Create()
                    aesAlg.Key = Key
                    aesAlg.IV = IV

                    ' Create a decrytor to perform the stream transform.
                    Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

                    ' Create the streams used for decryption.
                    Using msDecrypt As New MemoryStream(cipherText)

                        Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)

                            Using srDecrypt As New StreamReader(csDecrypt)


                                ' Read the decrypted bytes from the decrypting stream
                                ' and place them in a string.
                                plaintext = srDecrypt.ReadToEnd()
                            End Using
                        End Using
                    End Using
                End Using
            Catch ex As Exception

            End Try
            Return plaintext

        End Function 'DecryptStringFromBytes_Aes 
    End Class 'AesExample
End Namespace

