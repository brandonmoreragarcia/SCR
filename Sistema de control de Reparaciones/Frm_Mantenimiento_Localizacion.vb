﻿Imports System.Data.SqlClient
Public Class Frm_Mantenimiento_Localizacion
    Dim localizacion As String
    Private Sub Frm_Mantenimiento_Localizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_REPTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP)

    End Sub

    Private Sub Dgv_Localizacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Localizacion.CellContentClick
        localizacion = Dgv_Localizacion.Item(0, Dgv_Localizacion.CurrentRow.Index).Value()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim sql1 As String = "insert into dbo.SCR_LOCALIZACION_REP values(@LOCALIZACION)"
        Dim cmd1 As New SqlCommand(sql1, cxnc)
        Try
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = Txt_Localizacion.Text
            cxnc.Open()
            cmd1.ExecuteNonQuery()
            cxnc.Close()
            Me.SCR_LOCALIZACION_REPTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP)
            Txt_Localizacion.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim cmd = New SqlCommand("DELETE FROM dbo.SCR_LOCALIZACION_REP WHERE LOCALIZACION = '" & localizacion & "'", cxnc)
        cmd.CommandType = CommandType.Text
        cxnc.Open()
        cmd.ExecuteScalar()
        cxnc.Close()
        localizacion = ""
        Me.SCR_LOCALIZACION_REPTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP)
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class