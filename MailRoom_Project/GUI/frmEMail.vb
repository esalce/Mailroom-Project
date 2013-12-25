'Class Name:    frmEMail
'Purpose:       Send email to student that get package
'Change log:    CITA 450 Classs 11-9-12

Public Class frmEMail

#Region "Class Scope Variables/Properties"

    Public Property emlClient() As clsEMail

#End Region

#Region "Class Methods/Functions"

    ''' <summary>
    ''' Handles the loading of the email client
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on 24.Nov.2012 By K.Markowski
    ''' </remarks>
    Public Sub frmEMail_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        txtFrom.Text = emlClient.messageSentFrom()
        txtTo.Text = emlClient.sendMessageTo()
        txtSubject.Text = emlClient.MessageSubject()
        rtbMessage.Text = emlClient.MessageToSend()
    End Sub

    ''' <summary>
    ''' User clicked the send button
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on 25.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click

        Try
            emlClient.sendMessageTo = txtTo.Text
            emlClient.MessageSubject = txtSubject.Text
            emlClient.MessageToSend = rtbMessage.Text
            emlClient.SendEMail()
            MessageBox.Show("Your e-mail has been sent!")
            Me.Close()
        Catch ex As Exception
#If DEBUG Then
            Debug.WriteLine(ex.Message)
#End If
        End Try

    End Sub

#End Region

End Class