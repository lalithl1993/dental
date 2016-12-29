<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.listid = New System.Windows.Forms.ListBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DentalDataSet = New WindowsApplication1.DentalDataSet()
        Me.dtdob1 = New System.Windows.Forms.DateTimePicker()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.rbfemale1 = New System.Windows.Forms.RadioButton()
        Me.rbmale1 = New System.Windows.Forms.RadioButton()
        Me.btncancel1 = New System.Windows.Forms.Button()
        Me.txtsex1 = New System.Windows.Forms.TextBox()
        Me.btnupdate1 = New System.Windows.Forms.Button()
        Me.txtaddress1 = New System.Windows.Forms.TextBox()
        Me.txtemail1 = New System.Windows.Forms.TextBox()
        Me.txtphone1 = New System.Windows.Forms.TextBox()
        Me.txtdob1 = New System.Windows.Forms.TextBox()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtid1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.dtdob = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnsearch2 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtnotes2 = New System.Windows.Forms.TextBox()
        Me.txtcomplents2 = New System.Windows.Forms.TextBox()
        Me.txtaddress2 = New System.Windows.Forms.TextBox()
        Me.txtphone2 = New System.Windows.Forms.TextBox()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.txtpaid = New System.Windows.Forms.TextBox()
        Me.txtlastvisit = New System.Windows.Forms.TextBox()
        Me.txtid2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.PatientTableAdapter = New WindowsApplication1.DentalDataSetTableAdapters.patientTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(256, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 67)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(616, 437)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.Controls.Add(Me.listid)
        Me.TabPage2.Controls.Add(Me.dtdob1)
        Me.TabPage2.Controls.Add(Me.btndelete)
        Me.TabPage2.Controls.Add(Me.rbfemale1)
        Me.TabPage2.Controls.Add(Me.rbmale1)
        Me.TabPage2.Controls.Add(Me.btncancel1)
        Me.TabPage2.Controls.Add(Me.txtsex1)
        Me.TabPage2.Controls.Add(Me.btnupdate1)
        Me.TabPage2.Controls.Add(Me.txtaddress1)
        Me.TabPage2.Controls.Add(Me.txtemail1)
        Me.TabPage2.Controls.Add(Me.txtphone1)
        Me.TabPage2.Controls.Add(Me.txtdob1)
        Me.TabPage2.Controls.Add(Me.txtname1)
        Me.TabPage2.Controls.Add(Me.btnedit1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtid1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(608, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        '
        'listid
        '
        Me.listid.DataSource = Me.PatientBindingSource
        Me.listid.DisplayMember = "name"
        Me.listid.FormattingEnabled = True
        Me.listid.ItemHeight = 16
        Me.listid.Location = New System.Drawing.Point(6, 33)
        Me.listid.Name = "listid"
        Me.listid.Size = New System.Drawing.Size(212, 244)
        Me.listid.TabIndex = 51
        Me.listid.ValueMember = "id"
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.DentalDataSet
        '
        'DentalDataSet
        '
        Me.DentalDataSet.DataSetName = "DentalDataSet"
        Me.DentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtdob1
        '
        Me.dtdob1.CustomFormat = "d/MM/yyy"
        Me.dtdob1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdob1.Location = New System.Drawing.Point(352, 111)
        Me.dtdob1.MaxDate = New Date(2013, 9, 18, 0, 0, 0, 0)
        Me.dtdob1.Name = "dtdob1"
        Me.dtdob1.ShowUpDown = True
        Me.dtdob1.Size = New System.Drawing.Size(155, 22)
        Me.dtdob1.TabIndex = 50
        Me.dtdob1.Value = New Date(2013, 9, 18, 0, 0, 0, 0)
        Me.dtdob1.Visible = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightBlue
        Me.btndelete.Image = Global.WindowsApplication1.My.Resources.Resources.trash
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndelete.Location = New System.Drawing.Point(143, 312)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 40)
        Me.btndelete.TabIndex = 48
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'rbfemale1
        '
        Me.rbfemale1.AutoSize = True
        Me.rbfemale1.Location = New System.Drawing.Point(412, 154)
        Me.rbfemale1.Name = "rbfemale1"
        Me.rbfemale1.Size = New System.Drawing.Size(78, 20)
        Me.rbfemale1.TabIndex = 47
        Me.rbfemale1.Text = "FEMALE"
        Me.rbfemale1.UseVisualStyleBackColor = True
        Me.rbfemale1.Visible = False
        '
        'rbmale1
        '
        Me.rbmale1.AutoSize = True
        Me.rbmale1.Checked = True
        Me.rbmale1.Location = New System.Drawing.Point(352, 154)
        Me.rbmale1.Name = "rbmale1"
        Me.rbmale1.Size = New System.Drawing.Size(62, 20)
        Me.rbmale1.TabIndex = 46
        Me.rbmale1.TabStop = True
        Me.rbmale1.Text = "MALE"
        Me.rbmale1.UseVisualStyleBackColor = True
        Me.rbmale1.Visible = False
        '
        'btncancel1
        '
        Me.btncancel1.BackColor = System.Drawing.Color.LightBlue
        Me.btncancel1.Image = Global.WindowsApplication1.My.Resources.Resources.cross
        Me.btncancel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancel1.Location = New System.Drawing.Point(199, 358)
        Me.btncancel1.Name = "btncancel1"
        Me.btncancel1.Size = New System.Drawing.Size(75, 36)
        Me.btncancel1.TabIndex = 45
        Me.btncancel1.Text = "Cancel"
        Me.btncancel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel1.UseVisualStyleBackColor = False
        Me.btncancel1.Visible = False
        '
        'txtsex1
        '
        Me.txtsex1.Location = New System.Drawing.Point(352, 154)
        Me.txtsex1.Name = "txtsex1"
        Me.txtsex1.ReadOnly = True
        Me.txtsex1.Size = New System.Drawing.Size(121, 22)
        Me.txtsex1.TabIndex = 42
        '
        'btnupdate1
        '
        Me.btnupdate1.BackColor = System.Drawing.Color.LightBlue
        Me.btnupdate1.Image = Global.WindowsApplication1.My.Resources.Resources.retweet
        Me.btnupdate1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnupdate1.Location = New System.Drawing.Point(84, 358)
        Me.btnupdate1.Name = "btnupdate1"
        Me.btnupdate1.Size = New System.Drawing.Size(75, 36)
        Me.btnupdate1.TabIndex = 43
        Me.btnupdate1.Text = "Update"
        Me.btnupdate1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnupdate1.UseVisualStyleBackColor = False
        Me.btnupdate1.Visible = False
        '
        'txtaddress1
        '
        Me.txtaddress1.Location = New System.Drawing.Point(352, 274)
        Me.txtaddress1.Multiline = True
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.ReadOnly = True
        Me.txtaddress1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaddress1.Size = New System.Drawing.Size(240, 115)
        Me.txtaddress1.TabIndex = 40
        '
        'txtemail1
        '
        Me.txtemail1.Location = New System.Drawing.Point(352, 234)
        Me.txtemail1.Name = "txtemail1"
        Me.txtemail1.ReadOnly = True
        Me.txtemail1.Size = New System.Drawing.Size(240, 22)
        Me.txtemail1.TabIndex = 39
        '
        'txtphone1
        '
        Me.txtphone1.Location = New System.Drawing.Point(352, 194)
        Me.txtphone1.Name = "txtphone1"
        Me.txtphone1.ReadOnly = True
        Me.txtphone1.Size = New System.Drawing.Size(149, 22)
        Me.txtphone1.TabIndex = 38
        '
        'txtdob1
        '
        Me.txtdob1.Location = New System.Drawing.Point(352, 113)
        Me.txtdob1.Name = "txtdob1"
        Me.txtdob1.ReadOnly = True
        Me.txtdob1.Size = New System.Drawing.Size(149, 22)
        Me.txtdob1.TabIndex = 36
        '
        'txtname1
        '
        Me.txtname1.Location = New System.Drawing.Point(352, 76)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.ReadOnly = True
        Me.txtname1.Size = New System.Drawing.Size(149, 22)
        Me.txtname1.TabIndex = 35
        '
        'btnedit1
        '
        Me.btnedit1.BackColor = System.Drawing.Color.LightBlue
        Me.btnedit1.Image = Global.WindowsApplication1.My.Resources.Resources.pencil
        Me.btnedit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnedit1.Location = New System.Drawing.Point(29, 312)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(75, 40)
        Me.btnedit1.TabIndex = 34
        Me.btnedit1.Text = "Edit"
        Me.btnedit1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(253, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "SEX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "DOB"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(253, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(253, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "E-Mail"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 194)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Phone No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(253, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 16)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(253, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "ID"
        '
        'txtid1
        '
        Me.txtid1.Location = New System.Drawing.Point(352, 33)
        Me.txtid1.Name = "txtid1"
        Me.txtid1.ReadOnly = True
        Me.txtid1.Size = New System.Drawing.Size(100, 22)
        Me.txtid1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Patient List"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage1.Controls.Add(Me.Btnclear)
        Me.TabPage1.Controls.Add(Me.dtdob)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Controls.Add(Me.rbfemale)
        Me.TabPage1.Controls.Add(Me.rbmale)
        Me.TabPage1.Controls.Add(Me.txtaddress)
        Me.TabPage1.Controls.Add(Me.txtemail)
        Me.TabPage1.Controls.Add(Me.txtphone)
        Me.TabPage1.Controls.Add(Me.txtname)
        Me.TabPage1.Controls.Add(Me.txtid)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(608, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add"
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.LightBlue
        Me.Btnclear.Image = Global.WindowsApplication1.My.Resources.Resources.cross
        Me.Btnclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnclear.Location = New System.Drawing.Point(460, 310)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(75, 39)
        Me.Btnclear.TabIndex = 41
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'dtdob
        '
        Me.dtdob.CustomFormat = "d/MM/yyy"
        Me.dtdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdob.Location = New System.Drawing.Point(88, 88)
        Me.dtdob.MaxDate = New Date(2013, 9, 18, 0, 0, 0, 0)
        Me.dtdob.Name = "dtdob"
        Me.dtdob.ShowUpDown = True
        Me.dtdob.Size = New System.Drawing.Size(155, 22)
        Me.dtdob.TabIndex = 40
        Me.dtdob.Value = New Date(2013, 9, 18, 0, 0, 0, 0)
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightBlue
        Me.btnsave.Image = Global.WindowsApplication1.My.Resources.Resources.tick
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(460, 236)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 38)
        Me.btnsave.TabIndex = 38
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(196, 131)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(78, 20)
        Me.rbfemale.TabIndex = 37
        Me.rbfemale.Text = "FEMALE"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Checked = True
        Me.rbmale.Location = New System.Drawing.Point(104, 131)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(62, 20)
        Me.rbmale.TabIndex = 36
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "MALE"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(87, 249)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaddress.Size = New System.Drawing.Size(290, 131)
        Me.txtaddress.TabIndex = 32
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(88, 209)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(289, 22)
        Me.txtemail.TabIndex = 31
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(88, 169)
        Me.txtphone.MaxLength = 11
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(155, 22)
        Me.txtphone.TabIndex = 30
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(87, 51)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(155, 22)
        Me.txtname.TabIndex = 28
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(87, 14)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(154, 22)
        Me.txtid.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "SEX"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "E-Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Phone No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage3.Controls.Add(Me.btnsearch2)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.txtnotes2)
        Me.TabPage3.Controls.Add(Me.txtcomplents2)
        Me.TabPage3.Controls.Add(Me.txtaddress2)
        Me.TabPage3.Controls.Add(Me.txtphone2)
        Me.TabPage3.Controls.Add(Me.txtname2)
        Me.TabPage3.Controls.Add(Me.txtpaid)
        Me.TabPage3.Controls.Add(Me.txtlastvisit)
        Me.TabPage3.Controls.Add(Me.txtid2)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(608, 408)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "History"
        '
        'btnsearch2
        '
        Me.btnsearch2.BackColor = System.Drawing.Color.LightBlue
        Me.btnsearch2.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.btnsearch2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsearch2.Location = New System.Drawing.Point(151, 21)
        Me.btnsearch2.Name = "btnsearch2"
        Me.btnsearch2.Size = New System.Drawing.Size(89, 39)
        Me.btnsearch2.TabIndex = 25
        Me.btnsearch2.Text = "Search"
        Me.btnsearch2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsearch2.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(307, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 16)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Doctor's Notes"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 16)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Patient Complaints"
        '
        'txtnotes2
        '
        Me.txtnotes2.Location = New System.Drawing.Point(310, 110)
        Me.txtnotes2.Multiline = True
        Me.txtnotes2.Name = "txtnotes2"
        Me.txtnotes2.ReadOnly = True
        Me.txtnotes2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtnotes2.Size = New System.Drawing.Size(290, 89)
        Me.txtnotes2.TabIndex = 22
        '
        'txtcomplents2
        '
        Me.txtcomplents2.Location = New System.Drawing.Point(16, 110)
        Me.txtcomplents2.Multiline = True
        Me.txtcomplents2.Name = "txtcomplents2"
        Me.txtcomplents2.ReadOnly = True
        Me.txtcomplents2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcomplents2.Size = New System.Drawing.Size(290, 89)
        Me.txtcomplents2.TabIndex = 21
        '
        'txtaddress2
        '
        Me.txtaddress2.Location = New System.Drawing.Point(102, 294)
        Me.txtaddress2.Multiline = True
        Me.txtaddress2.Name = "txtaddress2"
        Me.txtaddress2.ReadOnly = True
        Me.txtaddress2.Size = New System.Drawing.Size(259, 89)
        Me.txtaddress2.TabIndex = 11
        '
        'txtphone2
        '
        Me.txtphone2.Location = New System.Drawing.Point(103, 252)
        Me.txtphone2.Name = "txtphone2"
        Me.txtphone2.ReadOnly = True
        Me.txtphone2.Size = New System.Drawing.Size(137, 22)
        Me.txtphone2.TabIndex = 10
        '
        'txtname2
        '
        Me.txtname2.Location = New System.Drawing.Point(62, 58)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.ReadOnly = True
        Me.txtname2.Size = New System.Drawing.Size(77, 22)
        Me.txtname2.TabIndex = 9
        '
        'txtpaid
        '
        Me.txtpaid.Location = New System.Drawing.Point(458, 283)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.ReadOnly = True
        Me.txtpaid.Size = New System.Drawing.Size(110, 22)
        Me.txtpaid.TabIndex = 8
        '
        'txtlastvisit
        '
        Me.txtlastvisit.Location = New System.Drawing.Point(494, 29)
        Me.txtlastvisit.Name = "txtlastvisit"
        Me.txtlastvisit.ReadOnly = True
        Me.txtlastvisit.Size = New System.Drawing.Size(93, 22)
        Me.txtlastvisit.TabIndex = 7
        '
        'txtid2
        '
        Me.txtid2.Location = New System.Drawing.Point(55, 24)
        Me.txtid2.Name = "txtid2"
        Me.txtid2.Size = New System.Drawing.Size(71, 22)
        Me.txtid2.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 16)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Address"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Phone No."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(461, 249)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Total Paid"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(414, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Last Visit"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(88, 209)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(155, 20)
        Me.txtmail.TabIndex = 31
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'frmpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(636, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmpatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtid1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit1 As System.Windows.Forms.Button
    Friend WithEvents dtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtemail1 As System.Windows.Forms.TextBox
    Friend WithEvents txtphone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdob1 As System.Windows.Forms.TextBox
    Friend WithEvents txtname1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsex1 As System.Windows.Forms.TextBox
    Friend WithEvents btnupdate1 As System.Windows.Forms.Button
    Friend WithEvents btncancel1 As System.Windows.Forms.Button
    Friend WithEvents rbfemale1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtaddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtphone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtname2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpaid As System.Windows.Forms.TextBox
    Friend WithEvents txtlastvisit As System.Windows.Forms.TextBox
    Friend WithEvents txtid2 As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtnotes2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplents2 As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch2 As System.Windows.Forms.Button
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents dtdob1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DentalDataSet As WindowsApplication1.DentalDataSet
    Friend WithEvents PatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientTableAdapter As WindowsApplication1.DentalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents listid As System.Windows.Forms.ListBox
End Class
