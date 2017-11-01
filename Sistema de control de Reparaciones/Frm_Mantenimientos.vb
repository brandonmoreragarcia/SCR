Public Class Frm_Mantenimientos
    Private Sub Btn_Usuarios_Click(sender As Object, e As EventArgs) Handles Btn_Usuarios.Click
        My.Forms.Frm_Mantenimiento_Usuarios.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Usuarios.Show()
    End Sub

    Private Sub Btn_Traido_Por_Click(sender As Object, e As EventArgs) Handles Btn_Traido_Por.Click
        My.Forms.Frm_Mantenimiento_Traido_Por.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Traido_Por.Show()
    End Sub

    Private Sub Btn_Transporte_Click(sender As Object, e As EventArgs) Handles Btn_Transporte.Click
        My.Forms.Frm_Mantenimiento_Transporte.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Transporte.Show()
    End Sub

    Private Sub Btn_Motivos_Click(sender As Object, e As EventArgs) Handles Btn_Motivos.Click
        My.Forms.Frm_Mantenimiento_Motivo.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Motivo.Show()
    End Sub

    Private Sub Btn_Encargado_Bodega_Click(sender As Object, e As EventArgs) Handles Btn_Encargado_Bodega.Click
        My.Forms.Frm_Mantenimiento_Encargado_Bodega.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Encargado_Bodega.Show()
    End Sub

    Private Sub Btn_Estado_Click(sender As Object, e As EventArgs) Handles Btn_Estado.Click
        My.Forms.Frm_Mantenimiento_Estado.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Estado.Show()
    End Sub

    Private Sub Btn_Localizacion_Click(sender As Object, e As EventArgs) Handles Btn_Localizacion.Click
        My.Forms.Frm_Mantenimiento_Localizacion.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Localizacion.Show()
    End Sub

    Private Sub Btn_Estado_Ruta_Click(sender As Object, e As EventArgs) Handles Btn_Estado_Ruta.Click
        My.Forms.Frm_Mantenimiento_Estado_Ruta.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Estado_Ruta.Show()
    End Sub

    Private Sub Btn_Localizacion_Ruta_Click(sender As Object, e As EventArgs) Handles Btn_Localizacion_Ruta.Click
        My.Forms.Frm_Mantenimiento_Localizacion_Ruta.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Localizacion_Ruta.Show()
    End Sub

    Private Sub Btn_Motivo_Queja_Click(sender As Object, e As EventArgs) Handles Btn_Motivo_Queja.Click
        My.Forms.Frm_Mantenimiento_Motivo_Queja.MdiParent = My.Forms.Frm_Main_Menu
        Frm_Mantenimiento_Motivo_Queja.Show()
    End Sub
End Class