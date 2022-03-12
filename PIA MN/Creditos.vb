Public Class Creditos
    Private Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_integrantes.Rows.Add("1863594", "Marco Abad Gasca Rodriguez", "IEA")
        dgv_integrantes.Rows.Add("1907875", "Valentín Alejandro Lizcano Esquivel", "ITS")
        dgv_integrantes.Rows.Add("1120086", "Arturo Guadalupe Reyes Castillo", "IEA")
        dgv_integrantes.Rows.Add("2035685", "Jonathan Eduardo Morales Cruz", "IEA")
        dgv_integrantes.Rows.Add("1920967", "Alvaro Fernando Novales Treviño", "IEA")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class