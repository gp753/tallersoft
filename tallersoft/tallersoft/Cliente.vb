Public Class Cliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Sub

    Private Sub clienteAgreBtn_Click(sender As Object, e As EventArgs) Handles clienteAgreBtn.Click

        Dim CC As New crearClientes
        CC.Show()
    End Sub

    Private Sub clienteSalBtn_Click(sender As Object, e As EventArgs) Handles clienteSalBtn.Click
        Me.Hide()
    End Sub

    Private Sub clienteBusBtn_Click(sender As Object, e As EventArgs) Handles clienteBusBtn.Click
        Dim t As New herramientas
        Dim j, cant1, cant2, cant3 As Integer
        Dim cad1, cad2, dato As String
        Dim ban As Boolean = False
        Dim b As Boolean = False
        cad1 = clienteParTxt.Text.ToString
        cant1 = cad1.LongCount
        cant2 = DataSet1.Tables("cliente").Rows.Count
        dato = "nombre_cliente"
        clienteNombreList.Items.Clear()
        clienteApellidoList.Items.Clear()
        clienteNumeroList.Items.Clear()
        clienteRucList.Items.Clear()
        For j = 0 To cant2 - 1
            cad2 = DataSet1.Tables("cliente").Rows(j).Item(dato)

            cant3 = cad2.LongCount
            If cant1 <= cant3 Then
                If cad1 = cad2.Substring(0, cant1) Then
                    ban = True
                End If
            End If
            If ban Then
                clienteNombreList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("nombre_cliente"))
                clienteApellidoList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("apellido_cliente"))
                clienteNumeroList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("numero_cliente"))
                clienteRucList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("ruc_cliente"))
                ban = False
            End If
            If j = cant2 - 1 And b = False Then
                dato = "apellido_cliente"
                b = True
                j = 0
            End If
        Next

    End Sub

    Private Sub clienteNombreList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNombreList.SelectedIndexChanged

        clienteApellidoList.SelectedIndex = clienteNombreList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteNombreList.SelectedIndex
        clienteRucList.SelectedIndex = clienteNombreList.SelectedIndex
    End Sub

    Private Sub clienteApellidoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteApellidoList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteApellidoList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteApellidoList.SelectedIndex
        clienteRucList.SelectedIndex = clienteApellidoList.SelectedIndex
    End Sub

    Private Sub clienteNumeroList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNumeroList.SelectedIndexChanged
        clienteApellidoList.SelectedIndex = clienteNumeroList.SelectedIndex
        clienteRucList.SelectedIndex = clienteNumeroList.SelectedIndex
        clienteNombreList.SelectedIndex = clienteNumeroList.SelectedIndex
    End Sub

    Private Sub clienteRucList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteRucList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteRucList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteRucList.SelectedIndex
        clienteApellidoList.SelectedIndex = clienteRucList.SelectedIndex
    End Sub
End Class