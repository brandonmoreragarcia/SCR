<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Encargado_Bodega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Encargado_Bodega))
        Me.Dgv_Encargado_B = New System.Windows.Forms.DataGridView()
        Me.Txt_Encargado_B = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRENCARGADOBODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ENCARGADO_BODEGATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ENCARGADO_BODEGATableAdapter()
        Me.ENCARGADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Encargado_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRENCARGADOBODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Encargado_B
        '
        Me.Dgv_Encargado_B.AllowUserToAddRows = False
        Me.Dgv_Encargado_B.AllowUserToDeleteRows = False
        Me.Dgv_Encargado_B.AutoGenerateColumns = False
        Me.Dgv_Encargado_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Encargado_B.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ENCARGADODataGridViewTextBoxColumn})
        Me.Dgv_Encargado_B.DataSource = Me.SCRENCARGADOBODEGABindingSource
        Me.Dgv_Encargado_B.Location = New System.Drawing.Point(12, 45)
        Me.Dgv_Encargado_B.Name = "Dgv_Encargado_B"
        Me.Dgv_Encargado_B.ReadOnly = True
        Me.Dgv_Encargado_B.Size = New System.Drawing.Size(240, 294)
        Me.Dgv_Encargado_B.TabIndex = 0
        '
        'Txt_Encargado_B
        '
        Me.Txt_Encargado_B.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Encargado_B.Name = "Txt_Encargado_B"
        Me.Txt_Encargado_B.Size = New System.Drawing.Size(351, 20)
        Me.Txt_Encargado_B.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(289, 90)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(289, 173)
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
        'SCRENCARGADOBODEGABindingSource
        '
        Me.SCRENCARGADOBODEGABindingSource.DataMember = "SCR_ENCARGADO_BODEGA"
        Me.SCRENCARGADOBODEGABindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ENCARGADO_BODEGATableAdapter
        '
        Me.SCR_ENCARGADO_BODEGATableAdapter.ClearBeforeFill = True
        '
        'ENCARGADODataGridViewTextBoxColumn
        '
        Me.ENCARGADODataGridViewTextBoxColumn.DataPropertyName = "ENCARGADO"
        Me.ENCARGADODataGridViewTextBoxColumn.HeaderText = "ENCARGADO"
        Me.ENCARGADODataGridViewTextBoxColumn.Name = "ENCARGADODataGridViewTextBoxColumn"
        Me.ENCARGADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Encargado_Bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 351)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Encargado_B)
        Me.Controls.Add(Me.Dgv_Encargado_B)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Encargado_Bodega"
        Me.Text = "Encargado Bodega"
        CType(Me.Dgv_Encargado_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRENCARGADOBODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Encargado_B As DataGridView
    Friend WithEvents Txt_Encargado_B As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRENCARGADOBODEGABindingSource As BindingSource
    Friend WithEvents SCR_ENCARGADO_BODEGATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ENCARGADO_BODEGATableAdapter
    Friend WithEvents ENCARGADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
