Imports System.Web.Mvc
Imports StratificateQCFlow.Models
Imports StratificateQCFlow.ViewModels

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Private db As ProductionOrderDbContext = New ProductionOrderDbContext()

        ' GET: Home
        Function Index() As ActionResult
            Dim data As IQueryable(Of OrderDateGroup) = db.Orders.GroupBy(Function(s) s.ReleaseDate).Select(Function(g) New OrderDateGroup With {.OrderDate = g.Key, .OrderCount = g.Count()})

            Return View(data.ToList)
        End Function




    End Class
End Namespace