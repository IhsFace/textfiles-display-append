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
        lstData = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(200, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 26)
        Label1.TabIndex = 0
        Label1.Text = "ITEMS STORE"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnDisplay.Location = New Point(50, 100)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(100, 35)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAppend
        ' 
        btnAppend.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppend.Location = New Point(50, 200)
        btnAppend.Name = "btnAppend"
        btnAppend.Size = New Size(100, 35)
        btnAppend.TabIndex = 2
        btnAppend.Text = "Append"
        btnAppend.UseVisualStyleBackColor = True
        ' 
        ' lstData
        ' 
        lstData.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lstData.FormattingEnabled = True
        lstData.ItemHeight = 24
        lstData.Location = New Point(200, 100)
        lstData.Name = "lstData"
        lstData.Size = New Size(350, 196)
        lstData.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(lstData)
        Controls.Add(btnAppend)
        Controls.Add(btnDisplay)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Items Store"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents lstData As ListBox
End Class
