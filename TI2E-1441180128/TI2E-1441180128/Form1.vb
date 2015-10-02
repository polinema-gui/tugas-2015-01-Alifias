Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Button1.Text = "START"
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
            Button1.Text = "STOP"
            Me.BackColor = Color.Maroon
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.BackColor = Color.Maroon Then
            Me.BackColor = Color.Black
        Else
            Me.BackColor = Color.Maroon
        End If
    End Sub
End Class
