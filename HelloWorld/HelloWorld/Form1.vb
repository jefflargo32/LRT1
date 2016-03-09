Public Class HelloWorldFrom
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHW.Click
        MessageBox.Show("Hello World!", "HelloWorld", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub
End Class
