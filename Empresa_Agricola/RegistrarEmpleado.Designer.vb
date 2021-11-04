<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEmpleado
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
        Me.TXT_Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Apellido_M = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Apellido_P = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Rfc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_Telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_Curp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_Sueldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_Puesto = New System.Windows.Forms.ComboBox()
        Me.BTN_Registrar_Empleado = New System.Windows.Forms.Button()
        Me.BTN_Direccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Nombre.Location = New System.Drawing.Point(43, 88)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Nombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido Materno"
        '
        'TXT_Apellido_M
        '
        Me.TXT_Apellido_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Apellido_M.Location = New System.Drawing.Point(43, 197)
        Me.TXT_Apellido_M.Name = "TXT_Apellido_M"
        Me.TXT_Apellido_M.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Apellido_M.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido Paterno"
        '
        'TXT_Apellido_P
        '
        Me.TXT_Apellido_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Apellido_P.Location = New System.Drawing.Point(43, 287)
        Me.TXT_Apellido_P.Name = "TXT_Apellido_P"
        Me.TXT_Apellido_P.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Apellido_P.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "rfc"
        '
        'TXT_Rfc
        '
        Me.TXT_Rfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Rfc.Location = New System.Drawing.Point(389, 197)
        Me.TXT_Rfc.Name = "TXT_Rfc"
        Me.TXT_Rfc.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Rfc.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono"
        '
        'TXT_Telefono
        '
        Me.TXT_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Telefono.Location = New System.Drawing.Point(389, 88)
        Me.TXT_Telefono.Name = "TXT_Telefono"
        Me.TXT_Telefono.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Telefono.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "curp"
        '
        'TXT_Curp
        '
        Me.TXT_Curp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Curp.Location = New System.Drawing.Point(389, 287)
        Me.TXT_Curp.Name = "TXT_Curp"
        Me.TXT_Curp.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Curp.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "sueldo"
        '
        'TXT_Sueldo
        '
        Me.TXT_Sueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Sueldo.Location = New System.Drawing.Point(43, 371)
        Me.TXT_Sueldo.Name = "TXT_Sueldo"
        Me.TXT_Sueldo.Size = New System.Drawing.Size(239, 32)
        Me.TXT_Sueldo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Puesto"
        '
        'CB_Puesto
        '
        Me.CB_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Puesto.FormattingEnabled = True
        Me.CB_Puesto.Location = New System.Drawing.Point(389, 369)
        Me.CB_Puesto.Name = "CB_Puesto"
        Me.CB_Puesto.Size = New System.Drawing.Size(239, 34)
        Me.CB_Puesto.TabIndex = 20
        '
        'BTN_Registrar_Empleado
        '
        Me.BTN_Registrar_Empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Registrar_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Registrar_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Registrar_Empleado.Image = Global.Empresa_Agricola.My.Resources.Resources.img_guardar
        Me.BTN_Registrar_Empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Registrar_Empleado.Location = New System.Drawing.Point(376, 484)
        Me.BTN_Registrar_Empleado.Name = "BTN_Registrar_Empleado"
        Me.BTN_Registrar_Empleado.Size = New System.Drawing.Size(252, 63)
        Me.BTN_Registrar_Empleado.TabIndex = 1
        Me.BTN_Registrar_Empleado.Text = "Registrar"
        Me.BTN_Registrar_Empleado.UseVisualStyleBackColor = True
        '
        'BTN_Direccion
        '
        Me.BTN_Direccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Direccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Direccion.Image = Global.Empresa_Agricola.My.Resources.Resources.img_direccion
        Me.BTN_Direccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Direccion.Location = New System.Drawing.Point(43, 484)
        Me.BTN_Direccion.Name = "BTN_Direccion"
        Me.BTN_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_Direccion.Size = New System.Drawing.Size(239, 63)
        Me.BTN_Direccion.TabIndex = 0
        Me.BTN_Direccion.Text = "Direccion"
        Me.BTN_Direccion.UseVisualStyleBackColor = True
        '
        'RegistrarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 580)
        Me.Controls.Add(Me.CB_Puesto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_Sueldo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_Curp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Rfc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_Telefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_Apellido_P)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Apellido_M)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.BTN_Registrar_Empleado)
        Me.Controls.Add(Me.BTN_Direccion)
        Me.Name = "RegistrarEmpleado"
        Me.Text = "Registrar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Direccion As Button
    Friend WithEvents BTN_Registrar_Empleado As Button
    Friend WithEvents TXT_Nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Apellido_M As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Apellido_P As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Rfc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_Telefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_Curp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_Sueldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_Puesto As ComboBox
End Class
