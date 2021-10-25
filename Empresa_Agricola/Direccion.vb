Imports System.Data.SqlClient
Public Class Direccion
    Private Sub Direccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PROPIEDADES DE CONEXION
        cn.ConnectionString = conexion

        Try
            'CONEXION A BD ABIERTA
            cn.Open()

            'consulta sql estados
            Dim query_estados As New SqlCommand("select * from estados", cn)

            Dim leerDatos As SqlDataReader = query_estados.ExecuteReader

            While leerDatos.Read
                M_Direccion.idestados.Add(leerDatos.GetValue(0))
                CB_Estados.Items.Add(leerDatos.GetValue(2))
            End While

            'CERRAR CONEXION A BD
            cn.Close()
            leerDatos.Close()


            CB_Estados.SelectedItem = "Sinaloa"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'proceso asincrona
    Sub Registrar()
        If M_Direccion.TipoDireccion = "cliente" Then
            VentaNewCliente.RegistrarCliente()
        End If
    End Sub

    Private Sub BTN_Registrar_Direccion_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Direccion.Click
        If TXT_Num_Exterior.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")
        ElseIf TXT_Colonia.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        ElseIf TXT_Codigo_Postal.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        ElseIf TXT_Calle.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        ElseIf CB_Ciudad.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        ElseIf CB_Municipios.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        ElseIf CB_Estados.Text = "" Then
            MsgBox("todos lo campos de texto son requeridos")

        Else
            'CAMPOS VALIDADOS

            'OBTENER ID DE ESTADO,MUNICIPIO Y LOCALIDAD
            Dim idest As String = idestados(CB_Estados.SelectedIndex)
            Dim idmun As String = idmunicipios(CB_Municipios.SelectedIndex)
            Dim idloc As String = idlocalidades(CB_Ciudad.SelectedIndex)


            'INSERTAR REGISTRO EN TABLA DIRECCIONES


            Try
                'ABRIR CONEXION BD
                cn.Open()

                'CONSULTA INSERT
                Dim query_insert_direcccion As New SqlCommand("insert into Direcciones values ('" + TXT_Num_Exterior.Text + "', '" + TXT_Calle.Text + "','" + TXT_Colonia.Text + "','" + idloc + "','" + idmun + "','" + idest + "','" + TXT_Codigo_Postal.Text + "','" + M_Direccion.TipoDireccion + "')", cn)

                'EJECUTAR CONSULTA
                query_insert_direcccion.ExecuteNonQuery()

                'OBTENER ID DE REGISTRO
                Dim query_id_direccion As New SqlCommand("select Max(ID_direccion) from Direcciones", cn)
                Dim leerdatos As SqlDataReader = query_id_direccion.ExecuteReader

                leerdatos.Read()

                M_Direccion.IDdireccion = leerdatos.GetValue(0)

                MsgBox("Direccion registrada")

                'BLOQUEAR BTN DIRECCION
                'VentaNewCliente.BTN_Agregar_Direccion.Enabled = False

                'CERRAR CONEXION BD
                cn.Close()
                leerdatos.Close()

                'ejecutar proceso asyncrono
                Registrar()

                'CERRAR LA VENTANA
                Me.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub CB_Estados_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Estados.SelectedValueChanged
        'limpiar combo box
        CB_Municipios.Items.Clear()
        CB_Municipios.Text = ""

        'obtener id de estado
        Dim idesta As String = idestados(CB_Estados.SelectedIndex)

        'abrir conexion bd
        cn.Open()

        'consulta
        Dim query_municipio As New SqlCommand("select * from Municipios where estado_id = '" + idesta + "'", cn)

        Dim leerdatos As SqlDataReader = query_municipio.ExecuteReader

        While leerdatos.Read
            idmunicipios.Add(leerdatos.GetValue(0))
            CB_Municipios.Items.Add(leerdatos.GetValue(3))
        End While

        leerdatos.Close()
        cn.Close()

    End Sub

    Private Sub CB_Municipios_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Municipios.SelectedValueChanged
        'LIMPIAR CB LOCALIDADES
        CB_Ciudad.Items.Clear()
        CB_Ciudad.Text = ""

        'OBTENER IDMUNICIPIO
        Dim idmun As String = idmunicipios(CB_Municipios.SelectedIndex)

        'ABRIR CONEXION SQL 
        cn.Open()

        'CONSULTA
        Dim query_localidades As New SqlCommand("select * from localidades where municipio_id = '" + idmun + "'", cn)

        Dim leerdatos As SqlDataReader = query_localidades.ExecuteReader

        While leerdatos.Read
            idlocalidades.Add(leerdatos.GetValue(0))
            CB_Ciudad.Items.Add(leerdatos.GetValue(3))

        End While

        cn.Close()
        leerdatos.Close()

    End Sub
End Class