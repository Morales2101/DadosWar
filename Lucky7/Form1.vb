Public Class Form1
    Private Sub btnAtaque_Click(sender As Object, e As EventArgs) Handles btnAtaque.Click
        lbl1.Text = CStr(Int(Rnd() * 6))
        lbl2.Text = CStr(Int(Rnd() * 6))
        lbl3.Text = CStr(Int(Rnd() * 6))


        If (lbl1.Text = "1") Or (lbl1.Text = "2") Or (lbl1.Text = "3") Or (lbl1.Text = "4") Or
               (lbl1.Text = "5") Or (lbl1.Text = "6") Then
            If (lbl2.Text = "1") Or (lbl2.Text = "2") Or (lbl2.Text = "3") Or (lbl2.Text = "4") Or
             (lbl2.Text = "5") Or (lbl2.Text = "6") Then
                If (lbl3.Text = "1") Or (lbl3.Text = "2") Or (lbl3.Text = "3") Or (lbl3.Text = "4") Or
           (lbl3.Text = "5") Or (lbl3.Text = "6") Then
                    Beep()
                End If
                Beep()
            End If
            Beep()
        End If

    End Sub


    Private Sub btnDefesa_Click(sender As Object, e As EventArgs) Handles btnDefesa.Click
        lbl4.Text = CStr(Int(Rnd() * 6))
        lbl5.Text = CStr(Int(Rnd() * 6))
        lbl6.Text = CStr(Int(Rnd() * 6))

        If (lbl1.Text = "1") Or (lbl1.Text = "2") Or (lbl1.Text = "3") Or (lbl1.Text = "4") Or
               (lbl1.Text = "5") Or (lbl1.Text = "6") Then
            If (lbl2.Text = "1") Or (lbl2.Text = "2") Or (lbl2.Text = "3") Or (lbl2.Text = "4") Or
             (lbl2.Text = "5") Or (lbl2.Text = "6") Then
                If (lbl3.Text = "1") Or (lbl3.Text = "2") Or (lbl3.Text = "3") Or (lbl3.Text = "4") Or
           (lbl3.Text = "5") Or (lbl3.Text = "6") Then
                    Beep()
                End If
                Beep()
            End If
            Beep()
        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVenc.Click
        'Três dados maiores que a defesa
        If (lbl1.Text > lbl4.Text) And (lbl2.Text > lbl5.Text) And (lbl3.Text > lbl6.Text) Then
            MessageBox.Show("Ataque venceu!")
        ElseIf (lbl1.Text > lbl4.Text) And (lbl2.Text > lbl5.Text) And (lbl3.Text < lbl6.Text) Then
            MessageBox.Show("Ataque venceu!")
        ElseIf (lbl1.Text < lbl4.Text) And (lbl2.Text > lbl5.Text) And (lbl3.Text > lbl6.Text) Then
            MessageBox.Show("Ataque venceu!")
        ElseIf (lbl1.Text > lbl4.Text) And (lbl2.Text < lbl5.Text) And (lbl3.Text > lbl6.Text) Then
            MessageBox.Show("Ataque venceu!")
        Else
            MessageBox.Show("Defesa venceu!")
        End If
    End Sub
End Class
