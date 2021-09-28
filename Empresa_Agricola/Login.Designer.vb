<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.link_registrar = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(280, 345)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(255, 36)
        Me.btn_iniciar.TabIndex = 5
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(209, 269)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(419, 26)
        Me.txt_password.TabIndex = 4
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(209, 167)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(419, 26)
        Me.txt_user.TabIndex = 3
        '
        'link_registrar
        '
        Me.link_registrar.AutoSize = True
        Me.link_registrar.Location = New System.Drawing.Point(562, 353)
        Me.link_registrar.Name = "link_registrar"
        Me.link_registrar.Size = New System.Drawing.Size(234, 20)
        Me.link_registrar.TabIndex = 6
        Me.link_registrar.TabStop = True
        Me.link_registrar.Text = "No tienes cuenta registrate aqui"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 627)
        Me.Controls.Add(Me.link_registrar)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_user)
        Me.Name = "Login"
        Me.Text = "Iniciar sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_iniciar As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents link_registrar As LinkLabel
End Class
