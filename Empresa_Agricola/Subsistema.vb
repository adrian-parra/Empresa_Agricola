﻿Public Class Subsistema
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Este es el form de los subsistemas
        Login.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Inventario.Show()

    End Sub
End Class