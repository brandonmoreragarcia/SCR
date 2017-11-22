Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows
Imports CrystalDecisions
Public Class Frm_Impresion_Rep_Consumo
    Dim cryRpt_Salida As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    Dim param As New ParameterValues
    Dim mydiscretevalue As New ParameterDiscreteValue
    Dim sql As String = "insert into SCR_CONTROL_IMPR_REP_CON values(@REPARACION_NUMERO,@FECHA)"
    Dim cmd As New SqlCommand(sql, cxnc)
    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        If Txt_Codigo.Text = "252510" Then
            Dim printersettings As New Printing.PrinterSettings
            Dim pagesettings As New Printing.PageSettings
            Dim reformatreportpagesettings As Boolean = False
            Dim valorEntero As Short
            printersettings.PrinterName = "Brother bodega inventario"
            printersettings.Copies = valorEntero
            'cryRpt.PrintToPrinter(printersettings, pagesettings, reformatreportpagesettings)
            cryRpt_Salida.Load("" & Application.StartupPath & "\REPORTES\IMPRESION_REP_CONSUMO.rpt")
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
            param.Clear()
            mydiscretevalue.Value = num_rep
            param.Add(mydiscretevalue)
            cryRpt_Salida.DataDefinition.ParameterFields("@REPNUMERO").ApplyCurrentValues(param)
            'Crv_Caja_Master.PrintMode = Forms.PrintMode.PrintToPrinter
            'Crv_Caja_Master.PrintReport()
            cryRpt_Salida.PrintToPrinter(1, False, 0, 0)
            Try
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = num_rep
                cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
                cxnc.Open()
                cmd.ExecuteNonQuery()
                cxnc.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        Else
            MsgBox("Lo siento el codigo de autorizacion no coincide")
        End If
    End Sub

    Private Sub Frm_Impresion_Rep_Consumo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Forms.Frm_Listado_Reportes.Enabled = True
    End Sub


    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
End Class