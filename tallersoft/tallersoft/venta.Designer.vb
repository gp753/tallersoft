<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Button20 = New System.Windows.Forms.Button()
        Me.bt_imprimir = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'bt_imprimir
        '
        Me.bt_imprimir.Location = New System.Drawing.Point(111, 413)
        Me.bt_imprimir.Name = "bt_imprimir"
        Me.bt_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.bt_imprimir.TabIndex = 48
        Me.bt_imprimir.Text = "Imprimir"
        Me.bt_imprimir.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(30, 471)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 23)
        Me.Button31.TabIndex = 45
        Me.Button31.Text = "Anterior"
        Me.Button31.UseVisualStyleBackColor = True
        Me.Button31.Visible = False
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(111, 471)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(75, 23)
        Me.Button30.TabIndex = 44
        Me.Button30.Text = "Siguiente"
        Me.Button30.UseVisualStyleBackColor = True
        Me.Button30.Visible = False
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
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 538)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.bt_imprimir)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button20 As Button
    Friend WithEvents bt_imprimir As Button
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
End Class
