Public Class Person
    Private _pername
    Public Property PerName As String
        Get
            Return _pername
        End Get
        Set(value As String)
            _pername = value
        End Set
    End Property
End Class
