<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarUsuarios
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
        Panel1 = New Panel()
        TxtBuscar = New TextBox()
        DgTablaUsuarios = New DataGridView()
        BtnBuscar = New Button()
        LblBuscar = New Label()
        BtnEliminar = New Button()
        BtnAgregar = New Button()
        BtnModificar = New Button()
        Label2 = New Label()
        CType(DgTablaUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(738, 22)
        Panel1.TabIndex = 2
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.ForeColor = SystemColors.ActiveCaptionText
        TxtBuscar.Location = New Point(130, 103)
        TxtBuscar.Multiline = True
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.PlaceholderText = "Ingrese nombre de usuario"
        TxtBuscar.Size = New Size(343, 34)
        TxtBuscar.TabIndex = 4
        ' 
        ' DgTablaUsuarios
        ' 
        DgTablaUsuarios.AllowUserToAddRows = False
        DgTablaUsuarios.AllowUserToDeleteRows = False
        DgTablaUsuarios.BackgroundColor = SystemColors.ButtonFace
        DgTablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgTablaUsuarios.Location = New Point(73, 162)
        DgTablaUsuarios.Name = "DgTablaUsuarios"
        DgTablaUsuarios.ReadOnly = True
        DgTablaUsuarios.RowHeadersWidth = 51
        DgTablaUsuarios.Size = New Size(596, 239)
        DgTablaUsuarios.TabIndex = 5
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackgroundImage = My.Resources.Resources.buscar1
        BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        BtnBuscar.Cursor = Cursors.Hand
        BtnBuscar.Location = New Point(479, 103)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(35, 34)
        BtnBuscar.TabIndex = 8
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' LblBuscar
        ' 
        LblBuscar.AutoSize = True
        LblBuscar.Location = New Point(69, 106)
        LblBuscar.Name = "LblBuscar"
        LblBuscar.Size = New Size(55, 20)
        LblBuscar.TabIndex = 9
        LblBuscar.Text = "Buscar:"
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEliminar.ForeColor = Color.White
        BtnEliminar.Location = New Point(572, 424)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(97, 44)
        BtnEliminar.TabIndex = 10
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        BtnAgregar.Cursor = Cursors.Hand
        BtnAgregar.FlatStyle = FlatStyle.Flat
        BtnAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAgregar.ForeColor = Color.White
        BtnAgregar.Location = New Point(366, 424)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(97, 44)
        BtnAgregar.TabIndex = 11
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' BtnModificar
        ' 
        BtnModificar.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        BtnModificar.Cursor = Cursors.Hand
        BtnModificar.FlatStyle = FlatStyle.Flat
        BtnModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnModificar.ForeColor = Color.White
        BtnModificar.Location = New Point(469, 424)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(97, 44)
        BtnModificar.TabIndex = 12
        BtnModificar.Text = "Modificar"
        BtnModificar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(279, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 23)
        Label2.TabIndex = 13
        Label2.Text = "Lista de usuarios"
        ' 
        ' FrmListarUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(738, 503)
        Controls.Add(Label2)
        Controls.Add(BtnModificar)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(LblBuscar)
        Controls.Add(BtnBuscar)
        Controls.Add(DgTablaUsuarios)
        Controls.Add(TxtBuscar)
        Controls.Add(Panel1)
        Name = "FrmListarUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmListarUsuarios"
        CType(DgTablaUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgTablaUsuarios As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblBuscar As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label2 As Label
End Class
