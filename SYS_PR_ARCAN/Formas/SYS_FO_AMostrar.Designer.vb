<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS_FO_AMostrar
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
        Me.grdAnimales = New System.Windows.Forms.DataGridView()
        CType(Me.grdAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdAnimales
        '
        Me.grdAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAnimales.Enabled = False
        Me.grdAnimales.Location = New System.Drawing.Point(12, 12)
        Me.grdAnimales.Name = "grdAnimales"
        Me.grdAnimales.RowHeadersVisible = False
        Me.grdAnimales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAnimales.Size = New System.Drawing.Size(245, 206)
        Me.grdAnimales.TabIndex = 0
        '
        'SYS_FO_AMostrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 230)
        Me.Controls.Add(Me.grdAnimales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SYS_FO_AMostrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrar Arca"
        CType(Me.grdAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdAnimales As DataGridView
End Class
