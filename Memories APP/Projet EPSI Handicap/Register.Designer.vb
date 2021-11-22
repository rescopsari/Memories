<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_Lastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Firstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_Telephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_Submit = New System.Windows.Forms.Button()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TB_Lastname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_Firstname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(262, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité"
        '
        'TB_Lastname
        '
        Me.TB_Lastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Lastname.ForeColor = System.Drawing.Color.White
        Me.TB_Lastname.Location = New System.Drawing.Point(75, 40)
        Me.TB_Lastname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_Lastname.Name = "TB_Lastname"
        Me.TB_Lastname.Size = New System.Drawing.Size(167, 20)
        Me.TB_Lastname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom:"
        '
        'TB_Firstname
        '
        Me.TB_Firstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Firstname.ForeColor = System.Drawing.Color.White
        Me.TB_Firstname.Location = New System.Drawing.Point(75, 17)
        Me.TB_Firstname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_Firstname.Name = "TB_Firstname"
        Me.TB_Firstname.Size = New System.Drawing.Size(167, 20)
        Me.TB_Firstname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prénom:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TB_Telephone)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_Email)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 93)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(262, 73)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact"
        '
        'TB_Telephone
        '
        Me.TB_Telephone.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Telephone.ForeColor = System.Drawing.Color.White
        Me.TB_Telephone.Location = New System.Drawing.Point(75, 40)
        Me.TB_Telephone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_Telephone.Name = "TB_Telephone"
        Me.TB_Telephone.Size = New System.Drawing.Size(167, 20)
        Me.TB_Telephone.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tél:"
        '
        'TB_Email
        '
        Me.TB_Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Email.ForeColor = System.Drawing.Color.White
        Me.TB_Email.Location = New System.Drawing.Point(75, 17)
        Me.TB_Email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(167, 20)
        Me.TB_Email.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TB_Password)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(10, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(262, 48)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mot de passe"
        '
        'TB_Password
        '
        Me.TB_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_Password.ForeColor = System.Drawing.Color.White
        Me.TB_Password.Location = New System.Drawing.Point(75, 17)
        Me.TB_Password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(167, 20)
        Me.TB_Password.TabIndex = 1
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "MDP:"
        '
        'BTN_Submit
        '
        Me.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Submit.Location = New System.Drawing.Point(174, 232)
        Me.BTN_Submit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_Submit.Name = "BTN_Submit"
        Me.BTN_Submit.Size = New System.Drawing.Size(98, 24)
        Me.BTN_Submit.TabIndex = 3
        Me.BTN_Submit.Text = "S'inscrire"
        Me.BTN_Submit.UseVisualStyleBackColor = True
        '
        'BTN_Back
        '
        Me.BTN_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Back.Location = New System.Drawing.Point(10, 232)
        Me.BTN_Back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(98, 24)
        Me.BTN_Back.TabIndex = 4
        Me.BTN_Back.Text = "< Retour"
        Me.BTN_Back.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 271)
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.BTN_Submit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscription"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Lastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Firstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_Telephone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_Submit As Button
    Friend WithEvents BTN_Back As Button
End Class
