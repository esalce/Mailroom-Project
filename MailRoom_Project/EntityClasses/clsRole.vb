'Class Name:    clsRole
'Purpose:       provide setters/getter and parameterized constructor
'Change log:    CITA 450 Classs 11-9-12

Public Class clsRole

    'Attributes
    Private intRoleID As Integer
    Private strRole As String

    'Getters/Setters

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

    Public Property Role As String
        Get
            Return strRole
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strRole = value
            Else
                strRole = String.Empty
            End If
        End Set
    End Property

    'Paramerterized Constructor
    Public Sub New(ByVal RoleID As Integer, ByVal Role As String)
        intRoleID = RoleID
        strRole = Role
    End Sub


End Class
