Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_Impresion_Rep
    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click
        If cb_Numero_Rep.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            If numero_rep(cb_Numero_Rep.Text) = True Then
                If rep_cerrada(cb_Numero_Rep.Text) = True Then
                    MsgBox("La Reparacion: " + cb_Numero_Rep.Text + " Ya ha sido CERRADA por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                Else
                    If impre_rep(cb_Numero_Rep.Text) = True Then
                        Dim numboleta As String = cb_Numero_Rep.Text
                        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_CONTROL_IMPR_REP WHERE DBO.SCR_CONTROL_IMPR_REP.REPARACION_NUMERO ='" & numboleta & "'", cxnc)
                        cmd3.CommandType = CommandType.Text
                        Dim n As Date
                        cxnc.Open()
                        n = CDate(cmd3.ExecuteScalar())
                        cxnc.Close()
                        MsgBox("La Reparacion: " + cb_Numero_Rep.Text + " Ya ha sido IMPRESA el dia " + n + " por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
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
                            mydiscretevalue.Value = cb_Numero_Rep.Text
                            param.Add(mydiscretevalue)
                            cryRpt.DataDefinition.ParameterFields("@REPNUMERO").ApplyCurrentValues(param)
                            Crv_Impresion_Rep.ReportSource = cryRpt
                            Crv_Impresion_Rep.Refresh()


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

    End Sub

    Private Sub Btn_Exportar_Click(sender As Object, e As EventArgs) Handles Btn_Exportar.Click
        Crv_Impresion_Rep.ExportReport()
        CONTROL_IMPR()

    End Sub

    Private Sub CONTROL_IMPR()
        Dim sql As String = "insert into SCR_CONTROL_IMPR_REP values(@REPARACION_NUMERO,@FECHA)"
        Dim cmd As New SqlCommand(sql, cxnc)

        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = cb_Numero_Rep.Text
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
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

    Private Sub Btn_Imprimir_Consumo_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir_Consumo.Click
        If cb_Numero_Rep.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            If numero_rep(cb_Numero_Rep.Text) = True Then
                If impre_rep_consumo(cb_Numero_Rep.Text) = True Then
                    Dim numboleta As String = cb_Numero_Rep.Text
                    Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_CONTROL_IMPR_REP_CON WHERE DBO.SCR_CONTROL_IMPR_REP_CON.REPARACION_NUMERO ='" & numboleta & "'", cxnc)
                    cmd3.CommandType = CommandType.Text
                    Dim n As Date
                    cxnc.Open()
                    n = CDate(cmd3.ExecuteScalar())
                    cxnc.Close()
                    MsgBox("La Reparacion: " + cb_Numero_Rep.Text + " Ya ha sido IMPRESA el dia " + n + " por tanto no puede ser impresa, debe comunicarse con un administrador para quitar el bloqueo")
                Else
                    My.Forms.Frm_Impresion_Rep_Consumo.MdiParent = Frm_Main_Menu
                    num_rep = cb_Numero_Rep.Text
                    Me.Enabled = False
                    Frm_Impresion_Rep_Consumo.Show()

                End If
            Else
                MsgBox("Lo sentimos la reparacion no existe")
            End If
        End If

    End Sub

    Private Sub SCR_DATOS_REPARACIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SCR_DATOS_REPARACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ExactusERP_SRC_TABLES)

    End Sub

    Private Sub SCR_DATOS_REPARACIONBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SCR_DATOS_REPARACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ExactusERP_SRC_TABLES)

    End Sub

    Private Sub Frm_Impresion_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_REPARACIONES_POR_IMPRIMIR' Puede moverla o quitarla según sea necesario.
        Me.SCR_REPARACIONES_POR_IMPRIMIRTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_REPARACIONES_POR_IMPRIMIR)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION' Puede moverla o quitarla según sea necesario.
        Me.SCR_DATOS_REPARACIONTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION)



    End Sub

    Private Sub cb_Numero_Rep_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles cb_Numero_Rep.KeyPress

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