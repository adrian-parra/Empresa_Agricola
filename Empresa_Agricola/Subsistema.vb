Public Class Subsistema
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OCULTAR INFO DE PERFIL
        LBL_Nombre.Visible = False
        LBL_Nombre_text.Visible = False
        LBL_Puesto.Visible = False
        LBL_Puesto_text.Visible  = False
        LBL_Usuario.Visible = False
        LBL_Usuario_text.Visible = False
        PB_Perfil.Visible = False

        'Este es el form de los subsistemas
        Login.Hide()

        'CHECAR PRIVILEGIOS
        If Privilegio = "Inventario" Or Privilegio = "Empleado_Inventario" Then
            BTN_Inventario.Enabled = True
        ElseIf Privilegio = "Compras" Or Privilegio = "Empleado_Compras" Then
            BTN_Compras.Enabled = True
        ElseIf Privilegio = "Ventas" Or Privilegio = "Empleado_Ventas" Then
            BTN_Ventas.Enabled = True
        ElseIf Privilegio = "Produccion" Or Privilegio = "Empleado_Produccion" Then
            BTN_Produccion.Enabled = True
        ElseIf Privilegio = "Distribuccion" Or Privilegio = "Empleado_Distribuccion" Then
            BTN_Distribuccion.Enabled = True
        ElseIf Privilegio = "Finanzas" Or Privilegio = "Empleado_Finanzas" Then
            BTN_Finanzas.Enabled = True
        ElseIf Privilegio = "Mantenimiento" Or Privilegio = "Empleado_Mantenimiento" Then
            BTN_Mantenimiento.Enabled = True
        ElseIf Privilegio = "Recursos_Humanos" Or Privilegio = "Empleado_Recursos_Humanos" Then
            BTN_Recursos_Humanos.Enabled = True
        ElseIf Privilegio = "gerente" Then
            BTN_Inventario.Enabled = True
            BTN_Compras.Enabled = True
            BTN_Ventas.Enabled = True
            BTN_Produccion.Enabled = True
            BTN_Distribuccion.Enabled = True
            BTN_Finanzas.Enabled = True
            BTN_Mantenimiento.Enabled = True
            BTN_Recursos_Humanos.Enabled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Inventario.Click

        Me.Hide()
        Inventario.Show()



    End Sub

    Private Sub Subsistema_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_Compras.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_Ventas.Click
        Venta.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Login.txt_user.Text = ""
        Login.txt_password.Text = ""

        Login.Show()
        Me.Close()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        BTN_Inventario.Visible = False
        BTN_Compras.Visible = False
        BTN_Ventas.Visible = False
        BTN_Produccion.Visible = False
        BTN_Distribuccion.Visible = False
        BTN_Finanzas.Visible = False
        BTN_Mantenimiento.Visible = False
        BTN_Recursos_Humanos.Visible = False

        LBL_Nombre.Visible = True
        LBL_Nombre_text.Visible = True

        LBL_Nombre_text.Text = Privilegios.Nombre
        LBL_Puesto.Visible = True
        LBL_Puesto_text.Visible = True
        LBL_Puesto_text.Text = Privilegios.Privilegio
        LBL_Usuario.Visible = True
        LBL_Usuario_text.Visible = True
        LBL_Usuario_text.Text = Privilegios.usuario
        PB_Perfil.Visible = True
    End Sub

    Private Sub SubsistemasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubsistemasToolStripMenuItem.Click
        BTN_Inventario.Visible = True
        BTN_Compras.Visible = True
        BTN_Ventas.Visible = True
        BTN_Produccion.Visible = True
        BTN_Distribuccion.Visible = True
        BTN_Finanzas.Visible = True
        BTN_Mantenimiento.Visible = True
        BTN_Recursos_Humanos.Visible = True

        LBL_Nombre.Visible = False
        LBL_Nombre_text.Visible = False
        LBL_Puesto.Visible = False
        LBL_Puesto_text.Visible = False
        LBL_Usuario.Visible = False
        LBL_Usuario_text.Visible = False
        PB_Perfil.Visible = False
    End Sub

    Private Sub BTN_Recursos_Humanos_Click(sender As Object, e As EventArgs) Handles BTN_Recursos_Humanos.Click
        Recursos_Humanos.Show()
        Me.Hide()

    End Sub
End Class