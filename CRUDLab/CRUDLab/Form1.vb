Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private conn As New SqlConnection(getConnectionString())
    Private da As New SqlDataAdapter("Select * from stores", conn)
    Private ds As New DataSet("Stores")
    Private dt As New DataTable("stores")
    Private Function getConnectionString() As String
        Return My.Settings.Database1ConnectionString
    End Function
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ds.Tables.Add(dt)
        da.Fill(ds.Tables("stores"))
        DataGridView1.DataSource = ds.Tables("stores")
        Dim commands As New SqlCommandBuilder(da)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ds.EndInit()
            da.Update(ds.Tables("stores"))
            MessageBox.Show("Data updated.. !")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class
