<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecursosHumanosDatosEmpleado
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
        Me.TXT_Buscar = New System.Windows.Forms.TextBox()
        Me.BTN_Buscar_Empleado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Buscar_Por = New System.Windows.Forms.ComboBox()
        Me.DGV_Datos_Empleado = New System.Windows.Forms.DataGridView()
        Me.BTN_Update_Empleado = New System.Windows.Forms.Button()
        CType(Me.DGV_Datos_Empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_Buscar
        '
        Me.TXT_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Buscar.Location = New System.Drawing.Point(466, 13)
        Me.TXT_Buscar.Name = "TXT_Buscar"
        Me.TXT_Buscar.Size = New System.Drawing.Size(315, 32)
        Me.TXT_Buscar.TabIndex = 0
        '
        'BTN_Buscar_Empleado
        '
        Me.BTN_Buscar_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Buscar_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Buscar_Empleado.Location = New System.Drawing.Point(813, 4)
        Me.BTN_Buscar_Empleado.Name = "BTN_Buscar_Empleado"
        Me.BTN_Buscar_Empleado.Size = New System.Drawing.Size(196, 54)
        Me.BTN_Buscar_Empleado.TabIndex = 1
        Me.BTN_Buscar_Empleado.Text = "Buscar"
        Me.BTN_Buscar_Empleado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por:"
        '
        'CB_Buscar_Por
        '
        Me.CB_Buscar_Por.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Buscar_Por.FormattingEnabled = True
        Me.CB_Buscar_Por.Items.AddRange(New Object() {"CURP", "ID"})
        Me.CB_Buscar_Por.Location = New System.Drawing.Point(159, 12)
        Me.CB_Buscar_Por.Name = "CB_Buscar_Por"
        Me.CB_Buscar_Por.Size = New System.Drawing.Size(295, 34)
        Me.CB_Buscar_Por.TabIndex = 3
        '
        'DGV_Datos_Empleado
        '
        Me.DGV_Datos_Empleado.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Datos_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Datos_Empleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGV_Datos_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Datos_Empleado.Location = New System.Drawing.Point(36, 98)
        Me.DGV_Datos_Empleado.Name = "DGV_Datos_Empleado"
        Me.DGV_Datos_Empleado.RowHeadersWidth = 62
        Me.DGV_Datos_Empleado.RowTemplate.Height = 28
        Me.DGV_Datos_Empleado.Size = New System.Drawing.Size(973, 346)
        Me.DGV_Datos_Empleado.TabIndex = 4
        '
        'BTN_Update_Empleado
        '
        Me.BTN_Update_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Update_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update_Empleado.Location = New System.Drawing.Point(36, 465)
        Me.BTN_Update_Empleado.Name = "BTN_Update_Empleado"
        Me.BTN_Update_Empleado.Size = New System.Drawing.Size(290, 54)
        Me.BTN_Update_Empleado.TabIndex = 5
        Me.BTN_Update_Empleado.Text = "Actualizar Empleado"
        Me.BTN_Update_Empleado.UseVisualStyleBackColor = True
        '
        'RecursosHumanosDatosEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1041, 614)
        Me.Controls.Add(Me.BTN_Update_Empleado)
        Me.Controls.Add(Me.DGV_Datos_Empleado)
        Me.Controls.Add(Me.CB_Buscar_Por)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Buscar_Empleado)
        Me.Controls.Add(Me.TXT_Buscar)
        Me.Name = "RecursosHumanosDatosEmpleado"
        Me.Text = "DATOS DE EMPLEADO"
        CType(Me.DGV_Datos_Empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Buscar As TextBox
    Friend WithEvents BTN_Buscar_Empleado As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Buscar_Por As ComboBox
    Friend WithEvents DGV_Datos_Empleado As DataGridView
    Friend WithEvents BTN_Update_Empleado As Button
End Class
