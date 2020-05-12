<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meinprofil
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.yourip_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usertype_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.steamid_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.yourip_box)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.usertype_box)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.steamid_box)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.username_box)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.id_box)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'yourip_box
        '
        Me.yourip_box.Enabled = False
        Me.yourip_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.yourip_box.Location = New System.Drawing.Point(361, 133)
        Me.yourip_box.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.yourip_box.Name = "yourip_box"
        Me.yourip_box.Size = New System.Drawing.Size(324, 23)
        Me.yourip_box.TabIndex = 9
        Me.yourip_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(357, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Deine IP:"
        '
        'usertype_box
        '
        Me.usertype_box.Enabled = False
        Me.usertype_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.usertype_box.Location = New System.Drawing.Point(8, 133)
        Me.usertype_box.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.usertype_box.Name = "usertype_box"
        Me.usertype_box.Size = New System.Drawing.Size(351, 23)
        Me.usertype_box.TabIndex = 7
        Me.usertype_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usertype:"
        '
        'steamid_box
        '
        Me.steamid_box.Enabled = False
        Me.steamid_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.steamid_box.Location = New System.Drawing.Point(361, 86)
        Me.steamid_box.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.steamid_box.Name = "steamid_box"
        Me.steamid_box.Size = New System.Drawing.Size(324, 23)
        Me.steamid_box.TabIndex = 5
        Me.steamid_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(357, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SteamID:"
        '
        'username_box
        '
        Me.username_box.Enabled = False
        Me.username_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.username_box.Location = New System.Drawing.Point(8, 86)
        Me.username_box.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.username_box.Name = "username_box"
        Me.username_box.Size = New System.Drawing.Size(351, 23)
        Me.username_box.TabIndex = 3
        Me.username_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Benutzername:"
        '
        'id_box
        '
        Me.id_box.Enabled = False
        Me.id_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.id_box.Location = New System.Drawing.Point(8, 40)
        Me.id_box.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_box.Name = "id_box"
        Me.id_box.Size = New System.Drawing.Size(677, 23)
        Me.id_box.TabIndex = 1
        Me.id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Benutzeridentifikation:"
        '
        'meinprofil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 200)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "meinprofil"
        Me.Text = "Mein Profil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents yourip_box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents usertype_box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents steamid_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents username_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_box As TextBox
    Friend WithEvents Label1 As Label
End Class
