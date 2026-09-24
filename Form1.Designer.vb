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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.solidarity_without_rainbow
        PictureBox1.Location = New Point(255, 160)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(371, 257)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkBlue
        Button1.Location = New Point(181, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 82)
        Button1.TabIndex = 1
        Button1.Text = "Inscrire un nouveau necessiteux"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button2.ForeColor = Color.DarkBlue
        Button2.Location = New Point(371, 444)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 82)
        Button2.TabIndex = 2
        Button2.Text = "Consulter les fichiers de chaque necessiteux"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkBlue
        Button3.Location = New Point(570, 444)
        Button3.Name = "Button3"
        Button3.Size = New Size(193, 82)
        Button3.TabIndex = 3
        Button3.Text = "Consulter les fichiers des responsables"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(191, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 41)
        Label1.TabIndex = 4
        Label1.Text = "Bienvenue dans notre association"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AZ
        PictureBox2.Location = New Point(750, 43)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = Color.DarkBlue
        Button4.Location = New Point(181, 543)
        Button4.Name = "Button4"
        Button4.Size = New Size(184, 82)
        Button4.TabIndex = 6
        Button4.Text = "Consulter les fichiers des participants"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.DarkBlue
        Button5.Location = New Point(371, 543)
        Button5.Name = "Button5"
        Button5.Size = New Size(193, 82)
        Button5.TabIndex = 7
        Button5.Text = "Consulter les fichiers des donnateurs"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkBlue
        Button6.Location = New Point(570, 543)
        Button6.Name = "Button6"
        Button6.Size = New Size(193, 82)
        Button6.TabIndex = 8
        Button6.Text = "Consulter la gestion comptable"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(917, 635)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Page d'acceuil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
