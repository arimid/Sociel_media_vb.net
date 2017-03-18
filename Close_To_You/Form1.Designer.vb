<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.Label_internet = New System.Windows.Forms.Label()
        Me.Label_databse = New System.Windows.Forms.Label()
        Me.ButtonForgot = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonNewACount = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(24, 34)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(35, 13)
        Me.LabelEmail.TabIndex = 0
        Me.LabelEmail.Text = "&Email:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxEmail.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxEmail.Location = New System.Drawing.Point(125, 31)
        Me.TextBoxEmail.Multiline = True
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(261, 30)
        Me.TextBoxEmail.TabIndex = 0
        '
        'ButtonLogin
        '
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(27, 121)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(359, 42)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "&Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(401, 31)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(220, 313)
        Me.WebBrowser1.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxPassword.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.SkyBlue
        Me.TextBoxPassword.Location = New System.Drawing.Point(125, 77)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(261, 30)
        Me.TextBoxPassword.TabIndex = 1
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(24, 80)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(56, 13)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "&Password:"
        '
        'Label_internet
        '
        Me.Label_internet.AutoSize = True
        Me.Label_internet.Location = New System.Drawing.Point(112, 368)
        Me.Label_internet.Name = "Label_internet"
        Me.Label_internet.Size = New System.Drawing.Size(39, 13)
        Me.Label_internet.TabIndex = 7
        Me.Label_internet.Text = "Label3"
        '
        'Label_databse
        '
        Me.Label_databse.AutoSize = True
        Me.Label_databse.Location = New System.Drawing.Point(426, 368)
        Me.Label_databse.Name = "Label_databse"
        Me.Label_databse.Size = New System.Drawing.Size(39, 13)
        Me.Label_databse.TabIndex = 8
        Me.Label_databse.Text = "Label4"
        '
        'ButtonForgot
        '
        Me.ButtonForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonForgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonForgot.Location = New System.Drawing.Point(207, 185)
        Me.ButtonForgot.Name = "ButtonForgot"
        Me.ButtonForgot.Size = New System.Drawing.Size(179, 42)
        Me.ButtonForgot.TabIndex = 3
        Me.ButtonForgot.Text = "&ForGot Password"
        Me.ButtonForgot.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Close_To_You.My.Resources.Resources.blue_cross
        Me.PictureBox2.Location = New System.Drawing.Point(604, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'ButtonNewACount
        '
        Me.ButtonNewACount.BackgroundImage = Global.Close_To_You.My.Resources.Resources.blue_button13
        Me.ButtonNewACount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonNewACount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNewACount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewACount.Location = New System.Drawing.Point(207, 233)
        Me.ButtonNewACount.Name = "ButtonNewACount"
        Me.ButtonNewACount.Size = New System.Drawing.Size(179, 111)
        Me.ButtonNewACount.TabIndex = 4
        Me.ButtonNewACount.Text = "&Create New Acount"
        Me.ButtonNewACount.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(27, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 397)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonNewACount)
        Me.Controls.Add(Me.ButtonForgot)
        Me.Controls.Add(Me.Label_databse)
        Me.Controls.Add(Me.Label_internet)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents Label_internet As System.Windows.Forms.Label
    Friend WithEvents Label_databse As System.Windows.Forms.Label
    Friend WithEvents ButtonForgot As System.Windows.Forms.Button
    Friend WithEvents ButtonNewACount As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
