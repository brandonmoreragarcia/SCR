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
    Dim debo_cargar As Boolean

    'Se usa para validar que el reporte se haya cargado previamente antes de imprimir'
    Dim imprimir As Boolean = False


    Private Sub cargar()
        Try


            If Txt_Caja.Text IsNot "" Then

                If Txt_Bulto.Text IsNot "" Then

                    If Txt_Bici.Text IsNot "" Then


                        imprimir = True

                        Integer.TryParse(Txt_Caja.Text, cajas)
                        Integer.TryParse(Txt_Bulto.Text, bultos)
                        Integer.TryParse(Txt_Bici.Text, bicis)
                        total = (cajas + bultos + bicis)

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
                        mydiscretevalue3.Value = total
                        mydiscretevalue4.Value = total
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

                    Else
                        Throw New MyException("error, el campo 'bici' no puede ir en blanco")
                    End If

                Else
                    Throw New MyException("error, el campo 'bulto' no puede ir en blanco")
                End If

            Else
                Throw New MyException("error, el campo 'caja' no puede ir en blanco")
            End If


        Catch ex As MyException
            MsgBox(ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click



        If Txt_Caja.Text = "" Then
            Txt_Caja.Text = 0

        End If


        If Txt_Bici.Text = "" Then
                Txt_Bici.Text = 0


            End If
        If Txt_Bulto.Text = "" Then
            Txt_Bulto.Text = 0
        End If

        mydiscretevalue1.Value = cb_Numero_Rep.Text
        mydiscretevalue2.Value = v_usuario

        mydiscretevalue5.Value = Txt_Caja.Text
        mydiscretevalue6.Value = Txt_Bulto.Text
        mydiscretevalue7.Value = Txt_Bici.Text

        cargar()
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click

        Try

            If imprimir Then

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

                '////////////////
                'CONTROL_IMPR()

                'código agregado por Brandon'
                Txt_Caja.Text = ""
                cb_Numero_Rep.Text = ""
                Txt_Bulto.Text = ""
                Txt_Bici.Text = ""
                imprimir = False

                'Por alguna razón esto no se ejecuta'
                lb_mensaje_impresion.ForeColor = System.Drawing.Color.Black
                lb_mensaje_impresion.Text = "IMPRIMIENDO..."

                System.Threading.Thread.Sleep(2000)
                lb_mensaje_impresion.ForeColor = System.Drawing.Color.Red
                lb_mensaje_impresion.Text = "IMPRESIÓN EXITOSA!"
            Else
                Throw New MyException("error, primero se debe cargar el reporte antes de imprimirlo")
            End If

        Catch ex As MyException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CONTROL_IMPR()
        Dim sql As String = "insert into DBO.SCR_CONTORL_IMPR_ETQ_SAL values(@REPARACION_NUMERO,@FECHA,@COPIAS)"
        Dim cmd As New SqlCommand(sql, cxnc)
        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = cb_Numero_Rep.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
            cmd.Parameters.Add("@COPIAS", SqlDbType.NVarChar).Value = Txt_Caja.Text
            cxnc.Open()
            cmd.ExecuteNonQuery()
            cxnc.Close()
            cb_Numero_Rep.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cb_Numero_Rep_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub Frm_Impresion_Etiqueta_Salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_REPARACIONES_POR_IMPRIMIR' Puede moverla o quitarla según sea necesario.
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter.Fill(Me.ExactusERP_SRC_TABLES1.SCR_REPARACIONES_POR_IMPRIMIR)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDA' Puede moverla o quitarla según sea necesario.
        Me.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDATableAdapter.Fill(Me.ExactusERP_SRC_TABLES1.SCR_REPARACIONES_PENDIENTES_DE_ETIQUETA_SALIDA)
        lb_mensaje_impresion.Text = ""
    End Sub

    Private Sub cb_Numero_Rep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Numero_Rep.SelectedIndexChanged
        lb_mensaje_impresion.Text = ""
    End Sub

    Private Sub cb_Numero_Rep_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Numero_Rep.SelectionChangeCommitted

        mydiscretevalue1.Value = ""
        mydiscretevalue2.Value = ""
        mydiscretevalue3.Value = ""
        mydiscretevalue4.Value = ""
        mydiscretevalue5.Value = ""
        mydiscretevalue6.Value = ""
        mydiscretevalue7.Value = ""

        If Txt_Caja.Text = "" Then
            Txt_Caja.Text = 0

            If Txt_Bulto.Text = "" Then
                Txt_Bulto.Text = 0

                If Txt_Bici.Text = "" Then
                    Txt_Bici.Text = 0

                    cargar()

                End If
            End If
        End If

    End Sub
End Class