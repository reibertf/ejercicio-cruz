Public Class Form1

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Me.txtAltura.Text = ""
        Me.txtPeso.Text = ""
        Me.txtIMC.Text = ""
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Altura, Peso, IMC As Decimal
        Altura = Val(txtAltura.Text)
        Altura = Math.Round(Altura, 2)

        Peso = Val(txtPeso.Text)
        Peso = Math.Round(Peso, 2)
        IMC = Peso / (Altura / 100) ^ 2
        IMC = Math.Round(IMC, 2)
        If IMC < 18.49 Then
            txtIMC.Text = IMC & " Infrapeso"
        ElseIf IMC > 18.5 And IMC < 24.99 Then
            txtIMC.Text = IMC & " Peso normal"
        ElseIf IMC > 25 And IMC < 29.99 Then
            txtIMC.Text = IMC & " Sobrepeso"
        Else : txtIMC.Text = IMC & " Obeso"
        End If
    End Sub
End Class
