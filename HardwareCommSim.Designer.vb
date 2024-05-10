<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HardwareCommSim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtInput = New TextBox()
        txtHeader = New TextBox()
        txtLength = New TextBox()
        txtData = New TextBox()
        txtFormat = New TextBox()
        txtTrailer = New TextBox()
        txtCRC = New TextBox()
        lblHeader = New Label()
        lblLength = New Label()
        lblFormat = New Label()
        lblData = New Label()
        lblTrailer = New Label()
        lblCRC = New Label()
        btnProcess = New Button()
        btnEnd = New Button()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(84, 12)
        txtInput.Name = "txtInput"
        txtInput.PlaceholderText = "copy and paste input string here"
        txtInput.Size = New Size(500, 23)
        txtInput.TabIndex = 0
        ' 
        ' txtHeader
        ' 
        txtHeader.Location = New Point(84, 53)
        txtHeader.Name = "txtHeader"
        txtHeader.Size = New Size(500, 23)
        txtHeader.TabIndex = 1
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(84, 79)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(500, 23)
        txtLength.TabIndex = 2
        ' 
        ' txtData
        ' 
        txtData.Location = New Point(84, 118)
        txtData.Name = "txtData"
        txtData.Size = New Size(500, 23)
        txtData.TabIndex = 3
        ' 
        ' txtFormat
        ' 
        txtFormat.Location = New Point(84, 144)
        txtFormat.Name = "txtFormat"
        txtFormat.Size = New Size(500, 23)
        txtFormat.TabIndex = 4
        ' 
        ' txtTrailer
        ' 
        txtTrailer.Location = New Point(84, 182)
        txtTrailer.Name = "txtTrailer"
        txtTrailer.Size = New Size(500, 23)
        txtTrailer.TabIndex = 5
        ' 
        ' txtCRC
        ' 
        txtCRC.Location = New Point(84, 208)
        txtCRC.Name = "txtCRC"
        txtCRC.Size = New Size(500, 23)
        txtCRC.TabIndex = 6
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Location = New Point(36, 57)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(45, 15)
        lblHeader.TabIndex = 7
        lblHeader.Text = "Header"
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Location = New Point(12, 83)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(71, 15)
        lblLength.TabIndex = 8
        lblLength.Text = "Data Length"
        ' 
        ' lblFormat
        ' 
        lblFormat.AutoSize = True
        lblFormat.Location = New Point(7, 148)
        lblFormat.Name = "lblFormat"
        lblFormat.Size = New Size(76, 15)
        lblFormat.TabIndex = 9
        lblFormat.Text = "Format Code"
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Location = New Point(50, 122)
        lblData.Name = "lblData"
        lblData.Size = New Size(31, 15)
        lblData.TabIndex = 9
        lblData.Text = "Data"
        ' 
        ' lblTrailer
        ' 
        lblTrailer.AutoSize = True
        lblTrailer.Location = New Point(43, 186)
        lblTrailer.Name = "lblTrailer"
        lblTrailer.Size = New Size(38, 15)
        lblTrailer.TabIndex = 10
        lblTrailer.Text = "Trailer"
        ' 
        ' lblCRC
        ' 
        lblCRC.AutoSize = True
        lblCRC.Location = New Point(51, 212)
        lblCRC.Name = "lblCRC"
        lblCRC.Size = New Size(30, 15)
        lblCRC.TabIndex = 11
        lblCRC.Text = "CRC"
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(176, 259)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(75, 23)
        btnProcess.TabIndex = 12
        btnProcess.Text = "&Process"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' btnEnd
        ' 
        btnEnd.Location = New Point(326, 259)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(75, 23)
        btnEnd.TabIndex = 13
        btnEnd.Text = "&End"
        btnEnd.UseVisualStyleBackColor = True
        ' 
        ' HardwareCommSim
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 301)
        Controls.Add(btnEnd)
        Controls.Add(btnProcess)
        Controls.Add(lblCRC)
        Controls.Add(lblTrailer)
        Controls.Add(lblData)
        Controls.Add(lblFormat)
        Controls.Add(lblLength)
        Controls.Add(lblHeader)
        Controls.Add(txtCRC)
        Controls.Add(txtTrailer)
        Controls.Add(txtFormat)
        Controls.Add(txtData)
        Controls.Add(txtLength)
        Controls.Add(txtHeader)
        Controls.Add(txtInput)
        Name = "HardwareCommSim"
        Text = "Hardware Communications Simulator"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents txtTrailer As TextBox
    Friend WithEvents txtCRC As TextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblFormat As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblTrailer As Label
    Friend WithEvents lblCRC As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnEnd As Button
End Class
