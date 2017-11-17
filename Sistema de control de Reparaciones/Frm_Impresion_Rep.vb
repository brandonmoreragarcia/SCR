Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_Impresion_Rep
    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click
        If Txt_Numero_Rep.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            If numero_rep(Txt_Numero_Rep.Text) = True Then
                If rep_cerrada(Txt_Numero_Rep.Text) = True Then
                    MsgBox("La Reparacion: " + Txt_Numero_Rep.Text + " Ya ha sido CERRADA por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                    Btn_Cargar.Enabled = False
                Else
                    If impre_rep(Txt_Numero_Rep.Text) = True Then
                        Dim numboleta As String = Txt_Numero_Rep.Text
                        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_CONTROL_IMPR_REP WHERE DBO.SCR_CONTROL_IMPR_REP.REPARACION_NUMERO ='" & numboleta & "'", cxnc)
                        cmd3.CommandType = CommandType.Text
                        Dim n As Date
                        cxnc.Open()
                        n = CDate(cmd3.ExecuteScalar())
                        cxnc.Close()
                        MsgBox("La Reparacion: " + Txt_Numero_Rep.Text + " Ya ha sido IMPRESA el dia " + n + " por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                        Btn_Cargar.Enabled = False
                    Else
                        Try
                            Dim cryRpt As New ReportDocument
                            Dim crtableLogoninfos As New TableLogOnInfos
                            Dim crtableLogoninfo As New TableLogOnInfo
                            Dim crConnectionInfo As New ConnectionInfo
                            Dim CrTables As Tables
                            Dim CrTable As Table
                            Dim param As New ParameterValues
                            Dim mydiscretevalue As New ParameterDiscreteValue

                            cryRpt.Load("" & Application.StartupPath & "\REPORTES\IMPRESION_REP_SALIDA.rpt")

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
                            param.Clear()
                            mydiscretevalue.Value = Txt_Numero_Rep.Text
                            param.Add(mydiscretevalue)
                            cryRpt.DataDefinition.ParameterFields("@REPNUMERO").ApplyCurrentValues(param)
                            Crv_Impresion_Rep.ReportSource = cryRpt
                            Crv_Impresion_Rep.Refresh()
                            Txt_Numero_Rep.Enabled = False
                            Btn_Exportar.Enabled = True
                            Btn_Imprimir.Enabled = True
                            Btn_Cargar.Enabled = False
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Crv_Impresion_Rep.PrintReport()
        CONTROL_IMPR()
        Btn_Imprimir.Enabled = False
        Btn_Exportar.Enabled = False
    End Sub

    Private Sub Btn_Exportar_Click(sender As Object, e As EventArgs) Handles Btn_Exportar.Click
        Crv_Impresion_Rep.ExportReport()
        CONTROL_IMPR()
        Btn_Exportar.Enabled = False
        Btn_Imprimir.Enabled = False
    End Sub

    Private Sub CONTROL_IMPR()
        Dim sql As String = "insert into SCR_CONTROL_IMPR_REP values(@REPARACION_NUMERO,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)

        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Txt_Numero_Rep.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            cxnc.Open()
            cmd.ExecuteNonQuery()
            cxnc.Close()
            Txt_Numero_Rep.Text = ""
            Txt_Numero_Rep.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_Numero_Rep_TextChanged(sender As Object, e As EventArgs) Handles Txt_Numero_Rep.TextChanged
        Btn_Cargar.Enabled = True
    End Sub

    Private Sub Txt_Numero_Rep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Numero_Rep.KeyPress
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

    Private Sub Btn_Imprimir_Consumo_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir_Consumo.Click
        If Txt_Numero_Rep.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            If numero_rep(Txt_Numero_Rep.Text) = True Then
                If impre_rep_consumo(Txt_Numero_Rep.Text) = True Then
                    Dim numboleta As String = Txt_Numero_Rep.Text
                    Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_CONTROL_IMPR_REP_CON WHERE DBO.SCR_CONTROL_IMPR_REP_CON.REPARACION_NUMERO ='" & numboleta & "'", cxnc)
                    cmd3.CommandType = CommandType.Text
                    Dim n As Date
                    cxnc.Open()
                    n = CDate(cmd3.ExecuteScalar())
                    cxnc.Close()
                    MsgBox("La Reparacion: " + Txt_Numero_Rep.Text + " Ya ha sido IMPRESA el dia " + n + " por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                Else
                    My.Forms.Frm_Impresion_Rep_Consumo.MdiParent = Frm_Main_Menu
                    num_rep = Txt_Numero_Rep.Text
                    Frm_Impresion_Rep_Consumo.Show()
                End If
            Else
                MsgBox("Lo sentimos la reparacion no existe")
            End If
        End If

    End Sub
End Class