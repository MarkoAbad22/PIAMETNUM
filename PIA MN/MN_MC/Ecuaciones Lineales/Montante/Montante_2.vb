Public Class Montante_2
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(20)
    Private respuesta As Boolean
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        TargetDT = DateTime.Now.Add(CountDownFrom)
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

    Private Sub Montante_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub

    Private Sub btn_gaussjordan_Click(sender As Object, e As EventArgs) Handles btn_gaussjordan.Click
        respuesta = checarRespuesta()
        If respuesta Then
            Montante_2_Respuesta.Show()
        Else

        End If
    End Sub

    Private Sub btn_gaussseidel_Click(sender As Object, e As EventArgs) Handles btn_gaussseidel.Click
        respuesta = checarRespuesta()
        If respuesta Then
            Montante_2_Respuesta.Show()
        Else

        End If
    End Sub

    Private Sub btn_montante_Click(sender As Object, e As EventArgs) Handles btn_montante.Click
        respuesta = checarRespuesta()
        If respuesta Then
            Montante_2_Respuesta.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub btn_elimgauss_Click(sender As Object, e As EventArgs) Handles btn_elimgauss.Click
        respuesta = checarRespuesta()
        If respuesta Then
            EGaussiana_1.Show()
        Else

        End If
    End Sub

    Private Sub btn_jacobi_Click(sender As Object, e As EventArgs) Handles btn_jacobi.Click
        respuesta = checarRespuesta()
        If respuesta Then
            EGaussiana_1.Show()
        Else

        End If
    End Sub

    Private Function checarRespuesta() As Boolean
        Dim A, B, C As Double
        Try
            A = Convert.ToDouble(txt_Avalue.Text)
            B = Convert.ToDouble(txt_Bvalue.Text)
            C = Convert.ToDouble(txt_Cvalue.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If A = 1 And B = 3 And C = 7 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function


    Private Sub btn_pista_Click(sender As Object, e As EventArgs) Handles btn_pista.Click
        MsgBox("Se puede usar cualquier método, suerte.")
        MainMenu.pistas = MainMenu.pistas - 1
    End Sub
End Class