Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmpatient
    

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmmain.Show()
        frmmain.Enabled = True
        frmmain.Activate()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text = "" Or txtphone.Text = "" Or txtemail.Text = "" Or txtaddress.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        Dim sex As String
        If rbmale.Checked = True Then
            sex = "male"
        ElseIf rbfemale.Checked = True Then
            sex = "female"
        End If
        sql = "insert into patient values('" & txtid.Text & "','" & txtname.Text & "','" & dtdob.Value.Date & "','" & sex & "','" & Val(txtphone.Text) & "','" & txtemail.Text & "','" & txtaddress.Text & "')"
        cmd = New SqlCommand(sql, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("data successfully recorded")

            createcase()
            listid.SelectedItem = Nothing
            RefreshList()
            txtid.Text = ""
            txtname.Text = ""
            txtphone.Text = ""
            txtemail.Text = ""
            txtaddress.Text = ""
        Catch ae As SqlException
            MessageBox.Show(ae.ToString())
        End Try

    End Sub

    Private Sub frmpatient_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub frmpatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DentalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.DentalDataSet.patient)

        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

  

    Private Sub txtid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid1.KeyPress
        Dim allowedChars As String = "0123456789"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtid1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid1.TextChanged
        If txtid1.Text = "" Then
        Else
            sql = "select * from patient where id= " & txtid1.Text & ""
            Try
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtname1.Text = reader("name")
                txtdob1.Text = reader("dob")
                dtdob1.Value = (reader("dob"))
                txtsex1.Text = reader("sex")
                txtphone1.Text = reader("phno")
                txtemail1.Text = reader("email")
                txtaddress1.Text = reader("address")
                reader.Close()


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                reader.Close()
            End Try
            
        End If
        

    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit1.Click
        txtname1.ReadOnly = False
        txtdob1.Visible = False
        dtdob1.Visible = True
        txtsex1.Visible = False

        rbfemale1.Visible = True
        rbmale1.Visible = True
        txtphone1.ReadOnly = False
        txtemail1.ReadOnly = False
        txtaddress1.ReadOnly = False

        listid.Enabled = False
        btncancel1.Visible = True
        btnedit1.Enabled = False
        btnupdate1.Visible = True

    End Sub

    Private Sub btnupdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate1.Click
        If txtname1.Text = "" Or txtphone1.Text = "" Or txtemail1.Text = "" Or txtaddress1.Text = "" Then
            MessageBox.Show("please fill all detales")
            Exit Sub

        End If

        Dim sex As String
        If rbmale1.Checked = True Then
            sex = "male"
        ElseIf rbfemale1.Checked = True Then
            sex = "female"
        End If
        sql = "update patient set name ='" & txtname1.Text & "',dob='" & dtdob1.Value.Date & "',sex='" & sex & "',phno='" & txtphone1.Text & "',email='" & txtemail1.Text & "',address='" & txtaddress1.Text & "' where id='" & txtid1.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("updated successfully")

            listid.SelectedItem = Nothing

            txtname1.ReadOnly = True
            txtdob1.Visible = True
            dtdob1.Visible = False
            txtsex1.Visible = True
            rbfemale1.Visible = False
            rbmale1.Visible = False
            txtphone1.ReadOnly = True
            txtemail1.ReadOnly = True
            txtaddress1.ReadOnly = True
            btnupdate1.Visible = False
            listid.Enabled = True
            btncancel1.Visible = False
            btnedit1.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

  

    Private Sub btncancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel1.Click

        txtname1.ReadOnly = True
        txtdob1.Visible = True
        dtdob1.Visible = False
        txtsex1.Visible = True
        rbfemale1.Visible = False
        rbmale1.Visible = False
        txtphone1.ReadOnly = True
        txtemail1.ReadOnly = True
        txtaddress1.ReadOnly = True

        listid.Enabled = True
        btncancel1.Visible = False
        btnedit1.Enabled = True
        btnupdate1.Visible = False

    End Sub
    Sub createcase()
        sql = "insert into case1 values('" & txtid.Text & "',' null' , 'null')"


        cmd = New SqlCommand(sql, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("case sheet created")
        Catch ae As SqlException
            MessageBox.Show(ae.ToString())
        End Try
    End Sub



    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Select Case MsgBox("all data of user will be deleted. do u want to continue??", MsgBoxStyle.YesNo, "confirm delete")
            Case MsgBoxResult.Yes
                'case delete
                sql = "delete from case1 where id='" & txtid1.Text & "'"

                cmd = New SqlCommand(sql, conn)



                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("case1 deleted")

                Catch ae As SqlException
                    MessageBox.Show(ae.Message.ToString())
                End Try

                'delete bill
                sql = "delete from bill where id='" & txtid1.Text & "'"

                cmd = New SqlCommand(sql, conn)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("bill deleted")

                Catch ae As SqlException
                    MessageBox.Show(ae.Message.ToString())
                End Try
                'delete appointment
                sql = "delete from appointment where id='" & txtid1.Text & "'"

                cmd = New SqlCommand(sql, conn)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("appointment deleted")

                Catch ae As SqlException
                    MessageBox.Show(ae.Message.ToString())
                End Try
                'delete patient
                sql = "delete from patient where id='" & txtid1.Text & "'"

                cmd = New SqlCommand(sql, conn)

                Try
                    cmd.ExecuteNonQuery()
                    listid.SelectedItem = Nothing
                    MsgBox("patient deleted")
                    listid.SelectedItem = Nothing
                    'Me.PatientTableAdapter.Fill(Me.DentalDataSet.patient)
                    RefreshList()

                Catch ae As SqlException
                    MessageBox.Show(ae.Message.ToString())
                End Try



            Case MsgBoxResult.No


        End Select


        


    End Sub

    Private Sub txtid2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid2.KeyPress
        Dim allowedChars As String = "0123456789"

        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtid2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid2.LostFocus
        If txtid2.Text = "" Then
        Else
            Try
                sql = "select name from patient where id= " & txtid2.Text & ""
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader()
                reader.Read()
                txtname.Text = reader("name")
                reader.Close()


            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                reader.Close()
            End Try
        End If

    End Sub

    Private Sub txtid2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid2.TextChanged
        AcceptButton = btnsearch2

    End Sub

    Private Sub btnsearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch2.Click
        Try
            sql = "select * from patient where id='" & txtid2.Text & "'"
            cmd = New SqlCommand(sql, conn)
            Dim num As Integer
            num = cmd.ExecuteScalar

            If num = Nothing Then
                MsgBox("invalid id")

                Exit Sub
            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        Try
            sql = "select name,phno,address from patient where id= " & txtid2.Text & ""
            cmd = New SqlCommand(sql, conn)
            reader = cmd.ExecuteReader()
            reader.Read()
            txtname2.Text = reader("name")
            txtphone2.Text = reader("phno")
            txtaddress2.Text = reader("address")
            reader.Close()


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            reader.Close()
        End Try

        Try
            sql = "select complents,notes from case1 where id= " & txtid2.Text & ""
            cmd = New SqlCommand(sql, conn)
            reader = cmd.ExecuteReader()
            reader.Read()
            txtcomplents2.Text = reader("complents")
            txtnotes2.Text = reader("notes")
            reader.Close()


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            reader.Close()
        End Try
        Dim type As String = "visit"

        Try
            sql = "select date as last from appointment where id= " & txtid2.Text & " and date=(select max(date) from appointment where type='" & type & "' )"
            cmd = New SqlCommand(sql, conn)
            reader = cmd.ExecuteReader()
            reader.Read()
            txtlastvisit.Text = reader("last")
            reader.Close()


        Catch ex As Exception
            'MsgBox(ex.Message.ToString())
            reader.Close()
        End Try
        Try
            sql = "select sum(amount) as amt from bill where id= " & txtid2.Text & ""
            cmd = New SqlCommand(sql, conn)
            reader = cmd.ExecuteReader()
            reader.Read()
            txtpaid.Text = reader("amt")
            reader.Close()


        Catch ex As Exception
            'MsgBox(ex.Message.ToString())
            reader.Close()
        End Try
    End Sub


    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click

        txtid.Text = ""
        txtname.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""
        txtaddress.Text = ""

    End Sub

    
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        AcceptButton = btnsave
        Call idload()
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


    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub txtphone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtphone.Leave
        If txtphone.Text = "" Then
        Else
            If (txtphone.TextLength < 10 Or txtphone.TextLength > 11) Then
                MsgBox("enter the correct phone number ")
                txtphone.Focus()
            End If
            End If

    End Sub


    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        If txtemail.Text = "" Then
        Else
            Dim ck As Boolean
            ck = EmailAddressCheck(txtemail.Text)
            If ck = False Then
                MsgBox("enter valid email")
                txtemail.Focus()
            End If

        End If


    End Sub


    Private Sub txtemail1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail1.Leave
        If txtemail1.Text = "" Then
        Else
            Dim ck As Boolean
            ck = EmailAddressCheck(txtemail1.Text)
            If ck = False Then
                MsgBox("enter valid email")
                txtemail1.Focus()
            End If

        End If
    End Sub


    Private Sub txtphone1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone1.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtphone1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtphone1.Leave
        If txtphone1.Text = "" Then
        Else
            If (txtphone1.TextLength < 10 Or txtphone1.TextLength > 11) Then
                MsgBox("enter the correct phone no lofer ")
                txtphone1.Focus()
            End If
        End If
    End Sub


    

    Private Sub listid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listid.SelectedIndexChanged
        'txtid1.Text = listid.SelectedValue
        Dim str As String
        Try
            str = listid.SelectedValue
            txtid1.Text = str
        Catch ex As Exception

        End Try
    End Sub
    Function idload()
        Try
            sql = "select max(id) from patient "
            cmd = New SqlCommand(sql, conn)
            Dim num As Integer

            If cmd.ExecuteScalar Is System.DBNull.Value Then
                txtid.Text = 1
            Else
                num = cmd.ExecuteScalar
                txtid.Text = num + 1

            End If


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        txtname.Focus()

    End Function

    Private Sub txtid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtid.GotFocus
        Call idload()


    End Sub
    Sub RefreshList()
        sql = "select * from patient"
        Dim ds As New DataSet
        ds.Clear()
        Dim da As New SqlDataAdapter(sql, conn)
        da.Fill(ds, "patient")
        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count > 0 Then
            listid.DataSource = ds.Tables(0)
            listid.DisplayMember = "name"
            listid.ValueMember = "id"

        End If
    End Sub

    Private Sub txtname1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname1.KeyPress
        If Char.IsLetter(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub
End Class
