<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert
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
        Me.components = New System.ComponentModel.Container()
        Me.T_Duracion_alert = New System.Windows.Forms.Timer(Me.components)
        Me.PB_img = New System.Windows.Forms.PictureBox()
        CType(Me.PB_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_Duracion_alert
        '
        Me.T_Duracion_alert.Interval = 1000
        '
        'PB_img
        '
        Me.PB_img.Location = New System.Drawing.Point(327, 21)
        Me.PB_img.Name = "PB_img"
        Me.PB_img.Size = New System.Drawing.Size(64, 64)
        Me.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_img.TabIndex = 0
        Me.PB_img.TabStop = False
        '
        'Alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PB_img)
        Me.MaximizeBox = False
        Me.Name = "Alert"
        Me.Text = "Alert"
        CType(Me.PB_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_img As PictureBox
    Friend WithEvents T_Duracion_alert As Timer
End Class
