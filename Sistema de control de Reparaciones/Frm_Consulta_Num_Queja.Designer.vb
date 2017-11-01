<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Num_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Num_Queja))
        Me.Txt_Num_Queja = New System.Windows.Forms.TextBox()
        Me.Grb_Detalle = New System.Windows.Forms.GroupBox()
        Me.Lbl_Detalle = New System.Windows.Forms.Label()
        Me.SCRULTIMOESTADOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Lbl_Fecha_Estado = New System.Windows.Forms.Label()
        Me.Lbl_Estado_Actual = New System.Windows.Forms.Label()
        Me.Lbl__T_Estado_Actual = New System.Windows.Forms.Label()
        Me.Lbl_Proforma = New System.Windows.Forms.Label()
        Me.Lbl_T_Proforma = New System.Windows.Forms.Label()
        Me.Lbl_Factua = New System.Windows.Forms.Label()
        Me.Lbl_T_Factua = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_T_Fecha_ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Direccion = New System.Windows.Forms.Label()
        Me.Lbl_T_Direccion = New System.Windows.Forms.Label()
        Me.Lbl_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_T_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Lbl__T_Tipo_Queja = New System.Windows.Forms.Label()
        Me.Lbl_Fax = New System.Windows.Forms.Label()
        Me.Lbl_T_Fax = New System.Windows.Forms.Label()
        Me.Lbl_Tel_2 = New System.Windows.Forms.Label()
        Me.Lbl_Tel_1 = New System.Windows.Forms.Label()
        Me.Lbl_Telefonos = New System.Windows.Forms.Label()
        Me.Lbl_Cod_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Cod_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Num_Queja = New System.Windows.Forms.Label()
        Me.Grb_Solucion = New System.Windows.Forms.GroupBox()
        Me.Lbl_Chequeo = New System.Windows.Forms.Label()
        Me.SCRSOLUCIONQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_T_Chequeo = New System.Windows.Forms.Label()
        Me.Lbl_Alisto = New System.Windows.Forms.Label()
        Me.Lbl_T_Alisto = New System.Windows.Forms.Label()
        Me.Lbl_Solucion = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Solucion = New System.Windows.Forms.Label()
        Me.Lbl_Usuario_Solucion = New System.Windows.Forms.Label()
        Me.Lbl_Solucionado_Por = New System.Windows.Forms.Label()
        Me.Grb_Lista_Estados = New System.Windows.Forms.GroupBox()
        Me.Dgv_Estados = New System.Windows.Forms.DataGridView()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRESTADOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter()
        Me.SCR_ESTADO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_QUEJATableAdapter()
        Me.SCR_SOLUCION_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_SOLUCION_QUEJATableAdapter()
        Me.Grb_Procesada = New System.Windows.Forms.GroupBox()
        Me.Lbl_Chequeo_P = New System.Windows.Forms.Label()
        Me.SCRQUEJAPROCESADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_T_Chequeo_Procesada = New System.Windows.Forms.Label()
        Me.Lbl_Alisto_P = New System.Windows.Forms.Label()
        Me.Lbl_Alisto_T = New System.Windows.Forms.Label()
        Me.Lbl_Comentario_Procesada = New System.Windows.Forms.Label()
        Me.Lbl_Procesada = New System.Windows.Forms.Label()
        Me.Lbl_Usuario_Procesada = New System.Windows.Forms.Label()
        Me.Lbl_T_Procesada_Por = New System.Windows.Forms.Label()
        Me.SCR_QUEJA_PROCESADATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_QUEJA_PROCESADATableAdapter()
        Me.Grb_Detalle.SuspendLayout()
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_Solucion.SuspendLayout()
        CType(Me.SCRSOLUCIONQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_Lista_Estados.SuspendLayout()
        CType(Me.Dgv_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_Procesada.SuspendLayout()
        CType(Me.SCRQUEJAPROCESADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Num_Queja
        '
        Me.Txt_Num_Queja.Location = New System.Drawing.Point(56, 12)
        Me.Txt_Num_Queja.Name = "Txt_Num_Queja"
        Me.Txt_Num_Queja.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Num_Queja.TabIndex = 0
        '
        'Grb_Detalle
        '
        Me.Grb_Detalle.Controls.Add(Me.Lbl_Detalle)
        Me.Grb_Detalle.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Detalle.Location = New System.Drawing.Point(6, 158)
        Me.Grb_Detalle.Name = "Grb_Detalle"
        Me.Grb_Detalle.Size = New System.Drawing.Size(956, 141)
        Me.Grb_Detalle.TabIndex = 62
        Me.Grb_Detalle.TabStop = False
        Me.Grb_Detalle.Text = "Descripcion Detallada de la Queja"
        '
        'Lbl_Detalle
        '
        Me.Lbl_Detalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "DETALLE", True))
        Me.Lbl_Detalle.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Detalle.Location = New System.Drawing.Point(6, 17)
        Me.Lbl_Detalle.Name = "Lbl_Detalle"
        Me.Lbl_Detalle.Size = New System.Drawing.Size(941, 121)
        Me.Lbl_Detalle.TabIndex = 0
        Me.Lbl_Detalle.Text = "Detalle"
        Me.Lbl_Detalle.Visible = False
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
        'Lbl_Fecha_Estado
        '
        Me.Lbl_Fecha_Estado.AutoSize = True
        Me.Lbl_Fecha_Estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FECHA_ACTUA", True))
        Me.Lbl_Fecha_Estado.Location = New System.Drawing.Point(664, 140)
        Me.Lbl_Fecha_Estado.Name = "Lbl_Fecha_Estado"
        Me.Lbl_Fecha_Estado.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_Fecha_Estado.TabIndex = 61
        Me.Lbl_Fecha_Estado.Text = "Fecha_Actua"
        Me.Lbl_Fecha_Estado.Visible = False
        '
        'Lbl_Estado_Actual
        '
        Me.Lbl_Estado_Actual.AutoSize = True
        Me.Lbl_Estado_Actual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "ESTADO", True))
        Me.Lbl_Estado_Actual.Location = New System.Drawing.Point(571, 140)
        Me.Lbl_Estado_Actual.Name = "Lbl_Estado_Actual"
        Me.Lbl_Estado_Actual.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_Estado_Actual.TabIndex = 60
        Me.Lbl_Estado_Actual.Text = "Estado_Actual"
        Me.Lbl_Estado_Actual.Visible = False
        '
        'Lbl__T_Estado_Actual
        '
        Me.Lbl__T_Estado_Actual.AutoSize = True
        Me.Lbl__T_Estado_Actual.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl__T_Estado_Actual.Location = New System.Drawing.Point(487, 141)
        Me.Lbl__T_Estado_Actual.Name = "Lbl__T_Estado_Actual"
        Me.Lbl__T_Estado_Actual.Size = New System.Drawing.Size(89, 14)
        Me.Lbl__T_Estado_Actual.TabIndex = 59
        Me.Lbl__T_Estado_Actual.Text = "Eatado Actual:"
        '
        'Lbl_Proforma
        '
        Me.Lbl_Proforma.AutoSize = True
        Me.Lbl_Proforma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "PROFORMA", True))
        Me.Lbl_Proforma.Location = New System.Drawing.Point(400, 141)
        Me.Lbl_Proforma.Name = "Lbl_Proforma"
        Me.Lbl_Proforma.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Proforma.TabIndex = 58
        Me.Lbl_Proforma.Text = "Proforma"
        Me.Lbl_Proforma.Visible = False
        '
        'Lbl_T_Proforma
        '
        Me.Lbl_T_Proforma.AutoSize = True
        Me.Lbl_T_Proforma.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Proforma.Location = New System.Drawing.Point(340, 141)
        Me.Lbl_T_Proforma.Name = "Lbl_T_Proforma"
        Me.Lbl_T_Proforma.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_T_Proforma.TabIndex = 57
        Me.Lbl_T_Proforma.Text = "Proforma:"
        '
        'Lbl_Factua
        '
        Me.Lbl_Factua.AutoSize = True
        Me.Lbl_Factua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FACTURA", True))
        Me.Lbl_Factua.Location = New System.Drawing.Point(252, 141)
        Me.Lbl_Factua.Name = "Lbl_Factua"
        Me.Lbl_Factua.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Factua.TabIndex = 56
        Me.Lbl_Factua.Text = "Factura"
        Me.Lbl_Factua.Visible = False
        '
        'Lbl_T_Factua
        '
        Me.Lbl_T_Factua.AutoSize = True
        Me.Lbl_T_Factua.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Factua.Location = New System.Drawing.Point(202, 141)
        Me.Lbl_T_Factua.Name = "Lbl_T_Factua"
        Me.Lbl_T_Factua.Size = New System.Drawing.Size(55, 14)
        Me.Lbl_T_Factua.TabIndex = 55
        Me.Lbl_T_Factua.Text = "Factura:"
        '
        'Lbl_Fecha_Ingreso
        '
        Me.Lbl_Fecha_Ingreso.AutoSize = True
        Me.Lbl_Fecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FECHA_INGRESO", True))
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(85, 141)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_Fecha_Ingreso.TabIndex = 54
        Me.Lbl_Fecha_Ingreso.Text = "Fecha de Ingreso"
        Me.Lbl_Fecha_Ingreso.Visible = False
        '
        'Lbl_T_Fecha_ingreso
        '
        Me.Lbl_T_Fecha_ingreso.AutoSize = True
        Me.Lbl_T_Fecha_ingreso.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Fecha_ingreso.Location = New System.Drawing.Point(2, 141)
        Me.Lbl_T_Fecha_ingreso.Name = "Lbl_T_Fecha_ingreso"
        Me.Lbl_T_Fecha_ingreso.Size = New System.Drawing.Size(88, 14)
        Me.Lbl_T_Fecha_ingreso.TabIndex = 53
        Me.Lbl_T_Fecha_ingreso.Text = "Fecha Ingreso:"
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "DIRECCION", True))
        Me.Lbl_Direccion.Location = New System.Drawing.Point(405, 102)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(370, 38)
        Me.Lbl_Direccion.TabIndex = 52
        Me.Lbl_Direccion.Text = "Direccion"
        Me.Lbl_Direccion.Visible = False
        '
        'Lbl_T_Direccion
        '
        Me.Lbl_T_Direccion.AutoSize = True
        Me.Lbl_T_Direccion.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Direccion.Location = New System.Drawing.Point(345, 102)
        Me.Lbl_T_Direccion.Name = "Lbl_T_Direccion"
        Me.Lbl_T_Direccion.Size = New System.Drawing.Size(63, 14)
        Me.Lbl_T_Direccion.TabIndex = 51
        Me.Lbl_T_Direccion.Text = "Direccion:"
        '
        'Lbl_Contacto
        '
        Me.Lbl_Contacto.AutoSize = True
        Me.Lbl_Contacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "CONTACTO", True))
        Me.Lbl_Contacto.Location = New System.Drawing.Point(58, 117)
        Me.Lbl_Contacto.Name = "Lbl_Contacto"
        Me.Lbl_Contacto.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_Contacto.TabIndex = 50
        Me.Lbl_Contacto.Text = "Contacto"
        Me.Lbl_Contacto.Visible = False
        '
        'Lbl_T_Contacto
        '
        Me.Lbl_T_Contacto.AutoSize = True
        Me.Lbl_T_Contacto.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Contacto.Location = New System.Drawing.Point(2, 117)
        Me.Lbl_T_Contacto.Name = "Lbl_T_Contacto"
        Me.Lbl_T_Contacto.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_T_Contacto.TabIndex = 49
        Me.Lbl_T_Contacto.Text = "Contacto:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "ALIAS", True))
        Me.Lbl_Alias.Location = New System.Drawing.Point(379, 75)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Alias.TabIndex = 48
        Me.Lbl_Alias.Text = "Alias"
        Me.Lbl_Alias.Visible = False
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(345, 75)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(37, 14)
        Me.Lbl_T_Alias.TabIndex = 47
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "NOMBRE", True))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(52, 75)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(288, 32)
        Me.Lbl_Nombre.TabIndex = 46
        Me.Lbl_Nombre.Text = "Nombre"
        Me.Lbl_Nombre.Visible = False
        '
        'Lbl_T_Nombre
        '
        Me.Lbl_T_Nombre.AutoSize = True
        Me.Lbl_T_Nombre.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Nombre.Location = New System.Drawing.Point(2, 75)
        Me.Lbl_T_Nombre.Name = "Lbl_T_Nombre"
        Me.Lbl_T_Nombre.Size = New System.Drawing.Size(53, 14)
        Me.Lbl_T_Nombre.TabIndex = 45
        Me.Lbl_T_Nombre.Text = "Nombre:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.AutoSize = True
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TIPO_QUEJA", True))
        Me.Lbl_Motivo.Location = New System.Drawing.Point(223, 14)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Motivo.TabIndex = 44
        Me.Lbl_Motivo.Text = "Motivo"
        Me.Lbl_Motivo.Visible = False
        '
        'Lbl__T_Tipo_Queja
        '
        Me.Lbl__T_Tipo_Queja.AutoSize = True
        Me.Lbl__T_Tipo_Queja.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl__T_Tipo_Queja.Location = New System.Drawing.Point(181, 14)
        Me.Lbl__T_Tipo_Queja.Name = "Lbl__T_Tipo_Queja"
        Me.Lbl__T_Tipo_Queja.Size = New System.Drawing.Size(49, 14)
        Me.Lbl__T_Tipo_Queja.TabIndex = 43
        Me.Lbl__T_Tipo_Queja.Text = "Motivo:"
        '
        'Lbl_Fax
        '
        Me.Lbl_Fax.AutoSize = True
        Me.Lbl_Fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "FAX", True))
        Me.Lbl_Fax.Location = New System.Drawing.Point(385, 50)
        Me.Lbl_Fax.Name = "Lbl_Fax"
        Me.Lbl_Fax.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Fax.TabIndex = 42
        Me.Lbl_Fax.Text = "Num_Fax"
        Me.Lbl_Fax.Visible = False
        '
        'Lbl_T_Fax
        '
        Me.Lbl_T_Fax.AutoSize = True
        Me.Lbl_T_Fax.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Fax.Location = New System.Drawing.Point(357, 50)
        Me.Lbl_T_Fax.Name = "Lbl_T_Fax"
        Me.Lbl_T_Fax.Size = New System.Drawing.Size(30, 14)
        Me.Lbl_T_Fax.TabIndex = 41
        Me.Lbl_T_Fax.Text = "Fax:"
        '
        'Lbl_Tel_2
        '
        Me.Lbl_Tel_2.AutoSize = True
        Me.Lbl_Tel_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TELEFONO2", True))
        Me.Lbl_Tel_2.Location = New System.Drawing.Point(271, 50)
        Me.Lbl_Tel_2.Name = "Lbl_Tel_2"
        Me.Lbl_Tel_2.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_Tel_2.TabIndex = 40
        Me.Lbl_Tel_2.Text = "Telefono_2"
        Me.Lbl_Tel_2.Visible = False
        '
        'Lbl_Tel_1
        '
        Me.Lbl_Tel_1.AutoSize = True
        Me.Lbl_Tel_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "TELEFONO1", True))
        Me.Lbl_Tel_1.Location = New System.Drawing.Point(202, 50)
        Me.Lbl_Tel_1.Name = "Lbl_Tel_1"
        Me.Lbl_Tel_1.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_Tel_1.TabIndex = 39
        Me.Lbl_Tel_1.Text = "Telefono_1"
        Me.Lbl_Tel_1.Visible = False
        '
        'Lbl_Telefonos
        '
        Me.Lbl_Telefonos.AutoSize = True
        Me.Lbl_Telefonos.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefonos.Location = New System.Drawing.Point(145, 50)
        Me.Lbl_Telefonos.Name = "Lbl_Telefonos"
        Me.Lbl_Telefonos.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_Telefonos.TabIndex = 38
        Me.Lbl_Telefonos.Text = "Telefonos:"
        '
        'Lbl_Cod_Cliente
        '
        Me.Lbl_Cod_Cliente.AutoSize = True
        Me.Lbl_Cod_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRULTIMOESTADOQUEJABindingSource, "CLIENTE", True))
        Me.Lbl_Cod_Cliente.Location = New System.Drawing.Point(51, 50)
        Me.Lbl_Cod_Cliente.Name = "Lbl_Cod_Cliente"
        Me.Lbl_Cod_Cliente.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Cod_Cliente.TabIndex = 37
        Me.Lbl_Cod_Cliente.Text = "Cod_Cliente"
        Me.Lbl_Cod_Cliente.Visible = False
        '
        'Lbl_T_Cod_Cliente
        '
        Me.Lbl_T_Cod_Cliente.AutoSize = True
        Me.Lbl_T_Cod_Cliente.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Cod_Cliente.Location = New System.Drawing.Point(2, 50)
        Me.Lbl_T_Cod_Cliente.Name = "Lbl_T_Cod_Cliente"
        Me.Lbl_T_Cod_Cliente.Size = New System.Drawing.Size(50, 14)
        Me.Lbl_T_Cod_Cliente.TabIndex = 36
        Me.Lbl_T_Cod_Cliente.Text = "Cliente:"
        '
        'Lbl_Num_Queja
        '
        Me.Lbl_Num_Queja.AutoSize = True
        Me.Lbl_Num_Queja.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Num_Queja.Location = New System.Drawing.Point(2, 14)
        Me.Lbl_Num_Queja.Name = "Lbl_Num_Queja"
        Me.Lbl_Num_Queja.Size = New System.Drawing.Size(53, 14)
        Me.Lbl_Num_Queja.TabIndex = 35
        Me.Lbl_Num_Queja.Text = "# Queja:"
        '
        'Grb_Solucion
        '
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Chequeo)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_T_Chequeo)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Alisto)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_T_Alisto)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Solucion)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Fecha_Solucion)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Usuario_Solucion)
        Me.Grb_Solucion.Controls.Add(Me.Lbl_Solucionado_Por)
        Me.Grb_Solucion.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Solucion.Location = New System.Drawing.Point(5, 414)
        Me.Grb_Solucion.Name = "Grb_Solucion"
        Me.Grb_Solucion.Size = New System.Drawing.Size(956, 100)
        Me.Grb_Solucion.TabIndex = 63
        Me.Grb_Solucion.TabStop = False
        Me.Grb_Solucion.Text = "Solucion"
        '
        'Lbl_Chequeo
        '
        Me.Lbl_Chequeo.AutoSize = True
        Me.Lbl_Chequeo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRSOLUCIONQUEJABindingSource, "CHEQUEO", True))
        Me.Lbl_Chequeo.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Chequeo.Location = New System.Drawing.Point(669, 17)
        Me.Lbl_Chequeo.Name = "Lbl_Chequeo"
        Me.Lbl_Chequeo.Size = New System.Drawing.Size(51, 14)
        Me.Lbl_Chequeo.TabIndex = 7
        Me.Lbl_Chequeo.Text = "Chequeo"
        Me.Lbl_Chequeo.Visible = False
        '
        'SCRSOLUCIONQUEJABindingSource
        '
        Me.SCRSOLUCIONQUEJABindingSource.DataMember = "SCR_SOLUCION_QUEJA"
        Me.SCRSOLUCIONQUEJABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Lbl_T_Chequeo
        '
        Me.Lbl_T_Chequeo.AutoSize = True
        Me.Lbl_T_Chequeo.Location = New System.Drawing.Point(614, 17)
        Me.Lbl_T_Chequeo.Name = "Lbl_T_Chequeo"
        Me.Lbl_T_Chequeo.Size = New System.Drawing.Size(57, 14)
        Me.Lbl_T_Chequeo.TabIndex = 6
        Me.Lbl_T_Chequeo.Text = "Chequeo:"
        '
        'Lbl_Alisto
        '
        Me.Lbl_Alisto.AutoSize = True
        Me.Lbl_Alisto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRSOLUCIONQUEJABindingSource, "ALISTO", True))
        Me.Lbl_Alisto.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alisto.Location = New System.Drawing.Point(394, 17)
        Me.Lbl_Alisto.Name = "Lbl_Alisto"
        Me.Lbl_Alisto.Size = New System.Drawing.Size(38, 14)
        Me.Lbl_Alisto.TabIndex = 5
        Me.Lbl_Alisto.Text = "Alisto"
        Me.Lbl_Alisto.Visible = False
        '
        'Lbl_T_Alisto
        '
        Me.Lbl_T_Alisto.AutoSize = True
        Me.Lbl_T_Alisto.Location = New System.Drawing.Point(351, 17)
        Me.Lbl_T_Alisto.Name = "Lbl_T_Alisto"
        Me.Lbl_T_Alisto.Size = New System.Drawing.Size(43, 14)
        Me.Lbl_T_Alisto.TabIndex = 4
        Me.Lbl_T_Alisto.Text = "Alisto:"
        '
        'Lbl_Solucion
        '
        Me.Lbl_Solucion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRSOLUCIONQUEJABindingSource, "SOLUCION", True))
        Me.Lbl_Solucion.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Solucion.Location = New System.Drawing.Point(8, 31)
        Me.Lbl_Solucion.Name = "Lbl_Solucion"
        Me.Lbl_Solucion.Size = New System.Drawing.Size(942, 66)
        Me.Lbl_Solucion.TabIndex = 3
        Me.Lbl_Solucion.Text = "Solucion"
        Me.Lbl_Solucion.Visible = False
        '
        'Lbl_Fecha_Solucion
        '
        Me.Lbl_Fecha_Solucion.AutoSize = True
        Me.Lbl_Fecha_Solucion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRSOLUCIONQUEJABindingSource, "FECHA_HORA", True))
        Me.Lbl_Fecha_Solucion.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Solucion.Location = New System.Drawing.Point(213, 17)
        Me.Lbl_Fecha_Solucion.Name = "Lbl_Fecha_Solucion"
        Me.Lbl_Fecha_Solucion.Size = New System.Drawing.Size(38, 14)
        Me.Lbl_Fecha_Solucion.TabIndex = 2
        Me.Lbl_Fecha_Solucion.Text = "Fecha"
        Me.Lbl_Fecha_Solucion.Visible = False
        '
        'Lbl_Usuario_Solucion
        '
        Me.Lbl_Usuario_Solucion.AutoSize = True
        Me.Lbl_Usuario_Solucion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRSOLUCIONQUEJABindingSource, "USUARIO", True))
        Me.Lbl_Usuario_Solucion.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario_Solucion.Location = New System.Drawing.Point(100, 17)
        Me.Lbl_Usuario_Solucion.Name = "Lbl_Usuario_Solucion"
        Me.Lbl_Usuario_Solucion.Size = New System.Drawing.Size(103, 14)
        Me.Lbl_Usuario_Solucion.TabIndex = 1
        Me.Lbl_Usuario_Solucion.Text = "Usuario_Soluciuon"
        Me.Lbl_Usuario_Solucion.Visible = False
        '
        'Lbl_Solucionado_Por
        '
        Me.Lbl_Solucionado_Por.AutoSize = True
        Me.Lbl_Solucionado_Por.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Solucionado_Por.Location = New System.Drawing.Point(8, 17)
        Me.Lbl_Solucionado_Por.Name = "Lbl_Solucionado_Por"
        Me.Lbl_Solucionado_Por.Size = New System.Drawing.Size(95, 14)
        Me.Lbl_Solucionado_Por.TabIndex = 0
        Me.Lbl_Solucionado_Por.Text = "Solucionado Por:"
        '
        'Grb_Lista_Estados
        '
        Me.Grb_Lista_Estados.Controls.Add(Me.Dgv_Estados)
        Me.Grb_Lista_Estados.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Lista_Estados.Location = New System.Drawing.Point(5, 520)
        Me.Grb_Lista_Estados.Name = "Grb_Lista_Estados"
        Me.Grb_Lista_Estados.Size = New System.Drawing.Size(465, 156)
        Me.Grb_Lista_Estados.TabIndex = 64
        Me.Grb_Lista_Estados.TabStop = False
        Me.Grb_Lista_Estados.Text = "Lista de Estados"
        '
        'Dgv_Estados
        '
        Me.Dgv_Estados.AllowUserToAddRows = False
        Me.Dgv_Estados.AllowUserToDeleteRows = False
        Me.Dgv_Estados.AutoGenerateColumns = False
        Me.Dgv_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESTADODataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.FECHA})
        Me.Dgv_Estados.DataSource = Me.SCRESTADOQUEJABindingSource
        Me.Dgv_Estados.Location = New System.Drawing.Point(18, 20)
        Me.Dgv_Estados.Name = "Dgv_Estados"
        Me.Dgv_Estados.ReadOnly = True
        Me.Dgv_Estados.Size = New System.Drawing.Size(441, 130)
        Me.Dgv_Estados.TabIndex = 0
        Me.Dgv_Estados.Visible = False
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'SCRESTADOQUEJABindingSource
        '
        Me.SCRESTADOQUEJABindingSource.DataMember = "SCR_ESTADO_QUEJA"
        Me.SCRESTADOQUEJABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ULTIMO_ESTADO_QUEJATableAdapter
        '
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'SCR_ESTADO_QUEJATableAdapter
        '
        Me.SCR_ESTADO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'SCR_SOLUCION_QUEJATableAdapter
        '
        Me.SCR_SOLUCION_QUEJATableAdapter.ClearBeforeFill = True
        '
        'Grb_Procesada
        '
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Chequeo_P)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_T_Chequeo_Procesada)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Alisto_P)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Alisto_T)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Comentario_Procesada)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Procesada)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_Usuario_Procesada)
        Me.Grb_Procesada.Controls.Add(Me.Lbl_T_Procesada_Por)
        Me.Grb_Procesada.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Procesada.Location = New System.Drawing.Point(5, 305)
        Me.Grb_Procesada.Name = "Grb_Procesada"
        Me.Grb_Procesada.Size = New System.Drawing.Size(957, 103)
        Me.Grb_Procesada.TabIndex = 65
        Me.Grb_Procesada.TabStop = False
        Me.Grb_Procesada.Text = "Procesada"
        '
        'Lbl_Chequeo_P
        '
        Me.Lbl_Chequeo_P.AutoSize = True
        Me.Lbl_Chequeo_P.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRQUEJAPROCESADABindingSource, "CHUEQUEO", True))
        Me.Lbl_Chequeo_P.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Chequeo_P.Location = New System.Drawing.Point(668, 30)
        Me.Lbl_Chequeo_P.Name = "Lbl_Chequeo_P"
        Me.Lbl_Chequeo_P.Size = New System.Drawing.Size(51, 14)
        Me.Lbl_Chequeo_P.TabIndex = 15
        Me.Lbl_Chequeo_P.Text = "Chequeo"
        Me.Lbl_Chequeo_P.Visible = False
        '
        'SCRQUEJAPROCESADABindingSource
        '
        Me.SCRQUEJAPROCESADABindingSource.DataMember = "SCR_QUEJA_PROCESADA"
        Me.SCRQUEJAPROCESADABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Lbl_T_Chequeo_Procesada
        '
        Me.Lbl_T_Chequeo_Procesada.AutoSize = True
        Me.Lbl_T_Chequeo_Procesada.Location = New System.Drawing.Point(613, 30)
        Me.Lbl_T_Chequeo_Procesada.Name = "Lbl_T_Chequeo_Procesada"
        Me.Lbl_T_Chequeo_Procesada.Size = New System.Drawing.Size(57, 14)
        Me.Lbl_T_Chequeo_Procesada.TabIndex = 14
        Me.Lbl_T_Chequeo_Procesada.Text = "Chequeo:"
        '
        'Lbl_Alisto_P
        '
        Me.Lbl_Alisto_P.AutoSize = True
        Me.Lbl_Alisto_P.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRQUEJAPROCESADABindingSource, "ALISTO", True))
        Me.Lbl_Alisto_P.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alisto_P.Location = New System.Drawing.Point(393, 30)
        Me.Lbl_Alisto_P.Name = "Lbl_Alisto_P"
        Me.Lbl_Alisto_P.Size = New System.Drawing.Size(38, 14)
        Me.Lbl_Alisto_P.TabIndex = 13
        Me.Lbl_Alisto_P.Text = "Alisto"
        Me.Lbl_Alisto_P.Visible = False
        '
        'Lbl_Alisto_T
        '
        Me.Lbl_Alisto_T.AutoSize = True
        Me.Lbl_Alisto_T.Location = New System.Drawing.Point(350, 30)
        Me.Lbl_Alisto_T.Name = "Lbl_Alisto_T"
        Me.Lbl_Alisto_T.Size = New System.Drawing.Size(43, 14)
        Me.Lbl_Alisto_T.TabIndex = 12
        Me.Lbl_Alisto_T.Text = "Alisto:"
        '
        'Lbl_Comentario_Procesada
        '
        Me.Lbl_Comentario_Procesada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRQUEJAPROCESADABindingSource, "SOLUCION", True))
        Me.Lbl_Comentario_Procesada.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Comentario_Procesada.Location = New System.Drawing.Point(7, 44)
        Me.Lbl_Comentario_Procesada.Name = "Lbl_Comentario_Procesada"
        Me.Lbl_Comentario_Procesada.Size = New System.Drawing.Size(942, 50)
        Me.Lbl_Comentario_Procesada.TabIndex = 11
        Me.Lbl_Comentario_Procesada.Text = "Procesada"
        Me.Lbl_Comentario_Procesada.Visible = False
        '
        'Lbl_Procesada
        '
        Me.Lbl_Procesada.AutoSize = True
        Me.Lbl_Procesada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRQUEJAPROCESADABindingSource, "FECHA_HORA", True))
        Me.Lbl_Procesada.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Procesada.Location = New System.Drawing.Point(212, 30)
        Me.Lbl_Procesada.Name = "Lbl_Procesada"
        Me.Lbl_Procesada.Size = New System.Drawing.Size(38, 14)
        Me.Lbl_Procesada.TabIndex = 10
        Me.Lbl_Procesada.Text = "Fecha"
        Me.Lbl_Procesada.Visible = False
        '
        'Lbl_Usuario_Procesada
        '
        Me.Lbl_Usuario_Procesada.AutoSize = True
        Me.Lbl_Usuario_Procesada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRQUEJAPROCESADABindingSource, "USUARIO", True))
        Me.Lbl_Usuario_Procesada.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usuario_Procesada.Location = New System.Drawing.Point(99, 30)
        Me.Lbl_Usuario_Procesada.Name = "Lbl_Usuario_Procesada"
        Me.Lbl_Usuario_Procesada.Size = New System.Drawing.Size(107, 14)
        Me.Lbl_Usuario_Procesada.TabIndex = 9
        Me.Lbl_Usuario_Procesada.Text = "Usuario_Procesada"
        Me.Lbl_Usuario_Procesada.Visible = False
        '
        'Lbl_T_Procesada_Por
        '
        Me.Lbl_T_Procesada_Por.AutoSize = True
        Me.Lbl_T_Procesada_Por.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_T_Procesada_Por.Location = New System.Drawing.Point(7, 30)
        Me.Lbl_T_Procesada_Por.Name = "Lbl_T_Procesada_Por"
        Me.Lbl_T_Procesada_Por.Size = New System.Drawing.Size(87, 14)
        Me.Lbl_T_Procesada_Por.TabIndex = 8
        Me.Lbl_T_Procesada_Por.Text = "Procesada Por:"
        '
        'SCR_QUEJA_PROCESADATableAdapter
        '
        Me.SCR_QUEJA_PROCESADATableAdapter.ClearBeforeFill = True
        '
        'Frm_Consulta_Num_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 678)
        Me.Controls.Add(Me.Grb_Procesada)
        Me.Controls.Add(Me.Grb_Lista_Estados)
        Me.Controls.Add(Me.Grb_Solucion)
        Me.Controls.Add(Me.Grb_Detalle)
        Me.Controls.Add(Me.Lbl_Fecha_Estado)
        Me.Controls.Add(Me.Lbl_Estado_Actual)
        Me.Controls.Add(Me.Lbl__T_Estado_Actual)
        Me.Controls.Add(Me.Lbl_Proforma)
        Me.Controls.Add(Me.Lbl_T_Proforma)
        Me.Controls.Add(Me.Lbl_Factua)
        Me.Controls.Add(Me.Lbl_T_Factua)
        Me.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.Controls.Add(Me.Lbl_T_Fecha_ingreso)
        Me.Controls.Add(Me.Lbl_Direccion)
        Me.Controls.Add(Me.Lbl_T_Direccion)
        Me.Controls.Add(Me.Lbl_Contacto)
        Me.Controls.Add(Me.Lbl_T_Contacto)
        Me.Controls.Add(Me.Lbl_Alias)
        Me.Controls.Add(Me.Lbl_T_Alias)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_T_Nombre)
        Me.Controls.Add(Me.Lbl_Motivo)
        Me.Controls.Add(Me.Lbl__T_Tipo_Queja)
        Me.Controls.Add(Me.Lbl_Fax)
        Me.Controls.Add(Me.Lbl_T_Fax)
        Me.Controls.Add(Me.Lbl_Tel_2)
        Me.Controls.Add(Me.Lbl_Tel_1)
        Me.Controls.Add(Me.Lbl_Telefonos)
        Me.Controls.Add(Me.Lbl_Cod_Cliente)
        Me.Controls.Add(Me.Lbl_T_Cod_Cliente)
        Me.Controls.Add(Me.Lbl_Num_Queja)
        Me.Controls.Add(Me.Txt_Num_Queja)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consulta_Num_Queja"
        Me.Text = "Consulta Num Queja"
        Me.Grb_Detalle.ResumeLayout(False)
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_Solucion.ResumeLayout(False)
        Me.Grb_Solucion.PerformLayout()
        CType(Me.SCRSOLUCIONQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_Lista_Estados.ResumeLayout(False)
        CType(Me.Dgv_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_Procesada.ResumeLayout(False)
        Me.Grb_Procesada.PerformLayout()
        CType(Me.SCRQUEJAPROCESADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Num_Queja As TextBox
    Friend WithEvents Grb_Detalle As GroupBox
    Friend WithEvents Lbl_Detalle As Label
    Friend WithEvents Lbl_Fecha_Estado As Label
    Friend WithEvents Lbl_Estado_Actual As Label
    Friend WithEvents Lbl__T_Estado_Actual As Label
    Friend WithEvents Lbl_Proforma As Label
    Friend WithEvents Lbl_T_Proforma As Label
    Friend WithEvents Lbl_Factua As Label
    Friend WithEvents Lbl_T_Factua As Label
    Friend WithEvents Lbl_Fecha_Ingreso As Label
    Friend WithEvents Lbl_T_Fecha_ingreso As Label
    Friend WithEvents Lbl_Direccion As Label
    Friend WithEvents Lbl_T_Direccion As Label
    Friend WithEvents Lbl_Contacto As Label
    Friend WithEvents Lbl_T_Contacto As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_T_Nombre As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl__T_Tipo_Queja As Label
    Friend WithEvents Lbl_Fax As Label
    Friend WithEvents Lbl_T_Fax As Label
    Friend WithEvents Lbl_Tel_2 As Label
    Friend WithEvents Lbl_Tel_1 As Label
    Friend WithEvents Lbl_Telefonos As Label
    Friend WithEvents Lbl_Cod_Cliente As Label
    Friend WithEvents Lbl_T_Cod_Cliente As Label
    Friend WithEvents Lbl_Num_Queja As Label
    Friend WithEvents Grb_Solucion As GroupBox
    Friend WithEvents Lbl_Solucion As Label
    Friend WithEvents Lbl_Fecha_Solucion As Label
    Friend WithEvents Lbl_Usuario_Solucion As Label
    Friend WithEvents Lbl_Solucionado_Por As Label
    Friend WithEvents Grb_Lista_Estados As GroupBox
    Friend WithEvents Dgv_Estados As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRULTIMOESTADOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_ULTIMO_ESTADO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter
    Friend WithEvents SCRESTADOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_ESTADO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_QUEJATableAdapter
    Friend WithEvents Lbl_Chequeo As Label
    Friend WithEvents Lbl_T_Chequeo As Label
    Friend WithEvents Lbl_Alisto As Label
    Friend WithEvents Lbl_T_Alisto As Label
    Friend WithEvents SCRSOLUCIONQUEJABindingSource As BindingSource
    Friend WithEvents SCR_SOLUCION_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_SOLUCION_QUEJATableAdapter
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents Grb_Procesada As GroupBox
    Friend WithEvents Lbl_Chequeo_P As Label
    Friend WithEvents Lbl_T_Chequeo_Procesada As Label
    Friend WithEvents Lbl_Alisto_P As Label
    Friend WithEvents Lbl_Alisto_T As Label
    Friend WithEvents Lbl_Comentario_Procesada As Label
    Friend WithEvents Lbl_Procesada As Label
    Friend WithEvents Lbl_Usuario_Procesada As Label
    Friend WithEvents Lbl_T_Procesada_Por As Label
    Friend WithEvents SCRQUEJAPROCESADABindingSource As BindingSource
    Friend WithEvents SCR_QUEJA_PROCESADATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_QUEJA_PROCESADATableAdapter
End Class
