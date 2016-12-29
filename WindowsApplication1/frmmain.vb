Public Class frmmain

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbpatient.Click
        frmpatient.Show()
        frmpatient.Activate()
        Me.Enabled = False

    End Sub

    Private Sub pbappointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbappointment.Click
        frmappointment.Show()
        frmappointment.Activate()

        Me.Enabled = False
    End Sub

    Private Sub pbcase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbcase.Click
        frmcase.Show()
        Me.Enabled = False
    End Sub


    Private Sub btnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmlocked.Show()
        frmlocked.Activate()

        Me.Enabled = False

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        frmlogin.Show()
        frmlogin.Activate()

        Me.Hide()

    End Sub

    Private Sub pbbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbbill.Click
        frmbill.Show()
        frmbill.Activate()

        Me.Enabled = False

    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        frmchangepass.Show()
        frmchangepass.Activate()

        Me.Enabled = False

    End Sub

    Private Sub btnlock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlock.Click
        frmlocked.Show()
        frmlocked.Activate()

        Me.Enabled = False

    End Sub

End Class