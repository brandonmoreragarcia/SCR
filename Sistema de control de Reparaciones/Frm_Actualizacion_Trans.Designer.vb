<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Actualizacion_Trans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Actualizacion_Trans))
        Me.Btn_Grabar_Actua = New System.Windows.Forms.Button()
        Me.Cbx_Localizacion = New System.Windows.Forms.ComboBox()
        Me.SCRLOCALIZACIONTRANSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Cbx_Estado = New System.Windows.Forms.ComboBox()
        Me.SCRESTADOTRANSPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txt_Comentario = New System.Windows.Forms.TextBox()
        Me.Lbl_Comentario = New System.Windows.Forms.Label()
        Me.Lbl_Localizacion = New System.Windows.Forms.Label()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Numero_Serie = New System.Windows.Forms.Label()
        Me.SCRDATOSREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_Boleta_Chofer = New System.Windows.Forms.Label()
        Me.Lbl_T_Numero_Serie = New System.Windows.Forms.Label()
        Me.Lbl_T_Articulo = New System.Windows.Forms.Label()
        Me.Lbl_Adicional_Art = New System.Windows.Forms.Label()
        Me.Lbl_ = New System.Windows.Forms.Label()
        Me.Lbl_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_Usuario_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_Articulo = New System.Windows.Forms.Label()
        Me.Lbl_T_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_T_Adicio_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Rep = New System.Windows.Forms.Label()
        Me.Lbl_T_Usuario_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_T_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Descripcion = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Problema = New System.Windows.Forms.Label()
        Me.Lbl_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_T_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.Lbl_Fecha_Ingreso = New System.Windows.Forms.Label()
        Me.Lbl_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_T_Encargado_Bod = New System.Windows.Forms.Label()
        Me.Lbl_T_Fecha_Ingeso = New System.Windows.Forms.Label()
        Me.Cbx_Dummy2 = New System.Windows.Forms.ComboBox()
        Me.Cbx_dummy1 = New System.Windows.Forms.ComboBox()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_Fecha_Hora = New System.Windows.Forms.Label()
        Me.Cbx_Boleta = New System.Windows.Forms.ComboBox()
        Me.Lbl_Numero_Boleta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Fax = New System.Windows.Forms.Label()
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Fax = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Numero_2 = New System.Windows.Forms.Label()
        Me.Lbl_Numero_1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.SCR_ESTADO_TRANSPORTETableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_TRANSPORTETableAdapter()
        Me.SCR_LOCALIZACION_TRANSTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_TRANSTableAdapter()
        CType(Me.SCRLOCALIZACIONTRANSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRESTADOTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Grabar_Actua
        '
        Me.Btn_Grabar_Actua.Enabled = False
        Me.Btn_Grabar_Actua.Location = New System.Drawing.Point(1273, 386)
        Me.Btn_Grabar_Actua.Name = "Btn_Grabar_Actua"
        Me.Btn_Grabar_Actua.Size = New System.Drawing.Size(87, 25)
        Me.Btn_Grabar_Actua.TabIndex = 45
        Me.Btn_Grabar_Actua.Text = "&Grabar"
        Me.Btn_Grabar_Actua.UseVisualStyleBackColor = True
        Me.Btn_Grabar_Actua.Visible = False
        '
        'Cbx_Localizacion
        '
        Me.Cbx_Localizacion.DataSource = Me.SCRLOCALIZACIONTRANSBindingSource
        Me.Cbx_Localizacion.DisplayMember = "LOCALIZACION"
        Me.Cbx_Localizacion.DropDownWidth = 290
        Me.Cbx_Localizacion.Enabled = False
        Me.Cbx_Localizacion.FormattingEnabled = True
        Me.Cbx_Localizacion.Location = New System.Drawing.Point(336, 244)
        Me.Cbx_Localizacion.Name = "Cbx_Localizacion"
        Me.Cbx_Localizacion.Size = New System.Drawing.Size(140, 22)
        Me.Cbx_Localizacion.TabIndex = 44
        '
        'SCRLOCALIZACIONTRANSBindingSource
        '
        Me.SCRLOCALIZACIONTRANSBindingSource.DataMember = "SCR_LOCALIZACION_TRANS"
        Me.SCRLOCALIZACIONTRANSBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cbx_Estado
        '
        Me.Cbx_Estado.DataSource = Me.SCRESTADOTRANSPORTEBindingSource
        Me.Cbx_Estado.DisplayMember = "ESTADO"
        Me.Cbx_Estado.DropDownWidth = 290
        Me.Cbx_Estado.FormattingEnabled = True
        Me.Cbx_Estado.Location = New System.Drawing.Point(73, 244)
        Me.Cbx_Estado.Name = "Cbx_Estado"
        Me.Cbx_Estado.Size = New System.Drawing.Size(140, 22)
        Me.Cbx_Estado.TabIndex = 43
        '
        'SCRESTADOTRANSPORTEBindingSource
        '
        Me.SCRESTADOTRANSPORTEBindingSource.DataMember = "SCR_ESTADO_TRANSPORTE"
        Me.SCRESTADOTRANSPORTEBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Enabled = False
        Me.Txt_Comentario.Location = New System.Drawing.Point(106, 286)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(1254, 94)
        Me.Txt_Comentario.TabIndex = 42
        '
        'Lbl_Comentario
        '
        Me.Lbl_Comentario.AutoSize = True
        Me.Lbl_Comentario.Location = New System.Drawing.Point(16, 290)
        Me.Lbl_Comentario.Name = "Lbl_Comentario"
        Me.Lbl_Comentario.Size = New System.Drawing.Size(74, 14)
        Me.Lbl_Comentario.TabIndex = 41
        Me.Lbl_Comentario.Text = "Comentario:"
        '
        'Lbl_Localizacion
        '
        Me.Lbl_Localizacion.AutoSize = True
        Me.Lbl_Localizacion.Location = New System.Drawing.Point(240, 248)
        Me.Lbl_Localizacion.Name = "Lbl_Localizacion"
        Me.Lbl_Localizacion.Size = New System.Drawing.Size(76, 14)
        Me.Lbl_Localizacion.TabIndex = 40
        Me.Lbl_Localizacion.Text = "Localizacion:"
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(16, 248)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(49, 14)
        Me.Lbl_Estado.TabIndex = 39
        Me.Lbl_Estado.Text = "Estado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_Numero_Serie)
        Me.GroupBox2.Controls.Add(Me.Lbl_Boleta_Chofer)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Numero_Serie)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Articulo)
        Me.GroupBox2.Controls.Add(Me.Lbl_Adicional_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_)
        Me.GroupBox2.Controls.Add(Me.Lbl_Doc_Ref)
        Me.GroupBox2.Controls.Add(Me.Lbl_Usuario_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Boleta)
        Me.GroupBox2.Controls.Add(Me.Lbl_Articulo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Doc_Ref)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Adicio_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Rep)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Usuario_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Problema_Reportado)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Motivo)
        Me.GroupBox2.Controls.Add(Me.Lbl_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Problema)
        Me.GroupBox2.Controls.Add(Me.Lbl_Motivo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Fecha_Ingeso)
        Me.GroupBox2.Location = New System.Drawing.Point(582, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 184)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFOMRACION ARTICULO Y REPARACION"
        '
        'Lbl_Numero_Serie
        '
        Me.Lbl_Numero_Serie.AutoSize = True
        Me.Lbl_Numero_Serie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "SERIE_PRODUCTO", True))
        Me.Lbl_Numero_Serie.Location = New System.Drawing.Point(199, 28)
        Me.Lbl_Numero_Serie.Name = "Lbl_Numero_Serie"
        Me.Lbl_Numero_Serie.Size = New System.Drawing.Size(85, 14)
        Me.Lbl_Numero_Serie.TabIndex = 47
        Me.Lbl_Numero_Serie.Text = "Numero_Serie"
        '
        'SCRDATOSREPARACIONBindingSource
        '
        Me.SCRDATOSREPARACIONBindingSource.DataMember = "SCR_DATOS_REPARACION"
        Me.SCRDATOSREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Lbl_Boleta_Chofer
        '
        Me.Lbl_Boleta_Chofer.AutoSize = True
        Me.Lbl_Boleta_Chofer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "BOLETA", True))
        Me.Lbl_Boleta_Chofer.Location = New System.Drawing.Point(568, 157)
        Me.Lbl_Boleta_Chofer.Name = "Lbl_Boleta_Chofer"
        Me.Lbl_Boleta_Chofer.Size = New System.Drawing.Size(83, 14)
        Me.Lbl_Boleta_Chofer.TabIndex = 35
        Me.Lbl_Boleta_Chofer.Text = "Boleta Chofer"
        '
        'Lbl_T_Numero_Serie
        '
        Me.Lbl_T_Numero_Serie.AutoSize = True
        Me.Lbl_T_Numero_Serie.Location = New System.Drawing.Point(147, 28)
        Me.Lbl_T_Numero_Serie.Name = "Lbl_T_Numero_Serie"
        Me.Lbl_T_Numero_Serie.Size = New System.Drawing.Size(48, 14)
        Me.Lbl_T_Numero_Serie.TabIndex = 46
        Me.Lbl_T_Numero_Serie.Text = "Serie #"
        '
        'Lbl_T_Articulo
        '
        Me.Lbl_T_Articulo.AutoSize = True
        Me.Lbl_T_Articulo.Location = New System.Drawing.Point(7, 28)
        Me.Lbl_T_Articulo.Name = "Lbl_T_Articulo"
        Me.Lbl_T_Articulo.Size = New System.Drawing.Size(56, 14)
        Me.Lbl_T_Articulo.TabIndex = 3
        Me.Lbl_T_Articulo.Text = "Articulo:"
        '
        'Lbl_Adicional_Art
        '
        Me.Lbl_Adicional_Art.AutoSize = True
        Me.Lbl_Adicional_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ADICIONAL_ART", True))
        Me.Lbl_Adicional_Art.Location = New System.Drawing.Point(62, 54)
        Me.Lbl_Adicional_Art.Name = "Lbl_Adicional_Art"
        Me.Lbl_Adicional_Art.Size = New System.Drawing.Size(55, 14)
        Me.Lbl_Adicional_Art.TabIndex = 22
        Me.Lbl_Adicional_Art.Text = "Adicional"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(475, 157)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(87, 14)
        Me.Lbl_.TabIndex = 33
        Me.Lbl_.Text = "Boleta Chofer:"
        '
        'Lbl_Doc_Ref
        '
        Me.Lbl_Doc_Ref.AutoSize = True
        Me.Lbl_Doc_Ref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "DOCUMENTO_REF", True))
        Me.Lbl_Doc_Ref.Location = New System.Drawing.Point(148, 132)
        Me.Lbl_Doc_Ref.Name = "Lbl_Doc_Ref"
        Me.Lbl_Doc_Ref.Size = New System.Drawing.Size(52, 14)
        Me.Lbl_Doc_Ref.TabIndex = 32
        Me.Lbl_Doc_Ref.Text = "Doc_Ref"
        '
        'Lbl_Usuario_Ingreso
        '
        Me.Lbl_Usuario_Ingreso.AutoSize = True
        Me.Lbl_Usuario_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "USUARIO", True))
        Me.Lbl_Usuario_Ingreso.Location = New System.Drawing.Point(101, 157)
        Me.Lbl_Usuario_Ingreso.Name = "Lbl_Usuario_Ingreso"
        Me.Lbl_Usuario_Ingreso.Size = New System.Drawing.Size(97, 14)
        Me.Lbl_Usuario_Ingreso.TabIndex = 28
        Me.Lbl_Usuario_Ingreso.Text = "Usuario_Ingreso"
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.AutoSize = True
        Me.Lbl_Traido_Por.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "TRAIDO_POR", True))
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(308, 157)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(65, 14)
        Me.Lbl_Traido_Por.TabIndex = 34
        Me.Lbl_Traido_Por.Text = "Traido Por"
        '
        'Lbl_T_Estado_Boleta
        '
        Me.Lbl_T_Estado_Boleta.AutoSize = True
        Me.Lbl_T_Estado_Boleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO", True))
        Me.Lbl_T_Estado_Boleta.Location = New System.Drawing.Point(530, 129)
        Me.Lbl_T_Estado_Boleta.Name = "Lbl_T_Estado_Boleta"
        Me.Lbl_T_Estado_Boleta.Size = New System.Drawing.Size(66, 14)
        Me.Lbl_T_Estado_Boleta.TabIndex = 32
        Me.Lbl_T_Estado_Boleta.Text = "Estado Bol"
        '
        'Lbl_Articulo
        '
        Me.Lbl_Articulo.AutoSize = True
        Me.Lbl_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_ART", True))
        Me.Lbl_Articulo.Location = New System.Drawing.Point(62, 28)
        Me.Lbl_Articulo.Name = "Lbl_Articulo"
        Me.Lbl_Articulo.Size = New System.Drawing.Size(79, 14)
        Me.Lbl_Articulo.TabIndex = 2
        Me.Lbl_Articulo.Text = "BI0000-000"
        '
        'Lbl_T_Doc_Ref
        '
        Me.Lbl_T_Doc_Ref.AutoSize = True
        Me.Lbl_T_Doc_Ref.Location = New System.Drawing.Point(7, 132)
        Me.Lbl_T_Doc_Ref.Name = "Lbl_T_Doc_Ref"
        Me.Lbl_T_Doc_Ref.Size = New System.Drawing.Size(135, 14)
        Me.Lbl_T_Doc_Ref.TabIndex = 31
        Me.Lbl_T_Doc_Ref.Text = "Documento Referencia:"
        '
        'Lbl_T_Adicio_Art
        '
        Me.Lbl_T_Adicio_Art.AutoSize = True
        Me.Lbl_T_Adicio_Art.Location = New System.Drawing.Point(7, 54)
        Me.Lbl_T_Adicio_Art.Name = "Lbl_T_Adicio_Art"
        Me.Lbl_T_Adicio_Art.Size = New System.Drawing.Size(59, 14)
        Me.Lbl_T_Adicio_Art.TabIndex = 21
        Me.Lbl_T_Adicio_Art.Text = "Adicional:"
        '
        'Lbl_T_Estado_Rep
        '
        Me.Lbl_T_Estado_Rep.AutoSize = True
        Me.Lbl_T_Estado_Rep.Location = New System.Drawing.Point(475, 129)
        Me.Lbl_T_Estado_Rep.Name = "Lbl_T_Estado_Rep"
        Me.Lbl_T_Estado_Rep.Size = New System.Drawing.Size(49, 14)
        Me.Lbl_T_Estado_Rep.TabIndex = 31
        Me.Lbl_T_Estado_Rep.Text = "Estado:"
        '
        'Lbl_T_Usuario_Ingreso
        '
        Me.Lbl_T_Usuario_Ingreso.AutoSize = True
        Me.Lbl_T_Usuario_Ingreso.Location = New System.Drawing.Point(7, 157)
        Me.Lbl_T_Usuario_Ingreso.Name = "Lbl_T_Usuario_Ingreso"
        Me.Lbl_T_Usuario_Ingreso.Size = New System.Drawing.Size(88, 14)
        Me.Lbl_T_Usuario_Ingreso.TabIndex = 27
        Me.Lbl_T_Usuario_Ingreso.Text = "Ingresado Por:"
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.AutoSize = True
        Me.Lbl_Problema_Reportado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "PROBLEMA_REPORTADO", True))
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(133, 80)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(117, 14)
        Me.Lbl_Problema_Reportado.TabIndex = 30
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_T_Motivo
        '
        Me.Lbl_T_Motivo.AutoSize = True
        Me.Lbl_T_Motivo.Location = New System.Drawing.Point(7, 104)
        Me.Lbl_T_Motivo.Name = "Lbl_T_Motivo"
        Me.Lbl_T_Motivo.Size = New System.Drawing.Size(49, 14)
        Me.Lbl_T_Motivo.TabIndex = 27
        Me.Lbl_T_Motivo.Text = "Motivo:"
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.AutoSize = True
        Me.Lbl_Estado_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO_ART", True))
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(332, 104)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(71, 14)
        Me.Lbl_Estado_Art.TabIndex = 28
        Me.Lbl_Estado_Art.Text = "Estado_Art"
        '
        'Lbl_T_Descripcion
        '
        Me.Lbl_T_Descripcion.AutoSize = True
        Me.Lbl_T_Descripcion.Location = New System.Drawing.Point(284, 28)
        Me.Lbl_T_Descripcion.Name = "Lbl_T_Descripcion"
        Me.Lbl_T_Descripcion.Size = New System.Drawing.Size(75, 14)
        Me.Lbl_T_Descripcion.TabIndex = 19
        Me.Lbl_T_Descripcion.Text = "Descripcion:"
        '
        'Lbl_T_Estado_Art
        '
        Me.Lbl_T_Estado_Art.AutoSize = True
        Me.Lbl_T_Estado_Art.Location = New System.Drawing.Point(233, 104)
        Me.Lbl_T_Estado_Art.Name = "Lbl_T_Estado_Art"
        Me.Lbl_T_Estado_Art.Size = New System.Drawing.Size(98, 14)
        Me.Lbl_T_Estado_Art.TabIndex = 25
        Me.Lbl_T_Estado_Art.Text = "Estado Articulo:"
        '
        'Lbl_T_Problema
        '
        Me.Lbl_T_Problema.AutoSize = True
        Me.Lbl_T_Problema.Location = New System.Drawing.Point(6, 80)
        Me.Lbl_T_Problema.Name = "Lbl_T_Problema"
        Me.Lbl_T_Problema.Size = New System.Drawing.Size(121, 14)
        Me.Lbl_T_Problema.TabIndex = 29
        Me.Lbl_T_Problema.Text = "Problema Reportado:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.AutoSize = True
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "MOTIVO", True))
        Me.Lbl_Motivo.Location = New System.Drawing.Point(56, 104)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(45, 14)
        Me.Lbl_Motivo.TabIndex = 26
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Lbl_T_Traido_Por
        '
        Me.Lbl_T_Traido_Por.AutoSize = True
        Me.Lbl_T_Traido_Por.Location = New System.Drawing.Point(233, 157)
        Me.Lbl_T_Traido_Por.Name = "Lbl_T_Traido_Por"
        Me.Lbl_T_Traido_Por.Size = New System.Drawing.Size(69, 14)
        Me.Lbl_T_Traido_Por.TabIndex = 33
        Me.Lbl_T_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOBindingSource, "DESCRIPCION", True))
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(359, 28)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(71, 14)
        Me.Lbl_Descripcion.TabIndex = 20
        Me.Lbl_Descripcion.Text = "Descripcion"
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'ExactusERP_TABLES
        '
        Me.ExactusERP_TABLES.DataSetName = "ExactusERP_TABLES"
        Me.ExactusERP_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Fecha_Ingreso
        '
        Me.Lbl_Fecha_Ingreso.AutoSize = True
        Me.Lbl_Fecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "FECHA_HORA", True))
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(343, 132)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(84, 14)
        Me.Lbl_Fecha_Ingreso.TabIndex = 30
        Me.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso"
        '
        'Lbl_Encargado_Bod
        '
        Me.Lbl_Encargado_Bod.AutoSize = True
        Me.Lbl_Encargado_Bod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ENCARGADO_BODEGA", True))
        Me.Lbl_Encargado_Bod.Location = New System.Drawing.Point(591, 104)
        Me.Lbl_Encargado_Bod.Name = "Lbl_Encargado_Bod"
        Me.Lbl_Encargado_Bod.Size = New System.Drawing.Size(106, 14)
        Me.Lbl_Encargado_Bod.TabIndex = 26
        Me.Lbl_Encargado_Bod.Text = "Encargado Bodega"
        '
        'Lbl_T_Encargado_Bod
        '
        Me.Lbl_T_Encargado_Bod.AutoSize = True
        Me.Lbl_T_Encargado_Bod.Location = New System.Drawing.Point(475, 104)
        Me.Lbl_T_Encargado_Bod.Name = "Lbl_T_Encargado_Bod"
        Me.Lbl_T_Encargado_Bod.Size = New System.Drawing.Size(110, 14)
        Me.Lbl_T_Encargado_Bod.TabIndex = 25
        Me.Lbl_T_Encargado_Bod.Text = "Encargado Bodega:"
        '
        'Lbl_T_Fecha_Ingeso
        '
        Me.Lbl_T_Fecha_Ingeso.AutoSize = True
        Me.Lbl_T_Fecha_Ingeso.Location = New System.Drawing.Point(233, 132)
        Me.Lbl_T_Fecha_Ingeso.Name = "Lbl_T_Fecha_Ingeso"
        Me.Lbl_T_Fecha_Ingeso.Size = New System.Drawing.Size(104, 14)
        Me.Lbl_T_Fecha_Ingeso.TabIndex = 29
        Me.Lbl_T_Fecha_Ingeso.Text = "Fecha de Ingreso:"
        '
        'Cbx_Dummy2
        '
        Me.Cbx_Dummy2.DataSource = Me.ARTICULOBindingSource
        Me.Cbx_Dummy2.DisplayMember = "ARTICULO"
        Me.Cbx_Dummy2.FormattingEnabled = True
        Me.Cbx_Dummy2.Location = New System.Drawing.Point(195, 10)
        Me.Cbx_Dummy2.Name = "Cbx_Dummy2"
        Me.Cbx_Dummy2.Size = New System.Drawing.Size(140, 22)
        Me.Cbx_Dummy2.TabIndex = 36
        Me.Cbx_Dummy2.Visible = False
        '
        'Cbx_dummy1
        '
        Me.Cbx_dummy1.DataSource = Me.CLIENTEBindingSource
        Me.Cbx_dummy1.DisplayMember = "CLIENTE"
        Me.Cbx_dummy1.FormattingEnabled = True
        Me.Cbx_dummy1.Location = New System.Drawing.Point(45, 9)
        Me.Cbx_dummy1.Name = "Cbx_dummy1"
        Me.Cbx_dummy1.Size = New System.Drawing.Size(140, 22)
        Me.Cbx_dummy1.TabIndex = 35
        Me.Cbx_dummy1.Visible = False
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'Lbl_Fecha_Hora
        '
        Me.Lbl_Fecha_Hora.AutoSize = True
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(1191, 37)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(72, 14)
        Me.Lbl_Fecha_Hora.TabIndex = 34
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Cbx_Boleta
        '
        Me.Cbx_Boleta.DataSource = Me.SCRDATOSREPARACIONBindingSource
        Me.Cbx_Boleta.DisplayMember = "REPARACION_NUMERO"
        Me.Cbx_Boleta.Enabled = False
        Me.Cbx_Boleta.FormattingEnabled = True
        Me.Cbx_Boleta.Location = New System.Drawing.Point(1222, 9)
        Me.Cbx_Boleta.Name = "Cbx_Boleta"
        Me.Cbx_Boleta.Size = New System.Drawing.Size(138, 22)
        Me.Cbx_Boleta.TabIndex = 33
        '
        'Lbl_Numero_Boleta
        '
        Me.Lbl_Numero_Boleta.AutoSize = True
        Me.Lbl_Numero_Boleta.Location = New System.Drawing.Point(1135, 12)
        Me.Lbl_Numero_Boleta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_Numero_Boleta.Name = "Lbl_Numero_Boleta"
        Me.Lbl_Numero_Boleta.Size = New System.Drawing.Size(79, 14)
        Me.Lbl_Numero_Boleta.TabIndex = 32
        Me.Lbl_Numero_Boleta.Text = "Reparacion #"
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 184)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION CLIENTE"
        '
        'Lbl_Nombre_Cliente
        '
        Me.Lbl_Nombre_Cliente.AutoSize = True
        Me.Lbl_Nombre_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre_Cliente.Location = New System.Drawing.Point(252, 28)
        Me.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente"
        Me.Lbl_Nombre_Cliente.Size = New System.Drawing.Size(94, 14)
        Me.Lbl_Nombre_Cliente.TabIndex = 9
        Me.Lbl_Nombre_Cliente.Text = "Nombre_Cliente"
        '
        'Lbl_T_Cliente
        '
        Me.Lbl_T_Cliente.AutoSize = True
        Me.Lbl_T_Cliente.Location = New System.Drawing.Point(12, 28)
        Me.Lbl_T_Cliente.Name = "Lbl_T_Cliente"
        Me.Lbl_T_Cliente.Size = New System.Drawing.Size(50, 14)
        Me.Lbl_T_Cliente.TabIndex = 6
        Me.Lbl_T_Cliente.Text = "Cliente:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Location = New System.Drawing.Point(57, 80)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(33, 14)
        Me.Lbl_Alias.TabIndex = 15
        Me.Lbl_Alias.Text = "Alias"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(12, 80)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(37, 14)
        Me.Lbl_T_Alias.TabIndex = 14
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Fax
        '
        Me.Lbl_Fax.AutoSize = True
        Me.Lbl_Fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "FAX", True))
        Me.Lbl_Fax.Location = New System.Drawing.Point(276, 54)
        Me.Lbl_Fax.Name = "Lbl_Fax"
        Me.Lbl_Fax.Size = New System.Drawing.Size(26, 14)
        Me.Lbl_Fax.TabIndex = 17
        Me.Lbl_Fax.Text = "Fax"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_CLIENTE", True))
        Me.Lbl_Cliente.Location = New System.Drawing.Point(77, 28)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(87, 14)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Codigo_Cliente"
        '
        'Lbl_T_Fax
        '
        Me.Lbl_T_Fax.AutoSize = True
        Me.Lbl_T_Fax.Location = New System.Drawing.Point(244, 54)
        Me.Lbl_T_Fax.Name = "Lbl_T_Fax"
        Me.Lbl_T_Fax.Size = New System.Drawing.Size(30, 14)
        Me.Lbl_T_Fax.TabIndex = 16
        Me.Lbl_T_Fax.Text = "Fax:"
        '
        'Lbl_T_Nombre_Cliente
        '
        Me.Lbl_T_Nombre_Cliente.AutoSize = True
        Me.Lbl_T_Nombre_Cliente.Location = New System.Drawing.Point(181, 28)
        Me.Lbl_T_Nombre_Cliente.Name = "Lbl_T_Nombre_Cliente"
        Me.Lbl_T_Nombre_Cliente.Size = New System.Drawing.Size(53, 14)
        Me.Lbl_T_Nombre_Cliente.TabIndex = 8
        Me.Lbl_T_Nombre_Cliente.Text = "Nombre:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(9, 54)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(56, 14)
        Me.Lbl_Telefono.TabIndex = 11
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Lbl_Numero_2
        '
        Me.Lbl_Numero_2.AutoSize = True
        Me.Lbl_Numero_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Lbl_Numero_2.Location = New System.Drawing.Point(154, 54)
        Me.Lbl_Numero_2.Name = "Lbl_Numero_2"
        Me.Lbl_Numero_2.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_Numero_2.TabIndex = 13
        Me.Lbl_Numero_2.Text = "Numero 2"
        '
        'Lbl_Numero_1
        '
        Me.Lbl_Numero_1.AutoSize = True
        Me.Lbl_Numero_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Lbl_Numero_1.Location = New System.Drawing.Point(76, 54)
        Me.Lbl_Numero_1.Name = "Lbl_Numero_1"
        Me.Lbl_Numero_1.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_Numero_1.TabIndex = 12
        Me.Lbl_Numero_1.Text = "Numero 1"
        '
        'Timer1
        '
        '
        'SCR_DATOS_REPARACIONTableAdapter
        '
        Me.SCR_DATOS_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOTableAdapter
        '
        Me.ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'SCR_ESTADO_TRANSPORTETableAdapter
        '
        Me.SCR_ESTADO_TRANSPORTETableAdapter.ClearBeforeFill = True
        '
        'SCR_LOCALIZACION_TRANSTableAdapter
        '
        Me.SCR_LOCALIZACION_TRANSTableAdapter.ClearBeforeFill = True
        '
        'Frm_Actualizacion_Trans
        '
        Me.AcceptButton = Me.Btn_Grabar_Actua
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 420)
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
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Actualizacion_Trans"
        Me.Text = "Actualizacion de Transporte"
        CType(Me.SCRLOCALIZACIONTRANSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRESTADOTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Grabar_Actua As Button
    Friend WithEvents Cbx_Localizacion As ComboBox
    Friend WithEvents Cbx_Estado As ComboBox
    Friend WithEvents Txt_Comentario As TextBox
    Friend WithEvents Lbl_Comentario As Label
    Friend WithEvents Lbl_Localizacion As Label
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_Boleta_Chofer As Label
    Friend WithEvents Lbl_T_Articulo As Label
    Friend WithEvents Lbl_Adicional_Art As Label
    Friend WithEvents Lbl_ As Label
    Friend WithEvents Lbl_Doc_Ref As Label
    Friend WithEvents Lbl_Usuario_Ingreso As Label
    Friend WithEvents Lbl_Traido_Por As Label
    Friend WithEvents Lbl_T_Estado_Boleta As Label
    Friend WithEvents Lbl_Articulo As Label
    Friend WithEvents Lbl_T_Doc_Ref As Label
    Friend WithEvents Lbl_T_Adicio_Art As Label
    Friend WithEvents Lbl_T_Estado_Rep As Label
    Friend WithEvents Lbl_T_Usuario_Ingreso As Label
    Friend WithEvents Lbl_Problema_Reportado As Label
    Friend WithEvents Lbl_T_Descripcion As Label
    Friend WithEvents Lbl_T_Problema As Label
    Friend WithEvents Lbl_T_Traido_Por As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl_Fecha_Ingreso As Label
    Friend WithEvents Lbl_T_Motivo As Label
    Friend WithEvents Lbl_T_Estado_Art As Label
    Friend WithEvents Lbl_Encargado_Bod As Label
    Friend WithEvents Lbl_Estado_Art As Label
    Friend WithEvents Lbl_T_Encargado_Bod As Label
    Friend WithEvents Lbl_T_Fecha_Ingeso As Label
    Friend WithEvents Cbx_Dummy2 As ComboBox
    Friend WithEvents Cbx_dummy1 As ComboBox
    Friend WithEvents Lbl_Fecha_Hora As Label
    Friend WithEvents Cbx_Boleta As ComboBox
    Friend WithEvents Lbl_Numero_Boleta As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbl_Nombre_Cliente As Label
    Friend WithEvents Lbl_T_Cliente As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_Fax As Label
    Friend WithEvents Lbl_Cliente As Label
    Friend WithEvents Lbl_T_Fax As Label
    Friend WithEvents Lbl_T_Nombre_Cliente As Label
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Numero_2 As Label
    Friend WithEvents Lbl_Numero_1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRDATOSREPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_DATOS_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter
    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As ExactusERP_TABLESTableAdapters.CLIENTETableAdapter
    Friend WithEvents Lbl_Numero_Serie As Label
    Friend WithEvents Lbl_T_Numero_Serie As Label
    Friend WithEvents SCRESTADOTRANSPORTEBindingSource As BindingSource
    Friend WithEvents SCR_ESTADO_TRANSPORTETableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_TRANSPORTETableAdapter
    Friend WithEvents SCRLOCALIZACIONTRANSBindingSource As BindingSource
    Friend WithEvents SCR_LOCALIZACION_TRANSTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_TRANSTableAdapter
End Class
