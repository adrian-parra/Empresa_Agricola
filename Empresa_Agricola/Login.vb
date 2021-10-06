Imports System.Data.SqlClient
Public Class Login
    Dim cn As New SqlConnection
    Private Sub link_registrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_registrar.LinkClicked
        Me.Hide()

        'INICIAR FORM PRINCIPAL
        Registro.Show()


    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        cn.ConnectionString = conexion
        'Verificar text box 
        If txt_user.Text = "" Then
            MsgBox("Ingrese nombre de usuario", vbOKOnly + vbExclamation, "Error de usuario")
            txt_user.Focus()
        ElseIf txt_password.Text = "" Then
            MsgBox("Ingrese contraseña", vbOKOnly + vbExclamation, "Error de usuario")
            txt_password.Focus()
        Else
            'buscar usaurio en la bd

            'consulta
            Dim queryBuscarUser As New SqlCommand("select NombreUsuario,Password ,Puesto from Usuario", cn)
            Try
                'inicio conexion
                cn.Open()
                'ejecuto consulta
                queryBuscarUser.ExecuteNonQuery()
                'leo los datos obtenidos de la consulta
                Dim leerDatos As SqlDataReader = queryBuscarUser.ExecuteReader
                While leerDatos.Read
                    'BUSCAR USUARIO EN LO DATOS
                    If txt_user.Text = leerDatos.GetValue(0) And txt_password.Text = leerDatos.GetValue(1) Then

                        Privilegios.Privilegio = leerDatos.GetValue(2)
                        Subsistema.Show()

                        cn.Close()

                        Exit Sub
                    End If

                End While
                leerDatos.Close()
                'imprimir que no existe el usuario
                MsgBox("usuario no encontrado verifique")
                cn.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
