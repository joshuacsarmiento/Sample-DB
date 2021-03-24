<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDBDialog
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
        Me.NewDBText = New System.Windows.Forms.TextBox()
        Me.NewDBButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewDBText
        '
        Me.NewDBText.Location = New System.Drawing.Point(84, 40)
        Me.NewDBText.Name = "NewDBText"
        Me.NewDBText.Size = New System.Drawing.Size(100, 23)
        Me.NewDBText.TabIndex = 0
        '
        'NewDBButton
        '
        Me.NewDBButton.Location = New System.Drawing.Point(84, 80)
        Me.NewDBButton.Name = "NewDBButton"
        Me.NewDBButton.Size = New System.Drawing.Size(100, 23)
        Me.NewDBButton.TabIndex = 1
        Me.NewDBButton.Text = "Create New DB"
        Me.NewDBButton.UseVisualStyleBackColor = True
        '
        'NewDBDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 147)
        Me.Controls.Add(Me.NewDBButton)
        Me.Controls.Add(Me.NewDBText)
        Me.Name = "NewDBDialog"
        Me.Text = "New Database Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewDBText As TextBox
    Friend WithEvents NewDBButton As Button
End Class
