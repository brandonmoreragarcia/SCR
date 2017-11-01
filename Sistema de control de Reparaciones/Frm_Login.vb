Imports System.Data.SqlClient

Public Class Frm_Login
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Txt_Usuario.Text = UCase(Txt_Usuario.Text)

        Try
            If usuarioRegistrado(Txt_Usuario.Text) = True Then
                Dim contra As String = contrasena(Txt_Usuario.Text)
                If contra.Equals(Txt_password.Text) = True Then
                    My.Forms.Frm_Main_Menu.Tsp_Menu.Enabled = True
                    v_usuario = Txt_Usuario.Text
                    My.Forms.Frm_Main_Menu.Lbl_Usuario.Text = v_usuario
                    Me.Close()

                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + Txt_Usuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.ExitThread()
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub

    Private Sub Txt_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Usuario.KeyPress

    End Sub

    Private Sub Txt_Usuario_TextChanged(sender As Object, e As EventArgs) Handles Txt_Usuario.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
