<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cliente
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
        Me.clienteEliBtn = New System.Windows.Forms.Button()
        Me.clienteLb = New System.Windows.Forms.Label()
        Me.clientesBusGroup = New System.Windows.Forms.GroupBox()
        Me.clienteAgreBtn = New System.Windows.Forms.Button()
        Me.clienteSalBtn = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New tallersoft.DataSet1()
        Me.clienteParaLb = New System.Windows.Forms.Label()
        Me.clienteParTxt = New System.Windows.Forms.TextBox()
        Me.clienteBusBtn = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New tallersoft.DataSet1TableAdapters.clienteTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clienteNombreList = New System.Windows.Forms.ListBox()
        Me.clienteApellidoList = New System.Windows.Forms.ListBox()
        Me.clienteNumeroList = New System.Windows.Forms.ListBox()
        Me.clienteRucList = New System.Windows.Forms.ListBox()
        Me.clientesBusGroup.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'clienteEliBtn
        '
        Me.clienteEliBtn.Location = New System.Drawing.Point(433, 57)
        Me.clienteEliBtn.Name = "clienteEliBtn"
        Me.clienteEliBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteEliBtn.TabIndex = 14
        Me.clienteEliBtn.Text = "Eliminar"
        Me.clienteEliBtn.UseVisualStyleBackColor = True
        '
        'clienteLb
        '
        Me.clienteLb.AutoSize = True
        Me.clienteLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteLb.Location = New System.Drawing.Point(257, 9)
        Me.clienteLb.Name = "clienteLb"
        Me.clienteLb.Size = New System.Drawing.Size(139, 37)
        Me.clienteLb.TabIndex = 15
        Me.clienteLb.Text = "Clientes"
        Me.clienteLb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clientesBusGroup
        '
        Me.clientesBusGroup.Controls.Add(Me.TableLayoutPanel1)
        Me.clientesBusGroup.Controls.Add(Me.clienteAgreBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteSalBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteParaLb)
        Me.clientesBusGroup.Controls.Add(Me.clienteParTxt)
        Me.clientesBusGroup.Controls.Add(Me.clienteEliBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteBusBtn)
        Me.clientesBusGroup.Location = New System.Drawing.Point(12, 49)
        Me.clientesBusGroup.Name = "clientesBusGroup"
        Me.clientesBusGroup.Size = New System.Drawing.Size(626, 388)
        Me.clientesBusGroup.TabIndex = 17
        Me.clientesBusGroup.TabStop = False
        Me.clientesBusGroup.Text = "Buscar Cliente"
        '
        'clienteAgreBtn
        '
        Me.clienteAgreBtn.Location = New System.Drawing.Point(352, 57)
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
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.clienteParTxt.Location = New System.Drawing.Point(146, 23)
        Me.clienteParTxt.Name = "clienteParTxt"
        Me.clienteParTxt.Size = New System.Drawing.Size(445, 20)
        Me.clienteParTxt.TabIndex = 0
        '
        'clienteBusBtn
        '
        Me.clienteBusBtn.Location = New System.Drawing.Point(271, 57)
        Me.clienteBusBtn.Name = "clienteBusBtn"
        Me.clienteBusBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteBusBtn.TabIndex = 11
        Me.clienteBusBtn.Text = "Buscar"
        Me.clienteBusBtn.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92746!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07254!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.clienteRucList, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNumeroList, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteApellidoList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNombreList, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 102)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(614, 280)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(505, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ruc:"
        '
        'clienteNombreList
        '
        Me.clienteNombreList.FormattingEnabled = True
        Me.clienteNombreList.Location = New System.Drawing.Point(3, 23)
        Me.clienteNombreList.Name = "clienteNombreList"
        Me.clienteNombreList.Size = New System.Drawing.Size(178, 251)
        Me.clienteNombreList.TabIndex = 4
        '
        'clienteApellidoList
        '
        Me.clienteApellidoList.FormattingEnabled = True
        Me.clienteApellidoList.Location = New System.Drawing.Point(187, 23)
        Me.clienteApellidoList.Name = "clienteApellidoList"
        Me.clienteApellidoList.Size = New System.Drawing.Size(194, 251)
        Me.clienteApellidoList.TabIndex = 5
        '
        'clienteNumeroList
        '
        Me.clienteNumeroList.FormattingEnabled = True
        Me.clienteNumeroList.Location = New System.Drawing.Point(387, 23)
        Me.clienteNumeroList.Name = "clienteNumeroList"
        Me.clienteNumeroList.Size = New System.Drawing.Size(112, 251)
        Me.clienteNumeroList.TabIndex = 6
        '
        'clienteRucList
        '
        Me.clienteRucList.FormattingEnabled = True
        Me.clienteRucList.Location = New System.Drawing.Point(505, 23)
        Me.clienteRucList.Name = "clienteRucList"
        Me.clienteRucList.Size = New System.Drawing.Size(106, 251)
        Me.clienteRucList.TabIndex = 7
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(659, 453)
        Me.Controls.Add(Me.clientesBusGroup)
        Me.Controls.Add(Me.clienteLb)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.clientesBusGroup.ResumeLayout(False)
        Me.clientesBusGroup.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clienteEliBtn As Button
    Friend WithEvents clienteLb As Label
    Friend WithEvents clientesBusGroup As GroupBox
    Friend WithEvents clienteParaLb As Label
    Friend WithEvents clienteParTxt As TextBox
    Friend WithEvents clienteBusBtn As Button
    Friend WithEvents clienteSalBtn As Button
    Friend WithEvents clienteAgreBtn As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents clienteRucList As ListBox
    Friend WithEvents clienteNumeroList As ListBox
    Friend WithEvents clienteApellidoList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clienteNombreList As ListBox
End Class
