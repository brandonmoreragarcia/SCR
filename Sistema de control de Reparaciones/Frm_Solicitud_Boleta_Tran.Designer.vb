<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Solicitud_Boleta_Tran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Solicitud_Boleta_Tran))
        Me.Txt_Boleta = New System.Windows.Forms.TextBox()
        Me.Rbt_Numero_Boleta = New System.Windows.Forms.RadioButton()
        Me.Rbt_Numero_Reparacion = New System.Windows.Forms.RadioButton()
        Me.Lbl_Solicitud_Boleta = New System.Windows.Forms.Label()
        Me.Txt_Reparacion = New System.Windows.Forms.TextBox()
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Boleta
        '
        Me.Txt_Boleta.Enabled = False
        Me.Txt_Boleta.Location = New System.Drawing.Point(232, 114)
        Me.Txt_Boleta.Name = "Txt_Boleta"
        Me.Txt_Boleta.Size = New System.Drawing.Size(132, 20)
        Me.Txt_Boleta.TabIndex = 13
        Me.Txt_Boleta.Visible = False
        '
        'Rbt_Numero_Boleta
        '
        Me.Rbt_Numero_Boleta.AutoSize = True
        Me.Rbt_Numero_Boleta.Location = New System.Drawing.Point(86, 116)
        Me.Rbt_Numero_Boleta.Name = "Rbt_Numero_Boleta"
        Me.Rbt_Numero_Boleta.Size = New System.Drawing.Size(98, 17)
        Me.Rbt_Numero_Boleta.TabIndex = 12
        Me.Rbt_Numero_Boleta.TabStop = True
        Me.Rbt_Numero_Boleta.Text = "Numero Boleta:"
        Me.Rbt_Numero_Boleta.UseVisualStyleBackColor = True
        Me.Rbt_Numero_Boleta.Visible = False
        '
        'Rbt_Numero_Reparacion
        '
        Me.Rbt_Numero_Reparacion.AutoSize = True
        Me.Rbt_Numero_Reparacion.Location = New System.Drawing.Point(86, 75)
        Me.Rbt_Numero_Reparacion.Name = "Rbt_Numero_Reparacion"
        Me.Rbt_Numero_Reparacion.Size = New System.Drawing.Size(123, 17)
        Me.Rbt_Numero_Reparacion.TabIndex = 11
        Me.Rbt_Numero_Reparacion.TabStop = True
        Me.Rbt_Numero_Reparacion.Text = "Numero Reparacion:"
        Me.Rbt_Numero_Reparacion.UseVisualStyleBackColor = True
        Me.Rbt_Numero_Reparacion.Visible = False
        '
        'Lbl_Solicitud_Boleta
        '
        Me.Lbl_Solicitud_Boleta.AutoSize = True
        Me.Lbl_Solicitud_Boleta.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Solicitud_Boleta.Location = New System.Drawing.Point(47, 19)
        Me.Lbl_Solicitud_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Solicitud_Boleta.Name = "Lbl_Solicitud_Boleta"
        Me.Lbl_Solicitud_Boleta.Size = New System.Drawing.Size(359, 27)
        Me.Lbl_Solicitud_Boleta.TabIndex = 10
        Me.Lbl_Solicitud_Boleta.Text = "Ingrese el numero de Reparacion"
        '
        'Txt_Reparacion
        '
        Me.Txt_Reparacion.Location = New System.Drawing.Point(140, 49)
        Me.Txt_Reparacion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Reparacion.Name = "Txt_Reparacion"
        Me.Txt_Reparacion.Size = New System.Drawing.Size(132, 20)
        Me.Txt_Reparacion.TabIndex = 0
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Location = New System.Drawing.Point(278, 90)
        Me.Btn_Cargar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(100, 27)
        Me.Btn_Cargar.TabIndex = 1
        Me.Btn_Cargar.Text = "Cargar"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Frm_Solicitud_Boleta_Tran
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 147)
        Me.Controls.Add(Me.Txt_Boleta)
        Me.Controls.Add(Me.Rbt_Numero_Boleta)
        Me.Controls.Add(Me.Rbt_Numero_Reparacion)
        Me.Controls.Add(Me.Lbl_Solicitud_Boleta)
        Me.Controls.Add(Me.Txt_Reparacion)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Solicitud_Boleta_Tran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud Boleta Transporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Boleta As TextBox
    Friend WithEvents Rbt_Numero_Boleta As RadioButton
    Friend WithEvents Rbt_Numero_Reparacion As RadioButton
    Friend WithEvents Lbl_Solicitud_Boleta As Label
    Friend WithEvents Txt_Reparacion As TextBox
    Friend WithEvents Btn_Cargar As Button
End Class
