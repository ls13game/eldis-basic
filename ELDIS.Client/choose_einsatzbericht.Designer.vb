<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choose_einsatzbericht
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
        Me.einsatzbericht = New System.Windows.Forms.DataGridView()
        CType(Me.einsatzbericht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'einsatzbericht
        '
        Me.einsatzbericht.AllowUserToAddRows = False
        Me.einsatzbericht.AllowUserToDeleteRows = False
        Me.einsatzbericht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.einsatzbericht.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.einsatzbericht.BackgroundColor = System.Drawing.Color.White
        Me.einsatzbericht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.einsatzbericht.Dock = System.Windows.Forms.DockStyle.Fill
        Me.einsatzbericht.Location = New System.Drawing.Point(0, 0)
        Me.einsatzbericht.Name = "einsatzbericht"
        Me.einsatzbericht.ReadOnly = True
        Me.einsatzbericht.RowHeadersWidth = 62
        Me.einsatzbericht.RowTemplate.Height = 28
        Me.einsatzbericht.Size = New System.Drawing.Size(1477, 935)
        Me.einsatzbericht.TabIndex = 0
        '
        'choose_einsatzbericht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 935)
        Me.Controls.Add(Me.einsatzbericht)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "choose_einsatzbericht"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einsatzbericht auswählen!"
        CType(Me.einsatzbericht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents einsatzbericht As DataGridView
End Class
