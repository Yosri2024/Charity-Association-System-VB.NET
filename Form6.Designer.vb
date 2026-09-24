<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Button4 = New Button()
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
        Column4 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Button6 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button7 = New Button()
        Button77 = New Button()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = Color.DarkOrchid
        Button4.Location = New Point(403, 603)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 51)
        Button4.TabIndex = 55
        Button4.Text = "Ajouter"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.DarkOrchid
        Button5.Location = New Point(555, 540)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 51)
        Button5.TabIndex = 51
        Button5.Text = "Modifier"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AZ
        PictureBox2.Location = New Point(813, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 50
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkOrchid
        Button3.Location = New Point(403, 540)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 51)
        Button3.TabIndex = 49
        Button3.Text = "Supprimer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkOrchid
        Button2.Location = New Point(19, 603)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 62)
        Button2.TabIndex = 48
        Button2.Text = "Retourner au menue principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkOrchid
        Button1.Location = New Point(251, 540)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 51)
        Button1.TabIndex = 47
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5, Column4})
        DataGridView1.Location = New Point(83, 179)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(777, 345)
        DataGridView1.TabIndex = 46
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
        ' Column4
        ' 
        Column4.HeaderText = "Montant"
        Column4.Name = "Column4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(135, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 31)
        Label2.TabIndex = 54
        Label2.Text = "CIN :"
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkOrchid
        Button6.Location = New Point(537, 108)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 51)
        Button6.TabIndex = 53
        Button6.Text = "Chercher"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        TextBox1.Location = New Point(219, 115)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(295, 44)
        TextBox1.TabIndex = 52
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(125, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 54)
        Label1.TabIndex = 45
        Label1.Text = "Consulter les donnateurs"
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button7.ForeColor = Color.DarkOrchid
        Button7.Location = New Point(19, 546)
        Button7.Name = "Button7"
        Button7.Size = New Size(146, 51)
        Button7.TabIndex = 56
        Button7.Text = "Fermer"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button77
        ' 
        Button77.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button77.ForeColor = Color.DarkOrchid
        Button77.Location = New Point(642, 781)
        Button77.Name = "Button77"
        Button77.Size = New Size(146, 51)
        Button77.TabIndex = 65
        Button77.Text = "Enregistrer"
        Button77.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox3.Location = New Point(332, 879)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 30)
        TextBox3.TabIndex = 64
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(110, 881)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 28)
        Label6.TabIndex = 63
        Label6.Text = "Adresse :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox4.Location = New Point(332, 827)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 30)
        TextBox4.TabIndex = 62
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox2.Location = New Point(332, 765)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 30)
        TextBox2.TabIndex = 61
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox5.Location = New Point(332, 716)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(249, 30)
        TextBox5.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(110, 827)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 59
        Label5.Text = "Téléphone :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkBlue
        Label3.Location = New Point(110, 767)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 28)
        Label3.TabIndex = 58
        Label3.Text = "Nom et Prénom :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkBlue
        Label4.Location = New Point(110, 718)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 28)
        Label4.TabIndex = 57
        Label4.Text = "CIN :"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox6.Location = New Point(332, 927)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(249, 30)
        TextBox6.TabIndex = 66
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkBlue
        Label7.Location = New Point(110, 929)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 28)
        Label7.TabIndex = 67
        Label7.Text = "Montant :"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(965, 979)
        Controls.Add(Label7)
        Controls.Add(TextBox6)
        Controls.Add(Button77)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Button7)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Consultation des donnateurs"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button77 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
End Class
