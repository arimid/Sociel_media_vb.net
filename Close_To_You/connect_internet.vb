Imports System.Web


Public Class connect_internet
    Public Function internet() As Boolean
        Dim url As New System.Uri("http://www.google.com")
        Dim webreq As System.Net.WebRequest
        webreq = System.Net.WebRequest.Create(url)

        Dim responce As System.Net.WebResponse
        Try
            responce = webreq.GetResponse
            responce.Close()
            responce = Nothing
            Return True

        Catch ex As Exception
            responce = Nothing
            webreq = Nothing
            Return False
        End Try
    End Function


End Class