Public Class Form1
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Not pn_menu.Visible Then
            Guna2Transition1.ShowSync(pn_menu)
        Else
            Guna2Transition1.HideSync(pn_menu)
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub
End Class
