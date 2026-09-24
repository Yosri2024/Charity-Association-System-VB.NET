Imports System.IO
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cin As String = TextBox1.Text
        Dim np As String = TextBox2.Text
        Dim dn As String = DateTimePicker1.Value.Date
        Dim tel As String = TextBox4.Text
        Dim adresse As String = TextBox3.Text.ToUpper


        Dim ok As Boolean = True


        If cin.Length <> 8 Or Not IsNumeric(cin) Then
            MsgBox("Verifier CIN", vbCritical, "Erreur")
            ok = False
        ElseIf cin(0) <> "1" And cin(0) <> "0" Then
            MsgBox("Verifier le 1er chiffre de CIN", vbCritical, "Erreur")
            ok = False
        End If

        If verif(cin) <> 0 Then
            MsgBox("Ce Cin est deja existe", vbInformation, "Info")
        Else
            If np.Length < 6 Or np.IndexOf(" ") = -1 Or IsNumeric(np) = True Then
                MsgBox("Verifier Nom et prenom", vbCritical, "Erreur")
                ok = False
            End If

            If dn >= Date.Now.Date Then
                MsgBox("Verifier date de naissance", vbCritical, "Erreur")
                ok = False
            End If

            If tel.Length <> 8 Or Not IsNumeric(tel) Then
                MsgBox("Verifier telephone", vbCritical, "Erreur")
                ok = False
            End If

            If adresse.IndexOf("RUE") = -1 Then
                MsgBox("Verifier adresse", vbCritical, "Erreur")
                ok = False

            End If
            If verif_adr(adresse) Then
                MsgBox("Cette adresse est déja existe", vbCritical, "Erreur")
                ok = False
            End If


            If ok = True Then
                Dim fs As New FileStream("E:\CC\PROJET\Necessiteux.txt", FileMode.Append, FileAccess.Write)
                Dim sw As New StreamWriter(fs)
                sw.WriteLine(cin + "#" + np + "#" + tel + "#" + DateTimePicker1.Value.ToShortDateString + "#" + adresse + "#" + Date.Now.Date)
                sw.Close()
                fs.Close()
                MsgBox("Inscrit !", vbInformation)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
            End If
        End If
    End Sub

    Public Function verif(ByVal cin As String) As Integer
        Dim k As Integer = 0
        Dim t() As String
        Dim ch As String
        Dim fs As New FileStream("E:\CC\PROJET\Necessiteux.txt", FileMode.Open, FileAccess.Read)
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

        Return k
    End Function

    Public Function verif_adr(ByVal adresse As String) As Integer
        Dim k As Integer = 0
        Dim t() As String
        Dim ch As String
        Dim fs As New FileStream("E:\CC\PROJET\Necessiteux.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        While sr.Peek > -1 And k = 0
            ch = sr.ReadLine()
            t = ch.Split("#")
            If t(4) = adresse Then
                k = 1
            End If
        End While
        sr.Close()
        fs.Close()

        Return k
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
