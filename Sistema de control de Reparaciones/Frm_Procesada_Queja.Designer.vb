<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Procesada_Queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Procesada_Queja))
        Me.Txt_Comentario = New System.Windows.Forms.TextBox()
        Me.Lbl_Alisto = New System.Windows.Forms.Label()
        Me.Lbl_Chequeo = New System.Windows.Forms.Label()
        Me.Cbx_Alisto = New System.Windows.Forms.ComboBox()
        Me.SCRALISTOCHEQUEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.Cbx_Chequeo = New System.Windows.Forms.ComboBox()
        Me.SCRALISTOCHEQUEOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.SCR_ALISTO_CHEQUEOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ALISTO_CHEQUEOTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Comentario.Location = New System.Drawing.Point(39, 99)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(405, 67)
        Me.Txt_Comentario.TabIndex = 0
        '
        'Lbl_Alisto
        '
        Me.Lbl_Alisto.AutoSize = True
        Me.Lbl_Alisto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alisto.Location = New System.Drawing.Point(102, 189)
        Me.Lbl_Alisto.Name = "Lbl_Alisto"
        Me.Lbl_Alisto.Size = New System.Drawing.Size(53, 15)
        Me.Lbl_Alisto.TabIndex = 1
        Me.Lbl_Alisto.Text = "ALISTÓ:"
        '
        'Lbl_Chequeo
        '
        Me.Lbl_Chequeo.AutoSize = True
        Me.Lbl_Chequeo.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Chequeo.Location = New System.Drawing.Point(82, 233)
        Me.Lbl_Chequeo.Name = "Lbl_Chequeo"
        Me.Lbl_Chequeo.Size = New System.Drawing.Size(71, 15)
        Me.Lbl_Chequeo.TabIndex = 2
        Me.Lbl_Chequeo.Text = "CHEQUEÓ:"
        '
        'Cbx_Alisto
        '
        Me.Cbx_Alisto.DataSource = Me.SCRALISTOCHEQUEOBindingSource
        Me.Cbx_Alisto.DisplayMember = "NOMBRE"
        Me.Cbx_Alisto.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Alisto.FormattingEnabled = True
        Me.Cbx_Alisto.Location = New System.Drawing.Point(170, 188)
        Me.Cbx_Alisto.Name = "Cbx_Alisto"
        Me.Cbx_Alisto.Size = New System.Drawing.Size(198, 23)
        Me.Cbx_Alisto.TabIndex = 3
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
        'Cbx_Chequeo
        '
        Me.Cbx_Chequeo.DataSource = Me.SCRALISTOCHEQUEOBindingSource1
        Me.Cbx_Chequeo.DisplayMember = "NOMBRE"
        Me.Cbx_Chequeo.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Chequeo.FormattingEnabled = True
        Me.Cbx_Chequeo.Location = New System.Drawing.Point(170, 232)
        Me.Cbx_Chequeo.Name = "Cbx_Chequeo"
        Me.Cbx_Chequeo.Size = New System.Drawing.Size(198, 23)
        Me.Cbx_Chequeo.TabIndex = 4
        '
        'SCRALISTOCHEQUEOBindingSource1
        '
        Me.SCRALISTOCHEQUEOBindingSource1.DataMember = "SCR_ALISTO_CHEQUEO"
        Me.SCRALISTOCHEQUEOBindingSource1.DataSource = Me.ExactusERP_SRC_TABLES
        Me.SCRALISTOCHEQUEOBindingSource1.Sort = "NOMBRE"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Font = New System.Drawing.Font("Square721 BT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(197, 295)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(98, 32)
        Me.Btn_Guardar.TabIndex = 5
        Me.Btn_Guardar.Text = "GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'SCR_ALISTO_CHEQUEOTableAdapter
        '
        Me.SCR_ALISTO_CHEQUEOTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QUEJA PROCESADA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COMENTARIO:"
        '
        'Frm_Procesada_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 348)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Cbx_Chequeo)
        Me.Controls.Add(Me.Cbx_Alisto)
        Me.Controls.Add(Me.Lbl_Chequeo)
        Me.Controls.Add(Me.Lbl_Alisto)
        Me.Controls.Add(Me.Txt_Comentario)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Procesada_Queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Queja Procesada"
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Comentario As TextBox
    Friend WithEvents Lbl_Alisto As Label
    Friend WithEvents Lbl_Chequeo As Label
    Friend WithEvents Cbx_Alisto As ComboBox
    Friend WithEvents Cbx_Chequeo As ComboBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents ExactusERP_SRC_TABLES As ExactusERP_SRC_TABLES
    Friend WithEvents SCRALISTOCHEQUEOBindingSource As BindingSource
    Friend WithEvents SCR_ALISTO_CHEQUEOTableAdapter As ExactusERP_SRC_TABLESTableAdapters.SCR_ALISTO_CHEQUEOTableAdapter
    Friend WithEvents SCRALISTOCHEQUEOBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
