<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maßnahme_list
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
        Me.maßnahmen_list = New System.Windows.Forms.DataGridView()
        Me.Maßnahme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.maßnahmen_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'maßnahmen_list
        '
        Me.maßnahmen_list.AllowUserToAddRows = False
        Me.maßnahmen_list.AllowUserToDeleteRows = False
        Me.maßnahmen_list.AllowUserToResizeColumns = False
        Me.maßnahmen_list.AllowUserToResizeRows = False
        Me.maßnahmen_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.maßnahmen_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.maßnahmen_list.BackgroundColor = System.Drawing.Color.White
        Me.maßnahmen_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.maßnahmen_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.maßnahmen_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Maßnahme})
        Me.maßnahmen_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maßnahmen_list.GridColor = System.Drawing.Color.White
        Me.maßnahmen_list.Location = New System.Drawing.Point(0, 0)
        Me.maßnahmen_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.maßnahmen_list.Name = "maßnahmen_list"
        Me.maßnahmen_list.ReadOnly = True
        Me.maßnahmen_list.RowHeadersWidth = 62
        Me.maßnahmen_list.Size = New System.Drawing.Size(1341, 752)
        Me.maßnahmen_list.TabIndex = 0
        '
        'Maßnahme
        '
        Me.Maßnahme.HeaderText = "Maßnahme"
        Me.Maßnahme.MinimumWidth = 8
        Me.Maßnahme.Name = "Maßnahme"
        Me.Maßnahme.ReadOnly = True
        '
        'maßnahme_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 752)
        Me.Controls.Add(Me.maßnahmen_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "maßnahme_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maßnahmen"
        CType(Me.maßnahmen_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents maßnahmen_list As DataGridView
    Friend WithEvents Maßnahme As DataGridViewTextBoxColumn
End Class
