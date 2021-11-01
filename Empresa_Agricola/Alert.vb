Public Class Alert
    Dim contSeg As Integer
    Dim TimeEnd As Integer
    Private Sub Alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimeEnd = M_Alert.tiempoDuracion

        'Me.Opacity = 0.8
        Me.Cursor = Cursors.Hand
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow

        Me.Text = UCase(M_Alert.titulo)
        Me.BackColor = Color.White



        Dim bmp As System.Drawing.Bitmap
        Dim text As New Label
        text.Left = 0

        'VERIFICAR TAMANHO DE ALERT
        If UCase(M_Alert.tama) = "LARGE" Then
            Me.Width = 400 '384
            Me.Height = 250
            text.Font = New Font(text.Font.Name, 13)

            If UCase(M_Alert.tipo) = "SUCCES" Then
                bmp = My.Resources.img_alert_succes_large
            Else
                bmp = My.Resources.img_alert_error_large
            End If

        ElseIf UCase(M_Alert.tama) = "SMALL" Then
            Me.Width = 400 '384
            Me.Height = 200
            text.Font = New Font(text.Font.Name, 12)
            If UCase(M_Alert.tipo) = "SUCCES" Then
                bmp = My.Resources.img_alert_succes_small
            Else
                bmp = My.Resources.img_alert_error_small
            End If
        ElseIf UCase(M_Alert.tama) = "TINY" Then
            Me.Width = 400 '384
            Me.Height = 180
            text.Font = New Font(text.Font.Name, 11)
            If UCase(M_Alert.tipo) = "SUCCES" Then
                bmp = My.Resources.img_alert_success_tiny
            Else
                bmp = My.Resources.img_alert_error_tiny
            End If
        End If

        PB_img.Top = 0




        PB_img.Left = ((Me.Width - 16) / 2) - (PB_img.Width / 2)
        'PB_img.Left = (192 - (PB_img.Width / 2))
        PB_img.Image = bmp

        text.Width = Me.Width - 16
        text.Height = 100
        text.TextAlign = ContentAlignment.MiddleCenter
        text.Top = PB_img.Height - 30

        If UCase(M_Alert.tipo) = "SUCCES" Then
            text.ForeColor = Color.LightSeaGreen
        Else
            text.ForeColor = Color.DarkRed
        End If




        'MENSAJE EN ALERT
        text.Text = UCase(M_Alert.mensaje)
        'LO AGREGO AL FORM
        Me.Controls.Add(text)



        'DURACION DE LA ALERT

        T_Duracion_alert.Enabled = True
        T_Duracion_alert.Start()





    End Sub

    Private Sub T_Duracion_alert_Tick(sender As Object, e As EventArgs) Handles T_Duracion_alert.Tick
        contSeg += 1

        If contSeg = TimeEnd Then

            contSeg = 0
            Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub Alert_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        contSeg = 0
        Dispose()
    End Sub

    Private Sub Alert_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()

    End Sub




    Private Sub Alert_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged
        MsgBox("")
    End Sub

    Private Sub PB_img_Click(sender As Object, e As EventArgs) Handles PB_img.Click
        Me.Close()

    End Sub
End Class