Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Registro
    Dim cn As New SqlConnection

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_newpass.TextChanged

    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click


        cn.ConnectionString = conexionBD.conexion

        'validacion de txt
        If validarTxt() = False Then
            Exit Sub
        End If

        'Traer todos lo usuario de la bd
        Dim queryusuarios As New SqlCommand("select NombreUsuario from Usuario", cn)
        Try
            cn.Open()
            queryusuarios.ExecuteNonQuery()

            Dim leerDatos As SqlDataReader = queryusuarios.ExecuteReader
            While leerDatos.Read
                'VERIFICAR QUE USUARIO NO ESTE REGISTRADO
                If txt_usuario.Text = leerDatos.GetValue(0) Then
                    MsgBox("nombre de usuario ya existe", vbOKOnly + vbExclamation, "Error en BD")
                    txt_usuario.Focus()
                    cn.Close()
                    Exit Sub
                End If

            End While
            leerDatos.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        'insercion a tabla Usuario
        Dim adaptador As New SqlCommand("insert into Usuario values ('" + txt_nombreCom.Text + "','" + txt_usuario.Text + "' ,'" + txt_pass.Text + "')", cn)

        Try

            'ejecutar consulta
            adaptador.ExecuteNonQuery()

            MsgBox("Usuario registrado con exito", vbOKOnly + vbInformation, "Registro")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'finalizar conexion
            cn.Close()
            cn.Dispose()

            Login.txt_user.Text = txt_usuario.Text
            Login.txt_password.Text = txt_pass.Text
            Me.Hide()
            Login.Show()


        End Try
    End Sub

    'FUNCION PARA VALIDAR TXT
    Public Function validarTxt()
        If txt_nombreCom.Text = "" Then
            MsgBox("Falta su nombre completo", vbOKOnly + vbExclamation, "Error de usuario")
            txt_nombreCom.Focus()
            Return False
        ElseIf txt_usuario.Text = "" Then
            MsgBox("Falta su nombre de usuario", vbOKOnly + vbExclamation, "Error de usuario")
            txt_usuario.Focus()
            Return False
        ElseIf txt_pass.Text = "" Then
            MsgBox("Falta su contraseña", vbOKOnly + vbExclamation, "Error de usuario")
            txt_pass.Focus()
            Return False
        ElseIf txt_newpass.Text = "" Then
            MsgBox("Falta su contraseña de nuevo", vbOKOnly + vbExclamation, "Error de usuario")
            txt_newpass.Focus()
            Return False
        Else
            'Validar que las contra. sean iguales
            If txt_pass.Text = txt_newpass.Text Then
                'Validacion correcta
                Return True
            Else
                'validacion incorrecta
                MsgBox("su contraseña no coincide", vbOKOnly + vbExclamation, "Error de usuario")
                txt_pass.Focus()
                Return False
            End If
        End If
    End Function

End Class