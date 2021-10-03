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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Puesto = New System.Windows.Forms.ComboBox()
        Me.LBL_Codigo = New System.Windows.Forms.Label()
        Me.TXT_Codigo = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombreCom
        '
        Me.txt_nombreCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreCom.Location = New System.Drawing.Point(146, 333)
        Me.txt_nombreCom.Name = "txt_nombreCom"
        Me.txt_nombreCom.Size = New System.Drawing.Size(512, 37)
        Me.txt_nombreCom.TabIndex = 0
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(146, 409)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(512, 37)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(146, 488)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(512, 37)
        Me.txt_pass.TabIndex = 2
        '
        'txt_newpass
        '
        Me.txt_newpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpass.Location = New System.Drawing.Point(146, 566)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.Size = New System.Drawing.Size(512, 37)
        Me.txt_newpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña de nuevo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Empresa_Agricola.My.Resources.Resources.img_registro
        Me.PictureBox1.Location = New System.Drawing.Point(146, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_registrar
        '
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Image = Global.Empresa_Agricola.My.Resources.Resources.img_registro_btn_registrar
        Me.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.Location = New System.Drawing.Point(276, 618)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_registrar.Size = New System.Drawing.Size(209, 62)
        Me.btn_registrar.TabIndex = 4
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 30)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Puesto"
        '
        'CB_Puesto
        '
        Me.CB_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Puesto.FormattingEnabled = True
        Me.CB_Puesto.Items.AddRange(New Object() {"usuario", "gerente"})
        Me.CB_Puesto.Location = New System.Drawing.Point(146, 256)
        Me.CB_Puesto.Name = "CB_Puesto"
        Me.CB_Puesto.Size = New System.Drawing.Size(283, 38)
        Me.CB_Puesto.TabIndex = 11
        '
        'LBL_Codigo
        '
        Me.LBL_Codigo.AutoSize = True
        Me.LBL_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Codigo.Location = New System.Drawing.Point(445, 219)
        Me.LBL_Codigo.Name = "LBL_Codigo"
        Me.LBL_Codigo.Size = New System.Drawing.Size(94, 30)
        Me.LBL_Codigo.TabIndex = 12
        Me.LBL_Codigo.Text = "Codigo"
        '
        'TXT_Codigo
        '
        Me.TXT_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Codigo.Location = New System.Drawing.Point(450, 257)
        Me.TXT_Codigo.MaxLength = 4
        Me.TXT_Codigo.Name = "TXT_Codigo"
        Me.TXT_Codigo.Size = New System.Drawing.Size(208, 37)
        Me.TXT_Codigo.TabIndex = 13
        Me.TXT_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 725)
        Me.Controls.Add(Me.TXT_Codigo)
        Me.Controls.Add(Me.LBL_Codigo)
        Me.Controls.Add(Me.CB_Puesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_newpass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_nombreCom)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombreCom As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_newpass As TextBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_Puesto As ComboBox
    Friend WithEvents LBL_Codigo As Label
    Friend WithEvents TXT_Codigo As TextBox
End Class
