<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Mantenimiento_Usuarios))
        Me.Dgv_Usuarios = New System.Windows.Forms.DataGridView()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada_rep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actua_rep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trans_rep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.busqueda_boleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada_queja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actua_queja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reportes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mantenimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.master = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crea_re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga_re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cierra_re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imprime_guia_re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reimprime_guia_re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCRUsuarioPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Lbl_T_Usuario = New System.Windows.Forms.Label()
        Me.Lbl_Passwd = New System.Windows.Forms.Label()
        Me.Lbl_Usuario = New System.Windows.Forms.Label()
        Me.Txt_Passwd = New System.Windows.Forms.TextBox()
        Me.Rbtn_Actua = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Crear = New System.Windows.Forms.RadioButton()
        Me.Btn_Actua = New System.Windows.Forms.Button()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Lbl_T_Nombre = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Cbx_Entrada_Rep = New System.Windows.Forms.ComboBox()
        Me.Lbl_Entrada_Rep = New System.Windows.Forms.Label()
        Me.Lbl_Actua_Rep = New System.Windows.Forms.Label()
        Me.Cbx_Actua_Rep = New System.Windows.Forms.ComboBox()
        Me.Lbl_Trans_Rep = New System.Windows.Forms.Label()
        Me.Cbx_Trans_Rep = New System.Windows.Forms.ComboBox()
        Me.Lbl_Busqueda_Boleta = New System.Windows.Forms.Label()
        Me.Cbx_Busqueda_Boleta = New System.Windows.Forms.ComboBox()
        Me.Lbl_Entrada_Queja = New System.Windows.Forms.Label()
        Me.Cbx_Entrada_Queja = New System.Windows.Forms.ComboBox()
        Me.Lbl_Actua_Queja = New System.Windows.Forms.Label()
        Me.Cbx_Actua_Queja = New System.Windows.Forms.ComboBox()
        Me.Lbl_Reportes = New System.Windows.Forms.Label()
        Me.Cbx_Reportes = New System.Windows.Forms.ComboBox()
        Me.Lbl_Mantenimiento = New System.Windows.Forms.Label()
        Me.Cbx_Mantenimiento = New System.Windows.Forms.ComboBox()
        Me.Lbl_Master = New System.Windows.Forms.Label()
        Me.Cbx_Master = New System.Windows.Forms.ComboBox()
        Me.Lbl_Cierra_Re = New System.Windows.Forms.Label()
        Me.Cbx_Cierra_Re = New System.Windows.Forms.ComboBox()
        Me.Lbl_Carga_Re = New System.Windows.Forms.Label()
        Me.Cbx_Carga_Re = New System.Windows.Forms.ComboBox()
        Me.Lbl_Crea_Re = New System.Windows.Forms.Label()
        Me.Cbx_Crea_Re = New System.Windows.Forms.ComboBox()
        Me.Lbl_Imprime_Guia_Re = New System.Windows.Forms.Label()
        Me.Cbx_Imprime_Guia_Re = New System.Windows.Forms.ComboBox()
        Me.Lbl_Reimprime_Guia_Re = New System.Windows.Forms.Label()
        Me.Cbx_Reimprime_Guia_Re = New System.Windows.Forms.ComboBox()
        Me.SCR_Usuario_PTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_Usuario_PTableAdapter()
        Me.Txt_Ean_8 = New System.Windows.Forms.TextBox()
        Me.Lbl_Ean_8 = New System.Windows.Forms.Label()
        Me.Btn_Imprime_Codigo = New System.Windows.Forms.Button()
        CType(Me.Dgv_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRUsuarioPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Usuarios
        '
        Me.Dgv_Usuarios.AllowUserToAddRows = False
        Me.Dgv_Usuarios.AllowUserToDeleteRows = False
        Me.Dgv_Usuarios.AutoGenerateColumns = False
        Me.Dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioDataGridViewTextBoxColumn, Me.Nombre, Me.entrada_rep, Me.actua_rep, Me.trans_rep, Me.busqueda_boleta, Me.entrada_queja, Me.actua_queja, Me.reportes, Me.mantenimiento, Me.master, Me.crea_re, Me.carga_re, Me.cierra_re, Me.imprime_guia_re, Me.reimprime_guia_re})
        Me.Dgv_Usuarios.DataSource = Me.SCRUsuarioPBindingSource
        Me.Dgv_Usuarios.Enabled = False
        Me.Dgv_Usuarios.Location = New System.Drawing.Point(12, 183)
        Me.Dgv_Usuarios.Name = "Dgv_Usuarios"
        Me.Dgv_Usuarios.ReadOnly = True
        Me.Dgv_Usuarios.Size = New System.Drawing.Size(882, 179)
        Me.Dgv_Usuarios.TabIndex = 0
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'entrada_rep
        '
        Me.entrada_rep.DataPropertyName = "entrada_rep"
        Me.entrada_rep.HeaderText = "Entrada Rep"
        Me.entrada_rep.Name = "entrada_rep"
        Me.entrada_rep.ReadOnly = True
        '
        'actua_rep
        '
        Me.actua_rep.DataPropertyName = "actua_rep"
        Me.actua_rep.HeaderText = "Actua Rep"
        Me.actua_rep.Name = "actua_rep"
        Me.actua_rep.ReadOnly = True
        '
        'trans_rep
        '
        Me.trans_rep.DataPropertyName = "trans_rep"
        Me.trans_rep.HeaderText = "Trans Rep"
        Me.trans_rep.Name = "trans_rep"
        Me.trans_rep.ReadOnly = True
        '
        'busqueda_boleta
        '
        Me.busqueda_boleta.DataPropertyName = "busqueda_boleta"
        Me.busqueda_boleta.HeaderText = "Busqueda Boleta"
        Me.busqueda_boleta.Name = "busqueda_boleta"
        Me.busqueda_boleta.ReadOnly = True
        '
        'entrada_queja
        '
        Me.entrada_queja.DataPropertyName = "entrada_queja"
        Me.entrada_queja.HeaderText = "Entrada Queja"
        Me.entrada_queja.Name = "entrada_queja"
        Me.entrada_queja.ReadOnly = True
        '
        'actua_queja
        '
        Me.actua_queja.DataPropertyName = "actua_queja"
        Me.actua_queja.HeaderText = "Actua Queja"
        Me.actua_queja.Name = "actua_queja"
        Me.actua_queja.ReadOnly = True
        '
        'reportes
        '
        Me.reportes.DataPropertyName = "reportes"
        Me.reportes.HeaderText = "Reportes"
        Me.reportes.Name = "reportes"
        Me.reportes.ReadOnly = True
        '
        'mantenimiento
        '
        Me.mantenimiento.DataPropertyName = "mantenimiento"
        Me.mantenimiento.HeaderText = "Mantenimiento"
        Me.mantenimiento.Name = "mantenimiento"
        Me.mantenimiento.ReadOnly = True
        '
        'master
        '
        Me.master.DataPropertyName = "master"
        Me.master.HeaderText = "Master"
        Me.master.Name = "master"
        Me.master.ReadOnly = True
        '
        'crea_re
        '
        Me.crea_re.DataPropertyName = "crea_re"
        Me.crea_re.HeaderText = "crea_re"
        Me.crea_re.Name = "crea_re"
        Me.crea_re.ReadOnly = True
        '
        'carga_re
        '
        Me.carga_re.DataPropertyName = "carga_re"
        Me.carga_re.HeaderText = "carga_re"
        Me.carga_re.Name = "carga_re"
        Me.carga_re.ReadOnly = True
        '
        'cierra_re
        '
        Me.cierra_re.DataPropertyName = "cierra_re"
        Me.cierra_re.HeaderText = "cierra_re"
        Me.cierra_re.Name = "cierra_re"
        Me.cierra_re.ReadOnly = True
        '
        'imprime_guia_re
        '
        Me.imprime_guia_re.DataPropertyName = "imprime_guia_re"
        Me.imprime_guia_re.HeaderText = "imprime_guia_re"
        Me.imprime_guia_re.Name = "imprime_guia_re"
        Me.imprime_guia_re.ReadOnly = True
        '
        'reimprime_guia_re
        '
        Me.reimprime_guia_re.DataPropertyName = "reimprime_guia_re"
        Me.reimprime_guia_re.HeaderText = "reimprime_guia_re"
        Me.reimprime_guia_re.Name = "reimprime_guia_re"
        Me.reimprime_guia_re.ReadOnly = True
        '
        'SCRUsuarioPBindingSource
        '
        Me.SCRUsuarioPBindingSource.DataMember = "SCR_Usuario_P"
        Me.SCRUsuarioPBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lbl_T_Usuario
        '
        Me.Lbl_T_Usuario.AutoSize = True
        Me.Lbl_T_Usuario.Location = New System.Drawing.Point(14, 10)
        Me.Lbl_T_Usuario.Name = "Lbl_T_Usuario"
        Me.Lbl_T_Usuario.Size = New System.Drawing.Size(51, 14)
        Me.Lbl_T_Usuario.TabIndex = 1
        Me.Lbl_T_Usuario.Text = "Usuario:"
        '
        'Lbl_Passwd
        '
        Me.Lbl_Passwd.AutoSize = True
        Me.Lbl_Passwd.Location = New System.Drawing.Point(14, 40)
        Me.Lbl_Passwd.Name = "Lbl_Passwd"
        Me.Lbl_Passwd.Size = New System.Drawing.Size(51, 14)
        Me.Lbl_Passwd.TabIndex = 2
        Me.Lbl_Passwd.Text = "Passwd:"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(71, 10)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(47, 14)
        Me.Lbl_Usuario.TabIndex = 3
        Me.Lbl_Usuario.Text = "Usuario"
        Me.Lbl_Usuario.Visible = False
        '
        'Txt_Passwd
        '
        Me.Txt_Passwd.Enabled = False
        Me.Txt_Passwd.Location = New System.Drawing.Point(74, 38)
        Me.Txt_Passwd.Name = "Txt_Passwd"
        Me.Txt_Passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.Txt_Passwd.Size = New System.Drawing.Size(112, 21)
        Me.Txt_Passwd.TabIndex = 4
        '
        'Rbtn_Actua
        '
        Me.Rbtn_Actua.AutoSize = True
        Me.Rbtn_Actua.Location = New System.Drawing.Point(721, 12)
        Me.Rbtn_Actua.Name = "Rbtn_Actua"
        Me.Rbtn_Actua.Size = New System.Drawing.Size(79, 18)
        Me.Rbtn_Actua.TabIndex = 5
        Me.Rbtn_Actua.TabStop = True
        Me.Rbtn_Actua.Text = "Actualizar"
        Me.Rbtn_Actua.UseVisualStyleBackColor = True
        '
        'Rbtn_Crear
        '
        Me.Rbtn_Crear.AutoSize = True
        Me.Rbtn_Crear.Location = New System.Drawing.Point(824, 12)
        Me.Rbtn_Crear.Name = "Rbtn_Crear"
        Me.Rbtn_Crear.Size = New System.Drawing.Size(55, 18)
        Me.Rbtn_Crear.TabIndex = 6
        Me.Rbtn_Crear.TabStop = True
        Me.Rbtn_Crear.Text = "Crear"
        Me.Rbtn_Crear.UseVisualStyleBackColor = True
        '
        'Btn_Actua
        '
        Me.Btn_Actua.Location = New System.Drawing.Point(721, 36)
        Me.Btn_Actua.Name = "Btn_Actua"
        Me.Btn_Actua.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Actua.TabIndex = 7
        Me.Btn_Actua.Text = "Actualizar"
        Me.Btn_Actua.UseVisualStyleBackColor = True
        Me.Btn_Actua.Visible = False
        '
        'Btn_Crear
        '
        Me.Btn_Crear.Location = New System.Drawing.Point(813, 36)
        Me.Btn_Crear.Name = "Btn_Crear"
        Me.Btn_Crear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Crear.TabIndex = 8
        Me.Btn_Crear.Text = "Crear"
        Me.Btn_Crear.UseVisualStyleBackColor = True
        Me.Btn_Crear.Visible = False
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(74, 7)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(112, 21)
        Me.Txt_Usuario.TabIndex = 9
        Me.Txt_Usuario.Visible = False
        '
        'Lbl_T_Nombre
        '
        Me.Lbl_T_Nombre.AutoSize = True
        Me.Lbl_T_Nombre.Location = New System.Drawing.Point(14, 74)
        Me.Lbl_T_Nombre.Name = "Lbl_T_Nombre"
        Me.Lbl_T_Nombre.Size = New System.Drawing.Size(53, 14)
        Me.Lbl_T_Nombre.TabIndex = 10
        Me.Lbl_T_Nombre.Text = "Nombre:"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(74, 71)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(112, 21)
        Me.Txt_Nombre.TabIndex = 11
        Me.Txt_Nombre.Visible = False
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Location = New System.Drawing.Point(76, 74)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(49, 14)
        Me.Lbl_Nombre.TabIndex = 12
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Cbx_Entrada_Rep
        '
        Me.Cbx_Entrada_Rep.FormattingEnabled = True
        Me.Cbx_Entrada_Rep.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Entrada_Rep.Location = New System.Drawing.Point(326, 6)
        Me.Cbx_Entrada_Rep.Name = "Cbx_Entrada_Rep"
        Me.Cbx_Entrada_Rep.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Entrada_Rep.TabIndex = 13
        Me.Cbx_Entrada_Rep.Text = "0"
        '
        'Lbl_Entrada_Rep
        '
        Me.Lbl_Entrada_Rep.AutoSize = True
        Me.Lbl_Entrada_Rep.Location = New System.Drawing.Point(219, 10)
        Me.Lbl_Entrada_Rep.Name = "Lbl_Entrada_Rep"
        Me.Lbl_Entrada_Rep.Size = New System.Drawing.Size(72, 14)
        Me.Lbl_Entrada_Rep.TabIndex = 14
        Me.Lbl_Entrada_Rep.Text = "Entrada Rep"
        '
        'Lbl_Actua_Rep
        '
        Me.Lbl_Actua_Rep.AutoSize = True
        Me.Lbl_Actua_Rep.Location = New System.Drawing.Point(219, 38)
        Me.Lbl_Actua_Rep.Name = "Lbl_Actua_Rep"
        Me.Lbl_Actua_Rep.Size = New System.Drawing.Size(62, 14)
        Me.Lbl_Actua_Rep.TabIndex = 16
        Me.Lbl_Actua_Rep.Text = "Actua Rep"
        '
        'Cbx_Actua_Rep
        '
        Me.Cbx_Actua_Rep.FormattingEnabled = True
        Me.Cbx_Actua_Rep.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Actua_Rep.Location = New System.Drawing.Point(326, 34)
        Me.Cbx_Actua_Rep.Name = "Cbx_Actua_Rep"
        Me.Cbx_Actua_Rep.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Actua_Rep.TabIndex = 15
        Me.Cbx_Actua_Rep.Text = "0"
        '
        'Lbl_Trans_Rep
        '
        Me.Lbl_Trans_Rep.AutoSize = True
        Me.Lbl_Trans_Rep.Location = New System.Drawing.Point(219, 66)
        Me.Lbl_Trans_Rep.Name = "Lbl_Trans_Rep"
        Me.Lbl_Trans_Rep.Size = New System.Drawing.Size(60, 14)
        Me.Lbl_Trans_Rep.TabIndex = 18
        Me.Lbl_Trans_Rep.Text = "Trans Rep"
        '
        'Cbx_Trans_Rep
        '
        Me.Cbx_Trans_Rep.FormattingEnabled = True
        Me.Cbx_Trans_Rep.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Trans_Rep.Location = New System.Drawing.Point(326, 62)
        Me.Cbx_Trans_Rep.Name = "Cbx_Trans_Rep"
        Me.Cbx_Trans_Rep.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Trans_Rep.TabIndex = 17
        Me.Cbx_Trans_Rep.Text = "0"
        '
        'Lbl_Busqueda_Boleta
        '
        Me.Lbl_Busqueda_Boleta.AutoSize = True
        Me.Lbl_Busqueda_Boleta.Location = New System.Drawing.Point(219, 93)
        Me.Lbl_Busqueda_Boleta.Name = "Lbl_Busqueda_Boleta"
        Me.Lbl_Busqueda_Boleta.Size = New System.Drawing.Size(95, 14)
        Me.Lbl_Busqueda_Boleta.TabIndex = 20
        Me.Lbl_Busqueda_Boleta.Text = "Busqueda Boleta"
        '
        'Cbx_Busqueda_Boleta
        '
        Me.Cbx_Busqueda_Boleta.FormattingEnabled = True
        Me.Cbx_Busqueda_Boleta.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Busqueda_Boleta.Location = New System.Drawing.Point(326, 89)
        Me.Cbx_Busqueda_Boleta.Name = "Cbx_Busqueda_Boleta"
        Me.Cbx_Busqueda_Boleta.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Busqueda_Boleta.TabIndex = 19
        Me.Cbx_Busqueda_Boleta.Text = "0"
        '
        'Lbl_Entrada_Queja
        '
        Me.Lbl_Entrada_Queja.AutoSize = True
        Me.Lbl_Entrada_Queja.Location = New System.Drawing.Point(219, 120)
        Me.Lbl_Entrada_Queja.Name = "Lbl_Entrada_Queja"
        Me.Lbl_Entrada_Queja.Size = New System.Drawing.Size(81, 14)
        Me.Lbl_Entrada_Queja.TabIndex = 22
        Me.Lbl_Entrada_Queja.Text = "Entrada Queja"
        '
        'Cbx_Entrada_Queja
        '
        Me.Cbx_Entrada_Queja.FormattingEnabled = True
        Me.Cbx_Entrada_Queja.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Entrada_Queja.Location = New System.Drawing.Point(325, 116)
        Me.Cbx_Entrada_Queja.Name = "Cbx_Entrada_Queja"
        Me.Cbx_Entrada_Queja.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Entrada_Queja.TabIndex = 21
        Me.Cbx_Entrada_Queja.Text = "0"
        '
        'Lbl_Actua_Queja
        '
        Me.Lbl_Actua_Queja.AutoSize = True
        Me.Lbl_Actua_Queja.Location = New System.Drawing.Point(385, 10)
        Me.Lbl_Actua_Queja.Name = "Lbl_Actua_Queja"
        Me.Lbl_Actua_Queja.Size = New System.Drawing.Size(71, 14)
        Me.Lbl_Actua_Queja.TabIndex = 24
        Me.Lbl_Actua_Queja.Text = "Actua Queja"
        '
        'Cbx_Actua_Queja
        '
        Me.Cbx_Actua_Queja.FormattingEnabled = True
        Me.Cbx_Actua_Queja.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Actua_Queja.Location = New System.Drawing.Point(477, 6)
        Me.Cbx_Actua_Queja.Name = "Cbx_Actua_Queja"
        Me.Cbx_Actua_Queja.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Actua_Queja.TabIndex = 23
        Me.Cbx_Actua_Queja.Text = "0"
        '
        'Lbl_Reportes
        '
        Me.Lbl_Reportes.AutoSize = True
        Me.Lbl_Reportes.Location = New System.Drawing.Point(385, 38)
        Me.Lbl_Reportes.Name = "Lbl_Reportes"
        Me.Lbl_Reportes.Size = New System.Drawing.Size(55, 14)
        Me.Lbl_Reportes.TabIndex = 26
        Me.Lbl_Reportes.Text = "Reportes"
        '
        'Cbx_Reportes
        '
        Me.Cbx_Reportes.FormattingEnabled = True
        Me.Cbx_Reportes.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Reportes.Location = New System.Drawing.Point(477, 34)
        Me.Cbx_Reportes.Name = "Cbx_Reportes"
        Me.Cbx_Reportes.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Reportes.TabIndex = 25
        Me.Cbx_Reportes.Text = "0"
        '
        'Lbl_Mantenimiento
        '
        Me.Lbl_Mantenimiento.AutoSize = True
        Me.Lbl_Mantenimiento.Location = New System.Drawing.Point(385, 65)
        Me.Lbl_Mantenimiento.Name = "Lbl_Mantenimiento"
        Me.Lbl_Mantenimiento.Size = New System.Drawing.Size(85, 14)
        Me.Lbl_Mantenimiento.TabIndex = 28
        Me.Lbl_Mantenimiento.Text = "Mantenimiento"
        '
        'Cbx_Mantenimiento
        '
        Me.Cbx_Mantenimiento.FormattingEnabled = True
        Me.Cbx_Mantenimiento.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Mantenimiento.Location = New System.Drawing.Point(477, 61)
        Me.Cbx_Mantenimiento.Name = "Cbx_Mantenimiento"
        Me.Cbx_Mantenimiento.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Mantenimiento.TabIndex = 27
        Me.Cbx_Mantenimiento.Text = "0"
        '
        'Lbl_Master
        '
        Me.Lbl_Master.AutoSize = True
        Me.Lbl_Master.Location = New System.Drawing.Point(385, 92)
        Me.Lbl_Master.Name = "Lbl_Master"
        Me.Lbl_Master.Size = New System.Drawing.Size(45, 14)
        Me.Lbl_Master.TabIndex = 30
        Me.Lbl_Master.Text = "Master"
        '
        'Cbx_Master
        '
        Me.Cbx_Master.FormattingEnabled = True
        Me.Cbx_Master.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Master.Location = New System.Drawing.Point(477, 89)
        Me.Cbx_Master.Name = "Cbx_Master"
        Me.Cbx_Master.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Master.TabIndex = 29
        Me.Cbx_Master.Text = "0"
        '
        'Lbl_Cierra_Re
        '
        Me.Lbl_Cierra_Re.AutoSize = True
        Me.Lbl_Cierra_Re.Location = New System.Drawing.Point(546, 36)
        Me.Lbl_Cierra_Re.Name = "Lbl_Cierra_Re"
        Me.Lbl_Cierra_Re.Size = New System.Drawing.Size(59, 14)
        Me.Lbl_Cierra_Re.TabIndex = 36
        Me.Lbl_Cierra_Re.Text = "Cierra RE"
        '
        'Cbx_Cierra_Re
        '
        Me.Cbx_Cierra_Re.FormattingEnabled = True
        Me.Cbx_Cierra_Re.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Cierra_Re.Location = New System.Drawing.Point(670, 34)
        Me.Cbx_Cierra_Re.Name = "Cbx_Cierra_Re"
        Me.Cbx_Cierra_Re.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Cierra_Re.TabIndex = 35
        Me.Cbx_Cierra_Re.Text = "0"
        '
        'Lbl_Carga_Re
        '
        Me.Lbl_Carga_Re.AutoSize = True
        Me.Lbl_Carga_Re.Location = New System.Drawing.Point(546, 9)
        Me.Lbl_Carga_Re.Name = "Lbl_Carga_Re"
        Me.Lbl_Carga_Re.Size = New System.Drawing.Size(57, 14)
        Me.Lbl_Carga_Re.TabIndex = 34
        Me.Lbl_Carga_Re.Text = "Carga RE"
        '
        'Cbx_Carga_Re
        '
        Me.Cbx_Carga_Re.FormattingEnabled = True
        Me.Cbx_Carga_Re.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Carga_Re.Location = New System.Drawing.Point(670, 7)
        Me.Cbx_Carga_Re.Name = "Cbx_Carga_Re"
        Me.Cbx_Carga_Re.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Carga_Re.TabIndex = 33
        Me.Cbx_Carga_Re.Text = "0"
        '
        'Lbl_Crea_Re
        '
        Me.Lbl_Crea_Re.AutoSize = True
        Me.Lbl_Crea_Re.Location = New System.Drawing.Point(385, 120)
        Me.Lbl_Crea_Re.Name = "Lbl_Crea_Re"
        Me.Lbl_Crea_Re.Size = New System.Drawing.Size(51, 14)
        Me.Lbl_Crea_Re.TabIndex = 32
        Me.Lbl_Crea_Re.Text = "Crea RE"
        '
        'Cbx_Crea_Re
        '
        Me.Cbx_Crea_Re.FormattingEnabled = True
        Me.Cbx_Crea_Re.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Crea_Re.Location = New System.Drawing.Point(477, 116)
        Me.Cbx_Crea_Re.Name = "Cbx_Crea_Re"
        Me.Cbx_Crea_Re.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Crea_Re.TabIndex = 31
        Me.Cbx_Crea_Re.Text = "0"
        '
        'Lbl_Imprime_Guia_Re
        '
        Me.Lbl_Imprime_Guia_Re.AutoSize = True
        Me.Lbl_Imprime_Guia_Re.Location = New System.Drawing.Point(546, 65)
        Me.Lbl_Imprime_Guia_Re.Name = "Lbl_Imprime_Guia_Re"
        Me.Lbl_Imprime_Guia_Re.Size = New System.Drawing.Size(102, 14)
        Me.Lbl_Imprime_Guia_Re.TabIndex = 38
        Me.Lbl_Imprime_Guia_Re.Text = "Imprime Guias RE"
        '
        'Cbx_Imprime_Guia_Re
        '
        Me.Cbx_Imprime_Guia_Re.FormattingEnabled = True
        Me.Cbx_Imprime_Guia_Re.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Imprime_Guia_Re.Location = New System.Drawing.Point(670, 63)
        Me.Cbx_Imprime_Guia_Re.Name = "Cbx_Imprime_Guia_Re"
        Me.Cbx_Imprime_Guia_Re.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Imprime_Guia_Re.TabIndex = 37
        Me.Cbx_Imprime_Guia_Re.Text = "0"
        '
        'Lbl_Reimprime_Guia_Re
        '
        Me.Lbl_Reimprime_Guia_Re.AutoSize = True
        Me.Lbl_Reimprime_Guia_Re.Location = New System.Drawing.Point(546, 93)
        Me.Lbl_Reimprime_Guia_Re.Name = "Lbl_Reimprime_Guia_Re"
        Me.Lbl_Reimprime_Guia_Re.Size = New System.Drawing.Size(120, 14)
        Me.Lbl_Reimprime_Guia_Re.TabIndex = 40
        Me.Lbl_Reimprime_Guia_Re.Text = "Re-Imprime Guias RE"
        '
        'Cbx_Reimprime_Guia_Re
        '
        Me.Cbx_Reimprime_Guia_Re.FormattingEnabled = True
        Me.Cbx_Reimprime_Guia_Re.Items.AddRange(New Object() {"0", "1"})
        Me.Cbx_Reimprime_Guia_Re.Location = New System.Drawing.Point(670, 91)
        Me.Cbx_Reimprime_Guia_Re.Name = "Cbx_Reimprime_Guia_Re"
        Me.Cbx_Reimprime_Guia_Re.Size = New System.Drawing.Size(36, 22)
        Me.Cbx_Reimprime_Guia_Re.TabIndex = 39
        Me.Cbx_Reimprime_Guia_Re.Text = "0"
        '
        'SCR_Usuario_PTableAdapter
        '
        Me.SCR_Usuario_PTableAdapter.ClearBeforeFill = True
        '
        'Txt_Ean_8
        '
        Me.Txt_Ean_8.Enabled = False
        Me.Txt_Ean_8.Location = New System.Drawing.Point(74, 103)
        Me.Txt_Ean_8.Name = "Txt_Ean_8"
        Me.Txt_Ean_8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.Txt_Ean_8.Size = New System.Drawing.Size(112, 21)
        Me.Txt_Ean_8.TabIndex = 42
        '
        'Lbl_Ean_8
        '
        Me.Lbl_Ean_8.AutoSize = True
        Me.Lbl_Ean_8.Location = New System.Drawing.Point(14, 105)
        Me.Lbl_Ean_8.Name = "Lbl_Ean_8"
        Me.Lbl_Ean_8.Size = New System.Drawing.Size(46, 14)
        Me.Lbl_Ean_8.TabIndex = 41
        Me.Lbl_Ean_8.Text = "EAN 8:"
        '
        'Btn_Imprime_Codigo
        '
        Me.Btn_Imprime_Codigo.Location = New System.Drawing.Point(767, 65)
        Me.Btn_Imprime_Codigo.Name = "Btn_Imprime_Codigo"
        Me.Btn_Imprime_Codigo.Size = New System.Drawing.Size(75, 42)
        Me.Btn_Imprime_Codigo.TabIndex = 43
        Me.Btn_Imprime_Codigo.Text = "Imprime Codigo"
        Me.Btn_Imprime_Codigo.UseVisualStyleBackColor = True
        Me.Btn_Imprime_Codigo.Visible = False
        '
        'Frm_Mantenimiento_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 374)
        Me.Controls.Add(Me.Btn_Imprime_Codigo)
        Me.Controls.Add(Me.Txt_Ean_8)
        Me.Controls.Add(Me.Lbl_Ean_8)
        Me.Controls.Add(Me.Lbl_Reimprime_Guia_Re)
        Me.Controls.Add(Me.Cbx_Reimprime_Guia_Re)
        Me.Controls.Add(Me.Lbl_Imprime_Guia_Re)
        Me.Controls.Add(Me.Cbx_Imprime_Guia_Re)
        Me.Controls.Add(Me.Lbl_Cierra_Re)
        Me.Controls.Add(Me.Cbx_Cierra_Re)
        Me.Controls.Add(Me.Lbl_Carga_Re)
        Me.Controls.Add(Me.Cbx_Carga_Re)
        Me.Controls.Add(Me.Lbl_Crea_Re)
        Me.Controls.Add(Me.Cbx_Crea_Re)
        Me.Controls.Add(Me.Lbl_Master)
        Me.Controls.Add(Me.Cbx_Master)
        Me.Controls.Add(Me.Lbl_Mantenimiento)
        Me.Controls.Add(Me.Cbx_Mantenimiento)
        Me.Controls.Add(Me.Lbl_Reportes)
        Me.Controls.Add(Me.Cbx_Reportes)
        Me.Controls.Add(Me.Lbl_Actua_Queja)
        Me.Controls.Add(Me.Cbx_Actua_Queja)
        Me.Controls.Add(Me.Lbl_Entrada_Queja)
        Me.Controls.Add(Me.Cbx_Entrada_Queja)
        Me.Controls.Add(Me.Lbl_Busqueda_Boleta)
        Me.Controls.Add(Me.Cbx_Busqueda_Boleta)
        Me.Controls.Add(Me.Lbl_Trans_Rep)
        Me.Controls.Add(Me.Cbx_Trans_Rep)
        Me.Controls.Add(Me.Lbl_Actua_Rep)
        Me.Controls.Add(Me.Cbx_Actua_Rep)
        Me.Controls.Add(Me.Lbl_Entrada_Rep)
        Me.Controls.Add(Me.Cbx_Entrada_Rep)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Lbl_T_Nombre)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Btn_Crear)
        Me.Controls.Add(Me.Btn_Actua)
        Me.Controls.Add(Me.Rbtn_Crear)
        Me.Controls.Add(Me.Rbtn_Actua)
        Me.Controls.Add(Me.Txt_Passwd)
        Me.Controls.Add(Me.Lbl_Usuario)
        Me.Controls.Add(Me.Lbl_Passwd)
        Me.Controls.Add(Me.Lbl_T_Usuario)
        Me.Controls.Add(Me.Dgv_Usuarios)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Mantenimiento_Usuarios"
        Me.Text = "Mantenimiento Usuarios"
        CType(Me.Dgv_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRUsuarioPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Usuarios As DataGridView
    Friend WithEvents Lbl_T_Usuario As Label
    Friend WithEvents Lbl_Passwd As Label
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Txt_Passwd As TextBox
    Friend WithEvents Rbtn_Actua As RadioButton
    Friend WithEvents Rbtn_Crear As RadioButton
    Friend WithEvents Btn_Actua As Button
    Friend WithEvents Btn_Crear As Button
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRUsuarioPBindingSource As BindingSource
    Friend WithEvents SCR_Usuario_PTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_Usuario_PTableAdapter
    Friend WithEvents Lbl_T_Nombre As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Cbx_Entrada_Rep As ComboBox
    Friend WithEvents Lbl_Entrada_Rep As Label
    Friend WithEvents Lbl_Actua_Rep As Label
    Friend WithEvents Cbx_Actua_Rep As ComboBox
    Friend WithEvents Lbl_Trans_Rep As Label
    Friend WithEvents Cbx_Trans_Rep As ComboBox
    Friend WithEvents Lbl_Busqueda_Boleta As Label
    Friend WithEvents Cbx_Busqueda_Boleta As ComboBox
    Friend WithEvents Lbl_Entrada_Queja As Label
    Friend WithEvents Cbx_Entrada_Queja As ComboBox
    Friend WithEvents Lbl_Actua_Queja As Label
    Friend WithEvents Cbx_Actua_Queja As ComboBox
    Friend WithEvents Lbl_Reportes As Label
    Friend WithEvents Cbx_Reportes As ComboBox
    Friend WithEvents Lbl_Mantenimiento As Label
    Friend WithEvents Cbx_Mantenimiento As ComboBox
    Friend WithEvents Lbl_Master As Label
    Friend WithEvents Cbx_Master As ComboBox
    Friend WithEvents Lbl_Cierra_Re As Label
    Friend WithEvents Cbx_Cierra_Re As ComboBox
    Friend WithEvents Lbl_Carga_Re As Label
    Friend WithEvents Cbx_Carga_Re As ComboBox
    Friend WithEvents Lbl_Crea_Re As Label
    Friend WithEvents Cbx_Crea_Re As ComboBox
    Friend WithEvents Lbl_Imprime_Guia_Re As Label
    Friend WithEvents Cbx_Imprime_Guia_Re As ComboBox
    Friend WithEvents Lbl_Reimprime_Guia_Re As Label
    Friend WithEvents Cbx_Reimprime_Guia_Re As ComboBox
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents entrada_rep As DataGridViewTextBoxColumn
    Friend WithEvents actua_rep As DataGridViewTextBoxColumn
    Friend WithEvents trans_rep As DataGridViewTextBoxColumn
    Friend WithEvents busqueda_boleta As DataGridViewTextBoxColumn
    Friend WithEvents entrada_queja As DataGridViewTextBoxColumn
    Friend WithEvents actua_queja As DataGridViewTextBoxColumn
    Friend WithEvents reportes As DataGridViewTextBoxColumn
    Friend WithEvents mantenimiento As DataGridViewTextBoxColumn
    Friend WithEvents master As DataGridViewTextBoxColumn
    Friend WithEvents crea_re As DataGridViewTextBoxColumn
    Friend WithEvents carga_re As DataGridViewTextBoxColumn
    Friend WithEvents cierra_re As DataGridViewTextBoxColumn
    Friend WithEvents imprime_guia_re As DataGridViewTextBoxColumn
    Friend WithEvents reimprime_guia_re As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Ean_8 As TextBox
    Friend WithEvents Lbl_Ean_8 As Label
    Friend WithEvents Btn_Imprime_Codigo As Button
End Class
