<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Solucion_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Solucion_Queja))
        Me.Lbl_Solucion = New System.Windows.Forms.Label()
        Me.Txt_Solucion = New System.Windows.Forms.TextBox()
        Me.Lbl_Chequeo = New System.Windows.Forms.Label()
        Me.Lbl_Alisto = New System.Windows.Forms.Label()
        Me.Cbx_Chequeo = New System.Windows.Forms.ComboBox()
        Me.SCRALISTOCHEQUEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Cbx_Alisto = New System.Windows.Forms.ComboBox()
        Me.SCRALISTOCHEQUEOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ALISTO_CHEQUEOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ALISTO_CHEQUEOTableAdapter()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Solucion
        '
        Me.Lbl_Solucion.AutoSize = True
        Me.Lbl_Solucion.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Solucion.Location = New System.Drawing.Point(32, 78)
        Me.Lbl_Solucion.Name = "Lbl_Solucion"
        Me.Lbl_Solucion.Size = New System.Drawing.Size(74, 15)
        Me.Lbl_Solucion.TabIndex = 0
        Me.Lbl_Solucion.Text = "SOLUCIÓN:"
        '
        'Txt_Solucion
        '
        Me.Txt_Solucion.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Solucion.Location = New System.Drawing.Point(35, 106)
        Me.Txt_Solucion.Multiline = True
        Me.Txt_Solucion.Name = "Txt_Solucion"
        Me.Txt_Solucion.Size = New System.Drawing.Size(405, 67)
        Me.Txt_Solucion.TabIndex = 1
        '
        'Lbl_Chequeo
        '
        Me.Lbl_Chequeo.AutoSize = True
        Me.Lbl_Chequeo.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Chequeo.Location = New System.Drawing.Point(75, 197)
        Me.Lbl_Chequeo.Name = "Lbl_Chequeo"
        Me.Lbl_Chequeo.Size = New System.Drawing.Size(71, 15)
        Me.Lbl_Chequeo.TabIndex = 2
        Me.Lbl_Chequeo.Text = "CHEQUEÓ:"
        '
        'Lbl_Alisto
        '
        Me.Lbl_Alisto.AutoSize = True
        Me.Lbl_Alisto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alisto.Location = New System.Drawing.Point(93, 241)
        Me.Lbl_Alisto.Name = "Lbl_Alisto"
        Me.Lbl_Alisto.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_Alisto.TabIndex = 3
        Me.Lbl_Alisto.Text = "ALISTÓ:"
        '
        'Cbx_Chequeo
        '
        Me.Cbx_Chequeo.DataSource = Me.SCRALISTOCHEQUEOBindingSource
        Me.Cbx_Chequeo.DisplayMember = "NOMBRE"
        Me.Cbx_Chequeo.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Chequeo.FormattingEnabled = True
        Me.Cbx_Chequeo.Location = New System.Drawing.Point(152, 194)
        Me.Cbx_Chequeo.Name = "Cbx_Chequeo"
        Me.Cbx_Chequeo.Size = New System.Drawing.Size(207, 23)
        Me.Cbx_Chequeo.TabIndex = 4
        '
        'SCRALISTOCHEQUEOBindingSource
        '
        Me.SCRALISTOCHEQUEOBindingSource.DataMember = "SCR_ALISTO_CHEQUEO"
        Me.SCRALISTOCHEQUEOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        Me.SCRALISTOCHEQUEOBindingSource.Sort = "NOMBRE"
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cbx_Alisto
        '
        Me.Cbx_Alisto.DataSource = Me.SCRALISTOCHEQUEOBindingSource1
        Me.Cbx_Alisto.DisplayMember = "NOMBRE"
        Me.Cbx_Alisto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Alisto.FormattingEnabled = True
        Me.Cbx_Alisto.Location = New System.Drawing.Point(152, 233)
        Me.Cbx_Alisto.Name = "Cbx_Alisto"
        Me.Cbx_Alisto.Size = New System.Drawing.Size(207, 23)
        Me.Cbx_Alisto.TabIndex = 5
        '
        'SCRALISTOCHEQUEOBindingSource1
        '
        Me.SCRALISTOCHEQUEOBindingSource1.DataMember = "SCR_ALISTO_CHEQUEO"
        Me.SCRALISTOCHEQUEOBindingSource1.DataSource = Me.ExactusERP_SRC_TABLES
        Me.SCRALISTOCHEQUEOBindingSource1.Sort = "NOMBRE"
        '
        'SCR_ALISTO_CHEQUEOTableAdapter
        '
        Me.SCR_ALISTO_CHEQUEOTableAdapter.ClearBeforeFill = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Font = New System.Drawing.Font("Square721 BT", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Guardar.Location = New System.Drawing.Point(199, 293)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(92, 33)
        Me.Btn_Guardar.TabIndex = 6
        Me.Btn_Guardar.Text = "GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(133, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SOLUCIÓN DE LA QUEJA"
        '
        'Frm_Solucion_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 348)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Cbx_Alisto)
        Me.Controls.Add(Me.Cbx_Chequeo)
        Me.Controls.Add(Me.Lbl_Alisto)
        Me.Controls.Add(Me.Lbl_Chequeo)
        Me.Controls.Add(Me.Txt_Solucion)
        Me.Controls.Add(Me.Lbl_Solucion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Solucion_Queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solucion Queja"
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Solucion As Label
    Friend WithEvents Txt_Solucion As TextBox
    Friend WithEvents Lbl_Chequeo As Label
    Friend WithEvents Lbl_Alisto As Label
    Friend WithEvents Cbx_Chequeo As ComboBox
    Friend WithEvents Cbx_Alisto As ComboBox
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRALISTOCHEQUEOBindingSource As BindingSource
    Friend WithEvents SCR_ALISTO_CHEQUEOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ALISTO_CHEQUEOTableAdapter
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents SCRALISTOCHEQUEOBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
End Class
