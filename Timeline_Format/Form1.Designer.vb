<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UltraTimelineView1 = New Infragistics.Win.UltraWinSchedule.UltraTimelineView()
        Me.UltraCalendarInfo1 = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        CType(Me.UltraTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTimelineView1
        '
        Me.UltraTimelineView1.Location = New System.Drawing.Point(12, 12)
        Me.UltraTimelineView1.Name = "UltraTimelineView1"
        Me.UltraTimelineView1.Size = New System.Drawing.Size(1333, 479)
        Me.UltraTimelineView1.TabIndex = 0
        '
        'UltraCalendarInfo1
        '
        Me.UltraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = Me
        Me.UltraCalendarInfo1.DataBindingsForOwners.BindingContextControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 503)
        Me.Controls.Add(Me.UltraTimelineView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UltraTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraTimelineView1 As Infragistics.Win.UltraWinSchedule.UltraTimelineView
    Friend WithEvents UltraCalendarInfo1 As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
End Class
