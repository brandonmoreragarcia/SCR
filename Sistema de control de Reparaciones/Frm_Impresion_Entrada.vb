
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Impresion_Entrada
    Private Sub Frm_Impresion_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_generar_tiquete_Click(sender As Object, e As EventArgs) Handles bt_generar_tiquete.Click
        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim param As New ParameterValues
            Dim mydiscretevalue As New ParameterDiscreteValue

            cryRpt.PrintOptions.PrinterName = "Impresion_Guias"
            cryRpt.Load("" & Application.StartupPath & "\REPORTES\COLILLA_REP.rpt")

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
            mydiscretevalue.Value = numero_reparacion
            param.Add(mydiscretevalue)
            cryRpt.DataDefinition.ParameterFields("@REPNUMERO").ApplyCurrentValues(param)
            Crv_Colilla.ReportSource = cryRpt
            Crv_Colilla.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class