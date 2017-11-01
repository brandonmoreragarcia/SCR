Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class Frm_Entrada
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dt_clientes As DataTable
    Dim dt_articulos As DataTable
    Const KEYUP As Integer = 38
    Const KEYDOWN As Integer = 40

    'Datos de CLIENTES. Se cargan con datos cuando se llama el método obtenerClientes()
    Dim _nombre As String
    Dim _alias As String
    Dim _codigo As String

    'Datos de ARTICULOS. Se cargan con datos cuando se usa el método obtenerArticulos()
    Dim _descripcion As String
    Dim _codigo_articulo As String

    Dim count = 0 ' Se usa en el método Txt_Cod_Cliente_MouseClick, para que los clientes se carguen solo una vez
    Dim count2 = 0 ' Se usa en el método Txt_Cod_Articulo_MouseClick, para que los clientes se carguen solo una vez
    Dim rowIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim colIndex As Integer ' Se usan en los métodos selectUpRow y selectDownRow
    Dim totalRows As Integer ' Se usa en el método selectDownRow

    Private Sub Frm_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.TRANSPORTES' Puede moverla o quitarla según sea necesario.
        Me.TRANSPORTESTableAdapter.Fill(Me.ExactusERP_TABLES.TRANSPORTES)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_ENCARGADO_BODEGA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ENCARGADO_BODEGATableAdapter1.Fill(Me.ExactusERP_SRC_TABLES1.SCR_ENCARGADO_BODEGA)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_TRANSPORTE' Puede moverla o quitarla según sea necesario.
        Me.SCR_TRANSPORTETableAdapter1.Fill(Me.ExactusERP_SRC_TABLES1.SCR_TRANSPORTE)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_TRAIDO_POR' Puede moverla o quitarla según sea necesario.
        Me.SCR_TRAIDO_PORTableAdapter1.Fill(Me.ExactusERP_SRC_TABLES1.SCR_TRAIDO_POR)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_ESTADO_INGRESO' Puede moverla o quitarla según sea necesario.
        Me.SCR_ESTADO_INGRESOTableAdapter.Fill(Me.ExactusERP_SRC_TABLES1.SCR_ESTADO_INGRESO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES1.SCR_MOTIVO' Puede moverla o quitarla según sea necesario.
        Me.SCR_MOTIVOTableAdapter1.Fill(Me.ExactusERP_SRC_TABLES1.SCR_MOTIVO)
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_TABLES.ARTICULO' Puede moverla o quitarla según sea necesario.


        check_box_opcional.Checked = False
        txt_opcional.Enabled = False

        Timer1.Start()
        Chb_Modificar.CheckState = CheckState.Unchecked
        Try
            Dim sql As String = "Select MAX(REPARACION_NUMERO) From dbo.SCR_DATOS_REPARACION"
            Dim cmd As New SqlCommand(sql, cxnc)
            Dim ULTIMO As Integer
            Dim uno As Integer = 1
            Dim TOTAL As Integer
            cxnc.Open()
            ULTIMO = cmd.ExecuteScalar()
            cxnc.Close()
            TOTAL = ULTIMO + uno
            Tbx_Reparacion.Text = TOTAL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Impresion_Colilla_Click(sender As Object, e As EventArgs) Handles Btn_Impresion_Colilla.Click

        'la siguiente línea utiliza el valor de Tbx_Reparacion y lo guarda en la variable global
        'numero_reparacion, la cual se utiliza en la pantalla Frm_Impresion_Entrada
        numero_reparacion = Tbx_Reparacion.Text

        'validaciones antes de guardar
        Try
            'If que  valida selección del cliente
            If dg_cliente.FirstDisplayedCell IsNot Nothing AndAlso dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value() IsNot Nothing Then 'valida que el grid de clientes no esté vacío y que haya un cliente seleccionado

                'If que valida selección del artículo
                If dg_articulo.FirstDisplayedCell IsNot Nothing AndAlso dg_articulo.Item(1, dg_articulo.CurrentRow.Index).Value() IsNot Nothing Then

                    'If que valida que la boleta verde no vaya en blanco
                    If Txt_Boleta.Text IsNot "" Then

                        'If que  valida que el Estado Artículo no vaya en blanco
                        If Tbx_Estado_Art.Text IsNot "" Then

                            'If que valida que El problema reportado no vaya en blanco
                            If Tbx_Problema_Reportado.Text IsNot "" Then

                                'if que valida selección del transporte
                                If Cbx_Transporte.SelectedValue IsNot Nothing Then

                                    'guardamos los datos

                                    Dim sql As String = "insert into SCR_DATOS_REPARACION values(@CODIGO_CLIENTE,@CODIGO_ART,@ADICIONAL_ART,@MOTIVO,@REPARACION_NUMERO,@ESTADO_ART,@PROBLEMA_REPORTADO,@TRAIDO_POR,@TRANSPORTE,@ENCARGADO_BODEGA,@DOCUMENTO_REF,@USUARIO,@ESTADO,@FECHA_HORA,@BOLETA,@SERIE_PRODUCTO)"
                                    Dim cmd As New SqlCommand(sql, cxnc)
                                    Dim sql2 As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
                                    Dim cmd2 As New SqlCommand(sql2, cxnc)
                                    Dim sql3 As String = "insert into SCR_ACTUALIZACION_REP values(@REPARACION_NUMERO,@CLIENTE,@COMENTARIO,@ESTADO,@USUARIO,@LOCALIZACION,@FECHA)"
                                    Dim cmd3 As New SqlCommand(sql3, cxnc)
                                    If numero_rep(Tbx_Reparacion.Text) = False Then
                                        Try
                                            cmd.CommandType = CommandType.Text
                                            cmd.Parameters.Add("@CODIGO_CLIENTE", SqlDbType.NVarChar).Value = dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value().ToString()
                                            cmd.Parameters.Add("@CODIGO_ART", SqlDbType.NVarChar).Value = dg_articulo.Item(1, dg_articulo.CurrentRow.Index).Value().ToString()
                                            cmd.Parameters.Add("@ADICIONAL_ART", SqlDbType.NVarChar).Value = Me.Tbx_Adicional_Art.Text
                                            cmd.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = Me.Cbx_Motivo.Text
                                            cmd.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Tbx_Reparacion.Text
                                            cmd.Parameters.Add("@ESTADO_ART", SqlDbType.NVarChar).Value = Tbx_Estado_Art.Text
                                            cmd.Parameters.Add("@PROBLEMA_REPORTADO", SqlDbType.NVarChar).Value = Tbx_Problema_Reportado.Text

                                            'valida quién trajo la reparación
                                            If check_box_opcional.Checked Then 'si el checkbox está activado se guarda lo que está en el txt opcional, sino se guarda la selección del combobox 
                                                If txt_opcional.Text IsNot "" Then
                                                    cmd.Parameters.Add("@TRAIDO_POR", SqlDbType.NVarChar).Value = txt_opcional.Text
                                                Else
                                                    Throw New MyException("Error, la casilla opcional está activada pero el campo 'opcional' no puede ir en blanco'")
                                                End If
                                            Else
                                                cmd.Parameters.Add("@TRAIDO_POR", SqlDbType.NVarChar).Value = Cbx_Traido_Por.Text
                                            End If

                                            cmd.Parameters.Add("@TRANSPORTE", SqlDbType.NVarChar).Value = Cbx_Transporte.Text
                                            cmd.Parameters.Add("@ENCARGADO_BODEGA", SqlDbType.NVarChar).Value = Cbx_Encargado_Bodega.Text
                                            cmd.Parameters.Add("@DOCUMENTO_REF", SqlDbType.NVarChar).Value = Tbx_Documento_Referencia.Text
                                            cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                            cmd.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = Cbx_Estado.Text
                                            cmd.Parameters.Add("@FECHA_HORA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                                            cmd.Parameters.Add("@BOLETA", SqlDbType.NVarChar).Value = Txt_Boleta.Text
                                            cmd.Parameters.Add("@SERIE_PRODUCTO", SqlDbType.NVarChar).Value = Txt_Numero_Serie.Text
                                            cxnc.Open()
                                            cmd.ExecuteNonQuery()
                                            cxnc.Close()
                                            cmd2.CommandType = CommandType.Text
                                            cmd2.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Tbx_Reparacion.Text
                                            cmd2.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value().ToString()
                                            cmd2.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = "ENTRADA DE REPARACION"
                                            cmd2.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "INGRESADA"
                                            cmd2.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                            cmd2.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = "POST VENTA"
                                            cmd2.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                                            cxnc.Open()
                                            cmd2.ExecuteNonQuery()
                                            cxnc.Close()
                                            cmd3.CommandType = CommandType.Text
                                            cmd3.Parameters.Add("@REPARACION_NUMERO", SqlDbType.NVarChar).Value = Tbx_Reparacion.Text
                                            cmd3.Parameters.Add("@CLIENTE", SqlDbType.NVarChar).Value = dg_cliente.Item(2, dg_cliente.CurrentRow.Index).Value().ToString()
                                            cmd3.Parameters.Add("@COMENTARIO", SqlDbType.NVarChar).Value = "SE TRASLADA LA REPARACION A TALLER"
                                            cmd3.Parameters.Add("@ESTADO", SqlDbType.NVarChar).Value = "EN REPARACION"
                                            cmd3.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = v_usuario
                                            cmd3.Parameters.Add("@LOCALIZACION", SqlDbType.NVarChar).Value = "TALLER"
                                            cmd3.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = Lbl_Fecha_Hora.Text
                                            cxnc.Open()
                                            cmd3.ExecuteNonQuery()
                                            cxnc.Close()
                                            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")


                                            Tbx_Adicional_Art.Text = ""
                                            Cbx_Motivo.Text = ""
                                            Tbx_Reparacion.Text = ""
                                            Tbx_Estado_Art.Text = ""
                                            Tbx_Problema_Reportado.Text = ""
                                            Cbx_Traido_Por.Text = ""
                                            Cbx_Transporte.Text = ""
                                            Cbx_Encargado_Bodega.Text = ""
                                            Tbx_Documento_Referencia.Text = ""
                                            Txt_Boleta.Text = ""
                                            Txt_Numero_Serie.Text = "N/A"
                                            Txt_Cod_Cliente.Enabled = True
                                            Txt_Cod_Cliente.Text = ""
                                            Txt_Cod_Articulo.Enabled = True
                                            Txt_Cod_Articulo.Text = ""
                                            dg_articulo.ClearSelection()
                                            dg_cliente.ClearSelection()
                                            lb_nombre_cliente.Text = ""
                                            lb_alias_cliente.Text = ""
                                            lb_descripcion_articulo.Text = ""

                                            Try
                                                Dim sql4 As String = "Select MAX(REPARACION_NUMERO) From dbo.SCR_DATOS_REPARACION"
                                                Dim cmd4 As New SqlCommand(sql4, cxnc)
                                                Dim ULTIMO As Integer
                                                Dim uno As Integer = 1
                                                Dim TOTAL As Integer
                                                cxnc.Open()
                                                ULTIMO = cmd4.ExecuteScalar()
                                                cxnc.Close()
                                                TOTAL = ULTIMO + uno
                                                Tbx_Reparacion.Text = TOTAL
                                                Tbx_Reparacion.Enabled = False

                                                'se crea y muestra la siguiente ventana
                                                My.Forms.Frm_Impresion_Entrada.MdiParent = Frm_Main_Menu
                                                Frm_Impresion_Entrada.Show()

                                            Catch ex As Exception
                                                MsgBox(ex.ToString)
                                            End Try

                                        Catch ex As MyException
                                            MessageBox.Show(ex.Message)

                                        Catch ex As Exception
                                            MsgBox(ex.ToString)
                                        End Try
                                    Else
                                        MsgBox("La Reparacion: " + Tbx_Reparacion.Text + " Ya  ha sido iniciada con anterioridad")
                                    End If
                                Else
                                    Throw New MyException("Error, no hay un transporte seleccionado")
                                End If
                            Else
                                Throw New MyException("Error, El 'Problema Reportado' no puede ir en blanco")
                            End If

                        Else
                            Throw New MyException("Error, El 'Estado Artículo' no puede ir en blanco")
                        End If

                    Else
                        Throw New MyException("Error, el espacio 'boleta verde' no puede ir en blanco")
                    End If

                Else
                    Throw New MyException("Error, no se ha seleccionado el artículo")
                End If

            Else
                Throw New MyException("Error, no se ha seleccionado el cliente")
            End If

        Catch ex As MyException
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Fecha_Hora.Text = Date.Now
    End Sub

    Private Sub Tbx_Reparacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbx_Reparacion.KeyPress
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

    Private Sub Tbx_Documento_Referencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbx_Documento_Referencia.KeyPress
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

    Private Sub Chb_Modificar_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Modificar.CheckedChanged
        If Chb_Modificar.CheckState = CheckState.Unchecked Then
            Tbx_Reparacion.Enabled = False
        Else
            Tbx_Reparacion.Enabled = True
        End If
    End Sub

    Private Sub Txt_Numero_Serie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Numero_Serie.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
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

    Private Sub Cbx_Motivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Motivo.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Encargado_Bodega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Encargado_Bodega.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cbx_Transporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Transporte.KeyPress
        'e.Handled = True
    End Sub

    Private Sub Cbx_Traido_Por_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbx_Traido_Por.KeyPress
        e.Handled = True
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

            Dim query As SqlCommand = New SqlCommand("SELECT DESCRIPCION, ARTICULO FROM DIS86.ARTICULO WHERE DESCRIPCION LIKE '" & filtro & "'", cxnc)
            cxnc.Open()
            Dim reader As SqlDataReader = query.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    _descripcion = reader.GetString(0)
                    _codigo_articulo = reader.GetString(1)
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
                    _nombre = reader.GetString(0)
                    _alias = reader.GetString(1)
                    _codigo = reader.GetString(2)
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

    'Método que se usa en el grid de CLIENTES, cuando se navega con la flecha arriba
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

    'Método que se usa en el grid de CLIENTES, cuando se navega con la flecha abajo
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
        Catch ex As MyException
            MessageBox.Show(ex.Message)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub check_box_opcional_CheckedChanged(sender As Object, e As EventArgs) Handles check_box_opcional.CheckedChanged
        If check_box_opcional.Checked Then
            Cbx_Traido_Por.Enabled = False
            txt_opcional.Enabled = True
        Else
            Cbx_Traido_Por.Enabled = True
            txt_opcional.Enabled = False
        End If
    End Sub

    Private Sub dg_cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cliente.CellClick
        lb_nombre_cliente.Text = dg_cliente.Item(0, dg_cliente.CurrentRow.Index).Value()
        lb_alias_cliente.Text = dg_cliente.Item(1, dg_cliente.CurrentRow.Index).Value()
    End Sub

End Class
