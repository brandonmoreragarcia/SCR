<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Transporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Transporte))
        Me.Dgv_Transporte = New System.Windows.Forms.DataGridView()
        Me.Txt_Transporte = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRTRANSPORTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_TRANSPORTETableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TRANSPORTETableAdapter()
        Me.TRANSPORTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Transporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Transporte
        '
        Me.Dgv_Transporte.AllowUserToAddRows = False
        Me.Dgv_Transporte.AllowUserToDeleteRows = False
        Me.Dgv_Transporte.AutoGenerateColumns = False
        Me.Dgv_Transporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Transporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSPORTEDataGridViewTextBoxColumn})
        Me.Dgv_Transporte.DataSource = Me.SCRTRANSPORTEBindingSource
        Me.Dgv_Transporte.Location = New System.Drawing.Point(12, 49)
        Me.Dgv_Transporte.Name = "Dgv_Transporte"
        Me.Dgv_Transporte.ReadOnly = True
        Me.Dgv_Transporte.Size = New System.Drawing.Size(240, 312)
        Me.Dgv_Transporte.TabIndex = 0
        '
        'Txt_Transporte
        '
        Me.Txt_Transporte.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Transporte.Name = "Txt_Transporte"
        Me.Txt_Transporte.Size = New System.Drawing.Size(341, 20)
        Me.Txt_Transporte.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(279, 96)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(279, 173)
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
        'SCRTRANSPORTEBindingSource
        '
        Me.SCRTRANSPORTEBindingSource.DataMember = "SCR_TRANSPORTE"
        Me.SCRTRANSPORTEBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_TRANSPORTETableAdapter
        '
        Me.SCR_TRANSPORTETableAdapter.ClearBeforeFill = True
        '
        'TRANSPORTEDataGridViewTextBoxColumn
        '
        Me.TRANSPORTEDataGridViewTextBoxColumn.DataPropertyName = "TRANSPORTE"
        Me.TRANSPORTEDataGridViewTextBoxColumn.HeaderText = "TRANSPORTE"
        Me.TRANSPORTEDataGridViewTextBoxColumn.Name = "TRANSPORTEDataGridViewTextBoxColumn"
        Me.TRANSPORTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Transporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 373)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Transporte)
        Me.Controls.Add(Me.Dgv_Transporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Transporte"
        Me.Text = "Transporte"
        CType(Me.Dgv_Transporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTRANSPORTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Transporte As DataGridView
    Friend WithEvents Txt_Transporte As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRTRANSPORTEBindingSource As BindingSource
    Friend WithEvents SCR_TRANSPORTETableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TRANSPORTETableAdapter
    Friend WithEvents TRANSPORTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
