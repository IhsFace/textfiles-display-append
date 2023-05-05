<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnDisplay = New Button()
        btnAppend = New Button()
        btnAverageSacScore = New Button()
        btnHighestSacScore = New Button()
        btnLowestSacScore = New Button()
        lstData = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(150, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 26)
        Label1.TabIndex = 0
        Label1.Text = "Append and Display Scores"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnDisplay.Location = New Point(325, 50)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(100, 50)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAppend
        ' 
        btnAppend.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppend.Location = New Point(450, 50)
        btnAppend.Name = "btnAppend"
        btnAppend.Size = New Size(100, 50)
        btnAppend.TabIndex = 2
        btnAppend.Text = "Append"
        btnAppend.UseVisualStyleBackColor = True
        ' 
        ' btnAverageSacScore
        ' 
        btnAverageSacScore.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAverageSacScore.Location = New Point(50, 50)
        btnAverageSacScore.Name = "btnAverageSacScore"
        btnAverageSacScore.Size = New Size(225, 75)
        btnAverageSacScore.TabIndex = 3
        btnAverageSacScore.Text = "Display the average SAC Score"
        btnAverageSacScore.UseVisualStyleBackColor = True
        ' 
        ' btnHighestSacScore
        ' 
        btnHighestSacScore.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnHighestSacScore.Location = New Point(50, 150)
        btnHighestSacScore.Name = "btnHighestSacScore"
        btnHighestSacScore.Size = New Size(225, 75)
        btnHighestSacScore.TabIndex = 4
        btnHighestSacScore.Text = "Display the highest SAC Score"
        btnHighestSacScore.UseVisualStyleBackColor = True
        ' 
        ' btnLowestSacScore
        ' 
        btnLowestSacScore.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnLowestSacScore.Location = New Point(50, 250)
        btnLowestSacScore.Name = "btnLowestSacScore"
        btnLowestSacScore.Size = New Size(225, 75)
        btnLowestSacScore.TabIndex = 5
        btnLowestSacScore.Text = "Display the lowest SAC Score"
        btnLowestSacScore.UseVisualStyleBackColor = True
        ' 
        ' lstData
        ' 
        lstData.FormattingEnabled = True
        lstData.ItemHeight = 15
        lstData.Location = New Point(300, 125)
        lstData.Name = "lstData"
        lstData.Size = New Size(250, 199)
        lstData.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(lstData)
        Controls.Add(btnLowestSacScore)
        Controls.Add(btnHighestSacScore)
        Controls.Add(btnAverageSacScore)
        Controls.Add(btnAppend)
        Controls.Add(btnDisplay)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SAC SCORES"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents btnAverageSacScore As Button
    Friend WithEvents btnHighestSacScore As Button
    Friend WithEvents btnLowestSacScore As Button
    Friend WithEvents lstData As ListBox
End Class
