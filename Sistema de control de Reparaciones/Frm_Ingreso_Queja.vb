Imports System.Data.SqlClient
Public Class Frm_Ingreso_Queja
    Private Sub Frm_Ingreso_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_TIPO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA)
        Me.ClienteTableAdapter1.Fill(Me.ExactusERP_TABLES1.CLIENTE)
        Timer1.Start()
        Cbx_Tipo_Queja.Text = ""
        select_num_queja()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Txt_Cliente_TextChanged(sender As Object, e As EventArgs) Handles Txt_Cliente.TextChanged
        CLIENTEBindingSource.Filter = "CLIENTE='" & Txt_Cliente.Text & "'"
        Lbl_Alias.Visible = True
        Lbl_Nombre.Visible = True
        Lbl_Telefono_1.Visible = True
        Lbl_Telefono_2.Visible = True
        Lbl_Fax.Visible = True
    End Sub

    Private Sub Txt_Cliente_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt_Cliente.MouseClick
        Txt_Cliente.Enabled = False
        My.Forms.Frm_Busqueda_cliente.MdiParent = Frm_Main_Menu
        Frm_Busqueda_cliente.Show()
        T_Busqueda_Cliente = 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim sql As String = "insert into dbo.SCR_DATOS_QUEJA values(@NUMERO_QUEJA,@CLIENTE,@FECHA,@USUARIO,@TIPO_QUEJA,@FACTURA,@PROFORMA,@DETALLE)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
        Dim cmd2 As New SqlCommand(sql2, cxnc)
        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@NUMERO_QUEJA", SqlDbType.Int).Value = Me.Lbl_Nun_Queja.Text
            cmd.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.Txt_Cliente.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
            cmd.Parameters.Add("@TIPO_QUEJA", SqlDbType.NVarChar).Value = Me.Cbx_Tipo_Queja.Text
            cmd.Parameters.Add("@FACTURA", SqlDbType.NVarChar).Value = Me.Txt_Factura.Text
            cmd.Parameters.Add("@PROFORMA", SqlDbType.NVarChar).Value = Me.Txt_Proforma.Text
            cmd.Parameters.Add("@DETALLE", SqlDbType.NVarChar).Value = Me.Txt_Descripcion_Queja.Text
            cxnc.Open()
            cmd.ExecuteNonQuery()
            cxnc.Close()
            cmd2.Parameters.Add("@NUMERO_QUEJA", SqlDbType.NVarChar).Value = Me.Lbl_Nun_Queja.Text
            cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "INGRESADA"
            cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
            cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            cxnc.Open()
            cmd2.ExecuteNonQuery()
            cxnc.Close()
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
            Lbl_Alias.Visible = False
            Lbl_Nombre.Visible = False
            Lbl_Telefono_1.Visible = False
            Lbl_Telefono_2.Visible = False
            Lbl_Fax.Visible = False
            Txt_Cliente.Text = ""
            Txt_Cliente.Enabled = True
            Txt_Factura.Text = ""
            Txt_Proforma.Text = ""
            Txt_Descripcion_Queja.Text = ""
            Cbx_Tipo_Queja.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        select_num_queja()
    End Sub

    Private Sub select_num_queja()
        Try
            Dim sql As String = "Select MAX(NUMERO_QUEJA) From dbo.SCR_DATOS_QUEJA"
            Dim cmd As New SqlCommand(sql, cxnc)
            Dim ULTIMO As Long
            Dim uno As Long = 1
            Dim TOTAL As Long
            cxnc.Open()
            ULTIMO = cmd.ExecuteScalar()
            cxnc.Close()
            TOTAL = ULTIMO + uno
            Lbl_Nun_Queja.Text = TOTAL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_Factura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Factura.KeyPress
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

    Private Sub Txt_Proforma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Proforma.KeyPress
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

    Private Sub Txt_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cliente.KeyPress
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
End Class