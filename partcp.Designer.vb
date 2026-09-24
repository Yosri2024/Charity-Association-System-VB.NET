<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class partcp
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
        Button6 = New Button()
        Button3 = New Button()
        TextBox3 = New TextBox()
        Label6 = New Label()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkOrchid
        Button6.Location = New Point(575, 453)
        Button6.Name = "Button6"
        Button6.Size = New Size(150, 58)
        Button6.TabIndex = 40
        Button6.Text = "Fermer"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkOrchid
        Button3.Location = New Point(413, 453)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 58)
        Button3.TabIndex = 39
        Button3.Text = "Annuler"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox3.Location = New Point(297, 266)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 30)
        TextBox3.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(75, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 28)
        Label6.TabIndex = 37
        Label6.Text = "Adresse :"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkOrchid
        Button2.Location = New Point(15, 454)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 60)
        Button2.TabIndex = 36
        Button2.Text = "Retourner au menue principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AZ
        PictureBox2.Location = New Point(716, 32)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox4.Location = New Point(297, 214)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 30)
        TextBox4.TabIndex = 33
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox2.Location = New Point(297, 149)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 30)
        TextBox2.TabIndex = 32
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox1.Location = New Point(297, 100)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 30)
        TextBox1.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(75, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 30
        Label5.Text = "Téléphone :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(75, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 28)
        Label3.TabIndex = 28
        Label3.Text = "Nom et Prénom :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(75, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 27
        Label2.Text = "CIN :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(141, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 41)
        Label1.TabIndex = 26
        Label1.Text = "Inscrire un nouveau paticipant"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkOrchid
        Button1.Location = New Point(251, 453)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 58)
        Button1.TabIndex = 25
        Button1.Text = "Inscrit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' partcp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(874, 538)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "partcp"
        Text = "partcp"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
