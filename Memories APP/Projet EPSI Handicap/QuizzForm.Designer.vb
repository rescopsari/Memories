<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizzForm
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LBL_Question = New System.Windows.Forms.Label()
        Me.BTN_Rep1 = New System.Windows.Forms.Button()
        Me.BTN_Rep2 = New System.Windows.Forms.Button()
        Me.BTN_Rep3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_AskedQuestions = New System.Windows.Forms.Label()
        Me.LBL_GoodReponses = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_BadReponses = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_PourcentageReussite = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LBL_PourcentageReussite)
        Me.PanelTop.Controls.Add(Me.Label7)
        Me.PanelTop.Controls.Add(Me.LBL_BadReponses)
        Me.PanelTop.Controls.Add(Me.Label6)
        Me.PanelTop.Controls.Add(Me.LBL_GoodReponses)
        Me.PanelTop.Controls.Add(Me.Label4)
        Me.PanelTop.Controls.Add(Me.LBL_AskedQuestions)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 98)
        Me.PanelTop.TabIndex = 0
        '
        'LBL_Question
        '
        Me.LBL_Question.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_Question.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Question.ForeColor = System.Drawing.Color.White
        Me.LBL_Question.Location = New System.Drawing.Point(13, 104)
        Me.LBL_Question.Name = "LBL_Question"
        Me.LBL_Question.Size = New System.Drawing.Size(775, 80)
        Me.LBL_Question.TabIndex = 1
        Me.LBL_Question.Text = "<Question>"
        Me.LBL_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_Rep1
        '
        Me.BTN_Rep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Rep1.ForeColor = System.Drawing.Color.White
        Me.BTN_Rep1.Location = New System.Drawing.Point(10, 3)
        Me.BTN_Rep1.Name = "BTN_Rep1"
        Me.BTN_Rep1.Size = New System.Drawing.Size(214, 65)
        Me.BTN_Rep1.TabIndex = 2
        Me.BTN_Rep1.Text = "Réponse 1"
        Me.BTN_Rep1.UseVisualStyleBackColor = True
        '
        'BTN_Rep2
        '
        Me.BTN_Rep2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTN_Rep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Rep2.ForeColor = System.Drawing.Color.White
        Me.BTN_Rep2.Location = New System.Drawing.Point(272, 3)
        Me.BTN_Rep2.Name = "BTN_Rep2"
        Me.BTN_Rep2.Size = New System.Drawing.Size(214, 65)
        Me.BTN_Rep2.TabIndex = 3
        Me.BTN_Rep2.Text = "Réponse 2"
        Me.BTN_Rep2.UseVisualStyleBackColor = True
        '
        'BTN_Rep3
        '
        Me.BTN_Rep3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Rep3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Rep3.ForeColor = System.Drawing.Color.White
        Me.BTN_Rep3.Location = New System.Drawing.Point(534, 3)
        Me.BTN_Rep3.Name = "BTN_Rep3"
        Me.BTN_Rep3.Size = New System.Drawing.Size(214, 65)
        Me.BTN_Rep3.TabIndex = 4
        Me.BTN_Rep3.Text = "Réponse 3"
        Me.BTN_Rep3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de question posées:"
        '
        'LBL_AskedQuestions
        '
        Me.LBL_AskedQuestions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_AskedQuestions.AutoSize = True
        Me.LBL_AskedQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AskedQuestions.Location = New System.Drawing.Point(192, 13)
        Me.LBL_AskedQuestions.Name = "LBL_AskedQuestions"
        Me.LBL_AskedQuestions.Size = New System.Drawing.Size(16, 16)
        Me.LBL_AskedQuestions.TabIndex = 1
        Me.LBL_AskedQuestions.Text = "0"
        '
        'LBL_GoodReponses
        '
        Me.LBL_GoodReponses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_GoodReponses.AutoSize = True
        Me.LBL_GoodReponses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GoodReponses.Location = New System.Drawing.Point(192, 38)
        Me.LBL_GoodReponses.Name = "LBL_GoodReponses"
        Me.LBL_GoodReponses.Size = New System.Drawing.Size(16, 16)
        Me.LBL_GoodReponses.TabIndex = 3
        Me.LBL_GoodReponses.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre de bonne réponses:"
        '
        'LBL_BadReponses
        '
        Me.LBL_BadReponses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_BadReponses.AutoSize = True
        Me.LBL_BadReponses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BadReponses.Location = New System.Drawing.Point(192, 64)
        Me.LBL_BadReponses.Name = "LBL_BadReponses"
        Me.LBL_BadReponses.Size = New System.Drawing.Size(16, 16)
        Me.LBL_BadReponses.TabIndex = 5
        Me.LBL_BadReponses.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nombre de mauvaise réponses:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(517, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pourcentage de réussite:"
        '
        'LBL_PourcentageReussite
        '
        Me.LBL_PourcentageReussite.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_PourcentageReussite.AutoSize = True
        Me.LBL_PourcentageReussite.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PourcentageReussite.Location = New System.Drawing.Point(663, 31)
        Me.LBL_PourcentageReussite.Name = "LBL_PourcentageReussite"
        Me.LBL_PourcentageReussite.Size = New System.Drawing.Size(30, 31)
        Me.LBL_PourcentageReussite.TabIndex = 7
        Me.LBL_PourcentageReussite.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.BTN_Rep1)
        Me.Panel1.Controls.Add(Me.BTN_Rep3)
        Me.Panel1.Controls.Add(Me.BTN_Rep2)
        Me.Panel1.Location = New System.Drawing.Point(32, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 71)
        Me.Panel1.TabIndex = 5
        '
        'QuizzForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 267)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBL_Question)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "QuizzForm"
        Me.Text = "Quizz"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents LBL_Question As Label
    Friend WithEvents BTN_Rep1 As Button
    Friend WithEvents BTN_Rep2 As Button
    Friend WithEvents BTN_Rep3 As Button
    Friend WithEvents LBL_PourcentageReussite As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_BadReponses As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBL_GoodReponses As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_AskedQuestions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
