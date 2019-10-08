Public Class Person
    Private _pername As String
    Public Property PerName As String
        Get
            Return _pername
        End Get
        Set(value As String)
            _pername = value
        End Set
    End Property
    Private _dob As Date
    Public Property dob As Date
        Get
            Return _dob
        End Get
        Set(value As Date)
            _dob = value
        End Set
    End Property
    Public Function age() As Byte
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Public Function months() As Long
        months = DateDiff(DateInterval.Month, dob, Date.Now)
        Return months
    End Function
    Public Function days() As Long
        days = DateDiff(DateInterval.Day, dob, Date.Now)
        Return days
    End Function
    Public Function hours() As Long
        hours = DateDiff(DateInterval.Hour, dob, Date.Now)
        Return hours
    End Function
    Public Function minutes() As Long
        minutes = DateDiff(DateInterval.Hour, dob, Date.Now)
        Return minutes
    End Function
End Class
