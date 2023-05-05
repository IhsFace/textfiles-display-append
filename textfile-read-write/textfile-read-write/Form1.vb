Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim TestScores As Integer
        Dim names As String
        Dim ExampleFile As StreamReader = File.OpenText("TestScoresData.txt")
        lstData.Items.Clear()
        For i = 0 To 4
            names = ExampleFile.ReadLine()
            TestScores = ExampleFile.ReadLine()
            lstData.Items.Add(names & " " & TestScores)
        Next
        ExampleFile.Close()
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim ExampleFile As StreamWriter = File.AppendText("TestScoresData.txt")
        Dim Pname As String = InputBox("Enter the name to add", "Add Name")
        ExampleFile.WriteLine(Pname)
        Dim Pscore As Integer = InputBox("Enter the test score to add", "Add score")
        ExampleFile.WriteLine(Pscore)
        MessageBox.Show("The name and score has been added to the text file")
        ExampleFile.Close()
    End Sub

    Private Sub btnReadUnknownLengthFile_Click(sender As Object, e As EventArgs) Handles btnReadUnknownLengthFile.Click
        Dim NamesFile As StreamReader = File.OpenText("TestScoresData.txt")
        lstData.Items.Clear()
        Dim Pname, Pscore As String
        Do While NamesFile.Peek <> -1
            Pname = NamesFile.ReadLine()
            Pscore = NamesFile.ReadLine()
            lstData.Items.Add(Pname & " " & Pscore)
        Loop
        NamesFile.Close()
    End Sub
End Class
