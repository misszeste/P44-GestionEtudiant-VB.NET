'formulaire gestion programme
' Programme childMDI FORM  Permet la gestion CRUD et l'affichage dans une DATA GRID VIEW des étudiants et des PROGS
' Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le: 22/11/10

Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions ' pour vos expressions régulières

Public Enum Operation
    Aucune = 0
    Ajouter = 1
    Modifier = 2
    Enlever = 3
End Enum


Public Class FrmProgramme

    'Variable globales pour l'ensemble du form
    Dim Ligne_Courante As Integer
    Dim Action As Operation = Operation.Aucune

    Private Sub FrmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Dois-je ouvrir la connection a la BD? NON , Le .fill le fait pour nous..
            'on doit respecter l'ordre de remplissage du DataSet

            '1) remplissage du DataSet
            DaProg.Fill(DsProg.T_programme)

            'Vérifier si vous avez des Programmes
            If DsProg.T_programme.Rows.Count > 0 Then
                BtnModifier.Enabled = True
                Ligne_Courante = 0
                Remplir_Etudiant()
            Else
                Ligne_Courante = -1
            End If


        Catch ex As Exception
            MsgBox(ex.Message, "Problème au chargement du formulaire, veuillez contacter votre administrateur ", vbExclamation)
            Me.Close()

        End Try
    End Sub



    Private Sub Remplir_Etudiant()
        Try
            'Vider les etudiants / Si binder aurait utilisé addnew
            DsProg.T_etudiants.Clear()

            'Retrouver les étudiants de ce prog
            DaEtud.SelectCommand.Parameters("@NoProg").Value = MskNo.Text
            DaEtud.Fill(DsProg.T_etudiants)

            BtnEnlever.Enabled = (DsProg.T_etudiants.Rows.Count = 0)
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)

        End Try

    End Sub

    Private Sub BtnNouveau_Click(sender As Object, e As EventArgs) Handles BtnNouveau.Click

        Try
            '1) Barrer des controles  
            Barrer(BtnNouveau, BtnModifier, BtnEnlever, DgProg) 'DgEtudiants

            '2) Débarrer les controles
            Debarrer(GbProg, BtnAnnuler, BtnOk, MskNo, TxtBoxNom, numUnites, numHeures)

            '3) indiquer  l'action de donner le focus au 1 champs a remplir
            Action = Operation.Ajouter
            MskNo.Focus()

            '4 vider l'écran
            'ici nous somme avec des controle liée (Bindingview)
            numHeures.Text = numHeures.Minimum
            numUnites.Text = numUnites.Minimum
            'on peut vider l'écran avec la methode Methode ADDNEW
            BS_Prog.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try


    End Sub

    Private Sub Debarrer(ParamArray ctrl() As Control)

        For Each c As Control In ctrl
            c.Enabled = True
        Next

    End Sub

    Private Sub Barrer(ParamArray ctrl() As Control)

        For Each c As Control In ctrl
            c.Enabled = False
        Next

    End Sub



    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try

            '1) valider le formulaire
            ' Si des erreurs on quitte.. sinon on fait l'action
            If Valider_Formulaire() = False Then
                Exit Sub
            End If

            'faut arreter action
            BS_Prog.EndEdit()
            DaProg.Update(DsProg.T_programme)

            Barrer(BtnOk, BtnAnnuler, GbProg)
            Debarrer(DgProg, DgEtudiants, BtnNouveau, BtnModifier, BtnEnlever)

            '2 Verifier l'action
            If Action = Operation.Ajouter Then
                MsgBox("Programme ajouté avec succès", vbExclamation)
                BS_Prog.MoveLast()


            Else
                MsgBox("Programme modifié avec succès", vbExclamation)
                'si il y a des etudiants dans le prog modifier ,ne peux etre enlever
                BtnEnlever.Enabled = (DsProg.T_etudiants.Rows.Count = 0)

            End If

            Action = Operation.Aucune


        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub



    Private Function Valider_Formulaire() As Boolean
        'efffacer nos anciens msg d'erreur
        erp1.Clear()
        Dim OK As Boolean = True

        'Verifier le formulaire et son contenu
        If MskNo.MaskFull = False Then
            OK = False
            erp1.SetError(MskNo, "  Numéro du programme est obligatoire")
        End If

        If TxtBoxNom.Text.Trim() = "" Then
            OK = False
            erp1.SetError(TxtBoxNom, "  Nom du programme est obligatoire")
        End If

        If numUnites.Value = False Then
            OK = False
            erp1.SetError(numUnites, " Nombre d'unité est obligatoire")
        End If

        If numHeures.Value = False Then
            OK = False
            erp1.SetError(numHeures, "Nombre d'heure est obligatoire")
        End If

        Return OK
    End Function

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        Try
            '1 action a aucune
            Action = Operation.Aucune
            BS_Prog.CancelEdit()

            '2 Barrer
            Barrer(BtnOk, BtnAnnuler, GbProg)
            '3 Debarrer
            Debarrer(DgProg, BtnModifier, BtnNouveau)
            BS_Prog.MoveFirst()

            'effacer les anciennes erreurs
            erp1.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try



    End Sub


    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click

        Try
            erp1.Clear()
            '1 initialisé l'aciton
            Action = Operation.Modifier

            '1 barre les controles
            Barrer(BtnNouveau, DgEtudiants, DgProg, BtnModifier, BtnEnlever)

            '2 debarrer les controles
            Debarrer(GbProg, BtnOk, BtnAnnuler, MskNo, TxtBoxNom, numHeures, numUnites)

            MskNo.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub BtnEnlever_Click(sender As Object, e As EventArgs) Handles BtnEnlever.Click
        'Lorsque la suppresion est permise , TOUTJOURS demander une confirmation
        Try
            If MessageBox.Show("Êtes-vous certain de vouloir enlever ce client?", "Confirmation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                BS_Prog.RemoveCurrent()
                'Ne pas oublier de transferer les changements dans le dataset
                DaProg.Update(DsProg.T_programme)
                MsgBox(" Programme enlevé avec succès ", vbExclamation)
                BS_Prog.MoveFirst()
                BtnAnnuler.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
            DsProg.T_programme.RejectChanges()
        End Try
    End Sub





    Private Sub ValiderChar(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNom.KeyPress
        erp1.Clear()

        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z \'\b\p{L}]$") Then
            Exit Sub
        Else
            erp1.SetError(TxtBoxNom, "Caractère autorisé seulement : Lettre, Espace, Appostrophe ")
            e.KeyChar = ""
        End If

        'On accepte les lettre, espace, backspace
        If e.KeyChar = " " Or e.KeyChar = vbBack Then Exit Sub

        If Char.IsLetter(e.KeyChar) = False Then
            e.KeyChar = vbBack

        End If

    End Sub
    Private Sub ValiderMskno(sender As Object, e As KeyPressEventArgs) Handles MskNo.KeyPress
        erp1.Clear()

        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z0-9]") Then
            Exit Sub
        Else
            erp1.SetError(TxtBoxNom, "Caractère autorisé seulement : Lettre et chiffre . ")
            e.KeyChar = vbBack
        End If
    End Sub

    Private Sub DgProg_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DgProg.CellClick
        Try
            If DgProg.SelectedRows.Count > 0 Then
                Ligne_Courante = DgProg.CurrentRow.Index
                Remplir_Etudiant()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class