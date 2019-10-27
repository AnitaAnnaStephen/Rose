Imports System.Data.SqlClient 'Import SQL Capabilities

Public Class MenuForm
    Dim strConn As String = Configuration.ConfigurationManager.ConnectionStrings("dBase").ConnectionString

    Private sqlCon As SqlConnection

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        sqlCon = New SqlConnection(strConn)

        sqlCon.Open()
        MessageBox.Show("Connection Successful", "Connection Status",
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        sqlCon.Close()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        UsersForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        GridViewForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub CreateTable()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspCreateUsersTable"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub DropTable()
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspDropUsersTable"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnCreateUsersTable_Click(sender As Object, e As EventArgs) Handles btnCreateUsersTable.Click
        CreateTable()
    End Sub

    Private Sub btnDropTable_Click(sender As Object, e As EventArgs) Handles btnDropTable.Click
        DropTable()
    End Sub


    Private Sub btnDBAdmin_Click(sender As Object, e As EventArgs) Handles btnDBAdmin.Click
        Manage_User_Roles_Form.Show()
        Me.Hide()
    End Sub


End Class

