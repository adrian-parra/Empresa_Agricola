<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subsistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subsistema))
        Me.BTN_Produccion = New System.Windows.Forms.Button()
        Me.BTN_Distribuccion = New System.Windows.Forms.Button()
        Me.BTN_Mantenimiento = New System.Windows.Forms.Button()
        Me.BTN_Recursos_Humanos = New System.Windows.Forms.Button()
        Me.MS_Perfil = New System.Windows.Forms.MenuStrip()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubsistemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_Finanzas = New System.Windows.Forms.Button()
        Me.BTN_Ventas = New System.Windows.Forms.Button()
        Me.BTN_Compras = New System.Windows.Forms.Button()
        Me.BTN_Inventario = New System.Windows.Forms.Button()
        Me.PB_Perfil = New System.Windows.Forms.PictureBox()
        Me.LBL_Nombre = New System.Windows.Forms.Label()
        Me.LBL_Usuario = New System.Windows.Forms.Label()
        Me.LBL_Puesto = New System.Windows.Forms.Label()
        Me.LBL_Nombre_text = New System.Windows.Forms.Label()
        Me.LBL_Usuario_text = New System.Windows.Forms.Label()
        Me.LBL_Puesto_text = New System.Windows.Forms.Label()
        Me.MS_Perfil.SuspendLayout()
        CType(Me.PB_Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Produccion
        '
        Me.BTN_Produccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Produccion.Enabled = False
        Me.BTN_Produccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Produccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Produccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Produccion.Location = New System.Drawing.Point(690, 59)
        Me.BTN_Produccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Produccion.Name = "BTN_Produccion"
        Me.BTN_Produccion.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Produccion.TabIndex = 3
        Me.BTN_Produccion.Text = "Produccion"
        Me.BTN_Produccion.UseVisualStyleBackColor = True
        '
        'BTN_Distribuccion
        '
        Me.BTN_Distribuccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Distribuccion.Enabled = False
        Me.BTN_Distribuccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Distribuccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Distribuccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Distribuccion.Location = New System.Drawing.Point(39, 338)
        Me.BTN_Distribuccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Distribuccion.Name = "BTN_Distribuccion"
        Me.BTN_Distribuccion.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Distribuccion.TabIndex = 4
        Me.BTN_Distribuccion.Text = "Distribuccion"
        Me.BTN_Distribuccion.UseVisualStyleBackColor = True
        '
        'BTN_Mantenimiento
        '
        Me.BTN_Mantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Mantenimiento.Enabled = False
        Me.BTN_Mantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Mantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Mantenimiento.Location = New System.Drawing.Point(466, 338)
        Me.BTN_Mantenimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Mantenimiento.Name = "BTN_Mantenimiento"
        Me.BTN_Mantenimiento.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Mantenimiento.TabIndex = 6
        Me.BTN_Mantenimiento.Text = "Mantenimiento"
        Me.BTN_Mantenimiento.UseVisualStyleBackColor = True
        '
        'BTN_Recursos_Humanos
        '
        Me.BTN_Recursos_Humanos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Recursos_Humanos.Enabled = False
        Me.BTN_Recursos_Humanos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Recursos_Humanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Recursos_Humanos.Location = New System.Drawing.Point(690, 338)
        Me.BTN_Recursos_Humanos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Recursos_Humanos.Name = "BTN_Recursos_Humanos"
        Me.BTN_Recursos_Humanos.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Recursos_Humanos.TabIndex = 7
        Me.BTN_Recursos_Humanos.Text = "Recursos humanos"
        Me.BTN_Recursos_Humanos.UseVisualStyleBackColor = True
        '
        'MS_Perfil
        '
        Me.MS_Perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MS_Perfil.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MS_Perfil.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MS_Perfil.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem})
        Me.MS_Perfil.Location = New System.Drawing.Point(0, 0)
        Me.MS_Perfil.Name = "MS_Perfil"
        Me.MS_Perfil.Size = New System.Drawing.Size(900, 38)
        Me.MS_Perfil.TabIndex = 8
        Me.MS_Perfil.Text = "Opciones"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.InformacionToolStripMenuItem, Me.SubsistemasToolStripMenuItem})
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(77, 34)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_cerrar_sesion
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_perfil_info
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'SubsistemasToolStripMenuItem
        '
        Me.SubsistemasToolStripMenuItem.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_subsistemas
        Me.SubsistemasToolStripMenuItem.Name = "SubsistemasToolStripMenuItem"
        Me.SubsistemasToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.SubsistemasToolStripMenuItem.Text = "Subsistemas"
        '
        'BTN_Finanzas
        '
        Me.BTN_Finanzas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Finanzas.Enabled = False
        Me.BTN_Finanzas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Finanzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Finanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Finanzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Finanzas.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_finanzas
        Me.BTN_Finanzas.Location = New System.Drawing.Point(255, 338)
        Me.BTN_Finanzas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Finanzas.Name = "BTN_Finanzas"
        Me.BTN_Finanzas.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Finanzas.TabIndex = 5
        Me.BTN_Finanzas.Text = "Finanzas"
        Me.BTN_Finanzas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_Finanzas.UseVisualStyleBackColor = True
        '
        'BTN_Ventas
        '
        Me.BTN_Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Ventas.Enabled = False
        Me.BTN_Ventas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Ventas.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_venta
        Me.BTN_Ventas.Location = New System.Drawing.Point(466, 59)
        Me.BTN_Ventas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Ventas.Name = "BTN_Ventas"
        Me.BTN_Ventas.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Ventas.TabIndex = 2
        Me.BTN_Ventas.Text = "Ventas"
        Me.BTN_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_Ventas.UseVisualStyleBackColor = True
        '
        'BTN_Compras
        '
        Me.BTN_Compras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Compras.Enabled = False
        Me.BTN_Compras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Compras.Image = Global.Empresa_Agricola.My.Resources.Resources.img_subsistemas_compras
        Me.BTN_Compras.Location = New System.Drawing.Point(255, 59)
        Me.BTN_Compras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Compras.Name = "BTN_Compras"
        Me.BTN_Compras.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Compras.TabIndex = 1
        Me.BTN_Compras.Text = "Compras"
        Me.BTN_Compras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_Compras.UseVisualStyleBackColor = True
        '
        'BTN_Inventario
        '
        Me.BTN_Inventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Inventario.Enabled = False
        Me.BTN_Inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Inventario.Image = Global.Empresa_Agricola.My.Resources.Resources.img_Subsistemas_Inventario
        Me.BTN_Inventario.Location = New System.Drawing.Point(39, 59)
        Me.BTN_Inventario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Inventario.Name = "BTN_Inventario"
        Me.BTN_Inventario.Size = New System.Drawing.Size(169, 188)
        Me.BTN_Inventario.TabIndex = 0
        Me.BTN_Inventario.Text = "Inventario"
        Me.BTN_Inventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_Inventario.UseVisualStyleBackColor = True
        '
        'PB_Perfil
        '
        Me.PB_Perfil.Image = Global.Empresa_Agricola.My.Resources.Resources.img_login
        Me.PB_Perfil.Location = New System.Drawing.Point(266, 41)
        Me.PB_Perfil.Name = "PB_Perfil"
        Me.PB_Perfil.Size = New System.Drawing.Size(343, 249)
        Me.PB_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Perfil.TabIndex = 9
        Me.PB_Perfil.TabStop = False
        '
        'LBL_Nombre
        '
        Me.LBL_Nombre.AutoSize = True
        Me.LBL_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nombre.Location = New System.Drawing.Point(381, 308)
        Me.LBL_Nombre.Name = "LBL_Nombre"
        Me.LBL_Nombre.Size = New System.Drawing.Size(96, 26)
        Me.LBL_Nombre.TabIndex = 10
        Me.LBL_Nombre.Text = "Nombre:"
        '
        'LBL_Usuario
        '
        Me.LBL_Usuario.AutoSize = True
        Me.LBL_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Usuario.Location = New System.Drawing.Point(381, 370)
        Me.LBL_Usuario.Name = "LBL_Usuario"
        Me.LBL_Usuario.Size = New System.Drawing.Size(93, 26)
        Me.LBL_Usuario.TabIndex = 11
        Me.LBL_Usuario.Text = "Usuario:"
        '
        'LBL_Puesto
        '
        Me.LBL_Puesto.AutoSize = True
        Me.LBL_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Puesto.Location = New System.Drawing.Point(381, 452)
        Me.LBL_Puesto.Name = "LBL_Puesto"
        Me.LBL_Puesto.Size = New System.Drawing.Size(86, 26)
        Me.LBL_Puesto.TabIndex = 12
        Me.LBL_Puesto.Text = "Puesto:"
        '
        'LBL_Nombre_text
        '
        Me.LBL_Nombre_text.AutoSize = True
        Me.LBL_Nombre_text.Location = New System.Drawing.Point(262, 347)
        Me.LBL_Nombre_text.Name = "LBL_Nombre_text"
        Me.LBL_Nombre_text.Size = New System.Drawing.Size(57, 20)
        Me.LBL_Nombre_text.TabIndex = 13
        Me.LBL_Nombre_text.Text = "Label1"
        '
        'LBL_Usuario_text
        '
        Me.LBL_Usuario_text.AutoSize = True
        Me.LBL_Usuario_text.Location = New System.Drawing.Point(262, 407)
        Me.LBL_Usuario_text.Name = "LBL_Usuario_text"
        Me.LBL_Usuario_text.Size = New System.Drawing.Size(57, 20)
        Me.LBL_Usuario_text.TabIndex = 14
        Me.LBL_Usuario_text.Text = "Label1"
        '
        'LBL_Puesto_text
        '
        Me.LBL_Puesto_text.AutoSize = True
        Me.LBL_Puesto_text.Location = New System.Drawing.Point(262, 500)
        Me.LBL_Puesto_text.Name = "LBL_Puesto_text"
        Me.LBL_Puesto_text.Size = New System.Drawing.Size(57, 20)
        Me.LBL_Puesto_text.TabIndex = 15
        Me.LBL_Puesto_text.Text = "Label1"
        '
        'Subsistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.LBL_Puesto_text)
        Me.Controls.Add(Me.LBL_Usuario_text)
        Me.Controls.Add(Me.LBL_Nombre_text)
        Me.Controls.Add(Me.LBL_Puesto)
        Me.Controls.Add(Me.LBL_Usuario)
        Me.Controls.Add(Me.LBL_Nombre)
        Me.Controls.Add(Me.PB_Perfil)
        Me.Controls.Add(Me.BTN_Recursos_Humanos)
        Me.Controls.Add(Me.BTN_Mantenimiento)
        Me.Controls.Add(Me.BTN_Finanzas)
        Me.Controls.Add(Me.BTN_Distribuccion)
        Me.Controls.Add(Me.BTN_Produccion)
        Me.Controls.Add(Me.BTN_Ventas)
        Me.Controls.Add(Me.BTN_Compras)
        Me.Controls.Add(Me.BTN_Inventario)
        Me.Controls.Add(Me.MS_Perfil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MS_Perfil
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Subsistema"
        Me.Text = "INICIO"
        Me.MS_Perfil.ResumeLayout(False)
        Me.MS_Perfil.PerformLayout()
        CType(Me.PB_Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Inventario As Button
    Friend WithEvents BTN_Compras As Button
    Friend WithEvents BTN_Ventas As Button
    Friend WithEvents BTN_Produccion As Button
    Friend WithEvents BTN_Distribuccion As Button
    Friend WithEvents BTN_Finanzas As Button
    Friend WithEvents BTN_Mantenimiento As Button
    Friend WithEvents BTN_Recursos_Humanos As Button
    Friend WithEvents MS_Perfil As MenuStrip
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PB_Perfil As PictureBox
    Friend WithEvents LBL_Nombre As Label
    Friend WithEvents LBL_Usuario As Label
    Friend WithEvents LBL_Puesto As Label
    Friend WithEvents LBL_Nombre_text As Label
    Friend WithEvents LBL_Usuario_text As Label
    Friend WithEvents LBL_Puesto_text As Label
    Friend WithEvents SubsistemasToolStripMenuItem As ToolStripMenuItem
End Class
