Imports System.Data.SqlClient
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Module M_Generar_Pdf
    'COLUMNA VACIA
    Private CVacio As PdfPCell = New PdfPCell(New Phrase(""))
    Private table As PdfPTable
    Private col As PdfPCell
    Private widths As Single()
    Private pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)



    Public Function Reporte_Venta(query_tabla As String, folio As String, fecha As String, total As String, cliente As String, MetodoPago As String)
        'CREANDO PDF Y ASIGNANDOLE NOMBRE
        Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Documento.pdf", FileMode.Create))

        'FUNETE DE LETRA
        Dim Fon8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim FonB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK))
        Dim FonB10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))


        CVacio.Border = 0 'SIN BORDES

        'ABRIR PDF PARA ESCRIBIRLE
        pdfDoc.Open()

        'CREO TABLA CON 4 CUATRO COLUMNAS
        table = New PdfPTable(4)


        'EStableSCO EL ANCHO EN 95%
        table.WidthPercentage = 95

        'EStablaSCO ANCHO DE COLUMNAS
        widths = New Single() {3.0F, 7.0F, 1.0F, 3.0F} '4.0f,7.0f,1.0f,3.0f

        table.SetWidths(widths)

        '--------PINTAR ENCABESADO EN PDF------------

        'AGREGAR IMAGEN DE LOGO EN PRIMERA COLUMNA
        Dim imagenURL As String = Environment.CurrentDirectory + "/img-pdf.png"
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        'ESCALA DE LA IMAGEN
        imagenBMP.ScaleToFit(100.0F, 130.0F)
        imagenBMP.SpacingBefore = 20.0F
        imagenBMP.SpacingAfter = 10.0F
        'POSICION EN EL PDF (PRIMERA COLUMNA)
        imagenBMP.SetAbsolutePosition(40, 730)

        'AGREGO LA IMAGEN AL PDF
        pdfDoc.Add(imagenBMP)

        'AGREGO LA COLUMNA VACIA POR AQUI ESTA LA IMG DE LOGO
        table.AddCell(CVacio)

        'PROPIEDADES DE LA COLUMNA 2
        'NOMBRE DE LA EMPRESA E INFORMACION DE LA MISMA
        col = New PdfPCell(New Phrase("NOMBRE DE LA EMPRESA EMISORA", FonB10))
        col.Border = 0 'SIN BORDES

        'LA AGREGO A  LA table LA COLUMNA 2
        table.AddCell(col)

        'AGREGO COLUMNA 3 VACIA PARA QUE ALLA ESPACIO
        table.AddCell(CVacio)

        'PRPIEDADES DE COLUMA 4 FOLIO
        col = New PdfPCell(New Phrase("FOLIO", FonB10))
        col.HorizontalAlignment = Element.ALIGN_CENTER 'ALIGN CENTER
        col.Border = 1
        col.Border += 4
        col.Border += 8

        'AGREGO COLUMNA 4 A PDF
        table.AddCell(col)

        'COLUMNA 1 VACIA 
        table.AddCell(CVacio)

        'COLUMNA 2
        col = New PdfPCell(New Phrase("av material xxx industrial", Fon8))
        col.Border = 0
        table.AddCell(col)

        'COLUMNA 3 VACIA 
        table.AddCell(CVacio)

        'COLUMNA 4
        col = New PdfPCell(New Phrase(folio, Fon8))
        col.HorizontalAlignment = Element.ALIGN_CENTER
        col.Border = 4
        col.Border += 8

        table.AddCell(col)

        'COLUMNA 1 VACIA
        table.AddCell(CVacio)
        'COLUMNA 2
        col = New PdfPCell(New Phrase("lima -lima -lima", Fon8))
        col.Border = 0
        table.AddCell(col)
        'COLUMAN 3
        table.AddCell(CVacio)

        'COLUMNA 4
        col = New PdfPCell(New Phrase("FECHA / HORA", FonB10))
        col.HorizontalAlignment = Element.ALIGN_CENTER
        col.Border = 4
        col.Border += 8
        table.AddCell(col)

        'COLUMNA 1
        table.AddCell(CVacio)
        'COLUMNA 2
        col = New PdfPCell(New Phrase("66823234232", Fon8))
        col.Border = 0
        table.AddCell(col)
        'COLUMNA 3
        table.AddCell(CVacio)

        'COLUMNA 4
        col = New PdfPCell(New Phrase(fecha, Fon8))
        col.HorizontalAlignment = Element.ALIGN_CENTER
        col.Border = 4
        col.Border += 8
        table.AddCell(col)
        'COLUMNA 1
        table.AddCell(CVacio)
        'COLUMAN 2
        col = New PdfPCell(New Phrase("www.xxxxxxxx.com.pe", Fon8))
        col.Border = 0
        table.AddCell(col)
        'COLUMNA 3
        table.AddCell(CVacio)
        'COLUMNA 4
        col = New PdfPCell(New Phrase("", Fon8))
        col.HorizontalAlignment = Element.ALIGN_CENTER
        col.Border = 6
        col.Border += 8

        table.AddCell(col)

        'PINTA LA table EN PDF
        pdfDoc.Add(table)

        'SPACIO ENTRE ELEMENTOS
        Spacing()

        'TABLA DE LA BD ARTICULOS
        'TRAER DATOS DE BD
        Dim query_cpc As New SqlDataAdapter(query_tabla, cn)
        Dim tbl As New DataTable
        query_cpc.Fill(tbl)

        'PINTAR HEADER DE TABLA
        table = New PdfPTable(tbl.Columns.Count)
        table.WidthPercentage = 95

        'widths = New Single() {7.0F}
        'table.SetWidths(widths)

        For i = 0 To tbl.Columns.Count - 1
            col = New PdfPCell(New Phrase(tbl.Columns(i).ToString, FonB8))
            col.HorizontalAlignment = Element.ALIGN_CENTER
            ' col.BackgroundColor = BaseColor.BLUE
            'col.BorderColor = BaseColor.BLUE
            col.Padding = 5.0F

            table.AddCell(col)
        Next
        pdfDoc.Add(table)

        'Rows de bd
        table = New PdfPTable(tbl.Columns.Count)
        table.WidthPercentage = 95

        ' widths = New Single() {7.0F, 7.0F, 7.0F, 7.0F}
        'table4.SetWidths(widths)


        For i = 0 To tbl.Rows.Count - 1
            For j = 0 To tbl.Columns.Count - 1
                'CELDA 1 ID

                If j = 3 Then
                    col = New PdfPCell(New Phrase("$" + tbl.Rows(i)(j).ToString, Fon8))
                Else
                    col = New PdfPCell(New Phrase(tbl.Rows(i)(j), Fon8))
                End If

                col.HorizontalAlignment = Element.ALIGN_CENTER
                col.Border = 6
                col.Border += 8

                'col.BackgroundColor = BaseColor.CYAN

                col.Padding = 2.0F

                table.AddCell(col)
            Next
        Next

        'AGREGO LA TABLA ARTICULOS
        pdfDoc.Add(table)


        'CREAR TOTAL DE FACTURA
        table = New PdfPTable(tbl.Columns.Count)
        table.WidthPercentage = 95



        For i = 1 To tbl.Columns.Count

            If i = 1 Then
                col = New PdfPCell(New Phrase("METODO DE PAGO:", FonB8))
                col.HorizontalAlignment = Element.ALIGN_RIGHT
                col.Border = 0
                table.AddCell(col)

            ElseIf i = 2 Then
                col = New PdfPCell(New Phrase(MetodoPago, Fon8))
                col.HorizontalAlignment = Element.ALIGN_LEFT
                col.Border = 0
                table.AddCell(col)


            ElseIf i = tbl.Columns.Count - 1 Then
                col = New PdfPCell(New Phrase("TOTAL", FonB8))
                col.HorizontalAlignment = Element.ALIGN_RIGHT
                col.Border = 0

                table.AddCell(col)
            ElseIf i = tbl.Columns.Count Then
                col = New PdfPCell(New Phrase("$" + total + ".0000", FonB8))
                col.HorizontalAlignment = Element.ALIGN_CENTER

                table.AddCell(col)
            Else
                table.AddCell(CVacio)
            End If



        Next

        For i = 1 To tbl.Columns.Count
            If i = 1 Then
                col = New PdfPCell(New Phrase("CLIENTE:", FonB8))
                col.HorizontalAlignment = Element.ALIGN_RIGHT
                col.Border = 0

                table.AddCell(col)
            ElseIf i = 2 Then
                col = New PdfPCell(New Phrase(cliente, Fon8))
                col.HorizontalAlignment = Element.ALIGN_LEFT
                col.Border = 0

                table.AddCell(col)
            Else

                table.AddCell(CVacio)

            End If

        Next

        For i = 1 To tbl.Columns.Count
            If i = 1 Then
                col = New PdfPCell(New Phrase("VENDEDOR:", FonB8))
                col.HorizontalAlignment = Element.ALIGN_RIGHT
                col.Border = 0

                table.AddCell(col)
            ElseIf i = 2 Then
                col = New PdfPCell(New Phrase(Privilegios.Nombre, Fon8))
                col.HorizontalAlignment = Element.ALIGN_LEFT
                col.Border = 0

                table.AddCell(col)
            Else

                table.AddCell(CVacio)

            End If

        Next












        pdfDoc.Add(table)


        'CIERRO LA ESCRITURA EN PDF
        pdfDoc.Close()

        'LO ABRO EN NAVEGADOR
        Shell("cmd.exe /k" + "start Documento.pdf && exit", vbHide)
        Return 0
    End Function

    Private Sub Spacing()
        'pintar espacio
        table = New PdfPTable(1)
        table.WidthPercentage = 95

        widths = New Single() {7.0F}
        table.SetWidths(widths)


        col = New PdfPCell(New Phrase(" "))
        col.Border = 0


        table.AddCell(col)

        pdfDoc.Add(table)

    End Sub


    Public Sub GuardarPdfBd(folio As String, id_cliente As Integer)

        Dim pdf As String = "documento.pdf"
        ' Dim ruta As New FileStream(pdf, FileMode.Open, FileAccess.Read)
        'Dim binario(ruta.Length) As Byte
        'ruta.Read(binario, 0, ruta.Length)
        'ruta.Close()

        Try
            cn.Open()

            Dim query_guardar_pdf As New SqlCommand("sp_mant_pdf", cn)
            query_guardar_pdf.CommandType = CommandType.StoredProcedure
            query_guardar_pdf.Parameters.AddWithValue("@Factura", File.ReadAllBytes(pdf))
            query_guardar_pdf.Parameters.AddWithValue("@Folio", folio)
            query_guardar_pdf.Parameters.AddWithValue("@ID_Cliente", id_cliente)


            query_guardar_pdf.ExecuteNonQuery()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try



    End Sub

    Public Sub TraerPdfBd()
        Try
            cn.Open()
            Dim directorioarchivo As String = System.AppDomain.CurrentDomain.BaseDirectory() + "DocumentoTemp.pdf"
            Dim query_traer_pdf_bd As New SqlCommand("select * from Documentos where ID_Documento = 1", cn)
            Dim leerdato As SqlDataReader = query_traer_pdf_bd.ExecuteReader

            If leerdato.HasRows Then
                While leerdato.Read
                    If leerdato("Factura") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = leerdato("Factura")
                        BytesAArchivo(bytes, directorioarchivo)

                    End If
                End While
            End If

        Catch ex As Exception

            CreateAlert(ex.Message, "", "error", "tiny", True, 10)
            cn.Close()
        End Try
    End Sub

    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal path As String)


        File.WriteAllBytes(path, bytes)

        Exit Sub
        Dim k As Long
        If bytes Is Nothing Then Exit Sub

        Try
            k = UBound(bytes)

            Dim fs As New FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, k)
            fs.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

End Module
