'Class Name:    frmSearch
'Purpose:       provide search for a student and populate labels with information
'Change log:    CITA 450 Classs 11-9-12

Public Class frmSearch

    Public Property student As clsStudent

    Private Sub frmSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MailRoomDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.MailRoomDataSet.tblStudent)

    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Me.TblStudentTableAdapter.FindStudent(MailRoomDataSet.tblStudent, txtLastName.Text)

    End Sub

    ''' <summary>
    ''' Adds the information to the user screen
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on 25.Nov.2012 by K.Markowski
    ''' </remarks>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            If (IsDBNull(dgvStudent.SelectedRows(0).Cells(4).Value)) Then
                student = New clsStudent(dgvStudent.SelectedRows(0).Cells(0).Value, _
                            dgvStudent.SelectedRows(0).Cells(1).Value, _
                            dgvStudent.SelectedRows(0).Cells(2).Value, _
                            dgvStudent.SelectedRows(0).Cells(3).Value, _
                            dgvStudent.SelectedRows(0).Cells(5).Value, _
                            "No Phone Given")
            Else
                student = New clsStudent(dgvStudent.SelectedRows(0).Cells(0).Value, _
                            dgvStudent.SelectedRows(0).Cells(1).Value, _
                            dgvStudent.SelectedRows(0).Cells(2).Value, _
                            dgvStudent.SelectedRows(0).Cells(3).Value, _
                            dgvStudent.SelectedRows(0).Cells(5).Value, _
                            dgvStudent.SelectedRows(0).Cells(4).Value)
            End If
            Me.Close()
        Catch ex As Exception
#If DEBUG Then
            Debug.WriteLine("frmSearch.btnAdd_click" & ex.Message)
#End If
        End Try
    End Sub

End Class