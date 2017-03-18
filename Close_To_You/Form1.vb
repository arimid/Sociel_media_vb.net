Imports MySql.Data.MySqlClient
Imports Close_To_You.PassingValue
Public Class FormLogin
    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand
    Dim mysqlreader As MySqlDataReader
    Dim myQRcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder


#Region "moving form"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub FormLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region


#Region "Button_Style"
    'buttonLogin 
    Private Sub ButtonLogin_MouseHover(sender As Object, e As EventArgs) Handles ButtonLogin.MouseHover
        ButtonLogin.BackColor = Color.SkyBlue
        ButtonLogin.ForeColor = Color.White
    End Sub
    Private Sub ButtonLogin_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLogin.MouseLeave
        ButtonLogin.BackColor = Color.White
        ButtonLogin.ForeColor = Color.Black
    End Sub
    'ButtonForgot
    Private Sub ButtonForgot_MouseHover(sender As Object, e As EventArgs) Handles ButtonForgot.MouseHover
        ButtonForgot.BackColor = Color.SkyBlue
        ButtonForgot.ForeColor = Color.White
    End Sub
    Private Sub ButtonForgot_MouseLeave(sender As Object, e As EventArgs) Handles ButtonForgot.MouseLeave
        ButtonForgot.BackColor = Color.White
        ButtonForgot.ForeColor = Color.Black
    End Sub
    'buttonNewAcount
    Private Sub ButtonNewACount_MouseHover(sender As Object, e As EventArgs) Handles ButtonNewACount.MouseHover
        ButtonNewACount.BackColor = Color.SkyBlue
        ButtonNewACount.ForeColor = Color.White
    End Sub
    Private Sub ButtonNewACount_MouseLeave(sender As Object, e As EventArgs) Handles ButtonNewACount.MouseLeave
        ButtonNewACount.BackColor = Color.White
        ButtonNewACount.ForeColor = Color.Black
    End Sub
#End Region

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxEmail.Text = setvar

        WebBrowser1.DocumentText = "<MARQUEE DIRECTION=LEFT><a href='http://www.guercif.cf/' style='font-color:#3399ff'>PUt Your Ads here</a></MARQUEE>"
        Dim inic As New connect_database()
        Dim inter_net As New connect_internet()

        '------
        If inter_net.internet = True Then
            Label_internet.ForeColor = Color.DodgerBlue
            Label_internet.Text = "Internet Conected"
            Label_internet.Visible = True

        Else
            Label_internet.ForeColor = Color.Crimson
            Label_internet.Text = "No Internet Connection"
            Label_internet.Visible = True
        End If

        '----------
        If inic.get_data = True Then
            Label_databse.ForeColor = Color.DodgerBlue
            Label_databse.Text = "Database Connected"
            Label_databse.Visible = True
        Else
            Label_databse.ForeColor = Color.Crimson
            Label_databse.Text = "Database Error Conniction"
            Label_databse.Visible = True
            TextBoxEmail.ReadOnly = True
            TextBoxPassword.ReadOnly = True

        End If
    End Sub

    Private Sub ButtonForgot_Click(sender As Object, e As EventArgs) Handles ButtonForgot.Click
        ForGotPassword.Show()
    End Sub

    Private Sub ButtonNewACount_Click(sender As Object, e As EventArgs) Handles ButtonNewACount.Click
        NewAcount.Show()
    End Sub
    Private Sub sevevars()
        setvarAuto = TextBoxEmail.Text
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim x1 As Integer
        x1 = InStr(TextBoxEmail.Text, "@gmail.com")
        If x1 <> 0 Then
            mysqlconnect = New MySqlConnection
            mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"


            Try
                mysqlconnect.Open()
                Dim QUERY As String
                QUERY = "select * from close.lic where email='" & TextBoxEmail.Text & "' and password='" & TextBoxPassword.Text & "' "
                mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
                mysqlreader = mysqlcmd.ExecuteReader

                Dim count As Integer
                count = 0
                While mysqlreader.Read
                    count = count + 1

                End While

                If count = 1 Then
                    sevevars()
                    main.Show()

                    Me.Close()

                Else
                    Dim a As Integer
                    While a < 10
                        Me.Location = New Point(Me.Location.X + 20, Me.Location.Y)
                        System.Threading.Thread.Sleep(50)
                        Me.Location = New Point(Me.Location.X - 20, Me.Location.Y)
                        System.Threading.Thread.Sleep(50)
                        a += 1
                    End While



                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                mysqlconnect.Dispose()
                mysqlcmd.Dispose()
                mysqlreader.Dispose()

            End Try
        Else
            MsgBox("please put  gmail  Acount")
        End If
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged
        Try
            PictureBox1.Image = myQRcode.Encode(TextBoxEmail.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


End Class
