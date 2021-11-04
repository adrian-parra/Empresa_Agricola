Imports System.Data.SqlClient
Public Class ProduccionEmpaque
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Accion.SelectedIndexChanged

    End Sub

    Private Sub ProduccionEmpaque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion
        Dim leerDatos As SqlDataReader
        arr_tipo_articulo.Clear()
        arr_nombre_sucursal.Clear()
        arr_nombre_articulo.Clear()
        Try
            cn.Open()
            Dim queryBuscarNombresProducto As New SqlCommand("select * from Nombres_Producto", cn)
            leerDatos = queryBuscarNombresProducto.ExecuteReader
            While leerDatos.Read
                CB_Nombre.Items.Add(leerDatos.GetValue(1))
                arr_nombre_articulo.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            Dim queryBuscarCalidades As New SqlCommand("select * from Calidades_Producto", cn)
            leerDatos = queryBuscarCalidades.ExecuteReader
            While leerDatos.Read
                CB_Calidad.Items.Add(leerDatos.GetValue(1))
                arr_tipo_articulo.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            Dim queryBuscarNombreSucursal As New SqlCommand("select * from Empaque", cn)
            leerDatos = queryBuscarNombreSucursal.ExecuteReader
            While leerDatos.Read
                CB_Empaque.Items.Add(leerDatos.GetValue(4))
                arr_nombre_sucursal.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            leerDatos.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Disminuir
        'Aumentar
        'Agregar
        Dim Cantidad As Integer
        Dim idArticulo As String
        Dim leerDatos As SqlDataReader
        Cantidad = 0
        Try
            cn.Open()
            If CB_Accion.Text = "Aumentar" Then
                Dim queryObtenerCantidad As New SqlCommand("select * from Inventario_Empaque where ID_Nombre_Producto = " + arr_nombre_articulo(CB_Nombre.SelectedIndex).ToString + " AND ID_Calidad = " + arr_tipo_articulo(CB_Calidad.SelectedIndex).ToString + "AND ID_Empaque = " + arr_nombre_sucursal(CB_Empaque.SelectedIndex).ToString, cn)
                leerDatos = queryObtenerCantidad.ExecuteReader
                While leerDatos.Read
                    idArticulo = leerDatos.GetValue(0)
                    Cantidad = leerDatos.GetValue(1)
                End While
                leerDatos.Close()
                Dim resul As Integer = Cantidad + CInt(TXT_Cantidad.Text)
                Dim queryUpdateDatosInventario As New SqlCommand("update Inventario_Empaque set Cantidad_producto = " + resul.ToString + " where ID_Articulo = " + idArticulo, cn)
                queryUpdateDatosInventario.ExecuteNonQuery()
                leerDatos.Close()
            ElseIf CB_Accion.Text = "Disminuir" Then
                Dim queryObtenerCantidad As New SqlCommand("select * from Inventario_Empaque where ID_Nombre_Producto = " + arr_nombre_articulo(CB_Nombre.SelectedIndex).ToString + " AND ID_Calidad = " + arr_tipo_articulo(CB_Calidad.SelectedIndex).ToString + "AND ID_Empaque = " + arr_nombre_sucursal(CB_Empaque.SelectedIndex).ToString, cn)
                leerDatos = queryObtenerCantidad.ExecuteReader
                While leerDatos.Read
                    idArticulo = leerDatos.GetValue(0)
                    Cantidad = leerDatos.GetValue(1)
                End While
                leerDatos.Close()
                If Cantidad < CInt(TXT_Cantidad.Text) Then
                    Dim resul As Integer = Cantidad - CInt(TXT_Cantidad.Text)
                    Dim queryUpdateDatosInventario As New SqlCommand("update Inventario_Empaque set Cantidad_producto = " + resul.ToString + " where ID_Articulo = " + idArticulo, cn)
                    queryUpdateDatosInventario.ExecuteNonQuery()
                    leerDatos.Close()
                End If
            ElseIf CB_Accion.Text = "Agregar" Then
                Dim queryAgregarAInventario As New SqlCommand("insert into Inventario_Empaque values(" + arr_nombre_articulo(CB_Nombre.SelectedIndex).ToString + "," + arr_tipo_articulo(CB_Calidad.SelectedIndex).ToString + "," + arr_nombre_sucursal(CB_Empaque.SelectedIndex).ToString + "," + TXT_Cantidad.Text + ")", cn)
                queryAgregarAInventario.ExecuteNonQuery()
            End If
            cn.Close()
            MsgBox("Datos Actualizados")
        Catch ex As Exception
            MsgBox(ex.Message)
            leerDatos.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim leerDatos As SqlDataReader
        Try
            cn.Open()
            Dim queryAgregarNuevoProducto As New SqlCommand("insert into Nombres_Producto values('" + TXT_NuevoProducto.Text + "')", cn)
            queryAgregarNuevoProducto.ExecuteNonQuery()
            Dim queryObtenerIdNuevoProducto As New SqlCommand("select Max(ID_Nombre_Producto) from Nombres_Producto", cn)
            leerDatos = queryObtenerIdNuevoProducto.ExecuteReader
            While leerDatos.Read
                arr_nombre_articulo.Add(leerDatos.GetValue(0))
            End While
            CB_Nombre.Items.Add(TXT_NuevoProducto.Text)
            TXT_NuevoProducto.Clear()
            MsgBox("Datos Actualizados")
            leerDatos.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            leerDatos.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim leerDatos As SqlDataReader
        Try
            cn.Open()
            Dim queryAgregarNuevoProducto As New SqlCommand("insert into Calidades_Producto values('" + TXT_NuevoProducto.Text + "')", cn)
            queryAgregarNuevoProducto.ExecuteNonQuery()
            Dim queryObtenerIdNuevoProducto As New SqlCommand("select Max(ID_calidad) from Calidades_Producto", cn)
            leerDatos = queryObtenerIdNuevoProducto.ExecuteReader
            While leerDatos.Read
                arr_tipo_articulo.Add(leerDatos.GetValue(0))
            End While
            CB_Calidad.Items.Add(TXT_NuevoProducto.Text)
            TXT_NuevoProducto.Clear()
            MsgBox("Datos Actualizados")
            leerDatos.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            leerDatos.Close()
            cn.Close()
        End Try
    End Sub
End Class