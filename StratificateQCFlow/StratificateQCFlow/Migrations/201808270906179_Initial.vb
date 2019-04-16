Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ProductionOrders",
                Function(c) New With
                    {
                        .ID = c.Int(nullable := False, identity := True),
                        .Order = c.String(),
                        .ReleaseDate = c.DateTime(nullable := False),
                        .QuantityOK = c.Int(nullable := False),
                        .QuantityNOK = c.Int(nullable := False),
                        .User = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.ID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.ProductionOrders")
        End Sub
    End Class
End Namespace
