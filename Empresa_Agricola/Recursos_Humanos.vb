Public Class Recursos_Humanos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Registro_Empleado.Click
        RegistrarEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub Recursos_Humanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Privilegios.Privilegio = "Empleado_Recursos_Humanos" Then
            BTN_Registro_Empleado.Enabled = False
        ElseIf Privilegios.Privilegio = "Recursos_Humanos" Or Privilegios.Privilegio = "gerente" Then
            BTN_Registro_Empleado.Enabled = True
        End If
    End Sub

    Private Sub Recursos_Humanos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Subsistema.Show()
    End Sub
End Class