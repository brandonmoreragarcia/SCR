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
        Me.Cbx_Chequeo = New System.Windows.Forms.ComboBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.ExactusERP_SRC_TABLES = New WindowsApplication1.ExactusERP_SRC_TABLES()
        Me.SCRALISTOCHEQUEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCR_ALISTO_CHEQUEOTableAdapter = New WindowsApplication1.ExactusERP_SRC_TABLESTableAdapters.SCR_ALISTO_CHEQUEOTableAdapter()
        Me.SCRALISTOCHEQUEOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Comentario
        '
        Me.Txt_Comentario.Location = New System.Drawing.Point(14, 13)
        Me.Txt_Comentario.Multiline = True
        Me.Txt_Comentario.Name = "Txt_Comentario"
        Me.Txt_Comentario.Size = New System.Drawing.Size(690, 90)
        Me.Txt_Comentario.TabIndex = 0
        '
        'Lbl_Alisto
        '
        Me.Lbl_Alisto.AutoSize = True
        Me.Lbl_Alisto.Location = New System.Drawing.Point(14, 115)
        Me.Lbl_Alisto.Name = "Lbl_Alisto"
        Me.Lbl_Alisto.Size = New System.Drawing.Size(42, 14)
        Me.Lbl_Alisto.TabIndex = 1
        Me.Lbl_Alisto.Text = "Alisto:"
        '
        'Lbl_Chequeo
        '
        Me.Lbl_Chequeo.AutoSize = True
        Me.Lbl_Chequeo.Location = New System.Drawing.Point(367, 115)
        Me.Lbl_Chequeo.Name = "Lbl_Chequeo"
        Me.Lbl_Chequeo.Size = New System.Drawing.Size(55, 14)
        Me.Lbl_Chequeo.TabIndex = 2
        Me.Lbl_Chequeo.Text = "Chequeo:"
        '
        'Cbx_Alisto
        '
        Me.Cbx_Alisto.DataSource = Me.SCRALISTOCHEQUEOBindingSource
        Me.Cbx_Alisto.DisplayMember = "NOMBRE"
        Me.Cbx_Alisto.FormattingEnabled = True
        Me.Cbx_Alisto.Location = New System.Drawing.Point(66, 110)
        Me.Cbx_Alisto.Name = "Cbx_Alisto"
        Me.Cbx_Alisto.Size = New System.Drawing.Size(268, 22)
        Me.Cbx_Alisto.TabIndex = 3
        '
        'Cbx_Chequeo
        '
        Me.Cbx_Chequeo.DataSource = Me.SCRALISTOCHEQUEOBindingSource1
        Me.Cbx_Chequeo.DisplayMember = "NOMBRE"
        Me.Cbx_Chequeo.FormattingEnabled = True
        Me.Cbx_Chequeo.Location = New System.Drawing.Point(436, 112)
        Me.Cbx_Chequeo.Name = "Cbx_Chequeo"
        Me.Cbx_Chequeo.Size = New System.Drawing.Size(268, 22)
        Me.Cbx_Chequeo.TabIndex = 4
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(629, 140)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 5
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'ExactusERP_SRC_TABLES
        '
        Me.ExactusERP_SRC_TABLES.DataSetName = "ExactusERP_SRC_TABLES"
        Me.ExactusERP_SRC_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SCRALISTOCHEQUEOBindingSource
        '
        Me.SCRALISTOCHEQUEOBindingSource.DataMember = "SCR_ALISTO_CHEQUEO"
        Me.SCRALISTOCHEQUEOBindingSource.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'SCR_ALISTO_CHEQUEOTableAdapter
        '
        Me.SCR_ALISTO_CHEQUEOTableAdapter.ClearBeforeFill = True
        '
        'SCRALISTOCHEQUEOBindingSource1
        '
        Me.SCRALISTOCHEQUEOBindingSource1.DataMember = "SCR_ALISTO_CHEQUEO"
        Me.SCRALISTOCHEQUEOBindingSource1.DataSource = Me.ExactusERP_SRC_TABLES
        '
        'Frm_Procesada_Queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 173)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Cbx_Chequeo)
        Me.Controls.Add(Me.Cbx_Alisto)
        Me.Controls.Add(Me.Lbl_Chequeo)
        Me.Controls.Add(Me.Lbl_Alisto)
        Me.Controls.Add(Me.Txt_Comentario)
        Me.Font = New System.Drawing.Font("Square721 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Procesada_Queja"
        Me.Text = "Queja Procesada"
        CType(Me.ExactusERP_SRC_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCRALISTOCHEQUEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
