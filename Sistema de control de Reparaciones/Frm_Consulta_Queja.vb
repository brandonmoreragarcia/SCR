Imports System.Data.SqlClient
Public Class Frm_Consulta_Queja
    Private Sub Frm_Consulta_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)

    End Sub

    Private Sub Txt_Num_Queja_TextChanged(sender As Object, e As EventArgs) Handles Txt_Num_Queja.TextChanged
        Num_Queja = Txt_Num_Queja.Text
        SCRULTIMOESTADOQUEJABindingSource.Filter = "NUMERO_QUEJA = '" & Num_Queja & "'"
        Lbl_Alias.Visible = True
        Lbl_Cod_Cliente.Visible = True
        Lbl_Contacto.Visible = True
        Lbl_Detalle.Visible = True
        Lbl_Direccion.Visible = True
        Lbl_Estado_Actual.Visible = True
        Lbl_Factua.Visible = True
        Lbl_Fax.Visible = True
        Lbl_Fecha_Estado.Visible = True
        Lbl_Fecha_Ingreso.Visible = True
        Lbl_Motivo.Visible = True
        Lbl_Nombre.Visible = True
        Lbl_Proforma.Visible = True
        Lbl_Telefonos.Visible = True
        Lbl_Tel_1.Visible = True
        Lbl_Tel_2.Visible = True
        Rbtn_Procesar.Visible = True
        Rbtn_Solucionar.Visible = True
        Rbt_Procesada.Visible = True
    End Sub

    Private Sub Rbtn_Procesar_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Procesar.CheckedChanged
        If Rbtn_Procesar.Checked = True Then
            Btn_Procesar.Visible = True
            Btn_Solucionar.Visible = False
            bt_guardar.Visible = False
        End If
    End Sub

    Private Sub Rbtn_Solucionar_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Solucionar.CheckedChanged
        If Rbtn_Solucionar.Checked = True Then
            Btn_Procesar.Visible = False
            Btn_Solucionar.Visible = True
            bt_guardar.Visible = False
        End If
    End Sub

    Private Sub Btn_Procesar_Click(sender As Object, e As EventArgs) Handles Btn_Procesar.Click
        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
            Dim numboleta As String = Txt_Num_Queja.Text
            Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
            cmd3.CommandType = CommandType.Text
            Dim n As Date
            n = CDate(cmd3.ExecuteScalar())
            MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue Solucionada desde el  " + n + " No admite cambios de Estado")
        Else
            If Queja_Procesada(Txt_Num_Queja.Text) = True Then
                Dim numboleta As String = Txt_Num_Queja.Text
                Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
                cmd3.CommandType = CommandType.Text
                Dim n As Date
                n = CDate(cmd3.ExecuteScalar())
                MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue procesada desde el  " + n + " Seleccione un estado Diferente")
            Else
                If Queja_Proces(Txt_Num_Queja.Text) = True Then
                    Dim numboleta As String = Txt_Num_Queja.Text
                    Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCES WHERE DBO.SCR_QUEJAS_PROCES.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
                    cmd3.CommandType = CommandType.Text
                    Dim n As Date
                    n = CDate(cmd3.ExecuteScalar())
                    MsgBox("La Queja: " + Txt_Num_Queja.Text + " Se encuentra en proceso desde el  " + n + " Seleccione un estado Diferente")
                Else
                    Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
                    Dim cmd2 As New SqlCommand(sql2, cxnc)
                    Try
                        cmd2.Parameters.Add("@NUMERO_QUEJA", SqlDbType.NVarChar).Value = Me.Txt_Num_Queja.Text
                        cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "PROCESANDO"
                        cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                        cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
                        cmd2.ExecuteNonQuery()
                        MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Solucionar_Click(sender As Object, e As EventArgs) Handles Btn_Solucionar.Click
        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
            Dim numboleta As String = Txt_Num_Queja.Text
            Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
            cmd3.CommandType = CommandType.Text
            Dim n As Date
            n = CDate(cmd3.ExecuteScalar())
            MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue Solucionada desde el  " + n + " No admite cambios de Estado")
        Else
            My.Forms.Frm_Solucion_Queja.MdiParent = Frm_Main_Menu
            Frm_Solucion_Queja.Show()
        End If
    End Sub

    Private Sub Txt_Num_Queja_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt_Num_Queja.MouseClick
        My.Forms.Frm_Listado_Quejas.Btn_Selec_Queja.Visible = True
        My.Forms.Frm_Listado_Quejas.MdiParent = Frm_Main_Menu
        T_busqueda_Queja = 2
        Frm_Listado_Quejas.Show()
        Dim estado As String = "SOLUCIONADO"
        My.Forms.Frm_Listado_Quejas.SCRULTIMOESTADOQUEJABindingSource.Filter = "ESTADO <> '" & estado & "'"
    End Sub

    Private Sub Rbt_Procesada_CheckedChanged(sender As Object, e As EventArgs) Handles Rbt_Procesada.CheckedChanged
        If Rbt_Procesada.Checked = True Then
            Btn_Procesar.Visible = False
            Btn_Solucionar.Visible = False
            bt_guardar.Visible = True
        End If
    End Sub

    Private Sub Btn_Procesada_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
            Dim numboleta As String = Txt_Num_Queja.Text
            Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
            cmd3.CommandType = CommandType.Text
            Dim n As Date
            n = CDate(cmd3.ExecuteScalar())
            MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue Solucionada desde el  " + n + " No admite cambios de Estado")
        Else
            If Queja_Procesada(Txt_Num_Queja.Text) = True Then
                Dim numboleta As String = Txt_Num_Queja.Text
                Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
                cmd3.CommandType = CommandType.Text
                Dim n As Date
                n = CDate(cmd3.ExecuteScalar())
                MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue procesada desde el  " + n + " Seleccione un estado Diferente")
            Else
                My.Forms.Frm_Procesada_Queja.MdiParent = Frm_Main_Menu
                Frm_Procesada_Queja.Show()
            End If
        End If
    End Sub

    Private Sub Txt_Num_Queja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Num_Queja.KeyPress
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class