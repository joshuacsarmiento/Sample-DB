Imports MySql.Data.MySqlClient
Imports System.Data

Imports System.Windows

Public Class Form1
    Public Shared tableDATA As New DataTable
    Public Shared tabledataadapter As New MySqlDataAdapter("show databases", con)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dblistreload()


    End Sub



    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public total As Integer
    Dim publictable As New DataTable

    Public Shared con As MySql.Data.MySqlClient.MySqlConnection = sqlconn()


    Public Shared Function sqlconn() As MySql.Data.MySqlClient.MySqlConnection
        Return New MySql.Data.MySqlClient.MySqlConnection("server=sql6.freemysqlhosting.net;user id=sql6400789;password=BPgF2Xs6i9;database=")
    End Function

    Public Sub dblistreload()

        reloadcombobox(databaseselect, "SHOW DATABASES", "Database")
    End Sub


    Public Sub tablelistreload()
        If databaseselect.Text <> "System.Data.DataRowView" Then
            reloadcombobox(Tableselect, "SHOW TABLES FROM " & databaseselect.Text, "Tables_in_" & databaseselect.Text)
        End If
    End Sub

    Public Sub tabledatareload(ByRef datagrid, ByVal sqlquery)





        tableDATA = New DataTable
        tabledataadapter = New MySqlDataAdapter(sqlquery, con)
        '  Dim tableDATA As New DataTable
        '  Dim tabledataadapter As New MySqlDataAdapter(sqlquery, con)
        Try
            tabledataadapter.Fill(tableDATA)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        datagrid.DataSource = tableDATA


    End Sub
    Public Sub deletetabledatarow()



        Dim dataGridViewSelectedRowCollection = tabledatagrid.SelectedRows


        For Each row As DataGridViewRow In dataGridViewSelectedRowCollection
            Try
                tabledatagrid.Rows.Remove(row)
            Catch ex As Exception

            End Try

        Next


    End Sub

    Public Sub updatedtabledatachanges()
        Dim cmdBuilder As MySqlCommandBuilder
        Dim changes As DataTable
        Try
            cmdBuilder = New MySqlCommandBuilder(tabledataadapter)
            changes = tableDATA.GetChanges()
            If changes IsNot Nothing Then
                tabledataadapter.Fill(changes)
                tabledataadapter.Update(changes)




                tabledataadapter.DeleteCommand = cmdBuilder.GetDeleteCommand(True)
                tabledataadapter.UpdateCommand = cmdBuilder.GetUpdateCommand(True)
                tabledataadapter.InsertCommand = cmdBuilder.GetInsertCommand(True)
                changes.AcceptChanges()
                tableDATA.AcceptChanges()
                tabledataadapter.AcceptChangesDuringUpdate = True


            End If
            MessageBox.Show("Updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        tabledatareload(tabledatagrid, "Use " & databaseselect.Text & "; Select * From " & Tableselect.Text)

    End Sub

    Public Shared Sub UpdateDataTable(ByRef datatable,
    ByRef myDataAdapter)
        Dim xDataTable As DataTable
        xDataTable = datatable.GetChanges()


        If xDataTable.HasErrors Then


        End If


        myDataAdapter.Update(xDataTable)
    End Sub
    Public Sub reloadcombobox(ByRef target, ByVal sqlquery, ByVal dispmember)

        Dim publictable As New DataTable
        Try

            'bind the connection and query
            With cmd
                .Connection = con
                .CommandText = sqlquery
            End With

            da.SelectCommand = cmd
            da.Fill(publictable)

            With target
                .DataSource = publictable
                .DisplayMember = dispmember
                .ValueMember = dispmember
            End With

            da.Dispose()

        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            '       MessageBox.Show(sqlquery)

        End Try
        con.Clone()

    End Sub

    Private Sub databaseselect_TextChanged(sender As Object, e As EventArgs) Handles databaseselect.TextChanged
        tabledatagrid.Columns.Clear()

        tablelistreload()
    End Sub



    Private Sub Tableselect_TextChanged(sender As Object, e As EventArgs) Handles Tableselect.TextChanged
        If Tableselect.Text <> "System.Data.DataRowView" And databaseselect.Text <> "System.Data.DataRowView" Then

            tabledatareload(tabledatagrid, "Use " & databaseselect.Text & "; Select * From " & Tableselect.Text)
        ElseIf Tableselect.Text <> "System.Data.DataRowView" Then
            'tabledatagrid.Rows.Clear()

        End If

    End Sub

    Private Sub newdb_Click(sender As Object, e As EventArgs) Handles newdb.Click
        Dim objForm As New NewDBDialog
        objForm.ShowDialog()
        objForm.Dispose()

    End Sub





    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles NewTableTab.Click

    End Sub

    Private Sub Addfield_Click(sender As Object, e As EventArgs) Handles Addfield.Click
        Dim row As String() = New String() {"", "", ""}
        tabledesigngrid.Rows.Add(row)

    End Sub

    Private Sub newtable_Click_1(sender As Object, e As EventArgs) Handles newtable.Click
        If NewTableName.Text = "" Then
            Exit Sub
        End If
        Dim field As String
        Dim type As String
        Dim nlenght As Integer
        Dim nNull As String
        Dim nIndex As String
        Dim nAI As String
        Dim alltxt As String
        Dim result As Integer

        Dim tblAndDB As String = databaseselect.Text & "." & NewTableName.Text
        Dim TBLCREATE As String = "CREATE TABLE " & tblAndDB & " ( "

        For i As Integer = 0 To Me.tabledesigngrid.Rows.Count - 2

            ' field.Add(Me.dtgStructNewTbl.Rows(i).Cells("n_field").Value)
            field = Me.tabledesigngrid.Rows(i).Cells("n_field").Value
            type = Me.tabledesigngrid.Rows(i).Cells("n_type").Value
            nlenght = Me.tabledesigngrid.Rows(i).Cells("n_lenght").Value
            nNull = Me.tabledesigngrid.Rows(i).Cells("n_null").Value
            nIndex = Me.tabledesigngrid.Rows(i).Cells("n_index").Value
            nAI = Me.tabledesigngrid.Rows(i).Cells("n_ai").Value

            alltxt += field & " " & type & "(" & nlenght & ")" & " " & nNull & " " & nIndex & " " & nAI & "," & vbCrLf

        Next
        Try

            alltxt = alltxt.Substring(0, alltxt.Length - Environment.NewLine.Length)
            Dim cleanText As String

            cleanText = alltxt.Remove(alltxt.Length - 1)
            Dim finalText As String

            finalText = TBLCREATE & cleanText & ")ENGINE = MYISAM ;"

            con.Open()
            With cmd
                .Connection = con
                .CommandText = finalText
                result = cmd.ExecuteNonQuery
                If result > 0 Then
                    MessageBox.Show("No Table has been created!")
                Else
                    MessageBox.Show(NewTableName.Text & " has been created Successfully!")
                    With Me
                        .NewTableName.ReadOnly = True


                        tablelistreload()
                        Tableselect.Text = NewTableName.Text
                        NewTableName.Text = ""
                        ' .tabledesigngrid.SendToBack()
                        '.tabledesigngrid.Columns.Clear()
                    End With


                End If
            End With


            Form1_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub UpdateTableButton_Click(sender As Object, e As EventArgs) Handles UpdateTableButton.Click
        updatedtabledatachanges()
    End Sub

    Private Sub deletedatarow_Click(sender As Object, e As EventArgs) Handles deletedatarow.Click
        Dim deletediag As DialogResult = MessageBox.Show("Delete Selected Row?",
                                                      "Delete",
                                                      MessageBoxButtons.YesNo)
        If deletediag = DialogResult.Yes Then
            deletetabledatarow()
        End If

    End Sub
End Class



