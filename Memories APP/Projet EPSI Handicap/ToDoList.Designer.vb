<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDoList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDoList))
        Me.PanelTaskInfo = New System.Windows.Forms.Panel()
        Me.GroupBox_TaskState = New System.Windows.Forms.GroupBox()
        Me.LBL_TaskCheckedOn = New System.Windows.Forms.Label()
        Me.CBB_Statut = New System.Windows.Forms.ComboBox()
        Me.GroupBox_TaskPlanification = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Remind = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBL_CreatedAt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox_TaskInfo = New System.Windows.Forms.GroupBox()
        Me.CBB_Category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Description = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Subtitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Title = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BTN_NewTask = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PanelTaskInfo.SuspendLayout()
        Me.GroupBox_TaskState.SuspendLayout()
        Me.GroupBox_TaskPlanification.SuspendLayout()
        Me.GroupBox_TaskInfo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTaskInfo
        '
        Me.PanelTaskInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTaskInfo.AutoScroll = True
        Me.PanelTaskInfo.Controls.Add(Me.GroupBox_TaskState)
        Me.PanelTaskInfo.Controls.Add(Me.GroupBox_TaskPlanification)
        Me.PanelTaskInfo.Controls.Add(Me.GroupBox_TaskInfo)
        Me.PanelTaskInfo.Location = New System.Drawing.Point(306, 55)
        Me.PanelTaskInfo.Name = "PanelTaskInfo"
        Me.PanelTaskInfo.Size = New System.Drawing.Size(378, 498)
        Me.PanelTaskInfo.TabIndex = 1
        Me.PanelTaskInfo.Visible = False
        '
        'GroupBox_TaskState
        '
        Me.GroupBox_TaskState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_TaskState.Controls.Add(Me.LBL_TaskCheckedOn)
        Me.GroupBox_TaskState.Controls.Add(Me.CBB_Statut)
        Me.GroupBox_TaskState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.GroupBox_TaskState.Location = New System.Drawing.Point(10, 411)
        Me.GroupBox_TaskState.Name = "GroupBox_TaskState"
        Me.GroupBox_TaskState.Size = New System.Drawing.Size(359, 79)
        Me.GroupBox_TaskState.TabIndex = 2
        Me.GroupBox_TaskState.TabStop = False
        Me.GroupBox_TaskState.Text = "Statut"
        '
        'LBL_TaskCheckedOn
        '
        Me.LBL_TaskCheckedOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_TaskCheckedOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBL_TaskCheckedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TaskCheckedOn.ForeColor = System.Drawing.Color.Black
        Me.LBL_TaskCheckedOn.Location = New System.Drawing.Point(8, 46)
        Me.LBL_TaskCheckedOn.Name = "LBL_TaskCheckedOn"
        Me.LBL_TaskCheckedOn.Size = New System.Drawing.Size(343, 27)
        Me.LBL_TaskCheckedOn.TabIndex = 3
        Me.LBL_TaskCheckedOn.Text = "Terminé le 00/00/0000 00:00:00"
        Me.LBL_TaskCheckedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBB_Statut
        '
        Me.CBB_Statut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBB_Statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBB_Statut.FormattingEnabled = True
        Me.CBB_Statut.Location = New System.Drawing.Point(8, 20)
        Me.CBB_Statut.Name = "CBB_Statut"
        Me.CBB_Statut.Size = New System.Drawing.Size(343, 21)
        Me.CBB_Statut.TabIndex = 0
        '
        'GroupBox_TaskPlanification
        '
        Me.GroupBox_TaskPlanification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_TaskPlanification.Controls.Add(Me.DateTimePicker_Remind)
        Me.GroupBox_TaskPlanification.Controls.Add(Me.Label5)
        Me.GroupBox_TaskPlanification.Controls.Add(Me.LBL_CreatedAt)
        Me.GroupBox_TaskPlanification.Controls.Add(Me.Label4)
        Me.GroupBox_TaskPlanification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.GroupBox_TaskPlanification.Location = New System.Drawing.Point(10, 324)
        Me.GroupBox_TaskPlanification.Name = "GroupBox_TaskPlanification"
        Me.GroupBox_TaskPlanification.Size = New System.Drawing.Size(359, 69)
        Me.GroupBox_TaskPlanification.TabIndex = 1
        Me.GroupBox_TaskPlanification.TabStop = False
        Me.GroupBox_TaskPlanification.Text = "Planification"
        '
        'DateTimePicker_Remind
        '
        Me.DateTimePicker_Remind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_Remind.Location = New System.Drawing.Point(123, 39)
        Me.DateTimePicker_Remind.Name = "DateTimePicker_Remind"
        Me.DateTimePicker_Remind.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker_Remind.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Rappel le:"
        '
        'LBL_CreatedAt
        '
        Me.LBL_CreatedAt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_CreatedAt.ForeColor = System.Drawing.Color.White
        Me.LBL_CreatedAt.Location = New System.Drawing.Point(120, 19)
        Me.LBL_CreatedAt.Name = "LBL_CreatedAt"
        Me.LBL_CreatedAt.Size = New System.Drawing.Size(233, 13)
        Me.LBL_CreatedAt.TabIndex = 2
        Me.LBL_CreatedAt.Text = "00/00/0000 00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Créer le:"
        '
        'GroupBox_TaskInfo
        '
        Me.GroupBox_TaskInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_TaskInfo.Controls.Add(Me.CBB_Category)
        Me.GroupBox_TaskInfo.Controls.Add(Me.Label6)
        Me.GroupBox_TaskInfo.Controls.Add(Me.TB_Description)
        Me.GroupBox_TaskInfo.Controls.Add(Me.Label3)
        Me.GroupBox_TaskInfo.Controls.Add(Me.TB_Subtitle)
        Me.GroupBox_TaskInfo.Controls.Add(Me.Label2)
        Me.GroupBox_TaskInfo.Controls.Add(Me.TB_Title)
        Me.GroupBox_TaskInfo.Controls.Add(Me.Label1)
        Me.GroupBox_TaskInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.GroupBox_TaskInfo.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox_TaskInfo.Name = "GroupBox_TaskInfo"
        Me.GroupBox_TaskInfo.Size = New System.Drawing.Size(359, 303)
        Me.GroupBox_TaskInfo.TabIndex = 0
        Me.GroupBox_TaskInfo.TabStop = False
        Me.GroupBox_TaskInfo.Text = "Information sur la tâche"
        '
        'CBB_Category
        '
        Me.CBB_Category.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBB_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBB_Category.FormattingEnabled = True
        Me.CBB_Category.Location = New System.Drawing.Point(10, 116)
        Me.CBB_Category.Name = "CBB_Category"
        Me.CBB_Category.Size = New System.Drawing.Size(343, 21)
        Me.CBB_Category.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Catégorie:"
        '
        'TB_Description
        '
        Me.TB_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Description.ForeColor = System.Drawing.Color.White
        Me.TB_Description.Location = New System.Drawing.Point(10, 161)
        Me.TB_Description.Multiline = True
        Me.TB_Description.Name = "TB_Description"
        Me.TB_Description.Size = New System.Drawing.Size(343, 132)
        Me.TB_Description.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description:"
        '
        'TB_Subtitle
        '
        Me.TB_Subtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Subtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Subtitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Subtitle.ForeColor = System.Drawing.Color.White
        Me.TB_Subtitle.Location = New System.Drawing.Point(10, 77)
        Me.TB_Subtitle.Name = "TB_Subtitle"
        Me.TB_Subtitle.Size = New System.Drawing.Size(343, 13)
        Me.TB_Subtitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sous-titre:"
        '
        'TB_Title
        '
        Me.TB_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Title.ForeColor = System.Drawing.Color.White
        Me.TB_Title.Location = New System.Drawing.Point(10, 37)
        Me.TB_Title.Name = "TB_Title"
        Me.TB_Title.Size = New System.Drawing.Size(343, 13)
        Me.TB_Title.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom de la tâche:"
        '
        'BTN_Delete
        '
        Me.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_Delete.FlatAppearance.BorderSize = 0
        Me.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Delete.ImageIndex = 2
        Me.BTN_Delete.ImageList = Me.ImageList1
        Me.BTN_Delete.Location = New System.Drawing.Point(149, 7)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(131, 42)
        Me.BTN_Delete.TabIndex = 4
        Me.BTN_Delete.Text = "Supprimer"
        Me.BTN_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Delete.UseVisualStyleBackColor = False
        '
        'BTN_Save
        '
        Me.BTN_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BTN_Save.FlatAppearance.BorderSize = 0
        Me.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Save.ImageIndex = 1
        Me.BTN_Save.ImageList = Me.ImageList1
        Me.BTN_Save.Location = New System.Drawing.Point(12, 7)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(131, 42)
        Me.BTN_Save.TabIndex = 3
        Me.BTN_Save.Text = "Enregistrer"
        Me.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Save.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BTN_Delete)
        Me.PanelMenu.Controls.Add(Me.BTN_NewTask)
        Me.PanelMenu.Controls.Add(Me.BTN_Save)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(691, 57)
        Me.PanelMenu.TabIndex = 2
        '
        'BTN_NewTask
        '
        Me.BTN_NewTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_NewTask.FlatAppearance.BorderSize = 0
        Me.BTN_NewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NewTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NewTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_NewTask.ImageIndex = 0
        Me.BTN_NewTask.ImageList = Me.ImageList1
        Me.BTN_NewTask.Location = New System.Drawing.Point(517, 7)
        Me.BTN_NewTask.Name = "BTN_NewTask"
        Me.BTN_NewTask.Size = New System.Drawing.Size(158, 42)
        Me.BTN_NewTask.TabIndex = 0
        Me.BTN_NewTask.Text = "Nouvelle tâche"
        Me.BTN_NewTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_NewTask.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "floppy-disk.png")
        Me.ImageList1.Images.SetKeyName(2, "delete.png")
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(3, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 490)
        Me.ListBox1.TabIndex = 3
        '
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 557)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTaskInfo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ToDoList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des choses à faire"
        Me.PanelTaskInfo.ResumeLayout(False)
        Me.GroupBox_TaskState.ResumeLayout(False)
        Me.GroupBox_TaskPlanification.ResumeLayout(False)
        Me.GroupBox_TaskPlanification.PerformLayout()
        Me.GroupBox_TaskInfo.ResumeLayout(False)
        Me.GroupBox_TaskInfo.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTaskInfo As Panel
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents BTN_Save As Button
    Friend WithEvents GroupBox_TaskState As GroupBox
    Friend WithEvents LBL_TaskCheckedOn As Label
    Friend WithEvents CBB_Statut As ComboBox
    Friend WithEvents GroupBox_TaskPlanification As GroupBox
    Friend WithEvents DateTimePicker_Remind As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_CreatedAt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox_TaskInfo As GroupBox
    Friend WithEvents TB_Description As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Subtitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Title As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBB_Category As ComboBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BTN_NewTask As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ImageList1 As ImageList
End Class
