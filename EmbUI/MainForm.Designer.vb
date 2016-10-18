<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.sfpMgmtIp_MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpMgmtIP_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sfpMgmtIp_MaskedTextBox
        '
        Me.sfpMgmtIp_MaskedTextBox.Location = New System.Drawing.Point(269, 12)
        Me.sfpMgmtIp_MaskedTextBox.Mask = "990.990.990.990"
        Me.sfpMgmtIp_MaskedTextBox.Name = "sfpMgmtIp_MaskedTextBox"
        Me.sfpMgmtIp_MaskedTextBox.Size = New System.Drawing.Size(89, 20)
        Me.sfpMgmtIp_MaskedTextBox.TabIndex = 0
        '
        'sfpMgmtIP_Label
        '
        Me.sfpMgmtIP_Label.AutoSize = True
        Me.sfpMgmtIP_Label.Location = New System.Drawing.Point(132, 16)
        Me.sfpMgmtIP_Label.Name = "sfpMgmtIP_Label"
        Me.sfpMgmtIP_Label.Size = New System.Drawing.Size(131, 13)
        Me.sfpMgmtIP_Label.TabIndex = 1
        Me.sfpMgmtIP_Label.Text = "Device Control IP Address"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 373)
        Me.Controls.Add(Me.sfpMgmtIP_Label)
        Me.Controls.Add(Me.sfpMgmtIp_MaskedTextBox)
        Me.Name = "MainForm"
        Me.Text = "EmbSFPConfigurator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfpMgmtIp_MaskedTextBox As MaskedTextBox
    Friend WithEvents sfpMgmtIP_Label As Label
End Class
