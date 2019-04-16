Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Batch
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.ProductionOrders", "Batch", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.ProductionOrders", "Batch")
        End Sub
    End Class
End Namespace
