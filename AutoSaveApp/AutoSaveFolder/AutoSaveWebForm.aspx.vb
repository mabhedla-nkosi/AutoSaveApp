Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient
Imports AutoSaveApp.AutoSaveModel
Imports AutoSaveApp.AutoSaveService
Imports Microsoft.Ajax.Utilities

Public Class AutoSaveWebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        display.Text = ShowNotes().ToString()
        'display.Text = GetAll().ToString()
        Console.WriteLine("Display List:")
        showLabel.Text = DisplayNotes().ToString()


    End Sub

    Private notesId As Integer
    Private typesOfNotes As String
    Private notesText As String
    Private saveOption As String

    'Get and set methods
    <[ReadOnly](True), Display(Name:="Notes Id")>
    Public Property NotesIDProperty() As Integer
        Get
            ' Gets the property value.
            Return notesId
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            notesId = Value
        End Set
    End Property

    <Display(Name:="Types of Notes")>
    Public Property TypeOfNotesProperty() As String
        Get
            ' Gets the property value.
            Return typesOfNotes
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            typesOfNotes = Value
        End Set
    End Property

    <Display(Name:="Notes")>
    Public Property NotesTextProperty() As String
        Get
            ' Gets the property value.
            Return notesText
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            notesText = Value
        End Set
    End Property

    <Display(Name:="Save Option")>
    Public Property SaveOptionProperty() As String
        Get
            ' Gets the property value.
            Return saveOption
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            saveOption = Value
        End Set
    End Property

    'Constructor
    Public Sub New(notesId As Integer, typesOfNotes As String, notesText As String, saveOption As String)
        Me.notesId = notesId
        Me.typesOfNotes = typesOfNotes
        Me.notesText = notesText
        Me.saveOption = saveOption
    End Sub

    Public Sub New()

    End Sub

    Private Function ShowNotes()
        'MsgBox("In the service method")
        Dim service As New AutoSaveService()
        Dim returnedResults As Object
        returnedResults = service.GetAllNotes()

        Return returnedResults
    End Function

    Private Function DisplayNotes()
        'MsgBox("In the service method")
        Dim service As New AutoSaveService()
        Dim returnedResults As List(Of String)
        returnedResults = service.GetAll()
        Dim nowDisplay As String

        Console.WriteLine("The list:")

        For Each i As String In returnedResults
            'Console.WriteLine(i)
            nowDisplay += i
        Next

        Return nowDisplay

    End Function

End Class