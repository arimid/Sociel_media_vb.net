Imports MySql.Data.MySqlClient
Public Class NewAcount
    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand

#Region "form moving"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region
    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)

        Return cpu_ids
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Captcha1.Refresh()
    End Sub

#Region " textbox Event"

    Private Sub NewAcount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSerial.Text = CpuId()
    End Sub
    Private Sub TextBoxName_Validated(sender As Object, e As EventArgs) Handles TextBoxName.Validated
        If TextBoxName.Text = "" Then
            TextBoxName.BackColor = Color.Red

        Else
            TextBoxName.BackColor = Color.White
            TextBoxPassword1.ReadOnly = False
            TextBoxPassword2.ReadOnly = False

        End If
    End Sub
    Private Sub TextBoxEmail_Validated(sender As Object, e As EventArgs) Handles TextBoxEmail.Validated
        Dim w As String
        w = InStr(TextBoxEmail.Text, "@gamil.com")
        If w <> 0 Then
            TextBoxName.ReadOnly = False
            TextBoxEmail.ReadOnly = True
        Else
            TextBoxEmail.Text = "@gamil.com"
            TextBoxEmail.ForeColor = Color.Red

        End If
    End Sub
    Private Sub TextBoxPassword2_Validated(sender As Object, e As EventArgs) Handles TextBoxPassword2.Validated
        If TextBoxPassword1.Text = TextBoxPassword2.Text Then
            TextBoxCaptcha.ReadOnly = False

        End If
    End Sub
    Private Sub TextBoxCaptcha_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCaptcha.TextChanged
        If TextBoxCaptcha.Text = Captcha1.CaptchaText Then
            ButtonRegistration.Visible = True

        End If
    End Sub
#End Region
    Private Sub ButtonRegistration_Click(sender As Object, e As EventArgs) Handles ButtonRegistration.Click
        mysqlconnect = New MySqlConnection
        mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"
        Dim mysqlreader As MySqlDataReader

        Try
            mysqlconnect.Open()
            Dim QUERY As String
            QUERY = "insert close.lic (email,username,password,serial)VALUES('" & TextBoxEmail.Text & "','" & TextBoxName.Text & "','" & TextBoxPassword1.Text & "','" & TextBoxSerial.Text & "')"
            mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
            mysqlreader = mysqlcmd.ExecuteReader

            MsgBox("Registration successuflly")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlconnect.Dispose()
            mysqlcmd.Dispose()
            ' mysqlreader.Dispose()

        End Try
    End Sub

#Region "button style"
    'ButtonRegistration
    Private Sub ButtonRegistration_MouseLeave(sender As Object, e As EventArgs) Handles ButtonRegistration.MouseLeave
        ButtonRegistration.BackColor = Color.SkyBlue
        ButtonRegistration.ForeColor = Color.White
    End Sub
    Private Sub ButtonRegistration_MouseHover(sender As Object, e As EventArgs) Handles ButtonRegistration.MouseHover
        ButtonRegistration.BackColor = Color.White
        ButtonRegistration.ForeColor = Color.Black
    End Sub
    'ButtonRefresh
    Private Sub ButtonRefresh_MouseHover(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseHover
        ButtonRefresh.BackColor = Color.SkyBlue
        ButtonRefresh.ForeColor = Color.White
    End Sub
    Private Sub ButtonRefresh_MouseLeave(sender As Object, e As EventArgs) Handles ButtonRefresh.MouseLeave
        ButtonRefresh.BackColor = Color.White
        ButtonRefresh.ForeColor = Color.Black
    End Sub
#End Region

End Class