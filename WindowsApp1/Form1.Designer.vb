<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimer
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextSetTimer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextRemainingTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerControl = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "時間設定"
        '
        'TextSetTimer
        '
        Me.TextSetTimer.Location = New System.Drawing.Point(84, 13)
        Me.TextSetTimer.Name = "TextSetTimer"
        Me.TextSetTimer.Size = New System.Drawing.Size(100, 19)
        Me.TextSetTimer.TabIndex = 1
        Me.TextSetTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "秒"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(15, 38)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(192, 39)
        Me.ButtonStart.TabIndex = 3
        Me.ButtonStart.Text = "スタート！"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "残り時間"
        '
        'TextRemainingTime
        '
        Me.TextRemainingTime.Location = New System.Drawing.Point(84, 83)
        Me.TextRemainingTime.Name = "TextRemainingTime"
        Me.TextRemainingTime.Size = New System.Drawing.Size(100, 19)
        Me.TextRemainingTime.TabIndex = 5
        Me.TextRemainingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "秒"
        '
        'TimerControl
        '
        Me.TimerControl.Interval = 1000
        '
        'FormTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 117)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextRemainingTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextSetTimer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTimer"
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextSetTimer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextRemainingTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TimerControl As Timer
End Class
