Imports System.Windows.Forms.DataVisualization.Charting
Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshQuizzList()
        If QuizzList Is Nothing Then MsgBox("Vous n'avez fait aucun quizz ! Veuillez faire au moins 1 quizz pour afficher vos statistiques !", vbInformation, "Aucunes données !") : Exit Sub
        If QuizzList.Count <= 0 Then MsgBox("Vous n'avez fait aucun quizz ! Veuillez faire au moins 1 quizz pour afficher vos statistiques !", vbInformation, "Aucunes données !") : Exit Sub
        Dim series1 As Series = Chart_SessionScore.Series(0)
        series1.Points.Clear()
        For Each q As Quizz In QuizzList
            series1.Points.Add(q.prc_reussite)
        Next
        series1.ChartArea = "ChartArea1"

        Chart_SessionScore.Series.Clear()
        Chart_SessionScore.Series.Add(series1)
    End Sub
End Class