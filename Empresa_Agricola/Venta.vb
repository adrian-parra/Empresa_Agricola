Imports System.Data.SqlClient
Public Class Venta
    Dim articulos As New DataTable
    Dim row As DataRow
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BTN_Registrar_Venta_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Venta.Click
        'OBTENER ID
        Dim IDcliente As String = arr_IDcliente(CB_Cliente.SelectedIndex)
        Dim IDarticulo As String = arr_nombre_articulo(CB_Articulo.SelectedIndex)


        'REGISTRAR EL PEDIDO DEL CLIENTE

        cn.Open()
        Try
            Dim query_Pedidos_Clientes As New SqlCommand("insert into Pedidos_Clientes values('" + IDcliente + "' ,'" + CB_Tipo_Pago.Text + "','ACT','" + TXT_Folio.Text + "')", cn)
            query_Pedidos_Clientes.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            Exit Sub
        End Try

        'REGISTRAR EL PEDIDO DE ARTICULOS
        Try
            'TRAER ID DE PEDIDO
            Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "'", cn)
            Dim leerDatos As SqlDataReader = query_folio_pedidos_cliente.ExecuteReader
            leerDatos.Read()
            Dim ID_Pedido_Cliente As String = leerDatos.GetValue(0)

            leerDatos.Close()

            'GUARDAR ARTICULOS DE CLIENTE
            For i = 0 To articulos.Rows.Count - 1
                'CONSULTA PARA INSERTAR LOS ARTICULOS
                Dim query_insert_articulos As New SqlCommand("insert into Pedido_Articulo values ('" + ID_Pedido_Cliente + "','" + articulos.Rows(i)(0) + "','" + articulos.Rows(i)(1) + "','" + articulos.Rows(i)(2) + "')", cn)
                query_insert_articulos.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
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

                Dim query_ventas As New SqlCommand("insert into Cuentas_Por_Cobrar values ('" + leerDatos.GetValue(0).ToString + "','" + SumArticulos() + "','A')", cn)
                leerDatos.Close()
                query_ventas.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
                MsgBox("add datos CREDITO")
                articulos.Rows.Clear()

                'LIBERAR MEMORIA
                'cn.Dispose()
                'articulos.Dispose()

            End Try



        End If



    End Sub

    'FUNCION PARA SUMAR EL PRECIO DE ARTICULOS
    Function SumArticulos()
        Dim suma As Double = 0.0

        For i = 0 To articulos.Rows.Count - 1

            suma += CDbl(articulos.Rows(i)(2))
        Next

        Return suma.ToString
    End Function
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cn.ConnectionString = conexion





        articulos.Columns.Add("Articulo")
        articulos.Columns.Add("Cantidad")
        articulos.Columns.Add("Precio")



        'MOSTRAR EN LISTVIW
        'For y = 0 To tabla.Rows.Count - 1
        '    LB_Articulos.Items.Add(tabla.Rows(y)(0))

        '    LB_Articulos.Items.Add(tabla.Rows(y)(1))
        '    LB_Articulos.Items.Add(tabla.Rows(y)(2))

        'Next




        'MOSTRAR CLIENTE EN CB_CLIENTES
        'LIMPIAR ARR IDCLIENTE 
        arr_IDcliente.Clear()
        Try
            cn.Open()
            Dim query_Clientes As New SqlCommand("select * from Cliente", cn)
            Dim leerDatos As SqlDataReader = query_Clientes.ExecuteReader
            While leerDatos.Read

                arr_IDcliente.Add(leerDatos.GetValue(0))
                CB_Cliente.Items.Add(leerDatos.GetValue(2))

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

    Private Sub BTN_Cunetas_Por_Cobrar_Click(sender As Object, e As EventArgs) Handles BTN_Cunetas_Por_Cobrar.Click
        VentaCuentasPorCobrar.Show()
    End Sub

    Private Sub BTN_Agrergar_Articulo_Click(sender As Object, e As EventArgs) Handles BTN_Agrergar_Articulo.Click
        If TXT_Cantidad.Text = "" Then
            MsgBox("ingrese la cantidad de articulo")
        ElseIf TXT_Precio.Text = "" Then
            MsgBox("ingrese el precio de articulo")
        Else

            row = articulos.NewRow()

            row("Articulo") = CB_Articulo.Text
            row("Cantidad") = TXT_Cantidad.Text
            row("Precio") = TXT_Precio.Text

            articulos.Rows.Add(row)

            'ADD PEDIDO ARTICULO A DGB
            DGV_Articulos.DataSource = articulos



            'BORRAR DATOS DE TEXTBOX Y CB
            CB_Articulo.Text = ""
            TXT_Cantidad.Text = ""
            TXT_Precio.Text = ""
        End If
    End Sub

    Private Sub BTN_Add_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Add_Cliente.Click
        VentaNewCliente.Show()

    End Sub
End Class