<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaCuentasPorCobrar
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
        Me.TXT_Folio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Abono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Abonar = New System.Windows.Forms.Button()
        Me.BTN_Buscar_Adeudo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_Folio
        '
        Me.TXT_Folio.Location = New System.Drawing.Point(12, 118)
        Me.TXT_Folio.Name = "TXT_Folio"
        Me.TXT_Folio.Size = New System.Drawing.Size(224, 26)
        Me.TXT_Folio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio"
        '
        'TXT_Abono
        '
        Me.TXT_Abono.Location = New System.Drawing.Point(12, 202)
        Me.TXT_Abono.Name = "TXT_Abono"
        Me.TXT_Abono.Size = New System.Drawing.Size(224, 26)
        Me.TXT_Abono.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Abono"
        '
        'BTN_Abonar
        '
        Me.BTN_Abonar.Location = New System.Drawing.Point(29, 270)
        Me.BTN_Abonar.Name = "BTN_Abonar"
        Me.BTN_Abonar.Size = New System.Drawing.Size(189, 38)
        Me.BTN_Abonar.TabIndex = 4
        Me.BTN_Abonar.Text = "Abonar"
        Me.BTN_Abonar.UseVisualStyleBackColor = True
        '
        'BTN_Buscar_Adeudo
        '
        Me.BTN_Buscar_Adeudo.Location = New System.Drawing.Point(256, 112)
        Me.BTN_Buscar_Adeudo.Name = "BTN_Buscar_Adeudo"
        Me.BTN_Buscar_Adeudo.Size = New System.Drawing.Size(189, 38)
        Me.BTN_Buscar_Adeudo.TabIndex = 5
        Me.BTN_Buscar_Adeudo.Text = "Buscar"
        Me.BTN_Buscar_Adeudo.UseVisualStyleBackColor = True
        '
        'VentaCuentasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.BTN_Buscar_Adeudo)
        Me.Controls.Add(Me.BTN_Abonar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Abono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Folio)
        Me.Name = "VentaCuentasPorCobrar"
        Me.Text = "VentaCuentasPorCobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Folio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Abono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Abonar As Button
    Friend WithEvents BTN_Buscar_Adeudo As Button
End Class
