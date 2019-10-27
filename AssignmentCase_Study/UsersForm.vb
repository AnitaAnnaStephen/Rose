Imports System.Data.SqlClient 'Import SQL Capabilities

Public Class UsersForm


    Dim strConn As String =
    Configuration.ConfigurationManager.ConnectionStrings("dBase").ConnectionString

    Dim strConnMaster As String =
    Configuration.ConfigurationManager.ConnectionStrings("dbMaster").ConnectionString


    Private sqlCon As SqlConnection


    Private Sub LoadData()
        Dim strQuery As String
        strQuery = "SELECT * FROM tblUsers"
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()



            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    txtFirstName.Text = sqlReader.GetString(1)
                    txtSurname.Text = sqlReader.GetString(2)
                    txtAge.Text = sqlReader.GetValue(3)
                    txtUserName.Text = sqlReader.GetString(4)
                    txtPassword.Text = sqlReader.GetString(5)
                End While
            End If

            sqlReader.Close()
        End Using
    End Sub



    Private Sub InsertNewRecord()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()


            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspInsertUserData"
            sqlComm.CommandType = CommandType.StoredProcedure


            sqlComm.Parameters.AddWithValue("FirstName", txtFirstName.Text)
            sqlComm.Parameters.AddWithValue("LastName", txtSurname.Text)
            sqlComm.Parameters.AddWithValue("Age", txtAge.Text)
            sqlComm.Parameters.AddWithValue("UserName", txtUserName.Text)
            sqlComm.Parameters.AddWithValue("Password", txtPassword.Text)
            sqlCon.Open()



            Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
            MessageBox.Show(rowsAffected)
            If rowsAffected > 0 Then
                MessageBox.Show("Record has been inserted successfully")
            End If
        End Using


        LoadData()

    End Sub



    Private Sub UpdateRecord()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()


            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspUpdateUserData"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("UserID", txtSearch.Text)
            sqlComm.Parameters.AddWithValue("FirstName", txtFirstName.Text)
            sqlComm.Parameters.AddWithValue("LastName", txtSurname.Text)
            sqlComm.Parameters.AddWithValue("Age", Integer.Parse(txtAge.Text))
            sqlComm.Parameters.AddWithValue("UserName", txtUserName.Text)
            sqlComm.Parameters.AddWithValue("Password", txtPassword.Text)
            sqlCon.Open()



            Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
            MessageBox.Show(rowsAffected)
            If rowsAffected > 0 Then
                MessageBox.Show("Record has been updated successfully")
            End If
        End Using


        LoadData()

    End Sub


    Private Sub DeleteRecord()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()


            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspDeleteUserData"
            sqlComm.CommandType = CommandType.StoredProcedure


            sqlComm.Parameters.AddWithValue("UserID", Integer.Parse(txtSearch.Text))

            sqlCon.Open()

            sqlComm.ExecuteNonQuery()
        End Using
        LoadData()
    End Sub



    Private Sub AddLogin()
        sqlCon = New SqlConnection(strConnMaster)
        Dim username As String = ""
        Dim password As String = ""
        username = txtUserName.Text
        password = txtPassword.Text
        Dim msg As String = ""

        msg = "CREATE LOGIN " & username & " WITH PASSWORD = " & "'" & password & "'" & vbNewLine & "CREATE USER " & username & " FROM LOGIN " & username
        MessageBox.Show(msg)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "CREATE LOGIN " & username & " WITH PASSWORD = " &
            "'" & password & "'"
            sqlComm.CommandType = CommandType.Text
            sqlCon.Open()


            Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
            MessageBox.Show(rowsAffected)
            If rowsAffected > 0 Then
                MessageBox.Show("Login has been created successfully")
            End If
            sqlCon.Close()
        End Using


        LoadData()

    End Sub


    Private Sub AddUser()
        sqlCon = New SqlConnection(strConn)
        Dim username As String = ""
        username = txtUserName.Text

        Dim msg As String = ""
        msg = "CREATE USER " & username & " FROM LOGIN " & username
        MessageBox.Show(msg)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "CREATE USER " & username & " FROM LOGIN " & username

            sqlComm.CommandType = CommandType.Text
            sqlCon.Open()


            Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
            MessageBox.Show(rowsAffected)
            If rowsAffected > 0 Then
                MessageBox.Show("User has been created successfully")
            End If
            sqlCon.Close()
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "SELECT * FROM tblUsers WHERE UserID = " & Integer.Parse(txtSearch.Text)
            sqlComm.CommandType = CommandType.Text

            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()



            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    txtFirstName.Text = sqlReader.GetString(1)
                    txtSurname.Text = sqlReader.GetString(2)
                    txtAge.Text = sqlReader.GetValue(3)
                    txtUserName.Text = sqlReader.GetString(4)
                    txtPassword.Text = sqlReader.GetString(5)
                End While
            End If

            sqlReader.Close()
        End Using

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        InsertNewRecord()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MenuForm.Show()
        Me.Hide()
    End Sub
End Class