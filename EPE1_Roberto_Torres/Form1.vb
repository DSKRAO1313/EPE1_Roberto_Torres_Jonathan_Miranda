Imports System.Data.OleDb

Public Class Form1

    Private productTable As DataTable
    Private nameColIndex As Integer = 0
    Private descColIndex As Integer = -1
    Private priceColIndex As Integer = -1
    Private stockColIndex As Integer = -1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Fijar el formulario para que no se pueda agrandar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "Archivos Excel|*.xls;*.xlsx;*.xlsm"
            ofd.Title = "Seleccione el archivo Lista.xls (o .xlsx)"
            If ofd.ShowDialog() <> DialogResult.OK Then Return

            Dim path As String = ofd.FileName
            Dim extension As String = IO.Path.GetExtension(path).ToLower()
            Dim connString As String = ""

            If extension = ".xls" Then
                connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"
            Else
                connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};Extended Properties='Excel 12.0 Xml;HDR=Yes;IMEX=1';"
            End If

            Using conn As New OleDbConnection(connString)
                conn.Open()

                Dim sheets As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                If sheets Is Nothing OrElse sheets.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron hojas en el Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim firstSheetName As String = sheets.Rows(0)("TABLE_NAME").ToString()
                Dim sql As String = $"SELECT * FROM [{firstSheetName}]"
                Dim da As New OleDbDataAdapter(sql, conn)
                productTable = New DataTable()
                da.Fill(productTable)
            End Using

            If productTable Is Nothing OrElse productTable.Rows.Count = 0 Then
                MessageBox.Show("El archivo Excel está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Asignar columnas (ajústalo si los encabezados son distintos)
            nameColIndex = 0
            If productTable.Columns.Count > 1 Then descColIndex = 1
            If productTable.Columns.Count > 2 Then priceColIndex = 2
            If productTable.Columns.Count > 3 Then stockColIndex = 3

            cmbProductos.Items.Clear()
            For Each r As DataRow In productTable.Rows
                cmbProductos.Items.Add(r(nameColIndex).ToString().Trim())
            Next

            If cmbProductos.Items.Count = 0 Then
                MessageBox.Show("No se encontraron productos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            btnCargar.Enabled = False
            MessageBox.Show("Productos cargados correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al leer Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.SelectedIndex < 0 Then Return
        If productTable Is Nothing Then Return

        Dim row As DataRow = productTable.Rows(cmbProductos.SelectedIndex)

        txtDescripcion.Text = If(descColIndex >= 0, row(descColIndex).ToString(), "")
        txtPrecio.Text = If(priceColIndex >= 0, row(priceColIndex).ToString(), "")
        txtStock.Text = If(stockColIndex >= 0, row(stockColIndex).ToString(), "")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub
End Class

