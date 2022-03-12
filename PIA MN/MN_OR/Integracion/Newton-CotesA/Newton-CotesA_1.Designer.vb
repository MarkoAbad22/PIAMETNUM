<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newton_CotesA_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newton_CotesA_1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_pista = New System.Windows.Forms.Button()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_RT = New System.Windows.Forms.Button()
        Me.btn_NCA = New System.Windows.Forms.Button()
        Me.btn_NCC = New System.Windows.Forms.Button()
        Me.btn_simpson18 = New System.Windows.Forms.Button()
        Me.btn_simpson13 = New System.Windows.Forms.Button()
        Me.txt_Avalue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_empty = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1264, 49)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(569, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Temporizador:"
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timer.Location = New System.Drawing.Point(722, 15)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(66, 25)
        Me.lbl_timer.TabIndex = 3
        Me.lbl_timer.Text = "20:00"
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(12, 9)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(149, 31)
        Me.lbl_categoria.TabIndex = 0
        Me.lbl_categoria.Text = "Integración"
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.DimGray
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_menu.Location = New System.Drawing.Point(18, 602)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(252, 67)
        Me.btn_menu.TabIndex = 11
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btn_pista
        '
        Me.btn_pista.BackColor = System.Drawing.Color.DimGray
        Me.btn_pista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pista.FlatAppearance.BorderSize = 0
        Me.btn_pista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pista.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pista.Location = New System.Drawing.Point(1067, 613)
        Me.btn_pista.Name = "btn_pista"
        Me.btn_pista.Size = New System.Drawing.Size(185, 56)
        Me.btn_pista.TabIndex = 13
        Me.btn_pista.Text = "Usar Pista"
        Me.btn_pista.UseVisualStyleBackColor = False
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(45, 21)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(517, 42)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Resuelve la siguiente Integral:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(953, 42)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Encuentre el valor de ""I"" (REDONDEA A 4 DECIMALES)"
        '
        'btn_RT
        '
        Me.btn_RT.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_RT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_RT.FlatAppearance.BorderSize = 0
        Me.btn_RT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_RT.Location = New System.Drawing.Point(811, 541)
        Me.btn_RT.Name = "btn_RT"
        Me.btn_RT.Size = New System.Drawing.Size(239, 53)
        Me.btn_RT.TabIndex = 9
        Me.btn_RT.Text = "Regla Trapezoidal"
        Me.btn_RT.UseVisualStyleBackColor = False
        '
        'btn_NCA
        '
        Me.btn_NCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_NCA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NCA.FlatAppearance.BorderSize = 0
        Me.btn_NCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NCA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_NCA.Location = New System.Drawing.Point(425, 541)
        Me.btn_NCA.Name = "btn_NCA"
        Me.btn_NCA.Size = New System.Drawing.Size(239, 53)
        Me.btn_NCA.TabIndex = 13
        Me.btn_NCA.Text = "Newton-Cotes Abierta"
        Me.btn_NCA.UseVisualStyleBackColor = False
        '
        'btn_NCC
        '
        Me.btn_NCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_NCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NCC.FlatAppearance.BorderSize = 0
        Me.btn_NCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NCC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_NCC.Location = New System.Drawing.Point(608, 461)
        Me.btn_NCC.Name = "btn_NCC"
        Me.btn_NCC.Size = New System.Drawing.Size(239, 53)
        Me.btn_NCC.TabIndex = 14
        Me.btn_NCC.Text = "Newton-Cotes Cerrada"
        Me.btn_NCC.UseVisualStyleBackColor = False
        '
        'btn_simpson18
        '
        Me.btn_simpson18.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_simpson18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpson18.FlatAppearance.BorderSize = 0
        Me.btn_simpson18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpson18.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpson18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_simpson18.Location = New System.Drawing.Point(219, 461)
        Me.btn_simpson18.Name = "btn_simpson18"
        Me.btn_simpson18.Size = New System.Drawing.Size(239, 53)
        Me.btn_simpson18.TabIndex = 15
        Me.btn_simpson18.Text = "3/8 Simpson"
        Me.btn_simpson18.UseVisualStyleBackColor = False
        '
        'btn_simpson13
        '
        Me.btn_simpson13.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_simpson13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpson13.FlatAppearance.BorderSize = 0
        Me.btn_simpson13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpson13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpson13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_simpson13.Location = New System.Drawing.Point(53, 541)
        Me.btn_simpson13.Name = "btn_simpson13"
        Me.btn_simpson13.Size = New System.Drawing.Size(239, 53)
        Me.btn_simpson13.TabIndex = 16
        Me.btn_simpson13.Text = "1/3 Simpson"
        Me.btn_simpson13.UseVisualStyleBackColor = False
        '
        'txt_Avalue
        '
        Me.txt_Avalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Avalue.Location = New System.Drawing.Point(56, 245)
        Me.txt_Avalue.Name = "txt_Avalue"
        Me.txt_Avalue.Size = New System.Drawing.Size(338, 49)
        Me.txt_Avalue.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(782, 42)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "A continuación selecciona el método utilizado:"
        '
        'lbl_empty
        '
        Me.lbl_empty.AutoSize = True
        Me.lbl_empty.Location = New System.Drawing.Point(79, 659)
        Me.lbl_empty.Name = "lbl_empty"
        Me.lbl_empty.Size = New System.Drawing.Size(0, 13)
        Me.lbl_empty.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_empty)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_Avalue)
        Me.Panel2.Controls.Add(Me.btn_simpson13)
        Me.Panel2.Controls.Add(Me.btn_simpson18)
        Me.Panel2.Controls.Add(Me.btn_NCC)
        Me.Panel2.Controls.Add(Me.btn_NCA)
        Me.Panel2.Controls.Add(Me.btn_RT)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbl_descripcion)
        Me.Panel2.Location = New System.Drawing.Point(51, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1167, 499)
        Me.Panel2.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(448, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Newton_CotesA_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btn_pista)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Newton_CotesA_1"
        Me.Text = "Integración"
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
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_pista As Button
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_RT As Button
    Friend WithEvents btn_NCA As Button
    Friend WithEvents btn_NCC As Button
    Friend WithEvents btn_simpson18 As Button
    Friend WithEvents btn_simpson13 As Button
    Friend WithEvents txt_Avalue As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_empty As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
