Public Class Frm_Ingreso_Boletas
    Private Sub Frm_Ingreso_Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

End Class