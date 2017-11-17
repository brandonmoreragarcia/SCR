<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Impresion_Rep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Impresion_Rep))
        Me.Crv_Impresion_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Numero_Rep = New System.Windows.Forms.TextBox()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Exportar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir_Consumo = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NÚMERO REPARACIÓN:"
        '
        'Txt_Numero_Rep
        '
        Me.Txt_Numero_Rep.Font = New System.Drawing.Font("Square721 BT", 10.0!)
        Me.Txt_Numero_Rep.Location = New System.Drawing.Point(301, 40)
        Me.Txt_Numero_Rep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Numero_Rep.Name = "Txt_Numero_Rep"
        Me.Txt_Numero_Rep.Size = New System.Drawing.Size(152, 24)
        Me.Txt_Numero_Rep.TabIndex = 2
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Enabled = False
        Me.Btn_Cargar.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cargar.Location = New System.Drawing.Point(486, 40)
        Me.Btn_Cargar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(117, 32)
        Me.Btn_Cargar.TabIndex = 3
        Me.Btn_Cargar.Text = "CARGAR"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Enabled = False
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(624, 41)
        Me.Btn_Imprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(127, 29)
        Me.Btn_Imprimir.TabIndex = 4
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Enabled = False
        Me.Btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exportar.Location = New System.Drawing.Point(772, 41)
        Me.Btn_Exportar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(124, 29)
        Me.Btn_Exportar.TabIndex = 5
        Me.Btn_Exportar.Text = "EXPORTAR"
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir_Consumo
        '
        Me.Btn_Imprimir_Consumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir_Consumo.Location = New System.Drawing.Point(918, 41)
        Me.Btn_Imprimir_Consumo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Imprimir_Consumo.Name = "Btn_Imprimir_Consumo"
        Me.Btn_Imprimir_Consumo.Size = New System.Drawing.Size(201, 29)
        Me.Btn_Imprimir_Consumo.TabIndex = 6
        Me.Btn_Imprimir_Consumo.Text = "IMPRIMIR CONSUMO"
        Me.Btn_Imprimir_Consumo.UseVisualStyleBackColor = True
        '
        'Frm_Impresion_Rep
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.Btn_Imprimir_Consumo)
        Me.Controls.Add(Me.Btn_Exportar)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Controls.Add(Me.Txt_Numero_Rep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Crv_Impresion_Rep)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Impresion_Rep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Reparacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Crv_Impresion_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Numero_Rep As TextBox
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Btn_Exportar As Button
    Friend WithEvents Btn_Imprimir_Consumo As Button
End Class
