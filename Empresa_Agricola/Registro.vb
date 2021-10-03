Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Registro
    Dim cn As New SqlConnection

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_newpass.TextChanged

    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'oculto codigo de privilegio
        LBL_Codigo.Visible = False
        TXT_Codigo.Visible = False
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




        If CB_Puesto.Text = "gerente" Then
            If TXT_Codigo.Text = "" Then
                MsgBox("Falta su codigo", vbOKOnly + vbExclamation, "Error de usuario")
                TXT_Codigo.Focus()
                cn.Close()
                Exit Sub
            End If

            'VERIFICAR QUE EL CODIGO SEA CORRECTO
            'CONSULTA PARA TRAER CODIGOS
            Dim BuscarCodigo As Boolean = False

            Try
                Dim queryCodigoPrivilegio As New SqlCommand("select * from Privilegio", cn)
                queryCodigoPrivilegio.ExecuteNonQuery()


                Dim leerDatos As SqlDataReader = queryCodigoPrivilegio.ExecuteReader
                While leerDatos.Read
                    'VERIFICAR QUE CODIGO SEA CORRECTO
                    If TXT_Codigo.Text = leerDatos.GetValue(1) Then
                        'MsgBox("nombre de usuario ya existe", vbOKOnly + vbExclamation, "Error en BD")
                        BuscarCodigo = True
                    End If

                End While
                leerDatos.Close()
                If Not BuscarCodigo Then
                    MsgBox("Codigo incorrecto", vbOKOnly + vbExclamation, "Error de usuario")
                    TXT_Codigo.Focus()
                    cn.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


        Try
            'insercion a tabla Usuario
            Dim adaptador As New SqlCommand("insert into Usuario values ('" + txt_nombreCom.Text + "','" + txt_usuario.Text + "' ,'" + txt_pass.Text + "' ,'" + CB_Puesto.Text + "')", cn)

            'ejecutar consulta
            adaptador.ExecuteNonQuery()

            MsgBox(CB_Puesto.Text + " registrado con exito", vbOKOnly + vbInformation, "Registro")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'finalizar conexion
            cn.Close()

            Login.txt_user.Text = txt_usuario.Text
            Login.txt_password.Text = txt_pass.Text

            Login.Show()
            Me.Close()


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
        ElseIf CB_Puesto.Text = "" Then
            MsgBox("Falta puesto de trabajo", vbOKOnly + vbExclamation, "Error de usuario")
            CB_Puesto.Focus()
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

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub Registro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()


    End Sub

    Private Sub CB_Puesto_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Puesto.SelectedValueChanged
        If CB_Puesto.Text = "gerente" Then
            LBL_Codigo.Visible = True
            TXT_Codigo.Visible = True
        Else
            LBL_Codigo.Visible = False
            TXT_Codigo.Visible = False
            TXT_Codigo.Text = ""
        End If
    End Sub
End Class