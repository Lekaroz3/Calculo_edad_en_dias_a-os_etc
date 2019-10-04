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

    Private _perborndate
    Public Property PerBornDate As Date
        Get
            Return _perborndate
        End Get
        Set(value As Date)
            _perborndate = value
        End Set
    End Property
End Class
