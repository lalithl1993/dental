<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmin
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
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.btndeleteuser = New System.Windows.Forms.Button()
        Me.btnresetpass = New System.Windows.Forms.Button()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DentalDataSet = New WindowsApplication1.DentalDataSet()
        Me.LoginTableAdapter = New WindowsApplication1.DentalDataSetTableAdapters.loginTableAdapter()
        Me.listuser = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadduser
        '
        Me.btnadduser.BackColor = System.Drawing.Color.LightBlue
        Me.btnadduser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.Image = Global.WindowsApplication1.My.Resources.Resources.adduser
        Me.btnadduser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadduser.Location = New System.Drawing.Point(112, 318)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(152, 151)
        Me.btnadduser.TabIndex = 0
        Me.btnadduser.Text = "Add User"
        Me.btnadduser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadduser.UseVisualStyleBackColor = False
        '
        'btndeleteuser
        '
        Me.btndeleteuser.BackColor = System.Drawing.Color.LightBlue
        Me.btndeleteuser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteuser.Image = Global.WindowsApplication1.My.Resources.Resources.deleteuser
        Me.btndeleteuser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndeleteuser.Location = New System.Drawing.Point(316, 318)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(152, 151)
        Me.btndeleteuser.TabIndex = 2
        Me.btndeleteuser.Text = "Delete User"
        Me.btndeleteuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndeleteuser.UseVisualStyleBackColor = False
        '
        'btnresetpass
        '
        Me.btnresetpass.BackColor = System.Drawing.Color.LightBlue
        Me.btnresetpass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresetpass.Image = Global.WindowsApplication1.My.Resources.Resources.reset
        Me.btnresetpass.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnresetpass.Location = New System.Drawing.Point(523, 318)
        Me.btnresetpass.Name = "btnresetpass"
        Me.btnresetpass.Size = New System.Drawing.Size(152, 151)
        Me.btnresetpass.TabIndex = 4
        Me.btnresetpass.Text = "Reset"
        Me.btnresetpass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnresetpass.UseVisualStyleBackColor = False
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(46, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.DentalDataSet
        '
        'DentalDataSet
        '
        Me.DentalDataSet.DataSetName = "DentalDataSet"
        Me.DentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'listuser
        '
        Me.listuser.BackColor = System.Drawing.Color.SkyBlue
        Me.listuser.DataSource = Me.LoginBindingSource
        Me.listuser.DisplayMember = "username"
        Me.listuser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listuser.FormattingEnabled = True
        Me.listuser.ItemHeight = 19
        Me.listuser.Location = New System.Drawing.Point(411, 23)
        Me.listuser.Name = "listuser"
        Me.listuser.Size = New System.Drawing.Size(264, 232)
        Me.listuser.TabIndex = 7
        Me.listuser.ValueMember = "username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(169, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 135)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Admin"
        '
        'frmadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(770, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.listuser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnresetpass)
        Me.Controls.Add(Me.btndeleteuser)
        Me.Controls.Add(Me.btnadduser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmadmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadduser As System.Windows.Forms.Button
    Friend WithEvents btndeleteuser As System.Windows.Forms.Button
    Friend WithEvents btnresetpass As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DentalDataSet As WindowsApplication1.DentalDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As WindowsApplication1.DentalDataSetTableAdapters.loginTableAdapter
    Friend WithEvents listuser As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
