Public Class LaGrange_1
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

    Private Sub LaGrange_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub

    Private Sub btn_LaGrange_Click(sender As Object, e As EventArgs) Handles btn_LaGrange.Click
        respuesta = checarRespuesta()
        If respuesta Then
            LaGrange_1_Respuesta.Show()
        Else

        End If
    End Sub
    Private Sub btn_NewtonDD_Click(sender As Object, e As EventArgs) Handles btn_NewtonDD.Click
        respuesta = checarRespuesta()
        If respuesta Then
            NewtonDD_1_Respuesta.Show()
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

        If A = 0.8 And B = 0.4 And C = 0.657813 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function


End Class