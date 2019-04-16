Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity
Namespace Models
    Public Class ProductionOrder
        Private _ReleaseDate As Date = DateTime.Now

        Public Property ID As Integer

        <Display(Name:="Order ID")>
        <Required>
        <StringLength(12, MinimumLength:=9)>
        Public Property Order As String

        <Display(Name:="Release Date")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:dd-MM-yyyy}", ApplyFormatInEditMode:=True)>
        Public Property ReleaseDate As DateTime
            Get
                Return _ReleaseDate
            End Get
            Set
                _ReleaseDate = Value
            End Set
        End Property

        <Display(Name:="Quantity OK [KGs]")>
        <Required>
        Public Property QuantityOK As Integer

        <Display(Name:="Quantity NOK [UNITs]")>
        <Required>
        Public Property QuantityNOK As Integer

        <Required>
        <StringLength(30, MinimumLength:=4)>
        Public Property Batch As String
        Public Property User As Integer
    End Class

    Public Class ProductionOrderDbContext
        Inherits DbContext

        Public Property Orders As DbSet(Of ProductionOrder)
    End Class

End Namespace

