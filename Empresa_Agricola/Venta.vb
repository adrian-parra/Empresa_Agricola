Imports System.Data.SqlClient
Public Class Venta
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BTN_Registrar_Venta_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Venta.Click
        'OBTENER ID
        Dim IDcliente As String = arr_IDcliente(CB_Cliente.SelectedIndex)
        Dim IDarticulo As String = arr_nombre_articulo(CB_Articulo.SelectedIndex)


        'REGISTRAR EL PEDIDO DEL CLIENTE

        cn.Open()
        Try
            Dim query_Pedidos_Clientes As New SqlCommand("insert into Pedidos_Clientes values('" + IDcliente + "' , '" + IDarticulo + "','" + CB_Tipo_Pago.Text + "','" + TXT_Cantidad.Text + "','" + TXT_Precio.Text + "','ACT','" + TXT_Folio.Text + "')", cn)
            query_Pedidos_Clientes.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            Exit Sub
        End Try




        If CB_Tipo_Pago.Text = "Efectivo" Then



            'REGISTRAR LA VENTA EN EFECTIVO
            'TRAER EL PEDIDO DEL CLIENTE CON EL FOLIO
            Try

                Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "'", cn)
                Dim leerDatos As SqlDataReader = query_folio_pedidos_cliente.ExecuteReader
                leerDatos.Read()


                Dim query_ventas As New SqlCommand("insert into Ventas values ('" + leerDatos.GetValue(0).ToString + "')", cn)
                    leerDatos.Close()
                query_ventas.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
                MsgBox("add datos efectivo")
            End Try





        ElseIf CB_Tipo_Pago.Text = "Credito" Then
            'REGISTRAR LA VENTA A CREDITO

            Try
                Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "'", cn)
                Dim leerDatos As SqlDataReader = query_folio_pedidos_cliente.ExecuteReader

                leerDatos.Read()

                Dim query_ventas As New SqlCommand("insert into Cuentas_Por_Cobrar values ('" + leerDatos.GetValue(0).ToString + "','" + TXT_Precio.Text + "','A')", cn)
                leerDatos.Close()
                query_ventas.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
                MsgBox("add datos CREDITO")
            End Try



        End If



    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion

        'MOSTRAR CLIENTE EN CB_CLIENTES
        'LIMPIAR ARR IDCLIENTE 
        arr_IDcliente.Clear()
        Try
            cn.Open()
            Dim query_Clientes As New SqlCommand("select * from Nombre_Clientes", cn)
            Dim leerDatos As SqlDataReader = query_Clientes.ExecuteReader
            While leerDatos.Read

                arr_IDcliente.Add(leerDatos.GetValue(0))
                CB_Cliente.Items.Add(leerDatos.GetValue(1))

            End While
            leerDatos.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

        'MOSTRAR ARTICULOS EN CB_ARTICULOS
        'LIMPIAR ARR ARR_ARTICULOS
        arr_nombre_articulo.Clear()

        Try
            cn.Open()
            Dim query_Articulos As New SqlCommand("select * from Nombre_Articulos", cn)
            Dim leerDatos As SqlDataReader = query_Articulos.ExecuteReader
            While leerDatos.Read

                arr_nombre_articulo.Add(leerDatos.GetValue(0))
                CB_Articulo.Items.Add(leerDatos.GetValue(1))

            End While
            leerDatos.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub
End Class