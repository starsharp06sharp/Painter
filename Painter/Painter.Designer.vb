<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Painter
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClearWindow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClearWindow
        '
        Me.btnClearWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearWindow.Location = New System.Drawing.Point(586, 420)
        Me.btnClearWindow.Name = "btnClearWindow"
        Me.btnClearWindow.Size = New System.Drawing.Size(39, 23)
        Me.btnClearWindow.TabIndex = 0
        Me.btnClearWindow.Text = "清除"
        Me.btnClearWindow.UseVisualStyleBackColor = True
        '
        'Painter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.btnClearWindow)
        Me.MinimumSize = New System.Drawing.Size(160, 120)
        Me.Name = "Painter"
        Me.Text = "画布"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClearWindow As System.Windows.Forms.Button

End Class
