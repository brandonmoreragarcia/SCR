<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Listado_Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listado_Reportes))
        Me.Lbl_Consulta_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_Reparacion = New System.Windows.Forms.Label()
        Me.Txt_Dato = New System.Windows.Forms.TextBox()
        Me.Lb_impresion_Rep = New System.Windows.Forms.Label()
        Me.Lbl_Listado_Rep = New System.Windows.Forms.Label()
        Me.Lbl_Dato = New System.Windows.Forms.Label()
        Me.Lbl_Listado_Rep_Estado = New System.Windows.Forms.Label()
        Me.Lbl_Etiqueta_Salida = New System.Windows.Forms.Label()
        Me.Lbl_Listado_Quejas = New System.Windows.Forms.Label()
        Me.Lbl_Consulta_Num_Queja = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Consulta_Cliente
        '
        Me.Lbl_Consulta_Cliente.AutoSize = True
        Me.Lbl_Consulta_Cliente.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Consulta_Cliente.Location = New System.Drawing.Point(358, 29)
        Me.Lbl_Consulta_Cliente.Name = "Lbl_Consulta_Cliente"
        Me.Lbl_Consulta_Cliente.Size = New System.Drawing.Size(203, 24)
        Me.Lbl_Consulta_Cliente.TabIndex = 0
        Me.Lbl_Consulta_Cliente.Text = "Consulta por Cliente"
        '
        'Lbl_Reparacion
        '
        Me.Lbl_Reparacion.AutoSize = True
        Me.Lbl_Reparacion.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Reparacion.Location = New System.Drawing.Point(358, 5)
        Me.Lbl_Reparacion.Name = "Lbl_Reparacion"
        Me.Lbl_Reparacion.Size = New System.Drawing.Size(245, 24)
        Me.Lbl_Reparacion.TabIndex = 2
        Me.Lbl_Reparacion.Text = "Consulta por Reparacion"
        '
        'Txt_Dato
        '
        Me.Txt_Dato.Location = New System.Drawing.Point(252, 19)
        Me.Txt_Dato.Name = "Txt_Dato"
        Me.Txt_Dato.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Dato.TabIndex = 3
        '
        'Lb_impresion_Rep
        '
        Me.Lb_impresion_Rep.AutoSize = True
        Me.Lb_impresion_Rep.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_impresion_Rep.Location = New System.Drawing.Point(73, 135)
        Me.Lb_impresion_Rep.Name = "Lb_impresion_Rep"
        Me.Lb_impresion_Rep.Size = New System.Drawing.Size(218, 24)
        Me.Lb_impresion_Rep.TabIndex = 4
        Me.Lb_impresion_Rep.Text = "Impresion Reparacion"
        '
        'Lbl_Listado_Rep
        '
        Me.Lbl_Listado_Rep.AutoSize = True
        Me.Lbl_Listado_Rep.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Listado_Rep.Location = New System.Drawing.Point(418, 74)
        Me.Lbl_Listado_Rep.Name = "Lbl_Listado_Rep"
        Me.Lbl_Listado_Rep.Size = New System.Drawing.Size(315, 24)
        Me.Lbl_Listado_Rep.TabIndex = 5
        Me.Lbl_Listado_Rep.Text = "Listado Reparaciones con LEAD"
        '
        'Lbl_Dato
        '
        Me.Lbl_Dato.AutoSize = True
        Me.Lbl_Dato.Font = New System.Drawing.Font("Swis721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dato.Location = New System.Drawing.Point(171, 19)
        Me.Lbl_Dato.Name = "Lbl_Dato"
        Me.Lbl_Dato.Size = New System.Drawing.Size(63, 22)
        Me.Lbl_Dato.TabIndex = 6
        Me.Lbl_Dato.Text = "DATO"
        '
        'Lbl_Listado_Rep_Estado
        '
        Me.Lbl_Listado_Rep_Estado.AutoSize = True
        Me.Lbl_Listado_Rep_Estado.Font = New System.Drawing.Font("Swis721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Listado_Rep_Estado.Location = New System.Drawing.Point(73, 76)
        Me.Lbl_Listado_Rep_Estado.Name = "Lbl_Listado_Rep_Estado"
        Me.Lbl_Listado_Rep_Estado.Size = New System.Drawing.Size(339, 22)
        Me.Lbl_Listado_Rep_Estado.TabIndex = 7
        Me.Lbl_Listado_Rep_Estado.Text = "Listado de Reparaciones por Estado"
        '
        'Lbl_Etiqueta_Salida
        '
        Me.Lbl_Etiqueta_Salida.AutoSize = True
        Me.Lbl_Etiqueta_Salida.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Etiqueta_Salida.Location = New System.Drawing.Point(418, 135)
        Me.Lbl_Etiqueta_Salida.Name = "Lbl_Etiqueta_Salida"
        Me.Lbl_Etiqueta_Salida.Size = New System.Drawing.Size(149, 24)
        Me.Lbl_Etiqueta_Salida.TabIndex = 8
        Me.Lbl_Etiqueta_Salida.Text = "Etiqueta Salida"
        '
        'Lbl_Listado_Quejas
        '
        Me.Lbl_Listado_Quejas.AutoSize = True
        Me.Lbl_Listado_Quejas.Font = New System.Drawing.Font("Swis721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Listado_Quejas.Location = New System.Drawing.Point(73, 106)
        Me.Lbl_Listado_Quejas.Name = "Lbl_Listado_Quejas"
        Me.Lbl_Listado_Quejas.Size = New System.Drawing.Size(145, 22)
        Me.Lbl_Listado_Quejas.TabIndex = 9
        Me.Lbl_Listado_Quejas.Text = "Listado Quejas"
        '
        'Lbl_Consulta_Num_Queja
        '
        Me.Lbl_Consulta_Num_Queja.AutoSize = True
        Me.Lbl_Consulta_Num_Queja.Font = New System.Drawing.Font("Swis721 BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Consulta_Num_Queja.Location = New System.Drawing.Point(418, 104)
        Me.Lbl_Consulta_Num_Queja.Name = "Lbl_Consulta_Num_Queja"
        Me.Lbl_Consulta_Num_Queja.Size = New System.Drawing.Size(214, 24)
        Me.Lbl_Consulta_Num_Queja.TabIndex = 10
        Me.Lbl_Consulta_Num_Queja.Text = "Consulta por # Queja"
        '
        'Frm_Listado_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 172)
        Me.Controls.Add(Me.Lbl_Consulta_Num_Queja)
        Me.Controls.Add(Me.Lbl_Listado_Quejas)
        Me.Controls.Add(Me.Lbl_Etiqueta_Salida)
        Me.Controls.Add(Me.Lbl_Listado_Rep_Estado)
        Me.Controls.Add(Me.Lbl_Dato)
        Me.Controls.Add(Me.Lbl_Listado_Rep)
        Me.Controls.Add(Me.Lb_impresion_Rep)
        Me.Controls.Add(Me.Txt_Dato)
        Me.Controls.Add(Me.Lbl_Reparacion)
        Me.Controls.Add(Me.Lbl_Consulta_Cliente)
        Me.Font = New System.Drawing.Font("Swis721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Listado_Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Consulta_Cliente As Label
    Friend WithEvents Lbl_Reparacion As Label
    Friend WithEvents Txt_Dato As TextBox
    Friend WithEvents Lb_impresion_Rep As Label
    Friend WithEvents Lbl_Listado_Rep As Label
    Friend WithEvents Lbl_Dato As Label
    Friend WithEvents Lbl_Listado_Rep_Estado As Label
    Friend WithEvents Lbl_Etiqueta_Salida As Label
    Friend WithEvents Lbl_Listado_Quejas As Label
    Friend WithEvents Lbl_Consulta_Num_Queja As Label
End Class
