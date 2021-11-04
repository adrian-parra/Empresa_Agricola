<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduccionCampo
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_Campo = New System.Windows.Forms.ComboBox()
        Me.TXT_Tamaño = New System.Windows.Forms.TextBox()
        Me.TXT_Nombre = New System.Windows.Forms.TextBox()
        Me.CB_Sucursal = New System.Windows.Forms.ComboBox()
        Me.CB_Producto = New System.Windows.Forms.ComboBox()
        Me.CB_Accion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(280, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tamaño"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Campo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Accion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_Campo
        '
        Me.CB_Campo.FormattingEnabled = True
        Me.CB_Campo.Location = New System.Drawing.Point(386, 94)
        Me.CB_Campo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Campo.Name = "CB_Campo"
        Me.CB_Campo.Size = New System.Drawing.Size(136, 28)
        Me.CB_Campo.TabIndex = 18
        '
        'TXT_Tamaño
        '
        Me.TXT_Tamaño.Location = New System.Drawing.Point(386, 187)
        Me.TXT_Tamaño.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Tamaño.Name = "TXT_Tamaño"
        Me.TXT_Tamaño.Size = New System.Drawing.Size(136, 26)
        Me.TXT_Tamaño.TabIndex = 17
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.Location = New System.Drawing.Point(386, 223)
        Me.TXT_Nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.Size = New System.Drawing.Size(136, 26)
        Me.TXT_Nombre.TabIndex = 16
        '
        'CB_Sucursal
        '
        Me.CB_Sucursal.FormattingEnabled = True
        Me.CB_Sucursal.Location = New System.Drawing.Point(386, 257)
        Me.CB_Sucursal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Sucursal.Name = "CB_Sucursal"
        Me.CB_Sucursal.Size = New System.Drawing.Size(136, 28)
        Me.CB_Sucursal.TabIndex = 15
        '
        'CB_Producto
        '
        Me.CB_Producto.FormattingEnabled = True
        Me.CB_Producto.Location = New System.Drawing.Point(386, 295)
        Me.CB_Producto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Producto.Name = "CB_Producto"
        Me.CB_Producto.Size = New System.Drawing.Size(136, 28)
        Me.CB_Producto.TabIndex = 14
        '
        'CB_Accion
        '
        Me.CB_Accion.FormattingEnabled = True
        Me.CB_Accion.Items.AddRange(New Object() {"Sembrar", "Registrar", "Fertilizar", "Regar"})
        Me.CB_Accion.Location = New System.Drawing.Point(386, 45)
        Me.CB_Accion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Accion.Name = "CB_Accion"
        Me.CB_Accion.Size = New System.Drawing.Size(136, 28)
        Me.CB_Accion.TabIndex = 13
        '
        'ProduccionCampo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_Campo)
        Me.Controls.Add(Me.TXT_Tamaño)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.CB_Sucursal)
        Me.Controls.Add(Me.CB_Producto)
        Me.Controls.Add(Me.CB_Accion)
        Me.Name = "ProduccionCampo"
        Me.Text = "ProduccionCampo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CB_Campo As ComboBox
    Friend WithEvents TXT_Tamaño As TextBox
    Friend WithEvents TXT_Nombre As TextBox
    Friend WithEvents CB_Sucursal As ComboBox
    Friend WithEvents CB_Producto As ComboBox
    Friend WithEvents CB_Accion As ComboBox
End Class
