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
        Me.components = New System.ComponentModel.Container()
        Me.sfpMgmtIPLabel = New System.Windows.Forms.Label()
        Me.sfpMgmtIpTextBox = New System.Windows.Forms.TextBox()
        Me.detailPanel = New System.Windows.Forms.Panel()
        Me.sfpFormattingPanel = New System.Windows.Forms.Panel()
        Me.sfpFormatCodeSamplingLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeSamplingLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeRateLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeRateLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeFormatLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeFormatLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodePScanLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodePScanLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeTScanLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeTScanLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeModeLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeModeLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeValidLabel = New System.Windows.Forms.Label()
        Me.sfpFormatCodeValidLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatClkRateLabel = New System.Windows.Forms.Label()
        Me.sfpFormatLineLabel = New System.Windows.Forms.Label()
        Me.sfpFormatClkRateLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFormatLabel = New System.Windows.Forms.Label()
        Me.sfpFormatButton = New System.Windows.Forms.Button()
        Me.sfpFlowPortMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpFlowIPMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpAdvancedPanel = New System.Windows.Forms.Panel()
        Me.sfpFlowSsrcMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpFlowSsrcLabel = New System.Windows.Forms.Label()
        Me.sfpVlanTagMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpVlanTagLabel = New System.Windows.Forms.Label()
        Me.sfpFlowSrcPortMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpFlowSrcIpMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpFlowDstMacMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.sfpFlowDstMacLabel = New System.Windows.Forms.Label()
        Me.sfpFlowSrcPortLabel = New System.Windows.Forms.Label()
        Me.sfpFlowSrcIpLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedLineLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedButton = New System.Windows.Forms.Button()
        Me.sfpFlowPortLabelLabel = New System.Windows.Forms.Label()
        Me.sfpFlowIpLabelLabel = New System.Windows.Forms.Label()
        Me.sfpTypeLabel = New System.Windows.Forms.Label()
        Me.sfpTypeLabelLabel = New System.Windows.Forms.Label()
        Me.sfpNameLabel = New System.Windows.Forms.Label()
        Me.sfpNameLabelLabel = New System.Windows.Forms.Label()
        Me.statusPanel = New System.Windows.Forms.Panel()
        Me.flow1SeenCounterLabel = New System.Windows.Forms.Label()
        Me.flow1RenderedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1DroppedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1DroppedLabel = New System.Windows.Forms.Label()
        Me.flow1RenderedLabel = New System.Windows.Forms.Label()
        Me.flow1SeenLabel = New System.Windows.Forms.Label()
        Me.flow1Label = New System.Windows.Forms.Label()
        Me.sfpFlowDetailToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfpConnectButton = New System.Windows.Forms.Button()
        Me.detailPanel.SuspendLayout()
        Me.sfpFormattingPanel.SuspendLayout()
        Me.sfpAdvancedPanel.SuspendLayout()
        Me.statusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfpMgmtIPLabel
        '
        Me.sfpMgmtIPLabel.AutoSize = True
        Me.sfpMgmtIPLabel.Location = New System.Drawing.Point(58, 15)
        Me.sfpMgmtIPLabel.Name = "sfpMgmtIPLabel"
        Me.sfpMgmtIPLabel.Size = New System.Drawing.Size(131, 13)
        Me.sfpMgmtIPLabel.TabIndex = 1
        Me.sfpMgmtIPLabel.Text = "Device Control IP Address"
        '
        'sfpMgmtIpTextBox
        '
        Me.sfpMgmtIpTextBox.Location = New System.Drawing.Point(195, 12)
        Me.sfpMgmtIpTextBox.Name = "sfpMgmtIpTextBox"
        Me.sfpMgmtIpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpMgmtIpTextBox.TabIndex = 2
        '
        'detailPanel
        '
        Me.detailPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.detailPanel.AutoScroll = True
        Me.detailPanel.Controls.Add(Me.sfpFormattingPanel)
        Me.detailPanel.Controls.Add(Me.sfpFlowPortMaskedTextBox)
        Me.detailPanel.Controls.Add(Me.sfpFlowIPMaskedTextBox)
        Me.detailPanel.Controls.Add(Me.sfpAdvancedPanel)
        Me.detailPanel.Controls.Add(Me.sfpFlowPortLabelLabel)
        Me.detailPanel.Controls.Add(Me.sfpFlowIpLabelLabel)
        Me.detailPanel.Controls.Add(Me.sfpTypeLabel)
        Me.detailPanel.Controls.Add(Me.sfpTypeLabelLabel)
        Me.detailPanel.Controls.Add(Me.sfpNameLabel)
        Me.detailPanel.Controls.Add(Me.sfpNameLabelLabel)
        Me.detailPanel.Location = New System.Drawing.Point(12, 38)
        Me.detailPanel.Name = "detailPanel"
        Me.detailPanel.Size = New System.Drawing.Size(346, 294)
        Me.detailPanel.TabIndex = 3
        '
        'sfpFormattingPanel
        '
        Me.sfpFormattingPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeSamplingLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeSamplingLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeRateLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeRateLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeFormatLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeFormatLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodePScanLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodePScanLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeTScanLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeTScanLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeModeLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeModeLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeValidLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatCodeValidLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatClkRateLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatLineLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatClkRateLabelLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatLabel)
        Me.sfpFormattingPanel.Controls.Add(Me.sfpFormatButton)
        Me.sfpFormattingPanel.Location = New System.Drawing.Point(7, 109)
        Me.sfpFormattingPanel.Name = "sfpFormattingPanel"
        Me.sfpFormattingPanel.Size = New System.Drawing.Size(333, 31)
        Me.sfpFormattingPanel.TabIndex = 23
        '
        'sfpFormatCodeSamplingLabel
        '
        Me.sfpFormatCodeSamplingLabel.AutoSize = True
        Me.sfpFormatCodeSamplingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeSamplingLabel.Location = New System.Drawing.Point(183, 59)
        Me.sfpFormatCodeSamplingLabel.Name = "sfpFormatCodeSamplingLabel"
        Me.sfpFormatCodeSamplingLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeSamplingLabel.TabIndex = 24
        Me.sfpFormatCodeSamplingLabel.Text = "0"
        '
        'sfpFormatCodeSamplingLabelLabel
        '
        Me.sfpFormatCodeSamplingLabelLabel.AutoSize = True
        Me.sfpFormatCodeSamplingLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeSamplingLabelLabel.Location = New System.Drawing.Point(104, 59)
        Me.sfpFormatCodeSamplingLabelLabel.Name = "sfpFormatCodeSamplingLabelLabel"
        Me.sfpFormatCodeSamplingLabelLabel.Size = New System.Drawing.Size(81, 13)
        Me.sfpFormatCodeSamplingLabelLabel.TabIndex = 23
        Me.sfpFormatCodeSamplingLabelLabel.Text = "Code Sampling:"
        '
        'sfpFormatCodeRateLabel
        '
        Me.sfpFormatCodeRateLabel.AutoSize = True
        Me.sfpFormatCodeRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeRateLabel.Location = New System.Drawing.Point(75, 59)
        Me.sfpFormatCodeRateLabel.Name = "sfpFormatCodeRateLabel"
        Me.sfpFormatCodeRateLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeRateLabel.TabIndex = 22
        Me.sfpFormatCodeRateLabel.Text = "0"
        '
        'sfpFormatCodeRateLabelLabel
        '
        Me.sfpFormatCodeRateLabelLabel.AutoSize = True
        Me.sfpFormatCodeRateLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeRateLabelLabel.Location = New System.Drawing.Point(17, 59)
        Me.sfpFormatCodeRateLabelLabel.Name = "sfpFormatCodeRateLabelLabel"
        Me.sfpFormatCodeRateLabelLabel.Size = New System.Drawing.Size(61, 13)
        Me.sfpFormatCodeRateLabelLabel.TabIndex = 21
        Me.sfpFormatCodeRateLabelLabel.Text = "Code Rate:"
        '
        'sfpFormatCodeFormatLabel
        '
        Me.sfpFormatCodeFormatLabel.AutoSize = True
        Me.sfpFormatCodeFormatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeFormatLabel.Location = New System.Drawing.Point(75, 46)
        Me.sfpFormatCodeFormatLabel.Name = "sfpFormatCodeFormatLabel"
        Me.sfpFormatCodeFormatLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeFormatLabel.TabIndex = 20
        Me.sfpFormatCodeFormatLabel.Text = "0"
        '
        'sfpFormatCodeFormatLabelLabel
        '
        Me.sfpFormatCodeFormatLabelLabel.AutoSize = True
        Me.sfpFormatCodeFormatLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeFormatLabelLabel.Location = New System.Drawing.Point(8, 46)
        Me.sfpFormatCodeFormatLabelLabel.Name = "sfpFormatCodeFormatLabelLabel"
        Me.sfpFormatCodeFormatLabelLabel.Size = New System.Drawing.Size(70, 13)
        Me.sfpFormatCodeFormatLabelLabel.TabIndex = 19
        Me.sfpFormatCodeFormatLabelLabel.Text = "Code Format:"
        '
        'sfpFormatCodePScanLabel
        '
        Me.sfpFormatCodePScanLabel.AutoSize = True
        Me.sfpFormatCodePScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodePScanLabel.Location = New System.Drawing.Point(183, 46)
        Me.sfpFormatCodePScanLabel.Name = "sfpFormatCodePScanLabel"
        Me.sfpFormatCodePScanLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodePScanLabel.TabIndex = 18
        Me.sfpFormatCodePScanLabel.Text = "0"
        '
        'sfpFormatCodePScanLabelLabel
        '
        Me.sfpFormatCodePScanLabelLabel.AutoSize = True
        Me.sfpFormatCodePScanLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodePScanLabelLabel.Location = New System.Drawing.Point(112, 46)
        Me.sfpFormatCodePScanLabelLabel.Name = "sfpFormatCodePScanLabelLabel"
        Me.sfpFormatCodePScanLabelLabel.Size = New System.Drawing.Size(73, 13)
        Me.sfpFormatCodePScanLabelLabel.TabIndex = 17
        Me.sfpFormatCodePScanLabelLabel.Text = "Code P Scan:"
        '
        'sfpFormatCodeTScanLabel
        '
        Me.sfpFormatCodeTScanLabel.AutoSize = True
        Me.sfpFormatCodeTScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeTScanLabel.Location = New System.Drawing.Point(282, 46)
        Me.sfpFormatCodeTScanLabel.Name = "sfpFormatCodeTScanLabel"
        Me.sfpFormatCodeTScanLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeTScanLabel.TabIndex = 16
        Me.sfpFormatCodeTScanLabel.Text = "0"
        '
        'sfpFormatCodeTScanLabelLabel
        '
        Me.sfpFormatCodeTScanLabelLabel.AutoSize = True
        Me.sfpFormatCodeTScanLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeTScanLabelLabel.Location = New System.Drawing.Point(211, 46)
        Me.sfpFormatCodeTScanLabelLabel.Name = "sfpFormatCodeTScanLabelLabel"
        Me.sfpFormatCodeTScanLabelLabel.Size = New System.Drawing.Size(73, 13)
        Me.sfpFormatCodeTScanLabelLabel.TabIndex = 15
        Me.sfpFormatCodeTScanLabelLabel.Text = "Code T Scan:"
        '
        'sfpFormatCodeModeLabel
        '
        Me.sfpFormatCodeModeLabel.AutoSize = True
        Me.sfpFormatCodeModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeModeLabel.Location = New System.Drawing.Point(282, 33)
        Me.sfpFormatCodeModeLabel.Name = "sfpFormatCodeModeLabel"
        Me.sfpFormatCodeModeLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeModeLabel.TabIndex = 14
        Me.sfpFormatCodeModeLabel.Text = "0"
        '
        'sfpFormatCodeModeLabelLabel
        '
        Me.sfpFormatCodeModeLabelLabel.AutoSize = True
        Me.sfpFormatCodeModeLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeModeLabelLabel.Location = New System.Drawing.Point(219, 33)
        Me.sfpFormatCodeModeLabelLabel.Name = "sfpFormatCodeModeLabelLabel"
        Me.sfpFormatCodeModeLabelLabel.Size = New System.Drawing.Size(65, 13)
        Me.sfpFormatCodeModeLabelLabel.TabIndex = 13
        Me.sfpFormatCodeModeLabelLabel.Text = "Code Mode:"
        '
        'sfpFormatCodeValidLabel
        '
        Me.sfpFormatCodeValidLabel.AutoSize = True
        Me.sfpFormatCodeValidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeValidLabel.Location = New System.Drawing.Point(183, 33)
        Me.sfpFormatCodeValidLabel.Name = "sfpFormatCodeValidLabel"
        Me.sfpFormatCodeValidLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeValidLabel.TabIndex = 12
        Me.sfpFormatCodeValidLabel.Text = "0"
        '
        'sfpFormatCodeValidLabelLabel
        '
        Me.sfpFormatCodeValidLabelLabel.AutoSize = True
        Me.sfpFormatCodeValidLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeValidLabelLabel.Location = New System.Drawing.Point(124, 33)
        Me.sfpFormatCodeValidLabelLabel.Name = "sfpFormatCodeValidLabelLabel"
        Me.sfpFormatCodeValidLabelLabel.Size = New System.Drawing.Size(61, 13)
        Me.sfpFormatCodeValidLabelLabel.TabIndex = 11
        Me.sfpFormatCodeValidLabelLabel.Text = "Code Valid:"
        '
        'sfpFormatClkRateLabel
        '
        Me.sfpFormatClkRateLabel.AutoSize = True
        Me.sfpFormatClkRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatClkRateLabel.Location = New System.Drawing.Point(75, 33)
        Me.sfpFormatClkRateLabel.Name = "sfpFormatClkRateLabel"
        Me.sfpFormatClkRateLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatClkRateLabel.TabIndex = 8
        Me.sfpFormatClkRateLabel.Text = "0"
        '
        'sfpFormatLineLabel
        '
        Me.sfpFormatLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sfpFormatLineLabel.Location = New System.Drawing.Point(94, 15)
        Me.sfpFormatLineLabel.Name = "sfpFormatLineLabel"
        Me.sfpFormatLineLabel.Size = New System.Drawing.Size(214, 2)
        Me.sfpFormatLineLabel.TabIndex = 10
        '
        'sfpFormatClkRateLabelLabel
        '
        Me.sfpFormatClkRateLabelLabel.AutoSize = True
        Me.sfpFormatClkRateLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatClkRateLabelLabel.Location = New System.Drawing.Point(15, 33)
        Me.sfpFormatClkRateLabelLabel.Name = "sfpFormatClkRateLabelLabel"
        Me.sfpFormatClkRateLabelLabel.Size = New System.Drawing.Size(63, 13)
        Me.sfpFormatClkRateLabelLabel.TabIndex = 7
        Me.sfpFormatClkRateLabelLabel.Text = "Clock Rate:"
        '
        'sfpFormatLabel
        '
        Me.sfpFormatLabel.AutoSize = True
        Me.sfpFormatLabel.Location = New System.Drawing.Point(3, 8)
        Me.sfpFormatLabel.Name = "sfpFormatLabel"
        Me.sfpFormatLabel.Size = New System.Drawing.Size(93, 13)
        Me.sfpFormatLabel.TabIndex = 9
        Me.sfpFormatLabel.Text = "Video Format Info."
        '
        'sfpFormatButton
        '
        Me.sfpFormatButton.Location = New System.Drawing.Point(311, 3)
        Me.sfpFormatButton.Name = "sfpFormatButton"
        Me.sfpFormatButton.Size = New System.Drawing.Size(19, 23)
        Me.sfpFormatButton.TabIndex = 1
        Me.sfpFormatButton.Text = "v"
        Me.sfpFormatButton.UseVisualStyleBackColor = True
        '
        'sfpFlowPortMaskedTextBox
        '
        Me.sfpFlowPortMaskedTextBox.Enabled = False
        Me.sfpFlowPortMaskedTextBox.Location = New System.Drawing.Point(233, 26)
        Me.sfpFlowPortMaskedTextBox.Mask = "99990"
        Me.sfpFlowPortMaskedTextBox.Name = "sfpFlowPortMaskedTextBox"
        Me.sfpFlowPortMaskedTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpFlowPortMaskedTextBox.TabIndex = 19
        '
        'sfpFlowIPMaskedTextBox
        '
        Me.sfpFlowIPMaskedTextBox.Enabled = False
        Me.sfpFlowIPMaskedTextBox.Location = New System.Drawing.Point(93, 26)
        Me.sfpFlowIPMaskedTextBox.Mask = "990.990.990.990"
        Me.sfpFlowIPMaskedTextBox.Name = "sfpFlowIPMaskedTextBox"
        Me.sfpFlowIPMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpFlowIPMaskedTextBox.TabIndex = 11
        '
        'sfpAdvancedPanel
        '
        Me.sfpAdvancedPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSsrcMaskedTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSsrcLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpVlanTagMaskedTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpVlanTagLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcPortMaskedTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcIpMaskedTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowDstMacMaskedTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowDstMacLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcPortLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcIpLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedLineLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedButton)
        Me.sfpAdvancedPanel.Location = New System.Drawing.Point(7, 72)
        Me.sfpAdvancedPanel.Name = "sfpAdvancedPanel"
        Me.sfpAdvancedPanel.Size = New System.Drawing.Size(333, 31)
        Me.sfpAdvancedPanel.TabIndex = 10
        '
        'sfpFlowSsrcMaskedTextBox
        '
        Me.sfpFlowSsrcMaskedTextBox.Enabled = False
        Me.sfpFlowSsrcMaskedTextBox.Location = New System.Drawing.Point(85, 88)
        Me.sfpFlowSsrcMaskedTextBox.Mask = "\0x>AAAAAAAA"
        Me.sfpFlowSsrcMaskedTextBox.Name = "sfpFlowSsrcMaskedTextBox"
        Me.sfpFlowSsrcMaskedTextBox.Size = New System.Drawing.Size(85, 20)
        Me.sfpFlowSsrcMaskedTextBox.TabIndex = 22
        '
        'sfpFlowSsrcLabel
        '
        Me.sfpFlowSsrcLabel.AutoSize = True
        Me.sfpFlowSsrcLabel.Location = New System.Drawing.Point(13, 92)
        Me.sfpFlowSsrcLabel.Name = "sfpFlowSsrcLabel"
        Me.sfpFlowSsrcLabel.Size = New System.Drawing.Size(61, 13)
        Me.sfpFlowSsrcLabel.TabIndex = 21
        Me.sfpFlowSsrcLabel.Text = "RTP SSRC"
        '
        'sfpVlanTagMaskedTextBox
        '
        Me.sfpVlanTagMaskedTextBox.Enabled = False
        Me.sfpVlanTagMaskedTextBox.Location = New System.Drawing.Point(265, 62)
        Me.sfpVlanTagMaskedTextBox.Mask = "9990"
        Me.sfpVlanTagMaskedTextBox.Name = "sfpVlanTagMaskedTextBox"
        Me.sfpVlanTagMaskedTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpVlanTagMaskedTextBox.TabIndex = 20
        '
        'sfpVlanTagLabel
        '
        Me.sfpVlanTagLabel.AutoSize = True
        Me.sfpVlanTagLabel.Location = New System.Drawing.Point(199, 66)
        Me.sfpVlanTagLabel.Name = "sfpVlanTagLabel"
        Me.sfpVlanTagLabel.Size = New System.Drawing.Size(57, 13)
        Me.sfpVlanTagLabel.TabIndex = 19
        Me.sfpVlanTagLabel.Text = "VLAN Tag"
        '
        'sfpFlowSrcPortMaskedTextBox
        '
        Me.sfpFlowSrcPortMaskedTextBox.Enabled = False
        Me.sfpFlowSrcPortMaskedTextBox.Location = New System.Drawing.Point(265, 36)
        Me.sfpFlowSrcPortMaskedTextBox.Mask = "99990"
        Me.sfpFlowSrcPortMaskedTextBox.Name = "sfpFlowSrcPortMaskedTextBox"
        Me.sfpFlowSrcPortMaskedTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpFlowSrcPortMaskedTextBox.TabIndex = 18
        '
        'sfpFlowSrcIpMaskedTextBox
        '
        Me.sfpFlowSrcIpMaskedTextBox.Enabled = False
        Me.sfpFlowSrcIpMaskedTextBox.Location = New System.Drawing.Point(98, 36)
        Me.sfpFlowSrcIpMaskedTextBox.Mask = "990.990.990.990"
        Me.sfpFlowSrcIpMaskedTextBox.Name = "sfpFlowSrcIpMaskedTextBox"
        Me.sfpFlowSrcIpMaskedTextBox.Size = New System.Drawing.Size(95, 20)
        Me.sfpFlowSrcIpMaskedTextBox.TabIndex = 17
        '
        'sfpFlowDstMacMaskedTextBox
        '
        Me.sfpFlowDstMacMaskedTextBox.Enabled = False
        Me.sfpFlowDstMacMaskedTextBox.Location = New System.Drawing.Point(85, 62)
        Me.sfpFlowDstMacMaskedTextBox.Mask = ">AA:AA:AA:AA:AA:AA"
        Me.sfpFlowDstMacMaskedTextBox.Name = "sfpFlowDstMacMaskedTextBox"
        Me.sfpFlowDstMacMaskedTextBox.Size = New System.Drawing.Size(108, 20)
        Me.sfpFlowDstMacMaskedTextBox.TabIndex = 16
        '
        'sfpFlowDstMacLabel
        '
        Me.sfpFlowDstMacLabel.AutoSize = True
        Me.sfpFlowDstMacLabel.Location = New System.Drawing.Point(13, 66)
        Me.sfpFlowDstMacLabel.Name = "sfpFlowDstMacLabel"
        Me.sfpFlowDstMacLabel.Size = New System.Drawing.Size(58, 13)
        Me.sfpFlowDstMacLabel.TabIndex = 15
        Me.sfpFlowDstMacLabel.Text = "Dest. MAC"
        '
        'sfpFlowSrcPortLabel
        '
        Me.sfpFlowSrcPortLabel.AutoSize = True
        Me.sfpFlowSrcPortLabel.Location = New System.Drawing.Point(199, 40)
        Me.sfpFlowSrcPortLabel.Name = "sfpFlowSrcPortLabel"
        Me.sfpFlowSrcPortLabel.Size = New System.Drawing.Size(63, 13)
        Me.sfpFlowSrcPortLabel.TabIndex = 13
        Me.sfpFlowSrcPortLabel.Text = "Source Port"
        '
        'sfpFlowSrcIpLabel
        '
        Me.sfpFlowSrcIpLabel.AutoSize = True
        Me.sfpFlowSrcIpLabel.Location = New System.Drawing.Point(13, 40)
        Me.sfpFlowSrcIpLabel.Name = "sfpFlowSrcIpLabel"
        Me.sfpFlowSrcIpLabel.Size = New System.Drawing.Size(82, 13)
        Me.sfpFlowSrcIpLabel.TabIndex = 11
        Me.sfpFlowSrcIpLabel.Text = "Source Address"
        '
        'sfpAdvancedLineLabel
        '
        Me.sfpAdvancedLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sfpAdvancedLineLabel.Location = New System.Drawing.Point(145, 15)
        Me.sfpAdvancedLineLabel.Name = "sfpAdvancedLineLabel"
        Me.sfpAdvancedLineLabel.Size = New System.Drawing.Size(162, 2)
        Me.sfpAdvancedLineLabel.TabIndex = 10
        '
        'sfpAdvancedLabel
        '
        Me.sfpAdvancedLabel.AutoSize = True
        Me.sfpAdvancedLabel.Location = New System.Drawing.Point(3, 8)
        Me.sfpAdvancedLabel.Name = "sfpAdvancedLabel"
        Me.sfpAdvancedLabel.Size = New System.Drawing.Size(140, 13)
        Me.sfpAdvancedLabel.TabIndex = 9
        Me.sfpAdvancedLabel.Text = "Advanced Network Settings"
        '
        'sfpAdvancedButton
        '
        Me.sfpAdvancedButton.Location = New System.Drawing.Point(311, 3)
        Me.sfpAdvancedButton.Name = "sfpAdvancedButton"
        Me.sfpAdvancedButton.Size = New System.Drawing.Size(19, 23)
        Me.sfpAdvancedButton.TabIndex = 1
        Me.sfpAdvancedButton.Text = "v"
        Me.sfpAdvancedButton.UseVisualStyleBackColor = True
        '
        'sfpFlowPortLabelLabel
        '
        Me.sfpFlowPortLabelLabel.AutoSize = True
        Me.sfpFlowPortLabelLabel.Location = New System.Drawing.Point(206, 30)
        Me.sfpFlowPortLabelLabel.Name = "sfpFlowPortLabelLabel"
        Me.sfpFlowPortLabelLabel.Size = New System.Drawing.Size(26, 13)
        Me.sfpFlowPortLabelLabel.TabIndex = 6
        Me.sfpFlowPortLabelLabel.Text = "Port"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFlowPortLabelLabel, "Destination UDP port number of the flow")
        '
        'sfpFlowIpLabelLabel
        '
        Me.sfpFlowIpLabelLabel.AutoSize = True
        Me.sfpFlowIpLabelLabel.Location = New System.Drawing.Point(41, 30)
        Me.sfpFlowIpLabelLabel.Name = "sfpFlowIpLabelLabel"
        Me.sfpFlowIpLabelLabel.Size = New System.Drawing.Size(45, 13)
        Me.sfpFlowIpLabelLabel.TabIndex = 4
        Me.sfpFlowIpLabelLabel.Text = "Address"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFlowIpLabelLabel, "Destination IP address of the flow")
        '
        'sfpTypeLabel
        '
        Me.sfpTypeLabel.AutoSize = True
        Me.sfpTypeLabel.Location = New System.Drawing.Point(236, 6)
        Me.sfpTypeLabel.Name = "sfpTypeLabel"
        Me.sfpTypeLabel.Size = New System.Drawing.Size(0, 13)
        Me.sfpTypeLabel.TabIndex = 3
        '
        'sfpTypeLabelLabel
        '
        Me.sfpTypeLabelLabel.AutoSize = True
        Me.sfpTypeLabelLabel.Location = New System.Drawing.Point(198, 6)
        Me.sfpTypeLabelLabel.Name = "sfpTypeLabelLabel"
        Me.sfpTypeLabelLabel.Size = New System.Drawing.Size(34, 13)
        Me.sfpTypeLabelLabel.TabIndex = 2
        Me.sfpTypeLabelLabel.Text = "Type:"
        '
        'sfpNameLabel
        '
        Me.sfpNameLabel.AutoSize = True
        Me.sfpNameLabel.Location = New System.Drawing.Point(95, 6)
        Me.sfpNameLabel.Name = "sfpNameLabel"
        Me.sfpNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.sfpNameLabel.TabIndex = 1
        '
        'sfpNameLabelLabel
        '
        Me.sfpNameLabelLabel.AutoSize = True
        Me.sfpNameLabelLabel.Location = New System.Drawing.Point(48, 6)
        Me.sfpNameLabelLabel.Name = "sfpNameLabelLabel"
        Me.sfpNameLabelLabel.Size = New System.Drawing.Size(38, 13)
        Me.sfpNameLabelLabel.TabIndex = 0
        Me.sfpNameLabelLabel.Text = "Name:"
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
        'sfpConnectButton
        '
        Me.sfpConnectButton.Location = New System.Drawing.Point(301, 11)
        Me.sfpConnectButton.Name = "sfpConnectButton"
        Me.sfpConnectButton.Size = New System.Drawing.Size(57, 23)
        Me.sfpConnectButton.TabIndex = 5
        Me.sfpConnectButton.Text = "Connect"
        Me.sfpConnectButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(370, 373)
        Me.Controls.Add(Me.sfpConnectButton)
        Me.Controls.Add(Me.statusPanel)
        Me.Controls.Add(Me.detailPanel)
        Me.Controls.Add(Me.sfpMgmtIpTextBox)
        Me.Controls.Add(Me.sfpMgmtIPLabel)
        Me.Name = "MainForm"
        Me.Text = "EmbSFPConfigurator"
        Me.detailPanel.ResumeLayout(False)
        Me.detailPanel.PerformLayout()
        Me.sfpFormattingPanel.ResumeLayout(False)
        Me.sfpFormattingPanel.PerformLayout()
        Me.sfpAdvancedPanel.ResumeLayout(False)
        Me.sfpAdvancedPanel.PerformLayout()
        Me.statusPanel.ResumeLayout(False)
        Me.statusPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sfpMgmtIPLabel As Label
    Friend WithEvents sfpMgmtIpTextBox As TextBox
    Friend WithEvents detailPanel As Panel
    Friend WithEvents statusPanel As Panel
    Friend WithEvents flow1Label As Label
    Friend WithEvents flow1SeenLabel As Label
    Friend WithEvents flow1DroppedCounterLabel As Label
    Friend WithEvents flow1DroppedLabel As Label
    Friend WithEvents flow1RenderedLabel As Label
    Friend WithEvents flow1SeenCounterLabel As Label
    Friend WithEvents flow1RenderedCounterLabel As Label
    Friend WithEvents sfpNameLabelLabel As Label
    Friend WithEvents sfpNameLabel As Label
    Friend WithEvents sfpTypeLabel As Label
    Friend WithEvents sfpTypeLabelLabel As Label
    Friend WithEvents sfpFlowIpLabelLabel As Label
    Friend WithEvents sfpFlowPortLabelLabel As Label
    Friend WithEvents sfpFlowDetailToolTip As ToolTip
    Friend WithEvents sfpConnectButton As Button
    Friend WithEvents sfpAdvancedButton As Button
    Friend WithEvents sfpAdvancedLabel As Label
    Friend WithEvents sfpAdvancedPanel As Panel
    Friend WithEvents sfpAdvancedLineLabel As Label
    Friend WithEvents sfpFlowSrcIpLabel As Label
    Friend WithEvents sfpFlowSrcPortLabel As Label
    Friend WithEvents sfpFlowDstMacLabel As Label
    Friend WithEvents sfpFlowDstMacMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFlowSrcIpMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFlowPortMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFlowIPMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFlowSsrcMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFlowSsrcLabel As Label
    Friend WithEvents sfpVlanTagMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpVlanTagLabel As Label
    Friend WithEvents sfpFlowSrcPortMaskedTextBox As MaskedTextBox
    Friend WithEvents sfpFormattingPanel As Panel
    Friend WithEvents sfpFormatLineLabel As Label
    Friend WithEvents sfpFormatLabel As Label
    Friend WithEvents sfpFormatButton As Button
    Friend WithEvents sfpFormatCodeValidLabel As Label
    Friend WithEvents sfpFormatCodeValidLabelLabel As Label
    Friend WithEvents sfpFormatClkRateLabel As Label
    Friend WithEvents sfpFormatClkRateLabelLabel As Label
    Friend WithEvents sfpFormatCodeTScanLabel As Label
    Friend WithEvents sfpFormatCodeTScanLabelLabel As Label
    Friend WithEvents sfpFormatCodeModeLabel As Label
    Friend WithEvents sfpFormatCodeModeLabelLabel As Label
    Friend WithEvents sfpFormatCodeFormatLabel As Label
    Friend WithEvents sfpFormatCodeFormatLabelLabel As Label
    Friend WithEvents sfpFormatCodePScanLabel As Label
    Friend WithEvents sfpFormatCodePScanLabelLabel As Label
    Friend WithEvents sfpFormatCodeSamplingLabel As Label
    Friend WithEvents sfpFormatCodeSamplingLabelLabel As Label
    Friend WithEvents sfpFormatCodeRateLabel As Label
    Friend WithEvents sfpFormatCodeRateLabelLabel As Label
End Class
