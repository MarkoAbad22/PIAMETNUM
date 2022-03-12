Public Class Secante_1
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(20)
    Private respuesta As Boolean
    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        TargetDT = DateTime.Now.Add(CountDownFrom)
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_pista_Click(sender As Object, e As EventArgs) Handles btn_pista.Click
        MsgBox("Los métodos que se pueden usar son: Secante." & vbCrLf & "El resto solo intentan engañarte!")
        MainMenu.pistas = MainMenu.pistas - 1
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

    Private Sub Secante_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub

    Private Sub btn_grafico_Click(sender As Object, e As EventArgs) Handles btn_grafico.Click
        If txt_answer.Text = "" Then
            MsgBox("Ingrese su respuesta")
        ElseIf txt_answer.Text > 0.4 And txt_answer.Text < 0.6 Then
            MsgBox("Respuesta correcta")
            Grafico_1_Respuesta.Show()
        Else
            MsgBox("Respuesta incorrecta")

        End If

    End Sub

    Private Sub btn_secante_Click(sender As Object, e As EventArgs) Handles btn_secante.Click
        If txt_answer.Text = "" Then
            MsgBox("Ingrese su respuesta")
        Else
            Dim Answer As Double
            Try
                Answer = Convert.ToDouble(txt_answer.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If Answer > 0.566143306 And Answer < 0.568143306 Then
                Secante_1_Respuesta.Show()
                MsgBox("Respuesta correcta")
            Else
                MsgBox("Respuesta incorrecta")
            End If
        End If
    End Sub



    Private Sub btn_pfijo_Click(sender As Object, e As EventArgs) Handles btn_pfijo.Click
        If txt_answer.Text = "" Then
            MsgBox("Ingrese su respuesta")
        Else
            Dim Answer As Double
            Try
                Answer = Convert.ToDouble(txt_answer.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If Answer > 0.5671307815 And Answer < 0.5671507815 Then
                PuntoFijo_1_Respuesta.Show()
                MsgBox("Respuesta correcta")
            Else
                MsgBox("Respuesta incorrecta")
            End If
        End If
    End Sub

    Private Sub btn_nr_Click(sender As Object, e As EventArgs) Handles btn_nr.Click

    End Sub

    Private Sub btn_fposicion_Click(sender As Object, e As EventArgs) Handles btn_fposicion.Click

    End Sub
End Class