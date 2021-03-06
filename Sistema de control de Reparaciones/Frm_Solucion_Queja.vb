﻿Imports System.Data.SqlClient
Public Class Frm_Solucion_Queja
    Private Sub Frm_Solucion_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ALISTO_CHEQUEO' Puede moverla o quitarla según sea necesario.
        Me.SCR_ALISTO_CHEQUEOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ALISTO_CHEQUEO)

        Cbx_Alisto.SelectedItem = Cbx_Alisto.Items.Item(0)
        Cbx_Chequeo.SelectedItem = Cbx_Chequeo.Items.Item(0)

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        Try
            If Txt_Solucion.Text IsNot "" Then

                Dim sql As String = "insert into dbo.SCR_SOLUCION_QUEJA values(@NUMERO_QUEJA,@SOLUCION,@USUARIO,@FECHA_HORA,@ALISTO,@CHEQUEO)"
                Dim cmd As New SqlCommand(sql, cxnc)
                Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
                Dim cmd2 As New SqlCommand(sql2, cxnc)

                cmd.Parameters.Add("@NUMERO_QUEJA", SqlDbType.NVarChar).Value = Num_Queja
                cmd.Parameters.Add("@SOLUCION", SqlDbType.NVarChar).Value = Txt_Solucion.Text
                cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                cmd.Parameters.Add("@FECHA_HORA", SqlDbType.DateTime).Value = Date.Now
                cmd.Parameters.Add("@ALISTO", SqlDbType.NVarChar).Value = Cbx_Alisto.Text
                cmd.Parameters.Add("@CHEQUEO", SqlDbType.NVarChar).Value = Cbx_Chequeo.Text
                cxnc.Open()
                cmd.ExecuteNonQuery()
                cxnc.Close()
                cmd2.Parameters.Add("@NUMERO_QUEJA", SqlDbType.NVarChar).Value = Num_Queja
                cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "SOLUCIONADO"
                cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
                cxnc.Open()
                cmd2.ExecuteNonQuery()
                cxnc.Close()
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                My.Forms.Frm_Consulta_Queja.Rbtn_Solucionar.Checked = False
                My.Forms.Frm_Consulta_Queja.Rbtn_Procesar.Checked = False
                My.Forms.Frm_Consulta_Queja.Lbl_Alias.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Cod_Cliente.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Contacto.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Detalle.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Direccion.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Estado_Actual.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Factua.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Fecha_Estado.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Fecha_Ingreso.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Motivo.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Nombre.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Proforma.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Telefonos.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Tel_1.Visible = False
                My.Forms.Frm_Consulta_Queja.Lbl_Tel_2.Visible = False
                My.Forms.Frm_Consulta_Queja.Rbtn_Procesar.Visible = False
                My.Forms.Frm_Consulta_Queja.Rbtn_Solucionar.Visible = False
                My.Forms.Frm_Consulta_Queja.Txt_Num_Queja.Text = ""
                Me.Close()

            Else
                Throw New MyException("Error, el espacio 'Solución' no puede ir en blanco")
            End If


        Catch ex As MyException
            MsgBox(ex.Message)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Frm_Solucion_Queja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Forms.Frm_Consulta_Queja.Enabled = True
        My.Forms.Frm_Consulta_Queja.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Frm_Consulta_Queja.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class