Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim SacScoresFile As StreamReader = File.OpenText("SacScores.txt")
        lstData.Items.Clear()
        Do While SacScoresFile.Peek <> -1
            lstData.Items.Add(SacScoresFile.ReadLine())
        Loop
        SacScoresFile.Close()
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim SacScoresFile As StreamWriter = File.AppendText("SacScores.txt")
        Dim SACScore As String = InputBox("Please enter a SAC Score between 0 and 100 inclusive.", "Enter Score")
        If Val(SACScore) >= 0 And Val(SACScore) <= 100 Then
            SacScoresFile.WriteLine(SACScore)
            MessageBox.Show("Your score has been appended to the textfile.")
        Else
            MessageBox.Show("Your score has not been appended to the textfile. Please enter a SAC Score between 0 and 100 inclusive.")
        End If
        SacScoresFile.Close()
    End Sub

    Private Sub btnAverageSacScore_Click(sender As Object, e As EventArgs) Handles btnAverageSacScore.Click
        Dim SACScore As Integer
        Dim TotalScore As Integer
        Dim AvgSacScore As Double
        Dim NoOfScores As Integer
        Dim SacScoresFile As StreamReader = File.OpenText("SacScores.txt")
        lstData.Items.Clear()
        Do While SacScoresFile.Peek <> -1
            SACScore = Val(SacScoresFile.ReadLine())
            TotalScore = TotalScore + SACScore
            NoOfScores = NoOfScores + 1
        Loop
        AvgSacScore = TotalScore / NoOfScores
        lstData.Items.Add("Average SAC Score: " & AvgSacScore)
        SacScoresFile.Close()
    End Sub

    Private Sub btnHighestSacScore_Click(sender As Object, e As EventArgs) Handles btnHighestSacScore.Click
        Dim SACScore As Integer
        Dim HighestSacScore As Integer = Integer.MinValue
        Dim SacScoresFile As StreamReader = File.OpenText("SacScores.txt")
        lstData.Items.Clear()
        Do While SacScoresFile.Peek <> -1
            SACScore = Val(SacScoresFile.ReadLine())
            If SACScore > HighestSacScore Then HighestSacScore = SACScore
        Loop
        lstData.Items.Add("Highest SAC Score: " & HighestSacScore)
        SacScoresFile.Close()
    End Sub

    Private Sub btnLowestSacScore_Click(sender As Object, e As EventArgs) Handles btnLowestSacScore.Click
        Dim SACScore As Integer
        Dim LowestSacScore As Integer = Integer.MaxValue
        Dim SacScoresFile As StreamReader = File.OpenText("SacScores.txt")
        lstData.Items.Clear()
        Do While SacScoresFile.Peek <> -1
            SACScore = Val(SacScoresFile.ReadLine())
            If SACScore < LowestSacScore Then LowestSacScore = SACScore
        Loop
        lstData.Items.Add("Lowest SAC Score: " & LowestSacScore)
        SacScoresFile.Close()
    End Sub
End Class
