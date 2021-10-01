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

        'insercion a tabla Usuario
        Dim adaptador As New SqlCommand("insert into Usuario values ('" + txt_nombreCom.Text + "','" + txt_usuario.Text + "' ,'" + txt_pass.Text + "','" + txt_newpass.Text + "')", cn)

        Try
            'conexion abierta
            cn.Open()
            'ejecutar consulta
            adaptador.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'finalizar conexion
            cn.Close()

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