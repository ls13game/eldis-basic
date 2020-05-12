Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Text
' TCP-MultiServer 
' C 2009 - Vincent Casser
Module Module1
    Private server As TcpListener
    Private client As New TcpClient
    Private ipendpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 8000) ' eingestellt ist port 8000. dieser muss ggf. freigegeben sein!
    Private list As New List(Of Connection)
    Private Structure Connection
        Dim stream As NetworkStream
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim nick As String ' natürlich optional, aber für die identifikation des clients empfehlenswert.
    End Structure
    Private Sub SendToAllClients(ByVal s As String)
        For Each c As Connection In list ' an alle clients weitersenden.
            Try
                c.streamw.WriteLine(s)
                c.streamw.Flush()
            Catch
            End Try
        Next
    End Sub
    Dim Uhrzeit As String
    Private Sub tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Uhrzeit = DateTime.Now.ToString("HH:mm:ss") & " Uhr | "
    End Sub

    Sub Main()

        Console.WriteLine("ELDIS-Server gestartet!")
        'Dim tcpClient As New System.Net.Sockets.TcpClient()
        'tcpClient.Connect("92.42.47.190", "10011")
        'Dim networkStream As Sockets.NetworkStream = tcpClient.GetStream()
        'Dim sendBytes As [Byte]()
        'sendBytes = Encoding.ASCII.GetBytes("login eldis qNhFatFm" + vbCrLf)
        'networkStream.Write(sendBytes, 0, sendBytes.Length)
        'sendBytes = Encoding.ASCII.GetBytes("use sid=1" + vbCrLf)
        'networkStream.Write(sendBytes, 0, sendBytes.Length)
        'sendBytes = Encoding.ASCII.GetBytes("clientupdate client_nickname=ELS" + vbCrLf)
        'networkStream.Write(sendBytes, 0, sendBytes.Length)
        'sendBytes = Encoding.ASCII.GetBytes("sendtextmessage targetmode=3 target=1 msg=[b][Color=green]ELDIS-Server\sgestartet!\s" + vbCrLf)
        'networkStream.Write(sendBytes, 0, sendBytes.Length)
        'sendBytes = Encoding.ASCII.GetBytes("logout" + vbCrLf)
        'networkStream.Write(sendBytes, 0, sendBytes.Length)
        'If Not networkStream.CanRead Then
        '    Console.WriteLine("cannot not write data to this stream")
        '    tcpClient.Close()
        'Else
        '    If Not networkStream.CanWrite Then
        '        Console.WriteLine("cannot read data from this stream")
        '        tcpClient.Close()
        '    End If
        'End If
        '' pause so user can view the console output


        server = New TcpListener(ipendpoint)
        server.Start()
        While True ' wir warten auf eine neue verbindung...
            client = server.AcceptTcpClient
            Dim c As New Connection ' und erstellen für die neue verbindung eine neue connection...
            c.stream = client.GetStream
            c.streamr = New StreamReader(c.stream)
            c.streamw = New StreamWriter(c.stream)
            c.nick = c.streamr.ReadLine ' falls das mit dem nick nicht gewünscht, auch diese zeile entfernen.
            list.Add(c) ' und fügen sie der liste der clients hinzu.
            Console.WriteLine(Uhrzeit & c.nick & " hat sich eingeloggt.")
            ' falls alle anderen das auch lesen sollen können, an alle clients weiterleiten. siehe SendToAllClients
            Dim t As New Threading.Thread(AddressOf ListenToConnection)
            t.Start(c)


        End While

    End Sub

    Private Sub ListenToConnection(ByVal con As Connection)
        Do
            Try
                Dim tmp As String = con.streamr.ReadLine ' warten, bis etwas empfangen wird...
                SendToAllClients(tmp) ' an alle clients weitersenden.
            Catch ' die aktuelle überwachte verbindung hat sich wohl verabschiedet.
                list.Remove(con)
                Console.WriteLine(Uhrzeit & con.nick & " hat sich ausgeloggt!")
                Exit Do
            End Try
        Loop
    End Sub
End Module