Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Motivo

    Dim motivo As String
    Private Sub Frm_Mantenimiento_Motivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_MOTIVO' Puede moverla o quitarla según sea necesario.
        Me.SCR_MOTIVOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_MOTIVO)

    End Sub

    Private Sub Dgv_Motivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Motivo.CellContentClick
        motivo = Dgv_Motivo.Item(0, Dgv_Motivo.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_MOTIVO WHERE MOTIVO = '" & motivo & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        motivo = ""
        Me.SCR_MOTIVOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_MOTIVO)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_MOTIVO values(@MOTIVO)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = Txt_Motivo.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_MOTIVOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_MOTIVO)
            Txt_Motivo.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class