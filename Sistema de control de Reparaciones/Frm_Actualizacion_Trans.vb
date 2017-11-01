Imports System.Data.SqlClient
Public Class Frm_Actualizacion_Trans
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Frm_Actualizacion_Trans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_TABLES.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERP_TABLES.ARTICULO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION' Puede moverla o quitarla según sea necesario.
        Me.SCR_DATOS_REPARACIONTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION)
        Cbx_Boleta.Text = Num_Boleta
        Cbx_dummy1.Text = Lbl_Cliente.Text
        Cbx_Dummy2.Text = Lbl_Articulo.Text
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Frm_Actualizacion_Trans_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Forms.Frm_Main_Menu.Btn_Transporte.Enabled = True
    End Sub

    Private Sub Btn_Grabar_Actua_Click(sender As Object, e As EventArgs) Handles Btn_Grabar_Actua.Click
        ACTUA()
    End Sub

    Private Sub Cbx_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Estado.SelectedIndexChanged
        Cbx_Localizacion.Enabled = True
    End Sub

    Private Sub Cbx_Localizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Localizacion.SelectedIndexChanged
        Txt_Comentario.Enabled = True
    End Sub
    Private Sub ACTUA()
        Dim sql As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Dim sql2 As String = "insert into SCR_ACTUALIZACION_RUTA values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
        Dim cmd2 As New SqlCommand(sql2, cxnc)
        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
            cmd.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.Lbl_Cliente.Text
            cmd.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = Txt_Comentario.Text
            cmd.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = Cbx_Estado.Text
            cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
            cmd.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = Cbx_Localizacion.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
            cxnc.Open()
            cmd.ExecuteNonQuery()
            cxnc.Close()
            cmd2.CommandType = CommandType.Text
            cmd2.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
            cmd2.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.Lbl_Cliente.Text
            cmd2.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = Txt_Comentario.Text
            cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = Cbx_Estado.Text
            cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
            cmd2.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = Cbx_Localizacion.Text
            cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
            cxnc.Open()
            cmd2.ExecuteNonQuery()
            cxnc.Close()
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
            Txt_Comentario.Text = ""
            Cbx_Localizacion.Enabled = False
            Txt_Comentario.Enabled = False
            Btn_Grabar_Actua.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Cbx_Estado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Estado.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Localizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Localizacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txt_Comentario_TextChanged(sender As Object, e As EventArgs) Handles Txt_Comentario.TextChanged
        Btn_Grabar_Actua.Enabled = True
        Btn_Grabar_Actua.Visible = True
    End Sub
End Class