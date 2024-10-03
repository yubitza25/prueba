<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarConsulta
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
        MonthCalendar1 = New MonthCalendar()
        DataGridView1 = New DataGridView()
        CBoxLunes = New CheckBox()
        CBoxMartes = New CheckBox()
        CBoxMiercoles = New CheckBox()
        CBoxJueves = New CheckBox()
        CBoxViernes = New CheckBox()
        CBoxSabado = New CheckBox()
        CBoxDomingo = New CheckBox()
        BtnNuevo = New Button()
        BtnSeleccionar = New Button()
        BtnSalir = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 0
        Label1.Text = "Dias Disponibles :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(388, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(266, 15)
        Label2.TabIndex = 1
        Label2.Text = "Seleccione la hora de la cita en la tabla de horario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 30)
        Label3.TabIndex = 2
        Label3.Text = "Seleccione la fecha de la cita en los días " & vbCrLf & "disponibles del medico"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(49, 194)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(388, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(535, 388)
        DataGridView1.TabIndex = 4
        ' 
        ' CBoxLunes
        ' 
        CBoxLunes.AutoSize = True
        CBoxLunes.Location = New Point(127, 34)
        CBoxLunes.Name = "CBoxLunes"
        CBoxLunes.Size = New Size(32, 19)
        CBoxLunes.TabIndex = 12
        CBoxLunes.Text = "L"
        CBoxLunes.UseVisualStyleBackColor = True
        ' 
        ' CBoxMartes
        ' 
        CBoxMartes.AutoSize = True
        CBoxMartes.Location = New Point(160, 34)
        CBoxMartes.Name = "CBoxMartes"
        CBoxMartes.Size = New Size(37, 19)
        CBoxMartes.TabIndex = 13
        CBoxMartes.Text = "M"
        CBoxMartes.UseVisualStyleBackColor = True
        ' 
        ' CBoxMiercoles
        ' 
        CBoxMiercoles.AutoSize = True
        CBoxMiercoles.Location = New Point(203, 34)
        CBoxMiercoles.Name = "CBoxMiercoles"
        CBoxMiercoles.Size = New Size(37, 19)
        CBoxMiercoles.TabIndex = 14
        CBoxMiercoles.Text = "M"
        CBoxMiercoles.UseVisualStyleBackColor = True
        ' 
        ' CBoxJueves
        ' 
        CBoxJueves.AutoSize = True
        CBoxJueves.Location = New Point(240, 34)
        CBoxJueves.Name = "CBoxJueves"
        CBoxJueves.Size = New Size(30, 19)
        CBoxJueves.TabIndex = 15
        CBoxJueves.Text = "J"
        CBoxJueves.UseVisualStyleBackColor = True
        ' 
        ' CBoxViernes
        ' 
        CBoxViernes.AutoSize = True
        CBoxViernes.Location = New Point(274, 34)
        CBoxViernes.Name = "CBoxViernes"
        CBoxViernes.Size = New Size(33, 19)
        CBoxViernes.TabIndex = 16
        CBoxViernes.Text = "V"
        CBoxViernes.UseVisualStyleBackColor = True
        ' 
        ' CBoxSabado
        ' 
        CBoxSabado.AutoSize = True
        CBoxSabado.Location = New Point(304, 34)
        CBoxSabado.Name = "CBoxSabado"
        CBoxSabado.Size = New Size(32, 19)
        CBoxSabado.TabIndex = 17
        CBoxSabado.Text = "S"
        CBoxSabado.UseVisualStyleBackColor = True
        ' 
        ' CBoxDomingo
        ' 
        CBoxDomingo.AutoSize = True
        CBoxDomingo.Location = New Point(333, 34)
        CBoxDomingo.Name = "CBoxDomingo"
        CBoxDomingo.Size = New Size(34, 19)
        CBoxDomingo.TabIndex = 18
        CBoxDomingo.Text = "D"
        CBoxDomingo.UseVisualStyleBackColor = True
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.Location = New Point(657, 487)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(75, 23)
        BtnNuevo.TabIndex = 19
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = True
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.Location = New Point(755, 487)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(75, 23)
        BtnSeleccionar.TabIndex = 20
        BtnSeleccionar.Text = "Seleccionar"
        BtnSeleccionar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(848, 487)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 21
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarConsulta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(949, 551)
        Controls.Add(BtnSalir)
        Controls.Add(BtnSeleccionar)
        Controls.Add(BtnNuevo)
        Controls.Add(CBoxDomingo)
        Controls.Add(CBoxSabado)
        Controls.Add(CBoxViernes)
        Controls.Add(CBoxJueves)
        Controls.Add(CBoxMiercoles)
        Controls.Add(CBoxMartes)
        Controls.Add(CBoxLunes)
        Controls.Add(DataGridView1)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmAgregarConsulta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Consulta"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CBoxLunes As CheckBox
    Friend WithEvents CBoxMartes As CheckBox
    Friend WithEvents CBoxMiercoles As CheckBox
    Friend WithEvents CBoxJueves As CheckBox
    Friend WithEvents CBoxViernes As CheckBox
    Friend WithEvents CBoxSabado As CheckBox
    Friend WithEvents CBoxDomingo As CheckBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents BtnSalir As Button
End Class
