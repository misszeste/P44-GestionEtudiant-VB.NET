<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProgramme
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramme))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RichTxtBoxProgromme = New System.Windows.Forms.RichTextBox()
        Me.BtnEnlever = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnNouveau = New System.Windows.Forms.Button()
        Me.GbProg = New System.Windows.Forms.GroupBox()
        Me.numHeures = New System.Windows.Forms.NumericUpDown()
        Me.BS_Prog = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProg = New P44_TP1_2210116.Ds()
        Me.numUnites = New System.Windows.Forms.NumericUpDown()
        Me.TxtBoxNom = New System.Windows.Forms.TextBox()
        Me.MskNo = New System.Windows.Forms.MaskedTextBox()
        Me.LblNbrHeures = New System.Windows.Forms.Label()
        Me.LblNbrUnites = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.LblNo = New System.Windows.Forms.Label()
        Me.erp1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cnProg = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DaProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DaEtud = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.DgEtudiants = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgProg = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbProg.SuspendLayout()
        CType(Me.numHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Prog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTxtBoxProgromme
        '
        Me.RichTxtBoxProgromme.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTxtBoxProgromme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTxtBoxProgromme.HideSelection = False
        Me.RichTxtBoxProgromme.Location = New System.Drawing.Point(0, 0)
        Me.RichTxtBoxProgromme.Name = "RichTxtBoxProgromme"
        Me.RichTxtBoxProgromme.Size = New System.Drawing.Size(1467, 831)
        Me.RichTxtBoxProgromme.TabIndex = 13
        Me.RichTxtBoxProgromme.Text = ""
        Me.RichTxtBoxProgromme.Visible = False
        '
        'BtnEnlever
        '
        Me.BtnEnlever.Enabled = False
        Me.BtnEnlever.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEnlever.Location = New System.Drawing.Point(561, 253)
        Me.BtnEnlever.Name = "BtnEnlever"
        Me.BtnEnlever.Size = New System.Drawing.Size(110, 33)
        Me.BtnEnlever.TabIndex = 21
        Me.BtnEnlever.Text = "Enlever"
        Me.BtnEnlever.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Enabled = False
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModifier.Location = New System.Drawing.Point(561, 205)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(110, 33)
        Me.BtnModifier.TabIndex = 20
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Enabled = False
        Me.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAnnuler.Location = New System.Drawing.Point(561, 161)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(110, 33)
        Me.BtnAnnuler.TabIndex = 19
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Enabled = False
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOk.Location = New System.Drawing.Point(561, 111)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(110, 33)
        Me.BtnOk.TabIndex = 18
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnNouveau
        '
        Me.BtnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnNouveau.Location = New System.Drawing.Point(561, 61)
        Me.BtnNouveau.Name = "BtnNouveau"
        Me.BtnNouveau.Size = New System.Drawing.Size(110, 33)
        Me.BtnNouveau.TabIndex = 17
        Me.BtnNouveau.Text = "Nouveau"
        Me.BtnNouveau.UseVisualStyleBackColor = True
        '
        'GbProg
        '
        Me.GbProg.AutoSize = True
        Me.GbProg.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GbProg.Controls.Add(Me.numHeures)
        Me.GbProg.Controls.Add(Me.numUnites)
        Me.GbProg.Controls.Add(Me.TxtBoxNom)
        Me.GbProg.Controls.Add(Me.MskNo)
        Me.GbProg.Controls.Add(Me.LblNbrHeures)
        Me.GbProg.Controls.Add(Me.LblNbrUnites)
        Me.GbProg.Controls.Add(Me.LblNom)
        Me.GbProg.Controls.Add(Me.LblNo)
        Me.GbProg.Location = New System.Drawing.Point(20, 51)
        Me.GbProg.Name = "GbProg"
        Me.GbProg.Size = New System.Drawing.Size(507, 235)
        Me.GbProg.TabIndex = 14
        Me.GbProg.TabStop = False
        Me.GbProg.Text = "Programme"
        '
        'numHeures
        '
        Me.numHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numHeures.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Prog, "pro_nbr_heures", True))
        Me.numHeures.Enabled = False
        Me.numHeures.Location = New System.Drawing.Point(192, 162)
        Me.numHeures.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numHeures.Name = "numHeures"
        Me.numHeures.Size = New System.Drawing.Size(120, 29)
        Me.numHeures.TabIndex = 6
        Me.numHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BS_Prog
        '
        Me.BS_Prog.DataMember = "T_programme"
        Me.BS_Prog.DataSource = Me.DsProg
        '
        'DsProg
        '
        Me.DsProg.DataSetName = "Ds"
        Me.DsProg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numUnites
        '
        Me.numUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUnites.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_Prog, "pro_nbr_unites", True))
        Me.numUnites.DecimalPlaces = 2
        Me.numUnites.Enabled = False
        Me.numUnites.Location = New System.Drawing.Point(192, 119)
        Me.numUnites.Name = "numUnites"
        Me.numUnites.Size = New System.Drawing.Size(120, 29)
        Me.numUnites.TabIndex = 5
        Me.numUnites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBoxNom
        '
        Me.TxtBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Prog, "pro_nom", True))
        Me.TxtBoxNom.Enabled = False
        Me.TxtBoxNom.Location = New System.Drawing.Point(191, 79)
        Me.TxtBoxNom.MaxLength = 50
        Me.TxtBoxNom.Name = "TxtBoxNom"
        Me.TxtBoxNom.Size = New System.Drawing.Size(289, 29)
        Me.TxtBoxNom.TabIndex = 2
        Me.TxtBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MskNo
        '
        Me.MskNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MskNo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MskNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Prog, "pro_no", True))
        Me.MskNo.Enabled = False
        Me.MskNo.Location = New System.Drawing.Point(191, 40)
        Me.MskNo.Mask = ">LLL.0L"
        Me.MskNo.Name = "MskNo"
        Me.MskNo.Size = New System.Drawing.Size(121, 29)
        Me.MskNo.TabIndex = 1
        Me.MskNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblNbrHeures
        '
        Me.LblNbrHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNbrHeures.Location = New System.Drawing.Point(5, 163)
        Me.LblNbrHeures.Name = "LblNbrHeures"
        Me.LblNbrHeures.Size = New System.Drawing.Size(165, 24)
        Me.LblNbrHeures.TabIndex = 3
        Me.LblNbrHeures.Text = "Nbr.  Heures :"
        '
        'LblNbrUnites
        '
        Me.LblNbrUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNbrUnites.Location = New System.Drawing.Point(5, 119)
        Me.LblNbrUnites.Name = "LblNbrUnites"
        Me.LblNbrUnites.Size = New System.Drawing.Size(165, 24)
        Me.LblNbrUnites.TabIndex = 2
        Me.LblNbrUnites.Text = "Nbr.  Unités :"
        '
        'LblNom
        '
        Me.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNom.Location = New System.Drawing.Point(6, 80)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(165, 24)
        Me.LblNom.TabIndex = 1
        Me.LblNom.Text = "Nom :"
        '
        'LblNo
        '
        Me.LblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNo.Location = New System.Drawing.Point(6, 45)
        Me.LblNo.Name = "LblNo"
        Me.LblNo.Size = New System.Drawing.Size(165, 24)
        Me.LblNo.TabIndex = 0
        Me.LblNo.Text = "No :"
        '
        'erp1
        '
        Me.erp1.ContainerControl = Me
        '
        'cnProg
        '
        Me.cnProg.ConnectionString = "Data Source=meme\sqlexpress;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnProg.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_" &
    "programme"
        Me.SqlSelectCommand1.Connection = Me.cnProg
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cnProg
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cnProg
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cnProg
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DaProg
        '
        Me.DaProg.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaProg.InsertCommand = Me.SqlInsertCommand1
        Me.DaProg.SelectCommand = Me.SqlSelectCommand1
        Me.DaProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.DaProg.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        etu_da, pro_no, etu_nom, etu_prenom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W" &
    "HERE        (pro_no = @NoProg)"
        Me.SqlSelectCommand2.Connection = Me.cnProg
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NoProg", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'DaEtud
        '
        Me.DaEtud.DeleteCommand = Me.SqlDeleteCommand
        Me.DaEtud.InsertCommand = Me.SqlInsertCommand
        Me.DaEtud.SelectCommand = Me.SqlSelectCommand2
        Me.DaEtud.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom")})})
        Me.DaEtud.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = "DELETE FROM [T_etudiants] WHERE (([etu_da] = @Original_etu_da) AND ([pro_no] = @O" &
    "riginal_pro_no) AND ([etu_nom] = @Original_etu_nom) AND ([etu_prenom] = @Origina" &
    "l_etu_prenom))"
        Me.SqlDeleteCommand.Connection = Me.cnProg
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.cnProg
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.cnProg
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DgEtudiants
        '
        Me.DgEtudiants.AllowUserToAddRows = False
        Me.DgEtudiants.AllowUserToDeleteRows = False
        Me.DgEtudiants.AutoGenerateColumns = False
        Me.DgEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgEtudiants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn})
        Me.DgEtudiants.DataMember = "T_etudiants"
        Me.DgEtudiants.DataSource = Me.DsProg
        Me.DgEtudiants.Location = New System.Drawing.Point(737, 61)
        Me.DgEtudiants.MultiSelect = False
        Me.DgEtudiants.Name = "DgEtudiants"
        Me.DgEtudiants.ReadOnly = True
        Me.DgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEtudiants.Size = New System.Drawing.Size(718, 618)
        Me.DgEtudiants.TabIndex = 23
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.MaxInputLength = 7
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DgProg
        '
        Me.DgProg.AllowUserToAddRows = False
        Me.DgProg.AllowUserToDeleteRows = False
        Me.DgProg.AutoGenerateColumns = False
        Me.DgProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgProg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn1, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.DgProg.DataSource = Me.BS_Prog
        Me.DgProg.Location = New System.Drawing.Point(10, 314)
        Me.DgProg.MultiSelect = False
        Me.DgProg.Name = "DgProg"
        Me.DgProg.ReadOnly = True
        Me.DgProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgProg.Size = New System.Drawing.Size(661, 365)
        Me.DgProg.TabIndex = 22
        '
        'PronoDataGridViewTextBoxColumn1
        '
        Me.PronoDataGridViewTextBoxColumn1.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.HeaderText = "No"
        Me.PronoDataGridViewTextBoxColumn1.MaxInputLength = 6
        Me.PronoDataGridViewTextBoxColumn1.Name = "PronoDataGridViewTextBoxColumn1"
        Me.PronoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PronomDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PronbrunitesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "Nbr. Unitée"
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "Nbr. Heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1467, 831)
        Me.Controls.Add(Me.DgEtudiants)
        Me.Controls.Add(Me.DgProg)
        Me.Controls.Add(Me.BtnEnlever)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnNouveau)
        Me.Controls.Add(Me.GbProg)
        Me.Controls.Add(Me.RichTxtBoxProgromme)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmProgramme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des programmes"
        Me.GbProg.ResumeLayout(False)
        Me.GbProg.PerformLayout()
        CType(Me.numHeures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Prog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTxtBoxProgromme As RichTextBox
    Friend WithEvents BtnEnlever As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnNouveau As Button
    Friend WithEvents LvEtudiants As ListView
    Friend WithEvents GbProg As GroupBox
    Friend WithEvents TxtBoxNom As TextBox
    Friend WithEvents MskNo As MaskedTextBox
    Friend WithEvents LblNbrHeures As Label
    Friend WithEvents LblNbrUnites As Label
    Friend WithEvents LblNom As Label
    Friend WithEvents LblNo As Label
    Friend WithEvents ColDa As ColumnHeader
    Friend WithEvents ColNumProg As ColumnHeader
    Friend WithEvents ColPrenom As ColumnHeader
    Friend WithEvents ColNom As ColumnHeader
    Friend WithEvents erp1 As ErrorProvider
    Friend WithEvents numHeures As NumericUpDown
    Friend WithEvents numUnites As NumericUpDown
    Friend WithEvents DgProg As DataGridView
    Friend WithEvents DgEtudiants As DataGridView
    Friend WithEvents cnProg As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents DaProg As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents DaEtud As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents DsProg As Ds
    Friend WithEvents BS_Prog As BindingSource
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
