Imports System.Data.SqlClient

Public Class NO_Detalle_Reparacion
    Private Sub Frm_Detalle_Reparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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
End Class