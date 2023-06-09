Imports System.IO
Imports System.Security.Cryptography

Public Class EncryptFileTool
    Dim Filee As String, SafeName As String
    Dim FasterWriting As Boolean = True
    Private Sub EncryptBtn_Click(sender As Object, e As EventArgs) Handles EncryptBtn.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Choose File"
            .Filter = "Text Document|*.txt|PNG Image|*.png|JPG Image|*.jpg|All Files|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Filee = .FileName
                SafeName = .SafeFileName
                If Not EncryptWorker.IsBusy Then EncryptWorker.RunWorkerAsync()
            End If
        End With
        MsgBox("Successfully encrypted file!", MsgBoxStyle.Exclamation, "Successfully Encrypted")
    End Sub

    Dim Key As String = "+-*&+%%_*!--_=%--*#@_!=$+_&++-^!#@#_@%=%=%%!!&__&*"
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles EncryptWorker.DoWork
        Dim TmpSrc As String = Convert.ToBase64String(File.ReadAllBytes(Filee))
        ProgressBar.Maximum = Convert.ToInt32(TmpSrc.Length)
        Dim Result As String = String.Empty
        For i As Integer = 1 To TmpSrc.Length
            ProgressByte.Text = i & "/" & TmpSrc.Length
            FileName.Text = SafeName & " (Encrypting file...)"
            Result &= ChrW(AscW(GetChar(TmpSrc, i))) & Key
            Try
                ProgressBar.Value = Convert.ToInt32(i)
            Catch : End Try
        Next
        File.WriteAllText(Filee, TmpSrc)
    End Sub

    Private Sub EncryptFileTool_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ProgressBar.Dispose()
    End Sub

    Dim DeFile As String, DeSafeFil As String
    Private Sub DecryptBtn_Click(sender As Object, e As EventArgs) Handles DecryptBtn.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "Choose File"
            .Filter = "Text Document|*.txt|PNG Image|*.png|JPG Image|*.jpg|All Files|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                DeFile = .FileName
                DeSafeFil = .SafeFileName
                If Not DecryptWorker.IsBusy Then DecryptWorker.RunWorkerAsync()
            End If
        End With
        MsgBox("Successfully decrypted file!", MsgBoxStyle.Exclamation, "Successfully Decripted")
    End Sub

    Private Sub DecryptWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DecryptWorker.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Dim TmpSrc As String = File.ReadAllText(DeFile)
        File.WriteAllBytes(DeFile, Convert.FromBase64String(TmpSrc.Replace(Key, String.Empty)))
    End Sub
End Class