Module M_Alert
    Public mensaje, titulo, tama, tipo As String
    Public tiempoDuracion As Integer


    'PARAMETROS
    'type -> success,error
    'size ->large,small,tiny
    'superposicion -> false=se muestra sin relacion con el form que lo llama
    '                 true=es parte del form que lo llama
    'time-> tiempo en segundos de duracion

    Public Sub CreateAlert(ms As String, title As String, type As String, size As String, superposicion As Boolean, time As Integer)
        mensaje = ms
        titulo = title
        tama = size
        tiempoDuracion = time
        tipo = type

        If Alert.WindowState = FormWindowState.Normal Then
            Alert.Close()
        End If

        If superposicion Then
            Alert.ShowDialog()
        Else
            Alert.Show()
        End If

    End Sub

End Module
