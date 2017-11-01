Imports System.Data.SqlClient
Public Class Frm_Consulta_Reparacion
    Private Sub Frm_Consulta_Reparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERP_TABLES.ARTICULO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_TABLES.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION' Puede moverla o quitarla según sea necesario.
        Me.SCR_DATOS_REPARACIONTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION)
        Cbx_Boleta.Text = Num_Boleta
        Cbx_dummy1.Text = Lbl_Cliente.Text
        Cbx_Dummy2.Text = Lbl_Articulo.Text

        Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
            command As New SqlCommand("SCR_CONSULTA_REPARACION", connection),
            adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure

            'Add parameters, e.g.
            command.Parameters.AddWithValue("@CONSULTAREP", Num_Boleta)

            Dim table As New DataTable

            'Get the data.
            adapter.Fill(table)

            'Display the data.
            Me.Dgv_Actualizaciones.DataSource = table
        End Using
    End Sub

    Private Sub Dgv_Actualizaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Actualizaciones.CellClick
        Lbl_Numero_Actua.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(1).Value()
        Lbl_Estado.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(4).Value()
        Lbl_Usuario.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(5).Value()
        Lbl_Localizacion.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(6).Value()
        Lbl_Fecha.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(7).Value()
        Txt_Comentario.Text = Dgv_Actualizaciones.Rows(e.RowIndex).Cells(3).Value()
    End Sub

    Private Sub Dgv_Actualizaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Actualizaciones.CellContentClick

    End Sub
End Class