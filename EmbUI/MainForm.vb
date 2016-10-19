Public Class MainForm
    Private Sub sfpConnect_Button_Click(sender As Object, e As EventArgs) Handles sfpConnectButton.Click
        ' When device is determined to be a decapsulator, scootch sfpFormattingPanel.Location with Offset() down, and set sfpFilterPanel.visible = True
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles sfpAdvancedPanel.Paint

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
End Class
