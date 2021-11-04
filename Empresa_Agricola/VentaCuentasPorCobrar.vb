Imports System.Data.SqlClient
Public Class VentaCuentasPorCobrar
    Dim IDpedido, Adeudo, IDcliente As String
    Dim folio As Boolean = False

    Sub DeudaCPC()
        Dim query_cpc As New SqlDataAdapter("select Adeudo,Estatus,Total from Cuentas_Por_Cobrar where ID_Pedido = '" + IDpedido + "'", cn)
        Dim tbl As New DataTable
        query_cpc.Fill(tbl)



        DGV_Cuentas_Por_Cobrar.DataSource = tbl


    End Sub
    Private Sub BTN_Buscar_Adeudo_Click(sender As Object, e As EventArgs) Handles BTN_Buscar_Adeudo.Click

        Try
            cn.Open()
            Dim query_buscar_folio As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "' and Tipo_Pago = 'Credito'", cn)
            Dim leerDatos As SqlDataReader = query_buscar_folio.ExecuteReader()



            'While leerDatos.Read()
            '    folio = True
            '    IDpedido = leerDatos.GetValue(0)
            '    CreateAlert("adeudu encontrado", "", "error", "tiny", False, 3)
            '    BTN_Abonar.Enabled = True


            'End While



            If leerDatos.Read() Then
                ' leerDatos.Read()
                IDcliente = leerDatos.GetValue(1)
                IDpedido = leerDatos.GetValue(0)
                CreateAlert("adeudo encontrado", "", "succes", "tiny", False, 3)
                BTN_Abonar.Enabled = True
                leerDatos.Close()

                DeudaCPC()
                TXT_Abono.Text = ""
                BTN_Factura.Enabled = True
                BTN_Reporte_Pagos.Enabled = True
                cn.Close()

                MostrarHist()


            Else
                cn.Close()
                CreateAlert("folio no encontrado", "", "error", "tiny", False, 3)
                BTN_Abonar.Enabled = False
                TXT_Abono.Text = ""
                BTN_Factura.Enabled = False
                BTN_Reporte_Pagos.Enabled = False
            End If



            'If folio Then

            '    DeudaCPC()

            '    'Dim query_pedido_articulo As New SqlDataAdapter("select Articulo,Cantidad,Precio from Pedido_Articulo where ID_Articulo = '" + IDpedido + "'", cn)
            '    'Dim tbl As New DataTable
            '    'query_pedido_articulo.Fill(tbl)

            '    'DGV_Articulos.DataSource = tbl

            '    'Dim query_pedido_cliente As New SqlDataAdapter("select Tipo_Pago,Estatus,Folio from Pedidos_Clientes where ID_Pedido = '" + IDpedido + "'", cn)
            '    'Dim tbl1 As New DataTable
            '    'query_pedido_cliente.Fill(tbl1)

            '    'DGV_Info_Venta.DataSource = tbl1



            'Else
            '    MsgBox("folio incorrecto")
            'End If



        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub VentaCuentasPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'OCULTAR BTN ABONAR HASTA ENCONTRAR FOLIO DE ADEUDO
        BTN_Abonar.Enabled = False

    End Sub

    Private Sub BTN_Abonar_Click(sender As Object, e As EventArgs) Handles BTN_Abonar.Click
        Try
            cn.Open()

            Dim query_buscar_idcuenta As New SqlCommand("select * from Cuentas_Por_Cobrar where ID_Pedido ='" + IDpedido + "'", cn)
            Dim leerDatos As SqlDataReader = query_buscar_idcuenta.ExecuteReader

            leerDatos.Read()

            Adeudo = leerDatos.GetValue(2).ToString
            leerDatos.Close()

            If CDbl(Adeudo) <= CDbl(TXT_Abono.Text) Then

                'FINALIZO EL ADEUDO
                Dim query_cuenta_pagada As New SqlCommand("update Cuentas_Por_Cobrar set Adeudo = 0 , Estatus = 'P' where ID_Pedido = '" + IDpedido + "'", cn)
                query_cuenta_pagada.ExecuteNonQuery()

                'REGISTRO LA VENTA

                Try

                    Dim query_folio_pedidos_cliente As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "'", cn)
                    leerDatos = query_folio_pedidos_cliente.ExecuteReader
                    leerDatos.Read()


                    Dim query_ventas As New SqlCommand("insert into Ventas values ('" + leerDatos.GetValue(0).ToString + "')", cn)
                    leerDatos.Close()
                    query_ventas.ExecuteNonQuery()

                    cn.Close()

                    CreateAlert("Cuenta pagada", "", "succes", "tiny", True, 3)
                    HistAbonos()
                    MostrarHist()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message)

                End Try


            Else
                'Abono
                Dim a As Double = CDbl(Adeudo) - CDbl(TXT_Abono.Text)
                Dim query_cuenta_pagada As New SqlCommand("update Cuentas_Por_Cobrar set Adeudo = '" + a.ToString + "' , Estatus = 'A' where ID_Cuenta = '" + IDpedido + "'", cn)
                query_cuenta_pagada.ExecuteNonQuery()
                cn.Close()
                CreateAlert("Abono registrado", "", "succes", "tiny", True, 3)
                'REGISTRAR HISTORIAL DE ABONOS
                HistAbonos()
                MostrarHist()

            End If

            DeudaCPC()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub BTN_Factura_Click(sender As Object, e As EventArgs) Handles BTN_Factura.Click
        TraerPdfBd(TXT_Folio.Text)
    End Sub

    Private Sub BTN_Reporte_Pagos_Click(sender As Object, e As EventArgs) Handles BTN_Reporte_Pagos.Click
        HistorialAbonosDocument("select ID,Abono,Fecha from Historial_Cuenta_Por_Cobrar where Folio = '" + TXT_Folio.Text + "'", TXT_Folio.Text, DateTime.Now.ToString("dd/MM/yyyy").ToString)
    End Sub

    Sub MostrarHist()

        Dim query_cpc As New SqlDataAdapter("select ID,Abono,Fecha from Historial_Cuenta_Por_Cobrar where Folio = '" + TXT_Folio.Text + "'", cn)
        Dim tbl As New DataTable
        query_cpc.Fill(tbl)



        DGV_Historial.DataSource = tbl
    End Sub

    Sub HistAbonos()
        Try
            cn.Open()
            Dim query_insert_hist As New SqlCommand("insert into Historial_Cuenta_Por_Cobrar values('" + IDcliente.ToString + "' ,'" + TXT_Folio.Text + "','" + TXT_Abono.Text + "',getDate())", cn)
            query_insert_hist.ExecuteNonQuery()
            ' CreateAlert("Historial de abono guardado", "", "succes", "tiny", False, 3)
            cn.Close()
        Catch ex As Exception
            cn.Close()
            CreateAlert(ex.Message, "", "error", "tiny", True, 3)
        End Try
    End Sub
End Class