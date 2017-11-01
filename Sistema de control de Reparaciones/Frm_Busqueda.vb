Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Frm_Busqueda
    Public r As SqlDataReader
    Public reparaciones As New DataTable

    Private Sub Btn_Cotejar_Click(sender As Object, e As EventArgs) Handles Btn_Cotejar.Click
        If Txt_Num_Boleta.Text = "" Then
            MsgBox("DEBES INGRESAR UN NUMERO DE BOLETA")
        Else
            reparaciones.Rows.Clear()
            Dim numboleta As String = Txt_Num_Boleta.Text
            Dim comando As New SqlCommand("SELECT REPARACION_NUMERO FROM DBO.SCR_DATOS_REPARACION WHERE DBO.SCR_DATOS_REPARACION.BOLETA ='" & numboleta & "'", cxnc)
            comando.CommandType = CommandType.Text
            cxnc.Open()
            r = comando.ExecuteReader
            While r.Read
                reparaciones.Rows.Add(r.Item("REPARACION_NUMERO"))
            End While
            r.Close()
            cxnc.Close()
            Dgv_Reps_boletas.DataSource = reparaciones
        End If

    End Sub

    Private Sub Txt_Num_Boleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Num_Boleta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Frm_Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reparaciones.Columns.Add("REPARACION")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Reps_boletas.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Serie_Numero.Click

    End Sub

    Private Sub Btn_Coteja_Serie_Click(sender As Object, e As EventArgs) Handles Btn_Coteja_Serie.Click
        If Txt_Serie.Text = "" Then
            MsgBox("DEBES INGRESAR UN NUMERO DE SERIE")
        Else
            reparaciones.Rows.Clear()
            Dim numboleta As String = Txt_Serie.Text
            Dim comando As New SqlCommand("SELECT REPARACION_NUMERO FROM DBO.SCR_DATOS_REPARACION WHERE DBO.SCR_DATOS_REPARACION.SERIE_PRODUCTO ='" & numboleta & "'", cxnc)
            comando.CommandType = CommandType.Text
            cxnc.Open()
            r = comando.ExecuteReader
            While r.Read
                reparaciones.Rows.Add(r.Item("REPARACION_NUMERO"))
            End While
            r.Close()
            cxnc.Close()
            Dgv_Reps_boletas.DataSource = reparaciones
        End If
    End Sub
End Class