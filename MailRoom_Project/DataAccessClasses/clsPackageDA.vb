'Class Name:    clsPackageDA
'Purpose:       provide code for getting, adding record
'Change log:    CITA 450 Classs 11-9-12

Option Explicit On
Option Strict On
Option Infer Off

Imports System.Data.OleDb

Public Class clsPackageDA

    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Methods
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Method Name:      GetRecords()
    ' Method Purpose:   To get all the records from the database for this entity 
    ' Parameters:       None
    ' Return:           All the records for this entity - Dataset
    ' Last Modified:    E. Salce 11/01/2012 @ 5:59pm
    '                   T. Reed  11/20/12

    Public Shared Function GetRecords() As DataSet
        Try 'Error Handling 
            'Connect to the database
            Dim dbConnection As OleDbConnection
            dbConnection = ConnectToDb()

            'Check if the connection is successful
            If dbConnection Is Nothing Then
                Return Nothing
            End If

            ' Declare a SQL query string 
            Dim strSQLQuery As String
            strSQLQuery = "SELECT * FROM PackageInfo"
            ' ORDER BY PackageID "

            ' Set up ADO componenets
            ' create Data Adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'configure the components
            dbCommand.CommandText = strSQLQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand


            'delcare a dataset
            Dim ds As New DataSet
            'fill the dataset
            dbDataAdapter.Fill(ds, "PackageInfo")

            Return ds

        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackageDA, Method: GetRecords(). Error: " & ex.Message)
            Return Nothing
        End Try
    End Function
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Methods
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Method Name:      GetRecords()
    ' Method Purpose:   To get all the records from the database for this entity 
    ' Parameters:       A field that can be ordered - string 
    ' Return:           All the records for this entity - Dataset
    ' Change log:       E. Salce @ 10/20/2011
    '                   T. Reed  11/20/12

    Public Shared Function GetRecords(ByVal aField As String) As DataSet
        Try 'Error Handling 
            'Connect to the database
            Dim dbConnection As OleDbConnection
            dbConnection = ConnectToDb()

            'Check if the connection is successful
            If dbConnection Is Nothing Then
                Return Nothing
            End If

            ' Declare a SQL query string 
            Dim strSQLQuery As String
            strSQLQuery = "SELECT * FROM PackageInfo"
            ' ORDER BY PackageInfo" & aField

            ' Set up ADO componenets
            ' create Data Adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'configure the components
            dbCommand.CommandText = strSQLQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand


            'delcare a dataset
            Dim ds As New DataSet
            'fill the dataset
            dbDataAdapter.Fill(ds, "PackageInfo")

            Return ds

        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackageDA, Method: GetRecords(String). Error: " & ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Function AddRecord(ByVal aPackage As clsPackage) As Integer
        Try
            'Connect to the database
            Dim dbConnection As OleDbConnection
            dbConnection = ConnectToDb()

            'Check if the connection is successful
            If dbConnection Is Nothing Then
                Return Nothing
            End If

            ' Declare a SQL query string 
            Dim strSQLQuery As String
            strSQLQuery = "INSERT INTO PackageInfo (StudentID, StudentName, Dorm, Room, EMail, Phone, Carrier, RecieverInitial, RecieveDate, Oversize, PickedUp) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"


            ' Set up ADO componenets
            ' create Data Adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'add a parameter
            dbCommand.Parameters.Add(New OleDbParameter("@StudentID", aPackage.StudentID))
            dbCommand.Parameters.Add(New OleDbParameter("@StudentName", aPackage.Name))
            dbCommand.Parameters.Add(New OleDbParameter("@Dorm", aPackage.Dorm))
            dbCommand.Parameters.Add(New OleDbParameter("@Room", aPackage.Room))
            dbCommand.Parameters.Add(New OleDbParameter("@EMail", aPackage.email))
            dbCommand.Parameters.Add(New OleDbParameter("@Phone", aPackage.Phone))
            dbCommand.Parameters.Add(New OleDbParameter("@Carrier", aPackage.Company))
            dbCommand.Parameters.Add(New OleDbParameter("@ReciverInitial", aPackage.Initials))
            dbCommand.Parameters.Add(New OleDbParameter("@RecieveDate", aPackage.DateReceived))
            dbCommand.Parameters.Add(New OleDbParameter("@Oversize", aPackage.Oversized))
            dbCommand.Parameters.Add(New OleDbParameter("@PickedUp", aPackage.PickedUp))



            'configure the components
            dbCommand.CommandText = strSQLQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.InsertCommand = dbCommand

            ' declare a variable to hold the result 
            Dim intResult As Integer
            intResult = dbCommand.ExecuteNonQuery
            ' return result 
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackageDA, Method: AddRecord(). Error: " & ex.Message)
            Return -9
        End Try
    End Function
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Methods
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Method Name:      Update Record()
    ' Method Purpose:   To update an exesiting record to the database for this entity 
    ' Parameters:       Object (an airplane) - clsAirplaneInfo
    ' Return:           Result (number of rows affected)
    ' Last Modified:    E. Salce 11/01/2012 @ 7:10pm
    '                   T. Reed  11/20/12

    Public Shared Function UpdateRecord(ByVal aPackage As clsPackage) As Integer
        Try
            'Connect to the database
            Dim dbConnection As OleDbConnection
            dbConnection = ConnectToDb()

            'Check if the connection is successful
            If dbConnection Is Nothing Then
                Return Nothing
            End If

            ' Declare a SQL query string 
            Dim strSQLQuery As String
            strSQLQuery = "UPDATE tblPackage SET StudentID = ?, StudentName = ?, Dorm = ?, Room = ?, EMail = ?, Phone = ?,  Carrier = ?, ReciverInitial = ?, RecieveDate = ?, " _
                & "Oversize = ?, PickedUp = ?, WHERE PackageID = ?"

            ' Set up ADO componenets
            ' create Data Adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            dbCommand.Parameters.Add(New OleDbParameter("@StudentID", aPackage.StudentID))
            dbCommand.Parameters.Add(New OleDbParameter("@StudentName", aPackage.Name))
            dbCommand.Parameters.Add(New OleDbParameter("@Dorm", aPackage.Dorm))
            dbCommand.Parameters.Add(New OleDbParameter("@Room", aPackage.Room))
            dbCommand.Parameters.Add(New OleDbParameter("@EMail", aPackage.email))
            dbCommand.Parameters.Add(New OleDbParameter("@Phone", aPackage.Phone))
            dbCommand.Parameters.Add(New OleDbParameter("@Carrier", aPackage.Company))
            dbCommand.Parameters.Add(New OleDbParameter("@ReceiverInitial", aPackage.Initials))
            dbCommand.Parameters.Add(New OleDbParameter("@RecieveDate", aPackage.DateReceived))
            dbCommand.Parameters.Add(New OleDbParameter("@Oversize", aPackage.Oversized))
            dbCommand.Parameters.Add(New OleDbParameter("@PickedUp", aPackage.PickedUp))
            dbCommand.Parameters.Add(New OleDbParameter("@PackageID", aPackage.PackageID))

            'configure the components
            dbCommand.CommandText = strSQLQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.UpdateCommand = dbCommand

            ' declare a variable to hold the result 
            Dim intResult As Integer
            intResult = dbCommand.ExecuteNonQuery
            ' return result 
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsPackageDA, Method: UpdateRecord(). Error: " & ex.Message)
            Return -9
        End Try
    End Function

End Class
