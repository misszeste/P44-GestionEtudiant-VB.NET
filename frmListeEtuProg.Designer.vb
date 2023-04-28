<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeEtuProg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeEtuProg))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DaRapEtudParProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.cnRapEtudParProg = New System.Data.SqlClient.SqlConnection()
        Me.DsRapEtudParProg1 = New P44_TP1_2210116.DsRapEtudParProg()
        Me.crvEtudParProg = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsRapEtudParProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.cnRapEtudParProg
        '
        'DaRapEtudParProg
        '
        Me.DaRapEtudParProg.SelectCommand = Me.SqlSelectCommand1
        Me.DaRapEtudParProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DA", "DA"), New System.Data.Common.DataColumnMapping("No Prog", "No Prog"), New System.Data.Common.DataColumnMapping("Nom", "Nom"), New System.Data.Common.DataColumnMapping("Prénom", "Prénom"), New System.Data.Common.DataColumnMapping("Nom du programme", "Nom du programme"), New System.Data.Common.DataColumnMapping("Telephone", "Telephone"), New System.Data.Common.DataColumnMapping("Num Prog", "Num Prog")})})
        '
        'cnRapEtudParProg
        '
        Me.cnRapEtudParProg.ConnectionString = "Data Source=meme\sqlexpress;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnRapEtudParProg.FireInfoMessageEventOnUserErrors = False
        '
        'DsRapEtudParProg1
        '
        Me.DsRapEtudParProg1.DataSetName = "DsRapEtudParProg"
        Me.DsRapEtudParProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'crvEtudParProg
        '
        Me.crvEtudParProg.ActiveViewIndex = -1
        Me.crvEtudParProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEtudParProg.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEtudParProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEtudParProg.Location = New System.Drawing.Point(0, 0)
        Me.crvEtudParProg.Name = "crvEtudParProg"
        Me.crvEtudParProg.Size = New System.Drawing.Size(1467, 831)
        Me.crvEtudParProg.TabIndex = 0
        '
        'frmListeEtuProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 831)
        Me.Controls.Add(Me.crvEtudParProg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmListeEtuProg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Étudiants par Programmes"
        CType(Me.DsRapEtudParProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnRapEtudParProg As SqlClient.SqlConnection
    Friend WithEvents DaRapEtudParProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapEtudParProg1 As DsRapEtudParProg
    Friend WithEvents crvEtudParProg As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
