<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Direccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Direccion))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CB_Ciudad = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_Municipios = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_Estados = New System.Windows.Forms.ComboBox()
        Me.TXT_Codigo_Postal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_Colonia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Calle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_Num_Exterior = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_Registrar_Direccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(456, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Ciudad"
        '
        'CB_Ciudad
        '
        Me.CB_Ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Ciudad.FormattingEnabled = True
        Me.CB_Ciudad.Location = New System.Drawing.Point(451, 277)
        Me.CB_Ciudad.Name = "CB_Ciudad"
        Me.CB_Ciudad.Size = New System.Drawing.Size(238, 37)
        Me.CB_Ciudad.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(456, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 25)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Municipio"
        '
        'CB_Municipios
        '
        Me.CB_Municipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Municipios.FormattingEnabled = True
        Me.CB_Municipios.Location = New System.Drawing.Point(451, 182)
        Me.CB_Municipios.Name = "CB_Municipios"
        Me.CB_Municipios.Size = New System.Drawing.Size(238, 37)
        Me.CB_Municipios.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(456, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Estado"
        '
        'CB_Estados
        '
        Me.CB_Estados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Estados.FormattingEnabled = True
        Me.CB_Estados.Location = New System.Drawing.Point(451, 95)
        Me.CB_Estados.Name = "CB_Estados"
        Me.CB_Estados.Size = New System.Drawing.Size(238, 37)
        Me.CB_Estados.TabIndex = 30
        '
        'TXT_Codigo_Postal
        '
        Me.TXT_Codigo_Postal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Codigo_Postal.Location = New System.Drawing.Point(93, 377)
        Me.TXT_Codigo_Postal.Name = "TXT_Codigo_Postal"
        Me.TXT_Codigo_Postal.Size = New System.Drawing.Size(260, 35)
        Me.TXT_Codigo_Postal.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Codigo postal"
        '
        'TXT_Colonia
        '
        Me.TXT_Colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Colonia.Location = New System.Drawing.Point(93, 277)
        Me.TXT_Colonia.Name = "TXT_Colonia"
        Me.TXT_Colonia.Size = New System.Drawing.Size(260, 35)
        Me.TXT_Colonia.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Colonia"
        '
        'TXT_Calle
        '
        Me.TXT_Calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Calle.Location = New System.Drawing.Point(93, 184)
        Me.TXT_Calle.Name = "TXT_Calle"
        Me.TXT_Calle.Size = New System.Drawing.Size(260, 35)
        Me.TXT_Calle.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "calle"
        '
        'TXT_Num_Exterior
        '
        Me.TXT_Num_Exterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Num_Exterior.Location = New System.Drawing.Point(93, 97)
        Me.TXT_Num_Exterior.Name = "TXT_Num_Exterior"
        Me.TXT_Num_Exterior.Size = New System.Drawing.Size(260, 35)
        Me.TXT_Num_Exterior.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Numero exterior"
        '
        'BTN_Registrar_Direccion
        '
        Me.BTN_Registrar_Direccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Registrar_Direccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Registrar_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Registrar_Direccion.Image = Global.Empresa_Agricola.My.Resources.Resources.img_guardar
        Me.BTN_Registrar_Direccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Registrar_Direccion.Location = New System.Drawing.Point(451, 341)
        Me.BTN_Registrar_Direccion.Name = "BTN_Registrar_Direccion"
        Me.BTN_Registrar_Direccion.Size = New System.Drawing.Size(238, 71)
        Me.BTN_Registrar_Direccion.TabIndex = 36
        Me.BTN_Registrar_Direccion.Text = "Registrar"
        Me.BTN_Registrar_Direccion.UseVisualStyleBackColor = True
        '
        'Direccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 457)
        Me.Controls.Add(Me.BTN_Registrar_Direccion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CB_Ciudad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CB_Municipios)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CB_Estados)
        Me.Controls.Add(Me.TXT_Codigo_Postal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_Colonia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_Calle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_Num_Exterior)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Direccion"
        Me.Text = "Direccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents CB_Ciudad As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CB_Municipios As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_Estados As ComboBox
    Friend WithEvents TXT_Codigo_Postal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_Colonia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Calle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_Num_Exterior As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_Registrar_Direccion As Button
End Class
