Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Animal As String
        Dim NoStock As Integer
        Dim Colour As String
        Dim ZooInventoryFile As StreamReader = File.OpenText("ZooInventory.txt")
        lstDisplay.Items.Clear()
        Do While ZooInventoryFile.Peek <> -1
            Animal = ZooInventoryFile.ReadLine()
            NoStock = ZooInventoryFile.ReadLine()
            Colour = ZooInventoryFile.ReadLine()
            lstDisplay.Items.Add(Colour & " " & Animal & " " & NoStock & " in stock")
        Loop
        ZooInventoryFile.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ZooInventoryFile As StreamWriter = File.AppendText("ZooInventory.txt")
        Dim Animal As String = InputBox("Enter the animal name to add", "Add Animal Name")
        ZooInventoryFile.WriteLine(Animal)
        Dim NoStock As Integer = InputBox("Enter the number in stock of the animal to add", "Add Animal Stock")
        ZooInventoryFile.WriteLine(NoStock)
        Dim Colour As String = InputBox("Enter the colour of the animal to add", "Add Animal Colour")
        ZooInventoryFile.WriteLine(Colour)
        MessageBox.Show("The animal name, stock, and colour have been added to the textfile.")
        ZooInventoryFile.Close()
    End Sub

    Private Sub btnListBlack_Click(sender As Object, e As EventArgs) Handles btnListBlack.Click
        Dim Animal As String
        Dim NoStock As Integer
        Dim Colour As String
        Dim ZooInventoryFile As StreamReader = File.OpenText("ZooInventory.txt")
        lstDisplay.Items.Clear()
        Do While ZooInventoryFile.Peek <> -1
            Animal = ZooInventoryFile.ReadLine()
            NoStock = ZooInventoryFile.ReadLine()
            Colour = ZooInventoryFile.ReadLine()
            If Colour = "Black" Then
                lstDisplay.Items.Add(Colour & " " & Animal & " " & NoStock & " in stock")
            End If
        Loop
        ZooInventoryFile.Close()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim Animal As String
        Dim NoStock As Integer
        Dim Colour As String
        Dim Total As Integer
        Dim ZooInventoryFile As StreamReader = File.OpenText("ZooInventory.txt")
        lstDisplay.Items.Clear()
        Do While ZooInventoryFile.Peek <> -1
            Animal = ZooInventoryFile.ReadLine()
            NoStock = ZooInventoryFile.ReadLine()
            Colour = ZooInventoryFile.ReadLine()
            Total = NoStock + Total
        Loop
        lstDisplay.Items.Add(Total & " in stock")
        ZooInventoryFile.Close()
    End Sub
End Class
