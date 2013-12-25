Public Class clsStudent
    ' private attributes 

    Private intStudentID As Integer
    Private strName As String
    Private strDorm As String
    Private strRoom As String
    Private strPhone As String
    Private strEmail As String


    'Getters and Setters'
    Public Property ID() As Integer
        Get
            Return intStudentID
        End Get
        Set(ByVal value As Integer)
            intStudentID = value
        End Set
    End Property


    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    Public Property Dorm() As String
        Get
            Return strDorm
        End Get
        Set(ByVal value As String)
            strDorm = value
        End Set
    End Property

    Public Property Room() As String
        Get
            Return strRoom
        End Get
        Set(ByVal value As String)
            strRoom = value
        End Set
    End Property


    Public Property Phone() As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property


    ' Constructor'

    Public Sub New(ByVal ID As Integer, ByVal Name As String, ByVal Dorm As String, ByVal Room As String, ByVal Email As String, Optional ByVal Phone As String = "")
        intStudentID = ID
        strName = Name
        strDorm = Dorm
        strRoom = Room
        strEmail = Email
        strPhone = Phone
    End Sub
End Class
