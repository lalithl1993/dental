<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangepass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.txtnp = New System.Windows.Forms.TextBox()
        Me.txtconp = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password"
        '
        'txtcp
        '
        Me.txtcp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcp.Location = New System.Drawing.Point(172, 46)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcp.Size = New System.Drawing.Size(100, 22)
        Me.txtcp.TabIndex = 3
        '
        'txtnp
        '
        Me.txtnp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnp.Location = New System.Drawing.Point(172, 78)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnp.Size = New System.Drawing.Size(100, 22)
        Me.txtnp.TabIndex = 4
        '
        'txtconp
        '
        Me.txtconp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconp.Location = New System.Drawing.Point(172, 109)
        Me.txtconp.Name = "txtconp"
        Me.txtconp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconp.Size = New System.Drawing.Size(100, 22)
        Me.txtconp.TabIndex = 5
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.LightBlue
        Me.btncancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Image = Global.WindowsApplication1.My.Resources.Resources.cross
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancel.Location = New System.Drawing.Point(172, 173)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 36)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.LightBlue
        Me.btnchange.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.Image = Global.WindowsApplication1.My.Resources.Resources.tick
        Me.btnchange.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnchange.Location = New System.Drawing.Point(50, 173)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(75, 36)
        Me.btnchange.TabIndex = 6
        Me.btnchange.Text = "Change"
        Me.btnchange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'frmchangepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.b1
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.txtconp)
        Me.Controls.Add(Me.txtnp)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmchangepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents txtnp As System.Windows.Forms.TextBox
    Friend WithEvents txtconp As System.Windows.Forms.TextBox
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
