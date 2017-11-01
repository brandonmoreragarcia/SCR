<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Motivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Motivo))
        Me.Dgv_Motivo = New System.Windows.Forms.DataGridView()
        Me.Txt_Motivo = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRMOTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_MOTIVOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_MOTIVOTableAdapter()
        Me.MOTIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Motivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRMOTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Motivo
        '
        Me.Dgv_Motivo.AllowUserToAddRows = False
        Me.Dgv_Motivo.AllowUserToDeleteRows = False
        Me.Dgv_Motivo.AutoGenerateColumns = False
        Me.Dgv_Motivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Motivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MOTIVODataGridViewTextBoxColumn})
        Me.Dgv_Motivo.DataSource = Me.SCRMOTIVOBindingSource
        Me.Dgv_Motivo.Location = New System.Drawing.Point(12, 50)
        Me.Dgv_Motivo.Name = "Dgv_Motivo"
        Me.Dgv_Motivo.ReadOnly = True
        Me.Dgv_Motivo.Size = New System.Drawing.Size(263, 284)
        Me.Dgv_Motivo.TabIndex = 0
        '
        'Txt_Motivo
        '
        Me.Txt_Motivo.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Motivo.Name = "Txt_Motivo"
        Me.Txt_Motivo.Size = New System.Drawing.Size(360, 20)
        Me.Txt_Motivo.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(298, 102)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(298, 162)
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
        'SCRMOTIVOBindingSource
        '
        Me.SCRMOTIVOBindingSource.DataMember = "SCR_MOTIVO"
        Me.SCRMOTIVOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_MOTIVOTableAdapter
        '
        Me.SCR_MOTIVOTableAdapter.ClearBeforeFill = True
        '
        'MOTIVODataGridViewTextBoxColumn
        '
        Me.MOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO"
        Me.MOTIVODataGridViewTextBoxColumn.HeaderText = "MOTIVO"
        Me.MOTIVODataGridViewTextBoxColumn.Name = "MOTIVODataGridViewTextBoxColumn"
        Me.MOTIVODataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Motivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 346)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Motivo)
        Me.Controls.Add(Me.Dgv_Motivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Motivo"
        Me.Text = "Motivo"
        CType(Me.Dgv_Motivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRMOTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Motivo As DataGridView
    Friend WithEvents Txt_Motivo As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRMOTIVOBindingSource As BindingSource
    Friend WithEvents SCR_MOTIVOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_MOTIVOTableAdapter
    Friend WithEvents MOTIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
