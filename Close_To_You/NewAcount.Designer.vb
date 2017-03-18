<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAcount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPassword2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSerial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCaptcha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Captcha1 = New Close_To_You.Captcha()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Captcha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxName.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxName.Location = New System.Drawing.Point(116, 65)
        Me.TextBoxName.Multiline = True
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(210, 36)
        Me.TextBoxName.TabIndex = 1
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistration.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistration.Location = New System.Drawing.Point(66, 348)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(275, 45)
        Me.ButtonRegistration.TabIndex = 2
        Me.ButtonRegistration.Text = "&Registration"
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        Me.ButtonRegistration.Visible = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(252, 314)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(89, 31)
        Me.ButtonRefresh.TabIndex = 3
        Me.ButtonRefresh.Text = "&Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxEmail.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxEmail.Location = New System.Drawing.Point(116, 21)
        Me.TextBoxEmail.Multiline = True
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(210, 36)
        Me.TextBoxEmail.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Email:"
        '
        'TextBoxPassword1
        '
        Me.TextBoxPassword1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxPassword1.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword1.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxPassword1.Location = New System.Drawing.Point(116, 108)
        Me.TextBoxPassword1.Multiline = True
        Me.TextBoxPassword1.Name = "TextBoxPassword1"
        Me.TextBoxPassword1.ReadOnly = True
        Me.TextBoxPassword1.Size = New System.Drawing.Size(210, 36)
        Me.TextBoxPassword1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Password:"
        '
        'TextBoxPassword2
        '
        Me.TextBoxPassword2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxPassword2.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword2.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxPassword2.Location = New System.Drawing.Point(116, 150)
        Me.TextBoxPassword2.Multiline = True
        Me.TextBoxPassword2.Name = "TextBoxPassword2"
        Me.TextBoxPassword2.ReadOnly = True
        Me.TextBoxPassword2.Size = New System.Drawing.Size(210, 32)
        Me.TextBoxPassword2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "&RePassword:"
        '
        'TextBoxSerial
        '
        Me.TextBoxSerial.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxSerial.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSerial.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxSerial.Location = New System.Drawing.Point(116, 190)
        Me.TextBoxSerial.Multiline = True
        Me.TextBoxSerial.Name = "TextBoxSerial"
        Me.TextBoxSerial.ReadOnly = True
        Me.TextBoxSerial.Size = New System.Drawing.Size(210, 32)
        Me.TextBoxSerial.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "&Serial:"
        '
        'TextBoxCaptcha
        '
        Me.TextBoxCaptcha.Font = New System.Drawing.Font("Minion Pro Med", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCaptcha.Location = New System.Drawing.Point(66, 314)
        Me.TextBoxCaptcha.Multiline = True
        Me.TextBoxCaptcha.Name = "TextBoxCaptcha"
        Me.TextBoxCaptcha.ReadOnly = True
        Me.TextBoxCaptcha.Size = New System.Drawing.Size(167, 31)
        Me.TextBoxCaptcha.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Close_To_You.My.Resources.Resources.blue_cross
        Me.PictureBox1.Location = New System.Drawing.Point(345, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Captcha1
        '
        Me.Captcha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Captcha1.CaptchaTextLength = 8
        Me.Captcha1.Location = New System.Drawing.Point(66, 239)
        Me.Captcha1.Name = "Captcha1"
        Me.Captcha1.NumberOfLines = 50
        Me.Captcha1.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
        Me.Captcha1.Size = New System.Drawing.Size(241, 69)
        Me.Captcha1.TabIndex = 14
        Me.Captcha1.TabStop = False
        Me.Captcha1.TextColor = System.Drawing.Color.Black
        '
        'NewAcount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(376, 406)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Captcha1)
        Me.Controls.Add(Me.TextBoxCaptcha)
        Me.Controls.Add(Me.TextBoxSerial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxPassword2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPassword1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonRegistration)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewAcount"
        Me.Text = "NewAcount"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Captcha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRegistration As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents Captcha1 As Close_To_You.Captcha
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
