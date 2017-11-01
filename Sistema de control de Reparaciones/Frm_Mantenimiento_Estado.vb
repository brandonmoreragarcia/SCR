Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Estado
    Dim estado As String
    Private Sub Frm_Mantenimiento_Estado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_ACTUATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA)

    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_ESTADO_ACTUA values(@ESTADO)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = Txt_Estado.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_ESTADO_ACTUATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA)
            Txt_Estado.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_ESTADO_ACTUA WHERE ESTADO = '" & estado & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        estado = ""
        Me.SCR_ESTADO_ACTUATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA)
    End Sub

    Private Sub Dgv_Estado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Estado.CellContentClick
        estado = Dgv_Estado.Item(0, Dgv_Estado.CurrentRow.Index).Value()
    End Sub
End Class