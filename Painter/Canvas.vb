Public Class Canvas
    Private m_buf As Bitmap             '防止因窗体重绘丢失图形而维护的Buffer
    Private m_graphics As Graphics      '直接在窗体上绘制的图形
    Private m_targetForm As System.Windows.Forms.Form

    Public ReadOnly Property buffer As Bitmap
        Get
            Return m_buf
        End Get
    End Property

    Public Sub New(ByRef targetForm As System.Windows.Forms.Form)
        m_targetForm = targetForm
        m_buf = New Bitmap(m_targetForm.ClientRectangle.Width, _
                           m_targetForm.ClientRectangle.Height, _
                           Drawing.Imaging.PixelFormat.Format24bppRgb)
        m_graphics = m_targetForm.CreateGraphics()

        Me.clear()
    End Sub

    Public Sub clear()
        Dim tmpGraphics = Graphics.FromImage(m_buf) '操作Buffer

        m_graphics.Clear(Color.White)
        tmpGraphics.Clear(Color.White)
    End Sub

    Public Sub drawPoint(ByVal x As Integer, ByVal y As Integer)
        Dim tmpGraphics = Graphics.FromImage(m_buf) '操作Buffer

        Dim rectEllipse As Rectangle
        With rectEllipse
            .X = x - 2
            .Y = y - 2
            .Width = 4
            .Height = 4
        End With

        m_graphics.FillEllipse(Brushes.Blue, rectEllipse)
        tmpGraphics.FillEllipse(Brushes.Blue, rectEllipse)
    End Sub

    Public Sub reSize()
        Dim tmpBuf = New Bitmap(m_targetForm.ClientRectangle.Width, _
                                        m_targetForm.ClientRectangle.Height, _
                                        Drawing.Imaging.PixelFormat.Format24bppRgb) '重新建立新的Buffer
        Dim tmpGraphics = Graphics.FromImage(tmpBuf)
        tmpGraphics.Clear(Color.White)
        tmpGraphics.DrawImage(m_buf, 0, 0) '把原Buffer写进新的Buffer

        m_buf = tmpBuf

        m_graphics = m_targetForm.CreateGraphics() '同步更新窗体上的图形
        m_graphics.Clear(Color.White)
        m_graphics.DrawImage(m_buf, 0, 0)
    End Sub

End Class
