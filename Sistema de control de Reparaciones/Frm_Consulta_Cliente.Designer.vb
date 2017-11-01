<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Consulta_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Cliente))
        Me.Dgv_Consulta_Cliente = New System.Windows.Forms.DataGridView()
        Me.REPARACIONNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROACTUADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRVISTAREPARACLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_VISTA_REPARA_CLIENTETableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_VISTA_REPARA_CLIENTETableAdapter()
        Me.ScR_LOCALIZACION_REPTableAdapter1 = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter()
        Me.Lbl_Rep_Numero = New System.Windows.Forms.Label()
        Me.Lbl_Actua_Num = New System.Windows.Forms.Label()
        Me.Lbl_Cod_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Cod_Articulo = New System.Windows.Forms.Label()
        Me.Lbl_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion_Articulo = New System.Windows.Forms.Label()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.Lbl_T_Rep_Numero = New System.Windows.Forms.Label()
        Me.Lbl_T_Actua_Num = New System.Windows.Forms.Label()
        Me.Lbl_T_Cod_Cliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_T_Estado = New System.Windows.Forms.Label()
        Me.Lbl_T_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_T_Alias = New System.Windows.Forms.Label()
        Me.Lbl_T_Problema_Reportado = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        CType(Me.Dgv_Consulta_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRVISTAREPARACLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Consulta_Cliente
        '
        Me.Dgv_Consulta_Cliente.AllowUserToAddRows = False
        Me.Dgv_Consulta_Cliente.AllowUserToDeleteRows = False
        Me.Dgv_Consulta_Cliente.AutoGenerateColumns = False
        Me.Dgv_Consulta_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Dgv_Consulta_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Consulta_Cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REPARACIONNUMERODataGridViewTextBoxColumn, Me.NUMEROACTUADataGridViewTextBoxColumn, Me.CODIGOCLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.ALIASDataGridViewTextBoxColumn, Me.CODIGOARTDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.PROBLEMAREPORTADODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn})
        Me.Dgv_Consulta_Cliente.DataSource = Me.SCRVISTAREPARACLIENTEBindingSource
        Me.Dgv_Consulta_Cliente.Location = New System.Drawing.Point(-4, 119)
        Me.Dgv_Consulta_Cliente.Name = "Dgv_Consulta_Cliente"
        Me.Dgv_Consulta_Cliente.ReadOnly = True
        Me.Dgv_Consulta_Cliente.Size = New System.Drawing.Size(1106, 250)
        Me.Dgv_Consulta_Cliente.TabIndex = 0
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "REPARACION NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Width = 121
        '
        'NUMEROACTUADataGridViewTextBoxColumn
        '
        Me.NUMEROACTUADataGridViewTextBoxColumn.DataPropertyName = "NUMERO_ACTUA"
        Me.NUMEROACTUADataGridViewTextBoxColumn.HeaderText = "NUMERO ACTUALIZACION"
        Me.NUMEROACTUADataGridViewTextBoxColumn.Name = "NUMEROACTUADataGridViewTextBoxColumn"
        Me.NUMEROACTUADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMEROACTUADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NUMEROACTUADataGridViewTextBoxColumn.Width = 134
        '
        'CODIGOCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.HeaderText = "CODIGO CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.Name = "CODIGOCLIENTEDataGridViewTextBoxColumn"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.Width = 93
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NOMBREDataGridViewTextBoxColumn.Width = 60
        '
        'ALIASDataGridViewTextBoxColumn
        '
        Me.ALIASDataGridViewTextBoxColumn.DataPropertyName = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.Name = "ALIASDataGridViewTextBoxColumn"
        Me.ALIASDataGridViewTextBoxColumn.ReadOnly = True
        Me.ALIASDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ALIASDataGridViewTextBoxColumn.Width = 43
        '
        'CODIGOARTDataGridViewTextBoxColumn
        '
        Me.CODIGOARTDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ART"
        Me.CODIGOARTDataGridViewTextBoxColumn.HeaderText = "CODIGO ARTICULO"
        Me.CODIGOARTDataGridViewTextBoxColumn.Name = "CODIGOARTDataGridViewTextBoxColumn"
        Me.CODIGOARTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODIGOARTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CODIGOARTDataGridViewTextBoxColumn.Width = 101
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRIPCIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Width = 86
        '
        'PROBLEMAREPORTADODataGridViewTextBoxColumn
        '
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.DataPropertyName = "PROBLEMA_REPORTADO"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.HeaderText = "PROBLEMA REPORTADO"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.Name = "PROBLEMAREPORTADODataGridViewTextBoxColumn"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.Width = 129
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ESTADODataGridViewTextBoxColumn.Width = 57
        '
        'SCRVISTAREPARACLIENTEBindingSource
        '
        Me.SCRVISTAREPARACLIENTEBindingSource.DataMember = "SCR_VISTA_REPARA_CLIENTE"
        Me.SCRVISTAREPARACLIENTEBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_VISTA_REPARA_CLIENTETableAdapter
        '
        Me.SCR_VISTA_REPARA_CLIENTETableAdapter.ClearBeforeFill = True
        '
        'ScR_LOCALIZACION_REPTableAdapter1
        '
        Me.ScR_LOCALIZACION_REPTableAdapter1.ClearBeforeFill = True
        '
        'Lbl_Rep_Numero
        '
        Me.Lbl_Rep_Numero.AutoSize = True
        Me.Lbl_Rep_Numero.Location = New System.Drawing.Point(98, 9)
        Me.Lbl_Rep_Numero.Name = "Lbl_Rep_Numero"
        Me.Lbl_Rep_Numero.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Rep_Numero.TabIndex = 1
        '
        'Lbl_Actua_Num
        '
        Me.Lbl_Actua_Num.AutoSize = True
        Me.Lbl_Actua_Num.Location = New System.Drawing.Point(98, 27)
        Me.Lbl_Actua_Num.Name = "Lbl_Actua_Num"
        Me.Lbl_Actua_Num.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Actua_Num.TabIndex = 2
        '
        'Lbl_Cod_Cliente
        '
        Me.Lbl_Cod_Cliente.AutoSize = True
        Me.Lbl_Cod_Cliente.Location = New System.Drawing.Point(98, 61)
        Me.Lbl_Cod_Cliente.Name = "Lbl_Cod_Cliente"
        Me.Lbl_Cod_Cliente.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Cod_Cliente.TabIndex = 3
        '
        'Lbl_Cod_Articulo
        '
        Me.Lbl_Cod_Articulo.AutoSize = True
        Me.Lbl_Cod_Articulo.Location = New System.Drawing.Point(98, 44)
        Me.Lbl_Cod_Articulo.Name = "Lbl_Cod_Articulo"
        Me.Lbl_Cod_Articulo.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Cod_Articulo.TabIndex = 4
        '
        'Lbl_Problema_Reportado
        '
        Me.Lbl_Problema_Reportado.AutoSize = True
        Me.Lbl_Problema_Reportado.Location = New System.Drawing.Point(309, 65)
        Me.Lbl_Problema_Reportado.Name = "Lbl_Problema_Reportado"
        Me.Lbl_Problema_Reportado.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Problema_Reportado.TabIndex = 5
        '
        'Lbl_Descripcion_Articulo
        '
        Me.Lbl_Descripcion_Articulo.AutoSize = True
        Me.Lbl_Descripcion_Articulo.Location = New System.Drawing.Point(317, 44)
        Me.Lbl_Descripcion_Articulo.Name = "Lbl_Descripcion_Articulo"
        Me.Lbl_Descripcion_Articulo.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Descripcion_Articulo.TabIndex = 6
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.Location = New System.Drawing.Point(241, 27)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Alias.TabIndex = 7
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(256, 8)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Nombre.TabIndex = 8
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(185, 86)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Estado.TabIndex = 9
        '
        'Lbl_T_Rep_Numero
        '
        Me.Lbl_T_Rep_Numero.AutoSize = True
        Me.Lbl_T_Rep_Numero.Location = New System.Drawing.Point(13, 8)
        Me.Lbl_T_Rep_Numero.Name = "Lbl_T_Rep_Numero"
        Me.Lbl_T_Rep_Numero.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_T_Rep_Numero.TabIndex = 10
        Me.Lbl_T_Rep_Numero.Text = "Reparacion #"
        '
        'Lbl_T_Actua_Num
        '
        Me.Lbl_T_Actua_Num.AutoSize = True
        Me.Lbl_T_Actua_Num.Location = New System.Drawing.Point(13, 27)
        Me.Lbl_T_Actua_Num.Name = "Lbl_T_Actua_Num"
        Me.Lbl_T_Actua_Num.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_T_Actua_Num.TabIndex = 11
        Me.Lbl_T_Actua_Num.Text = "Actualizacion #"
        '
        'Lbl_T_Cod_Cliente
        '
        Me.Lbl_T_Cod_Cliente.AutoSize = True
        Me.Lbl_T_Cod_Cliente.Location = New System.Drawing.Point(13, 61)
        Me.Lbl_T_Cod_Cliente.Name = "Lbl_T_Cod_Cliente"
        Me.Lbl_T_Cod_Cliente.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_T_Cod_Cliente.TabIndex = 12
        Me.Lbl_T_Cod_Cliente.Text = "Codigo Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Codigo Articulo:"
        '
        'Lbl_T_Estado
        '
        Me.Lbl_T_Estado.AutoSize = True
        Me.Lbl_T_Estado.Location = New System.Drawing.Point(142, 86)
        Me.Lbl_T_Estado.Name = "Lbl_T_Estado"
        Me.Lbl_T_Estado.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_T_Estado.TabIndex = 14
        Me.Lbl_T_Estado.Text = "Estado:"
        '
        'Lbl_T_Nombre
        '
        Me.Lbl_T_Nombre.AutoSize = True
        Me.Lbl_T_Nombre.Location = New System.Drawing.Point(203, 8)
        Me.Lbl_T_Nombre.Name = "Lbl_T_Nombre"
        Me.Lbl_T_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_T_Nombre.TabIndex = 15
        Me.Lbl_T_Nombre.Text = "Nombre:"
        '
        'Lbl_T_Alias
        '
        Me.Lbl_T_Alias.AutoSize = True
        Me.Lbl_T_Alias.Location = New System.Drawing.Point(203, 27)
        Me.Lbl_T_Alias.Name = "Lbl_T_Alias"
        Me.Lbl_T_Alias.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_T_Alias.TabIndex = 16
        Me.Lbl_T_Alias.Text = "Alias:"
        '
        'Lbl_T_Problema_Reportado
        '
        Me.Lbl_T_Problema_Reportado.AutoSize = True
        Me.Lbl_T_Problema_Reportado.Location = New System.Drawing.Point(203, 65)
        Me.Lbl_T_Problema_Reportado.Name = "Lbl_T_Problema_Reportado"
        Me.Lbl_T_Problema_Reportado.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_T_Problema_Reportado.TabIndex = 17
        Me.Lbl_T_Problema_Reportado.Text = "Problema Reportado:"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(203, 44)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_Descripcion.TabIndex = 18
        Me.Lbl_Descripcion.Text = "Descripcion Articulo:"
        '
        'Frm_Consulta_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 376)
        Me.Controls.Add(Me.Lbl_Descripcion)
        Me.Controls.Add(Me.Lbl_T_Problema_Reportado)
        Me.Controls.Add(Me.Lbl_T_Alias)
        Me.Controls.Add(Me.Lbl_T_Nombre)
        Me.Controls.Add(Me.Lbl_T_Estado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_T_Cod_Cliente)
        Me.Controls.Add(Me.Lbl_T_Actua_Num)
        Me.Controls.Add(Me.Lbl_T_Rep_Numero)
        Me.Controls.Add(Me.Lbl_Estado)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_Alias)
        Me.Controls.Add(Me.Lbl_Descripcion_Articulo)
        Me.Controls.Add(Me.Lbl_Problema_Reportado)
        Me.Controls.Add(Me.Lbl_Cod_Articulo)
        Me.Controls.Add(Me.Lbl_Cod_Cliente)
        Me.Controls.Add(Me.Lbl_Actua_Num)
        Me.Controls.Add(Me.Lbl_Rep_Numero)
        Me.Controls.Add(Me.Dgv_Consulta_Cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Consulta_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta por Codigo Cliente"
        CType(Me.Dgv_Consulta_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRVISTAREPARACLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Consulta_Cliente As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRVISTAREPARACLIENTEBindingSource As BindingSource
    Friend WithEvents SCR_VISTA_REPARA_CLIENTETableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_VISTA_REPARA_CLIENTETableAdapter
    Friend WithEvents ScR_LOCALIZACION_REPTableAdapter1 As ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter
    Friend WithEvents Lbl_Rep_Numero As Label
    Friend WithEvents Lbl_Actua_Num As Label
    Friend WithEvents Lbl_Cod_Cliente As Label
    Friend WithEvents Lbl_Cod_Articulo As Label
    Friend WithEvents Lbl_Problema_Reportado As Label
    Friend WithEvents Lbl_Descripcion_Articulo As Label
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents Lbl_T_Rep_Numero As Label
    Friend WithEvents Lbl_T_Actua_Num As Label
    Friend WithEvents Lbl_T_Cod_Cliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_T_Estado As Label
    Friend WithEvents Lbl_T_Nombre As Label
    Friend WithEvents Lbl_T_Alias As Label
    Friend WithEvents Lbl_T_Problema_Reportado As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROACTUADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOARTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROBLEMAREPORTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
