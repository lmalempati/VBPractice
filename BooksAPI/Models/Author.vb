Imports System.ComponentModel.DataAnnotations

Namespace BooksAPI.Models
    Public Class Author
        Private _authorid As Integer
        Public Property AuthorID() As Integer
            Get
                Return _authorid
            End Get
            Set(ByVal value As Integer)
                _authorid = value
            End Set
        End Property

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

    End Class
End Namespace

