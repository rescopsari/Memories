Public Class AddTask

    Private Sub AddTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryList = GetCategories()
        If Not CategoryList Is Nothing Then
            For Each cat As Categorie In CategoryList
                CB_Category.Items.Add(cat.title)
            Next
        End If
    End Sub

    Private Sub BTN_AddTask_Click(sender As Object, e As EventArgs) Handles BTN_AddTask.Click
        If IsTaskExist(TB_Title.Text) Then MsgBox("Une tâche portant le même titre existe déjà sur votre compte. Veuillez changer de nom", vbExclamation, "La tâche eiste déjà") : Exit Sub
        Dim CreatedOnStr As String = Now.Year & "/" & Now.Month & "/" & Now.Day
        Dim RemindOnStr As String = DateTimePicker1.Value.Year & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day
        Dim req As String = "INSERT INTO task (created_on, remind, title, description, id_utilisateur, id_categorie, id_status) VALUES ('" & CreatedOnStr & "', '" & RemindOnStr & "', '" & TB_Title.Text & "', '" & TB_Description.Text & "', " & ConnectedUser.user_id & ", " & CB_Category.SelectedIndex + 1 & ", 1)"
        If MySQL_REQUEST_EXEC(req) = True Then
            Dashboard.DisplayForm(New ToDoList, False)
            RefreshTasklist()
            CType(Dashboard.DisplayedForm, ToDoList).DisplayTasklist()
            Me.Close()
        Else
            MsgBox("Impossible d'effectuer l'insertion de donnée", vbCritical)
        End If
    End Sub
End Class