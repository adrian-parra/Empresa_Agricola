Imports System.Data.SqlClient
Public Class VentaNewCliente

    Sub RegistrarCliente()
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

                Try
                    'ABRIR CONEXION BD
                    cn.Open()

                    'CONSULTA ADD CLIENTE
                    Dim query_add_cliente As New SqlCommand("insert into Cliente values('" + M_Direccion.IDdireccion + "','" + TXT_Nombre.Text + "','" + TXT_Telefono.Text + "','" + TXT_Correo.Text + "','" + TXT_Rfc.Text + "')", cn)
                    query_add_cliente.ExecuteNonQuery()

                    MsgBox("cliente agregado")
                    M_Direccion.IDdireccion = ""
                    M_Direccion.TipoDireccion = ""

                    BTN_Agregar_Direccion.Enabled = True

                    cn.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub


    Private Sub BTN_Registrar_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Cliente.Click


        RegistrarCliente()

    End Sub

    Private Sub VentaNewCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PROPIEDADES DE CONEXION BD
        cn.ConnectionString = conexion
    End Sub

    Private Sub BTN_Agregar_Direccion_Click(sender As Object, e As EventArgs) Handles BTN_Agregar_Direccion.Click
        'AGREGAR AL MODULO TIPO DE DIRECCION
        M_Direccion.TipoDireccion = "cliente"
        Direccion.Show()

        BTN_Agregar_Direccion.Enabled = False


    End Sub
End Class