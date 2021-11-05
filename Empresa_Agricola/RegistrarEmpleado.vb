Imports System.Data.SqlClient
Public Class RegistrarEmpleado
    Dim puestos As New ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Direccion.Click
        If M_Direccion.IDdireccion <> "" Then
            CreateAlert("la direccion del cliente ya fue agregada " + vbNewLine + "registre al cliente", "", "error", "tiny", False, 3)
        Else
            M_Direccion.TipoDireccion = "empleado"
            Direccion.ShowDialog()
        End If


    End Sub



    Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = False

        cn.ConnectionString = conexion
        'MOSTRAR PUESTO
        Try
            cn.Open()
            Dim query_puesto As New SqlCommand("select * from Puestos", cn)
            Dim leerdata As SqlDataReader = query_puesto.ExecuteReader

            While leerdata.Read()

                CB_Puesto.Items.Add(leerdata.GetValue(1))
                puestos.Add(leerdata.GetValue(0))

            End While

            cn.Close()
        Catch ex As Exception
            cn.Close()
            CreateAlert(ex.Message, "", "error", "tiny", False, 3)
        End Try
    End Sub

    Private Sub RegistrarEmpleado_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Recursos_Humanos.Show()
    End Sub

    Sub limpiartxt()
        TXT_Nombre.Text = ""
        TXT_Apellido_M.Text = ""
        TXT_Apellido_P.Text = ""
        TXT_Rfc.Text = ""
        TXT_Telefono.Text = ""
        TXT_Curp.Text = ""
        TXT_Sueldo.Text = ""
    End Sub
    Private Sub BTN_Registrar_Empleado_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Empleado.Click
        If TXT_Nombre.Text = "" Then
            CreateAlert("Ingrese nombre", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Apellido_M.Text = "" Then
            CreateAlert("Ingrese apellido materno", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Apellido_P.Text = "" Then
            CreateAlert("Ingrese apellido paterno", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Rfc.Text = "" Then
            CreateAlert("Ingrese rfc", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Telefono.Text = "" Then
            CreateAlert("Ingrese telefono", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Curp.Text = "" Then
            CreateAlert("Ingrese curp", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf TXT_Sueldo.Text = "" Then
            CreateAlert("Ingrese sueldo", "Registro de empleado", "error", "tiny", False, 3)
        ElseIf CB_Puesto.Text = "" Then
            CreateAlert("SELECCIONE PUESTO", "Registro de empleado", "error", "tiny", False, 3)
        Else
            'VALIDAR DIRECCION DE CLIENTE
            If M_Direccion.IDdireccion = "" Then
                CreateAlert("Tiene que agregar la direccion del empleado", "Registro de empleado", "error", "tiny", False, 3)
            Else
                Try
                    'ABRIR CONEXION BD
                    cn.Open()

                    'CONSULTA ADD CLIENTE
                    Dim query_add_empleado As New SqlCommand("insert into Empleados values('" + puestos(CB_Puesto.SelectedIndex) + "','" + M_Direccion.IDdireccion + "','" + TXT_Telefono.Text + "','" + TXT_Sueldo.Text + "','A' ,'" + TXT_Rfc.Text + "','" + TXT_Curp.Text + "','" + TXT_Nombre.Text + "','" + TXT_Apellido_M.Text + "','" + TXT_Apellido_P.Text + "')", cn)
                    query_add_empleado.ExecuteNonQuery()


                    CreateAlert("Empleado registrado con exito", "", "succes", "small", True, 3)

                    M_Direccion.IDdireccion = ""
                    M_Direccion.TipoDireccion = ""


                    limpiartxt()
                    cn.Close()

                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message)
                End Try
            End If


        End If
    End Sub
End Class