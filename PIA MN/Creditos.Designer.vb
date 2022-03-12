<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_creditosmain = New System.Windows.Forms.Label()
        Me.dgv_integrantes = New System.Windows.Forms.DataGridView()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_creditos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_integrantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_creditosmain
        '
        Me.lbl_creditosmain.AutoSize = True
        Me.lbl_creditosmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_creditosmain.Location = New System.Drawing.Point(34, 82)
        Me.lbl_creditosmain.Name = "lbl_creditosmain"
        Me.lbl_creditosmain.Size = New System.Drawing.Size(397, 42)
        Me.lbl_creditosmain.TabIndex = 1
        Me.lbl_creditosmain.Text = "Integrantes del equipo:"
        '
        'dgv_integrantes
        '
        Me.dgv_integrantes.AllowUserToAddRows = False
        Me.dgv_integrantes.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_integrantes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_integrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_integrantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricula, Me.nombre, Me.carrera})
        Me.dgv_integrantes.Location = New System.Drawing.Point(39, 149)
        Me.dgv_integrantes.Name = "dgv_integrantes"
        Me.dgv_integrantes.ReadOnly = True
        Me.dgv_integrantes.Size = New System.Drawing.Size(900, 150)
        Me.dgv_integrantes.TabIndex = 2
        '
        'matricula
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matricula.DefaultCellStyle = DataGridViewCellStyle14
        Me.matricula.FillWeight = 200.0!
        Me.matricula.HeaderText = "Matrícula"
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        Me.matricula.Width = 200
        '
        'nombre
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle15
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 500
        '
        'carrera
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carrera.DefaultCellStyle = DataGridViewCellStyle16
        Me.carrera.HeaderText = "Carrera"
        Me.carrera.Name = "carrera"
        Me.carrera.ReadOnly = True
        Me.carrera.Width = 150
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.DimGray
        Me.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_menu.Location = New System.Drawing.Point(12, 602)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(216, 67)
        Me.btn_menu.TabIndex = 3
        Me.btn_menu.Text = "Menú Principal"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_creditos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 60)
        Me.Panel1.TabIndex = 4
        '
        'lbl_creditos
        '
        Me.lbl_creditos.AutoSize = True
        Me.lbl_creditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_creditos.Location = New System.Drawing.Point(12, 9)
        Me.lbl_creditos.Name = "lbl_creditos"
        Me.lbl_creditos.Size = New System.Drawing.Size(116, 31)
        Me.lbl_creditos.TabIndex = 0
        Me.lbl_creditos.Text = "Créditos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Periodo: Febrero - Junio 2022"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grupo: 003"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 42)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hora: V1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(835, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 42)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Frecuencia: 6, Sabatinos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(635, 541)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(598, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Profesora: Oralia Zamora Pequeño"
        '
        'Creditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.dgv_integrantes)
        Me.Controls.Add(Me.lbl_creditosmain)
        Me.Name = "Creditos"
        Me.Text = "Creditos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_integrantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_creditosmain As Label
    Friend WithEvents dgv_integrantes As DataGridView
    Friend WithEvents btn_menu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_creditos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents matricula As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents carrera As DataGridViewTextBoxColumn
End Class
