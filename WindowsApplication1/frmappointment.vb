Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmappointment
  
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmmain.Show()
        frmmain.Enabled = True
        frmmain.Activate()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or txtid.Text = "" Or txtvisit.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        Dim visit As String
        If rbappointment.Checked = True Then
            visit = "appointment"

        ElseIf rbvisit.Checked = True Then

            visit = "visit"
        End If

        sql = "insert into appointment values('" & txtid.Text & "','" & txtvisit.Text & "','" & dtdate.Value.Date & "','" & dttime.Value & "','" & visit & "')"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("data successfully recorded")
            refreshdg()

            txtid.Text = ""
            txtname.Text = ""
            txtvisit.Text = ""

        Catch ae As SqlException
            MessageBox.Show(ae.ToString())
        End Try
    End Sub

    Private Sub frmappointment_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dtdate.MinDate = Today
        dttime.Value = Now
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmappointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        'TODO: This line of code loads data into the 'DentalDataSet.appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.DentalDataSet.appointment)
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub AppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DentalDataSet)

    End Sub

    Private Sub rbvisit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbvisit.CheckedChanged
        dtdate.Visible = False
        dttime.Visible = False
        lbltime.Visible = False

    End Sub

    Private Sub rbappointment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbappointment.CheckedChanged
        dtdate.Visible = True
        dttime.Visible = True
        lbltime.Visible = True

    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.Leave

        Try
            sql = "select * from patient where id='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, conn)
            Dim num As Integer
            num = cmd.ExecuteScalar

            If num = Nothing Then
                MsgBox("invalid id")
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
            'reader.Close()
        End Try
        Try
            sql = "select max(visit) from appointment"
            cmd = New SqlCommand(sql, conn)
            Dim num As Integer
            num = cmd.ExecuteScalar

            If num = Nothing Then
                txtvisit.Text = 1
            Else
                txtvisit.Text = num + 1

            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub


    Private Sub txtvisit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvisit.KeyPress
        Dim allowedChars As String = "0123456789"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub
    Sub refreshdg()
        sql = "select * from appointment"
        Dim ds As New DataSet
        ds.Clear()
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "appointment")
        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            AppointmentDataGridView.DataSource = ds.Tables(0)

        End If

    End Sub

End Class