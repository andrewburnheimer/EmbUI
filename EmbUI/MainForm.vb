Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports Newtonsoft.Json

Public Class MainForm

    Private sfpMgmtIp As String = ""
    Private validIP As Boolean = False
    Private sfpType As String = ""
    Private mycomputerconnections() As Net.NetworkInformation.NetworkInterface
    Private myip As IPAddress
    Private sock As New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP)
    Private bytedata(4096) As Byte
    Private connType As String = ""
    Private ipFrom As IPAddress
    Private deviceConnect As Boolean = False
    'Private wcBusy As Boolean = False

    Private Sub sfpMgmtIpComboBox_KeyPress(sender As Object, e As KeyEventArgs) Handles sfpMgmtIpComboBox.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Call sfpConnect_Button_Click(sender, e)
        End If
    End Sub

    Private Sub sfpConnect_Button_Click(sender As Object, e As EventArgs) Handles sfpConnectButton.Click

        'Maybe make the connect text box invalid until a real flow is found and a parameter changes so that you can't change the IP while it's still trying, making the MsgBx loop error.
        'Shouldn't enable stuff until actual connection is made (no message box saying there's a problem).
        Try
            If sfpMgmtIpComboBox.Text.Length > 0 Then

                sfpFlowIPTextBox.Enabled = False
                sfpFlowPortTextBox.Enabled = False
                sfpNameTextBox.Enabled = False
                sfpApplyButton.Enabled = False
                CounterTimer.Enabled = False
                sfpAdvancedPanel.Enabled = False
                sfpFormattingPanel.Enabled = False
                sfpFilteringPanel.Enabled = False

                sfpMgmtIp = sfpMgmtIpComboBox.Text
                Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")

                'sfpMgmtIpComboBox.Enabled = False

                If Not sfpMgmtIpComboBox.Items.Contains(sfpMgmtIp) Then
                    sfpMgmtIpComboBox.Items.Add(sfpMgmtIp)
                    devicesListBox.Items.Add(sfpMgmtIp)
                End If

                GetResponse(sfpRequest, Function(x)
                                            Try
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

                                                sfpFlowIPTextBox.Enabled = True
                                                sfpFlowPortTextBox.Enabled = True
                                                sfpNameTextBox.Enabled = True
                                                sfpApplyButton.Enabled = True
                                                CounterTimer.Enabled = True
                                                sfpAdvancedPanel.Enabled = True
                                                sfpFormattingPanel.Enabled = True

                                                Return 0
                                            Catch ex As Exception
                                                MessageBox.Show("Connected IP Address might not belong to EmbSFP device.", "EmbSFP Configurator")
                                                Return 0
                                            End Try
                                        End Function)



            Else
                MessageBox.Show("Please enter a Control IP Address.", "EmbSFP Configurator")
            End If

        Catch ex As TimeoutException
            MessageBox.Show("Attempted connection timed out.", "EmbSFP Configurator")
        End Try

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
        'getResponseTimer.Enabled = True
        'wcBusy = True
        'webClientBusy(True)
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
        'getResponseTimer.Enabled = False
        wc.OpenReadAsync(uri)

        'wcBusy = False
        'webClientBusy(False)
    End Sub

    Private Sub webClientBusy(ByVal busy As Boolean)
        If busy Then
            sfpConnectButton.Enabled = False
            sfpFlowIPTextBox.Enabled = False
            sfpFlowPortTextBox.Enabled = False
            sfpNameTextBox.Enabled = False
            sfpApplyButton.Enabled = False
            CounterTimer.Enabled = False
            sfpAdvancedPanel.Enabled = False
            sfpFormattingPanel.Enabled = False
            If sfpType = "2" Then
                sfpFilteringPanel.Enabled = False
            End If
        Else
            sfpConnectButton.Enabled = True
            sfpFlowIPTextBox.Enabled = True
            sfpFlowPortTextBox.Enabled = True
            sfpNameTextBox.Enabled = True
            sfpApplyButton.Enabled = True
            CounterTimer.Enabled = True
            sfpAdvancedPanel.Enabled = True
            sfpFormattingPanel.Enabled = True
            If sfpType = "2" Then
                sfpFilteringPanel.Enabled = True
            End If
        End If
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

    Private Function IssueHTTPRequest(ByVal uri As Uri, Optional ByVal method As String = "GET", Optional ByVal data As String = "", Optional ByVal timeout As Integer = 0)
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

        If req.HaveResponse Then
            Dim resp As HttpWebResponse = req.GetResponse()
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As StreamReader = New StreamReader(resp.GetResponseStream(), enc)
            Dim Response As String = loResponseStream.ReadToEnd()

            loResponseStream.Close()
            resp.Close()
            Return Response
        Else
            Return 0
        End If

    End Function

    Private Sub sfpDevicesButton_Click(sender As Object, e As EventArgs) Handles sfpDevicesButton.Click
        devicesPanel.Visible = True
    End Sub

    Private Sub devicesFlowsButton_Click(sender As Object, e As EventArgs) Handles devicesFlowsButton.Click
        devicesPanel.Visible = False
    End Sub

    Private Sub devicesIpTextBox_TextChanged(sender As Object, e As EventArgs) Handles devicesIpTextBox.TextChanged
        If devicesIpTextBox.Text.Contains(".") And devicesSNMTextBox.Text.Contains(".") And (devicesDGTextBox.Text.Contains(".") Or devicesDGTextBox.Text.Equals("")) Then
            devicesApplyButton.Enabled = True
        Else
            devicesApplyButton.Enabled = False
        End If
    End Sub

    Private Sub devicesSNMTextBox_TextChanged(sender As Object, e As EventArgs) Handles devicesSNMTextBox.TextChanged
        Call devicesIpTextBox_TextChanged(sender, e)
    End Sub

    Private Sub devicesDGTextBox_TextChanged(sender As Object, e As EventArgs) Handles devicesDGTextBox.TextChanged
        Call devicesIpTextBox_TextChanged(sender, e)
    End Sub

    Private Sub devicesDHCPCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles devicesDHCPCheckBox.CheckedChanged
        If devicesDHCPCheckBox.Checked = False Then
            devicesAdaptersLabel.Enabled = False
            devicesAdaptersComboBox.Enabled = False
            devicesListBox.Height = 292
        ElseIf devicesDHCPCheckBox.Checked = True Then
            MessageBox.Show("Please select a Network Adapter that is on the EmbSFP LAN." + Environment.NewLine + Environment.NewLine + "EmbSFPs might not send out DHCP requests immediately.", "EmbSFP Configurator")

            mycomputerconnections = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
            devicesAdaptersComboBox.Items.Clear()
            For i = 0 To mycomputerconnections.Length - 1
                devicesAdaptersComboBox.Items.Add(mycomputerconnections(i).Name)
            Next
            devicesAdaptersLabel.Enabled = True
            devicesAdaptersComboBox.Enabled = True
            devicesListBox.Height = 160
        End If
    End Sub

    Private Sub devicesListBox_MouseDoubleClick(sender As Object, e As EventArgs) Handles devicesListBox.MouseDoubleClick
        Try
            If devicesListBox.SelectedItem.ToString().Length > 0 And devicesListBox.SelectedItem.ToString().Contains(".") Then

                Dim ipAddr As String = devicesListBox.SelectedItem.ToString()
                Dim dev As New Device
                Dim sfpRequest As New Uri("http://" & ipAddr & "/emsfp/ipconfig")

                GetResponse(sfpRequest, Function(x)
                                            dev = JsonConvert.DeserializeObject(Of Device)(x)
                                            devicesIpTextBox.Text = dev.ip_addr
                                            devicesSNMTextBox.Text = dev.subnet_mask
                                            devicesDGTextBox.Text = dev.gateway

                                            Return 0
                                        End Function)
                deviceConnect = True
            End If
        Catch ex As Exception
            If devicesListBox.Items.Count > 0 Then
                devicesListBox.SelectedItem = devicesListBox.Items.Item(devicesListBox.Items.Count - 1)
                deviceConnect = False
            End If

        End Try
    End Sub

    Private Sub devicesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles devicesListBox.SelectedIndexChanged
        devicesIpTextBox.Text = ""
        devicesSNMTextBox.Text = ""
        devicesDGTextBox.Text = ""
        deviceConnect = False
    End Sub

    Private Sub devicesAddButton_Click(sender As Object, e As EventArgs) Handles devicesAddButton.Click
        If devicesIpTextBox.Text.Length > 0 And devicesIpTextBox.Text.Contains(".") Then
            devicesListBox.Items.Add(devicesIpTextBox.Text)
            sfpMgmtIpComboBox.Items.Add(devicesIpTextBox.Text)
        Else
            MessageBox.Show("Please fill in a valid IP Address below before adding it to the list.", "EmbSFP Configurator")
        End If
    End Sub

    Private Sub devicesRemoveButton_Click(sender As Object, e As EventArgs) Handles devicesRemoveButton.Click

        Try
            Dim ipAddr As String = devicesListBox.SelectedItem.ToString()
            Dim selIndex As Integer = devicesListBox.SelectedIndex
            devicesListBox.SelectedItems.Remove(ipAddr)
            devicesListBox.Items.Remove(ipAddr)
            sfpMgmtIpComboBox.Items.Remove(ipAddr)

            If devicesListBox.Items.Count > 0 Then
                devicesListBox.SelectedItem = devicesListBox.Items.Item(0)
            End If

        Catch ex As Exception
            MessageBox.Show("Please select an IP Address from your Device list to remove.", "EmbSFP Configurator")
        End Try

    End Sub

    Private Sub devicesDHCPListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles devicesDHCPListBox.SelectedIndexChanged
        Try
            devicesIpTextBox.Text = ""
            devicesSNMTextBox.Text = ""
            devicesDGTextBox.Text = ""
            devicesIpTextBox.Text = devicesDHCPListBox.SelectedItem.ToString()

            deviceConnect = False
        Catch ex As Exception
            devicesIpTextBox.Text = ""
            deviceConnect = False
        End Try
    End Sub

    Private Sub devicesDHCPListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles devicesDHCPListBox.MouseDoubleClick
        Try
            If devicesDHCPListBox.SelectedItem.ToString().Length > 0 And devicesDHCPListBox.SelectedItem.ToString().Contains(".") Then

                Dim ipAddr As String = devicesDHCPListBox.SelectedItem.ToString()
                Dim dev As New Device
                Dim sfpRequest As New Uri("http://" & ipAddr & "/emsfp/ipconfig")

                GetResponse(sfpRequest, Function(x)
                                            dev = JsonConvert.DeserializeObject(Of Device)(x)
                                            devicesIpTextBox.Text = dev.ip_addr
                                            devicesSNMTextBox.Text = dev.subnet_mask
                                            devicesDGTextBox.Text = dev.gateway

                                            Return 0
                                        End Function)
                deviceConnect = True
            End If
        Catch ex As Exception
            If devicesDHCPListBox.Items.Count > 0 Then
                devicesDHCPListBox.SelectedItem = devicesDHCPListBox.Items.Item(0)
                deviceConnect = False
            End If
        End Try

    End Sub

    'Private Sub sfpTypeLabel_TextChanged(sender As Object, e As EventArgs) Handles sfpTypeLabel.TextChanged
    'sfpMgmtIpComboBox.Enabled = True
    'End Sub


    'Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    'My.Settings.Device0 = devicesListBox.Items.Item(0)
    'My.Settings.Device1 = devicesListBox.Items.Item(1)
    'My.Settings.Device2 = devicesListBox.Items.Item(2)
    'My.Settings.Device3 = devicesListBox.Items.Item(3)

    'My.Settings.Save()

    'Obviously have to change this, just testing the Settings function-it's not working, might have to resort to txt file since it uses an xml anyway...
    'End Sub



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

    Private Sub devicesAdaptersComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles devicesAdaptersComboBox.SelectedIndexChanged
        For i = 0 To mycomputerconnections(devicesAdaptersComboBox.SelectedIndex).GetIPProperties.UnicastAddresses.Count - 1
            If mycomputerconnections(devicesAdaptersComboBox.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then

                myip = mycomputerconnections(devicesAdaptersComboBox.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address
                devicesAdaptersComboBox.BackColor = SystemColors.Window

                BindSocket()
            End If
        Next
    End Sub

    Private Sub BindSocket()
        Try
            devicesAdaptersComboBox.BackColor = SystemColors.Window
            sock.Bind(New IPEndPoint(myip, 0))
            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, True)
            'Might want to try socketoptionlevel.udp but not sure
            Dim bytrue() As Byte = {1, 0, 0, 0}
            Dim byout() As Byte = {1, 0, 0, 0}
            'Look into IOControl paramters
            sock.IOControl(IOControlCode.ReceiveAll, bytrue, byout)
            sock.Blocking = False
            ReDim bytedata(sock.ReceiveBufferSize)
            sock.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)


        Catch ex As Exception
            devicesAdaptersComboBox.BackColor = Color.Red
        End Try
    End Sub

    Private Function Byteswap(ByVal bytes() As Byte, ByVal index As UInteger)
        Dim result(1) As Byte
        result(0) = bytes(index + 1)
        result(1) = bytes(index)
        Return result
    End Function


    Private Sub OnReceive(ByVal asyncresult As IAsyncResult)

        Dim sourceport As UInt16 = BitConverter.ToUInt16(Byteswap(bytedata, 20), 0)
        Dim destinationport As UInt16 = BitConverter.ToUInt16(Byteswap(bytedata, 22), 0)
        Dim ipto As IPAddress = New IPAddress(BitConverter.ToUInt32(bytedata, 16))

        'If bytedata(9) = 6 Then
        '    connType = "TCP"
        'ElseIf bytedata(9) = 17 Then
        '    connType = "UDP"
        '    ipFrom = New IPAddress(BitConverter.ToUInt32(bytedata, 12))
        '    devicesDHCPListBox.Items.Add(ipFrom.ToString())


        'For If: Or ipto.ToString() = "255.255.255.255"
        If sourceport = "68" Or destinationport = "68" Then
            connType = "DHCP Client"
            ipFrom = New IPAddress(BitConverter.ToUInt32(bytedata, 12))
            If Not devicesDHCPListBox.Items.Contains(ipFrom.ToString()) Then
                Me.SetDHCPListBox(ipFrom.ToString())
            End If


            'ElseIf sourceport = "67" Or destinationport = "67" Then
            '    connType = "DHCP Server"
            '    ipFrom = New IPAddress(BitConverter.ToUInt32(bytedata, 12))
            '    If Not devicesDHCPListBox.Items.Contains(ipFrom.ToString()) Then
            '        Me.SetDHCPListBox(ipFrom.ToString())
            '    End If
            'Else
            '        connType = "???"

        End If
        Try
            'Restart the Receiving
            sock.BeginReceive(bytedata, 0, bytedata.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
        Catch ex As Exception
            sock.Close()
        End Try

    End Sub

    Delegate Sub SetDHCPCallback(text As String)

    Private Sub SetDHCPListBox(ByVal text As String)
        If Me.devicesDHCPListBox.InvokeRequired Then
            Dim d As New SetDHCPCallback(AddressOf SetDHCPListBox)
            Me.Invoke(d, New Object() {text})
        Else
            Me.devicesDHCPListBox.Items.Add(text)
        End If
    End Sub

    Private Sub devicesApplyButton_Click(sender As Object, e As EventArgs) Handles devicesApplyButton.Click
        If deviceConnect Then

            Dim deviceToSend As New Device

            'If the JSON Object's parameter doesn't get set like if device.ip_addr is left blank, does it delete what was there or just send nothing and leave whatever it was???
            'Answer: If you don't mention the parameter at all, it will stay the same, but if you send the parameter name with a blank value, it will change it to zero or "", so better to take whatever was there and put it again.

            If devicesIpTextBox.Text.Length > 0 Then
                deviceToSend.ip_addr = devicesIpTextBox.Text
            End If
            If devicesSNMTextBox.Text.Length > 0 Then
                deviceToSend.subnet_mask = devicesSNMTextBox.Text
            End If
            If devicesDGTextBox.Text.Length > 0 Then
                deviceToSend.gateway = devicesDGTextBox.Text
            End If

            Dim bodyData As String
            bodyData = JsonConvert.SerializeObject(deviceToSend)

            Dim deviceIP As String
            If devicesListBox.SelectedIndex.Equals(-1) Then
                deviceIP = devicesDHCPListBox.SelectedItem.ToString()
            ElseIf devicesDHCPListBox.SelectedIndex.Equals(-1) Then
                deviceIP = devicesListBox.SelectedItem.ToString()
            End If

            'wait(0.5)
            Dim sfpRequest As New Uri("http://" & deviceIP & "/emsfp/ipconfig")
            IssueHTTPRequest(sfpRequest, "PUT", bodyData)

            IssueHTTPRequest(sfpRequest, "PUT", bodyData)
            MessageBox.Show("Reconnect to newly configured device in 1 minute to refresh IP, SNM, & DG." + Environment.NewLine + Environment.NewLine + "Before about 1 minute, the device won't respond with accurate addresses.", "EmbSFP Configurator")

        Else
            MessageBox.Show("Please connect to a device first, then use Apply to make careful changes." + Environment.NewLine + Environment.NewLine + Environment.NewLine + "To connect, add an IP to your Device List and double click it." + Environment.NewLine + "Or you can connect to an IP on the DHCP list by double clicking it as well.", "EmbSFP Configurator")

        End If
    End Sub

    Private Sub getResponseTimer_Tick(sender As Object, e As EventArgs) Handles getResponseTimer.Tick
        Throw New TimeoutException("Timeout Exception Occured")
    End Sub

    Private Sub devicesDHCPListBox_MouseClick(sender As Object, e As MouseEventArgs) Handles devicesDHCPListBox.MouseClick
        devicesListBox.SelectedIndex = -1
    End Sub

    Private Sub devicesListBox_MouseClick(sender As Object, e As MouseEventArgs) Handles devicesListBox.MouseClick
        devicesDHCPListBox.SelectedIndex = -1
    End Sub

    'Private Sub wait(ByVal seconds As Integer)
    '    For i As Integer = 0 To seconds * 100
    '        System.Threading.Thread.Sleep(10)
    '        Application.DoEvents()
    '    Next
    'End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        If File.Exists(appDataPath + "\" + Me.CompanyName + "\EmbUI" + "\EmbUIList_config.txt") Then
            Dim listString As String = File.ReadAllText(appDataPath + "\" + Me.CompanyName + "\EmbUI" + "\EmbUIList_config.txt")
            If listString IsNot "" Then
                Dim stringSplit As Array = listString.Split(",")
                For Each item As String In stringSplit
                    devicesListBox.Items.Add(item)
                    sfpMgmtIpComboBox.Items.Add(item)
                Next
            End If
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim listString As String = ""
        If Not devicesListBox.Items.Count = 0 Then
            For Each item As String In devicesListBox.Items
                If listString = "" Then
                    listString = item.ToString()
                Else
                    listString = listString + "," + item.ToString()
                End If
            Next
            If File.Exists(appDataPath + "\" + Me.CompanyName + "\EmbUI") Then
                File.WriteAllText(appDataPath + "\" + Me.CompanyName + "\EmbUI" + "\EmbUIList_config.txt", listString)
            Else
                System.IO.Directory.CreateDirectory(appDataPath + "\" + Me.CompanyName + "\EmbUI")
                File.WriteAllText(appDataPath + "\" + Me.CompanyName + "\EmbUI" + "\EmbUIList_config.txt", listString)
            End If
        End If
    End Sub
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
    Public src_udp_port As String
    Public dst_ip_addr As String
    Public dst_udp_port As String
    Public dst_mac As String
    Public vid_clk_rate As Integer
    Public vlan_tag As String
    Public ssrc As String
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
