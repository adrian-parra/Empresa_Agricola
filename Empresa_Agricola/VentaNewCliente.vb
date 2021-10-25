Public Class VentaNewCliente


    Private Sub BTN_Registrar_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Cliente.Click
        'VALIDAR TXT 
        If TXT_Correo.Text = "" Then
            MsgBox("campos de textos obligatorios")
        ElseIf TXT_Nombre.Text = "" Then
            MsgBox("campos de textos obligatorios")
        ElseIf TXT_Rfc.Text = "" Then
            MsgBox("campos de textos obligatorios")
        ElseIf TXT_Telefono.Text = "" Then
            MsgBox("campos de textos obligatorios")
        Else
            'VALIDAR DIRECCION DE CLIENTE
            If M_Direccion.IDdireccion = "" Then
                MsgBox("Tiene que agregar la direccion del cliente")
            Else
                'TODO VALIDADDO

            End If
        End If
    End Sub

    Private Sub VentaNewCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_Agregar_Direccion_Click(sender As Object, e As EventArgs) Handles BTN_Agregar_Direccion.Click
        'AGREGAR AL MODULO TIPO DE DIRECCION
        M_Direccion.TipoDireccion = "Cliente"
        Direccion.Show()

    End Sub
End Class