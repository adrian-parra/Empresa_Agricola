Imports System.Data.SqlClient
Public Class VentaCuentasPorCobrar
    Dim IDpedido, Adeudo As String

    Private Sub BTN_Buscar_Adeudo_Click(sender As Object, e As EventArgs) Handles BTN_Buscar_Adeudo.Click

        Try
            cn.Open()
            Dim query_buscar_folio As New SqlCommand("select * from Pedidos_Clientes where Folio = '" + TXT_Folio.Text + "' and Tipo_Pago = 'Credito'", cn)
            Dim leerDatos As SqlDataReader = query_buscar_folio.ExecuteReader()



            While leerDatos.Read()
                IDpedido = leerDatos.GetValue(0)
                MsgBox("folio encontrado con adeudo de " + leerDatos.GetValue(5).ToString)
                BTN_Abonar.Enabled = True
                cn.Close()
                Exit Sub
            End While

            MsgBox("folio incorrecto")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        cn.Close()
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

            Adeudo = leerDatos.GetValue(2)
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
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cn.Close()
                    MsgBox("registro de venta")
                End Try


            Else
                Dim a = CDbl(Adeudo) - CDbl(TXT_Abono.Text)
                Dim query_cuenta_pagada As New SqlCommand("update Cuentas_Por_Cobrar set Adeudo = '" + a + "' , Estatus = 'P' where ID_Cuenta = '" + IDpedido + "'", cn)
                query_cuenta_pagada.ExecuteNonQuery()
                cn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
End Class