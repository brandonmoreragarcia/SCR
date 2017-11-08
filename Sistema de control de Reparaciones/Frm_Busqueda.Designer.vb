<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Busqueda))
        Me.Lbl_Num_Boleta = New System.Windows.Forms.Label()
        Me.Txt_Num_Boleta = New System.Windows.Forms.TextBox()
        Me.Btn_Cotejar = New System.Windows.Forms.Button()
        Me.Dgv_Reps_boletas = New System.Windows.Forms.DataGridView()
        Me.Lbl_Serie_Numero = New System.Windows.Forms.Label()
        Me.Btn_Coteja_Serie = New System.Windows.Forms.Button()
        Me.Txt_Serie = New System.Windows.Forms.TextBox()
        CType(Me.Dgv_Reps_boletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Num_Boleta
        '
        Me.Lbl_Num_Boleta.AutoSize = True
        Me.Lbl_Num_Boleta.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Num_Boleta.Location = New System.Drawing.Point(63, 9)
        Me.Lbl_Num_Boleta.Name = "Lbl_Num_Boleta"
        Me.Lbl_Num_Boleta.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_Num_Boleta.TabIndex = 0
        Me.Lbl_Num_Boleta.Text = "Boleta #"
        '
        'Txt_Num_Boleta
        '
        Me.Txt_Num_Boleta.Location = New System.Drawing.Point(12, 32)
        Me.Txt_Num_Boleta.Name = "Txt_Num_Boleta"
        Me.Txt_Num_Boleta.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Num_Boleta.TabIndex = 1
        '
        'Btn_Cotejar
        '
        Me.Btn_Cotejar.Location = New System.Drawing.Point(118, 30)
        Me.Btn_Cotejar.Name = "Btn_Cotejar"
        Me.Btn_Cotejar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cotejar.TabIndex = 2
        Me.Btn_Cotejar.Text = "Cotejar"
        Me.Btn_Cotejar.UseVisualStyleBackColor = True
        '
        'Dgv_Reps_boletas
        '
        Me.Dgv_Reps_boletas.AllowUserToAddRows = False
        Me.Dgv_Reps_boletas.AllowUserToDeleteRows = False
        Me.Dgv_Reps_boletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Reps_boletas.Location = New System.Drawing.Point(118, 59)
        Me.Dgv_Reps_boletas.Name = "Dgv_Reps_boletas"
        Me.Dgv_Reps_boletas.ReadOnly = True
        Me.Dgv_Reps_boletas.Size = New System.Drawing.Size(181, 82)
        Me.Dgv_Reps_boletas.TabIndex = 3
        '
        'Lbl_Serie_Numero
        '
        Me.Lbl_Serie_Numero.AutoSize = True
        Me.Lbl_Serie_Numero.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Serie_Numero.Location = New System.Drawing.Point(302, 9)
        Me.Lbl_Serie_Numero.Name = "Lbl_Serie_Numero"
        Me.Lbl_Serie_Numero.Size = New System.Drawing.Size(69, 20)
        Me.Lbl_Serie_Numero.TabIndex = 4
        Me.Lbl_Serie_Numero.Text = "Serie #"
        '
        'Btn_Coteja_Serie
        '
        Me.Btn_Coteja_Serie.Location = New System.Drawing.Point(353, 30)
        Me.Btn_Coteja_Serie.Name = "Btn_Coteja_Serie"
        Me.Btn_Coteja_Serie.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Coteja_Serie.TabIndex = 6
        Me.Btn_Coteja_Serie.Text = "Cotejar"
        Me.Btn_Coteja_Serie.UseVisualStyleBackColor = True
        '
        'Txt_Serie
        '
        Me.Txt_Serie.Location = New System.Drawing.Point(247, 32)
        Me.Txt_Serie.Name = "Txt_Serie"
        Me.Txt_Serie.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Serie.TabIndex = 5
        '
        'Frm_Busqueda
        '
        Me.AcceptButton = Me.Btn_Cotejar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 173)
        Me.Controls.Add(Me.Btn_Coteja_Serie)
        Me.Controls.Add(Me.Txt_Serie)
        Me.Controls.Add(Me.Lbl_Serie_Numero)
        Me.Controls.Add(Me.Dgv_Reps_boletas)
        Me.Controls.Add(Me.Btn_Cotejar)
        Me.Controls.Add(Me.Txt_Num_Boleta)
        Me.Controls.Add(Me.Lbl_Num_Boleta)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Busqueda"
        Me.Text = "Busqueda de Reparacion por Boleta"
        CType(Me.Dgv_Reps_boletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Num_Boleta As Label
    Friend WithEvents Txt_Num_Boleta As TextBox
    Friend WithEvents Btn_Cotejar As Button
    Friend WithEvents Dgv_Reps_boletas As DataGridView
    Friend WithEvents Lbl_Serie_Numero As Label
    Friend WithEvents Btn_Coteja_Serie As Button
    Friend WithEvents Txt_Serie As TextBox
End Class
