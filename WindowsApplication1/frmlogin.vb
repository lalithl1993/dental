Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class frmlogin
    Friend username As String
    Friend userpass As String
    
    

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtuname.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        username = txtuname.Text
        userpass = txtpass.Text
        sql = "select username,password from login where username = '" & txtuname.Text & "' and password ='" & txtpass.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Try
            If dr.Read = False Then
                MessageBox.Show("login failed")
                txtuname.Text = ""
                txtpass.Text = ""

            Else
                MessageBox.Show("login success")
                Me.Hide()
                If txtuname.Text = "admin" Then
                    frmadmin.Show()
                    frmadmin.Activate()
                Else
                    frmmain.Show()
                    frmmain.Activate()
                End If
                txtuname.Text = ""
                txtpass.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmlogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
        AcceptButton = btnlogin

    End Sub
End Class