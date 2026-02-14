Imports System.Globalization
Imports System.Net
Imports System.Text
Imports System.Web
Imports Humanizer
Imports Newtonsoft.Json.Linq

Public Class Logic


    Public Function Addition()
        'Dim num As Integer = 1234

        'Dim arabic As String = num.ToWords(New CultureInfo("ar")) test

        Return TranslateToArabic("Heloo World")
    End Function

    Public Function TranslateToArabic(text As String) As String
        Dim url As String = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl=ar&dt=t&q=" &
        HttpUtility.UrlEncode(text)

        Dim wc As New WebClient()
        wc.Encoding = Encoding.UTF8
        Dim result As String = wc.DownloadString(url)

        Dim json = JArray.Parse(result)
        Return json(0)(0)(0).ToString()
    End Function
End Class
