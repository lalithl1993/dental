Public Class frmlocked

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnunlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunlock.Click

        If txtpass.Text = frmlogin.userpass Then
            txtpass.Text = ""
            frmmain.Show()
            frmmain.Enabled = True
            Me.Hide()
        Else
            txtpass.Text = ""
            MessageBox.Show("please enter correct password")

        End If

    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        AcceptButton = btnunlock
    End Sub
End Class