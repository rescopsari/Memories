Imports System.Net
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Module Fonctions

#Region "Variables de configuration"

    'Configuration de la base de donnée
    Public MySQL_SERVER_IP As String = "saufrasoft.fr" '"127.0.0.1"      'L'ip ou le nom d'hôte du serveur MySQL
    Public MySQL_USER_ID As String = "u453848127_epsi" '"memories_app"     'L'utilisateur ayant les privilèges nécessaire sur la base de donnée
    Public MySQL_USER_PASS As String = "3|n3y71kaI2L" '"12345678"       'Le mot de passe associé à l'utilisateur de la base de donnée
    Public MySQL_DATABASE As String = "u453848127_memories" ' "memories"        'Le nom de la base de donnée sur laquelle se trouvent toutes les tables dont l'application Memories dépend

#End Region

#Region "Propriétées publiques"

    Public CategoryList As New List(Of Categorie)   'La liste des catégories de tâches disponible
    Public StatutList As New List(Of Statut)        'La liste des statut que peut posséder une tâche
    Public QuizzList As New List(Of Quizz)
    Public Property Tasklist As New List(Of Task)

    Public User_ID As String = Nothing              'L'ID (clé primaire auto-incrémenter) de l'utilisateur connecté qui se trouve dans la table 'user' de la BDD
    Public ConnectedUser As User = Nothing          'L'utilisateur actuellement connecté


#End Region

#Region "Fonctions"

    Public Function GetPublicIPv4()
        Dim webreq As WebRequest = WebRequest.Create("http://127.0.0.1/myip.php")
        Dim rep As WebResponse = webreq.GetResponse
        Dim lire As New System.IO.StreamReader(rep.GetResponseStream)
        Dim html As String = lire.ReadToEnd
        lire.Close()

        Return html
    End Function

    Public Function DateToStr(ByVal ToConvert As Date) As String
        With ToConvert
            Return .Year & "/" & .Month & "/" & .Day & " " & .Hour & ":" & .Minute & ":" & .Second
        End With
    End Function

    ''' <summary>
    ''' Retourne l'objet task correspondant dans les liste des tâches (Tasklist) par le biais de son nom
    ''' </summary>
    ''' <param name="Taskname">Le nom de la tâche à récupéré</param>
    ''' <returns>Un objet Task si elle à été trouvée par son nom SINON NOTHING</returns>
    Public Function GetTaskByName(ByVal Taskname As String) As Task
        For Each tache As Task In Tasklist
            If tache.title.ToUpper = Taskname.ToUpper Then
                Return tache : Exit Function
            End If
        Next
        Return Nothing
    End Function

    Public Function IsTaskExist(ByVal Taskname As String) As Boolean
        For Each tache As Task In Tasklist
            If tache.title.ToUpper = Taskname.ToUpper Then Return True : Exit Function
        Next
        Return False
    End Function

    Public Sub RefreshTasklist()
        Tasklist.Clear()
        Dim req As String = "SELECT * from task WHERE id_utilisateur = " & ConnectedUser.user_id
        Dim rep = MySQL_GetReponse("SELECT * from task WHERE id_utilisateur = " & ConnectedUser.user_id & " AND NOT id_status = 3")
        If rep Is Nothing Then Console.WriteLine("[Fonctions] RefreshTasklist() : Impossible de récupérer la liste des tâche de l'utilisateur car la réponse à la requête suivante est nulle : " & req) : Exit Sub
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
            Tasklist.Add(tache)
        End While
    End Sub

    Public Sub RefreshQuizzList()
        QuizzList.Clear()
        Dim req As String = "SELECT * from quizz WHERE id_user = " & ConnectedUser.user_id
        Dim rep = MySQL_GetReponse(req)
        If rep Is Nothing Then Console.WriteLine("[Fonctions] RefreshQuizzList() : Impossible d'obtenir la liste de quizz de l'utilisateur car la réponse à la requête suivante est nulle : " & req) : Exit Sub
        While rep.Read
            Dim q As New Quizz
            q.id_quizz = rep.GetString("id_quizz")
            q.date_start = rep.GetDateTime("date_start")
            q.date_end = rep.GetDateTime("date_end")
            q.reponses_answered = rep.GetInt32("reponses_answered")
            q.good_reponse = rep.GetInt32("good_reponses")
            q.prc_reussite = rep.GetInt32("prc_reussite")
            QuizzList.Add(q)
        End While
    End Sub

#End Region

#Region "Requêtage MySQL"

    ''' <summary>
    ''' Ouvre une nouvelle connexion à la base de donnée en fonction des paramètres de connexion configurée dans la région 'Variables de configuration'
    ''' </summary>
    ''' <returns>Une connexion de type MySqlConnection ouverte et prête à être utilisée dans la propriétée 'MySqlCommand' des objets MySqlCommand. Si la connexion à échouée, la fonction retourne nothing</returns>
    Public Function MySQL_NEW_CONNECTION() As MySqlConnection
        Dim connectionString As String = "server=" & MySQL_SERVER_IP & "; uid=" & MySQL_USER_ID & "; pwd=" & MySQL_USER_PASS & "; database=" & MySQL_DATABASE & "; SslMode=none"
        Dim SQLConnection As MySqlConnection = New MySqlConnection
        Dim oDt_sched As New DataTable()


        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString

        Try
            SQLConnection.Open()
            'MsgBox("Connexion à la BDD réussie")
            If SQLConnection.State = ConnectionState.Open Then
                Return SQLConnection
            Else
                Return Nothing
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.Message, vbCritical, "Exception lors de la connexion à la BDD MySQL")
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Initialise une nouvelle connexion à la BDD, exécute une requête spécifique, puis retourne une réponse (un objet de type MySqlDataReader) afin d'y traiter les données reçues.
    ''' </summary>
    ''' <param name="SQL_REQUEST">La requête SQL à exécuter</param>
    ''' <returns>Une réponse du serveur (objet MySqlDataReader) à traiter ou Nothing en cas d'erreur d'éxécution (ou l'absence de donnée ?)</returns>
    Public Function MySQL_GetReponse(ByVal SQL_REQUEST As String) As MySqlDataReader
        Dim SQLConnection As MySqlConnection = MySQL_NEW_CONNECTION()
        If SQLConnection Is Nothing Then Return Nothing : Exit Function

        Dim sqlCommand As New MySqlCommand

        Try
            'MsgBox(SQL_REQUEST, MsgBoxStyle.Information, "Aperçu de la requête SQL")
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = SQL_REQUEST
            Return sqlCommand.ExecuteReader()
        Catch ex As Exception
            Return Nothing
            Console.WriteLine(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Ouvre une nouvelle connexion MySQL au serveur puis execute une requête MySQL (sans retour attendu)
    ''' </summary>
    ''' <param name="SQL_REQUEST">La requête SQL à éxécuter</param>
    ''' <returns>Retourne TRUE si la requête à été exécutée sans erreur sinon FALSE</returns>
    Public Function MySQL_REQUEST_EXEC(ByVal SQL_REQUEST As String) As Boolean
        Dim SQLConnection As MySqlConnection = MySQL_NEW_CONNECTION()
        If SQLConnection Is Nothing Then Return False : Exit Function

        Dim sqlCommand As New MySqlCommand
        Try
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = SQL_REQUEST
            sqlCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
            Console.WriteLine("Requête suivante non exécutée:" & Environment.NewLine & SQL_REQUEST & Environment.NewLine & "Détail de l'exception:" & Environment.NewLine & ex.Message)
        End Try
    End Function


    ''' <summary>
    ''' Vérifie dans la base de donnée si l'email et le mot de passe fournie en argument sont valides
    ''' </summary>
    ''' <param name="Email">L'adresse e-mail de l'utilisateur</param>
    ''' <param name="password">Le mot de passe de l'utilisateur</param>
    ''' <returns>TRUE si l'email ET le MDP de l'utilisateur est valide sinon FALSE</returns>
    Public Function LoginUser(ByVal Email As String, ByVal password As String) As Boolean
        Dim SQLConnection As MySqlConnection = MySQL_NEW_CONNECTION()
        If SQLConnection Is Nothing Then Return False : Exit Function

        Dim sqlCommand As New MySqlCommand

        Try
            'MsgBox(SQL_REQUEST, MsgBoxStyle.Information, "Aperçu de la requête SQL")
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = "SELECT email, password FROM utilisateur WHERE email='" & Email & "' AND password='" & password & "'"
            sqlCommand.ExecuteNonQuery()
            Dim reponse As MySqlDataReader = sqlCommand.ExecuteReader()
            Return reponse.HasRows
        Catch ex As Exception
            Return False
            Console.WriteLine(ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Récupère l'identifiant du client (dans la table user) par rapport à son addresse e-mail
    ''' </summary>
    Public Function GetClientID(ByVal USER_EMAIL As String) As String
        Dim SQLConnection As MySqlConnection = MySQL_NEW_CONNECTION()
        If SQLConnection Is Nothing Then Return False : Exit Function

        Dim sqlCommand As New MySqlCommand

        Try
            'MsgBox(SQL_REQUEST, MsgBoxStyle.Information, "Aperçu de la requête SQL")
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = "SELECT email, id FROM utilisateur WHERE email='" & USER_EMAIL & "'"
            sqlCommand.ExecuteNonQuery()
            Dim reponse As MySqlDataReader = sqlCommand.ExecuteReader()
            If reponse.HasRows = False Then Return Nothing
            Dim user_id As String = Nothing
            While reponse.Read
                user_id = reponse.GetString(1)
            End While
            Return user_id
        Catch ex As Exception
            Return False
            Console.WriteLine(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Récupère toutes les informations sur un client à partir de son e-mail, les places adéquatement dans les propriétées d'un objet 'user' puis retourne l'objet
    ''' </summary>
    ''' <param name="USER_EMAIL">L'adresse e-mail de connexion de l'utilisateur pour lequelle ces informations doivent être récupérées</param>
    ''' <returns>Un objet User sinon Nothing</returns>
    Public Function GetUserInfo(ByVal USER_EMAIL As String) As User
        Dim SQLConnection As MySqlConnection = MySQL_NEW_CONNECTION()
        If SQLConnection Is Nothing Then Return Nothing : Exit Function
        Dim ReturnUser As New User

        Dim sqlCommand As New MySqlCommand

        Try
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = "SELECT id_utilisateur, email, password, is_activ, last_login, phone_number, lastname, firstname FROM utilisateur WHERE email='" & USER_EMAIL & "'"
            sqlCommand.ExecuteNonQuery()
            Dim reponse As MySqlDataReader = sqlCommand.ExecuteReader()
            If reponse.HasRows = False Then Return Nothing
            While reponse.Read
                With ReturnUser
                    .user_id = reponse.GetString(0)
                    .email = reponse.GetString(1)
                    .password = reponse.GetString(2)
                    .is_activ = reponse.GetString(3)
                    .last_login = reponse.GetString(4)
                    .phone_number = reponse.GetString(5)
                    .lastname = reponse.GetString(6)
                    .firstname = reponse.GetString(7)
                End With
            End While
            Return ReturnUser
        Catch ex As Exception
            Console.WriteLine("Des erreurs sont survenues durant la récupération des informations sur l'utilisateur. Détail: " & ex.Message)
            Return ReturnUser
        End Try
    End Function

    ''' <summary>
    ''' Récupère toutes les catégories de tâches préconfigurées disponible dans la base de donnée
    ''' </summary>
    Public Function GetCategories() As List(Of Categorie)
        Dim CatList As New List(Of Categorie)
        Try
            Dim req As String = "SELECT * FROM categorie"
            Dim reponse As MySqlDataReader = MySQL_GetReponse(req)
            If reponse Is Nothing Then Console.WriteLine("[Fonctions] GetCategories() : Impossible d'obtenir la liste des catégories car la réponse à la requête suivante est nulle : " & req) : Return Nothing : Exit Function
            While reponse.Read
                Dim catobj As New Categorie
                catobj.id = reponse.GetString(0)
                catobj.title = reponse.GetString(1)
                catobj.color = reponse.GetString(2)
                catobj.thumbnail = reponse.GetString(3)
                CatList.Add(catobj)
            End While
        Catch ex As Exception
            Return Nothing
            Console.WriteLine(ex.Message)
        End Try
        Return CatList
    End Function

    ''' <summary>
    ''' Met à jour la variable StatutList contenant une liste des status à attribuer à une tâche
    ''' </summary>
    Public Sub UpdateStatus()
        StatutList.Clear()
        Dim Req As String = "SELECT * from status"
        Dim MySQL_REP = MySQL_GetReponse(Req)
        If MySQL_REP Is Nothing Then Console.WriteLine("[Fonctions] UpdateStatus() : La réponse de la requette suivante est nulle : " & Req) : Exit Sub
        While MySQL_REP.Read
            Dim statut As New Statut
            Try
                statut.id = MySQL_REP.GetString(0)
            Catch ex As Exception
                Continue While
            End Try
            Try
                statut.title = MySQL_REP.GetString(1)
            Catch ex As Exception

            End Try
            Try
                statut.slug = MySQL_REP.GetString(2)
            Catch ex As Exception

            End Try
            StatutList.Add(statut)
        End While
    End Sub

#End Region

#Region "Classes de la base de donnée"

    ''' <summary>
    ''' Classe permettant de définir une catégorie de tâche prédéfinie dans la base de donnée
    ''' </summary>
    Public Class Categorie
        ''' <summary>
        ''' L'identifiant uniquement de cette catégorie (permettant de le retrouver dans la table categorie)
        ''' </summary>
        Public id As String = Nothing
        ''' <summary>
        ''' Le titre de la catégorie
        ''' </summary>
        Public title As String = Nothing
        ''' <summary>
        ''' Utilisez un code RGB séparé par des virgules pour cette valeure (ex: 64, 64, 64)
        ''' </summary>
        Public color As String = Nothing
        ''' <summary>
        ''' L'icone de la catégorie. Mettre UNIQUEMENT un lien dans cette propriétée
        ''' </summary>
        Public thumbnail As String = Nothing
    End Class

    ''' <summary>
    ''' Classe représentant un utilisateur (de la table user) de la base de donnée
    ''' </summary>
    Public Class User
        ''' <summary>
        ''' L'Identifiant (Clé primaire auto-incrémentée) de la table de la base de donnée contenant les utilisateurs afin de pouvoir identifier un utilisateur
        ''' </summary>
        Public user_id As String
        ''' <summary>
        ''' L'adresse e-mail de l'utilisateur (utilisé par ce dernier durant le processus de connexion)
        ''' </summary>
        Public email As String
        ''' <summary>
        ''' Le mot de passe en clair de l'utilisateur (utilisé par ce dernier durant le processus de connexion)
        ''' </summary>
        Public password As String
        ''' <summary>
        ''' La dernière adresse IPv4 du client connu durant sa dernière connexion
        ''' </summary>
        Public ip As String
        ''' <summary>
        ''' (Normalement valeure booléane) permettant de spécifier si le compte peut être utilisé ou pas, ou s'il est bloqué ou non
        ''' </summary>
        Public is_activ As String
        ''' <summary>
        ''' (Normalement une date) précisant la dernière fois que l'utilisateur s'est connecté
        ''' </summary>
        Public last_login As String
        ''' <summary>
        ''' Le numéro de téléphone de l'utilisateur
        ''' </summary>
        Public phone_number As String
        ''' <summary>
        ''' Le nom de famille de l'utilisateur
        ''' </summary>
        Public lastname As String
        ''' <summary>
        ''' Le prénom de l'utilisateur
        ''' </summary>
        Public firstname As String
    End Class

    ''' <summary>
    ''' Classe représentant un statut attribuable dans la tâche de la base donnée
    ''' </summary>
    Public Class Statut
        ''' <summary>
        ''' L'ID du statut dans la base de donnée
        ''' </summary>
        Public id As Integer
        ''' <summary>
        ''' Le titre du statut
        ''' </summary>
        Public title As String
        ''' <summary>
        ''' Le titre sans les caractères spéciaux (pour faciliter les recherches)
        ''' </summary>
        Public slug As String
    End Class

    ''' <summary>
    ''' Classe représentant une tâche (table task de la BDD)
    ''' </summary>
    Public Class Task
        Public id As Integer
        ''' <summary>
        ''' L'objet de type date spécifiant la date de création de la tâche
        ''' </summary>
        Public Property created_on As Date
        Public title As String
        Public description As String
        Public subtitle As String
        Public thumbnail As String
        Public Property checked_on As Date
        Public Property remind As Date

        Public user_id As Integer
        Public category_id As Integer
        Public statut_id As Integer

        Sub New()

        End Sub

        Public Sub New(ByVal Title As String, ByVal StatusID As Integer)
            Me.title = Title
            Me.statut_id = StatusID
        End Sub

        ''' <summary>
        ''' Met à jour les propriétée de cette tâche en modifiant les colonnes de la donnée ayant l'ID de la tâche par les valeures adéquat des variables de l'objet.
        ''' </summary>
        ''' <returns>TRUE si l'opération à réussi sinon FALSE</returns>
        Public Function UpdateOnDatabase() As Boolean
            Dim req As String = "UPDATE task SET created_on = '" & DateToStr(created_on) & "', title = '" & title & "', description = '" & description & "', subtitle = '" & subtitle & "', thumbnail='" & thumbnail & "', checked_on='" & DateToStr(checked_on) & "', remind = '" & DateToStr(remind) & "', id_utilisateur = " & user_id & ", id_categorie = " & category_id & ", id_status = " & statut_id & " WHERE id_task = " & id
            Return MySQL_REQUEST_EXEC(req)
        End Function

        ''' <summary>
        ''' Cache la tache dans la base de donnée en spécifiant son statut sur 3 (id_status = 3)
        ''' </summary>
        ''' <returns>TRUE si l'opération a réussi, sinon FALSE</returns>
        Public Function Delete() As Boolean
            'Dim req2 As String = "DELETE FROM task WHERE id_task = " & id
            Dim req As String = "UPDATE task SET id_status = 3 WHERE id_task = " & id
            Return MySQL_REQUEST_EXEC(req)
        End Function

        ''' <summary>
        ''' Définis le statut d'une tâche et met à jour les colonnes dans la base de donnée pour cette tâche
        ''' </summary>
        ''' <param name="Status">Définir sur TRUE pour indiquer que la tâche à été réalisée sinon sur FALSE pour indiquer qu'elle est à faire</param>
        ''' <returns>TRUE si l'opération a réussie sinon FALSE</returns>
        Public Function SetStatut(ByVal Status As Integer) As Boolean
            Dim StatusId As Integer = 0
            StatusId = Status + 1
            Dim req As String = "UPDATE task SET id_status = " & StatusId
            Return MySQL_REQUEST_EXEC(req)
        End Function

    End Class

    Public Class Quizz
        Public id_quizz As Integer
        Public date_start As Date
        Public date_end As Date
        Public reponses_answered As Integer
        Public good_reponse As Integer
        Public prc_reussite As Double

        Sub New()
            date_start = Now
        End Sub

        Public Sub Finish()
            date_end = Now
        End Sub

        Public Function Upload() As Boolean
            Dim req As String = "INSERT INTO quizz (date_start, date_end, reponses_answered, good_reponses, prc_reussite, id_user) VALUES ('" & DateToStr(date_start) & "', '" & DateToStr(date_end) & "', " & reponses_answered & ", " & good_reponse & ", " & prc_reussite & ", " & ConnectedUser.user_id & ")"
            Console.WriteLine(req)
            Return MySQL_REQUEST_EXEC(req)
        End Function

        Public Function GetTimeElapsed() As TimeSpan
            Dim t As TimeSpan = date_end - date_start
            Return t
        End Function
    End Class

#End Region


End Module
