Imports System.Data.SqlClient
Public Class Frm_Actualizacion_Trans
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Frm_Actualizacion_Trans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS' Puede moverla o quitarla según sea necesario.
        Me.SCR_LOCALIZACION_TRANSTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_LOCALIZACION_TRANS)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_TRANSPORTETableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ESTADO_TRANSPORTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_TABLES.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERP_TABLES.ARTICULO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION' Puede moverla o quitarla según sea necesario.
        Me.SCR_DATOS_REPARACIONTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION)
        Cbx_Boleta.Text = Num_Boleta
        Cbx_dummy1.Text = Lbl_Cliente.Text
        Cbx_Dummy2.Text = Lbl_Articulo.Text
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Frm_Actualizacion_Trans_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Forms.Frm_Main_Menu.Btn_Transporte.Enabled = True
    End Sub

    Private Sub Btn_Grabar_Actua_Click(sender As Object, e As EventArgs) Handles Btn_Grabar_Actua.Click
        'ACTUA()
    End Sub

    Private Sub Cbx_Estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Estado.SelectedIndexChanged
        Cbx_Localizacion.Enabled = True
    End Sub

    Private Sub Cbx_Localizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Localizacion.SelectedIndexChanged
        Txt_Comentario.Enabled = True
    End Sub


    Private Sub Cbx_Estado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Estado.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Localizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Localizacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txt_Comentario_TextChanged(sender As Object, e As EventArgs) Handles Txt_Comentario.TextChanged
        Btn_Grabar_Actua.Enabled = True
        Btn_Grabar_Actua.Visible = True
    End Sub

    Private Sub Lbl_Comentario_Click(sender As Object, e As EventArgs) Handles Lbl_Comentario.Click

    End Sub

    Private Sub Lbl_Localizacion_Click(sender As Object, e As EventArgs) Handles Lbl_Localizacion.Click

    End Sub

    Private Sub Lbl_Estado_Click(sender As Object, e As EventArgs) Handles Lbl_Estado.Click

    End Sub
End Class