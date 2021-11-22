Imports System.ComponentModel

Public Class QuizzForm
    'Variables Globales:
    Dim UserTasks As New List(Of Task)
    Dim FakeTasks As New List(Of Task)
    'Stats globales:
    Dim quizz As New Quizz
    'Variables de la question en cours:
    Dim TypeQuestion As QuestionType
    Dim GoodReponse As Integer = 0



    Private Enum QuestionType
        AvezVousFinis = 1
        QuandAvezVousFinis = 2
    End Enum


    Private Sub QuizzForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quizz = New Quizz
        GenerateFakeTasks()
        AskNewQuestion()
    End Sub

    Private Sub AskNewQuestion()
        UpdateHeader()
        Dim AleaTypeQuestion As New Random
        TypeQuestion = AleaTypeQuestion.Next(1, 2)

        BTN_Rep1.Text = "Non je ne l'ai pas encore fait"
            BTN_Rep2.Text = "Oui je l'ai fait"
            BTN_Rep3.Text = "Je n'ai jamais eu à faire cette tâche"

            RefreshUserTasks()
            Dim SelectedTask As Task = Nothing

            Dim AleaDoFakeQuestion As New Random
            If AleaDoFakeQuestion.Next(1, 5) = 3 Then 'On va inventer une tâche'
                SelectedTask = PiocheUneTache(FakeTasks)
                GoodReponse = 3
            Else
                Dim PiocheTache As New Random
                SelectedTask = PiocheUneTache(UserTasks)
                Select Case SelectedTask.statut_id
                    Case 1 'Tache définit comme "A faire"
                        GoodReponse = 1
                    Case 2 'Tache définit comme "Fait"
                        GoodReponse = 2
                    Case 3 'Tache définit comme Cacher"
                        GoodReponse = 2
                End Select
            End If
            LBL_Question.Text = "Avez vous réaliser cette tâche ?" & Environment.NewLine & Chr(34) & SelectedTask.title & Chr(34)
    End Sub

    Private Sub RefreshUserTasks()
        UserTasks.Clear()
        Dim rep = MySQL_GetReponse("SELECT * FROM task WHERE id_utilisateur = " & ConnectedUser.user_id)
        If rep Is Nothing Then MsgBox("Impossible de démarrer un quizz car l'historique de vos tâches n'a pas pu être récupéré !", vbCritical, "Erreur de requêtage SQL") : Me.Close()
        Dim TasksToChoose As New List(Of Task)
        While rep.Read
            Dim tache As New Task
            With tache
                Try
                    .id = rep.GetString(0) '"id_task"
                Catch ex As Exception
                    Continue While
                End Try
                Try
                    .created_on = rep.GetDateTime(1) '"created_on"
                Catch ex As Exception
                End Try
                Try
                    .title = rep.GetString(2) '"title"
                Catch ex As Exception
                End Try
                Try
                    .description = rep.GetString(3) '"description"
                Catch ex As Exception
                End Try
                Try
                    .subtitle = rep.GetString(4) '"subtitle"
                Catch ex As Exception
                End Try
                Try
                    .thumbnail = rep.GetString(5) '"Thumbnail"
                Catch ex As Exception
                End Try
                Try
                    .checked_on = rep.GetDateTime(6) '"checked_on"
                Catch ex As Exception
                End Try
                Try
                    .remind = rep.GetDateTime(7) '"remind"
                Catch ex As Exception
                End Try
                Try
                    .category_id = rep.GetString("id_categorie")
                Catch ex As Exception
                End Try
                Try
                    .statut_id = rep.GetString("id_status")
                Catch ex As Exception
                End Try
                Try
                    .user_id = rep.GetString("id_utilisateur")
                Catch ex As Exception
                End Try
            End With
            UserTasks.Add(tache)
        End While
    End Sub

    Private Sub GenerateFakeTasks()
        FakeTasks.Clear()
        FakeTasks.Add(New Task("Acheter les albums de Mickael Jackson", 1))
        FakeTasks.Add(New Task("Faire un régime", 1))
        FakeTasks.Add(New Task("Acheter une pizza 3 fromages", 1))
        FakeTasks.Add(New Task("Faire de la méditation tous les jours", 2))
        FakeTasks.Add(New Task("Payer 4200 € d'impot", 1))
        FakeTasks.Add(New Task("Régler mon amende pour stationnement interdit", 1))
        FakeTasks.Add(New Task("Commander des pizzas sur amazon", 1))
        FakeTasks.Add(New Task("Acheter un tee-shirt sur Uber Eat", 1))
        FakeTasks.Add(New Task("Récupérer ma récompense au loto", 1))
        FakeTasks.Add(New Task("Boire du Coca-Cola à la place de l'eau", 1))
        FakeTasks.Add(New Task("S'inscrire au jeu olympique", 1))
        FakeTasks.Add(New Task("Courrir 100 Km par jour", 1))
    End Sub

    Private Function PiocheUneTache(ByVal ListeDeTache As List(Of Task)) As Task
        Dim alea As New Random
        Return ListeDeTache(alea.Next(0, ListeDeTache.Count - 1))
    End Function

    Private Sub SetReponse(ByVal ReponseID As Integer)
        quizz.reponses_answered += 1
        If GoodReponse = ReponseID Then
            quizz.good_reponse += 1
            MsgBox("Bien joué ! Vous avez correctement répondu.", vbInformation, "Quizz")
        Else
            MsgBox("Aille ! Vous avez répondu une mauvaise réponse", vbCritical, "Quizz")
        End If
        AskNewQuestion()
    End Sub

    Private Sub BTN_Rep1_Click(sender As Object, e As EventArgs) Handles BTN_Rep1.Click
        SetReponse(1)
    End Sub

    Private Sub BTN_Rep2_Click(sender As Object, e As EventArgs) Handles BTN_Rep2.Click
        SetReponse(2)
    End Sub

    Private Sub BTN_Rep3_Click(sender As Object, e As EventArgs) Handles BTN_Rep3.Click
        SetReponse(3)
    End Sub

    Sub UpdateHeader()
        LBL_AskedQuestions.Text = quizz.reponses_answered
        LBL_BadReponses.Text = quizz.good_reponse
        LBL_BadReponses.Text = quizz.reponses_answered - quizz.good_reponse
        quizz.prc_reussite = Math.Round((quizz.good_reponse / quizz.reponses_answered) * 100, 0)
        LBL_PourcentageReussite.Text = quizz.prc_reussite & " %"
    End Sub

    Dim ForceClose As Boolean = False
    Private Sub QuizzForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        quizz.Finish()

        If ForceClose = True Then
            e.Cancel = False
        Else
            If quizz.Upload = False Then
                If MsgBox("Le quizz n'a pas été enregistré dans la base de donnée." & Environment.NewLine & "Voulez-vous quand même quitter sans enregistrer votre progression ?", vbYesNo, "Erreur d'enregistrement dans la base de donnée") = vbYes Then
                    ForceClose = True
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class