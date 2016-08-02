Public Class Stock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInsertarProducto.Click
        Dim habilitado As Integer
        habilitado = 1

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        If TextBoxCodigo.Text = "" And TextBoxCodigoDeBarras.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete al menos un campo de Código"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxNombre.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Nombre'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxPrecioDeVenta.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el Precio de Venta"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxCantidad.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Cantidad'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxFactura.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Factura'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxPrecio.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Precio'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        ''' SI LOS CAMPOS IMPORTANTES NO ESTAN VACIOS, SE PROCEDE AL INGRESO
        If habilitado = 1 Then
            Dim codigo_existe As Integer
            codigo_existe = 0

            Dim i As Integer

            ''' BUSCA SI EXISTE PRODUCTO CON "CODIGO" YA INGRESADO
            For i = 0 To (cantidad_stock - 1)
                'Si el CODIGO ingresado existe'
                If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then
                    codigo_existe = 1
                End If
            Next

            'SI EL CODIGO ES NO NULO, Y NO EXISTE EN LA BASE DE DATOS, SE INSERTA UNA NUEVA FILA
            If codigo_existe = 0 And TextBoxCodigo.Text <> "" Then
                Dim nuevo_stock As DataRow = DataSet1.Tables("stock").NewRow()

                '''''If TextBoxCodigo.Text <> "" Then
                nuevo_stock("codigo") = TextBoxCodigo.Text
                '''''End If
                '''''If TextBoxCodigoDeBarras.Text <> "" Then
                nuevo_stock("codigo_barras") = TextBoxCodigoDeBarras.Text
                '''''End If
                nuevo_stock("nombre") = TextBoxNombre.Text
                nuevo_stock("descripcion") = TextBoxDescripcion.Text
                nuevo_stock("precio_venta") = TextBoxPrecioDeVenta.Text

                DataSet1.Tables("stock").Rows.Add(nuevo_stock)

                Validate()
                StockBindingSource.EndEdit()
                StockTableAdapter.Update(DataSet1.stock)

            Else

                ''' BUSCA SI EXISTE PRODUCTO CON "CODIGO DE BARRAS" YA INGRESADO
                For i = 0 To (cantidad_stock - 1)
                    'Si el CODIGO ingresado existe'
                    If TextBoxCodigoDeBarras.Text <> "" And DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text Then
                        codigo_existe = 1
                    End If
                Next

                'SI EL CODIGO DE BARRAS ES NO NULO, Y NO EXISTE EN LA BASE DE DATOS, SE INSERTA UNA NUEVA FILA
                If codigo_existe = 0 And TextBoxCodigoDeBarras.Text <> "" Then
                    Dim nuevo_stock As DataRow = DataSet1.Tables("stock").NewRow()

                    '''''If TextBoxCodigo.Text <> "" Then
                    nuevo_stock("codigo") = TextBoxCodigo.Text
                    '''''End If
                    '''''If TextBoxCodigoDeBarras.Text <> "" Then
                    nuevo_stock("codigo_barras") = TextBoxCodigoDeBarras.Text
                    '''''End If
                    nuevo_stock("nombre") = TextBoxNombre.Text
                    nuevo_stock("descripcion") = TextBoxDescripcion.Text
                    nuevo_stock("precio_venta") = TextBoxPrecioDeVenta.Text

                    DataSet1.Tables("stock").Rows.Add(nuevo_stock)

                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)
                End If
            End If

            '''ESTA ES LA PARTE DEL PROVEEDOR
            If TextBoxRUCproveedor.Text <> "" Then
                Dim proveedor_existe As Integer
                proveedor_existe = 0

                Dim cantidad_proveedores As Integer
                cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count

                For i = 0 To (cantidad_proveedores - 1)
                    'Si el PROVEEDOR ingresado existe'
                    If DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                        proveedor_existe = 1
                    End If
                Next

                'si el proveedor insertado no existe, crea una fila en la tabla proveedor
                If proveedor_existe = 0 Then

                    Dim nuevo_proveedor As DataRow = DataSet1.Tables("proveedor").NewRow()

                    nuevo_proveedor("ruc_proveedor") = TextBoxRUCproveedor.Text
                    nuevo_proveedor("nombre_proveedor") = TextBoxNombreProveedor.Text
                    nuevo_proveedor("numero_proveedor") = TextBoxNumeroProveedor.Text

                    DataSet1.Tables("proveedor").Rows.Add(nuevo_proveedor)

                    Validate()
                    ProveedorBindingSource.EndEdit()
                    ProveedorTableAdapter.Update(DataSet1.proveedor)

                End If
            End If

            '''cache_update
            Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
            Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
            Me.StockTableAdapter.Fill(Me.DataSet1.stock)
            '''

            cantidad_stock = DataSet1.Tables("stock").Rows.Count

            ''' ESTA ES LA PARTE PARA METER EN 'INGRESO'
            Dim bandera_encontro_codigo As Integer
            bandera_encontro_codigo = 0
            For i = 0 To (cantidad_stock - 1)
                'Si el PRODUCTO ingresado existe0'
                If TextBoxCodigo.Text <> "" And DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then
                    Dim nuevo_ingreso As DataRow = DataSet1.Tables("ingreso").NewRow()

                    Dim cantidad_proveedores As Integer
                    cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count
                    For j = 0 To (cantidad_proveedores - 1)
                        'Si el PROVEEDOR ingresado existe'
                        If DataSet1.Tables("proveedor").Rows(j).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                            nuevo_ingreso("id_proveedor") = DataSet1.Tables("proveedor").Rows(j).Item("id_proveedor")
                        End If
                    Next

                    nuevo_ingreso("id_stock") = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                    nuevo_ingreso("cantidad") = TextBoxCantidad.Text
                    nuevo_ingreso("factura_compra") = TextBoxFactura.Text
                    nuevo_ingreso("precio_compra") = TextBoxPrecio.Text

                    DataSet1.Tables("ingreso").Rows.Add(nuevo_ingreso)

                    Validate()
                    IngresoBindingSource.EndEdit()
                    IngresoTableAdapter.Update(DataSet1.ingreso)

                    bandera_encontro_codigo = 1
                End If
            Next

            If bandera_encontro_codigo = 0 Then 'si no encontro CODIGO, necesariamente tiene que encontrar CODIGO DE BARRAS
                For i = 0 To (cantidad_stock - 1)
                    'Si el PRODUCTO ingresado existe'
                    If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text Then
                        Dim nuevo_ingreso As DataRow = DataSet1.Tables("ingreso").NewRow()

                        Dim cantidad_proveedores As Integer
                        cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count
                        For j = 0 To (cantidad_proveedores - 1)
                            'Si el PROVEEDOR ingresado existe'
                            If DataSet1.Tables("proveedor").Rows(j).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                                nuevo_ingreso("id_proveedor") = DataSet1.Tables("proveedor").Rows(j).Item("id_proveedor")
                            End If
                        Next

                        nuevo_ingreso("id_stock") = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                        nuevo_ingreso("cantidad") = TextBoxCantidad.Text
                        nuevo_ingreso("factura_compra") = TextBoxFactura.Text
                        nuevo_ingreso("precio_compra") = TextBoxPrecio.Text

                        DataSet1.Tables("ingreso").Rows.Add(nuevo_ingreso)

                        Validate()
                        IngresoBindingSource.EndEdit()
                        IngresoTableAdapter.Update(DataSet1.ingreso)

                    End If
                Next
            End If


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodigoDeBarras.TextChanged

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        If TextBoxCodigoDeBarras.Text <> "" Then
            For i As Integer = 0 To (cantidad_stock - 1)
                'Si el PRODUCTO ingresado existe'
                If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text Then

                    LabelInsertarProducto.Hide()

                    TextBoxCodigo.Text = DataSet1.Tables("stock").Rows(i).Item("codigo")
                    TextBoxNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    TextBoxDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                    TextBoxPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")


                    TextBoxCantidad.Focus()
                End If
            Next

        End If

    End Sub

    Private Sub TextBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCodigo.LostFocus

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        If TextBoxCodigo.Text <> "" Then

            For i As Integer = 0 To (cantidad_stock - 1)
                'Si el PRODUCTO ingresado existe'
                If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then

                    LabelInsertarProducto.Hide()

                    TextBoxCodigoDeBarras.Text = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                    TextBoxNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    TextBoxDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                    TextBoxPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

                    TextBoxCantidad.Focus()

                End If
            Next

        End If


    End Sub

    Private Sub TextBoxCodigo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodigo.TextChanged

    End Sub

    'Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.StockBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    'End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
        'TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)

    End Sub

    Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBoxFactura_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFactura.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBoxCantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidad.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBoxPrecioDeVenta_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecioDeVenta.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBoxDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescripcion.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label41a_Click(sender As Object, e As EventArgs) Handles Label41a.Click

    End Sub

    Private Sub TextBoxCodigoDeBarras_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCodigoDeBarras.LostFocus


    End Sub

    Private Sub TextBoxCantidad_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCantidad.LostFocus
        LabelInsertarProducto.Hide()
        If IsNumeric(TextBoxCantidad.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese un número en 'Cantidad'"
            LabelInsertarProducto.ForeColor = Color.Red

            TextBoxCantidad.Text = ""
            TextBoxCantidad.Focus()
        End If
    End Sub



    Private Sub TextBoxPrecio_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPrecio.TextChanged

    End Sub

    Private Sub TextBoxPrecio_LostFocus(sender As Object, e As EventArgs) Handles TextBoxPrecio.LostFocus

        LabelInsertarProducto.Hide()
        If IsNumeric(TextBoxPrecio.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese un número en 'Precio'"
            LabelInsertarProducto.ForeColor = Color.Red

            TextBoxPrecio.Text = ""
            'TextBoxPrecio.Focus()
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRUCproveedor.TextChanged

    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBoxRUCproveedor.LostFocus
        Dim cantidad_proveedores As Integer
        cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count

        For i As Integer = 0 To (cantidad_proveedores - 1)
            'Si el PROVEEDOR ingresado existe'
            If DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                LabelInsertarProducto.Hide()

                TextBoxNombreProveedor.Text = DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor")
                TextBoxNumeroProveedor.Text = DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor")

                ButtonInsertarProducto.Focus()
            End If
        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        TextBoxCodigo.Clear()
        TextBoxCodigoDeBarras.Clear()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecioDeVenta.Clear()

        TextBoxCantidad.Clear()
        TextBoxFactura.Clear()
        TextBoxPrecio.Clear()

        TextBoxRUCproveedor.Clear()
        TextBoxNombreProveedor.Clear()
        TextBoxNumeroProveedor.Clear()

        LabelInsertarProducto.Visible = False

        TextBoxCodigoDeBarras.Focus()

    End Sub
End Class