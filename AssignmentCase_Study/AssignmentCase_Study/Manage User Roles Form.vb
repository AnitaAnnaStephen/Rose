Imports System.Data
Imports System.Data.SqlClient
Class Manage_User_Roles_Form

    Dim strConn As String =
        Configuration.ConfigurationManager.ConnectionStrings("dBase").ConnectionString

    Private sqlCon As SqlConnection
    Dim selectedUserID As Integer = 0
    Dim selectedUserName As String = ""
    Dim storedUserID As Integer = 0
    Dim storedUserName As String = ""
    Dim storedRoleDesc As String = ""
    Dim storedRoleID As Integer = 0
    Dim selectedRoleID As Integer = 0
    Dim selectedRoleDesc As String = ""


    Private Sub DbRolesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlCon = New SqlConnection(strConn)

        Dim sql As String = "SELECT UserID, UserName FROM vwUserInfo ORDER BY UserName"
        Dim sqlRole As String = "SELECT RoleID, RoleDesc FROM tblRoles"

        Dim command As New SqlCommand(sql, sqlCon)
        Dim da As New SqlDataAdapter(command)
        Dim tbl As New DataTable()
        da.Fill(tbl)
        cboUsers.DisplayMember = "UserName"
        cboUsers.ValueMember = "userID"
        cboUsers.DataSource = tbl

        Dim command2 As New SqlCommand(sqlRole, sqlCon)
        Dim da2 As New SqlDataAdapter(command2)
        Dim tbl2 As New DataTable()
        da2.Fill(tbl2)
        cboRole.DisplayMember = "RoleDesc"
        cboRole.ValueMember = "roleID"
        cboRole.DataSource = tbl2


        sqlCon.Close()

    End Sub

    Private Sub cboUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsers.SelectedIndexChanged


        selectedUserID = cboUsers.SelectedIndex + 1
        selectedUserName = cboUsers.Text
        storedUserID = selectedUserID
        storedUserName = selectedUserName
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged

        selectedRoleID = cboRole.SelectedIndex + 1
        selectedRoleDesc = cboRole.Text
        storedRoleID = selectedRoleID
        storedRoleDesc = selectedRoleDesc
    End Sub

    Private Sub btnShowRole_Click(sender As Object, e As EventArgs) Handles btnShowRole.Click

        MessageBox.Show("Role Id = " & storedRoleID & vbNewLine & "Role Desc : " & storedRoleDesc)
    End Sub

    Private Sub btnInsertUserRole_Click(sender As Object, e As EventArgs) Handles btnInsertUserRole.Click

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand()
            Dim msg As String = "EXEC sp_addrolemember '" & storedRoleDesc & "','" & storedUserName & "'"

            MessageBox.Show(msg)
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspInsertUserRoles"


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

    End Sub
End Class