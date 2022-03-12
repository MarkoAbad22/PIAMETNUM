Public Class MainMenu
    Public pistas = 5
    Private Sub btn_creditos_Click(sender As Object, e As EventArgs) Handles btn_creditos.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ecLineal_Click(sender As Object, e As EventArgs) Handles btn_ecLineal.Click
        Dim MyValue As Integer
        MyValue = Int((2 * Rnd()) + 1)
        If MyValue = 1 Then
            Montante_1.Show()
        Else
            Montante_2.Show()
        End If
        Me.Hide()
    End Sub
    Private Sub btn_interolacion_Click(sender As Object, e As EventArgs) Handles btn_interolacion.Click
        LaGrange_1.Show()
        Me.Hide()
    End Sub
    Private Sub btn_eclin2_Click(sender As Object, e As EventArgs)
        Montante_2.Show()
    End Sub

    Private Sub btn_ecNoLineal_Click(sender As Object, e As EventArgs) Handles btn_ecNoLineal.Click
        Secante_1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        CuadraticaCubica_1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        LinealCuadraticaFuncion_1.Show()
    End Sub

    Private Sub btn_integracion_Click(sender As Object, e As EventArgs) Handles btn_integracion.Click
        Newton_CotesA_1.Show()
        Me.Hide()
    End Sub
End Class
