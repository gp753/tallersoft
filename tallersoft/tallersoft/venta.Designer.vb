﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.n_factura_textbox = New System.Windows.Forms.TextBox()
        Me.label_n_factura = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.label_ruc_venta = New System.Windows.Forms.Label()
        Me.text_total = New System.Windows.Forms.TextBox()
        Me.label_total = New System.Windows.Forms.Label()
        Me.text_iva = New System.Windows.Forms.TextBox()
        Me.label_iva = New System.Windows.Forms.Label()
        Me.text_sub_total = New System.Windows.Forms.TextBox()
        Me.label_subtotal = New System.Windows.Forms.Label()
        Me.venta_guardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.label_venta_cliente = New System.Windows.Forms.Label()
        Me.text_ruc_venta = New System.Windows.Forms.TextBox()
        Me.label_ruc = New System.Windows.Forms.Label()
        Me.DataSet1 = New tallersoft.DataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New tallersoft.DataSet1TableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New tallersoft.DataSet1TableAdapters.TableAdapterManager()
        Me.IngresoTableAdapter = New tallersoft.DataSet1TableAdapters.ingresoTableAdapter()
        Me.StockTableAdapter = New tallersoft.DataSet1TableAdapters.stockTableAdapter()
        Me.VentaTableAdapter = New tallersoft.DataSet1TableAdapters.ventaTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngresoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(111, 380)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 49
        Me.Button20.Text = "Modificar"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(30, 471)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 23)
        Me.Button31.TabIndex = 45
        Me.Button31.Text = "Anterior"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(111, 471)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(75, 23)
        Me.Button30.TabIndex = 44
        Me.Button30.Text = "Siguiente"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(30, 442)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(156, 23)
        Me.Button29.TabIndex = 43
        Me.Button29.Text = "Buscar por factura"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'n_factura_textbox
        '
        Me.n_factura_textbox.Location = New System.Drawing.Point(517, 57)
        Me.n_factura_textbox.Name = "n_factura_textbox"
        Me.n_factura_textbox.Size = New System.Drawing.Size(109, 20)
        Me.n_factura_textbox.TabIndex = 42
        '
        'label_n_factura
        '
        Me.label_n_factura.AutoSize = True
        Me.label_n_factura.Location = New System.Drawing.Point(437, 62)
        Me.label_n_factura.Name = "label_n_factura"
        Me.label_n_factura.Size = New System.Drawing.Size(66, 13)
        Me.label_n_factura.TabIndex = 41
        Me.label_n_factura.Text = "Nro. Factura"
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(30, 380)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(75, 23)
        Me.Button24.TabIndex = 40
        Me.Button24.Text = "Nuevo"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'label_ruc_venta
        '
        Me.label_ruc_venta.AutoSize = True
        Me.label_ruc_venta.Location = New System.Drawing.Point(177, 22)
        Me.label_ruc_venta.Name = "label_ruc_venta"
        Me.label_ruc_venta.Size = New System.Drawing.Size(83, 13)
        Me.label_ruc_venta.TabIndex = 39
        Me.label_ruc_venta.Text = "label_ruc_venta"
        '
        'text_total
        '
        Me.text_total.Location = New System.Drawing.Point(501, 469)
        Me.text_total.Name = "text_total"
        Me.text_total.ReadOnly = True
        Me.text_total.Size = New System.Drawing.Size(100, 20)
        Me.text_total.TabIndex = 38
        Me.text_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Location = New System.Drawing.Point(400, 476)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(42, 13)
        Me.label_total.TabIndex = 37
        Me.label_total.Text = "TOTAL"
        '
        'text_iva
        '
        Me.text_iva.Location = New System.Drawing.Point(501, 433)
        Me.text_iva.Name = "text_iva"
        Me.text_iva.ReadOnly = True
        Me.text_iva.Size = New System.Drawing.Size(100, 20)
        Me.text_iva.TabIndex = 36
        Me.text_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_iva
        '
        Me.label_iva.AutoSize = True
        Me.label_iva.Location = New System.Drawing.Point(400, 440)
        Me.label_iva.Name = "label_iva"
        Me.label_iva.Size = New System.Drawing.Size(24, 13)
        Me.label_iva.TabIndex = 35
        Me.label_iva.Text = "IVA"
        '
        'text_sub_total
        '
        Me.text_sub_total.Location = New System.Drawing.Point(501, 394)
        Me.text_sub_total.Name = "text_sub_total"
        Me.text_sub_total.ReadOnly = True
        Me.text_sub_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.text_sub_total.Size = New System.Drawing.Size(100, 20)
        Me.text_sub_total.TabIndex = 34
        Me.text_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_subtotal
        '
        Me.label_subtotal.AutoSize = True
        Me.label_subtotal.Location = New System.Drawing.Point(400, 401)
        Me.label_subtotal.Name = "label_subtotal"
        Me.label_subtotal.Size = New System.Drawing.Size(67, 13)
        Me.label_subtotal.TabIndex = 33
        Me.label_subtotal.Text = "SUB TOTAL"
        '
        'venta_guardar
        '
        Me.venta_guardar.Location = New System.Drawing.Point(30, 413)
        Me.venta_guardar.Name = "venta_guardar"
        Me.venta_guardar.Size = New System.Drawing.Size(75, 23)
        Me.venta_guardar.TabIndex = 32
        Me.venta_guardar.Text = "Guardar"
        Me.venta_guardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Punit, Me.cant, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 236)
        Me.DataGridView1.TabIndex = 31
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Producto
        '
        Me.Producto.Frozen = True
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Punit
        '
        Me.Punit.HeaderText = "P/unid"
        Me.Punit.Name = "Punit"
        Me.Punit.ReadOnly = True
        '
        'cant
        '
        Me.cant.HeaderText = "Cant"
        Me.cant.Name = "cant"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(517, 21)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(109, 20)
        Me.TextBox17.TabIndex = 30
        '
        'label_fecha
        '
        Me.label_fecha.AutoSize = True
        Me.label_fecha.Location = New System.Drawing.Point(466, 26)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(37, 13)
        Me.label_fecha.TabIndex = 29
        Me.label_fecha.Text = "Fecha"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(69, 59)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(335, 20)
        Me.TextBox16.TabIndex = 28
        '
        'label_venta_cliente
        '
        Me.label_venta_cliente.AutoSize = True
        Me.label_venta_cliente.Location = New System.Drawing.Point(24, 64)
        Me.label_venta_cliente.Name = "label_venta_cliente"
        Me.label_venta_cliente.Size = New System.Drawing.Size(39, 13)
        Me.label_venta_cliente.TabIndex = 27
        Me.label_venta_cliente.Text = "Cliente"
        '
        'text_ruc_venta
        '
        Me.text_ruc_venta.Location = New System.Drawing.Point(60, 19)
        Me.text_ruc_venta.Name = "text_ruc_venta"
        Me.text_ruc_venta.Size = New System.Drawing.Size(100, 20)
        Me.text_ruc_venta.TabIndex = 26
        '
        'label_ruc
        '
        Me.label_ruc.AutoSize = True
        Me.label_ruc.Location = New System.Drawing.Point(24, 24)
        Me.label_ruc.Name = "label_ruc"
        Me.label_ruc.Size = New System.Drawing.Size(30, 13)
        Me.label_ruc.TabIndex = 25
        Me.label_ruc.Text = "RUC"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.ingresoTableAdapter = Me.IngresoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = tallersoft.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Me.VentaTableAdapter
        '
        'IngresoTableAdapter
        '
        Me.IngresoTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(684, 19)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ClienteDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numero_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numero_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ruc_cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ruc_cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IngresoBindingSource
        '
        Me.IngresoBindingSource.DataMember = "ingreso"
        Me.IngresoBindingSource.DataSource = Me.DataSet1
        '
        'IngresoDataGridView
        '
        Me.IngresoDataGridView.AutoGenerateColumns = False
        Me.IngresoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngresoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.IngresoDataGridView.DataSource = Me.IngresoBindingSource
        Me.IngresoDataGridView.Location = New System.Drawing.Point(1005, 19)
        Me.IngresoDataGridView.Name = "IngresoDataGridView"
        Me.IngresoDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.IngresoDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_ingreso"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_ingreso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "factura_compra"
        Me.DataGridViewTextBoxColumn10.HeaderText = "factura_compra"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.DataSet1
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(684, 245)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.StockDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn12.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "codigo_barras"
        Me.DataGridViewTextBoxColumn14.HeaderText = "codigo_barras"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn15.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn16.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn17.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.DataSet1
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(1005, 245)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VentaDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "id_venta"
        Me.DataGridViewTextBoxColumn18.HeaderText = "id_venta"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn20.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "cantidad_venta"
        Me.DataGridViewTextBoxColumn21.HeaderText = "cantidad_venta"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "factura_venta"
        Me.DataGridViewTextBoxColumn22.HeaderText = "factura_venta"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.IngresoDataGridView)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.n_factura_textbox)
        Me.Controls.Add(Me.label_n_factura)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.label_ruc_venta)
        Me.Controls.Add(Me.text_total)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.text_iva)
        Me.Controls.Add(Me.label_iva)
        Me.Controls.Add(Me.text_sub_total)
        Me.Controls.Add(Me.label_subtotal)
        Me.Controls.Add(Me.venta_guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.label_fecha)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.label_venta_cliente)
        Me.Controls.Add(Me.text_ruc_venta)
        Me.Controls.Add(Me.label_ruc)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "venta"
        Me.Text = "venta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button20 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents n_factura_textbox As TextBox
    Friend WithEvents label_n_factura As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents label_ruc_venta As Label
    Friend WithEvents text_total As TextBox
    Friend WithEvents label_total As Label
    Friend WithEvents text_iva As TextBox
    Friend WithEvents label_iva As Label
    Friend WithEvents text_sub_total As TextBox
    Friend WithEvents label_subtotal As Label
    Friend WithEvents venta_guardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Punit As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents label_fecha As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents label_venta_cliente As Label
    Friend WithEvents text_ruc_venta As TextBox
    Friend WithEvents label_ruc As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IngresoTableAdapter As DataSet1TableAdapters.ingresoTableAdapter
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IngresoBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents IngresoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As DataSet1TableAdapters.ventaTableAdapter
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
