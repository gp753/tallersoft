﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Me.clientesBusGroup = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.clienteNumeroList = New System.Windows.Forms.ListBox()
        Me.clienteApellidoList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clienteNombreList = New System.Windows.Forms.ListBox()
        Me.clienteAgreBtn = New System.Windows.Forms.Button()
        Me.clienteSalBtn = New System.Windows.Forms.Button()
        Me.clienteParaLb = New System.Windows.Forms.Label()
        Me.clienteParTxt = New System.Windows.Forms.TextBox()
        Me.clienteBusBtn = New System.Windows.Forms.Button()
        Me.clienteLb = New System.Windows.Forms.Label()
        Me.DataSet1 = New tallersoft.DataSet1()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New tallersoft.DataSet1TableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New tallersoft.DataSet1TableAdapters.TableAdapterManager()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientesBusGroup.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientesBusGroup
        '
        Me.clientesBusGroup.Controls.Add(Me.TableLayoutPanel1)
        Me.clientesBusGroup.Controls.Add(Me.clienteAgreBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteSalBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteParaLb)
        Me.clientesBusGroup.Controls.Add(Me.clienteParTxt)
        Me.clientesBusGroup.Controls.Add(Me.clienteBusBtn)
        Me.clientesBusGroup.Location = New System.Drawing.Point(117, 50)
        Me.clientesBusGroup.Name = "clientesBusGroup"
        Me.clientesBusGroup.Size = New System.Drawing.Size(626, 388)
        Me.clientesBusGroup.TabIndex = 19
        Me.clientesBusGroup.TabStop = False
        Me.clientesBusGroup.Text = "Buscar Cliente"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92746!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07254!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNumeroList, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteApellidoList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNombreList, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(22, 86)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(569, 280)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'clienteNumeroList
        '
        Me.clienteNumeroList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.clienteNumeroList.FormattingEnabled = True
        Me.clienteNumeroList.Location = New System.Drawing.Point(375, 23)
        Me.clienteNumeroList.Name = "clienteNumeroList"
        Me.clienteNumeroList.Size = New System.Drawing.Size(190, 251)
        Me.clienteNumeroList.TabIndex = 6
        '
        'clienteApellidoList
        '
        Me.clienteApellidoList.FormattingEnabled = True
        Me.clienteApellidoList.Location = New System.Drawing.Point(181, 23)
        Me.clienteApellidoList.Name = "clienteApellidoList"
        Me.clienteApellidoList.Size = New System.Drawing.Size(188, 251)
        Me.clienteApellidoList.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proveedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruc:"
        '
        'clienteNombreList
        '
        Me.clienteNombreList.FormattingEnabled = True
        Me.clienteNombreList.Location = New System.Drawing.Point(3, 23)
        Me.clienteNombreList.Name = "clienteNombreList"
        Me.clienteNombreList.Size = New System.Drawing.Size(172, 251)
        Me.clienteNombreList.TabIndex = 4
        '
        'clienteAgreBtn
        '
        Me.clienteAgreBtn.Location = New System.Drawing.Point(434, 57)
        Me.clienteAgreBtn.Name = "clienteAgreBtn"
        Me.clienteAgreBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteAgreBtn.TabIndex = 16
        Me.clienteAgreBtn.Text = "Agregar"
        Me.clienteAgreBtn.UseVisualStyleBackColor = True
        '
        'clienteSalBtn
        '
        Me.clienteSalBtn.Location = New System.Drawing.Point(515, 57)
        Me.clienteSalBtn.Name = "clienteSalBtn"
        Me.clienteSalBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteSalBtn.TabIndex = 15
        Me.clienteSalBtn.Text = "Salir"
        Me.clienteSalBtn.UseVisualStyleBackColor = True
        '
        'clienteParaLb
        '
        Me.clienteParaLb.AutoSize = True
        Me.clienteParaLb.Location = New System.Drawing.Point(17, 30)
        Me.clienteParaLb.Name = "clienteParaLb"
        Me.clienteParaLb.Size = New System.Drawing.Size(123, 13)
        Me.clienteParaLb.TabIndex = 4
        Me.clienteParaLb.Text = "Parametro de busqueda:"
        '
        'clienteParTxt
        '
        Me.clienteParTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.clienteParTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.clienteParTxt.Location = New System.Drawing.Point(146, 23)
        Me.clienteParTxt.Name = "clienteParTxt"
        Me.clienteParTxt.Size = New System.Drawing.Size(445, 20)
        Me.clienteParTxt.TabIndex = 0
        Me.clienteParTxt.Tag = "Holi"
        '
        'clienteBusBtn
        '
        Me.clienteBusBtn.Location = New System.Drawing.Point(353, 57)
        Me.clienteBusBtn.Name = "clienteBusBtn"
        Me.clienteBusBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteBusBtn.TabIndex = 11
        Me.clienteBusBtn.Text = "Buscar"
        Me.clienteBusBtn.UseVisualStyleBackColor = True
        '
        'clienteLb
        '
        Me.clienteLb.AutoSize = True
        Me.clienteLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteLb.Location = New System.Drawing.Point(338, 10)
        Me.clienteLb.Name = "clienteLb"
        Me.clienteLb.Size = New System.Drawing.Size(207, 37)
        Me.clienteLb.TabIndex = 18
        Me.clienteLb.Text = "Proveedores"
        Me.clienteLb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cliente1TableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.ingreso1TableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedor1TableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = tallersoft.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(773, 107)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ProveedorDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numero_proveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numero_proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1171, 458)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.clientesBusGroup)
        Me.Controls.Add(Me.clienteLb)
        Me.Name = "Proveedor"
        Me.Text = "Proveedor"
        Me.clientesBusGroup.ResumeLayout(False)
        Me.clientesBusGroup.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clientesBusGroup As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents clienteNumeroList As ListBox
    Friend WithEvents clienteApellidoList As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clienteNombreList As ListBox
    Friend WithEvents clienteAgreBtn As Button
    Friend WithEvents clienteSalBtn As Button
    Friend WithEvents clienteParaLb As Label
    Friend WithEvents clienteParTxt As TextBox
    Friend WithEvents clienteBusBtn As Button
    Friend WithEvents clienteLb As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As DataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
