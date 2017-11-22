Imports System.Data.SqlClient
Public Class Frm_Consulta_Queja

    Dim rowIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim colIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim totalRows As Integer ' Se usa en el método selectDownRow

    Private Sub Frm_Consulta_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)

        BindingSource_datagrid.Filter = "ESTADO <> '" & "SOLUCIONADO" & "'"
        If dg_quejas_pendientes.RowCount <> 0 Then 'Para que no se caiga el programa cuando no hay reparaciones pendientes'
            Txt_Num_Queja.Text = dg_quejas_pendientes.Item(0, dg_quejas_pendientes.CurrentRow.Index).Value
        End If

    End Sub

    Private Sub Txt_Num_Queja_TextChanged(sender As Object, e As EventArgs) Handles Txt_Num_Queja.TextChanged
        Num_Queja = Txt_Num_Queja.Text
        SCRULTIMOESTADOQUEJABindingSource.Filter = "NUMERO_QUEJA = '" & Num_Queja & "'"
        Lbl_Alias.Visible = True
        Lbl_Cod_Cliente.Visible = True
        Lbl_Contacto.Visible = True
        Lbl_Detalle.Visible = True
        Lbl_Direccion.Visible = True
        Lbl_Estado_Actual.Visible = True
        Lbl_Factua.Visible = True
        Lbl_Fecha_Estado.Visible = True
        Lbl_Fecha_Ingreso.Visible = True
        Lbl_Motivo.Visible = True
        Lbl_Nombre.Visible = True
        Lbl_Proforma.Visible = True
        Lbl_Telefonos.Visible = True
        Lbl_Tel_1.Visible = True
        Lbl_Tel_2.Visible = True
        Rbtn_Procesar.Visible = True
        Rbtn_Solucionar.Visible = True
        Rbtn_Procesada.Visible = True
        lb_detalle_queja.Visible = True
    End Sub

    Private Sub Txt_Num_Queja_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt_Num_Queja.MouseClick
        'My.Forms.Frm_Listado_Quejas.Btn_Selec_Queja.Visible = True
        'My.Forms.Frm_Listado_Quejas.MdiParent = Frm_Main_Menu
        'T_busqueda_Queja = 2
        'Frm_Listado_Quejas.Show()

    End Sub

    Private Sub Acciones_Queja_Solucionada()
        'Se trae la fecha de la QUEJA SOLUCIONADA y la muestra al usuario'
        Dim numboleta As String = Txt_Num_Queja.Text
        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
        cmd3.CommandType = CommandType.Text
        Dim n As Date
        cxnc.Open()
        n = CDate(cmd3.ExecuteScalar())
        cxnc.Close()
        MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue Solucionada desde el  " + n + " No admite cambios de Estado")
    End Sub

    Private Sub Acciones_Queja_Procesada()
        'Obtiene  la FECHA EN LA CUAL SE PROCESÓ la queja'
        Dim numboleta As String = Txt_Num_Queja.Text
        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCESADAS WHERE DBO.SCR_QUEJAS_PROCESADAS.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
        cmd3.CommandType = CommandType.Text
        Dim n As Date
        cxnc.Open()
        n = CDate(cmd3.ExecuteScalar())
        cxnc.Close()
        MsgBox("La Queja: " + Txt_Num_Queja.Text + " Fue procesada desde el  " + n + " Seleccione un estado Diferente")
    End Sub

    'Obtiene la FECHA EN LA CUAL SE EMPEZÓ A PROCESAR LA FECHA'
    Private Sub Acciones_Queja_Procesando()
        Dim numboleta As String = Txt_Num_Queja.Text
        Dim cmd3 = New SqlCommand("SELECT FECHA FROM DBO.SCR_QUEJAS_PROCES WHERE DBO.SCR_QUEJAS_PROCES.NUMERO_QUEJA ='" & numboleta & "'", cxnc)
        cmd3.CommandType = CommandType.Text
        Dim n As Date
        cxnc.Open()
        n = CDate(cmd3.ExecuteScalar())
        cxnc.Close()
        MsgBox("La Queja: " + Txt_Num_Queja.Text + " Se encuentra en proceso desde el  " + n + " Seleccione un estado Diferente")
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        Try
            If Txt_Num_Queja.Text IsNot "" Then

                If Verificar_Queja() Then

                    'Procesada'
                    If Rbtn_Procesada.Checked Then

                        'La queja está en estado Solucionada'
                        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
                            Acciones_Queja_Solucionada()
                        Else
                            'la queja está en estado Procesada'
                            If Queja_Procesada(Txt_Num_Queja.Text) = True Then
                                Acciones_Queja_Procesada()
                            Else
                                My.Forms.Frm_Procesada_Queja.MdiParent = Frm_Main_Menu

                                Frm_Procesada_Queja.Show()

                                'para controlar la ventana, y para que se muestre por encima la ventana de guardar'
                                Me.Enabled = False

                                'Actualiza el binding source para ver los cambios reflejados en la pantalla'
                                Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)
                            End If
                        End If

                    End If

                    'Solucionar'
                    If Rbtn_Solucionar.Checked Then
                        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
                            Acciones_Queja_Solucionada()
                        Else
                            My.Forms.Frm_Solucion_Queja.MdiParent = Frm_Main_Menu
                            Frm_Solucion_Queja.Show()

                            'para controlar la ventana, y para que se muestre por encima la ventana de guardar'
                            Me.Enabled = False

                            'Actualiza el binding source para ver los cambios reflejados en la pantalla'
                            Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)
                        End If
                    End If



                    'Procesar'
                    If Rbtn_Procesar.Checked Then

                        If Queja_Solucionada(Txt_Num_Queja.Text) = True Then
                            Acciones_Queja_Solucionada()
                        Else
                            If Queja_Procesada(Txt_Num_Queja.Text) = True Then
                                Acciones_Queja_Procesada()

                            Else
                                If Queja_Proces(Txt_Num_Queja.Text) = True Then
                                    Acciones_Queja_Procesando()
                                Else
                                    'se procede a procesar la queja'
                                    Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
                                    Dim cmd2 As New SqlCommand(sql2, cxnc)
                                    cxnc.Open()
                                    cmd2.Parameters.Add("@NUMERO_QUEJA", SqlDbType.Int).Value = Me.Txt_Num_Queja.Text
                                    cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "PROCESANDO"
                                    cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                    cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now

                                    cmd2.ExecuteNonQuery()
                                    cxnc.Close()
                                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")

                                End If
                            End If
                        End If
                    End If


                Else
                    Throw New MyException("Error, el número de queja ingresado NO EXISTE")
                End If

            Else
                Throw New MyException("Error, el campo 'Número Queja' está vacío")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Txt_Num_Queja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Num_Queja.KeyPress
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

    Private Sub dg_quejas_pendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_quejas_pendientes.CellContentClick
        Txt_Num_Queja.Text = dg_quejas_pendientes.Item(0, dg_quejas_pendientes.CurrentRow.Index).Value
    End Sub

    Private Sub dg_quejas_pendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_quejas_pendientes.CellClick
        Txt_Num_Queja.Text = dg_quejas_pendientes.Item(0, dg_quejas_pendientes.CurrentRow.Index).Value
    End Sub

    Private Sub dg_quejas_pendientes_KeyUp(sender As Object, e As KeyEventArgs) Handles dg_quejas_pendientes.KeyUp
        selectUpRow()
    End Sub

    Private Sub dg_quejas_pendientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_quejas_pendientes.KeyDown
        selectDownRow()
    End Sub

    'Método que se usa en el grid de QUEJAS PENDIENTES, cuando se navega con la flecha arriba
    Private Sub selectUpRow()
        Try
            rowIndex = dg_quejas_pendientes.SelectedCells(0).OwningRow.Index
            If rowIndex >= 0 Then
                colIndex = dg_quejas_pendientes.SelectedCells(0).OwningColumn.Index
                dg_quejas_pendientes.ClearSelection()
                dg_quejas_pendientes.Rows(rowIndex).Cells(colIndex).Selected = True

                Txt_Num_Queja.Text = dg_quejas_pendientes.Item(0, dg_quejas_pendientes.CurrentRow.Index).Value()
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Método que se usa en el grid de QUEJAS PENDIENTES, cuando se navega con la flecha abajo
    Private Sub selectDownRow()
        Try
            totalRows = dg_quejas_pendientes.Rows.Count
            rowIndex = dg_quejas_pendientes.SelectedCells(0).OwningRow.Index
            If (rowIndex <> (totalRows - 1)) Then
                colIndex = dg_quejas_pendientes.SelectedCells(0).OwningColumn.Index
                dg_quejas_pendientes.ClearSelection()
                dg_quejas_pendientes.Rows(rowIndex).Cells(colIndex).Selected = True

                Txt_Num_Queja.Text = dg_quejas_pendientes.Item(0, dg_quejas_pendientes.CurrentRow.Index).Value()

            End If
        Catch ex As Exception

        End Try
    End Sub

    'Método para imprimir la queja'
    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles bt_imprimir.Click

        Try
            If Txt_Num_Queja.Text IsNot "" Then
                If Verificar_Queja() Then
                    Num_Queja = Txt_Num_Queja.Text

                    My.Forms.Frm_Impresion_Queja.MdiParent = Frm_Main_Menu
                    Frm_Impresion_Queja.Show()

                Else
                    Throw New MyException("Error, el número de queja ingresado NO EXISTE")
                End If

            Else
                Throw New MyException("Error, el espacio 'número queja' está vacío")
            End If



        Catch ex As MyException
            MsgBox(ex.Message)
        End Try
    End Sub

    'verifica que el número de queja ingresado corresponda con una queja existente'
    Function Verificar_Queja() As Boolean
        Dim numero_queja As String = Txt_Num_Queja.Text
        Dim cmd3 = New SqlCommand("SELECT CASE WHEN EXISTS (SELECT * FROM SCR_DATOS_QUEJA WHERE NUMERO_QUEJA ='" & numero_queja & "') THEN CAST(1 AS INTEGER) ELSE CAST(0 AS INTEGER) END", cxnc)
        cmd3.CommandType = CommandType.Text
        Dim n As Integer
        cxnc.Open()
        n = Integer.Parse(cmd3.ExecuteScalar())
        cxnc.Close()
        Return (n = 1) 'retorna true si existe la queja'
    End Function

    'Para evitar que se mueva la ventana'
    Private Sub Frm_Entrada_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Top = 0
        Me.Left = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

End Class