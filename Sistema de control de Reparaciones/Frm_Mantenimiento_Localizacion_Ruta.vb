Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Localizacion_Ruta
    Private Sub Frm_Mantenimiento_Localizacion_Ruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)

    End Sub
    Dim localizacion_R As String
    Private Sub Dgv_Localizacion_Ruta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Localizacion_Ruta.CellContentClick
        localizacion_R = Dgv_Localizacion_Ruta.Item(0, Dgv_Localizacion_Ruta.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_LOCALIZACION_TRANS values(@LOCALIZACION)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = Txt_Mantenimiento_R.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)
            Txt_Mantenimiento_R.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_LOCALIZACION_TRANS WHERE LOCALIZACION = '" & localizacion_R & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        localizacion_R = ""
        Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)
    End Sub


    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class