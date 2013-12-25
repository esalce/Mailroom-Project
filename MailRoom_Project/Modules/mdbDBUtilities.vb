Imports System.Data.OleDb

'Class Name: mdlDbUtilities
'Class Purpose: Container to hold commonly used methods that will allow the connection with database
'Created: E. Salce  on 10/2/2012

Module mdlDb
    'Method Name:   ConnectToDb
    'Purpose:       Connect to Access Database
    'Parameter:     None
    'Return:        Database Connection - OledbConnection
    'Changelog:     created by E. Salce on 10/2/2012

    Public Function ConnectToDb() As OleDbConnection
        Try 'Error Handling

            'Connect to DB
            'declare and create a database connection object
            Dim dbConnection As New OleDbConnection

            'configure the database connection object
            Dim strConnectionString As String

            strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/MailRoomMain.accdb"

            dbConnection.ConnectionString = strConnectionString
            'Open the connection
            dbConnection.Open()

            'return the connection object 
            Return dbConnection

        Catch ex As Exception
            MessageBox.Show("Error Occured in Module: mdlDbUtilities, Function: ConnectDb(). Error:" & ex.Message)
            Return Nothing

        End Try
    End Function

    'Method Name:   disconnectToDb
    'Purpose:       disconnect from Access Database
    'Parameter:     Database Connection - OledbConnection
    'Return:        Nothing
    'Changelog:     created by E. Salce on 10/2/2012

    Public Sub Closedb(ByVal aConnection As OleDbConnection)
        'error handling
        Try
            aConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured in Module: mdlDbUtilities, Function: disconnectDb(). Error:" & ex.Message)
        End Try
    End Sub

End Module
