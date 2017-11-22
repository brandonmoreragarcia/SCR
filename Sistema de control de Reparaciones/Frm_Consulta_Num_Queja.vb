Public Class Frm_Consulta_Num_Queja
    Private Sub Frm_Consulta_Num_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_QUEJA_PROCESADA' Puede moverla o quitarla según sea necesario.
        Me.SCR_QUEJA_PROCESADATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_QUEJA_PROCESADA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_SOLUCION_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_SOLUCION_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_SOLUCION_QUEJA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_QUEJA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)

        Dgv_Estados.DataBindings.Clear()
    End Sub

    Private Sub Txt_Num_Queja_TextChanged(sender As Object, e As EventArgs) Handles Txt_Num_Queja.TextChanged
        SCRULTIMOESTADOQUEJABindingSource.Filter = "NUMERO_QUEJA = '" & Txt_Num_Queja.Text & "'"
        SCRESTADOQUEJABindingSource.Filter = "NUMERO_QUEJA = '" & Txt_Num_Queja.Text & "'"
        SCRSOLUCIONQUEJABindingSource.Filter = "NUMERO_QUEJA = '" & Txt_Num_Queja.Text & "'"
        SCRQUEJAPROCESADABindingSource.Filter = "NUMERO_QUEJA = '" & Txt_Num_Queja.Text & "'"
        Lbl_Alias.Visible = True
        Lbl_Alisto.Visible = True
        Lbl_Alisto_P.Visible = True
        Lbl_Alisto_T.Visible = True
        Lbl_Chequeo.Visible = True
        Lbl_Chequeo_P.Visible = True
        Lbl_Cod_Cliente.Visible = True
        Lbl_Comentario_Procesada.Visible = True
        Lbl_Contacto.Visible = True
        Lbl_Detalle.Visible = True
        Lbl_Direccion.Visible = True
        Lbl_Estado_Actual.Visible = True
        Lbl_Factua.Visible = True
        Lbl_Fecha_Estado.Visible = True
        Lbl_Fecha_Ingreso.Visible = True
        Lbl_Fecha_Solucion.Visible = True
        Lbl_Motivo.Visible = True
        Lbl_Nombre.Visible = True
        Lbl_Procesada.Visible = True
        Lbl_Proforma.Visible = True
        Lbl_Solucion.Visible = True
        Lbl_Solucionado_Por.Visible = True
        Lbl_Tel_1.Visible = True
        Lbl_Tel_2.Visible = True
        Lbl_Usuario_Procesada.Visible = True
        Lbl_Usuario_Solucion.Visible = True
        Dgv_Estados.Visible = True
    End Sub

    Private Sub bt_mostrar_todos_datos_Click(sender As Object, e As EventArgs) Handles bt_mostrar_todos_datos.Click
        T_busqueda_Queja = 1
        My.Forms.Frm_Listado_Quejas.MdiParent = Frm_Main_Menu
        Frm_Listado_Quejas.Show()
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

End Class