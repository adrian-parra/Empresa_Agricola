﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DGV_Cuentas_Por_Cobrar = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_Cuentas_Por_Cobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_Folio
        '
        Me.TXT_Folio.Location = New System.Drawing.Point(223, 95)
        Me.TXT_Folio.Name = "TXT_Folio"
        Me.TXT_Folio.Size = New System.Drawing.Size(224, 26)
        Me.TXT_Folio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio"
        '
        'TXT_Abono
        '
        Me.TXT_Abono.Location = New System.Drawing.Point(209, 501)
        Me.TXT_Abono.Name = "TXT_Abono"
        Me.TXT_Abono.Size = New System.Drawing.Size(224, 26)
        Me.TXT_Abono.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Abono"
        '
        'BTN_Abonar
        '
        Me.BTN_Abonar.Location = New System.Drawing.Point(450, 492)
        Me.BTN_Abonar.Name = "BTN_Abonar"
        Me.BTN_Abonar.Size = New System.Drawing.Size(189, 38)
        Me.BTN_Abonar.TabIndex = 4
        Me.BTN_Abonar.Text = "Abonar"
        Me.BTN_Abonar.UseVisualStyleBackColor = True
        '
        'BTN_Buscar_Adeudo
        '
        Me.BTN_Buscar_Adeudo.Location = New System.Drawing.Point(467, 89)
        Me.BTN_Buscar_Adeudo.Name = "BTN_Buscar_Adeudo"
        Me.BTN_Buscar_Adeudo.Size = New System.Drawing.Size(189, 38)
        Me.BTN_Buscar_Adeudo.TabIndex = 5
        Me.BTN_Buscar_Adeudo.Text = "Buscar"
        Me.BTN_Buscar_Adeudo.UseVisualStyleBackColor = True
        '
        'DGV_Cuentas_Por_Cobrar
        '
        Me.DGV_Cuentas_Por_Cobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Cuentas_Por_Cobrar.Location = New System.Drawing.Point(223, 203)
        Me.DGV_Cuentas_Por_Cobrar.Name = "DGV_Cuentas_Por_Cobrar"
        Me.DGV_Cuentas_Por_Cobrar.ReadOnly = True
        Me.DGV_Cuentas_Por_Cobrar.RowHeadersWidth = 62
        Me.DGV_Cuentas_Por_Cobrar.RowTemplate.Height = 28
        Me.DGV_Cuentas_Por_Cobrar.Size = New System.Drawing.Size(409, 193)
        Me.DGV_Cuentas_Por_Cobrar.TabIndex = 8
        '
        'VentaCuentasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 724)
        Me.Controls.Add(Me.DGV_Cuentas_Por_Cobrar)
        Me.Controls.Add(Me.BTN_Buscar_Adeudo)
        Me.Controls.Add(Me.BTN_Abonar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Abono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Folio)
        Me.Name = "VentaCuentasPorCobrar"
        Me.Text = "VentaCuentasPorCobrar"
        CType(Me.DGV_Cuentas_Por_Cobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Folio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Abono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Abonar As Button
    Friend WithEvents BTN_Buscar_Adeudo As Button
    Friend WithEvents DGV_Cuentas_Por_Cobrar As DataGridView
End Class
