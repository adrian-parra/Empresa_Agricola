Imports System.Data.SqlClient
Public Class ProduccionCampo
    Private Sub ProduccionCampo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion
        Dim leerDatos As SqlDataReader
        Try
            cn.Open()
            'Leer desde la BD los datos del campo
            Dim queryBuscarNombresCampo As New SqlCommand("select * from Campo", cn)
            leerDatos = queryBuscarNombresCampo.ExecuteReader
            arr_tipo_articulo.Clear()
            arr_nombre_sucursal.Clear()
            arr_nombre_articulo.Clear()
            While leerDatos.Read
                CB_Campo.Items.Add(leerDatos.GetValue(3))
                arr_tipo_articulo.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            Dim queryBuscarNombresProducto As New SqlCommand("select * from Nombres_Producto", cn)
            leerDatos = queryBuscarNombresProducto.ExecuteReader
            While leerDatos.Read
                CB_Producto.Items.Add(leerDatos.GetValue(1))
                arr_nombre_articulo.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            Dim queryBuscarNombresSucursal As New SqlCommand("select * from Sucursal", cn)
            leerDatos = queryBuscarNombresSucursal.ExecuteReader
            While leerDatos.Read
                CB_Sucursal.Items.Add(leerDatos.GetValue(3))
                arr_nombre_sucursal.Add(leerDatos.GetValue(0))
            End While
            leerDatos.Close()
            cn.Close()
        Catch ex As Exception
            leerDatos.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub CB_Accion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Accion.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Sembrar
        'Registrar
        'Fertilizar
        'Regar
        Try
            cn.Open()
            If CB_Accion.Text = "Sembrar" Then
                Dim queryRegistrarSiembra As New SqlCommand("update Campo set ID_Nombre_Producto = " + arr_nombre_articulo(CB_Producto.SelectedIndex).ToString + ",Estado_Siembra = GETDATE() where ID_Campo = " + arr_tipo_articulo(CB_Campo.SelectedIndex).ToString, cn)
                queryRegistrarSiembra.ExecuteNonQuery()
            ElseIf CB_Accion.Text = "Registrar" Then
                Dim queryRegistrarCampo As New SqlCommand("insert into Campo(Nombre,ID_Sucursal,Tamaño) values('" + TXT_Nombre.Text + "'," + arr_nombre_sucursal(CB_Sucursal.SelectedIndex).ToString + "," + TXT_Tamaño.Text + ")", cn)
                queryRegistrarCampo.ExecuteNonQuery()
            ElseIf CB_Accion.Text = "Fertilizar" Then
                Dim queryResgistrarFechaFertilizado As New SqlCommand("update Campo set Estado_Fertilizante = GETDATE() where ID_Campo = " + arr_tipo_articulo(CB_Campo.SelectedIndex).ToString, cn)
                queryResgistrarFechaFertilizado.ExecuteNonQuery()
            ElseIf CB_Accion.Text = "Regar" Then
                Dim queryResgistrarFechaRegado As New SqlCommand("update Campo set Estado_Riego = GETDATE() where ID_Campo = " + arr_tipo_articulo(CB_Campo.SelectedIndex).ToString, cn)
                queryResgistrarFechaRegado.ExecuteNonQuery()
            End If
            cn.Close()
            MsgBox("Datos Actualizados")
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
End Class