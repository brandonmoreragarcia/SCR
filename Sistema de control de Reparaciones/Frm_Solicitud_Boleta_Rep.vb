Public Class Frm_Solicitud_Boleta_Rep
    Dim solicitud As Boolean
    Private Sub Frm_Solicitud_Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.Frm_Main_Menu.Btn_Reparaciones.Enabled = False
        Num_Boleta = 0
    End Sub

    Private Sub Btn_Cargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar.Click
        If Txt_Reparacion.Text = "" Then
            MsgBox("DEBE INGRESAR UN NUMERO DE REPARACION")
        Else
            solicitud = True
            If solicitud = True Then

                If numero_rep(Txt_Reparacion.Text) = True Then
                    If rep_cerrada(Txt_Reparacion.Text) = True Then
                        MsgBox("La Reparacion: " + Txt_Reparacion.Text + " Ya ha sido cerrada por tanto no acepta mas actualizaciones, debe comunicarse con un administrador para quitar el bloqueo")
                    Else
                        Try
                            Num_Boleta = Txt_Reparacion.Text
                            My.Forms.Frm_Actualizacion_Rep.MdiParent = Frm_Main_Menu
                            Frm_Actualizacion_Rep.Show()
                            Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                Else

                        MsgBox("La Reparacion: " + Txt_Reparacion.Text + " No ha sido ingresada al sistema")

                End If
            Else
                MsgBox("La Reparacion  con numero de boleta: " + Txt_Boleta.Text + " No ha sido ingresada al sistema")
            End If
        End If

    End Sub

    Private Sub Rbt_Numero_Reparacion_CheckedChanged(sender As Object, e As EventArgs) Handles Rbt_Numero_Reparacion.CheckedChanged
        solicitud = True
        Txt_Reparacion.Enabled = True
        Txt_Boleta.Text = ""
        Txt_Boleta.Enabled = False
    End Sub

    Private Sub Rbt_Numero_Boleta_CheckedChanged(sender As Object, e As EventArgs) Handles Rbt_Numero_Boleta.CheckedChanged
        solicitud = False
        Txt_Boleta.Enabled = True
        Txt_Reparacion.Text = ""
        Txt_Reparacion.Enabled = False
    End Sub

    Private Sub Frm_Solicitud_Boleta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Num_Boleta = 0 Then
            My.Forms.Frm_Main_Menu.Btn_Reparaciones.Enabled = True
        Else

        End If
    End Sub

    Private Sub Txt_Reparacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Reparacion.KeyPress
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

    Private Sub Txt_Boleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Boleta.KeyPress
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

    Private Sub Lbl_Solicitud_Boleta_Click(sender As Object, e As EventArgs) Handles Lbl_Solicitud_Boleta.Click

    End Sub

    Private Sub Txt_Reparacion_TextChanged(sender As Object, e As EventArgs) Handles Txt_Reparacion.TextChanged

    End Sub
End Class