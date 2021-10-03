<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.TXT_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Tipo_Articulo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Nombre_Articulo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CB_Opciones = New System.Windows.Forms.ComboBox()
        Me.CB_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_Cantidad
        '
        Me.TXT_Cantidad.Location = New System.Drawing.Point(149, 122)
        Me.TXT_Cantidad.Name = "TXT_Cantidad"
        Me.TXT_Cantidad.Size = New System.Drawing.Size(201, 26)
        Me.TXT_Cantidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "cantidad:"
        '
        'CB_Tipo_Articulo
        '
        Me.CB_Tipo_Articulo.FormattingEnabled = True
        Me.CB_Tipo_Articulo.Location = New System.Drawing.Point(149, 213)
        Me.CB_Tipo_Articulo.Name = "CB_Tipo_Articulo"
        Me.CB_Tipo_Articulo.Size = New System.Drawing.Size(181, 28)
        Me.CB_Tipo_Articulo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "nombre:"
        '
        'CB_Nombre_Articulo
        '
        Me.CB_Nombre_Articulo.FormattingEnabled = True
        Me.CB_Nombre_Articulo.Location = New System.Drawing.Point(147, 304)
        Me.CB_Nombre_Articulo.Name = "CB_Nombre_Articulo"
        Me.CB_Nombre_Articulo.Size = New System.Drawing.Size(181, 28)
        Me.CB_Nombre_Articulo.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(686, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "add produc"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CB_Opciones
        '
        Me.CB_Opciones.FormattingEnabled = True
        Me.CB_Opciones.Items.AddRange(New Object() {"Disminuir", "Aumentar", "Agregar"})
        Me.CB_Opciones.Location = New System.Drawing.Point(149, 378)
        Me.CB_Opciones.Name = "CB_Opciones"
        Me.CB_Opciones.Size = New System.Drawing.Size(181, 28)
        Me.CB_Opciones.TabIndex = 8
        '
        'CB_Sucursal
        '
        Me.CB_Sucursal.FormattingEnabled = True
        Me.CB_Sucursal.Location = New System.Drawing.Point(149, 456)
        Me.CB_Sucursal.Name = "CB_Sucursal"
        Me.CB_Sucursal.Size = New System.Drawing.Size(181, 28)
        Me.CB_Sucursal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "sucursal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "opciones"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 536)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Sucursal)
        Me.Controls.Add(Me.CB_Opciones)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Nombre_Articulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Tipo_Articulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Cantidad)
        Me.Name = "Inventario"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Tipo_Articulo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_Nombre_Articulo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CB_Opciones As ComboBox
    Friend WithEvents CB_Sucursal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
