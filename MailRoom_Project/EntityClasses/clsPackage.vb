'Class Name:    clsPackage
'Purpose:       provide setters/getter and parameterized constructor
'Change log:    CITA 450 Classs 11-9-12
'               T. Reed   11/20/12 

Public Class clsPackage

    'private attributes'
    Private intPackageID As Integer
    Private intStudentID As String
    Private strCompany As String
    Private strHandlerInitial As String
    Private dtDateReceived As Date
    Private blnIsOversized As Boolean
    Private blnIsPickedUp As Boolean

    Private strName As String
    Private strDorm As String
    Private strRoom As String
    Private strPhone As String
    Private strEmail As String


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

    Public Property DateReceived() As Date
        Get
            Return dtDateReceived
        End Get
        Set(ByVal value As Date)
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

    Public Property StudentID() As String
        Get
            Return intStudentID
        End Get
        Set(ByVal value As String)
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

    Public Property email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property


    ' Parameterzied Constructor
    Public Sub New(ByVal PackageID As Integer, ByVal StudentID As String, ByVal name As String, _
                   ByVal dorm As String, ByVal room As String, ByVal email As String, ByVal phone As String, _
                   ByVal Company As String, ByVal Initials As String, ByVal DateReceived As Date, _
                   ByVal Oversized As Boolean, ByVal PickedUp As Boolean)
        intPackageID = PackageID
        intStudentID = StudentID

        'ByVal name As String, ByVal dorm As String, ByVal room As String, ByVal phone As String, ByVal email As String, 
        strName = name
        strDorm = dorm
        strRoom = room
        strPhone = phone
        strEmail = email

        strCompany = Company
        strHandlerInitial = Initials
        dtDateReceived = DateReceived
        blnIsOversized = Oversized
        blnIsPickedUp = PickedUp



    End Sub

    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Methods
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Method Name:      AddPackage()
    ' Method Purpose:   To add a record to the database for this entity 
    ' Parameters:       Object (aPackage)
    ' Return:           Result (number of rows affected) - Dataset
    ' Change log:       E. Salce @ 11/14/2012

    Public Shared Function AddPackage(ByVal aPackage As clsPackage) As Integer
        Try
            Return clsPackageDA.AddRecord(aPackage)
        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackage, Method: AddPackage(). Error: " & ex.Message)
            Return -9
        End Try
    End Function
    ' Method Name:      UpdatePackage()
    ' Method Purpose:   To update a record to the database for this entity 
    ' Parameters:       Object (aPackage)
    ' Return:           Result (number of rows affected) - Dataset
    ' Change log:       E. Salce @ 11/14/2012
    Public Shared Function UpdatePackage(ByVal aPackage As clsPackage) As Integer
        Try
            Return clsPackageDA.UpdateRecord(aPackage)
        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackage, Method: UpdatePackage(). Error: " & ex.Message)
            Return -9
        End Try
    End Function

End Class