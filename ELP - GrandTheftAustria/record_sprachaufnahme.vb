Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net
Public Class record_sprachaufnahme
    Dim FilePath As String = "C:\Sprachaufnahme.mp3"


    <DllImport("winmm.dll")>
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function
    Private Sub record_sprachaufnahme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mic_name.Text = ComputerInfo.Info.Soundcard.get_DeviceID
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles record.Click
        mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
        mciSendString("record recsound", "", 0, 0)
        ProgressBar1.Maximum = 1000
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles play.Click
        My.Computer.Audio.Play(FilePath)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.UploadFile(FilePath, "ftp://134.255.220.24/Sprachaufnahme/Sprachaufnahme.mp3", "Administrator", "9PyTh848v[5yH4j-KO")

        Me.Close()
        hauptmenu.maßnahme_record.Enabled = False
        hauptmenu.maßnahme_record.BackColor = Color.Green

        'Dim wc As New Net.WebClient
        'wc.Credentials = New Net.NetworkCredential("Administrator", "9PyTh848v[5yH4j-KO") 'Siehe *
        'wc.UploadString("ftp://134.255.220.24/Sprachaufnahme/", FilePath)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mciSendString("save recsound " & FilePath, "", 0, 0)
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Timer1.Stop()
        mciSendString("close recsound ", "", 0, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 990 Then
            ProgressBar1.Value = 1000
            Timer1.Stop()
        Else
            ProgressBar1.Value += 10
        End If
    End Sub
End Class