Public Class CreateLoginUSB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kf As New KeyFile
        kf.KEY_FILE_PATH = TextBox1.Text & "memories.key"
        kf.USER_NAME = My.Settings.USER_NAME
        kf.USER_PASS = My.Settings.USER_PASS
        If kf.Save() = True Then
            MsgBox("La clé de connexion à été créer avec succès !" & Environment.NewLine & "Tant qu'elle est insérer dans l'ordinateur, vous pourrez l'utiliser pour vous connecter automatiquement.", vbInformation, "Assistant de création de clé de connexion")
            Me.Close()
        Else
            MsgBox("La clé de connexion n'a pas pu être enregistrée !", vbCritical, "Assistant de création de clé de connexion")
        End If
    End Sub

    Private Sub CreateLoginUSB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class