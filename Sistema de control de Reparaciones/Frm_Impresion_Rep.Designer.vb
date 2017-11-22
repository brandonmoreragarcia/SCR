<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Impresion_Rep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Impresion_Rep))
        Me.Crv_Impresion_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Exportar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir_Consumo = New System.Windows.Forms.Button()
        Me.cb_Numero_Rep = New System.Windows.Forms.ComboBox()
        Me.SCR_DATOS_REPARACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCR_DATOS_REPARACIONTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.TableAdapterManager()
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter()
        CType(Me.SCR_DATOS_REPARACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRREPARACIONESPORIMPRIMIRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Crv_Impresion_Rep
        '
        Me.Crv_Impresion_Rep.ActiveViewIndex = -1
        Me.Crv_Impresion_Rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_Impresion_Rep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Impresion_Rep.Location = New System.Drawing.Point(44, 78)
        Me.Crv_Impresion_Rep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Crv_Impresion_Rep.Name = "Crv_Impresion_Rep"
        Me.Crv_Impresion_Rep.ShowCloseButton = False
        Me.Crv_Impresion_Rep.ShowCopyButton = False
        Me.Crv_Impresion_Rep.ShowExportButton = False
        Me.Crv_Impresion_Rep.ShowGotoPageButton = False
        Me.Crv_Impresion_Rep.ShowGroupTreeButton = False
        Me.Crv_Impresion_Rep.ShowPageNavigateButtons = False
        Me.Crv_Impresion_Rep.ShowParameterPanelButton = False
        Me.Crv_Impresion_Rep.ShowPrintButton = False
        Me.Crv_Impresion_Rep.ShowRefreshButton = False
        Me.Crv_Impresion_Rep.ShowTextSearchButton = False
        Me.Crv_Impresion_Rep.ShowZoomButton = False
        Me.Crv_Impresion_Rep.Size = New System.Drawing.Size(1194, 446)
        Me.Crv_Impresion_Rep.TabIndex = 0
        Me.Crv_Impresion_Rep.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NÚMERO REPARACIÓN:"
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cargar.Location = New System.Drawing.Point(385, 34)
        Me.Btn_Cargar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(110, 24)
        Me.Btn_Cargar.TabIndex = 1
        Me.Btn_Cargar.Text = "CARGAR"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(634, 35)
        Me.Btn_Imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(107, 25)
        Me.Btn_Imprimir.TabIndex = 4
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exportar.Location = New System.Drawing.Point(759, 35)
        Me.Btn_Exportar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(115, 24)
        Me.Btn_Exportar.TabIndex = 5
        Me.Btn_Exportar.Text = "EXPORTAR"
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir_Consumo
        '
        Me.Btn_Imprimir_Consumo.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir_Consumo.Location = New System.Drawing.Point(891, 35)
        Me.Btn_Imprimir_Consumo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Imprimir_Consumo.Name = "Btn_Imprimir_Consumo"
        Me.Btn_Imprimir_Consumo.Size = New System.Drawing.Size(184, 25)
        Me.Btn_Imprimir_Consumo.TabIndex = 6
        Me.Btn_Imprimir_Consumo.Text = "IMPRIMIR CONSUMO"
        Me.Btn_Imprimir_Consumo.UseVisualStyleBackColor = True
        '
        'cb_Numero_Rep
        '
        Me.cb_Numero_Rep.DataSource = Me.SCRREPARACIONESPORIMPRIMIRBindingSource
        Me.cb_Numero_Rep.DisplayMember = "REPARACION_NUMERO"
        Me.cb_Numero_Rep.FormattingEnabled = True
        Me.cb_Numero_Rep.Location = New System.Drawing.Point(259, 35)
        Me.cb_Numero_Rep.Name = "cb_Numero_Rep"
        Me.cb_Numero_Rep.Size = New System.Drawing.Size(110, 23)
        Me.cb_Numero_Rep.TabIndex = 0
        Me.cb_Numero_Rep.ValueMember = "REPARACION_NUMERO"
        '
        'SCR_DATOS_REPARACIONBindingSource
        '
        Me.SCR_DATOS_REPARACIONBindingSource.DataMember = "SCR_DATOS_REPARACION"
        Me.SCR_DATOS_REPARACIONBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        Me.SCR_DATOS_REPARACIONBindingSource.Sort = ""
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCR_DATOS_REPARACIONTableAdapter
        '
        Me.SCR_DATOS_REPARACIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SCR_ACTUALIZACION_REPARADATableAdapter = Nothing
        Me.TableAdapterManager.SCR_ACTUALIZACION_REPTableAdapter = Nothing
        Me.TableAdapterManager.SCR_ACTUALIZACION_RUTATableAdapter = Nothing
        Me.TableAdapterManager.SCR_ADICIONAL_REPTableAdapter = Nothing
        Me.TableAdapterManager.SCR_CONTORL_IMPR_ETQ_SALTableAdapter = Nothing
        Me.TableAdapterManager.SCR_CONTROL_IMPR_REPTableAdapter = Nothing
        Me.TableAdapterManager.SCR_DATOS_QUEJATableAdapter = Nothing
        Me.TableAdapterManager.SCR_DATOS_REPARACIONTableAdapter = Me.SCR_DATOS_REPARACIONTableAdapter
        Me.TableAdapterManager.SCR_ENCARGADO_BODEGATableAdapter = Nothing
        Me.TableAdapterManager.SCR_ESTADO_ACTUATableAdapter = Nothing
        Me.TableAdapterManager.SCR_ESTADO_INGRESOTableAdapter = Nothing
        Me.TableAdapterManager.SCR_ESTADO_QUEJATableAdapter = Nothing
        Me.TableAdapterManager.SCR_ESTADO_TRANSPORTETableAdapter = Nothing
        Me.TableAdapterManager.SCR_LOCALIZACION_REPTableAdapter = Nothing
        Me.TableAdapterManager.SCR_LOCALIZACION_TRANSTableAdapter = Nothing
        Me.TableAdapterManager.SCR_MOTIVOTableAdapter = Nothing
        Me.TableAdapterManager.SCR_QUEJA_PROCESADATableAdapter = Nothing
        Me.TableAdapterManager.SCR_SOLUCION_QUEJATableAdapter = Nothing
        Me.TableAdapterManager.SCR_TIPO_QUEJATableAdapter = Nothing
        Me.TableAdapterManager.SCR_TRAIDO_PORTableAdapter = Nothing
        Me.TableAdapterManager.SCR_TRANSPORTETableAdapter = Nothing
        Me.TableAdapterManager.SCR_Usuario_PTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SCRREPARACIONESPORIMPRIMIRBindingSource
        '
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource.DataMember = "SCR_REPARACIONES_POR_IMPRIMIR"
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_REPARACIONES_POR_IMPRIMIRTableAdapter
        '
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter.ClearBeforeFill = True
        '
        'Frm_Impresion_Rep
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.cb_Numero_Rep)
        Me.Controls.Add(Me.Btn_Imprimir_Consumo)
        Me.Controls.Add(Me.Btn_Exportar)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Crv_Impresion_Rep)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Impresion_Rep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Reparacion"
        CType(Me.SCR_DATOS_REPARACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRREPARACIONESPORIMPRIMIRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Crv_Impresion_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Btn_Exportar As Button
    Friend WithEvents Btn_Imprimir_Consumo As Button
    Friend WithEvents cb_Numero_Rep As ComboBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCR_DATOS_REPARACIONBindingSource As BindingSource
    Friend WithEvents SCR_DATOS_REPARACIONTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_DATOS_REPARACIONTableAdapter
    Friend WithEvents TableAdapterManager As ExactusERP_SRC_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents SCRREPARACIONESPORIMPRIMIRBindingSource As BindingSource
    Friend WithEvents SCR_REPARACIONES_POR_IMPRIMIRTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter
End Class
