<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Actualizacion_Boleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Actualizacion_Boleta))
        Me.Lbl_Numero_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_Articulo = New System.Windows.Forms.Label()
        Me.SCRDATOSREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Lbl_T_Articulo = New System.Windows.Forms.Label()
        Me.Cbx_Boleta = New System.Windows.Forms.ComboBox()
        Me.Lbl_Fecha_Hora = New System.Windows.Forms.Label()
        Me.Lbl_T_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.Cbx_dummy1 = New System.Windows.Forms.ComboBox()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Numero_1 = New System.Windows.Forms.Label()
        Me.Lbl_Numero_2 = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_T_Fax = New System.Windows.Forms.Label()
        Me.Lbl_Fax = New System.Windows.Forms.Label()
        Me.Cbx_Dummy2 = New System.Windows.Forms.ComboBox()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_T_Descripcion = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        Me.Lbl_T_Adicio_Art = New System.Windows.Forms.Label()
        Me.Lbl_Adicional_Art = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Boleta_Chofer = New System.Windows.Forms.Label()
        Me.Lbl_ = New System.Windows.Forms.Label()
        Me.Lbl_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Rep = New System.Windows.Forms.Label()
        Me.Lbl_T_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_T_Fecha_Ingeso = New System.Windows.Forms.Label()
        Me.Lbl_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_Usuario_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_T_Usuario_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_T_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_T_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_T_Problema = New System.Windows.Forms.Label()
        Me.Lbl_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Motivo = New System.Windows.Forms.Label()
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.Lbl_Localizacion = New System.Windows.Forms.Label()
        Me.Lbl_Comentario = New System.Windows.Forms.Label()
        Me.Txt_Comentario = New System.Windows.Forms.TextBox()
        Me.Cbx_Estado = New System.Windows.Forms.ComboBox()
        Me.Cbx_Localizacion = New System.Windows.Forms.ComboBox()
        Me.SCRESTADOACTUABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ESTADO_ACTUATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_ACTUATableAdapter()
        Me.SCRLOCALIZACIONREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_LOCALIZACION_REPTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter()
        Me.Btn_Grabar_Actua = New System.Windows.Forms.Button()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SCRESTADOACTUABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Numero_Boleta
        '
        Me.Lbl_Numero_Boleta.AutoSize = True
        Me.Lbl_Numero_Boleta.Location = New System.Drawing.Point(1219, 9)
        Me.Lbl_Numero_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Numero_Boleta.Name = "Lbl_Numero_Boleta"
        Me.Lbl_Numero_Boleta.Size = New System.Drawing.Size(85, 15)
        Me.Lbl_Numero_Boleta.TabIndex = 0
        Me.Lbl_Numero_Boleta.Text = "Reparacion #"
        '
        'Lbl_Articulo
        '
        Me.Lbl_Articulo.AutoSize = True
        Me.Lbl_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_ART", True))
        Me.Lbl_Articulo.Location = New System.Drawing.Point(67, 26)
        Me.Lbl_Articulo.Name = "Lbl_Articulo"
        Me.Lbl_Articulo.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_Articulo.TabIndex = 2
        Me.Lbl_Articulo.Text = "BI0000-000"
        '
        'SCRDATOSREPARACIONBindingSource
        '
        Me.SCRDATOSREPARACIONBindingSource.DataMember = "SCR_DATOS_REPARACION"
        Me.SCRDATOSREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_T_Articulo
        '
        Me.Lbl_T_Articulo.AutoSize = True
        Me.Lbl_T_Articulo.Location = New System.Drawing.Point(6, 26)
        Me.Lbl_T_Articulo.Name = "Lbl_T_Articulo"
        Me.Lbl_T_Articulo.Size = New System.Drawing.Size(60, 15)
        Me.Lbl_T_Articulo.TabIndex = 3
        Me.Lbl_T_Articulo.Text = "Articulo:"
        '
        'Cbx_Boleta
        '
        Me.Cbx_Boleta.DataSource = Me.SCRDATOSREPARACIONBindingSource
        Me.Cbx_Boleta.DisplayMember = "REPARACION_NUMERO"
        Me.Cbx_Boleta.Enabled = False
        Me.Cbx_Boleta.FormattingEnabled = True
        Me.Cbx_Boleta.Location = New System.Drawing.Point(1307, 6)
        Me.Cbx_Boleta.Name = "Cbx_Boleta"
        Me.Cbx_Boleta.Size = New System.Drawing.Size(119, 23)
        Me.Cbx_Boleta.TabIndex = 4
        '
        'Lbl_Fecha_Hora
        '
        Me.Lbl_Fecha_Hora.AutoSize = True
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(1278, 32)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(76, 15)
        Me.Lbl_Fecha_Hora.TabIndex = 5
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Lbl_T_Cliente
        '
        Me.Lbl_T_Cliente.AutoSize = True
        Me.Lbl_T_Cliente.Location = New System.Drawing.Point(3, 26)
        Me.Lbl_T_Cliente.Name = "Lbl_T_Cliente"
        Me.Lbl_T_Cliente.Size = New System.Drawing.Size(54, 15)
        Me.Lbl_T_Cliente.TabIndex = 6
        Me.Lbl_T_Cliente.Text = "Cliente:"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_CLIENTE", True))
        Me.Lbl_Cliente.Location = New System.Drawing.Point(59, 26)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(97, 15)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Codigo_Cliente"
        '
        'Lbl_T_Nombre_Cliente
        '
        Me.Lbl_T_Nombre_Cliente.AutoSize = True
        Me.Lbl_T_Nombre_Cliente.Location = New System.Drawing.Point(148, 26)
        Me.Lbl_T_Nombre_Cliente.Name = "Lbl_T_Nombre_Cliente"
        Me.Lbl_T_Nombre_Cliente.Size = New System.Drawing.Size(57, 15)
        Me.Lbl_T_Nombre_Cliente.TabIndex = 8
        Me.Lbl_T_Nombre_Cliente.Text = "Nombre:"
        '
        'Lbl_Nombre_Cliente
        '
        Me.Lbl_Nombre_Cliente.AutoSize = True
        Me.Lbl_Nombre_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre_Cliente.Location = New System.Drawing.Point(209, 26)
        Me.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente"
        Me.Lbl_Nombre_Cliente.Size = New System.Drawing.Size(102, 15)
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
        'Cbx_dummy1
        '
        Me.Cbx_dummy1.DataSource = Me.CLIENTEBindingSource
        Me.Cbx_dummy1.DisplayMember = "CLIENTE"
        Me.Cbx_dummy1.FormattingEnabled = True
        Me.Cbx_dummy1.Location = New System.Drawing.Point(29, 6)
        Me.Cbx_dummy1.Name = "Cbx_dummy1"
        Me.Cbx_dummy1.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_dummy1.TabIndex = 10
        Me.Cbx_dummy1.Visible = False
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(8, 50)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(61, 15)
        Me.Lbl_Telefono.TabIndex = 11
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Lbl_Numero_1
        '
        Me.Lbl_Numero_1.AutoSize = True
        Me.Lbl_Numero_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Lbl_Numero_1.Location = New System.Drawing.Point(65, 50)
        Me.Lbl_Numero_1.Name = "Lbl_Numero_1"
        Me.Lbl_Numero_1.Size = New System.Drawing.Size(64, 15)
        Me.Lbl_Numero_1.TabIndex = 12
        Me.Lbl_Numero_1.Text = "Numero 1"
        '
        'Lbl_Numero_2
        '
        Me.Lbl_Numero_2.AutoSize = True
        Me.Lbl_Numero_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Lbl_Numero_2.Location = New System.Drawing.Point(132, 50)
        Me.Lbl_Numero_2.Name = "Lbl_Numero_2"
        Me.Lbl_Numero_2.Size = New System.Drawing.Size(64, 15)
        Me.Lbl_Numero_2.TabIndex = 13
        Me.Lbl_Numero_2.Text = "Numero 2"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(10, 74)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(42, 15)
        Me.Lbl_T_Alias.TabIndex = 14
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Location = New System.Drawing.Point(49, 74)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(38, 15)
        Me.Lbl_Alias.TabIndex = 15
        Me.Lbl_Alias.Text = "Alias"
        '
        'Lbl_T_Fax
        '
        Me.Lbl_T_Fax.AutoSize = True
        Me.Lbl_T_Fax.Location = New System.Drawing.Point(209, 50)
        Me.Lbl_T_Fax.Name = "Lbl_T_Fax"
        Me.Lbl_T_Fax.Size = New System.Drawing.Size(32, 15)
        Me.Lbl_T_Fax.TabIndex = 16
        Me.Lbl_T_Fax.Text = "Fax:"
        '
        'Lbl_Fax
        '
        Me.Lbl_Fax.AutoSize = True
        Me.Lbl_Fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "FAX", True))
        Me.Lbl_Fax.Location = New System.Drawing.Point(237, 50)
        Me.Lbl_Fax.Name = "Lbl_Fax"
        Me.Lbl_Fax.Size = New System.Drawing.Size(28, 15)
        Me.Lbl_Fax.TabIndex = 17
        Me.Lbl_Fax.Text = "Fax"
        '
        'Cbx_Dummy2
        '
        Me.Cbx_Dummy2.DataSource = Me.ARTICULOBindingSource
        Me.Cbx_Dummy2.DisplayMember = "ARTICULO"
        Me.Cbx_Dummy2.FormattingEnabled = True
        Me.Cbx_Dummy2.Location = New System.Drawing.Point(157, 7)
        Me.Cbx_Dummy2.Name = "Cbx_Dummy2"
        Me.Cbx_Dummy2.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_Dummy2.TabIndex = 18
        Me.Cbx_Dummy2.Visible = False
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'Lbl_T_Descripcion
        '
        Me.Lbl_T_Descripcion.AutoSize = True
        Me.Lbl_T_Descripcion.Location = New System.Drawing.Point(152, 26)
        Me.Lbl_T_Descripcion.Name = "Lbl_T_Descripcion"
        Me.Lbl_T_Descripcion.Size = New System.Drawing.Size(82, 15)
        Me.Lbl_T_Descripcion.TabIndex = 19
        Me.Lbl_T_Descripcion.Text = "Descripcion:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOBindingSource, "DESCRIPCION", True))
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(231, 26)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(78, 15)
        Me.Lbl_Descripcion.TabIndex = 20
        Me.Lbl_Descripcion.Text = "Descripcion"
        '
        'Lbl_T_Adicio_Art
        '
        Me.Lbl_T_Adicio_Art.AutoSize = True
        Me.Lbl_T_Adicio_Art.Location = New System.Drawing.Point(6, 50)
        Me.Lbl_T_Adicio_Art.Name = "Lbl_T_Adicio_Art"
        Me.Lbl_T_Adicio_Art.Size = New System.Drawing.Size(67, 15)
        Me.Lbl_T_Adicio_Art.TabIndex = 21
        Me.Lbl_T_Adicio_Art.Text = "Adicional:"
        '
        'Lbl_Adicional_Art
        '
        Me.Lbl_Adicional_Art.AutoSize = True
        Me.Lbl_Adicional_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ADICIONAL_ART", True))
        Me.Lbl_Adicional_Art.Location = New System.Drawing.Point(74, 50)
        Me.Lbl_Adicional_Art.Name = "Lbl_Adicional_Art"
        Me.Lbl_Adicional_Art.Size = New System.Drawing.Size(63, 15)
        Me.Lbl_Adicional_Art.TabIndex = 22
        Me.Lbl_Adicional_Art.Text = "Adicional"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_Nombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_Fax)
        Me.GroupBox1.Controls.Add(Me.Lbl_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Fax)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Nombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Telefono)
        Me.GroupBox1.Controls.Add(Me.Lbl_Numero_2)
        Me.GroupBox1.Controls.Add(Me.Lbl_Numero_1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 171)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION CLIENTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_Boleta_Chofer)
        Me.GroupBox2.Controls.Add(Me.Lbl_)
        Me.GroupBox2.Controls.Add(Me.Lbl_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Boleta)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Articulo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Rep)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Adicional_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Fecha_Ingeso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Doc_Ref)
        Me.GroupBox2.Controls.Add(Me.Lbl_Usuario_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Articulo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Usuario_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Doc_Ref)
        Me.GroupBox2.Controls.Add(Me.Lbl_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Adicio_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_Problema_Reportado)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Problema)
        Me.GroupBox2.Controls.Add(Me.Lbl_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_Motivo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Motivo)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 171)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFOMRACION ARTICULO Y REPARACION"
        '
        'Lbl_Boleta_Chofer
        '
        Me.Lbl_Boleta_Chofer.AutoSize = True
        Me.Lbl_Boleta_Chofer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "BOLETA", True))
        Me.Lbl_Boleta_Chofer.Location = New System.Drawing.Point(763, 132)
        Me.Lbl_Boleta_Chofer.Name = "Lbl_Boleta_Chofer"
        Me.Lbl_Boleta_Chofer.Size = New System.Drawing.Size(89, 15)
        Me.Lbl_Boleta_Chofer.TabIndex = 35
        Me.Lbl_Boleta_Chofer.Text = "Boleta Chofer"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(665, 132)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(93, 15)
        Me.Lbl_.TabIndex = 33
        Me.Lbl_.Text = "Boleta Chofer:"
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.AutoSize = True
        Me.Lbl_Traido_Por.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "TRAIDO_POR", True))
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(320, 114)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(69, 15)
        Me.Lbl_Traido_Por.TabIndex = 34
        Me.Lbl_Traido_Por.Text = "Traido Por"
        '
        'Lbl_T_Estado_Boleta
        '
        Me.Lbl_T_Estado_Boleta.AutoSize = True
        Me.Lbl_T_Estado_Boleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO", True))
        Me.Lbl_T_Estado_Boleta.Location = New System.Drawing.Point(560, 132)
        Me.Lbl_T_Estado_Boleta.Name = "Lbl_T_Estado_Boleta"
        Me.Lbl_T_Estado_Boleta.Size = New System.Drawing.Size(72, 15)
        Me.Lbl_T_Estado_Boleta.TabIndex = 32
        Me.Lbl_T_Estado_Boleta.Text = "Estado Bol"
        '
        'Lbl_T_Estado_Rep
        '
        Me.Lbl_T_Estado_Rep.AutoSize = True
        Me.Lbl_T_Estado_Rep.Location = New System.Drawing.Point(502, 132)
        Me.Lbl_T_Estado_Rep.Name = "Lbl_T_Estado_Rep"
        Me.Lbl_T_Estado_Rep.Size = New System.Drawing.Size(52, 15)
        Me.Lbl_T_Estado_Rep.TabIndex = 31
        Me.Lbl_T_Estado_Rep.Text = "Estado:"
        '
        'Lbl_T_Traido_Por
        '
        Me.Lbl_T_Traido_Por.AutoSize = True
        Me.Lbl_T_Traido_Por.Location = New System.Drawing.Point(250, 114)
        Me.Lbl_T_Traido_Por.Name = "Lbl_T_Traido_Por"
        Me.Lbl_T_Traido_Por.Size = New System.Drawing.Size(73, 15)
        Me.Lbl_T_Traido_Por.TabIndex = 33
        Me.Lbl_T_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_Fecha_Ingreso
        '
        Me.Lbl_Fecha_Ingreso.AutoSize = True
        Me.Lbl_Fecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "FECHA_HORA", True))
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(346, 132)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(90, 15)
        Me.Lbl_Fecha_Ingreso.TabIndex = 30
        Me.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso"
        '
        'Lbl_T_Fecha_Ingeso
        '
        Me.Lbl_T_Fecha_Ingeso.AutoSize = True
        Me.Lbl_T_Fecha_Ingeso.Location = New System.Drawing.Point(231, 132)
        Me.Lbl_T_Fecha_Ingeso.Name = "Lbl_T_Fecha_Ingeso"
        Me.Lbl_T_Fecha_Ingeso.Size = New System.Drawing.Size(112, 15)
        Me.Lbl_T_Fecha_Ingeso.TabIndex = 29
        Me.Lbl_T_Fecha_Ingeso.Text = "Fecha de Ingreso:"
        '
        'Lbl_Doc_Ref
        '
        Me.Lbl_Doc_Ref.AutoSize = True
        Me.Lbl_Doc_Ref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "DOCUMENTO_REF", True))
        Me.Lbl_Doc_Ref.Location = New System.Drawing.Point(152, 114)
        Me.Lbl_Doc_Ref.Name = "Lbl_Doc_Ref"
        Me.Lbl_Doc_Ref.Size = New System.Drawing.Size(56, 15)
        Me.Lbl_Doc_Ref.TabIndex = 32
        Me.Lbl_Doc_Ref.Text = "Doc_Ref"
        '
        'Lbl_Usuario_Ingreso
        '
        Me.Lbl_Usuario_Ingreso.AutoSize = True
        Me.Lbl_Usuario_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "USUARIO", True))
        Me.Lbl_Usuario_Ingreso.Location = New System.Drawing.Point(97, 132)
        Me.Lbl_Usuario_Ingreso.Name = "Lbl_Usuario_Ingreso"
        Me.Lbl_Usuario_Ingreso.Size = New System.Drawing.Size(103, 15)
        Me.Lbl_Usuario_Ingreso.TabIndex = 28
        Me.Lbl_Usuario_Ingreso.Text = "Usuario_Ingreso"
        '
        'Lbl_T_Usuario_Ingreso
        '
        Me.Lbl_T_Usuario_Ingreso.AutoSize = True
        Me.Lbl_T_Usuario_Ingreso.Location = New System.Drawing.Point(6, 132)
        Me.Lbl_T_Usuario_Ingreso.Name = "Lbl_T_Usuario_Ingreso"
        Me.Lbl_T_Usuario_Ingreso.Size = New System.Drawing.Size(93, 15)
        Me.Lbl_T_Usuario_Ingreso.TabIndex = 27
        Me.Lbl_T_Usuario_Ingreso.Text = "Ingresado Por:"
        '
        'Lbl_T_Doc_Ref
        '
        Me.Lbl_T_Doc_Ref.AutoSize = True
        Me.Lbl_T_Doc_Ref.Location = New System.Drawing.Point(6, 114)
        Me.Lbl_T_Doc_Ref.Name = "Lbl_T_Doc_Ref"
        Me.Lbl_T_Doc_Ref.Size = New System.Drawing.Size(146, 15)
        Me.Lbl_T_Doc_Ref.TabIndex = 31
        Me.Lbl_T_Doc_Ref.Text = "Documento Referencia:"
        '
        'Lbl_Encargado_Bod
        '
        Me.Lbl_Encargado_Bod.AutoSize = True
        Me.Lbl_Encargado_Bod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ENCARGADO_BODEGA", True))
        Me.Lbl_Encargado_Bod.Location = New System.Drawing.Point(690, 114)
        Me.Lbl_Encargado_Bod.Name = "Lbl_Encargado_Bod"
        Me.Lbl_Encargado_Bod.Size = New System.Drawing.Size(117, 15)
        Me.Lbl_Encargado_Bod.TabIndex = 26
        Me.Lbl_Encargado_Bod.Text = "Encargado Bodega"
        '
        'Lbl_T_Encargado_Bod
        '
        Me.Lbl_T_Encargado_Bod.AutoSize = True
        Me.Lbl_T_Encargado_Bod.Location = New System.Drawing.Point(568, 114)
        Me.Lbl_T_Encargado_Bod.Name = "Lbl_T_Encargado_Bod"
        Me.Lbl_T_Encargado_Bod.Size = New System.Drawing.Size(121, 15)
        Me.Lbl_T_Encargado_Bod.TabIndex = 25
        Me.Lbl_T_Encargado_Bod.Text = "Encargado Bodega:"
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.AutoSize = True
        Me.Lbl_Problema_Reportado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "PROBLEMA_REPORTADO", True))
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(141, 96)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(129, 15)
        Me.Lbl_Problema_Reportado.TabIndex = 30
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_T_Problema
        '
        Me.Lbl_T_Problema.AutoSize = True
        Me.Lbl_T_Problema.Location = New System.Drawing.Point(6, 96)
        Me.Lbl_T_Problema.Name = "Lbl_T_Problema"
        Me.Lbl_T_Problema.Size = New System.Drawing.Size(133, 15)
        Me.Lbl_T_Problema.TabIndex = 29
        Me.Lbl_T_Problema.Text = "Problema Reportado:"
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.AutoSize = True
        Me.Lbl_Estado_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO_ART", True))
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(284, 74)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(74, 15)
        Me.Lbl_Estado_Art.TabIndex = 28
        Me.Lbl_Estado_Art.Text = "Estado_Art"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.AutoSize = True
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "MOTIVO", True))
        Me.Lbl_Motivo.Location = New System.Drawing.Point(59, 74)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(47, 15)
        Me.Lbl_Motivo.TabIndex = 26
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Lbl_T_Estado_Art
        '
        Me.Lbl_T_Estado_Art.AutoSize = True
        Me.Lbl_T_Estado_Art.Location = New System.Drawing.Point(180, 74)
        Me.Lbl_T_Estado_Art.Name = "Lbl_T_Estado_Art"
        Me.Lbl_T_Estado_Art.Size = New System.Drawing.Size(105, 15)
        Me.Lbl_T_Estado_Art.TabIndex = 25
        Me.Lbl_T_Estado_Art.Text = "Estado Articulo:"
        '
        'Lbl_T_Motivo
        '
        Me.Lbl_T_Motivo.AutoSize = True
        Me.Lbl_T_Motivo.Location = New System.Drawing.Point(6, 74)
        Me.Lbl_T_Motivo.Name = "Lbl_T_Motivo"
        Me.Lbl_T_Motivo.Size = New System.Drawing.Size(51, 15)
        Me.Lbl_T_Motivo.TabIndex = 27
        Me.Lbl_T_Motivo.Text = "Motivo:"
        '
        'SCR_DATOS_REPARACIONTableAdapter
        '
        Me.SCR_DATOS_REPARACIONTableAdapter.ClearBeforeFill = True
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
        Me.Lbl_Estado.Location = New System.Drawing.Point(4, 228)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(52, 15)
        Me.Lbl_Estado.TabIndex = 25
        Me.Lbl_Estado.Text = "Estado:"
        '
        'Lbl_Localizacion
        '
        Me.Lbl_Localizacion.AutoSize = True
        Me.Lbl_Localizacion.Location = New System.Drawing.Point(196, 228)
        Me.Lbl_Localizacion.Name = "Lbl_Localizacion"
        Me.Lbl_Localizacion.Size = New System.Drawing.Size(85, 15)
        Me.Lbl_Localizacion.TabIndex = 26
        Me.Lbl_Localizacion.Text = "Localizacion:"
        '
        'Lbl_Comentario
        '
        Me.Lbl_Comentario.AutoSize = True
        Me.Lbl_Comentario.Location = New System.Drawing.Point(4, 267)
        Me.Lbl_Comentario.Name = "Lbl_Comentario"
        Me.Lbl_Comentario.Size = New System.Drawing.Size(80, 15)
        Me.Lbl_Comentario.TabIndex = 27
        Me.Lbl_Comentario.Text = "Comentario:"
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Enabled = False
        Me.Txt_Comentario.Location = New System.Drawing.Point(81, 264)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(1344, 88)
        Me.Txt_Comentario.TabIndex = 28
        '
        'Cbx_Estado
        '
        Me.Cbx_Estado.DataSource = Me.SCRESTADOACTUABindingSource
        Me.Cbx_Estado.DisplayMember = "ESTADO"
        Me.Cbx_Estado.FormattingEnabled = True
        Me.Cbx_Estado.Location = New System.Drawing.Point(53, 225)
        Me.Cbx_Estado.Name = "Cbx_Estado"
        Me.Cbx_Estado.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_Estado.TabIndex = 29
        '
        'Cbx_Localizacion
        '
        Me.Cbx_Localizacion.DataSource = Me.SCRLOCALIZACIONREPBindingSource
        Me.Cbx_Localizacion.DisplayMember = "LOCALIZACION"
        Me.Cbx_Localizacion.Enabled = False
        Me.Cbx_Localizacion.FormattingEnabled = True
        Me.Cbx_Localizacion.Location = New System.Drawing.Point(278, 225)
        Me.Cbx_Localizacion.Name = "Cbx_Localizacion"
        Me.Cbx_Localizacion.Size = New System.Drawing.Size(121, 23)
        Me.Cbx_Localizacion.TabIndex = 30
        '
        'SCRESTADOACTUABindingSource
        '
        Me.SCRESTADOACTUABindingSource.DataMember = "SCR_ESTADO_ACTUA"
        Me.SCRESTADOACTUABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ESTADO_ACTUATableAdapter
        '
        Me.SCR_ESTADO_ACTUATableAdapter.ClearBeforeFill = True
        '
        'SCRLOCALIZACIONREPBindingSource
        '
        Me.SCRLOCALIZACIONREPBindingSource.DataMember = "SCR_LOCALIZACION_REP"
        Me.SCRLOCALIZACIONREPBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_LOCALIZACION_REPTableAdapter
        '
        Me.SCR_LOCALIZACION_REPTableAdapter.ClearBeforeFill = True
        '
        'Btn_Grabar_Actua
        '
        Me.Btn_Grabar_Actua.Location = New System.Drawing.Point(1350, 358)
        Me.Btn_Grabar_Actua.Name = "Btn_Grabar_Actua"
        Me.Btn_Grabar_Actua.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Grabar_Actua.TabIndex = 31
        Me.Btn_Grabar_Actua.Text = "&Grabar"
        Me.Btn_Grabar_Actua.UseVisualStyleBackColor = True
        '
        'Frm_Actualizacion_Boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 393)
        Me.Controls.Add(Me.Btn_Grabar_Actua)
        Me.Controls.Add(Me.Cbx_Localizacion)
        Me.Controls.Add(Me.Cbx_Estado)
        Me.Controls.Add(Me.Txt_Comentario)
        Me.Controls.Add(Me.Lbl_Comentario)
        Me.Controls.Add(Me.Lbl_Localizacion)
        Me.Controls.Add(Me.Lbl_Estado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cbx_Dummy2)
        Me.Controls.Add(Me.Cbx_dummy1)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Controls.Add(Me.Cbx_Boleta)
        Me.Controls.Add(Me.Lbl_Numero_Boleta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Actualizacion_Boleta"
        Me.Text = "Actualizacion de Reparacion"
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SCRESTADOACTUABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cbx_dummy1 As ComboBox
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Numero_1 As Label
    Friend WithEvents Lbl_Numero_2 As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_T_Fax As Label
    Friend WithEvents Lbl_Fax As Label
    Friend WithEvents Cbx_Dummy2 As ComboBox
    Friend WithEvents Lbl_T_Descripcion As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents Lbl_T_Adicio_Art As Label
    Friend WithEvents Lbl_Adicional_Art As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_T_Estado_Art As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl_T_Motivo As Label
    Friend WithEvents Lbl_Estado_Art As Label
    Friend WithEvents Lbl_T_Problema As Label
    Friend WithEvents Lbl_Problema_Reportado As Label
    Friend WithEvents Lbl_T_Doc_Ref As Label
    Friend WithEvents Lbl_Doc_Ref As Label
    Friend WithEvents Lbl_T_Traido_Por As Label
    Friend WithEvents Lbl_Traido_Por As Label
    Friend WithEvents Lbl_Encargado_Bod As Label
    Friend WithEvents Lbl_T_Encargado_Bod As Label
    Friend WithEvents Lbl_T_Usuario_Ingreso As Label
    Friend WithEvents Lbl_Usuario_Ingreso As Label
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
End Class
