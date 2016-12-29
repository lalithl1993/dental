Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmchangepass
    
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        If frmlogin.username = "admin" Then
            frmadmin.Show()
            frmadmin.Enabled = True
            Me.Hide()
        Else
            frmmain.Show()
            frmmain.Enabled = True
            Me.Hide()
        End If

    End Sub

    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If txtconp.Text = "" Or txtcp.Text = "" Or txtnp.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        If Not (txtcp.Text = frmlogin.userpass) Then
            MessageBox.Show("please enter right password")
            txtcp.Text = ""
            txtnp.Text = ""
            txtconp.Text = ""
            Exit Sub
        ElseIf Not (txtnp.Text = txtconp.Text) Then
            MessageBox.Show("confirmation failed")
            txtcp.Text = ""
            txtnp.Text = ""
            txtconp.Text = ""
            Exit Sub
        Else

            sql = "update login set password='" & txtconp.Text & "' where username='" & frmlogin.username & "'"
            cmd = New SqlCommand(sql, conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("password changed successfully")
                frmlogin.userpass = txtconp.Text

                txtcp.Text = ""
                txtnp.Text = ""
                txtconp.Text = ""
                If frmlogin.username = "admin" Then
                    frmadmin.Show()
                    frmadmin.Enabled = True
                    Me.Hide()
                Else
                    frmmain.Show()
                    frmmain.Enabled = True
                    Me.Hide()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try

        End If
    End Sub

    Private Sub frmchangepass_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmchangepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub
End Class