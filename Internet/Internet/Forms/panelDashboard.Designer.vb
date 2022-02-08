<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PanelContainerDashboard = New System.Windows.Forms.Panel()
        Me.ButtonUsers = New System.Windows.Forms.Button()
        Me.ButtonPayments = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelContainerDashboard.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContainerDashboard
        '
        Me.PanelContainerDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PanelContainerDashboard.Controls.Add(Me.Chart1)
        Me.PanelContainerDashboard.Controls.Add(Me.ButtonPayments)
        Me.PanelContainerDashboard.Controls.Add(Me.ButtonUsers)
        Me.PanelContainerDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainerDashboard.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainerDashboard.Name = "PanelContainerDashboard"
        Me.PanelContainerDashboard.Size = New System.Drawing.Size(616, 419)
        Me.PanelContainerDashboard.TabIndex = 0
        '
        'ButtonUsers
        '
        Me.ButtonUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ButtonUsers.FlatAppearance.BorderSize = 0
        Me.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsers.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsers.ForeColor = System.Drawing.Color.White
        Me.ButtonUsers.Location = New System.Drawing.Point(12, 12)
        Me.ButtonUsers.Name = "ButtonUsers"
        Me.ButtonUsers.Size = New System.Drawing.Size(130, 72)
        Me.ButtonUsers.TabIndex = 0
        Me.ButtonUsers.Text = "Users"
        Me.ButtonUsers.UseVisualStyleBackColor = False
        '
        'ButtonPayments
        '
        Me.ButtonPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ButtonPayments.FlatAppearance.BorderSize = 0
        Me.ButtonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPayments.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPayments.ForeColor = System.Drawing.Color.White
        Me.ButtonPayments.Location = New System.Drawing.Point(148, 12)
        Me.ButtonPayments.Name = "ButtonPayments"
        Me.ButtonPayments.Size = New System.Drawing.Size(130, 72)
        Me.ButtonPayments.TabIndex = 1
        Me.ButtonPayments.Text = "Payments"
        Me.ButtonPayments.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(13, 91)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(476, 300)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'panelDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 419)
        Me.Controls.Add(Me.PanelContainerDashboard)
        Me.Name = "panelDashboard"
        Me.Text = "panelDashboard"
        Me.PanelContainerDashboard.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainerDashboard As System.Windows.Forms.Panel
    Friend WithEvents ButtonUsers As System.Windows.Forms.Button
    Friend WithEvents ButtonPayments As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
