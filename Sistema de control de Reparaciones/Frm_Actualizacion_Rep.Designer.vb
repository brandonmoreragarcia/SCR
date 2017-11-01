<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Actualizacion_Rep
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Actualizacion_Rep))
        Me.Lbl_Numero_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_Articulo = New System.Windows.Forms.Label()
        Me.SCRREPSPENDIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRDATOSREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_T_Articulo = New System.Windows.Forms.Label()
        Me.Cbx_Boleta = New System.Windows.Forms.ComboBox()
        Me.Lbl_Fecha_Hora = New System.Windows.Forms.Label()
        Me.Lbl_T_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Numero_1 = New System.Windows.Forms.Label()
        Me.Lbl_Numero_2 = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_T_Descripcion = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        Me.Lbl_T_Adicio_Art = New System.Windows.Forms.Label()
        Me.Lbl_Adicional_Art = New System.Windows.Forms.Label()
        Me.Gbx_Info_Cliente = New System.Windows.Forms.GroupBox()
        Me.Gbx_Articulo_Rep = New System.Windows.Forms.GroupBox()
        Me.Lbl_Numero_Serie = New System.Windows.Forms.Label()
        Me.Lbl_Boleta_Chofer = New System.Windows.Forms.Label()
        Me.Lbl_T_Numero_Serie = New System.Windows.Forms.Label()
        Me.Lbl_ = New System.Windows.Forms.Label()
        Me.Lbl_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_T_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_T_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Rep = New System.Windows.Forms.Label()
        Me.Lbl_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Problema = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_T_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_T_Fecha_Ingeso = New System.Windows.Forms.Label()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.Lbl_Localizacion = New System.Windows.Forms.Label()
        Me.Lbl_Comentario = New System.Windows.Forms.Label()
        Me.Txt_Comentario = New System.Windows.Forms.TextBox()
        Me.Cbx_Estado = New System.Windows.Forms.ComboBox()
        Me.SCRESTADOACTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbx_Localizacion = New System.Windows.Forms.ComboBox()
        Me.SCRLOCALIZACIONREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Grabar_Actua = New System.Windows.Forms.Button()
        Me.Gbx_Garantia = New System.Windows.Forms.GroupBox()
        Me.Rbtn_Garan_No = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Garan_Si = New System.Windows.Forms.RadioButton()
        Me.Gbx_Facturada = New System.Windows.Forms.GroupBox()
        Me.Rbtn_Factu_No = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Factu_Si = New System.Windows.Forms.RadioButton()
        Me.Lbl_Factura_Num = New System.Windows.Forms.Label()
        Me.Txt_Factura_Num = New System.Windows.Forms.TextBox()
        Me.Lbl_Tiempo_Rep = New System.Windows.Forms.Label()
        Me.Txt_Tiempo_Inver = New System.Windows.Forms.TextBox()
        Me.Txt_Adicional = New System.Windows.Forms.TextBox()
        Me.Lbl_Adicional = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gb_detalle_reparacion = New System.Windows.Forms.GroupBox()
        Me.dg_detalle_rep = New System.Windows.Forms.DataGridView()
        Me.SCRCONSULTAREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dg_reparaciones = New System.Windows.Forms.DataGridView()
        Me.REPARACIONNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_ingresar_cod_reparacion = New System.Windows.Forms.Label()
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.SCR_ESTADO_ACTUATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_ACTUATableAdapter()
        Me.SCR_LOCALIZACION_REPTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter()
        Me.SCR_REPS_PENDIENTESTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_REPS_PENDIENTESTableAdapter()
        Me.bt_cerrado_rapido = New System.Windows.Forms.Button()
        Me.SCR_CONSULTA_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter()
        Me.ch_ver_informacion = New System.Windows.Forms.CheckBox()
        Me.COMENTARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SCRREPSPENDIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Info_Cliente.SuspendLayout()
        Me.Gbx_Articulo_Rep.SuspendLayout()
        CType(Me.SCRESTADOACTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Garantia.SuspendLayout()
        Me.Gbx_Facturada.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_detalle_reparacion.SuspendLayout()
        CType(Me.dg_detalle_rep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_reparaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Numero_Boleta
        '
        Me.Lbl_Numero_Boleta.AutoSize = True
        Me.Lbl_Numero_Boleta.Location = New System.Drawing.Point(1045, 15)
        Me.Lbl_Numero_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Numero_Boleta.Name = "Lbl_Numero_Boleta"
        Me.Lbl_Numero_Boleta.Size = New System.Drawing.Size(85, 15)
        Me.Lbl_Numero_Boleta.TabIndex = 0
        Me.Lbl_Numero_Boleta.Text = "Reparacion #"
        '
        'Lbl_Articulo
        '
        Me.Lbl_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "CODIGO_ART", True))
        Me.Lbl_Articulo.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Articulo.Location = New System.Drawing.Point(76, 38)
        Me.Lbl_Articulo.Name = "Lbl_Articulo"
        Me.Lbl_Articulo.Size = New System.Drawing.Size(102, 24)
        Me.Lbl_Articulo.TabIndex = 2
        Me.Lbl_Articulo.Text = "BI0000-000"
        '
        'SCRREPSPENDIENTESBindingSource
        '
        Me.SCRREPSPENDIENTESBindingSource.DataMember = "SCR_REPS_PENDIENTES"
        Me.SCRREPSPENDIENTESBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCRDATOSREPARACIONBindingSource
        '
        Me.SCRDATOSREPARACIONBindingSource.DataMember = "SCR_DATOS_REPARACION"
        Me.SCRDATOSREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Lbl_T_Articulo
        '
        Me.Lbl_T_Articulo.AutoSize = True
        Me.Lbl_T_Articulo.Location = New System.Drawing.Point(6, 38)
        Me.Lbl_T_Articulo.Name = "Lbl_T_Articulo"
        Me.Lbl_T_Articulo.Size = New System.Drawing.Size(67, 16)
        Me.Lbl_T_Articulo.TabIndex = 3
        Me.Lbl_T_Articulo.Text = "Articulo:"
        '
        'Cbx_Boleta
        '
        Me.Cbx_Boleta.DataSource = Me.SCRREPSPENDIENTESBindingSource
        Me.Cbx_Boleta.DisplayMember = "REPARACION_NUMERO"
        Me.Cbx_Boleta.Enabled = False
        Me.Cbx_Boleta.FormattingEnabled = True
        Me.Cbx_Boleta.Location = New System.Drawing.Point(1133, 12)
        Me.Cbx_Boleta.Name = "Cbx_Boleta"
        Me.Cbx_Boleta.Size = New System.Drawing.Size(119, 23)
        Me.Cbx_Boleta.TabIndex = 4
        '
        'Lbl_Fecha_Hora
        '
        Me.Lbl_Fecha_Hora.AutoSize = True
        Me.Lbl_Fecha_Hora.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(810, 14)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(85, 16)
        Me.Lbl_Fecha_Hora.TabIndex = 5
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Lbl_T_Cliente
        '
        Me.Lbl_T_Cliente.AutoSize = True
        Me.Lbl_T_Cliente.Location = New System.Drawing.Point(10, 32)
        Me.Lbl_T_Cliente.Name = "Lbl_T_Cliente"
        Me.Lbl_T_Cliente.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_T_Cliente.TabIndex = 6
        Me.Lbl_T_Cliente.Text = "Cliente:"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "CODIGO_CLIENTE", True))
        Me.Lbl_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Cliente.Location = New System.Drawing.Point(66, 32)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(98, 16)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Codigo_Cliente"
        '
        'Lbl_T_Nombre_Cliente
        '
        Me.Lbl_T_Nombre_Cliente.AutoSize = True
        Me.Lbl_T_Nombre_Cliente.Location = New System.Drawing.Point(10, 61)
        Me.Lbl_T_Nombre_Cliente.Name = "Lbl_T_Nombre_Cliente"
        Me.Lbl_T_Nombre_Cliente.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_T_Nombre_Cliente.TabIndex = 8
        Me.Lbl_T_Nombre_Cliente.Text = "Nombre:"
        '
        'Lbl_Nombre_Cliente
        '
        Me.Lbl_Nombre_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Nombre_Cliente.Location = New System.Drawing.Point(73, 61)
        Me.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente"
        Me.Lbl_Nombre_Cliente.Size = New System.Drawing.Size(196, 48)
        Me.Lbl_Nombre_Cliente.TabIndex = 9
        Me.Lbl_Nombre_Cliente.Text = "Nombre_Cliente"
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'ExactusERP_TABLES
        '
        Me.ExactusERP_TABLES.DataSetName = "ExactusERP_TABLES"
        Me.ExactusERP_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(312, 32)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(66, 16)
        Me.Lbl_Telefono.TabIndex = 11
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Lbl_Numero_1
        '
        Me.Lbl_Numero_1.AutoSize = True
        Me.Lbl_Numero_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "TELEFONO1", True))
        Me.Lbl_Numero_1.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Numero_1.Location = New System.Drawing.Point(379, 32)
        Me.Lbl_Numero_1.Name = "Lbl_Numero_1"
        Me.Lbl_Numero_1.Size = New System.Drawing.Size(69, 16)
        Me.Lbl_Numero_1.TabIndex = 12
        Me.Lbl_Numero_1.Text = "Numero 1"
        '
        'Lbl_Numero_2
        '
        Me.Lbl_Numero_2.AutoSize = True
        Me.Lbl_Numero_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "TELEFONO2", True))
        Me.Lbl_Numero_2.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Numero_2.Location = New System.Drawing.Point(519, 32)
        Me.Lbl_Numero_2.Name = "Lbl_Numero_2"
        Me.Lbl_Numero_2.Size = New System.Drawing.Size(69, 16)
        Me.Lbl_Numero_2.TabIndex = 13
        Me.Lbl_Numero_2.Text = "Numero 2"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(314, 56)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_T_Alias.TabIndex = 14
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Alias.Location = New System.Drawing.Point(353, 56)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(177, 43)
        Me.Lbl_Alias.TabIndex = 15
        Me.Lbl_Alias.Text = "Alias"
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'Lbl_T_Descripcion
        '
        Me.Lbl_T_Descripcion.AutoSize = True
        Me.Lbl_T_Descripcion.Location = New System.Drawing.Point(6, 78)
        Me.Lbl_T_Descripcion.Name = "Lbl_T_Descripcion"
        Me.Lbl_T_Descripcion.Size = New System.Drawing.Size(89, 16)
        Me.Lbl_T_Descripcion.TabIndex = 19
        Me.Lbl_T_Descripcion.Text = "Descripcion:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "DESCRIPCION", True))
        Me.Lbl_Descripcion.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(94, 78)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(243, 31)
        Me.Lbl_Descripcion.TabIndex = 20
        Me.Lbl_Descripcion.Text = "Descripcion"
        '
        'Lbl_T_Adicio_Art
        '
        Me.Lbl_T_Adicio_Art.AutoSize = True
        Me.Lbl_T_Adicio_Art.Location = New System.Drawing.Point(6, 119)
        Me.Lbl_T_Adicio_Art.Name = "Lbl_T_Adicio_Art"
        Me.Lbl_T_Adicio_Art.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_T_Adicio_Art.TabIndex = 21
        Me.Lbl_T_Adicio_Art.Text = "Adicional:"
        '
        'Lbl_Adicional_Art
        '
        Me.Lbl_Adicional_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "ADICIONAL_ART", True))
        Me.Lbl_Adicional_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Adicional_Art.Location = New System.Drawing.Point(74, 119)
        Me.Lbl_Adicional_Art.Name = "Lbl_Adicional_Art"
        Me.Lbl_Adicional_Art.Size = New System.Drawing.Size(263, 38)
        Me.Lbl_Adicional_Art.TabIndex = 22
        Me.Lbl_Adicional_Art.Text = "Adicional"
        '
        'Gbx_Info_Cliente
        '
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Nombre_Cliente)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_T_Cliente)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Alias)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_T_Alias)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Cliente)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_T_Nombre_Cliente)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Telefono)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Numero_2)
        Me.Gbx_Info_Cliente.Controls.Add(Me.Lbl_Numero_1)
        Me.Gbx_Info_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Gbx_Info_Cliente.Location = New System.Drawing.Point(590, 56)
        Me.Gbx_Info_Cliente.Name = "Gbx_Info_Cliente"
        Me.Gbx_Info_Cliente.Size = New System.Drawing.Size(662, 115)
        Me.Gbx_Info_Cliente.TabIndex = 23
        Me.Gbx_Info_Cliente.TabStop = False
        Me.Gbx_Info_Cliente.Text = "INFORMACION CLIENTE"
        '
        'Gbx_Articulo_Rep
        '
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Numero_Serie)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Boleta_Chofer)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Numero_Serie)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Articulo)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Adicional_Art)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Doc_Ref)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Traido_Por)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Estado_Boleta)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Articulo)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Traido_Por)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Doc_Ref)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Adicio_Art)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Estado_Rep)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Problema_Reportado)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Estado_Art)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Motivo)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Estado_Art)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Descripcion)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Problema)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Motivo)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Descripcion)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_Encargado_Bod)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Encargado_Bod)
        Me.Gbx_Articulo_Rep.Controls.Add(Me.Lbl_T_Fecha_Ingeso)
        Me.Gbx_Articulo_Rep.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Gbx_Articulo_Rep.Location = New System.Drawing.Point(592, 194)
        Me.Gbx_Articulo_Rep.Name = "Gbx_Articulo_Rep"
        Me.Gbx_Articulo_Rep.Size = New System.Drawing.Size(662, 337)
        Me.Gbx_Articulo_Rep.TabIndex = 24
        Me.Gbx_Articulo_Rep.TabStop = False
        Me.Gbx_Articulo_Rep.Text = "INFORMACION ARTICULO Y REPARACION"
        '
        'Lbl_Numero_Serie
        '
        Me.Lbl_Numero_Serie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "SERIE_PRODUCTO", True))
        Me.Lbl_Numero_Serie.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Numero_Serie.Location = New System.Drawing.Point(232, 29)
        Me.Lbl_Numero_Serie.Name = "Lbl_Numero_Serie"
        Me.Lbl_Numero_Serie.Size = New System.Drawing.Size(162, 33)
        Me.Lbl_Numero_Serie.TabIndex = 49
        Me.Lbl_Numero_Serie.Text = "Numero_Serie"
        '
        'Lbl_Boleta_Chofer
        '
        Me.Lbl_Boleta_Chofer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "BOLETA", True))
        Me.Lbl_Boleta_Chofer.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Boleta_Chofer.Location = New System.Drawing.Point(499, 38)
        Me.Lbl_Boleta_Chofer.Name = "Lbl_Boleta_Chofer"
        Me.Lbl_Boleta_Chofer.Size = New System.Drawing.Size(159, 15)
        Me.Lbl_Boleta_Chofer.TabIndex = 35
        Me.Lbl_Boleta_Chofer.Text = "Boleta Chofer"
        '
        'Lbl_T_Numero_Serie
        '
        Me.Lbl_T_Numero_Serie.AutoSize = True
        Me.Lbl_T_Numero_Serie.Location = New System.Drawing.Point(184, 37)
        Me.Lbl_T_Numero_Serie.Name = "Lbl_T_Numero_Serie"
        Me.Lbl_T_Numero_Serie.Size = New System.Drawing.Size(42, 16)
        Me.Lbl_T_Numero_Serie.TabIndex = 48
        Me.Lbl_T_Numero_Serie.Text = "Serie"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(400, 38)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(103, 16)
        Me.Lbl_.TabIndex = 33
        Me.Lbl_.Text = "Boleta Chofer:"
        '
        'Lbl_Doc_Ref
        '
        Me.Lbl_Doc_Ref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "DOCUMENTO_REF", True))
        Me.Lbl_Doc_Ref.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Doc_Ref.Location = New System.Drawing.Point(454, 158)
        Me.Lbl_Doc_Ref.Name = "Lbl_Doc_Ref"
        Me.Lbl_Doc_Ref.Size = New System.Drawing.Size(111, 24)
        Me.Lbl_Doc_Ref.TabIndex = 32
        Me.Lbl_Doc_Ref.Text = "Doc_Ref"
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "TRAIDO_POR", True))
        Me.Lbl_Traido_Por.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(446, 271)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(121, 23)
        Me.Lbl_Traido_Por.TabIndex = 34
        Me.Lbl_Traido_Por.Text = "Traido Por"
        '
        'Lbl_T_Estado_Boleta
        '
        Me.Lbl_T_Estado_Boleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "ESTADO", True))
        Me.Lbl_T_Estado_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_T_Estado_Boleta.Location = New System.Drawing.Point(424, 124)
        Me.Lbl_T_Estado_Boleta.Name = "Lbl_T_Estado_Boleta"
        Me.Lbl_T_Estado_Boleta.Size = New System.Drawing.Size(159, 28)
        Me.Lbl_T_Estado_Boleta.TabIndex = 32
        Me.Lbl_T_Estado_Boleta.Text = "Estado Bol"
        '
        'Lbl_T_Traido_Por
        '
        Me.Lbl_T_Traido_Por.AutoSize = True
        Me.Lbl_T_Traido_Por.Location = New System.Drawing.Point(365, 271)
        Me.Lbl_T_Traido_Por.Name = "Lbl_T_Traido_Por"
        Me.Lbl_T_Traido_Por.Size = New System.Drawing.Size(83, 16)
        Me.Lbl_T_Traido_Por.TabIndex = 33
        Me.Lbl_T_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_T_Doc_Ref
        '
        Me.Lbl_T_Doc_Ref.AutoSize = True
        Me.Lbl_T_Doc_Ref.Location = New System.Drawing.Point(366, 152)
        Me.Lbl_T_Doc_Ref.Name = "Lbl_T_Doc_Ref"
        Me.Lbl_T_Doc_Ref.Size = New System.Drawing.Size(82, 32)
        Me.Lbl_T_Doc_Ref.TabIndex = 31
        Me.Lbl_T_Doc_Ref.Text = "Documento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Referencia:"
        '
        'Lbl_T_Estado_Rep
        '
        Me.Lbl_T_Estado_Rep.AutoSize = True
        Me.Lbl_T_Estado_Rep.Location = New System.Drawing.Point(366, 124)
        Me.Lbl_T_Estado_Rep.Name = "Lbl_T_Estado_Rep"
        Me.Lbl_T_Estado_Rep.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_T_Estado_Rep.TabIndex = 31
        Me.Lbl_T_Estado_Rep.Text = "Estado:"
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "PROBLEMA_REPORTADO", True))
        Me.Lbl_Problema_Reportado.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(86, 159)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(251, 81)
        Me.Lbl_Problema_Reportado.TabIndex = 30
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "ESTADO_ART", True))
        Me.Lbl_Estado_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(81, 251)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(256, 69)
        Me.Lbl_Estado_Art.TabIndex = 28
        Me.Lbl_Estado_Art.Text = "Estado_Art"
        '
        'Lbl_T_Motivo
        '
        Me.Lbl_T_Motivo.AutoSize = True
        Me.Lbl_T_Motivo.Location = New System.Drawing.Point(367, 235)
        Me.Lbl_T_Motivo.Name = "Lbl_T_Motivo"
        Me.Lbl_T_Motivo.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_T_Motivo.TabIndex = 27
        Me.Lbl_T_Motivo.Text = "Motivo:"
        '
        'Lbl_T_Estado_Art
        '
        Me.Lbl_T_Estado_Art.AutoSize = True
        Me.Lbl_T_Estado_Art.Location = New System.Drawing.Point(8, 262)
        Me.Lbl_T_Estado_Art.Name = "Lbl_T_Estado_Art"
        Me.Lbl_T_Estado_Art.Size = New System.Drawing.Size(67, 32)
        Me.Lbl_T_Estado_Art.TabIndex = 25
        Me.Lbl_T_Estado_Art.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Articulo:"
        '
        'Lbl_T_Problema
        '
        Me.Lbl_T_Problema.AutoSize = True
        Me.Lbl_T_Problema.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_T_Problema.Location = New System.Drawing.Point(6, 159)
        Me.Lbl_T_Problema.Name = "Lbl_T_Problema"
        Me.Lbl_T_Problema.Size = New System.Drawing.Size(81, 32)
        Me.Lbl_T_Problema.TabIndex = 29
        Me.Lbl_T_Problema.Text = "Problema" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reportado:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "MOTIVO", True))
        Me.Lbl_Motivo.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Motivo.Location = New System.Drawing.Point(424, 235)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(114, 18)
        Me.Lbl_Motivo.TabIndex = 26
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Lbl_Fecha_Ingreso
        '
        Me.Lbl_Fecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "FECHA", True))
        Me.Lbl_Fecha_Ingreso.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(484, 200)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(140, 26)
        Me.Lbl_Fecha_Ingreso.TabIndex = 30
        Me.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso"
        '
        'Lbl_Encargado_Bod
        '
        Me.Lbl_Encargado_Bod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRREPSPENDIENTESBindingSource, "ENCARGADO_BODEGA", True))
        Me.Lbl_Encargado_Bod.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Encargado_Bod.Location = New System.Drawing.Point(446, 70)
        Me.Lbl_Encargado_Bod.Name = "Lbl_Encargado_Bod"
        Me.Lbl_Encargado_Bod.Size = New System.Drawing.Size(164, 42)
        Me.Lbl_Encargado_Bod.TabIndex = 26
        Me.Lbl_Encargado_Bod.Text = "Encargado Bodega"
        '
        'Lbl_T_Encargado_Bod
        '
        Me.Lbl_T_Encargado_Bod.AutoSize = True
        Me.Lbl_T_Encargado_Bod.Location = New System.Drawing.Point(367, 70)
        Me.Lbl_T_Encargado_Bod.Name = "Lbl_T_Encargado_Bod"
        Me.Lbl_T_Encargado_Bod.Size = New System.Drawing.Size(78, 32)
        Me.Lbl_T_Encargado_Bod.TabIndex = 25
        Me.Lbl_T_Encargado_Bod.Text = "Encargado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bodega:"
        '
        'Lbl_T_Fecha_Ingeso
        '
        Me.Lbl_T_Fecha_Ingeso.AutoSize = True
        Me.Lbl_T_Fecha_Ingeso.Location = New System.Drawing.Point(366, 200)
        Me.Lbl_T_Fecha_Ingeso.Name = "Lbl_T_Fecha_Ingeso"
        Me.Lbl_T_Fecha_Ingeso.Size = New System.Drawing.Size(125, 16)
        Me.Lbl_T_Fecha_Ingeso.TabIndex = 29
        Me.Lbl_T_Fecha_Ingeso.Text = "Fecha de Ingreso:"
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'ARTICULOTableAdapter
        '
        Me.ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(8, 42)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_Estado.TabIndex = 25
        Me.Lbl_Estado.Text = "Estado:"
        '
        'Lbl_Localizacion
        '
        Me.Lbl_Localizacion.AutoSize = True
        Me.Lbl_Localizacion.Location = New System.Drawing.Point(194, 42)
        Me.Lbl_Localizacion.Name = "Lbl_Localizacion"
        Me.Lbl_Localizacion.Size = New System.Drawing.Size(92, 16)
        Me.Lbl_Localizacion.TabIndex = 26
        Me.Lbl_Localizacion.Text = "Localizacion:"
        '
        'Lbl_Comentario
        '
        Me.Lbl_Comentario.AutoSize = True
        Me.Lbl_Comentario.Location = New System.Drawing.Point(11, 161)
        Me.Lbl_Comentario.Name = "Lbl_Comentario"
        Me.Lbl_Comentario.Size = New System.Drawing.Size(88, 16)
        Me.Lbl_Comentario.TabIndex = 27
        Me.Lbl_Comentario.Text = "Comentario:"
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Enabled = False
        Me.Txt_Comentario.Location = New System.Drawing.Point(105, 158)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(226, 55)
        Me.Txt_Comentario.TabIndex = 28
        '
        'Cbx_Estado
        '
        Me.Cbx_Estado.DataSource = Me.SCRESTADOACTUABindingSource
        Me.Cbx_Estado.DisplayMember = "ESTADO"
        Me.Cbx_Estado.DropDownWidth = 290
        Me.Cbx_Estado.FormattingEnabled = True
        Me.Cbx_Estado.Location = New System.Drawing.Point(67, 39)
        Me.Cbx_Estado.Name = "Cbx_Estado"
        Me.Cbx_Estado.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_Estado.TabIndex = 29
        '
        'SCRESTADOACTUABindingSource
        '
        Me.SCRESTADOACTUABindingSource.DataMember = "SCR_ESTADO_ACTUA"
        Me.SCRESTADOACTUABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Cbx_Localizacion
        '
        Me.Cbx_Localizacion.DataSource = Me.SCRLOCALIZACIONREPBindingSource
        Me.Cbx_Localizacion.DisplayMember = "LOCALIZACION"
        Me.Cbx_Localizacion.DropDownWidth = 290
        Me.Cbx_Localizacion.Enabled = False
        Me.Cbx_Localizacion.FormattingEnabled = True
        Me.Cbx_Localizacion.Location = New System.Drawing.Point(292, 38)
        Me.Cbx_Localizacion.Name = "Cbx_Localizacion"
        Me.Cbx_Localizacion.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_Localizacion.TabIndex = 30
        '
        'SCRLOCALIZACIONREPBindingSource
        '
        Me.SCRLOCALIZACIONREPBindingSource.DataMember = "SCR_LOCALIZACION_REP"
        Me.SCRLOCALIZACIONREPBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Btn_Grabar_Actua
        '
        Me.Btn_Grabar_Actua.Enabled = False
        Me.Btn_Grabar_Actua.Location = New System.Drawing.Point(398, 246)
        Me.Btn_Grabar_Actua.Name = "Btn_Grabar_Actua"
        Me.Btn_Grabar_Actua.Size = New System.Drawing.Size(103, 30)
        Me.Btn_Grabar_Actua.TabIndex = 31
        Me.Btn_Grabar_Actua.Text = "GUARDAR!"
        Me.Btn_Grabar_Actua.UseVisualStyleBackColor = True
        Me.Btn_Grabar_Actua.Visible = False
        '
        'Gbx_Garantia
        '
        Me.Gbx_Garantia.Controls.Add(Me.Rbtn_Garan_No)
        Me.Gbx_Garantia.Controls.Add(Me.Rbtn_Garan_Si)
        Me.Gbx_Garantia.Location = New System.Drawing.Point(390, 93)
        Me.Gbx_Garantia.Name = "Gbx_Garantia"
        Me.Gbx_Garantia.Size = New System.Drawing.Size(123, 50)
        Me.Gbx_Garantia.TabIndex = 47
        Me.Gbx_Garantia.TabStop = False
        Me.Gbx_Garantia.Text = "GARANTIA"
        Me.Gbx_Garantia.Visible = False
        '
        'Rbtn_Garan_No
        '
        Me.Rbtn_Garan_No.AutoSize = True
        Me.Rbtn_Garan_No.Location = New System.Drawing.Point(73, 21)
        Me.Rbtn_Garan_No.Name = "Rbtn_Garan_No"
        Me.Rbtn_Garan_No.Size = New System.Drawing.Size(47, 20)
        Me.Rbtn_Garan_No.TabIndex = 1
        Me.Rbtn_Garan_No.TabStop = True
        Me.Rbtn_Garan_No.Text = "NO"
        Me.Rbtn_Garan_No.UseVisualStyleBackColor = True
        '
        'Rbtn_Garan_Si
        '
        Me.Rbtn_Garan_Si.AutoSize = True
        Me.Rbtn_Garan_Si.Location = New System.Drawing.Point(8, 21)
        Me.Rbtn_Garan_Si.Name = "Rbtn_Garan_Si"
        Me.Rbtn_Garan_Si.Size = New System.Drawing.Size(39, 20)
        Me.Rbtn_Garan_Si.TabIndex = 0
        Me.Rbtn_Garan_Si.TabStop = True
        Me.Rbtn_Garan_Si.Text = "Sí"
        Me.Rbtn_Garan_Si.UseVisualStyleBackColor = True
        '
        'Gbx_Facturada
        '
        Me.Gbx_Facturada.Controls.Add(Me.Rbtn_Factu_No)
        Me.Gbx_Facturada.Controls.Add(Me.Rbtn_Factu_Si)
        Me.Gbx_Facturada.Location = New System.Drawing.Point(390, 161)
        Me.Gbx_Facturada.Name = "Gbx_Facturada"
        Me.Gbx_Facturada.Size = New System.Drawing.Size(123, 53)
        Me.Gbx_Facturada.TabIndex = 48
        Me.Gbx_Facturada.TabStop = False
        Me.Gbx_Facturada.Text = "FACTURADA"
        Me.Gbx_Facturada.Visible = False
        '
        'Rbtn_Factu_No
        '
        Me.Rbtn_Factu_No.AutoSize = True
        Me.Rbtn_Factu_No.Location = New System.Drawing.Point(72, 20)
        Me.Rbtn_Factu_No.Name = "Rbtn_Factu_No"
        Me.Rbtn_Factu_No.Size = New System.Drawing.Size(47, 20)
        Me.Rbtn_Factu_No.TabIndex = 1
        Me.Rbtn_Factu_No.TabStop = True
        Me.Rbtn_Factu_No.Text = "NO"
        Me.Rbtn_Factu_No.UseVisualStyleBackColor = True
        '
        'Rbtn_Factu_Si
        '
        Me.Rbtn_Factu_Si.AutoSize = True
        Me.Rbtn_Factu_Si.Location = New System.Drawing.Point(16, 21)
        Me.Rbtn_Factu_Si.Name = "Rbtn_Factu_Si"
        Me.Rbtn_Factu_Si.Size = New System.Drawing.Size(40, 20)
        Me.Rbtn_Factu_Si.TabIndex = 0
        Me.Rbtn_Factu_Si.TabStop = True
        Me.Rbtn_Factu_Si.Text = "SI"
        Me.Rbtn_Factu_Si.UseVisualStyleBackColor = True
        '
        'Lbl_Factura_Num
        '
        Me.Lbl_Factura_Num.AutoSize = True
        Me.Lbl_Factura_Num.Location = New System.Drawing.Point(9, 96)
        Me.Lbl_Factura_Num.Name = "Lbl_Factura_Num"
        Me.Lbl_Factura_Num.Size = New System.Drawing.Size(76, 16)
        Me.Lbl_Factura_Num.TabIndex = 49
        Me.Lbl_Factura_Num.Text = "Factura #"
        Me.Lbl_Factura_Num.Visible = False
        '
        'Txt_Factura_Num
        '
        Me.Txt_Factura_Num.Location = New System.Drawing.Point(78, 93)
        Me.Txt_Factura_Num.Name = "Txt_Factura_Num"
        Me.Txt_Factura_Num.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Factura_Num.TabIndex = 50
        Me.Txt_Factura_Num.Visible = False
        '
        'Lbl_Tiempo_Rep
        '
        Me.Lbl_Tiempo_Rep.AutoSize = True
        Me.Lbl_Tiempo_Rep.Location = New System.Drawing.Point(419, 35)
        Me.Lbl_Tiempo_Rep.Name = "Lbl_Tiempo_Rep"
        Me.Lbl_Tiempo_Rep.Size = New System.Drawing.Size(80, 32)
        Me.Lbl_Tiempo_Rep.TabIndex = 51
        Me.Lbl_Tiempo_Rep.Text = "horas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "invertidas:"
        Me.Lbl_Tiempo_Rep.Visible = False
        '
        'Txt_Tiempo_Inver
        '
        Me.Txt_Tiempo_Inver.Location = New System.Drawing.Point(503, 39)
        Me.Txt_Tiempo_Inver.Name = "Txt_Tiempo_Inver"
        Me.Txt_Tiempo_Inver.Size = New System.Drawing.Size(43, 22)
        Me.Txt_Tiempo_Inver.TabIndex = 52
        Me.Txt_Tiempo_Inver.Visible = False
        '
        'Txt_Adicional
        '
        Me.Txt_Adicional.AcceptsReturn = True
        Me.Txt_Adicional.Enabled = False
        Me.Txt_Adicional.Location = New System.Drawing.Point(105, 224)
        Me.Txt_Adicional.Multiline = True
        Me.Txt_Adicional.Name = "Txt_Adicional"
        Me.Txt_Adicional.Size = New System.Drawing.Size(226, 52)
        Me.Txt_Adicional.TabIndex = 55
        Me.Txt_Adicional.Visible = False
        '
        'Lbl_Adicional
        '
        Me.Lbl_Adicional.AutoSize = True
        Me.Lbl_Adicional.Location = New System.Drawing.Point(11, 227)
        Me.Lbl_Adicional.Name = "Lbl_Adicional"
        Me.Lbl_Adicional.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_Adicional.TabIndex = 54
        Me.Lbl_Adicional.Text = "Adicional:"
        Me.Lbl_Adicional.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gb_detalle_reparacion)
        Me.GroupBox1.Controls.Add(Me.Cbx_Estado)
        Me.GroupBox1.Controls.Add(Me.Txt_Adicional)
        Me.GroupBox1.Controls.Add(Me.Lbl_Estado)
        Me.GroupBox1.Controls.Add(Me.Lbl_Adicional)
        Me.GroupBox1.Controls.Add(Me.Lbl_Localizacion)
        Me.GroupBox1.Controls.Add(Me.Lbl_Comentario)
        Me.GroupBox1.Controls.Add(Me.Txt_Tiempo_Inver)
        Me.GroupBox1.Controls.Add(Me.Txt_Factura_Num)
        Me.GroupBox1.Controls.Add(Me.Lbl_Factura_Num)
        Me.GroupBox1.Controls.Add(Me.Txt_Comentario)
        Me.GroupBox1.Controls.Add(Me.Lbl_Tiempo_Rep)
        Me.GroupBox1.Controls.Add(Me.Cbx_Localizacion)
        Me.GroupBox1.Controls.Add(Me.Btn_Grabar_Actua)
        Me.GroupBox1.Controls.Add(Me.Gbx_Garantia)
        Me.GroupBox1.Controls.Add(Me.Gbx_Facturada)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 299)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR INFORMACION"
        '
        'gb_detalle_reparacion
        '
        Me.gb_detalle_reparacion.Controls.Add(Me.dg_detalle_rep)
        Me.gb_detalle_reparacion.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_detalle_reparacion.Location = New System.Drawing.Point(0, 0)
        Me.gb_detalle_reparacion.Name = "gb_detalle_reparacion"
        Me.gb_detalle_reparacion.Size = New System.Drawing.Size(561, 299)
        Me.gb_detalle_reparacion.TabIndex = 60
        Me.gb_detalle_reparacion.TabStop = False
        Me.gb_detalle_reparacion.Text = "DETALLE REPARACION"
        Me.gb_detalle_reparacion.Visible = False
        '
        'dg_detalle_rep
        '
        Me.dg_detalle_rep.AllowUserToAddRows = False
        Me.dg_detalle_rep.AllowUserToDeleteRows = False
        Me.dg_detalle_rep.AutoGenerateColumns = False
        Me.dg_detalle_rep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_detalle_rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_detalle_rep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COMENTARIODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.LOCALIZACIONDataGridViewTextBoxColumn})
        Me.dg_detalle_rep.DataSource = Me.SCRCONSULTAREPARACIONBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_detalle_rep.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg_detalle_rep.Location = New System.Drawing.Point(48, 33)
        Me.dg_detalle_rep.Name = "dg_detalle_rep"
        Me.dg_detalle_rep.ReadOnly = True
        Me.dg_detalle_rep.Size = New System.Drawing.Size(459, 243)
        Me.dg_detalle_rep.TabIndex = 60
        '
        'SCRCONSULTAREPARACIONBindingSource
        '
        Me.SCRCONSULTAREPARACIONBindingSource.DataMember = "SCR_CONSULTA_REPARACION"
        Me.SCRCONSULTAREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'dg_reparaciones
        '
        Me.dg_reparaciones.AllowUserToAddRows = False
        Me.dg_reparaciones.AllowUserToDeleteRows = False
        Me.dg_reparaciones.AutoGenerateColumns = False
        Me.dg_reparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_reparaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REPARACIONNUMERODataGridViewTextBoxColumn, Me.ESTADO})
        Me.dg_reparaciones.DataSource = Me.SCRREPSPENDIENTESBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_reparaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_reparaciones.Location = New System.Drawing.Point(23, 56)
        Me.dg_reparaciones.Name = "dg_reparaciones"
        Me.dg_reparaciones.ReadOnly = True
        Me.dg_reparaciones.Size = New System.Drawing.Size(327, 143)
        Me.dg_reparaciones.TabIndex = 57
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "REPARACION"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Width = 114
        '
        'ESTADO
        '
        Me.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 5
        '
        'lb_ingresar_cod_reparacion
        '
        Me.lb_ingresar_cod_reparacion.AutoSize = True
        Me.lb_ingresar_cod_reparacion.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lb_ingresar_cod_reparacion.Location = New System.Drawing.Point(176, 19)
        Me.lb_ingresar_cod_reparacion.Name = "lb_ingresar_cod_reparacion"
        Me.lb_ingresar_cod_reparacion.Size = New System.Drawing.Size(212, 16)
        Me.lb_ingresar_cod_reparacion.TabIndex = 16
        Me.lb_ingresar_cod_reparacion.Text = "REPARACIONES PENDIENTES"
        '
        'SCR_DATOS_REPARACIONTableAdapter
        '
        Me.SCR_DATOS_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'SCR_ESTADO_ACTUATableAdapter
        '
        Me.SCR_ESTADO_ACTUATableAdapter.ClearBeforeFill = True
        '
        'SCR_LOCALIZACION_REPTableAdapter
        '
        Me.SCR_LOCALIZACION_REPTableAdapter.ClearBeforeFill = True
        '
        'SCR_REPS_PENDIENTESTableAdapter
        '
        Me.SCR_REPS_PENDIENTESTableAdapter.ClearBeforeFill = True
        '
        'bt_cerrado_rapido
        '
        Me.bt_cerrado_rapido.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cerrado_rapido.Location = New System.Drawing.Point(383, 117)
        Me.bt_cerrado_rapido.Name = "bt_cerrado_rapido"
        Me.bt_cerrado_rapido.Size = New System.Drawing.Size(142, 29)
        Me.bt_cerrado_rapido.TabIndex = 58
        Me.bt_cerrado_rapido.Text = "CERRADO RÁPIDO!"
        Me.bt_cerrado_rapido.UseVisualStyleBackColor = True
        '
        'SCR_CONSULTA_REPARACIONTableAdapter
        '
        Me.SCR_CONSULTA_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'ch_ver_informacion
        '
        Me.ch_ver_informacion.AutoSize = True
        Me.ch_ver_informacion.Location = New System.Drawing.Point(356, 166)
        Me.ch_ver_informacion.Name = "ch_ver_informacion"
        Me.ch_ver_informacion.Size = New System.Drawing.Size(217, 19)
        Me.ch_ver_informacion.TabIndex = 60
        Me.ch_ver_informacion.Text = "VER INFORMACIÓN ADICIONAL"
        Me.ch_ver_informacion.UseVisualStyleBackColor = True
        '
        'COMENTARIODataGridViewTextBoxColumn
        '
        Me.COMENTARIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.COMENTARIODataGridViewTextBoxColumn.DataPropertyName = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.HeaderText = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.Name = "COMENTARIODataGridViewTextBoxColumn"
        Me.COMENTARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.COMENTARIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COMENTARIODataGridViewTextBoxColumn.Width = 118
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ESTADODataGridViewTextBoxColumn.Width = 83
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FECHADataGridViewTextBoxColumn.Width = 74
        '
        'LOCALIZACIONDataGridViewTextBoxColumn
        '
        Me.LOCALIZACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Name = "LOCALIZACIONDataGridViewTextBoxColumn"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Width = 124
        '
        'Frm_Actualizacion_Rep
        '
        Me.AcceptButton = Me.Btn_Grabar_Actua
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.ch_ver_informacion)
        Me.Controls.Add(Me.bt_cerrado_rapido)
        Me.Controls.Add(Me.lb_ingresar_cod_reparacion)
        Me.Controls.Add(Me.dg_reparaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbx_Articulo_Rep)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Controls.Add(Me.Cbx_Boleta)
        Me.Controls.Add(Me.Lbl_Numero_Boleta)
        Me.Controls.Add(Me.Gbx_Info_Cliente)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(30, 0)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Actualizacion_Rep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizacion de Reparacion"
        CType(Me.SCRREPSPENDIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Info_Cliente.ResumeLayout(False)
        Me.Gbx_Info_Cliente.PerformLayout()
        Me.Gbx_Articulo_Rep.ResumeLayout(False)
        Me.Gbx_Articulo_Rep.PerformLayout()
        CType(Me.SCRESTADOACTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Garantia.ResumeLayout(False)
        Me.Gbx_Garantia.PerformLayout()
        Me.Gbx_Facturada.ResumeLayout(False)
        Me.Gbx_Facturada.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_detalle_reparacion.ResumeLayout(False)
        CType(Me.dg_detalle_rep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_reparaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Numero_Boleta As Label
    Friend WithEvents Lbl_Articulo As Label
    Friend WithEvents Lbl_T_Articulo As Label
    Friend WithEvents Cbx_Boleta As ComboBox
    Friend WithEvents Lbl_Fecha_Hora As Label
    Friend WithEvents Lbl_T_Cliente As Label
    Friend WithEvents Lbl_Cliente As Label
    Friend WithEvents Lbl_T_Nombre_Cliente As Label
    Friend WithEvents Lbl_Nombre_Cliente As Label
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Numero_1 As Label
    Friend WithEvents Lbl_Numero_2 As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_T_Descripcion As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents Lbl_T_Adicio_Art As Label
    Friend WithEvents Lbl_Adicional_Art As Label
    Friend WithEvents Gbx_Info_Cliente As GroupBox
    Friend WithEvents Gbx_Articulo_Rep As GroupBox
    Friend WithEvents Lbl_T_Estado_Art As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl_T_Motivo As Label
    Friend WithEvents Lbl_Estado_Art As Label
    Friend WithEvents Lbl_T_Problema As Label
    Friend WithEvents Lbl_T_Doc_Ref As Label
    Friend WithEvents Lbl_Doc_Ref As Label
    Friend WithEvents Lbl_T_Traido_Por As Label
    Friend WithEvents Lbl_Traido_Por As Label
    Friend WithEvents Lbl_Encargado_Bod As Label
    Friend WithEvents Lbl_T_Encargado_Bod As Label
    Friend WithEvents Lbl_T_Fecha_Ingeso As Label
    Friend WithEvents Lbl_Fecha_Ingreso As Label
    Friend WithEvents Lbl_T_Estado_Rep As Label
    Friend WithEvents Lbl_T_Estado_Boleta As Label
    Friend WithEvents Lbl_ As Label
    Friend WithEvents Lbl_Boleta_Chofer As Label
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRDATOSREPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_DATOS_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter
    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As ExactusERP_TABLESTableAdapters.CLIENTETableAdapter
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents Lbl_Localizacion As Label
    Friend WithEvents Lbl_Comentario As Label
    Friend WithEvents Txt_Comentario As TextBox
    Friend WithEvents Cbx_Estado As ComboBox
    Friend WithEvents Cbx_Localizacion As ComboBox
    Friend WithEvents SCRESTADOACTUABindingSource As BindingSource
    Friend WithEvents SCR_ESTADO_ACTUATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_ACTUATableAdapter
    Friend WithEvents SCRLOCALIZACIONREPBindingSource As BindingSource
    Friend WithEvents SCR_LOCALIZACION_REPTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter
    Friend WithEvents Btn_Grabar_Actua As Button
    Friend WithEvents Lbl_Numero_Serie As Label
    Friend WithEvents Lbl_T_Numero_Serie As Label
    Friend WithEvents Gbx_Garantia As GroupBox
    Friend WithEvents Rbtn_Garan_No As RadioButton
    Friend WithEvents Rbtn_Garan_Si As RadioButton
    Friend WithEvents Gbx_Facturada As GroupBox
    Friend WithEvents Rbtn_Factu_No As RadioButton
    Friend WithEvents Rbtn_Factu_Si As RadioButton
    Friend WithEvents Lbl_Factura_Num As Label
    Friend WithEvents Txt_Factura_Num As TextBox
    Friend WithEvents Lbl_Tiempo_Rep As Label
    Friend WithEvents Txt_Tiempo_Inver As TextBox
    Friend WithEvents Lbl_Horas As Label
    Friend WithEvents Txt_Adicional As TextBox
    Friend WithEvents Lbl_Adicional As Label
    Private WithEvents Lbl_Problema_Reportado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg_reparaciones As DataGridView
    Friend WithEvents lb_ingresar_cod_reparacion As Label
    Friend WithEvents SCRREPSPENDIENTESBindingSource As BindingSource
    Friend WithEvents SCR_REPS_PENDIENTESTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_REPS_PENDIENTESTableAdapter
    Friend WithEvents bt_cerrado_rapido As Button
    Friend WithEvents SCRCONSULTAREPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_CONSULTA_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter
    Friend WithEvents dg_detalle_rep As DataGridView
    Friend WithEvents gb_detalle_reparacion As GroupBox
    Friend WithEvents ch_ver_informacion As CheckBox
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents COMENTARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
