Public Class Frm_Entrada
    Private Sub Frm_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERPDataSet.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERPDataSet.ARTICULO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_cliente_d86.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_cliente_d86.CLIENTE)

    End Sub
End Class
