Public Class clsPackage

    'private attributes'
    Private intPackageID As Integer
    Private blnIsPickedUp As Boolean
    Private blnIsOversized As Boolean
    Private strHandlerInitial As String
    Private dtDateReceived As DateTime
    Private strCompany As String
    Private intStudentID As Integer


    'Getters and Setters
    Public Property PackageID() As String
        Get
            Return intPackageID
        End Get
        Set(ByVal value As String)
            intPackageID = PackageID
        End Set
    End Property

    Public Property PickedUp() As Boolean
        Get
            Return blnIsPickedUp
        End Get
        Set(ByVal value As Boolean)
            blnIsPickedUp = PickedUp
        End Set
    End Property

    Public Property Oversized() As Boolean
        Get
            Return blnIsOversized
        End Get
        Set(ByVal value As Boolean)
            blnIsOversized = Oversized
        End Set
    End Property

    Public Property DateReceived() As DateTime
        Get
            Return dtDateReceived
        End Get
        Set(ByVal value As DateTime)
            dtDateReceived = DateReceived
        End Set
    End Property

    Public Property Company() As String
        Get
            Return strCompany
        End Get
        Set(ByVal value As String)
            strCompany = Company
        End Set
    End Property

    Public Property StudentID() As Integer
        Get
            Return intStudentID
        End Get
        Set(ByVal value As Integer)
            intStudentID = value
        End Set
    End Property

    Public Property Initials() As String
        Get
            Return strHandlerInitial
        End Get
        Set(ByVal value As String)
            strHandlerInitial = value
        End Set
    End Property


    ' Parameterzied Constructor
    Public Sub New(ByVal PackageID As Integer, ByVal PickedUp As Boolean, ByVal Oversized As Boolean, ByVal DateReceived As DateTime, ByVal Company As String, ByVal Initials As String, ByVal StudentID As Integer)
        intPackageID = PackageID
        blnIsPickedUp = PickedUp
        blnIsOversized = Oversized
        dtDateReceived = DateReceived
        strCompany = Company
        strHandlerInitial = Initials
        intStudentID = StudentID
    End Sub


End Class