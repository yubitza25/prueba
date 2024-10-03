<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistrarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblUsuario = New Label()
        LblConfirmarContraseña = New Label()
        LblContraseña = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        txtConfirmarContraseña = New TextBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        CbRol = New ComboBox()
        Label9 = New Label()
        BtnRegistrar = New Button()
        BtnCancelar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(31, 67)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(139, 20)
        LblUsuario.TabIndex = 9
        LblUsuario.Text = "Nombre de Usuario"
        ' 
        ' LblConfirmarContraseña
        ' 
        LblConfirmarContraseña.AutoSize = True
        LblConfirmarContraseña.Location = New Point(31, 208)
        LblConfirmarContraseña.Name = "LblConfirmarContraseña"
        LblConfirmarContraseña.Size = New Size(153, 20)
        LblConfirmarContraseña.TabIndex = 10
        LblConfirmarContraseña.Text = "Confirmar Contraseña"
        ' 
        ' LblContraseña
        ' 
        LblContraseña.AutoSize = True
        LblContraseña.Location = New Point(31, 132)
        LblContraseña.Name = "LblContraseña"
        LblContraseña.Size = New Size(83, 20)
        LblContraseña.TabIndex = 11
        LblContraseña.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(31, 91)
        txtUsuario.Margin = New Padding(3, 4, 3, 4)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(302, 27)
        txtUsuario.TabIndex = 13
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(31, 156)
        txtContraseña.Margin = New Padding(3, 4, 3, 4)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(302, 27)
        txtContraseña.TabIndex = 14
        ' 
        ' txtConfirmarContraseña
        ' 
        txtConfirmarContraseña.Location = New Point(31, 232)
        txtConfirmarContraseña.Margin = New Padding(3, 4, 3, 4)
        txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        txtConfirmarContraseña.Size = New Size(302, 27)
        txtConfirmarContraseña.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(230, 16)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CbRol)
        Panel2.Controls.Add(txtUsuario)
        Panel2.Controls.Add(txtContraseña)
        Panel2.Controls.Add(LblConfirmarContraseña)
        Panel2.Controls.Add(LblContraseña)
        Panel2.Controls.Add(txtConfirmarContraseña)
        Panel2.Controls.Add(LblUsuario)
        Panel2.Location = New Point(112, 192)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(371, 312)
        Panel2.TabIndex = 18
        ' 
        ' CbRol
        ' 
        CbRol.FormattingEnabled = True
        CbRol.Items.AddRange(New Object() {"Medico", "Paciente", "Administrador"})
        CbRol.Location = New Point(33, 22)
        CbRol.Name = "CbRol"
        CbRol.Size = New Size(151, 28)
        CbRol.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        Label9.Location = New Point(173, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(282, 28)
        Label9.TabIndex = 20
        Label9.Text = "Registrar nuevo usuario"
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.BackColor = Color.DarkTurquoise
        BtnRegistrar.FlatStyle = FlatStyle.Flat
        BtnRegistrar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRegistrar.ForeColor = Color.White
        BtnRegistrar.Location = New Point(112, 540)
        BtnRegistrar.Margin = New Padding(3, 4, 3, 4)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(157, 56)
        BtnRegistrar.TabIndex = 21
        BtnRegistrar.Text = "Registrar"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.DarkTurquoise
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(336, 540)
        BtnCancelar.Margin = New Padding(3, 4, 3, 4)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(147, 56)
        BtnCancelar.TabIndex = 22
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' FrmRegistrarUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(603, 703)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnRegistrar)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmRegistrarUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistrarUsuario"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblConfirmarContraseña As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CbRol As ComboBox
End Class
