Imports System.IO

Public Class Form4
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cin As String = TextBox1.Text

        If cin.Length <> 8 Or Not IsNumeric(cin) Then
            MsgBox("Verifier CIN", vbCritical, "Erreur")
        ElseIf (cin(0) <> "1" And cin(0) <> "0") Then
            MsgBox("Verifier le 1er chiffre de CIN", vbCritical, "Erreur")
        End If

        If verif(cin) <> 0 Then
            MsgBox("Ce Cin est deja existe", vbInformation, "Info")
        Else
            MsgBox("Ce Cin n'existe pas", vbInformation, "Info")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form1.Show()

    End Sub
    Public Function verif(ByVal cin As String) As Integer
        Dim k As Integer = 0
        Dim t() As String
        Dim ch As String
        Dim fs As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Open, FileAccess.Read)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.RemoveAt(row.Index)
        Next
        Dim fs As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Create, FileAccess.Write)
        Dim sr As New StreamWriter(fs)
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim val1, val2, val3 As String
            val1 = DataGridView1.Rows(i).Cells(0).Value
            val2 = DataGridView1.Rows(i).Cells(1).Value
            val3 = DataGridView1.Rows(i).Cells(2).Value


            sr.WriteLine(val1 + "#" + val2 + "#" + val3)

        Next
        sr.Close()
        fs.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fs As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        While sr.Peek > -1
            s = sr.ReadLine()
            t = s.Split("#")
            DataGridView1.Rows.Add(t(0), t(1), t(2), t(3))
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        For Each dr As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.RemoveAt(dr.Index)
            TextBox5.Text = dr.Cells(0).Value.ToString()
            TextBox2.Text = dr.Cells(1).Value.ToString()
            TextBox4.Text = dr.Cells(2).Value.ToString()
            TextBox3.Text = dr.Cells(3).Value.ToString()
        Next
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.RemoveAt(row.Index)
        Next
        Dim fs As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Create, FileAccess.Write)
        Dim sr As New StreamWriter(fs)
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim val1, val2, val3, val4 As String
            val1 = DataGridView1.Rows(i).Cells(0).Value
            val2 = DataGridView1.Rows(i).Cells(1).Value
            val3 = DataGridView1.Rows(i).Cells(2).Value
            val4 = DataGridView1.Rows(i).Cells(3).Value



            sr.WriteLine(val1 + "#" + val2 + "#" + val3 + "#" + val4 + "#" + Date.Now.Date)

        Next
        sr.Close()
        fs.Close()


    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        DataGridView1.Rows.Clear()
        Dim ok As Boolean = True
        Dim cin As String = TextBox5.Text
        Dim np As String = TextBox2.Text
        Dim tel As String = TextBox4.Text
        Dim adresse As String = TextBox3.Text.ToUpper


        If cin.Length <> 8 Or Not IsNumeric(cin) Then
            MsgBox("Verifier CIN", vbCritical, "Erreur")
            ok = False
        ElseIf cin(0) <> "1" And cin(0) <> "0" Then
            MsgBox("Verifier le 1er chiffre de CIN", vbCritical, "Erreur")
            ok = False
        End If

        If verif(cin) Then
            ok = False
            MsgBox("Ce Cin est deja existe", vbInformation, "Info")
        Else

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

            If tel.Length <> 8 Or Not IsNumeric(tel) Then
                MsgBox("Verifier telephone", vbCritical, "Erreur")
                ok = False
            End If
        End If

        If adresse.IndexOf("RUE") = -1 Then
            MsgBox("Verifier adresse", vbCritical, "Erreur")
            ok = False

        End If
        If ok = True Then
            Dim ff As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Append, FileAccess.Write)
            Dim sw As New StreamWriter(ff)
            sw.WriteLine(cin + "#" + np + "#" + tel + "#" + adresse + "#" + Date.Now.Date)
            sw.Close()
            ff.Close()
            MsgBox("Enregistrer !", vbInformation)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If


    End Sub


    Public Function verif_adr(ByVal adresse As String) As Integer
        Dim k As Integer = 0
        Dim t() As String
        Dim ch As String
        Dim fs As New FileStream("E:\CC\PROJET\Responsables.txt", FileMode.Open, FileAccess.Read)
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

End Class