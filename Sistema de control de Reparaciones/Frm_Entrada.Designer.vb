<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Entrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Entrada))
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.Lbl_Codigo_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Cliente_Nombre = New System.Windows.Forms.Label()
        Me.lb_nombre_cliente = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.lb_alias_cliente = New System.Windows.Forms.Label()
        Me.Lbl_Codigo_Art = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion_Art = New System.Windows.Forms.Label()
        Me.lb_descripcion_articulo = New System.Windows.Forms.Label()
        Me.Tbx_Adicional_Art = New System.Windows.Forms.TextBox()
        Me.Lbl_Adicional_Art_1 = New System.Windows.Forms.Label()
        Me.Lbl_Reparacion = New System.Windows.Forms.Label()
        Me.Tbx_Reparacion = New System.Windows.Forms.TextBox()
        Me.Lbl_Estado_Art = New System.Windows.Forms.Label()
        Me.Tbx_Estado_Art = New System.Windows.Forms.TextBox()
        Me.Tbx_Problema_Reportado = New System.Windows.Forms.TextBox()
        Me.Lbl_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Btn_Impresion_Colilla = New System.Windows.Forms.Button()
        Me.Lbl_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_Transporte = New System.Windows.Forms.Label()
        Me.Lbl_Encargado_Bodega = New System.Windows.Forms.Label()
        Me.Lbl_Documento_Referencia = New System.Windows.Forms.Label()
        Me.Tbx_Documento_Referencia = New System.Windows.Forms.TextBox()
        Me.Cbx_Motivo = New System.Windows.Forms.ComboBox()
        Me.SCRMOTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES1 = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Lbl_Fecha_Hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cbx_Traido_Por = New System.Windows.Forms.ComboBox()
        Me.SCRTRAIDOPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbx_Transporte = New System.Windows.Forms.ComboBox()
        Me.TRANSPORTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCRTRANSPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cbx_Encargado_Bodega = New System.Windows.Forms.ComboBox()
        Me.SCRENCARGADOBODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERPSRCTABLES1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_Boleta = New System.Windows.Forms.Label()
        Me.Txt_Boleta = New System.Windows.Forms.TextBox()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.Cbx_Estado = New System.Windows.Forms.ComboBox()
        Me.SCRESTADOINGRESOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_MOTIVOTableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_MOTIVOTableAdapter()
        Me.SCR_ESTADO_INGRESOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_INGRESOTableAdapter()
        Me.SCR_TRAIDO_PORTableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TRAIDO_PORTableAdapter()
        Me.SCR_TRANSPORTETableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TRANSPORTETableAdapter()
        Me.SCR_ENCARGADO_BODEGATableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ENCARGADO_BODEGATableAdapter()
        Me.Lbl_Serie = New System.Windows.Forms.Label()
        Me.Txt_Numero_Serie = New System.Windows.Forms.TextBox()
        Me.Chb_Modificar = New System.Windows.Forms.CheckBox()
        Me.Txt_Cod_Cliente = New System.Windows.Forms.TextBox()
        Me.Txt_Cod_Articulo = New System.Windows.Forms.TextBox()
        Me.Lbl_Boleta_2 = New System.Windows.Forms.Label()
        Me.dg_cliente = New System.Windows.Forms.DataGridView()
        Me.dg_articulo = New System.Windows.Forms.DataGridView()
        Me.rb_nombre = New System.Windows.Forms.RadioButton()
        Me.rb_alias = New System.Windows.Forms.RadioButton()
        Me.bs_clientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_articulo = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_buscar_articulo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_opcional = New System.Windows.Forms.TextBox()
        Me.check_box_opcional = New System.Windows.Forms.CheckBox()
        Me.TRANSPORTESTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.TRANSPORTESTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRMOTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTRAIDOPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSPORTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRENCARGADOBODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERPSRCTABLES1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRESTADOINGRESOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExactusERP_TABLES
        '
        Me.ExactusERP_TABLES.DataSetName = "ExactusERP_TABLES"
        Me.ExactusERP_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Codigo_Cliente
        '
        Me.Lbl_Codigo_Cliente.AutoSize = True
        Me.Lbl_Codigo_Cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Cliente.Location = New System.Drawing.Point(183, 53)
        Me.Lbl_Codigo_Cliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Codigo_Cliente.Name = "Lbl_Codigo_Cliente"
        Me.Lbl_Codigo_Cliente.Size = New System.Drawing.Size(48, 15)
        Me.Lbl_Codigo_Cliente.TabIndex = 2
        Me.Lbl_Codigo_Cliente.Text = "Filtrar:"
        '
        'Lbl_Cliente_Nombre
        '
        Me.Lbl_Cliente_Nombre.AutoSize = True
        Me.Lbl_Cliente_Nombre.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cliente_Nombre.Location = New System.Drawing.Point(447, 95)
        Me.Lbl_Cliente_Nombre.Name = "Lbl_Cliente_Nombre"
        Me.Lbl_Cliente_Nombre.Size = New System.Drawing.Size(57, 15)
        Me.Lbl_Cliente_Nombre.TabIndex = 3
        Me.Lbl_Cliente_Nombre.Text = "Nombre:"
        '
        'lb_nombre_cliente
        '
        Me.lb_nombre_cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_nombre_cliente.Location = New System.Drawing.Point(509, 95)
        Me.lb_nombre_cliente.Name = "lb_nombre_cliente"
        Me.lb_nombre_cliente.Size = New System.Drawing.Size(182, 69)
        Me.lb_nombre_cliente.TabIndex = 4
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alias.Location = New System.Drawing.Point(457, 164)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(42, 15)
        Me.Lbl_Alias.TabIndex = 10
        Me.Lbl_Alias.Text = "Alias:"
        '
        'lb_alias_cliente
        '
        Me.lb_alias_cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alias_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_alias_cliente.Location = New System.Drawing.Point(505, 164)
        Me.lb_alias_cliente.Name = "lb_alias_cliente"
        Me.lb_alias_cliente.Size = New System.Drawing.Size(186, 70)
        Me.lb_alias_cliente.TabIndex = 11
        '
        'Lbl_Codigo_Art
        '
        Me.Lbl_Codigo_Art.AutoSize = True
        Me.Lbl_Codigo_Art.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Art.Location = New System.Drawing.Point(93, 47)
        Me.Lbl_Codigo_Art.Name = "Lbl_Codigo_Art"
        Me.Lbl_Codigo_Art.Size = New System.Drawing.Size(48, 15)
        Me.Lbl_Codigo_Art.TabIndex = 14
        Me.Lbl_Codigo_Art.Text = "Filtrar:"
        '
        'Lbl_Descripcion_Art
        '
        Me.Lbl_Descripcion_Art.AutoSize = True
        Me.Lbl_Descripcion_Art.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descripcion_Art.Location = New System.Drawing.Point(437, 81)
        Me.Lbl_Descripcion_Art.Name = "Lbl_Descripcion_Art"
        Me.Lbl_Descripcion_Art.Size = New System.Drawing.Size(82, 15)
        Me.Lbl_Descripcion_Art.TabIndex = 15
        Me.Lbl_Descripcion_Art.Text = "Descripcion:"
        '
        'lb_descripcion_articulo
        '
        Me.lb_descripcion_articulo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_descripcion_articulo.ForeColor = System.Drawing.Color.Red
        Me.lb_descripcion_articulo.Location = New System.Drawing.Point(520, 81)
        Me.lb_descripcion_articulo.Name = "lb_descripcion_articulo"
        Me.lb_descripcion_articulo.Size = New System.Drawing.Size(169, 56)
        Me.lb_descripcion_articulo.TabIndex = 16
        '
        'Tbx_Adicional_Art
        '
        Me.Tbx_Adicional_Art.Location = New System.Drawing.Point(510, 144)
        Me.Tbx_Adicional_Art.Multiline = True
        Me.Tbx_Adicional_Art.Name = "Tbx_Adicional_Art"
        Me.Tbx_Adicional_Art.Size = New System.Drawing.Size(174, 64)
        Me.Tbx_Adicional_Art.TabIndex = 5
        '
        'Lbl_Adicional_Art_1
        '
        Me.Lbl_Adicional_Art_1.AutoSize = True
        Me.Lbl_Adicional_Art_1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Adicional_Art_1.Location = New System.Drawing.Point(437, 155)
        Me.Lbl_Adicional_Art_1.Name = "Lbl_Adicional_Art_1"
        Me.Lbl_Adicional_Art_1.Size = New System.Drawing.Size(67, 15)
        Me.Lbl_Adicional_Art_1.TabIndex = 18
        Me.Lbl_Adicional_Art_1.Text = "Adicional:"
        '
        'Lbl_Reparacion
        '
        Me.Lbl_Reparacion.AutoSize = True
        Me.Lbl_Reparacion.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Reparacion.Location = New System.Drawing.Point(17, 52)
        Me.Lbl_Reparacion.Name = "Lbl_Reparacion"
        Me.Lbl_Reparacion.Size = New System.Drawing.Size(85, 15)
        Me.Lbl_Reparacion.TabIndex = 20
        Me.Lbl_Reparacion.Text = "Reparacion #"
        '
        'Tbx_Reparacion
        '
        Me.Tbx_Reparacion.Enabled = False
        Me.Tbx_Reparacion.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Reparacion.Location = New System.Drawing.Point(108, 47)
        Me.Tbx_Reparacion.Name = "Tbx_Reparacion"
        Me.Tbx_Reparacion.Size = New System.Drawing.Size(104, 23)
        Me.Tbx_Reparacion.TabIndex = 1000
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.AutoSize = True
        Me.Lbl_Estado_Art.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(60, 317)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(101, 15)
        Me.Lbl_Estado_Art.TabIndex = 23
        Me.Lbl_Estado_Art.Text = "Estado Articulo"
        '
        'Tbx_Estado_Art
        '
        Me.Tbx_Estado_Art.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Estado_Art.Location = New System.Drawing.Point(167, 314)
        Me.Tbx_Estado_Art.Multiline = True
        Me.Tbx_Estado_Art.Name = "Tbx_Estado_Art"
        Me.Tbx_Estado_Art.Size = New System.Drawing.Size(359, 53)
        Me.Tbx_Estado_Art.TabIndex = 15
        '
        'Tbx_Problema_Reportado
        '
        Me.Tbx_Problema_Reportado.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Problema_Reportado.Location = New System.Drawing.Point(167, 385)
        Me.Tbx_Problema_Reportado.Multiline = True
        Me.Tbx_Problema_Reportado.Name = "Tbx_Problema_Reportado"
        Me.Tbx_Problema_Reportado.Size = New System.Drawing.Size(359, 53)
        Me.Tbx_Problema_Reportado.TabIndex = 16
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.AutoSize = True
        Me.Lbl_Problema_Reportado.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(32, 385)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(129, 15)
        Me.Lbl_Problema_Reportado.TabIndex = 26
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.AutoSize = True
        Me.Lbl_Motivo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Motivo.Location = New System.Drawing.Point(256, 232)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(47, 15)
        Me.Lbl_Motivo.TabIndex = 27
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Btn_Impresion_Colilla
        '
        Me.Btn_Impresion_Colilla.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Impresion_Colilla.Location = New System.Drawing.Point(204, 451)
        Me.Btn_Impresion_Colilla.Name = "Btn_Impresion_Colilla"
        Me.Btn_Impresion_Colilla.Size = New System.Drawing.Size(215, 47)
        Me.Btn_Impresion_Colilla.TabIndex = 17
        Me.Btn_Impresion_Colilla.Text = "GUARDAR!"
        Me.Btn_Impresion_Colilla.UseVisualStyleBackColor = True
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.AutoSize = True
        Me.Lbl_Traido_Por.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(244, 99)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_Traido_Por.TabIndex = 33
        Me.Lbl_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_Transporte
        '
        Me.Lbl_Transporte.AutoSize = True
        Me.Lbl_Transporte.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Transporte.Location = New System.Drawing.Point(245, 186)
        Me.Lbl_Transporte.Name = "Lbl_Transporte"
        Me.Lbl_Transporte.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_Transporte.TabIndex = 35
        Me.Lbl_Transporte.Text = "Transporte"
        '
        'Lbl_Encargado_Bodega
        '
        Me.Lbl_Encargado_Bodega.AutoSize = True
        Me.Lbl_Encargado_Bodega.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Encargado_Bodega.Location = New System.Drawing.Point(244, 266)
        Me.Lbl_Encargado_Bodega.Name = "Lbl_Encargado_Bodega"
        Me.Lbl_Encargado_Bodega.Size = New System.Drawing.Size(69, 30)
        Me.Lbl_Encargado_Bodega.TabIndex = 37
        Me.Lbl_Encargado_Bodega.Text = "Encargado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Bodega"
        '
        'Lbl_Documento_Referencia
        '
        Me.Lbl_Documento_Referencia.AutoSize = True
        Me.Lbl_Documento_Referencia.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Documento_Referencia.Location = New System.Drawing.Point(244, 47)
        Me.Lbl_Documento_Referencia.Name = "Lbl_Documento_Referencia"
        Me.Lbl_Documento_Referencia.Size = New System.Drawing.Size(144, 30)
        Me.Lbl_Documento_Referencia.TabIndex = 39
        Me.Lbl_Documento_Referencia.Text = "Documento Referencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Factura Cliente Final"""
        '
        'Tbx_Documento_Referencia
        '
        Me.Tbx_Documento_Referencia.Location = New System.Drawing.Point(398, 51)
        Me.Tbx_Documento_Referencia.Name = "Tbx_Documento_Referencia"
        Me.Tbx_Documento_Referencia.Size = New System.Drawing.Size(125, 22)
        Me.Tbx_Documento_Referencia.TabIndex = 8
        '
        'Cbx_Motivo
        '
        Me.Cbx_Motivo.DataSource = Me.SCRMOTIVOBindingSource
        Me.Cbx_Motivo.DisplayMember = "MOTIVO"
        Me.Cbx_Motivo.DropDownWidth = 290
        Me.Cbx_Motivo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Motivo.FormattingEnabled = True
        Me.Cbx_Motivo.Location = New System.Drawing.Point(336, 229)
        Me.Cbx_Motivo.Name = "Cbx_Motivo"
        Me.Cbx_Motivo.Size = New System.Drawing.Size(190, 23)
        Me.Cbx_Motivo.TabIndex = 13
        '
        'SCRMOTIVOBindingSource
        '
        Me.SCRMOTIVOBindingSource.DataMember = "SCR_MOTIVO"
        Me.SCRMOTIVOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'ExactusERP_SRC_TABLES1
        '
        Me.ExactusERP_SRC_TABLES1.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Fecha_Hora
        '
        Me.Lbl_Fecha_Hora.AutoSize = True
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(1121, 9)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(76, 15)
        Me.Lbl_Fecha_Hora.TabIndex = 42
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Timer1
        '
        '
        'Cbx_Traido_Por
        '
        Me.Cbx_Traido_Por.DataSource = Me.SCRTRAIDOPORBindingSource
        Me.Cbx_Traido_Por.DisplayMember = "TRAIDO_POR"
        Me.Cbx_Traido_Por.DropDownWidth = 320
        Me.Cbx_Traido_Por.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Traido_Por.FormattingEnabled = True
        Me.Cbx_Traido_Por.Location = New System.Drawing.Point(335, 96)
        Me.Cbx_Traido_Por.Name = "Cbx_Traido_Por"
        Me.Cbx_Traido_Por.Size = New System.Drawing.Size(192, 23)
        Me.Cbx_Traido_Por.TabIndex = 9
        '
        'SCRTRAIDOPORBindingSource
        '
        Me.SCRTRAIDOPORBindingSource.DataMember = "SCR_TRAIDO_POR"
        Me.SCRTRAIDOPORBindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'Cbx_Transporte
        '
        Me.Cbx_Transporte.DataSource = Me.TRANSPORTESBindingSource
        Me.Cbx_Transporte.DisplayMember = "TRANSPORTE"
        Me.Cbx_Transporte.DropDownHeight = 120
        Me.Cbx_Transporte.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Transporte.FormattingEnabled = True
        Me.Cbx_Transporte.IntegralHeight = False
        Me.Cbx_Transporte.Location = New System.Drawing.Point(333, 183)
        Me.Cbx_Transporte.Name = "Cbx_Transporte"
        Me.Cbx_Transporte.Size = New System.Drawing.Size(190, 23)
        Me.Cbx_Transporte.TabIndex = 12
        Me.Cbx_Transporte.ValueMember = "TRANSPORTE"
        '
        'TRANSPORTESBindingSource
        '
        Me.TRANSPORTESBindingSource.DataMember = "TRANSPORTES"
        Me.TRANSPORTESBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'SCRTRANSPORTEBindingSource
        '
        Me.SCRTRANSPORTEBindingSource.DataMember = "SCR_TRANSPORTE"
        Me.SCRTRANSPORTEBindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'Cbx_Encargado_Bodega
        '
        Me.Cbx_Encargado_Bodega.DataSource = Me.SCRENCARGADOBODEGABindingSource
        Me.Cbx_Encargado_Bodega.DisplayMember = "ENCARGADO"
        Me.Cbx_Encargado_Bodega.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Encargado_Bodega.FormattingEnabled = True
        Me.Cbx_Encargado_Bodega.Location = New System.Drawing.Point(336, 273)
        Me.Cbx_Encargado_Bodega.Name = "Cbx_Encargado_Bodega"
        Me.Cbx_Encargado_Bodega.Size = New System.Drawing.Size(191, 23)
        Me.Cbx_Encargado_Bodega.TabIndex = 14
        '
        'SCRENCARGADOBODEGABindingSource
        '
        Me.SCRENCARGADOBODEGABindingSource.DataMember = "SCR_ENCARGADO_BODEGA"
        Me.SCRENCARGADOBODEGABindingSource.DataSource = Me.ExactusERPSRCTABLES1BindingSource
        '
        'ExactusERPSRCTABLES1BindingSource
        '
        Me.ExactusERPSRCTABLES1BindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        Me.ExactusERPSRCTABLES1BindingSource.Position = 0
        '
        'Lbl_Boleta
        '
        Me.Lbl_Boleta.AutoSize = True
        Me.Lbl_Boleta.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Boleta.Location = New System.Drawing.Point(17, 105)
        Me.Lbl_Boleta.Name = "Lbl_Boleta"
        Me.Lbl_Boleta.Size = New System.Drawing.Size(61, 15)
        Me.Lbl_Boleta.TabIndex = 46
        Me.Lbl_Boleta.Text = "Boleta  #"
        '
        'Txt_Boleta
        '
        Me.Txt_Boleta.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Boleta.Location = New System.Drawing.Point(85, 102)
        Me.Txt_Boleta.Name = "Txt_Boleta"
        Me.Txt_Boleta.Size = New System.Drawing.Size(127, 23)
        Me.Txt_Boleta.TabIndex = 6
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Enabled = False
        Me.Lbl_Estado.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Estado.Location = New System.Drawing.Point(2, 467)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(52, 15)
        Me.Lbl_Estado.TabIndex = 48
        Me.Lbl_Estado.Text = "Estado:"
        Me.Lbl_Estado.Visible = False
        '
        'Cbx_Estado
        '
        Me.Cbx_Estado.DataSource = Me.SCRESTADOINGRESOBindingSource
        Me.Cbx_Estado.DisplayMember = "ESTADO"
        Me.Cbx_Estado.Enabled = False
        Me.Cbx_Estado.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Estado.FormattingEnabled = True
        Me.Cbx_Estado.Location = New System.Drawing.Point(41, 484)
        Me.Cbx_Estado.Name = "Cbx_Estado"
        Me.Cbx_Estado.Size = New System.Drawing.Size(74, 23)
        Me.Cbx_Estado.TabIndex = 49
        Me.Cbx_Estado.Visible = False
        '
        'SCRESTADOINGRESOBindingSource
        '
        Me.SCRESTADOINGRESOBindingSource.DataMember = "SCR_ESTADO_INGRESO"
        Me.SCRESTADOINGRESOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'SCR_MOTIVOTableAdapter1
        '
        Me.SCR_MOTIVOTableAdapter1.ClearBeforeFill = True
        '
        'SCR_ESTADO_INGRESOTableAdapter
        '
        Me.SCR_ESTADO_INGRESOTableAdapter.ClearBeforeFill = True
        '
        'SCR_TRAIDO_PORTableAdapter1
        '
        Me.SCR_TRAIDO_PORTableAdapter1.ClearBeforeFill = True
        '
        'SCR_TRANSPORTETableAdapter1
        '
        Me.SCR_TRANSPORTETableAdapter1.ClearBeforeFill = True
        '
        'SCR_ENCARGADO_BODEGATableAdapter1
        '
        Me.SCR_ENCARGADO_BODEGATableAdapter1.ClearBeforeFill = True
        '
        'Lbl_Serie
        '
        Me.Lbl_Serie.AutoSize = True
        Me.Lbl_Serie.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Serie.Location = New System.Drawing.Point(17, 158)
        Me.Lbl_Serie.Name = "Lbl_Serie"
        Me.Lbl_Serie.Size = New System.Drawing.Size(49, 15)
        Me.Lbl_Serie.TabIndex = 50
        Me.Lbl_Serie.Text = "Serie #"
        '
        'Txt_Numero_Serie
        '
        Me.Txt_Numero_Serie.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero_Serie.Location = New System.Drawing.Point(85, 155)
        Me.Txt_Numero_Serie.Name = "Txt_Numero_Serie"
        Me.Txt_Numero_Serie.Size = New System.Drawing.Size(127, 23)
        Me.Txt_Numero_Serie.TabIndex = 7
        Me.Txt_Numero_Serie.Text = "N/A"
        '
        'Chb_Modificar
        '
        Me.Chb_Modificar.AutoSize = True
        Me.Chb_Modificar.Location = New System.Drawing.Point(20, 484)
        Me.Chb_Modificar.Name = "Chb_Modificar"
        Me.Chb_Modificar.Size = New System.Drawing.Size(15, 14)
        Me.Chb_Modificar.TabIndex = 55
        Me.Chb_Modificar.UseVisualStyleBackColor = True
        Me.Chb_Modificar.Visible = False
        '
        'Txt_Cod_Cliente
        '
        Me.Txt_Cod_Cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Cliente.Location = New System.Drawing.Point(244, 50)
        Me.Txt_Cod_Cliente.Name = "Txt_Cod_Cliente"
        Me.Txt_Cod_Cliente.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Cod_Cliente.TabIndex = 0
        '
        'Txt_Cod_Articulo
        '
        Me.Txt_Cod_Articulo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Articulo.Location = New System.Drawing.Point(156, 44)
        Me.Txt_Cod_Articulo.Name = "Txt_Cod_Articulo"
        Me.Txt_Cod_Articulo.Size = New System.Drawing.Size(185, 23)
        Me.Txt_Cod_Articulo.TabIndex = 2
        '
        'Lbl_Boleta_2
        '
        Me.Lbl_Boleta_2.AutoSize = True
        Me.Lbl_Boleta_2.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Boleta_2.Location = New System.Drawing.Point(18, 117)
        Me.Lbl_Boleta_2.Name = "Lbl_Boleta_2"
        Me.Lbl_Boleta_2.Size = New System.Drawing.Size(40, 15)
        Me.Lbl_Boleta_2.TabIndex = 46
        Me.Lbl_Boleta_2.Text = "verde"
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
        'dg_articulo
        '
        Me.dg_articulo.AllowUserToAddRows = False
        Me.dg_articulo.AllowUserToDeleteRows = False
        Me.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulo.Location = New System.Drawing.Point(12, 81)
        Me.dg_articulo.Name = "dg_articulo"
        Me.dg_articulo.ReadOnly = True
        Me.dg_articulo.Size = New System.Drawing.Size(419, 135)
        Me.dg_articulo.TabIndex = 4
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nombre.Location = New System.Drawing.Point(23, 51)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(71, 19)
        Me.rb_nombre.TabIndex = 62
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'rb_alias
        '
        Me.rb_alias.AutoSize = True
        Me.rb_alias.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_alias.Location = New System.Drawing.Point(98, 51)
        Me.rb_alias.Name = "rb_alias"
        Me.rb_alias.Size = New System.Drawing.Size(56, 19)
        Me.rb_alias.TabIndex = 63
        Me.rb_alias.Text = "Alias"
        Me.rb_alias.UseVisualStyleBackColor = True
        '
        'bt_buscar_articulo
        '
        Me.bt_buscar_articulo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar_articulo.Location = New System.Drawing.Point(356, 44)
        Me.bt_buscar_articulo.Name = "bt_buscar_articulo"
        Me.bt_buscar_articulo.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar_articulo.TabIndex = 3
        Me.bt_buscar_articulo.Text = "Buscar"
        Me.bt_buscar_articulo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Opcional"
        '
        'txt_opcional
        '
        Me.txt_opcional.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_opcional.Location = New System.Drawing.Point(335, 139)
        Me.txt_opcional.Name = "txt_opcional"
        Me.txt_opcional.Size = New System.Drawing.Size(192, 23)
        Me.txt_opcional.TabIndex = 11
        '
        'check_box_opcional
        '
        Me.check_box_opcional.AutoSize = True
        Me.check_box_opcional.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_box_opcional.Location = New System.Drawing.Point(247, 141)
        Me.check_box_opcional.Name = "check_box_opcional"
        Me.check_box_opcional.Size = New System.Drawing.Size(82, 19)
        Me.check_box_opcional.TabIndex = 10
        Me.check_box_opcional.Text = "Opcional:"
        Me.check_box_opcional.UseVisualStyleBackColor = True
        '
        'TRANSPORTESTableAdapter
        '
        Me.TRANSPORTESTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_cliente)
        Me.GroupBox2.Controls.Add(Me.Txt_Cod_Cliente)
        Me.GroupBox2.Controls.Add(Me.Lbl_Cliente_Nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Codigo_Cliente)
        Me.GroupBox2.Controls.Add(Me.lb_nombre_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Alias)
        Me.GroupBox2.Controls.Add(Me.lb_alias_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_alias)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(697, 268)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACIÓN DEL CLIENTE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Cod_Articulo)
        Me.GroupBox3.Controls.Add(Me.Lbl_Codigo_Art)
        Me.GroupBox3.Controls.Add(Me.Lbl_Descripcion_Art)
        Me.GroupBox3.Controls.Add(Me.lb_descripcion_articulo)
        Me.GroupBox3.Controls.Add(Me.Lbl_Adicional_Art_1)
        Me.GroupBox3.Controls.Add(Me.dg_articulo)
        Me.GroupBox3.Controls.Add(Me.bt_buscar_articulo)
        Me.GroupBox3.Controls.Add(Me.Tbx_Adicional_Art)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(697, 233)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN DEL ARTÍCULO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tbx_Estado_Art)
        Me.GroupBox1.Controls.Add(Me.Lbl_Boleta_2)
        Me.GroupBox1.Controls.Add(Me.Lbl_Reparacion)
        Me.GroupBox1.Controls.Add(Me.check_box_opcional)
        Me.GroupBox1.Controls.Add(Me.Tbx_Reparacion)
        Me.GroupBox1.Controls.Add(Me.txt_opcional)
        Me.GroupBox1.Controls.Add(Me.Lbl_Estado_Art)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Tbx_Problema_Reportado)
        Me.GroupBox1.Controls.Add(Me.Chb_Modificar)
        Me.GroupBox1.Controls.Add(Me.Lbl_Problema_Reportado)
        Me.GroupBox1.Controls.Add(Me.Txt_Numero_Serie)
        Me.GroupBox1.Controls.Add(Me.Lbl_Motivo)
        Me.GroupBox1.Controls.Add(Me.Lbl_Serie)
        Me.GroupBox1.Controls.Add(Me.Btn_Impresion_Colilla)
        Me.GroupBox1.Controls.Add(Me.Cbx_Estado)
        Me.GroupBox1.Controls.Add(Me.Lbl_Traido_Por)
        Me.GroupBox1.Controls.Add(Me.Lbl_Estado)
        Me.GroupBox1.Controls.Add(Me.Lbl_Transporte)
        Me.GroupBox1.Controls.Add(Me.Txt_Boleta)
        Me.GroupBox1.Controls.Add(Me.Lbl_Encargado_Bodega)
        Me.GroupBox1.Controls.Add(Me.Lbl_Boleta)
        Me.GroupBox1.Controls.Add(Me.Lbl_Documento_Referencia)
        Me.GroupBox1.Controls.Add(Me.Cbx_Encargado_Bodega)
        Me.GroupBox1.Controls.Add(Me.Tbx_Documento_Referencia)
        Me.GroupBox1.Controls.Add(Me.Cbx_Transporte)
        Me.GroupBox1.Controls.Add(Me.Cbx_Motivo)
        Me.GroupBox1.Controls.Add(Me.Cbx_Traido_Por)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(722, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 513)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN SOBRE LA REPARACIÓN"
        '
        'Frm_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(30, 0)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Datos"
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRMOTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTRAIDOPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSPORTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRENCARGADOBODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERPSRCTABLES1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRESTADOINGRESOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Codigo_Cliente As Label
    Friend WithEvents Lbl_Cliente_Nombre As Label
    Friend WithEvents lb_nombre_cliente As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents lb_alias_cliente As Label
    Friend WithEvents Lbl_Codigo_Art As Label
    Friend WithEvents Lbl_Descripcion_Art As Label
    Friend WithEvents lb_descripcion_articulo As Label
    Friend WithEvents Tbx_Adicional_Art As TextBox
    Friend WithEvents Lbl_Adicional_Art_1 As Label
    Friend WithEvents Lbl_Reparacion As Label
    Friend WithEvents Tbx_Reparacion As TextBox
    Friend WithEvents Lbl_Estado_Art As Label
    Friend WithEvents Tbx_Estado_Art As TextBox
    Friend WithEvents Tbx_Problema_Reportado As TextBox
    Friend WithEvents Lbl_Problema_Reportado As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Btn_Impresion_Colilla As Button
    Friend WithEvents Lbl_Traido_Por As Label
    Friend WithEvents Lbl_Transporte As Label
    Friend WithEvents Lbl_Encargado_Bodega As Label
    Friend WithEvents Lbl_Documento_Referencia As Label
    Friend WithEvents Tbx_Documento_Referencia As TextBox
    Friend WithEvents Cbx_Motivo As ComboBox
    Friend WithEvents Lbl_Fecha_Hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cbx_Traido_Por As ComboBox
    Friend WithEvents Cbx_Transporte As ComboBox
    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCR_MOTIVOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_MOTIVOTableAdapter
    Friend WithEvents SCR_TRAIDO_PORTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TRAIDO_PORTableAdapter
    Friend WithEvents SCR_TRANSPORTETableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TRANSPORTETableAdapter
    Friend WithEvents Cbx_Encargado_Bodega As ComboBox
    Friend WithEvents SCR_ENCARGADO_BODEGATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ENCARGADO_BODEGATableAdapter
    Friend WithEvents Lbl_Boleta As Label
    Friend WithEvents Txt_Boleta As TextBox
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents Cbx_Estado As ComboBox
    Friend WithEvents ExactusERP_SRC_TABLES1 As ExactusERP_SRC_TABLES
    Friend WithEvents SCRMOTIVOBindingSource As BindingSource
    Friend WithEvents SCR_MOTIVOTableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_MOTIVOTableAdapter
    Friend WithEvents SCRESTADOINGRESOBindingSource As BindingSource
    Friend WithEvents SCR_ESTADO_INGRESOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_INGRESOTableAdapter
    Friend WithEvents SCRTRAIDOPORBindingSource As BindingSource
    Friend WithEvents SCR_TRAIDO_PORTableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_TRAIDO_PORTableAdapter
    Friend WithEvents SCRTRANSPORTEBindingSource As BindingSource
    Friend WithEvents SCR_TRANSPORTETableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_TRANSPORTETableAdapter
    Friend WithEvents ExactusERPSRCTABLES1BindingSource As BindingSource
    Friend WithEvents SCRENCARGADOBODEGABindingSource As BindingSource
    Friend WithEvents SCR_ENCARGADO_BODEGATableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_ENCARGADO_BODEGATableAdapter
    Friend WithEvents Lbl_Serie As Label
    Friend WithEvents Txt_Numero_Serie As TextBox
    Friend WithEvents Chb_Modificar As CheckBox
    Friend WithEvents Txt_Cod_Cliente As TextBox
    Friend WithEvents Txt_Cod_Articulo As TextBox
    Friend WithEvents Lbl_Boleta_2 As Label
    Friend WithEvents dg_cliente As DataGridView
    Friend WithEvents dg_articulo As DataGridView
    Friend WithEvents rb_nombre As RadioButton
    Friend WithEvents rb_alias As RadioButton
    Friend WithEvents bs_clientes As BindingSource
    Friend WithEvents bs_articulo As BindingSource
    Friend WithEvents bt_buscar_articulo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_opcional As TextBox
    Friend WithEvents check_box_opcional As CheckBox
    Friend WithEvents TRANSPORTESBindingSource As BindingSource
    Friend WithEvents TRANSPORTESTableAdapter As ExactusERP_TABLESTableAdapters.TRANSPORTESTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
