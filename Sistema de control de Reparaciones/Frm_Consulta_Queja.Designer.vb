<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Queja))
        Me.Rbtn_Procesar = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Solucionar = New System.Windows.Forms.RadioButton()
        Me.Lbl_Num_Queja = New System.Windows.Forms.Label()
        Me.Txt_Num_Queja = New System.Windows.Forms.TextBox()
        Me.Lbl_T_Cod_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Cod_Cliente = New System.Windows.Forms.Label()
        Me.SCRULTIMOESTADOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Lbl_Telefonos = New System.Windows.Forms.Label()
        Me.Lbl_Tel_1 = New System.Windows.Forms.Label()
        Me.Lbl_Tel_2 = New System.Windows.Forms.Label()
        Me.Lbl__T_Tipo_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_T_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_T_Direccion = New System.Windows.Forms.Label()
        Me.Lbl_Direccion = New System.Windows.Forms.Label()
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter()
        Me.Lbl_T_Fecha_ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_T_Factua = New System.Windows.Forms.Label()
        Me.Lbl_Factua = New System.Windows.Forms.Label()
        Me.Lbl_T_Proforma = New System.Windows.Forms.Label()
        Me.Lbl_Proforma = New System.Windows.Forms.Label()
        Me.Lbl__T_Estado_Actual = New System.Windows.Forms.Label()
        Me.Lbl_Estado_Actual = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Estado = New System.Windows.Forms.Label()
        Me.Grb_Detalle = New System.Windows.Forms.GroupBox()
        Me.lb_detalle_queja = New System.Windows.Forms.Label()
        Me.Lbl_Detalle = New System.Windows.Forms.Label()
        Me.Rbtn_Procesada = New System.Windows.Forms.RadioButton()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_quejas_pendientes = New System.Windows.Forms.DataGridView()
        Me.NUMEROQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource_datagrid = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_imprimir = New System.Windows.Forms.Button()
        Me.ScR_ULTIMO_ESTADO_QUEJATableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter()
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_Detalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_quejas_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rbtn_Procesar
        '
        Me.Rbtn_Procesar.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Rbtn_Procesar.Location = New System.Drawing.Point(96, 302)
        Me.Rbtn_Procesar.Name = "Rbtn_Procesar"
        Me.Rbtn_Procesar.Size = New System.Drawing.Size(115, 32)
        Me.Rbtn_Procesar.TabIndex = 4
        Me.Rbtn_Procesar.Text = "PROCESAR"
        Me.Rbtn_Procesar.UseVisualStyleBackColor = True
        Me.Rbtn_Procesar.Visible = False
        '
        'Rbtn_Solucionar
        '
        Me.Rbtn_Solucionar.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Rbtn_Solucionar.Location = New System.Drawing.Point(96, 367)
        Me.Rbtn_Solucionar.Name = "Rbtn_Solucionar"
        Me.Rbtn_Solucionar.Size = New System.Drawing.Size(124, 22)
        Me.Rbtn_Solucionar.TabIndex = 3
        Me.Rbtn_Solucionar.Text = "SOLUCIONAR"
        Me.Rbtn_Solucionar.UseVisualStyleBackColor = True
        Me.Rbtn_Solucionar.Visible = False
        '
        'Lbl_Num_Queja
        '
        Me.Lbl_Num_Queja.AutoSize = True
        Me.Lbl_Num_Queja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Num_Queja.Location = New System.Drawing.Point(45, 256)
        Me.Lbl_Num_Queja.Name = "Lbl_Num_Queja"
        Me.Lbl_Num_Queja.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Num_Queja.TabIndex = 2
        Me.Lbl_Num_Queja.Text = "# QUEJA:"
        '
        'Txt_Num_Queja
        '
        Me.Txt_Num_Queja.Location = New System.Drawing.Point(118, 251)
        Me.Txt_Num_Queja.Name = "Txt_Num_Queja"
        Me.Txt_Num_Queja.Size = New System.Drawing.Size(93, 23)
        Me.Txt_Num_Queja.TabIndex = 1
        '
        'Lbl_T_Cod_Cliente
        '
        Me.Lbl_T_Cod_Cliente.AutoSize = True
        Me.Lbl_T_Cod_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Cod_Cliente.Location = New System.Drawing.Point(16, 37)
        Me.Lbl_T_Cod_Cliente.Name = "Lbl_T_Cod_Cliente"
        Me.Lbl_T_Cod_Cliente.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_T_Cod_Cliente.TabIndex = 4
        Me.Lbl_T_Cod_Cliente.Text = "Cliente:"
        '
        'Lbl_Cod_Cliente
        '
        Me.Lbl_Cod_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "CLIENTE", True))
        Me.Lbl_Cod_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Cod_Cliente.Location = New System.Drawing.Point(81, 37)
        Me.Lbl_Cod_Cliente.Name = "Lbl_Cod_Cliente"
        Me.Lbl_Cod_Cliente.Size = New System.Drawing.Size(152, 24)
        Me.Lbl_Cod_Cliente.TabIndex = 5
        Me.Lbl_Cod_Cliente.Text = "Cod_Cliente"
        Me.Lbl_Cod_Cliente.Visible = False
        '
        'SCRULTIMOESTADOQUEJABindingSource
        '
        Me.SCRULTIMOESTADOQUEJABindingSource.DataMember = "SCR_ULTIMO_ESTADO_QUEJA"
        Me.SCRULTIMOESTADOQUEJABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Telefonos
        '
        Me.Lbl_Telefonos.AutoSize = True
        Me.Lbl_Telefonos.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Telefonos.Location = New System.Drawing.Point(421, 37)
        Me.Lbl_Telefonos.Name = "Lbl_Telefonos"
        Me.Lbl_Telefonos.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_Telefonos.TabIndex = 6
        Me.Lbl_Telefonos.Text = "Telefonos:"
        '
        'Lbl_Tel_1
        '
        Me.Lbl_Tel_1.AutoSize = True
        Me.Lbl_Tel_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TELEFONO1", True))
        Me.Lbl_Tel_1.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Tel_1.Location = New System.Drawing.Point(500, 37)
        Me.Lbl_Tel_1.Name = "Lbl_Tel_1"
        Me.Lbl_Tel_1.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_Tel_1.TabIndex = 7
        Me.Lbl_Tel_1.Text = "Telefono_1"
        Me.Lbl_Tel_1.Visible = False
        '
        'Lbl_Tel_2
        '
        Me.Lbl_Tel_2.AutoSize = True
        Me.Lbl_Tel_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TELEFONO2", True))
        Me.Lbl_Tel_2.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Tel_2.Location = New System.Drawing.Point(590, 37)
        Me.Lbl_Tel_2.Name = "Lbl_Tel_2"
        Me.Lbl_Tel_2.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_Tel_2.TabIndex = 8
        Me.Lbl_Tel_2.Text = "Telefono_2"
        Me.Lbl_Tel_2.Visible = False
        '
        'Lbl__T_Tipo_Queja
        '
        Me.Lbl__T_Tipo_Queja.AutoSize = True
        Me.Lbl__T_Tipo_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl__T_Tipo_Queja.Location = New System.Drawing.Point(420, 191)
        Me.Lbl__T_Tipo_Queja.Name = "Lbl__T_Tipo_Queja"
        Me.Lbl__T_Tipo_Queja.Size = New System.Drawing.Size(58, 16)
        Me.Lbl__T_Tipo_Queja.TabIndex = 11
        Me.Lbl__T_Tipo_Queja.Text = "Motivo:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TIPO_QUEJA", True))
        Me.Lbl_Motivo.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Motivo.Location = New System.Drawing.Point(484, 191)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(302, 36)
        Me.Lbl_Motivo.TabIndex = 12
        Me.Lbl_Motivo.Text = "Motivo"
        Me.Lbl_Motivo.Visible = False
        '
        'Lbl_T_Nombre
        '
        Me.Lbl_T_Nombre.AutoSize = True
        Me.Lbl_T_Nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Nombre.Location = New System.Drawing.Point(16, 75)
        Me.Lbl_T_Nombre.Name = "Lbl_T_Nombre"
        Me.Lbl_T_Nombre.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_T_Nombre.TabIndex = 13
        Me.Lbl_T_Nombre.Text = "Nombre:"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "NOMBRE", True))
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Nombre.Location = New System.Drawing.Point(81, 75)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(263, 32)
        Me.Lbl_Nombre.TabIndex = 14
        Me.Lbl_Nombre.Text = "Nombre"
        Me.Lbl_Nombre.Visible = False
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(16, 118)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_T_Alias.TabIndex = 15
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "ALIAS", True))
        Me.Lbl_Alias.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Alias.Location = New System.Drawing.Point(68, 118)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(276, 38)
        Me.Lbl_Alias.TabIndex = 16
        Me.Lbl_Alias.Text = "Alias"
        Me.Lbl_Alias.Visible = False
        '
        'Lbl_T_Contacto
        '
        Me.Lbl_T_Contacto.AutoSize = True
        Me.Lbl_T_Contacto.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Contacto.Location = New System.Drawing.Point(16, 156)
        Me.Lbl_T_Contacto.Name = "Lbl_T_Contacto"
        Me.Lbl_T_Contacto.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_T_Contacto.TabIndex = 17
        Me.Lbl_T_Contacto.Text = "Contacto:"
        '
        'Lbl_Contacto
        '
        Me.Lbl_Contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "CONTACTO", True))
        Me.Lbl_Contacto.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Contacto.Location = New System.Drawing.Point(95, 156)
        Me.Lbl_Contacto.Name = "Lbl_Contacto"
        Me.Lbl_Contacto.Size = New System.Drawing.Size(249, 25)
        Me.Lbl_Contacto.TabIndex = 18
        Me.Lbl_Contacto.Text = "Contacto"
        Me.Lbl_Contacto.Visible = False
        '
        'Lbl_T_Direccion
        '
        Me.Lbl_T_Direccion.AutoSize = True
        Me.Lbl_T_Direccion.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Direccion.Location = New System.Drawing.Point(420, 75)
        Me.Lbl_T_Direccion.Name = "Lbl_T_Direccion"
        Me.Lbl_T_Direccion.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_T_Direccion.TabIndex = 19
        Me.Lbl_T_Direccion.Text = "Direccion:"
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "DIRECCION", True))
        Me.Lbl_Direccion.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Direccion.Location = New System.Drawing.Point(500, 75)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(370, 38)
        Me.Lbl_Direccion.TabIndex = 20
        Me.Lbl_Direccion.Text = "Direccion"
        Me.Lbl_Direccion.Visible = False
        '
        'SCR_ULTIMO_ESTADO_QUEJATableAdapter
        '
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'Lbl_T_Fecha_ingreso
        '
        Me.Lbl_T_Fecha_ingreso.AutoSize = True
        Me.Lbl_T_Fecha_ingreso.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Fecha_ingreso.Location = New System.Drawing.Point(16, 191)
        Me.Lbl_T_Fecha_ingreso.Name = "Lbl_T_Fecha_ingreso"
        Me.Lbl_T_Fecha_ingreso.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_T_Fecha_ingreso.TabIndex = 21
        Me.Lbl_T_Fecha_ingreso.Text = "Fecha Ingreso:"
        '
        'Lbl_Fecha_Ingreso
        '
        Me.Lbl_Fecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FECHA_INGRESO", True))
        Me.Lbl_Fecha_Ingreso.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(127, 191)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(150, 26)
        Me.Lbl_Fecha_Ingreso.TabIndex = 22
        Me.Lbl_Fecha_Ingreso.Text = "Fecha de Ingreso"
        Me.Lbl_Fecha_Ingreso.Visible = False
        '
        'Lbl_T_Factua
        '
        Me.Lbl_T_Factua.AutoSize = True
        Me.Lbl_T_Factua.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Factua.Location = New System.Drawing.Point(16, 226)
        Me.Lbl_T_Factua.Name = "Lbl_T_Factua"
        Me.Lbl_T_Factua.Size = New System.Drawing.Size(66, 16)
        Me.Lbl_T_Factua.TabIndex = 23
        Me.Lbl_T_Factua.Text = "Factura:"
        '
        'Lbl_Factua
        '
        Me.Lbl_Factua.AutoSize = True
        Me.Lbl_Factua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FACTURA", True))
        Me.Lbl_Factua.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Factua.Location = New System.Drawing.Point(82, 226)
        Me.Lbl_Factua.Name = "Lbl_Factua"
        Me.Lbl_Factua.Size = New System.Drawing.Size(56, 16)
        Me.Lbl_Factua.TabIndex = 24
        Me.Lbl_Factua.Text = "Factura"
        Me.Lbl_Factua.Visible = False
        '
        'Lbl_T_Proforma
        '
        Me.Lbl_T_Proforma.AutoSize = True
        Me.Lbl_T_Proforma.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Proforma.Location = New System.Drawing.Point(421, 118)
        Me.Lbl_T_Proforma.Name = "Lbl_T_Proforma"
        Me.Lbl_T_Proforma.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_T_Proforma.TabIndex = 25
        Me.Lbl_T_Proforma.Text = "Proforma:"
        '
        'Lbl_Proforma
        '
        Me.Lbl_Proforma.AutoSize = True
        Me.Lbl_Proforma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "PROFORMA", True))
        Me.Lbl_Proforma.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Proforma.Location = New System.Drawing.Point(501, 118)
        Me.Lbl_Proforma.Name = "Lbl_Proforma"
        Me.Lbl_Proforma.Size = New System.Drawing.Size(65, 16)
        Me.Lbl_Proforma.TabIndex = 26
        Me.Lbl_Proforma.Text = "Proforma"
        Me.Lbl_Proforma.Visible = False
        '
        'Lbl__T_Estado_Actual
        '
        Me.Lbl__T_Estado_Actual.AutoSize = True
        Me.Lbl__T_Estado_Actual.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl__T_Estado_Actual.Location = New System.Drawing.Point(421, 156)
        Me.Lbl__T_Estado_Actual.Name = "Lbl__T_Estado_Actual"
        Me.Lbl__T_Estado_Actual.Size = New System.Drawing.Size(108, 16)
        Me.Lbl__T_Estado_Actual.TabIndex = 27
        Me.Lbl__T_Estado_Actual.Text = "Estado Actual:"
        '
        'Lbl_Estado_Actual
        '
        Me.Lbl_Estado_Actual.AutoSize = True
        Me.Lbl_Estado_Actual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "ESTADO", True))
        Me.Lbl_Estado_Actual.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Estado_Actual.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Estado_Actual.Location = New System.Drawing.Point(536, 156)
        Me.Lbl_Estado_Actual.Name = "Lbl_Estado_Actual"
        Me.Lbl_Estado_Actual.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_Estado_Actual.TabIndex = 28
        Me.Lbl_Estado_Actual.Text = "Estado_Actual"
        Me.Lbl_Estado_Actual.Visible = False
        '
        'Lbl_Fecha_Estado
        '
        Me.Lbl_Fecha_Estado.AutoSize = True
        Me.Lbl_Fecha_Estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FECHA_ACTUA", True))
        Me.Lbl_Fecha_Estado.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Fecha_Estado.Location = New System.Drawing.Point(656, 156)
        Me.Lbl_Fecha_Estado.Name = "Lbl_Fecha_Estado"
        Me.Lbl_Fecha_Estado.Size = New System.Drawing.Size(87, 16)
        Me.Lbl_Fecha_Estado.TabIndex = 29
        Me.Lbl_Fecha_Estado.Text = "Fecha_Actua"
        Me.Lbl_Fecha_Estado.Visible = False
        '
        'Grb_Detalle
        '
        Me.Grb_Detalle.AutoSize = True
        Me.Grb_Detalle.Controls.Add(Me.lb_detalle_queja)
        Me.Grb_Detalle.Controls.Add(Me.Lbl_Detalle)
        Me.Grb_Detalle.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Grb_Detalle.Location = New System.Drawing.Point(20, 273)
        Me.Grb_Detalle.MaximumSize = New System.Drawing.Size(770, 0)
        Me.Grb_Detalle.Name = "Grb_Detalle"
        Me.Grb_Detalle.Size = New System.Drawing.Size(739, 167)
        Me.Grb_Detalle.TabIndex = 30
        Me.Grb_Detalle.TabStop = False
        Me.Grb_Detalle.Text = "DETALLE QUEJA"
        '
        'lb_detalle_queja
        '
        Me.lb_detalle_queja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "DETALLE", True))
        Me.lb_detalle_queja.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.lb_detalle_queja.Location = New System.Drawing.Point(14, 29)
        Me.lb_detalle_queja.Name = "lb_detalle_queja"
        Me.lb_detalle_queja.Size = New System.Drawing.Size(695, 120)
        Me.lb_detalle_queja.TabIndex = 13
        Me.lb_detalle_queja.Text = "Detalle"
        Me.lb_detalle_queja.Visible = False
        '
        'Lbl_Detalle
        '
        Me.Lbl_Detalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "DETALLE", True))
        Me.Lbl_Detalle.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Detalle.Location = New System.Drawing.Point(14, 28)
        Me.Lbl_Detalle.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Lbl_Detalle.Name = "Lbl_Detalle"
        Me.Lbl_Detalle.Size = New System.Drawing.Size(719, 0)
        Me.Lbl_Detalle.TabIndex = 0
        Me.Lbl_Detalle.Text = "Detalle"
        Me.Lbl_Detalle.Visible = False
        '
        'Rbtn_Procesada
        '
        Me.Rbtn_Procesada.Checked = True
        Me.Rbtn_Procesada.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Rbtn_Procesada.Location = New System.Drawing.Point(96, 334)
        Me.Rbtn_Procesada.Name = "Rbtn_Procesada"
        Me.Rbtn_Procesada.Size = New System.Drawing.Size(115, 27)
        Me.Rbtn_Procesada.TabIndex = 2
        Me.Rbtn_Procesada.TabStop = True
        Me.Rbtn_Procesada.Text = "PROCESADA"
        Me.Rbtn_Procesada.UseVisualStyleBackColor = True
        Me.Rbtn_Procesada.Visible = False
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(183, 427)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(105, 33)
        Me.bt_guardar.TabIndex = 5
        Me.bt_guardar.Text = "GUARDAR!"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_Motivo)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Cod_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Cod_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Telefonos)
        Me.GroupBox1.Controls.Add(Me.Lbl_Tel_1)
        Me.GroupBox1.Controls.Add(Me.Grb_Detalle)
        Me.GroupBox1.Controls.Add(Me.Lbl_Tel_2)
        Me.GroupBox1.Controls.Add(Me.Lbl_Fecha_Estado)
        Me.GroupBox1.Controls.Add(Me.Lbl_Estado_Actual)
        Me.GroupBox1.Controls.Add(Me.Lbl__T_Estado_Actual)
        Me.GroupBox1.Controls.Add(Me.Lbl__T_Tipo_Queja)
        Me.GroupBox1.Controls.Add(Me.Lbl_Proforma)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Nombre)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Proforma)
        Me.GroupBox1.Controls.Add(Me.Lbl_Nombre)
        Me.GroupBox1.Controls.Add(Me.Lbl_Factua)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Factua)
        Me.GroupBox1.Controls.Add(Me.Lbl_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Contacto)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Fecha_ingreso)
        Me.GroupBox1.Controls.Add(Me.Lbl_Contacto)
        Me.GroupBox1.Controls.Add(Me.Lbl_Direccion)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Direccion)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 482)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION QUEJA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dg_quejas_pendientes)
        Me.GroupBox2.Controls.Add(Me.bt_imprimir)
        Me.GroupBox2.Controls.Add(Me.Rbtn_Procesada)
        Me.GroupBox2.Controls.Add(Me.Rbtn_Procesar)
        Me.GroupBox2.Controls.Add(Me.Txt_Num_Queja)
        Me.GroupBox2.Controls.Add(Me.Lbl_Num_Queja)
        Me.GroupBox2.Controls.Add(Me.bt_guardar)
        Me.GroupBox2.Controls.Add(Me.Rbtn_Solucionar)
        Me.GroupBox2.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 482)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BÚSQUEDA QUEJA"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(79, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "QUEJAS PENDIENTES"
        '
        'dg_quejas_pendientes
        '
        Me.dg_quejas_pendientes.AllowUserToAddRows = False
        Me.dg_quejas_pendientes.AllowUserToDeleteRows = False
        Me.dg_quejas_pendientes.AutoGenerateColumns = False
        Me.dg_quejas_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_quejas_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMEROQUEJADataGridViewTextBoxColumn})
        Me.dg_quejas_pendientes.DataSource = Me.BindingSource_datagrid
        Me.dg_quejas_pendientes.Location = New System.Drawing.Point(69, 82)
        Me.dg_quejas_pendientes.Name = "dg_quejas_pendientes"
        Me.dg_quejas_pendientes.ReadOnly = True
        Me.dg_quejas_pendientes.Size = New System.Drawing.Size(178, 145)
        Me.dg_quejas_pendientes.TabIndex = 0
        '
        'NUMEROQUEJADataGridViewTextBoxColumn
        '
        Me.NUMEROQUEJADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_QUEJA"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.HeaderText = "#"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.Name = "NUMEROQUEJADataGridViewTextBoxColumn"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingSource_datagrid
        '
        Me.BindingSource_datagrid.DataMember = "SCR_ULTIMO_ESTADO_QUEJA"
        Me.BindingSource_datagrid.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'bt_imprimir
        '
        Me.bt_imprimir.Location = New System.Drawing.Point(16, 427)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(148, 33)
        Me.bt_imprimir.TabIndex = 6
        Me.bt_imprimir.Text = "IMPRIMIR QUEJA"
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'ScR_ULTIMO_ESTADO_QUEJATableAdapter1
        '
        Me.ScR_ULTIMO_ESTADO_QUEJATableAdapter1.ClearBeforeFill = True
        '
        'Frm_Consulta_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consulta_Queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Queja"
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_Detalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_quejas_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rbtn_Procesar As RadioButton
    Friend WithEvents Rbtn_Solucionar As RadioButton
    Friend WithEvents Lbl_Num_Queja As Label
    Friend WithEvents Txt_Num_Queja As TextBox
    Friend WithEvents Lbl_T_Cod_Cliente As Label
    Friend WithEvents Lbl_Cod_Cliente As Label
    Friend WithEvents Lbl_Telefonos As Label
    Friend WithEvents Lbl_Tel_1 As Label
    Friend WithEvents Lbl_Tel_2 As Label
    Friend WithEvents Lbl__T_Tipo_Queja As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl_T_Nombre As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_T_Contacto As Label
    Friend WithEvents Lbl_Contacto As Label
    Friend WithEvents Lbl_T_Direccion As Label
    Friend WithEvents Lbl_Direccion As Label
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRULTIMOESTADOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_ULTIMO_ESTADO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter
    Friend WithEvents Lbl_T_Fecha_ingreso As Label
    Friend WithEvents Lbl_Fecha_Ingreso As Label
    Friend WithEvents Lbl_T_Factua As Label
    Friend WithEvents Lbl_Factua As Label
    Friend WithEvents Lbl_T_Proforma As Label
    Friend WithEvents Lbl_Proforma As Label
    Friend WithEvents Lbl__T_Estado_Actual As Label
    Friend WithEvents Lbl_Estado_Actual As Label
    Friend WithEvents Lbl_Fecha_Estado As Label
    Friend WithEvents Grb_Detalle As GroupBox
    Friend WithEvents Lbl_Detalle As Label
    Friend WithEvents Rbtn_Procesada As RadioButton
    Friend WithEvents bt_guardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lb_detalle_queja As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bt_imprimir As Button
    Friend WithEvents dg_quejas_pendientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource_datagrid As BindingSource
    Friend WithEvents ScR_ULTIMO_ESTADO_QUEJATableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter
    Friend WithEvents NUMEROQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
