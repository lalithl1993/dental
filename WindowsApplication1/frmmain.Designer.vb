<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnlock = New System.Windows.Forms.Button()
        Me.pbbill = New System.Windows.Forms.PictureBox()
        Me.pbcase = New System.Windows.Forms.PictureBox()
        Me.pbappointment = New System.Windows.Forms.PictureBox()
        Me.pbpatient = New System.Windows.Forms.PictureBox()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbbill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(46, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem1, Me.LogoutToolStripMenuItem1})
        Me.ToolStripMenuItem2.Image = Global.WindowsApplication1.My.Resources.Resources.settings
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(38, 20)
        Me.ToolStripMenuItem2.Text = " "
        '
        'ChangePasswordToolStripMenuItem1
        '
        Me.ChangePasswordToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ChangePasswordToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1"
        Me.ChangePasswordToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ChangePasswordToolStripMenuItem1.Text = "Change Password"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Patient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Appointment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(390, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Case Sheet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(558, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bill"
        '
        'btnlock
        '
        Me.btnlock.BackColor = System.Drawing.Color.LightBlue
        Me.btnlock.Image = Global.WindowsApplication1.My.Resources.Resources.locked3
        Me.btnlock.Location = New System.Drawing.Point(622, 424)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(75, 38)
        Me.btnlock.TabIndex = 12
        Me.btnlock.UseVisualStyleBackColor = False
        '
        'pbbill
        '
        Me.pbbill.BackColor = System.Drawing.Color.Transparent
        Me.pbbill.Image = Global.WindowsApplication1.My.Resources.Resources.bill
        Me.pbbill.Location = New System.Drawing.Point(513, 82)
        Me.pbbill.Name = "pbbill"
        Me.pbbill.Size = New System.Drawing.Size(130, 133)
        Me.pbbill.TabIndex = 3
        Me.pbbill.TabStop = False
        '
        'pbcase
        '
        Me.pbcase.BackColor = System.Drawing.Color.Transparent
        Me.pbcase.Image = Global.WindowsApplication1.My.Resources.Resources.case_sheet
        Me.pbcase.Location = New System.Drawing.Point(365, 82)
        Me.pbcase.Name = "pbcase"
        Me.pbcase.Size = New System.Drawing.Size(132, 133)
        Me.pbcase.TabIndex = 2
        Me.pbcase.TabStop = False
        '
        'pbappointment
        '
        Me.pbappointment.BackColor = System.Drawing.Color.Transparent
        Me.pbappointment.Image = Global.WindowsApplication1.My.Resources.Resources.appo1
        Me.pbappointment.Location = New System.Drawing.Point(211, 82)
        Me.pbappointment.Name = "pbappointment"
        Me.pbappointment.Size = New System.Drawing.Size(131, 133)
        Me.pbappointment.TabIndex = 1
        Me.pbappointment.TabStop = False
        '
        'pbpatient
        '
        Me.pbpatient.BackColor = System.Drawing.Color.Transparent
        Me.pbpatient.Image = Global.WindowsApplication1.My.Resources.Resources.patient
        Me.pbpatient.Location = New System.Drawing.Point(66, 82)
        Me.pbpatient.Name = "pbpatient"
        Me.pbpatient.Size = New System.Drawing.Size(123, 133)
        Me.pbpatient.TabIndex = 0
        Me.pbpatient.TabStop = False
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ProfileToolStripMenuItem.Text = "profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LogoutToolStripMenuItem.Text = "logout"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "change password"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
        Me.ToolStripMenuItem1.Text = " "
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(733, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbbill)
        Me.Controls.Add(Me.pbcase)
        Me.Controls.Add(Me.pbappointment)
        Me.Controls.Add(Me.pbpatient)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "welcome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbbill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbappointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbpatient As System.Windows.Forms.PictureBox
    Friend WithEvents pbappointment As System.Windows.Forms.PictureBox
    Friend WithEvents pbcase As System.Windows.Forms.PictureBox
    Friend WithEvents pbbill As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnlock As System.Windows.Forms.Button
End Class
