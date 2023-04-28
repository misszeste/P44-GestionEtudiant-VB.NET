<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeProg
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cnListeProg = New System.Data.SqlClient.SqlConnection()
        Me.daListeProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsListeProg1 = New P44_TP1_2210116.dsListeProg()
        Me.crvListeProg = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsListeProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        pro_no AS [No Programme], pro_nom AS [Nom du Programme], pro_nbr_un" &
    "ites AS [Nombre d'heures'], pro_nbr_heures AS [Nombre d'unités']" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          " &
    "  T_programme"
        Me.SqlSelectCommand1.Connection = Me.cnListeProg
        '
        'cnListeProg
        '
        Me.cnListeProg.ConnectionString = "Data Source=meme\sqlexpress;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnListeProg.FireInfoMessageEventOnUserErrors = False
        '
        'daListeProg
        '
        Me.daListeProg.SelectCommand = Me.SqlSelectCommand1
        Me.daListeProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("No Programme", "No Programme"), New System.Data.Common.DataColumnMapping("Nom du Programme", "Nom du Programme"), New System.Data.Common.DataColumnMapping("Nombre d'heures'", "Nombre d'heures'"), New System.Data.Common.DataColumnMapping("Nombre d'unités'", "Nombre d'unités'")})})
        '
        'DsListeProg1
        '
        Me.DsListeProg1.DataSetName = "dsListeProg"
        Me.DsListeProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'crvListeProg
        '
        Me.crvListeProg.ActiveViewIndex = -1
        Me.crvListeProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvListeProg.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvListeProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvListeProg.Location = New System.Drawing.Point(0, 0)
        Me.crvListeProg.Name = "crvListeProg"
        Me.crvListeProg.Size = New System.Drawing.Size(1467, 831)
        Me.crvListeProg.TabIndex = 0
        '
        'frmListeProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 831)
        Me.Controls.Add(Me.crvListeProg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmListeProg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Programmes"
        CType(Me.DsListeProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnListeProg As SqlClient.SqlConnection
    Friend WithEvents daListeProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsListeProg1 As dsListeProg
    Friend WithEvents crvListeProg As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
