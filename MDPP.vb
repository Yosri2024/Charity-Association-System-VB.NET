Public Class MDPP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "00002222" And TextBox1.Text <> "00001111" Then
            MsgBox("CIN Invalide", vbCritical, "Erreur")
        Else

            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class