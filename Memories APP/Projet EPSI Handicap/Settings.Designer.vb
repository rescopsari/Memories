<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.BTN_CreateLoginUSB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_CreateLoginUSB
        '
        Me.BTN_CreateLoginUSB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CreateLoginUSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CreateLoginUSB.ForeColor = System.Drawing.Color.White
        Me.BTN_CreateLoginUSB.Location = New System.Drawing.Point(10, 11)
        Me.BTN_CreateLoginUSB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_CreateLoginUSB.Name = "BTN_CreateLoginUSB"
        Me.BTN_CreateLoginUSB.Size = New System.Drawing.Size(657, 40)
        Me.BTN_CreateLoginUSB.TabIndex = 0
        Me.BTN_CreateLoginUSB.Text = "Créer une clée USB de connexion"
        Me.BTN_CreateLoginUSB.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 368)
        Me.Controls.Add(Me.BTN_CreateLoginUSB)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_CreateLoginUSB As Button
End Class
