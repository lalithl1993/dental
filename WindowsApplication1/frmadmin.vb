Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmadmin
    Dim usname As String

    Private Sub btnadduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadduser.Click
        frmadduser.Show()
        frmadduser.Activate()
        Me.Enabled = False

    End Sub

    Private Sub frmadmin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DentalDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DentalDataSet.login)


        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub btndeleteuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeleteuser.Click
        If usname = "admin" Then
            MessageBox.Show("admin account cannot be deleted")
            Exit Sub
        Else
            sql = "delete from login where username='" & usname & "'"
            cmd = New SqlCommand(sql, conn)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("account deleted")
                listuser.SelectedItem = Nothing
                RefreshList()
            Catch ae As SqlException
                MessageBox.Show(ae.Message.ToString())
            End Try

        End If


    End Sub

    Private Sub btnresetpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresetpass.Click
        sql = "update login set password='" & usname & "' where username='" & usname & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("password reset successfully")

            Me.LoginTableAdapter.Fill(Me.DentalDataSet.login)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        frmchangepass.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        frmlogin.Show()
        Me.Hide()
    End Sub



    Private Sub listuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listuser.SelectedIndexChanged
        usname = listuser.SelectedValue
    End Sub

    Sub RefreshList()
        sql = "select * from login"
        Dim ds As New DataSet
        ds.Clear()
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "login")
        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            listuser.DataSource = ds.Tables(0)
            listuser.DisplayMember = "username"
            listuser.ValueMember = "username"

        End If
    End Sub
End Class