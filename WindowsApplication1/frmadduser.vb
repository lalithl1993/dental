Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmadduser


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        frmadmin.Show()

        frmadmin.Enabled = True
        frmadmin.Activate()
    End Sub

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        If txtuname.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        sql = "insert into login values('" & txtuname.Text & "','" & txtuname.Text & "')"
        cmd = New SqlCommand(sql, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("new user created")
            frmadmin.RefreshList()
            txtuname.Text = ""


        Catch ae As SqlException
            MessageBox.Show(ae.ToString())
        End Try

    End Sub

    Private Sub frmadduser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmadduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub txtuname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuname.Enter
        AcceptButton = btncreate

    End Sub

    Private Sub txtuname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuname.KeyPress
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

End Class