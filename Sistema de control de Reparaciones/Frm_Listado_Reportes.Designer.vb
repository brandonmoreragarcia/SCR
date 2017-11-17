<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Listado_Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listado_Reportes))
        Me.Txt_Dato = New System.Windows.Forms.TextBox()
        Me.Lbl_Dato = New System.Windows.Forms.Label()
        Me.bt_listado_rep_estado = New System.Windows.Forms.Button()
        Me.bt_listado_rep_lead = New System.Windows.Forms.Button()
        Me.bt_consulta_num_queja = New System.Windows.Forms.Button()
        Me.bt_impresion_reparacion = New System.Windows.Forms.Button()
        Me.bt_consulta_cliente = New System.Windows.Forms.Button()
        Me.bt_etiqueta_salida = New System.Windows.Forms.Button()
        Me.bt_listado_quejas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gb_reparaciones_estado = New System.Windows.Forms.GroupBox()
        Me.Btn_Filtrar = New System.Windows.Forms.Button()
        Me.bt_eliminar_filtros = New System.Windows.Forms.Button()
        Me.Cbx_Estados = New System.Windows.Forms.ComboBox()
        Me.Check_Estado = New System.Windows.Forms.CheckBox()
        Me.Check_fecha = New System.Windows.Forms.CheckBox()
        Me.Lbl_Fecha_Final = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Inicio = New System.Windows.Forms.Label()
        Me.Dtp_Fecha_Final = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dgv_Rep_Total = New System.Windows.Forms.DataGridView()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPARACIONNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOLETADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTOREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEPRODUCTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRPROCREPLISTADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_PROC_REP_LISTADOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_PROC_REP_LISTADOTableAdapter()
        Me.SCR_ESTADOS_TOTALTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADOS_TOTALTableAdapter()
        Me.gb_reparacion_lead = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Fecha_Final = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_Fecha_Inicial = New System.Windows.Forms.MaskedTextBox()
        Me.Crv_Listado_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Inicial = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb_reparaciones_estado.SuspendLayout()
        CType(Me.Dgv_Rep_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRPROCREPLISTADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_reparacion_lead.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Dato
        '
        Me.Txt_Dato.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Dato.Location = New System.Drawing.Point(101, 44)
        Me.Txt_Dato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Dato.Name = "Txt_Dato"
        Me.Txt_Dato.Size = New System.Drawing.Size(153, 23)
        Me.Txt_Dato.TabIndex = 3
        '
        'Lbl_Dato
        '
        Me.Lbl_Dato.AutoSize = True
        Me.Lbl_Dato.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dato.Location = New System.Drawing.Point(49, 47)
        Me.Lbl_Dato.Name = "Lbl_Dato"
        Me.Lbl_Dato.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Dato.TabIndex = 6
        Me.Lbl_Dato.Text = "DATO"
        '
        'bt_listado_rep_estado
        '
        Me.bt_listado_rep_estado.Location = New System.Drawing.Point(52, 86)
        Me.bt_listado_rep_estado.Name = "bt_listado_rep_estado"
        Me.bt_listado_rep_estado.Size = New System.Drawing.Size(202, 57)
        Me.bt_listado_rep_estado.TabIndex = 11
        Me.bt_listado_rep_estado.Text = "LISTADO DE REPARACIONES POR ESTADO"
        Me.bt_listado_rep_estado.UseVisualStyleBackColor = True
        '
        'bt_listado_rep_lead
        '
        Me.bt_listado_rep_lead.Location = New System.Drawing.Point(52, 159)
        Me.bt_listado_rep_lead.Name = "bt_listado_rep_lead"
        Me.bt_listado_rep_lead.Size = New System.Drawing.Size(202, 59)
        Me.bt_listado_rep_lead.TabIndex = 12
        Me.bt_listado_rep_lead.Text = "LISTADO DE REPARACIONES CON LEAD"
        Me.bt_listado_rep_lead.UseVisualStyleBackColor = True
        '
        'bt_consulta_num_queja
        '
        Me.bt_consulta_num_queja.Location = New System.Drawing.Point(52, 234)
        Me.bt_consulta_num_queja.Name = "bt_consulta_num_queja"
        Me.bt_consulta_num_queja.Size = New System.Drawing.Size(202, 56)
        Me.bt_consulta_num_queja.TabIndex = 13
        Me.bt_consulta_num_queja.Text = "CONSULTA POR NÚMERO DE QUEJA"
        Me.bt_consulta_num_queja.UseVisualStyleBackColor = True
        '
        'bt_impresion_reparacion
        '
        Me.bt_impresion_reparacion.Location = New System.Drawing.Point(52, 308)
        Me.bt_impresion_reparacion.Name = "bt_impresion_reparacion"
        Me.bt_impresion_reparacion.Size = New System.Drawing.Size(202, 54)
        Me.bt_impresion_reparacion.TabIndex = 14
        Me.bt_impresion_reparacion.Text = "IMPRESION DE REPARACIÓN"
        Me.bt_impresion_reparacion.UseVisualStyleBackColor = True
        '
        'bt_consulta_cliente
        '
        Me.bt_consulta_cliente.Location = New System.Drawing.Point(52, 379)
        Me.bt_consulta_cliente.Name = "bt_consulta_cliente"
        Me.bt_consulta_cliente.Size = New System.Drawing.Size(202, 36)
        Me.bt_consulta_cliente.TabIndex = 15
        Me.bt_consulta_cliente.Text = "CONSULTA POR CLIENTE"
        Me.bt_consulta_cliente.UseVisualStyleBackColor = True
        '
        'bt_etiqueta_salida
        '
        Me.bt_etiqueta_salida.Location = New System.Drawing.Point(52, 431)
        Me.bt_etiqueta_salida.Name = "bt_etiqueta_salida"
        Me.bt_etiqueta_salida.Size = New System.Drawing.Size(202, 36)
        Me.bt_etiqueta_salida.TabIndex = 16
        Me.bt_etiqueta_salida.Text = "ETIQUETA SALIDA"
        Me.bt_etiqueta_salida.UseVisualStyleBackColor = True
        '
        'bt_listado_quejas
        '
        Me.bt_listado_quejas.Location = New System.Drawing.Point(52, 564)
        Me.bt_listado_quejas.Name = "bt_listado_quejas"
        Me.bt_listado_quejas.Size = New System.Drawing.Size(202, 51)
        Me.bt_listado_quejas.TabIndex = 17
        Me.bt_listado_quejas.Text = "LISTADO QUEJAS"
        Me.bt_listado_quejas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_consulta_cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_Dato)
        Me.GroupBox1.Controls.Add(Me.bt_listado_rep_estado)
        Me.GroupBox1.Controls.Add(Me.Txt_Dato)
        Me.GroupBox1.Controls.Add(Me.bt_impresion_reparacion)
        Me.GroupBox1.Controls.Add(Me.bt_listado_quejas)
        Me.GroupBox1.Controls.Add(Me.bt_consulta_num_queja)
        Me.GroupBox1.Controls.Add(Me.bt_etiqueta_salida)
        Me.GroupBox1.Controls.Add(Me.bt_listado_rep_lead)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 507)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTAS"
        '
        'gb_reparaciones_estado
        '
        Me.gb_reparaciones_estado.Controls.Add(Me.Btn_Filtrar)
        Me.gb_reparaciones_estado.Controls.Add(Me.bt_eliminar_filtros)
        Me.gb_reparaciones_estado.Controls.Add(Me.Cbx_Estados)
        Me.gb_reparaciones_estado.Controls.Add(Me.Check_Estado)
        Me.gb_reparaciones_estado.Controls.Add(Me.Check_fecha)
        Me.gb_reparaciones_estado.Controls.Add(Me.Lbl_Fecha_Final)
        Me.gb_reparaciones_estado.Controls.Add(Me.Lbl_Fecha_Inicio)
        Me.gb_reparaciones_estado.Controls.Add(Me.Dtp_Fecha_Final)
        Me.gb_reparaciones_estado.Controls.Add(Me.Dtp_Fecha_Inicio)
        Me.gb_reparaciones_estado.Controls.Add(Me.Dgv_Rep_Total)
        Me.gb_reparaciones_estado.Location = New System.Drawing.Point(413, 25)
        Me.gb_reparaciones_estado.Name = "gb_reparaciones_estado"
        Me.gb_reparaciones_estado.Size = New System.Drawing.Size(824, 507)
        Me.gb_reparaciones_estado.TabIndex = 19
        Me.gb_reparaciones_estado.TabStop = False
        Me.gb_reparaciones_estado.Text = "REPARACIONES"
        Me.gb_reparaciones_estado.Visible = False
        '
        'Btn_Filtrar
        '
        Me.Btn_Filtrar.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Filtrar.Location = New System.Drawing.Point(448, 53)
        Me.Btn_Filtrar.Name = "Btn_Filtrar"
        Me.Btn_Filtrar.Size = New System.Drawing.Size(156, 30)
        Me.Btn_Filtrar.TabIndex = 19
        Me.Btn_Filtrar.Text = "FILTRAR"
        Me.Btn_Filtrar.UseVisualStyleBackColor = True
        '
        'bt_eliminar_filtros
        '
        Me.bt_eliminar_filtros.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar_filtros.Location = New System.Drawing.Point(448, 99)
        Me.bt_eliminar_filtros.Name = "bt_eliminar_filtros"
        Me.bt_eliminar_filtros.Size = New System.Drawing.Size(156, 30)
        Me.bt_eliminar_filtros.TabIndex = 18
        Me.bt_eliminar_filtros.Text = "ELIMINAR FILTROS"
        Me.bt_eliminar_filtros.UseVisualStyleBackColor = True
        '
        'Cbx_Estados
        '
        Me.Cbx_Estados.DisplayMember = "ESTADO"
        Me.Cbx_Estados.DropDownWidth = 240
        Me.Cbx_Estados.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Estados.FormattingEnabled = True
        Me.Cbx_Estados.Location = New System.Drawing.Point(262, 79)
        Me.Cbx_Estados.Name = "Cbx_Estados"
        Me.Cbx_Estados.Size = New System.Drawing.Size(121, 24)
        Me.Cbx_Estados.TabIndex = 17
        Me.Cbx_Estados.Visible = False
        '
        'Check_Estado
        '
        Me.Check_Estado.AutoSize = True
        Me.Check_Estado.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Estado.Location = New System.Drawing.Point(275, 53)
        Me.Check_Estado.Name = "Check_Estado"
        Me.Check_Estado.Size = New System.Drawing.Size(95, 20)
        Me.Check_Estado.TabIndex = 16
        Me.Check_Estado.Text = "Por estado"
        Me.Check_Estado.UseVisualStyleBackColor = True
        '
        'Check_fecha
        '
        Me.Check_fecha.AutoSize = True
        Me.Check_fecha.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_fecha.Location = New System.Drawing.Point(90, 53)
        Me.Check_fecha.Name = "Check_fecha"
        Me.Check_fecha.Size = New System.Drawing.Size(89, 20)
        Me.Check_fecha.TabIndex = 15
        Me.Check_fecha.Text = "Por Fecha"
        Me.Check_fecha.UseVisualStyleBackColor = True
        '
        'Lbl_Fecha_Final
        '
        Me.Lbl_Fecha_Final.AutoSize = True
        Me.Lbl_Fecha_Final.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Final.Location = New System.Drawing.Point(48, 110)
        Me.Lbl_Fecha_Final.Name = "Lbl_Fecha_Final"
        Me.Lbl_Fecha_Final.Size = New System.Drawing.Size(24, 16)
        Me.Lbl_Fecha_Final.TabIndex = 14
        Me.Lbl_Fecha_Final.Text = "Al:"
        Me.Lbl_Fecha_Final.Visible = False
        '
        'Lbl_Fecha_Inicio
        '
        Me.Lbl_Fecha_Inicio.AutoSize = True
        Me.Lbl_Fecha_Inicio.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Inicio.Location = New System.Drawing.Point(40, 85)
        Me.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio"
        Me.Lbl_Fecha_Inicio.Size = New System.Drawing.Size(32, 16)
        Me.Lbl_Fecha_Inicio.TabIndex = 13
        Me.Lbl_Fecha_Inicio.Text = "Del:"
        Me.Lbl_Fecha_Inicio.Visible = False
        '
        'Dtp_Fecha_Final
        '
        Me.Dtp_Fecha_Final.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_Final.Location = New System.Drawing.Point(77, 106)
        Me.Dtp_Fecha_Final.Name = "Dtp_Fecha_Final"
        Me.Dtp_Fecha_Final.Size = New System.Drawing.Size(152, 23)
        Me.Dtp_Fecha_Final.TabIndex = 12
        Me.Dtp_Fecha_Final.Visible = False
        '
        'Dtp_Fecha_Inicio
        '
        Me.Dtp_Fecha_Inicio.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_Inicio.Location = New System.Drawing.Point(77, 80)
        Me.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio"
        Me.Dtp_Fecha_Inicio.Size = New System.Drawing.Size(152, 23)
        Me.Dtp_Fecha_Inicio.TabIndex = 11
        Me.Dtp_Fecha_Inicio.Visible = False
        '
        'Dgv_Rep_Total
        '
        Me.Dgv_Rep_Total.AllowUserToAddRows = False
        Me.Dgv_Rep_Total.AllowUserToDeleteRows = False
        Me.Dgv_Rep_Total.AllowUserToOrderColumns = True
        Me.Dgv_Rep_Total.AutoGenerateColumns = False
        Me.Dgv_Rep_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Rep_Total.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA, Me.REPARACIONNUMERODataGridViewTextBoxColumn, Me.CODIGOCLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.CODIGOARTDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.BOLETADataGridViewTextBoxColumn, Me.DOCUMENTOREFDataGridViewTextBoxColumn, Me.SERIEPRODUCTODataGridViewTextBoxColumn, Me.PROBLEMAREPORTADODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn})
        Me.Dgv_Rep_Total.DataSource = Me.SCRPROCREPLISTADOBindingSource
        Me.Dgv_Rep_Total.Location = New System.Drawing.Point(32, 159)
        Me.Dgv_Rep_Total.Name = "Dgv_Rep_Total"
        Me.Dgv_Rep_Total.ReadOnly = True
        Me.Dgv_Rep_Total.Size = New System.Drawing.Size(770, 328)
        Me.Dgv_Rep_Total.TabIndex = 10
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "# REP"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CODIGOCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.HeaderText = "CODIGO_CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.Name = "CODIGOCLIENTEDataGridViewTextBoxColumn"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CODIGOARTDataGridViewTextBoxColumn
        '
        Me.CODIGOARTDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ART"
        Me.CODIGOARTDataGridViewTextBoxColumn.HeaderText = "CODIGO_ART"
        Me.CODIGOARTDataGridViewTextBoxColumn.Name = "CODIGOARTDataGridViewTextBoxColumn"
        Me.CODIGOARTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BOLETADataGridViewTextBoxColumn
        '
        Me.BOLETADataGridViewTextBoxColumn.DataPropertyName = "BOLETA"
        Me.BOLETADataGridViewTextBoxColumn.HeaderText = "BOLETA"
        Me.BOLETADataGridViewTextBoxColumn.Name = "BOLETADataGridViewTextBoxColumn"
        Me.BOLETADataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCUMENTOREFDataGridViewTextBoxColumn
        '
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_REF"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.HeaderText = "DOCUMENTO_REF"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.Name = "DOCUMENTOREFDataGridViewTextBoxColumn"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERIEPRODUCTODataGridViewTextBoxColumn
        '
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "SERIE_PRODUCTO"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.Name = "SERIEPRODUCTODataGridViewTextBoxColumn"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROBLEMAREPORTADODataGridViewTextBoxColumn
        '
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.DataPropertyName = "PROBLEMA_REPORTADO"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.HeaderText = "REPORTE"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.Name = "PROBLEMAREPORTADODataGridViewTextBoxColumn"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCRPROCREPLISTADOBindingSource
        '
        Me.SCRPROCREPLISTADOBindingSource.DataMember = "SCR_PROC_REP_LISTADO"
        Me.SCRPROCREPLISTADOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_PROC_REP_LISTADOTableAdapter
        '
        Me.SCR_PROC_REP_LISTADOTableAdapter.ClearBeforeFill = True
        '
        'SCR_ESTADOS_TOTALTableAdapter
        '
        Me.SCR_ESTADOS_TOTALTableAdapter.ClearBeforeFill = True
        '
        'gb_reparacion_lead
        '
        Me.gb_reparacion_lead.Controls.Add(Me.DateTimePicker1)
        Me.gb_reparacion_lead.Controls.Add(Me.DateTimePicker2)
        Me.gb_reparacion_lead.Controls.Add(Me.Txt_Fecha_Final)
        Me.gb_reparacion_lead.Controls.Add(Me.Txt_Fecha_Inicial)
        Me.gb_reparacion_lead.Controls.Add(Me.Crv_Listado_Rep)
        Me.gb_reparacion_lead.Controls.Add(Me.Btn_Cargar)
        Me.gb_reparacion_lead.Controls.Add(Me.Label1)
        Me.gb_reparacion_lead.Controls.Add(Me.Lbl_Fecha_Inicial)
        Me.gb_reparacion_lead.Location = New System.Drawing.Point(419, 20)
        Me.gb_reparacion_lead.Name = "gb_reparacion_lead"
        Me.gb_reparacion_lead.Size = New System.Drawing.Size(804, 520)
        Me.gb_reparacion_lead.TabIndex = 20
        Me.gb_reparacion_lead.TabStop = False
        Me.gb_reparacion_lead.Text = "REPARACIONES"
        Me.gb_reparacion_lead.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 83)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 23)
        Me.DateTimePicker1.TabIndex = 17
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(120, 49)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(152, 23)
        Me.DateTimePicker2.TabIndex = 16
        '
        'Txt_Fecha_Final
        '
        Me.Txt_Fecha_Final.Enabled = False
        Me.Txt_Fecha_Final.Location = New System.Drawing.Point(569, 45)
        Me.Txt_Fecha_Final.Mask = "0000-00-00"
        Me.Txt_Fecha_Final.Name = "Txt_Fecha_Final"
        Me.Txt_Fecha_Final.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Fecha_Final.TabIndex = 15
        Me.Txt_Fecha_Final.Visible = False
        '
        'Txt_Fecha_Inicial
        '
        Me.Txt_Fecha_Inicial.Location = New System.Drawing.Point(442, 45)
        Me.Txt_Fecha_Inicial.Mask = "0000-00-00"
        Me.Txt_Fecha_Inicial.Name = "Txt_Fecha_Inicial"
        Me.Txt_Fecha_Inicial.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Fecha_Inicial.TabIndex = 14
        Me.Txt_Fecha_Inicial.Visible = False
        '
        'Crv_Listado_Rep
        '
        Me.Crv_Listado_Rep.ActiveViewIndex = -1
        Me.Crv_Listado_Rep.AutoScroll = True
        Me.Crv_Listado_Rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_Listado_Rep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Listado_Rep.DisplayStatusBar = False
        Me.Crv_Listado_Rep.Location = New System.Drawing.Point(26, 134)
        Me.Crv_Listado_Rep.Name = "Crv_Listado_Rep"
        Me.Crv_Listado_Rep.ShowCloseButton = False
        Me.Crv_Listado_Rep.ShowCopyButton = False
        Me.Crv_Listado_Rep.ShowGroupTreeButton = False
        Me.Crv_Listado_Rep.ShowParameterPanelButton = False
        Me.Crv_Listado_Rep.ShowRefreshButton = False
        Me.Crv_Listado_Rep.Size = New System.Drawing.Size(753, 358)
        Me.Crv_Listado_Rep.TabIndex = 13
        Me.Crv_Listado_Rep.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Enabled = False
        Me.Btn_Cargar.Location = New System.Drawing.Point(289, 45)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(88, 27)
        Me.Btn_Cargar.TabIndex = 12
        Me.Btn_Cargar.Text = "Cargar"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha Final"
        '
        'Lbl_Fecha_Inicial
        '
        Me.Lbl_Fecha_Inicial.AutoSize = True
        Me.Lbl_Fecha_Inicial.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_Inicial.Location = New System.Drawing.Point(23, 52)
        Me.Lbl_Fecha_Inicial.Name = "Lbl_Fecha_Inicial"
        Me.Lbl_Fecha_Inicial.Size = New System.Drawing.Size(81, 16)
        Me.Lbl_Fecha_Inicial.TabIndex = 10
        Me.Lbl_Fecha_Inicial.Text = "Fecha Inicial"
        '
        'Frm_Listado_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.gb_reparacion_lead)
        Me.Controls.Add(Me.gb_reparaciones_estado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Listado_Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_reparaciones_estado.ResumeLayout(False)
        Me.gb_reparaciones_estado.PerformLayout()
        CType(Me.Dgv_Rep_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRPROCREPLISTADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_reparacion_lead.ResumeLayout(False)
        Me.gb_reparacion_lead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txt_Dato As TextBox
    Friend WithEvents Lbl_Dato As Label
    Friend WithEvents bt_listado_rep_estado As Button
    Friend WithEvents bt_listado_rep_lead As Button
    Friend WithEvents bt_consulta_num_queja As Button
    Friend WithEvents bt_impresion_reparacion As Button
    Friend WithEvents bt_consulta_cliente As Button
    Friend WithEvents bt_etiqueta_salida As Button
    Friend WithEvents bt_listado_quejas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb_reparaciones_estado As GroupBox
    Friend WithEvents Btn_Filtrar As Button
    Friend WithEvents bt_eliminar_filtros As Button
    Friend WithEvents Cbx_Estados As ComboBox
    Friend WithEvents Check_Estado As CheckBox
    Friend WithEvents Check_fecha As CheckBox
    Friend WithEvents Lbl_Fecha_Final As Label
    Friend WithEvents Lbl_Fecha_Inicio As Label
    Friend WithEvents Dtp_Fecha_Final As DateTimePicker
    Friend WithEvents Dtp_Fecha_Inicio As DateTimePicker
    Friend WithEvents Dgv_Rep_Total As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRPROCREPLISTADOBindingSource As BindingSource
    Friend WithEvents SCR_PROC_REP_LISTADOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_PROC_REP_LISTADOTableAdapter
    Friend WithEvents SCR_ESTADOS_TOTALTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADOS_TOTALTableAdapter
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOARTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BOLETADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTOREFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SERIEPRODUCTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROBLEMAREPORTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gb_reparacion_lead As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Txt_Fecha_Final As MaskedTextBox
    Friend WithEvents Txt_Fecha_Inicial As MaskedTextBox
    Friend WithEvents Crv_Listado_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_Fecha_Inicial As Label
End Class
