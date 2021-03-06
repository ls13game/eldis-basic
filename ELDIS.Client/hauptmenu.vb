﻿Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports system.text

Public Class hauptmenu
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Private nick As String = My.Settings.benutzername
    Dim Uhrzeit As String

    Dim Time As String
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
    Dim EinsatzComboMySQL As String
    Dim READER As MySqlDataReader
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim JetzigeUhrzeit As String
    Dim AlarmUhrzeit As String
    Dim AlarmTime As String
    Dim Einsatznummer As Double
    Dim xcoord As Double
    Dim ycoord As Double
    Dim bar As String



    Dim stringConn As String
    Dim stringCmd As String
    Dim myConn As MySqlConnection
    Dim myCmd As MySqlCommand


    Private Sub hauptmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        Me.Text = "ELDIS @" & My.Settings.benutzername & " [" & Me.GetType.Assembly.GetName.Version.ToString & "]"
        conn = New MySqlConnection()
        conn.ConnectionString = (“server=" & My.Settings.mysqlserver & " ;userid=" & My.Settings.mysqluser & ";password=" & My.Settings.mysqlpassword & ";database=" & My.Settings.mysqldatabase & "")
        GetEinsatze()
        Dim Uhrzeit = DateTime.Now.ToString("HH:mm:ss") & " Uhr | "
        Try
            client.Connect("DEINE IP", 8000) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(nick) ' das ist optional.
                streamw.Flush()
                t.Start()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Verbindung zum Server nicht möglich!")
            Application.Exit()
        End Try


        If My.Settings.usertype = "user" Then
            eldis_tabcontrol.TabPages.Remove(eldis_einsatzerfassung)
            eldis_tabcontrol.TabPages.Remove(eldis_einsatzübersicht)
            DisponentToolStripMenuItem.Visible = False
            AdminToolStripMenuItem.Visible = False
        End If

        If My.Settings.usertype = "admin" Then
            AdminToolStripMenuItem.Visible = True
        End If

        If My.Settings.usertype = "disponent" Then
            DisponentToolStripMenuItem.Visible = True
            AdminToolStripMenuItem.Visible = False
        End If
        initELDIS.Dock = DockStyle.Fill
        initELDIS.BackColor = Color.White
    End Sub

    Private Sub Listen()
        While client.Connected
            Try

            Catch
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End Try
        End While
    End Sub


    Private Sub initELDIS_timer_Tick(sender As Object, e As EventArgs) Handles initELDIS_timer.Tick
        initELDIS.Visible = False
        initELDIS_Label.Visible = False

    End Sub

    Private Sub EinsatzerfassungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinsatzerfassungToolStripMenuItem.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung
    End Sub

    Private Sub hauptmenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As Integer = MessageBox.Show("Willst du ELDIS wirklich beenden?", "ELDIS", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            Application.Exit()
            streamw.Flush()
            client.Close()
            End
        Else
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NeuerEinsatz()
        conn.Open()
        Dim QueryID As String
        QueryID = "insert into sis_fw_einsatz (datum,status,disponent,islocked,idlocked) values ('" & AlarmUhrzeit & "','" & "OFFEN" & "','" & My.Settings.benutzername & "','" & "yes" & "','" & My.Settings.id & "')"
        COMMAND = New MySqlCommand(QueryID, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub
    Private Sub LetzteEinsatznummer()
        conn.Open()
        Dim QueryID As String
        QueryID = "SELECT MAX(einsatznummer) FROM sis_fw_einsatz"
        Dim cmd_query As New MySqlCommand(QueryID, conn)
        Dim cmd_result As Integer = CInt(cmd_query.ExecuteScalar())
        einsatznummer_box.Text = cmd_result
        COMMAND = New MySqlCommand(QueryID, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub

    Private Sub controlbox_neweinsatz_Click(sender As Object, e As EventArgs) Handles controlbox_neweinsatz.Click
        NeuerEinsatz()
        LetzteEinsatznummer()

        sonstiges_intern.Text = AlarmUhrzeit
        status_box.Text = "OFFEN"
        maßnahme_pager.Enabled = True
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = True
        maßnahme_probesirene.Enabled = True
        maßnahme_ausführen.Enabled = True
        maßnahme_mehr.Enabled = True
        maßnahme_record.Enabled = False
        controlbox_neweinsatz.Enabled = False
        alarmundmelde_alarmstufebox.Enabled = True
        alarmundmelde_meldebildbox.Enabled = True
        einsatzort_straße.Enabled = True
        einsatzort_nr.Enabled = True
        einsatzort_abschnitt.Enabled = True
        einsatzort_postleitzahl.Enabled = True
        einsatzort_stadt.Enabled = True
        einsatzort_objekt.Enabled = True
        sonstiges_extern.Enabled = True
        sonstiges_intern.Enabled = True
    End Sub
    Private Sub OpenEinsatz()
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET idlocked = '" & My.Settings.id & "',islocked = '" & "yes" & "' WHERE einsatznummer = '" & My.Settings.currenteinsatzid & "'"
        COMMAND = New MySqlCommand(Query, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub



    Private Sub controlbox_ende_Click(sender As Object, e As EventArgs) Handles controlbox_ende.Click
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET status = '" & "ABGESCHLOSSEN" & "',idlocked = '" & "" & "',islocked = '" & "end" & "' WHERE einsatznummer = '" & My.Settings.currenteinsatzid & "'"
        COMMAND = New MySqlCommand(Query, conn)
        ' Textboxen-Clearen
        maßnahme_pager.Enabled = False
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = False
        maßnahme_probesirene.Enabled = False
        maßnahme_ausführen.Enabled = False
        maßnahme_mehr.Enabled = False
        controlbox_neweinsatz.Enabled = True
        alarmundmelde_alarmstufebox.Enabled = False
        alarmundmelde_meldebildbox.Enabled = False
        einsatzort_straße.Enabled = False
        einsatzort_nr.Enabled = False
        einsatzort_abschnitt.Enabled = False
        einsatzort_postleitzahl.Enabled = False
        einsatzort_stadt.Enabled = False
        einsatzort_objekt.Enabled = False
        sonstiges_extern.Enabled = False
        sonstiges_intern.Enabled = False

        alarmundmelde_alarmstufebox.Text = ""
        alarmundmelde_meldebildbox.Text = ""
        einsatzort_straße.Text = ""
        einsatzort_nr.Text = ""
        einsatzort_abschnitt.Text = ""
        einsatzort_postleitzahl.Text = ""
        einsatzort_stadt.Text = ""
        einsatzort_objekt.Text = ""
        sonstiges_extern.Text = ""
        sonstiges_intern.Text = ""
        status_box.Text = ""
        einsatznummer_box.Text = ""
        maßnahmen_view.Rows.Clear()
        My.Settings.currenteinsatzid = ""
        '
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub

    Private Sub controlbox_speichern_Click(sender As Object, e As EventArgs) Handles controlbox_speichern.Click
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        conn.Open()
        Dim Query As String

        Query = "UPDATE sis_fw_einsatz SET alarmstufe = '" & alarmundmelde_alarmstufebox.Text & "', meldebild= '" & alarmundmelde_meldebildbox.Text & "', datum = '" & AlarmUhrzeit & "', straße = '" & einsatzort_straße.Text & "', nr = '" & einsatzort_nr.Text & "', plz = '" & einsatzort_postleitzahl.Text & "', stadt = '" & einsatzort_stadt.Text & "', einsatzort = '" & einsatzort_straße.Text + " " + einsatzort_nr.Text + ", " + einsatzort_postleitzahl.Text + " " + einsatzort_stadt.Text & "', interne_notizen = '" & sonstiges_intern.Text & "', externe_notizen = '" & sonstiges_extern.Text & "' WHERE einsatznummer = '" & einsatznummer_box.Text & "'"
        COMMAND = New MySqlCommand(Query, conn)

        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub

    Private Sub PagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagerToolStripMenuItem.Click
        pager.Show()
    End Sub
    Private Sub maßnahme_ausführen_Click(sender As Object, e As EventArgs) Handles maßnahme_ausführen.Click
        maßnahme_ausführen.BackColor = Color.Green
        'If alarmstufeCombo.Text = "" And adressetext.Text = "" & nrtext.Text = "" & plztext.Text = "" & stadttext.Text = "" Then
        'MessageBox.Show("Fülle die Einsatzmaske richtig aus!", "ELDIS", MessageBoxButtons.OK)
        'Else
        Dim Query As String
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        Query = "UPDATE sis_fw_einsatz SET alarmstufe = '" & alarmundmelde_alarmstufebox.Text & "',meldebild= '" & alarmundmelde_meldebildbox.Text & "', datum = '" & Uhrzeit + dayName & "', straße = '" & einsatzort_straße.Text & "', nr = '" & einsatzort_nr.Text & "', plz = '" & einsatzort_postleitzahl.Text & "', stadt = '" & einsatzort_stadt.Text & "', interne_notizen = '" & sonstiges_intern.Text & "', externe_notizen = '" & sonstiges_extern.Text & "' WHERE einsatznummer = '" & einsatznummer_box.Text & "'"
        'Query = "insert into einsatz (einsatzart,datum,einsatzort,status,disponent) values ('" & meldebildCombo.Text & "','" & AlarmUhrzeit & "','" & adressetext.Text & " " & nrtext.Text & ", " & plztext.Text & " " & stadttext.Text & "','" & "OFFEN" & "','" & My.Settings.username & "')"
        status_box.Text = "OFFEN"
        COMMAND = New MySqlCommand(Query, conn)
        conn.Open()
        READER = COMMAND.ExecuteReader
        READER.Close()
        Dim sirene As Boolean
        Dim probe_sirene As Boolean
        sirene = maßnahme_feuersirene.Checked
        probe_sirene = maßnahme_probesirene.Checked
        Dim prefix As String

        If sirene = True Then
            prefix = "#sirene"
            maßnahmen_view.Rows.Add("LS-Dummy Generalalarm FW-Los Santos Sirene", True)
        ElseIf sirene = False Then
            If maßnahme_pager.Checked = True Then
                prefix = "#pager"
                maßnahmen_view.Rows.Add("LS-Dummy Generalalarm FW-Los Santos", True)
            Else
                If probe_sirene = True Then
                    prefix = "#probesirene"
                    maßnahmen_view.Rows.Add("LS-Dummy Sirenenproberuf Los Santos", True)
                End If
            End If
        End If
        streamw.WriteLine(prefix + " ELS: " & alarmundmelde_meldebildbox.Text & " (" & alarmundmelde_alarmstufebox.Text & ") " & " für die Feuerwehr Los Santos, " & einsatzort_postleitzahl.Text & " " & einsatzort_stadt.Text & ", " & einsatzort_straße.Text & " " & einsatzort_nr.Text & ", " & "Info: " & sonstiges_extern.Text & " um: " & DateTime.Now.ToString("HH:mm:ss"))
        maßnahme_ausführen.BackColor = Color.Green
        streamw.Flush()
        conn.Close()
    End Sub

    Private Sub maßnahme_mehr_Click(sender As Object, e As EventArgs) Handles maßnahme_mehr.Click
        maßnahme_list.Show()
    End Sub

    Private Sub EinsatzberichtSchreibenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinsatzberichtSchreibenToolStripMenuItem.Click
        choose_einsatzbericht.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MeinProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeinProfilToolStripMenuItem.Click
        meinprofil.Show()
    End Sub

    Private Sub record_sprachaufnahme_Click(sender As Object, e As EventArgs) Handles maßnahme_record.Click
        record_sprachaufnahme.Show()
    End Sub


    Private Sub GetEinsatze()
        Dim conn As MySqlConnection
        Dim cmd As New MySqlCommand
        conn = New MySqlConnection()
        conn.ConnectionString = (“server=" & My.Settings.mysqlserver & " ;userid=" & My.Settings.mysqluser & ";password=" & My.Settings.mysqlpassword & ";database=" & My.Settings.mysqldatabase & "")
        Try
            conn.Open() ' Verbindung öffnen
        Catch myerror As MySqlException
            MsgBox("Keine Verbindung zur Datenbank : " & myerror.Message.ToString) ' Falls Fehler : Fehler anzeigen
        End Try
        Dim table As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT einsatznummer as 'Einsatznummer',datum as 'Datum',alarmstufe as 'Alarmstufe',meldebild as 'Meldebild', einsatzort as 'Einsatzadresse' FROM sis_fw_einsatz"

        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        einsatzliste.DataSource = table
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung


        NeuerEinsatz()
        LetzteEinsatznummer()

        sonstiges_intern.Text = AlarmUhrzeit
        status_box.Text = "OFFEN"
        maßnahme_pager.Enabled = True
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = True
        maßnahme_probesirene.Enabled = True
        maßnahme_ausführen.Enabled = True
        maßnahme_mehr.Enabled = True
        maßnahme_record.Enabled = False
        controlbox_neweinsatz.Enabled = False
        alarmundmelde_alarmstufebox.Enabled = True
        alarmundmelde_meldebildbox.Enabled = True
        einsatzort_straße.Enabled = True
        einsatzort_nr.Enabled = True
        einsatzort_abschnitt.Enabled = True
        einsatzort_postleitzahl.Enabled = True
        einsatzort_stadt.Enabled = True
        einsatzort_objekt.Enabled = True
        sonstiges_extern.Enabled = True
        sonstiges_intern.Enabled = True
    End Sub

    Private Sub einsatzliste_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles einsatzliste.CellDoubleClick
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        Dim cell As DataGridViewCell
        For Each cell In einsatzliste.SelectedCells
            stringCmd = "Select * FROM sis_fw_einsatz where einsatznummer= '" & cell.Value.ToString & "'"
        Next
        'Frame your connection string here.
        stringConn = (“server=" & My.Settings.mysqlserver & " ;userid=" & My.Settings.mysqluser & ";password=" & My.Settings.mysqlpassword & ";database=" & My.Settings.mysqldatabase & "")

        'Get your connection here.
        myConn = New MySqlConnection(stringConn)

        'Get a command by using your connection and query.
        myCmd = New MySqlCommand(stringCmd, myConn)

        'Open the connection.
        myConn.Open()

        'create a reader to store the datum which will be returned from the DB
        Dim myReader As MySqlDataReader

        'Execute your query using .ExecuteReader()
        myReader = myCmd.ExecuteReader()

        'Reset your List box here.

        While (myReader.Read())
            'Sperrung wurde auskommentiert, da die Funktion ungültig ist. FIX SOON : p
            If myReader.GetString(18) = "yes" Then
                MessageBox.Show("Dieser Einsatz wird bearbeitet! (" + myReader.GetString(19) + ")", "ELDIS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf myReader.GetString(18) = "no" Then
                eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung
                My.Settings.currenteinsatzid = cell.Value.ToString
                einsatznummer_box.Text = cell.Value.ToString
                sonstiges_intern.Text = AlarmUhrzeit

                status_box.Text = myReader.GetString(4)
                einsatznummer_box.Text = myReader.GetString(0)
                alarmundmelde_alarmstufebox.Text = myReader.GetString(1)
                alarmundmelde_meldebildbox.Text = myReader.GetString(2)
                einsatzort_straße.Text = myReader.GetString(5)
                einsatzort_nr.Text = myReader.GetString(6)
                einsatzort_postleitzahl.Text = myReader.GetString(7)
                einsatzort_stadt.Text = myReader.GetString(8)
                sonstiges_intern.Text = myReader.GetString(15)
                sonstiges_extern.Text = myReader.GetString(16)




                maßnahme_pager.Enabled = True
                maßnahme_proberuf.Enabled = False
                maßnahme_feuersirene.Enabled = True
                maßnahme_probesirene.Enabled = True
                maßnahme_ausführen.Enabled = True
                maßnahme_mehr.Enabled = True
                maßnahme_record.Enabled = True
                controlbox_neweinsatz.Enabled = False
                alarmundmelde_alarmstufebox.Enabled = True
                alarmundmelde_meldebildbox.Enabled = True
                einsatzort_straße.Enabled = True
                einsatzort_nr.Enabled = True
                einsatzort_abschnitt.Enabled = True
                einsatzort_postleitzahl.Enabled = True
                einsatzort_stadt.Enabled = True
                einsatzort_objekt.Enabled = True
                sonstiges_extern.Enabled = True
                sonstiges_intern.Enabled = True
                OpenEinsatz()
            ElseIf myReader.GetString(18) = "end" Then
                MessageBox.Show("Dieser Einsatz wurde bereits beendet!", "ELDIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End While

        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub FunkgerätToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunkgerätToolStripMenuItem.Click
        Dim strPath As String = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Process.Start(strPath & "/Funkgerät.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetEinsatze()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET status = '" & "OFFEN" & "',idlocked = '" & "" & "',islocked = '" & "no" & "' WHERE einsatznummer = '" & My.Settings.currenteinsatzid & "'"
        COMMAND = New MySqlCommand(Query, conn)
        ' Textboxen-Clearen
        maßnahme_pager.Enabled = False
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = False
        maßnahme_probesirene.Enabled = False
        maßnahme_ausführen.Enabled = False
        maßnahme_mehr.Enabled = False
        controlbox_neweinsatz.Enabled = True
        alarmundmelde_alarmstufebox.Enabled = False
        alarmundmelde_meldebildbox.Enabled = False
        einsatzort_straße.Enabled = False
        einsatzort_nr.Enabled = False
        einsatzort_abschnitt.Enabled = False
        einsatzort_postleitzahl.Enabled = False
        einsatzort_stadt.Enabled = False
        einsatzort_objekt.Enabled = False
        sonstiges_extern.Enabled = False
        sonstiges_intern.Enabled = False

        alarmundmelde_alarmstufebox.Text = ""
        alarmundmelde_meldebildbox.Text = ""
        einsatzort_straße.Text = ""
        einsatzort_nr.Text = ""
        einsatzort_abschnitt.Text = ""
        einsatzort_postleitzahl.Text = ""
        einsatzort_stadt.Text = ""
        einsatzort_objekt.Text = ""
        sonstiges_extern.Text = ""
        sonstiges_intern.Text = ""
        status_box.Text = ""
        einsatznummer_box.Text = ""
        maßnahmen_view.Rows.Clear()
        My.Settings.currenteinsatzid = ""
        '
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Sub

    Private Sub controlbox_openeinsatz_Click(sender As Object, e As EventArgs) Handles controlbox_openeinsatz.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzübersicht
    End Sub

    Private Sub einsatzliste_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles einsatzliste.CellContentClick

    End Sub

    Private Sub NeuenSISBenutzerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuenSISBenutzerToolStripMenuItem.Click
        neuen_sis.Show()
    End Sub

    Private Sub DisponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisponentToolStripMenuItem.Click

    End Sub
End Class
