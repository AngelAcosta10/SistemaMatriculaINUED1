Imports System.Data.OleDb

Public Class frmBuscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\PROGRAMACIÓN\SistemaMatriculaINUED\Base de datos\MatriculaINUED(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Registro Encontrado", , "Buscar")

            Dim query = "Select * from maestro where DNImaestro Like '" & txtBuscar.Text & "%"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class