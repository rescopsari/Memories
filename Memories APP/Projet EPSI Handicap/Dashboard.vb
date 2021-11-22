Public Class Dashboard

    Public DisplayedForm As Form = Nothing
    Private DisconnectUser As Boolean = False

#Region "Formulaire"

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ConnectedUser Is Nothing Then
            LBL_User_Nom.Text = ConnectedUser.firstname
            LBL_User_Prenom.Text = ConnectedUser.lastname
        End If
        UpdateStatus()
        CategoryList = GetCategories()
        RefreshQuizzList()
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If DisconnectUser = True Then
            DisconnectUser = False
        Else
            End
        End If
    End Sub

#End Region

#Region "Fonctions d'affichage"

    Dim Color_Jaune As Color = Color.FromArgb(250, 202, 7)

    Dim Color_Text_Selected As Color = Color.FromArgb(131, 156, 176)
    Dim Color_Text_Normal As Color = Color.Black

    Dim Font_Navbar_Normal As Font = New Font("Calibri", 14.25, FontStyle.Regular)
    Dim Font_Navbar_Selected As Font = New Font("Calibri", 16, FontStyle.Bold)



    ''' <summary>
    ''' Affiche un formulaire du projet dans le conteneur MainPanel
    ''' </summary>
    ''' <param name="Formulaire">WindowsForm à affiché dans MainPanel</param>
    ''' <param name="ClosePreviousForm">Quand le paramètre est sur true (par défaut) le formulaire précédemment ouvert (grâce à l'appel précédent de cette méthode) sera fermé</param>
    Public Sub DisplayForm(ByVal Formulaire As Form, Optional ByVal ClosePreviousForm As Boolean = True)
        If ClosePreviousForm = True Then
            If Not DisplayedForm Is Nothing Then DisplayedForm.Close()
        End If
        DisplayedForm = Formulaire
        DisplayedForm.FormBorderStyle = FormBorderStyle.None
        DisplayedForm.Dock = DockStyle.None
        DisplayedForm.MdiParent = Me
        DisplayedForm.Parent = Me.MainPanel
        MainPanel.Tag = DisplayedForm
        DisplayedForm.BringToFront()
        DisplayedForm.Show()
        DisplayedForm.Size = Me.MainPanel.Size
    End Sub

    Public Sub SelectButtonMenu(ByVal BTN As Button)
        'On désélectionne tous les boutons de la navbar:
        For Each ctrl As Control In Panel_Navbar.Controls
            If Not TypeOf ctrl Is Button Then Continue For
            UnselectButtonMenu(ctrl)
        Next
        'On sélectionne uniquement le bouton fourni en argument de la méthode:
        'BTN.ForeColor = Color_Text_Selected
        BTN.Font = Font_Navbar_Selected
    End Sub

    Public Sub UnselectButtonMenu(ByVal BTN As Button)
        Console.WriteLine(BTN.Name & " à été désélectionné")
        'BTN.ForeColor = Color_Text_Normal
        BTN.Font = Font_Navbar_Normal
    End Sub

#End Region

#Region "Evènements"

    Private Sub BTN_Settings_Click(sender As Object, e As EventArgs) Handles BTN_MENU_Settings.Click
        SelectButtonMenu(BTN_MENU_Settings)
        DisplayForm(New Settings)
    End Sub

    Private Sub BTN_ShowTasks_Click(sender As Object, e As EventArgs) Handles BTN_MENU_ShowTasks.Click
        SelectButtonMenu(BTN_MENU_ShowTasks)
        DisplayForm(New ToDoList)
    End Sub

    Private Sub BTN_MENU_Stats_Click(sender As Object, e As EventArgs) Handles BTN_MENU_Stats.Click
        SelectButtonMenu(BTN_MENU_Stats)
        DisplayForm(New StatsForm)
    End Sub

    Private Sub BTN_MENU_Questionnaire_Click(sender As Object, e As EventArgs) Handles BTN_MENU_Questionnaire.Click
        SelectButtonMenu(BTN_MENU_Questionnaire)
        DisplayForm(New QuizzForm)
    End Sub

    Private Sub BTN_Logout_Click(sender As Object, e As EventArgs) Handles BTN_Logout.Click
        ConnectedUser = Nothing
        DisconnectUser = True
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not DisplayedForm Is Nothing Then
            DisplayedForm.Size = MainPanel.Size
            DisplayedForm.Invalidate()
        End If
    End Sub

#End Region




End Class