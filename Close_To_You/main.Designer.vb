<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.RichChatRead = New System.Windows.Forms.RichTextBox()
        Me.RichChatSend = New System.Windows.Forms.RichTextBox()
        Me.ButtonChatSend = New System.Windows.Forms.Button()
        Me.RichPostStatus = New System.Windows.Forms.RichTextBox()
        Me.ButtonPostStatus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WebKitBrowser1 = New WebKit.WebKitBrowser()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichChatRead
        '
        Me.RichChatRead.Location = New System.Drawing.Point(12, 12)
        Me.RichChatRead.Name = "RichChatRead"
        Me.RichChatRead.ReadOnly = True
        Me.RichChatRead.Size = New System.Drawing.Size(262, 398)
        Me.RichChatRead.TabIndex = 0
        Me.RichChatRead.Text = ""
        '
        'RichChatSend
        '
        Me.RichChatSend.Location = New System.Drawing.Point(12, 416)
        Me.RichChatSend.Name = "RichChatSend"
        Me.RichChatSend.Size = New System.Drawing.Size(193, 42)
        Me.RichChatSend.TabIndex = 1
        Me.RichChatSend.Text = ""
        '
        'ButtonChatSend
        '
        Me.ButtonChatSend.Location = New System.Drawing.Point(211, 416)
        Me.ButtonChatSend.Name = "ButtonChatSend"
        Me.ButtonChatSend.Size = New System.Drawing.Size(63, 42)
        Me.ButtonChatSend.TabIndex = 3
        Me.ButtonChatSend.Text = "&Send"
        Me.ButtonChatSend.UseVisualStyleBackColor = True
        '
        'RichPostStatus
        '
        Me.RichPostStatus.Location = New System.Drawing.Point(281, 13)
        Me.RichPostStatus.Name = "RichPostStatus"
        Me.RichPostStatus.Size = New System.Drawing.Size(569, 82)
        Me.RichPostStatus.TabIndex = 4
        Me.RichPostStatus.Text = ""
        '
        'ButtonPostStatus
        '
        Me.ButtonPostStatus.Location = New System.Drawing.Point(856, 13)
        Me.ButtonPostStatus.Name = "ButtonPostStatus"
        Me.ButtonPostStatus.Size = New System.Drawing.Size(79, 82)
        Me.ButtonPostStatus.TabIndex = 6
        Me.ButtonPostStatus.Text = "&POST"
        Me.ButtonPostStatus.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Close_To_You.My.Resources.Resources.blue_cross
        Me.PictureBox1.Location = New System.Drawing.Point(1119, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 464)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(193, 20)
        Me.TextBox1.TabIndex = 9
        '
        'WebKitBrowser1
        '
        Me.WebKitBrowser1.BackColor = System.Drawing.Color.White
        Me.WebKitBrowser1.Location = New System.Drawing.Point(281, 101)
        Me.WebKitBrowser1.Name = "WebKitBrowser1"
        Me.WebKitBrowser1.Size = New System.Drawing.Size(654, 309)
        Me.WebKitBrowser1.TabIndex = 11
        Me.WebKitBrowser1.Url = Nothing
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1151, 487)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonPostStatus)
        Me.Controls.Add(Me.RichPostStatus)
        Me.Controls.Add(Me.ButtonChatSend)
        Me.Controls.Add(Me.RichChatSend)
        Me.Controls.Add(Me.RichChatRead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.Text = "main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichChatRead As System.Windows.Forms.RichTextBox
    Friend WithEvents RichChatSend As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonChatSend As System.Windows.Forms.Button
    Friend WithEvents RichPostStatus As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonPostStatus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WebKitBrowser1 As WebKit.WebKitBrowser
End Class
