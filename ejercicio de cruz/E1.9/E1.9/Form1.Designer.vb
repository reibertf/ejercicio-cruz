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
        Me.txt_Palabra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_CantPalabras = New System.Windows.Forms.Label()
        Me.Violeta = New System.Windows.Forms.ColorDialog()
        Me.Blue = New System.Windows.Forms.ColorDialog()
        Me.Marrón = New System.Windows.Forms.ColorDialog()
        Me.Negro = New System.Windows.Forms.ColorDialog()
        Me.Amarillo = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'txt_Palabra
        '
        Me.txt_Palabra.Location = New System.Drawing.Point(15, 25)
        Me.txt_Palabra.Name = "txt_Palabra"
        Me.txt_Palabra.Size = New System.Drawing.Size(295, 20)
        Me.txt_Palabra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese una cadena de Texto:"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(15, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 96)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cantidad de vocales:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(221, 53)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Alternar Mayúsculas/Minúsculas"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(221, 79)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Negrita"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(221, 102)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Cursiva"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(221, 125)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Normal"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_CantPalabras
        '
        Me.txt_CantPalabras.AutoSize = True
        Me.txt_CantPalabras.Location = New System.Drawing.Point(12, 180)
        Me.txt_CantPalabras.Name = "txt_CantPalabras"
        Me.txt_CantPalabras.Size = New System.Drawing.Size(19, 13)
        Me.txt_CantPalabras.TabIndex = 8
        Me.txt_CantPalabras.Text = "¿?"
        '
        'Violeta
        '
        Me.Violeta.Color = System.Drawing.Color.BlueViolet
        Me.Violeta.FullOpen = True
        '
        'Blue
        '
        Me.Blue.Color = System.Drawing.Color.Blue
        Me.Blue.FullOpen = True
        '
        'Marrón
        '
        Me.Marrón.Color = System.Drawing.Color.Brown
        Me.Marrón.FullOpen = True
        '
        'Negro
        '
        Me.Negro.FullOpen = True
        '
        'Amarillo
        '
        Me.Amarillo.Color = System.Drawing.Color.Yellow
        Me.Amarillo.FullOpen = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 212)
        Me.Controls.Add(Me.txt_CantPalabras)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Palabra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Palabra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_CantPalabras As System.Windows.Forms.Label
    Friend WithEvents Violeta As System.Windows.Forms.ColorDialog
    Friend WithEvents Blue As System.Windows.Forms.ColorDialog
    Friend WithEvents Marrón As System.Windows.Forms.ColorDialog
    Friend WithEvents Negro As System.Windows.Forms.ColorDialog
    Friend WithEvents Amarillo As System.Windows.Forms.ColorDialog

End Class
