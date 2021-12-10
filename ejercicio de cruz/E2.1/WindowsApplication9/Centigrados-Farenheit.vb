Public Class Form1

    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Farenheit.Text = Val(Centigrados.Text * 9 / 5) + 32

    End Sub


End Class
