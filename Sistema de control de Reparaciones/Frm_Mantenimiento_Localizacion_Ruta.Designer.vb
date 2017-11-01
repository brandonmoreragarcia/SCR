<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Localizacion_Ruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Localizacion_Ruta))
        Me.Dgv_Localizacion_Ruta = New System.Windows.Forms.DataGridView()
        Me.Txt_Mantenimiento_R = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRLOCALIZACIONTRANSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_LOCALIZACION_TRANSTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_TRANSTableAdapter()
        Me.LOCALIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Localizacion_Ruta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRLOCALIZACIONTRANSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Localizacion_Ruta
        '
        Me.Dgv_Localizacion_Ruta.AllowUserToAddRows = False
        Me.Dgv_Localizacion_Ruta.AllowUserToDeleteRows = False
        Me.Dgv_Localizacion_Ruta.AutoGenerateColumns = False
        Me.Dgv_Localizacion_Ruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Localizacion_Ruta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOCALIZACIONDataGridViewTextBoxColumn})
        Me.Dgv_Localizacion_Ruta.DataSource = Me.SCRLOCALIZACIONTRANSBindingSource
        Me.Dgv_Localizacion_Ruta.Location = New System.Drawing.Point(12, 51)
        Me.Dgv_Localizacion_Ruta.Name = "Dgv_Localizacion_Ruta"
        Me.Dgv_Localizacion_Ruta.ReadOnly = True
        Me.Dgv_Localizacion_Ruta.Size = New System.Drawing.Size(240, 324)
        Me.Dgv_Localizacion_Ruta.TabIndex = 0
        '
        'Txt_Mantenimiento_R
        '
        Me.Txt_Mantenimiento_R.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Mantenimiento_R.Name = "Txt_Mantenimiento_R"
        Me.Txt_Mantenimiento_R.Size = New System.Drawing.Size(327, 20)
        Me.Txt_Mantenimiento_R.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(265, 91)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(265, 176)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 3
        Me.Btn_Eliminar.Text = "&Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCRLOCALIZACIONTRANSBindingSource
        '
        Me.SCRLOCALIZACIONTRANSBindingSource.DataMember = "SCR_LOCALIZACION_TRANS"
        Me.SCRLOCALIZACIONTRANSBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_LOCALIZACION_TRANSTableAdapter
        '
        Me.SCR_LOCALIZACION_TRANSTableAdapter.ClearBeforeFill = True
        '
        'LOCALIZACIONDataGridViewTextBoxColumn
        '
        Me.LOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Name = "LOCALIZACIONDataGridViewTextBoxColumn"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Localizacion_Ruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 387)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Mantenimiento_R)
        Me.Controls.Add(Me.Dgv_Localizacion_Ruta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Localizacion_Ruta"
        Me.Text = "Localizacion Ruta"
        CType(Me.Dgv_Localizacion_Ruta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRLOCALIZACIONTRANSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Localizacion_Ruta As DataGridView
    Friend WithEvents Txt_Mantenimiento_R As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRLOCALIZACIONTRANSBindingSource As BindingSource
    Friend WithEvents SCR_LOCALIZACION_TRANSTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_TRANSTableAdapter
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
