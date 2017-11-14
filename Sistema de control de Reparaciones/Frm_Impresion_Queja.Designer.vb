<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Impresion_Queja
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
        Me.Crv_Colilla = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crv_Colilla
        '
        Me.Crv_Colilla.ActiveViewIndex = -1
        Me.Crv_Colilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Crv_Colilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Colilla.DisplayStatusBar = False
        Me.Crv_Colilla.Location = New System.Drawing.Point(166, 40)
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
        Me.Crv_Colilla.Size = New System.Drawing.Size(969, 484)
        Me.Crv_Colilla.TabIndex = 55
        Me.Crv_Colilla.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_Impresion_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.Crv_Colilla)
        Me.Name = "Frm_Impresion_Queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Impresion_Queja"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Crv_Colilla As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
