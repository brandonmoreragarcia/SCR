Public Class NO_Busqueda_cliente
    Private Sub Frm_Busqueda_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_TABLES.CLIENTE)

    End Sub

    'Private Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click
    '    If Rbtn_Nombre.Checked = True Then
    '        CLIENTEBindingSource.Filter = "NOMBRE LIKE '%" & Txt_Dato.Text & "%'"
    '    ElseIf Rbtn_Alias.Checked = True Then
    '        CLIENTEBindingSource.Filter = "ALIAS LIKE '%" & Txt_Dato.Text & "%'"
    '    Else

    '    End If
    'End Sub

    Private Sub Btn_Quitar_Filtro_Click(sender As Object, e As EventArgs) Handles Btn_Quitar_Filtro.Click
        Rbtn_Alias.Checked = False
        Rbtn_Nombre.Checked = False
        CLIENTEBindingSource.Filter = ""
    End Sub

    'Private Sub Btn_Selecionar_Click_1(sender As Object, e As EventArgs) Handles Btn_Selecionar.Click
    '    If T_Busqueda_Cliente = 1 Then
    '        My.Forms.Frm_Entrada.Cbx_Codigo_Cliente.Text = Dgv_Cliente.Item(0, Dgv_Cliente.CurrentRow.Index).Value()
    '        My.Forms.Frm_Entrada.Txt_Cod_Cliente.Text = My.Forms.Frm_Entrada.Cbx_Codigo_Cliente.Text
    '        Me.Close()
    '    ElseIf T_Busqueda_Cliente = 2 Then
    '        My.Forms.Frm_Ingreso_Queja.Txt_Cliente.Text = Dgv_Cliente.Item(0, Dgv_Cliente.CurrentRow.Index).Value()
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub Dgv_Cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Cliente.CellContentClick

    End Sub
End Class