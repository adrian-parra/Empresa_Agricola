<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recursos_Humanos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recursos_Humanos))
        Me.BTN_Registro_Empleado = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_Registro_Empleado
        '
        Me.BTN_Registro_Empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Registro_Empleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Registro_Empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Registro_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Registro_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Registro_Empleado.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_subsistemas
        Me.BTN_Registro_Empleado.Location = New System.Drawing.Point(103, 140)
        Me.BTN_Registro_Empleado.Name = "BTN_Registro_Empleado"
        Me.BTN_Registro_Empleado.Size = New System.Drawing.Size(246, 142)
        Me.BTN_Registro_Empleado.TabIndex = 0
        Me.BTN_Registro_Empleado.Text = "Registrar Empleado"
        Me.BTN_Registro_Empleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_Registro_Empleado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_perfil_info
        Me.Button2.Location = New System.Drawing.Point(461, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(282, 142)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Datos de Empleado"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Recursos_Humanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(846, 412)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_Registro_Empleado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recursos_Humanos"
        Me.Text = "Recursos Humanos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_Registro_Empleado As Button
    Friend WithEvents Button2 As Button
End Class
