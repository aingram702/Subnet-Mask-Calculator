Public Class frmSubnettingCalc
    'Subnetting Calculator.vb copyright(c) 2018 by Andrew Ingram
    'Program will open a dialog box, allow user to type network address, the number of 
    'subnets and the filename that will hold each subnet network address, IP address range and 
    'broadcast address. When the user clicks on the Calculate button, all is calculated.
    Public path As String
    Public newfile As String

    Private Sub frmSubnettingCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNetworkAddress_Click(sender As Object, e As EventArgs) Handles lblNetworkAddress.Click

    End Sub

    Private Sub txtOctet1_TextChanged(sender As Object, e As EventArgs) Handles txtOctet1.TextChanged

    End Sub

    Private Sub txtOctet2_TextChanged(sender As Object, e As EventArgs) Handles txtOctet2.TextChanged

    End Sub

    Private Sub txtOctet3_TextChanged(sender As Object, e As EventArgs) Handles txtOctet3.TextChanged

    End Sub

    Private Sub txtOctet4_TextChanged(sender As Object, e As EventArgs) Handles txtOctet4.TextChanged

    End Sub

    Private Sub lblSubnetQty_Click(sender As Object, e As EventArgs) Handles lblSubnetQty.Click

    End Sub

    Private Sub txtSubnetQty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSubnetMask_Click(sender As Object, e As EventArgs) Handles lblSubnetMask.Click

    End Sub

    Private Sub txtSubnetMaskAnswer_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHostQty_Click(sender As Object, e As EventArgs) Handles lblHostQty.Click

    End Sub

    Private Sub txtHostQtyAnswer_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblFilename_Click(sender As Object, e As EventArgs) Handles lblFilename.Click

    End Sub

    Private Sub txtFilename_TextChanged(sender As Object, e As EventArgs) Handles txtFilename.TextChanged

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        'find the folder to write a subnet file to
        Dim FolderBrowser As New FolderBrowserDialog

        FolderBrowser.ShowNewFolderButton = False
        FolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        FolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = FolderBrowser.SelectedPath & "\"
        End If

    End Sub

    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        'declare variables
        Dim octet1 As Double
        Dim octet2 As Double
        Dim octet3 As Double
        Dim octet4 As Double
        Dim subnet As Double
        Dim subnet_last_octet As String
        Dim netIP As String
        Dim IpRange As String
        Dim Broadcast As String
        Dim counter As Double

        'set variables
        octet1 = txtOctet1.Text
        octet2 = txtOctet2.Text
        octet3 = txtOctet3.Text
        octet4 = txtOctet4.Text
        subnet = txtSubnetQty.Text
        newfile = txtFilename.Text

        'calculate mask
        If subnet = 1 Then
            subnet_last_octet = "0"
            subnet = 1
        End If
        If subnet > 1 And subnet <= 2 Then
            subnet_last_octet = "128"
            subnet = 2
        End If
        If subnet > 2 And subnet <= 4 Then
            subnet_last_octet = "192"
            subnet = 4
        End If
        If subnet > 4 And subnet <= 8 Then
            subnet_last_octet = "224"
            subnet = 8
        End If
        If subnet > 8 And subnet <= 16 Then
            subnet_last_octet = "240"
            subnet = 16
        End If
        If subnet > 16 And subnet <= 32 Then
            subnet_last_octet = "248"
            subnet = 32
        End If
        If subnet > 32 And subnet <= 64 Then
            subnet_last_octet = "252"
            subnet = 64
        End If
        If subnet > 64 And subnet <= 128 Then
            subnet_last_octet = "254"
            subnet = 128
        End If
        If subnet > 128 And subnet <= 256 Then
            subnet_last_octet = "255"
            subnet = 256
        End If

        'set subnet mask for class A network
        If octet1 >= 1 And octet1 <= 126 Then
            lblSubnetMaskAnswer.Text = "255" & subnet_last_octet & ".0.0"
            lblHostQtyAnswer.Text = 2 ^ 24 / subnet - 2
            My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "Subnet" & vbTab & "Netwok IP" & vbTab & vbTab & "IP Range" & vbTab & vbTab & vbTab * "Broadcast IP" & vbCrLf, True)
            counter = 0
            Do While counter < subnet
                netIP = Str(octet1) & "." & Str(octet2 + (256 / subnet) * counter) & "." & Str(octet3) & "." & Str(octet4)
                Broadcast = Str(octet1) & "." & Str(octet2 + (256 / subnet) * (counter + 1) - 1) & ".255" & ".255"
                IpRange = Str(octet1) & "." & Str(octet2 + (256 / subnet) * counter) & "." & Str(octet3) & "." & Str(octet4 + 1) & "-" & Str(octet1) & "." & Str(octet2 + (256 / subnet) * (counter + 1) - 1) & ".255" & ".254"
                My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "" & Str(counter + 1) & vbTab & netIP & vbTab & IpRange & vbTab & Broadcast & vbCrLf, True)
                counter = counter + 1
            Loop
        End If

        'set subnet mask for class B network
        If octet1 >= 128 And octet1 <= 191 Then
            lblSubnetMaskAnswer.Text = "255.255" & subnet_last_octet & ".0"
            lblHostQtyAnswer.Text = 2 ^ 16 / subnet - 2
            counter = 0
            My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "Subnet" & vbTab & "Netwok IP" & vbTab & vbTab & "IP Range" & vbTab & vbTab & vbTab * "Broadcast IP" & vbCrLf, True)
            Do While counter < subnet
                netIP = Str(octet1) & "." & Str(octet2) & "." & Str(octet3 + (256 / subnet) * counter) & "." & Str(octet4)
                Broadcast = Str(octet1) & "." & Str(octet2) & "." & Str(octet3 + (256 / subnet) * (counter + 1) - 1) & ".255"
                IpRange = Str(octet1) & "." & Str(octet2) & "." & Str(octet3 + (256 / subnet) * (counter + 1) - 1) & ".254"
                My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "" & Str(counter + 1) & vbTab & netIP & vbTab & IpRange & vbTab & Broadcast & vbCrLf, True)
                counter = counter + 1
            Loop
        End If

        'subnet mask for class C network
        If octet1 >= 192 And octet1 <= 223 Then
            lblSubnetMaskAnswer.Text = "255.255.255." & subnet_last_octet
            lblHostQtyAnswer.Text = 2 ^ 8 / subnet - 2
            counter = 0
            My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "Subnet" & vbTab & "Netwok IP" & vbTab & vbTab & "IP Range" & vbTab & vbTab & vbTab & "Broadcast IP" & vbCrLf, True)
            Do While counter < subnet
                netIP = Str(octet1) & "." & Str(octet2) & "." & Str(octet3) & "." & Str(octet4 + (256 / subnet) * counter)
                Broadcast = Str(octet1) & "." & Str(octet2) & "." & Str(octet3) & "." & Str(octet4 + (256 / subnet) * (counter + 1) - 1)
                IpRange = Str(octet1) & "." & Str(octet2) & "." & Str(octet3) & "." & Str(octet4 + (256 / subnet) * counter + 1) & "-" & Str(octet1) & "." & Str(octet3) & "." & Str(octet4 + (256 / subnet) * (counter + 1) - 2)
                My.Computer.FileSystem.WriteAllText(path & newfile & ".txt", "" & Str(counter + 1) & vbTab & netIP & vbTab & IpRange & vbTab & Broadcast & vbCrLf, True)
                counter = counter + 1
            Loop
        End If
    End Sub

    Private Sub cmdOpenFile_Click(sender As Object, e As EventArgs) Handles cmdOpenFile.Click
        'open the file to view and print
        System.Diagnostics.Process.Start("Notepad", path & newfile & ".txt")
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        'clear textboxes, labels, and path
        txtOctet1.Text = ""
        txtOctet2.Text = ""
        txtOctet3.Text = ""
        txtOctet4.Text = ""
        txtSubnetQty.Text = ""
        lblSubnetMaskAnswer.Text = ""
        lblHostQtyAnswer.Text = ""
        txtFilename.Text = ""
        path = ""

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'unload and exit the program
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblSubnetMaskAnswer.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblHostQtyAnswer.Click

    End Sub
End Class
