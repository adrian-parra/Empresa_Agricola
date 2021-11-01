Imports System.Data.SqlClient
Module M_Venta
    Public arr_IDcliente As New ArrayList
    Public arr_Pediso_Articulos As New ArrayList


    Public Function TraerNombreCliente(id As String)
        Dim nombreCliente As String

        Try
            cn.Open()
            Dim queryCliente As New SqlCommand("select Nombre from Cliente where ID_Cliente = '" + id + "'", cn)
            Dim leerdata As SqlDataReader = queryCliente.ExecuteReader

            leerdata.Read()
            nombreCliente = leerdata.GetValue(0)

            cn.Close()
        Catch ex As Exception
            CreateAlert(ex.Message, "", "error", "small", False, 3)
            cn.Close()
        End Try


        Return nombreCliente
    End Function
End Module
