<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Listado_Quejas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listado_Quejas))
        Me.Dgv_Quejas_Total = New System.Windows.Forms.DataGridView()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINGRESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROFORMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAACTUADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRULTIMOESTADOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter()
        Me.Btn_Selec_Queja = New System.Windows.Forms.Button()
        Me.Btn_Exportar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Quejas_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Quejas_Total
        '
        Me.Dgv_Quejas_Total.AllowUserToAddRows = False
        Me.Dgv_Quejas_Total.AllowUserToDeleteRows = False
        Me.Dgv_Quejas_Total.AutoGenerateColumns = False
        Me.Dgv_Quejas_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Quejas_Total.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESTADODataGridViewTextBoxColumn, Me.NUMEROQUEJADataGridViewTextBoxColumn, Me.TIPOQUEJADataGridViewTextBoxColumn, Me.DETALLEDataGridViewTextBoxColumn, Me.CLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.ALIASDataGridViewTextBoxColumn, Me.TELEFONO1DataGridViewTextBoxColumn, Me.TELEFONO2DataGridViewTextBoxColumn, Me.CONTACTODataGridViewTextBoxColumn, Me.FAXDataGridViewTextBoxColumn, Me.FECHAINGRESODataGridViewTextBoxColumn, Me.FACTURADataGridViewTextBoxColumn, Me.PROFORMADataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.DIRECCIONDataGridViewTextBoxColumn, Me.FECHAACTUADataGridViewTextBoxColumn})
        Me.Dgv_Quejas_Total.DataSource = Me.SCRULTIMOESTADOQUEJABindingSource
        Me.Dgv_Quejas_Total.Location = New System.Drawing.Point(12, 34)
        Me.Dgv_Quejas_Total.Name = "Dgv_Quejas_Total"
        Me.Dgv_Quejas_Total.ReadOnly = True
        Me.Dgv_Quejas_Total.Size = New System.Drawing.Size(943, 448)
        Me.Dgv_Quejas_Total.TabIndex = 0
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMEROQUEJADataGridViewTextBoxColumn
        '
        Me.NUMEROQUEJADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_QUEJA"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.HeaderText = "NUMERO QUEJA"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.Name = "NUMEROQUEJADataGridViewTextBoxColumn"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIPOQUEJADataGridViewTextBoxColumn
        '
        Me.TIPOQUEJADataGridViewTextBoxColumn.DataPropertyName = "TIPO_QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.HeaderText = "TIPO QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.Name = "TIPOQUEJADataGridViewTextBoxColumn"
        Me.TIPOQUEJADataGridViewTextBoxColumn.ReadOnly = True
        '
        'DETALLEDataGridViewTextBoxColumn
        '
        Me.DETALLEDataGridViewTextBoxColumn.DataPropertyName = "DETALLE"
        Me.DETALLEDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DETALLEDataGridViewTextBoxColumn.Name = "DETALLEDataGridViewTextBoxColumn"
        Me.DETALLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIENTEDataGridViewTextBoxColumn
        '
        Me.CLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.Name = "CLIENTEDataGridViewTextBoxColumn"
        Me.CLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ALIASDataGridViewTextBoxColumn
        '
        Me.ALIASDataGridViewTextBoxColumn.DataPropertyName = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.Name = "ALIASDataGridViewTextBoxColumn"
        Me.ALIASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONO1DataGridViewTextBoxColumn
        '
        Me.TELEFONO1DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO1"
        Me.TELEFONO1DataGridViewTextBoxColumn.HeaderText = "TELEFONO 1"
        Me.TELEFONO1DataGridViewTextBoxColumn.Name = "TELEFONO1DataGridViewTextBoxColumn"
        Me.TELEFONO1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONO2DataGridViewTextBoxColumn
        '
        Me.TELEFONO2DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO2"
        Me.TELEFONO2DataGridViewTextBoxColumn.HeaderText = "TELEFONO 2"
        Me.TELEFONO2DataGridViewTextBoxColumn.Name = "TELEFONO2DataGridViewTextBoxColumn"
        Me.TELEFONO2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTODataGridViewTextBoxColumn
        '
        Me.CONTACTODataGridViewTextBoxColumn.DataPropertyName = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.HeaderText = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.Name = "CONTACTODataGridViewTextBoxColumn"
        Me.CONTACTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FAXDataGridViewTextBoxColumn
        '
        Me.FAXDataGridViewTextBoxColumn.DataPropertyName = "FAX"
        Me.FAXDataGridViewTextBoxColumn.HeaderText = "FAX"
        Me.FAXDataGridViewTextBoxColumn.Name = "FAXDataGridViewTextBoxColumn"
        Me.FAXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAINGRESODataGridViewTextBoxColumn
        '
        Me.FECHAINGRESODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.HeaderText = "FECHA INGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.Name = "FECHAINGRESODataGridViewTextBoxColumn"
        Me.FECHAINGRESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FACTURADataGridViewTextBoxColumn
        '
        Me.FACTURADataGridViewTextBoxColumn.DataPropertyName = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.HeaderText = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.Name = "FACTURADataGridViewTextBoxColumn"
        Me.FACTURADataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROFORMADataGridViewTextBoxColumn
        '
        Me.PROFORMADataGridViewTextBoxColumn.DataPropertyName = "PROFORMA"
        Me.PROFORMADataGridViewTextBoxColumn.HeaderText = "PROFORMA"
        Me.PROFORMADataGridViewTextBoxColumn.Name = "PROFORMADataGridViewTextBoxColumn"
        Me.PROFORMADataGridViewTextBoxColumn.ReadOnly = True
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'DIRECCIONDataGridViewTextBoxColumn
        '
        Me.DIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.Name = "DIRECCIONDataGridViewTextBoxColumn"
        Me.DIRECCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAACTUADataGridViewTextBoxColumn
        '
        Me.FECHAACTUADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ACTUA"
        Me.FECHAACTUADataGridViewTextBoxColumn.HeaderText = "FECHA ACTUA"
        Me.FECHAACTUADataGridViewTextBoxColumn.Name = "FECHAACTUADataGridViewTextBoxColumn"
        Me.FECHAACTUADataGridViewTextBoxColumn.ReadOnly = True
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
        'SCR_ULTIMO_ESTADO_QUEJATableAdapter
        '
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'Btn_Selec_Queja
        '
        Me.Btn_Selec_Queja.Location = New System.Drawing.Point(880, 5)
        Me.Btn_Selec_Queja.Name = "Btn_Selec_Queja"
        Me.Btn_Selec_Queja.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Selec_Queja.TabIndex = 1
        Me.Btn_Selec_Queja.Text = "&Seleccionar"
        Me.Btn_Selec_Queja.UseVisualStyleBackColor = True
        Me.Btn_Selec_Queja.Visible = False
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Location = New System.Drawing.Point(12, 5)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Exportar.TabIndex = 2
        Me.Btn_Exportar.Text = "Exportar"
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'Frm_Listado_Quejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 488)
        Me.Controls.Add(Me.Btn_Exportar)
        Me.Controls.Add(Me.Btn_Selec_Queja)
        Me.Controls.Add(Me.Dgv_Quejas_Total)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Listado_Quejas"
        Me.Text = "Listado Quejas"
        CType(Me.Dgv_Quejas_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRULTIMOESTADOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_Quejas_Total As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRULTIMOESTADOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_ULTIMO_ESTADO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DETALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FAXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINGRESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FACTURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROFORMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAACTUADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Selec_Queja As Button
    Friend WithEvents Btn_Exportar As Button
End Class
