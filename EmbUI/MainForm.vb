Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class MainForm

    Private sfpMgmtIp As String = ""
    Private validIP As Boolean = False

    Private Sub sfpConnect_Button_Click(sender As Object, e As EventArgs) Handles sfpConnectButton.Click
        ' When device is determined to be a decapsulator, scootch sfpFormattingPanel.Location with Offset() down, and set sfpFilterPanel.visible = True

        sfpMgmtIp = sfpMgmtIpTextBox.Text
        Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")

        sfpFlowIPTextBox.Enabled = True
        sfpFlowPortTextBox.Enabled = True
        sfpNameTextBox.Enabled = True
        sfpFlowDstMacTextBox.Enabled = True
        sfpFlowSrcIpTextBox.Enabled = True
        sfpFlowSrcPortTextBox.Enabled = True
        sfpFlowSsrcTextBox.Enabled = True
        sfpFlowVlanTagTextBox.Enabled = True
        sfpApplyButton.Enabled = True
        CounterTimer.Enabled = True

        GetResponse(sfpRequest, Function(x)
                                    Dim f As Flow = JsonConvert.DeserializeObject(Of Flow)(x)
                                    sfpNameTextBox.Text = f.name
                                    sfpTypeLabel.Text = f.type
                                    sfpFlowIPTextBox.Text = f.network.dst_ip_addr
                                    sfpFlowPortTextBox.Text = f.network.dst_udp_port
                                    sfpFlowSrcIpTextBox.Text = f.network.src_ip_addr
                                    sfpFlowSrcPortTextBox.Text = f.network.src_udp_port
                                    sfpFlowDstMacTextBox.Text = f.network.dst_mac
                                    sfpFlowSsrcTextBox.Text = f.network.ssrc
                                    sfpFlowVlanTagTextBox.Text = f.network.vlan_tag

                                    If Int(f.network.pkt_filter_dst_ip) > 0 Then
                                        sfpFilterDestIPCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_dst_udp) > 0 Then
                                        sfpFilterDestPortCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_dst_mac) > 0 Then
                                        sfpFilterDestMACCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_src_ip) > 0 Then
                                        sfpFilterSrcIPCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_src_udp) > 0 Then
                                        sfpFilterSrcPortCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_src_mac) > 0 Then
                                        sfpFilterSrcMACCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_vlan) > 0 Then
                                        sfpFilterVlanCheckbox.Checked = True
                                    End If
                                    If Int(f.network.pkt_filter_ssrc) > 0 Then
                                        sfpFilterSSRCCheckbox.Checked = True
                                    End If

                                    sfpFormatCodeValidLabel.Text = f.format_code_valid
                                    sfpFormatCodeTScanLabel.Text = f.format_code_t_scan
                                    sfpFormatCodePScanLabel.Text = f.format_code_p_scan
                                    sfpFormatCodeModeLabel.Text = f.format_code_mode
                                    sfpFormatCodeFormatLabel.Text = f.format_code_format
                                    sfpFormatClkRateLabel.Text = f.format_code_rate
                                    sfpFormatCodeSamplingLabel.Text = f.format_code_sampling

                                    Return 0
                                End Function)

        If sfpTypeLabel.Text = "1" Then
            sfpNameTextBox.BackColor = Color.PaleGreen
            sfpFlowIPTextBox.BackColor = Color.PaleGreen
            sfpFlowPortTextBox.BackColor = Color.PaleGreen
        End If

        If sfpTypeLabel.Text = "2" Then
            sfpNameTextBox.BackColor = Color.LightSalmon
            sfpFlowIPTextBox.BackColor = Color.LightSalmon
            sfpFlowPortTextBox.BackColor = Color.LightSalmon
        End If

    End Sub

    Private Sub sfpAdvancedButton_Click(sender As Object, e As EventArgs) Handles sfpAdvancedButton.Click
        If sfpAdvancedButton.Text Is "v" Then
            sfpAdvancedPanel.Height = 118
            sfpAdvancedButton.Text = "^"
            Dim aPoint As Point = sfpFormattingPanel.Location
            aPoint.Offset(0, 87)
            sfpFormattingPanel.Location = aPoint
        Else
            sfpAdvancedPanel.Height = 31
            sfpAdvancedButton.Text = "v"
            Dim aPoint As Point = sfpFormattingPanel.Location
            aPoint.Offset(0, -87)
            sfpFormattingPanel.Location = aPoint
        End If
    End Sub


    Private Sub sfpFormatButton_Click(sender As Object, e As EventArgs) Handles sfpFormatButton.Click
        If sfpFormatButton.Text Is "v" Then
            sfpFormattingPanel.Height = 89
            sfpFormatButton.Text = "^"
        Else
            sfpFormattingPanel.Height = 31
            sfpFormatButton.Text = "v"
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
                    End If
                    validIP = True
                    Return 0
                Catch ex As Exception
                    validIP = False
                    MessageBox.Show("Problem reaching uri:  " & uri.ToString(), "EmbUI")
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
                                        flow1SeenCounterLabel.Text = f.network.rx_pkt_cnt
                                        flow1RenderedCounterLabel.Text = f.network.rx_pkt_good_cnt
                                        flow1DroppedCounterLabel.Text = f.network.rx_pkt_filtd_cnt
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

        Dim bodyData As String
        bodyData = JsonConvert.SerializeObject(flowToSend)
        Dim sfpRequest As New Uri("http://" & sfpMgmtIp & "/emsfp/node/v1/flows")
        IssueHTTPRequest(sfpRequest, "PUT", bodyData)

        'To get updates on format codes, but the valid flag takes a little while to update
        GetResponse(sfpRequest, Function(x)
                                    Dim f As Flow = JsonConvert.DeserializeObject(Of Flow)(x)
                                    sfpFormatCodeValidLabel.Text = f.format_code_valid
                                    sfpFormatCodeTScanLabel.Text = f.format_code_t_scan
                                    sfpFormatCodePScanLabel.Text = f.format_code_p_scan
                                    sfpFormatCodeModeLabel.Text = f.format_code_mode
                                    sfpFormatCodeFormatLabel.Text = f.format_code_format
                                    sfpFormatClkRateLabel.Text = f.format_code_rate
                                    sfpFormatCodeSamplingLabel.Text = f.format_code_sampling

                                    Return 0
                                End Function)

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
