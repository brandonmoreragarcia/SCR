Imports System.Data.SqlClient
Public Class Frm_Ingreso_Queja

    'Datos de CLIENTES. Se cargan con datos cuando se llama el método obtenerClientes()
    Dim _nombre As String
    Dim _alias As String
    Dim _codigo As String

    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dt_clientes As DataTable
    Dim dt_articulos As DataTable

    'Datos de ARTICULOS. Se cargan con datos cuando se usa el método obtenerArticulos()
    Dim _descripcion As String
    Dim _codigo_articulo As String

    Dim count = 0 ' Se usa en el método Txt_Cod_Cliente_MouseClick, para que los clientes se carguen solo una vez
    Dim count2 = 0 ' Se usa en el método Txt_Cod_Articulo_MouseClick, para que los clientes se carguen solo una vez
    Dim rowIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim colIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim totalRows As Integer ' Se usa en el método selectDownRow

    Private Sub Frm_Ingreso_Queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_TIPO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_TIPO_QUEJA)
        Me.ClienteTableAdapter1.Fill(Me.ExactusERP_TABLES1.CLIENTE)
        Timer1.Start()

        dg_articulo.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 9.25, Font.Style.Bold)
        dg_cliente.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 9.25, Font.Style.Bold)

        Cbx_Tipo_Queja.Text = ""
        select_num_queja()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Txt_Cliente_TextChanged(sender As Object, e As EventArgs)
        'CLIENTEBindingSource.Filter = "CLIENTE='" & Txt_Cliente.Text & "'"

    End Sub


    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        Dim answer As DialogResult = MessageBox.Show("Seguro que desear guardar los cambios?" + vbLf + "", "Aviso", MessageBoxButtons.YesNo)
        If (answer = DialogResult.Yes) Then
            Try
                'If que  valida selección del cliente
                If dg_cliente.FirstDisplayedCell IsNot Nothing AndAlso dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value() IsNot Nothing Then 'valida que el grid de clientes no esté vacío y que haya un cliente seleccionado

                    'If que valida selección del artículo
                    If dg_articulo.FirstDisplayedCell IsNot Nothing AndAlso dg_articulo.Item(1, dg_articulo.CurrentRow.Index).Value() IsNot Nothing Then

                        'if que valida selección del tipo queja
                        If Cbx_Tipo_Queja.Text IsNot "" Then

                            'If que  valida que la factura no vaya en blanco
                            If Txt_Factura.Text IsNot "" Then

                                'If que valida que la proforma no vaya en blanco
                                If Txt_Proforma.Text IsNot "" Then

                                    'If que valida que la proforma no vaya en blanco
                                    If Txt_Descripcion_Queja.Text IsNot "" Then


                                        Dim sql As String = "insert into dbo.SCR_DATOS_QUEJA values(@NUMERO_QUEJA,@CLIENTE,@FECHA,@USUARIO,@TIPO_QUEJA,@FACTURA,@PROFORMA,@DETALLE)"
                                        Dim cmd As New SqlCommand(sql, cxnc)
                                        Dim sql2 As String = "insert into dbo.SCR_ESTADO_QUEJA values(@NUMERO_QUEJA,@ESTADO,@USUARIO,@FECHA)"
                                        Dim cmd2 As New SqlCommand(sql2, cxnc)
                                        Try
                                            cmd.CommandType = CommandType.Text
                                            cmd.Parameters.Add("@NUMERO_QUEJA", SqlDbType.Int).Value = Me.Lbl_Nun_Queja.Text
                                            cmd.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = Me.dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value()
                                            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
                                            cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                            cmd.Parameters.Add("@TIPO_QUEJA", SqlDbType.NVarChar).Value = Me.Cbx_Tipo_Queja.Text
                                            cmd.Parameters.Add("@FACTURA", SqlDbType.NVarChar).Value = Me.Txt_Factura.Text
                                            cmd.Parameters.Add("@PROFORMA", SqlDbType.NVarChar).Value = Me.Txt_Proforma.Text
                                            cmd.Parameters.Add("@DETALLE", SqlDbType.NVarChar).Value = Me.Txt_Descripcion_Queja.Text
                                            cxnc.Open()
                                            cmd.ExecuteNonQuery()
                                            cxnc.Close()
                                            cmd2.Parameters.Add("@NUMERO_QUEJA", SqlDbType.NVarChar).Value = Me.Lbl_Nun_Queja.Text
                                            cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "INGRESADA"
                                            cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                            cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Date.Now
                                            cxnc.Open()
                                            cmd2.ExecuteNonQuery()
                                            cxnc.Close()
                                            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")

                                            Txt_Factura.Text = ""
                                            Txt_Proforma.Text = ""
                                            Txt_Descripcion_Queja.Text = ""
                                            Cbx_Tipo_Queja.Text = ""

                                            lb_alias_cliente.Text = ""
                                            lb_descripcion_articulo.Text = ""
                                            lb_nombre_cliente.Text = ""
                                            Txt_Cod_Articulo.Text = ""

                                            dg_articulo.ClearSelection()
                                            dg_cliente.ClearSelection()

                                        Catch ex As Exception
                                            MsgBox(ex.ToString)
                                        End Try
                                        select_num_queja()

                                    Else
                                        Throw New MyException("Error, el espacio 'descripcion' no puede ir en blanco")
                                    End If

                                Else
                                    Throw New MyException("Error, el espacio  'proforma' no puede ir en blanco")
                                End If

                            Else
                                Throw New MyException("Error, el espacio 'Factura' no puede ir en blanco")
                            End If

                        Else
                            Throw New MyException("Error, no hay un 'motivo' seleccionado")
                        End If

                    Else
                            Throw New MyException("Error, no se ha seleccionado el artículo")
                    End If

                Else
                    Throw New MyException("Error, no se ha seleccionado el cliente")
                End If

            Catch ex As MyException
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub select_num_queja()
        Try
            Dim sql As String = "Select MAX(NUMERO_QUEJA) From dbo.SCR_DATOS_QUEJA"
            Dim cmd As New SqlCommand(sql, cxnc)
            Dim ULTIMO As Long
            Dim uno As Long = 1
            Dim TOTAL As Long
            cxnc.Open()
            ULTIMO = cmd.ExecuteScalar()
            cxnc.Close()
            TOTAL = ULTIMO + uno
            Lbl_Nun_Queja.Text = TOTAL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_Factura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Factura.KeyPress
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

    Private Sub Txt_Proforma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Proforma.KeyPress
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

    Private Sub Txt_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub Txt_Cod_Cliente_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt_Cod_Cliente.MouseClick
        If count = 0 Then 'para que los clientes no se carguen cada vez que se da click
            obtenerClientes()
            dg_cliente.Rows(0).Cells(0).Selected = True
            lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
            lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
        End If
        count = 1
    End Sub

    Private Sub dg_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cliente.CellContentClick
        lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
        lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
    End Sub

    Private Sub Txt_Cod_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cod_Cliente.KeyPress
        If rb_alias.Checked Then
            bs_clientes.Filter = " alias like '%" & Txt_Cod_Cliente.Text & "%'"
        Else
            bs_clientes.Filter = " nombre like '%" & Txt_Cod_Cliente.Text & "%'"
        End If

        Try
            lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
            lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
        Catch ex As Exception
            dg_cliente.ClearSelection()
            lb_nombre_cliente.Text = ""
            lb_alias_cliente.Text = ""
        End Try
    End Sub

    Private Sub obtenerArticulos()
        dt_articulos = New DataTable
        dt_articulos.Columns.Add("Descripcion")
        dt_articulos.Columns.Add("codigo")
        Try
            Dim filtro As String = Txt_Cod_Articulo.Text.Replace("*", "%").ToUpper() 'sustiyuye los * por %, ya que en SQL se utilizan los %
            Dim query As SqlCommand

            If rb_descripcion.Checked Then
                query = New SqlCommand("SELECT DESCRIPCION, ARTICULO FROM DIS86.ARTICULO WHERE DESCRIPCION LIKE '" & filtro & "'", cxnc)
            Else
                query = New SqlCommand("SELECT DESCRIPCION, ARTICULO FROM DIS86.ARTICULO WHERE ARTICULO LIKE '" & filtro & "'", cxnc)
            End If

            cxnc.Open()
            Dim reader As SqlDataReader = query.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    _descripcion = reader.GetString(0).ToUpper()
                    _codigo_articulo = reader.GetString(1).ToUpper()
                    dt_articulos.Rows.Add(_descripcion, _codigo_articulo)
                End While
            End If
            cxnc.Close()
            bs_articulo.DataSource = dt_articulos
            dg_articulo.DataSource = bs_articulo
            dg_articulo.AutoResizeColumn(0)


        Catch ex As ArgumentException
            MessageBox.Show("Se produjo un error. Recuerde utilizar el siguiente formato:  *bicicleta*maverick*amarilla*")

        Catch ex As Exception
            MessageBox.Show("Se produjo un error, por favor vuelva a intentarlo")
        End Try

    End Sub

    'Método que se ejecuta en el mouseclick del Txt_Cod_Cliente
    Private Sub obtenerClientes()
        dt_clientes = New DataTable
        dt_clientes.Columns.Add("Nombre")
        dt_clientes.Columns.Add("Alias")
        dt_clientes.Columns.Add("Código")

        Try
            Dim query As SqlCommand = New SqlCommand("SELECT NOMBRE, ALIAS, CLIENTE FROM DIS86.CLIENTE", cxnc)
            cxnc.Open()
            Dim reader As SqlDataReader = query.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    _nombre = reader.GetString(0).ToUpper()
                    _alias = reader.GetString(1).ToUpper()
                    _codigo = reader.GetString(2).ToUpper()
                    dt_clientes.Rows.Add(_nombre, _alias, _codigo)

                End While
            End If
            cxnc.Close()
            bs_clientes.DataSource = dt_clientes
            dg_cliente.DataSource = bs_clientes
            dg_cliente.AutoResizeColumn(0)
            dg_cliente.Columns(2).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '////////////////Metodos de Up and Down para GRID CLIENTES

    'Método que se usa en el grid de CLIENTES, cuando se navega con la flecha arriba
    Private Sub selectUpRow()
        Try
            rowIndex = dg_cliente.SelectedCells(0).OwningRow.Index
            If rowIndex >= 0 Then
                colIndex = dg_cliente.SelectedCells(0).OwningColumn.Index
                dg_cliente.ClearSelection()
                dg_cliente.Rows(rowIndex).Cells(colIndex).Selected = True

                lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
                lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Método que se usa en el grid de CLIENTES, cuando se navega con la flecha abajo
    Private Sub selectDownRow()
        Try
            totalRows = dg_cliente.Rows.Count
            rowIndex = dg_cliente.SelectedCells(0).OwningRow.Index
            If (rowIndex <> (totalRows - 1)) Then
                colIndex = dg_cliente.SelectedCells(0).OwningColumn.Index
                dg_cliente.ClearSelection()
                dg_cliente.Rows(rowIndex).Cells(colIndex).Selected = True

                lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
                lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
            End If
        Catch ex As Exception

        End Try

    End Sub

    '///////////////////////Métodos de Up and Down para GRID ARTICULOS

    'Método que se usa en el grid de articulos, cuando se navega con la flecha arriba
    Private Sub selectUpRow_articulos()
        Try
            rowIndex = dg_articulo.SelectedCells(0).OwningRow.Index
            If rowIndex >= 0 Then
                colIndex = dg_articulo.SelectedCells(0).OwningColumn.Index
                dg_articulo.ClearSelection()
                dg_articulo.Rows(rowIndex).Cells(colIndex).Selected = True

                lb_descripcion_articulo.Text = dg_articulo.Item(0, dg_articulo.CurrentRow.Index).Value()
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Método que se usa en el grid de articulos, cuando se navega con la flecha abajo
    Private Sub selectDownRow_articulos()
        Try
            totalRows = dg_articulo.Rows.Count
            rowIndex = dg_articulo.SelectedCells(0).OwningRow.Index
            If (rowIndex <> (totalRows - 1)) Then
                colIndex = dg_articulo.SelectedCells(0).OwningColumn.Index
                dg_articulo.ClearSelection()
                dg_articulo.Rows(rowIndex).Cells(colIndex).Selected = True

                lb_descripcion_articulo.Text = dg_articulo.Item(0, dg_articulo.CurrentRow.Index).Value()

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_cliente.KeyDown

        selectUpRow()
    End Sub

    Private Sub dg_cliente_KeyUp(sender As Object, e As KeyEventArgs) Handles dg_cliente.KeyUp

        selectUpRow()
    End Sub

    Private Sub rb_alias_CheckedChanged(sender As Object, e As EventArgs) Handles rb_alias.CheckedChanged
        bs_clientes.Filter = " alias like '%" & Txt_Cod_Cliente.Text & "%'"
        If dg_cliente.RowCount <> 0 Then
            dg_cliente.Columns(0).DisplayIndex = 1 'el DisplayIndex solo cambia el orden visual, pero la estructura inicial se mantiene
            dg_cliente.Columns(1).DisplayIndex = 0
            dg_cliente.AutoResizeColumn(1)
        End If

    End Sub

    Private Sub rb_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles rb_nombre.CheckedChanged

        bs_clientes.Filter = " nombre like '%" & Txt_Cod_Cliente.Text & "%'"
        If dg_cliente.RowCount <> 0 And rb_nombre.Checked Then
            dg_cliente.Columns(1).DisplayIndex = 1
            dg_cliente.AutoResizeColumn(0)
        End If
    End Sub

    Private Sub dg_articulo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_articulo.CellContentClick
        lb_descripcion_articulo.Text = dg_articulo.Item(0, dg_articulo.CurrentRow.Index).Value()
    End Sub

    Private Sub dg_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_articulo.KeyDown
        selectDownRow_articulos()
    End Sub

    Private Sub dg_articulo_KeyUp(sender As Object, e As KeyEventArgs) Handles dg_articulo.KeyUp
        selectUpRow_articulos()
    End Sub

    Private Sub bt_buscar_articulo_Click(sender As Object, e As EventArgs) Handles bt_buscar_articulo.Click

        dg_articulo.ClearSelection() 'cada vez que se realiza una búsqueda, se limpia la selección anterior. Esto porque a veces la búsqueda no devuelve nada pero la selección anterior se mantiene.
        lb_descripcion_articulo.Text = ""

        Try
            If Txt_Cod_Articulo.Text.Length <> 0 Then ' Para validar que la búsqueda no vaya en blanco
                obtenerArticulos()
                dg_articulo.Item(0, dg_articulo.CurrentRow.Index).Selected = True 'se selecciona el primero para que siempre haya uno seleccionado
                lb_descripcion_articulo.Text = dg_articulo.Item(0, dg_articulo.CurrentRow.Index).Value()
            Else
                Throw New MyException("Error, Recuerde escribir en el campo antes de iniciar la búsqueda")
            End If

            If dg_articulo.RowCount <> 0 AndAlso rb_codigo.Checked Then
                dg_articulo.Columns(0).DisplayIndex = 1 'el DisplayIndex solo cambia el orden visual, pero la estructura inicial se mantiene
                dg_articulo.Columns(1).DisplayIndex = 0
                dg_articulo.AutoResizeColumn(1)
            Else
                If dg_articulo.RowCount <> 0 AndAlso rb_descripcion.Checked Then
                    dg_articulo.Columns(1).DisplayIndex = 1
                    dg_articulo.AutoResizeColumn(0)
                End If

            End If



        Catch ex As MyException
            MessageBox.Show(ex.Message)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cliente.CellClick
        lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
        lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
    End Sub

    Private Sub bt_agregar_a_descripcion_Click(sender As Object, e As EventArgs) Handles bt_agregar_a_descripcion.Click
        Try
            If lb_descripcion_articulo.Text IsNot "" Then
                Txt_Descripcion_Queja.Text = Txt_Descripcion_Queja.Text + "  ** Artículo: " + lb_descripcion_articulo.Text + "  Código:" + dg_articulo.Item(1, dg_articulo.CurrentRow.Index).Value()
            Else
                Throw New MyException("Error, primero debe seleccionar el artículo")
            End If

        Catch ex As MyException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rb_codigo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_codigo.CheckedChanged

        Try
            bs_articulo.Filter = " codigo like '%" & Txt_Cod_Articulo.Text & "%'"

        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb_descripcion_CheckedChanged(sender As Object, e As EventArgs) Handles rb_descripcion.CheckedChanged

        Try
            bs_articulo.Filter = " descripcion like '%" & Txt_Cod_Articulo.Text & "%'"

        Catch ex As Exception
        End Try
    End Sub
End Class