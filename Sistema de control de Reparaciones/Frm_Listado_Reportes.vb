Public Class Frm_Listado_Reportes
    Dim cliente As Boolean
    Dim solicitud As Boolean
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Consulta_Cliente.Click
        If Txt_Dato.Text = "" Then
            MsgBox("LA CASILLA DATO DEBE TENER INFORMACION")
        Else
            If cliente = True Then

                If cliente_existe(Txt_Dato.Text) = True Then
                    Try
                        CONSULTA_CLIENTE = Txt_Dato.Text
                        My.Forms.Frm_Consulta_Cliente.MdiParent = My.Forms.Frm_Main_Menu
                        Frm_Consulta_Cliente.Show()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                    MsgBox("El cliente: " + Txt_Dato.Text + " No aparece registrado en el sistema")

                End If
            Else
                MsgBox("El cliente: " + Txt_Dato.Text + " No aparece registrado en el sistema")
            End If
        End If
    End Sub

    Private Sub Frm_Listado_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Lbl_Reparacion_Click(sender As Object, e As EventArgs) Handles Lbl_Reparacion.Click
        If Txt_Dato.Text = "" Then
            MsgBox("LA CASILLA DATO DEBE TENER INFORMACION")
        Else
            If solicitud = True Then

                If numero_rep(Txt_Dato.Text) = True Then
                    Try
                        Num_Boleta = Txt_Dato.Text
                        My.Forms.Frm_Consulta_Reparacion.MdiParent = Frm_Main_Menu
                        Frm_Consulta_Reparacion.Show()

                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                    MsgBox("La Reparacion: " + Txt_Dato.Text + " No ha sido ingresada al sistema")

                End If
            Else
                MsgBox("La Reparacion  con numero de boleta: " + Txt_Dato.Text + " No ha sido ingresada al sistema")
            End If
        End If
    End Sub

    Private Sub Txt_Reparacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Dato.KeyPress
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

    Private Sub Lb_impresion_Rep_Click(sender As Object, e As EventArgs) Handles Lb_impresion_Rep.Click
        My.Forms.Frm_Impresion_Rep.MdiParent = Frm_Main_Menu
        Frm_Impresion_Rep.Show()
        Me.Close()
    End Sub

    Private Sub Lbl_Listado_Rep_Click(sender As Object, e As EventArgs) Handles Lbl_Listado_Rep.Click
        My.Forms.Frm_Listado_Rep.MdiParent = Frm_Main_Menu
        Frm_Listado_Rep.Show()
        Me.Close()
    End Sub

    Private Sub Lbl_Listado_Rep_Estado_Click_1(sender As Object, e As EventArgs) Handles Lbl_Listado_Rep_Estado.Click
        My.Forms.Frm_Rep_Total.MdiParent = Frm_Main_Menu
        Frm_Rep_Total.Show()
        Me.Close()
    End Sub

    Private Sub Lbl_Etiqueta_Salida_Click_1(sender As Object, e As EventArgs) Handles Lbl_Etiqueta_Salida.Click
        My.Forms.Frm_Impresion_Etiqueta_Salida.MdiParent = Frm_Main_Menu
        Frm_Impresion_Etiqueta_Salida.Show()
        Me.Close()
    End Sub

    Private Sub Lbl_Listado_Quejas_Click(sender As Object, e As EventArgs) Handles Lbl_Listado_Quejas.Click
        My.Forms.Frm_Listado_Quejas.MdiParent = Frm_Main_Menu
        Frm_Listado_Quejas.Show()
        Me.Close()
    End Sub

    Private Sub Lbl_Consulta_Num_Queja_Click(sender As Object, e As EventArgs) Handles Lbl_Consulta_Num_Queja.Click
        My.Forms.Frm_Consulta_Num_Queja.MdiParent = Frm_Main_Menu
        Num_Queja = 0
        Frm_Consulta_Num_Queja.Show()
        Me.Close()
    End Sub
End Class