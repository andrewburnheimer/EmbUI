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
        Me.detailPanel = New System.Windows.Forms.Panel()
        Me.sfpNameLabel = New System.Windows.Forms.Label()
        Me.sfpFilteringPanel = New System.Windows.Forms.Panel()
        Me.sfpFilterSSRCCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterDestIPCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterDestMACCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterDestPortCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterVlanCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterSrcMACCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterSrcPortCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilterSrcIPCheckbox = New System.Windows.Forms.CheckBox()
        Me.sfpFilteringLineLabel = New System.Windows.Forms.Label()
        Me.sfpFilteringLabel = New System.Windows.Forms.Label()
        Me.sfpFilteringButton = New System.Windows.Forms.Button()
        Me.sfpFlowPortTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowIPTextBox = New System.Windows.Forms.TextBox()
        Me.sfpNameTextBox = New System.Windows.Forms.TextBox()
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
        Me.sfpAdvancedPanel = New System.Windows.Forms.Panel()
        Me.sfpFlowVlanTagTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowSrcPortTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowSsrcTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowDstMacTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowSrcIpTextBox = New System.Windows.Forms.TextBox()
        Me.sfpFlowSsrcLabel = New System.Windows.Forms.Label()
        Me.sfpFlowVlanTagLabel = New System.Windows.Forms.Label()
        Me.sfpFlowDstMacLabel = New System.Windows.Forms.Label()
        Me.sfpFlowSrcPortLabel = New System.Windows.Forms.Label()
        Me.sfpFlowSrcIpLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedLineLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedLabel = New System.Windows.Forms.Label()
        Me.sfpAdvancedButton = New System.Windows.Forms.Button()
        Me.sfpFlowPortLabel = New System.Windows.Forms.Label()
        Me.sfpFlowIpLabel = New System.Windows.Forms.Label()
        Me.sfpTypeLabel = New System.Windows.Forms.Label()
        Me.sfpTypeLabelLabel = New System.Windows.Forms.Label()
        Me.sfpMgmtIpComboBox = New System.Windows.Forms.ComboBox()
        Me.decapStatusPanel = New System.Windows.Forms.Panel()
        Me.encapStatusPanel = New System.Windows.Forms.Panel()
        Me.encapCounterNote = New System.Windows.Forms.Label()
        Me.flow1SentCounterLabel = New System.Windows.Forms.Label()
        Me.flow1SentLabel = New System.Windows.Forms.Label()
        Me.flow1LabelEncap = New System.Windows.Forms.Label()
        Me.flow1SeenCounterLabel = New System.Windows.Forms.Label()
        Me.flow1RenderedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1DroppedCounterLabel = New System.Windows.Forms.Label()
        Me.flow1DroppedLabel = New System.Windows.Forms.Label()
        Me.flow1RenderedLabel = New System.Windows.Forms.Label()
        Me.flow1SeenLabel = New System.Windows.Forms.Label()
        Me.flow1LabelDecap = New System.Windows.Forms.Label()
        Me.sfpFlowDetailToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfpConnectButton = New System.Windows.Forms.Button()
        Me.CounterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sfpApplyButton = New System.Windows.Forms.Button()
        Me.sfpDevicesButton = New System.Windows.Forms.Button()
        Me.devicesFlowsButton = New System.Windows.Forms.Button()
        Me.devicesPanel = New System.Windows.Forms.Panel()
        Me.devicesAdaptersLabel = New System.Windows.Forms.Label()
        Me.devicesAdaptersComboBox = New System.Windows.Forms.ComboBox()
        Me.devicesAddButton = New System.Windows.Forms.Button()
        Me.devicesDoubleClickLabel = New System.Windows.Forms.Label()
        Me.devicesSNMTextBox = New System.Windows.Forms.TextBox()
        Me.devicesSNMLabel = New System.Windows.Forms.Label()
        Me.devicesListBox = New System.Windows.Forms.ListBox()
        Me.devicesDGTextBox = New System.Windows.Forms.TextBox()
        Me.devicesDHCPListBox = New System.Windows.Forms.ListBox()
        Me.devicesDGLabel = New System.Windows.Forms.Label()
        Me.devicesDHCPCheckBox = New System.Windows.Forms.CheckBox()
        Me.devicesIpTextBox = New System.Windows.Forms.TextBox()
        Me.devicesRemoveButton = New System.Windows.Forms.Button()
        Me.devicesApplyButton = New System.Windows.Forms.Button()
        Me.devicesAccentPanel1 = New System.Windows.Forms.Panel()
        Me.devicesIpLabel = New System.Windows.Forms.Label()
        Me.devicesAccentPanel3 = New System.Windows.Forms.Panel()
        Me.devicesAccentPanel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.getResponseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sfpAccentPanel = New System.Windows.Forms.Panel()
        Me.detailPanel.SuspendLayout()
        Me.sfpFilteringPanel.SuspendLayout()
        Me.sfpFormattingPanel.SuspendLayout()
        Me.sfpAdvancedPanel.SuspendLayout()
        Me.decapStatusPanel.SuspendLayout()
        Me.encapStatusPanel.SuspendLayout()
        Me.devicesPanel.SuspendLayout()
        Me.devicesAccentPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfpMgmtIPLabel
        '
        Me.sfpMgmtIPLabel.AutoSize = True
        Me.sfpMgmtIPLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sfpMgmtIPLabel.Location = New System.Drawing.Point(85, 15)
        Me.sfpMgmtIPLabel.Name = "sfpMgmtIPLabel"
        Me.sfpMgmtIPLabel.Size = New System.Drawing.Size(94, 13)
        Me.sfpMgmtIPLabel.TabIndex = 1
        Me.sfpMgmtIPLabel.Text = "Control IP Address"
        '
        'detailPanel
        '
        Me.detailPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.detailPanel.AutoScroll = True
        Me.detailPanel.Controls.Add(Me.sfpNameLabel)
        Me.detailPanel.Controls.Add(Me.sfpFilteringPanel)
        Me.detailPanel.Controls.Add(Me.sfpFlowPortTextBox)
        Me.detailPanel.Controls.Add(Me.sfpFlowIPTextBox)
        Me.detailPanel.Controls.Add(Me.sfpNameTextBox)
        Me.detailPanel.Controls.Add(Me.sfpFormattingPanel)
        Me.detailPanel.Controls.Add(Me.sfpAdvancedPanel)
        Me.detailPanel.Controls.Add(Me.sfpFlowPortLabel)
        Me.detailPanel.Controls.Add(Me.sfpFlowIpLabel)
        Me.detailPanel.Controls.Add(Me.sfpTypeLabel)
        Me.detailPanel.Controls.Add(Me.sfpTypeLabelLabel)
        Me.detailPanel.Location = New System.Drawing.Point(19, 41)
        Me.detailPanel.Name = "detailPanel"
        Me.detailPanel.Size = New System.Drawing.Size(346, 454)
        Me.detailPanel.TabIndex = 3
        '
        'sfpNameLabel
        '
        Me.sfpNameLabel.AutoSize = True
        Me.sfpNameLabel.Location = New System.Drawing.Point(89, 14)
        Me.sfpNameLabel.Name = "sfpNameLabel"
        Me.sfpNameLabel.Size = New System.Drawing.Size(38, 13)
        Me.sfpNameLabel.TabIndex = 0
        Me.sfpNameLabel.Text = "Name:"
        '
        'sfpFilteringPanel
        '
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterSSRCCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterDestIPCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterDestMACCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterDestPortCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterVlanCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterSrcMACCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterSrcPortCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilterSrcIPCheckbox)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilteringLineLabel)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilteringLabel)
        Me.sfpFilteringPanel.Controls.Add(Me.sfpFilteringButton)
        Me.sfpFilteringPanel.Enabled = False
        Me.sfpFilteringPanel.Location = New System.Drawing.Point(7, 142)
        Me.sfpFilteringPanel.Name = "sfpFilteringPanel"
        Me.sfpFilteringPanel.Size = New System.Drawing.Size(333, 33)
        Me.sfpFilteringPanel.TabIndex = 26
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFilteringPanel, "Decap Only")
        '
        'sfpFilterSSRCCheckbox
        '
        Me.sfpFilterSSRCCheckbox.AutoSize = True
        Me.sfpFilterSSRCCheckbox.Location = New System.Drawing.Point(234, 102)
        Me.sfpFilterSSRCCheckbox.Name = "sfpFilterSSRCCheckbox"
        Me.sfpFilterSSRCCheckbox.Size = New System.Drawing.Size(55, 17)
        Me.sfpFilterSSRCCheckbox.TabIndex = 21
        Me.sfpFilterSSRCCheckbox.Text = "SSRC"
        Me.sfpFilterSSRCCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterDestIPCheckbox
        '
        Me.sfpFilterDestIPCheckbox.AutoSize = True
        Me.sfpFilterDestIPCheckbox.Location = New System.Drawing.Point(234, 39)
        Me.sfpFilterDestIPCheckbox.Name = "sfpFilterDestIPCheckbox"
        Me.sfpFilterDestIPCheckbox.Size = New System.Drawing.Size(61, 17)
        Me.sfpFilterDestIPCheckbox.TabIndex = 20
        Me.sfpFilterDestIPCheckbox.Text = "Dest IP"
        Me.sfpFilterDestIPCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterDestMACCheckbox
        '
        Me.sfpFilterDestMACCheckbox.AutoSize = True
        Me.sfpFilterDestMACCheckbox.Location = New System.Drawing.Point(234, 80)
        Me.sfpFilterDestMACCheckbox.Name = "sfpFilterDestMACCheckbox"
        Me.sfpFilterDestMACCheckbox.Size = New System.Drawing.Size(74, 17)
        Me.sfpFilterDestMACCheckbox.TabIndex = 19
        Me.sfpFilterDestMACCheckbox.Text = "Dest MAC"
        Me.sfpFilterDestMACCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterDestPortCheckbox
        '
        Me.sfpFilterDestPortCheckbox.AutoSize = True
        Me.sfpFilterDestPortCheckbox.Location = New System.Drawing.Point(234, 59)
        Me.sfpFilterDestPortCheckbox.Name = "sfpFilterDestPortCheckbox"
        Me.sfpFilterDestPortCheckbox.Size = New System.Drawing.Size(96, 17)
        Me.sfpFilterDestPortCheckbox.TabIndex = 18
        Me.sfpFilterDestPortCheckbox.Text = "Dest UDP Port"
        Me.sfpFilterDestPortCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterVlanCheckbox
        '
        Me.sfpFilterVlanCheckbox.AutoSize = True
        Me.sfpFilterVlanCheckbox.Location = New System.Drawing.Point(36, 102)
        Me.sfpFilterVlanCheckbox.Name = "sfpFilterVlanCheckbox"
        Me.sfpFilterVlanCheckbox.Size = New System.Drawing.Size(69, 17)
        Me.sfpFilterVlanCheckbox.TabIndex = 17
        Me.sfpFilterVlanCheckbox.Text = "Vlan Tag"
        Me.sfpFilterVlanCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterSrcMACCheckbox
        '
        Me.sfpFilterSrcMACCheckbox.AutoSize = True
        Me.sfpFilterSrcMACCheckbox.Location = New System.Drawing.Point(36, 81)
        Me.sfpFilterSrcMACCheckbox.Name = "sfpFilterSrcMACCheckbox"
        Me.sfpFilterSrcMACCheckbox.Size = New System.Drawing.Size(86, 17)
        Me.sfpFilterSrcMACCheckbox.TabIndex = 16
        Me.sfpFilterSrcMACCheckbox.Text = "Source MAC"
        Me.sfpFilterSrcMACCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterSrcPortCheckbox
        '
        Me.sfpFilterSrcPortCheckbox.AutoSize = True
        Me.sfpFilterSrcPortCheckbox.Location = New System.Drawing.Point(36, 59)
        Me.sfpFilterSrcPortCheckbox.Name = "sfpFilterSrcPortCheckbox"
        Me.sfpFilterSrcPortCheckbox.Size = New System.Drawing.Size(108, 17)
        Me.sfpFilterSrcPortCheckbox.TabIndex = 15
        Me.sfpFilterSrcPortCheckbox.Text = "Source UDP Port"
        Me.sfpFilterSrcPortCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilterSrcIPCheckbox
        '
        Me.sfpFilterSrcIPCheckbox.AutoSize = True
        Me.sfpFilterSrcIPCheckbox.Location = New System.Drawing.Point(36, 39)
        Me.sfpFilterSrcIPCheckbox.Name = "sfpFilterSrcIPCheckbox"
        Me.sfpFilterSrcIPCheckbox.Size = New System.Drawing.Size(73, 17)
        Me.sfpFilterSrcIPCheckbox.TabIndex = 14
        Me.sfpFilterSrcIPCheckbox.Text = "Source IP"
        Me.sfpFilterSrcIPCheckbox.UseVisualStyleBackColor = True
        '
        'sfpFilteringLineLabel
        '
        Me.sfpFilteringLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sfpFilteringLineLabel.Location = New System.Drawing.Point(84, 19)
        Me.sfpFilteringLineLabel.Name = "sfpFilteringLineLabel"
        Me.sfpFilteringLineLabel.Size = New System.Drawing.Size(220, 2)
        Me.sfpFilteringLineLabel.TabIndex = 13
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFilteringLineLabel, "Decap Only")
        '
        'sfpFilteringLabel
        '
        Me.sfpFilteringLabel.AutoSize = True
        Me.sfpFilteringLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFilteringLabel.Location = New System.Drawing.Point(5, 12)
        Me.sfpFilteringLabel.Name = "sfpFilteringLabel"
        Me.sfpFilteringLabel.Size = New System.Drawing.Size(78, 13)
        Me.sfpFilteringLabel.TabIndex = 12
        Me.sfpFilteringLabel.Text = "Decap Filtering"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFilteringLabel, "Decap Only")
        '
        'sfpFilteringButton
        '
        Me.sfpFilteringButton.Location = New System.Drawing.Point(311, 7)
        Me.sfpFilteringButton.Name = "sfpFilteringButton"
        Me.sfpFilteringButton.Size = New System.Drawing.Size(19, 23)
        Me.sfpFilteringButton.TabIndex = 11
        Me.sfpFilteringButton.Text = "v"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFilteringButton, "Decap Only")
        Me.sfpFilteringButton.UseVisualStyleBackColor = True
        '
        'sfpFlowPortTextBox
        '
        Me.sfpFlowPortTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.sfpFlowPortTextBox.Enabled = False
        Me.sfpFlowPortTextBox.Location = New System.Drawing.Point(266, 39)
        Me.sfpFlowPortTextBox.Name = "sfpFlowPortTextBox"
        Me.sfpFlowPortTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpFlowPortTextBox.TabIndex = 25
        '
        'sfpFlowIPTextBox
        '
        Me.sfpFlowIPTextBox.Enabled = False
        Me.sfpFlowIPTextBox.Location = New System.Drawing.Point(129, 42)
        Me.sfpFlowIPTextBox.Name = "sfpFlowIPTextBox"
        Me.sfpFlowIPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpFlowIPTextBox.TabIndex = 24
        '
        'sfpNameTextBox
        '
        Me.sfpNameTextBox.Enabled = False
        Me.sfpNameTextBox.Location = New System.Drawing.Point(129, 12)
        Me.sfpNameTextBox.Name = "sfpNameTextBox"
        Me.sfpNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpNameTextBox.TabIndex = 6
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
        Me.sfpFormattingPanel.Enabled = False
        Me.sfpFormattingPanel.Location = New System.Drawing.Point(7, 108)
        Me.sfpFormattingPanel.Name = "sfpFormattingPanel"
        Me.sfpFormattingPanel.Size = New System.Drawing.Size(333, 29)
        Me.sfpFormattingPanel.TabIndex = 23
        '
        'sfpFormatCodeSamplingLabel
        '
        Me.sfpFormatCodeSamplingLabel.AutoSize = True
        Me.sfpFormatCodeSamplingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeSamplingLabel.Location = New System.Drawing.Point(190, 65)
        Me.sfpFormatCodeSamplingLabel.Name = "sfpFormatCodeSamplingLabel"
        Me.sfpFormatCodeSamplingLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeSamplingLabel.TabIndex = 24
        Me.sfpFormatCodeSamplingLabel.Text = "0"
        '
        'sfpFormatCodeSamplingLabelLabel
        '
        Me.sfpFormatCodeSamplingLabelLabel.AutoSize = True
        Me.sfpFormatCodeSamplingLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeSamplingLabelLabel.Location = New System.Drawing.Point(136, 65)
        Me.sfpFormatCodeSamplingLabelLabel.Name = "sfpFormatCodeSamplingLabelLabel"
        Me.sfpFormatCodeSamplingLabelLabel.Size = New System.Drawing.Size(53, 13)
        Me.sfpFormatCodeSamplingLabelLabel.TabIndex = 23
        Me.sfpFormatCodeSamplingLabelLabel.Text = "Sampling:"
        '
        'sfpFormatCodeRateLabel
        '
        Me.sfpFormatCodeRateLabel.AutoSize = True
        Me.sfpFormatCodeRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeRateLabel.Location = New System.Drawing.Point(92, 65)
        Me.sfpFormatCodeRateLabel.Name = "sfpFormatCodeRateLabel"
        Me.sfpFormatCodeRateLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeRateLabel.TabIndex = 22
        Me.sfpFormatCodeRateLabel.Text = "0"
        '
        'sfpFormatCodeRateLabelLabel
        '
        Me.sfpFormatCodeRateLabelLabel.AutoSize = True
        Me.sfpFormatCodeRateLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeRateLabelLabel.Location = New System.Drawing.Point(59, 66)
        Me.sfpFormatCodeRateLabelLabel.Name = "sfpFormatCodeRateLabelLabel"
        Me.sfpFormatCodeRateLabelLabel.Size = New System.Drawing.Size(33, 13)
        Me.sfpFormatCodeRateLabelLabel.TabIndex = 21
        Me.sfpFormatCodeRateLabelLabel.Text = "Rate:"
        '
        'sfpFormatCodeFormatLabel
        '
        Me.sfpFormatCodeFormatLabel.AutoSize = True
        Me.sfpFormatCodeFormatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeFormatLabel.Location = New System.Drawing.Point(92, 48)
        Me.sfpFormatCodeFormatLabel.Name = "sfpFormatCodeFormatLabel"
        Me.sfpFormatCodeFormatLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeFormatLabel.TabIndex = 20
        Me.sfpFormatCodeFormatLabel.Text = "0"
        '
        'sfpFormatCodeFormatLabelLabel
        '
        Me.sfpFormatCodeFormatLabelLabel.AutoSize = True
        Me.sfpFormatCodeFormatLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeFormatLabelLabel.Location = New System.Drawing.Point(50, 49)
        Me.sfpFormatCodeFormatLabelLabel.Name = "sfpFormatCodeFormatLabelLabel"
        Me.sfpFormatCodeFormatLabelLabel.Size = New System.Drawing.Size(42, 13)
        Me.sfpFormatCodeFormatLabelLabel.TabIndex = 19
        Me.sfpFormatCodeFormatLabelLabel.Text = "Format:"
        '
        'sfpFormatCodePScanLabel
        '
        Me.sfpFormatCodePScanLabel.AutoSize = True
        Me.sfpFormatCodePScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodePScanLabel.Location = New System.Drawing.Point(190, 49)
        Me.sfpFormatCodePScanLabel.Name = "sfpFormatCodePScanLabel"
        Me.sfpFormatCodePScanLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodePScanLabel.TabIndex = 18
        Me.sfpFormatCodePScanLabel.Text = "0"
        '
        'sfpFormatCodePScanLabelLabel
        '
        Me.sfpFormatCodePScanLabelLabel.AutoSize = True
        Me.sfpFormatCodePScanLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodePScanLabelLabel.Location = New System.Drawing.Point(144, 49)
        Me.sfpFormatCodePScanLabelLabel.Name = "sfpFormatCodePScanLabelLabel"
        Me.sfpFormatCodePScanLabelLabel.Size = New System.Drawing.Size(45, 13)
        Me.sfpFormatCodePScanLabelLabel.TabIndex = 17
        Me.sfpFormatCodePScanLabelLabel.Text = "P Scan:"
        '
        'sfpFormatCodeTScanLabel
        '
        Me.sfpFormatCodeTScanLabel.AutoSize = True
        Me.sfpFormatCodeTScanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeTScanLabel.Location = New System.Drawing.Point(290, 53)
        Me.sfpFormatCodeTScanLabel.Name = "sfpFormatCodeTScanLabel"
        Me.sfpFormatCodeTScanLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeTScanLabel.TabIndex = 16
        Me.sfpFormatCodeTScanLabel.Text = "0"
        '
        'sfpFormatCodeTScanLabelLabel
        '
        Me.sfpFormatCodeTScanLabelLabel.AutoSize = True
        Me.sfpFormatCodeTScanLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeTScanLabelLabel.Location = New System.Drawing.Point(240, 51)
        Me.sfpFormatCodeTScanLabelLabel.Name = "sfpFormatCodeTScanLabelLabel"
        Me.sfpFormatCodeTScanLabelLabel.Size = New System.Drawing.Size(45, 13)
        Me.sfpFormatCodeTScanLabelLabel.TabIndex = 15
        Me.sfpFormatCodeTScanLabelLabel.Text = "T Scan:"
        '
        'sfpFormatCodeModeLabel
        '
        Me.sfpFormatCodeModeLabel.AutoSize = True
        Me.sfpFormatCodeModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeModeLabel.Location = New System.Drawing.Point(290, 33)
        Me.sfpFormatCodeModeLabel.Name = "sfpFormatCodeModeLabel"
        Me.sfpFormatCodeModeLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeModeLabel.TabIndex = 14
        Me.sfpFormatCodeModeLabel.Text = "0"
        '
        'sfpFormatCodeModeLabelLabel
        '
        Me.sfpFormatCodeModeLabelLabel.AutoSize = True
        Me.sfpFormatCodeModeLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeModeLabelLabel.Location = New System.Drawing.Point(248, 33)
        Me.sfpFormatCodeModeLabelLabel.Name = "sfpFormatCodeModeLabelLabel"
        Me.sfpFormatCodeModeLabelLabel.Size = New System.Drawing.Size(37, 13)
        Me.sfpFormatCodeModeLabelLabel.TabIndex = 13
        Me.sfpFormatCodeModeLabelLabel.Text = "Mode:"
        '
        'sfpFormatCodeValidLabel
        '
        Me.sfpFormatCodeValidLabel.AutoSize = True
        Me.sfpFormatCodeValidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeValidLabel.Location = New System.Drawing.Point(190, 33)
        Me.sfpFormatCodeValidLabel.Name = "sfpFormatCodeValidLabel"
        Me.sfpFormatCodeValidLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatCodeValidLabel.TabIndex = 12
        Me.sfpFormatCodeValidLabel.Text = "0"
        '
        'sfpFormatCodeValidLabelLabel
        '
        Me.sfpFormatCodeValidLabelLabel.AutoSize = True
        Me.sfpFormatCodeValidLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatCodeValidLabelLabel.Location = New System.Drawing.Point(156, 33)
        Me.sfpFormatCodeValidLabelLabel.Name = "sfpFormatCodeValidLabelLabel"
        Me.sfpFormatCodeValidLabelLabel.Size = New System.Drawing.Size(33, 13)
        Me.sfpFormatCodeValidLabelLabel.TabIndex = 11
        Me.sfpFormatCodeValidLabelLabel.Text = "Valid:"
        '
        'sfpFormatClkRateLabel
        '
        Me.sfpFormatClkRateLabel.AutoSize = True
        Me.sfpFormatClkRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatClkRateLabel.Location = New System.Drawing.Point(92, 33)
        Me.sfpFormatClkRateLabel.Name = "sfpFormatClkRateLabel"
        Me.sfpFormatClkRateLabel.Size = New System.Drawing.Size(13, 13)
        Me.sfpFormatClkRateLabel.TabIndex = 8
        Me.sfpFormatClkRateLabel.Text = "0"
        '
        'sfpFormatLineLabel
        '
        Me.sfpFormatLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sfpFormatLineLabel.Location = New System.Drawing.Point(107, 15)
        Me.sfpFormatLineLabel.Name = "sfpFormatLineLabel"
        Me.sfpFormatLineLabel.Size = New System.Drawing.Size(200, 2)
        Me.sfpFormatLineLabel.TabIndex = 10
        '
        'sfpFormatClkRateLabelLabel
        '
        Me.sfpFormatClkRateLabelLabel.AutoSize = True
        Me.sfpFormatClkRateLabelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatClkRateLabelLabel.Location = New System.Drawing.Point(29, 33)
        Me.sfpFormatClkRateLabelLabel.Name = "sfpFormatClkRateLabelLabel"
        Me.sfpFormatClkRateLabelLabel.Size = New System.Drawing.Size(63, 13)
        Me.sfpFormatClkRateLabelLabel.TabIndex = 7
        Me.sfpFormatClkRateLabelLabel.Text = "Clock Rate:"
        '
        'sfpFormatLabel
        '
        Me.sfpFormatLabel.AutoSize = True
        Me.sfpFormatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpFormatLabel.Location = New System.Drawing.Point(3, 8)
        Me.sfpFormatLabel.Name = "sfpFormatLabel"
        Me.sfpFormatLabel.Size = New System.Drawing.Size(102, 13)
        Me.sfpFormatLabel.TabIndex = 9
        Me.sfpFormatLabel.Text = "Video Format Codes"
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
        'sfpAdvancedPanel
        '
        Me.sfpAdvancedPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowVlanTagTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcPortTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSsrcTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowDstMacTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcIpTextBox)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSsrcLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowVlanTagLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowDstMacLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcPortLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpFlowSrcIpLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedLineLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedLabel)
        Me.sfpAdvancedPanel.Controls.Add(Me.sfpAdvancedButton)
        Me.sfpAdvancedPanel.Enabled = False
        Me.sfpAdvancedPanel.Location = New System.Drawing.Point(7, 72)
        Me.sfpAdvancedPanel.Name = "sfpAdvancedPanel"
        Me.sfpAdvancedPanel.Size = New System.Drawing.Size(333, 32)
        Me.sfpAdvancedPanel.TabIndex = 10
        '
        'sfpFlowVlanTagTextBox
        '
        Me.sfpFlowVlanTagTextBox.Location = New System.Drawing.Point(265, 64)
        Me.sfpFlowVlanTagTextBox.Name = "sfpFlowVlanTagTextBox"
        Me.sfpFlowVlanTagTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpFlowVlanTagTextBox.TabIndex = 28
        '
        'sfpFlowSrcPortTextBox
        '
        Me.sfpFlowSrcPortTextBox.Location = New System.Drawing.Point(265, 36)
        Me.sfpFlowSrcPortTextBox.Name = "sfpFlowSrcPortTextBox"
        Me.sfpFlowSrcPortTextBox.Size = New System.Drawing.Size(50, 20)
        Me.sfpFlowSrcPortTextBox.TabIndex = 27
        '
        'sfpFlowSsrcTextBox
        '
        Me.sfpFlowSsrcTextBox.Location = New System.Drawing.Point(89, 89)
        Me.sfpFlowSsrcTextBox.Name = "sfpFlowSsrcTextBox"
        Me.sfpFlowSsrcTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpFlowSsrcTextBox.TabIndex = 26
        '
        'sfpFlowDstMacTextBox
        '
        Me.sfpFlowDstMacTextBox.Location = New System.Drawing.Point(89, 62)
        Me.sfpFlowDstMacTextBox.Name = "sfpFlowDstMacTextBox"
        Me.sfpFlowDstMacTextBox.Size = New System.Drawing.Size(100, 20)
        Me.sfpFlowDstMacTextBox.TabIndex = 25
        '
        'sfpFlowSrcIpTextBox
        '
        Me.sfpFlowSrcIpTextBox.Location = New System.Drawing.Point(90, 37)
        Me.sfpFlowSrcIpTextBox.Name = "sfpFlowSrcIpTextBox"
        Me.sfpFlowSrcIpTextBox.Size = New System.Drawing.Size(99, 20)
        Me.sfpFlowSrcIpTextBox.TabIndex = 24
        '
        'sfpFlowSsrcLabel
        '
        Me.sfpFlowSsrcLabel.AutoSize = True
        Me.sfpFlowSsrcLabel.Location = New System.Drawing.Point(51, 92)
        Me.sfpFlowSsrcLabel.Name = "sfpFlowSsrcLabel"
        Me.sfpFlowSsrcLabel.Size = New System.Drawing.Size(39, 13)
        Me.sfpFlowSsrcLabel.TabIndex = 21
        Me.sfpFlowSsrcLabel.Text = "SSRC:"
        '
        'sfpFlowVlanTagLabel
        '
        Me.sfpFlowVlanTagLabel.AutoSize = True
        Me.sfpFlowVlanTagLabel.Location = New System.Drawing.Point(204, 66)
        Me.sfpFlowVlanTagLabel.Name = "sfpFlowVlanTagLabel"
        Me.sfpFlowVlanTagLabel.Size = New System.Drawing.Size(60, 13)
        Me.sfpFlowVlanTagLabel.TabIndex = 19
        Me.sfpFlowVlanTagLabel.Text = "VLAN Tag:"
        '
        'sfpFlowDstMacLabel
        '
        Me.sfpFlowDstMacLabel.AutoSize = True
        Me.sfpFlowDstMacLabel.Location = New System.Drawing.Point(32, 66)
        Me.sfpFlowDstMacLabel.Name = "sfpFlowDstMacLabel"
        Me.sfpFlowDstMacLabel.Size = New System.Drawing.Size(58, 13)
        Me.sfpFlowDstMacLabel.TabIndex = 15
        Me.sfpFlowDstMacLabel.Text = "Dest MAC:"
        '
        'sfpFlowSrcPortLabel
        '
        Me.sfpFlowSrcPortLabel.AutoSize = True
        Me.sfpFlowSrcPortLabel.Location = New System.Drawing.Point(199, 40)
        Me.sfpFlowSrcPortLabel.Name = "sfpFlowSrcPortLabel"
        Me.sfpFlowSrcPortLabel.Size = New System.Drawing.Size(66, 13)
        Me.sfpFlowSrcPortLabel.TabIndex = 13
        Me.sfpFlowSrcPortLabel.Text = "Source Port:"
        '
        'sfpFlowSrcIpLabel
        '
        Me.sfpFlowSrcIpLabel.AutoSize = True
        Me.sfpFlowSrcIpLabel.Location = New System.Drawing.Point(4, 40)
        Me.sfpFlowSrcIpLabel.Name = "sfpFlowSrcIpLabel"
        Me.sfpFlowSrcIpLabel.Size = New System.Drawing.Size(85, 13)
        Me.sfpFlowSrcIpLabel.TabIndex = 11
        Me.sfpFlowSrcIpLabel.Text = "Source Address:"
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
        Me.sfpAdvancedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'sfpFlowPortLabel
        '
        Me.sfpFlowPortLabel.AutoSize = True
        Me.sfpFlowPortLabel.Location = New System.Drawing.Point(237, 42)
        Me.sfpFlowPortLabel.Name = "sfpFlowPortLabel"
        Me.sfpFlowPortLabel.Size = New System.Drawing.Size(29, 13)
        Me.sfpFlowPortLabel.TabIndex = 6
        Me.sfpFlowPortLabel.Text = "Port:"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFlowPortLabel, "Destination UDP port number of the flow")
        '
        'sfpFlowIpLabel
        '
        Me.sfpFlowIpLabel.AutoSize = True
        Me.sfpFlowIpLabel.BackColor = System.Drawing.SystemColors.Control
        Me.sfpFlowIpLabel.Location = New System.Drawing.Point(5, 45)
        Me.sfpFlowIpLabel.Name = "sfpFlowIpLabel"
        Me.sfpFlowIpLabel.Size = New System.Drawing.Size(125, 13)
        Me.sfpFlowIpLabel.TabIndex = 4
        Me.sfpFlowIpLabel.Text = "Multicast Group Address:"
        Me.sfpFlowDetailToolTip.SetToolTip(Me.sfpFlowIpLabel, "Destination IP address of the flow")
        '
        'sfpTypeLabel
        '
        Me.sfpTypeLabel.AutoSize = True
        Me.sfpTypeLabel.Location = New System.Drawing.Point(263, 15)
        Me.sfpTypeLabel.Name = "sfpTypeLabel"
        Me.sfpTypeLabel.Size = New System.Drawing.Size(0, 13)
        Me.sfpTypeLabel.TabIndex = 3
        '
        'sfpTypeLabelLabel
        '
        Me.sfpTypeLabelLabel.AutoSize = True
        Me.sfpTypeLabelLabel.Location = New System.Drawing.Point(233, 14)
        Me.sfpTypeLabelLabel.Name = "sfpTypeLabelLabel"
        Me.sfpTypeLabelLabel.Size = New System.Drawing.Size(34, 13)
        Me.sfpTypeLabelLabel.TabIndex = 2
        Me.sfpTypeLabelLabel.Text = "Type:"
        '
        'sfpMgmtIpComboBox
        '
        Me.sfpMgmtIpComboBox.FormattingEnabled = True
        Me.sfpMgmtIpComboBox.Items.AddRange(New Object() {"127.0.0.1:9912", "127.0.0.1:9913", "127.0.0.1:9914", "127.0.0.1:9991"})
        Me.sfpMgmtIpComboBox.Location = New System.Drawing.Point(181, 11)
        Me.sfpMgmtIpComboBox.MaxDropDownItems = 100
        Me.sfpMgmtIpComboBox.Name = "sfpMgmtIpComboBox"
        Me.sfpMgmtIpComboBox.Size = New System.Drawing.Size(131, 21)
        Me.sfpMgmtIpComboBox.TabIndex = 27
        '
        'decapStatusPanel
        '
        Me.decapStatusPanel.Controls.Add(Me.encapStatusPanel)
        Me.decapStatusPanel.Controls.Add(Me.flow1SeenCounterLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1RenderedCounterLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1DroppedCounterLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1DroppedLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1RenderedLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1SeenLabel)
        Me.decapStatusPanel.Controls.Add(Me.flow1LabelDecap)
        Me.decapStatusPanel.Location = New System.Drawing.Point(0, 475)
        Me.decapStatusPanel.Name = "decapStatusPanel"
        Me.decapStatusPanel.Size = New System.Drawing.Size(389, 23)
        Me.decapStatusPanel.TabIndex = 4
        '
        'encapStatusPanel
        '
        Me.encapStatusPanel.Controls.Add(Me.encapCounterNote)
        Me.encapStatusPanel.Controls.Add(Me.flow1SentCounterLabel)
        Me.encapStatusPanel.Controls.Add(Me.flow1SentLabel)
        Me.encapStatusPanel.Controls.Add(Me.flow1LabelEncap)
        Me.encapStatusPanel.Location = New System.Drawing.Point(0, 0)
        Me.encapStatusPanel.Name = "encapStatusPanel"
        Me.encapStatusPanel.Size = New System.Drawing.Size(389, 23)
        Me.encapStatusPanel.TabIndex = 27
        '
        'encapCounterNote
        '
        Me.encapCounterNote.AutoSize = True
        Me.encapCounterNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encapCounterNote.Location = New System.Drawing.Point(107, 5)
        Me.encapCounterNote.Name = "encapCounterNote"
        Me.encapCounterNote.Size = New System.Drawing.Size(178, 13)
        Me.encapCounterNote.TabIndex = 6
        Me.encapCounterNote.Text = "Encap SFP Counters Not Supported"
        Me.encapCounterNote.Visible = False
        '
        'flow1SentCounterLabel
        '
        Me.flow1SentCounterLabel.AutoSize = True
        Me.flow1SentCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1SentCounterLabel.Location = New System.Drawing.Point(90, 5)
        Me.flow1SentCounterLabel.Name = "flow1SentCounterLabel"
        Me.flow1SentCounterLabel.Size = New System.Drawing.Size(13, 13)
        Me.flow1SentCounterLabel.TabIndex = 5
        Me.flow1SentCounterLabel.Text = "0"
        Me.flow1SentCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.flow1SentCounterLabel.Visible = False
        '
        'flow1SentLabel
        '
        Me.flow1SentLabel.AutoSize = True
        Me.flow1SentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1SentLabel.Location = New System.Drawing.Point(62, 5)
        Me.flow1SentLabel.Name = "flow1SentLabel"
        Me.flow1SentLabel.Size = New System.Drawing.Size(32, 13)
        Me.flow1SentLabel.TabIndex = 2
        Me.flow1SentLabel.Text = "Sent:"
        Me.flow1SentLabel.Visible = False
        '
        'flow1LabelEncap
        '
        Me.flow1LabelEncap.AutoSize = True
        Me.flow1LabelEncap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1LabelEncap.Location = New System.Drawing.Point(3, 5)
        Me.flow1LabelEncap.Name = "flow1LabelEncap"
        Me.flow1LabelEncap.Size = New System.Drawing.Size(44, 13)
        Me.flow1LabelEncap.TabIndex = 0
        Me.flow1LabelEncap.Text = "Flow 1"
        Me.flow1LabelEncap.Visible = False
        '
        'flow1SeenCounterLabel
        '
        Me.flow1SeenCounterLabel.AutoSize = True
        Me.flow1SeenCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1SeenCounterLabel.Location = New System.Drawing.Point(81, 5)
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
        Me.flow1RenderedCounterLabel.Location = New System.Drawing.Point(206, 5)
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
        Me.flow1DroppedCounterLabel.Location = New System.Drawing.Point(316, 5)
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
        Me.flow1DroppedLabel.Location = New System.Drawing.Point(268, 5)
        Me.flow1DroppedLabel.Name = "flow1DroppedLabel"
        Me.flow1DroppedLabel.Size = New System.Drawing.Size(51, 13)
        Me.flow1DroppedLabel.TabIndex = 3
        Me.flow1DroppedLabel.Text = "Dropped:"
        '
        'flow1RenderedLabel
        '
        Me.flow1RenderedLabel.AutoSize = True
        Me.flow1RenderedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1RenderedLabel.Location = New System.Drawing.Point(152, 5)
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
        'flow1LabelDecap
        '
        Me.flow1LabelDecap.AutoSize = True
        Me.flow1LabelDecap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flow1LabelDecap.Location = New System.Drawing.Point(3, 5)
        Me.flow1LabelDecap.Name = "flow1LabelDecap"
        Me.flow1LabelDecap.Size = New System.Drawing.Size(44, 13)
        Me.flow1LabelDecap.TabIndex = 0
        Me.flow1LabelDecap.Text = "Flow 1"
        '
        'sfpConnectButton
        '
        Me.sfpConnectButton.BackColor = System.Drawing.SystemColors.Control
        Me.sfpConnectButton.Location = New System.Drawing.Point(316, 11)
        Me.sfpConnectButton.Name = "sfpConnectButton"
        Me.sfpConnectButton.Size = New System.Drawing.Size(57, 23)
        Me.sfpConnectButton.TabIndex = 5
        Me.sfpConnectButton.Text = "Connect"
        Me.sfpConnectButton.UseVisualStyleBackColor = False
        '
        'CounterTimer
        '
        Me.CounterTimer.Interval = 1000
        '
        'sfpApplyButton
        '
        Me.sfpApplyButton.Enabled = False
        Me.sfpApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpApplyButton.Location = New System.Drawing.Point(158, 453)
        Me.sfpApplyButton.Name = "sfpApplyButton"
        Me.sfpApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.sfpApplyButton.TabIndex = 6
        Me.sfpApplyButton.Text = "Apply"
        Me.sfpApplyButton.UseVisualStyleBackColor = True
        '
        'sfpDevicesButton
        '
        Me.sfpDevicesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sfpDevicesButton.Location = New System.Drawing.Point(8, 10)
        Me.sfpDevicesButton.Name = "sfpDevicesButton"
        Me.sfpDevicesButton.Size = New System.Drawing.Size(75, 23)
        Me.sfpDevicesButton.TabIndex = 7
        Me.sfpDevicesButton.Text = "Devices"
        Me.sfpDevicesButton.UseVisualStyleBackColor = True
        '
        'devicesFlowsButton
        '
        Me.devicesFlowsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesFlowsButton.Location = New System.Drawing.Point(13, 9)
        Me.devicesFlowsButton.Name = "devicesFlowsButton"
        Me.devicesFlowsButton.Size = New System.Drawing.Size(75, 23)
        Me.devicesFlowsButton.TabIndex = 28
        Me.devicesFlowsButton.Text = "Flows"
        Me.devicesFlowsButton.UseVisualStyleBackColor = True
        '
        'devicesPanel
        '
        Me.devicesPanel.Controls.Add(Me.devicesAdaptersLabel)
        Me.devicesPanel.Controls.Add(Me.devicesAdaptersComboBox)
        Me.devicesPanel.Controls.Add(Me.devicesAddButton)
        Me.devicesPanel.Controls.Add(Me.devicesDoubleClickLabel)
        Me.devicesPanel.Controls.Add(Me.devicesSNMTextBox)
        Me.devicesPanel.Controls.Add(Me.devicesSNMLabel)
        Me.devicesPanel.Controls.Add(Me.devicesListBox)
        Me.devicesPanel.Controls.Add(Me.devicesDGTextBox)
        Me.devicesPanel.Controls.Add(Me.devicesDHCPListBox)
        Me.devicesPanel.Controls.Add(Me.devicesDGLabel)
        Me.devicesPanel.Controls.Add(Me.devicesDHCPCheckBox)
        Me.devicesPanel.Controls.Add(Me.devicesIpTextBox)
        Me.devicesPanel.Controls.Add(Me.devicesRemoveButton)
        Me.devicesPanel.Controls.Add(Me.devicesApplyButton)
        Me.devicesPanel.Controls.Add(Me.devicesFlowsButton)
        Me.devicesPanel.Controls.Add(Me.devicesAccentPanel1)
        Me.devicesPanel.Controls.Add(Me.devicesAccentPanel3)
        Me.devicesPanel.Controls.Add(Me.devicesAccentPanel2)
        Me.devicesPanel.Location = New System.Drawing.Point(0, 0)
        Me.devicesPanel.Name = "devicesPanel"
        Me.devicesPanel.Size = New System.Drawing.Size(390, 501)
        Me.devicesPanel.TabIndex = 29
        Me.devicesPanel.Visible = False
        '
        'devicesAdaptersLabel
        '
        Me.devicesAdaptersLabel.AutoSize = True
        Me.devicesAdaptersLabel.Enabled = False
        Me.devicesAdaptersLabel.Location = New System.Drawing.Point(23, 200)
        Me.devicesAdaptersLabel.Name = "devicesAdaptersLabel"
        Me.devicesAdaptersLabel.Size = New System.Drawing.Size(190, 13)
        Me.devicesAdaptersLabel.TabIndex = 37
        Me.devicesAdaptersLabel.Text = "Network Adapters for DHCP Discovery"
        '
        'devicesAdaptersComboBox
        '
        Me.devicesAdaptersComboBox.Enabled = False
        Me.devicesAdaptersComboBox.FormattingEnabled = True
        Me.devicesAdaptersComboBox.Location = New System.Drawing.Point(20, 219)
        Me.devicesAdaptersComboBox.Name = "devicesAdaptersComboBox"
        Me.devicesAdaptersComboBox.Size = New System.Drawing.Size(198, 21)
        Me.devicesAdaptersComboBox.TabIndex = 36
        '
        'devicesAddButton
        '
        Me.devicesAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesAddButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.devicesAddButton.Location = New System.Drawing.Point(49, 69)
        Me.devicesAddButton.Name = "devicesAddButton"
        Me.devicesAddButton.Size = New System.Drawing.Size(145, 42)
        Me.devicesAddButton.TabIndex = 31
        Me.devicesAddButton.Text = "     Add (+)      --->  "
        Me.devicesAddButton.UseVisualStyleBackColor = True
        '
        'devicesDoubleClickLabel
        '
        Me.devicesDoubleClickLabel.AutoSize = True
        Me.devicesDoubleClickLabel.Location = New System.Drawing.Point(187, 29)
        Me.devicesDoubleClickLabel.Name = "devicesDoubleClickLabel"
        Me.devicesDoubleClickLabel.Size = New System.Drawing.Size(203, 13)
        Me.devicesDoubleClickLabel.TabIndex = 35
        Me.devicesDoubleClickLabel.Text = "Double Click an IP to Attempt Connection"
        '
        'devicesSNMTextBox
        '
        Me.devicesSNMTextBox.Location = New System.Drawing.Point(267, 394)
        Me.devicesSNMTextBox.Name = "devicesSNMTextBox"
        Me.devicesSNMTextBox.Size = New System.Drawing.Size(112, 20)
        Me.devicesSNMTextBox.TabIndex = 32
        '
        'devicesSNMLabel
        '
        Me.devicesSNMLabel.AutoSize = True
        Me.devicesSNMLabel.Location = New System.Drawing.Point(195, 396)
        Me.devicesSNMLabel.Name = "devicesSNMLabel"
        Me.devicesSNMLabel.Size = New System.Drawing.Size(73, 13)
        Me.devicesSNMLabel.TabIndex = 31
        Me.devicesSNMLabel.Text = "Subnet Mask:"
        '
        'devicesListBox
        '
        Me.devicesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesListBox.FormattingEnabled = True
        Me.devicesListBox.ItemHeight = 16
        Me.devicesListBox.Items.AddRange(New Object() {"127.0.0.1:9912", "127.0.0.1:9913", "127.0.0.1:9914", "127.0.0.1:9991"})
        Me.devicesListBox.Location = New System.Drawing.Point(222, 49)
        Me.devicesListBox.Name = "devicesListBox"
        Me.devicesListBox.Size = New System.Drawing.Size(142, 292)
        Me.devicesListBox.TabIndex = 29
        '
        'devicesDGTextBox
        '
        Me.devicesDGTextBox.Location = New System.Drawing.Point(166, 433)
        Me.devicesDGTextBox.Name = "devicesDGTextBox"
        Me.devicesDGTextBox.Size = New System.Drawing.Size(110, 20)
        Me.devicesDGTextBox.TabIndex = 30
        '
        'devicesDHCPListBox
        '
        Me.devicesDHCPListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesDHCPListBox.FormattingEnabled = True
        Me.devicesDHCPListBox.ItemHeight = 16
        Me.devicesDHCPListBox.Items.AddRange(New Object() {"000.000.000.000:0000", "000.000.000.000:0000", "DHCP Box Test", "000.000.000.000:0000", "000.000.000.000:0000", "127.0.0.1:9912"})
        Me.devicesDHCPListBox.Location = New System.Drawing.Point(222, 194)
        Me.devicesDHCPListBox.Name = "devicesDHCPListBox"
        Me.devicesDHCPListBox.Size = New System.Drawing.Size(142, 148)
        Me.devicesDHCPListBox.TabIndex = 33
        '
        'devicesDGLabel
        '
        Me.devicesDGLabel.AutoSize = True
        Me.devicesDGLabel.Location = New System.Drawing.Point(79, 435)
        Me.devicesDGLabel.Name = "devicesDGLabel"
        Me.devicesDGLabel.Size = New System.Drawing.Size(89, 13)
        Me.devicesDGLabel.TabIndex = 29
        Me.devicesDGLabel.Text = "Default Gateway:"
        '
        'devicesDHCPCheckBox
        '
        Me.devicesDHCPCheckBox.AutoSize = True
        Me.devicesDHCPCheckBox.Location = New System.Drawing.Point(229, 346)
        Me.devicesDHCPCheckBox.Name = "devicesDHCPCheckBox"
        Me.devicesDHCPCheckBox.Size = New System.Drawing.Size(134, 17)
        Me.devicesDHCPCheckBox.TabIndex = 32
        Me.devicesDHCPCheckBox.Text = "Show DHCP Requests"
        Me.devicesDHCPCheckBox.UseVisualStyleBackColor = True
        '
        'devicesIpTextBox
        '
        Me.devicesIpTextBox.Location = New System.Drawing.Point(67, 393)
        Me.devicesIpTextBox.Name = "devicesIpTextBox"
        Me.devicesIpTextBox.Size = New System.Drawing.Size(112, 20)
        Me.devicesIpTextBox.TabIndex = 28
        '
        'devicesRemoveButton
        '
        Me.devicesRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesRemoveButton.Location = New System.Drawing.Point(49, 123)
        Me.devicesRemoveButton.Name = "devicesRemoveButton"
        Me.devicesRemoveButton.Size = New System.Drawing.Size(145, 44)
        Me.devicesRemoveButton.TabIndex = 30
        Me.devicesRemoveButton.Text = "  Remove (-)    <---   "
        Me.devicesRemoveButton.UseVisualStyleBackColor = True
        '
        'devicesApplyButton
        '
        Me.devicesApplyButton.Enabled = False
        Me.devicesApplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devicesApplyButton.Location = New System.Drawing.Point(161, 469)
        Me.devicesApplyButton.Name = "devicesApplyButton"
        Me.devicesApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.devicesApplyButton.TabIndex = 30
        Me.devicesApplyButton.Text = "Apply"
        Me.devicesApplyButton.UseVisualStyleBackColor = True
        '
        'devicesAccentPanel1
        '
        Me.devicesAccentPanel1.BackColor = System.Drawing.Color.PeachPuff
        Me.devicesAccentPanel1.Controls.Add(Me.devicesIpLabel)
        Me.devicesAccentPanel1.Location = New System.Drawing.Point(7, 386)
        Me.devicesAccentPanel1.Name = "devicesAccentPanel1"
        Me.devicesAccentPanel1.Size = New System.Drawing.Size(187, 35)
        Me.devicesAccentPanel1.TabIndex = 38
        '
        'devicesIpLabel
        '
        Me.devicesIpLabel.AutoSize = True
        Me.devicesIpLabel.Location = New System.Drawing.Point(1, 10)
        Me.devicesIpLabel.Name = "devicesIpLabel"
        Me.devicesIpLabel.Size = New System.Drawing.Size(61, 13)
        Me.devicesIpLabel.TabIndex = 27
        Me.devicesIpLabel.Text = "IP Address:"
        '
        'devicesAccentPanel3
        '
        Me.devicesAccentPanel3.BackColor = System.Drawing.Color.PeachPuff
        Me.devicesAccentPanel3.Location = New System.Drawing.Point(7, 62)
        Me.devicesAccentPanel3.Name = "devicesAccentPanel3"
        Me.devicesAccentPanel3.Size = New System.Drawing.Size(222, 55)
        Me.devicesAccentPanel3.TabIndex = 39
        '
        'devicesAccentPanel2
        '
        Me.devicesAccentPanel2.BackColor = System.Drawing.Color.PeachPuff
        Me.devicesAccentPanel2.Location = New System.Drawing.Point(7, 69)
        Me.devicesAccentPanel2.Name = "devicesAccentPanel2"
        Me.devicesAccentPanel2.Size = New System.Drawing.Size(10, 321)
        Me.devicesAccentPanel2.TabIndex = 39
        '
        'ComboBoxTimer
        '
        Me.ComboBoxTimer.Interval = 1000
        '
        'getResponseTimer
        '
        Me.getResponseTimer.Interval = 4000
        '
        'sfpAccentPanel
        '
        Me.sfpAccentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sfpAccentPanel.Location = New System.Drawing.Point(-1, 0)
        Me.sfpAccentPanel.Name = "sfpAccentPanel"
        Me.sfpAccentPanel.Size = New System.Drawing.Size(390, 41)
        Me.sfpAccentPanel.TabIndex = 30
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(391, 505)
        Me.Controls.Add(Me.devicesPanel)
        Me.Controls.Add(Me.decapStatusPanel)
        Me.Controls.Add(Me.sfpMgmtIpComboBox)
        Me.Controls.Add(Me.sfpDevicesButton)
        Me.Controls.Add(Me.sfpApplyButton)
        Me.Controls.Add(Me.sfpConnectButton)
        Me.Controls.Add(Me.sfpMgmtIPLabel)
        Me.Controls.Add(Me.sfpAccentPanel)
        Me.Controls.Add(Me.detailPanel)
        Me.Location = New System.Drawing.Point(50, 50)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(407, 543)
        Me.MinimumSize = New System.Drawing.Size(407, 543)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmbSFP Configurator"
        Me.detailPanel.ResumeLayout(False)
        Me.detailPanel.PerformLayout()
        Me.sfpFilteringPanel.ResumeLayout(False)
        Me.sfpFilteringPanel.PerformLayout()
        Me.sfpFormattingPanel.ResumeLayout(False)
        Me.sfpFormattingPanel.PerformLayout()
        Me.sfpAdvancedPanel.ResumeLayout(False)
        Me.sfpAdvancedPanel.PerformLayout()
        Me.decapStatusPanel.ResumeLayout(False)
        Me.decapStatusPanel.PerformLayout()
        Me.encapStatusPanel.ResumeLayout(False)
        Me.encapStatusPanel.PerformLayout()
        Me.devicesPanel.ResumeLayout(False)
        Me.devicesPanel.PerformLayout()
        Me.devicesAccentPanel1.ResumeLayout(False)
        Me.devicesAccentPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sfpMgmtIPLabel As Label
    Friend WithEvents detailPanel As Panel
    Friend WithEvents decapStatusPanel As Panel
    Friend WithEvents flow1LabelDecap As Label
    Friend WithEvents flow1SeenLabel As Label
    Friend WithEvents flow1DroppedCounterLabel As Label
    Friend WithEvents flow1DroppedLabel As Label
    Friend WithEvents flow1RenderedLabel As Label
    Friend WithEvents flow1SeenCounterLabel As Label
    Friend WithEvents flow1RenderedCounterLabel As Label
    Friend WithEvents sfpNameLabel As Label
    Friend WithEvents sfpTypeLabel As Label
    Friend WithEvents sfpTypeLabelLabel As Label
    Friend WithEvents sfpFlowIpLabel As Label
    Friend WithEvents sfpFlowPortLabel As Label
    Friend WithEvents sfpFlowDetailToolTip As ToolTip
    Friend WithEvents sfpConnectButton As Button
    Friend WithEvents sfpAdvancedButton As Button
    Friend WithEvents sfpAdvancedLabel As Label
    Friend WithEvents sfpAdvancedPanel As Panel
    Friend WithEvents sfpAdvancedLineLabel As Label
    Friend WithEvents sfpFlowSrcIpLabel As Label
    Friend WithEvents sfpFlowSrcPortLabel As Label
    Friend WithEvents sfpFlowDstMacLabel As Label
    Friend WithEvents sfpFlowSsrcLabel As Label
    Friend WithEvents sfpFlowVlanTagLabel As Label
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
    Friend WithEvents sfpNameTextBox As TextBox
    Friend WithEvents CounterTimer As Timer
    Friend WithEvents sfpFlowVlanTagTextBox As TextBox
    Friend WithEvents sfpFlowSrcPortTextBox As TextBox
    Friend WithEvents sfpFlowSsrcTextBox As TextBox
    Friend WithEvents sfpFlowDstMacTextBox As TextBox
    Friend WithEvents sfpFlowSrcIpTextBox As TextBox
    Friend WithEvents sfpFlowPortTextBox As TextBox
    Friend WithEvents sfpFlowIPTextBox As TextBox
    Friend WithEvents sfpApplyButton As Button
    Friend WithEvents sfpFilteringPanel As Panel
    Friend WithEvents sfpFilteringLineLabel As Label
    Friend WithEvents sfpFilteringLabel As Label
    Friend WithEvents sfpFilteringButton As Button
    Friend WithEvents sfpFilterSSRCCheckbox As CheckBox
    Friend WithEvents sfpFilterDestIPCheckbox As CheckBox
    Friend WithEvents sfpFilterDestMACCheckbox As CheckBox
    Friend WithEvents sfpFilterDestPortCheckbox As CheckBox
    Friend WithEvents sfpFilterVlanCheckbox As CheckBox
    Friend WithEvents sfpFilterSrcMACCheckbox As CheckBox
    Friend WithEvents sfpFilterSrcPortCheckbox As CheckBox
    Friend WithEvents sfpFilterSrcIPCheckbox As CheckBox
    Friend WithEvents encapStatusPanel As Panel
    Friend WithEvents flow1SentCounterLabel As Label
    Friend WithEvents flow1SentLabel As Label
    Friend WithEvents flow1LabelEncap As Label
    Friend WithEvents encapCounterNote As Label
    Friend WithEvents sfpDevicesButton As Button
    Friend WithEvents sfpMgmtIpComboBox As ComboBox
    Friend WithEvents devicesFlowsButton As Button
    Friend WithEvents devicesPanel As Panel
    Friend WithEvents devicesRemoveButton As Button
    Friend WithEvents devicesAddButton As Button
    Friend WithEvents devicesApplyButton As Button
    Friend WithEvents devicesListBox As ListBox
    Friend WithEvents devicesDHCPCheckBox As CheckBox
    Friend WithEvents devicesDHCPListBox As ListBox
    Friend WithEvents devicesSNMTextBox As TextBox
    Friend WithEvents devicesSNMLabel As Label
    Friend WithEvents devicesDGTextBox As TextBox
    Friend WithEvents devicesDGLabel As Label
    Friend WithEvents devicesIpTextBox As TextBox
    Friend WithEvents devicesIpLabel As Label
    Friend WithEvents ComboBoxTimer As Timer
    Friend WithEvents getResponseTimer As Timer
    Friend WithEvents devicesDoubleClickLabel As Label
    Friend WithEvents devicesAdaptersComboBox As ComboBox
    Friend WithEvents devicesAdaptersLabel As Label
    Friend WithEvents devicesAccentPanel2 As Panel
    Friend WithEvents devicesAccentPanel1 As Panel
    Friend WithEvents devicesAccentPanel3 As Panel
    Friend WithEvents sfpAccentPanel As Panel
End Class
