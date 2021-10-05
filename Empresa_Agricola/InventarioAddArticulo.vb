Imports System.Data.SqlClient
Public Class InventarioAddArticulo
    Private Sub InventarioAddArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion

        cn.Open()
        Dim queryBuscarTipoArt As New SqlCommand("select * from Tipo_Articulo", cn)


        Dim leerDatos As SqlDataReader = queryBuscarTipoArt.ExecuteReader
        While leerDatos.Read

            arr_tipo_articulo.Add(leerDatos.GetValue(0))
            CB_Tipo_Articulo.Items.Add(leerDatos.GetValue(1))

        End While
        leerDatos.Close()
        cn.Close()
    End Sub

    Private Sub InventarioAddArticulo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Inventario.Show()

    End Sub

    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        cn.Open()

        Dim idtipo_articulo As String = arr_tipo_articulo(CB_Tipo_Articulo.SelectedIndex)

        Try


            Dim queryInsertarProducto As New SqlCommand("insert into Nombre_Articulos values('" + TXT_Nombre_Articulo.Text + "' ,'" + idtipo_articulo + "')", cn)
            queryInsertarProducto.ExecuteNonQuery()

            MsgBox("add")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try


    End Sub
End Class