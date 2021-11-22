<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_USER_PASS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_USER_NAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_REGISTER = New System.Windows.Forms.Button()
        Me.BTN_CONNECT = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelLeft.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.PictureBoxLogo)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(200, 366)
        Me.PanelLeft.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEMORIES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TB_USER_PASS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TB_USER_NAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(33, 101)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(333, 163)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connexion à votre compte"
        '
        'TB_USER_PASS
        '
        Me.TB_USER_PASS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_USER_PASS.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_USER_PASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_USER_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USER_PASS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TB_USER_PASS.Location = New System.Drawing.Point(25, 121)
        Me.TB_USER_PASS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_USER_PASS.Name = "TB_USER_PASS"
        Me.TB_USER_PASS.Size = New System.Drawing.Size(280, 26)
        Me.TB_USER_PASS.TabIndex = 3
        Me.TB_USER_PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_USER_PASS.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(100, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mot de passe:"
        '
        'TB_USER_NAME
        '
        Me.TB_USER_NAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_USER_NAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TB_USER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_USER_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USER_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TB_USER_NAME.Location = New System.Drawing.Point(25, 53)
        Me.TB_USER_NAME.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_USER_NAME.Name = "TB_USER_NAME"
        Me.TB_USER_NAME.Size = New System.Drawing.Size(280, 26)
        Me.TB_USER_NAME.TabIndex = 1
        Me.TB_USER_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(116, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identifiant:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BTN_REGISTER)
        Me.Panel1.Controls.Add(Me.BTN_CONNECT)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(200, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 364)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 51)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Si vous détenez une clée de connexion," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "insérez-la dans votre ordinateur"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_REGISTER
        '
        Me.BTN_REGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REGISTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGISTER.ForeColor = System.Drawing.Color.White
        Me.BTN_REGISTER.Location = New System.Drawing.Point(33, 271)
        Me.BTN_REGISTER.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_REGISTER.Name = "BTN_REGISTER"
        Me.BTN_REGISTER.Size = New System.Drawing.Size(100, 32)
        Me.BTN_REGISTER.TabIndex = 3
        Me.BTN_REGISTER.Text = "INSCRIPTION"
        Me.BTN_REGISTER.UseVisualStyleBackColor = True
        '
        'BTN_CONNECT
        '
        Me.BTN_CONNECT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CONNECT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CONNECT.ForeColor = System.Drawing.Color.White
        Me.BTN_CONNECT.Location = New System.Drawing.Point(266, 271)
        Me.BTN_CONNECT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_CONNECT.Name = "BTN_CONNECT"
        Me.BTN_CONNECT.Size = New System.Drawing.Size(100, 32)
        Me.BTN_CONNECT.TabIndex = 2
        Me.BTN_CONNECT.Text = "CONNEXION"
        Me.BTN_CONNECT.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(36, 88)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(128, 128)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelLeft)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelLeft.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_USER_PASS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_USER_NAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_REGISTER As Button
    Friend WithEvents BTN_CONNECT As Button
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
