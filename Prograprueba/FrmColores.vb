Public Class FrmColores
    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click

        txtColores.BackColor = Color.Red

    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click

        txtColores.BackColor = Color.Blue

    End Sub

    Private Sub btnAmarillo_Click(sender As Object, e As EventArgs) Handles btnAmarillo.Click

        txtColores.BackColor = Color.Yellow

    End Sub

    Private Sub btnVerde_Click(sender As Object, e As EventArgs) Handles btnVerde.Click

        txtColores.BackColor = Color.Green

    End Sub

    Private Sub btnMorado_Click(sender As Object, e As EventArgs) Handles btnMorado.Click

        txtColores.BackColor = Color.Purple

    End Sub
End Class
