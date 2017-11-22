<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NO_Busqueda_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NO_Busqueda_cliente))
        Me.Dgv_Cliente = New System.Windows.Forms.DataGridView()
        Me.CLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.CLIENTETableAdapter()
        Me.Rbtn_Nombre = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Alias = New System.Windows.Forms.RadioButton()
        Me.Txt_Dato = New System.Windows.Forms.TextBox()
        Me.Btn_Filtrar = New System.Windows.Forms.Button()
        Me.Btn_Quitar_Filtro = New System.Windows.Forms.Button()
        Me.Btn_Selecionar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Cliente
        '
        Me.Dgv_Cliente.AllowUserToAddRows = False
        Me.Dgv_Cliente.AllowUserToDeleteRows = False
        Me.Dgv_Cliente.AllowUserToOrderColumns = True
        Me.Dgv_Cliente.AutoGenerateColumns = False
        Me.Dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.ALIASDataGridViewTextBoxColumn, Me.TELEFONO1DataGridViewTextBoxColumn, Me.TELEFONO2DataGridViewTextBoxColumn, Me.FAXDataGridViewTextBoxColumn})
        Me.Dgv_Cliente.DataSource = Me.CLIENTEBindingSource
        Me.Dgv_Cliente.Location = New System.Drawing.Point(12, 35)
        Me.Dgv_Cliente.Name = "Dgv_Cliente"
        Me.Dgv_Cliente.ReadOnly = True
        Me.Dgv_Cliente.Size = New System.Drawing.Size(872, 230)
        Me.Dgv_Cliente.TabIndex = 0
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
        Me.NOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 79
        '
        'ALIASDataGridViewTextBoxColumn
        '
        Me.ALIASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ALIASDataGridViewTextBoxColumn.DataPropertyName = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.Name = "ALIASDataGridViewTextBoxColumn"
        Me.ALIASDataGridViewTextBoxColumn.ReadOnly = True
        Me.ALIASDataGridViewTextBoxColumn.Width = 62
        '
        'TELEFONO1DataGridViewTextBoxColumn
        '
        Me.TELEFONO1DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO1"
        Me.TELEFONO1DataGridViewTextBoxColumn.HeaderText = "TELEFONO1"
        Me.TELEFONO1DataGridViewTextBoxColumn.Name = "TELEFONO1DataGridViewTextBoxColumn"
        Me.TELEFONO1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONO2DataGridViewTextBoxColumn
        '
        Me.TELEFONO2DataGridViewTextBoxColumn.DataPropertyName = "TELEFONO2"
        Me.TELEFONO2DataGridViewTextBoxColumn.HeaderText = "TELEFONO2"
        Me.TELEFONO2DataGridViewTextBoxColumn.Name = "TELEFONO2DataGridViewTextBoxColumn"
        Me.TELEFONO2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FAXDataGridViewTextBoxColumn
        '
        Me.FAXDataGridViewTextBoxColumn.DataPropertyName = "FAX"
        Me.FAXDataGridViewTextBoxColumn.HeaderText = "FAX"
        Me.FAXDataGridViewTextBoxColumn.Name = "FAXDataGridViewTextBoxColumn"
        Me.FAXDataGridViewTextBoxColumn.ReadOnly = True
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
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'Rbtn_Nombre
        '
        Me.Rbtn_Nombre.AutoSize = True
        Me.Rbtn_Nombre.Location = New System.Drawing.Point(392, 9)
        Me.Rbtn_Nombre.Name = "Rbtn_Nombre"
        Me.Rbtn_Nombre.Size = New System.Drawing.Size(81, 17)
        Me.Rbtn_Nombre.TabIndex = 1
        Me.Rbtn_Nombre.TabStop = True
        Me.Rbtn_Nombre.Text = "Por Nombre"
        Me.Rbtn_Nombre.UseVisualStyleBackColor = True
        '
        'Rbtn_Alias
        '
        Me.Rbtn_Alias.AutoSize = True
        Me.Rbtn_Alias.Location = New System.Drawing.Point(488, 9)
        Me.Rbtn_Alias.Name = "Rbtn_Alias"
        Me.Rbtn_Alias.Size = New System.Drawing.Size(66, 17)
        Me.Rbtn_Alias.TabIndex = 2
        Me.Rbtn_Alias.TabStop = True
        Me.Rbtn_Alias.Text = "Por Alias"
        Me.Rbtn_Alias.UseVisualStyleBackColor = True
        '
        'Txt_Dato
        '
        Me.Txt_Dato.Location = New System.Drawing.Point(24, 9)
        Me.Txt_Dato.Multiline = True
        Me.Txt_Dato.Name = "Txt_Dato"
        Me.Txt_Dato.Size = New System.Drawing.Size(328, 20)
        Me.Txt_Dato.TabIndex = 3
        '
        'Btn_Filtrar
        '
        Me.Btn_Filtrar.Location = New System.Drawing.Point(634, 9)
        Me.Btn_Filtrar.Name = "Btn_Filtrar"
        Me.Btn_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Filtrar.TabIndex = 4
        Me.Btn_Filtrar.Text = "Filtrar"
        Me.Btn_Filtrar.UseVisualStyleBackColor = True
        '
        'Btn_Quitar_Filtro
        '
        Me.Btn_Quitar_Filtro.Location = New System.Drawing.Point(715, 9)
        Me.Btn_Quitar_Filtro.Name = "Btn_Quitar_Filtro"
        Me.Btn_Quitar_Filtro.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Quitar_Filtro.TabIndex = 4
        Me.Btn_Quitar_Filtro.Text = "Quitar Filtros"
        Me.Btn_Quitar_Filtro.UseVisualStyleBackColor = True
        '
        'Btn_Selecionar
        '
        Me.Btn_Selecionar.Location = New System.Drawing.Point(796, 9)
        Me.Btn_Selecionar.Name = "Btn_Selecionar"
        Me.Btn_Selecionar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Selecionar.TabIndex = 5
        Me.Btn_Selecionar.Text = "Seleccionar"
        Me.Btn_Selecionar.UseVisualStyleBackColor = True
        '
        'Frm_Busqueda_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Selecionar)
        Me.Controls.Add(Me.Btn_Quitar_Filtro)
        Me.Controls.Add(Me.Btn_Filtrar)
        Me.Controls.Add(Me.Txt_Dato)
        Me.Controls.Add(Me.Rbtn_Alias)
        Me.Controls.Add(Me.Rbtn_Nombre)
        Me.Controls.Add(Me.Dgv_Cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Busqueda_cliente"
        Me.Text = "Busqueda Cliente"
        CType(Me.Dgv_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Cliente As DataGridView
    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As ExactusERP_TABLESTableAdapters.CLIENTETableAdapter
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FAXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Rbtn_Nombre As RadioButton
    Friend WithEvents Rbtn_Alias As RadioButton
    Friend WithEvents Txt_Dato As TextBox
    Friend WithEvents Btn_Filtrar As Button
    Friend WithEvents Btn_Quitar_Filtro As Button
    Friend WithEvents Btn_Selecionar As Button
End Class
