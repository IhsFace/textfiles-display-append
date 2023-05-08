Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim itemName As String
        Dim Price As Double
        Dim NoInStock As Integer
        Dim InventoryFile As StreamReader = File.OpenText("Inventory.txt")
        lstDisplay.Items.Clear()
        Do While InventoryFile.Peek <> -1
            itemName = InventoryFile.ReadLine()
            Price = InventoryFile.ReadLine()
            NoInStock = InventoryFile.ReadLine()
            lstDisplay.Items.Add(itemName & " $" & Price & " " & NoInStock & " in stock")
        Loop
        InventoryFile.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim InventoryFile As StreamWriter = File.AppendText("Inventory.txt")
        Dim itemName As String = InputBox("Enter the item name to add", "Add Item Name")
        InventoryFile.WriteLine(itemName)
        Dim Price As Double = InputBox("Enter the price of the item to add", "Add Item Price")
        InventoryFile.WriteLine(Price)
        Dim NoInStock As Integer = InputBox("Enter the number in stock of the item to add", "Add Item Stock")
        InventoryFile.WriteLine(NoInStock)
        MessageBox.Show("The item name, price, and number in stock have been added to the textfile.")
        InventoryFile.Close()
    End Sub

    Private Sub btnLowStock_Click(sender As Object, e As EventArgs) Handles btnLowStock.Click
        Dim itemName As String
        Dim Price As Double
        Dim NoInStock As Integer
        Dim InventoryFile As StreamReader = File.OpenText("Inventory.txt")
        lstDisplay.Items.Clear()
        Do While InventoryFile.Peek <> -1
            itemName = InventoryFile.ReadLine()
            Price = InventoryFile.ReadLine()
            NoInStock = InventoryFile.ReadLine()
            If NoInStock < 5 Then
                lstDisplay.Items.Add(itemName & " $" & Price & " " & NoInStock & " in stock")
            End If
        Loop
        InventoryFile.Close()
    End Sub
End Class
