'Class Name:    clsStudent
'Purpose:       provide setters/getter and parameterized constructor
'Change log:    CITA 450 Classs 11-9-12

Public Class clsStudent

    ' private attributes 
    Private strStudentID As String
    Private strName As String
    Private strDorm As String
    Private strRoom As String
    Private strPhone As String
    Private strEmail As String


    'Getters and Setters'
    Public Property ID() As String
        Get
            Return strStudentID
        End Get
        Set(ByVal value As String)
            strStudentID = value
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
    Public Sub New(ByVal ID As String, ByVal Name As String, ByVal Dorm As String, ByVal Room As String, ByVal Email As String, Optional ByVal Phone As String = "")
        strStudentID = ID
        strName = Name
        strDorm = Dorm
        strRoom = Room
        strEmail = Email
        strPhone = Phone
    End Sub
End Class
