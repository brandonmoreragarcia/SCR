<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Impresion_Rep_Consumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Impresion_Rep_Consumo))
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.Location = New System.Drawing.Point(62, 30)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Codigo.Size = New System.Drawing.Size(126, 23)
        Me.Txt_Codigo.TabIndex = 0
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(206, 29)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(97, 24)
        Me.Btn_Imprimir.TabIndex = 1
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Frm_Impresion_Rep_Consumo
        '
        Me.AcceptButton = Me.Btn_Imprimir
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(376, 84)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Impresion_Rep_Consumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion Reparacion Consumo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Btn_Imprimir As Button
End Class
