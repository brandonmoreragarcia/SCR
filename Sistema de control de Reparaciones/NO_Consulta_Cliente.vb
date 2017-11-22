Imports System.Data.SqlClient
Public Class NO_Consulta_Cliente

    Private Sub Frm_Consulta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SCR_VISTA_REPARA_CLIENTETableAdapter.FillBy(Me.ExactusERP_SRC_TABLES.SCR_VISTA_REPARA_CLIENTE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SCR_VISTA_REPARA_CLIENTETableAdapter.FillBy1(Me.ExactusERP_SRC_TABLES.SCR_VISTA_REPARA_CLIENTE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Dgv_Consulta_Cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Consulta_Cliente.CellClick
        Try
            Dim index As Integer
            index = Dgv_Consulta_Cliente.CurrentRow.Index
            Lbl_Rep_Numero.Text = Dgv_Consulta_Cliente.Item(0, index).Value()
            Lbl_Actua_Num.Text = Dgv_Consulta_Cliente.Item(1, index).Value()
            Lbl_Cod_Cliente.Text = Dgv_Consulta_Cliente.Item(2, index).Value()
            Lbl_Nombre.Text = Dgv_Consulta_Cliente.Item(3, index).Value()
            Lbl_Alias.Text = Dgv_Consulta_Cliente.Item(4, index).Value()
            Lbl_Cod_Articulo.Text = Dgv_Consulta_Cliente.Item(5, index).Value()
            Lbl_Descripcion_Articulo.Text = Dgv_Consulta_Cliente.Item(6, index).Value()
            Lbl_Problema_Reportado.Text = Dgv_Consulta_Cliente.Item(7, index).Value()
            Lbl_Estado.Text = Dgv_Consulta_Cliente.Item(8, index).Value()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

End Class


