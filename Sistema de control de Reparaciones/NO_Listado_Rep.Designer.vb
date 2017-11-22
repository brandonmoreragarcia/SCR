<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NO_Listado_Rep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NO_Listado_Rep))
        Me.Lbl_Fecha_Inicial = New System.Windows.Forms.Label()
        Me.Lbl_Fecha_Final = New System.Windows.Forms.Label()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Crv_Listado_Rep = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Txt_Fecha_Inicial = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_Fecha_Final = New System.Windows.Forms.MaskedTextBox()
        Me.Dtp_Fecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fecha_Final = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Lbl_Fecha_Inicial
        '
        Me.Lbl_Fecha_Inicial.AutoSize = True
        Me.Lbl_Fecha_Inicial.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Fecha_Inicial.Name = "Lbl_Fecha_Inicial"
        Me.Lbl_Fecha_Inicial.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_Fecha_Inicial.TabIndex = 0
        Me.Lbl_Fecha_Inicial.Text = "Fecha Inicial"
        '
        'Lbl_Fecha_Final
        '
        Me.Lbl_Fecha_Final.AutoSize = True
        Me.Lbl_Fecha_Final.Location = New System.Drawing.Point(12, 36)
        Me.Lbl_Fecha_Final.Name = "Lbl_Fecha_Final"
        Me.Lbl_Fecha_Final.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Fecha_Final.TabIndex = 2
        Me.Lbl_Fecha_Final.Text = "Fecha Final"
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Enabled = False
        Me.Btn_Cargar.Location = New System.Drawing.Point(191, 18)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cargar.TabIndex = 4
        Me.Btn_Cargar.Text = "Cargar"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Crv_Listado_Rep
        '
        Me.Crv_Listado_Rep.ActiveViewIndex = -1
        Me.Crv_Listado_Rep.AutoScroll = True
        Me.Crv_Listado_Rep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv_Listado_Rep.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv_Listado_Rep.DisplayStatusBar = False
        Me.Crv_Listado_Rep.Location = New System.Drawing.Point(12, 76)
        Me.Crv_Listado_Rep.Name = "Crv_Listado_Rep"
        Me.Crv_Listado_Rep.ShowCloseButton = False
        Me.Crv_Listado_Rep.ShowCopyButton = False
        Me.Crv_Listado_Rep.ShowGroupTreeButton = False
        Me.Crv_Listado_Rep.ShowParameterPanelButton = False
        Me.Crv_Listado_Rep.ShowRefreshButton = False
        Me.Crv_Listado_Rep.Size = New System.Drawing.Size(702, 328)
        Me.Crv_Listado_Rep.TabIndex = 5
        Me.Crv_Listado_Rep.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Txt_Fecha_Inicial
        '
        Me.Txt_Fecha_Inicial.Location = New System.Drawing.Point(436, 7)
        Me.Txt_Fecha_Inicial.Mask = "0000-00-00"
        Me.Txt_Fecha_Inicial.Name = "Txt_Fecha_Inicial"
        Me.Txt_Fecha_Inicial.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Fecha_Inicial.TabIndex = 6
        Me.Txt_Fecha_Inicial.Visible = False
        '
        'Txt_Fecha_Final
        '
        Me.Txt_Fecha_Final.Enabled = False
        Me.Txt_Fecha_Final.Location = New System.Drawing.Point(436, 33)
        Me.Txt_Fecha_Final.Mask = "0000-00-00"
        Me.Txt_Fecha_Final.Name = "Txt_Fecha_Final"
        Me.Txt_Fecha_Final.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Fecha_Final.TabIndex = 7
        Me.Txt_Fecha_Final.Visible = False
        '
        'Dtp_Fecha_Inicio
        '
        Me.Dtp_Fecha_Inicio.Location = New System.Drawing.Point(85, 7)
        Me.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio"
        Me.Dtp_Fecha_Inicio.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Fecha_Inicio.TabIndex = 8
        '
        'Dtp_Fecha_Final
        '
        Me.Dtp_Fecha_Final.Enabled = False
        Me.Dtp_Fecha_Final.Location = New System.Drawing.Point(85, 36)
        Me.Dtp_Fecha_Final.Name = "Dtp_Fecha_Final"
        Me.Dtp_Fecha_Final.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Fecha_Final.TabIndex = 9
        '
        'Frm_Listado_Rep
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 643)
        Me.Controls.Add(Me.Dtp_Fecha_Final)
        Me.Controls.Add(Me.Dtp_Fecha_Inicio)
        Me.Controls.Add(Me.Txt_Fecha_Final)
        Me.Controls.Add(Me.Txt_Fecha_Inicial)
        Me.Controls.Add(Me.Crv_Listado_Rep)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Controls.Add(Me.Lbl_Fecha_Final)
        Me.Controls.Add(Me.Lbl_Fecha_Inicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Listado_Rep"
        Me.Text = "Lista de Reparaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Fecha_Inicial As Label
    Friend WithEvents Lbl_Fecha_Final As Label
    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Crv_Listado_Rep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Txt_Fecha_Inicial As MaskedTextBox
    Friend WithEvents Txt_Fecha_Final As MaskedTextBox
    Friend WithEvents Dtp_Fecha_Inicio As DateTimePicker
    Friend WithEvents Dtp_Fecha_Final As DateTimePicker
End Class
