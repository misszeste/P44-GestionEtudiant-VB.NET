'Form qui permet l'affichage du rapport Liste de programme
'Fait par : Jessika Soucy
' Le : 22/10/17
' Révisé le:22/11/10
Imports System.Data.SqlClient ' SQL server
Imports System.Net.Sockets
Imports System.Text.RegularExpressions ' pour vos expressions régulières
Public Class frmListeProg
    Private Sub frmListeProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'remplissage du DS (dataset)
            daListeProg.Fill(DsListeProg1.T_programme)
            Dim rapprog As New RapportProgrammes 'meme nom que le rapport crystal rpt*
            rapprog.SetDataSource(DsListeProg1)
            crvListeProg.ReportSource = rapprog
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub crvListeProg_Load(sender As Object, e As EventArgs) Handles crvListeProg.Load

    End Sub
End Class