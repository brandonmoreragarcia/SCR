Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Traido_Por
    Dim traido_por As String
    Private Sub Frm_Mantenimiento_Traido_Por_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_TRAIDO_POR' Puede moverla o quitarla según sea necesario.
        Me.SCR_TRAIDO_PORTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRAIDO_POR)

    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_TRAIDO_POR WHERE traido_por = '" & traido_por & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        traido_por = ""
        Me.SCR_TRAIDO_PORTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRAIDO_POR)
    End Sub

    Private Sub Dgv_Traido_Por_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Traido_Por.CellContentClick
        traido_por = Dgv_Traido_Por.Item(0, Dgv_Traido_Por.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_TRAIDO_POR values(@traido_por)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@traido_por", SqlDbType.NVarChar).Value = Txt_Traido_Por.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_TRAIDO_PORTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRAIDO_POR)
            Txt_Traido_Por.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class