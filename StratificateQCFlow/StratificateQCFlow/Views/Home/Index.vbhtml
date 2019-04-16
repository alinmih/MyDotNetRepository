@ModelType IEnumerable(Of StratificateQCFlow.ViewModels.OrderDateGroup)
@Code
    'Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Production Reports"
End Code


<h2>Number of orders controlled</h2>
<table class="table">
    <tr>
        <th>Date</th>
        <th>Number of orders</th>
    </tr>
    @For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderDate)
        </td>
    <td>
        @item.OrderCount
    </td>
    </tr>
    Next
</table>

