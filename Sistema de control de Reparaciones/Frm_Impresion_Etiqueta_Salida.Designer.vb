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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Impresion_Etiqueta_Salida))
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Txt_Numero_Rep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Crv_Impresion_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Lbl_Copias = New System.Windows.Forms.Label()
        Me.Txt_Caja = New System.Windows.Forms.TextBox()
        Me.Lbl_Bulto = New System.Windows.Forms.Label()
        Me.Txt_Bulto = New System.Windows.Forms.TextBox()
        Me.Lbl_Bici = New System.Windows.Forms.Label()
        Me.Txt_Bici = New System.Windows.Forms.TextBox()
        Me.Chk_Imprimir_Control = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Enabled = False
        Me.Btn_Imprimir.Location = New System.Drawing.Point(418, 37)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Imprimir.TabIndex = 10
        Me.Btn_Imprimir.Text = "&Imprimir"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        Me.Btn_Imprimir.Visible = False
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Enabled = False
        Me.Btn_Cargar.Location = New System.Drawing.Point(418, 8)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cargar.TabIndex = 9
        Me.Btn_Cargar.Text = "&Cargar"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        Me.Btn_Cargar.Visible = False
        '
        'Txt_Numero_Rep
        '
        Me.Txt_Numero_Rep.Location = New System.Drawing.Point(212, 14)
        Me.Txt_Numero_Rep.Name = "Txt_Numero_Rep"
        Me.Txt_Numero_Rep.Size = New System.Drawing.Size(115, 20)
        Me.Txt_Numero_Rep.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero de Reparacion:"
        '
        'Crv_Impresion_Rep
        '
        Me.Crv_Impresion_Rep.ActiveViewIndex = -1
        Me.Crv_Impresion_Rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_Impresion_Rep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Impresion_Rep.Location = New System.Drawing.Point(-10, 93)
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
        Me.Crv_Impresion_Rep.Size = New System.Drawing.Size(633, 325)
        Me.Crv_Impresion_Rep.TabIndex = 6
        Me.Crv_Impresion_Rep.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Lbl_Copias
        '
        Me.Lbl_Copias.AutoSize = True
        Me.Lbl_Copias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Copias.Location = New System.Drawing.Point(10, 37)
        Me.Lbl_Copias.Name = "Lbl_Copias"
        Me.Lbl_Copias.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_Copias.TabIndex = 11
        Me.Lbl_Copias.Text = "Caja"
        '
        'Txt_Caja
        '
        Me.Txt_Caja.Enabled = False
        Me.Txt_Caja.Location = New System.Drawing.Point(56, 34)
        Me.Txt_Caja.Name = "Txt_Caja"
        Me.Txt_Caja.Size = New System.Drawing.Size(54, 20)
        Me.Txt_Caja.TabIndex = 12
        '
        'Lbl_Bulto
        '
        Me.Lbl_Bulto.AutoSize = True
        Me.Lbl_Bulto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bulto.Location = New System.Drawing.Point(130, 37)
        Me.Lbl_Bulto.Name = "Lbl_Bulto"
        Me.Lbl_Bulto.Size = New System.Drawing.Size(45, 17)
        Me.Lbl_Bulto.TabIndex = 13
        Me.Lbl_Bulto.Text = "Bulto"
        '
        'Txt_Bulto
        '
        Me.Txt_Bulto.Enabled = False
        Me.Txt_Bulto.Location = New System.Drawing.Point(176, 36)
        Me.Txt_Bulto.Name = "Txt_Bulto"
        Me.Txt_Bulto.Size = New System.Drawing.Size(54, 20)
        Me.Txt_Bulto.TabIndex = 14
        '
        'Lbl_Bici
        '
        Me.Lbl_Bici.AutoSize = True
        Me.Lbl_Bici.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bici.Location = New System.Drawing.Point(250, 39)
        Me.Lbl_Bici.Name = "Lbl_Bici"
        Me.Lbl_Bici.Size = New System.Drawing.Size(34, 17)
        Me.Lbl_Bici.TabIndex = 13
        Me.Lbl_Bici.Text = "Bici"
        '
        'Txt_Bici
        '
        Me.Txt_Bici.Enabled = False
        Me.Txt_Bici.Location = New System.Drawing.Point(296, 36)
        Me.Txt_Bici.Name = "Txt_Bici"
        Me.Txt_Bici.Size = New System.Drawing.Size(54, 20)
        Me.Txt_Bici.TabIndex = 15
        '
        'Chk_Imprimir_Control
        '
        Me.Chk_Imprimir_Control.AutoSize = True
        Me.Chk_Imprimir_Control.Location = New System.Drawing.Point(133, 62)
        Me.Chk_Imprimir_Control.Name = "Chk_Imprimir_Control"
        Me.Chk_Imprimir_Control.Size = New System.Drawing.Size(97, 17)
        Me.Chk_Imprimir_Control.TabIndex = 16
        Me.Chk_Imprimir_Control.Text = "Imprimir Control"
        Me.Chk_Imprimir_Control.UseVisualStyleBackColor = True
        '
        'Frm_Impresion_Etiqueta_Salida
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 430)
        Me.Controls.Add(Me.Chk_Imprimir_Control)
        Me.Controls.Add(Me.Txt_Bici)
        Me.Controls.Add(Me.Txt_Bulto)
        Me.Controls.Add(Me.Lbl_Bici)
        Me.Controls.Add(Me.Lbl_Bulto)
        Me.Controls.Add(Me.Txt_Caja)
        Me.Controls.Add(Me.Lbl_Copias)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Controls.Add(Me.Txt_Numero_Rep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Crv_Impresion_Rep)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Impresion_Etiqueta_Salida"
        Me.Text = "Impresion Etiqueta Salida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Txt_Numero_Rep As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Crv_Impresion_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Lbl_Copias As Label
    Friend WithEvents Txt_Caja As TextBox
    Friend WithEvents Lbl_Bulto As Label
    Friend WithEvents Txt_Bulto As TextBox
    Friend WithEvents Lbl_Bici As Label
    Friend WithEvents Txt_Bici As TextBox
    Friend WithEvents Chk_Imprimir_Control As CheckBox
End Class
