﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Localizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Localizacion))
        Me.Txt_Localizacion = New System.Windows.Forms.TextBox()
        Me.Dgv_Localizacion = New System.Windows.Forms.DataGridView()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRLOCALIZACIONREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_LOCALIZACION_REPTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter()
        Me.LOCALIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Localizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Localizacion
        '
        Me.Txt_Localizacion.Location = New System.Drawing.Point(13, 13)
        Me.Txt_Localizacion.Name = "Txt_Localizacion"
        Me.Txt_Localizacion.Size = New System.Drawing.Size(356, 20)
        Me.Txt_Localizacion.TabIndex = 0
        '
        'Dgv_Localizacion
        '
        Me.Dgv_Localizacion.AllowUserToAddRows = False
        Me.Dgv_Localizacion.AllowUserToDeleteRows = False
        Me.Dgv_Localizacion.AutoGenerateColumns = False
        Me.Dgv_Localizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Localizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOCALIZACIONDataGridViewTextBoxColumn})
        Me.Dgv_Localizacion.DataSource = Me.SCRLOCALIZACIONREPBindingSource
        Me.Dgv_Localizacion.Location = New System.Drawing.Point(13, 39)
        Me.Dgv_Localizacion.Name = "Dgv_Localizacion"
        Me.Dgv_Localizacion.ReadOnly = True
        Me.Dgv_Localizacion.Size = New System.Drawing.Size(240, 349)
        Me.Dgv_Localizacion.TabIndex = 1
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(294, 77)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 2
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(294, 182)
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
        'SCRLOCALIZACIONREPBindingSource
        '
        Me.SCRLOCALIZACIONREPBindingSource.DataMember = "SCR_LOCALIZACION_REP"
        Me.SCRLOCALIZACIONREPBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_LOCALIZACION_REPTableAdapter
        '
        Me.SCR_LOCALIZACION_REPTableAdapter.ClearBeforeFill = True
        '
        'LOCALIZACIONDataGridViewTextBoxColumn
        '
        Me.LOCALIZACIONDataGridViewTextBoxColumn.DataPropertyName = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.HeaderText = "LOCALIZACION"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.Name = "LOCALIZACIONDataGridViewTextBoxColumn"
        Me.LOCALIZACIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Mantenimiento_Localizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 400)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Dgv_Localizacion)
        Me.Controls.Add(Me.Txt_Localizacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Localizacion"
        Me.Text = "Localizacion"
        CType(Me.Dgv_Localizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRLOCALIZACIONREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Localizacion As TextBox
    Friend WithEvents Dgv_Localizacion As DataGridView
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRLOCALIZACIONREPBindingSource As BindingSource
    Friend WithEvents SCR_LOCALIZACION_REPTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_LOCALIZACION_REPTableAdapter
    Friend WithEvents LOCALIZACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
