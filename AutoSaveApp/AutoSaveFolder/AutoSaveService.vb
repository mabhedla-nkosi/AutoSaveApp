Imports System.Data.SqlClient

Public Class AutoSaveService
    Public Function GetAllNotes() 'As IEnumerable(Of AutoSaveModel)
        'declarations
        Dim connection As SqlConnection = New SqlConnection
        Dim results As Object
        Dim tableContent As New DataTable()

        'assignment
        Dim sqlStatement = "SELECT * FROM dbo.tblNotes"
        connection.ConnectionString = "Data Source=DESKTOP-I7PRM8M\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=dbNotes;"

        Try
            connection.Open()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(sqlStatement, connection)
            Dim dataSet As DataSet = New DataSet()

            adapter.Fill(dataSet)
            adapter.Fill(tableContent)

            If dataSet.Tables.Count <> 0 Then
                'results = dataSet.Tables(0).Rows(0)
                results = dataSet.Tables(0).Rows(0)(1)
                'results = tableContent
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try

        Return results

    End Function

    Public Function GetAll() As List(Of String)
        'declarations
        Dim connection As SqlConnection = New SqlConnection
        Dim results As List(Of String)
        Dim tableContent As New DataTable()
        Dim k As Integer
        Dim listNotes As List(Of String) = New List(Of String)
        Dim collection As String

        'assignment
        Dim sqlStatement = "SELECT * FROM dbo.tblNotes"
        connection.ConnectionString = "Data Source=DESKTOP-I7PRM8M\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=dbNotes;"

        Try
            connection.Open()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(sqlStatement, connection)
            Dim dataSet As DataSet = New DataSet()

            adapter.Fill(dataSet)
            adapter.Fill(tableContent)

            If dataSet.Tables.Count <> 0 Then
                'results = dataSet.Tables(0).Rows(0)

                For i As Integer = 0 To dataSet.Tables(0).Rows.Count - 1
                    For j As Integer = 0 To dataSet.Tables(0).Columns.Count - 1
                        collection += dataSet.Tables(0).Rows(i)(j)

                    Next
                    listNotes.Add(collection)
                Next

                results = listNotes
                'results = tableContent
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try

        Return results

    End Function

    Public Function GetCount() 'As IEnumerable(Of AutoSaveModel)
        'declarations
        Dim connection As SqlConnection = New SqlConnection
        Dim results As Object
        Dim tableContent As New DataTable()

        'assignment
        Dim sqlStatement = "Select COUNT(NotesID) from tblNotes"
        connection.ConnectionString = "Data Source=DESKTOP-I7PRM8M\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=dbNotes;"

        Try
            connection.Open()

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(sqlStatement, connection)
            Dim dataSet As DataSet = New DataSet()

            adapter.Fill(dataSet)
            adapter.Fill(tableContent)
            If dataSet.Tables.Count <> 0 Then
                'results = dataSet.Tables(0).Rows(0)
                results = dataSet.Tables(0).Rows(0)(0)
                'results = tableContent
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
        End Try

        Return results

    End Function

    Public Function GetNotes(notesId As Integer) As IEnumerable(Of AutoSaveModel)
        'declarations
        Dim connection As SqlConnection = New SqlConnection
        Dim results As Object
        Dim tableContent As New DataTable

        'assignment
        Dim sqlStatement = "SELECT * FROM tblNotes WHERE notesId=" + notesId
        connection.ConnectionString = "Data Source=DESKTOP-I7PRM8M\SQLEXPRESS; _
         Initial Catalog=dbNotes;Integrated Security=True"


        Try
            connection.Open()
            Dim adp As SqlDataAdapter = New SqlDataAdapter(sqlStatement, connection)
            Dim dataSet As DataSet = New DataSet()
            If dataSet.Tables.Count <> 0 Then
                adp.Fill(dataSet)
                adp.Fill(tableContent)
            End If

            'results = dataSet.Tables(0).Rows(0)
            'results = dataSet.Tables(0).Rows
            results = tableContent.Rows(0)

        Catch ex As Exception

        End Try

        Return results

    End Function

    Public Sub UpdateNotes(ByVal notesId As Integer)

    End Sub
End Class
