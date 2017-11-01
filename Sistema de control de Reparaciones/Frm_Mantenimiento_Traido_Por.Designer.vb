<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Traido_Por
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Traido_Por))
        Me.Dgv_Traido_Por = New System.Windows.Forms.DataGridView()
        Me.TRAIDOPORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRTRAIDOPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_TRAIDO_PORTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TRAIDO_PORTableAdapter()
        Me.Txt_Traido_Por = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Traido_Por, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTRAIDOPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Traido_Por
        '
        Me.Dgv_Traido_Por.AllowUserToAddRows = False
        Me.Dgv_Traido_Por.AllowUserToDeleteRows = False
        Me.Dgv_Traido_Por.AutoGenerateColumns = False
        Me.Dgv_Traido_Por.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Traido_Por.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRAIDOPORDataGridViewTextBoxColumn})
        Me.Dgv_Traido_Por.DataSource = Me.SCRTRAIDOPORBindingSource
        Me.Dgv_Traido_Por.Location = New System.Drawing.Point(12, 41)
        Me.Dgv_Traido_Por.Name = "Dgv_Traido_Por"
        Me.Dgv_Traido_Por.ReadOnly = True
        Me.Dgv_Traido_Por.Size = New System.Drawing.Size(240, 298)
        Me.Dgv_Traido_Por.TabIndex = 0
        '
        'TRAIDOPORDataGridViewTextBoxColumn
        '
        Me.TRAIDOPORDataGridViewTextBoxColumn.DataPropertyName = "TRAIDO_POR"
        Me.TRAIDOPORDataGridViewTextBoxColumn.HeaderText = "TRAIDO POR"
        Me.TRAIDOPORDataGridViewTextBoxColumn.Name = "TRAIDOPORDataGridViewTextBoxColumn"
        Me.TRAIDOPORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCRTRAIDOPORBindingSource
        '
        Me.SCRTRAIDOPORBindingSource.DataMember = "SCR_TRAIDO_POR"
        Me.SCRTRAIDOPORBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_TRAIDO_PORTableAdapter
        '
        Me.SCR_TRAIDO_PORTableAdapter.ClearBeforeFill = True
        '
        'Txt_Traido_Por
        '
        Me.Txt_Traido_Por.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Traido_Por.Name = "Txt_Traido_Por"
        Me.Txt_Traido_Por.Size = New System.Drawing.Size(340, 20)
        Me.Txt_Traido_Por.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(278, 135)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(278, 178)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 3
        Me.Btn_Eliminar.Text = "&Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Frm_Mantenimiento_Traido_Por
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 351)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Traido_Por)
        Me.Controls.Add(Me.Dgv_Traido_Por)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Traido_Por"
        Me.Text = "Traido Por"
        CType(Me.Dgv_Traido_Por, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTRAIDOPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Traido_Por As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRTRAIDOPORBindingSource As BindingSource
    Friend WithEvents SCR_TRAIDO_PORTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TRAIDO_PORTableAdapter
    Friend WithEvents TRAIDOPORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Traido_Por As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
End Class
