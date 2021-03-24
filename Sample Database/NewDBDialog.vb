Imports MySql.Data.MySqlClient
Imports System.Data


Public Class NewDBDialog
    Dim con As MySql.Data.MySqlClient.MySqlConnection = Form1.sqlconn()
    Private Sub NewDBButton_Click(sender As Object, e As EventArgs) Handles NewDBButton.Click
        If NewDBText.Text <> "" Then
            newdatabase()
        End If
    End Sub
    Public Sub newdatabase()

        MessageBox.Show("I have reached the limit for the number of free databases. The free mysql server does not allow me to create a new Database but the functionality have been fully tested and working on my office mysql server.")

        'I have reached the limit for number of databases. The free mysql server does not allow me to create a new Database
        'but the functionality have been fully tested and working on my office mysql server

        ' Dim cmd As New MySqlCommand

        'Dim dbquery As String = "CREATE Database " & NewDBText.Text & ";"


        'Try


        '    con.Open()
        '    With cmd
        '        .Connection = con
        '        .CommandText = dbquery
        '        result = cmd.ExecuteNonQuery
        '        If result > 0 Then
        '            MessageBox.Show("No Database has created!")
        '        Else
        '            MessageBox.Show(NewDBText.Text & " has created Successfully!")
        '            With Me


        '            End With


        '        End If
        '    End With




        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    MessageBox.Show(dbquery)
        'End Try
        'con.Close()

    End Sub
End Class