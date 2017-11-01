<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Estado_Ruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Estado_Ruta))
        Me.Dgv_Estado_R = New System.Windows.Forms.DataGridView()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Txt_Estado_R = New System.Windows.Forms.TextBox()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRESTADOTRANSPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ESTADO_TRANSPORTETableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_TRANSPORTETableAdapter()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Estado_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRESTADOTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Estado_R
        '
        Me.Dgv_Estado_R.AllowUserToAddRows = False
        Me.Dgv_Estado_R.AllowUserToDeleteRows = False
        Me.Dgv_Estado_R.AutoGenerateColumns = False
        Me.Dgv_Estado_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Estado_R.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESTADODataGridViewTextBoxColumn})
        Me.Dgv_Estado_R.DataSource = Me.SCRESTADOTRANSPORTEBindingSource
        Me.Dgv_Estado_R.Location = New System.Drawing.Point(12, 52)
        Me.Dgv_Estado_R.Name = "Dgv_Estado_R"
        Me.Dgv_Estado_R.ReadOnly = True
        Me.Dgv_Estado_R.Size = New System.Drawing.Size(240, 298)
        Me.Dgv_Estado_R.TabIndex = 0
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(284, 121)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 1
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(284, 191)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 2
        Me.Btn_Eliminar.Text = "&Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Txt_Estado_R
        '
        Me.Txt_Estado_R.Location = New System.Drawing.Point(12, 13)
        Me.Txt_Estado_R.Name = "Txt_Estado_R"
        Me.Txt_Estado_R.Size = New System.Drawing.Size(347, 20)
        Me.Txt_Estado_R.TabIndex = 3
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCRESTADOTRANSPORTEBindingSource
        '
        Me.SCRESTADOTRANSPORTEBindingSource.DataMember = "SCR_ESTADO_TRANSPORTE"
        Me.SCRESTADOTRANSPORTEBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ESTADO_TRANSPORTETableAdapter
        '
        Me.SCR_ESTADO_TRANSPORTETableAdapter.ClearBeforeFill = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Estado_Ruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 362)
        Me.Controls.Add(Me.Txt_Estado_R)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Dgv_Estado_R)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Estado_Ruta"
        Me.Text = "Estado Ruta"
        CType(Me.Dgv_Estado_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRESTADOTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Estado_R As DataGridView
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Txt_Estado_R As TextBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRESTADOTRANSPORTEBindingSource As BindingSource
    Friend WithEvents SCR_ESTADO_TRANSPORTETableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADO_TRANSPORTETableAdapter
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
