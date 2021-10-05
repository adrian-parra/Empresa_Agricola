Imports System.Data.SqlClient
Public Class Inventario
    Dim cn As New SqlConnection
    Dim arr_tipo_articulo As New ArrayList
    Dim arr_nombre_articulo As New ArrayList
    Dim arr_nombre_sucursal As New ArrayList


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'VERIFICAR PRIVILEGIOS
        If Privilegios.Privilegio = "usuario" Then
            BTN_Add_Product.Visible = False
        End If


        cn.ConnectionString = conexion
        'consulta
        Try
            'inicio conexion
            cn.Open()
            Dim queryBuscarTipoArt As New SqlCommand("select * from Tipo_Articulo", cn)


            Dim leerDatos As SqlDataReader = queryBuscarTipoArt.ExecuteReader
            While leerDatos.Read

                arr_tipo_articulo.Add(leerDatos.GetValue(0))

                CB_Tipo_Articulo.Items.Add(leerDatos.GetValue(1))

            End While
            leerDatos.Close()

            Dim queryBuscarNombre_Articulo As New SqlCommand("select * from Nombre_Articulos", cn)

            leerDatos = queryBuscarNombre_Articulo.ExecuteReader
            While leerDatos.Read

                arr_nombre_articulo.Add(leerDatos.GetValue(0))

                CB_Nombre_Articulo.Items.Add(leerDatos.GetValue(1))

            End While
            leerDatos.Close()

            Dim queryBuscarNombre_Sucursal As New SqlCommand("select * from Sucursal", cn)

            leerDatos = queryBuscarNombre_Sucursal.ExecuteReader
            While leerDatos.Read

                arr_nombre_sucursal.Add(leerDatos.GetValue(0))

                CB_Sucursal.Items.Add(leerDatos.GetValue(3))

            End While
            leerDatos.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Sub ProcesoInventario(opcion As Integer, idNombre_sucursal As String, idNombre_Articulo As String)
        Dim idArti As String
        Dim Cantidad As Integer


        Try
            Dim queryTraerIDCantidad As New SqlCommand("select Cantidad_Articulo ,ID_Articulo  from Inventario_Sucursal where ID_Sucursal = " + idNombre_sucursal + " AND ID_Nombre  = " + idNombre_Articulo + "", cn)
            queryTraerIDCantidad.ExecuteNonQuery()

            Dim leerDatos As SqlDataReader = queryTraerIDCantidad.ExecuteReader

            While leerDatos.Read



                idArti = leerDatos.GetValue(1)
                Cantidad = leerDatos.GetValue(0)


            End While
            leerDatos.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        If opcion = 1 Then
            If Cantidad > CInt(TXT_Cantidad.Text) Then

                Dim resulCant As Integer = Cantidad - CInt(TXT_Cantidad.Text)
                Try
                    Dim queryUpdateCantidad As New SqlCommand("update Inventario_Sucursal set Cantidad_Articulo = " + resulCant.ToString + " where ID_Articulo = '" + idArti + "'", cn)
                    queryUpdateCantidad.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MsgBox("restado")
                End Try

            End If
        Else
            Dim resulCant As Integer = Cantidad + CInt(TXT_Cantidad.Text)




            Try
                Dim queryUpdateCantidad As New SqlCommand("update Inventario_Sucursal set Cantidad_Articulo = " + resulCant.ToString + " where ID_Articulo = '" + idArti + "'", cn)
                queryUpdateCantidad.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("sumado")
            End Try

        End If


    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        Dim idNombre_Articulo As String = arr_nombre_articulo(CB_Nombre_Articulo.SelectedIndex)
        Dim idtipo_articulo As String = arr_tipo_articulo(CB_Tipo_Articulo.SelectedIndex)
        Dim idNombre_sucursal As String = arr_nombre_sucursal(CB_Sucursal.SelectedIndex)

        MsgBox("idtipoarticulo" + idtipo_articulo)

        If CB_Opciones.Text = "Disminuir" Then
            ProcesoInventario(1, idNombre_sucursal, idNombre_Articulo)

        ElseIf CB_Opciones.Text = "Aumentar" Then

            ProcesoInventario(2, idNombre_sucursal, idNombre_Articulo)
        Else


            Try


                Dim queryInsertarInventario As New SqlCommand("insert into Inventario_Sucursal values('" + idNombre_sucursal + "' ,'" + idNombre_Articulo + "','" + idtipo_articulo + "', " + TXT_Cantidad.Text + ")", cn)
                queryInsertarInventario.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("Datos actualizados")
            End Try



        End If

    End Sub

    Private Sub Inventario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Subsistema.Show()

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

    Private Sub CB_Tipo_Articulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Tipo_Articulo.SelectedIndexChanged

    End Sub

    Private Sub CB_Tipo_Articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Tipo_Articulo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Nombre_Articulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Nombre_Articulo.SelectedIndexChanged

    End Sub

    Private Sub CB_Nombre_Articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Nombre_Articulo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Opciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Opciones.SelectedIndexChanged

    End Sub

    Private Sub BTN_Add_Product_Click(sender As Object, e As EventArgs) Handles BTN_Add_Product.Click

    End Sub
End Class