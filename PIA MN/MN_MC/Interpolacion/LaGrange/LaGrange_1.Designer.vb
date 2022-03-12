<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaGrange_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_empty = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Cvalue = New System.Windows.Forms.TextBox()
        Me.txt_Bvalue = New System.Windows.Forms.TextBox()
        Me.lbl_Cvalue = New System.Windows.Forms.Label()
        Me.lbl_Bvalue = New System.Windows.Forms.Label()
        Me.lbl_Avalue = New System.Windows.Forms.Label()
        Me.txt_Avalue = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_LaGrange = New System.Windows.Forms.Button()
        Me.btn_NewtonDD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.btn_pista = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_timer)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_categoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 60)
        Me.Panel1.TabIndex = 9
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timer.Location = New System.Drawing.Point(719, 16)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(66, 25)
        Me.lbl_timer.TabIndex = 29
        Me.lbl_timer.Text = "20:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(563, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Temporizador:"
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(12, 9)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(170, 31)
        Me.lbl_categoria.TabIndex = 0
        Me.lbl_categoria.Text = "Interpolación"
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
        Me.btn_menu.Size = New System.Drawing.Size(281, 67)
        Me.btn_menu.TabIndex = 10
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_empty)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_Cvalue)
        Me.Panel2.Controls.Add(Me.txt_Bvalue)
        Me.Panel2.Controls.Add(Me.lbl_Cvalue)
        Me.Panel2.Controls.Add(Me.lbl_Bvalue)
        Me.Panel2.Controls.Add(Me.lbl_Avalue)
        Me.Panel2.Controls.Add(Me.txt_Avalue)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_LaGrange)
        Me.Panel2.Controls.Add(Me.btn_NewtonDD)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_descripcion)
        Me.Panel2.Location = New System.Drawing.Point(51, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1157, 470)
        Me.Panel2.TabIndex = 11
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
        Me.Label7.Location = New System.Drawing.Point(55, 650)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(782, 42)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "A continuación selecciona el método utilizado:"
        '
        'txt_Cvalue
        '
        Me.txt_Cvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cvalue.Location = New System.Drawing.Point(526, 566)
        Me.txt_Cvalue.Name = "txt_Cvalue"
        Me.txt_Cvalue.Size = New System.Drawing.Size(296, 49)
        Me.txt_Cvalue.TabIndex = 24
        '
        'txt_Bvalue
        '
        Me.txt_Bvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Bvalue.Location = New System.Drawing.Point(526, 502)
        Me.txt_Bvalue.Name = "txt_Bvalue"
        Me.txt_Bvalue.Size = New System.Drawing.Size(296, 49)
        Me.txt_Bvalue.TabIndex = 23
        '
        'lbl_Cvalue
        '
        Me.lbl_Cvalue.AutoSize = True
        Me.lbl_Cvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cvalue.Location = New System.Drawing.Point(55, 566)
        Me.lbl_Cvalue.Name = "lbl_Cvalue"
        Me.lbl_Cvalue.Size = New System.Drawing.Size(328, 42)
        Me.lbl_Cvalue.TabIndex = 22
        Me.lbl_Cvalue.Text = "El valor de g(x) es:"
        '
        'lbl_Bvalue
        '
        Me.lbl_Bvalue.AutoSize = True
        Me.lbl_Bvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bvalue.Location = New System.Drawing.Point(55, 502)
        Me.lbl_Bvalue.Name = "lbl_Bvalue"
        Me.lbl_Bvalue.Size = New System.Drawing.Size(390, 42)
        Me.lbl_Bvalue.TabIndex = 21
        Me.lbl_Bvalue.Text = "Segundo  intervalo es:"
        '
        'lbl_Avalue
        '
        Me.lbl_Avalue.AutoSize = True
        Me.lbl_Avalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Avalue.Location = New System.Drawing.Point(55, 442)
        Me.lbl_Avalue.Name = "lbl_Avalue"
        Me.lbl_Avalue.Size = New System.Drawing.Size(337, 42)
        Me.lbl_Avalue.TabIndex = 20
        Me.lbl_Avalue.Text = "Primer intervalo es:"
        '
        'txt_Avalue
        '
        Me.txt_Avalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Avalue.Location = New System.Drawing.Point(526, 439)
        Me.txt_Avalue.Name = "txt_Avalue"
        Me.txt_Avalue.Size = New System.Drawing.Size(296, 49)
        Me.txt_Avalue.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(454, 42)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Busca los intervalos y g(x)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_LaGrange
        '
        Me.btn_LaGrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_LaGrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LaGrange.FlatAppearance.BorderSize = 0
        Me.btn_LaGrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LaGrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LaGrange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_LaGrange.Location = New System.Drawing.Point(179, 743)
        Me.btn_LaGrange.Name = "btn_LaGrange"
        Me.btn_LaGrange.Size = New System.Drawing.Size(250, 87)
        Me.btn_LaGrange.TabIndex = 16
        Me.btn_LaGrange.Text = "LaGrange"
        Me.btn_LaGrange.UseVisualStyleBackColor = False
        '
        'btn_NewtonDD
        '
        Me.btn_NewtonDD.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_NewtonDD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewtonDD.FlatAppearance.BorderSize = 0
        Me.btn_NewtonDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewtonDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewtonDD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_NewtonDD.Location = New System.Drawing.Point(606, 743)
        Me.btn_NewtonDD.Name = "btn_NewtonDD"
        Me.btn_NewtonDD.Size = New System.Drawing.Size(250, 87)
        Me.btn_NewtonDD.TabIndex = 13
        Me.btn_NewtonDD.Text = "Newton Diferencias Divididas"
        Me.btn_NewtonDD.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 168)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "xi          yi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7.3       -0.28" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6.5       -1.35" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6.1       -1.96" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(55, 36)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(461, 84)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Problema de interpolación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resolver g(x) para x=7 "
        '
        'btn_pista
        '
        Me.btn_pista.BackColor = System.Drawing.Color.DimGray
        Me.btn_pista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pista.FlatAppearance.BorderSize = 0
        Me.btn_pista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pista.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pista.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pista.Location = New System.Drawing.Point(1038, 602)
        Me.btn_pista.Name = "btn_pista"
        Me.btn_pista.Size = New System.Drawing.Size(214, 67)
        Me.btn_pista.TabIndex = 29
        Me.btn_pista.Text = "Usar Pista"
        Me.btn_pista.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 879)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'LaGrange_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_pista)
        Me.Name = "LaGrange_1"
        Me.Text = "Interpolación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_categoria As Label
    Friend WithEvents btn_menu As Button
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
    Friend WithEvents btn_LaGrange As Button
    Friend WithEvents btn_NewtonDD As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_pista As Button
    Friend WithEvents lbl_timer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
