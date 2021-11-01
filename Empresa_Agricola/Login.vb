Imports System.Data.SqlClient
Public Class Login
    Dim cn As New SqlConnection
    Private Sub link_registrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_registrar.LinkClicked
        Me.Hide()

        'INICIAR FORM PRINCIPAL
        Registro.Show()


    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click



        'Verificar text box 
        If txt_user.Text = "" Then
            M_Alert.CreateAlert("Ingrese nombre de usuario", "", "error", "tiny", False, 3)


        ElseIf txt_password.Text = "" Then
            M_Alert.CreateAlert("Ingrese contraseña", "", "error", "tiny", False, 3)

        Else
            'buscar usaurio en la bd
            cn.ConnectionString = conexion
            'consulta
            Dim queryBuscarUser As New SqlCommand("select * from Usuario", cn)
            Try
                'inicio conexion
                cn.Open()
                'ejecuto consulta
                queryBuscarUser.ExecuteNonQuery()
                'leo los datos obtenidos de la consulta
                Dim leerDatos As SqlDataReader = queryBuscarUser.ExecuteReader
                While leerDatos.Read
                    'BUSCAR USUARIO EN LO DATOS
                    If txt_user.Text = leerDatos.GetValue(1) And txt_password.Text = leerDatos.GetValue(2) Then

                        Privilegios.Privilegio = leerDatos.GetValue(3)
                        Privilegios.Nombre = leerDatos.GetValue(0)
                        Privilegios.usuario = leerDatos.GetValue(1)


                        M_Alert.CreateAlert("Inicio de sesion completo", "", "succes", "tiny", True, 2)

                        Subsistema.Show()

                        cn.Close()

                        Exit Sub
                    End If

                End While
                leerDatos.Close()
                'imprimir que no existe el usuario

                M_Alert.CreateAlert("usuario no encontrado verifique", "", "error", "tiny", False, 3)


                cn.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = FormBorderStyle.None
        'Me.ForeColor = Color.DeepSkyBlue
        'Me.Cursor = Cursors.IBeam
        'Me.Left = 0



        ' - Me.ClientSize.Width

        Me.Top = 0
        'Me.Width = 1280

        'Me.Height = 720

        Me.ShowIcon = False








        'Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        'MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())

        'Dim F As New Venta
        'F.StartPosition = FormStartPosition.CenterScreen
        'F.Size = New System.Drawing.Size(CInt(pantalla.Bounds.Width.ToString()), CInt(pantalla.Bounds.Height.ToString()))
        'F.ShowDialog(Me)

















    End Sub
End Class
