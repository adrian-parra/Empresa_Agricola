<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduccionEmpaque
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_NuevoProducto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Cantidad = New System.Windows.Forms.TextBox()
        Me.CB_Empaque = New System.Windows.Forms.ComboBox()
        Me.CB_Calidad = New System.Windows.Forms.ComboBox()
        Me.CB_Nombre = New System.Windows.Forms.ComboBox()
        Me.CB_Accion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(636, 466)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 29)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Nueva Calidad"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(563, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nombre"
        '
        'TXT_NuevoProducto
        '
        Me.TXT_NuevoProducto.Location = New System.Drawing.Point(512, 285)
        Me.TXT_NuevoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_NuevoProducto.Name = "TXT_NuevoProducto"
        Me.TXT_NuevoProducto.Size = New System.Drawing.Size(168, 26)
        Me.TXT_NuevoProducto.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(441, 466)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 29)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Nuevo Producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 466)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 29)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Empaque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Calidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Accion"
        '
        'TXT_Cantidad
        '
        Me.TXT_Cantidad.Location = New System.Drawing.Point(234, 375)
        Me.TXT_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Cantidad.Name = "TXT_Cantidad"
        Me.TXT_Cantidad.Size = New System.Drawing.Size(136, 26)
        Me.TXT_Cantidad.TabIndex = 19
        '
        'CB_Empaque
        '
        Me.CB_Empaque.FormattingEnabled = True
        Me.CB_Empaque.Location = New System.Drawing.Point(234, 320)
        Me.CB_Empaque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Empaque.Name = "CB_Empaque"
        Me.CB_Empaque.Size = New System.Drawing.Size(136, 28)
        Me.CB_Empaque.TabIndex = 18
        '
        'CB_Calidad
        '
        Me.CB_Calidad.FormattingEnabled = True
        Me.CB_Calidad.Location = New System.Drawing.Point(234, 260)
        Me.CB_Calidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Calidad.Name = "CB_Calidad"
        Me.CB_Calidad.Size = New System.Drawing.Size(136, 28)
        Me.CB_Calidad.TabIndex = 17
        '
        'CB_Nombre
        '
        Me.CB_Nombre.FormattingEnabled = True
        Me.CB_Nombre.Location = New System.Drawing.Point(234, 200)
        Me.CB_Nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Nombre.Name = "CB_Nombre"
        Me.CB_Nombre.Size = New System.Drawing.Size(136, 28)
        Me.CB_Nombre.TabIndex = 16
        '
        'CB_Accion
        '
        Me.CB_Accion.FormattingEnabled = True
        Me.CB_Accion.Items.AddRange(New Object() {"Disminuir", "Aumentar", "Agregar"})
        Me.CB_Accion.Location = New System.Drawing.Point(234, 149)
        Me.CB_Accion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Accion.Name = "CB_Accion"
        Me.CB_Accion.Size = New System.Drawing.Size(136, 28)
        Me.CB_Accion.TabIndex = 15
        '
        'ProduccionEmpaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 644)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_NuevoProducto)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Cantidad)
        Me.Controls.Add(Me.CB_Empaque)
        Me.Controls.Add(Me.CB_Calidad)
        Me.Controls.Add(Me.CB_Nombre)
        Me.Controls.Add(Me.CB_Accion)
        Me.Name = "ProduccionEmpaque"
        Me.Text = "ProduccionEmpaque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_NuevoProducto As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Cantidad As TextBox
    Friend WithEvents CB_Empaque As ComboBox
    Friend WithEvents CB_Calidad As ComboBox
    Friend WithEvents CB_Nombre As ComboBox
    Friend WithEvents CB_Accion As ComboBox
End Class
