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
        lblTitle = New Label()
        btnDisplay = New Button()
        btnAppend = New Button()
        btnReadUnknownLengthFile = New Button()
        lstData = New ListBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(45, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(501, 26)
        lblTitle.TabIndex = 0
        lblTitle.Text = "A demonstration of reading and writing to a Textfile"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnDisplay.Location = New Point(35, 100)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(240, 50)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display Contents of textfile"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAppend
        ' 
        btnAppend.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppend.Location = New Point(35, 175)
        btnAppend.Name = "btnAppend"
        btnAppend.Size = New Size(240, 50)
        btnAppend.TabIndex = 2
        btnAppend.Text = "Append data to textfile"
        btnAppend.UseVisualStyleBackColor = True
        ' 
        ' btnReadUnknownLengthFile
        ' 
        btnReadUnknownLengthFile.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnReadUnknownLengthFile.Location = New Point(35, 250)
        btnReadUnknownLengthFile.Name = "btnReadUnknownLengthFile"
        btnReadUnknownLengthFile.Size = New Size(240, 65)
        btnReadUnknownLengthFile.TabIndex = 3
        btnReadUnknownLengthFile.Text = "Read a file of unknown length"
        btnReadUnknownLengthFile.UseVisualStyleBackColor = True
        ' 
        ' lstData
        ' 
        lstData.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lstData.FormattingEnabled = True
        lstData.ItemHeight = 24
        lstData.Location = New Point(330, 100)
        lstData.Name = "lstData"
        lstData.Size = New Size(220, 220)
        lstData.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(lstData)
        Controls.Add(btnReadUnknownLengthFile)
        Controls.Add(btnAppend)
        Controls.Add(btnDisplay)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents btnReadUnknownLengthFile As Button
    Friend WithEvents lstData As ListBox
End Class
