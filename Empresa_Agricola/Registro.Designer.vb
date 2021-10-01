<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.txt_nombreCom = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_newpass = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nombreCom
        '
        Me.txt_nombreCom.Location = New System.Drawing.Point(273, 141)
        Me.txt_nombreCom.Name = "txt_nombreCom"
        Me.txt_nombreCom.Size = New System.Drawing.Size(280, 26)
        Me.txt_nombreCom.TabIndex = 0
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(273, 207)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(280, 26)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(273, 280)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(280, 26)
        Me.txt_pass.TabIndex = 2
        '
        'txt_newpass
        '
        Me.txt_newpass.Location = New System.Drawing.Point(273, 334)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.Size = New System.Drawing.Size(280, 26)
        Me.txt_newpass.TabIndex = 3
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(317, 392)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(236, 46)
        Me.btn_registrar.TabIndex = 4
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 450)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_newpass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_nombreCom)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombreCom As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_newpass As TextBox
    Friend WithEvents btn_registrar As Button
End Class
