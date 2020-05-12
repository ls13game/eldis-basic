Public Class maßnahme_list
    Dim maßnahmetext As String
    Private Sub maßnahme_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maßnahmen_list.Rows.Add("LS-Polizei Los Santos verständigen")
        maßnahmen_list.Rows.Add("LS-Rotes Kreuz Los Santos verständigen")
        maßnahmen_list.Rows.Add("LS-FW Sandy-Shores nachalamieren")
        maßnahmen_list.Rows.Add("LS-FW Blane-Country nachalamieren")
        maßnahmen_list.Rows.Add("LS-FW Paleto-Bay nachalamieren")
        maßnahmen_list.Rows.Add("LS-FW LFKDT verständigen")
        maßnahmen_list.Rows.Add("LS-FW LFKDT-STV verständigen")
        maßnahmen_list.Rows.Add("LS-FW Dispo verständigen")
        maßnahmen_list.Rows.Add("LS-FW ELDIS Techniker verständigen")
    End Sub

    Private Sub maßnahmen_list_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles maßnahmen_list.CellDoubleClick
        hauptmenu.maßnahmen_view.Rows.Add(maßnahmen_list.CurrentCell.Value.ToString, True)
        Me.Close()
    End Sub
End Class