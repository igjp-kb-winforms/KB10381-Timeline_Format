Imports Infragistics.Win
Imports Infragistics.Win.UltraWinSchedule

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.UltraTimelineView1.CalendarInfo = Me.UltraCalendarInfo1

        Dim dayInterval As New DateInterval(1, DateIntervalUnits.Days)
        dayInterval.HeaderTextFormat = "yyyy年MM月dd日 (ddd)"
        Me.UltraTimelineView1.PrimaryInterval = dayInterval

    End Sub
End Class
