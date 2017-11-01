<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Busqueda_Articulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Busqueda_Articulo))
        Me.ExactusERP_TABLES = New WindowsApplication1.ExactusERP_TABLES()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ExactusERP_TABLESTableAdapters.TableAdapterManager()
        Me.Dgv_Articulo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Dato = New System.Windows.Forms.TextBox()
        Me.Btn_Filtrar = New System.Windows.Forms.Button()
        Me.Btn_Quitar_Filtros = New System.Windows.Forms.Button()
        Me.Btn_Seleccionar = New System.Windows.Forms.Button()
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExactusERP_TABLES
        '
        Me.ExactusERP_TABLES.DataSetName = "ExactusERP_TABLES"
        Me.ExactusERP_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.ExactusERP_TABLES
        '
        'ARTICULOTableAdapter
        '
        Me.ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARTICULOTableAdapter = Me.ARTICULOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ExactusERP_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dgv_Articulo
        '
        Me.Dgv_Articulo.AllowUserToAddRows = False
        Me.Dgv_Articulo.AllowUserToDeleteRows = False
        Me.Dgv_Articulo.AllowUserToOrderColumns = True
        Me.Dgv_Articulo.AutoGenerateColumns = False
        Me.Dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Articulo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Dgv_Articulo.DataSource = Me.ARTICULOBindingSource
        Me.Dgv_Articulo.Location = New System.Drawing.Point(12, 38)
        Me.Dgv_Articulo.Name = "Dgv_Articulo"
        Me.Dgv_Articulo.ReadOnly = True
        Me.Dgv_Articulo.Size = New System.Drawing.Size(769, 220)
        Me.Dgv_Articulo.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ARTICULO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ARTICULO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 105
        '
        'Txt_Dato
        '
        Me.Txt_Dato.Location = New System.Drawing.Point(12, 12)
        Me.Txt_Dato.Name = "Txt_Dato"
        Me.Txt_Dato.Size = New System.Drawing.Size(298, 20)
        Me.Txt_Dato.TabIndex = 2
        '
        'Btn_Filtrar
        '
        Me.Btn_Filtrar.Location = New System.Drawing.Point(344, 13)
        Me.Btn_Filtrar.Name = "Btn_Filtrar"
        Me.Btn_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Filtrar.TabIndex = 3
        Me.Btn_Filtrar.Text = "&Filtrar"
        Me.Btn_Filtrar.UseVisualStyleBackColor = True
        '
        'Btn_Quitar_Filtros
        '
        Me.Btn_Quitar_Filtros.Location = New System.Drawing.Point(461, 12)
        Me.Btn_Quitar_Filtros.Name = "Btn_Quitar_Filtros"
        Me.Btn_Quitar_Filtros.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Quitar_Filtros.TabIndex = 4
        Me.Btn_Quitar_Filtros.Text = "&Quitar Filtros"
        Me.Btn_Quitar_Filtros.UseVisualStyleBackColor = True
        '
        'Btn_Seleccionar
        '
        Me.Btn_Seleccionar.Location = New System.Drawing.Point(576, 12)
        Me.Btn_Seleccionar.Name = "Btn_Seleccionar"
        Me.Btn_Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Seleccionar.TabIndex = 5
        Me.Btn_Seleccionar.Text = "&Seleccionar"
        Me.Btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Frm_Busqueda_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Seleccionar)
        Me.Controls.Add(Me.Btn_Quitar_Filtros)
        Me.Controls.Add(Me.Btn_Filtrar)
        Me.Controls.Add(Me.Txt_Dato)
        Me.Controls.Add(Me.Dgv_Articulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Busqueda_Articulo"
        Me.RightToLeftLayout = True
        Me.Text = "Busqueda Articulo"
        CType(Me.ExactusERP_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExactusERP_TABLES As ExactusERP_TABLES
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As ExactusERP_TABLESTableAdapters.ARTICULOTableAdapter
    Friend WithEvents TableAdapterManager As ExactusERP_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents Dgv_Articulo As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Dato As TextBox
    Friend WithEvents Btn_Filtrar As Button
    Friend WithEvents Btn_Quitar_Filtros As Button
    Friend WithEvents Btn_Seleccionar As Button
End Class
