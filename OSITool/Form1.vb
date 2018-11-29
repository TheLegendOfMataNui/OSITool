Public Class OSITool
    Private mySubTask As Process

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mySubTask = Process.Start("Resources\ASSEMBLE (ALPHA).bat")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mySubTask = Process.Start("Resources\DISASSEMBLE (ALPHA).bat")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mySubTask = Process.Start("Resources\ASSEMBLE (LEGACY).bat")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mySubTask = Process.Start("Resources\DISASSEMBLE (LEGACY).bat")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mySubTask = Process.Start("Resources\ASSEMBLE.bat")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mySubTask = Process.Start("Resources\DISASSEMBLE.bat")
    End Sub

End Class
