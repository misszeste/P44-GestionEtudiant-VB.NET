'Form qui permet l'affichage de rapport Liste Etudiants
'Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le:22/11/10
Imports System.Data.SqlClient ' SQL server
Imports System.Net.Sockets
Imports System.Text.RegularExpressions ' pour vos expressions régulières
Public Class frmListeEtu
    Private Sub frmListeEtu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'remplissage du DS (dataset)
            DaRapEtudiant.Fill(DsRapEtudiant1.T_etudiants)
            Dim rap As New RapportEtudiants 'meme nom que le rapport crystal rpt*
            rap.SetDataSource(DsRapEtudiant1)
            crvEtudiant.ReportSource = rap
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class