'Class Name:    frmMain
'Purpose:       Main form for user to complete tasks
'Change log:    CITA 450 Classs 11-9-12

'included the Excel object lib 11.0 and office lib 11.0
Imports Microsoft.Office.Interop.Excel

Public Class frmMain

    'private variables
    Private student As clsStudent
    Private db As New MailRoomMainDataSet
    Private settingsInterface As My.MySettings = New My.MySettings
    Private emlClient As clsEMail
    Private PackageInfo As clsPackage

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MailRoomMainDataSet.PackageInfo' table. You can move, or remove it, as needed.
        Me.PackageInfoTableAdapter1.Fill(Me.MailRoomMainDataSet.PackageInfo)
        'TODO: This line of code loads data into the 'MailRoomMainDataSet.PackageInfo' table. You can move, or remove it, as needed.
        If settingsInterface.CampusUsername = "" Then
            frmCampusLogin.ShowDialog()
            settingsInterface = New My.MySettings()

        End If
        ClearStudentData()
    End Sub

#Region "frm_Main_Disposed"

    'close the hidden login form after close
    Private Sub frmMain_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        frmLogin.Close()
    End Sub

#End Region

#Region "btnSearch_Click"


    'Package_ID is a label and is will modify to the next # in the grid
    Private Sub btnSearch_Click(sender As Object, e As System.EventArgs) Handles btnSearch.Click


        'under the student container
        'all boxes are labels (because she will not be able to modify) they should auto fill with the selected student from frmSearch

        'open main form
        frmSearch.ShowDialog()

        student = frmSearch.student

        populateStudentData()

    End Sub

#End Region

#Region "btnSend_Click"

    ''' <summary>
    ''' Displays the EMail Client form
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on - 
    ''' 2. code revised to display the email client form 25.Nov.2012 by K.Markowski
    ''' </remarks>
    Private Sub btnSend_Click(sender As Object, e As System.EventArgs) Handles btnSend.Click
        If Not (emlClient Is Nothing) Then
            frmEMail.emlClient = emlClient
            frmEMail.ShowDialog()
        End If
    End Sub
#End Region

#Region "btnExport_Click"

    Private Sub btnExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp.Click
        Dim xlApp As Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To dgvLog.RowCount - 2
            For j = 0 To dgvLog.ColumnCount - 1
                For k As Integer = 1 To dgvLog.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvLog.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvLog(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("C:\Mail Room Logs.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file at C:\Mail Room Logs.xlsx")
    End Sub

    'Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp.Click

    '    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    '    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    '    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    '    Dim misValue As Object = System.Reflection.Missing.Value
    '    Dim i As Integer
    '    Dim j As Integer

    '    Dim source = MailRoomMainDataSet.tblStudent

    '    xlApp = New Microsoft.Office.Interop.Excel.Application
    '    xlWorkBook = xlApp.Workbooks.Add(misValue)
    '    xlWorkSheet = xlWorkBook.Sheets("sheet1")

    '    'For i = 0 To source.Rows.Count - 2
    '    '    For j = 0 To source.Columns.Count - 1
    '    '        For k As Integer = 1 To source.Columns.Count
    '    '            xlWorkSheet.Cells(1, k) = source.Columns(k - 1).HeaderText
    '    '            xlWorkSheet.Cells(i + 2, j + 1) = source(j, i).Value.ToString()
    '    '        Next
    '    '    Next
    '    'Next
    '    Dim rowAdj = source.Rows.Count - (source.Rows.Count - 1)
    '    Dim colAdj = source.Columns.Count - (source.Columns.Count - 1)

    '    For i = 0 To rowAdj
    '        For j = 0 To colAdj
    '            For k As Integer = 1 To source.Columns.Count
    '                xlWorkSheet.Cells(1, k) = source.Columns(k - 1).ColumnName
    '                xlWorkSheet.Cells(i + rowAdj + 1, j + colAdj) = source(i + rowAdj).ToString()
    '                'xlWorkSheet.Cells(i + rowAdj, j + colAdj) = source(j + rowAdj).ToString()
    '            Next
    '        Next
    '    Next

    '    xlWorkSheet.SaveAs("C:\Mail Room Logs.xlsx")
    '    xlWorkBook.Close()
    '    xlApp.Quit()

    '    releaseObject(xlApp)
    '    releaseObject(xlWorkBook)
    '    releaseObject(xlWorkSheet)

    '    MsgBox("You can find the file at C:\Mail Room Logs.xlsx")
    'End Sub

#End Region

#Region "release object"

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region

#Region "mnuLogout_Click"

    Private Sub mnuLogout_Click_1(sender As System.Object, e As System.EventArgs) Handles mnuLogout.Click
        'change back to the login form
        Me.Visible = False
        frmLogin.Visible = True
    End Sub

#End Region




    'Name:          btnSave_Click
    'Purpose:       load information to the dgvDate
    'Change log:   J.Salce  11-28-12
    Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
        'error handling
        Try
            ' Create a reference to the package info data table
            Dim PackageTableData As New MailRoom_Project.MailRoomMainDataSet.PackageInfoDataTable()
            ' Open the bindingsource for adding
            ' add the new package to the table


            'feedback on adding to log
            Dim intRowsAffected As Integer = 0
            intRowsAffected = PackageInfoTableAdapter1.Insert(lblID.Text, lblName.Text, lblDorm.Text, _
                                               lblRoom.Text, lblEMail.Text, lblPhone.Text, txtDelivCompany.Text, txtHandler.Text, dtpDate.Text, _
                                               ckOversize.CheckState, False)

            PackageInfo = New clsPackage(0, lblID.Text, lblName.Text, lblDorm.Text, _
                                               lblRoom.Text, lblEMail.Text, lblPhone.Text, txtDelivCompany.Text, txtHandler.Text, dtpDate.Text, _
                                               ckOversize.CheckState, False)

            ' add to database
            Dim intResult As Integer = clsPackage.AddPackage(PackageInfo)


            Me.Validate()

            'update to dataset
            Me.PackageInfoTableAdapter1.Update(MailRoomMainDataSet.PackageInfo)



            'feedback and clearing boxes
            If intRowsAffected > 0 Then

               
                PackageInfoTableAdapter1.Fill(Me.MailRoomMainDataSet.PackageInfo)

                ' MessageBox.Show((dgvLog.RowCount - 1).ToString & " Entry Saved to Log")
                MessageBox.Show("Entry Saved to Log")

                'clear labels and rows
                ClearStudentData()

            Else
                MessageBox.Show("No Rows Affected")

            End If


            'Email Portion***********************************************************************************

            ' Create a secured password string
            Dim secPassword As New System.Security.SecureString
            ' Loop through each character in the stored password and add it to the scure password string
            For Each ltr As Char In settingsInterface.CampusUserPassword
                secPassword.AppendChar(ltr)
            Next
            ' Send email notification to the recipient of the package
            emlClient = New clsEMail(settingsInterface.CampusUsername & "@morrisville.edu", student.Email, settingsInterface.CampusUsername, secPassword)
            ' Send the mail notification and display the results of the send
            If emlClient.SendEMail() Then
                MessageBox.Show("Message has been sent to the package recipient!", "MSC Mailroom", MessageBoxButtons.OK, MessageBoxIcon.None)
            Else
                MessageBox.Show("A problem occured sending the message, please try again later!", "MSC Mailroom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try

    End Sub

    Public Sub ClearStudentData()
        'error handling
        Try
            ' lblPackageID.Text = String.Empty
            txtDelivCompany.Clear()
            txtDelivCompany.Focus()
            txtHandler.Clear()
            lblID.Text = String.Empty
            lblName.Text = String.Empty
            lblDorm.Text = String.Empty
            lblRoom.Text = String.Empty
            lblEMail.Text = String.Empty
            lblPhone.Text = String.Empty
            ckOversize.Checked = False
            chkPickedUp.Checked = False
        Catch ex As Exception

        End Try
    End Sub

#Region "populateStudentData()"

    ''' <summary>
    ''' Poplulates the fields on the form with the student data from the search window
    ''' </summary>
    ''' <remarks>
    ''' Revision Hsitory:
    ''' 1. Created on 26.Nov.2012 by K.Markowski/A.Surento
    ''' </remarks>
    Private Sub populateStudentData()
        If Not (student Is Nothing) Then
            lblID.Text = student.ID
            lblName.Text = student.Name
            lblDorm.Text = student.Dorm
            lblPhone.Text = student.Phone
            lblEMail.Text = student.Email
            lblRoom.Text = student.Room
        End If
    End Sub

#End Region


 

End Class