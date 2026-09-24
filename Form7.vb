Imports System.IO


Public Class Form7
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()

        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tp As String = ""
        Dim ok As Boolean = True
        Dim mt As String = TextBox3.Text
        Dim cin As String = TextBox1.Text

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            ok = False

        ElseIf RadioButton1.Checked = True Then
            tp = "COTISATION"
        Else
            tp = "DONS"
        End If
        If IsNumeric(cin) Then
            If cin.Length <> 8 Or Not IsNumeric(cin) Then
                MsgBox("Verifier CIN", vbCritical, "Erreur")
                ok = False
            ElseIf cin(0) <> "1" And cin(0) <> "0" Then
                MsgBox("Verifier le 1er chiffre de CIN", vbCritical, "Erreur")
                ok = False
            End If
        Else
            MsgBox("Verifier CIN", vbCritical, "Erreur")
            ok = False
        End If
        If verif(cin)=0Then
            MsgBox("CIN n'existe pas", vbCritical, "Erreur")
            ok = False
        End If

        If tp = "DONS" And mt <> "70" Then
            MsgBox("Verifier le montant", vbCritical, "Erreur")
            ok = False
        ElseIf tp = "COTISATION" And mt <> "100" Then
            MsgBox("Verifier le montant", vbCritical, "Erreur")
            ok = False
        End If

        If ok = True Then
            Dim fs As New FileStream("E:\CC\PROJET\GESTION.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(fs)
            sw.WriteLine(cin + "#" + tp + "#" + mt + "#" + Date.Now.Date)
            sw.Close()
            fs.Close()
            MsgBox("Inscrit !", vbInformation)
            TextBox1.Clear()

            TextBox3.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        End If



    End Sub

    Public Function verif(ByVal cin As String) As Integer
        Dim k As Integer = 0
        Dim k1 As Integer = 0
        Dim t() As String
        Dim ch As String
        Dim fs As New FileStream("E:\CC\PROJET\Donnateurs.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek > -1 And k = 0
            ch = sr.ReadLine()
            t = ch.Split("#")
            If t(0) = cin Then
                k = 1
            End If
        End While
        sr.Close()
        fs.Close()
        Dim fff As New FileStream("E:\CC\PROJET\Participants.txt", FileMode.Open, FileAccess.Read)
        Dim sss As New StreamReader(fff)
        While sss.Peek > -1 And k1 = 0
            ch = sss.ReadLine()
            t = ch.Split("#")
            If t(0) = cin Then
                k1 = 1
            End If
        End While
        sss.Close()
        fff.Close()

        Return k Or k1
    End Function
End Class