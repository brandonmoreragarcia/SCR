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
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES1 = New WindowsApplication1.ExactusERP_TABLES()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_cliente = New System.Windows.Forms.DataGridView()
        Me.Txt_Cod_Cliente = New System.Windows.Forms.TextBox()
        Me.Lbl_Cliente_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Codigo_Cliente = New System.Windows.Forms.Label()
        Me.lb_nombre_cliente = New System.Windows.Forms.Label()
        Me.rb_nombre = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_alias_cliente = New System.Windows.Forms.Label()
        Me.rb_alias = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bt_agregar_a_descripcion = New System.Windows.Forms.Button()
        Me.Txt_Cod_Articulo = New System.Windows.Forms.TextBox()
        Me.Lbl_Codigo_Art = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion_Art = New System.Windows.Forms.Label()
        Me.lb_descripcion_articulo = New System.Windows.Forms.Label()
        Me.dg_articulo = New System.Windows.Forms.DataGridView()
        Me.bt_buscar_articulo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bs_clientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_articulo = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bs_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Lbl_Tipo_Queja
        '
        Me.Lbl_Tipo_Queja.AutoSize = True
        Me.Lbl_Tipo_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tipo_Queja.Location = New System.Drawing.Point(40, 72)
        Me.Lbl_Tipo_Queja.Name = "Lbl_Tipo_Queja"
        Me.Lbl_Tipo_Queja.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_Tipo_Queja.TabIndex = 12
        Me.Lbl_Tipo_Queja.Text = "Motivo:"
        '
        'Lbl_Descripcion_Queja
        '
        Me.Lbl_Descripcion_Queja.AutoSize = True
        Me.Lbl_Descripcion_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descripcion_Queja.Location = New System.Drawing.Point(23, 185)
        Me.Lbl_Descripcion_Queja.Name = "Lbl_Descripcion_Queja"
        Me.Lbl_Descripcion_Queja.Size = New System.Drawing.Size(202, 16)
        Me.Lbl_Descripcion_Queja.TabIndex = 13
        Me.Lbl_Descripcion_Queja.Text = "DESCRIPCION DE LA QUEJA"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha.Location = New System.Drawing.Point(982, 20)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Fecha.TabIndex = 14
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Cbx_Tipo_Queja
        '
        Me.Cbx_Tipo_Queja.DataSource = Me.SCRTIPOQUEJABindingSource
        Me.Cbx_Tipo_Queja.DisplayMember = "TIPO_QUEJA"
        Me.Cbx_Tipo_Queja.DropDownWidth = 420
        Me.Cbx_Tipo_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Tipo_Queja.FormattingEnabled = True
        Me.Cbx_Tipo_Queja.Location = New System.Drawing.Point(104, 69)
        Me.Cbx_Tipo_Queja.Name = "Cbx_Tipo_Queja"
        Me.Cbx_Tipo_Queja.Size = New System.Drawing.Size(121, 23)
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
        Me.Lbl_Fecha_Hora.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(1036, 20)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(85, 16)
        Me.Lbl_Fecha_Hora.TabIndex = 16
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Timer1
        '
        '
        'Txt_Descripcion_Queja
        '
        Me.Txt_Descripcion_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Descripcion_Queja.Location = New System.Drawing.Point(26, 220)
        Me.Txt_Descripcion_Queja.Multiline = True
        Me.Txt_Descripcion_Queja.Name = "Txt_Descripcion_Queja"
        Me.Txt_Descripcion_Queja.Size = New System.Drawing.Size(449, 120)
        Me.Txt_Descripcion_Queja.TabIndex = 17
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(196, 362)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(122, 37)
        Me.Btn_Guardar.TabIndex = 18
        Me.Btn_Guardar.Text = "GUARDAR!"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'Lbl_T_Num_Queja
        '
        Me.Lbl_T_Num_Queja.AutoSize = True
        Me.Lbl_T_Num_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Num_Queja.Location = New System.Drawing.Point(815, 20)
        Me.Lbl_T_Num_Queja.Name = "Lbl_T_Num_Queja"
        Me.Lbl_T_Num_Queja.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_T_Num_Queja.TabIndex = 19
        Me.Lbl_T_Num_Queja.Text = "# Queja"
        '
        'Lbl_Nun_Queja
        '
        Me.Lbl_Nun_Queja.AutoSize = True
        Me.Lbl_Nun_Queja.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Nun_Queja.Location = New System.Drawing.Point(881, 20)
        Me.Lbl_Nun_Queja.Name = "Lbl_Nun_Queja"
        Me.Lbl_Nun_Queja.Size = New System.Drawing.Size(52, 16)
        Me.Lbl_Nun_Queja.TabIndex = 20
        Me.Lbl_Nun_Queja.Text = "Label1"
        '
        'Lbl_Factura
        '
        Me.Lbl_Factura.AutoSize = True
        Me.Lbl_Factura.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Factura.Location = New System.Drawing.Point(270, 128)
        Me.Lbl_Factura.Name = "Lbl_Factura"
        Me.Lbl_Factura.Size = New System.Drawing.Size(66, 16)
        Me.Lbl_Factura.TabIndex = 21
        Me.Lbl_Factura.Text = "Factura:"
        '
        'Lbl_Proforma
        '
        Me.Lbl_Proforma.AutoSize = True
        Me.Lbl_Proforma.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Proforma.Location = New System.Drawing.Point(262, 72)
        Me.Lbl_Proforma.Name = "Lbl_Proforma"
        Me.Lbl_Proforma.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_Proforma.TabIndex = 21
        Me.Lbl_Proforma.Text = "Proforma:"
        '
        'Txt_Factura
        '
        Me.Txt_Factura.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Factura.Location = New System.Drawing.Point(342, 123)
        Me.Txt_Factura.Name = "Txt_Factura"
        Me.Txt_Factura.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Factura.TabIndex = 22
        '
        'Txt_Proforma
        '
        Me.Txt_Proforma.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proforma.Location = New System.Drawing.Point(342, 69)
        Me.Txt_Proforma.Name = "Txt_Proforma"
        Me.Txt_Proforma.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Proforma.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_cliente)
        Me.GroupBox2.Controls.Add(Me.Txt_Cod_Cliente)
        Me.GroupBox2.Controls.Add(Me.Lbl_Cliente_Nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Codigo_Cliente)
        Me.GroupBox2.Controls.Add(Me.lb_nombre_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_nombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lb_alias_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_alias)
        Me.GroupBox2.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(697, 268)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACIÓN DEL CLIENTE"
        '
        'dg_cliente
        '
        Me.dg_cliente.AllowUserToAddRows = False
        Me.dg_cliente.AllowUserToDeleteRows = False
        Me.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cliente.Location = New System.Drawing.Point(14, 87)
        Me.dg_cliente.Name = "dg_cliente"
        Me.dg_cliente.ReadOnly = True
        Me.dg_cliente.Size = New System.Drawing.Size(419, 158)
        Me.dg_cliente.TabIndex = 1
        '
        'Txt_Cod_Cliente
        '
        Me.Txt_Cod_Cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Cliente.Location = New System.Drawing.Point(245, 54)
        Me.Txt_Cod_Cliente.Name = "Txt_Cod_Cliente"
        Me.Txt_Cod_Cliente.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Cod_Cliente.TabIndex = 0
        '
        'Lbl_Cliente_Nombre
        '
        Me.Lbl_Cliente_Nombre.AutoSize = True
        Me.Lbl_Cliente_Nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cliente_Nombre.Location = New System.Drawing.Point(447, 95)
        Me.Lbl_Cliente_Nombre.Name = "Lbl_Cliente_Nombre"
        Me.Lbl_Cliente_Nombre.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_Cliente_Nombre.TabIndex = 3
        Me.Lbl_Cliente_Nombre.Text = "Nombre:"
        '
        'Lbl_Codigo_Cliente
        '
        Me.Lbl_Codigo_Cliente.AutoSize = True
        Me.Lbl_Codigo_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Cliente.Location = New System.Drawing.Point(183, 57)
        Me.Lbl_Codigo_Cliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_Codigo_Cliente.Name = "Lbl_Codigo_Cliente"
        Me.Lbl_Codigo_Cliente.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_Codigo_Cliente.TabIndex = 2
        Me.Lbl_Codigo_Cliente.Text = "Filtrar:"
        '
        'lb_nombre_cliente
        '
        Me.lb_nombre_cliente.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_nombre_cliente.Location = New System.Drawing.Point(509, 95)
        Me.lb_nombre_cliente.Name = "lb_nombre_cliente"
        Me.lb_nombre_cliente.Size = New System.Drawing.Size(182, 69)
        Me.lb_nombre_cliente.TabIndex = 4
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nombre.Location = New System.Drawing.Point(24, 54)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(77, 20)
        Me.rb_nombre.TabIndex = 62
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(457, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Alias:"
        '
        'lb_alias_cliente
        '
        Me.lb_alias_cliente.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alias_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_alias_cliente.Location = New System.Drawing.Point(505, 164)
        Me.lb_alias_cliente.Name = "lb_alias_cliente"
        Me.lb_alias_cliente.Size = New System.Drawing.Size(186, 70)
        Me.lb_alias_cliente.TabIndex = 11
        '
        'rb_alias
        '
        Me.rb_alias.AutoSize = True
        Me.rb_alias.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_alias.Location = New System.Drawing.Point(107, 54)
        Me.rb_alias.Name = "rb_alias"
        Me.rb_alias.Size = New System.Drawing.Size(59, 20)
        Me.rb_alias.TabIndex = 63
        Me.rb_alias.Text = "Alias"
        Me.rb_alias.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bt_agregar_a_descripcion)
        Me.GroupBox3.Controls.Add(Me.Txt_Cod_Articulo)
        Me.GroupBox3.Controls.Add(Me.Lbl_Codigo_Art)
        Me.GroupBox3.Controls.Add(Me.Lbl_Descripcion_Art)
        Me.GroupBox3.Controls.Add(Me.lb_descripcion_articulo)
        Me.GroupBox3.Controls.Add(Me.dg_articulo)
        Me.GroupBox3.Controls.Add(Me.bt_buscar_articulo)
        Me.GroupBox3.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(697, 233)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN DEL ARTÍCULO"
        '
        'bt_agregar_a_descripcion
        '
        Me.bt_agregar_a_descripcion.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_agregar_a_descripcion.Location = New System.Drawing.Point(499, 181)
        Me.bt_agregar_a_descripcion.Name = "bt_agregar_a_descripcion"
        Me.bt_agregar_a_descripcion.Size = New System.Drawing.Size(109, 35)
        Me.bt_agregar_a_descripcion.TabIndex = 17
        Me.bt_agregar_a_descripcion.Text = "AGREGAR"
        Me.bt_agregar_a_descripcion.UseVisualStyleBackColor = True
        '
        'Txt_Cod_Articulo
        '
        Me.Txt_Cod_Articulo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Articulo.Location = New System.Drawing.Point(155, 44)
        Me.Txt_Cod_Articulo.Name = "Txt_Cod_Articulo"
        Me.Txt_Cod_Articulo.Size = New System.Drawing.Size(185, 23)
        Me.Txt_Cod_Articulo.TabIndex = 2
        '
        'Lbl_Codigo_Art
        '
        Me.Lbl_Codigo_Art.AutoSize = True
        Me.Lbl_Codigo_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Art.Location = New System.Drawing.Point(93, 47)
        Me.Lbl_Codigo_Art.Name = "Lbl_Codigo_Art"
        Me.Lbl_Codigo_Art.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_Codigo_Art.TabIndex = 14
        Me.Lbl_Codigo_Art.Text = "Filtrar:"
        '
        'Lbl_Descripcion_Art
        '
        Me.Lbl_Descripcion_Art.AutoSize = True
        Me.Lbl_Descripcion_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descripcion_Art.Location = New System.Drawing.Point(505, 51)
        Me.Lbl_Descripcion_Art.Name = "Lbl_Descripcion_Art"
        Me.Lbl_Descripcion_Art.Size = New System.Drawing.Size(103, 16)
        Me.Lbl_Descripcion_Art.TabIndex = 15
        Me.Lbl_Descripcion_Art.Text = "DESCRIPCION"
        '
        'lb_descripcion_articulo
        '
        Me.lb_descripcion_articulo.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lb_descripcion_articulo.ForeColor = System.Drawing.Color.Red
        Me.lb_descripcion_articulo.Location = New System.Drawing.Point(447, 81)
        Me.lb_descripcion_articulo.Name = "lb_descripcion_articulo"
        Me.lb_descripcion_articulo.Size = New System.Drawing.Size(229, 85)
        Me.lb_descripcion_articulo.TabIndex = 16
        '
        'dg_articulo
        '
        Me.dg_articulo.AllowUserToAddRows = False
        Me.dg_articulo.AllowUserToDeleteRows = False
        Me.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulo.Location = New System.Drawing.Point(11, 81)
        Me.dg_articulo.Name = "dg_articulo"
        Me.dg_articulo.ReadOnly = True
        Me.dg_articulo.Size = New System.Drawing.Size(419, 135)
        Me.dg_articulo.TabIndex = 4
        '
        'bt_buscar_articulo
        '
        Me.bt_buscar_articulo.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar_articulo.Location = New System.Drawing.Point(357, 44)
        Me.bt_buscar_articulo.Name = "bt_buscar_articulo"
        Me.bt_buscar_articulo.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar_articulo.TabIndex = 3
        Me.bt_buscar_articulo.Text = "BUSCAR"
        Me.bt_buscar_articulo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Factura)
        Me.GroupBox1.Controls.Add(Me.Lbl_Tipo_Queja)
        Me.GroupBox1.Controls.Add(Me.Cbx_Tipo_Queja)
        Me.GroupBox1.Controls.Add(Me.Txt_Proforma)
        Me.GroupBox1.Controls.Add(Me.Lbl_Factura)
        Me.GroupBox1.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.Lbl_Proforma)
        Me.GroupBox1.Controls.Add(Me.Lbl_Descripcion_Queja)
        Me.GroupBox1.Controls.Add(Me.Txt_Descripcion_Queja)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(760, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 436)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION QUEJA"
        '
        'Frm_Ingreso_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lbl_Nun_Queja)
        Me.Controls.Add(Me.Lbl_T_Num_Queja)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Controls.Add(Me.Lbl_Fecha)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Ingreso_Queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Queja"
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bs_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dg_cliente As DataGridView
    Friend WithEvents Txt_Cod_Cliente As TextBox
    Friend WithEvents Lbl_Cliente_Nombre As Label
    Friend WithEvents Lbl_Codigo_Cliente As Label
    Friend WithEvents lb_nombre_cliente As Label
    Friend WithEvents rb_nombre As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_alias_cliente As Label
    Friend WithEvents rb_alias As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Cod_Articulo As TextBox
    Friend WithEvents Lbl_Codigo_Art As Label
    Friend WithEvents Lbl_Descripcion_Art As Label
    Friend WithEvents lb_descripcion_articulo As Label
    Friend WithEvents dg_articulo As DataGridView
    Friend WithEvents bt_buscar_articulo As Button
    Friend WithEvents bt_agregar_a_descripcion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bs_clientes As BindingSource
    Friend WithEvents bs_articulo As BindingSource
End Class
