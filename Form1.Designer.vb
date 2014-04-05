<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtPassphrase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInitVector = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeySize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdEncrypt = New System.Windows.Forms.Button()
        Me.cmdDecrypt = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(20, 36)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(261, 83)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "Hello, World!"
        '
        'txtPassphrase
        '
        Me.txtPassphrase.Location = New System.Drawing.Point(79, 125)
        Me.txtPassphrase.Name = "txtPassphrase"
        Me.txtPassphrase.Size = New System.Drawing.Size(202, 20)
        Me.txtPassphrase.TabIndex = 3
        Me.txtPassphrase.Text = "Pas5pr@se"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Passphrase"
        '
        'txtSalt
        '
        Me.txtSalt.Location = New System.Drawing.Point(79, 151)
        Me.txtSalt.Name = "txtSalt"
        Me.txtSalt.Size = New System.Drawing.Size(202, 20)
        Me.txtSalt.TabIndex = 5
        Me.txtSalt.Text = "s@1tValue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salt Value"
        '
        'txtIterations
        '
        Me.txtIterations.Location = New System.Drawing.Point(79, 203)
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.Size = New System.Drawing.Size(83, 20)
        Me.txtIterations.TabIndex = 7
        Me.txtIterations.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Iterations"
        '
        'txtInitVector
        '
        Me.txtInitVector.Location = New System.Drawing.Point(79, 177)
        Me.txtInitVector.Name = "txtInitVector"
        Me.txtInitVector.Size = New System.Drawing.Size(132, 20)
        Me.txtInitVector.TabIndex = 9
        Me.txtInitVector.Text = "@1B2c3D4e5F6g7H8"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Init Vector"
        '
        'txtKeySize
        '
        Me.txtKeySize.Location = New System.Drawing.Point(79, 229)
        Me.txtKeySize.Name = "txtKeySize"
        Me.txtKeySize.Size = New System.Drawing.Size(83, 20)
        Me.txtKeySize.TabIndex = 11
        Me.txtKeySize.Text = "256"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Key Size"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(20, 279)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(248, 84)
        Me.txtOutput.TabIndex = 12
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.Location = New System.Drawing.Point(20, 381)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.Size = New System.Drawing.Size(120, 23)
        Me.cmdEncrypt.TabIndex = 13
        Me.cmdEncrypt.Text = "Encrypt"
        Me.cmdEncrypt.UseVisualStyleBackColor = True
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.Location = New System.Drawing.Point(148, 381)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(120, 23)
        Me.cmdDecrypt.TabIndex = 14
        Me.cmdDecrypt.Text = "Decrypt"
        Me.cmdDecrypt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Output:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "16 bytes only"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Input:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 422)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdDecrypt)
        Me.Controls.Add(Me.cmdEncrypt)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtKeySize)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtInitVector)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIterations)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSalt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassphrase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "SHA1 Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtPassphrase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIterations As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInitVector As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKeySize As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmdEncrypt As System.Windows.Forms.Button
    Friend WithEvents cmdDecrypt As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
