Public Class frmsplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pb1.Value = Val(pb1.Value) + 1
        If pb1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmlogin.Show()
        End If
    End Sub

End Class
