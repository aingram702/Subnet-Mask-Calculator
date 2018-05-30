<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubnettingCalc
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
        Me.lblNetworkAddress = New System.Windows.Forms.Label()
        Me.txtOctet1 = New System.Windows.Forms.TextBox()
        Me.lblDot1 = New System.Windows.Forms.Label()
        Me.txtOctet2 = New System.Windows.Forms.TextBox()
        Me.lblDot2 = New System.Windows.Forms.Label()
        Me.txtOctet3 = New System.Windows.Forms.TextBox()
        Me.lblDot3 = New System.Windows.Forms.Label()
        Me.txtOctet4 = New System.Windows.Forms.TextBox()
        Me.lblSubnetQty = New System.Windows.Forms.Label()
        Me.lblSubnetMask = New System.Windows.Forms.Label()
        Me.lblHostQty = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdOpenFile = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubnetMaskAnswer = New System.Windows.Forms.Label()
        Me.txtSubnetQty = New System.Windows.Forms.TextBox()
        Me.lblHostQtyAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNetworkAddress
        '
        Me.lblNetworkAddress.AutoSize = True
        Me.lblNetworkAddress.Location = New System.Drawing.Point(66, 56)
        Me.lblNetworkAddress.Name = "lblNetworkAddress"
        Me.lblNetworkAddress.Size = New System.Drawing.Size(126, 18)
        Me.lblNetworkAddress.TabIndex = 0
        Me.lblNetworkAddress.Text = "Netwok Address:"
        '
        'txtOctet1
        '
        Me.txtOctet1.Location = New System.Drawing.Point(229, 53)
        Me.txtOctet1.Name = "txtOctet1"
        Me.txtOctet1.Size = New System.Drawing.Size(36, 26)
        Me.txtOctet1.TabIndex = 1
        Me.txtOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDot1
        '
        Me.lblDot1.AutoSize = True
        Me.lblDot1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot1.Location = New System.Drawing.Point(271, 60)
        Me.lblDot1.Name = "lblDot1"
        Me.lblDot1.Size = New System.Drawing.Size(13, 19)
        Me.lblDot1.TabIndex = 2
        Me.lblDot1.Text = "."
        '
        'txtOctet2
        '
        Me.txtOctet2.Location = New System.Drawing.Point(290, 53)
        Me.txtOctet2.Name = "txtOctet2"
        Me.txtOctet2.Size = New System.Drawing.Size(36, 26)
        Me.txtOctet2.TabIndex = 3
        Me.txtOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDot2
        '
        Me.lblDot2.AutoSize = True
        Me.lblDot2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot2.Location = New System.Drawing.Point(332, 60)
        Me.lblDot2.Name = "lblDot2"
        Me.lblDot2.Size = New System.Drawing.Size(13, 19)
        Me.lblDot2.TabIndex = 4
        Me.lblDot2.Text = "."
        '
        'txtOctet3
        '
        Me.txtOctet3.Location = New System.Drawing.Point(351, 53)
        Me.txtOctet3.Name = "txtOctet3"
        Me.txtOctet3.Size = New System.Drawing.Size(36, 26)
        Me.txtOctet3.TabIndex = 5
        Me.txtOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDot3
        '
        Me.lblDot3.AutoSize = True
        Me.lblDot3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot3.Location = New System.Drawing.Point(393, 60)
        Me.lblDot3.Name = "lblDot3"
        Me.lblDot3.Size = New System.Drawing.Size(13, 19)
        Me.lblDot3.TabIndex = 6
        Me.lblDot3.Text = "."
        '
        'txtOctet4
        '
        Me.txtOctet4.Location = New System.Drawing.Point(412, 53)
        Me.txtOctet4.Name = "txtOctet4"
        Me.txtOctet4.Size = New System.Drawing.Size(36, 26)
        Me.txtOctet4.TabIndex = 7
        Me.txtOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubnetQty
        '
        Me.lblSubnetQty.AutoSize = True
        Me.lblSubnetQty.Location = New System.Drawing.Point(66, 108)
        Me.lblSubnetQty.Name = "lblSubnetQty"
        Me.lblSubnetQty.Size = New System.Drawing.Size(145, 18)
        Me.lblSubnetQty.TabIndex = 8
        Me.lblSubnetQty.Text = "Number of Subnets:"
        '
        'lblSubnetMask
        '
        Me.lblSubnetMask.AutoSize = True
        Me.lblSubnetMask.Location = New System.Drawing.Point(66, 156)
        Me.lblSubnetMask.Name = "lblSubnetMask"
        Me.lblSubnetMask.Size = New System.Drawing.Size(103, 18)
        Me.lblSubnetMask.TabIndex = 10
        Me.lblSubnetMask.Text = "Subnet Mask:"
        '
        'lblHostQty
        '
        Me.lblHostQty.AutoSize = True
        Me.lblHostQty.Location = New System.Drawing.Point(66, 208)
        Me.lblHostQty.Name = "lblHostQty"
        Me.lblHostQty.Size = New System.Drawing.Size(145, 18)
        Me.lblHostQty.TabIndex = 12
        Me.lblHostQty.Text = "Number of Devices:"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(66, 263)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(84, 18)
        Me.lblFilename.TabIndex = 14
        Me.lblFilename.Text = "File Name:"
        '
        'txtFilename
        '
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilename.Location = New System.Drawing.Point(229, 260)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(200, 26)
        Me.txtFilename.TabIndex = 15
        Me.txtFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(478, 262)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(90, 29)
        Me.cmdBrowse.TabIndex = 16
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(69, 345)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(90, 29)
        Me.cmdCalculate.TabIndex = 17
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdOpenFile
        '
        Me.cmdOpenFile.Location = New System.Drawing.Point(197, 345)
        Me.cmdOpenFile.Name = "cmdOpenFile"
        Me.cmdOpenFile.Size = New System.Drawing.Size(90, 29)
        Me.cmdOpenFile.TabIndex = 18
        Me.cmdOpenFile.Text = "Open File"
        Me.cmdOpenFile.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(339, 345)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(90, 29)
        Me.cmdReset.TabIndex = 19
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(478, 345)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 29)
        Me.cmdExit.TabIndex = 20
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Subnetting Calculator.dv copyright(c) 2018 by andrew ingram"
        '
        'lblSubnetMaskAnswer
        '
        Me.lblSubnetMaskAnswer.BackColor = System.Drawing.SystemColors.Window
        Me.lblSubnetMaskAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubnetMaskAnswer.Location = New System.Drawing.Point(229, 155)
        Me.lblSubnetMaskAnswer.Name = "lblSubnetMaskAnswer"
        Me.lblSubnetMaskAnswer.Size = New System.Drawing.Size(254, 26)
        Me.lblSubnetMaskAnswer.TabIndex = 22
        '
        'txtSubnetQty
        '
        Me.txtSubnetQty.Location = New System.Drawing.Point(229, 100)
        Me.txtSubnetQty.Name = "txtSubnetQty"
        Me.txtSubnetQty.Size = New System.Drawing.Size(36, 26)
        Me.txtSubnetQty.TabIndex = 23
        Me.txtSubnetQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHostQtyAnswer
        '
        Me.lblHostQtyAnswer.BackColor = System.Drawing.SystemColors.Window
        Me.lblHostQtyAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHostQtyAnswer.Location = New System.Drawing.Point(229, 207)
        Me.lblHostQtyAnswer.Name = "lblHostQtyAnswer"
        Me.lblHostQtyAnswer.Size = New System.Drawing.Size(254, 26)
        Me.lblHostQtyAnswer.TabIndex = 24
        '
        'frmSubnettingCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(645, 413)
        Me.Controls.Add(Me.lblHostQtyAnswer)
        Me.Controls.Add(Me.txtSubnetQty)
        Me.Controls.Add(Me.lblSubnetMaskAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdOpenFile)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.lblHostQty)
        Me.Controls.Add(Me.lblSubnetMask)
        Me.Controls.Add(Me.lblSubnetQty)
        Me.Controls.Add(Me.txtOctet4)
        Me.Controls.Add(Me.lblDot3)
        Me.Controls.Add(Me.txtOctet3)
        Me.Controls.Add(Me.lblDot2)
        Me.Controls.Add(Me.txtOctet2)
        Me.Controls.Add(Me.lblDot1)
        Me.Controls.Add(Me.txtOctet1)
        Me.Controls.Add(Me.lblNetworkAddress)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSubnettingCalc"
        Me.Text = "Subnetting Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNetworkAddress As Label
    Friend WithEvents txtOctet1 As TextBox
    Friend WithEvents lblDot1 As Label
    Friend WithEvents txtOctet2 As TextBox
    Friend WithEvents lblDot2 As Label
    Friend WithEvents txtOctet3 As TextBox
    Friend WithEvents lblDot3 As Label
    Friend WithEvents txtOctet4 As TextBox
    Friend WithEvents lblSubnetQty As Label
    Friend WithEvents lblSubnetMask As Label
    Friend WithEvents lblHostQty As Label
    Friend WithEvents lblFilename As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdOpenFile As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubnetMaskAnswer As Label
    Friend WithEvents txtSubnetQty As TextBox
    Friend WithEvents lblHostQtyAnswer As Label
End Class
