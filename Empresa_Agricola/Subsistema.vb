﻿Public Class Subsistema
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Este es el form de los subsistemas
        Login.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Inventario.Show()



    End Sub

    Private Sub Subsistema_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Venta.Show()

    End Sub
End Class