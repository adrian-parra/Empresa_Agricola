
Imports System.Data.SqlClient
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Venta
    Dim articulos As New DataTable
    Dim row As DataRow




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
            CreateAlert("Seleccione el cliente", "", "error", "tiny", False, 3)
            Exit Sub
        ElseIf CB_Tipo_Pago.Text = "" Then
            CreateAlert("Seleccione el tipo de pago", "", "error", "tiny", False, 3)
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
            Dim query_Pedidos_Clientes As New SqlCommand("insert into Pedidos_Clientes values('" + IDcliente + "' ,'" + CB_Tipo_Pago.Text + "','PEN','" + folio + "',getDate())", cn)
            query_Pedidos_Clientes.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            Exit Sub
        End Try

        'REGISTRAR EL PEDIDO DE ARTICULOS
        Dim leerDatos As SqlDataReader
        Dim fecha, idecliente, idPedido, tipoPago As String
        Try
            'TRAER ID DE PEDIDO
            Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + folio + "'", cn)
            leerDatos = query_folio_pedidos_cliente.ExecuteReader
            leerDatos.Read()
            Dim ID_Pedido_Cliente As String = leerDatos.GetValue(0)

            'DATOS PARA PARAMETRO DE GENERAR REPORTE
            fecha = leerDatos.GetValue(5).ToString
            idPedido = leerDatos.GetValue(0).ToString
            idecliente = leerDatos.GetValue(1).ToString
            tipoPago = leerDatos.GetValue(2).ToString

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
                CreateAlert("Venta en efectivo registrada", "Informacion de ventas", "succes", "small", True, 3)



                limpiartext()
                BTN_Registrar_Venta.Enabled = False

                cn.Close()

                'CREAR FACTURA y abrir
                M_Generar_Pdf.Reporte_Venta("select * from pedido_articulo where ID_Articulo = '" + idPedido + "'", folio, fecha, SumArticulos(), TraerNombreCliente(idecliente), tipoPago)
                'GUARDAR FACTURA EN BD
                GuardarPdfBd(folio, CInt(idecliente))

                'TRAER PDF
                'TraerPdfBd()

                articulos.Rows.Clear()
            Catch ex As Exception
                cn.Close()
                leerDatos.Close()
                MsgBox(ex.Message)

            End Try





        ElseIf CB_Tipo_Pago.Text = "Credito" Then
            'REGISTRAR LA VENTA A CREDITO

            Try
                Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + folio + "'", cn)
                leerDatos = query_folio_pedidos_cliente.ExecuteReader

                leerDatos.Read()

                Dim query_ventas As New SqlCommand("insert into Cuentas_Por_Cobrar values ('" + leerDatos.GetValue(0).ToString + "','" + SumArticulos() + "','A', '" + SumArticulos() + "' )", cn)
                leerDatos.Close()
                query_ventas.ExecuteNonQuery()

                CreateAlert("VENTA a credito registrada", "", "succes", "small", True, 3)
                cn.Close()

                'CREAR FACTURA y abrir
                M_Generar_Pdf.Reporte_Venta("select * from pedido_articulo where ID_Articulo = '" + idPedido + "'", folio, fecha, SumArticulos(), TraerNombreCliente(idecliente), tipoPago)
                'GUARDAR FACTURA EN BD
                GuardarPdfBd(folio, CInt(idecliente))

                articulos.Rows.Clear()
                BTN_Registrar_Venta.Enabled = False
                limpiartext()
            Catch ex As Exception
                cn.Close()
                leerDatos.Close()
                MsgBox(ex.Message)

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
        'VERIFICAR PRIVILEGIOS
        If Privilegios.Privilegio = "Empleado_Ventas" Then
            BTN_Add_Cliente.Visible = False
        ElseIf Privilegios.Privilegio = "Ventas" Or Privilegios.Privilegio = "gerente" Then
            BTN_Add_Cliente.Visible = True
        End If











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
            Dim query_Articulos As New SqlCommand("select * from Nombre_Articulos where ID_Tipo_Articulo = 1 or ID_Tipo_Articulo = 5", cn)
            leerDatos = query_Articulos.ExecuteReader
            While leerDatos.Read

                arr_nombre_articulo.Add(leerDatos.GetValue(0))
                CB_Articulo.Items.Add(leerDatos.GetValue(1))

            End While

            CB_Articulo.SelectedIndex = 0
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
            CreateAlert("ingrese la cantidad de articulo", "", "error", "tiny", False, 3)
        ElseIf TXT_Precio.Text = "" Then
            CreateAlert("ingrese el precio de articulo", "", "error", "tiny", False, 3)

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
        Me.Hide()
    End Sub



    Private Sub CB_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Cliente.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Tipo_Pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Tipo_Pago.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Articulo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TXT_Cantidad_TextChanged(sender As Object, e As EventArgs) Handles TXT_Cantidad.TextChanged

    End Sub

    Private Sub TXT_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Cantidad.KeyPress
        If e.KeyChar = ChrW(8) Then
            Exit Sub
        End If

        Dim caracteres As String = "0123456789"
        Dim caracterCorrecto As Boolean = False
        For i = 1 To caracteres.Length
            If Mid(caracteres, i, 1) = e.KeyChar Then
                caracterCorrecto = True
            End If
        Next

        If Not caracterCorrecto Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TXT_Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Precio.KeyPress
        If e.KeyChar = ChrW(8) Then
            Exit Sub
        End If

        Dim caracteres As String = "0123456789"
        Dim caracterCorrecto As Boolean = False
        For i = 1 To caracteres.Length
            If Mid(caracteres, i, 1) = e.KeyChar Then
                caracterCorrecto = True
            End If
        Next

        If Not caracterCorrecto Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub Venta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Subsistema.Show()
    End Sub
End Class