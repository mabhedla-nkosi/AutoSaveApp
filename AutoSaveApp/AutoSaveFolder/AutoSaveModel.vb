Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class AutoSaveModel
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
End Class
