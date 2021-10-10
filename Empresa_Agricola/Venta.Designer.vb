<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CB_Cliente = New System.Windows.Forms.ComboBox()
        Me.CB_Articulo = New System.Windows.Forms.ComboBox()
        Me.CB_Tipo_Pago = New System.Windows.Forms.ComboBox()
        Me.TXT_Cantidad = New System.Windows.Forms.TextBox()
        Me.TXT_Precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_Registrar_Venta = New System.Windows.Forms.Button()
        Me.TXT_Folio = New System.Windows.Forms.TextBox()
        Me.BTN_Cunetas_Por_Cobrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CB_Cliente
        '
        Me.CB_Cliente.FormattingEnabled = True
        Me.CB_Cliente.Location = New System.Drawing.Point(93, 104)
        Me.CB_Cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Cliente.Name = "CB_Cliente"
        Me.CB_Cliente.Size = New System.Drawing.Size(150, 28)
        Me.CB_Cliente.TabIndex = 0
        '
        'CB_Articulo
        '
        Me.CB_Articulo.FormattingEnabled = True
        Me.CB_Articulo.Location = New System.Drawing.Point(93, 181)
        Me.CB_Articulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Articulo.Name = "CB_Articulo"
        Me.CB_Articulo.Size = New System.Drawing.Size(150, 28)
        Me.CB_Articulo.TabIndex = 1
        '
        'CB_Tipo_Pago
        '
        Me.CB_Tipo_Pago.FormattingEnabled = True
        Me.CB_Tipo_Pago.Items.AddRange(New Object() {"Efectivo", "Credito"})
        Me.CB_Tipo_Pago.Location = New System.Drawing.Point(93, 260)
        Me.CB_Tipo_Pago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Tipo_Pago.Name = "CB_Tipo_Pago"
        Me.CB_Tipo_Pago.Size = New System.Drawing.Size(150, 28)
        Me.CB_Tipo_Pago.TabIndex = 2
        '
        'TXT_Cantidad
        '
        Me.TXT_Cantidad.Location = New System.Drawing.Point(93, 325)
        Me.TXT_Cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Cantidad.Name = "TXT_Cantidad"
        Me.TXT_Cantidad.Size = New System.Drawing.Size(150, 26)
        Me.TXT_Cantidad.TabIndex = 3
        '
        'TXT_Precio
        '
        Me.TXT_Precio.Location = New System.Drawing.Point(93, 390)
        Me.TXT_Precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Precio.Name = "TXT_Precio"
        Me.TXT_Precio.Size = New System.Drawing.Size(150, 26)
        Me.TXT_Precio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo_Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio"
        '
        'BTN_Registrar_Venta
        '
        Me.BTN_Registrar_Venta.Location = New System.Drawing.Point(82, 508)
        Me.BTN_Registrar_Venta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Registrar_Venta.Name = "BTN_Registrar_Venta"
        Me.BTN_Registrar_Venta.Size = New System.Drawing.Size(171, 42)
        Me.BTN_Registrar_Venta.TabIndex = 10
        Me.BTN_Registrar_Venta.Text = "Registrar_Venta"
        Me.BTN_Registrar_Venta.UseVisualStyleBackColor = True
        '
        'TXT_Folio
        '
        Me.TXT_Folio.Location = New System.Drawing.Point(93, 457)
        Me.TXT_Folio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Folio.Name = "TXT_Folio"
        Me.TXT_Folio.Size = New System.Drawing.Size(150, 26)
        Me.TXT_Folio.TabIndex = 11
        '
        'BTN_Cunetas_Por_Cobrar
        '
        Me.BTN_Cunetas_Por_Cobrar.Location = New System.Drawing.Point(339, 494)
        Me.BTN_Cunetas_Por_Cobrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Cunetas_Por_Cobrar.Name = "BTN_Cunetas_Por_Cobrar"
        Me.BTN_Cunetas_Por_Cobrar.Size = New System.Drawing.Size(171, 42)
        Me.BTN_Cunetas_Por_Cobrar.TabIndex = 12
        Me.BTN_Cunetas_Por_Cobrar.Text = "Cuentas_Por_Cobrar"
        Me.BTN_Cunetas_Por_Cobrar.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 563)
        Me.Controls.Add(Me.BTN_Cunetas_Por_Cobrar)
        Me.Controls.Add(Me.TXT_Folio)
        Me.Controls.Add(Me.BTN_Registrar_Venta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Precio)
        Me.Controls.Add(Me.TXT_Cantidad)
        Me.Controls.Add(Me.CB_Tipo_Pago)
        Me.Controls.Add(Me.CB_Articulo)
        Me.Controls.Add(Me.CB_Cliente)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Cliente As ComboBox
    Friend WithEvents CB_Articulo As ComboBox
    Friend WithEvents CB_Tipo_Pago As ComboBox
    Friend WithEvents TXT_Cantidad As TextBox
    Friend WithEvents TXT_Precio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_Registrar_Venta As Button
    Friend WithEvents TXT_Folio As TextBox
    Friend WithEvents BTN_Cunetas_Por_Cobrar As Button
End Class
