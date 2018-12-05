Public Class Form1
    Private Sub btnFilldataset_Click(sender As Object, e As EventArgs) Handles btnFilldataset.Click
        daCustomers.Fill(DsNorthwind1.Customers)
        daOrders.Fill(DsNorthwind1.Orders)
        DataGridView1.DataSource = DsNorthwind1.Customers
    End Sub

    Private Sub btnSaveXML_Click(sender As Object, e As EventArgs) Handles btnSaveXML.Click
        Try
            DsNorthwind1.WriteXml("Northwind.xml")
            MessageBox.Show("Data saved as Northwind.xml")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveXMLSchema_Click(sender As Object, e As EventArgs) Handles btnSaveXMLSchema.Click
        Try
            DsNorthwind1.WriteXmlSchema("Northwind.xsd")
            MessageBox.Show("Data saved as Northwind.xsd")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
