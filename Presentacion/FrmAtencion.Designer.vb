<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAtencion
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
        MenuStrip1 = New MenuStrip()
        PacienteToolStripMenuItem = New ToolStripMenuItem()
        VerPacientesToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        AgregarConsultaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {PacienteToolStripMenuItem, ConsultasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(890, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PacienteToolStripMenuItem
        ' 
        PacienteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerPacientesToolStripMenuItem})
        PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        PacienteToolStripMenuItem.Size = New Size(64, 20)
        PacienteToolStripMenuItem.Text = "Paciente"
        ' 
        ' VerPacientesToolStripMenuItem
        ' 
        VerPacientesToolStripMenuItem.Name = "VerPacientesToolStripMenuItem"
        VerPacientesToolStripMenuItem.Size = New Size(180, 22)
        VerPacientesToolStripMenuItem.Text = "Ver Pacientes"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarConsultaToolStripMenuItem})
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(71, 20)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' AgregarConsultaToolStripMenuItem
        ' 
        AgregarConsultaToolStripMenuItem.Name = "AgregarConsultaToolStripMenuItem"
        AgregarConsultaToolStripMenuItem.Size = New Size(180, 22)
        AgregarConsultaToolStripMenuItem.Text = "Agregar Consulta"
        ' 
        ' FrmAtencion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(890, 508)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FrmAtencion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Principal Atencion"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarConsultaToolStripMenuItem As ToolStripMenuItem
End Class
