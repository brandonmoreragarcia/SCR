Imports System.Data.SqlClient
Public Class Frm_Actualizacion_Rep
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim Garantia As String
    Dim facturada As String
    Dim garancheck As Boolean = False
    Dim faccheck As Boolean = False
    Private Sub Frm_Actualizacion_Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ENCARGADO_BODEGATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ENCARGADO_BODEGA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_REPS_PENDIENTES' Puede moverla o quitarla según sea necesario.
        Me.SCR_REPS_PENDIENTESTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_REPS_PENDIENTES)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_REPTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_REP)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_ACTUATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_ACTUA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        dg_reparaciones.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 8, Font.Style.Bold)
        Btn_Grabar_Actua.Enabled = True
        Cbx_Localizacion.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Frm_Actualizacion_Boleta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Forms.Frm_Main_Menu.Btn_Reparaciones.Enabled = True
    End Sub

    Private Sub Cbx_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Estado.SelectedIndexChanged
        If Cbx_Estado.Text = "REPARADA" Then
            Gbx_Garantia.Visible = True
            Gbx_Facturada.Visible = True
            Lbl_Tiempo_Rep.Visible = True
            Txt_Tiempo_Inver.Visible = True
            Lbl_Adicional.Visible = True
            Txt_Adicional.Visible = True

        Else
            Gbx_Garantia.Visible = False
            Gbx_Facturada.Visible = False
            Lbl_Tiempo_Rep.Visible = False
            Txt_Tiempo_Inver.Visible = False
            Txt_Tiempo_Inver.Text = ""
            Rbtn_Factu_No.Checked = False
            Rbtn_Factu_Si.Checked = False
            Rbtn_Garan_No.Checked = False
            Rbtn_Garan_Si.Checked = False
            Lbl_Factura_Num.Visible = False
            Txt_Factura_Num.Visible = False
            Txt_Factura_Num.Text = ""
            garancheck = False
            faccheck = False
            Lbl_Adicional.Visible = False
            Txt_Adicional.Visible = False

        End If
        Cbx_Localizacion.Enabled = True
        Txt_Adicional.Enabled = False
        Txt_Adicional.Text = ""
        Txt_Comentario.Text = ""
    End Sub

    Private Sub Cbx_Localizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Localizacion.SelectedIndexChanged
        Txt_Comentario.Enabled = True
    End Sub

    Private Sub Btn_Grabar_Actua_Click(sender As Object, e As EventArgs) Handles Btn_Grabar_Actua.Click

        Dim answer As DialogResult = MessageBox.Show("Seguro que desear guardar los cambios?" + vbLf + "", "Aviso", MessageBoxButtons.YesNo)
        If (answer = DialogResult.Yes) Then
            Try
                If Txt_Comentario.Text IsNot "" Then
                    If Cbx_Estado.Text = "REPARADA" Then
                        If estado_rep(Num_Boleta) = False Then
                            Try
                                If garancheck = False And faccheck = False Then
                                    MessageBox.Show("HA SELECCIONADO EL ESTADO REPARADA, DEBE SELECCIONAR SI O NO EN LOS CAMPOS GARANTIA Y FACTURADA")
                                ElseIf garancheck = True And faccheck = False Then
                                    MessageBox.Show("HA SELECCIONADO EL ESTADO REPARADA, DEBE SELECCIONAR SI O NO EN EL CAMPO FACTURADA")
                                ElseIf garancheck = False And faccheck = True Then
                                    MessageBox.Show("HA SELECCIONADO EL ESTADO REPARADA, DEBE SELECCIONAR SI O NO EN EL CAMPO GARANTIA")
                                Else
                                    If facturada = "NO" Then
                                        If Txt_Tiempo_Inver.Text = "" Then
                                            MessageBox.Show("DEBE INGRESAR LA HORAS INVERTIDAS EN LA REPARACION")
                                        Else
                                            'ACTUAREP()
                                            ACTUA()
                                            ACTUAREP_2()
                                            ACTUAREP_3()
                                            ACTUAREP_LIMPIAR()
                                        End If
                                    Else
                                        If Txt_Factura_Num.Text = "" And Txt_Factura_Num.Visible = True Then
                                            MessageBox.Show("HA SELECCIONADO FACURADADO COMO SI. DEBE INGRESAR EL NUMERO DE FACTURA")
                                        Else
                                            If Txt_Tiempo_Inver.Text = "" Then
                                                MessageBox.Show("DEBE INGRESAR LA HORAS INVERTIDAS EN LA REPARACION")
                                            Else
                                                ACTUAREP()
                                            End If
                                        End If
                                    End If
                                End If
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Else
                            MsgBox("La Reparacion: " + Cbx_Boleta.Text + " Ya tiene ingresado el estado REPARADA")

                        End If
                    Else
                        If rep_cerrada(Cbx_Boleta.Text) = True Then
                            MsgBox("La Reparacion: " + Cbx_Boleta.Text + " Ya ha sido cerrada por tanto no acepta mas actualizaciones, debe comunicarse con un administrador para quitar el bloqueo")
                        Else
                            ACTUA()
                            ACTUA_LIMPIAR()
                        End If
                    End If
                Else
                    Throw New MyException("Error, el espacio COMENTARIO no debe ir vacío")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Rbtn_Factu_Si_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Factu_Si.CheckedChanged
        Lbl_Factura_Num.Visible = True
        Txt_Factura_Num.Visible = True
        facturada = "SI"
        faccheck = True
    End Sub

    Private Sub Rbtn_Factu_No_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Factu_No.CheckedChanged
        Lbl_Factura_Num.Visible = False
        Txt_Factura_Num.Visible = False
        Txt_Factura_Num.Text = ""
        facturada = "NO"
        faccheck = True
    End Sub

    Private Sub Txt_Comentario_TextChanged(sender As Object, e As EventArgs) Handles Txt_Comentario.TextChanged
        If Cbx_Estado.Text = "REPARADA" Then
            Txt_Adicional.Enabled = True
        Else
            Btn_Grabar_Actua.Visible = True
            Btn_Grabar_Actua.Enabled = True
        End If
    End Sub

    Private Sub Rbtn_Garan_Si_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Garan_Si.CheckedChanged
        Garantia = "SI"
        garancheck = True
    End Sub

    Private Sub Rbtn_Garan_No_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Garan_No.CheckedChanged
        Garantia = "NO"
        garancheck = True
    End Sub

    Private Sub ACTUA()
        Dim sql As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)
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
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ACTUA_LIMPIAR()
        Txt_Comentario.Text = ""
        Cbx_Localizacion.Enabled = False
        Txt_Comentario.Enabled = False
    End Sub
    Private Sub ACTUAREP_1()
        Dim sql As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)
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
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ACTUAREP_2()
        Dim sql2 As String = "insert into SCR_ACTUALIZACION_REPARADA values(@NUMERO_REPARACION,@GARANTIA,@FACTURADA,@FACTURA,@TIEMPO_REP)"
        Dim cmd2 As New SqlCommand(sql2, cxnc)
        Try
            cmd2.CommandType = CommandType.Text
            cmd2.Parameters.Add("@NUMERO_REPARACION", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
            cmd2.Parameters.Add("@GARANTIA", SqlDbType.NVarChar).Value = Garantia
            cmd2.Parameters.Add("@FACTURADA", SqlDbType.NVarChar).Value = facturada
            cmd2.Parameters.Add("@FACTURA", SqlDbType.NVarChar).Value = Txt_Factura_Num.Text
            cmd2.Parameters.Add("@TIEMPO_REP", SqlDbType.NVarChar).Value = Txt_Tiempo_Inver.Text
            cxnc.Open()
            cmd2.ExecuteNonQuery()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ACTUAREP_3()
        Dim sql3 As String = "insert into SCR_ADICIONAL_REP values(@ADICIONAL,@REPARACION_NUMERO,@USUARIO,@FECHA)"
        Dim cmd3 As New SqlCommand(sql3, cxnc)
        Try
            cmd3.CommandType = CommandType.Text
            cmd3.Parameters.Add("@ADICIONAL", SqlDbType.NVarChar).Value = Txt_Adicional.Text
            cmd3.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
            cmd3.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
            cmd3.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
            cxnc.Open()
            cmd3.ExecuteNonQuery()
            cxnc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ACTUAREP_LIMPIAR()
        Try
            Txt_Comentario.Text = ""
            Cbx_Localizacion.Enabled = False
            Txt_Comentario.Enabled = False
            Gbx_Garantia.Visible = False
            Gbx_Facturada.Visible = False
            Lbl_Tiempo_Rep.Visible = False
            Txt_Tiempo_Inver.Visible = False
            Txt_Tiempo_Inver.Text = ""
            Rbtn_Factu_No.Checked = False
            Rbtn_Factu_Si.Checked = False
            Rbtn_Garan_No.Checked = False
            Rbtn_Garan_Si.Checked = False
            Lbl_Factura_Num.Visible = False
            Txt_Factura_Num.Visible = False
            Txt_Factura_Num.Text = ""
            garancheck = False
            faccheck = False
            Lbl_Adicional.Visible = False
            Txt_Adicional.Visible = False
            Txt_Adicional.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ACTUAREP()
        Dim sql As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Dim sql2 As String = "insert into SCR_ACTUALIZACION_REPARADA values(@NUMERO_REPARACION,@GARANTIA,@FACTURADA,@FACTURA,@TIEMPO_REP)"
        Dim cmd2 As New SqlCommand(sql2, cxnc)
        Dim sql3 As String = "insert into SCR_ADICIONAL_REP values(@ADICIONAL,@REPARACION_NUMERO,@USUARIO,@FECHA)"
        Dim cmd3 As New SqlCommand(sql3, cxnc)
        If factu_exist(Txt_Factura_Num.Text) = True Then
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
                cmd2.Parameters.Add("@NUMERO_REPARACION", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                cmd2.Parameters.Add("@GARANTIA", SqlDbType.NVarChar).Value = Garantia
                cmd2.Parameters.Add("@FACTURADA", SqlDbType.NVarChar).Value = facturada
                cmd2.Parameters.Add("@FACTURA", SqlDbType.NVarChar).Value = Txt_Factura_Num.Text
                cmd2.Parameters.Add("@TIEMPO_REP", SqlDbType.NVarChar).Value = Txt_Tiempo_Inver.Text
                cxnc.Open()
                cmd2.ExecuteNonQuery()
                cxnc.Close()
                cmd3.CommandType = CommandType.Text
                cmd3.Parameters.Add("@ADICIONAL", SqlDbType.NVarChar).Value = Txt_Adicional.Text
                cmd3.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                cmd3.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                cmd3.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                cxnc.Open()
                cmd3.ExecuteNonQuery()
                cxnc.Close()
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Txt_Comentario.Text = ""
                Cbx_Localizacion.Enabled = False
                Txt_Comentario.Enabled = False
                Gbx_Garantia.Visible = False
                Gbx_Facturada.Visible = False
                Lbl_Tiempo_Rep.Visible = False
                Txt_Tiempo_Inver.Visible = False
                Txt_Tiempo_Inver.Text = ""
                Rbtn_Factu_No.Checked = False
                Rbtn_Factu_Si.Checked = False
                Rbtn_Garan_No.Checked = False
                Rbtn_Garan_Si.Checked = False
                Lbl_Factura_Num.Visible = False
                Txt_Factura_Num.Visible = False
                Txt_Factura_Num.Text = ""
                garancheck = False
                faccheck = False
                Lbl_Adicional.Visible = False
                Txt_Adicional.Visible = False
                Txt_Adicional.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            If factu_exist2(Txt_Factura_Num.Text) = True Then
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
                    cmd2.Parameters.Add("@NUMERO_REPARACION", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                    cmd2.Parameters.Add("@GARANTIA", SqlDbType.NVarChar).Value = Garantia
                    cmd2.Parameters.Add("@FACTURADA", SqlDbType.NVarChar).Value = facturada
                    cmd2.Parameters.Add("@FACTURA", SqlDbType.NVarChar).Value = Txt_Factura_Num.Text
                    cmd2.Parameters.Add("@TIEMPO_REP", SqlDbType.NVarChar).Value = Txt_Tiempo_Inver.Text
                    cxnc.Open()
                    cmd2.ExecuteNonQuery()
                    cxnc.Close()
                    cmd3.CommandType = CommandType.Text
                    cmd3.Parameters.Add("@ADICIONAL", SqlDbType.NVarChar).Value = Txt_Adicional.Text
                    cmd3.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                    cmd3.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                    cmd3.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                    cxnc.Open()
                    cmd3.ExecuteNonQuery()
                    cxnc.Close()
                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                    Txt_Comentario.Text = ""
                    Cbx_Localizacion.Enabled = False
                    Txt_Comentario.Enabled = False
                    Gbx_Garantia.Visible = False
                    Gbx_Facturada.Visible = False
                    Lbl_Tiempo_Rep.Visible = False
                    Txt_Tiempo_Inver.Visible = False
                    Txt_Tiempo_Inver.Text = ""
                    Rbtn_Factu_No.Checked = False
                    Rbtn_Factu_Si.Checked = False
                    Rbtn_Garan_No.Checked = False
                    Rbtn_Garan_Si.Checked = False
                    Lbl_Factura_Num.Visible = False
                    Txt_Factura_Num.Visible = False
                    Txt_Factura_Num.Text = ""
                    garancheck = False
                    faccheck = False
                    Lbl_Adicional.Visible = False
                    Txt_Adicional.Visible = False
                    Txt_Adicional.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("La factura: " + Txt_Factura_Num.Text + " No existe, Ingrese una factura valida")
            End If
        End If
    End Sub


    Private Sub Txt_Factura_Num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Factura_Num.KeyPress
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

    Private Sub Txt_Tiempo_Inver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Tiempo_Inver.KeyPress
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

    Private Sub Cbx_Estado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Estado.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Localizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Localizacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub bt_cerrado_rapido_Click(sender As Object, e As EventArgs) Handles bt_cerrado_rapido.Click

        Dim answer As DialogResult = MessageBox.Show("Seguro que desear cerrar la opción seleccionada?" + vbLf + "", "Aviso", MessageBoxButtons.YesNo)
        If (answer = DialogResult.Yes) Then

            Dim sql As String = "UPDATE SCR_ACTUALIZACION_REP SET ESTADO = 'CERRADA' WHERE REPARACION_NUMERO = @REPARACION_NUMERO"
            Dim cmd As New SqlCommand(sql, cxnc)
            Try
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value()
                cxnc.Open()
                cmd.ExecuteNonQuery()
                cxnc.Close()
                MessageBox.Show("Reparación Cerrada Exitosamente!")
                Me.SCR_REPS_PENDIENTESTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_REPS_PENDIENTES)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ch_ver_informacion_CheckedChanged(sender As Object, e As EventArgs) Handles ch_ver_informacion.CheckedChanged

        If dg_reparaciones.SelectedCells IsNot Nothing Then
            If ch_ver_informacion.Checked = True Then

                Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
            command As New SqlCommand("SCR_CONSULTA_REPARACION", connection),
            adapter As New SqlDataAdapter(command)
                    command.CommandType = CommandType.StoredProcedure

                    'Add parameters, e.g.
                    command.Parameters.AddWithValue("@CONSULTAREP", dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value())

                    Dim table As New DataTable

                    'Get the data.
                    adapter.Fill(table)

                    'Display the data.
                    Me.dg_detalle_rep.DataSource = table
                End Using

                gb_ingresar_info_reparacion.Visible = False
                gb__ingresar_info_transporte.Visible = False
                gb_detalle_reparacion.Visible = True

                Num_Boleta = dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value()

            Else
                gb_detalle_reparacion.Visible = False
                gb_ingresar_info_reparacion.Visible = True
            End If
        End If
    End Sub

    Private Sub Cbx_Boleta_TextChanged(sender As Object, e As EventArgs) Handles Cbx_Boleta.TextChanged

        If ch_ver_informacion.Checked Or ch_ver_informacion_transporte.Checked Then
            Try
                Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
            command As New SqlCommand("SCR_CONSULTA_REPARACION", connection),
            adapter As New SqlDataAdapter(command)
                    command.CommandType = CommandType.StoredProcedure

                    'Add parameters, e.g.
                    command.Parameters.AddWithValue("@CONSULTAREP", dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value())

                    Dim table As New DataTable

                    'Get the data.
                    adapter.Fill(table)

                    'Display the data.
                    Me.dg_detalle_rep.DataSource = table
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub bt_guardar_transporte_Click(sender As Object, e As EventArgs) Handles bt_guardar_transporte.Click
        Dim answer As DialogResult = MessageBox.Show("Seguro que desear guardar los cambios?" + vbLf + "", "Aviso", MessageBoxButtons.YesNo)
        If (answer = DialogResult.Yes) Then
            Try
                If txt_comentario_transporte.Text IsNot "" Then
                    Dim sql As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
                    Dim cmd As New SqlCommand(sql, cxnc)
                    Dim sql2 As String = "insert into SCR_ACTUALIZACION_RUTA values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
                    Dim cmd2 As New SqlCommand(sql2, cxnc)

                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                    cmd.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.Lbl_Cliente.Text
                    cmd.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = txt_comentario_transporte.Text
                    cmd.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = cbx_estado_transporte.Text
                    cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                    cmd.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = cbx_localizacion_transporte.Text
                    cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                    cxnc.Open()
                    cmd.ExecuteNonQuery()
                    cxnc.Close()
                    cmd2.CommandType = CommandType.Text
                    cmd2.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Cbx_Boleta.Text
                    cmd2.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.Lbl_Cliente.Text
                    cmd2.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = txt_comentario_transporte.Text
                    cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = cbx_estado_transporte.Text
                    cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                    cmd2.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = cbx_localizacion_transporte.Text
                    cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                    cxnc.Open()
                    cmd2.ExecuteNonQuery()
                    cxnc.Close()
                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                    txt_comentario_transporte.Text = ""
                    cbx_localizacion_transporte.Enabled = False
                    txt_comentario_transporte.Enabled = False

                Else
                    Throw New MyException("el campo COMENTARIO no puede ir vacío")
                End If
            Catch ex As MyException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ch_ver_informacion_transporte_CheckedChanged(sender As Object, e As EventArgs) Handles ch_ver_informacion_transporte.CheckedChanged
        If dg_reparaciones.SelectedCells IsNot Nothing Then
            If ch_ver_informacion_transporte.Checked = True Then

                Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
            command As New SqlCommand("SCR_CONSULTA_REPARACION", connection),
            adapter As New SqlDataAdapter(command)
                    command.CommandType = CommandType.StoredProcedure

                    'Add parameters, e.g.
                    command.Parameters.AddWithValue("@CONSULTAREP", dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value())

                    Dim table As New DataTable

                    'Get the data.
                    adapter.Fill(table)

                    'Display the data.
                    Me.dg_detalle_rep.DataSource = table
                End Using

                gb__ingresar_info_transporte.Visible = False
                gb_detalle_reparacion.Visible = True

                Num_Boleta = dg_reparaciones.Item(0, dg_reparaciones.CurrentRow.Index).Value()

            Else
                gb_detalle_reparacion.Visible = False
                gb__ingresar_info_transporte.Visible = True
            End If
        End If
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

End Class