<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Detalle_Reparacion
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
        Me.Dgv_Actualizaciones = New System.Windows.Forms.DataGridView()
        Me.SCRCONSULTAREPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.lb_detalle = New System.Windows.Forms.Label()
        Me.SCR_CONSULTA_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter()
        Me.COMENTARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Actualizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Actualizaciones
        '
        Me.Dgv_Actualizaciones.AllowUserToAddRows = False
        Me.Dgv_Actualizaciones.AllowUserToDeleteRows = False
        Me.Dgv_Actualizaciones.AllowUserToResizeColumns = False
        Me.Dgv_Actualizaciones.AllowUserToResizeRows = False
        Me.Dgv_Actualizaciones.AutoGenerateColumns = False
        Me.Dgv_Actualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Actualizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COMENTARIODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.LOCALIZACIONDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn})
        Me.Dgv_Actualizaciones.DataSource = Me.SCRCONSULTAREPARACIONBindingSource
        Me.Dgv_Actualizaciones.Location = New System.Drawing.Point(52, 75)
        Me.Dgv_Actualizaciones.Name = "Dgv_Actualizaciones"
        Me.Dgv_Actualizaciones.ReadOnly = True
        Me.Dgv_Actualizaciones.Size = New System.Drawing.Size(675, 150)
        Me.Dgv_Actualizaciones.TabIndex = 1
        '
        'SCRCONSULTAREPARACIONBindingSource
        '
        Me.SCRCONSULTAREPARACIONBindingSource.DataMember = "SCR_CONSULTA_REPARACION"
        Me.SCRCONSULTAREPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lb_detalle
        '
        Me.lb_detalle.AutoSize = True
        Me.lb_detalle.Location = New System.Drawing.Point(374, 43)
        Me.lb_detalle.Name = "lb_detalle"
        Me.lb_detalle.Size = New System.Drawing.Size(39, 13)
        Me.lb_detalle.TabIndex = 2
        Me.lb_detalle.Text = "Label1"
        '
        'SCR_CONSULTA_REPARACIONTableAdapter
        '
        Me.SCR_CONSULTA_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'COMENTARIODataGridViewTextBoxColumn
        '
        Me.COMENTARIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.COMENTARIODataGridViewTextBoxColumn.DataPropertyName = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.HeaderText = "COMENTARIO"
        Me.COMENTARIODataGridViewTextBoxColumn.Name = "COMENTARIODataGridViewTextBoxColumn"
        Me.COMENTARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.COMENTARIODataGridViewTextBoxColumn.Width = 5
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.Width = 5
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.USUARIODataGridViewTextBoxColumn.Width = 5
        '
        'LOCALIZACIONDataGridViewTextBoxColumn
        '
        Me.LOCALIZACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.LOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Name = "LOCALIZACIONDataGridViewTextBoxColumn"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Width = 5
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.Width = 5
        '
        'Frm_Detalle_Reparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 263)
        Me.Controls.Add(Me.lb_detalle)
        Me.Controls.Add(Me.Dgv_Actualizaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Detalle_Reparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Reparación"
        CType(Me.Dgv_Actualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRCONSULTAREPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Actualizaciones As DataGridView
    Friend WithEvents lb_detalle As Label
    Friend WithEvents SCRCONSULTAREPARACIONBindingSource As BindingSource
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCR_CONSULTA_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_CONSULTA_REPARACIONTableAdapter
    Friend WithEvents COMENTARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
