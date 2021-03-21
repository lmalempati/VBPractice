Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace BooksAPI.Models
    Public Class Book
        Private _bookid As Integer
        Public Property BookId() As Integer
            Get
                Return _bookid
            End Get
            Set(ByVal value As Integer)
                _bookid = value
            End Set
        End Property

        Private _title As String
        Public Property Title() As String
            Get
                Return _title
            End Get
            Set(ByVal value As String)
                _title = value
            End Set
        End Property

        Private _price As Decimal
        Public Property Price() As Decimal
            Get
                Return _price
            End Get
            Set(ByVal value As Decimal)
                _price = value
            End Set
        End Property
    End Class
End Namespace
