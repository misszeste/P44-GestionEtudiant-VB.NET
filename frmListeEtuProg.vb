'Form qui permet l'affichage de rapport Liste Etudiants par programmes
' Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le:22/11/10
Imports System.Data.SqlClient ' SQL server
Imports System.Text.RegularExpressions ' pour vos expressions régulières
Public Class frmListeEtuProg
    Private Sub frmListeEtuProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DaRapEtudParProg.Fill(DsRapEtudParProg1.T_etudiants)
            Dim r As New RapportEtudParProg()
            r.SetDataSource(DsRapEtudParProg1)
            crvEtudParProg.ReportSource = r


        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class