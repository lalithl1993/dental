<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlocked
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
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnunlock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(198, 46)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(177, 22)
        Me.txtpass.TabIndex = 1
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.LightBlue
        Me.btnexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(248, 85)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(63, 44)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password Please"
        '
        'btnunlock
        '
        Me.btnunlock.BackColor = System.Drawing.Color.LightBlue
        Me.btnunlock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunlock.Image = Global.WindowsApplication1.My.Resources.Resources.unlocked3
        Me.btnunlock.Location = New System.Drawing.Point(122, 85)
        Me.btnunlock.Name = "btnunlock"
        Me.btnunlock.Size = New System.Drawing.Size(65, 44)
        Me.btnunlock.TabIndex = 3
        Me.btnunlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnunlock.UseVisualStyleBackColor = False
        '
        'frmlocked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(443, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnunlock)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmlocked"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "locked!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnunlock As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
