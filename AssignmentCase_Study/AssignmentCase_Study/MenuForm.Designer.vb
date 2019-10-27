<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.lblselect = New System.Windows.Forms.Label()
        Me.gbmaintain = New System.Windows.Forms.GroupBox()
        Me.btnDBAdmin = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.bbTables = New System.Windows.Forms.GroupBox()
        Me.btnDropTable = New System.Windows.Forms.Button()
        Me.btnCreateUsersTable = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbmaintain.SuspendLayout()
        Me.bbTables.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblselect
        '
        Me.lblselect.AutoSize = True
        Me.lblselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselect.Location = New System.Drawing.Point(42, 29)
        Me.lblselect.Name = "lblselect"
        Me.lblselect.Size = New System.Drawing.Size(280, 20)
        Me.lblselect.TabIndex = 0
        Me.lblselect.Text = "Select a Button to Open the Form"
        '
        'gbmaintain
        '
        Me.gbmaintain.Controls.Add(Me.btnDBAdmin)
        Me.gbmaintain.Controls.Add(Me.btnDisplay)
        Me.gbmaintain.Controls.Add(Me.btnUsers)
        Me.gbmaintain.Location = New System.Drawing.Point(12, 81)
        Me.gbmaintain.Name = "gbmaintain"
        Me.gbmaintain.Size = New System.Drawing.Size(200, 162)
        Me.gbmaintain.TabIndex = 1
        Me.gbmaintain.TabStop = False
        Me.gbmaintain.Text = "Mainatin Users"
        '
        'btnDBAdmin
        '
        Me.btnDBAdmin.Location = New System.Drawing.Point(6, 115)
        Me.btnDBAdmin.Name = "btnDBAdmin"
        Me.btnDBAdmin.Size = New System.Drawing.Size(110, 25)
        Me.btnDBAdmin.TabIndex = 2
        Me.btnDBAdmin.Text = "Manage User Roles"
        Me.btnDBAdmin.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(6, 74)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(110, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Users"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(6, 34)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(110, 23)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "Manage Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'bbTables
        '
        Me.bbTables.Controls.Add(Me.btnDropTable)
        Me.bbTables.Controls.Add(Me.btnCreateUsersTable)
        Me.bbTables.Location = New System.Drawing.Point(528, 81)
        Me.bbTables.Name = "bbTables"
        Me.bbTables.Size = New System.Drawing.Size(200, 162)
        Me.bbTables.TabIndex = 2
        Me.bbTables.TabStop = False
        Me.bbTables.Text = "Maintain Tables"
        '
        'btnDropTable
        '
        Me.btnDropTable.Location = New System.Drawing.Point(0, 117)
        Me.btnDropTable.Name = "btnDropTable"
        Me.btnDropTable.Size = New System.Drawing.Size(122, 23)
        Me.btnDropTable.TabIndex = 1
        Me.btnDropTable.Text = "Drop Users Table"
        Me.btnDropTable.UseVisualStyleBackColor = True
        '
        'btnCreateUsersTable
        '
        Me.btnCreateUsersTable.Location = New System.Drawing.Point(0, 34)
        Me.btnCreateUsersTable.Name = "btnCreateUsersTable"
        Me.btnCreateUsersTable.Size = New System.Drawing.Size(122, 23)
        Me.btnCreateUsersTable.TabIndex = 0
        Me.btnCreateUsersTable.Text = "Create Users Table"
        Me.btnCreateUsersTable.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(64, 333)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 38)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(249, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.bbTables)
        Me.Controls.Add(Me.gbmaintain)
        Me.Controls.Add(Me.lblselect)
        Me.Name = "MenuForm"
        Me.Text = "Application to Manage Database"
        Me.gbmaintain.ResumeLayout(False)
        Me.bbTables.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblselect As Label
    Friend WithEvents gbmaintain As GroupBox
    Friend WithEvents btnDBAdmin As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents bbTables As GroupBox
    Friend WithEvents btnDropTable As Button
    Friend WithEvents btnCreateUsersTable As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnExit As Button
End Class
