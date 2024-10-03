Public Class login
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim registrarUsuario As New FrmRegistrarUsuario
        Me.Hide()
        registrarUsuario.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim FormularioPrincipal As New FrmPrincipal
        Me.Hide()
        FormularioPrincipal.ShowDialog()
        Me.Close()
    End Sub
End Class
