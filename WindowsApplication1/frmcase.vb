Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmcase
    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmmain.Show()
        frmmain.Enabled = True
        frmmain.Activate()
    End Sub

    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtid.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        sql = "update case1 set complents ='" & txtcomplents.Text & "',notes='" & txtnotes.Text & " 'where id='" & txtid.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("updated successfully")
            refreshdg()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
    End Sub

    Private Sub frmcase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmcase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DentalDataSet.case1' table. You can move, or remove it, as needed.
        Me.Case1TableAdapter.Fill(Me.DentalDataSet.case1)
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        Dim allowedChars As String = "0123456789"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave
        If txtid.Text = "" Then
        Else
            Try
                sql = "select * from case1 where id='" & txtid.Text & "'"
                cmd = New SqlCommand(sql, conn)
                Dim num As Integer
                num = cmd.ExecuteScalar

                If num = Nothing Then
                    MsgBox("invalid id")
                    txtcomplents.Text = ""
                    txtname.Text = ""
                    txtnotes.Text = ""

                    Exit Sub
                End If


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try

            Try
                sql = "select name from patient where id= " & txtid.Text & ""
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtname.Text = reader("name")
                reader.Close()


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                reader.Close()
            End Try
            Try
                sql = "select notes,complents from case1 where id= " & txtid.Text & ""
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtnotes.Text = reader("notes")
                txtcomplents.Text = reader("complents")

                reader.Close()


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                reader.Close()
            End Try
        End If
        
    End Sub

    Sub refreshdg()
        sql = "select * from case1"
        Dim ds As New DataSet
        ds.Clear()
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "case1")
        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)

        End If

    End Sub
End Class