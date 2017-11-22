Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Impresion_Queja

    Private Sub Frm_Impresion_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim param As New ParameterValues
            Dim mydiscretevalue As New ParameterDiscreteValue

            'cryRpt.PrintOptions.PrinterName = "Impresion_Guias"
            cryRpt.Load("" & Application.StartupPath & "\REPORTES\IMPRESION_QUEJA.rpt")

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
            mydiscretevalue.Value = Num_Queja
            param.Add(mydiscretevalue)
            cryRpt.DataDefinition.ParameterFields("@numQUEJA").ApplyCurrentValues(param)
            Crv_Colilla.ReportSource = cryRpt
            Crv_Colilla.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
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