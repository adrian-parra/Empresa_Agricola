Imports System.Data.SqlClient
Public Class Mantenimiento
    Private Sub Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Aceptar.Click
        Dim ID_Vehiculo As String
        Dim ID_Mantenimiento As String
        Dim leerDatos As SqlDataReader
        'Obtener el ID del vehiculo utilizando la matricula del mismo
        Try
            cn.Open()
            Dim queryObtenerIDVehiculo As New SqlCommand("select ID_Vehiculo from Vehiculos where Matricula =" + "'" + TXT_Matricula.Text + "'", cn)
            leerDatos = queryObtenerIDVehiculo.ExecuteReader
            While leerDatos.Read
                ID_Vehiculo = leerDatos.GetValue(0)
            End While
            leerDatos.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If CB_Operacion.Text = "Ingresar" Then
            'Ingresa al sistema de mantenimiento el ID del vehiculo, y el ID del empleado que lo llevo a mantenimiento
            Try
                cn.Open()
                Dim queryIngresarVehiculo As New SqlCommand("insert into Mantenimiento values (" + ID_Vehiculo + "," + TXT_Empleado.Text + ",GETDATE(),GETDATE(),'notext')", cn)
                queryIngresarVehiculo.ExecuteNonQuery()
                Dim queryObtenerMantenimiento As New SqlCommand("select max(ID_Mantenimiento) from Mantenimiento")
                leerDatos = queryObtenerMantenimiento.ExecuteReader
                While leerDatos.Read
                    ID_Mantenimiento = leerDatos.GetValue(0)
                End While
                Dim queryActualizarEstatusEstacionamiento As New SqlCommand("update Estacionamiento set Estatus = 'M' where ID_Vehiculo = '" + ID_Vehiculo + "'", cn)
                queryActualizarEstatusEstacionamiento.ExecuteNonQuery()
                MsgBox("Se ingresaron los datos")
                cn.Close()
            Catch ex As Exception
                cn.Close()
                leerDatos.Close()
                MsgBox(ex.Message)
            End Try
        ElseIf CB_Operacion.Text = "Consultar" Then
            'Muestra la informacion del vehiculo utilizando la ID del mismo
            Try
                cn.Open()
                Dim queryObtenerDatosVehiculo As New SqlCommand("select * from Vehiculos where ID_Vehiculo = '" + ID_Vehiculo + "'", cn)
                leerDatos = queryObtenerDatosVehiculo.ExecuteReader
                arr_nombre_articulo.Clear()
                While leerDatos.Read
                    'Se guardan en el array los datos del vehiculo
                    arr_nombre_articulo.Add(leerDatos.GetValue(1))
                    arr_nombre_articulo.Add(leerDatos.GetValue(2))
                    arr_nombre_articulo.Add(leerDatos.GetValue(3))
                    arr_nombre_articulo.Add(leerDatos.GetValue(4))
                End While
                leerDatos.Close()
                'Se muestran los datos del vehiculo
                MsgBox("Matricula: " + arr_nombre_articulo(0) + "   Marca: " + arr_nombre_articulo(1) + "   Modelo: " + arr_nombre_articulo(2) + "   Color: " + arr_nombre_articulo(3))
                cn.Close()
            Catch ex As Exception
                cn.Close()
                leerDatos.Close()
                MsgBox(ex.Message)
            End Try
        ElseIf CB_Operacion.Text = "Actualizar" Then
            Try
                cn.Open()
                'Actualizar fecha de salida y problema al mantenimiento
                Dim queryActualizarDatos As New SqlCommand("update Mantenimiento set Fecha_Salida = GETDATE(), Problema = '" + TXT_Problema.Text + "' where ID_Mantenimiento = '" + ID_Mantenimiento + "'", cn)
                queryActualizarDatos.ExecuteNonQuery()
                Dim queryActualizarEstatusEstacionamiento As New SqlCommand("update Estacionamiento set Estatus = 'E' where ID_Vehiculo = '" + ID_Vehiculo + "'", cn)
                queryActualizarEstatusEstacionamiento.ExecuteNonQuery()
                MsgBox("Datos Actualizados")
                cn.Close()
            Catch ex As Exception
                cn.Close()
                leerDatos.Close()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class