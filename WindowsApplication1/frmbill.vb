Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmbill

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmmain.Show()
        frmmain.Enabled = True
        frmmain.Activate()
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtid.Text = "" Or txtamount.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        Dim curtime As String = TimeOfDay
        Dim curdate As String = DateString

        sql = "insert into bill values('" & txtid.Text & "','" & txtvisit.Text & "','" & txtamount.Text & "','" & curtime & "','" & curdate & "','" & dtnext.Value.Date & "')"
        cmd = New SqlCommand(sql, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("data successfully recorded")
            refreshdg()
            txtid.Text = ""
            txtname.Text = ""
            txtvisit.Text = ""
            txtamount.Text = ""
        Catch ae As SqlException
            MessageBox.Show(ae.ToString())
        End Try
    End Sub

    Private Sub frmbill_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dtnext.MinDate = Today


        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
    'TODO: This line of code loads data into the 'DentalDataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.DentalDataSet.bill)
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

    Private Sub txtid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.LostFocus
        
        If txtid.Text = "" Then

        Else
            Try
                sql = "select * from appointment where id='" & txtid.Text & "'"
                cmd = New SqlCommand(sql, conn)
                Dim num As Integer
                num = cmd.ExecuteScalar

                If num = Nothing Then
                    MsgBox("invalid id")
                    txtamount.Text = ""
                    txtname.Text = ""
                    txtvisit.Text = ""

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
                'Dim visit As String = "visit"
                sql = "select max(visit) as max from appointment where id= " & txtid.Text & " and type= 'visit' "
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtvisit.Text = reader("max")
                reader.Close()


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                reader.Close()
            End Try
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataGridView1.Refresh()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay

    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub


    Sub refreshdg()
        sql = "select * from bill"
        Dim ds As New DataSet
        ds.Clear()
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "bill")
        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)

        End If

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        On Error GoTo errorfound
        Printbill.Print()
        Exit Sub
errorfound:
        MsgBox("please connect to printer")
    End Sub
End Class