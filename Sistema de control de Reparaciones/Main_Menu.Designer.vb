<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_Entrada_Datos = New System.Windows.Forms.Label()
        Me.Btn_Entrada_Datos = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
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
        'Lbl_Entrada_Datos
        '
        Me.Lbl_Entrada_Datos.AutoSize = True
        Me.Lbl_Entrada_Datos.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_Entrada_Datos.Name = "Lbl_Entrada_Datos"
        Me.Lbl_Entrada_Datos.Size = New System.Drawing.Size(117, 13)
        Me.Lbl_Entrada_Datos.TabIndex = 9
        Me.Lbl_Entrada_Datos.Text = "ENTRADA DE DATOS"
        '
        'Btn_Entrada_Datos
        '
        Me.Btn_Entrada_Datos.Image = CType(resources.GetObject("Btn_Entrada_Datos.Image"), System.Drawing.Image)
        Me.Btn_Entrada_Datos.Location = New System.Drawing.Point(26, 44)
        Me.Btn_Entrada_Datos.Name = "Btn_Entrada_Datos"
        Me.Btn_Entrada_Datos.Size = New System.Drawing.Size(93, 107)
        Me.Btn_Entrada_Datos.TabIndex = 10
        Me.Btn_Entrada_Datos.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1093, 559)
        Me.Controls.Add(Me.Btn_Entrada_Datos)
        Me.Controls.Add(Me.Lbl_Entrada_Datos)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main_Menu"
        Me.Text = "Sistema de control de Reparaciones"
        Me.TransparencyKey = System.Drawing.Color.PaleGreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Lbl_Entrada_Datos As Label
    Friend WithEvents Btn_Entrada_Datos As Button
End Class
