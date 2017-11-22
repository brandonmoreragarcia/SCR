Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Estado_Ruta
    Dim estado_r As String
    Private Sub Frm_Mantenimiento_Estado_Ruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)

    End Sub

    Private Sub Dgv_Estado_R_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Estado_R.CellContentClick
        estado_r = Dgv_Estado_R.Item(0, Dgv_Estado_R.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_ESTADO_TRANSPORTE values(@ESTADO)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = Txt_Estado_R.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)
            Txt_Estado_R.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_ESTADO_TRANSPORTE WHERE ESTADO = '" & estado_r & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        estado_r = ""
        Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)
    End Sub



    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class