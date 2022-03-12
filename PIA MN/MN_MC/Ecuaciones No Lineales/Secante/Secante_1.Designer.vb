<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secante_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Secante_1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_secante = New System.Windows.Forms.Button()
        Me.lbl_empty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_answer = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_grafico = New System.Windows.Forms.Button()
        Me.btn_bisectriz = New System.Windows.Forms.Button()
        Me.btn_nr = New System.Windows.Forms.Button()
        Me.btn_fposicion = New System.Windows.Forms.Button()
        Me.btn_pfijo = New System.Windows.Forms.Button()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.btn_pista = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_categoria)
        Me.Panel1.Controls.Add(Me.lbl_timer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 60)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(569, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Temporizador:"
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(12, 9)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(305, 31)
        Me.lbl_categoria.TabIndex = 0
        Me.lbl_categoria.Text = "Ecuaciones No Lineales"
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timer.Location = New System.Drawing.Point(722, 9)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(66, 25)
        Me.lbl_timer.TabIndex = 13
        Me.lbl_timer.Text = "20:00"
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.DimGray
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_menu.Location = New System.Drawing.Point(18, 601)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(244, 67)
        Me.btn_menu.TabIndex = 10
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btn_secante)
        Me.Panel2.Controls.Add(Me.lbl_empty)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_answer)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_grafico)
        Me.Panel2.Controls.Add(Me.btn_bisectriz)
        Me.Panel2.Controls.Add(Me.btn_nr)
        Me.Panel2.Controls.Add(Me.btn_pfijo)
        Me.Panel2.Controls.Add(Me.lbl_descripcion)
        Me.Panel2.Controls.Add(Me.lbl_answer)
        Me.Panel2.Controls.Add(Me.btn_fposicion)
        Me.Panel2.Location = New System.Drawing.Point(51, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1176, 475)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(449, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'btn_secante
        '
        Me.btn_secante.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_secante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_secante.FlatAppearance.BorderSize = 0
        Me.btn_secante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_secante.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_secante.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_secante.Location = New System.Drawing.Point(585, 528)
        Me.btn_secante.Name = "btn_secante"
        Me.btn_secante.Size = New System.Drawing.Size(384, 53)
        Me.btn_secante.TabIndex = 27
        Me.btn_secante.Text = "Secante"
        Me.btn_secante.UseVisualStyleBackColor = False
        '
        'lbl_empty
        '
        Me.lbl_empty.AutoSize = True
        Me.lbl_empty.Location = New System.Drawing.Point(124, 629)
        Me.lbl_empty.Name = "lbl_empty"
        Me.lbl_empty.Size = New System.Drawing.Size(0, 13)
        Me.lbl_empty.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(782, 42)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "A continuación selecciona el método utilizado:"
        '
        'lbl_answer
        '
        Me.lbl_answer.AutoSize = True
        Me.lbl_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_answer.Location = New System.Drawing.Point(49, 203)
        Me.lbl_answer.Name = "lbl_answer"
        Me.lbl_answer.Size = New System.Drawing.Size(363, 42)
        Me.lbl_answer.TabIndex = 20
        Me.lbl_answer.Text = "El valor de la raíz es:"
        '
        'txt_answer
        '
        Me.txt_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_answer.Location = New System.Drawing.Point(484, 203)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(394, 49)
        Me.txt_answer.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(436, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Solo existe una raíz para este problema"
        '
        'btn_grafico
        '
        Me.btn_grafico.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_grafico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_grafico.FlatAppearance.BorderSize = 0
        Me.btn_grafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grafico.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grafico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grafico.Location = New System.Drawing.Point(54, 351)
        Me.btn_grafico.Name = "btn_grafico"
        Me.btn_grafico.Size = New System.Drawing.Size(384, 53)
        Me.btn_grafico.TabIndex = 16
        Me.btn_grafico.Text = "Gráfico"
        Me.btn_grafico.UseVisualStyleBackColor = False
        '
        'btn_bisectriz
        '
        Me.btn_bisectriz.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_bisectriz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bisectriz.FlatAppearance.BorderSize = 0
        Me.btn_bisectriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bisectriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bisectriz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_bisectriz.Location = New System.Drawing.Point(54, 436)
        Me.btn_bisectriz.Name = "btn_bisectriz"
        Me.btn_bisectriz.Size = New System.Drawing.Size(384, 53)
        Me.btn_bisectriz.TabIndex = 15
        Me.btn_bisectriz.Text = "Bisectriz"
        Me.btn_bisectriz.UseVisualStyleBackColor = False
        '
        'btn_nr
        '
        Me.btn_nr.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_nr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nr.FlatAppearance.BorderSize = 0
        Me.btn_nr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_nr.Location = New System.Drawing.Point(585, 351)
        Me.btn_nr.Name = "btn_nr"
        Me.btn_nr.Size = New System.Drawing.Size(384, 53)
        Me.btn_nr.TabIndex = 14
        Me.btn_nr.Text = "Newton-Raphson"
        Me.btn_nr.UseVisualStyleBackColor = False
        '
        'btn_fposicion
        '
        Me.btn_fposicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_fposicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fposicion.FlatAppearance.BorderSize = 0
        Me.btn_fposicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fposicion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_fposicion.Location = New System.Drawing.Point(54, 528)
        Me.btn_fposicion.Name = "btn_fposicion"
        Me.btn_fposicion.Size = New System.Drawing.Size(384, 53)
        Me.btn_fposicion.TabIndex = 13
        Me.btn_fposicion.Text = "Falsa Posición"
        Me.btn_fposicion.UseVisualStyleBackColor = False
        '
        'btn_pfijo
        '
        Me.btn_pfijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_pfijo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pfijo.FlatAppearance.BorderSize = 0
        Me.btn_pfijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pfijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pfijo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pfijo.Location = New System.Drawing.Point(585, 436)
        Me.btn_pfijo.Name = "btn_pfijo"
        Me.btn_pfijo.Size = New System.Drawing.Size(384, 53)
        Me.btn_pfijo.TabIndex = 9
        Me.btn_pfijo.Text = "Punto Fijo"
        Me.btn_pfijo.UseVisualStyleBackColor = False
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(45, 21)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(314, 42)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Calcule la raíz de:"
        '
        'btn_pista
        '
        Me.btn_pista.BackColor = System.Drawing.Color.DimGray
        Me.btn_pista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pista.FlatAppearance.BorderSize = 0
        Me.btn_pista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pista.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pista.Location = New System.Drawing.Point(1075, 630)
        Me.btn_pista.Name = "btn_pista"
        Me.btn_pista.Size = New System.Drawing.Size(177, 38)
        Me.btn_pista.TabIndex = 12
        Me.btn_pista.Text = "Usar Pista"
        Me.btn_pista.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Secante_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btn_pista)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Secante_1"
        Me.Text = "Ecuaciones No Lineales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents btn_menu As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_answer As Label
    Friend WithEvents txt_answer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_grafico As Button
    Friend WithEvents btn_bisectriz As Button
    Friend WithEvents btn_nr As Button
    Friend WithEvents btn_fposicion As Button
    Friend WithEvents btn_pfijo As Button
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_secante As Button
    Friend WithEvents lbl_empty As Label
    Friend WithEvents btn_pista As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents Timer1 As Timer
End Class
