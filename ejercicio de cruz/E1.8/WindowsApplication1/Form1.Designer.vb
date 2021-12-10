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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Boton = New System.Windows.Forms.Button()
        Me.txtNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtAño = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el año en que nació"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese el año actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Su edad aproximada es: "
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(133, 92)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(19, 13)
        Me.Total.TabIndex = 5
        Me.Total.Text = "¿?"
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(182, 68)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 6
        Me.Boton.Text = "Calcular"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNacimiento.Location = New System.Drawing.Point(157, 12)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtNacimiento.TabIndex = 7
        '
        'txtAño
        '
        Me.txtAño.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtAño.Location = New System.Drawing.Point(157, 42)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 116)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtNacimiento)
        Me.Controls.Add(Me.Boton)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Boton As System.Windows.Forms.Button
    Friend WithEvents txtNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAño As System.Windows.Forms.DateTimePicker

End Class
