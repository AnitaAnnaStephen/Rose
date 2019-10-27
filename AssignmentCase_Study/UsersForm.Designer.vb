<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersForm
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
        Me.gbsearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.Label()
        Me.surname = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.gbsearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbsearch
        '
        Me.gbsearch.Controls.Add(Me.btnSearch)
        Me.gbsearch.Controls.Add(Me.txtSearch)
        Me.gbsearch.Controls.Add(Me.lbluserid)
        Me.gbsearch.Location = New System.Drawing.Point(563, 117)
        Me.gbsearch.Name = "gbsearch"
        Me.gbsearch.Size = New System.Drawing.Size(200, 132)
        Me.gbsearch.TabIndex = 0
        Me.gbsearch.TabStop = False
        Me.gbsearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(6, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(10, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(53, 20)
        Me.txtSearch.TabIndex = 1
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Location = New System.Drawing.Point(7, 34)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(74, 13)
        Me.lbluserid.TabIndex = 0
        Me.lbluserid.Text = "Enter User ID:"
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(51, 80)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(76, 16)
        Me.firstName.TabIndex = 1
        Me.firstName.Text = "First Name:"
        '
        'surname
        '
        Me.surname.AutoSize = True
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(51, 130)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(65, 16)
        Me.surname.TabIndex = 2
        Me.surname.Text = "Surname:"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(51, 170)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(36, 16)
        Me.age.TabIndex = 3
        Me.age.Text = "Age:"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(51, 220)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(77, 16)
        Me.username.TabIndex = 4
        Me.username.Text = "UserName:"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(51, 263)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(71, 16)
        Me.password.TabIndex = 5
        Me.password.Text = "Password:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(199, 79)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(199, 126)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 7
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(199, 167)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 8
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(199, 216)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(199, 263)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 10
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(81, 349)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Insert Data"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(234, 349)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update Data"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(366, 349)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(508, 349)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(118, 23)
        Me.btnMainMenu.TabIndex = 14
        Me.btnMainMenu.Text = "Return to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.gbsearch)
        Me.Name = "UsersForm"
        Me.Text = "Maintain_Users"
        Me.gbsearch.ResumeLayout(False)
        Me.gbsearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbsearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbluserid As Label
    Friend WithEvents firstName As Label
    Friend WithEvents surname As Label
    Friend WithEvents age As Label
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMainMenu As Button
End Class
