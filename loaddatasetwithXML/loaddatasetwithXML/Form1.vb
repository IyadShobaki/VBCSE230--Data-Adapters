Imports System.Data
Public Class Form1
    Private dsNorthwind As New DataSet("Northwind")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoadSchema_Click(sender As Object, e As EventArgs) Handles btnLoadSchema.Click
        dsNorthwind.ReadXmlSchema("D:\XMLFiles\Northwind.xsd")
        dgvCustomers.DataSource = dsNorthwind.Tables("Customers")
        dgvOrders.DataSource = dsNorthwind.Tables("Orders")
    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        dsNorthwind.ReadXml("D:\XMLFiles\Northwind.xml")
    End Sub
End Class
