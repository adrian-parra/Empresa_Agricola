<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NombreCom = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_new_password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro"
        '
        'txt_NombreCom
        '
        Me.txt_NombreCom.Location = New System.Drawing.Point(312, 101)
        Me.txt_NombreCom.Name = "txt_NombreCom"
        Me.txt_NombreCom.Size = New System.Drawing.Size(258, 26)
        Me.txt_NombreCom.TabIndex = 2
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(312, 196)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(258, 26)
        Me.txt_user.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(312, 285)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(258, 26)
        Me.txt_password.TabIndex = 4
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(374, 393)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(157, 42)
        Me.btn_registrar.TabIndex = 5
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txt_new_password
        '
        Me.txt_new_password.Location = New System.Drawing.Point(312, 346)
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.Size = New System.Drawing.Size(258, 26)
        Me.txt_new_password.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 562)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.txt_NombreCom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Interf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_NombreCom As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_new_password As TextBox
End Class
