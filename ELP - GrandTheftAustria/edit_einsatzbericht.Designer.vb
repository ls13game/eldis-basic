<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_einsatzbericht
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.einsatz = New System.Windows.Forms.GroupBox()
        Me.einsatzort_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datum_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.einsatzart_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.disponent_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.einsatznummer_box = New System.Windows.Forms.TextBox()
        Me.einsatz_einsatznummer = New System.Windows.Forms.Label()
        Me.status_box = New System.Windows.Forms.TextBox()
        Me.einsatz_status = New System.Windows.Forms.Label()
        Me.einsatzbericht = New System.Windows.Forms.GroupBox()
        Me.absenden = New System.Windows.Forms.Button()
        Me.verbrauch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tätigkeiten = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.situation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.einsatzleiter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.einsatz.SuspendLayout()
        Me.einsatzbericht.SuspendLayout()
        Me.SuspendLayout()
        '
        'einsatz
        '
        Me.einsatz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatz.Controls.Add(Me.einsatzort_box)
        Me.einsatz.Controls.Add(Me.Label1)
        Me.einsatz.Controls.Add(Me.datum_box)
        Me.einsatz.Controls.Add(Me.Label3)
        Me.einsatz.Controls.Add(Me.einsatzart_box)
        Me.einsatz.Controls.Add(Me.Label4)
        Me.einsatz.Controls.Add(Me.disponent_box)
        Me.einsatz.Controls.Add(Me.Label2)
        Me.einsatz.Controls.Add(Me.einsatznummer_box)
        Me.einsatz.Controls.Add(Me.einsatz_einsatznummer)
        Me.einsatz.Controls.Add(Me.status_box)
        Me.einsatz.Controls.Add(Me.einsatz_status)
        Me.einsatz.Location = New System.Drawing.Point(13, 14)
        Me.einsatz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatz.Name = "einsatz"
        Me.einsatz.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatz.Size = New System.Drawing.Size(888, 172)
        Me.einsatz.TabIndex = 2
        Me.einsatz.TabStop = False
        Me.einsatz.Text = "Einsatz"
        '
        'einsatzort_box
        '
        Me.einsatzort_box.Enabled = False
        Me.einsatzort_box.Location = New System.Drawing.Point(599, 100)
        Me.einsatzort_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatzort_box.Name = "einsatzort_box"
        Me.einsatzort_box.Size = New System.Drawing.Size(281, 26)
        Me.einsatzort_box.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(434, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Einsatzort:"
        '
        'datum_box
        '
        Me.datum_box.Enabled = False
        Me.datum_box.Location = New System.Drawing.Point(599, 66)
        Me.datum_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.datum_box.Name = "datum_box"
        Me.datum_box.Size = New System.Drawing.Size(281, 26)
        Me.datum_box.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(433, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Datum:"
        '
        'einsatzart_box
        '
        Me.einsatzart_box.Enabled = False
        Me.einsatzart_box.Location = New System.Drawing.Point(599, 35)
        Me.einsatzart_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatzart_box.Name = "einsatzart_box"
        Me.einsatzart_box.Size = New System.Drawing.Size(281, 26)
        Me.einsatzart_box.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(434, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Einsatzart:"
        '
        'disponent_box
        '
        Me.disponent_box.Enabled = False
        Me.disponent_box.Location = New System.Drawing.Point(174, 98)
        Me.disponent_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.disponent_box.Name = "disponent_box"
        Me.disponent_box.Size = New System.Drawing.Size(252, 26)
        Me.disponent_box.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Disponent:"
        '
        'einsatznummer_box
        '
        Me.einsatznummer_box.Enabled = False
        Me.einsatznummer_box.Location = New System.Drawing.Point(174, 64)
        Me.einsatznummer_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatznummer_box.Name = "einsatznummer_box"
        Me.einsatznummer_box.Size = New System.Drawing.Size(252, 26)
        Me.einsatznummer_box.TabIndex = 3
        '
        'einsatz_einsatznummer
        '
        Me.einsatz_einsatznummer.AutoSize = True
        Me.einsatz_einsatznummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.einsatz_einsatznummer.Location = New System.Drawing.Point(8, 65)
        Me.einsatz_einsatznummer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.einsatz_einsatznummer.Name = "einsatz_einsatznummer"
        Me.einsatz_einsatznummer.Size = New System.Drawing.Size(153, 25)
        Me.einsatz_einsatznummer.TabIndex = 2
        Me.einsatz_einsatznummer.Text = "Einsatznummer:"
        '
        'status_box
        '
        Me.status_box.Enabled = False
        Me.status_box.Location = New System.Drawing.Point(174, 33)
        Me.status_box.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.status_box.Name = "status_box"
        Me.status_box.Size = New System.Drawing.Size(252, 26)
        Me.status_box.TabIndex = 1
        '
        'einsatz_status
        '
        Me.einsatz_status.AutoSize = True
        Me.einsatz_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.einsatz_status.Location = New System.Drawing.Point(9, 32)
        Me.einsatz_status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.einsatz_status.Name = "einsatz_status"
        Me.einsatz_status.Size = New System.Drawing.Size(74, 25)
        Me.einsatz_status.TabIndex = 0
        Me.einsatz_status.Text = "Status:"
        '
        'einsatzbericht
        '
        Me.einsatzbericht.Controls.Add(Me.absenden)
        Me.einsatzbericht.Controls.Add(Me.verbrauch)
        Me.einsatzbericht.Controls.Add(Me.Label8)
        Me.einsatzbericht.Controls.Add(Me.tätigkeiten)
        Me.einsatzbericht.Controls.Add(Me.Label7)
        Me.einsatzbericht.Controls.Add(Me.situation)
        Me.einsatzbericht.Controls.Add(Me.Label6)
        Me.einsatzbericht.Controls.Add(Me.einsatzleiter)
        Me.einsatzbericht.Controls.Add(Me.Label5)
        Me.einsatzbericht.Location = New System.Drawing.Point(12, 194)
        Me.einsatzbericht.Name = "einsatzbericht"
        Me.einsatzbericht.Size = New System.Drawing.Size(1773, 834)
        Me.einsatzbericht.TabIndex = 3
        Me.einsatzbericht.TabStop = False
        Me.einsatzbericht.Text = "Einsatzbericht:"
        '
        'absenden
        '
        Me.absenden.BackColor = System.Drawing.Color.Green
        Me.absenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.absenden.ForeColor = System.Drawing.Color.White
        Me.absenden.Location = New System.Drawing.Point(15, 791)
        Me.absenden.Name = "absenden"
        Me.absenden.Size = New System.Drawing.Size(1752, 37)
        Me.absenden.TabIndex = 20
        Me.absenden.Text = "&Absenden"
        Me.absenden.UseVisualStyleBackColor = False
        '
        'verbrauch
        '
        Me.verbrauch.Location = New System.Drawing.Point(1030, 36)
        Me.verbrauch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.verbrauch.Multiline = True
        Me.verbrauch.Name = "verbrauch"
        Me.verbrauch.Size = New System.Drawing.Size(622, 678)
        Me.verbrauch.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(835, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Verbrauchsmaterial:"
        '
        'tätigkeiten
        '
        Me.tätigkeiten.Location = New System.Drawing.Point(278, 411)
        Me.tätigkeiten.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tätigkeiten.Multiline = True
        Me.tätigkeiten.Name = "tätigkeiten"
        Me.tätigkeiten.Size = New System.Drawing.Size(549, 303)
        Me.tätigkeiten.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(10, 410)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tätigkeiten am Einsatzort:"
        '
        'situation
        '
        Me.situation.Location = New System.Drawing.Point(278, 77)
        Me.situation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.situation.Multiline = True
        Me.situation.Name = "situation"
        Me.situation.Size = New System.Drawing.Size(549, 302)
        Me.situation.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(10, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Situation am Einsatzort:"
        '
        'einsatzleiter
        '
        Me.einsatzleiter.Location = New System.Drawing.Point(278, 34)
        Me.einsatzleiter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.einsatzleiter.Name = "einsatzleiter"
        Me.einsatzleiter.Size = New System.Drawing.Size(549, 26)
        Me.einsatzleiter.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(10, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Einsatzleiter:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'edit_einsatzbericht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1797, 1040)
        Me.Controls.Add(Me.einsatzbericht)
        Me.Controls.Add(Me.einsatz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "edit_einsatzbericht"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einsatzbericht schreiben!"
        Me.einsatz.ResumeLayout(False)
        Me.einsatz.PerformLayout()
        Me.einsatzbericht.ResumeLayout(False)
        Me.einsatzbericht.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents einsatz As GroupBox
    Friend WithEvents einsatznummer_box As TextBox
    Friend WithEvents einsatz_einsatznummer As Label
    Friend WithEvents status_box As TextBox
    Friend WithEvents einsatz_status As Label
    Friend WithEvents einsatzort_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents datum_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents einsatzart_box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents disponent_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents einsatzbericht As GroupBox
    Friend WithEvents verbrauch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tätigkeiten As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents situation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents einsatzleiter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents absenden As Button
    Friend WithEvents Timer1 As Timer
End Class
