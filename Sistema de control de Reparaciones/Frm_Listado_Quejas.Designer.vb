<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Listado_Quejas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listado_Quejas))
        Me.bs_quejas = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter()
        Me.Btn_Exportar = New System.Windows.Forms.Button()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_Quejas_Total = New System.Windows.Forms.DataGridView()
        Me.CLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAINGRESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROFORMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bs_quejas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Quejas_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bs_quejas
        '
        Me.bs_quejas.DataMember = "SCR_ULTIMO_ESTADO_QUEJA"
        Me.bs_quejas.DataSource = Me.ExactusERP_SRC_TABLES
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
        'Btn_Exportar
        '
        Me.Btn_Exportar.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exportar.Location = New System.Drawing.Point(977, 18)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(177, 33)
        Me.Btn_Exportar.TabIndex = 2
        Me.Btn_Exportar.Text = "EXPORTAR A EXCEL"
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(221, 29)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(173, 22)
        Me.txt_filtro.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE CLIENTE:"
        '
        'Dgv_Quejas_Total
        '
        Me.Dgv_Quejas_Total.AllowUserToAddRows = False
        Me.Dgv_Quejas_Total.AllowUserToDeleteRows = False
        Me.Dgv_Quejas_Total.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Quejas_Total.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Quejas_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Quejas_Total.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.ALIASDataGridViewTextBoxColumn, Me.NUMEROQUEJADataGridViewTextBoxColumn, Me.FECHAINGRESODataGridViewTextBoxColumn, Me.TIPOQUEJADataGridViewTextBoxColumn, Me.FACTURADataGridViewTextBoxColumn, Me.PROFORMADataGridViewTextBoxColumn, Me.DETALLEDataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn})
        Me.Dgv_Quejas_Total.DataSource = Me.bs_quejas
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Quejas_Total.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Quejas_Total.Location = New System.Drawing.Point(58, 86)
        Me.Dgv_Quejas_Total.Name = "Dgv_Quejas_Total"
        Me.Dgv_Quejas_Total.ReadOnly = True
        Me.Dgv_Quejas_Total.Size = New System.Drawing.Size(1133, 433)
        Me.Dgv_Quejas_Total.TabIndex = 5
        '
        'CLIENTEDataGridViewTextBoxColumn
        '
        Me.CLIENTEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.Name = "CLIENTEDataGridViewTextBoxColumn"
        Me.CLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTEDataGridViewTextBoxColumn.Width = 92
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 94
        '
        'ALIASDataGridViewTextBoxColumn
        '
        Me.ALIASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ALIASDataGridViewTextBoxColumn.DataPropertyName = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.Name = "ALIASDataGridViewTextBoxColumn"
        Me.ALIASDataGridViewTextBoxColumn.ReadOnly = True
        Me.ALIASDataGridViewTextBoxColumn.Width = 75
        '
        'NUMEROQUEJADataGridViewTextBoxColumn
        '
        Me.NUMEROQUEJADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NUMEROQUEJADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_QUEJA"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.HeaderText = "NUMERO_QUEJA"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.Name = "NUMEROQUEJADataGridViewTextBoxColumn"
        Me.NUMEROQUEJADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMEROQUEJADataGridViewTextBoxColumn.Width = 149
        '
        'FECHAINGRESODataGridViewTextBoxColumn
        '
        Me.FECHAINGRESODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FECHAINGRESODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.HeaderText = "FECHA_INGRESO"
        Me.FECHAINGRESODataGridViewTextBoxColumn.Name = "FECHAINGRESODataGridViewTextBoxColumn"
        Me.FECHAINGRESODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAINGRESODataGridViewTextBoxColumn.Width = 149
        '
        'TIPOQUEJADataGridViewTextBoxColumn
        '
        Me.TIPOQUEJADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TIPOQUEJADataGridViewTextBoxColumn.DataPropertyName = "TIPO_QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.HeaderText = "TIPO_QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.Name = "TIPOQUEJADataGridViewTextBoxColumn"
        Me.TIPOQUEJADataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPOQUEJADataGridViewTextBoxColumn.Width = 119
        '
        'FACTURADataGridViewTextBoxColumn
        '
        Me.FACTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FACTURADataGridViewTextBoxColumn.DataPropertyName = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.HeaderText = "FACTURA"
        Me.FACTURADataGridViewTextBoxColumn.Name = "FACTURADataGridViewTextBoxColumn"
        Me.FACTURADataGridViewTextBoxColumn.ReadOnly = True
        Me.FACTURADataGridViewTextBoxColumn.Width = 97
        '
        'PROFORMADataGridViewTextBoxColumn
        '
        Me.PROFORMADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PROFORMADataGridViewTextBoxColumn.DataPropertyName = "PROFORMA"
        Me.PROFORMADataGridViewTextBoxColumn.HeaderText = "PROFORMA"
        Me.PROFORMADataGridViewTextBoxColumn.Name = "PROFORMADataGridViewTextBoxColumn"
        Me.PROFORMADataGridViewTextBoxColumn.ReadOnly = True
        Me.PROFORMADataGridViewTextBoxColumn.Width = 111
        '
        'DETALLEDataGridViewTextBoxColumn
        '
        Me.DETALLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DETALLEDataGridViewTextBoxColumn.DataPropertyName = "DETALLE"
        Me.DETALLEDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DETALLEDataGridViewTextBoxColumn.Name = "DETALLEDataGridViewTextBoxColumn"
        Me.DETALLEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DETALLEDataGridViewTextBoxColumn.Width = 95
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.Width = 89
        '
        'Frm_Listado_Quejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.Dgv_Quejas_Total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Btn_Exportar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Listado_Quejas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Quejas"
        CType(Me.bs_quejas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Quejas_Total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents bs_quejas As BindingSource
    Friend WithEvents SCR_ULTIMO_ESTADO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ULTIMO_ESTADO_QUEJATableAdapter
    Friend WithEvents Btn_Exportar As Button
    Friend WithEvents txt_filtro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_Quejas_Total As DataGridView
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAINGRESODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FACTURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROFORMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DETALLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
