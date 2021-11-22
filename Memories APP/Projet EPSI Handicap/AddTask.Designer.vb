<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddTask
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox_Time = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_GeneralInfo = New System.Windows.Forms.GroupBox()
        Me.CB_Category = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Description = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Title = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_AddTask = New System.Windows.Forms.Button()
        Me.GroupBox_Time.SuspendLayout()
        Me.GroupBox_GeneralInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Time
        '
        Me.GroupBox_Time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Time.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox_Time.Controls.Add(Me.Label1)
        Me.GroupBox_Time.ForeColor = System.Drawing.Color.White
        Me.GroupBox_Time.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox_Time.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Time.Name = "GroupBox_Time"
        Me.GroupBox_Time.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Time.Size = New System.Drawing.Size(581, 58)
        Me.GroupBox_Time.TabIndex = 0
        Me.GroupBox_Time.TabStop = False
        Me.GroupBox_Time.Text = "Planification"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(212, 21)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(349, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rappel le:"
        '
        'GroupBox_GeneralInfo
        '
        Me.GroupBox_GeneralInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.CB_Category)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.Label4)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.TB_Description)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.Label3)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.TB_Title)
        Me.GroupBox_GeneralInfo.Controls.Add(Me.Label2)
        Me.GroupBox_GeneralInfo.ForeColor = System.Drawing.Color.White
        Me.GroupBox_GeneralInfo.Location = New System.Drawing.Point(10, 74)
        Me.GroupBox_GeneralInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_GeneralInfo.Name = "GroupBox_GeneralInfo"
        Me.GroupBox_GeneralInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_GeneralInfo.Size = New System.Drawing.Size(581, 166)
        Me.GroupBox_GeneralInfo.TabIndex = 1
        Me.GroupBox_GeneralInfo.TabStop = False
        Me.GroupBox_GeneralInfo.Text = "Informations générales"
        '
        'CB_Category
        '
        Me.CB_Category.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Category.FormattingEnabled = True
        Me.CB_Category.Location = New System.Drawing.Point(212, 129)
        Me.CB_Category.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_Category.Name = "CB_Category"
        Me.CB_Category.Size = New System.Drawing.Size(349, 21)
        Me.CB_Category.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Catégorie:"
        '
        'TB_Description
        '
        Me.TB_Description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Description.ForeColor = System.Drawing.Color.White
        Me.TB_Description.Location = New System.Drawing.Point(212, 50)
        Me.TB_Description.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_Description.Multiline = True
        Me.TB_Description.Name = "TB_Description"
        Me.TB_Description.Size = New System.Drawing.Size(349, 76)
        Me.TB_Description.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'TB_Title
        '
        Me.TB_Title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Title.ForeColor = System.Drawing.Color.White
        Me.TB_Title.Location = New System.Drawing.Point(212, 27)
        Me.TB_Title.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_Title.Name = "TB_Title"
        Me.TB_Title.Size = New System.Drawing.Size(349, 20)
        Me.TB_Title.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom de la tâche:"
        '
        'BTN_AddTask
        '
        Me.BTN_AddTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AddTask.Location = New System.Drawing.Point(489, 247)
        Me.BTN_AddTask.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AddTask.Name = "BTN_AddTask"
        Me.BTN_AddTask.Size = New System.Drawing.Size(102, 40)
        Me.BTN_AddTask.TabIndex = 2
        Me.BTN_AddTask.Text = "Ajouter"
        Me.BTN_AddTask.UseVisualStyleBackColor = True
        '
        'AddTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.BTN_AddTask)
        Me.Controls.Add(Me.GroupBox_GeneralInfo)
        Me.Controls.Add(Me.GroupBox_Time)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter une tâche"
        Me.GroupBox_Time.ResumeLayout(False)
        Me.GroupBox_Time.PerformLayout()
        Me.GroupBox_GeneralInfo.ResumeLayout(False)
        Me.GroupBox_GeneralInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Time As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_GeneralInfo As GroupBox
    Friend WithEvents CB_Category As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Description As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Title As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_AddTask As Button
End Class
