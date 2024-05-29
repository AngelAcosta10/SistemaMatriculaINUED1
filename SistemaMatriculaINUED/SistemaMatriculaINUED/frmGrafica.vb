Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\PROGRAMACIÓN\SistemaMatriculaINUED\Base de datos\MatriculaINUED(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)

            Chart1.Series("Series")

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class