'Class Name:    frmCampusLogin
'Purpose:       provide campus secure login
'Change log:    CITA 450 Classs 11-9-12

Public Class frmCampusLogin

    Private settings As My.MySettings = New My.MySettings

    Private Sub frmCampusLogin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtUsername.Text = settings.CampusUsername
        mtxtPassword.Text = settings.CampusUserPassword
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        settings.CampusUsername = txtUsername.Text
        settings.CampusUserPassword = mtxtPassword.Text
        settings.Save()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class