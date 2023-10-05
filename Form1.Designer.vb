<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLen = New Button()
        SuspendLayout()
        ' 
        ' btnLen
        ' 
        btnLen.BackColor = SystemColors.ControlDark
        btnLen.ForeColor = Color.Cyan
        btnLen.Location = New Point(309, 146)
        btnLen.Name = "btnLen"
        btnLen.Size = New Size(112, 34)
        btnLen.TabIndex = 0
        btnLen.Text = "Len Function"
        btnLen.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(btnLen)
        Name = "Form1"
        Text = "Len Function"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLen As Button
End Class
