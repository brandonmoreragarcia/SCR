<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Solicitud_Boleta_Rep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Solicitud_Boleta_Rep))
        Me.Btn_Cargar = New System.Windows.Forms.Button()
        Me.Txt_Reparacion = New System.Windows.Forms.TextBox()
        Me.Lbl_Solicitud_Boleta = New System.Windows.Forms.Label()
        Me.Rbt_Numero_Reparacion = New System.Windows.Forms.RadioButton()
        Me.Rbt_Numero_Boleta = New System.Windows.Forms.RadioButton()
        Me.Txt_Boleta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Cargar
        '
        Me.Btn_Cargar.Location = New System.Drawing.Point(285, 92)
        Me.Btn_Cargar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Cargar.Name = "Btn_Cargar"
        Me.Btn_Cargar.Size = New System.Drawing.Size(100, 27)
        Me.Btn_Cargar.TabIndex = 1
        Me.Btn_Cargar.Text = "Cargar"
        Me.Btn_Cargar.UseVisualStyleBackColor = True
        '
        'Txt_Reparacion
        '
        Me.Txt_Reparacion.Location = New System.Drawing.Point(144, 52)
        Me.Txt_Reparacion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_Reparacion.Name = "Txt_Reparacion"
        Me.Txt_Reparacion.Size = New System.Drawing.Size(132, 23)
        Me.Txt_Reparacion.TabIndex = 0
        '
        'Lbl_Solicitud_Boleta
        '
        Me.Lbl_Solicitud_Boleta.AutoSize = True
        Me.Lbl_Solicitud_Boleta.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Solicitud_Boleta.Location = New System.Drawing.Point(37, 9)
        Me.Lbl_Solicitud_Boleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Solicitud_Boleta.Name = "Lbl_Solicitud_Boleta"
        Me.Lbl_Solicitud_Boleta.Size = New System.Drawing.Size(359, 27)
        Me.Lbl_Solicitud_Boleta.TabIndex = 4
        Me.Lbl_Solicitud_Boleta.Text = "Ingrese el numero de Reparacion"
        '
        'Rbt_Numero_Reparacion
        '
        Me.Rbt_Numero_Reparacion.AutoSize = True
        Me.Rbt_Numero_Reparacion.Location = New System.Drawing.Point(42, 100)
        Me.Rbt_Numero_Reparacion.Name = "Rbt_Numero_Reparacion"
        Me.Rbt_Numero_Reparacion.Size = New System.Drawing.Size(146, 19)
        Me.Rbt_Numero_Reparacion.TabIndex = 5
        Me.Rbt_Numero_Reparacion.TabStop = True
        Me.Rbt_Numero_Reparacion.Text = "Numero Reparacion:"
        Me.Rbt_Numero_Reparacion.UseVisualStyleBackColor = True
        Me.Rbt_Numero_Reparacion.Visible = False
        '
        'Rbt_Numero_Boleta
        '
        Me.Rbt_Numero_Boleta.AutoSize = True
        Me.Rbt_Numero_Boleta.Location = New System.Drawing.Point(42, 141)
        Me.Rbt_Numero_Boleta.Name = "Rbt_Numero_Boleta"
        Me.Rbt_Numero_Boleta.Size = New System.Drawing.Size(118, 19)
        Me.Rbt_Numero_Boleta.TabIndex = 6
        Me.Rbt_Numero_Boleta.TabStop = True
        Me.Rbt_Numero_Boleta.Text = "Numero Boleta:"
        Me.Rbt_Numero_Boleta.UseVisualStyleBackColor = True
        Me.Rbt_Numero_Boleta.Visible = False
        '
        'Txt_Boleta
        '
        Me.Txt_Boleta.Enabled = False
        Me.Txt_Boleta.Location = New System.Drawing.Point(188, 139)
        Me.Txt_Boleta.Name = "Txt_Boleta"
        Me.Txt_Boleta.Size = New System.Drawing.Size(132, 23)
        Me.Txt_Boleta.TabIndex = 7
        Me.Txt_Boleta.Visible = False
        '
        'Frm_Solicitud_Boleta_Rep
        '
        Me.AcceptButton = Me.Btn_Cargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 221)
        Me.Controls.Add(Me.Txt_Boleta)
        Me.Controls.Add(Me.Rbt_Numero_Boleta)
        Me.Controls.Add(Me.Rbt_Numero_Reparacion)
        Me.Controls.Add(Me.Lbl_Solicitud_Boleta)
        Me.Controls.Add(Me.Txt_Reparacion)
        Me.Controls.Add(Me.Btn_Cargar)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Solicitud_Boleta_Rep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud Boleta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Cargar As Button
    Friend WithEvents Txt_Reparacion As TextBox
    Friend WithEvents Lbl_Solicitud_Boleta As Label
    Friend WithEvents Rbt_Numero_Reparacion As RadioButton
    Friend WithEvents Rbt_Numero_Boleta As RadioButton
    Friend WithEvents Txt_Boleta As TextBox
End Class
