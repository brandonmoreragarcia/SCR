Public Class Frm_Busqueda_Articulo
    Private Sub ARTICULOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ARTICULOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ExactusERP_TABLES)

    End Sub

    Private Sub Frm_Busqueda_Articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERP_TABLES.ARTICULO)

    End Sub

    Private Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click
        ARTICULOBindingSource.Filter = "DESCRIPCION LIKE '%" & Txt_Dato.Text & "%'"
    End Sub

    Private Sub Btn_Quitar_Filtros_Click(sender As Object, e As EventArgs) Handles Btn_Quitar_Filtros.Click
        ARTICULOBindingSource.Filter = ""
    End Sub
End Class