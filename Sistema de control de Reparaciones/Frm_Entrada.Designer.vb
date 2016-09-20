<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Entrada))
        Me.Lbl_Titulo_Cliente = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_cliente_d86 = New WindowsApplication1.ExactusERP_cliente_d86()
        Me.Lbl_Codigo_Cliente = New System.Windows.Forms.Label()
        Me.CLIENTETableAdapter = New WindowsApplication1.ExactusERP_cliente_d86TableAdapters.CLIENTETableAdapter()
        Me.Lbl_Cliente_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERPDataSet = New WindowsApplication1.ExactusERPDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ARTICULOTableAdapter = New WindowsApplication1.ExactusERPDataSetTableAdapters.ARTICULOTableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_cliente_d86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Titulo_Cliente
        '
        Me.Lbl_Titulo_Cliente.AutoSize = True
        Me.Lbl_Titulo_Cliente.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo_Cliente.Location = New System.Drawing.Point(459, 9)
        Me.Lbl_Titulo_Cliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Titulo_Cliente.Name = "Lbl_Titulo_Cliente"
        Me.Lbl_Titulo_Cliente.Size = New System.Drawing.Size(364, 38)
        Me.Lbl_Titulo_Cliente.TabIndex = 0
        Me.Lbl_Titulo_Cliente.Text = "Informacion del Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CLIENTEBindingSource
        Me.ComboBox1.DisplayMember = "CLIENTE"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(90, 62)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.ExactusERP_cliente_d86
        '
        'ExactusERP_cliente_d86
        '
        Me.ExactusERP_cliente_d86.DataSetName = "ExactusERP_cliente_d86"
        Me.ExactusERP_cliente_d86.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_Codigo_Cliente
        '
        Me.Lbl_Codigo_Cliente.AutoSize = True
        Me.Lbl_Codigo_Cliente.Location = New System.Drawing.Point(13, 65)
        Me.Lbl_Codigo_Cliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Codigo_Cliente.Name = "Lbl_Codigo_Cliente"
        Me.Lbl_Codigo_Cliente.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_Codigo_Cliente.TabIndex = 2
        Me.Lbl_Codigo_Cliente.Text = "Codigo #"
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'Lbl_Cliente_Nombre
        '
        Me.Lbl_Cliente_Nombre.AutoSize = True
        Me.Lbl_Cliente_Nombre.Location = New System.Drawing.Point(290, 65)
        Me.Lbl_Cliente_Nombre.Name = "Lbl_Cliente_Nombre"
        Me.Lbl_Cliente_Nombre.Size = New System.Drawing.Size(57, 15)
        Me.Lbl_Cliente_Nombre.TabIndex = 3
        Me.Lbl_Cliente_Nombre.Text = "Nombre:"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NOMBRE", True))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(347, 65)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_Nombre.TabIndex = 4
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Lbl_
        '
        Me.Lbl_.AutoSize = True
        Me.Lbl_.Location = New System.Drawing.Point(11, 95)
        Me.Lbl_.Name = "Lbl_"
        Me.Lbl_.Size = New System.Drawing.Size(61, 15)
        Me.Lbl_.TabIndex = 5
        Me.Lbl_.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO1", True))
        Me.Label1.Location = New System.Drawing.Point(73, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# Telefono 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "TELEFONO2", True))
        Me.Label2.Location = New System.Drawing.Point(152, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "# telefono 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "FAX", True))
        Me.Label4.Location = New System.Drawing.Point(274, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "# Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Alias:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ALIAS", True))
        Me.Label6.Location = New System.Drawing.Point(407, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(403, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(451, 38)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Informacion sobre el Articulo"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ARTICULOBindingSource
        Me.ComboBox2.DisplayMember = "ARTICULO"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(90, 206)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 23)
        Me.ComboBox2.TabIndex = 13
        '
        'ARTICULOBindingSource
        '
        Me.ARTICULOBindingSource.DataMember = "ARTICULO"
        Me.ARTICULOBindingSource.DataSource = Me.ExactusERPDataSet
        '
        'ExactusERPDataSet
        '
        Me.ExactusERPDataSet.DataSetName = "ExactusERPDataSet"
        Me.ExactusERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Codigo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(277, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Descripcion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOBindingSource, "DESCRIPCION", True))
        Me.Label10.Location = New System.Drawing.Point(365, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Descripcion"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 247)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1115, 23)
        Me.TextBox1.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Adicional:"
        '
        'ARTICULOTableAdapter
        '
        Me.ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(381, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(500, 38)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Informacion sobre la Reparacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Boleta #"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 338)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(929, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 23)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Frm_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 536)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Lbl_Cliente_Nombre)
        Me.Controls.Add(Me.Lbl_Codigo_Cliente)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Lbl_Titulo_Cliente)
        Me.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(30, 0)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Datos"
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_cliente_d86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Titulo_Cliente As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lbl_Codigo_Cliente As Label
    Friend WithEvents ExactusERP_cliente_d86 As ExactusERP_cliente_d86
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As ExactusERP_cliente_d86TableAdapters.CLIENTETableAdapter
    Friend WithEvents Lbl_Cliente_Nombre As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_ As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ExactusERPDataSet As ExactusERPDataSet
    Friend WithEvents ARTICULOBindingSource As BindingSource
    Friend WithEvents ARTICULOTableAdapter As ExactusERPDataSetTableAdapters.ARTICULOTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
