Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows
Imports CrystalDecisions
Public Class Frm_Impresion_Etiqueta_Salida
    Dim cryRpt_Salida As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    Dim param1 As New ParameterValues
    Dim mydiscretevalue1 As New ParameterDiscreteValue
    Dim param2 As New ParameterValues
    Dim mydiscretevalue2 As New ParameterDiscreteValue
    Dim param3 As New ParameterValues
    Dim mydiscretevalue3 As New ParameterDiscreteValue
    Dim param4 As New ParameterValues
    Dim mydiscretevalue4 As New ParameterDiscreteValue
    Dim param5 As New ParameterValues
    Dim mydiscretevalue5 As New ParameterDiscreteValue
    Dim param6 As New ParameterValues
    Dim mydiscretevalue6 As New ParameterDiscreteValue
    Dim param7 As New ParameterValues
    Dim mydiscretevalue7 As New ParameterDiscreteValue
    Dim cajas As Integer
    Dim bultos As Integer
    Dim bicis As Integer
    Dim total As Integer

    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click
        If Txt_Numero_Rep.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            If numero_rep(Txt_Numero_Rep.Text) = True Then
                If rep_cerrada(Txt_Numero_Rep.Text) = True Then
                    MsgBox("La Reparacion: " + Txt_Numero_Rep.Text + " Ya ha sido CERRADA por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                    Btn_Cargar.Enabled = False
                Else
                    If impre_rep_sal(Txt_Numero_Rep.Text) = True Then
                        Dim numboleta As String = Txt_Numero_Rep.Text
                        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_CONTORL_IMPR_ETQ_SAL WHERE DBO.SCR_CONTORL_IMPR_ETQ_SAL.REPARACION_NUMERO ='" & numboleta & "'", cxnc)
                        cmd3.CommandType = CommandType.Text
                        Dim n As Date
                        cxnc.Open()
                        n = CDate(cmd3.ExecuteScalar())
                        cxnc.Close()
                        MsgBox("La Etiqueta de Salida para la Reparacion: " + Txt_Numero_Rep.Text + " Ya ha sido IMPRESA el dia " + n + " por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                        Btn_Cargar.Enabled = True
                        Btn_Imprimir.Enabled = False
                        Txt_Numero_Rep.Text = ""
                        Txt_Bici.Text = ""
                        Txt_Bulto.Text = ""
                        Txt_Caja.Text = ""
                    Else

                        Integer.TryParse(Txt_Caja.Text, cajas)
                        Integer.TryParse(Txt_Bulto.Text, bultos)
                        Integer.TryParse(Txt_Bici.Text, bicis)
                        total = (cajas + bultos + bicis)
                        Try
                            cryRpt_Salida.PrintOptions.PrinterName = "Impresion_Guias"

                            cryRpt_Salida.Load("" & Application.StartupPath & "\REPORTES\IMPRESION_ETQ_SALIDA.rpt")

                            With crConnectionInfo
                                .UserID = "SA"
                                .Password = "B1@dm1n"
                            End With

                            CrTables = cryRpt_Salida.Database.Tables
                            For Each CrTable In CrTables
                                crtableLogoninfo = CrTable.LogOnInfo
                                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                            Next
                            param1.Clear()
                            param2.Clear()
                            param3.Clear()
                            param4.Clear()
                            param5.Clear()
                            param6.Clear()
                            param7.Clear()
                            mydiscretevalue1.Value = Txt_Numero_Rep.Text
                            mydiscretevalue2.Value = v_usuario
                            mydiscretevalue3.Value = total
                            mydiscretevalue4.Value = total
                            mydiscretevalue5.Value = Txt_Caja.Text
                            mydiscretevalue6.Value = Txt_Bulto.Text
                            mydiscretevalue7.Value = Txt_Bici.Text
                            param1.Add(mydiscretevalue1)
                            param2.Add(mydiscretevalue2)
                            param3.Add(mydiscretevalue3)
                            param4.Add(mydiscretevalue4)
                            param5.Add(mydiscretevalue5)
                            param6.Add(mydiscretevalue6)
                            param7.Add(mydiscretevalue7)
                            cryRpt_Salida.DataDefinition.ParameterFields("@REPNUMERO").ApplyCurrentValues(param1)
                            cryRpt_Salida.DataDefinition.ParameterFields("empacado").ApplyCurrentValues(param2)
                            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
                            cryRpt_Salida.DataDefinition.ParameterFields("TOTAL").ApplyCurrentValues(param4)
                            cryRpt_Salida.DataDefinition.ParameterFields("CAJAS").ApplyCurrentValues(param5)
                            cryRpt_Salida.DataDefinition.ParameterFields("BULTOS").ApplyCurrentValues(param6)
                            cryRpt_Salida.DataDefinition.ParameterFields("BICIS").ApplyCurrentValues(param7)
                            Crv_Impresion_Rep.ReportSource = cryRpt_Salida
                            Crv_Impresion_Rep.Refresh()
                            Txt_Numero_Rep.Enabled = False
                            Btn_Imprimir.Enabled = True
                            Btn_Imprimir.Visible = True
                            Btn_Cargar.Enabled = False
                            Txt_Caja.Enabled = False
                            Txt_Bici.Enabled = False
                            Txt_Bulto.Enabled = False

                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        'Crv_Impresion_Rep.PrintReport()
        'cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
        'Imprimir_Caja()
        'Imprimir_Bulto()
        'Imprimir_Bici()
        'CONTROL_IMPR()
        Dim resultado As Integer = total
        While resultado > 0
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            Short.TryParse(total, valorEntero)
            printersettings.PrinterName = "Impresion_Guias"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt_Salida.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param3.Clear()
            mydiscretevalue3.Value = resultado
            param3.Add(mydiscretevalue3)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
            'Crv_Caja_Master.PrintMode = Forms.PrintMode.PrintToPrinter
            'Crv_Caja_Master.PrintReport()
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
            resultado -= 1
        End While
        If Chk_Imprimir_Control.CheckState = CheckState.Checked Then
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            Short.TryParse(total, valorEntero)
            printersettings.PrinterName = "Impresion_Guias"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt_Salida.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param3.Clear()
            mydiscretevalue3.Value = total
            param3.Add(mydiscretevalue3)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
            param4.Clear()
            mydiscretevalue4.Value = "TRANS"
            param4.Add(mydiscretevalue4)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param4)
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
        End If
        CONTROL_IMPR()
        Btn_Imprimir.Enabled = False
        Btn_Cargar.Enabled = True
        Txt_Caja.Text = ""
        Txt_Numero_Rep.Text = ""
        Txt_Bulto.Text = ""
        Txt_Bici.Text = ""
        Txt_Caja.Enabled = False
        Txt_Bulto.Enabled = False
        Txt_Bici.Enabled = False
        Txt_Numero_Rep.Enabled = True
    End Sub

    Private Sub CONTROL_IMPR()
        Dim sql As String = "insert into DBO.SCR_CONTORL_IMPR_ETQ_SAL values(@REPARACION_NUMERO,@FECHA,@COPIAS)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Txt_Numero_Rep.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            cmd.Parameters.Add("@COPIAS", SqlDbType.NVarChar).Value = Txt_Caja.Text
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
        Txt_Caja.Enabled = True
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

    Private Sub Frm_Impresion_Etiqueta_Salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Imprimir_Caja()
        Dim num_Copias As Integer
        Integer.TryParse(Txt_Caja.Text, num_Copias)
        Dim resultado As Integer = num_Copias
        While resultado > 0
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            Short.TryParse(Txt_Caja.Text, valorEntero)
            printersettings.PrinterName = "Impresion_Guias"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt_Salida.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param3.Clear()
            mydiscretevalue3.Value = resultado
            param3.Add(mydiscretevalue3)
            param5.Clear()
            mydiscretevalue5.Value = "Caja"
            param5.Add(mydiscretevalue5)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
            cryRpt_Salida.DataDefinition.ParameterFields("T_Cantidad").ApplyCurrentValues(param5)
            'Crv_Caja_Master.PrintMode = Forms.PrintMode.PrintToPrinter
            'Crv_Caja_Master.PrintReport()
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
            MessageBox.Show(" Bici Impresa '" + resultado + "' '" + num_Copias + "'")
            resultado -= 1
        End While
    End Sub
    Private Sub Imprimir_Bulto()
        Dim num_Copias As Integer
        Integer.TryParse(Txt_Bulto.Text, num_Copias)
        Dim resultado As Integer = num_Copias
        While resultado > 0
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            Short.TryParse(Txt_Bulto.Text, valorEntero)
            printersettings.PrinterName = "Impresion_Guias"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt_Salida.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param3.Clear()
            mydiscretevalue3.Value = resultado
            param3.Add(mydiscretevalue3)
            param5.Clear()
            mydiscretevalue5.Value = "Bulto"
            param5.Add(mydiscretevalue5)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
            cryRpt_Salida.DataDefinition.ParameterFields("T_Cantidad").ApplyCurrentValues(param5)
            'Crv_Caja_Master.PrintMode = Forms.PrintMode.PrintToPrinter
            'Crv_Caja_Master.PrintReport()
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
            MessageBox.Show(" Bici Impresa '" + resultado + "' '" + num_Copias + "'")
            resultado -= 1
        End While
    End Sub
    Private Sub Imprimir_Bici()
        Dim num_Copias As Integer
        Integer.TryParse(Txt_Bici.Text, num_Copias)
        Dim resultado As Integer = num_Copias
        While resultado > 0
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            Short.TryParse(Txt_Bici.Text, valorEntero)
            printersettings.PrinterName = "Impresion_Guias"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            With crConnectionInfo
                .UserID = "SA"
                .Password = "B1@dm1n"
            End With

            CrTables = cryRpt_Salida.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            param3.Clear()
            mydiscretevalue3.Value = resultado
            param3.Add(mydiscretevalue3)
            param5.Clear()
            mydiscretevalue5.Value = "Bici"
            param5.Add(mydiscretevalue5)
            cryRpt_Salida.DataDefinition.ParameterFields("BULTO_CAJA").ApplyCurrentValues(param3)
            cryRpt_Salida.DataDefinition.ParameterFields("T_Cantidad").ApplyCurrentValues(param5)
            'Crv_Caja_Master.PrintMode = Forms.PrintMode.PrintToPrinter
            'Crv_Caja_Master.PrintReport()
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
            MessageBox.Show(" Bici Impresa '" + resultado + "' '" + num_Copias + "'")
            resultado -= 1
        End While
    End Sub

    Private Sub Txt_Bulto_Caja_TextChanged(sender As Object, e As EventArgs) Handles Txt_Caja.TextChanged
        Txt_Bulto.Enabled = True
    End Sub

    Private Sub Lbl_Copias_Click(sender As Object, e As EventArgs) Handles Lbl_Copias.Click

    End Sub

    Private Sub Txt_Bici_TextChanged(sender As Object, e As EventArgs) Handles Txt_Bici.TextChanged
        Btn_Cargar.Visible = True
        Btn_Cargar.Enabled = True
    End Sub

    Private Sub Txt_Bulto_TextChanged(sender As Object, e As EventArgs) Handles Txt_Bulto.TextChanged
        Txt_Bici.Enabled = True
    End Sub

    Private Sub Txt_Caja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Caja.KeyPress
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

    Private Sub Txt_Bulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Bulto.KeyPress
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

    Private Sub Txt_Bici_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Bici.KeyPress
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


    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class