Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Transporte
    Dim trans As String
    Private Sub Frm_Mantenimiento_Transporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRANSPORTE)

    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_TRANSPORTE WHERE TRANSPORTE = '" & trans & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        trans = ""
        Me.SCR_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRANSPORTE)
    End Sub

    Private Sub Dgv_Transporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Transporte.CellContentClick
        trans = Dgv_Transporte.Item(0, Dgv_Transporte.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_TRANSPORTE values(@TRANSPORTE)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@TRANSPORTE", SqlDbType.NVarChar).Value = Txt_Transporte.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TRANSPORTE)
            Txt_Transporte.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class