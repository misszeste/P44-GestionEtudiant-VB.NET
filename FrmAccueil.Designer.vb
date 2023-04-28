<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
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
        Me.MenuAccueil = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesProgrammesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesÉtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesÉtudiantsParProgrammesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAccueil.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuAccueil
        '
        Me.MenuAccueil.AutoSize = False
        Me.MenuAccueil.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuAccueil.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.RapportToolStripMenuItem})
        Me.MenuAccueil.Location = New System.Drawing.Point(0, 0)
        Me.MenuAccueil.Name = "MenuAccueil"
        Me.MenuAccueil.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuAccueil.Size = New System.Drawing.Size(1467, 49)
        Me.MenuAccueil.TabIndex = 0
        Me.MenuAccueil.Text = "MenuStrip1"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.AutoSize = False
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammeToolStripMenuItem, Me.ÉtudiantsToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.GestionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 41)
        Me.GestionToolStripMenuItem.Text = "&Gestion"
        '
        'ProgrammeToolStripMenuItem
        '
        Me.ProgrammeToolStripMenuItem.Name = "ProgrammeToolStripMenuItem"
        Me.ProgrammeToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.ProgrammeToolStripMenuItem.Text = "&Programme"
        '
        'ÉtudiantsToolStripMenuItem
        '
        Me.ÉtudiantsToolStripMenuItem.Name = "ÉtudiantsToolStripMenuItem"
        Me.ÉtudiantsToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.ÉtudiantsToolStripMenuItem.Text = "&Étudiants"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'RapportToolStripMenuItem
        '
        Me.RapportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesProgrammesToolStripMenuItem, Me.ListeDesÉtudiantsToolStripMenuItem, Me.ListeDesÉtudiantsParProgrammesToolStripMenuItem})
        Me.RapportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        Me.RapportToolStripMenuItem.Size = New System.Drawing.Size(78, 41)
        Me.RapportToolStripMenuItem.Text = "Rapport"
        '
        'ListeDesProgrammesToolStripMenuItem
        '
        Me.ListeDesProgrammesToolStripMenuItem.Name = "ListeDesProgrammesToolStripMenuItem"
        Me.ListeDesProgrammesToolStripMenuItem.Size = New System.Drawing.Size(329, 26)
        Me.ListeDesProgrammesToolStripMenuItem.Text = "Liste des Programmes"
        '
        'ListeDesÉtudiantsToolStripMenuItem
        '
        Me.ListeDesÉtudiantsToolStripMenuItem.Name = "ListeDesÉtudiantsToolStripMenuItem"
        Me.ListeDesÉtudiantsToolStripMenuItem.Size = New System.Drawing.Size(329, 26)
        Me.ListeDesÉtudiantsToolStripMenuItem.Text = "Liste des Étudiants"
        '
        'ListeDesÉtudiantsParProgrammesToolStripMenuItem
        '
        Me.ListeDesÉtudiantsParProgrammesToolStripMenuItem.Name = "ListeDesÉtudiantsParProgrammesToolStripMenuItem"
        Me.ListeDesÉtudiantsParProgrammesToolStripMenuItem.Size = New System.Drawing.Size(329, 26)
        Me.ListeDesÉtudiantsParProgrammesToolStripMenuItem.Text = "Liste des étudiants par programmes"
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1467, 831)
        Me.Controls.Add(Me.MenuAccueil)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuAccueil
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormAccueil"
        Me.Text = "Gestion"
        Me.MenuAccueil.ResumeLayout(False)
        Me.MenuAccueil.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuAccueil As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesProgrammesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudiantsParProgrammesToolStripMenuItem As ToolStripMenuItem
End Class
