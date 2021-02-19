Option Strict On

Public Class Form1
    Private Sub EndeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EndeToolStripMenuItem1.Click
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub tsms_Click(sender As Object, e As EventArgs) Handles tsms.Click
        Form2.ShowDialog()

    End Sub

    Private Sub EndeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndeToolStripMenuItem.Click
        txtBoxSpieler1.Text = ""
        txtBoxSpieler2.Text = ""

    End Sub
End Class
