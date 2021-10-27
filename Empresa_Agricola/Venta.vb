Imports System.Data.SqlClient
Public Class Venta
    Dim articulos As New DataTable
    Dim row As DataRow
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Function GenerarFolio()
        Dim folio As String = ""
        Dim numAleatorio As New Random(CInt(Date.Now.Ticks And Integer.MaxValue))

        Dim al = System.Convert.ToString(numAleatorio.Next)



        Dim leerdatos As SqlDataReader

        Try
            cn.Open()
            Dim query_id_pedido_cliente As New SqlCommand("select max(ID_Pedido) from Pedidos_Clientes", cn)

            leerdatos = query_id_pedido_cliente.ExecuteReader

            leerdatos.Read()

            If leerdatos.GetValue(0).ToString = "" Then
                folio = "1"
            Else
                folio = (CInt(leerdatos.GetValue(0)) + 1).ToString
            End If


            'crear folio
            Dim numCarcateres As Integer = 10 - folio.Length


            If numCarcateres <= al.Length Then
                folio += Mid(al, 1, numCarcateres)
            Else
                Dim caracfaltantes As Integer = numCarcateres - al.Length



                folio += Mid(al, 1, al.Length)

                For i = 1 To caracfaltantes
                    folio += "0"
                Next



            End If
            leerdatos.Close()
            cn.Close()

            Return folio


        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            If Not leerdatos.IsClosed Then
                leerdatos.Close()
            End If
        End Try
    End Function

    Sub limpiartext()
        CB_Cliente.Text = ""
        CB_Tipo_Pago.Text = ""
    End Sub

    Private Sub BTN_Registrar_Venta_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Venta.Click
        'VALIDAR TEXTBOX,COMBOBOX
        If CB_Cliente.Text = "" Then
            MsgBox("CAMPOS FALTANTES")
            Exit Sub
        ElseIf CB_Tipo_Pago.Text = "" Then
            MsgBox("CAMPOS FALTANTES")
            Exit Sub
        End If

        'GENERAR FOLIO
        Dim folio As String = GenerarFolio()


        'OBTENER ID
        Dim IDcliente As String = arr_IDcliente(CB_Cliente.SelectedIndex)
        Dim IDarticulo As String = arr_nombre_articulo(CB_Articulo.SelectedIndex)


        'REGISTRAR EL PEDIDO DEL CLIENTE


        Try
            cn.Open()
            Dim query_Pedidos_Clientes As New SqlCommand("insert into Pedidos_Clientes values('" + IDcliente + "' ,'" + CB_Tipo_Pago.Text + "','PEN','" + folio + "')", cn)
            query_Pedidos_Clientes.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            Exit Sub
        End Try

        'REGISTRAR EL PEDIDO DE ARTICULOS
        Dim leerDatos As SqlDataReader
        Try
            'TRAER ID DE PEDIDO
            Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + folio + "'", cn)
            leerDatos = query_folio_pedidos_cliente.ExecuteReader
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
            cn.Close()
            leerDatos.Close()

            MsgBox(ex.Message)
            Exit Sub
        End Try


        If CB_Tipo_Pago.Text = "Efectivo" Then



            'REGISTRAR LA VENTA EN EFECTIVO
            'TRAER EL PEDIDO DEL CLIENTE CON EL FOLIO
            Try

                Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + folio + "'", cn)
                leerDatos = query_folio_pedidos_cliente.ExecuteReader
                leerDatos.Read()


                Dim query_ventas As New SqlCommand("insert into Ventas values ('" + leerDatos.GetValue(0).ToString + "')", cn)
                leerDatos.Close()
                query_ventas.ExecuteNonQuery()
                MsgBox("add datos efectivo")
                articulos.Rows.Clear()
                limpiartext()
                BTN_Registrar_Venta.Enabled = False
            Catch ex As Exception
                leerDatos.Close()
                MsgBox(ex.Message)
            Finally
                cn.Close()


            End Try





        ElseIf CB_Tipo_Pago.Text = "Credito" Then
            'REGISTRAR LA VENTA A CREDITO

            Try
                Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + folio + "'", cn)
                leerDatos = query_folio_pedidos_cliente.ExecuteReader

                leerDatos.Read()

                Dim query_ventas As New SqlCommand("insert into Cuentas_Por_Cobrar values ('" + leerDatos.GetValue(0).ToString + "','" + SumArticulos() + "','A')", cn)
                leerDatos.Close()
                query_ventas.ExecuteNonQuery()
                MsgBox("add datos CREDITO")
                articulos.Rows.Clear()
                BTN_Registrar_Venta.Enabled = False
                limpiartext()
            Catch ex As Exception
                leerDatos.Close()
                MsgBox(ex.Message)
            Finally
                cn.Close()

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

        BTN_Registrar_Venta.Enabled = False
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

        Dim leerDatos As SqlDataReader
        Try
            cn.Open()
            Dim query_Clientes As New SqlCommand("select * from Cliente", cn)
            leerDatos = query_Clientes.ExecuteReader
            While leerDatos.Read

                arr_IDcliente.Add(leerDatos.GetValue(0))
                CB_Cliente.Items.Add(leerDatos.GetValue(2))

            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            leerDatos.Close()
        End Try

        'MOSTRAR ARTICULOS EN CB_ARTICULOS
        'LIMPIAR ARR ARR_ARTICULOS
        arr_nombre_articulo.Clear()

        Try
            cn.Open()
            Dim query_Articulos As New SqlCommand("select * from Nombre_Articulos", cn)
            leerDatos = query_Articulos.ExecuteReader
            While leerDatos.Read

                arr_nombre_articulo.Add(leerDatos.GetValue(0))
                CB_Articulo.Items.Add(leerDatos.GetValue(1))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            leerDatos.Close()
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

            'HABILITAR BTN REGISTRAR VENTA
            BTN_Registrar_Venta.Enabled = True

            'BORRAR DATOS DE TEXTBOX Y CB
            CB_Articulo.Text = ""
            TXT_Cantidad.Text = ""
            TXT_Precio.Text = ""
        End If
    End Sub

    Private Sub BTN_Add_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Add_Cliente.Click
        VentaNewCliente.Show()

    End Sub

    Private Sub CB_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Cliente.SelectedIndexChanged

    End Sub
End Class