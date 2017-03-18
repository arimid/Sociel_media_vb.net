Imports MySql.Data.MySqlClient
Imports Close_To_You.PassingValue

Public Class main
    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand
    Dim tari As Date = Date.Now



    Private Sub savevars()
        setvarAuto = TextBox1.Text
    End Sub

    Private Sub ButtonPostStatus_Click(sender As Object, e As EventArgs) Handles ButtonPostStatus.Click
        mysqlconnect = New MySqlConnection
        mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"
        Dim mysqlreader As MySqlDataReader
        Try
            mysqlconnect.Open()
            Dim QUERY As String
            QUERY = "insert close.post (name,text,date) VALUES('" & TextBox1.Text & "', '" & RichPostStatus.Text & "','" & tari & "')"
            mysqlcmd = New MySqlCommand(QUERY, mysqlconnect)
            mysqlreader = mysqlcmd.ExecuteReader

            MsgBox("Post successuflly")
            RichPostStatus.Clear()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconnect.Dispose()
            mysqlcmd.Dispose()
            '  mysqlreader.Dispose()
        End Try


    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  WebKitBrowser1.scri()

        TextBox1.Text = setvarAuto
        savevars()
        WebKitBrowser1.Navigate("http://sadik.ma/closetoyou/")
    End Sub

#Region "moving form"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
End Class