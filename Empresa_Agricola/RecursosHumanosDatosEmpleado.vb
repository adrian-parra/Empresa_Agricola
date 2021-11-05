Imports System.Data.SqlClient
Public Class RecursosHumanosDatosEmpleado
    Private Sub RecursosHumanosDatosEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = conexion
    End Sub

    Sub DatosEmpleados(busc As String)
        Dim query As String

        If busc = "CURP" Then
            query = "select Telefono,Sueldo,Estatus,RFC,CURP,Nombre,Apellido1,Apellido2 from Empleados where CURP = '" + TXT_Buscar.Text + "'"
        Else
            query = "select Telefono,Sueldo,Estatus,RFC,CURP,Nombre,Apellido1,Apellido2 from Empleados where ID_Empleado = '" + TXT_Buscar.Text + "'"
        End If

        Dim query_buscar_empleado As New SqlDataAdapter(query, cn)







        Dim tbl As New DataTable
        query_buscar_empleado.Fill(tbl)


        DGV_Datos_Empleado.DataSource = tbl
    End Sub

    Private Sub BTN_Buscar_Empleado_Click(sender As Object, e As EventArgs) Handles BTN_Buscar_Empleado.Click
        If CB_Buscar_Por.Text = "CURP" Then

            Try
                cn.Open()
                DatosEmpleados("CURP")
                cn.Close()
            Catch ex As Exception
                cn.Close()
                CreateAlert(ex.Message, "", "error", "tiny", True, 3)
            End Try
        ElseIf CB_Buscar_Por.Text = "ID" Then
            Try
                cn.Open()
                DatosEmpleados("ID")
                cn.Close()
            Catch ex As Exception
                cn.Close()
                CreateAlert(ex.Message, "", "error", "tiny", True, 3)
            End Try
        Else
            CreateAlert("ingrese tipo de busqueda", "", "error", "tiny", False, 3)
        End If
    End Sub

    Private Sub RecursosHumanosDatosEmpleado_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Recursos_Humanos.Show()

    End Sub

    Private Sub BTN_Update_Empleado_Click(sender As Object, e As EventArgs) Handles BTN_Update_Empleado.Click
        Try
            cn.Open()

            For y = 0 To DGV_Datos_Empleado.Rows.Count - 2
                'LB_Articulos.Items.Add(tabla.Rows(y)(0))

                'MsgBox(DGV_Datos_Empleado.CurrentRow.Cells(3).Value.ToString)

                Dim query_actulisar_empleado As New SqlCommand("update Empleados set Estatus = '" + DGV_Datos_Empleado.CurrentRow.Cells(2).Value.ToString + "' where CURP = '" + TXT_Buscar.Text + "' OR ID_Empleado = '" + TXT_Buscar.Text + "'", cn)
                query_actulisar_empleado.ExecuteNonQuery()


            Next

            CreateAlert("estaus de empleado cambiado", "", "succes", "tiny", False, 3)
            cn.Close()
        Catch ex As Exception
            cn.Close()
            CreateAlert(ex.Message, "", "error", "tiny", True, 5)
        End Try
    End Sub
End Class