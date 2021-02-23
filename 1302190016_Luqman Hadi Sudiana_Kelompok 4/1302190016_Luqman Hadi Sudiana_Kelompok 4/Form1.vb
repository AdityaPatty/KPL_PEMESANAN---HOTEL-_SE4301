Public Class Form1
    Private Sub MASUK_Click(sender As Object, e As EventArgs) Handles MASUK.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim ellipseRadius As New Drawing2D.GraphicsPath
        ellipseRadius.StartFigure()
        ellipseRadius.AddArc(New Rectangle(0, 0, 10, 10), 100, 100)
        ellipseRadius.AddLine(10, 0, Panel1.Width - 20, 0)
        ellipseRadius.AddArc(New Rectangle(Panel1.Width, -10, 0, 10, 10), -90, 90)
        ellipseRadius.AddLine(Panel1.Width  20, Panel1.Width, Panel1.Height - 10)
        ellipseRadius.AddArc(New Rectangle(Panel1.Width, -10, Panel1.Height - 10, 10, 10), 0, 90)
        ellipseRadius.AddLine(Panel1.Width  20, Panel1.Height 20, Panel1.Height)
        ellipseRadius.AddArc(New Rectangle(0, Panel1.Height - 10, 10, 10), 90, 90)
        ellipseRadius.CloseFigure()
        Panel1.Region = New Region(ellipseRadius)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
