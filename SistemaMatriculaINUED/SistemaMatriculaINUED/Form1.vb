Imports System.Data.OleDb
Public Class Form1
    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\PROGRAMACIÓN\SistemaMatriculaINUED\Base de datos\MatriculaINUED(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscar.Show()
    End Sub
End Class
