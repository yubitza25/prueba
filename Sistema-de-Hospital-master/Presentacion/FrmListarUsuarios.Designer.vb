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
        TextBox1 = New TextBox()
        DgTablaUsuarios = New DataGridView()
        Button5 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
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
        ' TextBox1
        ' 
        TextBox1.ForeColor = SystemColors.ActiveCaptionText
        TextBox1.Location = New Point(130, 103)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Ingrese nombre de usuario"
        TextBox1.Size = New Size(343, 34)
        TextBox1.TabIndex = 4
        ' 
        ' DgTablaUsuarios
        ' 
        DgTablaUsuarios.BackgroundColor = SystemColors.ButtonFace
        DgTablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgTablaUsuarios.Location = New Point(73, 162)
        DgTablaUsuarios.Name = "DgTablaUsuarios"
        DgTablaUsuarios.RowHeadersWidth = 51
        DgTablaUsuarios.Size = New Size(596, 239)
        DgTablaUsuarios.TabIndex = 5
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = My.Resources.Resources.buscar1
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Cursor = Cursors.Hand
        Button5.Location = New Point(479, 103)
        Button5.Name = "Button5"
        Button5.Size = New Size(35, 34)
        Button5.TabIndex = 8
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 9
        Label1.Text = "Buscar:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(572, 424)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 44)
        Button1.TabIndex = 10
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(366, 424)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 44)
        Button2.TabIndex = 11
        Button2.Text = "Agregar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(72), CByte(209), CByte(76))
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(469, 424)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 44)
        Button3.TabIndex = 12
        Button3.Text = "Modificar"
        Button3.UseVisualStyleBackColor = False
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
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(DgTablaUsuarios)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Name = "FrmListarUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmListarUsuarios"
        CType(DgTablaUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DgTablaUsuarios As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
End Class
