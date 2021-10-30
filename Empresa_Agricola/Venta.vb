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
            Dim query_Pedidos_Clientes As New SqlCommand("insert into Pedidos_Clientes values('" + IDcliente + "' ,'" + CB_Tipo_Pago.Text + "','PEN','" + folio + "',getDate())", cn)
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
            Dim query_Articulos As New SqlCommand("select * from Nombre_Articulos where ID_Tipo_Articulo = 1 or ID_Tipo_Articulo = 4", cn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

        M_Generar_Pdf.Reporte_Venta("select * from Pedido_Articulo")
        Exit Sub
        Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("demo.pdf", FileMode.Create))


        Dim Fon8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim FonB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
        Dim FonB10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
        Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
        CVacio.Border = 0


        pdfDoc.Open()

        Dim table1 As PdfPTable = New PdfPTable(4)
        Dim col1 As PdfPCell
        Dim col2 As PdfPCell
        Dim col3 As PdfPCell
        Dim col4 As PdfPCell
        Dim col5 As PdfPCell
        Dim col6 As PdfPCell
        Dim ILine As Integer
        Dim IFila As Integer

        table1.WidthPercentage = 95

        Dim widths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        table1.SetWidths(widths)

        'pintar en pantalla
        Dim imagenURL As String = Environment.CurrentDirectory + "/img-pdf.png"
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        imagenBMP.ScaleToFit(100.0F, 130.0F)
        imagenBMP.SpacingBefore = 20.0F
        imagenBMP.SpacingAfter = 10.0F
        imagenBMP.SetAbsolutePosition(40, 730)
        pdfDoc.Add(imagenBMP)


        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("NOMBRE DE LA EMPRESA EMISORA", FonB10))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase("FOLIO", FonB10))
        col3.HorizontalAlignment = Element.ALIGN_CENTER
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("av material xxx industrial", Fon8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("12345678", Fon8))
        col3.HorizontalAlignment = Element.ALIGN_CENTER
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("lima -lima -lima", Fon8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(CVacio)

        col3 = New PdfPCell(New Phrase("FECHA", FonB10))
        col3.HorizontalAlignment = Element.ALIGN_CENTER
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("66823234232", Fon8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("23/07/2012", Fon8))
        col3.HorizontalAlignment = Element.ALIGN_CENTER
        col3.Border = 0
        table1.AddCell(col3)

        table1.AddCell(CVacio)
        col2 = New PdfPCell(New Phrase("www.xxxxxxxx.com.pe", Fon8))
        col2.Border = 0
        table1.AddCell(col2)
        table1.AddCell(CVacio)
        col3 = New PdfPCell(New Phrase("f0001-00004", Fon8))
        col3.HorizontalAlignment = Element.ALIGN_CENTER
        col3.Border = 0
        table1.AddCell(col3)
        pdfDoc.Add(table1)




        'pintar espacio
        Dim table2 As PdfPTable = New PdfPTable(4)
        table2.WidthPercentage = 95

        widths = New Single() {7.0F, 7.0F, 7.0F, 7.0F}
        table2.SetWidths(widths)


        col1 = New PdfPCell(New Phrase(" " + vbNewLine + " ", FonB8))
        col1.Border = 0
        'col1.BorderColorLeft = BaseColor.BLUE
        col1.BorderColor = BaseColor.BLUE

        table2.AddCell(col1)

        col2 = New PdfPCell(New Phrase("", FonB8))
        col2.Border = 0
        'col2.BorderColor = BaseColor.CYAN
        'col2.BackgroundColor = BaseColor.GREEN
        table2.AddCell(col2)

        col3 = New PdfPCell(New Phrase("", FonB8))
        col3.Border = 0
        table2.AddCell(col3)

        col4 = New PdfPCell(New Phrase("", FonB8))
        col4.Border = 0
        table2.AddCell(col4)
        pdfDoc.Add(table2)


        'PINTAR HEADER DE TABLA
        Dim table3 As PdfPTable = New PdfPTable(4)
        table3.WidthPercentage = 95

        widths = New Single() {7.0F, 7.0F, 7.0F, 7.0F}
        table3.SetWidths(widths)




        col1 = New PdfPCell(New Phrase("ID", FonB8))

        col1.HorizontalAlignment = Element.ALIGN_CENTER
        col1.BackgroundColor = BaseColor.BLUE
        col1.BorderColor = BaseColor.BLUE
        col1.Padding = 5.0F



        'col1.BorderWidth = 2.0F
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Articulo", FonB8))
        col2.BackgroundColor = BaseColor.BLUE
        col2.BorderColor = BaseColor.BLUE
        col2.Padding = 5.0F

        col2.HorizontalAlignment = Element.ALIGN_CENTER
        'col2.BorderColor = BaseColor.CYAN
        'col2.BackgroundColor = BaseColor.GREEN
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Cantidad", FonB8))
        col3.BackgroundColor = BaseColor.BLUE
        col3.BorderColor = BaseColor.BLUE
        col3.Padding = 5.0F

        col3.HorizontalAlignment = Element.ALIGN_CENTER
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Precio", FonB8))
        col4.BackgroundColor = BaseColor.BLUE
        col4.BorderColor = BaseColor.BLUE
        col4.Padding = 5.0F

        col4.HorizontalAlignment = Element.ALIGN_CENTER

        table3.AddCell(col4)



        pdfDoc.Add(table3)

        'TRAER DATOS DE BD
        Dim query_cpc As New SqlDataAdapter("select * from Pedido_articulo where ID_Articulo = 6", cn)
        Dim tbl As New DataTable
        query_cpc.Fill(tbl)



        Dim table4 As PdfPTable = New PdfPTable(4)
        table4.WidthPercentage = 95

        widths = New Single() {7.0F, 7.0F, 7.0F, 7.0F}
        table4.SetWidths(widths)

        Dim colorFondo As Integer = 0
        Dim colorFondoC As Boolean = False
        For i = 0 To tbl.Rows.Count - 1
            colorFondo = i + 1
            If (colorFondo Mod 2) > 0 Then
                colorFondoC = False
            Else
                colorFondoC = True
            End If
            'CELDA 1 ID
            col1 = New PdfPCell(New Phrase(tbl.Rows(i)(0), Fon8))
            col1.HorizontalAlignment = Element.ALIGN_CENTER
            col1.Border = 6
            col1.Border += 8
            If colorFondoC Then
                col1.BackgroundColor = BaseColor.CYAN
            End If
            col1.Padding = 2.0F

            table4.AddCell(col1)

            'CELDA 2 ARTICULO
            col2 = New PdfPCell(New Phrase(tbl.Rows(i)(1), Fon8))
            col2.HorizontalAlignment = Element.ALIGN_CENTER
            col2.Border = 6
            col2.Border += 8
            If colorFondoC Then
                col2.BackgroundColor = BaseColor.CYAN
            End If
            col2.Padding = 2.0F
            table4.AddCell(col2)

            'CELDA 3 CANTIDAD
            col3 = New PdfPCell(New Phrase(tbl.Rows(i)(2), Fon8))
            col3.HorizontalAlignment = Element.ALIGN_CENTER
            col3.Border = 6
            col3.Border += 8
            If colorFondoC Then
                col3.BackgroundColor = BaseColor.CYAN
            End If
            col3.Padding = 2.0F
            table4.AddCell(col3)

            'CELADA 4 PRECIO
            col4 = New PdfPCell(New Phrase(tbl.Rows(i)(3), Fon8))
            col4.HorizontalAlignment = Element.ALIGN_CENTER
            col4.Border = 6
            col4.Border += 8
            If colorFondoC Then
                col4.BackgroundColor = BaseColor.CYAN
            End If
            col4.Padding = 2.0F
            table4.AddCell(col4)

        Next
        pdfDoc.Add(table4)

        'Ejemplo tabla
        Dim table5 As PdfPTable = New PdfPTable(4)
        table5.WidthPercentage = 95

        widths = New Single() {7.0F, 7.0F, 7.0F, 7.0F}
        table5.SetWidths(widths)


        'CELDA 1 
        col1 = New PdfPCell(New Phrase("ejemplo", Fon8))
        col1.HorizontalAlignment = Element.ALIGN_CENTER

        col1.Padding = 2.0F

        table5.AddCell(col1)

        'CELDA 2
        col2 = New PdfPCell(New Phrase("lopez", Fon8))
        col2.HorizontalAlignment = Element.ALIGN_CENTER


        col2.Padding = 2.0F

        table5.AddCell(col2)

        'CELDA 3
        col1 = New PdfPCell(New Phrase("ejemplo", Fon8))
        col1.HorizontalAlignment = Element.ALIGN_CENTER

        col1.Padding = 2.0F

        table5.AddCell(col1)

        'CELDA 4
        col1 = New PdfPCell(New Phrase("lopez", Fon8))
        col1.HorizontalAlignment = Element.ALIGN_CENTER


        col1.Padding = 2.0F

        table5.AddCell(col1)

        pdfDoc.Add(table5)

        pdfDoc.Close()

        Shell("cmd.exe /k" + "start demo.pdf")




    End Sub
End Class