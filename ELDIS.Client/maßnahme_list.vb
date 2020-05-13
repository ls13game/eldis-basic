Public Class maßnahme_list
    Dim maßnahmetext As String
    Private Sub maßnahme_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mit dieser Function fügt man eine neue Maßnahme hinzu, wie sie funktioniert, und co, ist dir überlassen!
        ' maßnahmen_list.Rows.Add("Maßnahmedemo")
        ' Mit dieser Function fügt man eine neue Maßnahme hinzu, wie sie funktioniert, und co, ist dir überlassen!
    End Sub

    Private Sub maßnahmen_list_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles maßnahmen_list.CellDoubleClick
        hauptmenu.maßnahmen_view.Rows.Add(maßnahmen_list.CurrentCell.Value.ToString, True)
        Me.Close()
    End Sub
End Class