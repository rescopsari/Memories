Public Class ToDoList

    Dim SelectedTask As Task

    Private Sub ToDoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBB_Category.Items.Clear()
        If Not CategoryList Is Nothing Then
            For Each cat As Categorie In CategoryList
                CBB_Category.Items.Add(cat.title)
            Next
        Else
            Console.WriteLine("ToDoList_Load() : Impossible de charger les catégories des tâches car la variable les contenant est vide")
        End If



        CBB_Statut.Items.Clear()
        If Not StatutList Is Nothing Then
            For Each statut As Statut In StatutList
                CBB_Statut.Items.Add(statut.title)
            Next
        Else
            Console.WriteLine("ToDoList_Load() : Impossible de charger les status des tâches attribuable car la variable les contenant est vide")
        End If

        RefreshTasklist()
        DisplayTasklist()
    End Sub

    Dim TasklistDisplaying As Boolean = False
    Public Sub DisplayTasklist()
        TasklistDisplaying = True
        ListBox1.Items.Clear()
        If Tasklist Is Nothing Then Exit Sub
        For Each tache As Task In Tasklist
            ListBox1.Items.Add(tache.title)
        Next
        TasklistDisplaying = False
    End Sub

    Private Sub EditTask(ByVal tache As Task)
        PanelTaskInfo.Visible = True
        BTN_Save.Visible = True
        BTN_Delete.Visible = True
        TB_Title.Text = tache.title
        TB_Subtitle.Text = tache.subtitle
        TB_Description.Text = tache.description
        CBB_Category.SelectedIndex = tache.category_id - 1
        CBB_Statut.SelectedIndex = tache.statut_id - 1
        LBL_CreatedAt.Text = tache.created_on.ToString("G")
        Try
            DateTimePicker_Remind.Value = tache.remind
        Catch ex As Exception
            Console.WriteLine("[ToDoList] (EditTask) la date de rappel n'a pas pu être affichée. Détail: " & ex.Message)
        End Try
        If tache.statut_id = 2 Then
            LBL_TaskCheckedOn.Visible = True
            LBL_TaskCheckedOn.Text = "Terminée le " & tache.checked_on.ToString("G")
        Else
            LBL_TaskCheckedOn.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_NewTask.Click
        Dashboard.DisplayForm(New AddTask)
    End Sub


#Region "Relation contrôles > Objet"


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem Is Nothing Then Exit Sub
        SelectedTask = GetTaskByName(ListBox1.SelectedItem.ToString)
        If Not SelectedTask Is Nothing Then EditTask(SelectedTask)
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        If SelectedTask.UpdateOnDatabase() = True Then
            BTN_Save.Visible = False
            BTN_Delete.Visible = False
            PanelTaskInfo.Visible = False
            RefreshTasklist()
            DisplayTasklist()
        Else
            MsgBox("Impossible de mettre à jours les données de cette tâche !", vbCritical, "Echec de requêtage")
        End If
    End Sub

    Private Sub TB_Title_TextChanged(sender As Object, e As EventArgs) Handles TB_Title.TextChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.title = TB_Title.Text
    End Sub

    Private Sub TB_Subtitle_TextChanged(sender As Object, e As EventArgs) Handles TB_Subtitle.TextChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.subtitle = TB_Subtitle.Text
    End Sub

    Private Sub CBB_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBB_Category.SelectedIndexChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.category_id = CBB_Category.SelectedIndex + 1
    End Sub

    Private Sub TB_Description_TextChanged(sender As Object, e As EventArgs) Handles TB_Description.TextChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.description = TB_Description.Text
    End Sub

    Private Sub DateTimePicker_Remind_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Remind.ValueChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.remind = DateTimePicker_Remind.Value
    End Sub

    Private Sub CBB_Statut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBB_Statut.SelectedIndexChanged
        If SelectedTask Is Nothing Then Exit Sub
        SelectedTask.statut_id = CBB_Statut.SelectedIndex + 1
    End Sub

#End Region

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        If SelectedTask Is Nothing Then MsgBox("Vous n'avez pas sélectionner de tâches !", vbExclamation, "Erreur d'utilisation") : Exit Sub
        If SelectedTask.Delete() = True Then
            PanelTaskInfo.Visible = False
            BTN_Delete.Visible = False
            BTN_Save.Visible = False
            RefreshTasklist()
            DisplayTasklist()
        Else
            MsgBox("Une erreur est survenue durant la supression de la tâche sélectionnée !", vbCritical, "Impossible de supprimer une tâche")
        End If
    End Sub
End Class
