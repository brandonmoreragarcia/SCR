<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Impresion_Etiqueta_Salida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Impresion_Etiqueta_Salida))
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Crv_Impresion_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Lbl_Copias = New System.Windows.Forms.Label()
        Me.Txt_Caja = New System.Windows.Forms.TextBox()
        Me.Lbl_Bulto = New System.Windows.Forms.Label()
        Me.Txt_Bulto = New System.Windows.Forms.TextBox()
        Me.Lbl_Bici = New System.Windows.Forms.Label()
        Me.Txt_Bici = New System.Windows.Forms.TextBox()
        Me.Chk_Imprimir_Control = New System.Windows.Forms.CheckBox()
        Me.cb_Numero_Rep = New System.Windows.Forms.ComboBox()
        Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES1 = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_mensaje_impresion = New System.Windows.Forms.Label()
        Me.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter()
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter()
        CType(Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SCRREPARACIONESPORIMPRIMIRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(117, 387)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(87, 29)
        Me.Btn_Imprimir.TabIndex = 10
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cargar.Location = New System.Drawing.Point(117, 315)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(87, 27)
        Me.Btn_Cargar.TabIndex = 9
        Me.Btn_Cargar.Text = "CARGAR"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NUMERO REPARACIÓN:"
        '
        'Crv_Impresion_Rep
        '
        Me.Crv_Impresion_Rep.ActiveViewIndex = -1
        Me.Crv_Impresion_Rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_Impresion_Rep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Impresion_Rep.Location = New System.Drawing.Point(472, 59)
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
        Me.Crv_Impresion_Rep.Size = New System.Drawing.Size(522, 464)
        Me.Crv_Impresion_Rep.TabIndex = 6
        Me.Crv_Impresion_Rep.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Lbl_Copias
        '
        Me.Lbl_Copias.AutoSize = True
        Me.Lbl_Copias.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Copias.Location = New System.Drawing.Point(88, 153)
        Me.Lbl_Copias.Name = "Lbl_Copias"
        Me.Lbl_Copias.Size = New System.Drawing.Size(44, 15)
        Me.Lbl_Copias.TabIndex = 11
        Me.Lbl_Copias.Text = "CAJA:"
        '
        'Txt_Caja
        '
        Me.Txt_Caja.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Caja.Location = New System.Drawing.Point(134, 152)
        Me.Txt_Caja.Name = "Txt_Caja"
        Me.Txt_Caja.Size = New System.Drawing.Size(106, 22)
        Me.Txt_Caja.TabIndex = 1
        '
        'Lbl_Bulto
        '
        Me.Lbl_Bulto.AutoSize = True
        Me.Lbl_Bulto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bulto.Location = New System.Drawing.Point(78, 191)
        Me.Lbl_Bulto.Name = "Lbl_Bulto"
        Me.Lbl_Bulto.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_Bulto.TabIndex = 13
        Me.Lbl_Bulto.Text = "BULTO:"
        '
        'Txt_Bulto
        '
        Me.Txt_Bulto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bulto.Location = New System.Drawing.Point(134, 190)
        Me.Txt_Bulto.Name = "Txt_Bulto"
        Me.Txt_Bulto.Size = New System.Drawing.Size(106, 22)
        Me.Txt_Bulto.TabIndex = 2
        '
        'Lbl_Bici
        '
        Me.Lbl_Bici.AutoSize = True
        Me.Lbl_Bici.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bici.Location = New System.Drawing.Point(89, 232)
        Me.Lbl_Bici.Name = "Lbl_Bici"
        Me.Lbl_Bici.Size = New System.Drawing.Size(36, 15)
        Me.Lbl_Bici.TabIndex = 13
        Me.Lbl_Bici.Text = "BICI:"
        '
        'Txt_Bici
        '
        Me.Txt_Bici.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bici.Location = New System.Drawing.Point(134, 232)
        Me.Txt_Bici.Name = "Txt_Bici"
        Me.Txt_Bici.Size = New System.Drawing.Size(106, 22)
        Me.Txt_Bici.TabIndex = 3
        '
        'Chk_Imprimir_Control
        '
        Me.Chk_Imprimir_Control.AutoSize = True
        Me.Chk_Imprimir_Control.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Imprimir_Control.Location = New System.Drawing.Point(87, 280)
        Me.Chk_Imprimir_Control.Name = "Chk_Imprimir_Control"
        Me.Chk_Imprimir_Control.Size = New System.Drawing.Size(153, 19)
        Me.Chk_Imprimir_Control.TabIndex = 4
        Me.Chk_Imprimir_Control.Text = "IMPRIMIR CONTROL"
        Me.Chk_Imprimir_Control.UseVisualStyleBackColor = True
        '
        'cb_Numero_Rep
        '
        Me.cb_Numero_Rep.DataSource = Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource
        Me.cb_Numero_Rep.DisplayMember = "REPARACION_NUMERO"
        Me.cb_Numero_Rep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Numero_Rep.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Numero_Rep.FormattingEnabled = True
        Me.cb_Numero_Rep.Location = New System.Drawing.Point(185, 79)
        Me.cb_Numero_Rep.Name = "cb_Numero_Rep"
        Me.cb_Numero_Rep.Size = New System.Drawing.Size(110, 24)
        Me.cb_Numero_Rep.TabIndex = 0
        Me.cb_Numero_Rep.ValueMember = "REPARACION_NUMERO"
        '
        'SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource
        '
        Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource.DataMember = "SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDA"
        Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'ExactusERP_SRC_TABLES1
        '
        Me.ExactusERP_SRC_TABLES1.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_mensaje_impresion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_Numero_Rep)
        Me.GroupBox1.Controls.Add(Me.Btn_Cargar)
        Me.GroupBox1.Controls.Add(Me.Chk_Imprimir_Control)
        Me.GroupBox1.Controls.Add(Me.Btn_Imprimir)
        Me.GroupBox1.Controls.Add(Me.Txt_Bici)
        Me.GroupBox1.Controls.Add(Me.Lbl_Copias)
        Me.GroupBox1.Controls.Add(Me.Txt_Bulto)
        Me.GroupBox1.Controls.Add(Me.Txt_Caja)
        Me.GroupBox1.Controls.Add(Me.Lbl_Bici)
        Me.GroupBox1.Controls.Add(Me.Lbl_Bulto)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 473)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN"
        '
        'lb_mensaje_impresion
        '
        Me.lb_mensaje_impresion.AutoSize = True
        Me.lb_mensaje_impresion.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mensaje_impresion.ForeColor = System.Drawing.Color.Red
        Me.lb_mensaje_impresion.Location = New System.Drawing.Point(63, 431)
        Me.lb_mensaje_impresion.Name = "lb_mensaje_impresion"
        Me.lb_mensaje_impresion.Size = New System.Drawing.Size(0, 20)
        Me.lb_mensaje_impresion.TabIndex = 14
        '
        'SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter
        '
        Me.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter.ClearBeforeFill = True
        '
        'SCRREPARACIONESPORIMPRIMIRBindingSource
        '
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource.DataMember = "SCR_REPARACIONES_POR_IMPRIMIR"
        Me.SCRREPARACIONESPORIMPRIMIRBindingSource.DataSource = Me.ExactusERP_SRC_TABLES1
        '
        'SCR_REPARACIONES_POR_IMPRIMIRTableAdapter
        '
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter.ClearBeforeFill = True
        '
        'Frm_Impresion_Etiqueta_Salida
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Crv_Impresion_Rep)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Impresion_Etiqueta_Salida"
        Me.Text = "Impresion Etiqueta Salida"
        CType(Me.SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SCRREPARACIONESPORIMPRIMIRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Crv_Impresion_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Lbl_Copias As Label
    Friend WithEvents Txt_Caja As TextBox
    Friend WithEvents Lbl_Bulto As Label
    Friend WithEvents Txt_Bulto As TextBox
    Friend WithEvents Lbl_Bici As Label
    Friend WithEvents Txt_Bici As TextBox
    Friend WithEvents Chk_Imprimir_Control As CheckBox
    Friend WithEvents cb_Numero_Rep As ComboBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExactusERP_SRC_TABLES1 As ExactusERP_SRC_TABLES
    Friend WithEvents SCRREPARACIONESPENDIENTESDEETIQUETASALIDABindingSource As BindingSource
    Friend WithEvents SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter
    Friend WithEvents SCRREPARACIONESPORIMPRIMIRBindingSource As BindingSource
    Friend WithEvents SCR_REPARACIONES_POR_IMPRIMIRTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter
    Friend WithEvents lb_mensaje_impresion As Label
End Class
