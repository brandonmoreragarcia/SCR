Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Encargado_Bodega
    Dim encargado_b As String
    Private Sub Frm_Mantenimiento_Encargado_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ENCARGADO_BODEGATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA)

    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_ENCARGADO_BODEGA values(@ENCARGADO)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@ENCARGADO", SqlDbType.NVarChar).Value = Txt_Encargado_B.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_ENCARGADO_BODEGATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA)
            Txt_Encargado_B.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_ENCARGADO_BODEGA WHERE ENCARGADO = '" & encargado_b & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        encargado_b = ""
        Me.SCR_ENCARGADO_BODEGATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA)
    End Sub

    Private Sub Dgv_Encargado_B_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Encargado_B.CellContentClick
        encargado_b = Dgv_Encargado_B.Item(0, Dgv_Encargado_B.CurrentRow.Index).Value()
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class