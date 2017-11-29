<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ingreso_Boletas
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.check_box_opcional = New System.Windows.Forms.CheckBox()
        Me.Txt_Cod_Articulo = New System.Windows.Forms.TextBox()
        Me.Lbl_Codigo_Art = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion_Art = New System.Windows.Forms.Label()
        Me.lb_descripcion_articulo = New System.Windows.Forms.Label()
        Me.dg_articulo = New System.Windows.Forms.DataGridView()
        Me.bt_buscar_articulo = New System.Windows.Forms.Button()
        Me.Tbx_Adicional_Art = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_cliente = New System.Windows.Forms.DataGridView()
        Me.Txt_Cod_Cliente = New System.Windows.Forms.TextBox()
        Me.Lbl_Cliente_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Codigo_Cliente = New System.Windows.Forms.Label()
        Me.lb_nombre_cliente = New System.Windows.Forms.Label()
        Me.rb_nombre = New System.Windows.Forms.RadioButton()
        Me.Lbl_Alias = New System.Windows.Forms.Label()
        Me.lb_alias_cliente = New System.Windows.Forms.Label()
        Me.rb_alias = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.check_box_opcional)
        Me.GroupBox3.Controls.Add(Me.Txt_Cod_Articulo)
        Me.GroupBox3.Controls.Add(Me.Lbl_Codigo_Art)
        Me.GroupBox3.Controls.Add(Me.Lbl_Descripcion_Art)
        Me.GroupBox3.Controls.Add(Me.lb_descripcion_articulo)
        Me.GroupBox3.Controls.Add(Me.dg_articulo)
        Me.GroupBox3.Controls.Add(Me.bt_buscar_articulo)
        Me.GroupBox3.Controls.Add(Me.Tbx_Adicional_Art)
        Me.GroupBox3.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(697, 270)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN DEL ARTÍCULO"
        '
        'check_box_opcional
        '
        Me.check_box_opcional.AutoSize = True
        Me.check_box_opcional.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_box_opcional.Location = New System.Drawing.Point(472, 108)
        Me.check_box_opcional.Name = "check_box_opcional"
        Me.check_box_opcional.Size = New System.Drawing.Size(88, 20)
        Me.check_box_opcional.TabIndex = 17
        Me.check_box_opcional.Text = "Opcional:"
        Me.check_box_opcional.UseVisualStyleBackColor = True
        '
        'Txt_Cod_Articulo
        '
        Me.Txt_Cod_Articulo.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Articulo.Location = New System.Drawing.Point(111, 42)
        Me.Txt_Cod_Articulo.Name = "Txt_Cod_Articulo"
        Me.Txt_Cod_Articulo.Size = New System.Drawing.Size(185, 23)
        Me.Txt_Cod_Articulo.TabIndex = 2
        Me.Txt_Cod_Articulo.Text = "**"
        '
        'Lbl_Codigo_Art
        '
        Me.Lbl_Codigo_Art.AutoSize = True
        Me.Lbl_Codigo_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Art.Location = New System.Drawing.Point(49, 45)
        Me.Lbl_Codigo_Art.Name = "Lbl_Codigo_Art"
        Me.Lbl_Codigo_Art.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_Codigo_Art.TabIndex = 14
        Me.Lbl_Codigo_Art.Text = "Filtrar:"
        '
        'Lbl_Descripcion_Art
        '
        Me.Lbl_Descripcion_Art.AutoSize = True
        Me.Lbl_Descripcion_Art.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descripcion_Art.Location = New System.Drawing.Point(469, 18)
        Me.Lbl_Descripcion_Art.Name = "Lbl_Descripcion_Art"
        Me.Lbl_Descripcion_Art.Size = New System.Drawing.Size(89, 16)
        Me.Lbl_Descripcion_Art.TabIndex = 15
        Me.Lbl_Descripcion_Art.Text = "Descripcion:"
        '
        'lb_descripcion_articulo
        '
        Me.lb_descripcion_articulo.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_descripcion_articulo.ForeColor = System.Drawing.Color.Red
        Me.lb_descripcion_articulo.Location = New System.Drawing.Point(472, 45)
        Me.lb_descripcion_articulo.Name = "lb_descripcion_articulo"
        Me.lb_descripcion_articulo.Size = New System.Drawing.Size(208, 56)
        Me.lb_descripcion_articulo.TabIndex = 16
        '
        'dg_articulo
        '
        Me.dg_articulo.AllowUserToAddRows = False
        Me.dg_articulo.AllowUserToDeleteRows = False
        Me.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulo.Location = New System.Drawing.Point(11, 81)
        Me.dg_articulo.Name = "dg_articulo"
        Me.dg_articulo.ReadOnly = True
        Me.dg_articulo.Size = New System.Drawing.Size(419, 164)
        Me.dg_articulo.TabIndex = 4
        '
        'bt_buscar_articulo
        '
        Me.bt_buscar_articulo.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar_articulo.Location = New System.Drawing.Point(313, 42)
        Me.bt_buscar_articulo.Name = "bt_buscar_articulo"
        Me.bt_buscar_articulo.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar_articulo.TabIndex = 3
        Me.bt_buscar_articulo.Text = "Buscar"
        Me.bt_buscar_articulo.UseVisualStyleBackColor = True
        '
        'Tbx_Adicional_Art
        '
        Me.Tbx_Adicional_Art.Location = New System.Drawing.Point(472, 134)
        Me.Tbx_Adicional_Art.Multiline = True
        Me.Tbx_Adicional_Art.Name = "Tbx_Adicional_Art"
        Me.Tbx_Adicional_Art.Size = New System.Drawing.Size(174, 64)
        Me.Tbx_Adicional_Art.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_cliente)
        Me.GroupBox2.Controls.Add(Me.Txt_Cod_Cliente)
        Me.GroupBox2.Controls.Add(Me.Lbl_Cliente_Nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Codigo_Cliente)
        Me.GroupBox2.Controls.Add(Me.lb_nombre_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_nombre)
        Me.GroupBox2.Controls.Add(Me.Lbl_Alias)
        Me.GroupBox2.Controls.Add(Me.lb_alias_cliente)
        Me.GroupBox2.Controls.Add(Me.rb_alias)
        Me.GroupBox2.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(697, 227)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACIÓN DEL CLIENTE"
        '
        'dg_cliente
        '
        Me.dg_cliente.AllowUserToAddRows = False
        Me.dg_cliente.AllowUserToDeleteRows = False
        Me.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cliente.Location = New System.Drawing.Point(14, 87)
        Me.dg_cliente.Name = "dg_cliente"
        Me.dg_cliente.ReadOnly = True
        Me.dg_cliente.Size = New System.Drawing.Size(419, 123)
        Me.dg_cliente.TabIndex = 1
        '
        'Txt_Cod_Cliente
        '
        Me.Txt_Cod_Cliente.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Cliente.Location = New System.Drawing.Point(245, 50)
        Me.Txt_Cod_Cliente.Name = "Txt_Cod_Cliente"
        Me.Txt_Cod_Cliente.Size = New System.Drawing.Size(188, 23)
        Me.Txt_Cod_Cliente.TabIndex = 0
        '
        'Lbl_Cliente_Nombre
        '
        Me.Lbl_Cliente_Nombre.AutoSize = True
        Me.Lbl_Cliente_Nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cliente_Nombre.Location = New System.Drawing.Point(447, 77)
        Me.Lbl_Cliente_Nombre.Name = "Lbl_Cliente_Nombre"
        Me.Lbl_Cliente_Nombre.Size = New System.Drawing.Size(64, 16)
        Me.Lbl_Cliente_Nombre.TabIndex = 3
        Me.Lbl_Cliente_Nombre.Text = "Nombre:"
        '
        'Lbl_Codigo_Cliente
        '
        Me.Lbl_Codigo_Cliente.AutoSize = True
        Me.Lbl_Codigo_Cliente.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Codigo_Cliente.Location = New System.Drawing.Point(183, 53)
        Me.Lbl_Codigo_Cliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_Codigo_Cliente.Name = "Lbl_Codigo_Cliente"
        Me.Lbl_Codigo_Cliente.Size = New System.Drawing.Size(58, 16)
        Me.Lbl_Codigo_Cliente.TabIndex = 2
        Me.Lbl_Codigo_Cliente.Text = "Filtrar:"
        '
        'lb_nombre_cliente
        '
        Me.lb_nombre_cliente.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nombre_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_nombre_cliente.Location = New System.Drawing.Point(509, 77)
        Me.lb_nombre_cliente.Name = "lb_nombre_cliente"
        Me.lb_nombre_cliente.Size = New System.Drawing.Size(182, 69)
        Me.lb_nombre_cliente.TabIndex = 4
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_nombre.Location = New System.Drawing.Point(23, 51)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(77, 20)
        Me.rb_nombre.TabIndex = 62
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'Lbl_Alias
        '
        Me.Lbl_Alias.AutoSize = True
        Me.Lbl_Alias.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alias.Location = New System.Drawing.Point(453, 157)
        Me.Lbl_Alias.Name = "Lbl_Alias"
        Me.Lbl_Alias.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Alias.TabIndex = 10
        Me.Lbl_Alias.Text = "Alias:"
        '
        'lb_alias_cliente
        '
        Me.lb_alias_cliente.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alias_cliente.ForeColor = System.Drawing.Color.Red
        Me.lb_alias_cliente.Location = New System.Drawing.Point(505, 158)
        Me.lb_alias_cliente.Name = "lb_alias_cliente"
        Me.lb_alias_cliente.Size = New System.Drawing.Size(186, 52)
        Me.lb_alias_cliente.TabIndex = 11
        '
        'rb_alias
        '
        Me.rb_alias.AutoSize = True
        Me.rb_alias.Font = New System.Drawing.Font("Square721 BT", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_alias.Location = New System.Drawing.Point(106, 50)
        Me.rb_alias.Name = "rb_alias"
        Me.rb_alias.Size = New System.Drawing.Size(59, 20)
        Me.rb_alias.TabIndex = 63
        Me.rb_alias.Text = "Alias"
        Me.rb_alias.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(757, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 513)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR INFORMACIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LINEAS DE LA BOLETA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(401, 174)
        Me.DataGridView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(156, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "GUARDAR!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 323)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 32)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "GUARDAR!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Square721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NÚMERO DE BOLETA:"
        '
        'Frm_Ingreso_Boletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Ingreso_Boletas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Ingreso_Boletas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Cod_Articulo As TextBox
    Friend WithEvents Lbl_Codigo_Art As Label
    Friend WithEvents Lbl_Descripcion_Art As Label
    Friend WithEvents lb_descripcion_articulo As Label
    Friend WithEvents dg_articulo As DataGridView
    Friend WithEvents bt_buscar_articulo As Button
    Friend WithEvents Tbx_Adicional_Art As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dg_cliente As DataGridView
    Friend WithEvents Txt_Cod_Cliente As TextBox
    Friend WithEvents Lbl_Cliente_Nombre As Label
    Friend WithEvents Lbl_Codigo_Cliente As Label
    Friend WithEvents lb_nombre_cliente As Label
    Friend WithEvents rb_nombre As RadioButton
    Friend WithEvents Lbl_Alias As Label
    Friend WithEvents lb_alias_cliente As Label
    Friend WithEvents rb_alias As RadioButton
    Friend WithEvents check_box_opcional As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
