Imports System.Data.SqlClient
Public Class Frm_Solucion_Queja
    Private Sub Frm_Solucion_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ALISTO_CHEQUEO' Puede moverla o quitarla según sea necesario.
        Me.SCR_ALISTO_CHEQUEOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ALISTO_CHEQUEO)
        Cbx_Alisto.Text = ""
        Cbx_Chequeo.Text = ""
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim sql As String = "insert into dbo.SCR_SOLUCION_QUEJA values(@NUMERO_QUEJA,@SOLUCION,@USUARIO,@FECHA_HORA,@ALISTO,@CHEQUEO)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
        Dim cmd2 As New SqlCommand(sql2, cxnc)
        Try
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
            My.Forms.Frm_Consulta_Queja.Lbl_Fax.Visible = False
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
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class