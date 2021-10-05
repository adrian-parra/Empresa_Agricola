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
        Me.CB_Opciones = New System.Windows.Forms.ComboBox()
        Me.CB_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.BTN_Add_Product = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_Cantidad
        '
        Me.TXT_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Cantidad.Location = New System.Drawing.Point(353, 129)
        Me.TXT_Cantidad.Name = "TXT_Cantidad"
        Me.TXT_Cantidad.Size = New System.Drawing.Size(162, 37)
        Me.TXT_Cantidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad:"
        '
        'CB_Tipo_Articulo
        '
        Me.CB_Tipo_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Tipo_Articulo.FormattingEnabled = True
        Me.CB_Tipo_Articulo.Location = New System.Drawing.Point(197, 209)
        Me.CB_Tipo_Articulo.Name = "CB_Tipo_Articulo"
        Me.CB_Tipo_Articulo.Size = New System.Drawing.Size(478, 38)
        Me.CB_Tipo_Articulo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'CB_Nombre_Articulo
        '
        Me.CB_Nombre_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Nombre_Articulo.FormattingEnabled = True
        Me.CB_Nombre_Articulo.Location = New System.Drawing.Point(197, 288)
        Me.CB_Nombre_Articulo.Name = "CB_Nombre_Articulo"
        Me.CB_Nombre_Articulo.Size = New System.Drawing.Size(478, 38)
        Me.CB_Nombre_Articulo.TabIndex = 4
        '
        'CB_Opciones
        '
        Me.CB_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Opciones.FormattingEnabled = True
        Me.CB_Opciones.Items.AddRange(New Object() {"Disminuir", "Aumentar", "Agregar"})
        Me.CB_Opciones.Location = New System.Drawing.Point(197, 368)
        Me.CB_Opciones.Name = "CB_Opciones"
        Me.CB_Opciones.Size = New System.Drawing.Size(478, 38)
        Me.CB_Opciones.TabIndex = 8
        '
        'CB_Sucursal
        '
        Me.CB_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Sucursal.FormattingEnabled = True
        Me.CB_Sucursal.Location = New System.Drawing.Point(197, 448)
        Me.CB_Sucursal.Name = "CB_Sucursal"
        Me.CB_Sucursal.Size = New System.Drawing.Size(478, 38)
        Me.CB_Sucursal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sucursal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(197, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Opciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 36)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Inventario"
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.Image = Global.Empresa_Agricola.My.Resources.Resources.img_registro_btn_registrar
        Me.BTN_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Guardar.Location = New System.Drawing.Point(197, 501)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_Guardar.Size = New System.Drawing.Size(215, 69)
        Me.BTN_Guardar.TabIndex = 7
        Me.BTN_Guardar.Text = "guardar"
        Me.BTN_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'BTN_Add_Product
        '
        Me.BTN_Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Add_Product.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Add_Product.Image = Global.Empresa_Agricola.My.Resources.Resources.img_inventario_btn_agregar
        Me.BTN_Add_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Add_Product.Location = New System.Drawing.Point(418, 501)
        Me.BTN_Add_Product.Name = "BTN_Add_Product"
        Me.BTN_Add_Product.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_Add_Product.Size = New System.Drawing.Size(257, 69)
        Me.BTN_Add_Product.TabIndex = 6
        Me.BTN_Add_Product.Text = "Registrar"
        Me.BTN_Add_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Add_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Add_Product.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 622)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Sucursal)
        Me.Controls.Add(Me.CB_Opciones)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.BTN_Add_Product)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Nombre_Articulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Tipo_Articulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Cantidad)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Tipo_Articulo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_Nombre_Articulo As ComboBox
    Friend WithEvents BTN_Add_Product As Button
    Friend WithEvents BTN_Guardar As Button
    Friend WithEvents CB_Opciones As ComboBox
    Friend WithEvents CB_Sucursal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
