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



    Public Function Reporte_Venta(query_tabla As String)
        'CREANDO PDF Y ASIGNANDOLE NOMBRE
        Dim pdfwriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("demo.pdf", FileMode.Create))

        'FUNETE DE LETRA
        Dim Fon8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim FonB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
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
        col = New PdfPCell(New Phrase("12345678", Fon8))
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
        col = New PdfPCell(New Phrase("FECHA", FonB10))
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
        col = New PdfPCell(New Phrase("23/07/2012", Fon8))
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
        col = New PdfPCell(New Phrase("f0001-00004", Fon8))
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
            col.BackgroundColor = BaseColor.BLUE
            col.BorderColor = BaseColor.BLUE
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
                col = New PdfPCell(New Phrase(tbl.Rows(i)(j), Fon8))
                col.HorizontalAlignment = Element.ALIGN_CENTER
                col.Border = 6
                col.Border += 8

                col.BackgroundColor = BaseColor.CYAN

                col.Padding = 2.0F

                table.AddCell(col)
            Next
        Next

        pdfDoc.Add(table)

        'CIERRO LA ESCRITURA EN PDF
        pdfDoc.Close()

        'LO ABRO EN NAVEGADOR
        Shell("cmd.exe /k" + "start demo.pdf && exit", vbHide)
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

End Module
