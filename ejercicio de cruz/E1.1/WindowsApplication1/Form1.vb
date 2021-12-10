Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double
        Dim b As Integer
        Dim h As Integer
        b = Val(Me.b.Text)
        h = Val(Me.h.Text)
        a = ((b * h) / 2)
        Me.a.Text = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.h.Text = ""
        Me.b.Text = ""
        Me.a.Text = ""
    End Sub
End Class
