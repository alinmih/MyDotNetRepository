Imports System.ComponentModel.DataAnnotations

Namespace ViewModels
    Public Class OrderDateGroup

        <DataType(DataType.Date)>
        Public Property OrderDate As DateTime
        Public Property OrderCount As Integer

    End Class
End Namespace