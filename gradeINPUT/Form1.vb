Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Check.Click




        If grade.Text >= 90 Then
            MsgBox("A+")
        ElseIf grade.Text >= 80 Then
            MsgBox("B")
        ElseIf grade.Text >= 70 Then
            MsgBox("C")
        ElseIf grade.Text >= 60 Then
            MsgBox("D")
        Else
            MsgBox("F")

        End If


    End Sub

    Private Sub grade_TextChanged(sender As Object, e As EventArgs) Handles grade.TextChanged

    End Sub
End Class
