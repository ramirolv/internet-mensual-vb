<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnPago = New System.Windows.Forms.Button()
        Me.PanelCotainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataDataSet = New Internet.dataDataSet()
        Me.DataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Internet.dataDataSetTableAdapters.ClientesTableAdapter()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelCotainer.SuspendLayout()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.Panel1)
        Me.PanelSideMenu.Controls.Add(Me.Button5)
        Me.PanelSideMenu.Controls.Add(Me.Button4)
        Me.PanelSideMenu.Controls.Add(Me.Button3)
        Me.PanelSideMenu.Controls.Add(Me.BtnCliente)
        Me.PanelSideMenu.Controls.Add(Me.BtnPago)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(168, 427)
        Me.PanelSideMenu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 102)
        Me.Panel1.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 264)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 33)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Estados"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(3, 186)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(162, 33)
        Me.BtnCliente.TabIndex = 1
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnPago
        '
        Me.BtnPago.Location = New System.Drawing.Point(3, 147)
        Me.BtnPago.Name = "BtnPago"
        Me.BtnPago.Size = New System.Drawing.Size(162, 33)
        Me.BtnPago.TabIndex = 0
        Me.BtnPago.Text = "Pago"
        Me.BtnPago.UseVisualStyleBackColor = True
        '
        'PanelCotainer
        '
        Me.PanelCotainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelCotainer.Controls.Add(Me.Label1)
        Me.PanelCotainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCotainer.Location = New System.Drawing.Point(168, 0)
        Me.PanelCotainer.Name = "PanelCotainer"
        Me.PanelCotainer.Size = New System.Drawing.Size(552, 427)
        Me.PanelCotainer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 112)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System"
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataDataSetBindingSource
        '
        Me.DataDataSetBindingSource.DataSource = Me.DataDataSet
        Me.DataDataSetBindingSource.Position = 0
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataDataSetBindingSource
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DataDataSetBindingSource
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 427)
        Me.Controls.Add(Me.PanelCotainer)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelCotainer.ResumeLayout(False)
        Me.PanelCotainer.PerformLayout()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSideMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelCotainer As System.Windows.Forms.Panel
    Friend WithEvents BtnPago As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
    Friend WithEvents DataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataDataSet As Internet.dataDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Internet.dataDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
