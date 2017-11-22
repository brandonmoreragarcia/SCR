Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class NO_Listado_Rep

    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click
        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim param As New ParameterValues
            Dim param2 As New ParameterValues
            Dim fecha_inicio As New ParameterDiscreteValue
            Dim fecha_final As New ParameterDiscreteValue

            cryRpt.Load("" & Application.StartupPath & "\REPORTES\LISTADO REPS.rpt")

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
            param2.Clear()
            fecha_inicio.Value = Dtp_Fecha_Inicio.Text
            fecha_final.Value = Dtp_Fecha_Final.Text
            param.Add(fecha_inicio)
            param2.Add(fecha_final)
            cryRpt.DataDefinition.ParameterFields("@FECHA_INICIO").ApplyCurrentValues(param)
            cryRpt.DataDefinition.ParameterFields("@FECHA_FINAL").ApplyCurrentValues(param2)
            Crv_Listado_Rep.ReportSource = cryRpt
            Crv_Listado_Rep.Refresh()
            Txt_Fecha_Final.Text = ""
            Txt_Fecha_Inicial.Text = ""
            Txt_Fecha_Final.Enabled = False
            Btn_Cargar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_Fecha_Inicial_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Txt_Fecha_Inicial.MaskInputRejected
        MsgBox("DEBE INGRESAR LA FECHA EN EL FORMATO AÑO-MES-DIA POR EJEMPLO 2016-01-31")
    End Sub

    Private Sub Txt_Fecha_Inicial_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_Fecha_Inicial.TextChanged
        Txt_Fecha_Final.Enabled = True
    End Sub

    Private Sub Txt_Fecha_Final_TextChanged(sender As Object, e As EventArgs) Handles Txt_Fecha_Final.TextChanged
        Btn_Cargar.Enabled = True
    End Sub

    Private Sub Txt_Fecha_Final_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Txt_Fecha_Final.MaskInputRejected
        MsgBox("DEBE INGRESAR LA FECHA EN EL FORMATO AÑO-MES-DIA POR EJEMPLO 2016-01-31")
    End Sub

    Private Sub Frm_Listado_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dtp_Fecha_Inicio.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Inicio.CustomFormat = "yyyy/MM/dd"
        Dtp_Fecha_Final.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Final.CustomFormat = "yyyy/MM/dd"
        Btn_Cargar.Enabled = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_Inicio.ValueChanged
        Dtp_Fecha_Final.Enabled = True
    End Sub

    Private Sub Dtp_Fecha_Final_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_Final.ValueChanged
        Btn_Cargar.Enabled = True
    End Sub
End Class