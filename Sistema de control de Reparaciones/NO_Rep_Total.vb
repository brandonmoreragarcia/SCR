Public Class Frm_Rep_Total
    Private Sub Frm_Rep_Total_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADOS_TOTAL' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADOS_TOTALTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADOS_TOTAL)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO' Puede moverla o quitarla según sea necesario.
        Me.SCR_PROC_REP_LISTADOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO' Puede moverla o quitarla según sea necesario.
        Me.SCR_PROC_REP_LISTADOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_PROC_REP_LISTADO)
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

    Private Sub Cbx_Estados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Estados.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SCRPROCREPLISTADOBindingSource.Filter = ""
        Check_Estado.CheckState = CheckState.Unchecked
        Check_fecha.CheckState = CheckState.Unchecked
        Lbl_Fecha_Inicio.Visible = False
        Lbl_Fecha_Final.Visible = False
        Dtp_Fecha_Inicio.Visible = False
        Dtp_Fecha_Final.Visible = False
        Cbx_Estados.Visible = False
    End Sub

    Private Sub Btn_Filtrar_Click(sender As Object, e As EventArgs) Handles Btn_Filtrar.Click
        If Check_Estado.CheckState = CheckState.Unchecked And Check_fecha.CheckState = CheckState.Unchecked Then
        ElseIf Check_Estado.CheckState = CheckState.Unchecked And Check_fecha.CheckState = CheckState.Checked Then
            SCRPROCREPLISTADOBindingSource.Filter = "FECHA >= '" & Dtp_Fecha_Inicio.Text & "' AND FECHA <='" & Dtp_Fecha_Final.Text & "'"
        ElseIf Check_Estado.CheckState = CheckState.Checked And Check_fecha.CheckState = CheckState.Unchecked Then
            SCRPROCREPLISTADOBindingSource.Filter = "ESTADO = '" & Cbx_Estados.Text & "'"
        Else
            SCRPROCREPLISTADOBindingSource.Filter = "FECHA >= '" & Dtp_Fecha_Inicio.Text & "' AND FECHA <='" & Dtp_Fecha_Final.Text & "' AND ESTADO = '" & Cbx_Estados.Text & "'"
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Rep_Total.CellContentDoubleClick
        Num_Boleta = Dgv_Rep_Total.Item(0, Dgv_Rep_Total.CurrentRow.Index).Value()
        Frm_Consulta_Reparacion.Show()
    End Sub

    Private Sub Dgv_Rep_Total_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Rep_Total.CellContentClick

    End Sub
End Class