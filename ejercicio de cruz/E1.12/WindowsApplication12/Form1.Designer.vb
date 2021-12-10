<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Boton = New System.Windows.Forms.Button()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(205, 9)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "Ok"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(99, 9)
        Me.Cedula.MaxLength = 1000000000
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(100, 20)
        Me.Cedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Cedula:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 36)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boton As System.Windows.Forms.Button
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
