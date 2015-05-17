    Public Function antisqli(ByVal str As String)
        Return Replace(Replace(Replace(Replace(str, "'", ""), ",", ""), "`", ""), "--", "")
    End Function
