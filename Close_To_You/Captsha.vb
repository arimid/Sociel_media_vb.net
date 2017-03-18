Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Class Captcha

    Inherits PictureBox
    Public randomstr As String
#Region "Properties"
    Private _textcolor As Color = Color.Black
    Public Property TextColor() As Color
        Get
            Return _textcolor
        End Get
        Set(ByVal value As Color)
            _textcolor = value
            Invalidate()
        End Set
    End Property

    Private _font As New Font("Segoe UI", 20)
    Public Overrides Property Font() As Font
        Get
            Return _font
        End Get
        Set(ByVal value As Font)
            _font = value
            Invalidate()
        End Set
    End Property

    Private _texttouse As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
    Public Property RandomCharacters() As String
        Get
            Return _texttouse
        End Get
        Set(ByVal value As String)
            _texttouse = value
            Invalidate()
        End Set
    End Property

    Private _captchalength As Integer = 8
    Public Property CaptchaTextLength() As Integer
        Get
            Return _captchalength
        End Get
        Set(ByVal value As Integer)
            _captchalength = value
            Invalidate()
        End Set
    End Property

    Private _numberoflines As Integer = 50
    Public Property NumberOfLines() As Integer
        Get
            Return _numberoflines
        End Get
        Set(ByVal value As Integer)
            _numberoflines = value
            Invalidate()
        End Set
    End Property
#End Region

#Region "Events"
    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Me.Size = New Size(241, 69)
        Me.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Public CaptchaText As String = String.Empty
    Private rnd As New Random()
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        Dim BoxSize As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim txtcolor As Brush = New SolidBrush(Color.FromArgb(rnd.[Next](160, 255), _textcolor))
        G.SmoothingMode = SmoothingMode.HighQuality

        G.Clear(BackColor)

        For I As Integer = 0 To _numberoflines - 1
            G.DrawLine(New Pen(Color.FromArgb(rnd.[Next](128, 255), CreateRandomColor())), rnd.[Next](0, BoxSize.Width), rnd.[Next](0, BoxSize.Height), rnd.[Next](BoxSize.Width), rnd.[Next](BoxSize.Height))
        Next

        Dim SFormat As New StringFormat()
        SFormat.Alignment = StringAlignment.Center
        SFormat.LineAlignment = StringAlignment.Center

        G.RotateTransform(rnd.[Next](-7, 7), MatrixOrder.Append)

        randomstr = CreateRandomString()
        G.DrawString(randomstr, Font, txtcolor, BoxSize, SFormat)
        CaptchaText = randomstr

        e.Graphics.DrawImage(B, 0, 0)
        G.Dispose()
        B.Dispose()
    End Sub
#End Region

#Region "Create Randoms"
    Private Function CreateRandomColor() As Color
        Return Color.FromArgb(100, rnd.[Next](255), rnd.[Next](255), rnd.[Next](255))
    End Function

    Private Function CreateRandomString() As String
        Dim buffer As Char() = New Char(_captchalength - 1) {}
        For i As Integer = 0 To _captchalength - 1
            If _texttouse = String.Empty Then
                Dim newtext As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
                buffer(i) = newtext(rnd.[Next](newtext.Length))
            Else
                buffer(i) = _texttouse(rnd.[Next](_texttouse.Length))
            End If
        Next
        Return New String(buffer)
    End Function
#End Region
End Class