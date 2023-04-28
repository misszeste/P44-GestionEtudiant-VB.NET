' Programme childMDI FORM Étudiant Permet la gestion CRUD affichage dans une Data Grid des étudiants
' Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le: 22/11/10
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions 'pour expression regulières
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.Logging

'formulaire étudiant
Public Class FrmEtudiants

    Public Enum Operation
        Aucune = 0
        AJOUTER = 1
        MODIFIER = 2
        ENLEVER = 3
    End Enum

    ' Variables globales au formulaire
    Dim Ligne_Courante As Integer
    Dim Action As Operation = Operation.Aucune



    Private Sub FrmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Pas besoin d'ouvrir la connection a la BD: Le .fill le fait pour nous..
            'on doit respecter l'ordre de remplissage du DataSet

            '1) remplissage du DataSet
            DaProg.Fill(DsEtudiants.T_programme)
            DaEtudiants.Fill(DsEtudiants.T_etudiants)



            If DsEtudiants.Tables("T_Etudiants").Rows(DgEtudiant.CurrentRow.Index).Item(4) = "F" Then
                rdbFeminim.Checked = True
            Else
                rdbMasculin.Checked = True

            End If

            'Vérifier si vous avez des Etudiants
            If DsEtudiants.T_etudiants.Rows.Count > 0 Then
                BtnModifier.Enabled = True
                BtnEnlever.Enabled = True
                Ligne_Courante = 0
            Else
                BtnModifier.Enabled = False
                BtnEnlever.Enabled = False
                Ligne_Courante = -1
            End If


        Catch ex As Exception
            MsgBox(ex.Message, "Problème au chargement du formulaire, veuillez contacter votre administrateur ", vbCritical)
            Me.Close()

        End Try
    End Sub




    Private Sub BtnNouveau_Click(sender As Object, e As EventArgs) Handles BtnNouveau.Click
        Try
            '1) Barrer des controles  
            Barrer(BtnNouveau, BtnModifier, BtnEnlever, DgEtudiant)

            '2) Débarrer les controles
            Debarrer(GbEtudiants, BtnAnnuler, BtnOK, mskDA, cboNoProg, txtPrenom, txtNom, rdbFeminim, rdbMasculin, txtAdresse, txtVille, cboProv, mskCP, mskTel)

            '3) indiquer  l'action de donner le focus au 1 champs a remplir
            Action = Operation.AJOUTER

            mskDA.Focus()

            '4 vider l'écran

            'ici nous somme avec des controle liée (BindingSource)
            'on peut vider l'écran avec la Methode ADDNEW
            'ajoute une ligne blanche dans la table
            BS_Etudiants.AddNew()
            'asigné la valeur par défaut chicoutimi
            txtVille.Text = "CHICOUTIMI"
            rdbFeminim.Checked = False
            rdbMasculin.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub


    ''' <summary>
    ''' Permet de barrer les CTRLS
    ''' </summary>
    ''' <param name="ctrl"></param>
    Private Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub




    ''' <summary>
    ''' Permet de debarrer les CTRLS
    ''' </summary>
    ''' <param name="ctrl"></param>
    Private Sub Debarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub



    ''' <summary>
    ''' Permet la validation du formulaire et engendre un msg d'erreur et empeche l'action
    ''' </summary>
    ''' <returns>True or false</returns>
    Private Function Valider_Formulaire() As Boolean
        'efffacer nos anciens msg d'erreur
        erp1.Clear()
        Dim OK As Boolean = True

        'Verifier le formulaire et son contenu
        If mskDA.MaskFull = False Then
            OK = False
            erp1.SetError(mskDA, "DA est obligatoire")
        End If

        If cboNoProg.SelectedIndex = -1 Then
            OK = False
            erp1.SetError(cboNoProg, "NO du programme est obligatoire")
        End If

        If txtPrenom.Text.Trim() = "" Then
            OK = False
            erp1.SetError(txtPrenom, "Prénom est obligatoire")
        End If

        If txtNom.Text.Trim() = "" Then
            OK = False
            erp1.SetError(txtNom, "  Nom est obligatoire")
        End If

        If rdbMasculin.Checked = False And rdbFeminim.Checked = False Then
            OK = False
            erp1.SetError(rdbFeminim, " Sexe est obligatoire")
        End If

        If txtAdresse.Text.Trim() = "" Then
            OK = False
            erp1.SetError(txtAdresse, "Adresse est obligatoire")
        Else

        End If

        If txtVille.Text.Trim() = "" Then
            OK = False
            erp1.SetError(txtVille, "Ville est obligatoire")
        End If

        If mskCP.MaskFull = False Then
            OK = False
            erp1.SetError(mskCP, "Code Postal est obligatoire")
        End If

        If mskTel.MaskFull = False Then
            OK = False
            erp1.SetError(mskTel, "Telephone est obligatoire")
        End If

        If cboProv.SelectedIndex = -1 Then
            OK = False
            erp1.SetError(cboProv, " Province est obligatoire")
        End If

        Return OK
    End Function


    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Try

            '1) valider le formulaire
            ' Si des erreurs on quitte.. sinon on fait l'action
            If Valider_Formulaire() = False Then
                Exit Sub
            End If

            If rdbFeminim.Checked = True Then
                BS_Etudiants.Current.Item("etu_sexe") = "F"

            Else
                BS_Etudiants.Current.Item("etu_sexe") = "M"

            End If

            'faut arreter action
            BS_Etudiants.EndEdit()
            DaEtudiants.Update(DsEtudiants.T_etudiants)


            '2 Verifier l'action
            If Action = Operation.AJOUTER Then
                MsgBox("Étudiant ajouté avec succès")

                Barrer(BtnOK, BtnAnnuler, GbEtudiants)
                Debarrer(DgEtudiant, BtnNouveau, BtnModifier, BtnEnlever)
                BS_Etudiants.MoveLast()


            Else
                MsgBox("Étudiant modifié avec succès")
                Barrer(BtnOK, BtnAnnuler, GbEtudiants)
                Debarrer(DgEtudiant, BtnNouveau, BtnModifier, BtnEnlever)

            End If

            Action = Operation.Aucune


        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try


    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        Try

            '1 action a aucune
            Action = Operation.Aucune
            BS_Etudiants.CancelEdit()

            '2 Barrer
            Barrer(BtnOK, BtnAnnuler, GbEtudiants)

            '3 Debarrer
            Debarrer(DgEtudiant, BtnModifier, BtnEnlever, BtnNouveau)

            'effacer les anciennes erreurs
            erp1.Clear()

            'Scroll to the first row
            DgEtudiant.Rows(0).Selected = True
            BS_Etudiants.MoveFirst()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        Try
            erp1.Clear()
            '1 initialisé l'action
            Action = Operation.MODIFIER

            '1 barre les controles
            Barrer(BtnNouveau, DgEtudiant, BtnModifier, BtnEnlever)

            '2 debarrer les controles
            Debarrer(GbEtudiants, BtnOK, BtnAnnuler, gbSexe, mskDA, cboNoProg, txtPrenom, txtNom, rdbFeminim, rdbMasculin, txtAdresse, txtVille, cboProv, mskCP, mskTel)

            cboNoProg.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub BtnEnlever_Click(sender As Object, e As EventArgs) Handles BtnEnlever.Click
        'Lorsque la suppresion est permise , TOUTJOURS demander une confirmation
        Try
            If MessageBox.Show("Êtes-vous certain de vouloir enlever cet étudiant ?", "Confirmation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                BS_Etudiants.RemoveCurrent()
                'Ne pas oublier de transferer les changements dans le dataset
                DaEtudiants.Update(DsEtudiants.T_etudiants)
                MsgBox(" Étudiant enlevé avec succès ")
                BtnAnnuler.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
            DsEtudiants.T_etudiants.RejectChanges()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de valider sur un evenement Keypress le champs Adresse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ValiderAdresse(sender As Object, e As KeyPressEventArgs)
        erp1.Clear()
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z0-9 \'\b\p{L}]$") Then
            Exit Sub
        Else
            erp1.SetError(txtAdresse, "Caractère autorisé seulement : Chiffre, Lettre, Espace, Apostrophe")
            e.KeyChar = vbBack
        End If

    End Sub


    Private Sub txtAdresse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        ValiderAdresse(sender, e)
    End Sub

    Private Sub ValiderChar(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress, txtNom.KeyPress, txtPrenom.KeyPress
        erp1.Clear()
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z \'\-\b\p{L}]$") Then
            Exit Sub
        Else
            erp1.SetError(txtAdresse, "Caractère autorisé seulement : Lettre, Espace, Apostrophe")
            e.KeyChar = vbBack
        End If
        'accepte les lettres, espaces, backspaces
        If e.KeyChar = " " Or e.KeyChar = vbBack Then Exit Sub

        If Char.IsLetter(e.KeyChar) = False Then
            e.KeyChar = vbBack

        End If

    End Sub
    Private Sub Valider_NumLettre(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        erp1.Clear()

        'accepte les lettres, espaces, backspaces

        If e.KeyChar = " " Or e.KeyChar = vbBack Then Exit Sub

        If Char.IsLetterOrDigit(e.KeyChar) = False Then
            e.KeyChar = vbBack
        Else
            erp1.SetError(txtAdresse, "Caractère autorisé seulement : Chiffre, Lettre, Espace")
        End If

        'If Char.IsDigit(e.KeyChar) = False Then
        '    e.KeyChar = ""
        'End If

        'If Char.IsLetter(e.KeyChar) = False Then
        '    e.KeyChar = ""
        'End If

    End Sub

    Private Sub DgEtudiant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEtudiant.CellContentClick
        Try
            If DgEtudiant.SelectedRows.Count > 0 Then
                BS_Etudiants.Position = DgEtudiant.CurrentRow.Index
                If DsEtudiants.Tables("T_Etudiants").Rows(DgEtudiant.CurrentRow.Index).Item(4) = "F" Then
                    rdbFeminim.Checked = True
                Else
                    rdbMasculin.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub txtSex_TextChanged(sender As Object, e As EventArgs) Handles txtSex.TextChanged
        If txtSex.Text = "F" Then
            rdbFeminim.Checked = True
            rdbMasculin.Checked = False

        Else
            rdbMasculin.Checked = True
            rdbFeminim.Checked = False

        End If
    End Sub

    Private Sub rdbFeminim_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFeminim.CheckedChanged
        If rdbFeminim.Checked = True Then
            txtSex.Text = "F"
        End If

    End Sub

    Private Sub rdbMasculin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMasculin.CheckedChanged
        If rdbMasculin.Checked = True Then
            txtSex.Text = "M"
        End If
    End Sub

    Private Sub mskCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCP.KeyPress

        Dim asciiBytes As Integer
        asciiBytes = Convert.ToByte(e.KeyChar)
        If (asciiBytes >= 48 And asciiBytes <= 57) Or (asciiBytes >= 65 And asciiBytes <= 90) Or (asciiBytes >= 97 And asciiBytes <= 122) Then
        Else
            e.KeyChar = vbBack
        End If



    End Sub
End Class

