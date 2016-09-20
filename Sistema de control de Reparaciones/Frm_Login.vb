Public Class Frm_Login

    Dim user As String
    Dim password As String
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        user = Txt_Usuario.Text
        password = Txt_password.Text

        If user = "jpicado" And password = "exjpicado" Then
            Main_Menu.Lbl_Entrada_Datos.Visible = True
            Main_Menu.Btn_Entrada_Datos.Visible = True
            Me.Close()

        Else
            Dim Msg As MsgBoxResult
            Msg = MsgBox("Contraseña incorrecta, ¿Desea salir?", vbYesNo, "Salir del Modulo")
            If Msg = MsgBoxResult.Yes Then
                Application.ExitThread()
            Else
                Txt_Usuario.Text = ""
                Txt_password.Text = ""
                Exit Sub
            End If

        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.ExitThread()
    End Sub

End Class
