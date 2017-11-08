Imports System.Data.SqlClient
Public Class Frm_Consulta_Reparacion

    Public r As SqlDataReader
    Public reparaciones As New DataTable
    Dim rowIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim colIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim totalRows As Integer ' Se usa en el método selectDownRow
    Dim count As Integer = 0 'para evitar que se ejecute el método Dgv_Actualizaciones_DataSourceChanged al cargar la página
    Private Sub Frm_Consulta_Reparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.
        Me.ARTICULOTableAdapter.Fill(Me.ExactusERP_TABLES.ARTICULO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.ExactusERP_TABLES.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION' Puede moverla o quitarla según sea necesario.
        Me.SCR_DATOS_REPARACIONTableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_DATOS_REPARACION)
        reparaciones.Columns.Add("REPARACION")
        Dgv_Actualizaciones.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 9.25, Font.Style.Bold)
        dg_reps_asociadas.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 9.25, Font.Style.Bold)

    End Sub

    Private Sub Txt_Num_Boleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Num_Boleta.KeyPress
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

    Private Sub Btn_Cotejar_Boleta_Click(sender As Object, e As EventArgs) Handles Btn_Cotejar_Boleta.Click
        If Txt_Num_Boleta.Text = "" Then
            MsgBox("el campo BOLETA no puede ir vacío")
        Else
            reparaciones.Rows.Clear()
            Dim numboleta As String = Txt_Num_Boleta.Text
            Dim comando As New SqlCommand("SELECT REPARACION_NUMERO FROM DBO.SCR_DATOS_REPARACION WHERE DBO.SCR_DATOS_REPARACION.BOLETA ='" & numboleta & "'", cxnc)
            comando.CommandType = CommandType.Text
            cxnc.Open()
            r = comando.ExecuteReader
            While r.Read
                reparaciones.Rows.Add(r.Item("REPARACION_NUMERO"))
            End While

            r.Close()
            cxnc.Close()
            dg_reps_asociadas.DataSource = reparaciones

            Try 'PARA QUE NO SE CAIGA CUANDO EL RESULTADO DE LA BÚSQUEDA SEA CERO
                Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value()
            Catch ex As Exception
                MsgBox("Lo siento, no hay reparaciones asociadas")
            End Try

        End If
    End Sub

    Private Sub Btn_Cotejar_Serie_Click(sender As Object, e As EventArgs) Handles Btn_Cotejar_Serie.Click
        If Txt_Serie.Text = "" Then
            MsgBox("El campo SERIE no puede ir vacío")
        Else
            reparaciones.Rows.Clear()
            Dim numboleta As String = Txt_Serie.Text
            Dim comando As New SqlCommand("SELECT REPARACION_NUMERO FROM DBO.SCR_DATOS_REPARACION WHERE DBO.SCR_DATOS_REPARACION.SERIE_PRODUCTO ='" & numboleta & "'", cxnc)
            comando.CommandType = CommandType.Text
            cxnc.Open()
            r = comando.ExecuteReader
            While r.Read
                reparaciones.Rows.Add(r.Item("REPARACION_NUMERO"))
            End While
            r.Close()
            cxnc.Close()
            dg_reps_asociadas.DataSource = reparaciones


            Try 'PARA QUE NO SE CAIGA CUANDO EL RESULTADO DE LA BÚSQUEDA SEA CERO
                Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value()
            Catch ex As Exception
                MsgBox("Lo siento, no hay reparaciones asociadas")
            End Try
        End If
    End Sub

    Private Sub Cbx_Boleta_TextChanged(sender As Object, e As EventArgs) Handles Cbx_Boleta.TextChanged

        If Cbx_Boleta.Text IsNot "" Then 'para que no se caiga cuando se cierra la ventana, ya que setea como "" y se cae porque se asigna a un Long
            Num_Boleta = Cbx_Boleta.Text
        End If

        Using connection As New SqlConnection("Data Source=SERVER;Initial Catalog=ExactusERP;Persist Security Info=True;User ID=sa;Password=B1@dm1n"),
            command As New SqlCommand("SCR_CONSULTA_REPARACION", connection),
            adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure

            'Add parameters, e.g.
            command.Parameters.AddWithValue("@CONSULTAREP", Num_Boleta)

            Dim table As New DataTable

            'Get the data.
            adapter.Fill(table)

            'Display the data.
            Me.Dgv_Actualizaciones.DataSource = table

        End Using
    End Sub

    Private Sub dg_reps_asociadas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_reps_asociadas.CellClick
        Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value()
    End Sub
    Private Sub dg_reps_asociadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_reps_asociadas.CellContentClick
        Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value()
    End Sub

    Private Sub dg_reps_asociadas_KeyUp(sender As Object, e As KeyEventArgs) Handles dg_reps_asociadas.KeyUp
        selectUpRow()
    End Sub

    Private Sub dg_reps_asociadas_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_reps_asociadas.KeyDown
        selectDownRow()
    End Sub


    'Métodos Para navegar con las flechas arriba y abajo en el datagrid 'reparaciones pendientes'
    Private Sub selectUpRow()
        Try
            rowIndex = dg_reps_asociadas.SelectedCells(0).OwningRow.Index
            If rowIndex >= 0 Then
                colIndex = dg_reps_asociadas.SelectedCells(0).OwningColumn.Index
                dg_reps_asociadas.ClearSelection()
                dg_reps_asociadas.Rows(rowIndex).Cells(colIndex).Selected = True

                Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value().ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub selectDownRow()
        Try
            totalRows = dg_reps_asociadas.Rows.Count
            rowIndex = dg_reps_asociadas.SelectedCells(0).OwningRow.Index
            If (rowIndex <> (totalRows - 1)) Then
                colIndex = dg_reps_asociadas.SelectedCells(0).OwningColumn.Index
                dg_reps_asociadas.ClearSelection()
                dg_reps_asociadas.Rows(rowIndex).Cells(colIndex).Selected = True

                Cbx_Boleta.Text = dg_reps_asociadas.Item(0, dg_reps_asociadas.CurrentRow.Index).Value()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class