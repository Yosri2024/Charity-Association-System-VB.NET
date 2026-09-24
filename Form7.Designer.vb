<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        Button6 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        RadioButton1.ForeColor = Color.DarkBlue
        RadioButton1.Location = New Point(157, 280)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(331, 32)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Cotisation Mensuelle (100DT)" & vbTab
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        RadioButton2.ForeColor = Color.DarkBlue
        RadioButton2.Location = New Point(157, 318)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(159, 32)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Dons (70DT)"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox1.Location = New Point(319, 102)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 30)
        TextBox1.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkBlue
        Label2.Location = New Point(97, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 34
        Label2.Text = "CIN :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(163, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(480, 41)
        Label1.TabIndex = 33
        Label1.Text = "Gestion des Cotisations et Dons"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkBlue
        Label5.Location = New Point(92, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 28)
        Label5.TabIndex = 40
        Label5.Text = "Choisir le type  :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        TextBox3.Location = New Point(285, 360)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 30)
        TextBox3.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkBlue
        Label6.Location = New Point(157, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 28)
        Label6.TabIndex = 42
        Label6.Text = "Montant :"
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button6.ForeColor = Color.DarkOrchid
        Button6.Location = New Point(566, 482)
        Button6.Name = "Button6"
        Button6.Size = New Size(150, 58)
        Button6.TabIndex = 46
        Button6.Text = "Fermer"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.DarkOrchid
        Button3.Location = New Point(404, 482)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 58)
        Button3.TabIndex = 45
        Button3.Text = "Annuler"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DarkOrchid
        Button2.Location = New Point(6, 483)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 60)
        Button2.TabIndex = 44
        Button2.Text = "Retourner au menue principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.DarkOrchid
        Button1.Location = New Point(242, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 58)
        Button1.TabIndex = 43
        Button1.Text = "Enregistrer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(855, 552)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
