Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim name As String
        Dim items As String
        Dim ClientsFile As StreamReader = File.OpenText("Clients.txt")
        lstData.Items.Clear()
        Do While ClientsFile.Peek <> -1
            name = ClientsFile.ReadLine()
            items = ClientsFile.ReadLine()
            lstData.Items.Add(name & " " & items)
        Loop
        ClientsFile.Close()
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim ClientsFile As StreamWriter = File.AppendText("Clients.txt")
        Dim name As String = InputBox("Enter the name to add", "Add Name")
        ClientsFile.WriteLine(name)
        Dim items As Integer = InputBox("Enter the number of items to add", "Add Items")
        ClientsFile.WriteLine(items)
        MessageBox.Show("The name and number of items have been added to the textfile.")
        ClientsFile.Close()
    End Sub
End Class
