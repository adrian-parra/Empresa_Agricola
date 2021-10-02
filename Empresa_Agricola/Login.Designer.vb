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
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.link_registrar = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(122, 437)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(506, 37)
        Me.txt_password.TabIndex = 4
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(122, 335)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(506, 37)
        Me.txt_user.TabIndex = 3
        '
        'link_registrar
        '
        Me.link_registrar.AutoSize = True
        Me.link_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_registrar.LinkVisited = True
        Me.link_registrar.Location = New System.Drawing.Point(372, 518)
        Me.link_registrar.Name = "link_registrar"
        Me.link_registrar.Size = New System.Drawing.Size(264, 22)
        Me.link_registrar.TabIndex = 6
        Me.link_registrar.TabStop = True
        Me.link_registrar.Text = "No tienes cuenta registrate aqui"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Empresa_Agricola.My.Resources.Resources.img_login
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(506, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar.Image = Global.Empresa_Agricola.My.Resources.Resources.img_login_btn_iniciar
        Me.btn_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_iniciar.Location = New System.Drawing.Point(122, 496)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_iniciar.Size = New System.Drawing.Size(232, 65)
        Me.btn_iniciar.TabIndex = 5
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_iniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(742, 677)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.link_registrar)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_user)
        Me.Name = "Login"
        Me.Text = "Iniciar sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_iniciar As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents link_registrar As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
