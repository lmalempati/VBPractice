Imports System.Web.Http

Public Class HomeController
    Inherits ApiController
    <HttpGet, HttpPost, HttpOptions> Function Index() As ActionResult
        Return Nothing
    End Function
End Class
