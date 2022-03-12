<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Montante_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_gaussjordan = New System.Windows.Forms.Button()
        Me.btn_gaussseidel = New System.Windows.Forms.Button()
        Me.btn_montante = New System.Windows.Forms.Button()
        Me.btn_jacobi = New System.Windows.Forms.Button()
        Me.btn_elimgauss = New System.Windows.Forms.Button()
        Me.lbl_empty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Cvalue = New System.Windows.Forms.TextBox()
        Me.txt_Bvalue = New System.Windows.Forms.TextBox()
        Me.lbl_Cvalue = New System.Windows.Forms.Label()
        Me.lbl_Bvalue = New System.Windows.Forms.Label()
        Me.lbl_Avalue = New System.Windows.Forms.Label()
        Me.txt_Avalue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.btn_pista = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_timer)
        Me.Panel1.Controls.Add(Me.lbl_categoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 60)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(568, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Temporizador:"
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timer.Location = New System.Drawing.Point(721, 15)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(66, 25)
        Me.lbl_timer.TabIndex = 9
        Me.lbl_timer.Text = "20:00"
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(12, 9)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(263, 31)
        Me.lbl_categoria.TabIndex = 0
        Me.lbl_categoria.Text = "Ecuaciones Lineales"
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.DimGray
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_menu.Location = New System.Drawing.Point(12, 602)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(243, 67)
        Me.btn_menu.TabIndex = 8
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_gaussjordan)
        Me.Panel2.Controls.Add(Me.btn_gaussseidel)
        Me.Panel2.Controls.Add(Me.btn_montante)
        Me.Panel2.Controls.Add(Me.btn_jacobi)
        Me.Panel2.Controls.Add(Me.btn_elimgauss)
        Me.Panel2.Controls.Add(Me.lbl_empty)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_Cvalue)
        Me.Panel2.Controls.Add(Me.txt_Bvalue)
        Me.Panel2.Controls.Add(Me.lbl_Cvalue)
        Me.Panel2.Controls.Add(Me.lbl_Bvalue)
        Me.Panel2.Controls.Add(Me.lbl_Avalue)
        Me.Panel2.Controls.Add(Me.txt_Avalue)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_descripcion)
        Me.Panel2.Location = New System.Drawing.Point(51, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1169, 480)
        Me.Panel2.TabIndex = 9
        '
        'btn_gaussjordan
        '
        Me.btn_gaussjordan.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_gaussjordan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gaussjordan.FlatAppearance.BorderSize = 0
        Me.btn_gaussjordan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gaussjordan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gaussjordan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_gaussjordan.Location = New System.Drawing.Point(53, 563)
        Me.btn_gaussjordan.Name = "btn_gaussjordan"
        Me.btn_gaussjordan.Size = New System.Drawing.Size(230, 53)
        Me.btn_gaussjordan.TabIndex = 31
        Me.btn_gaussjordan.Text = "Gauss-Jordan"
        Me.btn_gaussjordan.UseVisualStyleBackColor = False
        '
        'btn_gaussseidel
        '
        Me.btn_gaussseidel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_gaussseidel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gaussseidel.FlatAppearance.BorderSize = 0
        Me.btn_gaussseidel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gaussseidel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gaussseidel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_gaussseidel.Location = New System.Drawing.Point(289, 563)
        Me.btn_gaussseidel.Name = "btn_gaussseidel"
        Me.btn_gaussseidel.Size = New System.Drawing.Size(220, 53)
        Me.btn_gaussseidel.TabIndex = 30
        Me.btn_gaussseidel.Text = "Gauss-Seidel"
        Me.btn_gaussseidel.UseVisualStyleBackColor = False
        '
        'btn_montante
        '
        Me.btn_montante.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_montante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_montante.FlatAppearance.BorderSize = 0
        Me.btn_montante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_montante.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_montante.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_montante.Location = New System.Drawing.Point(794, 563)
        Me.btn_montante.Name = "btn_montante"
        Me.btn_montante.Size = New System.Drawing.Size(167, 53)
        Me.btn_montante.TabIndex = 29
        Me.btn_montante.Text = "Montante"
        Me.btn_montante.UseVisualStyleBackColor = False
        '
        'btn_jacobi
        '
        Me.btn_jacobi.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_jacobi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jacobi.FlatAppearance.BorderSize = 0
        Me.btn_jacobi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_jacobi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jacobi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_jacobi.Location = New System.Drawing.Point(999, 563)
        Me.btn_jacobi.Name = "btn_jacobi"
        Me.btn_jacobi.Size = New System.Drawing.Size(152, 53)
        Me.btn_jacobi.TabIndex = 28
        Me.btn_jacobi.Text = "Jacobi"
        Me.btn_jacobi.UseVisualStyleBackColor = False
        '
        'btn_elimgauss
        '
        Me.btn_elimgauss.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_elimgauss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_elimgauss.FlatAppearance.BorderSize = 0
        Me.btn_elimgauss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_elimgauss.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_elimgauss.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_elimgauss.Location = New System.Drawing.Point(521, 563)
        Me.btn_elimgauss.Name = "btn_elimgauss"
        Me.btn_elimgauss.Size = New System.Drawing.Size(267, 92)
        Me.btn_elimgauss.TabIndex = 27
        Me.btn_elimgauss.Text = "Eliminación Gaussiana"
        Me.btn_elimgauss.UseVisualStyleBackColor = False
        '
        'lbl_empty
        '
        Me.lbl_empty.AutoSize = True
        Me.lbl_empty.Location = New System.Drawing.Point(79, 659)
        Me.lbl_empty.Name = "lbl_empty"
        Me.lbl_empty.Size = New System.Drawing.Size(0, 13)
        Me.lbl_empty.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(782, 42)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "A continuación selecciona el método utilizado:"
        '
        'txt_Cvalue
        '
        Me.txt_Cvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cvalue.Location = New System.Drawing.Point(344, 403)
        Me.txt_Cvalue.Name = "txt_Cvalue"
        Me.txt_Cvalue.Size = New System.Drawing.Size(268, 49)
        Me.txt_Cvalue.TabIndex = 24
        '
        'txt_Bvalue
        '
        Me.txt_Bvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Bvalue.Location = New System.Drawing.Point(344, 356)
        Me.txt_Bvalue.Name = "txt_Bvalue"
        Me.txt_Bvalue.Size = New System.Drawing.Size(268, 49)
        Me.txt_Bvalue.TabIndex = 23
        '
        'lbl_Cvalue
        '
        Me.lbl_Cvalue.AutoSize = True
        Me.lbl_Cvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cvalue.Location = New System.Drawing.Point(49, 400)
        Me.lbl_Cvalue.Name = "lbl_Cvalue"
        Me.lbl_Cvalue.Size = New System.Drawing.Size(291, 42)
        Me.lbl_Cvalue.TabIndex = 22
        Me.lbl_Cvalue.Text = "El valor de C es:"
        '
        'lbl_Bvalue
        '
        Me.lbl_Bvalue.AutoSize = True
        Me.lbl_Bvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bvalue.Location = New System.Drawing.Point(49, 356)
        Me.lbl_Bvalue.Name = "lbl_Bvalue"
        Me.lbl_Bvalue.Size = New System.Drawing.Size(289, 42)
        Me.lbl_Bvalue.TabIndex = 21
        Me.lbl_Bvalue.Text = "El valor de B es:"
        '
        'lbl_Avalue
        '
        Me.lbl_Avalue.AutoSize = True
        Me.lbl_Avalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Avalue.Location = New System.Drawing.Point(49, 315)
        Me.lbl_Avalue.Name = "lbl_Avalue"
        Me.lbl_Avalue.Size = New System.Drawing.Size(289, 42)
        Me.lbl_Avalue.TabIndex = 20
        Me.lbl_Avalue.Text = "El valor de A es:"
        '
        'txt_Avalue
        '
        Me.txt_Avalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Avalue.Location = New System.Drawing.Point(344, 315)
        Me.txt_Avalue.Name = "txt_Avalue"
        Me.txt_Avalue.Size = New System.Drawing.Size(268, 49)
        Me.txt_Avalue.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1094, 84)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Resuelve para las incógnitas de A, B y C. Redondea tu resultado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " a 2 decimales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(442, 42)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "0.7A +0.1B - 8.2C = -56.4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(442, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "3.7A - 7.3B - 0.1C = -18.9"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "25A - 0.9B - 0.3C = 20.2"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(45, 21)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(745, 42)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Se tiene el siguiente sistema de ecuaciones"
        '
        'btn_pista
        '
        Me.btn_pista.BackColor = System.Drawing.Color.DimGray
        Me.btn_pista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pista.FlatAppearance.BorderSize = 0
        Me.btn_pista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pista.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pista.Location = New System.Drawing.Point(1044, 617)
        Me.btn_pista.Name = "btn_pista"
        Me.btn_pista.Size = New System.Drawing.Size(176, 52)
        Me.btn_pista.TabIndex = 10
        Me.btn_pista.Text = "Usar Pista"
        Me.btn_pista.UseVisualStyleBackColor = False
        '
        'Montante_2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btn_pista)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Montante_2"
        Me.Text = "Ecuaciones Lineales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_menu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_empty As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Cvalue As TextBox
    Friend WithEvents txt_Bvalue As TextBox
    Friend WithEvents lbl_Cvalue As Label
    Friend WithEvents lbl_Bvalue As Label
    Friend WithEvents lbl_Avalue As Label
    Friend WithEvents txt_Avalue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents btn_pista As Button
    Friend WithEvents btn_gaussjordan As Button
    Friend WithEvents btn_gaussseidel As Button
    Friend WithEvents btn_montante As Button
    Friend WithEvents btn_jacobi As Button
    Friend WithEvents btn_elimgauss As Button
End Class
