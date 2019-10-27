<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_User_Roles_Form
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.btnInsertUserRole = New System.Windows.Forms.Button()
        Me.selectrole = New System.Windows.Forms.Label()
        Me.selectuser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowRole = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboRole)
        Me.GroupBox1.Controls.Add(Me.cboUsers)
        Me.GroupBox1.Controls.Add(Me.btnInsertUserRole)
        Me.GroupBox1.Controls.Add(Me.selectrole)
        Me.GroupBox1.Controls.Add(Me.selectuser)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assigning Roles to Users"
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(198, 59)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(121, 24)
        Me.cboRole.TabIndex = 4
        '
        'cboUsers
        '
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(6, 59)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(121, 24)
        Me.cboUsers.TabIndex = 3
        '
        'btnInsertUserRole
        '
        Me.btnInsertUserRole.Location = New System.Drawing.Point(601, 23)
        Me.btnInsertUserRole.Name = "btnInsertUserRole"
        Me.btnInsertUserRole.Size = New System.Drawing.Size(82, 51)
        Me.btnInsertUserRole.TabIndex = 2
        Me.btnInsertUserRole.Text = "Insert User and Role"
        Me.btnInsertUserRole.UseVisualStyleBackColor = True
        '
        'selectrole
        '
        Me.selectrole.AutoSize = True
        Me.selectrole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectrole.Location = New System.Drawing.Point(218, 23)
        Me.selectrole.Name = "selectrole"
        Me.selectrole.Size = New System.Drawing.Size(81, 16)
        Me.selectrole.TabIndex = 1
        Me.selectrole.Text = "Select Role:"
        '
        'selectuser
        '
        Me.selectuser.AutoSize = True
        Me.selectuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectuser.Location = New System.Drawing.Point(7, 22)
        Me.selectuser.Name = "selectuser"
        Me.selectuser.Size = New System.Drawing.Size(81, 16)
        Me.selectuser.TabIndex = 0
        Me.selectuser.Text = "Select User:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Roles for Selected User"
        '
        'btnShowRole
        '
        Me.btnShowRole.Location = New System.Drawing.Point(317, 359)
        Me.btnShowRole.Name = "btnShowRole"
        Me.btnShowRole.Size = New System.Drawing.Size(75, 37)
        Me.btnShowRole.TabIndex = 2
        Me.btnShowRole.Text = "Refresh Listbox"
        Me.btnShowRole.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(543, 359)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 38)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "Return Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(29, 257)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(166, 160)
        Me.ListBox1.TabIndex = 4
        '
        'Manage_User_Roles_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnShowRole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Manage_User_Roles_Form"
        Me.Text = "Manage_User_Roles_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents selectrole As Label
    Friend WithEvents selectuser As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents btnInsertUserRole As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowRole As Button
    Friend WithEvents btnMainMenu As Button


    Friend WithEvents ListBox1 As ListBox
End Class
