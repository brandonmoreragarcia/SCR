<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main_Menu))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tsp_Menu = New System.Windows.Forms.ToolStrip()
        Me.Btn_Entrada_Datos = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Reparaciones = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Transporte = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Busqueda = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Ingreso_Queja = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Actua_Queja = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Reportes = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Mantenimiento = New System.Windows.Forms.ToolStripButton()
        Me.Lbl_Usuario_T = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Btn_Cambia_Usuario = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.Tsp_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1093, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Tsp_Menu
        '
        Me.Tsp_Menu.AutoSize = False
        Me.Tsp_Menu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Tsp_Menu.Enabled = False
        Me.Tsp_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Entrada_Datos, Me.Btn_Reparaciones, Me.Btn_Transporte, Me.Btn_Busqueda, Me.Btn_Ingreso_Queja, Me.Btn_Actua_Queja, Me.Btn_Reportes, Me.Btn_Mantenimiento})
        Me.Tsp_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Tsp_Menu.Name = "Tsp_Menu"
        Me.Tsp_Menu.Size = New System.Drawing.Size(1093, 117)
        Me.Tsp_Menu.TabIndex = 14
        Me.Tsp_Menu.Text = "Menu Principal"
        '
        'Btn_Entrada_Datos
        '
        Me.Btn_Entrada_Datos.AutoSize = False
        Me.Btn_Entrada_Datos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Entrada_Datos.Image = CType(resources.GetObject("Btn_Entrada_Datos.Image"), System.Drawing.Image)
        Me.Btn_Entrada_Datos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Entrada_Datos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Entrada_Datos.Name = "Btn_Entrada_Datos"
        Me.Btn_Entrada_Datos.Size = New System.Drawing.Size(93, 120)
        Me.Btn_Entrada_Datos.Text = "&Entrada de Datos"
        Me.Btn_Entrada_Datos.ToolTipText = "Entrada de Datos"
        '
        'Btn_Reparaciones
        '
        Me.Btn_Reparaciones.AutoSize = False
        Me.Btn_Reparaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Reparaciones.Image = CType(resources.GetObject("Btn_Reparaciones.Image"), System.Drawing.Image)
        Me.Btn_Reparaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Reparaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Reparaciones.Name = "Btn_Reparaciones"
        Me.Btn_Reparaciones.Size = New System.Drawing.Size(93, 120)
        Me.Btn_Reparaciones.Text = "&Reparaciones"
        Me.Btn_Reparaciones.ToolTipText = "Actualizacion de Reparacion"
        '
        'Btn_Transporte
        '
        Me.Btn_Transporte.AutoSize = False
        Me.Btn_Transporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Transporte.Image = CType(resources.GetObject("Btn_Transporte.Image"), System.Drawing.Image)
        Me.Btn_Transporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Transporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Transporte.Name = "Btn_Transporte"
        Me.Btn_Transporte.Size = New System.Drawing.Size(93, 120)
        Me.Btn_Transporte.Text = "&Transporte"
        '
        'Btn_Busqueda
        '
        Me.Btn_Busqueda.AutoSize = False
        Me.Btn_Busqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Busqueda.Image = CType(resources.GetObject("Btn_Busqueda.Image"), System.Drawing.Image)
        Me.Btn_Busqueda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Busqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Busqueda.Name = "Btn_Busqueda"
        Me.Btn_Busqueda.Size = New System.Drawing.Size(93, 120)
        Me.Btn_Busqueda.Text = "ToolStripButton1"
        Me.Btn_Busqueda.ToolTipText = "Busqueda"
        '
        'Btn_Ingreso_Queja
        '
        Me.Btn_Ingreso_Queja.AutoSize = False
        Me.Btn_Ingreso_Queja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Ingreso_Queja.Image = CType(resources.GetObject("Btn_Ingreso_Queja.Image"), System.Drawing.Image)
        Me.Btn_Ingreso_Queja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Ingreso_Queja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Ingreso_Queja.Name = "Btn_Ingreso_Queja"
        Me.Btn_Ingreso_Queja.Size = New System.Drawing.Size(96, 120)
        Me.Btn_Ingreso_Queja.Text = "Ingreso Queja"
        '
        'Btn_Actua_Queja
        '
        Me.Btn_Actua_Queja.AutoSize = False
        Me.Btn_Actua_Queja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Actua_Queja.Image = CType(resources.GetObject("Btn_Actua_Queja.Image"), System.Drawing.Image)
        Me.Btn_Actua_Queja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Actua_Queja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Actua_Queja.Name = "Btn_Actua_Queja"
        Me.Btn_Actua_Queja.Size = New System.Drawing.Size(96, 120)
        Me.Btn_Actua_Queja.Text = "Actualizacion Queja"
        '
        'Btn_Reportes
        '
        Me.Btn_Reportes.AutoSize = False
        Me.Btn_Reportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Reportes.Image = CType(resources.GetObject("Btn_Reportes.Image"), System.Drawing.Image)
        Me.Btn_Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Reportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Reportes.Name = "Btn_Reportes"
        Me.Btn_Reportes.Size = New System.Drawing.Size(93, 120)
        Me.Btn_Reportes.Text = "ToolStripButton1"
        Me.Btn_Reportes.ToolTipText = "Reportes"
        '
        'Btn_Mantenimiento
        '
        Me.Btn_Mantenimiento.AutoSize = False
        Me.Btn_Mantenimiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Mantenimiento.Image = CType(resources.GetObject("Btn_Mantenimiento.Image"), System.Drawing.Image)
        Me.Btn_Mantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Mantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Mantenimiento.Name = "Btn_Mantenimiento"
        Me.Btn_Mantenimiento.Size = New System.Drawing.Size(90, 90)
        Me.Btn_Mantenimiento.Text = "Mantenimientos"
        '
        'Lbl_Usuario_T
        '
        Me.Lbl_Usuario_T.AutoSize = True
        Me.Lbl_Usuario_T.Location = New System.Drawing.Point(888, 13)
        Me.Lbl_Usuario_T.Name = "Lbl_Usuario_T"
        Me.Lbl_Usuario_T.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Usuario_T.TabIndex = 16
        Me.Lbl_Usuario_T.Text = "Usuario:"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(941, 13)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Usuario.TabIndex = 17
        '
        'Btn_Cambia_Usuario
        '
        Me.Btn_Cambia_Usuario.Location = New System.Drawing.Point(891, 29)
        Me.Btn_Cambia_Usuario.Name = "Btn_Cambia_Usuario"
        Me.Btn_Cambia_Usuario.Size = New System.Drawing.Size(111, 23)
        Me.Btn_Cambia_Usuario.TabIndex = 19
        Me.Btn_Cambia_Usuario.Text = "Cambiar Usuario"
        Me.Btn_Cambia_Usuario.UseVisualStyleBackColor = True
        '
        'Frm_Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1093, 559)
        Me.Controls.Add(Me.Btn_Cambia_Usuario)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Lbl_Usuario_T)
        Me.Controls.Add(Me.Tsp_Menu)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Frm_Main_Menu"
        Me.Text = "Sistema de control de Reparaciones"
        Me.TransparencyKey = System.Drawing.Color.PaleGreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Tsp_Menu.ResumeLayout(False)
        Me.Tsp_Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Tsp_Menu As ToolStrip
    Friend WithEvents Btn_Entrada_Datos As ToolStripButton
    Friend WithEvents Btn_Reparaciones As ToolStripButton
    Friend WithEvents Btn_Transporte As ToolStripButton
    Friend WithEvents Btn_Reportes As ToolStripButton
    Friend WithEvents Btn_Busqueda As ToolStripButton
    Friend WithEvents Lbl_Usuario_T As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Btn_Ingreso_Queja As ToolStripButton
    Friend WithEvents Btn_Actua_Queja As ToolStripButton
    Friend WithEvents Btn_Mantenimiento As ToolStripButton
    Friend WithEvents Btn_Cambia_Usuario As Button
End Class
