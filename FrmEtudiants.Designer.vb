<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEtudiants
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEtudiants))
        Me.GbEtudiants = New System.Windows.Forms.GroupBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.BS_Etudiants = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEtudiants = New P44_TP1_2210116.Ds2()
        Me.cboNoProg = New System.Windows.Forms.ComboBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.mskCP = New System.Windows.Forms.MaskedTextBox()
        Me.mskDA = New System.Windows.Forms.MaskedTextBox()
        Me.gbSexe = New System.Windows.Forms.GroupBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.rdbMasculin = New System.Windows.Forms.RadioButton()
        Me.rdbFeminim = New System.Windows.Forms.RadioButton()
        Me.lblTelEtud = New System.Windows.Forms.Label()
        Me.lblCpEtud = New System.Windows.Forms.Label()
        Me.lblProvinceEtud = New System.Windows.Forms.Label()
        Me.lblVilleEtud = New System.Windows.Forms.Label()
        Me.lblAdresseEtud = New System.Windows.Forms.Label()
        Me.lblNomEtud = New System.Windows.Forms.Label()
        Me.lblPrenomEtud = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.BtnNouveau = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnEnlever = New System.Windows.Forms.Button()
        Me.erp1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DgEtudiant = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CN_TP2_P44 = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DaEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DaProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.GbEtudiants.SuspendLayout()
        CType(Me.BS_Etudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSexe.SuspendLayout()
        CType(Me.erp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgEtudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbEtudiants
        '
        Me.GbEtudiants.AutoSize = True
        Me.GbEtudiants.Controls.Add(Me.cboProv)
        Me.GbEtudiants.Controls.Add(Me.cboNoProg)
        Me.GbEtudiants.Controls.Add(Me.txtVille)
        Me.GbEtudiants.Controls.Add(Me.txtAdresse)
        Me.GbEtudiants.Controls.Add(Me.txtNom)
        Me.GbEtudiants.Controls.Add(Me.txtPrenom)
        Me.GbEtudiants.Controls.Add(Me.mskTel)
        Me.GbEtudiants.Controls.Add(Me.mskCP)
        Me.GbEtudiants.Controls.Add(Me.mskDA)
        Me.GbEtudiants.Controls.Add(Me.gbSexe)
        Me.GbEtudiants.Controls.Add(Me.lblTelEtud)
        Me.GbEtudiants.Controls.Add(Me.lblCpEtud)
        Me.GbEtudiants.Controls.Add(Me.lblProvinceEtud)
        Me.GbEtudiants.Controls.Add(Me.lblVilleEtud)
        Me.GbEtudiants.Controls.Add(Me.lblAdresseEtud)
        Me.GbEtudiants.Controls.Add(Me.lblNomEtud)
        Me.GbEtudiants.Controls.Add(Me.lblPrenomEtud)
        Me.GbEtudiants.Controls.Add(Me.lblNoProg)
        Me.GbEtudiants.Controls.Add(Me.lblDA)
        Me.GbEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GbEtudiants.Location = New System.Drawing.Point(12, 37)
        Me.GbEtudiants.Name = "GbEtudiants"
        Me.GbEtudiants.Size = New System.Drawing.Size(1224, 350)
        Me.GbEtudiants.TabIndex = 29
        Me.GbEtudiants.TabStop = False
        Me.GbEtudiants.Text = "Étudiants"
        '
        'cboProv
        '
        Me.cboProv.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BS_Etudiants, "etu_province", True))
        Me.cboProv.DisplayMember = "T_etudiants.etu_province"
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.Enabled = False
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.ItemHeight = 24
        Me.cboProv.Items.AddRange(New Object() {"Ontario", "Québec", "Nouvelle-Écosse", "Nouveau-Brunswick", "Manitoba", "Colombie-Britannique", "Île-du-Prince-Édouard", "Saskatchewan", "Alberta", "Terre-Neuve-et-Labrador", "Yukon", "Territoires du Nord-Ouest", "Nunavut"})
        Me.cboProv.Location = New System.Drawing.Point(782, 124)
        Me.cboProv.MaxDropDownItems = 10
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(304, 32)
        Me.cboProv.TabIndex = 19
        Me.cboProv.ValueMember = "T_etudiants.etu_province"
        '
        'BS_Etudiants
        '
        Me.BS_Etudiants.DataMember = "T_etudiants"
        Me.BS_Etudiants.DataSource = Me.DsEtudiants
        '
        'DsEtudiants
        '
        Me.DsEtudiants.DataSetName = "Ds"
        Me.DsEtudiants.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboNoProg
        '
        Me.cboNoProg.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_Etudiants, "pro_no", True))
        Me.cboNoProg.DataSource = Me.DsEtudiants
        Me.cboNoProg.DisplayMember = "T_programme.pro_no"
        Me.cboNoProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNoProg.Enabled = False
        Me.cboNoProg.FormattingEnabled = True
        Me.cboNoProg.Location = New System.Drawing.Point(159, 74)
        Me.cboNoProg.MaxLength = 6
        Me.cboNoProg.Name = "cboNoProg"
        Me.cboNoProg.Size = New System.Drawing.Size(335, 32)
        Me.cboNoProg.TabIndex = 18
        Me.cboNoProg.ValueMember = "T_programme.pro_no"
        '
        'txtVille
        '
        Me.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVille.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_ville", True))
        Me.txtVille.Enabled = False
        Me.txtVille.Location = New System.Drawing.Point(782, 79)
        Me.txtVille.MaxLength = 150
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(304, 29)
        Me.txtVille.TabIndex = 17
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_adresse", True))
        Me.txtAdresse.Enabled = False
        Me.txtAdresse.Location = New System.Drawing.Point(782, 29)
        Me.txtAdresse.MaxLength = 150
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(401, 29)
        Me.txtAdresse.TabIndex = 16
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_nom", True))
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(159, 172)
        Me.txtNom.MaxLength = 50
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(445, 29)
        Me.txtNom.TabIndex = 15
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_prenom", True))
        Me.txtPrenom.Enabled = False
        Me.txtPrenom.Location = New System.Drawing.Point(159, 125)
        Me.txtPrenom.MaxLength = 50
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(445, 29)
        Me.txtPrenom.TabIndex = 14
        '
        'mskTel
        '
        Me.mskTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_telephone", True))
        Me.mskTel.Enabled = False
        Me.mskTel.Location = New System.Drawing.Point(782, 222)
        Me.mskTel.Mask = "(999) 999-9999"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(137, 29)
        Me.mskTel.TabIndex = 12
        '
        'mskCP
        '
        Me.mskCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_codepostal", True))
        Me.mskCP.Enabled = False
        Me.mskCP.Location = New System.Drawing.Point(782, 175)
        Me.mskCP.Mask = ">L9L-9L9"
        Me.mskCP.Name = "mskCP"
        Me.mskCP.Size = New System.Drawing.Size(137, 29)
        Me.mskCP.TabIndex = 11
        '
        'mskDA
        '
        Me.mskDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_da", True))
        Me.mskDA.Enabled = False
        Me.mskDA.Location = New System.Drawing.Point(159, 28)
        Me.mskDA.Mask = "9999999"
        Me.mskDA.Name = "mskDA"
        Me.mskDA.Size = New System.Drawing.Size(335, 29)
        Me.mskDA.TabIndex = 10
        '
        'gbSexe
        '
        Me.gbSexe.Controls.Add(Me.txtSex)
        Me.gbSexe.Controls.Add(Me.rdbMasculin)
        Me.gbSexe.Controls.Add(Me.rdbFeminim)
        Me.gbSexe.Location = New System.Drawing.Point(159, 222)
        Me.gbSexe.Name = "gbSexe"
        Me.gbSexe.Size = New System.Drawing.Size(294, 100)
        Me.gbSexe.TabIndex = 9
        Me.gbSexe.TabStop = False
        Me.gbSexe.Text = "Sexe"
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Etudiants, "etu_sexe", True))
        Me.txtSex.Location = New System.Drawing.Point(212, 29)
        Me.txtSex.MaxLength = 1
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(100, 29)
        Me.txtSex.TabIndex = 2
        Me.txtSex.Visible = False
        '
        'rdbMasculin
        '
        Me.rdbMasculin.AutoSize = True
        Me.rdbMasculin.Enabled = False
        Me.rdbMasculin.Location = New System.Drawing.Point(103, 63)
        Me.rdbMasculin.Name = "rdbMasculin"
        Me.rdbMasculin.Size = New System.Drawing.Size(103, 28)
        Me.rdbMasculin.TabIndex = 1
        Me.rdbMasculin.TabStop = True
        Me.rdbMasculin.Text = "Masculin"
        Me.rdbMasculin.UseVisualStyleBackColor = True
        '
        'rdbFeminim
        '
        Me.rdbFeminim.AutoSize = True
        Me.rdbFeminim.Enabled = False
        Me.rdbFeminim.Location = New System.Drawing.Point(103, 29)
        Me.rdbFeminim.Name = "rdbFeminim"
        Me.rdbFeminim.Size = New System.Drawing.Size(97, 28)
        Me.rdbFeminim.TabIndex = 0
        Me.rdbFeminim.TabStop = True
        Me.rdbFeminim.Text = "Féminin"
        Me.rdbFeminim.UseVisualStyleBackColor = True
        '
        'lblTelEtud
        '
        Me.lblTelEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelEtud.Location = New System.Drawing.Point(650, 227)
        Me.lblTelEtud.Name = "lblTelEtud"
        Me.lblTelEtud.Size = New System.Drawing.Size(126, 24)
        Me.lblTelEtud.TabIndex = 8
        Me.lblTelEtud.Text = "Téléphone :"
        '
        'lblCpEtud
        '
        Me.lblCpEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCpEtud.Location = New System.Drawing.Point(650, 177)
        Me.lblCpEtud.Name = "lblCpEtud"
        Me.lblCpEtud.Size = New System.Drawing.Size(126, 24)
        Me.lblCpEtud.TabIndex = 7
        Me.lblCpEtud.Text = "Code Postal : "
        '
        'lblProvinceEtud
        '
        Me.lblProvinceEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvinceEtud.Location = New System.Drawing.Point(650, 125)
        Me.lblProvinceEtud.Name = "lblProvinceEtud"
        Me.lblProvinceEtud.Size = New System.Drawing.Size(126, 24)
        Me.lblProvinceEtud.TabIndex = 6
        Me.lblProvinceEtud.Text = "Province : "
        '
        'lblVilleEtud
        '
        Me.lblVilleEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVilleEtud.Location = New System.Drawing.Point(650, 79)
        Me.lblVilleEtud.Name = "lblVilleEtud"
        Me.lblVilleEtud.Size = New System.Drawing.Size(126, 24)
        Me.lblVilleEtud.TabIndex = 5
        Me.lblVilleEtud.Text = "Ville : "
        '
        'lblAdresseEtud
        '
        Me.lblAdresseEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresseEtud.Location = New System.Drawing.Point(650, 31)
        Me.lblAdresseEtud.Name = "lblAdresseEtud"
        Me.lblAdresseEtud.Size = New System.Drawing.Size(126, 24)
        Me.lblAdresseEtud.TabIndex = 4
        Me.lblAdresseEtud.Text = "Adresse :"
        '
        'lblNomEtud
        '
        Me.lblNomEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomEtud.Location = New System.Drawing.Point(38, 177)
        Me.lblNomEtud.Name = "lblNomEtud"
        Me.lblNomEtud.Size = New System.Drawing.Size(115, 24)
        Me.lblNomEtud.TabIndex = 3
        Me.lblNomEtud.Text = "Nom : "
        '
        'lblPrenomEtud
        '
        Me.lblPrenomEtud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenomEtud.Location = New System.Drawing.Point(38, 125)
        Me.lblPrenomEtud.Name = "lblPrenomEtud"
        Me.lblPrenomEtud.Size = New System.Drawing.Size(115, 24)
        Me.lblPrenomEtud.TabIndex = 2
        Me.lblPrenomEtud.Text = "Prénom : "
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(38, 74)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(115, 24)
        Me.lblNoProg.TabIndex = 1
        Me.lblNoProg.Text = "No Prog. :"
        '
        'lblDA
        '
        Me.lblDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDA.Location = New System.Drawing.Point(38, 31)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(115, 24)
        Me.lblDA.TabIndex = 0
        Me.lblDA.Text = "DA :"
        '
        'BtnNouveau
        '
        Me.BtnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnNouveau.Location = New System.Drawing.Point(1304, 77)
        Me.BtnNouveau.Name = "BtnNouveau"
        Me.BtnNouveau.Size = New System.Drawing.Size(112, 32)
        Me.BtnNouveau.TabIndex = 31
        Me.BtnNouveau.Text = "Nouveau"
        Me.BtnNouveau.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Enabled = False
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOK.Location = New System.Drawing.Point(1304, 123)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(112, 32)
        Me.BtnOK.TabIndex = 32
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAnnuler.Enabled = False
        Me.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAnnuler.Location = New System.Drawing.Point(1304, 169)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(112, 32)
        Me.BtnAnnuler.TabIndex = 33
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Enabled = False
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModifier.Location = New System.Drawing.Point(1304, 216)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(112, 32)
        Me.BtnModifier.TabIndex = 34
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnEnlever
        '
        Me.BtnEnlever.Enabled = False
        Me.BtnEnlever.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEnlever.Location = New System.Drawing.Point(1304, 268)
        Me.BtnEnlever.Name = "BtnEnlever"
        Me.BtnEnlever.Size = New System.Drawing.Size(112, 32)
        Me.BtnEnlever.TabIndex = 35
        Me.BtnEnlever.Text = "Enlever"
        Me.BtnEnlever.UseVisualStyleBackColor = True
        '
        'erp1
        '
        Me.erp1.ContainerControl = Me
        '
        'DgEtudiant
        '
        Me.DgEtudiant.AllowUserToAddRows = False
        Me.DgEtudiant.AllowUserToDeleteRows = False
        Me.DgEtudiant.AutoGenerateColumns = False
        Me.DgEtudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgEtudiant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEtudiant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn})
        Me.DgEtudiant.DataSource = Me.BS_Etudiants
        Me.DgEtudiant.Location = New System.Drawing.Point(12, 393)
        Me.DgEtudiant.MultiSelect = False
        Me.DgEtudiant.Name = "DgEtudiant"
        Me.DgEtudiant.ReadOnly = True
        Me.DgEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEtudiant.Size = New System.Drawing.Size(1443, 397)
        Me.DgEtudiant.TabIndex = 36
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.FillWeight = 67.41004!
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.FillWeight = 72.20022!
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.FillWeight = 140.6312!
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.FillWeight = 152.9242!
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.FillWeight = 50.76143!
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.EtusexeDataGridViewTextBoxColumn.MaxInputLength = 1
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.FillWeight = 196.88!
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.FillWeight = 102.5925!
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "ville"
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.FillWeight = 72.20022!
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "Code Postal"
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.FillWeight = 72.20022!
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.FillWeight = 72.20022!
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CN_TP2_P44
        '
        Me.CN_TP2_P44.ConnectionString = "Data Source=meme\sqlexpress;Initial Catalog=tp_p44;Integrated Security=True"
        Me.CN_TP2_P44.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SqlSelectCommand1.Connection = Me.CN_TP2_P44
        '
        'DaEtudiants
        '
        Me.DaEtudiants.DeleteCommand = Me.SqlDeleteCommand
        Me.DaEtudiants.InsertCommand = Me.SqlInsertCommand
        Me.DaEtudiants.SelectCommand = Me.SqlSelectCommand1
        Me.DaEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.DaEtudiants.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.CN_TP2_P44
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.CN_TP2_P44
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.CN_TP2_P44
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT pro_no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_programme"
        Me.SqlSelectCommand2.Connection = Me.CN_TP2_P44
        '
        'DaProg
        '
        Me.DaProg.SelectCommand = Me.SqlSelectCommand2
        Me.DaProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no")})})
        '
        'FrmEtudiants
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.BtnAnnuler
        Me.ClientSize = New System.Drawing.Size(1471, 797)
        Me.Controls.Add(Me.DgEtudiant)
        Me.Controls.Add(Me.BtnEnlever)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnNouveau)
        Me.Controls.Add(Me.GbEtudiants)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmEtudiants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des étudiants"
        Me.GbEtudiants.ResumeLayout(False)
        Me.GbEtudiants.PerformLayout()
        CType(Me.BS_Etudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSexe.ResumeLayout(False)
        Me.gbSexe.PerformLayout()
        CType(Me.erp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgEtudiant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbEtudiants As GroupBox
    Friend WithEvents gbSexe As GroupBox
    Friend WithEvents rdbMasculin As RadioButton
    Friend WithEvents rdbFeminim As RadioButton
    Friend WithEvents lblTelEtud As Label
    Friend WithEvents lblCpEtud As Label
    Friend WithEvents lblProvinceEtud As Label
    Friend WithEvents lblVilleEtud As Label
    Friend WithEvents lblAdresseEtud As Label
    Friend WithEvents lblNomEtud As Label
    Friend WithEvents lblPrenomEtud As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents lblDA As Label
    Friend WithEvents cboProv As ComboBox
    Friend WithEvents cboNoProg As ComboBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents mskCP As MaskedTextBox
    Friend WithEvents mskDA As MaskedTextBox
    Friend WithEvents BtnNouveau As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnEnlever As Button
    Friend WithEvents erp1 As ErrorProvider
    Friend WithEvents DgEtudiant As DataGridView
    Friend WithEvents CN_TP2_P44 As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents DaEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents BS_Etudiants As BindingSource
    Friend WithEvents DsEtudiants As Ds2
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents DaProg As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents txtSex As TextBox
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
