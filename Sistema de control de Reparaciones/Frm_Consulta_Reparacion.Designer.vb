<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Reparacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Reparacion))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Numero_Serie = New System.Windows.Forms.Label()
        Me.SCRDATOSREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
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
        Me.Lbl_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Motivo = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Descripcion = New System.Windows.Forms.Label()
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
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.Gbx_Actualizaciones = New System.Windows.Forms.GroupBox()
        Me.Txt_Comentario = New System.Windows.Forms.TextBox()
        Me.Lbl_T_Comentario = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Lbl_T_Fecha = New System.Windows.Forms.Label()
        Me.Lbl_Localizacion = New System.Windows.Forms.Label()
        Me.Lbl_T_Localizacion = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_T_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado = New System.Windows.Forms.Label()
        Me.Lbl_Numero_Actua = New System.Windows.Forms.Label()
        Me.Lbl_T_Numero_Actua = New System.Windows.Forms.Label()
        Me.Dgv_Actualizaciones = New System.Windows.Forms.DataGridView()
        Me.REPARACIONNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROACTUADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMENTARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRCONSULTAREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_CONSULTA_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Gbx_Actualizaciones.SuspendLayout()
        CType(Me.Dgv_Actualizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Controls.Add(Me.Lbl_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Motivo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Problema)
        Me.GroupBox2.Controls.Add(Me.Lbl_Motivo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_Descripcion)
        Me.GroupBox2.Controls.Add(Me.Lbl_Fecha_Ingreso)
        Me.GroupBox2.Controls.Add(Me.Lbl_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Encargado_Bod)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Fecha_Ingeso)
        Me.GroupBox2.Location = New System.Drawing.Point(551, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 171)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFOMRACION ARTICULO Y REPARACION"
        '
        'Lbl_Numero_Serie
        '
        Me.Lbl_Numero_Serie.AutoSize = True
        Me.Lbl_Numero_Serie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "SERIE_PRODUCTO", True))
        Me.Lbl_Numero_Serie.Location = New System.Drawing.Point(193, 26)
        Me.Lbl_Numero_Serie.Name = "Lbl_Numero_Serie"
        Me.Lbl_Numero_Serie.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Numero_Serie.TabIndex = 49
        Me.Lbl_Numero_Serie.Text = "Numero_Serie"
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
        'Lbl_Boleta_Chofer
        '
        Me.Lbl_Boleta_Chofer.AutoSize = True
        Me.Lbl_Boleta_Chofer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "BOLETA", True))
        Me.Lbl_Boleta_Chofer.Location = New System.Drawing.Point(569, 98)
        Me.Lbl_Boleta_Chofer.Name = "Lbl_Boleta_Chofer"
        Me.Lbl_Boleta_Chofer.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_Boleta_Chofer.TabIndex = 35
        Me.Lbl_Boleta_Chofer.Text = "Boleta Chofer"
        '
        'Lbl_T_Numero_Serie
        '
        Me.Lbl_T_Numero_Serie.AutoSize = True
        Me.Lbl_T_Numero_Serie.Location = New System.Drawing.Point(141, 26)
        Me.Lbl_T_Numero_Serie.Name = "Lbl_T_Numero_Serie"
        Me.Lbl_T_Numero_Serie.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_T_Numero_Serie.TabIndex = 48
        Me.Lbl_T_Numero_Serie.Text = "Serie #"
        '
        'Lbl_T_Articulo
        '
        Me.Lbl_T_Articulo.AutoSize = True
        Me.Lbl_T_Articulo.Location = New System.Drawing.Point(6, 26)
        Me.Lbl_T_Articulo.Name = "Lbl_T_Articulo"
        Me.Lbl_T_Articulo.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_T_Articulo.TabIndex = 3
        Me.Lbl_T_Articulo.Text = "Articulo:"
        '
        'Lbl_Adicional_Art
        '
        Me.Lbl_Adicional_Art.AutoSize = True
        Me.Lbl_Adicional_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ADICIONAL_ART", True))
        Me.Lbl_Adicional_Art.Location = New System.Drawing.Point(74, 50)
        Me.Lbl_Adicional_Art.Name = "Lbl_Adicional_Art"
        Me.Lbl_Adicional_Art.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_Adicional_Art.TabIndex = 22
        Me.Lbl_Adicional_Art.Text = "Adicional"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(471, 98)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_.TabIndex = 33
        Me.Lbl_.Text = "Boleta Chofer:"
        '
        'Lbl_Doc_Ref
        '
        Me.Lbl_Doc_Ref.AutoSize = True
        Me.Lbl_Doc_Ref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "DOCUMENTO_REF", True))
        Me.Lbl_Doc_Ref.Location = New System.Drawing.Point(157, 123)
        Me.Lbl_Doc_Ref.Name = "Lbl_Doc_Ref"
        Me.Lbl_Doc_Ref.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_Doc_Ref.TabIndex = 32
        Me.Lbl_Doc_Ref.Text = "Doc_Ref"
        '
        'Lbl_Usuario_Ingreso
        '
        Me.Lbl_Usuario_Ingreso.AutoSize = True
        Me.Lbl_Usuario_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "USUARIO", True))
        Me.Lbl_Usuario_Ingreso.Location = New System.Drawing.Point(105, 146)
        Me.Lbl_Usuario_Ingreso.Name = "Lbl_Usuario_Ingreso"
        Me.Lbl_Usuario_Ingreso.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_Usuario_Ingreso.TabIndex = 28
        Me.Lbl_Usuario_Ingreso.Text = "Usuario_Ingreso"
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.AutoSize = True
        Me.Lbl_Traido_Por.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "TRAIDO_POR", True))
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(300, 146)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_Traido_Por.TabIndex = 34
        Me.Lbl_Traido_Por.Text = "Traido Por"
        '
        'Lbl_T_Estado_Boleta
        '
        Me.Lbl_T_Estado_Boleta.AutoSize = True
        Me.Lbl_T_Estado_Boleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO", True))
        Me.Lbl_T_Estado_Boleta.Location = New System.Drawing.Point(529, 146)
        Me.Lbl_T_Estado_Boleta.Name = "Lbl_T_Estado_Boleta"
        Me.Lbl_T_Estado_Boleta.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_T_Estado_Boleta.TabIndex = 32
        Me.Lbl_T_Estado_Boleta.Text = "Estado Bol"
        '
        'Lbl_Articulo
        '
        Me.Lbl_Articulo.AutoSize = True
        Me.Lbl_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_ART", True))
        Me.Lbl_Articulo.Location = New System.Drawing.Point(67, 26)
        Me.Lbl_Articulo.Name = "Lbl_Articulo"
        Me.Lbl_Articulo.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Articulo.TabIndex = 2
        Me.Lbl_Articulo.Text = "BI0000-000"
        '
        'Lbl_T_Doc_Ref
        '
        Me.Lbl_T_Doc_Ref.AutoSize = True
        Me.Lbl_T_Doc_Ref.Location = New System.Drawing.Point(6, 123)
        Me.Lbl_T_Doc_Ref.Name = "Lbl_T_Doc_Ref"
        Me.Lbl_T_Doc_Ref.Size = New System.Drawing.Size(120, 13)
        Me.Lbl_T_Doc_Ref.TabIndex = 31
        Me.Lbl_T_Doc_Ref.Text = "Documento Referencia:"
        '
        'Lbl_T_Adicio_Art
        '
        Me.Lbl_T_Adicio_Art.AutoSize = True
        Me.Lbl_T_Adicio_Art.Location = New System.Drawing.Point(6, 50)
        Me.Lbl_T_Adicio_Art.Name = "Lbl_T_Adicio_Art"
        Me.Lbl_T_Adicio_Art.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_T_Adicio_Art.TabIndex = 21
        Me.Lbl_T_Adicio_Art.Text = "Adicional:"
        '
        'Lbl_T_Estado_Rep
        '
        Me.Lbl_T_Estado_Rep.AutoSize = True
        Me.Lbl_T_Estado_Rep.Location = New System.Drawing.Point(471, 146)
        Me.Lbl_T_Estado_Rep.Name = "Lbl_T_Estado_Rep"
        Me.Lbl_T_Estado_Rep.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_T_Estado_Rep.TabIndex = 31
        Me.Lbl_T_Estado_Rep.Text = "Estado:"
        '
        'Lbl_T_Usuario_Ingreso
        '
        Me.Lbl_T_Usuario_Ingreso.AutoSize = True
        Me.Lbl_T_Usuario_Ingreso.Location = New System.Drawing.Point(6, 146)
        Me.Lbl_T_Usuario_Ingreso.Name = "Lbl_T_Usuario_Ingreso"
        Me.Lbl_T_Usuario_Ingreso.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_T_Usuario_Ingreso.TabIndex = 27
        Me.Lbl_T_Usuario_Ingreso.Text = "Ingresado Por:"
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.AutoSize = True
        Me.Lbl_Problema_Reportado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "PROBLEMA_REPORTADO", True))
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(141, 74)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_Problema_Reportado.TabIndex = 30
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.AutoSize = True
        Me.Lbl_Estado_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO_ART", True))
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(334, 98)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_Estado_Art.TabIndex = 28
        Me.Lbl_Estado_Art.Text = "Estado_Art"
        '
        'Lbl_T_Motivo
        '
        Me.Lbl_T_Motivo.AutoSize = True
        Me.Lbl_T_Motivo.Location = New System.Drawing.Point(6, 98)
        Me.Lbl_T_Motivo.Name = "Lbl_T_Motivo"
        Me.Lbl_T_Motivo.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_T_Motivo.TabIndex = 27
        Me.Lbl_T_Motivo.Text = "Motivo:"
        '
        'Lbl_T_Estado_Art
        '
        Me.Lbl_T_Estado_Art.AutoSize = True
        Me.Lbl_T_Estado_Art.Location = New System.Drawing.Point(230, 98)
        Me.Lbl_T_Estado_Art.Name = "Lbl_T_Estado_Art"
        Me.Lbl_T_Estado_Art.Size = New System.Drawing.Size(81, 13)
        Me.Lbl_T_Estado_Art.TabIndex = 25
        Me.Lbl_T_Estado_Art.Text = "Estado Articulo:"
        '
        'Lbl_T_Descripcion
        '
        Me.Lbl_T_Descripcion.AutoSize = True
        Me.Lbl_T_Descripcion.Location = New System.Drawing.Point(289, 26)
        Me.Lbl_T_Descripcion.Name = "Lbl_T_Descripcion"
        Me.Lbl_T_Descripcion.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_T_Descripcion.TabIndex = 19
        Me.Lbl_T_Descripcion.Text = "Descripcion:"
        '
        'Lbl_T_Problema
        '
        Me.Lbl_T_Problema.AutoSize = True
        Me.Lbl_T_Problema.Location = New System.Drawing.Point(6, 74)
        Me.Lbl_T_Problema.Name = "Lbl_T_Problema"
        Me.Lbl_T_Problema.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_T_Problema.TabIndex = 29
        Me.Lbl_T_Problema.Text = "Problema Reportado:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.AutoSize = True
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "MOTIVO", True))
        Me.Lbl_Motivo.Location = New System.Drawing.Point(59, 98)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Motivo.TabIndex = 26
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Lbl_T_Traido_Por
        '
        Me.Lbl_T_Traido_Por.AutoSize = True
        Me.Lbl_T_Traido_Por.Location = New System.Drawing.Point(230, 146)
        Me.Lbl_T_Traido_Por.Name = "Lbl_T_Traido_Por"
        Me.Lbl_T_Traido_Por.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_T_Traido_Por.TabIndex = 33
        Me.Lbl_T_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOBindingSource, "DESCRIPCION", True))
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(368, 26)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
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
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(345, 123)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_Fecha_Ingreso.TabIndex = 30
        Me.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso"
        '
        'Lbl_Encargado_Bod
        '
        Me.Lbl_Encargado_Bod.AutoSize = True
        Me.Lbl_Encargado_Bod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ENCARGADO_BODEGA", True))
        Me.Lbl_Encargado_Bod.Location = New System.Drawing.Point(593, 123)
        Me.Lbl_Encargado_Bod.Name = "Lbl_Encargado_Bod"
        Me.Lbl_Encargado_Bod.Size = New System.Drawing.Size(99, 13)
        Me.Lbl_Encargado_Bod.TabIndex = 26
        Me.Lbl_Encargado_Bod.Text = "Encargado Bodega"
        '
        'Lbl_T_Encargado_Bod
        '
        Me.Lbl_T_Encargado_Bod.AutoSize = True
        Me.Lbl_T_Encargado_Bod.Location = New System.Drawing.Point(471, 123)
        Me.Lbl_T_Encargado_Bod.Name = "Lbl_T_Encargado_Bod"
        Me.Lbl_T_Encargado_Bod.Size = New System.Drawing.Size(102, 13)
        Me.Lbl_T_Encargado_Bod.TabIndex = 25
        Me.Lbl_T_Encargado_Bod.Text = "Encargado Bodega:"
        '
        'Lbl_T_Fecha_Ingeso
        '
        Me.Lbl_T_Fecha_Ingeso.AutoSize = True
        Me.Lbl_T_Fecha_Ingeso.Location = New System.Drawing.Point(230, 123)
        Me.Lbl_T_Fecha_Ingeso.Name = "Lbl_T_Fecha_Ingeso"
        Me.Lbl_T_Fecha_Ingeso.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_T_Fecha_Ingeso.TabIndex = 29
        Me.Lbl_T_Fecha_Ingeso.Text = "Fecha de Ingreso:"
        '
        'Cbx_Dummy2
        '
        Me.Cbx_Dummy2.DataSource = Me.ARTICULOBindingSource
        Me.Cbx_Dummy2.DisplayMember = "ARTICULO"
        Me.Cbx_Dummy2.FormattingEnabled = True
        Me.Cbx_Dummy2.Location = New System.Drawing.Point(164, 11)
        Me.Cbx_Dummy2.Name = "Cbx_Dummy2"
        Me.Cbx_Dummy2.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_Dummy2.TabIndex = 35
        Me.Cbx_Dummy2.Visible = False
        '
        'Cbx_dummy1
        '
        Me.Cbx_dummy1.DataSource = Me.CLIENTEBindingSource
        Me.Cbx_dummy1.DisplayMember = "CLIENTE"
        Me.Cbx_dummy1.FormattingEnabled = True
        Me.Cbx_dummy1.Location = New System.Drawing.Point(36, 10)
        Me.Cbx_dummy1.Name = "Cbx_dummy1"
        Me.Cbx_dummy1.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_dummy1.TabIndex = 34
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
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(1122, 36)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Fecha_Hora.TabIndex = 33
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Cbx_Boleta
        '
        Me.Cbx_Boleta.DataSource = Me.SCRDATOSREPARACIONBindingSource
        Me.Cbx_Boleta.DisplayMember = "REPARACION_NUMERO"
        Me.Cbx_Boleta.Enabled = False
        Me.Cbx_Boleta.FormattingEnabled = True
        Me.Cbx_Boleta.Location = New System.Drawing.Point(1151, 10)
        Me.Cbx_Boleta.Name = "Cbx_Boleta"
        Me.Cbx_Boleta.Size = New System.Drawing.Size(119, 21)
        Me.Cbx_Boleta.TabIndex = 32
        '
        'Lbl_Numero_Boleta
        '
        Me.Lbl_Numero_Boleta.AutoSize = True
        Me.Lbl_Numero_Boleta.Location = New System.Drawing.Point(1063, 13)
        Me.Lbl_Numero_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Numero_Boleta.Name = "Lbl_Numero_Boleta"
        Me.Lbl_Numero_Boleta.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_Numero_Boleta.TabIndex = 31
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 171)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION CLIENTE"
        '
        'Lbl_Nombre_Cliente
        '
        Me.Lbl_Nombre_Cliente.AutoSize = True
        Me.Lbl_Nombre_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre_Cliente.Location = New System.Drawing.Point(216, 26)
        Me.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente"
        Me.Lbl_Nombre_Cliente.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_Nombre_Cliente.TabIndex = 9
        Me.Lbl_Nombre_Cliente.Text = "Nombre_Cliente"
        '
        'Lbl_T_Cliente
        '
        Me.Lbl_T_Cliente.AutoSize = True
        Me.Lbl_T_Cliente.Location = New System.Drawing.Point(10, 26)
        Me.Lbl_T_Cliente.Name = "Lbl_T_Cliente"
        Me.Lbl_T_Cliente.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_T_Cliente.TabIndex = 6
        Me.Lbl_T_Cliente.Text = "Cliente:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Location = New System.Drawing.Point(49, 74)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Alias.TabIndex = 15
        Me.Lbl_Alias.Text = "Alias"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(10, 74)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_T_Alias.TabIndex = 14
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Fax
        '
        Me.Lbl_Fax.AutoSize = True
        Me.Lbl_Fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "FAX", True))
        Me.Lbl_Fax.Location = New System.Drawing.Point(237, 50)
        Me.Lbl_Fax.Name = "Lbl_Fax"
        Me.Lbl_Fax.Size = New System.Drawing.Size(24, 13)
        Me.Lbl_Fax.TabIndex = 17
        Me.Lbl_Fax.Text = "Fax"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_CLIENTE", True))
        Me.Lbl_Cliente.Location = New System.Drawing.Point(66, 26)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Codigo_Cliente"
        '
        'Lbl_T_Fax
        '
        Me.Lbl_T_Fax.AutoSize = True
        Me.Lbl_T_Fax.Location = New System.Drawing.Point(209, 50)
        Me.Lbl_T_Fax.Name = "Lbl_T_Fax"
        Me.Lbl_T_Fax.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_T_Fax.TabIndex = 16
        Me.Lbl_T_Fax.Text = "Fax:"
        '
        'Lbl_T_Nombre_Cliente
        '
        Me.Lbl_T_Nombre_Cliente.AutoSize = True
        Me.Lbl_T_Nombre_Cliente.Location = New System.Drawing.Point(155, 26)
        Me.Lbl_T_Nombre_Cliente.Name = "Lbl_T_Nombre_Cliente"
        Me.Lbl_T_Nombre_Cliente.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_T_Nombre_Cliente.TabIndex = 8
        Me.Lbl_T_Nombre_Cliente.Text = "Nombre:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(8, 50)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Telefono.TabIndex = 11
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Lbl_Numero_2
        '
        Me.Lbl_Numero_2.AutoSize = True
        Me.Lbl_Numero_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Lbl_Numero_2.Location = New System.Drawing.Point(132, 50)
        Me.Lbl_Numero_2.Name = "Lbl_Numero_2"
        Me.Lbl_Numero_2.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Numero_2.TabIndex = 13
        Me.Lbl_Numero_2.Text = "Numero 2"
        '
        'Lbl_Numero_1
        '
        Me.Lbl_Numero_1.AutoSize = True
        Me.Lbl_Numero_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Lbl_Numero_1.Location = New System.Drawing.Point(65, 50)
        Me.Lbl_Numero_1.Name = "Lbl_Numero_1"
        Me.Lbl_Numero_1.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Numero_1.TabIndex = 12
        Me.Lbl_Numero_1.Text = "Numero 1"
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
        'Gbx_Actualizaciones
        '
        Me.Gbx_Actualizaciones.Controls.Add(Me.Txt_Comentario)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Comentario)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_Fecha)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Fecha)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_Localizacion)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Localizacion)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_Usuario)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Usuario)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_Estado)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Estado)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_Numero_Actua)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Lbl_T_Numero_Actua)
        Me.Gbx_Actualizaciones.Controls.Add(Me.Dgv_Actualizaciones)
        Me.Gbx_Actualizaciones.Location = New System.Drawing.Point(8, 241)
        Me.Gbx_Actualizaciones.Name = "Gbx_Actualizaciones"
        Me.Gbx_Actualizaciones.Size = New System.Drawing.Size(1262, 232)
        Me.Gbx_Actualizaciones.TabIndex = 38
        Me.Gbx_Actualizaciones.TabStop = False
        Me.Gbx_Actualizaciones.Text = "Actualizaciones"
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Enabled = False
        Me.Txt_Comentario.Location = New System.Drawing.Point(931, 77)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(325, 121)
        Me.Txt_Comentario.TabIndex = 12
        '
        'Lbl_T_Comentario
        '
        Me.Lbl_T_Comentario.AutoSize = True
        Me.Lbl_T_Comentario.Location = New System.Drawing.Point(866, 80)
        Me.Lbl_T_Comentario.Name = "Lbl_T_Comentario"
        Me.Lbl_T_Comentario.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_T_Comentario.TabIndex = 11
        Me.Lbl_T_Comentario.Text = "Comentario:"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(1059, 48)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Fecha.TabIndex = 10
        '
        'Lbl_T_Fecha
        '
        Me.Lbl_T_Fecha.AutoSize = True
        Me.Lbl_T_Fecha.Location = New System.Drawing.Point(1014, 48)
        Me.Lbl_T_Fecha.Name = "Lbl_T_Fecha"
        Me.Lbl_T_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_T_Fecha.TabIndex = 9
        Me.Lbl_T_Fecha.Text = "Fecha:"
        '
        'Lbl_Localizacion
        '
        Me.Lbl_Localizacion.AutoSize = True
        Me.Lbl_Localizacion.Location = New System.Drawing.Point(935, 48)
        Me.Lbl_Localizacion.Name = "Lbl_Localizacion"
        Me.Lbl_Localizacion.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Localizacion.TabIndex = 8
        '
        'Lbl_T_Localizacion
        '
        Me.Lbl_T_Localizacion.AutoSize = True
        Me.Lbl_T_Localizacion.Location = New System.Drawing.Point(866, 48)
        Me.Lbl_T_Localizacion.Name = "Lbl_T_Localizacion"
        Me.Lbl_T_Localizacion.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_T_Localizacion.TabIndex = 7
        Me.Lbl_T_Localizacion.Text = "Localizacion:"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(1186, 20)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Usuario.TabIndex = 6
        '
        'Lbl_T_Usuario
        '
        Me.Lbl_T_Usuario.AutoSize = True
        Me.Lbl_T_Usuario.Location = New System.Drawing.Point(1141, 20)
        Me.Lbl_T_Usuario.Name = "Lbl_T_Usuario"
        Me.Lbl_T_Usuario.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_T_Usuario.TabIndex = 5
        Me.Lbl_T_Usuario.Text = "Usuario:"
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(1059, 20)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Estado.TabIndex = 4
        '
        'Lbl_T_Estado
        '
        Me.Lbl_T_Estado.AutoSize = True
        Me.Lbl_T_Estado.Location = New System.Drawing.Point(1014, 20)
        Me.Lbl_T_Estado.Name = "Lbl_T_Estado"
        Me.Lbl_T_Estado.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_T_Estado.TabIndex = 3
        Me.Lbl_T_Estado.Text = "Estado:"
        '
        'Lbl_Numero_Actua
        '
        Me.Lbl_Numero_Actua.AutoSize = True
        Me.Lbl_Numero_Actua.Location = New System.Drawing.Point(952, 20)
        Me.Lbl_Numero_Actua.Name = "Lbl_Numero_Actua"
        Me.Lbl_Numero_Actua.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Numero_Actua.TabIndex = 2
        '
        'Lbl_T_Numero_Actua
        '
        Me.Lbl_T_Numero_Actua.AutoSize = True
        Me.Lbl_T_Numero_Actua.Location = New System.Drawing.Point(866, 20)
        Me.Lbl_T_Numero_Actua.Name = "Lbl_T_Numero_Actua"
        Me.Lbl_T_Numero_Actua.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_T_Numero_Actua.TabIndex = 1
        Me.Lbl_T_Numero_Actua.Text = "Actualizacion #"
        '
        'Dgv_Actualizaciones
        '
        Me.Dgv_Actualizaciones.AllowUserToAddRows = False
        Me.Dgv_Actualizaciones.AllowUserToDeleteRows = False
        Me.Dgv_Actualizaciones.AllowUserToResizeColumns = False
        Me.Dgv_Actualizaciones.AllowUserToResizeRows = False
        Me.Dgv_Actualizaciones.AutoGenerateColumns = False
        Me.Dgv_Actualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Actualizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REPARACIONNUMERODataGridViewTextBoxColumn, Me.NUMEROACTUADataGridViewTextBoxColumn, Me.CLIENTEDataGridViewTextBoxColumn, Me.COMENTARIODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.LOCALIZACIONDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn})
        Me.Dgv_Actualizaciones.DataSource = Me.SCRCONSULTAREPARACIONBindingSource
        Me.Dgv_Actualizaciones.Location = New System.Drawing.Point(7, 20)
        Me.Dgv_Actualizaciones.Name = "Dgv_Actualizaciones"
        Me.Dgv_Actualizaciones.ReadOnly = True
        Me.Dgv_Actualizaciones.Size = New System.Drawing.Size(853, 150)
        Me.Dgv_Actualizaciones.TabIndex = 0
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "REPARACION NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NUMEROACTUADataGridViewTextBoxColumn
        '
        Me.NUMEROACTUADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_ACTUA"
        Me.NUMEROACTUADataGridViewTextBoxColumn.HeaderText = "NUMERO ACTUALIZACION"
        Me.NUMEROACTUADataGridViewTextBoxColumn.Name = "NUMEROACTUADataGridViewTextBoxColumn"
        Me.NUMEROACTUADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMEROACTUADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CLIENTEDataGridViewTextBoxColumn
        '
        Me.CLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.Name = "CLIENTEDataGridViewTextBoxColumn"
        Me.CLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COMENTARIODataGridViewTextBoxColumn
        '
        Me.COMENTARIODataGridViewTextBoxColumn.DataPropertyName = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.HeaderText = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.Name = "COMENTARIODataGridViewTextBoxColumn"
        Me.COMENTARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.COMENTARIODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.USUARIODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LOCALIZACIONDataGridViewTextBoxColumn
        '
        Me.LOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Name = "LOCALIZACIONDataGridViewTextBoxColumn"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOCALIZACIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SCRCONSULTAREPARACIONBindingSource
        '
        Me.SCRCONSULTAREPARACIONBindingSource.DataMember = "SCR_CONSULTA_REPARACION"
        Me.SCRCONSULTAREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_CONSULTA_REPARACIONTableAdapter
        '
        Me.SCR_CONSULTA_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'Frm_Consulta_Reparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 485)
        Me.Controls.Add(Me.Gbx_Actualizaciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cbx_Dummy2)
        Me.Controls.Add(Me.Cbx_dummy1)
        Me.Controls.Add(Me.Lbl_Fecha_Hora)
        Me.Controls.Add(Me.Cbx_Boleta)
        Me.Controls.Add(Me.Lbl_Numero_Boleta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consulta_Reparacion"
        Me.Text = "Consulta Reparacion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SCRDATOSREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gbx_Actualizaciones.ResumeLayout(False)
        Me.Gbx_Actualizaciones.PerformLayout()
        CType(Me.Dgv_Actualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_Numero_Serie As Label
    Friend WithEvents Lbl_Boleta_Chofer As Label
    Friend WithEvents Lbl_T_Numero_Serie As Label
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
    Friend WithEvents Lbl_Estado_Art As Label
    Friend WithEvents Lbl_T_Motivo As Label
    Friend WithEvents Lbl_T_Estado_Art As Label
    Friend WithEvents Lbl_T_Descripcion As Label
    Friend WithEvents Lbl_T_Problema As Label
    Friend WithEvents Lbl_Motivo As Label
    Friend WithEvents Lbl_T_Traido_Por As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents Lbl_Fecha_Ingreso As Label
    Friend WithEvents Lbl_Encargado_Bod As Label
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
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRDATOSREPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_DATOS_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter
    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As ExactusERP_TABLESTableAdapters.CLIENTETableAdapter
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter
    Friend WithEvents Gbx_Actualizaciones As GroupBox
    Friend WithEvents Dgv_Actualizaciones As DataGridView
    Friend WithEvents SCRCONSULTAREPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_CONSULTA_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter
    Friend WithEvents Txt_Comentario As TextBox
    Friend WithEvents Lbl_T_Comentario As Label
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents Lbl_T_Fecha As Label
    Friend WithEvents Lbl_Localizacion As Label
    Friend WithEvents Lbl_T_Localizacion As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Lbl_T_Usuario As Label
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents Lbl_T_Estado As Label
    Friend WithEvents Lbl_Numero_Actua As Label
    Friend WithEvents Lbl_T_Numero_Actua As Label
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROACTUADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMENTARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
