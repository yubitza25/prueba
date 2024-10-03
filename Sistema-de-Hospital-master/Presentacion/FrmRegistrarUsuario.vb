Public Class FrmRegistrarUsuario
#Region "Personalizar controles"
    Private Sub PersonalizarControles()
        'txtContraseña
        txtContraseña.AutoSize = False
        txtContraseña.Size = New Size(265, 23)
        txtContraseña.UseSystemPasswordChar = True
        'txtConfirmarContraseña
        txtConfirmarContraseña.AutoSize = False
        txtConfirmarContraseña.Size = New Size(265, 23)
        txtConfirmarContraseña.UseSystemPasswordChar = True
    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        PersonalizarControles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

    End Sub
#End Region
End Class