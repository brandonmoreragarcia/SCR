Imports System.Windows.Forms

Public Class Frm_Main_Menu


    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.Frm_Login.MdiParent = Me
        Frm_Login.Show()
    End Sub

    Private Sub Btn_Entrada_Datos_Click(sender As Object, e As EventArgs) Handles Btn_Entrada_Datos.Click
        If privilegio_entrada_rep(v_usuario) = True Then
            My.Forms.Frm_Entrada.MdiParent = Me
            Frm_Entrada.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Reparaciones_Click(sender As Object, e As EventArgs) Handles Btn_Reparaciones.Click
        If privilegio_actua_rep(v_usuario) = True Then
            My.Forms.Frm_Actualizacion_Rep.MdiParent = Me
            Frm_Actualizacion_Rep.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Transporte_Click(sender As Object, e As EventArgs) Handles Btn_Transporte.Click
        If privilegio_trans_rep(v_usuario) = True Then
            My.Forms.Frm_Solicitud_Boleta_Tran.MdiParent = Me
            Frm_Solicitud_Boleta_Tran.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Reportes_Click(sender As Object, e As EventArgs) Handles Btn_Reportes.Click
        If privilegio_reportes(v_usuario) = True Then
            My.Forms.Frm_Listado_Reportes.MdiParent = Me
            Frm_Listado_Reportes.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Busqueda_Click(sender As Object, e As EventArgs) Handles Btn_Busqueda.Click
        If privilegio_busqueda_boleta(v_usuario) = True Then
            My.Forms.Frm_Busqueda.MdiParent = Me
            Frm_Busqueda.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Ingreso_Queja_Click(sender As Object, e As EventArgs) Handles Btn_Ingreso_Queja.Click
        If privilegio_entrada_queja(v_usuario) = True Then
            My.Forms.Frm_Ingreso_Queja.MdiParent = Me
            Frm_Ingreso_Queja.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TBtn_Actua_Queja_Click(sender As Object, e As EventArgs) Handles Btn_Actua_Queja.Click
        If privilegio_actua_queja(v_usuario) = True Then
            My.Forms.Frm_Consulta_Queja.MdiParent = Me
            Frm_Consulta_Queja.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Mantenimiento_Click(sender As Object, e As EventArgs) Handles Btn_Mantenimiento.Click
        If privilegio_mantenimiento(v_usuario) = True Then
            My.Forms.Frm_Mantenimientos.MdiParent = Me
            Frm_Mantenimientos.Show()
        Else
            MsgBox("Lo siento, al parecer no tienes acceso a esta funcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Btn_Cambia_Usuario_Click(sender As Object, e As EventArgs) Handles Btn_Cambia_Usuario.Click
        My.Forms.Frm_Main_Menu.Tsp_Menu.Enabled = False
        My.Forms.Frm_Login.MdiParent = Me
        Frm_Login.Show()
    End Sub
End Class
