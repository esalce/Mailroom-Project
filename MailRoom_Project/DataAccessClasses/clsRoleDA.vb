Imports System.Data.OleDb

Public Class clsRoleDA
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Methods
    ' """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    ' Method Name:      GetRecords()
    ' Method Purpose:   To get all the records from the database for this entity 
    ' Parameters:       None
    ' Return:           All the records for this entity - Dataset
    ' Last Modified:    E.Salce 11/01/2012 @ 5:53pm

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
            strSQLQuery = "SELECT * FROM tblRole ORDER BY RoleID "

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
            dbDataAdapter.Fill(ds, "tblRole")

            Return ds

        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsRoleDA, Method: GetRecords(). Error: " & ex.Message)
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
            strSQLQuery = "SELECT * FROM tblRole ORDER BY RoleName." & aField

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
            dbDataAdapter.Fill(ds, "tblRole")

            Return ds

        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsRoleDA, Method: GetRecords(String). Error: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class
