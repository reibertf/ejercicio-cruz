Public Class Form1

    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim Año As Date = CDate(Me.txtAño.Value)
        Dim Nacimiento As Date = CDate(Me.txtNacimiento.Value)

        Total.Text = CStr(Año.Year - Nacimiento.Year) & " años"
    End Sub
End Class
