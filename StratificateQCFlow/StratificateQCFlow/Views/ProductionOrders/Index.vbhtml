@ModelType PagedList.IPagedList(Of StratificateQCFlow.Models.ProductionOrder)
@Imports PagedList.Mvc
<link href="~/Content/PagedList.css" rel="stylesheet" type="text/css" />
@Code
    ViewBag.Title = "Orders"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
    @Using Html.BeginForm("Index", "ProductionOrders", FormMethod.Get)
        @<p>
            Date: @Html.DropDownList("orderDate", "All")
            Order: @Html.TextBox("searchOrder", TryCast(ViewBag.CurrentFilter, String))
            Batch: @Html.TextBox("searchBatch", TryCast(ViewBag.CurrentFilter, String))
    <br />
    @*Ok Parts: @Html.TextBox("searchOk", value:=20)*@
    @*NOk Parts: @Html.TextBox("searchNOk") *@
    <input type="submit" value="Filter" />
</p>
    End Using

    </p>
    <Table Class="table">
        <tr>
            <th>
                @Html.ActionLink("Order", "Index", New With {.sortOrder = ViewBag.OrderSortParm})
            </th>
            <th>
                @Html.ActionLink("Release Date", "Index", New With {.sortOrder = ViewBag.DateSortParm})
            </th>
            <th>
                Quantity OK
            </th>
            <th>
                Quantity NOK
            </th>
            <th>
                @Html.ActionLink("Batch", "Index", New With {.sortOrder = ViewBag.BatchSortParm})
            </th>
            <th>
                @Html.ActionLink("User", "Index", New With {.sortOrder = ViewBag.UserSortParm})
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Order)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ReleaseDate)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.QuantityOK)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.QuantityNOK)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Batch)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.User)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
                </td>
            </tr>
        Next

    </Table>
    <br />
    Page @IIf(Model.PageCount < Model.PageNumber, 0, Model.PageNumber) of @Model.PageCount
    @Html.PagedListPager(Model, Function(page) Url.Action("Index", _
          New With {page, .sortOrder = ViewBag.CurrentSort, .currentFilter = ViewBag.CurrentFilter}))