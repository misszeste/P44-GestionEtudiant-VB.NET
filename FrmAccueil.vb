' Programme Accueil MDI =) qui établie la connection et qui permet d'acceder au FORM Etudiant et FORM Programme et de Quitter
' Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le:22/11/10
Imports System.Data.SqlClient ' SQL server
Imports System.Text.RegularExpressions ' pour vos expressions régulières
Imports System.Diagnostics.Eventing.Reader

'form accueuil du programme
Public Class FormAccueil
    '' variable Globale form 1
    'Dim CN As SqlConnection
    'Dim COM As SqlCommand
    'Dim DR As SqlDataReader


    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)

        End Try
    End Sub


    Private Sub ProgrammeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammeToolStripMenuItem.Click
        Try
            For Each form In Me.MdiChildren
                If TypeOf (form) Is FrmProgramme Then
                    form.BringToFront()
                    Exit Sub
                End If
            Next

            Dim programmes As New FrmProgramme With {
                .MdiParent = Me
            }

            programmes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub ÉtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉtudiantsToolStripMenuItem.Click
        Try
            For Each form In Me.MdiChildren
                If TypeOf (form) Is FrmEtudiants Then
                    form.BringToFront()
                    Exit Sub
                End If
            Next

            Dim etudiants As New FrmEtudiants With {
                .MdiParent = Me
            }
            etudiants.Show()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try


    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Try

            Dim reponse As Integer
            reponse = MsgBox("Êtes-vous certain de vouloir quitter?", vbYesNo + vbQuestion)

            If reponse = 6 Then
                Application.Exit()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub ListeDesProgrammesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesProgrammesToolStripMenuItem.Click
        Try
            For Each form In Me.MdiChildren
                If TypeOf (form) Is frmListeProg Then
                    form.BringToFront()
                    Exit Sub
                End If
            Next

            Dim listProg As New frmListeProg With {
                .MdiParent = Me
            }
            listProg.Show()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub ListeDesÉtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesÉtudiantsToolStripMenuItem.Click
        Try
            For Each form In Me.MdiChildren
                If TypeOf (form) Is frmListeEtu Then
                    form.BringToFront()
                    Exit Sub
                End If
            Next

            Dim listEtud As New frmListeEtu With {
                .MdiParent = Me
            }
            listEtud.Show()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub ListeDesÉtudiantsParProgrammesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesÉtudiantsParProgrammesToolStripMenuItem.Click
        Try
            For Each form In Me.MdiChildren
                If TypeOf (form) Is frmListeEtuProg Then
                    form.BringToFront()
                    Exit Sub
                End If
            Next

            Dim listEtudProg As New frmListeEtuProg With {
                .MdiParent = Me
            }
            listEtudProg.Show()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub


End Class
