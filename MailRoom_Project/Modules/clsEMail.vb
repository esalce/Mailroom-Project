Imports System.Net.Mail

Public Class clsEMail

#Region "Class Scope Variables"

    Private sender As String
    Private recipient As String
    Private msgBody As String
    Private msgSubject As String
    Private smtpServer As String
    Private strUserName As String
    Private strPassword As System.Security.SecureString
    Private strDomain As String = "csntprod.morrisville.edu"

#End Region

#Region "Class Constructor"

    ''' <summary>
    ''' Class Constructor used to configure an instance of the class
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 By K.Markowski
    ''' </remarks>
    Public Sub New(ByVal pFrom As String,
                        ByVal pSendTo As String,
                        ByVal pUsername As String,
                        ByVal pUserPassword As System.Security.SecureString,
                        Optional ByVal pSubject As String = "New Package Notification",
                        Optional ByVal pBody As String = "You have a new package waiting to be picked up in the mail room",
                        Optional ByVal pSMTPServer As String = "smtp.morrisville.edu")
        sender = pFrom
        recipient = pSendTo
        strUserName = pUsername
        strPassword = pUserPassword
        msgBody = pBody
        msgSubject = pSubject
        smtpServer = pSMTPServer
    End Sub

#End Region

#Region "Class Properties"

    ''' <summary>
    ''' Sets the name of the person that the message is being sent to
    ''' </summary>
    ''' <value>String - The EMail address of the person the message is for</value>
    ''' <returns>String - The EMail address of the recipient that is currently stored</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Property sendMessageTo() As String
        Get
            Return recipient
        End Get
        Set(value As String)
            recipient = value
        End Set
    End Property

    ''' <summary>
    ''' Sets the name of the person that the message is being sent to
    ''' </summary>
    ''' <value>String - The EMail address of the person the message is from</value>
    ''' <returns>String - The EMail address of the sender that is currently stored</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Property messageSentFrom() As String
        Get
            Return sender
        End Get
        Set(value As String)
            sender = value
        End Set
    End Property

    ''' <summary>
    ''' Gets/Sets the message that is to be sent
    ''' </summary>
    ''' <value>String - The EMail message</value>
    ''' <returns>String - The EMail message that is currently stored</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Property MessageToSend() As String
        Get
            Return msgBody
        End Get
        Set(value As String)
            msgBody = value
        End Set
    End Property

    ''' <summary>
    ''' Gets/Sets the subject line of the message that is being sent
    ''' </summary>
    ''' <value>String - The EMail Subject</value>
    ''' <returns>String - The EMail subject that is currently stored</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Property MessageSubject() As String
        Get
            Return msgSubject
        End Get
        Set(value As String)
            msgSubject = value
        End Set
    End Property

    ''' <summary>
    ''' Sets the name of the person that the message is being sent to
    ''' </summary>
    ''' <value>String - The EMail address of the person the message is for</value>
    ''' <returns>String - The EMail address of the person that is currently stored</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1.  Create on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Property SMTPServerAddress() As String
        Get
            Return smtpServer
        End Get
        Set(value As String)
            smtpServer = value
        End Set
    End Property

    ''' <summary>
    ''' Gets/Sets the SMTP user name for the domain
    ''' </summary>
    ''' <value>String - The username that is to be passed to the domain</value>
    ''' <returns>String - The password for the specified user to the domain</returns>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on 23.Nov.2012 By K.Markowski
    ''' </remarks>
    Public Property SMTPUserName() As String
        Get
            Return strUserName
        End Get
        Set(value As String)
            strUserName = value
        End Set
    End Property

    ''' <summary>
    ''' Sets the SMTP users password for the domain
    ''' </summary>
    ''' <value>String - The username that is to be passed to the domain</value>
    ''' <remarks>
    ''' Revision History:
    ''' 1. Created on 23.Nov.2012 By K.Markowski
    ''' </remarks>
    Public WriteOnly Property SMTPPassword() As System.Security.SecureString
        Set(value As System.Security.SecureString)
            strPassword = value
        End Set
    End Property

#End Region

#Region "Class public Methods/Functions"

    ''' <summary>
    ''' Send an Email Message to the user 
    ''' </summary>
    ''' <remarks>
    ''' Revision History:
    ''' 1: Created on 14.Nov.2012 by K.Markowski
    ''' </remarks>
    Public Function SendEMail() As Boolean
        Try
            ' Define the email client
            Dim emlClient As New MailMessage(sender, recipient, msgSubject, msgBody)
            ' Define an SMTP User
            Dim smtpUser As New System.Net.NetworkCredential()

            ' Setup the users credentials for the SMTP Server access
            smtpUser.UserName = strUserName
            smtpUser.SecurePassword = strPassword
            smtpUser.Domain = strDomain

            ' define the email server and its properties
            Dim emlServer As New SmtpClient(smtpServer)
            emlServer.EnableSsl = True
            emlServer.UseDefaultCredentials() = False
            emlServer.Credentials = smtpUser
            ' Set the delivery method for the message
            emlServer.DeliveryMethod = SmtpDeliveryMethod.Network
            ' Set the server timeout value
            emlServer.Timeout = 30000
            ' Send the message using the mail message value
            emlServer.Send(emlClient)
            ' Completed the function successfully
            Return True

        Catch ex As Exception
            '******************************************************************
            ' Compiler Condition - Build state is debug, not release
            '******************************************************************
#If DEBUG Then
            ' Write the error message to the system bugger
            Debug.WriteLine("Error in EMailInterFace.SendMail: " & ex.Message)
#End If
            ' return a false value indicating that the function failed
            Return False
        End Try
    End Function

#End Region

End Class
