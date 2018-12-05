Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private conn As New SqlConnection(getConnectionString())
    Private da As New SqlDataAdapter("Select * from Customers", conn)
    Private ds As New DataSet("Northwind")
    Private dt As New DataTable("Customers")
    Private Function getConnectionString() As String
        Return My.Settings.NorthwindConnectionString
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Tables.Add(dt)
        da.Fill(ds.Tables("Customers"))
        Grid1.DataSource = ds.Tables("Customers")
        Dim commands As New SqlCommandBuilder(da)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ds.EndInit()
        da.Update(ds.Tables("Customers"))
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim dv As New DataView(ds.Tables(0))
        Grid1.DataSource = dv
        dv.Sort = "contactname"
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim dv As New DataView(ds.Tables(0))
        dv.RowFilter = "ContactName like '%" & TextBox1.Text & "%'"
        Grid1.DataSource = dv
    End Sub
End Class
