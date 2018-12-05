<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.btnLoadSchema = New System.Windows.Forms.Button()
        Me.btnLoadData = New System.Windows.Forms.Button()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 112)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowTemplate.Height = 24
        Me.dgvCustomers.Size = New System.Drawing.Size(373, 326)
        Me.dgvCustomers.TabIndex = 0
        '
        'dgvOrders
        '
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(415, 112)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowTemplate.Height = 24
        Me.dgvOrders.Size = New System.Drawing.Size(373, 326)
        Me.dgvOrders.TabIndex = 1
        '
        'btnLoadSchema
        '
        Me.btnLoadSchema.Location = New System.Drawing.Point(132, 45)
        Me.btnLoadSchema.Name = "btnLoadSchema"
        Me.btnLoadSchema.Size = New System.Drawing.Size(155, 43)
        Me.btnLoadSchema.TabIndex = 2
        Me.btnLoadSchema.Text = "Load Schema"
        Me.btnLoadSchema.UseVisualStyleBackColor = True
        '
        'btnLoadData
        '
        Me.btnLoadData.Location = New System.Drawing.Point(530, 45)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(155, 43)
        Me.btnLoadData.TabIndex = 3
        Me.btnLoadData.Text = "Load Data"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnLoadSchema)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnLoadSchema As Button
    Friend WithEvents btnLoadData As Button
End Class
