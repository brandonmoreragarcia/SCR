Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Listado_Quejas
    Private Sub Frm_Listado_Quejas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA' Puede moverla o quitarla según sea necesario.
        Me.SCR_ULTIMO_ESTADO_QUEJATableAdapter.Fill(Me.ExactusERP_SRC_TABLES.SCR_ULTIMO_ESTADO_QUEJA)
        'Dgv_Quejas_Total.DefaultCellStyle.Font = New Drawing.Font("Square721 BT", 10, Font.Style.Regular)

    End Sub

    Private Sub Dgv_Quejas_Total_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Num_Queja = Dgv_Quejas_Total.Item(1, Dgv_Quejas_Total.CurrentRow.Index).Value()
        My.Forms.Frm_Consulta_Num_Queja.Txt_Num_Queja.Enabled = False
        Frm_Consulta_Num_Queja.Show()

    End Sub

    Private Sub Btn_Selec_Queja_Click(sender As Object, e As EventArgs)
        If T_busqueda_Queja = 2 Then
            My.Forms.Frm_Consulta_Queja.Txt_Num_Queja.Text = Dgv_Quejas_Total.Item(1, Dgv_Quejas_Total.CurrentRow.Index).Value()
            Me.Close()

        ElseIf T_busqueda_Queja = 1 Then
            My.Forms.Frm_Consulta_Num_Queja.Txt_Num_Queja.Text = Dgv_Quejas_Total.Item(1, Dgv_Quejas_Total.CurrentRow.Index).Value()
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Exportar_Click(sender As Object, e As EventArgs) Handles Btn_Exportar.Click

        Dim fichero As New SaveFileDialog()
        fichero.Filter = "Excel (*.xls)|*.xls"
        If fichero.ShowDialog() = DialogResult.OK Then
            Dim aplicacion As Microsoft.Office.Interop.Excel.Application
            Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
            aplicacion = New Microsoft.Office.Interop.Excel.Application()
            libros_trabajo = aplicacion.Workbooks.Add()
            hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
            'Recorremos el DataGridView rellenando la hoja de trabajo
            Dim columnsCount As Integer = Dgv_Quejas_Total.Columns.Count
            For i As Integer = 0 To Dgv_Quejas_Total.Rows.Count - 2
                For j As Integer = 0 To Dgv_Quejas_Total.Columns.Count - 1
                    If i = 0 Then 'pintamos cabecera
                        hoja_trabajo.Cells(i + 1, j + 1) = Dgv_Quejas_Total.Columns(j).HeaderText
                    Else 'pintamos datos
                        hoja_trabajo.Cells(i + 1, j + 1) = Dgv_Quejas_Total.Rows(i).Cells(j).Value.ToString()
                    End If
                Next
            Next
            libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
            libros_trabajo.Close(True)
            aplicacion.Quit()
            MsgBox("DATOS EXPORTADOS EXITOSAMENTE")
        End If


    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet.Columns.AutoFit()

        For i = 0 To Dgv_Quejas_Total.RowCount - 2
            For j = 0 To Dgv_Quejas_Total.ColumnCount - 1
                For k As Integer = 1 To Dgv_Quejas_Total.Columns.Count
                    xlWorkSheet.Cells(1, k) = Dgv_Quejas_Total.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = Dgv_Quejas_Total(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file D:\vbexcel.xlsx")
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub txt_filtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_filtro.KeyPress
        bs_quejas.Filter = " nombre like '%" & txt_filtro.Text & "%'"
    End Sub
End Class