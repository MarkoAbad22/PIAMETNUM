Public Class CuadraticaCubica_1
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
    Private Sub CuadraticaCubica_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub

    Private Sub btn_Cuadratica_Click(sender As Object, e As EventArgs) Handles btn_Cuadratica.Click
        respuesta = checarRespuestaCuadratica()
        If respuesta Then
            CuadraticaCubica_2.Show()
        Else

        End If
    End Sub
    Private Function checarRespuestaCuadratica() As Boolean
        Dim A, B, C, D, E, F As Double
        Try
            A = Convert.ToDouble(TextBox1.Text)
            B = Convert.ToDouble(TextBox2.Text)
            C = Convert.ToDouble(TextBox3.Text)
            D = Convert.ToDouble(TextBox4.Text)
            E = Convert.ToDouble(TextBox5.Text)
            F = Convert.ToDouble(TextBox6.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If A = 2.3 And B = 3.07 And C = 3.53 And D = 5.47 And E = 5.68 And F = 8.31 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function

    Private Sub btn_Cubica_Click(sender As Object, e As EventArgs) Handles btn_Cubica.Click
        respuesta = checarRespuestaCubica()
        If respuesta Then
            CuadraticaCubica_2.Show()
        Else

        End If
    End Sub
    Private Function checarRespuestaCubica() As Boolean
        Dim A, B, C, D, E, F As Double
        Try
            A = Convert.ToDouble(TextBox1.Text)
            B = Convert.ToDouble(TextBox2.Text)
            C = Convert.ToDouble(TextBox3.Text)
            D = Convert.ToDouble(TextBox4.Text)
            E = Convert.ToDouble(TextBox5.Text)
            F = Convert.ToDouble(TextBox6.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If A = 2.43 And B = 3 And C = 3.39 And D = 5.49 And E = 5.76 And F = 8.3 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function
    Private Sub btn_Lineal_Click(sender As Object, e As EventArgs) Handles btn_Lineal.Click
        respuesta = checarRespuestaLineal()
        If respuesta Then
            LineaRecta_1.Show()
        Else

        End If
    End Sub
    Private Function checarRespuestaLineal() As Boolean
        Dim A, B, C, D, E, F As Double
        Try
            A = Convert.ToDouble(TextBox1.Text)
            B = Convert.ToDouble(TextBox2.Text)
            C = Convert.ToDouble(TextBox3.Text)
            D = Convert.ToDouble(TextBox4.Text)
            E = Convert.ToDouble(TextBox5.Text)
            F = Convert.ToDouble(TextBox6.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If A = 2.7 And B = 3.21 And C = 3.52 And D = 5.05 And E = 5.24 And F = 8.66 Then
            MsgBox("Correcto")
            Return True
        Else
            MsgBox("Incorrecto")
            Return False
        End If

    End Function
End Class