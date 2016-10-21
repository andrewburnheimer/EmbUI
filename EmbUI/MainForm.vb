Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class MainForm
    Private Sub sfpConnect_Button_Click(sender As Object, e As EventArgs) Handles sfpConnectButton.Click
        ' When device is determined to be a decapsulator, scootch sfpFormattingPanel.Location with Offset() down, and set sfpFilterPanel.visible = True

        Dim sfpRequest As New Uri("http://" & sfpMgmtIpTextBox.Text & "/emsfp/node/v1/flows")

        sfpFlowIPTextBox.Enabled = True
        sfpFlowPortTextBox.Enabled = True
        sfpNameTextBox.Enabled = True
        sfpFlowDstMacTextBox.Enabled = True
        sfpFlowSrcIpTextBox.Enabled = True
        sfpFlowSrcPortTextBox.Enabled = True
        sfpFlowSsrcTextBox.Enabled = True
        sfpFlowVlanTagTextBox.Enabled = True
        Timer1.Enabled = True

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sfpAdvancedButton.Click
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
                    Return 0
                Catch ex As Exception
                    MessageBox.Show("Problem reaching uri:  " & uri.ToString(), "EmbUI")
                    Return -1
                End Try
            End Function
        wc.OpenReadAsync(uri)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim sfpRequest As New Uri("http://" & sfpMgmtIpTextBox.Text & "/emsfp/node/v1/flows")

        GetResponse(sfpRequest, Function(x)
                                    Dim f As Flow = JsonConvert.DeserializeObject(Of Flow)(x)
                                    flow1SeenCounterLabel.Text = f.network.rx_pkt_cnt
                                    flow1RenderedCounterLabel.Text = f.network.rx_pkt_good_cnt
                                    flow1DroppedCounterLabel.Text = f.network.rx_pkt_filtd_cnt
                                    Return 0
                                End Function)
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
