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
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.txtIMC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el peso (Kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese la altura (cm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IMC"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(114, 37)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 5
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(114, 8)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 6
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(10, 90)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 7
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(139, 90)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Borrar.TabIndex = 8
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'txtIMC
        '
        Me.txtIMC.AutoSize = True
        Me.txtIMC.Location = New System.Drawing.Point(114, 71)
        Me.txtIMC.Name = "txtIMC"
        Me.txtIMC.Size = New System.Drawing.Size(19, 13)
        Me.txtIMC.TabIndex = 9
        Me.txtIMC.Text = "¿?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 131)
        Me.Controls.Add(Me.txtIMC)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtAltura)
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
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents txtIMC As System.Windows.Forms.Label

End Class
