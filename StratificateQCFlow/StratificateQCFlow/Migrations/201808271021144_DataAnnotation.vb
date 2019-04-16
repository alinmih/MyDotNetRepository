Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DataAnnotation
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.ProductionOrders", "Order", Function(c) c.String(nullable := False, maxLength := 12))
            AlterColumn("dbo.ProductionOrders", "Batch", Function(c) c.String(nullable := False, maxLength := 30))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.ProductionOrders", "Batch", Function(c) c.String())
            AlterColumn("dbo.ProductionOrders", "Order", Function(c) c.String())
        End Sub
    End Class
End Namespace
