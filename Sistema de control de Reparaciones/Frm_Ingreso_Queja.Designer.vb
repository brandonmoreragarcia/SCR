<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ingreso_Queja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ingreso_Queja))
        Me.Lbl_Titulo__Ingreso_Quejas = New System.Windows.Forms.Label()
        Me.Txt_Cliente = New System.Windows.Forms.TextBox()
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES1 = New WindowsApplication1.ExactusERP_TABLES()
        Me.Lbl_Telefonos = New System.Windows.Forms.Label()
        Me.Lbl_Telefono_1 = New System.Windows.Forms.Label()
        Me.Lbl_Telefono_2 = New System.Windows.Forms.Label()
        Me.Lbl_T_Fax = New System.Windows.Forms.Label()
        Me.Lbl_Fax = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Tipo_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Cbx_Tipo_Queja = New System.Windows.Forms.ComboBox()
        Me.SCRTIPOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_TIPO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TIPO_QUEJATableAdapter()
        Me.Lbl_Fecha_Hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Txt_Descripcion_Queja = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter1 = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.Lbl_T_Num_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Nun_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Factura = New System.Windows.Forms.Label()
        Me.Lbl_Proforma = New System.Windows.Forms.Label()
        Me.Txt_Factura = New System.Windows.Forms.TextBox()
        Me.Txt_Proforma = New System.Windows.Forms.TextBox()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Titulo__Ingreso_Quejas
        '
        Me.Lbl_Titulo__Ingreso_Quejas.AutoSize = True
        Me.Lbl_Titulo__Ingreso_Quejas.Font = New System.Drawing.Font("Square721 BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo__Ingreso_Quejas.Location = New System.Drawing.Point(136, 9)
        Me.Lbl_Titulo__Ingreso_Quejas.Name = "Lbl_Titulo__Ingreso_Quejas"
        Me.Lbl_Titulo__Ingreso_Quejas.Size = New System.Drawing.Size(516, 25)
        Me.Lbl_Titulo__Ingreso_Quejas.TabIndex = 0
        Me.Lbl_Titulo__Ingreso_Quejas.Text = "Registro de Quejas de Clientes Internos o Externos"
        '
        'Txt_Cliente
        '
        Me.Txt_Cliente.Location = New System.Drawing.Point(66, 48)
        Me.Txt_Cliente.Name = "Txt_Cliente"
        Me.Txt_Cliente.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Cliente.TabIndex = 1
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(12, 51)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(48, 14)
        Me.Lbl_Cliente.TabIndex = 2
        Me.Lbl_Cliente.Text = "Cliente:"
        '
        'Lbl_T_Nombre
        '
        Me.Lbl_T_Nombre.AutoSize = True
        Me.Lbl_T_Nombre.Location = New System.Drawing.Point(180, 53)
        Me.Lbl_T_Nombre.Name = "Lbl_T_Nombre"
        Me.Lbl_T_Nombre.Size = New System.Drawing.Size(53, 14)
        Me.Lbl_T_Nombre.TabIndex = 3
        Me.Lbl_T_Nombre.Text = "Nombre:"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(233, 53)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(49, 14)
        Me.Lbl_Nombre.TabIndex = 4
        Me.Lbl_Nombre.Text = "Nombre"
        Me.Lbl_Nombre.Visible = False
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.ExactusERP_TABLES1
        Me.CLIENTEBindingSource.Filter = ""
        '
        'ExactusERP_TABLES1
        '
        Me.ExactusERP_TABLES1.DataSetName = "ExactusERP_TABLES"
        Me.ExactusERP_TABLES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Telefonos
        '
        Me.Lbl_Telefonos.AutoSize = True
        Me.Lbl_Telefonos.Location = New System.Drawing.Point(18, 80)
        Me.Lbl_Telefonos.Name = "Lbl_Telefonos"
        Me.Lbl_Telefonos.Size = New System.Drawing.Size(60, 14)
        Me.Lbl_Telefonos.TabIndex = 5
        Me.Lbl_Telefonos.Text = "Telefonos:"
        '
        'Lbl_Telefono_1
        '
        Me.Lbl_Telefono_1.AutoSize = True
        Me.Lbl_Telefono_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Lbl_Telefono_1.Location = New System.Drawing.Point(84, 80)
        Me.Lbl_Telefono_1.Name = "Lbl_Telefono_1"
        Me.Lbl_Telefono_1.Size = New System.Drawing.Size(61, 14)
        Me.Lbl_Telefono_1.TabIndex = 6
        Me.Lbl_Telefono_1.Text = "Telefono 1"
        Me.Lbl_Telefono_1.Visible = False
        '
        'Lbl_Telefono_2
        '
        Me.Lbl_Telefono_2.AutoSize = True
        Me.Lbl_Telefono_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Lbl_Telefono_2.Location = New System.Drawing.Point(151, 80)
        Me.Lbl_Telefono_2.Name = "Lbl_Telefono_2"
        Me.Lbl_Telefono_2.Size = New System.Drawing.Size(61, 14)
        Me.Lbl_Telefono_2.TabIndex = 7
        Me.Lbl_Telefono_2.Text = "Telefono 2"
        Me.Lbl_Telefono_2.Visible = False
        '
        'Lbl_T_Fax
        '
        Me.Lbl_T_Fax.AutoSize = True
        Me.Lbl_T_Fax.Location = New System.Drawing.Point(233, 80)
        Me.Lbl_T_Fax.Name = "Lbl_T_Fax"
        Me.Lbl_T_Fax.Size = New System.Drawing.Size(30, 14)
        Me.Lbl_T_Fax.TabIndex = 8
        Me.Lbl_T_Fax.Text = "Fax:"
        '
        'Lbl_Fax
        '
        Me.Lbl_Fax.AutoSize = True
        Me.Lbl_Fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "FAX", True))
        Me.Lbl_Fax.Location = New System.Drawing.Point(269, 80)
        Me.Lbl_Fax.Name = "Lbl_Fax"
        Me.Lbl_Fax.Size = New System.Drawing.Size(26, 14)
        Me.Lbl_Fax.TabIndex = 9
        Me.Lbl_Fax.Text = "Fax"
        Me.Lbl_Fax.Visible = False
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(385, 80)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(37, 14)
        Me.Lbl_T_Alias.TabIndex = 10
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Location = New System.Drawing.Point(428, 80)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(33, 14)
        Me.Lbl_Alias.TabIndex = 11
        Me.Lbl_Alias.Text = "Alias"
        Me.Lbl_Alias.Visible = False
        '
        'Lbl_Tipo_Queja
        '
        Me.Lbl_Tipo_Queja.AutoSize = True
        Me.Lbl_Tipo_Queja.Location = New System.Drawing.Point(12, 120)
        Me.Lbl_Tipo_Queja.Name = "Lbl_Tipo_Queja"
        Me.Lbl_Tipo_Queja.Size = New System.Drawing.Size(46, 14)
        Me.Lbl_Tipo_Queja.TabIndex = 12
        Me.Lbl_Tipo_Queja.Text = "Motivo:"
        '
        'Lbl_Descripcion_Queja
        '
        Me.Lbl_Descripcion_Queja.AutoSize = True
        Me.Lbl_Descripcion_Queja.Location = New System.Drawing.Point(316, 146)
        Me.Lbl_Descripcion_Queja.Name = "Lbl_Descripcion_Queja"
        Me.Lbl_Descripcion_Queja.Size = New System.Drawing.Size(183, 14)
        Me.Lbl_Descripcion_Queja.TabIndex = 13
        Me.Lbl_Descripcion_Queja.Text = "Descripcion Detallada de la Queja"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(658, 18)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(38, 14)
        Me.Lbl_Fecha.TabIndex = 14
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Cbx_Tipo_Queja
        '
        Me.Cbx_Tipo_Queja.DataSource = Me.SCRTIPOQUEJABindingSource
        Me.Cbx_Tipo_Queja.DisplayMember = "TIPO_QUEJA"
        Me.Cbx_Tipo_Queja.DropDownWidth = 420
        Me.Cbx_Tipo_Queja.FormattingEnabled = True
        Me.Cbx_Tipo_Queja.Location = New System.Drawing.Point(60, 115)
        Me.Cbx_Tipo_Queja.Name = "Cbx_Tipo_Queja"
        Me.Cbx_Tipo_Queja.Size = New System.Drawing.Size(121, 22)
        Me.Cbx_Tipo_Queja.TabIndex = 15
        '
        'SCRTIPOQUEJABindingSource
        '
        Me.SCRTIPOQUEJABindingSource.DataMember = "SCR_TIPO_QUEJA"
        Me.SCRTIPOQUEJABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_TIPO_QUEJATableAdapter
        '
        Me.SCR_TIPO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'Lbl_Fecha_Hora
        '
        Me.Lbl_Fecha_Hora.AutoSize = True
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(702, 18)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(69, 14)
        Me.Lbl_Fecha_Hora.TabIndex = 16
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Timer1
        '
        '
        'Txt_Descripcion_Queja
        '
        Me.Txt_Descripcion_Queja.Location = New System.Drawing.Point(10, 166)
        Me.Txt_Descripcion_Queja.Multiline = True
        Me.Txt_Descripcion_Queja.Name = "Txt_Descripcion_Queja"
        Me.Txt_Descripcion_Queja.Size = New System.Drawing.Size(834, 107)
        Me.Txt_Descripcion_Queja.TabIndex = 17
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(769, 279)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 18
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'Lbl_T_Num_Queja
        '
        Me.Lbl_T_Num_Queja.AutoSize = True
        Me.Lbl_T_Num_Queja.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_T_Num_Queja.Name = "Lbl_T_Num_Queja"
        Me.Lbl_T_Num_Queja.Size = New System.Drawing.Size(48, 14)
        Me.Lbl_T_Num_Queja.TabIndex = 19
        Me.Lbl_T_Num_Queja.Text = "# Queja"
        '
        'Lbl_Nun_Queja
        '
        Me.Lbl_Nun_Queja.AutoSize = True
        Me.Lbl_Nun_Queja.Location = New System.Drawing.Point(66, 9)
        Me.Lbl_Nun_Queja.Name = "Lbl_Nun_Queja"
        Me.Lbl_Nun_Queja.Size = New System.Drawing.Size(42, 14)
        Me.Lbl_Nun_Queja.TabIndex = 20
        Me.Lbl_Nun_Queja.Text = "Label1"
        '
        'Lbl_Factura
        '
        Me.Lbl_Factura.AutoSize = True
        Me.Lbl_Factura.Location = New System.Drawing.Point(191, 120)
        Me.Lbl_Factura.Name = "Lbl_Factura"
        Me.Lbl_Factura.Size = New System.Drawing.Size(52, 14)
        Me.Lbl_Factura.TabIndex = 21
        Me.Lbl_Factura.Text = "Factura:"
        '
        'Lbl_Proforma
        '
        Me.Lbl_Proforma.AutoSize = True
        Me.Lbl_Proforma.Location = New System.Drawing.Point(362, 120)
        Me.Lbl_Proforma.Name = "Lbl_Proforma"
        Me.Lbl_Proforma.Size = New System.Drawing.Size(60, 14)
        Me.Lbl_Proforma.TabIndex = 21
        Me.Lbl_Proforma.Text = "Proforma:"
        '
        'Txt_Factura
        '
        Me.Txt_Factura.Location = New System.Drawing.Point(243, 115)
        Me.Txt_Factura.Name = "Txt_Factura"
        Me.Txt_Factura.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Factura.TabIndex = 22
        '
        'Txt_Proforma
        '
        Me.Txt_Proforma.Location = New System.Drawing.Point(426, 115)
        Me.Txt_Proforma.Name = "Txt_Proforma"
        Me.Txt_Proforma.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Proforma.TabIndex = 23
        '
        'Frm_Ingreso_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 306)
        Me.Controls.Add(Me.Txt_Proforma)
        Me.Controls.Add(Me.Txt_Factura)
        Me.Controls.Add(Me.Lbl_Proforma)
        Me.Controls.Add(Me.Lbl_Factura)
        Me.Controls.Add(Me.Lbl_Nun_Queja)
        Me.Controls.Add(Me.Lbl_T_Num_Queja)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Txt_Descripcion_Queja)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Controls.Add(Me.Cbx_Tipo_Queja)
        Me.Controls.Add(Me.Lbl_Fecha)
        Me.Controls.Add(Me.Lbl_Descripcion_Queja)
        Me.Controls.Add(Me.Lbl_Tipo_Queja)
        Me.Controls.Add(Me.Lbl_Alias)
        Me.Controls.Add(Me.Lbl_T_Alias)
        Me.Controls.Add(Me.Lbl_Fax)
        Me.Controls.Add(Me.Lbl_T_Fax)
        Me.Controls.Add(Me.Lbl_Telefono_2)
        Me.Controls.Add(Me.Lbl_Telefono_1)
        Me.Controls.Add(Me.Lbl_Telefonos)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_T_Nombre)
        Me.Controls.Add(Me.Lbl_Cliente)
        Me.Controls.Add(Me.Txt_Cliente)
        Me.Controls.Add(Me.Lbl_Titulo__Ingreso_Quejas)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Ingreso_Queja"
        Me.Text = "Ingreso Queja"
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Titulo__Ingreso_Quejas As Label
    Friend WithEvents Txt_Cliente As TextBox
    Friend WithEvents Lbl_Cliente As Label
    Friend WithEvents Lbl_T_Nombre As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_Telefonos As Label
    Friend WithEvents Lbl_Telefono_1 As Label
    Friend WithEvents Lbl_Telefono_2 As Label
    Friend WithEvents Lbl_T_Fax As Label
    Friend WithEvents Lbl_Fax As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_Tipo_Queja As Label
    Friend WithEvents Lbl_Descripcion_Queja As Label
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents Cbx_Tipo_Queja As ComboBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRTIPOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_TIPO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TIPO_QUEJATableAdapter
    Friend WithEvents Lbl_Fecha_Hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Txt_Descripcion_Queja As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents ClienteTableAdapter1 As ExactusERP_TABLESTableAdapters.CLIENTETableAdapter
    Friend WithEvents ExactusERP_TABLES1 As ExactusERP_TABLES
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents Lbl_T_Num_Queja As Label
    Friend WithEvents Lbl_Nun_Queja As Label
    Friend WithEvents Lbl_Factura As Label
    Friend WithEvents Lbl_Proforma As Label
    Friend WithEvents Txt_Factura As TextBox
    Friend WithEvents Txt_Proforma As TextBox
End Class
