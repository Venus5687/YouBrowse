Imports System.Net

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim html As String = "<html><head>"
        html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
        html &= "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='420' height='250' frameborder='0' allowfullscreen></iframe>"
        html &= "</body></html>"
        Me.WebBrowser1.DocumentText = String.Format(html, TextBox1.Text.Split("=")(1))
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
