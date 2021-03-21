Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports BooksAPI.BooksAPI.Models

Namespace Migrations

    Friend NotInheritable Class Configuration 
        Inherits DbMigrationsConfiguration(Of Data.BooksAPIContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub
        Protected Overrides Sub Seed(context As Data.BooksAPIContext)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data. E.g.
            '
            '    context.People.AddOrUpdate(
            '       Function(c) c.FullName,
            '       New Customer() With {.FullName = "Andrew Peters"},
            '       New Customer() With {.FullName = "Brice Lambson"},
            '       New Customer() With {.FullName = "Rowan Miller"})
            '        context.Books.AddOrUpdate(Function(x) x.Id, New Book() With {
            '    .BookId = 1,
            '    .Title = "Jane Austen"
            '}, New Author() With {
            '    .AuthorID = 2,
            '    .Name = "Charles Dickens"
            '}, New Author() With {
            '    .AuthorID = 3,
            '    .Name = "Miguel de Cervantes"
            '})
            context.Books.AddOrUpdate(Function(x) x.Id, New Book() With {
        .BookId = 1,
        .Title = "Pride and Prejudice"
    }, New Book() With {
         .BookId = 2,
        .Title = "Northanger Abbey",
        .Price = 12.95D
    }, New Book() With {
        .BookId = 3,
        .Title = "David Copperfield",
        .Price = 15
    }, New Book() With {
        .BookId = 4,
        .Title = "Don Quixote",
        .Price = 8.95D
    })
        End Sub

    End Class

End Namespace
