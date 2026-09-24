<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PictureBox2 = New PictureBox()
        Button5 = New Button()
        Button6 = New Button()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button77 = New Button()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Button7 = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(162, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 54)
        Label1.TabIndex = 11
        Label1.Text = "Consulter les necessiteux"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column7})
        DataGridView1.Location = New Point(48, 174)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(824, 376)
        DataGridView1.TabIndex = 12
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
        ' Column4
        ' 
        Column4.HeaderText = "DATE DE NAISSANCE"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "ADRESSE"
        Column5.Name = "Column5"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "DATE D'UNSCRIPTION"
        Column7.Name = "Column7"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkOrchid
        Button2.Location = New Point(22, 632)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 60)
        Button2.TabIndex = 18
        Button2.Text = "Retourner au menue principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkOrchid
        Button1.Location = New Point(261, 576)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 51)
        Button1.TabIndex = 17
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkOrchid
        Button3.Location = New Point(413, 576)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 51)
        Button3.TabIndex = 19
        Button3.Text = "Supprimer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = Color.DarkOrchid
        Button4.Location = New Point(565, 576)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 51)
        Button4.TabIndex = 20
        Button4.Text = "Ajouter"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AZ
        PictureBox2.Location = New Point(744, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.DarkOrchid
        Button5.Location = New Point(413, 641)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 51)
        Button5.TabIndex = 22
        Button5.Text = "Modifier"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkOrchid
        Button6.Location = New Point(22, 576)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 51)
        Button6.TabIndex = 23
        Button6.Text = "Fermer"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox3.Location = New Point(279, 884)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 30)
        TextBox3.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(57, 886)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 28)
        Label6.TabIndex = 32
        Label6.Text = "Adresse :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox4.Location = New Point(279, 832)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 30)
        TextBox4.TabIndex = 30
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox2.Location = New Point(279, 770)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 30)
        TextBox2.TabIndex = 29
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox1.Location = New Point(279, 720)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 30)
        TextBox1.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(57, 832)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 27
        Label5.Text = "Téléphone :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(57, 772)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 28)
        Label3.TabIndex = 25
        Label3.Text = "Nom et Prénom :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(57, 722)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 24
        Label2.Text = "CIN :"
        ' 
        ' Button77
        ' 
        Button77.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button77.ForeColor = Color.DarkOrchid
        Button77.Location = New Point(589, 786)
        Button77.Name = "Button77"
        Button77.Size = New Size(146, 51)
        Button77.TabIndex = 35
        Button77.Text = "Enregistrer"
        Button77.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox5.Location = New Point(279, 935)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(249, 30)
        TextBox5.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(78, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 31)
        Label4.TabIndex = 39
        Label4.Text = "CIN :"
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button7.ForeColor = Color.DarkOrchid
        Button7.Location = New Point(480, 106)
        Button7.Name = "Button7"
        Button7.Size = New Size(146, 51)
        Button7.TabIndex = 38
        Button7.Text = "Chercher"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        TextBox6.Location = New Point(162, 113)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(295, 44)
        TextBox6.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkBlue
        Label7.Location = New Point(53, 937)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 28)
        Label7.TabIndex = 40
        Label7.Text = "Date d'ajout :"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(920, 989)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Button7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button77)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Consultation des necessiteux"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button77 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
End Class
