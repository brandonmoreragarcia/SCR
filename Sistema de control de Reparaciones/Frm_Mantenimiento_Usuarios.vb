Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows
Imports CrystalDecisions
Public Class Frm_Mantenimiento_Usuarios
    Dim tipo As String

    Private Sub Frm_Mantenimiento_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_Usuario_P' Puede moverla o quitarla según sea necesario.
        Me.SCR_Usuario_PTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_Usuario_P)


    End Sub

    Private Sub Dgv_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Usuarios.CellContentClick
        Lbl_Usuario.Text = Dgv_Usuarios.Item(0, Dgv_Usuarios.CurrentRow.Index).Value()
        Lbl_Nombre.Text = Dgv_Usuarios.Item(1, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Entrada_Rep.Text = Dgv_Usuarios.Item(2, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Actua_Rep.Text = Dgv_Usuarios.Item(3, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Trans_Rep.Text = Dgv_Usuarios.Item(4, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Busqueda_Boleta.Text = Dgv_Usuarios.Item(5, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Entrada_Queja.Text = Dgv_Usuarios.Item(6, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Actua_Queja.Text = Dgv_Usuarios.Item(7, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Reportes.Text = Dgv_Usuarios.Item(8, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Mantenimiento.Text = Dgv_Usuarios.Item(9, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Master.Text = Dgv_Usuarios.Item(10, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Crea_Re.Text = Dgv_Usuarios.Item(11, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Carga_Re.Text = Dgv_Usuarios.Item(12, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Cierra_Re.Text = Dgv_Usuarios.Item(13, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Imprime_Guia_Re.Text = Dgv_Usuarios.Item(14, Dgv_Usuarios.CurrentRow.Index).Value()
        Cbx_Reimprime_Guia_Re.Text = Dgv_Usuarios.Item(15, Dgv_Usuarios.CurrentRow.Index).Value()
        Txt_Passwd.Enabled = True
        Txt_Ean_8.Enabled = True
        Btn_Imprime_Codigo.Visible = True
    End Sub

    Private Sub Rbtn_Actua_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Actua.CheckedChanged
        Lbl_Usuario.Visible = True
        Btn_Actua.Visible = True
        Lbl_Nombre.Visible = True
        Txt_Usuario.Visible = False
        Btn_Crear.Visible = False
        Dgv_Usuarios.Enabled = True
        Txt_Passwd.Enabled = False
        Txt_Ean_8.Enabled = False
        Txt_Nombre.Visible = False
    End Sub

    Private Sub Rbtn_Crear_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_Crear.CheckedChanged
        Txt_Usuario.Visible = True
        Btn_Crear.Visible = True
        Lbl_Usuario.Visible = False
        Btn_Actua.Visible = False
        Dgv_Usuarios.Enabled = False
        Txt_Passwd.Enabled = True
        Txt_Ean_8.Enabled = True
        Lbl_Nombre.Visible = False
        Txt_Nombre.Visible = True
    End Sub

    Private Sub Btn_Crear_Click(sender As Object, e As EventArgs) Handles Btn_Crear.Click
        If Txt_Usuario.Text = "" Then
            MsgBox("Lo siento, debe ingresar un usuario valido")
        Else
            If Txt_Passwd.Text = "" Then
                MsgBox("Lo siento, debe ingresar una contraseña valida")
            Else
                If Txt_Nombre.Text = "" Then
                    MsgBox("Lo siento, debe ingresar un nombre valido")
                Else


                    Txt_Usuario.Text = UCase(Txt_Usuario.Text)
                    Dim sql As String = "INSERT INTO dbo.SCR_Usuario_P VALUES(@Usuario ,dbo.fnEncripClave(@passwd),@entrada_rep,@actua_rep,@trans_rep,@busqueda_boleta,@entrada_queja,@actua_queja,@reportes,@mantenimiento,@master,@Nombre,@crea_re,@carga_re,@cierra_re,@imprime_guia_re,@reimprime_guia_re,dbo.fnEncripClave(@cod_ean_8))"
                    Dim cmd As New SqlCommand(sql, cxnc)
                    Try
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = Txt_Usuario.Text
                        cmd.Parameters.Add("@passwd", SqlDbType.NVarChar).Value = Txt_Passwd.Text
                        cmd.Parameters.Add("@entrada_rep", SqlDbType.NVarChar).Value = Cbx_Entrada_Rep.Text
                        cmd.Parameters.Add("@actua_rep", SqlDbType.NVarChar).Value = Cbx_Actua_Rep.Text
                        cmd.Parameters.Add("@trans_rep", SqlDbType.NVarChar).Value = Cbx_Trans_Rep.Text
                        cmd.Parameters.Add("@busqueda_boleta", SqlDbType.NVarChar).Value = Cbx_Busqueda_Boleta.Text
                        cmd.Parameters.Add("@entrada_queja", SqlDbType.NVarChar).Value = Cbx_Entrada_Queja.Text
                        cmd.Parameters.Add("@actua_queja", SqlDbType.NVarChar).Value = Cbx_Actua_Queja.Text
                        cmd.Parameters.Add("@reportes", SqlDbType.NVarChar).Value = Cbx_Reportes.Text
                        cmd.Parameters.Add("@mantenimiento", SqlDbType.NVarChar).Value = Cbx_Mantenimiento.Text
                        cmd.Parameters.Add("@master", SqlDbType.NVarChar).Value = Cbx_Master.Text
                        cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = Txt_Nombre.Text
                        cmd.Parameters.Add("@crea_re", SqlDbType.NVarChar).Value = Cbx_Crea_Re.Text
                        cmd.Parameters.Add("@carga_re", SqlDbType.NVarChar).Value = Cbx_Carga_Re.Text
                        cmd.Parameters.Add("@cierra_re", SqlDbType.NVarChar).Value = Cbx_Cierra_Re.Text
                        cmd.Parameters.Add("@imprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Imprime_Guia_Re.Text
                        cmd.Parameters.Add("@reimprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Reimprime_Guia_Re.Text
                        cmd.Parameters.Add("@cod_ean_8", SqlDbType.NVarChar).Value = Txt_Ean_8.Text
                        cxnc.Open()
                        cmd.ExecuteNonQuery()
                        cxnc.Close()
                        MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                        Txt_Usuario.Text = ""
                        Txt_Nombre.Text = ""
                        Txt_Passwd.Text = ""
                        Cbx_Entrada_Rep.Text = "0"
                        Cbx_Actua_Rep.Text = "0"
                        Cbx_Trans_Rep.Text = "0"
                        Cbx_Busqueda_Boleta.Text = "0"
                        Cbx_Entrada_Queja.Text = "0"
                        Cbx_Actua_Queja.Text = "0"
                        Cbx_Reportes.Text = "0"
                        Cbx_Mantenimiento.Text = "0"
                        Cbx_Master.Text = "0"
                        Cbx_Crea_Re.Text = "0"
                        Cbx_Carga_Re.Text = "0"
                        Cbx_Cierra_Re.Text = "0"
                        Cbx_Imprime_Guia_Re.Text = "0"
                        Cbx_Reimprime_Guia_Re.Text = "0"
                        Txt_Ean_8.Text = ""
                        Me.SCR_Usuario_PTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_Usuario_P)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub Btn_Actua_Click(sender As Object, e As EventArgs) Handles Btn_Actua.Click
        If Txt_Passwd.Text = "" Then
            Dim sql1 As String = "UPDATE dbo.SCR_Usuario_P SET entrada_rep = @entrada_rep, actua_rep = @actua_rep, trans_rep = @trans_rep, busqueda_boleta = @busqueda_boleta, entrada_queja = @entrada_queja, actua_queja = @actua_queja, reportes = @reportes, mantenimiento = @mantenimiento, master = @master, crea_re = @crea_re, carga_re = @carga_re, cierra_re = @cierra_re, imprime_guia_re = @imprime_guia_re, reimprime_guia_re = @reimprime_guia_re WHERE dbo.SCR_Usuario_P.usuario = @usuario"
            Dim cmd1 As New SqlCommand(sql1, cxnc)
            Try
                cmd1.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = Lbl_Usuario.Text
                cmd1.Parameters.Add("@entrada_rep", SqlDbType.NVarChar).Value = Cbx_Entrada_Rep.Text
                cmd1.Parameters.Add("@actua_rep", SqlDbType.NVarChar).Value = Cbx_Actua_Rep.Text
                cmd1.Parameters.Add("@trans_rep", SqlDbType.NVarChar).Value = Cbx_Trans_Rep.Text
                cmd1.Parameters.Add("@busqueda_boleta", SqlDbType.NVarChar).Value = Cbx_Busqueda_Boleta.Text
                cmd1.Parameters.Add("@entrada_queja", SqlDbType.NVarChar).Value = Cbx_Entrada_Queja.Text
                cmd1.Parameters.Add("@actua_queja", SqlDbType.NVarChar).Value = Cbx_Actua_Queja.Text
                cmd1.Parameters.Add("@reportes", SqlDbType.NVarChar).Value = Cbx_Reportes.Text
                cmd1.Parameters.Add("@mantenimiento", SqlDbType.NVarChar).Value = Cbx_Mantenimiento.Text
                cmd1.Parameters.Add("@master", SqlDbType.NVarChar).Value = Cbx_Master.Text
                cmd1.Parameters.Add("@crea_re", SqlDbType.NVarChar).Value = Cbx_Crea_Re.Text
                cmd1.Parameters.Add("@carga_re", SqlDbType.NVarChar).Value = Cbx_Carga_Re.Text
                cmd1.Parameters.Add("@cierra_re", SqlDbType.NVarChar).Value = Cbx_Cierra_Re.Text
                cmd1.Parameters.Add("@imprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Imprime_Guia_Re.Text
                cmd1.Parameters.Add("@reimprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Reimprime_Guia_Re.Text
                cxnc.Open()
                cmd1.ExecuteNonQuery()
                cxnc.Close()
                Txt_Usuario.Text = ""
                Txt_Nombre.Text = ""
                Txt_Passwd.Text = ""
                Cbx_Entrada_Rep.Text = "0"
                Cbx_Actua_Rep.Text = "0"
                Cbx_Trans_Rep.Text = "0"
                Cbx_Busqueda_Boleta.Text = "0"
                Cbx_Entrada_Queja.Text = "0"
                Cbx_Actua_Queja.Text = "0"
                Cbx_Reportes.Text = "0"
                Cbx_Mantenimiento.Text = "0"
                Cbx_Master.Text = "0"
                Cbx_Crea_Re.Text = "0"
                Cbx_Carga_Re.Text = "0"
                Cbx_Cierra_Re.Text = "0"
                Cbx_Imprime_Guia_Re.Text = "0"
                Cbx_Reimprime_Guia_Re.Text = "0"
                Txt_Ean_8.Text = ""
                Me.SCR_Usuario_PTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_Usuario_P)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Dim sql1 As String = "UPDATE dbo.SCR_Usuario_P SET passwd = dbo.fnEncripClave(@passwd), entrada_rep = @entrada_rep, actua_rep = @actua_rep, trans_rep = @trans_rep, busqueda_boleta = @busqueda_boleta, entrada_queja = @entrada_queja, actua_queja = @actua_queja, reportes = @reportes, mantenimiento = @mantenimiento, master = @master, crea_re = @crea_re, carga_re = @carga_re, cierra_re = @cierra_re, imprime_guia_re = @imprime_guia_re, reimprime_guia_re = @reimprime_guia_re, cod_ean_8 = dbo.fnEncripClave(@cod_ean_8) WHERE dbo.SCR_Usuario_P.usuario = @usuario"
            Dim cmd1 As New SqlCommand(sql1, cxnc)
            Try
                cmd1.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = Lbl_Usuario.Text
                cmd1.Parameters.Add("@passwd", SqlDbType.NVarChar).Value = Txt_Passwd.Text
                cmd1.Parameters.Add("@entrada_rep", SqlDbType.NVarChar).Value = Cbx_Entrada_Rep.Text
                cmd1.Parameters.Add("@actua_rep", SqlDbType.NVarChar).Value = Cbx_Actua_Rep.Text
                cmd1.Parameters.Add("@trans_rep", SqlDbType.NVarChar).Value = Cbx_Trans_Rep.Text
                cmd1.Parameters.Add("@busqueda_boleta", SqlDbType.NVarChar).Value = Cbx_Busqueda_Boleta.Text
                cmd1.Parameters.Add("@entrada_queja", SqlDbType.NVarChar).Value = Cbx_Entrada_Queja.Text
                cmd1.Parameters.Add("@actua_queja", SqlDbType.NVarChar).Value = Cbx_Actua_Queja.Text
                cmd1.Parameters.Add("@reportes", SqlDbType.NVarChar).Value = Cbx_Reportes.Text
                cmd1.Parameters.Add("@mantenimiento", SqlDbType.NVarChar).Value = Cbx_Mantenimiento.Text
                cmd1.Parameters.Add("@master", SqlDbType.NVarChar).Value = Cbx_Master.Text
                cmd1.Parameters.Add("@crea_re", SqlDbType.NVarChar).Value = Cbx_Crea_Re.Text
                cmd1.Parameters.Add("@carga_re", SqlDbType.NVarChar).Value = Cbx_Carga_Re.Text
                cmd1.Parameters.Add("@cierra_re", SqlDbType.NVarChar).Value = Cbx_Cierra_Re.Text
                cmd1.Parameters.Add("@imprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Imprime_Guia_Re.Text
                cmd1.Parameters.Add("@reimprime_guia_re", SqlDbType.NVarChar).Value = Cbx_Reimprime_Guia_Re.Text
                cmd1.Parameters.Add("@cod_ean_8", SqlDbType.NVarChar).Value = Txt_Ean_8.Text
                cxnc.Open()
                cmd1.ExecuteNonQuery()
                cxnc.Close()
                Txt_Usuario.Text = ""
                Txt_Nombre.Text = ""
                Txt_Passwd.Text = ""
                Cbx_Entrada_Rep.Text = "0"
                Cbx_Actua_Rep.Text = "0"
                Cbx_Trans_Rep.Text = "0"
                Cbx_Busqueda_Boleta.Text = "0"
                Cbx_Entrada_Queja.Text = "0"
                Cbx_Actua_Queja.Text = "0"
                Cbx_Reportes.Text = "0"
                Cbx_Mantenimiento.Text = "0"
                Cbx_Master.Text = "0"
                Cbx_Crea_Re.Text = "0"
                Cbx_Carga_Re.Text = "0"
                Cbx_Cierra_Re.Text = "0"
                Cbx_Imprime_Guia_Re.Text = "0"
                Cbx_Reimprime_Guia_Re.Text = "0"
                Txt_Ean_8.Text = ""
                Me.SCR_Usuario_PTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_Usuario_P)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Cbx_Master_TextChanged(sender As Object, e As EventArgs) Handles Cbx_Master.TextChanged

    End Sub

    Private Sub Cbx_Entrada_Rep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Entrada_Rep.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Actua_Rep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Actua_Rep.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Trans_Rep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Trans_Rep.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Busqueda_Boleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Busqueda_Boleta.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Entrada_Queja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Entrada_Queja.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Actua_Queja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Actua_Queja.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Reportes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Reportes.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Mantenimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Mantenimiento.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Master_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Master.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txt_Ean_8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Ean_8.KeyPress
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

    Private Sub Btn_Imprime_Codigo_Click(sender As Object, e As EventArgs) Handles Btn_Imprime_Codigo.Click
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table
        Dim param1 As New ParameterValues
        Dim mydiscretevalue1 As New ParameterDiscreteValue

        Dim num_Copias As Short
        Dim resultado As Short = num_Copias
        Dim n As String = ""
        Dim cmd3 = New SqlCommand("Select dbo.fnLeeClave(cod_ean_8) as CODIGO from dbo.SCR_Usuario_P where usuario = '" & Lbl_Usuario.Text & "'", cxnc)
        cmd3.CommandType = CommandType.Text
        cxnc.Open()
        Try
            n = CStr(cmd3.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cxnc.Close()
        Try
            cryRpt.PrintOptions.PrinterName = "Impresion_Guias"
            cryRpt.Load("" & Application.StartupPath & "\REPORTES\Codigo_Impresion.rpt")


            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param1.Clear()
            mydiscretevalue1.Value = n
            param1.Add(mydiscretevalue1)
            cryRpt.DataDefinition.ParameterFields("codigo").ApplyCurrentValues(param1)
            cryRpt.PrintToPrinter(1, False, 0, 0)
            n = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class