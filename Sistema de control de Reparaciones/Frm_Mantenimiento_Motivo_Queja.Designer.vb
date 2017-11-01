<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Motivo_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Motivo_Queja))
        Me.Dgv_Tipo_Queja = New System.Windows.Forms.DataGridView()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRTIPOQUEJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_TIPO_QUEJATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_TIPO_QUEJATableAdapter()
        Me.TIPOQUEJADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Tipo_Queja = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Tipo_Queja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Tipo_Queja
        '
        Me.Dgv_Tipo_Queja.AllowUserToAddRows = False
        Me.Dgv_Tipo_Queja.AllowUserToDeleteRows = False
        Me.Dgv_Tipo_Queja.AutoGenerateColumns = False
        Me.Dgv_Tipo_Queja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Tipo_Queja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPOQUEJADataGridViewTextBoxColumn})
        Me.Dgv_Tipo_Queja.DataSource = Me.SCRTIPOQUEJABindingSource
        Me.Dgv_Tipo_Queja.Location = New System.Drawing.Point(12, 39)
        Me.Dgv_Tipo_Queja.Name = "Dgv_Tipo_Queja"
        Me.Dgv_Tipo_Queja.ReadOnly = True
        Me.Dgv_Tipo_Queja.Size = New System.Drawing.Size(426, 326)
        Me.Dgv_Tipo_Queja.TabIndex = 0
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCRTIPOQUEJABindingSource
        '
        Me.SCRTIPOQUEJABindingSource.DataMember = "SCR_TIPO_QUEJA"
        Me.SCRTIPOQUEJABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_TIPO_QUEJATableAdapter
        '
        Me.SCR_TIPO_QUEJATableAdapter.ClearBeforeFill = True
        '
        'TIPOQUEJADataGridViewTextBoxColumn
        '
        Me.TIPOQUEJADataGridViewTextBoxColumn.DataPropertyName = "TIPO_QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.HeaderText = "TIPO QUEJA"
        Me.TIPOQUEJADataGridViewTextBoxColumn.Name = "TIPOQUEJADataGridViewTextBoxColumn"
        Me.TIPOQUEJADataGridViewTextBoxColumn.ReadOnly = True
        '
        'Txt_Tipo_Queja
        '
        Me.Txt_Tipo_Queja.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Tipo_Queja.Name = "Txt_Tipo_Queja"
        Me.Txt_Tipo_Queja.Size = New System.Drawing.Size(536, 20)
        Me.Txt_Tipo_Queja.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(474, 100)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(474, 173)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 3
        Me.Btn_Eliminar.Text = "&Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Frm_Mantenimiento_Motivo_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 377)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Tipo_Queja)
        Me.Controls.Add(Me.Dgv_Tipo_Queja)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Motivo_Queja"
        Me.Text = "Motivo Queja"
        CType(Me.Dgv_Tipo_Queja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRTIPOQUEJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Tipo_Queja As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRTIPOQUEJABindingSource As BindingSource
    Friend WithEvents SCR_TIPO_QUEJATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_TIPO_QUEJATableAdapter
    Friend WithEvents TIPOQUEJADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Tipo_Queja As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
End Class
