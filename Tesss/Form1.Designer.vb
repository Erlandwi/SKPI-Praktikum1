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
        btjumlah = New Button()
        btkurang = New Button()
        btbagi = New Button()
        btkali = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Txtangka1 = New TextBox()
        Txtangka2 = New TextBox()
        Txthasil = New TextBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        SuspendLayout()
        ' 
        ' btjumlah
        ' 
        btjumlah.Location = New Point(104, 185)
        btjumlah.Name = "btjumlah"
        btjumlah.Size = New Size(43, 23)
        btjumlah.TabIndex = 0
        btjumlah.Text = "+"
        btjumlah.UseVisualStyleBackColor = True
        ' 
        ' btkurang
        ' 
        btkurang.Location = New Point(153, 185)
        btkurang.Name = "btkurang"
        btkurang.Size = New Size(43, 23)
        btkurang.TabIndex = 1
        btkurang.Text = "-"
        btkurang.UseVisualStyleBackColor = True
        ' 
        ' btbagi
        ' 
        btbagi.Location = New Point(229, 185)
        btbagi.Name = "btbagi"
        btbagi.Size = New Size(41, 23)
        btbagi.TabIndex = 2
        btbagi.Text = "/"
        btbagi.UseVisualStyleBackColor = True
        ' 
        ' btkali
        ' 
        btkali.Location = New Point(288, 185)
        btkali.Name = "btkali"
        btkali.Size = New Size(41, 23)
        btkali.TabIndex = 3
        btkali.Text = "*"
        btkali.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 4
        Label1.Text = "Angka Pertama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 5
        Label2.Text = "Angka Kedua"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 6
        Label3.Text = "Hasil"
        ' 
        ' Txtangka1
        ' 
        Txtangka1.Location = New Point(229, 93)
        Txtangka1.Name = "Txtangka1"
        Txtangka1.Size = New Size(100, 23)
        Txtangka1.TabIndex = 7
        ' 
        ' Txtangka2
        ' 
        Txtangka2.Location = New Point(229, 133)
        Txtangka2.Name = "Txtangka2"
        Txtangka2.Size = New Size(100, 23)
        Txtangka2.TabIndex = 8
        ' 
        ' Txthasil
        ' 
        Txthasil.Location = New Point(229, 278)
        Txthasil.Name = "Txthasil"
        Txthasil.Size = New Size(100, 23)
        Txthasil.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Txthasil)
        Controls.Add(Txtangka2)
        Controls.Add(Txtangka1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btkali)
        Controls.Add(btbagi)
        Controls.Add(btkurang)
        Controls.Add(btjumlah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btjumlah As Button
    Friend WithEvents btkurang As Button
    Friend WithEvents btbagi As Button
    Friend WithEvents btkali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtangka1 As TextBox
    Friend WithEvents Txtangka2 As TextBox
    Friend WithEvents Txthasil As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog

End Class
