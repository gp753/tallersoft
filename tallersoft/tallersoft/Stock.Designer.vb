﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label41a = New System.Windows.Forms.Label()
        Me.TextBoxCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonInsertarProducto = New System.Windows.Forms.Button()
        Me.LabelInsertarProducto = New System.Windows.Forms.Label()
        Me.DataSet1 = New tallersoft.DataSet1()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New tallersoft.DataSet1TableAdapters.stockTableAdapter()
        Me.TableAdapterManager = New tallersoft.DataSet1TableAdapters.TableAdapterManager()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.IngresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngresoTableAdapter = New tallersoft.DataSet1TableAdapters.ingresoTableAdapter()
        Me.IngresoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxNumeroProveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxRUCproveedor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New tallersoft.DataSet1TableAdapters.proveedorTableAdapter()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxModificarNuevoPrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevaDescripcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoCodigo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxModificarCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxModificarCodigo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelModificarProducto = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New tallersoft.DataSet1TableAdapters.ventaTableAdapter()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxIngresarProducto = New System.Windows.Forms.GroupBox()
        Me.GroupBoxModificarProducto = New System.Windows.Forms.GroupBox()
        Me.ButtonIngresarProducto = New System.Windows.Forms.Button()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxIngresarProducto.SuspendLayout()
        Me.GroupBoxModificarProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(124, 41)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigo.TabIndex = 1
        '
        'Label41a
        '
        Me.Label41a.AutoSize = True
        Me.Label41a.Location = New System.Drawing.Point(79, 45)
        Me.Label41a.Name = "Label41a"
        Me.Label41a.Size = New System.Drawing.Size(43, 13)
        Me.Label41a.TabIndex = 4
        Me.Label41a.Text = "Código:"
        '
        'TextBoxCodigoDeBarras
        '
        Me.TextBoxCodigoDeBarras.Location = New System.Drawing.Point(124, 15)
        Me.TextBoxCodigoDeBarras.Name = "TextBoxCodigoDeBarras"
        Me.TextBoxCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigoDeBarras.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código de barras:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(124, 104)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(124, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'TextBoxPrecioDeVenta
        '
        Me.TextBoxPrecioDeVenta.Location = New System.Drawing.Point(124, 130)
        Me.TextBoxPrecioDeVenta.Name = "TextBoxPrecioDeVenta"
        Me.TextBoxPrecioDeVenta.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecioDeVenta.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio de venta:"
        '
        'ButtonInsertarProducto
        '
        Me.ButtonInsertarProducto.Location = New System.Drawing.Point(38, 359)
        Me.ButtonInsertarProducto.Name = "ButtonInsertarProducto"
        Me.ButtonInsertarProducto.Size = New System.Drawing.Size(96, 24)
        Me.ButtonInsertarProducto.TabIndex = 11
        Me.ButtonInsertarProducto.Text = "Insertar Producto"
        Me.ButtonInsertarProducto.UseVisualStyleBackColor = True
        '
        'LabelInsertarProducto
        '
        Me.LabelInsertarProducto.AutoSize = True
        Me.LabelInsertarProducto.Location = New System.Drawing.Point(146, 335)
        Me.LabelInsertarProducto.Name = "LabelInsertarProducto"
        Me.LabelInsertarProducto.Size = New System.Drawing.Size(111, 13)
        Me.LabelInsertarProducto.TabIndex = 15
        Me.LabelInsertarProducto.Text = "LabelInsertarProducto"
        Me.LabelInsertarProducto.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.DataSet1
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = tallersoft.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(300, 67)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(141, 75)
        Me.StockDataGridView.TabIndex = 2
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "codigo_barras"
        Me.DataGridViewTextBoxColumn3.HeaderText = "codigo_barras"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Costo:"
        '
        'TextBoxFactura
        '
        Me.TextBoxFactura.Location = New System.Drawing.Point(124, 192)
        Me.TextBoxFactura.Name = "TextBoxFactura"
        Me.TextBoxFactura.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxFactura.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Factura:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(124, 166)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCantidad.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cantidad:"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(124, 218)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecio.TabIndex = 7
        '
        'IngresoBindingSource
        '
        Me.IngresoBindingSource.DataMember = "ingreso"
        Me.IngresoBindingSource.DataSource = Me.DataSet1
        '
        'IngresoTableAdapter
        '
        Me.IngresoTableAdapter.ClearBeforeFill = True
        '
        'IngresoDataGridView
        '
        Me.IngresoDataGridView.AutoGenerateColumns = False
        Me.IngresoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngresoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.IngresoDataGridView.DataSource = Me.IngresoBindingSource
        Me.IngresoDataGridView.Location = New System.Drawing.Point(300, 139)
        Me.IngresoDataGridView.Name = "IngresoDataGridView"
        Me.IngresoDataGridView.Size = New System.Drawing.Size(141, 79)
        Me.IngresoDataGridView.TabIndex = 21
        Me.IngresoDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_ingreso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_ingreso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "factura_compra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "factura_compra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn12.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'TextBoxNumeroProveedor
        '
        Me.TextBoxNumeroProveedor.Location = New System.Drawing.Point(124, 306)
        Me.TextBoxNumeroProveedor.Name = "TextBoxNumeroProveedor"
        Me.TextBoxNumeroProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNumeroProveedor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Número del Proveedor:"
        '
        'TextBoxNombreProveedor
        '
        Me.TextBoxNombreProveedor.Location = New System.Drawing.Point(124, 280)
        Me.TextBoxNombreProveedor.Name = "TextBoxNombreProveedor"
        Me.TextBoxNombreProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombreProveedor.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nombre del Proveedor:"
        '
        'TextBoxRUCproveedor
        '
        Me.TextBoxRUCproveedor.Location = New System.Drawing.Point(124, 254)
        Me.TextBoxRUCproveedor.Name = "TextBoxRUCproveedor"
        Me.TextBoxRUCproveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxRUCproveedor.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "RUC del Proveedor:"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSet1
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(300, 220)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(140, 80)
        Me.ProveedorDataGridView.TabIndex = 27
        Me.ProveedorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn13.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn15.HeaderText = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "numero_proveedor"
        Me.DataGridViewTextBoxColumn16.HeaderText = "numero_proveedor"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Borrar Campos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxModificarNuevoPrecioDeVenta
        '
        Me.TextBoxModificarNuevoPrecioDeVenta.Location = New System.Drawing.Point(127, 233)
        Me.TextBoxModificarNuevoPrecioDeVenta.Name = "TextBoxModificarNuevoPrecioDeVenta"
        Me.TextBoxModificarNuevoPrecioDeVenta.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoPrecioDeVenta.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Nuevo Precio de venta:"
        '
        'TextBoxModificarNuevaDescripcion
        '
        Me.TextBoxModificarNuevaDescripcion.Location = New System.Drawing.Point(127, 207)
        Me.TextBoxModificarNuevaDescripcion.Name = "TextBoxModificarNuevaDescripcion"
        Me.TextBoxModificarNuevaDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevaDescripcion.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Nueva Descripción:"
        '
        'TextBoxModificarNuevoNombre
        '
        Me.TextBoxModificarNuevoNombre.Location = New System.Drawing.Point(127, 181)
        Me.TextBoxModificarNuevoNombre.Name = "TextBoxModificarNuevoNombre"
        Me.TextBoxModificarNuevoNombre.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoNombre.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(43, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Nuevo Nombre:"
        '
        'TextBoxModificarNuevoCodigoDeBarras
        '
        Me.TextBoxModificarNuevoCodigoDeBarras.Enabled = False
        Me.TextBoxModificarNuevoCodigoDeBarras.Location = New System.Drawing.Point(127, 118)
        Me.TextBoxModificarNuevoCodigoDeBarras.Name = "TextBoxModificarNuevoCodigoDeBarras"
        Me.TextBoxModificarNuevoCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoCodigoDeBarras.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Código de barras:"
        '
        'TextBoxModificarNuevoCodigo
        '
        Me.TextBoxModificarNuevoCodigo.Location = New System.Drawing.Point(127, 144)
        Me.TextBoxModificarNuevoCodigo.Name = "TextBoxModificarNuevoCodigo"
        Me.TextBoxModificarNuevoCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoCodigo.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(47, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Nuevo Código:"
        '
        'TextBoxModificarCodigoDeBarras
        '
        Me.TextBoxModificarCodigoDeBarras.Location = New System.Drawing.Point(127, 55)
        Me.TextBoxModificarCodigoDeBarras.Name = "TextBoxModificarCodigoDeBarras"
        Me.TextBoxModificarCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarCodigoDeBarras.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(35, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Código de barras:"
        '
        'TextBoxModificarCodigo
        '
        Me.TextBoxModificarCodigo.Location = New System.Drawing.Point(127, 81)
        Me.TextBoxModificarCodigo.Name = "TextBoxModificarCodigo"
        Me.TextBoxModificarCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarCodigo.TabIndex = 46
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(82, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Código:"
        '
        'LabelModificarProducto
        '
        Me.LabelModificarProducto.AutoSize = True
        Me.LabelModificarProducto.Location = New System.Drawing.Point(136, 271)
        Me.LabelModificarProducto.Name = "LabelModificarProducto"
        Me.LabelModificarProducto.Size = New System.Drawing.Size(119, 13)
        Me.LabelModificarProducto.TabIndex = 49
        Me.LabelModificarProducto.Text = "LabelModificarProducto"
        Me.LabelModificarProducto.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Borrar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Modificar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.DataSet1
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(300, 297)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.Size = New System.Drawing.Size(140, 79)
        Me.VentaDataGridView.TabIndex = 51
        Me.VentaDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "id_venta"
        Me.DataGridViewTextBoxColumn17.HeaderText = "id_venta"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn18.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "cantidad_venta"
        Me.DataGridViewTextBoxColumn20.HeaderText = "cantidad_venta"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "factura_venta"
        Me.DataGridViewTextBoxColumn21.HeaderText = "factura_venta"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'GroupBoxIngresarProducto
        '
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Button1)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNumeroProveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label8)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNombreProveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label9)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxRUCproveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label10)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label4)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxFactura)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label6)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label7)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.LabelInsertarProducto)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.ButtonInsertarProducto)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxPrecioDeVenta)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label5)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label3)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCodigoDeBarras)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label41a)
        Me.GroupBoxIngresarProducto.Location = New System.Drawing.Point(141, 15)
        Me.GroupBoxIngresarProducto.Name = "GroupBoxIngresarProducto"
        Me.GroupBoxIngresarProducto.Size = New System.Drawing.Size(304, 400)
        Me.GroupBoxIngresarProducto.TabIndex = 52
        Me.GroupBoxIngresarProducto.TabStop = False
        Me.GroupBoxIngresarProducto.Text = "Ingresar Producto"
        '
        'GroupBoxModificarProducto
        '
        Me.GroupBoxModificarProducto.Controls.Add(Me.Button2)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Button3)
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelModificarProducto)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarCodigoDeBarras)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label19)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarCodigo)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label20)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoPrecioDeVenta)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label14)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevaDescripcion)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label15)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoNombre)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label16)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoCodigoDeBarras)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label17)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoCodigo)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label18)
        Me.GroupBoxModificarProducto.Location = New System.Drawing.Point(488, 15)
        Me.GroupBoxModificarProducto.Name = "GroupBoxModificarProducto"
        Me.GroupBoxModificarProducto.Size = New System.Drawing.Size(304, 400)
        Me.GroupBoxModificarProducto.TabIndex = 53
        Me.GroupBoxModificarProducto.TabStop = False
        Me.GroupBoxModificarProducto.Text = "Modificar Producto"
        Me.GroupBoxModificarProducto.Visible = False
        '
        'ButtonIngresarProducto
        '
        Me.ButtonIngresarProducto.Location = New System.Drawing.Point(30, 52)
        Me.ButtonIngresarProducto.Name = "ButtonIngresarProducto"
        Me.ButtonIngresarProducto.Size = New System.Drawing.Size(72, 34)
        Me.ButtonIngresarProducto.TabIndex = 54
        Me.ButtonIngresarProducto.Text = "Ingresar Producto"
        Me.ButtonIngresarProducto.UseVisualStyleBackColor = True
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(30, 108)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(72, 34)
        Me.ButtonModificarProducto.TabIndex = 55
        Me.ButtonModificarProducto.Text = "Modificar Producto"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 432)
        Me.Controls.Add(Me.ButtonModificarProducto)
        Me.Controls.Add(Me.ButtonIngresarProducto)
        Me.Controls.Add(Me.GroupBoxIngresarProducto)
        Me.Controls.Add(Me.GroupBoxModificarProducto)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.IngresoDataGridView)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Name = "Stock"
        Me.Text = "Stock"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxIngresarProducto.ResumeLayout(False)
        Me.GroupBoxIngresarProducto.PerformLayout()
        Me.GroupBoxModificarProducto.ResumeLayout(False)
        Me.GroupBoxModificarProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label41a As Label
    Friend WithEvents TextBoxCodigoDeBarras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPrecioDeVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonInsertarProducto As Button
    Friend WithEvents LabelInsertarProducto As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxFactura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents IngresoBindingSource As BindingSource
    Friend WithEvents IngresoTableAdapter As DataSet1TableAdapters.ingresoTableAdapter
    Friend WithEvents IngresoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxNumeroProveedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxNombreProveedor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxRUCproveedor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As DataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxModificarNuevoPrecioDeVenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxModificarNuevaDescripcion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxModificarNuevoNombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxModificarNuevoCodigoDeBarras As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxModificarNuevoCodigo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxModificarCodigoDeBarras As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxModificarCodigo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents LabelModificarProducto As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As DataSet1TableAdapters.ventaTableAdapter
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxIngresarProducto As GroupBox
    Friend WithEvents GroupBoxModificarProducto As GroupBox
    Friend WithEvents ButtonIngresarProducto As Button
    Friend WithEvents ButtonModificarProducto As Button
End Class
