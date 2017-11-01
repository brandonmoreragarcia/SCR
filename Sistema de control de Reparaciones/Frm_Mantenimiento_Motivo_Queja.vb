Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Motivo_Queja
    Dim tipo_queja As String
    Private Sub Frm_Mantenimiento_Motivo_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_TIPO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA)

    End Sub

    Private Sub Dgv_Tipo_Queja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Tipo_Queja.CellContentClick
        tipo_queja = Dgv_Tipo_Queja.Item(0, Dgv_Tipo_Queja.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_TIPO_QUEJA values(@TIPO_QUEJA)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@TIPO_QUEJA", SqlDbType.NVarChar).Value = Txt_Tipo_Queja.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_TIPO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA)
            Txt_Tipo_Queja.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_TIPO_QUEJA WHERE TIPO_QUEJA = '" & tipo_queja & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        tipo_queja = ""
        Me.SCR_TIPO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA)
    End Sub
End Class