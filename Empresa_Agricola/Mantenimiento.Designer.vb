<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Matricula = New System.Windows.Forms.Label()
        Me.TXT_Problema = New System.Windows.Forms.TextBox()
        Me.BTN_Aceptar = New System.Windows.Forms.Button()
        Me.TXT_Empleado = New System.Windows.Forms.TextBox()
        Me.TXT_Matricula = New System.Windows.Forms.TextBox()
        Me.CB_Operacion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Problema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Empleado"
        '
        'Matricula
        '
        Me.Matricula.AutoSize = True
        Me.Matricula.Location = New System.Drawing.Point(256, 176)
        Me.Matricula.Name = "Matricula"
        Me.Matricula.Size = New System.Drawing.Size(73, 20)
        Me.Matricula.TabIndex = 13
        Me.Matricula.Text = "Matricula"
        '
        'TXT_Problema
        '
        Me.TXT_Problema.Location = New System.Drawing.Point(406, 287)
        Me.TXT_Problema.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Problema.Name = "TXT_Problema"
        Me.TXT_Problema.Size = New System.Drawing.Size(126, 26)
        Me.TXT_Problema.TabIndex = 12
        '
        'BTN_Aceptar
        '
        Me.BTN_Aceptar.Location = New System.Drawing.Point(418, 340)
        Me.BTN_Aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Aceptar.Name = "BTN_Aceptar"
        Me.BTN_Aceptar.Size = New System.Drawing.Size(115, 30)
        Me.BTN_Aceptar.TabIndex = 11
        Me.BTN_Aceptar.Text = "Realizar"
        Me.BTN_Aceptar.UseVisualStyleBackColor = True
        '
        'TXT_Empleado
        '
        Me.TXT_Empleado.Location = New System.Drawing.Point(406, 232)
        Me.TXT_Empleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Empleado.Name = "TXT_Empleado"
        Me.TXT_Empleado.Size = New System.Drawing.Size(126, 26)
        Me.TXT_Empleado.TabIndex = 10
        '
        'TXT_Matricula
        '
        Me.TXT_Matricula.Location = New System.Drawing.Point(406, 170)
        Me.TXT_Matricula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Matricula.Name = "TXT_Matricula"
        Me.TXT_Matricula.Size = New System.Drawing.Size(126, 26)
        Me.TXT_Matricula.TabIndex = 9
        '
        'CB_Operacion
        '
        Me.CB_Operacion.FormattingEnabled = True
        Me.CB_Operacion.Items.AddRange(New Object() {"Ingresar", "Consultar", "Actualizar"})
        Me.CB_Operacion.Location = New System.Drawing.Point(409, 80)
        Me.CB_Operacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Operacion.Name = "CB_Operacion"
        Me.CB_Operacion.Size = New System.Drawing.Size(136, 28)
        Me.CB_Operacion.TabIndex = 8
        '
        'Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Matricula)
        Me.Controls.Add(Me.TXT_Problema)
        Me.Controls.Add(Me.BTN_Aceptar)
        Me.Controls.Add(Me.TXT_Empleado)
        Me.Controls.Add(Me.TXT_Matricula)
        Me.Controls.Add(Me.CB_Operacion)
        Me.Name = "Mantenimiento"
        Me.Text = "Mantenimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Matricula As Label
    Friend WithEvents TXT_Problema As TextBox
    Friend WithEvents BTN_Aceptar As Button
    Friend WithEvents TXT_Empleado As TextBox
    Friend WithEvents TXT_Matricula As TextBox
    Friend WithEvents CB_Operacion As ComboBox
End Class
