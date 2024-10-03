<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCita
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
        CbTipoBusqueda = New ComboBox()
        TxtBusqueda = New TextBox()
        LblNombre = New Label()
        BtnBuscar = New Button()
        DGVListaCitas = New DataGridView()
        Col3 = New DataGridViewTextBoxColumn()
        Col4 = New DataGridViewTextBoxColumn()
        Col6 = New DataGridViewTextBoxColumn()
        Col5 = New DataGridViewTextBoxColumn()
        Acciones = New DataGridViewTextBoxColumn()
        BtnCancelar = New Button()
        BtnProgramar = New Button()
        CType(DGVListaCitas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(220, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 32)
        Label1.TabIndex = 0
        Label1.Text = "ENCONTRAR CITAS"
        ' 
        ' CbTipoBusqueda
        ' 
        CbTipoBusqueda.BackColor = SystemColors.MenuBar
        CbTipoBusqueda.FormattingEnabled = True
        CbTipoBusqueda.Location = New Point(37, 94)
        CbTipoBusqueda.Name = "CbTipoBusqueda"
        CbTipoBusqueda.Size = New Size(144, 23)
        CbTipoBusqueda.TabIndex = 16
        ' 
        ' TxtBusqueda
        ' 
        TxtBusqueda.BackColor = SystemColors.HighlightText
        TxtBusqueda.ForeColor = Color.White
        TxtBusqueda.Location = New Point(200, 94)
        TxtBusqueda.Multiline = True
        TxtBusqueda.Name = "TxtBusqueda"
        TxtBusqueda.PlaceholderText = "Ingrese nombre"
        TxtBusqueda.Size = New Size(224, 22)
        TxtBusqueda.TabIndex = 18
        ' 
        ' LblNombre
        ' 
        LblNombre.AutoSize = True
        LblNombre.BackColor = Color.Transparent
        LblNombre.Location = New Point(37, 68)
        LblNombre.Name = "LblNombre"
        LblNombre.Size = New Size(58, 15)
        LblNombre.TabIndex = 17
        LblNombre.Text = "Categoria"
        LblNombre.TextAlign = ContentAlignment.TopCenter
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.White
        BtnBuscar.FlatStyle = FlatStyle.Popup
        BtnBuscar.Font = New Font("Segoe UI", 10F)
        BtnBuscar.Location = New Point(555, 94)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(75, 21)
        BtnBuscar.TabIndex = 20
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' DGVListaCitas
        ' 
        DGVListaCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaCitas.Columns.AddRange(New DataGridViewColumn() {Col3, Col4, Col6, Col5, Acciones})
        DGVListaCitas.Location = New Point(37, 154)
        DGVListaCitas.Name = "DGVListaCitas"
        DGVListaCitas.RowHeadersWidth = 51
        DGVListaCitas.Size = New Size(593, 137)
        DGVListaCitas.TabIndex = 46
        ' 
        ' Col3
        ' 
        Col3.HeaderText = "Nombre"
        Col3.MinimumWidth = 6
        Col3.Name = "Col3"
        Col3.Width = 125
        ' 
        ' Col4
        ' 
        Col4.HeaderText = "DNI"
        Col4.MinimumWidth = 6
        Col4.Name = "Col4"
        Col4.Width = 125
        ' 
        ' Col6
        ' 
        Col6.HeaderText = "Doctor"
        Col6.MinimumWidth = 6
        Col6.Name = "Col6"
        Col6.Width = 125
        ' 
        ' Col5
        ' 
        Col5.HeaderText = "Fecha"
        Col5.MinimumWidth = 6
        Col5.Name = "Col5"
        Col5.Width = 125
        ' 
        ' Acciones
        ' 
        Acciones.HeaderText = "Hora"
        Acciones.MinimumWidth = 6
        Acciones.Name = "Acciones"
        Acciones.Width = 125
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.White
        BtnCancelar.FlatStyle = FlatStyle.Popup
        BtnCancelar.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancelar.Location = New Point(37, 310)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(122, 33)
        BtnCancelar.TabIndex = 47
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnProgramar
        ' 
        BtnProgramar.BackColor = Color.White
        BtnProgramar.FlatStyle = FlatStyle.Popup
        BtnProgramar.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnProgramar.Location = New Point(471, 310)
        BtnProgramar.Name = "BtnProgramar"
        BtnProgramar.Size = New Size(159, 33)
        BtnProgramar.TabIndex = 48
        BtnProgramar.Text = "Programar"
        BtnProgramar.UseVisualStyleBackColor = False
        ' 
        ' BuscarCita
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(677, 369)
        Controls.Add(BtnProgramar)
        Controls.Add(BtnCancelar)
        Controls.Add(DGVListaCitas)
        Controls.Add(BtnBuscar)
        Controls.Add(TxtBusqueda)
        Controls.Add(LblNombre)
        Controls.Add(CbTipoBusqueda)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "BuscarCita"
        Text = "BuscarCita"
        CType(DGVListaCitas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbTipoBusqueda As ComboBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DGVListaCitas As DataGridView
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
    Friend WithEvents Col6 As DataGridViewTextBoxColumn
    Friend WithEvents Col5 As DataGridViewTextBoxColumn
    Friend WithEvents Acciones As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnProgramar As Button
End Class
