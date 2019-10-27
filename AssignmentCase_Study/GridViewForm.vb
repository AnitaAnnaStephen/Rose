Imports System.Data.SqlClient
Public Class GridViewForm

    Dim strConn As String =
    Configuration.ConfigurationManager.ConnectionStrings("dBase").ConnectionString


    Private sqlCon As SqlConnection

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub GridViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim sql As String = "SELECT * FROM tblUsers"
        Dim connection As New SqlConnection(strConn)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Users Table")
        connection.close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Users Table"

    End Sub

End Class