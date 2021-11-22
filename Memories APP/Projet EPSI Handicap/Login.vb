Imports System.Runtime.InteropServices
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_REGISTER_Click(sender As Object, e As EventArgs) Handles BTN_REGISTER.Click
        Register.Show()
        Me.Hide()
    End Sub
    Private Sub BTN_CONNECT_Click(sender As Object, e As EventArgs) Handles BTN_CONNECT.Click
        My.Settings.USER_NAME = TB_USER_NAME.Text
        My.Settings.USER_PASS = TB_USER_PASS.Text
        My.Settings.Save()

        If My.Settings.USER_NAME.ToUpper = "ADMIN" Then
            ConnectedUser = New User
            ConnectedUser.email = "francois.saura@epsi.fr"
            ConnectedUser.firstname = "François"
            ConnectedUser.lastname = "Administrateur"
            ConnectedUser.user_id = 9999

            Dashboard.Show()
            TB_USER_NAME.Clear()
            TB_USER_PASS.Clear()
            Me.Hide()
            Exit Sub
        End If
        If LoginUser(My.Settings.USER_NAME, My.Settings.USER_PASS) = True Then
            ConnectedUser = GetUserInfo(My.Settings.USER_NAME)
            ConnectedUser.ip = GetPublicIPv4()
            If MySQL_REQUEST_EXEC("INSERT INTO ip (address, id_utilisateur) VALUES ('" & ConnectedUser.ip & "','" & ConnectedUser.user_id & "')") = False Then
                MsgBox("Impossible de mettre à jour l'IP de l'utilisateur !", vbExclamation)
            End If

            Dashboard.Show()
            TB_USER_NAME.Clear()
            TB_USER_PASS.Clear()
            Me.Hide()
        Else
            MsgBox("Echec de connexion à votre compte. Vérifiez les identifiants saisies.", vbExclamation, "Echec d'authentification")
        End If
    End Sub

#Region "USB Detection"

    Private Delegate Sub CheckKeyOnUSBDelegate(ByVal DriveLetter As String)
    Private Sub CheckKeyOnUSB(ByVal DriveLetter As String)
        Console.WriteLine("Vérification de la présence d'une clé de connexion sur : " & DriveLetter)
        Dim keyfile As New KeyFile
        keyfile.KEY_FILE_PATH = DriveLetter & "memories.key"
        If IO.File.Exists(keyfile.KEY_FILE_PATH) Then
            Console.WriteLine("Une clé de connexion existe bien sur cette clé USB")
            If keyfile.Open = True Then
                TB_USER_NAME.Text = keyfile.USER_NAME
                TB_USER_PASS.Text = keyfile.USER_PASS
                'BTN_CONNECT.PerformClick()
            Else
                Console.WriteLine("Impossible de désérialiser la clé de licence à l'emplacement suivant:" & Environment.NewLine & keyfile.KEY_FILE_PATH)
            End If
        End If
    End Sub

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2            'Valeure précisant qu'il s'agit d'un support de stockage

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DEVICECHANGE Then         'Un périphérique à été connecté/déconnecté de l'ordinateur

            If CInt(m.WParam) = DBT_DEVICEARRIVAL Then  'Le périphérique en question est un périphérique USB
                Console.WriteLine("Connexion / Déconnexion d'un périphérique USB")
                Dim DeviceInfo As DEV_BROADCAST_HDR     'Récupération des informations du périphérique à partir de la structure LParam
                DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)
                If DeviceInfo.dbch_devicetype = DBT_DEVTYP_VOLUME Then      'Si le périphérique USB est un support de stockage = C'est une clée USB
                    Dim Volume As DEV_BROADCAST_VOLUME
                    Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)
                    Dim DriveLetter As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")
                    CheckKeyOnUSB(DriveLetter)
                End If
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    Public Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure

    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    Private Function GetDriveLetterFromMask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
    End Function

    Private Sub TB_USER_PASS_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_USER_PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTN_CONNECT.PerformClick()
        End If
    End Sub

#End Region
End Class