Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data

Public Class Register
    Private Sub BTN_Back_Click(sender As Object, e As EventArgs) Handles BTN_Back.Click
        Me.Close()
    End Sub

    Private Sub BTN_Submit_Click(sender As Object, e As EventArgs) Handles BTN_Submit.Click
        Dim todaystr = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
        Dim str_SqlRequest As String = "insert into utilisateur (email, password, phone_number, lastname, firstname, is_activ, last_login) values ('" + TB_Email.Text + "','" + TB_Password.Text + "','" + TB_Telephone.Text + "','" + TB_Lastname.Text.ToUpper + "','" + TB_Firstname.Text + "',1,'" + todaystr + "')"
        If MySQL_REQUEST_EXEC(str_SqlRequest) = True Then
            MsgBox("Inscription réussie !", vbInformation)
            Me.Close()
        Else
            MsgBox("Impossible de communiquer avec la base de donnée", vbCritical, "Inscription impossible")
        End If
    End Sub

    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()

    End Sub

#Region "MySQL"

    Private Sub TB_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTN_Submit.PerformClick()
        End If
    End Sub
#End Region
End Class