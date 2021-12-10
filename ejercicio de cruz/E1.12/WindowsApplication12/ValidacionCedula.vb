Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton.Click
        If Cedula.Text <= 0 Then
            MsgBox("El valor ingresado no corresponde a una cedula")
        ElseIf Cedula.Text >= 0 Then
            MsgBox("El valor ingresado es valido como cedula")
        End If
    End Sub
End Class
