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
        Me.Lbl_Traido_Por = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Boleta = New System.Windows.Forms.Label()
        Me.Lbl_Articulo = New System.Windows.Forms.Label()
        Me.Lbl_T_Doc_Ref = New System.Windows.Forms.Label()
        Me.Lbl_T_Adicio_Art = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado_Rep = New System.Windows.Forms.Label()
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
        Me.Lbl_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Numero_2 = New System.Windows.Forms.Label()
        Me.Lbl_Numero_1 = New System.Windows.Forms.Label()
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.Gbx_Actualizaciones = New System.Windows.Forms.GroupBox()
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
        Me.Btn_Cotejar_Serie = New System.Windows.Forms.Button()
        Me.Txt_Serie = New System.Windows.Forms.TextBox()
        Me.Lbl_Serie_Numero = New System.Windows.Forms.Label()
        Me.Btn_Cotejar_Boleta = New System.Windows.Forms.Button()
        Me.Txt_Num_Boleta = New System.Windows.Forms.TextBox()
        Me.Lbl_Num_Boleta = New System.Windows.Forms.Label()
        Me.dg_reps_asociadas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.dg_reps_asociadas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Controls.Add(Me.Lbl_Traido_Por)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Boleta)
        Me.GroupBox2.Controls.Add(Me.Lbl_Articulo)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Doc_Ref)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Adicio_Art)
        Me.GroupBox2.Controls.Add(Me.Lbl_T_Estado_Rep)
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
        Me.GroupBox2.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(490, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 288)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACION ARTICULO Y REPARACION"
        '
        'Lbl_Numero_Serie
        '
        Me.Lbl_Numero_Serie.AutoSize = True
        Me.Lbl_Numero_Serie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "SERIE_PRODUCTO", True))
        Me.Lbl_Numero_Serie.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Numero_Serie.Location = New System.Drawing.Point(103, 94)
        Me.Lbl_Numero_Serie.Name = "Lbl_Numero_Serie"
        Me.Lbl_Numero_Serie.Size = New System.Drawing.Size(95, 16)
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
        Me.Lbl_Boleta_Chofer.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Boleta_Chofer.Location = New System.Drawing.Point(490, 197)
        Me.Lbl_Boleta_Chofer.Name = "Lbl_Boleta_Chofer"
        Me.Lbl_Boleta_Chofer.Size = New System.Drawing.Size(91, 16)
        Me.Lbl_Boleta_Chofer.TabIndex = 35
        Me.Lbl_Boleta_Chofer.Text = "Boleta Chofer"
        '
        'Lbl_T_Numero_Serie
        '
        Me.Lbl_T_Numero_Serie.AutoSize = True
        Me.Lbl_T_Numero_Serie.Location = New System.Drawing.Point(51, 95)
        Me.Lbl_T_Numero_Serie.Name = "Lbl_T_Numero_Serie"
        Me.Lbl_T_Numero_Serie.Size = New System.Drawing.Size(52, 15)
        Me.Lbl_T_Numero_Serie.TabIndex = 48
        Me.Lbl_T_Numero_Serie.Text = "Serie #"
        '
        'Lbl_T_Articulo
        '
        Me.Lbl_T_Articulo.AutoSize = True
        Me.Lbl_T_Articulo.Location = New System.Drawing.Point(51, 63)
        Me.Lbl_T_Articulo.Name = "Lbl_T_Articulo"
        Me.Lbl_T_Articulo.Size = New System.Drawing.Size(61, 15)
        Me.Lbl_T_Articulo.TabIndex = 3
        Me.Lbl_T_Articulo.Text = "Articulo:"
        '
        'Lbl_Adicional_Art
        '
        Me.Lbl_Adicional_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ADICIONAL_ART", True))
        Me.Lbl_Adicional_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Adicional_Art.Location = New System.Drawing.Point(119, 131)
        Me.Lbl_Adicional_Art.Name = "Lbl_Adicional_Art"
        Me.Lbl_Adicional_Art.Size = New System.Drawing.Size(259, 30)
        Me.Lbl_Adicional_Art.TabIndex = 22
        Me.Lbl_Adicional_Art.Text = "Adicional"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(392, 197)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(94, 15)
        Me.Lbl_.TabIndex = 33
        Me.Lbl_.Text = "Boleta Chofer:"
        '
        'Lbl_Doc_Ref
        '
        Me.Lbl_Doc_Ref.AutoSize = True
        Me.Lbl_Doc_Ref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "DOCUMENTO_REF", True))
        Me.Lbl_Doc_Ref.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Doc_Ref.Location = New System.Drawing.Point(201, 260)
        Me.Lbl_Doc_Ref.Name = "Lbl_Doc_Ref"
        Me.Lbl_Doc_Ref.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_Doc_Ref.TabIndex = 32
        Me.Lbl_Doc_Ref.Text = "Doc_Ref"
        '
        'Lbl_Traido_Por
        '
        Me.Lbl_Traido_Por.AutoSize = True
        Me.Lbl_Traido_Por.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "TRAIDO_POR", True))
        Me.Lbl_Traido_Por.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Traido_Por.Location = New System.Drawing.Point(462, 164)
        Me.Lbl_Traido_Por.Name = "Lbl_Traido_Por"
        Me.Lbl_Traido_Por.Size = New System.Drawing.Size(71, 16)
        Me.Lbl_Traido_Por.TabIndex = 34
        Me.Lbl_Traido_Por.Text = "Traido Por"
        '
        'Lbl_T_Estado_Boleta
        '
        Me.Lbl_T_Estado_Boleta.AutoSize = True
        Me.Lbl_T_Estado_Boleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO", True))
        Me.Lbl_T_Estado_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_T_Estado_Boleta.Location = New System.Drawing.Point(449, 252)
        Me.Lbl_T_Estado_Boleta.Name = "Lbl_T_Estado_Boleta"
        Me.Lbl_T_Estado_Boleta.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_T_Estado_Boleta.TabIndex = 32
        Me.Lbl_T_Estado_Boleta.Text = "Estado Bol"
        '
        'Lbl_Articulo
        '
        Me.Lbl_Articulo.AutoSize = True
        Me.Lbl_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_ART", True))
        Me.Lbl_Articulo.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Articulo.Location = New System.Drawing.Point(110, 64)
        Me.Lbl_Articulo.Name = "Lbl_Articulo"
        Me.Lbl_Articulo.Size = New System.Drawing.Size(88, 16)
        Me.Lbl_Articulo.TabIndex = 2
        Me.Lbl_Articulo.Text = "BI0000-000"
        '
        'Lbl_T_Doc_Ref
        '
        Me.Lbl_T_Doc_Ref.AutoSize = True
        Me.Lbl_T_Doc_Ref.Location = New System.Drawing.Point(48, 260)
        Me.Lbl_T_Doc_Ref.Name = "Lbl_T_Doc_Ref"
        Me.Lbl_T_Doc_Ref.Size = New System.Drawing.Size(147, 15)
        Me.Lbl_T_Doc_Ref.TabIndex = 31
        Me.Lbl_T_Doc_Ref.Text = "Documento Referencia:"
        '
        'Lbl_T_Adicio_Art
        '
        Me.Lbl_T_Adicio_Art.AutoSize = True
        Me.Lbl_T_Adicio_Art.Location = New System.Drawing.Point(51, 131)
        Me.Lbl_T_Adicio_Art.Name = "Lbl_T_Adicio_Art"
        Me.Lbl_T_Adicio_Art.Size = New System.Drawing.Size(67, 15)
        Me.Lbl_T_Adicio_Art.TabIndex = 21
        Me.Lbl_T_Adicio_Art.Text = "Adicional:"
        '
        'Lbl_T_Estado_Rep
        '
        Me.Lbl_T_Estado_Rep.AutoSize = True
        Me.Lbl_T_Estado_Rep.Location = New System.Drawing.Point(391, 252)
        Me.Lbl_T_Estado_Rep.Name = "Lbl_T_Estado_Rep"
        Me.Lbl_T_Estado_Rep.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_T_Estado_Rep.TabIndex = 31
        Me.Lbl_T_Estado_Rep.Text = "Estado:"
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "PROBLEMA_REPORTADO", True))
        Me.Lbl_Problema_Reportado.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(184, 164)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(194, 38)
        Me.Lbl_Problema_Reportado.TabIndex = 30
        Me.Lbl_Problema_Reportado.Text = "Problema Reportado"
        '
        'Lbl_Estado_Art
        '
        Me.Lbl_Estado_Art.AutoSize = True
        Me.Lbl_Estado_Art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ESTADO_ART", True))
        Me.Lbl_Estado_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Estado_Art.Location = New System.Drawing.Point(496, 99)
        Me.Lbl_Estado_Art.Name = "Lbl_Estado_Art"
        Me.Lbl_Estado_Art.Size = New System.Drawing.Size(79, 16)
        Me.Lbl_Estado_Art.TabIndex = 28
        Me.Lbl_Estado_Art.Text = "Estado_Art"
        '
        'Lbl_T_Motivo
        '
        Me.Lbl_T_Motivo.AutoSize = True
        Me.Lbl_T_Motivo.Location = New System.Drawing.Point(51, 223)
        Me.Lbl_T_Motivo.Name = "Lbl_T_Motivo"
        Me.Lbl_T_Motivo.Size = New System.Drawing.Size(54, 15)
        Me.Lbl_T_Motivo.TabIndex = 27
        Me.Lbl_T_Motivo.Text = "Motivo:"
        '
        'Lbl_T_Estado_Art
        '
        Me.Lbl_T_Estado_Art.AutoSize = True
        Me.Lbl_T_Estado_Art.Location = New System.Drawing.Point(392, 99)
        Me.Lbl_T_Estado_Art.Name = "Lbl_T_Estado_Art"
        Me.Lbl_T_Estado_Art.Size = New System.Drawing.Size(107, 15)
        Me.Lbl_T_Estado_Art.TabIndex = 25
        Me.Lbl_T_Estado_Art.Text = "Estado Articulo:"
        '
        'Lbl_T_Descripcion
        '
        Me.Lbl_T_Descripcion.AutoSize = True
        Me.Lbl_T_Descripcion.Location = New System.Drawing.Point(392, 43)
        Me.Lbl_T_Descripcion.Name = "Lbl_T_Descripcion"
        Me.Lbl_T_Descripcion.Size = New System.Drawing.Size(83, 15)
        Me.Lbl_T_Descripcion.TabIndex = 19
        Me.Lbl_T_Descripcion.Text = "Descripcion:"
        '
        'Lbl_T_Problema
        '
        Me.Lbl_T_Problema.AutoSize = True
        Me.Lbl_T_Problema.Location = New System.Drawing.Point(51, 164)
        Me.Lbl_T_Problema.Name = "Lbl_T_Problema"
        Me.Lbl_T_Problema.Size = New System.Drawing.Size(135, 15)
        Me.Lbl_T_Problema.TabIndex = 29
        Me.Lbl_T_Problema.Text = "Problema Reportado:"
        '
        'Lbl_Motivo
        '
        Me.Lbl_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "MOTIVO", True))
        Me.Lbl_Motivo.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Motivo.Location = New System.Drawing.Point(103, 223)
        Me.Lbl_Motivo.Name = "Lbl_Motivo"
        Me.Lbl_Motivo.Size = New System.Drawing.Size(275, 31)
        Me.Lbl_Motivo.TabIndex = 26
        Me.Lbl_Motivo.Text = "Motivo"
        '
        'Lbl_T_Traido_Por
        '
        Me.Lbl_T_Traido_Por.AutoSize = True
        Me.Lbl_T_Traido_Por.Location = New System.Drawing.Point(392, 164)
        Me.Lbl_T_Traido_Por.Name = "Lbl_T_Traido_Por"
        Me.Lbl_T_Traido_Por.Size = New System.Drawing.Size(76, 15)
        Me.Lbl_T_Traido_Por.TabIndex = 33
        Me.Lbl_T_Traido_Por.Text = "Traido Por:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOBindingSource, "DESCRIPCION", True))
        Me.Lbl_Descripcion.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(488, 43)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(191, 42)
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
        Me.Lbl_Fecha_Ingreso.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Fecha_Ingreso.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Fecha_Ingreso.Location = New System.Drawing.Point(167, 32)
        Me.Lbl_Fecha_Ingreso.Name = "Lbl_Fecha_Ingreso"
        Me.Lbl_Fecha_Ingreso.Size = New System.Drawing.Size(100, 16)
        Me.Lbl_Fecha_Ingreso.TabIndex = 30
        Me.Lbl_Fecha_Ingreso.Text = "Fecha Ingreso"
        '
        'Lbl_Encargado_Bod
        '
        Me.Lbl_Encargado_Bod.AutoSize = True
        Me.Lbl_Encargado_Bod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "ENCARGADO_BODEGA", True))
        Me.Lbl_Encargado_Bod.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Encargado_Bod.Location = New System.Drawing.Point(514, 224)
        Me.Lbl_Encargado_Bod.Name = "Lbl_Encargado_Bod"
        Me.Lbl_Encargado_Bod.Size = New System.Drawing.Size(121, 16)
        Me.Lbl_Encargado_Bod.TabIndex = 26
        Me.Lbl_Encargado_Bod.Text = "Encargado Bodega"
        '
        'Lbl_T_Encargado_Bod
        '
        Me.Lbl_T_Encargado_Bod.AutoSize = True
        Me.Lbl_T_Encargado_Bod.Location = New System.Drawing.Point(392, 224)
        Me.Lbl_T_Encargado_Bod.Name = "Lbl_T_Encargado_Bod"
        Me.Lbl_T_Encargado_Bod.Size = New System.Drawing.Size(122, 15)
        Me.Lbl_T_Encargado_Bod.TabIndex = 25
        Me.Lbl_T_Encargado_Bod.Text = "Encargado Bodega:"
        '
        'Lbl_T_Fecha_Ingeso
        '
        Me.Lbl_T_Fecha_Ingeso.AutoSize = True
        Me.Lbl_T_Fecha_Ingeso.Location = New System.Drawing.Point(48, 33)
        Me.Lbl_T_Fecha_Ingeso.Name = "Lbl_T_Fecha_Ingeso"
        Me.Lbl_T_Fecha_Ingeso.Size = New System.Drawing.Size(113, 15)
        Me.Lbl_T_Fecha_Ingeso.TabIndex = 29
        Me.Lbl_T_Fecha_Ingeso.Text = "Fecha de Ingreso:"
        '
        'Cbx_Dummy2
        '
        Me.Cbx_Dummy2.DataSource = Me.ARTICULOBindingSource
        Me.Cbx_Dummy2.DisplayMember = "ARTICULO"
        Me.Cbx_Dummy2.FormattingEnabled = True
        Me.Cbx_Dummy2.Location = New System.Drawing.Point(660, 9)
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
        Me.Cbx_dummy1.Location = New System.Drawing.Point(532, 8)
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
        Me.Lbl_Fecha_Hora.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Hora.Location = New System.Drawing.Point(861, 13)
        Me.Lbl_Fecha_Hora.Name = "Lbl_Fecha_Hora"
        Me.Lbl_Fecha_Hora.Size = New System.Drawing.Size(85, 16)
        Me.Lbl_Fecha_Hora.TabIndex = 33
        Me.Lbl_Fecha_Hora.Text = "Fecha_Hora"
        '
        'Cbx_Boleta
        '
        Me.Cbx_Boleta.DataSource = Me.SCRDATOSREPARACIONBindingSource
        Me.Cbx_Boleta.DisplayMember = "REPARACION_NUMERO"
        Me.Cbx_Boleta.Enabled = False
        Me.Cbx_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Boleta.FormattingEnabled = True
        Me.Cbx_Boleta.Location = New System.Drawing.Point(1134, 13)
        Me.Cbx_Boleta.Name = "Cbx_Boleta"
        Me.Cbx_Boleta.Size = New System.Drawing.Size(119, 23)
        Me.Cbx_Boleta.TabIndex = 32
        '
        'Lbl_Numero_Boleta
        '
        Me.Lbl_Numero_Boleta.AutoSize = True
        Me.Lbl_Numero_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero_Boleta.Location = New System.Drawing.Point(1046, 16)
        Me.Lbl_Numero_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Numero_Boleta.Name = "Lbl_Numero_Boleta"
        Me.Lbl_Numero_Boleta.Size = New System.Drawing.Size(89, 16)
        Me.Lbl_Numero_Boleta.TabIndex = 31
        Me.Lbl_Numero_Boleta.Text = "Reparacion #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_Nombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Alias)
        Me.GroupBox1.Controls.Add(Me.Lbl_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_T_Nombre_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Telefono)
        Me.GroupBox1.Controls.Add(Me.Lbl_Numero_2)
        Me.GroupBox1.Controls.Add(Me.Lbl_Numero_1)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 142)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION CLIENTE"
        '
        'Lbl_Nombre_Cliente
        '
        Me.Lbl_Nombre_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Nombre_Cliente.Location = New System.Drawing.Point(239, 26)
        Me.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente"
        Me.Lbl_Nombre_Cliente.Size = New System.Drawing.Size(200, 39)
        Me.Lbl_Nombre_Cliente.TabIndex = 9
        Me.Lbl_Nombre_Cliente.Text = "Nombre_Cliente"
        '
        'Lbl_T_Cliente
        '
        Me.Lbl_T_Cliente.AutoSize = True
        Me.Lbl_T_Cliente.Location = New System.Drawing.Point(10, 26)
        Me.Lbl_T_Cliente.Name = "Lbl_T_Cliente"
        Me.Lbl_T_Cliente.Size = New System.Drawing.Size(54, 15)
        Me.Lbl_T_Cliente.TabIndex = 6
        Me.Lbl_T_Cliente.Text = "Cliente:"
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Lbl_Alias.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Alias.Location = New System.Drawing.Point(56, 92)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(272, 43)
        Me.Lbl_Alias.TabIndex = 15
        Me.Lbl_Alias.Text = "Alias"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(8, 92)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(42, 15)
        Me.Lbl_T_Alias.TabIndex = 14
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCRDATOSREPARACIONBindingSource, "CODIGO_CLIENTE", True))
        Me.Lbl_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Cliente.Location = New System.Drawing.Point(66, 26)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(98, 16)
        Me.Lbl_Cliente.TabIndex = 7
        Me.Lbl_Cliente.Text = "Codigo_Cliente"
        '
        'Lbl_T_Nombre_Cliente
        '
        Me.Lbl_T_Nombre_Cliente.AutoSize = True
        Me.Lbl_T_Nombre_Cliente.Location = New System.Drawing.Point(178, 26)
        Me.Lbl_T_Nombre_Cliente.Name = "Lbl_T_Nombre_Cliente"
        Me.Lbl_T_Nombre_Cliente.Size = New System.Drawing.Size(58, 15)
        Me.Lbl_T_Nombre_Cliente.TabIndex = 8
        Me.Lbl_T_Nombre_Cliente.Text = "Nombre:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Location = New System.Drawing.Point(11, 65)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Telefono.TabIndex = 11
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Lbl_Numero_2
        '
        Me.Lbl_Numero_2.AutoSize = True
        Me.Lbl_Numero_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Lbl_Numero_2.Location = New System.Drawing.Point(188, 65)
        Me.Lbl_Numero_2.Name = "Lbl_Numero_2"
        Me.Lbl_Numero_2.Size = New System.Drawing.Size(66, 15)
        Me.Lbl_Numero_2.TabIndex = 13
        Me.Lbl_Numero_2.Text = "Numero 2"
        '
        'Lbl_Numero_1
        '
        Me.Lbl_Numero_1.AutoSize = True
        Me.Lbl_Numero_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Lbl_Numero_1.Font = New System.Drawing.Font("Square721 BT", 9.25!)
        Me.Lbl_Numero_1.Location = New System.Drawing.Point(72, 65)
        Me.Lbl_Numero_1.Name = "Lbl_Numero_1"
        Me.Lbl_Numero_1.Size = New System.Drawing.Size(69, 16)
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
        Me.Gbx_Actualizaciones.Controls.Add(Me.Dgv_Actualizaciones)
        Me.Gbx_Actualizaciones.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Actualizaciones.Location = New System.Drawing.Point(102, 360)
        Me.Gbx_Actualizaciones.Name = "Gbx_Actualizaciones"
        Me.Gbx_Actualizaciones.Size = New System.Drawing.Size(902, 180)
        Me.Gbx_Actualizaciones.TabIndex = 38
        Me.Gbx_Actualizaciones.TabStop = False
        Me.Gbx_Actualizaciones.Text = "ACTUALIZACIONES"
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
        Me.Dgv_Actualizaciones.Location = New System.Drawing.Point(6, 31)
        Me.Dgv_Actualizaciones.Name = "Dgv_Actualizaciones"
        Me.Dgv_Actualizaciones.ReadOnly = True
        Me.Dgv_Actualizaciones.Size = New System.Drawing.Size(853, 138)
        Me.Dgv_Actualizaciones.TabIndex = 0
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "REPARACION"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Width = 90
        '
        'NUMEROACTUADataGridViewTextBoxColumn
        '
        Me.NUMEROACTUADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_ACTUA"
        Me.NUMEROACTUADataGridViewTextBoxColumn.HeaderText = "ACTUALIZACION"
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
        'Btn_Cotejar_Serie
        '
        Me.Btn_Cotejar_Serie.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cotejar_Serie.Location = New System.Drawing.Point(170, 147)
        Me.Btn_Cotejar_Serie.Name = "Btn_Cotejar_Serie"
        Me.Btn_Cotejar_Serie.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cotejar_Serie.TabIndex = 44
        Me.Btn_Cotejar_Serie.Text = "COTEJAR"
        Me.Btn_Cotejar_Serie.UseVisualStyleBackColor = True
        '
        'Txt_Serie
        '
        Me.Txt_Serie.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Serie.Location = New System.Drawing.Point(64, 149)
        Me.Txt_Serie.Name = "Txt_Serie"
        Me.Txt_Serie.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Serie.TabIndex = 43
        '
        'Lbl_Serie_Numero
        '
        Me.Lbl_Serie_Numero.AutoSize = True
        Me.Lbl_Serie_Numero.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Serie_Numero.Location = New System.Drawing.Point(92, 130)
        Me.Lbl_Serie_Numero.Name = "Lbl_Serie_Numero"
        Me.Lbl_Serie_Numero.Size = New System.Drawing.Size(57, 16)
        Me.Lbl_Serie_Numero.TabIndex = 42
        Me.Lbl_Serie_Numero.Text = "Serie #"
        '
        'Btn_Cotejar_Boleta
        '
        Me.Btn_Cotejar_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cotejar_Boleta.Location = New System.Drawing.Point(170, 85)
        Me.Btn_Cotejar_Boleta.Name = "Btn_Cotejar_Boleta"
        Me.Btn_Cotejar_Boleta.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cotejar_Boleta.TabIndex = 41
        Me.Btn_Cotejar_Boleta.Text = "COTEJAR"
        Me.Btn_Cotejar_Boleta.UseVisualStyleBackColor = True
        '
        'Txt_Num_Boleta
        '
        Me.Txt_Num_Boleta.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Num_Boleta.Location = New System.Drawing.Point(64, 87)
        Me.Txt_Num_Boleta.Name = "Txt_Num_Boleta"
        Me.Txt_Num_Boleta.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Num_Boleta.TabIndex = 40
        '
        'Lbl_Num_Boleta
        '
        Me.Lbl_Num_Boleta.AutoSize = True
        Me.Lbl_Num_Boleta.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Num_Boleta.Location = New System.Drawing.Point(84, 68)
        Me.Lbl_Num_Boleta.Name = "Lbl_Num_Boleta"
        Me.Lbl_Num_Boleta.Size = New System.Drawing.Size(65, 16)
        Me.Lbl_Num_Boleta.TabIndex = 39
        Me.Lbl_Num_Boleta.Text = "Boleta #"
        '
        'dg_reps_asociadas
        '
        Me.dg_reps_asociadas.AllowUserToAddRows = False
        Me.dg_reps_asociadas.AllowUserToDeleteRows = False
        Me.dg_reps_asociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_reps_asociadas.Location = New System.Drawing.Point(266, 68)
        Me.dg_reps_asociadas.Name = "dg_reps_asociadas"
        Me.dg_reps_asociadas.ReadOnly = True
        Me.dg_reps_asociadas.Size = New System.Drawing.Size(181, 110)
        Me.dg_reps_asociadas.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "REPARACIONES ASOCIADAS"
        '
        'Frm_Consulta_Reparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_reps_asociadas)
        Me.Controls.Add(Me.Btn_Cotejar_Serie)
        Me.Controls.Add(Me.Txt_Serie)
        Me.Controls.Add(Me.Lbl_Serie_Numero)
        Me.Controls.Add(Me.Btn_Cotejar_Boleta)
        Me.Controls.Add(Me.Txt_Num_Boleta)
        Me.Controls.Add(Me.Lbl_Num_Boleta)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        CType(Me.Dgv_Actualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_reps_asociadas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Lbl_Traido_Por As Label
    Friend WithEvents Lbl_T_Estado_Boleta As Label
    Friend WithEvents Lbl_Articulo As Label
    Friend WithEvents Lbl_T_Doc_Ref As Label
    Friend WithEvents Lbl_T_Adicio_Art As Label
    Friend WithEvents Lbl_T_Estado_Rep As Label
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
    Friend WithEvents Lbl_Cliente As Label
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
    Friend WithEvents Btn_Cotejar_Serie As Button
    Friend WithEvents Txt_Serie As TextBox
    Friend WithEvents Lbl_Serie_Numero As Label
    Friend WithEvents Btn_Cotejar_Boleta As Button
    Friend WithEvents Txt_Num_Boleta As TextBox
    Friend WithEvents Lbl_Num_Boleta As Label
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROACTUADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMENTARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dg_reps_asociadas As DataGridView
    Friend WithEvents Label1 As Label
End Class
