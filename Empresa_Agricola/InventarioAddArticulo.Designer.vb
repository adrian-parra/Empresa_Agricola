<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioAddArticulo
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
        Me.CB_Tipo_Articulo = New System.Windows.Forms.ComboBox()
        Me.TXT_Nombre_Articulo = New System.Windows.Forms.TextBox()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo:"
        '
        'CB_Tipo_Articulo
        '
        Me.CB_Tipo_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Tipo_Articulo.FormattingEnabled = True
        Me.CB_Tipo_Articulo.Location = New System.Drawing.Point(219, 174)
        Me.CB_Tipo_Articulo.Name = "CB_Tipo_Articulo"
        Me.CB_Tipo_Articulo.Size = New System.Drawing.Size(478, 38)
        Me.CB_Tipo_Articulo.TabIndex = 6
        '
        'TXT_Nombre_Articulo
        '
        Me.TXT_Nombre_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Nombre_Articulo.Location = New System.Drawing.Point(219, 261)
        Me.TXT_Nombre_Articulo.Name = "TXT_Nombre_Articulo"
        Me.TXT_Nombre_Articulo.Size = New System.Drawing.Size(482, 37)
        Me.TXT_Nombre_Articulo.TabIndex = 9
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.Image = Global.Empresa_Agricola.My.Resources.Resources.img_registro_btn_registrar
        Me.BTN_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Guardar.Location = New System.Drawing.Point(344, 334)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_Guardar.Size = New System.Drawing.Size(215, 69)
        Me.BTN_Guardar.TabIndex = 10
        Me.BTN_Guardar.Text = "guardar"
        Me.BTN_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 36)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Agregar articulo"
        '
        'InventarioAddArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 541)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.TXT_Nombre_Articulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Tipo_Articulo)
        Me.Name = "InventarioAddArticulo"
        Me.Text = "InventarioAddArticulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Tipo_Articulo As ComboBox
    Friend WithEvents TXT_Nombre_Articulo As TextBox
    Friend WithEvents BTN_Guardar As Button
    Friend WithEvents Label6 As Label
End Class
