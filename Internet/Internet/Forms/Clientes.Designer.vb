<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridViewClients = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New Internet.dataDataSet()
        Me.PanelTopFields = New System.Windows.Forms.Panel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDeleteReg = New System.Windows.Forms.Button()
        Me.BtnNewReg = New System.Windows.Forms.Button()
        Me.PanelTable = New System.Windows.Forms.Panel()
        Me.ClientesTableAdapter = New Internet.dataDataSetTableAdapters.ClientesTableAdapter()
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopFields.SuspendLayout()
        Me.PanelTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewClients
        '
        Me.DataGridViewClients.AllowUserToAddRows = False
        Me.DataGridViewClients.AutoGenerateColumns = False
        Me.DataGridViewClients.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DPIDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.DataGridViewClients.DataSource = Me.ClientesBindingSource
        Me.DataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewClients.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewClients.Name = "DataGridViewClients"
        Me.DataGridViewClients.ReadOnly = True
        Me.DataGridViewClients.Size = New System.Drawing.Size(558, 358)
        Me.DataGridViewClients.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DPIDataGridViewTextBoxColumn
        '
        Me.DPIDataGridViewTextBoxColumn.DataPropertyName = "DPI"
        Me.DPIDataGridViewTextBoxColumn.HeaderText = "DPI"
        Me.DPIDataGridViewTextBoxColumn.Name = "DPIDataGridViewTextBoxColumn"
        Me.DPIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataDataSetBindingSource
        '
        'DataDataSetBindingSource
        '
        Me.DataDataSetBindingSource.DataSource = Me.DataDataSet
        Me.DataDataSetBindingSource.Position = 0
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelTopFields
        '
        Me.PanelTopFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelTopFields.Controls.Add(Me.BtnUpdate)
        Me.PanelTopFields.Controls.Add(Me.BtnDeleteReg)
        Me.PanelTopFields.Controls.Add(Me.BtnNewReg)
        Me.PanelTopFields.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopFields.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopFields.Name = "PanelTopFields"
        Me.PanelTopFields.Size = New System.Drawing.Size(558, 42)
        Me.PanelTopFields.TabIndex = 2
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(174, 12)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Modificar"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDeleteReg
        '
        Me.BtnDeleteReg.Location = New System.Drawing.Point(93, 12)
        Me.BtnDeleteReg.Name = "BtnDeleteReg"
        Me.BtnDeleteReg.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteReg.TabIndex = 1
        Me.BtnDeleteReg.Text = "Borrar"
        Me.BtnDeleteReg.UseVisualStyleBackColor = True
        '
        'BtnNewReg
        '
        Me.BtnNewReg.Location = New System.Drawing.Point(12, 12)
        Me.BtnNewReg.Name = "BtnNewReg"
        Me.BtnNewReg.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewReg.TabIndex = 0
        Me.BtnNewReg.Text = "Nuevo"
        Me.BtnNewReg.UseVisualStyleBackColor = True
        '
        'PanelTable
        '
        Me.PanelTable.Controls.Add(Me.DataGridViewClients)
        Me.PanelTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTable.Location = New System.Drawing.Point(0, 42)
        Me.PanelTable.Name = "PanelTable"
        Me.PanelTable.Size = New System.Drawing.Size(558, 358)
        Me.PanelTable.TabIndex = 3
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 400)
        Me.Controls.Add(Me.PanelTable)
        Me.Controls.Add(Me.PanelTopFields)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopFields.ResumeLayout(False)
        Me.PanelTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewClients As System.Windows.Forms.DataGridView
    Friend WithEvents PanelTopFields As System.Windows.Forms.Panel
    Friend WithEvents PanelTable As System.Windows.Forms.Panel
    Friend WithEvents DataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataDataSet As Internet.dataDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Internet.dataDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DPIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnNewReg As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteReg As System.Windows.Forms.Button
End Class
