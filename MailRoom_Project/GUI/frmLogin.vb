'Class Name:    frmLogin
'Purpose:       Login or exit security form
'Change log:    CITA 450 Classs 11-20-12

Public Class frmLogin
     
    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim useraccess As String = "user"
            Dim useraccesspass As String = "user"

            If txtUsername.Text.Length <= 0 Then
                MessageBox.Show("Enter a user name.")
                txtUsername.Focus()
            ElseIf txtPassword.Text.Length <= 0 Then
                MessageBox.Show("Enter a password.")
                txtPassword.Focus()
            End If

            'hard code password and user name as all users will be taken to the same form
            If txtUsername.Text = useraccess.ToString Then
                If txtPassword.Text = useraccess.ToString Then
                    'clear textboxes
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    'open main form
                    Me.Visible = False
                    frmMain.Visible = True
                End If
            Else
                MessageBox.Show("User name or password incorect. Please try again.")
                txtUsername.Focus()
                'clear textboxes
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'close window
        Me.Close()
    End Sub
End Class