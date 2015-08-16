Public Class Painter
    Private m_canvas As Canvas

    Private Sub Painter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_canvas = New Canvas(Me)
    End Sub

    Private Sub Painter_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        m_canvas.drawPoint(e.X, e.Y)
    End Sub

    Private Sub btnClearWindow_Click(sender As Object, e As EventArgs) Handles btnClearWindow.Click
        m_canvas.clear()
        Me.Invalidate()
    End Sub

    Private Sub Painter_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawImage(m_canvas.buffer, 0, 0)
    End Sub

    Private Sub Painter_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        m_canvas.reSize()
    End Sub

End Class
