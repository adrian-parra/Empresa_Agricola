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

    Private Sub BTN_Registrar_Direccion_Click(sender As Object, e As EventArgs) Handles BTN_Registrar_Direccion.Click
        If TXT_Num_Exterior.Text = "" Then

        ElseIf TXT_Colonia.Text = "" Then

        ElseIf TXT_Codigo_Postal.Text = "" Then

        ElseIf TXT_Calle.Text = "" Then

        ElseIf CB_Ciudad.Text = "" Then

        ElseIf CB_Municipios.Text = "" Then

        ElseIf CB_Estados.Text = "" Then

        Else
            'CAMPOS VALIDADOS


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
            idmunicipios.Add(leerdatos.GetValue(0))
            CB_Ciudad.Items.Add(leerdatos.GetValue(3))

        End While

        cn.Close()
        leerdatos.Close()

    End Sub
End Class