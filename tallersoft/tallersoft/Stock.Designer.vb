<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(151, 44)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigo.TabIndex = 1
        '
        'Label41a
        '
        Me.Label41a.AutoSize = True
        Me.Label41a.Location = New System.Drawing.Point(106, 48)
        Me.Label41a.Name = "Label41a"
        Me.Label41a.Size = New System.Drawing.Size(43, 13)
        Me.Label41a.TabIndex = 4
        Me.Label41a.Text = "Código:"
        '
        'TextBoxCodigoDeBarras
        '
        Me.TextBoxCodigoDeBarras.Location = New System.Drawing.Point(151, 18)
        Me.TextBoxCodigoDeBarras.Name = "TextBoxCodigoDeBarras"
        Me.TextBoxCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigoDeBarras.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código de barras:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(151, 107)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(151, 81)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'TextBoxPrecioDeVenta
        '
        Me.TextBoxPrecioDeVenta.Location = New System.Drawing.Point(151, 133)
        Me.TextBoxPrecioDeVenta.Name = "TextBoxPrecioDeVenta"
        Me.TextBoxPrecioDeVenta.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecioDeVenta.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio de venta:"
        '
        'ButtonInsertarProducto
        '
        Me.ButtonInsertarProducto.Location = New System.Drawing.Point(65, 362)
        Me.ButtonInsertarProducto.Name = "ButtonInsertarProducto"
        Me.ButtonInsertarProducto.Size = New System.Drawing.Size(96, 24)
        Me.ButtonInsertarProducto.TabIndex = 11
        Me.ButtonInsertarProducto.Text = "Insertar Producto"
        Me.ButtonInsertarProducto.UseVisualStyleBackColor = True
        '
        'LabelInsertarProducto
        '
        Me.LabelInsertarProducto.AutoSize = True
        Me.LabelInsertarProducto.Location = New System.Drawing.Point(173, 338)
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
        Me.StockDataGridView.Location = New System.Drawing.Point(373, 67)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(183, 75)
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
        Me.Label4.Location = New System.Drawing.Point(109, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Precio:"
        '
        'TextBoxFactura
        '
        Me.TextBoxFactura.Location = New System.Drawing.Point(151, 195)
        Me.TextBoxFactura.Name = "TextBoxFactura"
        Me.TextBoxFactura.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxFactura.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Factura:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(151, 169)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCantidad.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cantidad:"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(151, 221)
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
        Me.IngresoDataGridView.Location = New System.Drawing.Point(373, 139)
        Me.IngresoDataGridView.Name = "IngresoDataGridView"
        Me.IngresoDataGridView.Size = New System.Drawing.Size(183, 79)
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
        Me.TextBoxNumeroProveedor.Location = New System.Drawing.Point(151, 309)
        Me.TextBoxNumeroProveedor.Name = "TextBoxNumeroProveedor"
        Me.TextBoxNumeroProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNumeroProveedor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Número del Proveedor:"
        '
        'TextBoxNombreProveedor
        '
        Me.TextBoxNombreProveedor.Location = New System.Drawing.Point(151, 283)
        Me.TextBoxNombreProveedor.Name = "TextBoxNombreProveedor"
        Me.TextBoxNombreProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombreProveedor.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nombre del Proveedor:"
        '
        'TextBoxRUCproveedor
        '
        Me.TextBoxRUCproveedor.Location = New System.Drawing.Point(151, 257)
        Me.TextBoxRUCproveedor.Name = "TextBoxRUCproveedor"
        Me.TextBoxRUCproveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxRUCproveedor.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 261)
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
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(373, 220)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(182, 80)
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
        Me.Button1.Location = New System.Drawing.Point(225, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Borrar Campos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 486)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.TextBoxNumeroProveedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxNombreProveedor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxRUCproveedor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelInsertarProducto)
        Me.Controls.Add(Me.ButtonInsertarProducto)
        Me.Controls.Add(Me.TextBoxPrecioDeVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCodigoDeBarras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.Label41a)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
