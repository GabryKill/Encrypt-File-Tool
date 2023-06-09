<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncryptFileTool
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ProgressByte = New TextBox()
        FileName = New TextBox()
        DecryptBtn = New Button()
        EncryptBtn = New Button()
        ProgressBar = New ProgressBar()
        EncryptWorker = New ComponentModel.BackgroundWorker()
        PrintDocument1 = New Printing.PrintDocument()
        DecryptWorker = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' ProgressByte
        ' 
        ProgressByte.Location = New Point(301, 12)
        ProgressByte.Name = "ProgressByte"
        ProgressByte.ReadOnly = True
        ProgressByte.Size = New Size(100, 23)
        ProgressByte.TabIndex = 0
        ProgressByte.TabStop = False
        ' 
        ' FileName
        ' 
        FileName.Location = New Point(12, 12)
        FileName.Name = "FileName"
        FileName.ReadOnly = True
        FileName.Size = New Size(283, 23)
        FileName.TabIndex = 0
        FileName.TabStop = False
        ' 
        ' DecryptBtn
        ' 
        DecryptBtn.Location = New Point(496, 12)
        DecryptBtn.Name = "DecryptBtn"
        DecryptBtn.Size = New Size(83, 23)
        DecryptBtn.TabIndex = 0
        DecryptBtn.TabStop = False
        DecryptBtn.Text = "Decrypt"
        DecryptBtn.UseVisualStyleBackColor = True
        ' 
        ' EncryptBtn
        ' 
        EncryptBtn.Location = New Point(407, 12)
        EncryptBtn.Name = "EncryptBtn"
        EncryptBtn.Size = New Size(83, 23)
        EncryptBtn.TabIndex = 0
        EncryptBtn.TabStop = False
        EncryptBtn.Text = "Encrypt"
        EncryptBtn.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(12, 41)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(567, 23)
        ProgressBar.TabIndex = 0
        ' 
        ' EncryptWorker
        ' 
        EncryptWorker.WorkerSupportsCancellation = True
        ' 
        ' DecryptWorker
        ' 
        ' 
        ' EncryptFileTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(595, 82)
        Controls.Add(ProgressByte)
        Controls.Add(FileName)
        Controls.Add(DecryptBtn)
        Controls.Add(EncryptBtn)
        Controls.Add(ProgressBar)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "EncryptFileTool"
        Text = "Encrypt File Tool"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressByte As TextBox
    Friend WithEvents FileName As TextBox
    Friend WithEvents DecryptBtn As Button
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents EncryptWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DecryptWorker As System.ComponentModel.BackgroundWorker
End Class
