<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Rep_Total
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rep_Total))
        Me.Dgv_Rep_Total = New System.Windows.Forms.DataGridView()
        Me.REPARACIONNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOLETADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTOREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEPRODUCTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRPROCREPLISTADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_PROC_REP_LISTADOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_PROC_REP_LISTADOTableAdapter()
        Me.Dtp_Fecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fecha_Final = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Fecha_Inicio = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Final = New System.Windows.Forms.Label()
        Me.Check_fecha = New System.Windows.Forms.CheckBox()
        Me.Check_Estado = New System.Windows.Forms.CheckBox()
        Me.Cbx_Estados = New System.Windows.Forms.ComboBox()
        Me.SCRESTADOSTOTALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ESTADOS_TOTALTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADOS_TOTALTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Filtrar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Rep_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRPROCREPLISTADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRESTADOSTOTALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Rep_Total
        '
        Me.Dgv_Rep_Total.AllowUserToAddRows = False
        Me.Dgv_Rep_Total.AllowUserToDeleteRows = False
        Me.Dgv_Rep_Total.AllowUserToOrderColumns = True
        Me.Dgv_Rep_Total.AutoGenerateColumns = False
        Me.Dgv_Rep_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Rep_Total.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REPARACIONNUMERODataGridViewTextBoxColumn, Me.CODIGOCLIENTEDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.ALIASDataGridViewTextBoxColumn, Me.CODIGOARTDataGridViewTextBoxColumn, Me.DESCRIPCIONDataGridViewTextBoxColumn, Me.BOLETADataGridViewTextBoxColumn, Me.DOCUMENTOREFDataGridViewTextBoxColumn, Me.SERIEPRODUCTODataGridViewTextBoxColumn, Me.PROBLEMAREPORTADODataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.FECHA})
        Me.Dgv_Rep_Total.DataSource = Me.SCRPROCREPLISTADOBindingSource
        Me.Dgv_Rep_Total.Location = New System.Drawing.Point(12, 90)
        Me.Dgv_Rep_Total.Name = "Dgv_Rep_Total"
        Me.Dgv_Rep_Total.ReadOnly = True
        Me.Dgv_Rep_Total.Size = New System.Drawing.Size(1298, 378)
        Me.Dgv_Rep_Total.TabIndex = 0
        '
        'REPARACIONNUMERODataGridViewTextBoxColumn
        '
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.DataPropertyName = "REPARACION_NUMERO"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.HeaderText = "REPARACION #"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Name = "REPARACIONNUMERODataGridViewTextBoxColumn"
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.REPARACIONNUMERODataGridViewTextBoxColumn.Width = 103
        '
        'CODIGOCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.HeaderText = "COD CLIENTE"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.Name = "CODIGOCLIENTEDataGridViewTextBoxColumn"
        Me.CODIGOCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ALIASDataGridViewTextBoxColumn
        '
        Me.ALIASDataGridViewTextBoxColumn.DataPropertyName = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.HeaderText = "ALIAS"
        Me.ALIASDataGridViewTextBoxColumn.Name = "ALIASDataGridViewTextBoxColumn"
        Me.ALIASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CODIGOARTDataGridViewTextBoxColumn
        '
        Me.CODIGOARTDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_ART"
        Me.CODIGOARTDataGridViewTextBoxColumn.HeaderText = "COD ART"
        Me.CODIGOARTDataGridViewTextBoxColumn.Name = "CODIGOARTDataGridViewTextBoxColumn"
        Me.CODIGOARTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.Name = "DESCRIPCIONDataGridViewTextBoxColumn"
        Me.DESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BOLETADataGridViewTextBoxColumn
        '
        Me.BOLETADataGridViewTextBoxColumn.DataPropertyName = "BOLETA"
        Me.BOLETADataGridViewTextBoxColumn.HeaderText = "BOLETA"
        Me.BOLETADataGridViewTextBoxColumn.Name = "BOLETADataGridViewTextBoxColumn"
        Me.BOLETADataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCUMENTOREFDataGridViewTextBoxColumn
        '
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTO_REF"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.HeaderText = "DOC REF"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.Name = "DOCUMENTOREFDataGridViewTextBoxColumn"
        Me.DOCUMENTOREFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERIEPRODUCTODataGridViewTextBoxColumn
        '
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "SERIE_PRODUCTO"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.HeaderText = "SERIE ART"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.Name = "SERIEPRODUCTODataGridViewTextBoxColumn"
        Me.SERIEPRODUCTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROBLEMAREPORTADODataGridViewTextBoxColumn
        '
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.DataPropertyName = "PROBLEMA_REPORTADO"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.HeaderText = "PROBLEMA REPORTADO"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.Name = "PROBLEMAREPORTADODataGridViewTextBoxColumn"
        Me.PROBLEMAREPORTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'SCRPROCREPLISTADOBindingSource
        '
        Me.SCRPROCREPLISTADOBindingSource.DataMember = "SCR_PROC_REP_LISTADO"
        Me.SCRPROCREPLISTADOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_PROC_REP_LISTADOTableAdapter
        '
        Me.SCR_PROC_REP_LISTADOTableAdapter.ClearBeforeFill = True
        '
        'Dtp_Fecha_Inicio
        '
        Me.Dtp_Fecha_Inicio.Location = New System.Drawing.Point(55, 32)
        Me.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio"
        Me.Dtp_Fecha_Inicio.Size = New System.Drawing.Size(120, 20)
        Me.Dtp_Fecha_Inicio.TabIndex = 1
        Me.Dtp_Fecha_Inicio.Visible = False
        '
        'Dtp_Fecha_Final
        '
        Me.Dtp_Fecha_Final.Location = New System.Drawing.Point(55, 58)
        Me.Dtp_Fecha_Final.Name = "Dtp_Fecha_Final"
        Me.Dtp_Fecha_Final.Size = New System.Drawing.Size(120, 20)
        Me.Dtp_Fecha_Final.TabIndex = 2
        Me.Dtp_Fecha_Final.Visible = False
        '
        'Lbl_Fecha_Inicio
        '
        Me.Lbl_Fecha_Inicio.AutoSize = True
        Me.Lbl_Fecha_Inicio.Location = New System.Drawing.Point(25, 35)
        Me.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio"
        Me.Lbl_Fecha_Inicio.Size = New System.Drawing.Size(23, 13)
        Me.Lbl_Fecha_Inicio.TabIndex = 3
        Me.Lbl_Fecha_Inicio.Text = "Del"
        Me.Lbl_Fecha_Inicio.Visible = False
        '
        'Lbl_Fecha_Final
        '
        Me.Lbl_Fecha_Final.AutoSize = True
        Me.Lbl_Fecha_Final.Location = New System.Drawing.Point(26, 62)
        Me.Lbl_Fecha_Final.Name = "Lbl_Fecha_Final"
        Me.Lbl_Fecha_Final.Size = New System.Drawing.Size(16, 13)
        Me.Lbl_Fecha_Final.TabIndex = 4
        Me.Lbl_Fecha_Final.Text = "Al"
        Me.Lbl_Fecha_Final.Visible = False
        '
        'Check_fecha
        '
        Me.Check_fecha.AutoSize = True
        Me.Check_fecha.Location = New System.Drawing.Point(68, 9)
        Me.Check_fecha.Name = "Check_fecha"
        Me.Check_fecha.Size = New System.Drawing.Size(75, 17)
        Me.Check_fecha.TabIndex = 5
        Me.Check_fecha.Text = "Por Fecha"
        Me.Check_fecha.UseVisualStyleBackColor = True
        '
        'Check_Estado
        '
        Me.Check_Estado.AutoSize = True
        Me.Check_Estado.Location = New System.Drawing.Point(215, 9)
        Me.Check_Estado.Name = "Check_Estado"
        Me.Check_Estado.Size = New System.Drawing.Size(77, 17)
        Me.Check_Estado.TabIndex = 6
        Me.Check_Estado.Text = "Por estado"
        Me.Check_Estado.UseVisualStyleBackColor = True
        '
        'Cbx_Estados
        '
        Me.Cbx_Estados.DataSource = Me.SCRESTADOSTOTALBindingSource
        Me.Cbx_Estados.DisplayMember = "ESTADO"
        Me.Cbx_Estados.DropDownWidth = 240
        Me.Cbx_Estados.FormattingEnabled = True
        Me.Cbx_Estados.Location = New System.Drawing.Point(202, 31)
        Me.Cbx_Estados.Name = "Cbx_Estados"
        Me.Cbx_Estados.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_Estados.TabIndex = 7
        Me.Cbx_Estados.Visible = False
        '
        'SCRESTADOSTOTALBindingSource
        '
        Me.SCRESTADOSTOTALBindingSource.DataMember = "SCR_ESTADOS_TOTAL"
        Me.SCRESTADOSTOTALBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ESTADOS_TOTALTableAdapter
        '
        Me.SCR_ESTADOS_TOTALTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(611, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Eliminar Filtros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_Filtrar
        '
        Me.Btn_Filtrar.Location = New System.Drawing.Point(611, 3)
        Me.Btn_Filtrar.Name = "Btn_Filtrar"
        Me.Btn_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Filtrar.TabIndex = 9
        Me.Btn_Filtrar.Text = "Filtrar"
        Me.Btn_Filtrar.UseVisualStyleBackColor = True
        '
        'Frm_Rep_Total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 480)
        Me.Controls.Add(Me.Btn_Filtrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cbx_Estados)
        Me.Controls.Add(Me.Check_Estado)
        Me.Controls.Add(Me.Check_fecha)
        Me.Controls.Add(Me.Lbl_Fecha_Final)
        Me.Controls.Add(Me.Lbl_Fecha_Inicio)
        Me.Controls.Add(Me.Dtp_Fecha_Final)
        Me.Controls.Add(Me.Dtp_Fecha_Inicio)
        Me.Controls.Add(Me.Dgv_Rep_Total)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Rep_Total"
        Me.Text = "SISTEMA DE CONTROL DE REPARACIONES"
        CType(Me.Dgv_Rep_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRPROCREPLISTADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRESTADOSTOTALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Rep_Total As DataGridView
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRPROCREPLISTADOBindingSource As BindingSource
    Friend WithEvents SCR_PROC_REP_LISTADOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_PROC_REP_LISTADOTableAdapter
    Friend WithEvents REPARACIONNUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOARTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BOLETADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTOREFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SERIEPRODUCTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROBLEMAREPORTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Dtp_Fecha_Inicio As DateTimePicker
    Friend WithEvents Dtp_Fecha_Final As DateTimePicker
    Friend WithEvents Lbl_Fecha_Inicio As Label
    Friend WithEvents Lbl_Fecha_Final As Label
    Friend WithEvents Check_fecha As CheckBox
    Friend WithEvents Check_Estado As CheckBox
    Friend WithEvents Cbx_Estados As ComboBox
    Friend WithEvents SCRESTADOSTOTALBindingSource As BindingSource
    Friend WithEvents SCR_ESTADOS_TOTALTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ESTADOS_TOTALTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_Filtrar As Button
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
End Class
