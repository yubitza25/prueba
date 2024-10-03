<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        MenuStrip1 = New MenuStrip()
        CitasToolStripMenuItem = New ToolStripMenuItem()
        RegistrarCitaToolStripMenuItem = New ToolStripMenuItem()
        EspecialidadesToolStripMenuItem = New ToolStripMenuItem()
        RegistrarEspecialidadToolStripMenuItem = New ToolStripMenuItem()
        ListarEspecialidadesToolStripMenuItem = New ToolStripMenuItem()
        AtencionToolStripMenuItem = New ToolStripMenuItem()
        RegistrarAtencionToolStripMenuItem = New ToolStripMenuItem()
        ListarAtencionToolStripMenuItem = New ToolStripMenuItem()
        MedicosToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        ListarUsuariosToolStripMenuItem = New ToolStripMenuItem()
        PacientesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AccessibleRole = AccessibleRole.Cursor
        MenuStrip1.BackColor = Color.Azure
        MenuStrip1.Font = New Font("Goudy Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(60, 60)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CitasToolStripMenuItem, EspecialidadesToolStripMenuItem, AtencionToolStripMenuItem, MedicosToolStripMenuItem, UsuariosToolStripMenuItem, PacientesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1042, 68)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CitasToolStripMenuItem
        ' 
        CitasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrarCitaToolStripMenuItem})
        CitasToolStripMenuItem.Image = My.Resources.Resources.WhatsApp_Image_2024_09_22_at_1_31_36_AM
        CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        CitasToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.M
        CitasToolStripMenuItem.Size = New Size(140, 64)
        CitasToolStripMenuItem.Text = "Citas"
        ' 
        ' RegistrarCitaToolStripMenuItem
        ' 
        RegistrarCitaToolStripMenuItem.Name = "RegistrarCitaToolStripMenuItem"
        RegistrarCitaToolStripMenuItem.Size = New Size(233, 36)
        RegistrarCitaToolStripMenuItem.Text = "Registrar Cita"
        ' 
        ' EspecialidadesToolStripMenuItem
        ' 
        EspecialidadesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrarEspecialidadToolStripMenuItem, ListarEspecialidadesToolStripMenuItem})
        EspecialidadesToolStripMenuItem.Image = CType(resources.GetObject("EspecialidadesToolStripMenuItem.Image"), Image)
        EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        EspecialidadesToolStripMenuItem.Size = New Size(238, 64)
        EspecialidadesToolStripMenuItem.Text = "Especialidades"
        ' 
        ' RegistrarEspecialidadToolStripMenuItem
        ' 
        RegistrarEspecialidadToolStripMenuItem.Name = "RegistrarEspecialidadToolStripMenuItem"
        RegistrarEspecialidadToolStripMenuItem.Size = New Size(320, 36)
        RegistrarEspecialidadToolStripMenuItem.Text = "Registrar Especialidad"
        ' 
        ' ListarEspecialidadesToolStripMenuItem
        ' 
        ListarEspecialidadesToolStripMenuItem.Name = "ListarEspecialidadesToolStripMenuItem"
        ListarEspecialidadesToolStripMenuItem.Size = New Size(320, 36)
        ListarEspecialidadesToolStripMenuItem.Text = "Listar Especialidades"
        ' 
        ' AtencionToolStripMenuItem
        ' 
        AtencionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrarAtencionToolStripMenuItem, ListarAtencionToolStripMenuItem})
        AtencionToolStripMenuItem.Image = My.Resources.Resources.counter_3492400
        AtencionToolStripMenuItem.Name = "AtencionToolStripMenuItem"
        AtencionToolStripMenuItem.Size = New Size(185, 64)
        AtencionToolStripMenuItem.Text = "Atencion"
        ' 
        ' RegistrarAtencionToolStripMenuItem
        ' 
        RegistrarAtencionToolStripMenuItem.Name = "RegistrarAtencionToolStripMenuItem"
        RegistrarAtencionToolStripMenuItem.Size = New Size(287, 36)
        RegistrarAtencionToolStripMenuItem.Text = "Registrar Atencion"
        ' 
        ' ListarAtencionToolStripMenuItem
        ' 
        ListarAtencionToolStripMenuItem.Name = "ListarAtencionToolStripMenuItem"
        ListarAtencionToolStripMenuItem.Size = New Size(287, 36)
        ListarAtencionToolStripMenuItem.Text = "Listar Atencion"
        ' 
        ' MedicosToolStripMenuItem
        ' 
        MedicosToolStripMenuItem.Image = My.Resources.Resources.medical_team_4807695
        MedicosToolStripMenuItem.Name = "MedicosToolStripMenuItem"
        MedicosToolStripMenuItem.Size = New Size(175, 64)
        MedicosToolStripMenuItem.Text = "Medicos"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListarUsuariosToolStripMenuItem})
        UsuariosToolStripMenuItem.Image = My.Resources.Resources.join_12366447
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(180, 64)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' ListarUsuariosToolStripMenuItem
        ' 
        ListarUsuariosToolStripMenuItem.Name = "ListarUsuariosToolStripMenuItem"
        ListarUsuariosToolStripMenuItem.Size = New Size(248, 36)
        ListarUsuariosToolStripMenuItem.Text = "Listar Usuarios"
        ' 
        ' PacientesToolStripMenuItem
        ' 
        PacientesToolStripMenuItem.Image = My.Resources.Resources.patient_8997523
        PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        PacientesToolStripMenuItem.Size = New Size(183, 64)
        PacientesToolStripMenuItem.Text = "Pacientes"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vecteezy_blur_hospital_background_2783362
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1042, 559)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmPrincipal"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarCitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarEspecialidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarEspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarAtencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarAtencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
End Class
