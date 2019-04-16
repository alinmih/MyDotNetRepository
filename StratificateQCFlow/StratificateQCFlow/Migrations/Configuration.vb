Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports StratificateQCFlow.Models

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Models.ProductionOrderDbContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As Models.ProductionOrderDbContext)
            context.Orders.AddOrUpdate(Function(i) i.Order,
New ProductionOrder() With {
    .Order = "123456789123",
    .ReleaseDate = DateTime.Now,
    .QuantityOK = 100,
    .QuantityNOK = 10,
    .Batch = 1334,
    .User = 1234
}, New ProductionOrder() With {
    .Order = "123456789456",
    .ReleaseDate = DateTime.Now,
    .QuantityOK = 12353,
    .QuantityNOK = 325,
    .Batch = 8987,
    .User = 1234
    }, New ProductionOrder() With {
    .Order = "123456789789",
    .ReleaseDate = DateTime.Now,
    .QuantityOK = 5584,
    .QuantityNOK = 365,
    .Batch = 7899,
    .User = 4567
    }, New ProductionOrder() With {
    .Order = "qwertyuiopas",
    .ReleaseDate = DateTime.Now,
    .QuantityOK = 66582,
    .QuantityNOK = 1,
    .Batch = 8799,
    .User = 8895
})
        End Sub

    End Class

End Namespace
