'Class Name:    clsConfirm
'Purpose:       provide setters/getter and parameterized constructor
'Change log:    CITA 450 Classs 11-9-12

Public Class clsConfirm

    'Attributes
    Private intPeopleID As Integer
    Private strUsername As String
    Private strPassword As String
    Private intRoleID As Integer

    'Getters/Setters
    Public Property PeopleID As Integer
        Get
            Return intPeopleID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intPeopleID = value
            Else
                intPeopleID = 0
            End If
        End Set
    End Property

    Public Property UserName As String
        Get
            Return strUsername
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strUsername = value
            Else
                strUsername = String.Empty
            End If
        End Set
    End Property
    Public Property Password As String
        Get
            Return strPassword
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strPassword = value
            Else
                strPassword = String.Empty
            End If
        End Set
    End Property
    Public Property RoleID As Integer
        Get
            Return intRoleID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intRoleID = value
            Else
                intRoleID = 0
            End If
        End Set
    End Property

    'Paramerterized Constructor Constructors
    Public Sub New(ByVal PeopleID As Integer, ByVal Username As String, _
                   ByVal Password As String, ByVal RoleID As Integer)

        intPeopleID = PeopleID
        strUsername = Username
        strPassword = Password
        RoleID = intRoleID

    End Sub



End Class
