Imports MySql.Data.MySqlClient
Public Class ForGotPassword
    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand

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

#Region "moving form"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub ForGotPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub ForGotPassword_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub ForGotPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region


    Private Sub ForGotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = CpuId()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysqlreader As MySqlDataReader
        Dim a As Integer
        a = InStr(TextBox1.Text, "@gmail.com")
        If a <> 0 Then
            'WebBrowser1.Navigate("http://sadik.eu.pn/send.php" + "?mail=" + TextBox3.Text + "&subject=" + TextBox1.Text + "&body=" + TextBox2.Text)

            mysqlconnect = New MySqlConnection
            mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"
            Try
                mysqlconnect.Open()
                Dim QUERY As String
                QUERY = "select * from close.lic where email='" & TextBox1.Text & "' and serial='" & Label1.Text & "' "
                mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
                mysqlreader = mysqlcmd.ExecuteReader

                If mysqlreader.HasRows Then
                    MsgBox("ok")
                    TextBox1.ReadOnly = True
                    TextBox2.ReadOnly = False

                Else
                    MsgBox("Error Email NOt  the  same  email with cpuID")
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                mysqlconnect.Dispose()
                mysqlcmd.Dispose()

            End Try
        Else
            MsgBox("email is  not  correct" & vbCrLf & "werite like  this  example" & vbCrLf & "example@domail.com", vbInformation, "Error email")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("email is  not  correct" & vbCrLf & "werite like  this  example" & vbCrLf & "password#12", vbInformation, "Error password")
        Else
            mysqlconnect = New MySqlConnection
            mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"
            Dim mysqlreader As MySqlDataReader

            Try
                mysqlconnect.Open()
                Dim QUERY As String
                QUERY = "update close.lic set password='" & TextBox2.Text & "' where  email='" & TextBox1.Text & "'"
                mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
                mysqlreader = mysqlcmd.ExecuteReader

                MessageBox.Show("the password changet")
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlconnect.Dispose()
                mysqlcmd.Dispose()
                ' mysqlreader.Dispose()

            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    'button1
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.SkyBlue
        Button1.ForeColor = Color.White

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
    End Sub
    'button2
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.SkyBlue
        Button2.ForeColor = Color.White
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
    End Sub


End Class