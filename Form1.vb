Public Class Form1

    ' GUI and codes made by Fariz Luqman (farizluqman@simplelinux.my)
    ' SHA1 module created by Obviex. Copyright (C) 2002 Obviex(TM). All rights reserved.
    '  http://www.obviex.com/samples/hash.aspx


    ' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
    ' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
    ' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
    ' 

    Dim plainText As String
    Dim cipherText As String

    Dim passPhrase As String
    Dim saltValue As String
    Dim hashAlgorithm As String
    Dim passwordIterations As Integer
    Dim initVector As String
    Dim keySize As Integer

    Private Sub cmdEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEncrypt.Click
        Dim plainText As String
        Dim cipherText As String

        Dim passPhrase As String
        Dim saltValue As String
        Dim hashAlgorithm As String
        Dim passwordIterations As Integer
        Dim initVector As String
        Dim keySize As Integer

        plainText = txtInput.Text    ' original plaintext

        passPhrase = txtPassphrase.Text       ' can be any string
        saltValue = txtSalt.Text       ' can be any string
        hashAlgorithm = "SHA1"             ' can be "MD5"
        passwordIterations = txtIterations.Text                ' can be any number
        initVector = txtInitVector.Text ' must be 16 bytes
        keySize = txtKeySize.Text                ' can be 192 or 128

        cipherText = RijndaelSimple.Encrypt(plainText, _
                                     passPhrase, _
                                     saltValue, _
                                     hashAlgorithm, _
                                     passwordIterations, _
                                     initVector, _
                                     keySize)

        txtOutput.Text = cipherText
    End Sub

    Private Sub cmdDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecrypt.Click
        Dim plainText As String
        Dim cipherText As String

        Dim passPhrase As String
        Dim saltValue As String
        Dim hashAlgorithm As String
        Dim passwordIterations As Integer
        Dim initVector As String
        Dim keySize As Integer

        cipherText = txtInput.Text

        plainText = txtInput.Text    ' original plaintext

        passPhrase = txtPassphrase.Text       ' can be any string
        saltValue = txtSalt.Text       ' can be any string
        hashAlgorithm = "SHA1"             ' can be "MD5"
        passwordIterations = txtIterations.Text                ' can be any number
        initVector = txtInitVector.Text ' must be 16 bytes
        keySize = txtKeySize.Text                ' can be 192 or 128

        Try
            plainText = RijndaelSimple.Decrypt(cipherText, _
                                         passPhrase, _
                                         saltValue, _
                                         hashAlgorithm, _
                                         passwordIterations, _
                                         initVector, _
                                         keySize)
        Catch ex As Exception
            MsgBox("Error: Do not decrypt an unencrypted input", vbExclamation, "Decrypted an unencrypted input")
        End Try
        

        txtOutput.Text = plainText
    End Sub
End Class
