<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarConsultaDiagnostico
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnGuardar = New Button()
        BtnSalir = New Button()
        TxtPaciente = New TextBox()
        TxtDoctor = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 0
        Label1.Text = "Paciente :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(260, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Doctor :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 2
        Label3.Text = "Consulta"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 3
        Label4.Text = "Diagnostico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "Receta"
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(330, 495)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(75, 23)
        BtnGuardar.TabIndex = 5
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(432, 495)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 6
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' TxtPaciente
        ' 
        TxtPaciente.Location = New Point(82, 30)
        TxtPaciente.Name = "TxtPaciente"
        TxtPaciente.Size = New Size(172, 23)
        TxtPaciente.TabIndex = 7
        ' 
        ' TxtDoctor
        ' 
        TxtDoctor.Location = New Point(315, 30)
        TxtDoctor.Name = "TxtDoctor"
        TxtDoctor.Size = New Size(192, 23)
        TxtDoctor.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(82, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 86)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(82, 222)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(425, 117)
        Panel2.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(82, 383)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(425, 86)
        Panel3.TabIndex = 11
        ' 
        ' FrmAgregarConsultaDiagnostico
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(532, 543)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(TxtDoctor)
        Controls.Add(TxtPaciente)
        Controls.Add(BtnSalir)
        Controls.Add(BtnGuardar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmAgregarConsultaDiagnostico"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmAgregarConsultaDiagnostico"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents TxtDoctor As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
