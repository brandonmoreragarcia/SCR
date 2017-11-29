Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Listado_Reportes
    Dim cliente As Boolean
    Dim solicitud As Boolean
    Dim cargar_bindings As Boolean = True

    Private Sub Frm_Listado_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO' Puede moverla o quitarla según sea necesario.
        Me.SCR_PROC_REP_LISTADOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO)
        cliente = True
        solicitud = True

    End Sub

    Private Sub Txt_Consulta_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If Char.IsSeparator(e.KeyChar) Then e.Handled = False Else e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_Reparacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo_cliente.KeyPress
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


    '////////////////
    '////////////////

    ' /////////////////////////////    LISTADO REPARACION ESTADO     ////////////////////////////

    '////////////////
    '////////////////

    Private Sub cargarBindingSource()

        'para que el método se ejecute solo una vez'
        If cargar_bindings Then
            'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADOS_TOTAL' Puede moverla o quitarla según sea necesario.
            Me.SCR_PROC_REP_LISTADOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO)
            'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO' Puede moverla o quitarla según sea necesario.
            Me.SCR_PROC_REP_LISTADOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO)
            Dgv_Rep_Total.DataSource = bs_lista_reportes
            Dgv_Rep_Total.ColumnHeadersDefaultCellStyle.Font = New Drawing.Font("Square721 BT", 9, Font.Style.Bold)
            cargar_bindings = False
        End If
    End Sub

    Private Sub bt_listado_rep_estado_Click(sender As Object, e As EventArgs) Handles bt_listado_rep_estado.Click

        Me.SCR_ESTADOS_TOTALTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADOS_TOTAL)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO' Puede moverla o quitarla según sea necesario.

        gb_reparaciones_estado.Visible = True
        gb_consulta_cliente.Visible = False
        gb_reparacion_lead.Visible = False

        Dtp_Fecha_Inicio.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Inicio.CustomFormat = "yyyy/MM/dd"
        Dtp_Fecha_Final.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Final.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub Check_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles Check_fecha.CheckedChanged
        If Check_fecha.CheckState = CheckState.Checked Then
            Lbl_Fecha_Inicio.Visible = True
            Lbl_Fecha_Final.Visible = True
            Dtp_Fecha_Inicio.Visible = True
            Dtp_Fecha_Final.Visible = True
        Else
            Lbl_Fecha_Inicio.Visible = False
            Lbl_Fecha_Final.Visible = False
            Dtp_Fecha_Inicio.Visible = False
            Dtp_Fecha_Final.Visible = False
        End If
    End Sub

    Private Sub Check_Estado_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Estado.CheckedChanged
        If Check_Estado.CheckState = CheckState.Checked Then
            Cbx_Estados.Visible = True
        Else
            Cbx_Estados.Visible = False
        End If
    End Sub

    Private Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click

        cargarBindingSource()

        If Check_Estado.CheckState = CheckState.Unchecked And Check_fecha.CheckState = CheckState.Unchecked Then
        ElseIf Check_Estado.CheckState = CheckState.Unchecked And Check_fecha.CheckState = CheckState.Checked Then
            bs_lista_reportes.Filter = "FECHA >= '" & Dtp_Fecha_Inicio.Text & "' AND FECHA <='" & Dtp_Fecha_Final.Text & "'"
        ElseIf Check_Estado.CheckState = CheckState.Checked And Check_fecha.CheckState = CheckState.Unchecked Then
            bs_lista_reportes.Filter = "ESTADO = '" & Cbx_Estados.Text & "'"
        Else
            bs_lista_reportes.Filter = "FECHA >= '" & Dtp_Fecha_Inicio.Text & "' AND FECHA <='" & Dtp_Fecha_Final.Text & "' AND ESTADO = '" & Cbx_Estados.Text & "'"
        End If
    End Sub

    Private Sub Dgv_Rep_Total_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Rep_Total.CellContentDoubleClick
        Num_Boleta = Dgv_Rep_Total.Item(0, Dgv_Rep_Total.CurrentRow.Index).Value()
        Frm_Consulta_Reparacion.Show()
    End Sub


    '////////////////
    '////////////////

    ' /////////////////////////////    LISTADO REPARACION LEAD     ////////////////////////////

    '////////////////
    '////////////////

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


    Private Sub bt_listado_rep_lead_Click(sender As Object, e As EventArgs) Handles bt_listado_rep_lead.Click
        gb_reparaciones_estado.Visible = False
        gb_consulta_cliente.Visible = False
        gb_reparacion_lead.Visible = True

        Dtp_Fecha_Inicio_lead.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Inicio_lead.CustomFormat = "yyyy/MM/dd"
        Dtp_Fecha_Final_lead.Format = DateTimePickerFormat.Custom
        Dtp_Fecha_Final_lead.CustomFormat = "yyyy/MM/dd"

    End Sub

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
            fecha_inicio.Value = Dtp_Fecha_Inicio_lead.Text
            fecha_final.Value = Dtp_Fecha_Final_lead.Text
            param.Add(fecha_inicio)
            param2.Add(fecha_final)
            cryRpt.DataDefinition.ParameterFields("@FECHA_INICIO").ApplyCurrentValues(param)
            cryRpt.DataDefinition.ParameterFields("@FECHA_FINAL").ApplyCurrentValues(param2)
            Crv_Listado_Rep.ReportSource = cryRpt
            Crv_Listado_Rep.Refresh()
            Txt_Fecha_Final.Text = ""
            Txt_Fecha_Inicial.Text = ""

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

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_Inicio.ValueChanged
        Dtp_Fecha_Final.Enabled = True
    End Sub

    Private Sub Dtp_Fecha_Final_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_Final.ValueChanged
        Btn_Cargar.Enabled = True
    End Sub


    '////////////////
    '////////////////

    ' /////////////////////////////    CONSULTA NÚMERO QUEJA     ////////////////////////////

    '////////////////
    '////////////////

    Private Sub bt_consulta_num_queja_Click(sender As Object, e As EventArgs) Handles bt_consulta_num_queja.Click
        My.Forms.Frm_Consulta_Num_Queja.MdiParent = Frm_Main_Menu
        Num_Queja = 0
        Frm_Consulta_Num_Queja.Show()
        Me.Close()
    End Sub


    '////////////////
    '////////////////

    ' /////////////////////////////    IMPRESION REPARACIÓN     ////////////////////////////

    '////////////////
    '////////////////


    Private Sub bt_impresion_reparacion_Click(sender As Object, e As EventArgs) Handles bt_impresion_reparacion.Click
        My.Forms.Frm_Impresion_Rep.MdiParent = Frm_Main_Menu
        Frm_Impresion_Rep.Show()
        Me.Close()

    End Sub


    '////////////////
    '////////////////

    ' /////////////////////////////    CONSULTA CLIENTE     ////////////////////////////

    '////////////////
    '////////////////


    Private Sub bt_consulta_cliente_Click(sender As Object, e As EventArgs) Handles bt_consulta_cliente.Click

        gb_reparaciones_estado.Visible = False
        gb_consulta_cliente.Visible = True
        gb_reparacion_lead.Visible = False

    End Sub

    Private Sub bt_listado_quejas_Click(sender As Object, e As EventArgs) Handles bt_listado_quejas.Click
        My.Forms.Frm_Listado_Quejas.MdiParent = Frm_Main_Menu
        Frm_Impresion_Queja.Show()
        Me.Close()
    End Sub

    Private Sub bt_etiqueta_salida_Click(sender As Object, e As EventArgs) Handles bt_etiqueta_salida.Click
        My.Forms.Frm_Impresion_Etiqueta_Salida.MdiParent = Frm_Main_Menu
        Frm_Impresion_Etiqueta_Salida.Show()
        Me.Close()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        If txt_codigo_cliente.Text = "" Then
            MsgBox("LA CASILLA DATO DEBE TENER INFORMACION")
        Else
            If cliente = True Then

                If cliente_existe(txt_codigo_cliente.Text) = True Then


                    Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
                        Command As New SqlCommand("SCR_PROC_CONSULTA_CLIENTE", connection), adapter As New SqlDataAdapter(Command)
                        Command.CommandType = CommandType.StoredProcedure

                        'Add parameters, e.g.
                        Command.Parameters.AddWithValue("@COD_CLIENTE", txt_codigo_cliente.Text)

                        Dim table As New DataTable

                        'Get the data.
                        adapter.Fill(table)

                        'Display the data.
                        Me.Dgv_Consulta_Cliente.DataSource = table


                    End Using
                Else

                    MsgBox("El cliente: " + txt_codigo_cliente.Text + " No aparece registrado en el sistema")

                End If
            Else
                MsgBox("El cliente: " + txt_codigo_cliente.Text + " No aparece registrado en el sistema")
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