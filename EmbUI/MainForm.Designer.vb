<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.sfpMgmtIP_Label = New System.Windows.Forms.Label()
        Me.sfpMgmtIp_TextBox = New System.Windows.Forms.TextBox()
        Me.detailPanel = New System.Windows.Forms.Panel()
        Me.statusPanel = New System.Windows.Forms.Panel()
        Me.flow1DroppedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1DroppedLabel = New System.Windows.Forms.Label()
        Me.flow1RenderedLabel = New System.Windows.Forms.Label()
        Me.flow1SeenLabel = New System.Windows.Forms.Label()
        Me.flow1Label = New System.Windows.Forms.Label()
        Me.flow1RenderedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1SeenCounterLabel = New System.Windows.Forms.Label()
        Me.statusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfpMgmtIP_Label
        '
        Me.sfpMgmtIP_Label.AutoSize = True
        Me.sfpMgmtIP_Label.Location = New System.Drawing.Point(121, 15)
        Me.sfpMgmtIP_Label.Name = "sfpMgmtIP_Label"
        Me.sfpMgmtIP_Label.Size = New System.Drawing.Size(131, 13)
        Me.sfpMgmtIP_Label.TabIndex = 1
        Me.sfpMgmtIP_Label.Text = "Device Control IP Address"
        '
        'sfpMgmtIp_TextBox
        '
        Me.sfpMgmtIp_TextBox.Location = New System.Drawing.Point(258, 12)
        Me.sfpMgmtIp_TextBox.Name = "sfpMgmtIp_TextBox"
        Me.sfpMgmtIp_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpMgmtIp_TextBox.TabIndex = 2
        '
        'detailPanel
        '
        Me.detailPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.detailPanel.AutoScroll = True
        Me.detailPanel.Location = New System.Drawing.Point(12, 38)
        Me.detailPanel.Name = "detailPanel"
        Me.detailPanel.Size = New System.Drawing.Size(346, 294)
        Me.detailPanel.TabIndex = 3
        '
        'statusPanel
        '
        Me.statusPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statusPanel.Controls.Add(Me.flow1SeenCounterLabel)
        Me.statusPanel.Controls.Add(Me.flow1RenderedCounterLabel)
        Me.statusPanel.Controls.Add(Me.flow1DroppedCounterLabel)
        Me.statusPanel.Controls.Add(Me.flow1DroppedLabel)
        Me.statusPanel.Controls.Add(Me.flow1RenderedLabel)
        Me.statusPanel.Controls.Add(Me.flow1SeenLabel)
        Me.statusPanel.Controls.Add(Me.flow1Label)
        Me.statusPanel.Location = New System.Drawing.Point(13, 338)
        Me.statusPanel.Name = "statusPanel"
        Me.statusPanel.Size = New System.Drawing.Size(345, 23)
        Me.statusPanel.TabIndex = 4
        '
        'flow1DroppedCounterLabel
        '
        Me.flow1DroppedCounterLabel.AutoSize = True
        Me.flow1DroppedCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1DroppedCounterLabel.Location = New System.Drawing.Point(326, 5)
        Me.flow1DroppedCounterLabel.Name = "flow1DroppedCounterLabel"
        Me.flow1DroppedCounterLabel.Size = New System.Drawing.Size(13, 13)
        Me.flow1DroppedCounterLabel.TabIndex = 4
        Me.flow1DroppedCounterLabel.Text = "0"
        Me.flow1DroppedCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'flow1DroppedLabel
        '
        Me.flow1DroppedLabel.AutoSize = True
        Me.flow1DroppedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1DroppedLabel.Location = New System.Drawing.Point(246, 5)
        Me.flow1DroppedLabel.Name = "flow1DroppedLabel"
        Me.flow1DroppedLabel.Size = New System.Drawing.Size(51, 13)
        Me.flow1DroppedLabel.TabIndex = 3
        Me.flow1DroppedLabel.Text = "Dropped:"
        '
        'flow1RenderedLabel
        '
        Me.flow1RenderedLabel.AutoSize = True
        Me.flow1RenderedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1RenderedLabel.Location = New System.Drawing.Point(142, 5)
        Me.flow1RenderedLabel.Name = "flow1RenderedLabel"
        Me.flow1RenderedLabel.Size = New System.Drawing.Size(57, 13)
        Me.flow1RenderedLabel.TabIndex = 2
        Me.flow1RenderedLabel.Text = "Rendered:"
        '
        'flow1SeenLabel
        '
        Me.flow1SeenLabel.AutoSize = True
        Me.flow1SeenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1SeenLabel.Location = New System.Drawing.Point(47, 5)
        Me.flow1SeenLabel.Name = "flow1SeenLabel"
        Me.flow1SeenLabel.Size = New System.Drawing.Size(35, 13)
        Me.flow1SeenLabel.TabIndex = 1
        Me.flow1SeenLabel.Text = "Seen:"
        '
        'flow1Label
        '
        Me.flow1Label.AutoSize = True
        Me.flow1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1Label.Location = New System.Drawing.Point(3, 5)
        Me.flow1Label.Name = "flow1Label"
        Me.flow1Label.Size = New System.Drawing.Size(44, 13)
        Me.flow1Label.TabIndex = 0
        Me.flow1Label.Text = "Flow 1"
        '
        'flow1RenderedCounterLabel
        '
        Me.flow1RenderedCounterLabel.AutoSize = True
        Me.flow1RenderedCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1RenderedCounterLabel.Location = New System.Drawing.Point(229, 5)
        Me.flow1RenderedCounterLabel.Name = "flow1RenderedCounterLabel"
        Me.flow1RenderedCounterLabel.Size = New System.Drawing.Size(13, 13)
        Me.flow1RenderedCounterLabel.TabIndex = 5
        Me.flow1RenderedCounterLabel.Text = "0"
        Me.flow1RenderedCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'flow1SeenCounterLabel
        '
        Me.flow1SeenCounterLabel.AutoSize = True
        Me.flow1SeenCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1SeenCounterLabel.Location = New System.Drawing.Point(113, 5)
        Me.flow1SeenCounterLabel.Name = "flow1SeenCounterLabel"
        Me.flow1SeenCounterLabel.Size = New System.Drawing.Size(13, 13)
        Me.flow1SeenCounterLabel.TabIndex = 6
        Me.flow1SeenCounterLabel.Text = "0"
        Me.flow1SeenCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 373)
        Me.Controls.Add(Me.statusPanel)
        Me.Controls.Add(Me.detailPanel)
        Me.Controls.Add(Me.sfpMgmtIp_TextBox)
        Me.Controls.Add(Me.sfpMgmtIP_Label)
        Me.Name = "MainForm"
        Me.Text = "EmbSFPConfigurator"
        Me.statusPanel.ResumeLayout(False)
        Me.statusPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sfpMgmtIP_Label As Label
    Friend WithEvents sfpMgmtIp_TextBox As TextBox
    Friend WithEvents detailPanel As Panel
    Friend WithEvents statusPanel As Panel
    Friend WithEvents flow1Label As Label
    Friend WithEvents flow1SeenLabel As Label
    Friend WithEvents flow1DroppedCounterLabel As Label
    Friend WithEvents flow1DroppedLabel As Label
    Friend WithEvents flow1RenderedLabel As Label
    Friend WithEvents flow1SeenCounterLabel As Label
    Friend WithEvents flow1RenderedCounterLabel As Label
End Class
