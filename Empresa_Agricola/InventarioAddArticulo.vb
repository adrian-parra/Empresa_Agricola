Imports System.Data.SqlClient
Public Class InventarioAddArticulo
    Private Sub InventarioAddArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion

        cn.Open()
        Dim queryBuscarTipoArt As New SqlCommand("select * from Tipo_Articulo", cn)


        Dim leerDatos As SqlDataReader = queryBuscarTipoArt.ExecuteReader
        While leerDatos.Read

            ' arr_tipo_articulo.Add(leerDatos.GetValue(0))

            CB_Tipo_Articulo.Items.Add(leerDatos.GetValue(1))

        End While
        leerDatos.Close()
    End Sub
End Class