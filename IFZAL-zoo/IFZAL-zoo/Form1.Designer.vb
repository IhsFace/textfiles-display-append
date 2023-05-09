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
        btnAdd = New Button()
        btnListBlack = New Button()
        btnTotal = New Button()
        Label2 = New Label()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(150, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 26)
        Label1.TabIndex = 0
        Label1.Text = "MAC'S MAGNIFICENT ZOO"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnDisplay.Location = New Point(75, 75)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(200, 35)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display All"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(300, 75)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(200, 35)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Animal"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnListBlack
        ' 
        btnListBlack.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnListBlack.Location = New Point(75, 125)
        btnListBlack.Name = "btnListBlack"
        btnListBlack.Size = New Size(200, 35)
        btnListBlack.TabIndex = 3
        btnListBlack.Text = "List all Black Animals"
        btnListBlack.UseVisualStyleBackColor = True
        ' 
        ' btnTotal
        ' 
        btnTotal.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnTotal.Location = New Point(300, 125)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(200, 35)
        btnTotal.TabIndex = 4
        btnTotal.Text = "Total No. Animals"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(75, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 24)
        Label2.TabIndex = 5
        Label2.Text = "DISPLAY"
        ' 
        ' lstDisplay
        ' 
        lstDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 24
        lstDisplay.Location = New Point(75, 225)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(425, 124)
        lstDisplay.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(lstDisplay)
        Controls.Add(Label2)
        Controls.Add(btnTotal)
        Controls.Add(btnListBlack)
        Controls.Add(btnAdd)
        Controls.Add(btnDisplay)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "MAC'S MAGNIFICENT ZOO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnListBlack As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstDisplay As ListBox
End Class
