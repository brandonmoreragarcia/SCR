<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Impresion_Entrada
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
        Me.Crv_Colilla = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.bt_generar_tiquete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Crv_Colilla
        '
        Me.Crv_Colilla.ActiveViewIndex = -1
        Me.Crv_Colilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Crv_Colilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Colilla.DisplayStatusBar = False
        Me.Crv_Colilla.Location = New System.Drawing.Point(38, 26)
        Me.Crv_Colilla.Name = "Crv_Colilla"
        Me.Crv_Colilla.ShowCloseButton = False
        Me.Crv_Colilla.ShowCopyButton = False
        Me.Crv_Colilla.ShowExportButton = False
        Me.Crv_Colilla.ShowGotoPageButton = False
        Me.Crv_Colilla.ShowGroupTreeButton = False
        Me.Crv_Colilla.ShowLogo = False
        Me.Crv_Colilla.ShowPageNavigateButtons = False
        Me.Crv_Colilla.ShowParameterPanelButton = False
        Me.Crv_Colilla.ShowRefreshButton = False
        Me.Crv_Colilla.ShowTextSearchButton = False
        Me.Crv_Colilla.ShowZoomButton = False
        Me.Crv_Colilla.Size = New System.Drawing.Size(785, 352)
        Me.Crv_Colilla.TabIndex = 53
        Me.Crv_Colilla.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'bt_generar_tiquete
        '
        Me.bt_generar_tiquete.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_generar_tiquete.Location = New System.Drawing.Point(392, 406)
        Me.bt_generar_tiquete.Name = "bt_generar_tiquete"
        Me.bt_generar_tiquete.Size = New System.Drawing.Size(138, 32)
        Me.bt_generar_tiquete.TabIndex = 54
        Me.bt_generar_tiquete.Text = "GENERAR!"
        Me.bt_generar_tiquete.UseVisualStyleBackColor = True
        '
        'Frm_Impresion_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 480)
        Me.Controls.Add(Me.bt_generar_tiquete)
        Me.Controls.Add(Me.Crv_Colilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Impresion_Entrada"
        Me.Text = "Frm_Impresion_Entrada"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Crv_Colilla As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents bt_generar_tiquete As Button
End Class
