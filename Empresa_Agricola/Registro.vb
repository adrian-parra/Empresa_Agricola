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
        Dim adaptador As New SqlCommand("insert into Usuario values ('" + txt_nombreCom.Text + "','" + txt_usuario.Text + "' ,'" + txt_pass.Text + "','" + txt_newpass.Text + "')", cn)

        Try
            cn.Open()
            MsgBox("Conexion exitosa")
            adaptador.ExecuteNonQuery()
            MsgBox("insert ")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()

        End Try
    End Sub


End Class