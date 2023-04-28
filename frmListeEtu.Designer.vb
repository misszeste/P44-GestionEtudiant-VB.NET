<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeEtu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeEtu))
        Me.crvEtudiant = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DaRapEtudiant = New System.Data.SqlClient.SqlDataAdapter()
        Me.cnRapEtudiant = New System.Data.SqlClient.SqlConnection()
        Me.DsRapEtudiant1 = New P44_TP1_2210116.DsRapEtudiant()
        CType(Me.DsRapEtudiant1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvEtudiant
        '
        Me.crvEtudiant.ActiveViewIndex = -1
        Me.crvEtudiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEtudiant.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEtudiant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEtudiant.Location = New System.Drawing.Point(0, 0)
        Me.crvEtudiant.Name = "crvEtudiant"
        Me.crvEtudiant.Size = New System.Drawing.Size(1467, 830)
        Me.crvEtudiant.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.cnRapEtudiant
        '
        'DaRapEtudiant
        '
        Me.DaRapEtudiant.SelectCommand = Me.SqlSelectCommand1
        Me.DaRapEtudiant.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DA", "DA"), New System.Data.Common.DataColumnMapping("No Prog", "No Prog"), New System.Data.Common.DataColumnMapping("Prénom", "Prénom"), New System.Data.Common.DataColumnMapping("Nom", "Nom"), New System.Data.Common.DataColumnMapping("Sexe", "Sexe"), New System.Data.Common.DataColumnMapping("Adresse", "Adresse"), New System.Data.Common.DataColumnMapping("Ville", "Ville"), New System.Data.Common.DataColumnMapping("Code Postal", "Code Postal"), New System.Data.Common.DataColumnMapping("Téléphone", "Téléphone"), New System.Data.Common.DataColumnMapping("Province", "Province")})})
        '
        'cnRapEtudiant
        '
        Me.cnRapEtudiant.ConnectionString = "Data Source=meme\sqlexpress;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnRapEtudiant.FireInfoMessageEventOnUserErrors = False
        '
        'DsRapEtudiant1
        '
        Me.DsRapEtudiant1.DataSetName = "DsRapEtudiant"
        Me.DsRapEtudiant1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmListeEtu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 830)
        Me.Controls.Add(Me.crvEtudiant)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmListeEtu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Étudiants"
        CType(Me.DsRapEtudiant1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvEtudiant As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnRapEtudiant As SqlClient.SqlConnection
    Friend WithEvents DaRapEtudiant As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapEtudiant1 As DsRapEtudiant
End Class
