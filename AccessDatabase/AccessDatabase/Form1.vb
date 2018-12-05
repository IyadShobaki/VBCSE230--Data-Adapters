Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Private ds As DataSet = New DataSet
    Private conn As OleDbConnection = New OleDbConnection(getConnection())
    Private sql As String = "Select * from customers"
    Private da As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
    Private cmds As New OleDbCommandBuilder(da)
    Private Function getConnection() As String
        Dim connStr = My.Settings.NorthwindConnectionString
        Return connStr
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da.Fill(ds, "Customers")
        Grid1.DataSource = ds
        Grid1.DataMember = "Customers"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ds.EndInit()
        da.Update(ds.Tables("customers"))
    End Sub
End Class
