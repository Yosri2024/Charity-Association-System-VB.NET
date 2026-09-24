<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button5 = New Button()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button6 = New Button()
        Label2 = New Label()
        Button4 = New Button()
        Button77 = New Button()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.DarkOrchid
        Button5.Location = New Point(548, 536)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 51)
        Button5.TabIndex = 30
        Button5.Text = "Modifier"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AZ
        PictureBox2.Location = New Point(806, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkOrchid
        Button3.Location = New Point(396, 536)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 51)
        Button3.TabIndex = 27
        Button3.Text = "Supprimer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkOrchid
        Button2.Location = New Point(12, 599)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 60)
        Button2.TabIndex = 26
        Button2.Text = "Retourner au menue principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkOrchid
        Button1.Location = New Point(244, 536)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 51)
        Button1.TabIndex = 25
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5})
        DataGridView1.Location = New Point(76, 175)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(777, 345)
        DataGridView1.TabIndex = 24
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "CIN"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NOM ET PRENOM"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "TEL"
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "ADRESSE"
        Column5.Name = "Column5"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(173, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(549, 54)
        Label1.TabIndex = 23
        Label1.Text = "Consulter les responsables"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        TextBox1.Location = New Point(212, 111)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(295, 44)
        TextBox1.TabIndex = 31
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkOrchid
        Button6.Location = New Point(530, 104)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 51)
        Button6.TabIndex = 32
        Button6.Text = "Chercher"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(128, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 31)
        Label2.TabIndex = 33
        Label2.Text = "CIN :"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = Color.DarkOrchid
        Button4.Location = New Point(12, 542)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 51)
        Button4.TabIndex = 34
        Button4.Text = "Fermer"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button77
        ' 
        Button77.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button77.ForeColor = Color.DarkOrchid
        Button77.Location = New Point(723, 700)
        Button77.Name = "Button77"
        Button77.Size = New Size(146, 51)
        Button77.TabIndex = 44
        Button77.Text = "Enregistrer"
        Button77.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox3.Location = New Point(413, 798)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 30)
        TextBox3.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(191, 800)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 28)
        Label6.TabIndex = 42
        Label6.Text = "Adresse :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox4.Location = New Point(413, 746)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 30)
        TextBox4.TabIndex = 41
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox2.Location = New Point(413, 684)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 30)
        TextBox2.TabIndex = 40
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox5.Location = New Point(413, 635)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(249, 30)
        TextBox5.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(191, 746)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 38
        Label5.Text = "Téléphone :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(191, 686)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 28)
        Label3.TabIndex = 37
        Label3.Text = "Nom et Prénom :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(191, 637)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 28)
        Label4.TabIndex = 36
        Label4.Text = "CIN :"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(936, 905)
        Controls.Add(Button77)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Consultation des responsables"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button77 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
