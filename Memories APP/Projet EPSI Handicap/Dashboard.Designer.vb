<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BTN_Logout = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LBL_User_Prenom = New System.Windows.Forms.Label()
        Me.LBL_Slogan = New System.Windows.Forms.Label()
        Me.LBL_User_Nom = New System.Windows.Forms.Label()
        Me.PictureBox_UserPictureProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        Me.BTN_MENU_Questionnaire = New System.Windows.Forms.Button()
        Me.BTN_MENU_ShowTasks = New System.Windows.Forms.Button()
        Me.BTN_MENU_Settings = New System.Windows.Forms.Button()
        Me.BTN_MENU_Stats = New System.Windows.Forms.Button()
        Me.Panel_Navbar = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox_UserPictureProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Navbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BTN_Logout)
        Me.PanelMenu.Controls.Add(Me.LBL_User_Prenom)
        Me.PanelMenu.Controls.Add(Me.LBL_Slogan)
        Me.PanelMenu.Controls.Add(Me.LBL_User_Nom)
        Me.PanelMenu.Controls.Add(Me.PictureBox_UserPictureProfile)
        Me.PanelMenu.Controls.Add(Me.PictureBox_Logo)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(884, 128)
        Me.PanelMenu.TabIndex = 0
        '
        'BTN_Logout
        '
        Me.BTN_Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BTN_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Logout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Logout.ImageIndex = 4
        Me.BTN_Logout.ImageList = Me.ImageList1
        Me.BTN_Logout.Location = New System.Drawing.Point(635, 74)
        Me.BTN_Logout.Name = "BTN_Logout"
        Me.BTN_Logout.Size = New System.Drawing.Size(135, 38)
        Me.BTN_Logout.TabIndex = 4
        Me.BTN_Logout.Text = "Déconnexion"
        Me.BTN_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Logout.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "004-settings.png")
        Me.ImageList1.Images.SetKeyName(1, "checklist (2).png")
        Me.ImageList1.Images.SetKeyName(2, "checklist.png")
        Me.ImageList1.Images.SetKeyName(3, "bar-chart.png")
        Me.ImageList1.Images.SetKeyName(4, "logout.png")
        '
        'LBL_User_Prenom
        '
        Me.LBL_User_Prenom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_User_Prenom.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_User_Prenom.Location = New System.Drawing.Point(438, 46)
        Me.LBL_User_Prenom.Name = "LBL_User_Prenom"
        Me.LBL_User_Prenom.Size = New System.Drawing.Size(332, 25)
        Me.LBL_User_Prenom.TabIndex = 3
        Me.LBL_User_Prenom.Text = "Prénom"
        Me.LBL_User_Prenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBL_Slogan
        '
        Me.LBL_Slogan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_Slogan.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Slogan.Location = New System.Drawing.Point(118, 16)
        Me.LBL_Slogan.Name = "LBL_Slogan"
        Me.LBL_Slogan.Size = New System.Drawing.Size(247, 96)
        Me.LBL_Slogan.TabIndex = 2
        Me.LBL_Slogan.Text = "Mémorises tes tâches"
        Me.LBL_Slogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_User_Nom
        '
        Me.LBL_User_Nom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_User_Nom.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_User_Nom.Location = New System.Drawing.Point(438, 16)
        Me.LBL_User_Nom.Name = "LBL_User_Nom"
        Me.LBL_User_Nom.Size = New System.Drawing.Size(332, 25)
        Me.LBL_User_Nom.TabIndex = 1
        Me.LBL_User_Nom.Text = "NOM"
        Me.LBL_User_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox_UserPictureProfile
        '
        Me.PictureBox_UserPictureProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_UserPictureProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_UserPictureProfile.Image = CType(resources.GetObject("PictureBox_UserPictureProfile.Image"), System.Drawing.Image)
        Me.PictureBox_UserPictureProfile.Location = New System.Drawing.Point(776, 16)
        Me.PictureBox_UserPictureProfile.Name = "PictureBox_UserPictureProfile"
        Me.PictureBox_UserPictureProfile.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox_UserPictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_UserPictureProfile.TabIndex = 1
        Me.PictureBox_UserPictureProfile.TabStop = False
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Logo.Image = CType(resources.GetObject("PictureBox_Logo.Image"), System.Drawing.Image)
        Me.PictureBox_Logo.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Logo.TabIndex = 0
        Me.PictureBox_Logo.TabStop = False
        '
        'BTN_MENU_Questionnaire
        '
        Me.BTN_MENU_Questionnaire.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_MENU_Questionnaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Questionnaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Questionnaire.FlatAppearance.BorderSize = 2
        Me.BTN_MENU_Questionnaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_MENU_Questionnaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BTN_MENU_Questionnaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MENU_Questionnaire.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MENU_Questionnaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_MENU_Questionnaire.ImageIndex = 1
        Me.BTN_MENU_Questionnaire.ImageList = Me.ImageList1
        Me.BTN_MENU_Questionnaire.Location = New System.Drawing.Point(257, 5)
        Me.BTN_MENU_Questionnaire.Name = "BTN_MENU_Questionnaire"
        Me.BTN_MENU_Questionnaire.Size = New System.Drawing.Size(108, 38)
        Me.BTN_MENU_Questionnaire.TabIndex = 4
        Me.BTN_MENU_Questionnaire.Text = "Quizz"
        Me.BTN_MENU_Questionnaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MENU_Questionnaire.UseVisualStyleBackColor = False
        '
        'BTN_MENU_ShowTasks
        '
        Me.BTN_MENU_ShowTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_MENU_ShowTasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_ShowTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_ShowTasks.FlatAppearance.BorderSize = 2
        Me.BTN_MENU_ShowTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_MENU_ShowTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BTN_MENU_ShowTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MENU_ShowTasks.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MENU_ShowTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_MENU_ShowTasks.ImageIndex = 2
        Me.BTN_MENU_ShowTasks.ImageList = Me.ImageList1
        Me.BTN_MENU_ShowTasks.Location = New System.Drawing.Point(131, 5)
        Me.BTN_MENU_ShowTasks.Name = "BTN_MENU_ShowTasks"
        Me.BTN_MENU_ShowTasks.Size = New System.Drawing.Size(120, 38)
        Me.BTN_MENU_ShowTasks.TabIndex = 3
        Me.BTN_MENU_ShowTasks.Text = "Tâches"
        Me.BTN_MENU_ShowTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MENU_ShowTasks.UseVisualStyleBackColor = False
        '
        'BTN_MENU_Settings
        '
        Me.BTN_MENU_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_MENU_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Settings.FlatAppearance.BorderSize = 2
        Me.BTN_MENU_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_MENU_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BTN_MENU_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MENU_Settings.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MENU_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_MENU_Settings.ImageIndex = 0
        Me.BTN_MENU_Settings.ImageList = Me.ImageList1
        Me.BTN_MENU_Settings.Location = New System.Drawing.Point(609, 5)
        Me.BTN_MENU_Settings.Name = "BTN_MENU_Settings"
        Me.BTN_MENU_Settings.Size = New System.Drawing.Size(166, 38)
        Me.BTN_MENU_Settings.TabIndex = 2
        Me.BTN_MENU_Settings.Text = "Paramètres"
        Me.BTN_MENU_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MENU_Settings.UseVisualStyleBackColor = False
        '
        'BTN_MENU_Stats
        '
        Me.BTN_MENU_Stats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_MENU_Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Stats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_MENU_Stats.FlatAppearance.BorderSize = 2
        Me.BTN_MENU_Stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_MENU_Stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BTN_MENU_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MENU_Stats.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MENU_Stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_MENU_Stats.ImageIndex = 3
        Me.BTN_MENU_Stats.ImageList = Me.ImageList1
        Me.BTN_MENU_Stats.Location = New System.Drawing.Point(438, 5)
        Me.BTN_MENU_Stats.Name = "BTN_MENU_Stats"
        Me.BTN_MENU_Stats.Size = New System.Drawing.Size(165, 38)
        Me.BTN_MENU_Stats.TabIndex = 1
        Me.BTN_MENU_Stats.Text = "Statistiques"
        Me.BTN_MENU_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MENU_Stats.UseVisualStyleBackColor = False
        '
        'Panel_Navbar
        '
        Me.Panel_Navbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Navbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel_Navbar.Controls.Add(Me.BTN_MENU_Questionnaire)
        Me.Panel_Navbar.Controls.Add(Me.BTN_MENU_ShowTasks)
        Me.Panel_Navbar.Controls.Add(Me.BTN_MENU_Settings)
        Me.Panel_Navbar.Controls.Add(Me.BTN_MENU_Stats)
        Me.Panel_Navbar.Location = New System.Drawing.Point(0, 127)
        Me.Panel_Navbar.Name = "Panel_Navbar"
        Me.Panel_Navbar.Size = New System.Drawing.Size(884, 48)
        Me.Panel_Navbar.TabIndex = 5
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.Location = New System.Drawing.Point(0, 174)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(884, 405)
        Me.MainPanel.TabIndex = 6
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 579)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel_Navbar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox_UserPictureProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Navbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BTN_MENU_Stats As Button
    Friend WithEvents BTN_MENU_Settings As Button
    Friend WithEvents BTN_MENU_Questionnaire As Button
    Friend WithEvents BTN_MENU_ShowTasks As Button
    Friend WithEvents LBL_User_Nom As Label
    Friend WithEvents PictureBox_UserPictureProfile As PictureBox
    Friend WithEvents PictureBox_Logo As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LBL_Slogan As Label
    Friend WithEvents Panel_Navbar As Panel
    Friend WithEvents BTN_Logout As Button
    Friend WithEvents LBL_User_Prenom As Label
    Friend WithEvents MainPanel As Panel
End Class
