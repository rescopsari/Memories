<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart_SessionScore = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart_SessionScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_SessionScore
        '
        Me.Chart_SessionScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart_SessionScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Chart_SessionScore.BackSecondaryColor = System.Drawing.Color.Black
        Me.Chart_SessionScore.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Chart_SessionScore.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.Title = "Questionnaire"
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart_SessionScore.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart_SessionScore.Legends.Add(Legend1)
        Me.Chart_SessionScore.Location = New System.Drawing.Point(-1, 0)
        Me.Chart_SessionScore.Name = "Chart_SessionScore"
        Me.Chart_SessionScore.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Me.Chart_SessionScore.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.LegendText = "Réussite en %"
        Series1.Name = "Series1"
        Me.Chart_SessionScore.Series.Add(Series1)
        Me.Chart_SessionScore.Size = New System.Drawing.Size(801, 451)
        Me.Chart_SessionScore.TabIndex = 0
        Me.Chart_SessionScore.Text = "Graphique"
        '
        'StatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart_SessionScore)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "StatsForm"
        Me.Text = "StatsForm"
        CType(Me.Chart_SessionScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart_SessionScore As DataVisualization.Charting.Chart
End Class
