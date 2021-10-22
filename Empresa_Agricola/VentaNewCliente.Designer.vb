<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaNewCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Nombre = New System.Windows.Forms.TextBox()
        Me.TXT_Telefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Correo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Rfc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_Registrar_Cliente = New System.Windows.Forms.Button()
        Me.BTN_Agregar_Direccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.Location = New System.Drawing.Point(297, 80)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.Size = New System.Drawing.Size(184, 26)
        Me.TXT_Nombre.TabIndex = 1
        '
        'TXT_Telefono
        '
        Me.TXT_Telefono.Location = New System.Drawing.Point(297, 167)
        Me.TXT_Telefono.Name = "TXT_Telefono"
        Me.TXT_Telefono.Size = New System.Drawing.Size(184, 26)
        Me.TXT_Telefono.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefono"
        '
        'TXT_Correo
        '
        Me.TXT_Correo.Location = New System.Drawing.Point(297, 260)
        Me.TXT_Correo.Name = "TXT_Correo"
        Me.TXT_Correo.Size = New System.Drawing.Size(184, 26)
        Me.TXT_Correo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Correo"
        '
        'TXT_Rfc
        '
        Me.TXT_Rfc.Location = New System.Drawing.Point(297, 360)
        Me.TXT_Rfc.Name = "TXT_Rfc"
        Me.TXT_Rfc.Size = New System.Drawing.Size(184, 26)
        Me.TXT_Rfc.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rfc"
        '
        'BTN_Registrar_Cliente
        '
        Me.BTN_Registrar_Cliente.Location = New System.Drawing.Point(452, 469)
        Me.BTN_Registrar_Cliente.Name = "BTN_Registrar_Cliente"
        Me.BTN_Registrar_Cliente.Size = New System.Drawing.Size(302, 48)
        Me.BTN_Registrar_Cliente.TabIndex = 22
        Me.BTN_Registrar_Cliente.Text = "REGISTRAR CLIENTE"
        Me.BTN_Registrar_Cliente.UseVisualStyleBackColor = True
        '
        'BTN_Agregar_Direccion
        '
        Me.BTN_Agregar_Direccion.Location = New System.Drawing.Point(76, 469)
        Me.BTN_Agregar_Direccion.Name = "BTN_Agregar_Direccion"
        Me.BTN_Agregar_Direccion.Size = New System.Drawing.Size(302, 48)
        Me.BTN_Agregar_Direccion.TabIndex = 23
        Me.BTN_Agregar_Direccion.Text = "AGREGAR DIRECCION"
        Me.BTN_Agregar_Direccion.UseVisualStyleBackColor = True
        '
        'VentaNewCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 556)
        Me.Controls.Add(Me.BTN_Agregar_Direccion)
        Me.Controls.Add(Me.BTN_Registrar_Cliente)
        Me.Controls.Add(Me.TXT_Rfc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Correo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_Telefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VentaNewCliente"
        Me.Text = "VentaNewCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Nombre As TextBox
    Friend WithEvents TXT_Telefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Correo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Rfc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_Registrar_Cliente As Button
    Friend WithEvents BTN_Agregar_Direccion As Button
End Class
