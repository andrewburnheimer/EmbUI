Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class MainForm

    Private sfpMgmtIp As String = ""
    Private validIP As Boolean = False
    Private sfpType As String = ""

    Private Sub sfpMgmtIpComboBox_KeyPress(sender As Object, e As KeyEventArgs) Handles sfpMgmtIpComboBox.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Call sfpConnect_Button_Click(sender, e)
        End If
    End Sub

    Private Sub sfpConnect_Button_Click(sender As Object, e As EventArgs) Handles sfpConnectButton.Click

        'Maybe make the connect text box invalid until a real flow is found and a parameter changes so that you can't change the IP while it's still trying, making the MsgBx loop error.

        If sfpMgmtIpComboBox.Text.Length > 0 Then

            sfpMgmtIp = sfpMgmtIpComboBox.Text
            Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")

            'sfpMgmtIpComboBox.Enabled = False

            If Not sfpMgmtIpComboBox.Items.Contains(sfpMgmtIp) Then
                sfpMgmtIpComboBox.Items.Add(sfpMgmtIp)
                devicesListBox.Items.Add(sfpMgmtIp)
            End If

            GetResponse(sfpRequest, Function(x)
                                        Dim f As Flow = JsonConvert.DeserializeObject(Of Flow)(x)
                                        sfpNameTextBox.Text = f.name
                                        sfpType = f.type
                                        sfpFlowIPTextBox.Text = f.network.dst_ip_addr
                                        sfpFlowPortTextBox.Text = f.network.dst_udp_port
                                        sfpFlowSrcIpTextBox.Text = f.network.src_ip_addr
                                        sfpFlowSrcPortTextBox.Text = f.network.src_udp_port
                                        sfpFlowDstMacTextBox.Text = f.network.dst_mac
                                        sfpFlowSsrcTextBox.Text = f.network.ssrc
                                        sfpFlowVlanTagTextBox.Text = f.network.vlan_tag

                                        If sfpType = "2" Then
                                            If Int(f.network.pkt_filter_dst_ip) > 0 Then
                                                sfpFilterDestIPCheckbox.Checked = True
                                            Else
                                                sfpFilterDestIPCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_dst_udp) > 0 Then
                                                sfpFilterDestPortCheckbox.Checked = True
                                            Else
                                                sfpFilterDestPortCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_dst_mac) > 0 Then
                                                sfpFilterDestMACCheckbox.Checked = True
                                            Else
                                                sfpFilterDestMACCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_src_ip) > 0 Then
                                                sfpFilterSrcIPCheckbox.Checked = True
                                            Else
                                                sfpFilterSrcIPCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_src_udp) > 0 Then
                                                sfpFilterSrcPortCheckbox.Checked = True
                                            Else
                                                sfpFilterSrcPortCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_src_mac) > 0 Then
                                                sfpFilterSrcMACCheckbox.Checked = True
                                            Else
                                                sfpFilterSrcMACCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_vlan) > 0 Then
                                                sfpFilterVlanCheckbox.Checked = True
                                            Else
                                                sfpFilterVlanCheckbox.Checked = False
                                            End If

                                            If Int(f.network.pkt_filter_ssrc) > 0 Then
                                                sfpFilterSSRCCheckbox.Checked = True
                                            Else
                                                sfpFilterSSRCCheckbox.Checked = False
                                            End If

                                        End If


                                        sfpFormatCodeValidLabel.Text = f.format_code_valid
                                        sfpFormatCodeTScanLabel.Text = f.format_code_t_scan
                                        sfpFormatCodePScanLabel.Text = f.format_code_p_scan
                                        sfpFormatCodeModeLabel.Text = f.format_code_mode
                                        sfpFormatCodeFormatLabel.Text = f.format_code_format
                                        sfpFormatClkRateLabel.Text = f.format_code_rate
                                        sfpFormatCodeSamplingLabel.Text = f.format_code_sampling

                                        If sfpType = "1" Then
                                            sfpTypeLabel.Text = "Encap (Source)"
                                            sfpNameTextBox.BackColor = Color.PaleGreen
                                            sfpFlowIPTextBox.BackColor = Color.PaleGreen
                                            sfpFlowPortTextBox.BackColor = Color.PaleGreen
                                            sfpFilteringPanel.Enabled = False
                                            encapStatusPanel.Visible = True
                                            encapCounterNote.Visible = True
                                            If sfpFilteringButton.Text = "^" Then
                                                Call sfpFilteringButton_Click(sender, e)
                                            End If

                                        ElseIf sfpType = "2" Then
                                            sfpTypeLabel.Text = "Decap (Dest)"
                                            sfpNameTextBox.BackColor = Color.NavajoWhite
                                            sfpFlowIPTextBox.BackColor = Color.NavajoWhite
                                            sfpFlowPortTextBox.BackColor = Color.NavajoWhite
                                            sfpFilteringPanel.Enabled = True
                                            encapStatusPanel.Visible = False
                                        End If

                                        Return 0
                                    End Function)

            sfpFlowIPTextBox.Enabled = True
            sfpFlowPortTextBox.Enabled = True
            sfpNameTextBox.Enabled = True
            sfpApplyButton.Enabled = True
            CounterTimer.Enabled = True
            sfpAdvancedPanel.Enabled = True
            sfpFormattingPanel.Enabled = True

        Else
            MessageBox.Show("Please enter a Control IP Address.", "EmbSFP Configurator")
        End If


    End Sub

    Private Sub sfpAdvancedButton_Click(sender As Object, e As EventArgs) Handles sfpAdvancedButton.Click
        If sfpAdvancedButton.Text Is "v" Then
            sfpAdvancedPanel.Height = 118
            sfpAdvancedButton.Text = "^"
            Dim aPoint As Point = sfpFormattingPanel.Location
            Dim bPoint As Point = sfpFilteringPanel.Location
            aPoint.Offset(0, 87)
            bPoint.Offset(0, 87)
            sfpFormattingPanel.Location = aPoint
            sfpFilteringPanel.Location = bPoint
        Else
            sfpAdvancedPanel.Height = 31
            sfpAdvancedButton.Text = "v"
            Dim aPoint As Point = sfpFormattingPanel.Location
            Dim bPoint As Point = sfpFilteringPanel.Location
            aPoint.Offset(0, -87)
            bPoint.Offset(0, -87)
            sfpFormattingPanel.Location = aPoint
            sfpFilteringPanel.Location = bPoint
        End If
    End Sub


    Private Sub sfpFormatButton_Click(sender As Object, e As EventArgs) Handles sfpFormatButton.Click
        If sfpFormatButton.Text Is "v" Then
            sfpFormattingPanel.Height = 89
            sfpFormatButton.Text = "^"
            Dim aPoint As Point = sfpFilteringPanel.Location
            aPoint.Offset(0, 58)
            sfpFilteringPanel.Location = aPoint
        Else
            sfpFormattingPanel.Height = 31
            sfpFormatButton.Text = "v"
            Dim aPoint As Point = sfpFilteringPanel.Location
            aPoint.Offset(0, -58)
            sfpFilteringPanel.Location = aPoint
        End If
    End Sub

    Private Sub sfpFilteringButton_Click(sender As Object, e As EventArgs) Handles sfpFilteringButton.Click
        If sfpFilteringButton.Text Is "v" Then
            sfpFilteringPanel.Height = 126
            sfpFilteringButton.Text = "^"
        Else
            sfpFilteringPanel.Height = 38
            sfpFilteringButton.Text = "v"
        End If
    End Sub
    Private Sub GetResponse(ByVal uri As Uri, ByVal callback As Action(Of String))
        Dim wc As New WebClient()
        AddHandler wc.OpenReadCompleted,
            Function(o, a)
                Try
                    If callback IsNot Nothing Then
                        Dim s As StreamReader
                        s = New StreamReader(a.Result)
                        callback(s.ReadToEnd())
                        validIP = True
                    End If
                    Return 0
                Catch ex As Exception
                    validIP = False
                    MessageBox.Show("Problem reaching uri:  " & uri.ToString(), "EmbSFP Configurator")
                    'sfpMgmtIpComboBox.Enabled = True
                    Return -1
                End Try
            End Function
        wc.OpenReadAsync(uri)
    End Sub

    Private Sub CounterTimer_Tick(sender As Object, e As EventArgs) Handles CounterTimer.Tick

        Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")

        If validIP = True Then
            GetResponse(sfpRequest, Function(x)
                                        Dim f As Flow = JsonConvert.DeserializeObject(Of Flow)(x)
                                        If sfpType = "2" Then
                                            flow1SeenCounterLabel.Text = f.network.rx_pkt_cnt
                                            flow1RenderedCounterLabel.Text = f.network.rx_pkt_good_cnt
                                            flow1DroppedCounterLabel.Text = f.network.rx_pkt_filtd_cnt
                                        ElseIf sfpType = "1" Then
                                            flow1SentCounterLabel.Text = f.network.tx_pkt_cnt
                                        End If
                                        Return 0
                                    End Function)
        End If
    End Sub

    Private Sub sfpApplyButton_Click(sender As Object, e As EventArgs) Handles sfpApplyButton.Click
        Dim flowToSend As New Flow
        Dim net As New Network
        flowToSend.network = net

        flowToSend.name = sfpNameTextBox.Text
        flowToSend.network.dst_ip_addr = sfpFlowIPTextBox.Text
        flowToSend.network.dst_udp_port = sfpFlowPortTextBox.Text
        flowToSend.network.src_ip_addr = sfpFlowSrcIpTextBox.Text
        flowToSend.network.src_udp_port = sfpFlowSrcPortTextBox.Text
        flowToSend.network.dst_mac = sfpFlowDstMacTextBox.Text
        flowToSend.network.ssrc = sfpFlowSsrcTextBox.Text
        flowToSend.network.vlan_tag = sfpFlowVlanTagTextBox.Text

        If sfpType = "2" Then
            If sfpFilterDestIPCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_dst_ip = 1
            Else
                flowToSend.network.pkt_filter_dst_ip = 0
            End If

            If sfpFilterDestPortCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_dst_udp = 1
            Else
                flowToSend.network.pkt_filter_dst_udp = 0
            End If

            If sfpFilterDestMACCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_dst_mac = 1
            Else
                flowToSend.network.pkt_filter_dst_mac = 0
            End If

            If sfpFilterSrcIPCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_src_ip = 1
            Else
                flowToSend.network.pkt_filter_src_ip = 0
            End If

            If sfpFilterSrcPortCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_src_udp = 1
            Else
                flowToSend.network.pkt_filter_src_udp = 0
            End If

            If sfpFilterSrcMACCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_src_mac = 1
            Else
                flowToSend.network.pkt_filter_src_mac = 0
            End If

            If sfpFilterVlanCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_vlan = 1
            Else
                flowToSend.network.pkt_filter_vlan = 0
            End If

            If sfpFilterSSRCCheckbox.Checked = True Then
                flowToSend.network.pkt_filter_ssrc = 1
            Else
                flowToSend.network.pkt_filter_ssrc = 0
            End If
        End If


        Dim bodyData As String
        bodyData = JsonConvert.SerializeObject(flowToSend)
        Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")
        IssueHTTPRequest(sfpRequest, "PUT", bodyData)
        'To get updates on format codes and Multicast Address, but the valid flag takes a little while to update and SFPs need resends sometimes and they flip numbers
        Call sfpConnect_Button_Click(sender, e)

        'To send twice or it sometimes doesn't take...
        IssueHTTPRequest(sfpRequest, "PUT", bodyData)
        Call sfpConnect_Button_Click(sender, e)

    End Sub

    Private Function IssueHTTPRequest(ByVal uri As Uri, Optional ByVal method As String = "GET", Optional ByVal data As String = "")
        Dim req As HttpWebRequest = WebRequest.Create(uri)
        req.KeepAlive = False
        req.Method = method.ToUpper()

        If ("POST,PUT").Split(",").Contains(method.ToUpper()) Then
            Dim dataBuffer As Byte() = System.Text.Encoding.ASCII.GetBytes(data)
            req.ContentLength = dataBuffer.Length
            req.ContentType = "application/json"
            Dim PostData As Stream = req.GetRequestStream()
            PostData.Write(dataBuffer, 0, dataBuffer.Length)
            PostData.Close()
        End If

        Dim resp As HttpWebResponse = req.GetResponse()
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding(1252)
        Dim loResponseStream As StreamReader = New StreamReader(resp.GetResponseStream(), enc)
        Dim Response As String = loResponseStream.ReadToEnd()

        loResponseStream.Close()
        resp.Close()
        Return Response
    End Function

    Private Sub sfpDevicesButton_Click(sender As Object, e As EventArgs) Handles sfpDevicesButton.Click
        devicesPanel.Visible = True
    End Sub

    Private Sub devicesFlowsButton_Click(sender As Object, e As EventArgs) Handles devicesFlowsButton.Click
        devicesPanel.Visible = false
    End Sub

    Private Sub devicesIpTextBox_TextChanged(sender As Object, e As EventArgs) Handles devicesIpTextBox.TextChanged
        If devicesIpTextBox.Text.Length > 0 Then
            devicesApplyButton.Enabled = True
        Else
            devicesApplyButton.Enabled = False
        End If
    End Sub

    Private Sub devicesDHCPCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles devicesDHCPCheckBox.CheckedChanged
        If devicesDHCPCheckBox.Checked = False Then
            devicesListBox.Height = 292
        ElseIf devicesDHCPCheckBox.Checked = True Then
            devicesListBox.Height = 160
        End If
    End Sub

    'Private Sub devicesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles devicesListBox.SelectedIndexChanged
    'If devicesListBox.SelectedItem.ToString().Length > 0 Then

    'Dim ipAddr As String = devicesListBox.SelectedItem.ToString()
    'Dim dev As New Device
    'Dim sfpRequest As New Uri("http://" & ipAddr & "/emsfp/ipconfig")

    '       GetResponse(sfpRequest, Function(x)
    '                                   dev = JsonConvert.DeserializeObject(Of Device)(x)
    '                                  devicesIpTextBox.Text = dev.ip_addr
    '                                  devicesSNMTextBox.Text = dev.subnet_mask
    '                                  devicesDGTextBox.Text = dev.gateway

    'Return 0
    'End Function)
    'Else
    '       devicesListBox.SelectedItem = devicesListBox.Items.Item(0)
    'End If

    'End Sub

    Private Sub devicesAddButton_Click(sender As Object, e As EventArgs) Handles devicesAddButton.Click
        devicesListBox.Items.Add(devicesIpTextBox.Text)
        sfpMgmtIpComboBox.Items.Add(devicesIpTextBox.Text)
        'Need to save it somewhere at load and close
    End Sub

    Private Sub devicesRemoveButton_Click(sender As Object, e As EventArgs) Handles devicesRemoveButton.Click
        Dim ipAddr As String = devicesListBox.SelectedItem.ToString()
        devicesListBox.SelectedItems.Remove(ipAddr)
        devicesListBox.Items.Remove(ipAddr)
        sfpMgmtIpComboBox.Items.Remove(ipAddr)
    End Sub

    'Private Sub sfpTypeLabel_TextChanged(sender As Object, e As EventArgs) Handles sfpTypeLabel.TextChanged
    'sfpMgmtIpComboBox.Enabled = True
    'End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        My.Settings.Device0 = devicesListBox.Items.Item(0)
        My.Settings.Device1 = devicesListBox.Items.Item(1)
        My.Settings.Device2 = devicesListBox.Items.Item(2)
        My.Settings.Device3 = devicesListBox.Items.Item(3)

        My.Settings.Save()

        'Obviously have to change this, just testing the Settings function-it's not working, might have to resort to txt file since it uses an xml anyway...
    End Sub

    'Private Sub ComboBoxTimer_Tick(sender As Object, e As EventArgs) Handles ComboBoxTimer.Tick

    'For Each item As String In devicesListBox.Items
    '    If Not sfpMgmtIpComboBox.Items.Contains(item) Then
    '        sfpMgmtIpComboBox.Items.Add(item)
    '    End If
    'Next

    'For Each item As String In sfpMgmtIpComboBox.Items
    'If Not devicesListBox.Items.Contains(item) Then
    'sfpMgmtIpComboBox.Items.Remove(item)
    'End If
    'Next


    'Might not need this counter if just keep lists updated using Add and Remove buttons, can also add using Connect on Flows page

    'End Sub


End Class

Public Class Flow
    Public version As Integer
    Public label As String
    Public id As String
    Public source_id As String
    Public type As Integer
    Public name As String
    Public network As Network
    Public format_code_valid As Integer
    Public format_code_t_scan As Integer
    Public format_code_p_scan As Integer
    Public format_code_mode As Integer
    Public format_code_format As Integer
    Public format_code_rate As Integer
    Public format_code_sampling As Integer
End Class

Public Class Network
    Public src_ip_addr As String
    Public src_udp_port As Integer
    Public dst_ip_addr As String
    Public dst_udp_port As Integer
    Public dst_mac As String
    Public vid_clk_rate As Integer
    Public vlan_tag As Integer
    Public ssrc As Integer
    Public pkt_filter_src_ip As Integer
    Public pkt_filter_src_udp As Integer
    Public pkt_filter_src_mac As Integer
    Public pkt_filter_dst_ip As Integer
    Public pkt_filter_dst_udp As Integer
    Public pkt_filter_dst_mac As Integer
    Public pkt_filter_vlan As Integer
    Public pkt_filter_ssrc As Integer
    Public tx_pkt_cnt As Integer
    Public rx_pkt_cnt As Integer
    Public rx_pkt_good_cnt As Integer
    Public rx_pkt_filtd_cnt As Integer
End Class

Public Class Device
    Public ip_addr As String
    Public subnet_mask As String
    Public gateway As String
End Class
