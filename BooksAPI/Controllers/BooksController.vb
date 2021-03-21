Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Description
Imports BooksAPI.BooksAPI.Models
Imports BooksAPI.Data

Namespace Controllers
    Public Class BooksController
        Inherits System.Web.Http.ApiController

        Private db As New BooksAPIContext

        ' GET: api/Books
        Function GetBooks() As IQueryable(Of Book)
            Return db.Books
        End Function

        ' GET: api/Books/5
        <ResponseType(GetType(Book))>
        Function GetBook(ByVal id As Integer) As IHttpActionResult
            Dim book As Book = db.Books.Find(id)
            If IsNothing(book) Then
                Return NotFound()
            End If

            Return Ok(book)
        End Function

        ' PUT: api/Books/5
        <ResponseType(GetType(Void))>
        Function PutBook(ByVal id As Integer, ByVal book As Book) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = book.BookId Then
                Return BadRequest()
            End If

            db.Entry(book).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (BookExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/Books
        <ResponseType(GetType(Book))>
        Function PostBook(ByVal book As Book) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Books.Add(book)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = book.BookId}, book)
        End Function

        ' DELETE: api/Books/5
        <ResponseType(GetType(Book))>
        Function DeleteBook(ByVal id As Integer) As IHttpActionResult
            Dim book As Book = db.Books.Find(id)
            If IsNothing(book) Then
                Return NotFound()
            End If

            db.Books.Remove(book)
            db.SaveChanges()

            Return Ok(book)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function BookExists(ByVal id As Integer) As Boolean
            Return db.Books.Count(Function(e) e.BookId = id) > 0
        End Function
    End Class
End Namespace