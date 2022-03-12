Public Class Newton_CotesA_1
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(20)
    Private respuesta As Boolean
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            lbl_timer.Text = ts.ToString("mm\:ss")
        Else
            lbl_timer.Text = "00:00"
            Timer1.Stop()
            MsgBox("Tiempo Acabado")
        End If
    End Sub
    Private Sub NCA_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub
    Private Function checarRespuesta() As Boolean
        Dim A As Double
        Try
            A = Convert.ToDouble(txt_Avalue.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If A = 0.6666 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function
    Private Sub btn_pista_Click(sender As Object, e As EventArgs) Handles btn_pista.Click
        MsgBox("Sólo no puede usarse el método de Newton-Cotes Cerrada) ")
        MainMenu.pistas = MainMenu.pistas - 1
    End Sub

    Private Sub btn_NCA_Click(sender As Object, e As EventArgs) Handles btn_NCA.Click
        respuesta = checarRespuesta()
        If respuesta Then
            Newton_CotesA_1_Respuesta.Show()
        Else

        End If
    End Sub

    Private Sub btn_RT_Click(sender As Object, e As EventArgs) Handles btn_RT.Click
        respuesta = checarRespuesta()
        If respuesta Then
            Regla_Trapezoida_1_Respuesta.Show()
        Else

        End If
    End Sub

    Private Sub btn_simpson13_Click(sender As Object, e As EventArgs) Handles btn_simpson13.Click
        respuesta = checarRespuesta()
        If respuesta Then
            simpson13_1_Respuesta.Show()
        Else

        End If
    End Sub

    Private Sub btn_NCC_Click(sender As Object, e As EventArgs) Handles btn_NCC.Click
        respuesta = checarRespuesta()
    End Sub
End Class