<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyForm
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
        Me.butMyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butMyButton
        '
        Me.butMyButton.Location = New System.Drawing.Point(86, 40)
        Me.butMyButton.Name = "butMyButton"
        Me.butMyButton.Size = New System.Drawing.Size(75, 23)
        Me.butMyButton.TabIndex = 0
        Me.butMyButton.Text = "My Button"
        Me.butMyButton.UseVisualStyleBackColor = True
        '
        'MyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 102)
        Me.Controls.Add(Me.butMyButton)
        Me.Name = "MyForm"
        Me.Text = "My Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butMyButton As System.Windows.Forms.Button

End Class
